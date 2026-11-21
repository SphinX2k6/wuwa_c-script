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

// Token: 0x02000C9B RID: 3227
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ComboTeachingNode : AutoAttachItem<IComboTeachingInfo>
{
	// Token: 0x06008692 RID: 34450 RVA: 0x0028FAE7 File Offset: 0x0028DCE7
	public ComboTeachingNode(AActor uiItem = null) : base(uiItem)
	{
	}

	// Token: 0x06008693 RID: 34451 RVA: 0x0028FAFC File Offset: 0x0028DCFC
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

	// Token: 0x06008694 RID: 34452 RVA: 0x0028FC08 File Offset: 0x0028DE08
	protected override void OnBeforeShow()
	{
		if (this.HasInit && !this.HasAdd)
		{
			this.HasAdd = true;
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		}
	}

	// Token: 0x06008695 RID: 34453 RVA: 0x0028FC3D File Offset: 0x0028DE3D
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		this.HasAdd = false;
	}

	// Token: 0x06008696 RID: 34454 RVA: 0x0028FC64 File Offset: 0x0028DE64
	protected UniTask InitAsync()
	{
		ComboTeachingNode.<InitAsync>d__12 <InitAsync>d__;
		<InitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAsync>d__.<>4__this = this;
		<InitAsync>d__.<>1__state = -1;
		<InitAsync>d__.<>t__builder.Start<ComboTeachingNode.<InitAsync>d__12>(ref <InitAsync>d__);
		return <InitAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008697 RID: 34455 RVA: 0x0028FCA7 File Offset: 0x0028DEA7
	protected override void OnBeforeDestroy()
	{
		this.LevelSequencePlayer.Clear();
		this.LevelSequencePlayer = null;
		this.KeyComponent = null;
	}

	// Token: 0x06008698 RID: 34456 RVA: 0x0028FCC2 File Offset: 0x0028DEC2
	public override void OnSelect()
	{
	}

	// Token: 0x06008699 RID: 34457 RVA: 0x0028FCC4 File Offset: 0x0028DEC4
	protected override void OnUnSelect()
	{
	}

	// Token: 0x0600869A RID: 34458 RVA: 0x0028FCC6 File Offset: 0x0028DEC6
	protected override void OnMoveItem()
	{
	}

	// Token: 0x0600869B RID: 34459 RVA: 0x0028FCC8 File Offset: 0x0028DEC8
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

	// Token: 0x0600869C RID: 34460 RVA: 0x0028FD00 File Offset: 0x0028DF00
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
		text3 = this.ApplySpecialIcon((index < config.SpecialIconIDLength) ? config.SpecialIconID(index) : null, text3);
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

	// Token: 0x0600869D RID: 34461 RVA: 0x0028FFC0 File Offset: 0x0028E1C0
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

	// Token: 0x0600869E RID: 34462 RVA: 0x00290084 File Offset: 0x0028E284
	public void PlayFailAnimation()
	{
		base.GetSprite(2).SetUIActive(true);
		this.LevelSequencePlayer.StopCurrentSequence(false, true);
		this.LevelSequencePlayer.PlayLevelSequenceByName("ClickRigMIs", false, null, false);
	}

	// Token: 0x0600869F RID: 34463 RVA: 0x002900C8 File Offset: 0x0028E2C8
	public void PlaySuccessAnimation()
	{
		base.GetSprite(1).SetUIActive(true);
		this.LevelSequencePlayer.StopCurrentSequence(false, true);
		this.LevelSequencePlayer.PlayLevelSequenceByName("ClickRigMIs", false, null, false);
	}

	// Token: 0x060086A0 RID: 34464 RVA: 0x0029010C File Offset: 0x0028E30C
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

	// Token: 0x060086A1 RID: 34465 RVA: 0x00290164 File Offset: 0x0028E364
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

	// Token: 0x060086A2 RID: 34466 RVA: 0x00290264 File Offset: 0x0028E464
	public void OnHold(EInputAction action, float time)
	{
		if (this.Data.IsHoldAction && action == this.CheckAction)
		{
			if (this.HoldTime < this.Data.HoldTotalTime)
			{
				float holdTotalTime = this.Data.HoldTotalTime;
			}
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

	// Token: 0x060086A3 RID: 34467 RVA: 0x00290398 File Offset: 0x0028E598
	public void OnUseSkill(int skillId)
	{
		EComboTeachingFailCondition condition = EComboTeachingFailCondition.SkillIdChecker;
		if (this.Data.IsHoldAction)
		{
			condition = EComboTeachingFailCondition.HoldSkillIdChecker;
		}
		if (ComboTeachingModel.Instance.CheckFailCondition(this.Data, condition))
		{
			this.CheckFailDelay(null);
		}
	}

	// Token: 0x060086A4 RID: 34468 RVA: 0x002903D4 File Offset: 0x0028E5D4
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

	// Token: 0x060086A5 RID: 34469 RVA: 0x00290440 File Offset: 0x0028E640
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

	// Token: 0x060086A6 RID: 34470 RVA: 0x002904FC File Offset: 0x0028E6FC
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

	// Token: 0x060086A7 RID: 34471 RVA: 0x0029059C File Offset: 0x0028E79C
	public void CheckFailCondition()
	{
		if (this.Data.IsEmit)
		{
			return;
		}
		bool flag = false;
		string text = "";
		foreach (BaseCheckCondition baseCheckCondition in this.Data.FailUpdateCondition)
		{
			bool flag2 = baseCheckCondition.Check(this.Data, null);
			if (flag2)
			{
				string str = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
				defaultInterpolatedStringHandler.AppendFormatted<EComboTeachingFailCondition>((EComboTeachingFailCondition)baseCheckCondition.GetConditionType());
				defaultInterpolatedStringHandler.AppendLiteral("=");
				defaultInterpolatedStringHandler.AppendFormatted(baseCheckCondition.OriginString);
				defaultInterpolatedStringHandler.AppendLiteral(";");
				text = str + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			flag = (flag2 || flag);
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

	// Token: 0x060086A8 RID: 34472 RVA: 0x002906AC File Offset: 0x0028E8AC
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

	// Token: 0x060086A9 RID: 34473 RVA: 0x00290768 File Offset: 0x0028E968
	public void CheckFailEventCondition(IBaseCheckConditionInfo param = null)
	{
		if (this.Data.IsEmit)
		{
			return;
		}
		bool flag = false;
		string text = "";
		foreach (BaseCheckCondition baseCheckCondition in this.Data.FailEventCondition)
		{
			bool flag2 = baseCheckCondition.Check(this.Data, param);
			if (flag2)
			{
				string str = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
				defaultInterpolatedStringHandler.AppendFormatted<EComboTeachingFailCondition>((EComboTeachingFailCondition)baseCheckCondition.GetConditionType());
				defaultInterpolatedStringHandler.AppendLiteral("=");
				defaultInterpolatedStringHandler.AppendFormatted(baseCheckCondition.OriginString);
				defaultInterpolatedStringHandler.AppendLiteral(";");
				text = str + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			flag = (flag2 || flag);
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

	// Token: 0x060086AA RID: 34474 RVA: 0x00290878 File Offset: 0x0028EA78
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

	// Token: 0x060086AB RID: 34475 RVA: 0x00290904 File Offset: 0x0028EB04
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
		text = this.ApplySpecialIcon((index < config.SpecialIconIDLength) ? config.SpecialIconID(index) : null, text);
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

	// Token: 0x060086AC RID: 34476 RVA: 0x002909D4 File Offset: 0x0028EBD4
	[NullableContext(1)]
	private string ApplySpecialIcon(string special, string defaultKeyName)
	{
		if (string.IsNullOrEmpty(special) || special == "0")
		{
			return defaultKeyName;
		}
		string[] array = special.Split('#', StringSplitOptions.None);
		int num = Info.Instance.IsInGamepad() ? 1 : (Info.Instance.IsInTouch() ? 2 : 0);
		if (array.Length <= num)
		{
			return defaultKeyName;
		}
		string text = array[num];
		if (string.IsNullOrEmpty(text) || text == "0")
		{
			return defaultKeyName;
		}
		return text;
	}

	// Token: 0x040051AB RID: 20907
	private EInputAction CheckAction = EInputAction.None;

	// Token: 0x040051AC RID: 20908
	private IComboTeachingInfo Data;

	// Token: 0x040051AD RID: 20909
	public float HoldTime;

	// Token: 0x040051AE RID: 20910
	protected bool HasInit;

	// Token: 0x040051AF RID: 20911
	protected bool HasAdd;

	// Token: 0x040051B0 RID: 20912
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040051B1 RID: 20913
	public InputMultiKeyItem KeyComponent;

	// Token: 0x02006F51 RID: 28497
	[NullableContext(0)]
	private enum EComboTeachingNodeDefine
	{
		// Token: 0x0402460B RID: 149003
		ActionIcon,
		// Token: 0x0402460C RID: 149004
		SuccessTexture,
		// Token: 0x0402460D RID: 149005
		FailTexture,
		// Token: 0x0402460E RID: 149006
		CdSprite,
		// Token: 0x0402460F RID: 149007
		TopTagItem,
		// Token: 0x04024610 RID: 149008
		TopTagText,
		// Token: 0x04024611 RID: 149009
		SelectedItem,
		// Token: 0x04024612 RID: 149010
		DescriptionText,
		// Token: 0x04024613 RID: 149011
		HoldEffectItem,
		// Token: 0x04024614 RID: 149012
		KeyItem,
		// Token: 0x04024615 RID: 149013
		CdItem
	}
}
