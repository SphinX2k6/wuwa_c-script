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

// Token: 0x02000B8C RID: 2956
[NullableContext(1)]
[Nullable(0)]
public class AdviceInfoView : UiViewBase
{
	// Token: 0x06007B0B RID: 31499 RVA: 0x00261EB4 File Offset: 0x002600B4
	public AdviceInfoView(UiViewInfo uiViewInfo) : base(uiViewInfo)
	{
	}

	// Token: 0x06007B0C RID: 31500 RVA: 0x00261EC0 File Offset: 0x002600C0
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

	// Token: 0x06007B0D RID: 31501 RVA: 0x00261FDC File Offset: 0x002601DC
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

	// Token: 0x06007B0E RID: 31502 RVA: 0x00262050 File Offset: 0x00260250
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAdviceEntityNotify, new Action(this.OnReceiveEntityRefresh));
		EventSystem.Instance.Add(EEventName.OnAdviceVoteNotify, new Action(this.OnReceiveEntityRefresh));
		EventSystem.Instance.Add(EEventName.CreateViewInstance, new Action<UiViewBase>(this.OnCreateViewInstance));
		EventSystem.Instance.Add(EEventName.UiSceneStartLoad, new Action(this.OnShowUiScene));
		EventSystem.Instance.Add(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleCompleted));
		EventSystem.Instance.Add(EEventName.RefreshAdviceInfoView, new Action(this.RefreshAdviceInfoView));
	}

	// Token: 0x06007B0F RID: 31503 RVA: 0x00262100 File Offset: 0x00260300
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleCompleted));
		EventSystem.Instance.Remove(EEventName.OnAdviceEntityNotify, new Action(this.OnReceiveEntityRefresh));
		EventSystem.Instance.Remove(EEventName.OnAdviceVoteNotify, new Action(this.OnReceiveEntityRefresh));
		EventSystem.Instance.Remove(EEventName.CreateViewInstance, new Action<UiViewBase>(this.OnCreateViewInstance));
		EventSystem.Instance.Remove(EEventName.UiSceneStartLoad, new Action(this.OnShowUiScene));
		EventSystem.Instance.Remove(EEventName.RefreshAdviceInfoView, new Action(this.RefreshAdviceInfoView));
	}

	// Token: 0x06007B10 RID: 31504 RVA: 0x002621AE File Offset: 0x002603AE
	private void OnChangeRoleCompleted(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		this.ListCurrentEntityBattleTag();
	}

	// Token: 0x06007B11 RID: 31505 RVA: 0x002621B8 File Offset: 0x002603B8
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

	// Token: 0x06007B12 RID: 31506 RVA: 0x0026222C File Offset: 0x0026042C
	private void ListenPlayerEnterFight(EntityHandle playerEntityHandle)
	{
		WorldEntity entity = playerEntityHandle.Entity;
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		if (baseTagComponent != null)
		{
			this.EnterFightTask = baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]), new BaseTagComponent.TTagSwitchedCallback(this.OnPlayerEnterFight), null);
		}
	}

	// Token: 0x06007B13 RID: 31507 RVA: 0x0026227C File Offset: 0x0026047C
	private void RemoveEnterFightTask()
	{
		if (this.EnterFightTask != null)
		{
			((ITagTask)this.EnterFightTask).EndTask();
			this.EnterFightTask = null;
		}
	}

	// Token: 0x06007B14 RID: 31508 RVA: 0x0026229D File Offset: 0x0026049D
	private void OnPlayerEnterFight(int tagId, bool tagExists)
	{
		this.IsPlayerEnterFight = tagExists;
		if (tagExists)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x06007B15 RID: 31509 RVA: 0x002622B0 File Offset: 0x002604B0
	private bool CanClickLikeToggle()
	{
		return true;
	}

	// Token: 0x06007B16 RID: 31510 RVA: 0x002622B4 File Offset: 0x002604B4
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

	// Token: 0x06007B17 RID: 31511 RVA: 0x002623BC File Offset: 0x002605BC
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

	// Token: 0x06007B18 RID: 31512 RVA: 0x002624D2 File Offset: 0x002606D2
	private void RefreshAdviceInfoView()
	{
		this.InitView();
	}

	// Token: 0x06007B19 RID: 31513 RVA: 0x002624DA File Offset: 0x002606DA
	private void OnReceiveEntityRefresh()
	{
		this.RefreshLikeToggle();
		this.RefreshLikeNum();
	}

	// Token: 0x06007B1A RID: 31514 RVA: 0x002624E8 File Offset: 0x002606E8
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

	// Token: 0x06007B1B RID: 31515 RVA: 0x00262599 File Offset: 0x00260799
	protected override void OnAfterShow()
	{
		this.InitView();
	}

	// Token: 0x06007B1C RID: 31516 RVA: 0x002625A4 File Offset: 0x002607A4
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

	// Token: 0x06007B1D RID: 31517 RVA: 0x002625E9 File Offset: 0x002607E9
	private void InitTimer()
	{
		this.RemoveTimer();
		if (this.TimerId == null)
		{
			this.TimerId = TimerSystem.Instance.Forever(new TTimerAction(this.TimerCheck), 500f, 1f, null, null, true);
		}
	}

	// Token: 0x06007B1E RID: 31518 RVA: 0x00262622 File Offset: 0x00260822
	private void RemoveTimer()
	{
		if (this.TimerId != null)
		{
			TimerSystem.Instance.Remove(this.TimerId);
			this.TimerId = null;
		}
	}

	// Token: 0x06007B1F RID: 31519 RVA: 0x00262644 File Offset: 0x00260844
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

	// Token: 0x06007B20 RID: 31520 RVA: 0x0026268C File Offset: 0x0026088C
	private void RefreshView()
	{
		this.RefreshLikeNum();
		this.RefreshText();
		this.RefreshEmojiTexture();
		this.RefreshLikeToggle();
		this.RefreshPlayerName();
	}

	// Token: 0x06007B21 RID: 31521 RVA: 0x002626AC File Offset: 0x002608AC
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

	// Token: 0x06007B22 RID: 31522 RVA: 0x0026271A File Offset: 0x0026091A
	private void RefreshText()
	{
		UUIText text = base.GetText(4);
		if (text == null)
		{
			return;
		}
		text.SetText(this.AdviceDataInstance.GetAdviceShowText(), true);
	}

	// Token: 0x06007B23 RID: 31523 RVA: 0x0026273C File Offset: 0x0026093C
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

	// Token: 0x06007B24 RID: 31524 RVA: 0x0026277C File Offset: 0x0026097C
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

	// Token: 0x06007B25 RID: 31525 RVA: 0x0026280B File Offset: 0x00260A0B
	private void TimerCheck(float deltaTime)
	{
		this.CachePlayerCurrentPosition();
		this.CheckEntityDistanceIfNeedClose();
		this.CheckPlayerIfMoveAndSetInteractState();
	}

	// Token: 0x06007B26 RID: 31526 RVA: 0x00262820 File Offset: 0x00260A20
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

	// Token: 0x06007B27 RID: 31527 RVA: 0x002628C0 File Offset: 0x00260AC0
	private bool CheckPositionInRange(double current, double target, int off)
	{
		int num = (int)Math.Ceiling(current) - (int)Math.Ceiling(target);
		return num < off && num > -1 * off;
	}

	// Token: 0x06007B28 RID: 31528 RVA: 0x002628EC File Offset: 0x00260AEC
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

	// Token: 0x06007B29 RID: 31529 RVA: 0x00262967 File Offset: 0x00260B67
	private void OnCreateViewInstance(UiViewBase view)
	{
		UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(view.ViewInfo.Name);
		if (uiViewInfo != null && uiViewInfo.Type == ELayerType.Normal)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x06007B2A RID: 31530 RVA: 0x00262996 File Offset: 0x00260B96
	private void OnShowUiScene()
	{
		base.CloseMe(null);
	}

	// Token: 0x06007B2B RID: 31531 RVA: 0x0026299F File Offset: 0x00260B9F
	protected override void OnBeforeDestroy()
	{
		this.RemoveTimer();
		this.RemoveEnterFightTask();
		InteractionModel.Instance.SetInteractionHintDisable(false);
	}

	// Token: 0x04004C23 RID: 19491
	private const int CHECKTIMEGAP = 500;

	// Token: 0x04004C24 RID: 19492
	private const int ROLEMOVERAGE = 3;

	// Token: 0x04004C25 RID: 19493
	[Nullable(2)]
	private TimerHandle TimerId;

	// Token: 0x04004C26 RID: 19494
	[Nullable(2)]
	private AdviceData AdviceDataInstance;

	// Token: 0x04004C27 RID: 19495
	[Nullable(2)]
	private object EnterFightTask;

	// Token: 0x04004C28 RID: 19496
	private bool IsPlayerEnterFight;

	// Token: 0x04004C29 RID: 19497
	[Nullable(2)]
	private global::Vector ActorStartPosition;

	// Token: 0x02006E2D RID: 28205
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04024160 RID: 147808
		public const int ContentItem = 0;

		// Token: 0x04024161 RID: 147809
		public const int EmojiTexture = 1;

		// Token: 0x04024162 RID: 147810
		public const int NameText = 2;

		// Token: 0x04024163 RID: 147811
		public const int TextLayout = 3;

		// Token: 0x04024164 RID: 147812
		public const int ContentText = 4;

		// Token: 0x04024165 RID: 147813
		public const int LikeNumText = 5;

		// Token: 0x04024166 RID: 147814
		public const int DislikeToggle = 6;

		// Token: 0x04024167 RID: 147815
		public const int LikeToggle = 7;

		// Token: 0x04024168 RID: 147816
		public const int ContentText2 = 8;
	}
}
