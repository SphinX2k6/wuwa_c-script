using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004012 RID: 16402
	[NullableContext(1)]
	[Nullable(0)]
	public class EntitySequenceView : UiPanelBase
	{
		// Token: 0x06029836 RID: 170038 RVA: 0x00BB8188 File Offset: 0x00BB6388
		protected override UniTask OnCreateAsync()
		{
			EntitySequenceView.<OnCreateAsync>d__12 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<EntitySequenceView.<OnCreateAsync>d__12>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029837 RID: 170039 RVA: 0x00BB81CC File Offset: 0x00BB63CC
		protected override UniTask OnBeforeStartAsync()
		{
			EntitySequenceView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EntitySequenceView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029838 RID: 170040 RVA: 0x00BB820F File Offset: 0x00BB640F
		protected override void OnBeforeShow()
		{
			this.SetEntitySequenceInteractState(true);
			if (SequenceModel.Instance.IsPlaying)
			{
				this.Enable();
			}
		}

		// Token: 0x06029839 RID: 170041 RVA: 0x00BB822A File Offset: 0x00BB642A
		protected override void OnAfterHide()
		{
			this.SetEntitySequenceInteractState(false);
		}

		// Token: 0x0602983A RID: 170042 RVA: 0x00BB8234 File Offset: 0x00BB6434
		protected override void OnBeforeDestroy()
		{
			SequenceController.Instance.ClearAccelerateCallback();
			this.StopAccelerate();
			this.ScreenEffectCache = null;
			this.PostProcessCache = null;
			this.HandleActionBinding(false);
			this.SetEntitySequenceInteractState(false);
			this.Disable();
			if (this.ScreenEffectHandle != null)
			{
				ScreenEffectModel.Instance.EndScreenEffect(this.ScreenEffectHandle.Value);
			}
			if (this.PostProcessHandle != null)
			{
				EffectSystem.Instance.StopEffectById(this.PostProcessHandle.Value, "[EntitySequenceView.OnSkipButtonClick]", true, null);
			}
			EventSystem.Instance.Remove(EEventName.PlotSequenceStarted, new Action(this.Enable));
		}

		// Token: 0x0602983B RID: 170043 RVA: 0x00BB82E4 File Offset: 0x00BB64E4
		public UniTask OpenAsync(UUIItem parentItem)
		{
			EntitySequenceView.<OpenAsync>d__17 <OpenAsync>d__;
			<OpenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenAsync>d__.<>4__this = this;
			<OpenAsync>d__.parentItem = parentItem;
			<OpenAsync>d__.<>1__state = -1;
			<OpenAsync>d__.<>t__builder.Start<EntitySequenceView.<OpenAsync>d__17>(ref <OpenAsync>d__);
			return <OpenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602983C RID: 170044 RVA: 0x00BB8330 File Offset: 0x00BB6530
		public UniTask CloseAsync()
		{
			EntitySequenceView.<CloseAsync>d__18 <CloseAsync>d__;
			<CloseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseAsync>d__.<>4__this = this;
			<CloseAsync>d__.<>1__state = -1;
			<CloseAsync>d__.<>t__builder.Start<EntitySequenceView.<CloseAsync>d__18>(ref <CloseAsync>d__);
			return <CloseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602983D RID: 170045 RVA: 0x00BB8373 File Offset: 0x00BB6573
		public void SetParentUiItem(UUIItem parentItem)
		{
			base.GetRootItem().SetUIParent(parentItem, false);
		}

		// Token: 0x0602983E RID: 170046 RVA: 0x00BB8384 File Offset: 0x00BB6584
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnSkipButtonClickFromButton));
			this.BtnBindInfo = list2;
			if (!Info.Instance.IsInTouch())
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
			}
		}

		// Token: 0x0602983F RID: 170047 RVA: 0x00BB8451 File Offset: 0x00BB6651
		private void OnSkipButtonClickFromButton()
		{
			this.OnSkipButtonClickCore();
		}

		// Token: 0x06029840 RID: 170048 RVA: 0x00BB8459 File Offset: 0x00BB6659
		private void OnSkipButtonInput(string actionName, InputDistributeDefine.EActionType value, InputIdentification inputIdentification)
		{
			if (value == InputDistributeDefine.EActionType.Release)
			{
				return;
			}
			this.OnSkipButtonClickCore();
		}

		// Token: 0x06029841 RID: 170049 RVA: 0x00BB8468 File Offset: 0x00BB6668
		private void OnSkipButtonClickCore()
		{
			this.IsAccelerate = true;
			SequenceController.Instance.AccelerateToNextSubtitleOrChildSeq(new Action(this.StopAccelerate));
			if (!this.IsAccelerate)
			{
				return;
			}
			this.Disable();
			this.ScreenEffectHandle = new int?(ScreenEffectModel.Instance.PlayScreenEffect(PlotModel.Instance.PlotGlobalConfig.EntitySequenceScreenEffectPath, null, null));
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(Transform.Create().ToUeTransform());
			this.PostProcessHandle = new int?(instance.SpawnEffect(world, ftransformDouble, PlotModel.Instance.PlotGlobalConfig.EntitySequencePostEffectPath, "[EntitySequenceView.OnSkipButtonClick]", null, EEffectType.Scene, null, null, null, false, false));
			this.AudioHandle = new int?(AudioSystem.Instance.PostEvent(PlotModel.Instance.PlotGlobalConfig.EntitySequenceAudioEvent));
			AudioSystem.Instance.SetRtpcValue("global_seq_rate", PlotModel.Instance.PlotGlobalConfig.EntitySequenceAccelerateRate, null);
		}

		// Token: 0x06029842 RID: 170050 RVA: 0x00BB855C File Offset: 0x00BB675C
		private void StopAccelerate()
		{
			if (!this.IsAccelerate)
			{
				return;
			}
			this.IsAccelerate = false;
			this.Enable();
			int? num = this.ScreenEffectHandle;
			if (num != null && num.GetValueOrDefault() != 0)
			{
				ScreenEffectModel.Instance.EndScreenEffect(this.ScreenEffectHandle.Value);
				this.ScreenEffectHandle = null;
			}
			num = this.PostProcessHandle;
			if (num != null && num.GetValueOrDefault() != 0)
			{
				EffectSystem.Instance.StopEffectById(this.PostProcessHandle.Value, "[EntitySequenceView.OnSkipButtonClick]", true, null);
				this.PostProcessHandle = null;
			}
			num = this.AudioHandle;
			if (num != null)
			{
				AudioSystem.Instance.ExecuteAction(this.AudioHandle.Value, EAudioActionType.Stop, null);
				this.AudioHandle = null;
			}
			AudioSystem.Instance.SetRtpcValue("global_seq_rate", 1f, null);
		}

		// Token: 0x06029843 RID: 170051 RVA: 0x00BB865C File Offset: 0x00BB685C
		public void Enable()
		{
			EntityControlRuntimeOptions entityControlOptions = PlotModel.Instance.PlotConfig.EntityControlOptions;
			if (entityControlOptions != null && entityControlOptions.HideSkipButton)
			{
				return;
			}
			UUIButtonComponent button = base.GetButton(1);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(true);
			}
			this.HandleActionBinding(true);
		}

		// Token: 0x06029844 RID: 170052 RVA: 0x00BB86B0 File Offset: 0x00BB68B0
		public void Disable()
		{
			UUIButtonComponent button = base.GetButton(1);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			this.HandleActionBinding(false);
		}

		// Token: 0x06029845 RID: 170053 RVA: 0x00BB86E4 File Offset: 0x00BB68E4
		private bool OnCheckKey(string actionName, InputDistributeDefine.EActionType actionType)
		{
			return !(actionName == "地图") && !(actionName == "功能菜单");
		}

		// Token: 0x06029846 RID: 170054 RVA: 0x00BB8705 File Offset: 0x00BB6905
		public void RefreshActionBinding()
		{
			if (this.HasBindActionGamepad || this.HasBindActionOther)
			{
				this.HandleActionBinding(false);
				this.HandleActionBinding(true);
			}
		}

		// Token: 0x06029847 RID: 170055 RVA: 0x00BB8728 File Offset: 0x00BB6928
		private void SetEntitySequenceInteractState(bool active)
		{
			if (active && !PlotModel.Instance.EntitySequenceInteractTag)
			{
				PlotModel.Instance.EntitySequenceInteractTag = true;
				InputManager.Instance.RegisterLockShortcutKeyReason("实机剧情禁用快捷键", new TLockShortcutKeyDelegate(this.OnCheckKey));
				BattleUiModel.Instance.ChildViewData.HideBattleView(EBattleUiVisibleReason.UiControl, new EBattleUiChild[]
				{
					EBattleUiChild.Joystick,
					EBattleUiChild.ScreenEffect,
					EBattleUiChild.MiniMap,
					EBattleUiChild.ExitButton,
					EBattleUiChild.HomeButton
				}, 0);
				return;
			}
			if (!active && PlotModel.Instance.EntitySequenceInteractTag)
			{
				PlotModel.Instance.EntitySequenceInteractTag = false;
				InputManager.Instance.RemoveLockShortcutKeyReason("实机剧情禁用快捷键");
				BattleUiModel.Instance.ChildViewData.ShowBattleView(EBattleUiVisibleReason.UiControl, 0);
			}
		}

		// Token: 0x06029848 RID: 170056 RVA: 0x00BB87CC File Offset: 0x00BB69CC
		private void HandleActionBinding(bool bBind)
		{
			if (!bBind)
			{
				if (this.HasBindActionGamepad)
				{
					this.HasBindActionGamepad = false;
				}
				if (this.HasBindActionOther)
				{
					this.HasBindActionOther = false;
					InputDistributeController.Instance.UnBindActionIgnoreLimit("大招", new TInputHandle<InputDistributeDefine.EActionType>(this.OnSkipButtonInput));
					InputMultiKeyItem keyItem = this.KeyItem;
					if (keyItem == null)
					{
						return;
					}
					keyItem.Hide(null);
				}
				return;
			}
			if (Info.Instance.IsInGamepad())
			{
				if (this.HasBindActionGamepad)
				{
					return;
				}
				InputMultiKeyItem keyItem2 = this.KeyItem;
				if (keyItem2 != null)
				{
					keyItem2.Hide(null);
				}
				this.HasBindActionGamepad = true;
				return;
			}
			else
			{
				if (this.HasBindActionOther)
				{
					return;
				}
				InputDistributeController.Instance.BindActionIgnoreLimit("大招", new TInputHandle<InputDistributeDefine.EActionType>(this.OnSkipButtonInput));
				InputMultiKeyItem keyItem3 = this.KeyItem;
				if (keyItem3 != null)
				{
					keyItem3.RefreshByActionOrAxis(new InputActionOrAxisKeyItem
					{
						ActionOrAxisName = "大招"
					}, false);
				}
				InputMultiKeyItem keyItem4 = this.KeyItem;
				if (keyItem4 != null)
				{
					keyItem4.Show(null);
				}
				this.HasBindActionOther = true;
				return;
			}
		}

		// Token: 0x04016A84 RID: 92804
		private const string ENTITY_SEQUENCE_ACCELERATE_RATE_RTPC = "global_seq_rate";

		// Token: 0x04016A85 RID: 92805
		private const string BLOCK_KEY_REASON = "实机剧情禁用快捷键";

		// Token: 0x04016A86 RID: 92806
		[Nullable(2)]
		private EffectScreenPlayData_C ScreenEffectCache;

		// Token: 0x04016A87 RID: 92807
		[Nullable(2)]
		private EffectModelPostProcess PostProcessCache;

		// Token: 0x04016A88 RID: 92808
		private bool HasBindActionGamepad;

		// Token: 0x04016A89 RID: 92809
		private bool HasBindActionOther;

		// Token: 0x04016A8A RID: 92810
		[Nullable(2)]
		private InputMultiKeyItem KeyItem;

		// Token: 0x04016A8B RID: 92811
		private int? ScreenEffectHandle;

		// Token: 0x04016A8C RID: 92812
		private int? PostProcessHandle;

		// Token: 0x04016A8D RID: 92813
		private int? AudioHandle;

		// Token: 0x04016A8E RID: 92814
		private bool IsAccelerate;

		// Token: 0x02009BCF RID: 39887
		[NullableContext(0)]
		private enum EEntitySequenceView
		{
			// Token: 0x04030816 RID: 198678
			HotKey,
			// Token: 0x04030817 RID: 198679
			SkipButton,
			// Token: 0x04030818 RID: 198680
			HotKeyCombine
		}
	}
}
