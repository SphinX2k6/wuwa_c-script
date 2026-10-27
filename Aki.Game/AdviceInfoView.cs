using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016D4 RID: 5844
[NullableContext(1)]
[Nullable(0)]
public class AdviceInfoView : UiViewBase
{
	// Token: 0x0600A72B RID: 42795 RVA: 0x00257AA8 File Offset: 0x00255CA8
	public AdviceInfoView(UiViewInfo uiViewInfo) : base(uiViewInfo)
	{
	}

	// Token: 0x0600A72C RID: 42796 RVA: 0x00257AB4 File Offset: 0x00255CB4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(7, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnClickDisLikeBtn)),
			new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnClickLikeBtn))
		};
	}

	// Token: 0x0600A72D RID: 42797 RVA: 0x00257BD0 File Offset: 0x00255DD0
	protected override void OnStart()
	{
		this.TimerId = null;
		UUIExtendToggle extendToggle = base.GetExtendToggle(6);
		if (extendToggle != null)
		{
			extendToggle.SetToggleGroup(null);
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(7);
		if (extendToggle2 != null)
		{
			extendToggle2.CanExecuteChange.Unbind();
			extendToggle2.CanExecuteChange.Bind(new Func<bool>(this.CanClickLikeToggle));
			extendToggle2.SetToggleGroup(null);
		}
		UUIText text = base.GetText(8);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		this.ListCurrentEntityBattleTag();
	}

	// Token: 0x0600A72E RID: 42798 RVA: 0x00257C44 File Offset: 0x00255E44
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAdviceEntityNotify, new Action(this.OnReceiveEntityRefresh));
		EventSystem.Instance.Add(EEventName.OnAdviceVoteNotify, new Action(this.OnReceiveEntityRefresh));
		EventSystem.Instance.Add(EEventName.CreateViewInstance, new Action<UiViewBase>(this.OnCreateViewInstance));
		EventSystem.Instance.Add(EEventName.UiSceneStartLoad, new Action(this.OnShowUiScene));
		EventSystem.Instance.Add(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleCompleted));
		EventSystem.Instance.Add(EEventName.RefreshAdviceInfoView, new Action(this.RefreshAdviceInfoView));
	}

	// Token: 0x0600A72F RID: 42799 RVA: 0x00257CF4 File Offset: 0x00255EF4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleCompleted));
		EventSystem.Instance.Remove(EEventName.OnAdviceEntityNotify, new Action(this.OnReceiveEntityRefresh));
		EventSystem.Instance.Remove(EEventName.OnAdviceVoteNotify, new Action(this.OnReceiveEntityRefresh));
		EventSystem.Instance.Remove(EEventName.CreateViewInstance, new Action<UiViewBase>(this.OnCreateViewInstance));
		EventSystem.Instance.Remove(EEventName.UiSceneStartLoad, new Action(this.OnShowUiScene));
		EventSystem.Instance.Remove(EEventName.RefreshAdviceInfoView, new Action(this.RefreshAdviceInfoView));
	}

	// Token: 0x0600A730 RID: 42800 RVA: 0x00257DA2 File Offset: 0x00255FA2
	private void OnChangeRoleCompleted(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		this.ListCurrentEntityBattleTag();
	}

	// Token: 0x0600A731 RID: 42801 RVA: 0x00257DAC File Offset: 0x00255FAC
	private void ListCurrentEntityBattleTag()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null && getCurrentEntity.Valid)
		{
			WorldEntity entity = getCurrentEntity.Entity;
			BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent != null)
			{
				this.IsPlayerEnterFight = baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]);
				this.RemoveEnterFightTask();
				if (this.IsPlayerEnterFight)
				{
					base.CloseMe(null);
					return;
				}
				this.ListenPlayerEnterFight(getCurrentEntity);
			}
		}
	}

	// Token: 0x0600A732 RID: 42802 RVA: 0x00257E20 File Offset: 0x00256020
	private void ListenPlayerEnterFight(EntityHandle playerEntityHandle)
	{
		WorldEntity entity = playerEntityHandle.Entity;
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		if (baseTagComponent != null)
		{
			this.EnterFightTask = baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]), new BaseTagComponent.TTagSwitchedCallback(this.OnPlayerEnterFight), null);
		}
	}

	// Token: 0x0600A733 RID: 42803 RVA: 0x00257E70 File Offset: 0x00256070
	private void RemoveEnterFightTask()
	{
		if (this.EnterFightTask != null)
		{
			((ITagTask)this.EnterFightTask).EndTask();
			this.EnterFightTask = null;
		}
	}

	// Token: 0x0600A734 RID: 42804 RVA: 0x00257E91 File Offset: 0x00256091
	private void OnPlayerEnterFight(int tagId, bool tagExists)
	{
		this.IsPlayerEnterFight = tagExists;
		if (tagExists)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x0600A735 RID: 42805 RVA: 0x00257EA4 File Offset: 0x002560A4
	private bool CanClickLikeToggle()
	{
		return true;
	}

	// Token: 0x0600A736 RID: 42806 RVA: 0x00257EA8 File Offset: 0x002560A8
	private void OnClickDisLikeBtn(EToggleState state)
	{
		int currentEntityId = AdviceModel.Instance.GetCurrentEntityId();
		Entity entity = EntitySystem.Instance.Get(currentEntityId);
		long? num;
		if (entity == null)
		{
			num = null;
		}
		else
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			num = ((component != null) ? new long?(component.GetCreatureDataId()) : null);
		}
		long? num2 = num;
		long valueOrDefault = num2.GetValueOrDefault();
		AdviceEntityData currentEntityAdviceData = AdviceModel.Instance.GetCurrentEntityAdviceData();
		bool flag;
		if (currentEntityAdviceData == null)
		{
			flag = true;
		}
		else
		{
			AdviceData adviceData = currentEntityAdviceData.GetAdviceData();
			flag = (adviceData == null || adviceData.GetAdviceBigId() == null);
		}
		if (flag)
		{
			return;
		}
		long value = currentEntityAdviceData.GetAdviceData().GetAdviceBigId().Value;
		long[] upVoteIds = AdviceModel.Instance.GetUpVoteIds();
		bool flag2 = false;
		long[] array = upVoteIds;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == value)
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			return;
		}
		long entityId = MathUtils.Instance.NumberToLong(valueOrDefault);
		UUIExtendToggle extendToggle = base.GetExtendToggle(6);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
		AdviceController.Instance.RequestVote(entityId, value, PbAdviceVoteType.Cancel);
	}

	// Token: 0x0600A737 RID: 42807 RVA: 0x00257FB0 File Offset: 0x002561B0
	private void OnClickLikeBtn(EToggleState state)
	{
		int currentEntityId = AdviceModel.Instance.GetCurrentEntityId();
		Entity entity = EntitySystem.Instance.Get(currentEntityId);
		long? num;
		if (entity == null)
		{
			num = null;
		}
		else
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			num = ((component != null) ? new long?(component.GetCreatureDataId()) : null);
		}
		long? num2 = num;
		long valueOrDefault = num2.GetValueOrDefault();
		AdviceEntityData currentEntityAdviceData = AdviceModel.Instance.GetCurrentEntityAdviceData();
		bool flag;
		if (currentEntityAdviceData == null)
		{
			flag = true;
		}
		else
		{
			AdviceData adviceData = currentEntityAdviceData.GetAdviceData();
			flag = (adviceData == null || adviceData.GetAdviceBigId() == null);
		}
		if (flag)
		{
			return;
		}
		long value = currentEntityAdviceData.GetAdviceData().GetAdviceBigId().Value;
		long entityId = MathUtils.Instance.NumberToLong(valueOrDefault);
		UUIExtendToggle extendToggle = base.GetExtendToggle(7);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
		long[] upVoteIds = AdviceModel.Instance.GetUpVoteIds();
		bool flag2 = false;
		long[] array = upVoteIds;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == value)
			{
				flag2 = true;
				break;
			}
		}
		if (flag2)
		{
			AdviceController.Instance.RequestVote(entityId, value, PbAdviceVoteType.Cancel);
			return;
		}
		AdviceController.Instance.RequestVote(entityId, value, PbAdviceVoteType.Up);
	}

	// Token: 0x0600A738 RID: 42808 RVA: 0x002580C6 File Offset: 0x002562C6
	private void RefreshAdviceInfoView()
	{
		this.InitView();
	}

	// Token: 0x0600A739 RID: 42809 RVA: 0x002580CE File Offset: 0x002562CE
	private void OnReceiveEntityRefresh()
	{
		this.RefreshLikeToggle();
		this.RefreshLikeNum();
	}

	// Token: 0x0600A73A RID: 42810 RVA: 0x002580DC File Offset: 0x002562DC
	private void RefreshLikeToggle()
	{
		long[] upVoteIds = AdviceModel.Instance.GetUpVoteIds();
		AdviceEntityData currentEntityAdviceData = AdviceModel.Instance.GetCurrentEntityAdviceData();
		bool flag;
		if (currentEntityAdviceData == null)
		{
			flag = true;
		}
		else
		{
			AdviceData adviceData = currentEntityAdviceData.GetAdviceData();
			flag = (adviceData == null || adviceData.GetAdviceBigId() == null);
		}
		if (flag)
		{
			return;
		}
		long value = currentEntityAdviceData.GetAdviceData().GetAdviceBigId().Value;
		bool flag2 = false;
		long[] array = upVoteIds;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == value)
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(7);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			return;
		}
		else
		{
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(7);
			if (extendToggle2 == null)
			{
				return;
			}
			extendToggle2.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
			return;
		}
	}

	// Token: 0x0600A73B RID: 42811 RVA: 0x0025818D File Offset: 0x0025638D
	protected override void OnAfterShow()
	{
		this.InitView();
	}

	// Token: 0x0600A73C RID: 42812 RVA: 0x00258198 File Offset: 0x00256398
	private void InitView()
	{
		this.InitTimer();
		this.ActorStartPosition = null;
		InteractionModel.Instance.SetInteractionHintDisable(true);
		AdviceEntityData currentEntityAdviceData = AdviceModel.Instance.GetCurrentEntityAdviceData();
		if (currentEntityAdviceData != null)
		{
			this.AdviceDataInstance = currentEntityAdviceData.GetAdviceData();
		}
		this.RefreshView();
	}

	// Token: 0x0600A73D RID: 42813 RVA: 0x002581DD File Offset: 0x002563DD
	private void InitTimer()
	{
		this.RemoveTimer();
		if (this.TimerId == null)
		{
			this.TimerId = TimerSystem.Instance.Forever(new TTimerAction(this.TimerCheck), 500f, 1f, null, null, true);
		}
	}

	// Token: 0x0600A73E RID: 42814 RVA: 0x00258216 File Offset: 0x00256416
	private void RemoveTimer()
	{
		if (this.TimerId != null)
		{
			TimerSystem.Instance.Remove(this.TimerId);
			this.TimerId = null;
		}
	}

	// Token: 0x0600A73F RID: 42815 RVA: 0x00258238 File Offset: 0x00256438
	private void CachePlayerCurrentPosition()
	{
		if (this.ActorStartPosition != null)
		{
			return;
		}
		global::Vector vector = global::Vector.Create();
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null) != null)
		{
			vector.DeepCopy(baseCharacter.CharacterActorComponent.ActorLocationProxy);
		}
		this.ActorStartPosition = vector;
	}

	// Token: 0x0600A740 RID: 42816 RVA: 0x00258280 File Offset: 0x00256480
	private void RefreshView()
	{
		this.RefreshLikeNum();
		this.RefreshText();
		this.RefreshEmojiTexture();
		this.RefreshLikeToggle();
		this.RefreshPlayerName();
	}

	// Token: 0x0600A741 RID: 42817 RVA: 0x002582A0 File Offset: 0x002564A0
	private void RefreshLikeNum()
	{
		if (this.AdviceDataInstance == null)
		{
			return;
		}
		long vote = this.AdviceDataInstance.GetVote();
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.SetText(vote.ToString(), true);
		}
		FColor color = FColor.FromHex((vote >= (long)AdviceConfig.Instance.GetAdviceHighNum()) ? "F9D751" : "FFFFFF");
		UUIText text2 = base.GetText(5);
		if (text2 == null)
		{
			return;
		}
		text2.SetColor(color);
	}

	// Token: 0x0600A742 RID: 42818 RVA: 0x0025830E File Offset: 0x0025650E
	private void RefreshText()
	{
		UUIText text = base.GetText(4);
		if (text == null)
		{
			return;
		}
		text.SetText(this.AdviceDataInstance.GetAdviceShowText(), true);
	}

	// Token: 0x0600A743 RID: 42819 RVA: 0x00258330 File Offset: 0x00256530
	private void RefreshPlayerName()
	{
		AdviceEntityData currentEntityAdviceData = AdviceModel.Instance.GetCurrentEntityAdviceData();
		string newText = ((currentEntityAdviceData != null) ? currentEntityAdviceData.GetPlayerName() : null) ?? "";
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(newText, true);
	}

	// Token: 0x0600A744 RID: 42820 RVA: 0x00258370 File Offset: 0x00256570
	private void RefreshEmojiTexture()
	{
		if (this.AdviceDataInstance == null)
		{
			return;
		}
		if (this.AdviceDataInstance.GetAdviceExpressionId() > 0)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			ChatExpression? expressionConfig = ChatConfig.Instance.GetExpressionConfig(this.AdviceDataInstance.GetAdviceExpressionId());
			if (expressionConfig != null)
			{
				base.SetTextureByPath(expressionConfig.Value.ExpressionTexturePath, base.GetTexture(1), null, null);
				return;
			}
		}
		else
		{
			UUITexture texture2 = base.GetTexture(1);
			if (texture2 == null)
			{
				return;
			}
			texture2.SetUIActive(false);
		}
	}

	// Token: 0x0600A745 RID: 42821 RVA: 0x002583FF File Offset: 0x002565FF
	private void TimerCheck(float deltaTime)
	{
		this.CachePlayerCurrentPosition();
		this.CheckEntityDistanceIfNeedClose();
		this.CheckPlayerIfMoveAndSetInteractState();
	}

	// Token: 0x0600A746 RID: 42822 RVA: 0x00258414 File Offset: 0x00256614
	private void CheckPlayerIfMoveAndSetInteractState()
	{
		if (InteractionModel.Instance.IsHideInteractHint && this.ActorStartPosition != null)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null) != null)
			{
				global::Vector actorLocationProxy = baseCharacter.CharacterActorComponent.ActorLocationProxy;
				if (!this.CheckPositionInRange(actorLocationProxy.X, this.ActorStartPosition.X, 3) || !this.CheckPositionInRange(actorLocationProxy.Y, this.ActorStartPosition.Y, 3) || !this.CheckPositionInRange(actorLocationProxy.Z, this.ActorStartPosition.Z, 3))
				{
					InteractionModel.Instance.SetInteractionHintDisable(false);
				}
			}
		}
	}

	// Token: 0x0600A747 RID: 42823 RVA: 0x002584B4 File Offset: 0x002566B4
	private bool CheckPositionInRange(double current, double target, int off)
	{
		int num = (int)Math.Ceiling(current) - (int)Math.Ceiling(target);
		return num < off && num > -1 * off;
	}

	// Token: 0x0600A748 RID: 42824 RVA: 0x002584E0 File Offset: 0x002566E0
	private void CheckEntityDistanceIfNeedClose()
	{
		int currentEntityId = AdviceModel.Instance.GetCurrentEntityId();
		Entity entity = EntitySystem.Instance.Get(currentEntityId);
		if (entity == null)
		{
			base.CloseMe(null);
			return;
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
		AActor aactor = (component != null) ? component.Owner : null;
		if (baseCharacter != null && aactor != null)
		{
			FVectorDouble v = aactor.D_K2_GetActorLocation();
			FVectorDouble v2 = baseCharacter.D_K2_GetActorLocation();
			double num = UKismetMathLibrary.D_Vector_Distance(v, v2);
			int adviceViewCloseDistance = AdviceConfig.Instance.GetAdviceViewCloseDistance();
			if (num > (double)adviceViewCloseDistance)
			{
				base.CloseMe(null);
			}
		}
	}

	// Token: 0x0600A749 RID: 42825 RVA: 0x0025855B File Offset: 0x0025675B
	private void OnCreateViewInstance(UiViewBase view)
	{
		UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(view.ViewInfo.Name);
		if (uiViewInfo != null && uiViewInfo.Type == ELayerType.Normal)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x0600A74A RID: 42826 RVA: 0x0025858A File Offset: 0x0025678A
	private void OnShowUiScene()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600A74B RID: 42827 RVA: 0x00258593 File Offset: 0x00256793
	protected override void OnBeforeDestroy()
	{
		this.RemoveTimer();
		this.RemoveEnterFightTask();
		InteractionModel.Instance.SetInteractionHintDisable(false);
	}

	// Token: 0x04004B7C RID: 19324
	private const int CHECKTIMEGAP = 500;

	// Token: 0x04004B7D RID: 19325
	private const int ROLEMOVERAGE = 3;

	// Token: 0x04004B7E RID: 19326
	[Nullable(2)]
	private TimerHandle TimerId;

	// Token: 0x04004B7F RID: 19327
	[Nullable(2)]
	private AdviceData AdviceDataInstance;

	// Token: 0x04004B80 RID: 19328
	[Nullable(2)]
	private object EnterFightTask;

	// Token: 0x04004B81 RID: 19329
	private bool IsPlayerEnterFight;

	// Token: 0x04004B82 RID: 19330
	[Nullable(2)]
	private global::Vector ActorStartPosition;

	// Token: 0x02007CA8 RID: 31912
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04028E37 RID: 167479
		public const int ContentItem = 0;

		// Token: 0x04028E38 RID: 167480
		public const int EmojiTexture = 1;

		// Token: 0x04028E39 RID: 167481
		public const int NameText = 2;

		// Token: 0x04028E3A RID: 167482
		public const int TextLayout = 3;

		// Token: 0x04028E3B RID: 167483
		public const int ContentText = 4;

		// Token: 0x04028E3C RID: 167484
		public const int LikeNumText = 5;

		// Token: 0x04028E3D RID: 167485
		public const int DislikeToggle = 6;

		// Token: 0x04028E3E RID: 167486
		public const int LikeToggle = 7;

		// Token: 0x04028E3F RID: 167487
		public const int ContentText2 = 8;
	}
}
