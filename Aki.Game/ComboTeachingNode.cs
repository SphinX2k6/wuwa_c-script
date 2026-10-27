using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017E2 RID: 6114
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ComboTeachingNode : AutoAttachItem<IComboTeachingInfo>
{
	// Token: 0x0600B2A9 RID: 45737 RVA: 0x0028553B File Offset: 0x0028373B
	public ComboTeachingNode(AActor uiItem = null) : base(uiItem)
	{
	}

	// Token: 0x0600B2AA RID: 45738 RVA: 0x00285550 File Offset: 0x00283750
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
	}

	// Token: 0x0600B2AB RID: 45739 RVA: 0x0028565C File Offset: 0x0028385C
	protected override void OnBeforeShow()
	{
		if (this.HasInit && !this.HasAdd)
		{
			this.HasAdd = true;
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		}
	}

	// Token: 0x0600B2AC RID: 45740 RVA: 0x00285691 File Offset: 0x00283891
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		this.HasAdd = false;
	}

	// Token: 0x0600B2AD RID: 45741 RVA: 0x002856B8 File Offset: 0x002838B8
	protected UniTask InitAsync()
	{
		ComboTeachingNode.<InitAsync>d__12 <InitAsync>d__;
		<InitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAsync>d__.<>4__this = this;
		<InitAsync>d__.<>1__state = -1;
		<InitAsync>d__.<>t__builder.Start<ComboTeachingNode.<InitAsync>d__12>(ref <InitAsync>d__);
		return <InitAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B2AE RID: 45742 RVA: 0x002856FB File Offset: 0x002838FB
	protected override void OnBeforeDestroy()
	{
		this.LevelSequencePlayer.Clear();
		this.LevelSequencePlayer = null;
		this.KeyComponent = null;
	}

	// Token: 0x0600B2AF RID: 45743 RVA: 0x00285716 File Offset: 0x00283916
	public override void OnSelect()
	{
	}

	// Token: 0x0600B2B0 RID: 45744 RVA: 0x00285718 File Offset: 0x00283918
	protected override void OnUnSelect()
	{
	}

	// Token: 0x0600B2B1 RID: 45745 RVA: 0x0028571A File Offset: 0x0028391A
	protected override void OnMoveItem()
	{
	}

	// Token: 0x0600B2B2 RID: 45746 RVA: 0x0028571C File Offset: 0x0028391C
	protected override void OnRefreshItem(IComboTeachingInfo data)
	{
		this.Data = data;
		if (this.LevelSequencePlayer == null)
		{
			this.InitAsync().ContinueWith(delegate()
			{
				this.InitNode();
				this.Refresh();
			});
			return;
		}
		this.InitNode();
		this.Refresh();
	}

	// Token: 0x0600B2B3 RID: 45747 RVA: 0x00285754 File Offset: 0x00283954
	public void InitNode()
	{
		if (!this.HasInit && !this.HasAdd)
		{
			this.HasAdd = true;
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		}
		this.HasInit = true;
		int index = this.Data.Index;
		ComboTeaching config = this.Data.Config;
		bool isHoldAction = this.Data.IsHoldAction;
		if (index >= config.KeyIDLength || string.IsNullOrEmpty(config.KeyID(index)))
		{
			this.RootItem.SetAlpha(0f);
			return;
		}
		string[] array = config.KeyID(index).Split(';', StringSplitOptions.None);
		string text = array[0];
		string text2 = (array.Length > 1) ? array[1] : null;
		string key = text.Split('#', StringSplitOptions.None)[0];
		EInputAction checkAction;
		ComboTeachingNodeDefine.KeyMap.TryGetValue(key, out checkAction);
		this.CheckAction = checkAction;
		string text3;
		ComboTeachingNodeDefine.ActionMap.TryGetValue(key, out text3);
		if (text3 == null)
		{
			text3 = "";
		}
		if (config.Id == 15111001 && index == 1)
		{
			if (Info.Instance.IsInGamepad())
			{
				text3 = "UI键盘F手柄A";
			}
			else
			{
				text3 = "UI左键点击";
			}
		}
		InputActionOrAxisKeyItem actionOrAxisKeyItem = new InputActionOrAxisKeyItem
		{
			ActionOrAxisName = text3
		};
		InputMultiKeyItem keyComponent = this.KeyComponent;
		if (keyComponent != null)
		{
			keyComponent.RefreshByActionOrAxis(actionOrAxisKeyItem, false);
		}
		if (isHoldAction)
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("AutoLoop", false, null, false);
		}
		this.LevelSequencePlayer.StopCurrentSequence(false, true);
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		if (text2 != null && text2.Length > 0)
		{
			int entityIdNoBlueprint = Global.BaseCharacter.GetEntityIdNoBlueprint();
			SSkillInfo skillInfo = EntitySystem.Instance.Get(entityIdNoBlueprint).GetComponent<CharacterSkillComponent>().GetSkillInfo(int.Parse(text2));
			if (skillInfo != null)
			{
				FSoftObjectPath skillIcon = skillInfo.SkillIcon;
				this.SetSpriteByPath((skillIcon != null) ? skillIcon.AssetPathName.ToString() : null, base.GetSprite(0), false, new EUiViewName?(EUiViewName.ComboTeachingView), null);
			}
		}
		if (config.IconTagTextLength > index && config.IconTagText(index) != "")
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), config.IconTagText(index), Array.Empty<object>());
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), (index < config.IconTextLength) ? config.IconText(index) : null, Array.Empty<object>());
		LguiUtil.Instance.ReplaceWildCard(base.GetText(7));
		base.GetSprite(3).SetFillAmount(0f);
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(this.Data.IsShowTag);
		}
		base.GetSprite(3).SetUIActive(isHoldAction);
		base.GetItem(10).SetUIActive(isHoldAction);
	}

	// Token: 0x0600B2B4 RID: 45748 RVA: 0x00285A24 File Offset: 0x00283C24
	public void Refresh()
	{
		if (this.Data == null)
		{
			return;
		}
		int currentNodeIndex = ComboTeachingModel.Instance.CurrentNodeIndex;
		if (currentNodeIndex == this.Data.Index)
		{
			base.GetSprite(1).SetUIActive(false);
			base.GetSprite(2).SetUIActive(false);
			base.GetItem(6).SetUIActive(true);
			return;
		}
		if (currentNodeIndex < this.Data.Index)
		{
			base.GetSprite(1).SetUIActive(false);
			base.GetSprite(2).SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			return;
		}
		if (currentNodeIndex > this.Data.Index)
		{
			base.GetSprite(1).SetUIActive(true);
			base.GetSprite(2).SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
		}
	}

	// Token: 0x0600B2B5 RID: 45749 RVA: 0x00285AE8 File Offset: 0x00283CE8
	public void PlayFailAnimation()
	{
		base.GetSprite(2).SetUIActive(true);
		this.LevelSequencePlayer.StopCurrentSequence(false, true);
		this.LevelSequencePlayer.PlayLevelSequenceByName("ClickRigMIs", false, null, false);
	}

	// Token: 0x0600B2B6 RID: 45750 RVA: 0x00285B2C File Offset: 0x00283D2C
	public void PlaySuccessAnimation()
	{
		base.GetSprite(1).SetUIActive(true);
		this.LevelSequencePlayer.StopCurrentSequence(false, true);
		this.LevelSequencePlayer.PlayLevelSequenceByName("ClickRigMIs", false, null, false);
	}

	// Token: 0x0600B2B7 RID: 45751 RVA: 0x00285B70 File Offset: 0x00283D70
	public void OnPress(EInputAction action, float time)
	{
		CheckKeyCondition param = new CheckKeyCondition
		{
			ActionKey = action,
			ActionType = EComboKeyType.Press
		};
		if (this.Data.SuccessCondition.GetConditionType() == 10)
		{
			this.CheckSuccessDelay(param);
		}
		if (ComboTeachingModel.Instance.CheckFailCondition(this.Data, EComboTeachingFailCondition.PressKey))
		{
			this.CheckFailDelay(param);
		}
	}

	// Token: 0x0600B2B8 RID: 45752 RVA: 0x00285BC8 File Offset: 0x00283DC8
	public void OnRelease(EInputAction action, float time)
	{
		this.HoldTime = 0f;
		base.GetSprite(3).SetFillAmount(0f);
		this.LevelSequencePlayer.StopSequenceByKey("LongPress", false, false);
		if (this.Data.IsHoldAction)
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("AutoLoop", false, null, false);
		}
		if (!this.Data.IsEmit && this.Data.IsHoldAction)
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(this.Data.IsShowTag);
			}
		}
		base.GetItem(8).SetUIActive(false);
		base.GetItem(6).SetUIActive(true);
		CheckKeyCondition param = new CheckKeyCondition
		{
			ActionKey = action,
			ActionType = EComboKeyType.Release
		};
		if (this.Data.SuccessCondition.GetConditionType() == 10)
		{
			this.CheckSuccessDelay(param);
		}
		if (ComboTeachingModel.Instance.CheckFailCondition(this.Data, EComboTeachingFailCondition.PressKey))
		{
			this.CheckFailDelay(param);
		}
	}

	// Token: 0x0600B2B9 RID: 45753 RVA: 0x00285CC8 File Offset: 0x00283EC8
	public void OnHold(EInputAction action, float time)
	{
		if (this.Data.IsHoldAction && action == this.CheckAction)
		{
			this.HoldTime = time;
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(this.Data.IsShowTag);
			}
			base.GetSprite(3).SetFillAmount(this.HoldTime / this.Data.HoldTotalTime);
			if (this.LevelSequencePlayer.GetCurrentSequence() != "LongPress")
			{
				this.LevelSequencePlayer.PlayLevelSequenceByName("LongPress", false, null, false);
				base.GetItem(8).SetUIActive(true);
				base.GetItem(6).SetUIActive(false);
			}
			CheckKeyCondition param = new CheckKeyCondition
			{
				ActionKey = action,
				ActionType = EComboKeyType.Hold,
				HoldTime = new float?(time)
			};
			if (this.Data.SuccessCondition.GetConditionType() == 11)
			{
				this.CheckSuccessDelay(param);
			}
			if (ComboTeachingModel.Instance.CheckFailCondition(this.Data, EComboTeachingFailCondition.HoldKey))
			{
				this.CheckFailDelay(param);
			}
		}
	}

	// Token: 0x0600B2BA RID: 45754 RVA: 0x00285DDC File Offset: 0x00283FDC
	public void OnUseSkill(int skillId)
	{
		bool flag = ComboTeachingModel.Instance.CheckFailCondition(this.Data, EComboTeachingFailCondition.SkillIdChecker);
		if (!this.Data.IsHoldAction && flag)
		{
			this.CheckFailDelay(null);
		}
	}

	// Token: 0x0600B2BB RID: 45755 RVA: 0x00285E14 File Offset: 0x00284014
	public void OnTick(float delta)
	{
		if (this.Data.IsEmit)
		{
			return;
		}
		if (this.Data.NeedTickSummon)
		{
			ComboTeachingModel.Instance.CheckSummonBuffAdd(this.Data);
		}
		if (this.Data.SuccessCondition == null)
		{
			return;
		}
		if (this.Data.SuccessCondition.Type == EComboTeachingCheckType.Update && this.CheckSuccessCondition(null))
		{
			return;
		}
		this.CheckFailCondition();
	}

	// Token: 0x0600B2BC RID: 45756 RVA: 0x00285E80 File Offset: 0x00284080
	public void CheckSuccessDelay(IBaseCheckConditionInfo param = null)
	{
		if (this.Data.SuccessDelay == 0f)
		{
			this.CheckSuccessCondition(param);
			return;
		}
		if (this.Data.SuccessHandle != null)
		{
			if (TimerSystem.Instance.Has(this.Data.SuccessHandle))
			{
				TimerSystem.Instance.Remove(this.Data.SuccessHandle);
			}
			this.Data.SuccessHandle = null;
		}
		this.Data.SuccessHandle = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.CheckSuccessCondition(param);
		}, this.Data.SuccessDelay, null, null, true, 1f);
	}

	// Token: 0x0600B2BD RID: 45757 RVA: 0x00285F3C File Offset: 0x0028413C
	public bool CheckSuccessCondition(IBaseCheckConditionInfo param = null)
	{
		if (!this.Data.SuccessCondition.Check(this.Data, param) || this.Data.IsEmit)
		{
			return false;
		}
		if (!EventSystem.Instance.Emit<ComboTeachingNode, bool>(EEventName.ComboTeachingNodeEnd, this, true))
		{
			return false;
		}
		this.LevelSequencePlayer.StopSequenceByKey("LongPress", false, false);
		this.LevelSequencePlayer.StopCurrentSequence(false, true);
		this.LevelSequencePlayer.PlayLevelSequenceByName("ClickRigMIs", false, null, false);
		base.GetItem(8).SetUIActive(false);
		this.Data.IsEmit = true;
		return true;
	}

	// Token: 0x0600B2BE RID: 45758 RVA: 0x00285FDC File Offset: 0x002841DC
	public void CheckFailCondition()
	{
		if (this.Data.IsEmit)
		{
			return;
		}
		bool flag = false;
		foreach (BaseCheckCondition baseCheckCondition in this.Data.FailUpdateCondition)
		{
			flag = (baseCheckCondition.Check(this.Data, null) || flag);
		}
		if (flag)
		{
			if (!EventSystem.Instance.Emit<ComboTeachingNode, bool>(EEventName.ComboTeachingNodeEnd, this, false))
			{
				return;
			}
			this.LevelSequencePlayer.StopCurrentSequence(false, true);
			this.LevelSequencePlayer.PlayLevelSequenceByName("ClickRigMIs", false, null, false);
			this.Data.IsEmit = true;
		}
	}

	// Token: 0x0600B2BF RID: 45759 RVA: 0x00286098 File Offset: 0x00284298
	public void CheckFailDelay(IBaseCheckConditionInfo param = null)
	{
		if (this.Data.FailDelay == 0f)
		{
			this.CheckFailEventCondition(param);
			return;
		}
		if (this.Data.FailHandle != null)
		{
			if (TimerSystem.Instance.Has(this.Data.FailHandle))
			{
				TimerSystem.Instance.Remove(this.Data.FailHandle);
			}
			this.Data.FailHandle = null;
		}
		this.Data.FailHandle = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.CheckFailEventCondition(param);
		}, this.Data.FailDelay, null, null, true, 1f);
	}

	// Token: 0x0600B2C0 RID: 45760 RVA: 0x00286154 File Offset: 0x00284354
	public void CheckFailEventCondition(IBaseCheckConditionInfo param = null)
	{
		if (this.Data.IsEmit)
		{
			return;
		}
		bool flag = false;
		foreach (BaseCheckCondition baseCheckCondition in this.Data.FailEventCondition)
		{
			flag = (baseCheckCondition.Check(this.Data, param) || flag);
		}
		if (flag)
		{
			if (!EventSystem.Instance.Emit<ComboTeachingNode, bool>(EEventName.ComboTeachingNodeEnd, this, false))
			{
				return;
			}
			this.LevelSequencePlayer.StopCurrentSequence(false, true);
			this.LevelSequencePlayer.PlayLevelSequenceByName("ClickRigMIs", false, null, false);
			this.Data.IsEmit = true;
		}
	}

	// Token: 0x0600B2C1 RID: 45761 RVA: 0x00286210 File Offset: 0x00284410
	[NullableContext(1)]
	public void OnBulletHit(HitInformation hitInfo)
	{
		int conditionType = this.Data.SuccessCondition.GetConditionType();
		if (conditionType != 9 && conditionType != 1)
		{
			return;
		}
		CharacterSkillComponent component = hitInfo.Attacker.GetComponent<CharacterSkillComponent>();
		CheckSkillHitCondition checkSkillHitCondition = new CheckSkillHitCondition();
		int? num;
		if (component == null)
		{
			num = null;
		}
		else
		{
			global::Skill currentSkill = component.CurrentSkill;
			num = ((currentSkill != null) ? new int?(currentSkill.SkillId) : null);
		}
		int? num2 = num;
		checkSkillHitCondition.HitSkillId = (long)num2.GetValueOrDefault();
		checkSkillHitCondition.BulletId = hitInfo.BulletId;
		CheckSkillHitCondition param = checkSkillHitCondition;
		this.CheckSuccessDelay(param);
	}

	// Token: 0x0600B2C2 RID: 45762 RVA: 0x0028629C File Offset: 0x0028449C
	private void InputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		int index = this.Data.Index;
		ComboTeaching config = this.Data.Config;
		if (index >= config.KeyIDLength || string.IsNullOrEmpty(config.KeyID(index)))
		{
			return;
		}
		string key = config.KeyID(index).Split(';', StringSplitOptions.None)[0].Split('#', StringSplitOptions.None)[0];
		EInputAction checkAction;
		ComboTeachingNodeDefine.KeyMap.TryGetValue(key, out checkAction);
		this.CheckAction = checkAction;
		string text;
		ComboTeachingNodeDefine.ActionMap.TryGetValue(key, out text);
		if (text == null)
		{
			text = "";
		}
		if (config.Id == 15111001 && index == 1)
		{
			if (Info.Instance.IsInGamepad())
			{
				text = "UI键盘F手柄A";
			}
			else
			{
				text = "UI左键点击";
			}
		}
		InputActionOrAxisKeyItem actionOrAxisKeyItem = new InputActionOrAxisKeyItem
		{
			ActionOrAxisName = text
		};
		InputMultiKeyItem keyComponent = this.KeyComponent;
		if (keyComponent == null)
		{
			return;
		}
		keyComponent.RefreshByActionOrAxis(actionOrAxisKeyItem, false);
	}

	// Token: 0x04005100 RID: 20736
	private EInputAction CheckAction = EInputAction.None;

	// Token: 0x04005101 RID: 20737
	private IComboTeachingInfo Data;

	// Token: 0x04005102 RID: 20738
	public float HoldTime;

	// Token: 0x04005103 RID: 20739
	protected bool HasInit;

	// Token: 0x04005104 RID: 20740
	protected bool HasAdd;

	// Token: 0x04005105 RID: 20741
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04005106 RID: 20742
	public InputMultiKeyItem KeyComponent;

	// Token: 0x02007DCB RID: 32203
	[NullableContext(0)]
	private enum EComboTeachingNodeDefine
	{
		// Token: 0x040292E0 RID: 168672
		ActionIcon,
		// Token: 0x040292E1 RID: 168673
		SuccessTexture,
		// Token: 0x040292E2 RID: 168674
		FailTexture,
		// Token: 0x040292E3 RID: 168675
		CdSprite,
		// Token: 0x040292E4 RID: 168676
		TopTagItem,
		// Token: 0x040292E5 RID: 168677
		TopTagText,
		// Token: 0x040292E6 RID: 168678
		SelectedItem,
		// Token: 0x040292E7 RID: 168679
		DescriptionText,
		// Token: 0x040292E8 RID: 168680
		HoldEffectItem,
		// Token: 0x040292E9 RID: 168681
		KeyItem,
		// Token: 0x040292EA RID: 168682
		CdItem
	}
}
