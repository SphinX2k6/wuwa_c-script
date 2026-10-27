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
	// Token: 0x02005043 RID: 20547
	[NullableContext(1)]
	[Nullable(0)]
	public class EntitySequenceView : UiPanelBase
	{
		// Token: 0x0603495A RID: 215386 RVA: 0x00C6B0E8 File Offset: 0x00C692E8
		protected override UniTask OnCreateAsync()
		{
			EntitySequenceView.<OnCreateAsync>d__12 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<EntitySequenceView.<OnCreateAsync>d__12>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603495B RID: 215387 RVA: 0x00C6B12C File Offset: 0x00C6932C
		protected override UniTask OnBeforeStartAsync()
		{
			EntitySequenceView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EntitySequenceView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603495C RID: 215388 RVA: 0x00C6B16F File Offset: 0x00C6936F
		protected override void OnBeforeShow()
		{
			this.SetEntitySequenceInteractState(true);
			if (SequenceModel.Instance.IsPlaying)
			{
				this.Enable();
			}
		}

		// Token: 0x0603495D RID: 215389 RVA: 0x00C6B18A File Offset: 0x00C6938A
		protected override void OnAfterHide()
		{
			this.SetEntitySequenceInteractState(false);
		}

		// Token: 0x0603495E RID: 215390 RVA: 0x00C6B194 File Offset: 0x00C69394
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

		// Token: 0x0603495F RID: 215391 RVA: 0x00C6B244 File Offset: 0x00C69444
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

		// Token: 0x06034960 RID: 215392 RVA: 0x00C6B290 File Offset: 0x00C69490
		public UniTask CloseAsync()
		{
			EntitySequenceView.<CloseAsync>d__18 <CloseAsync>d__;
			<CloseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseAsync>d__.<>4__this = this;
			<CloseAsync>d__.<>1__state = -1;
			<CloseAsync>d__.<>t__builder.Start<EntitySequenceView.<CloseAsync>d__18>(ref <CloseAsync>d__);
			return <CloseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034961 RID: 215393 RVA: 0x00C6B2D3 File Offset: 0x00C694D3
		public void SetParentUiItem(UUIItem parentItem)
		{
			base.GetRootItem().SetUIParent(parentItem, false);
		}

		// Token: 0x06034962 RID: 215394 RVA: 0x00C6B2E4 File Offset: 0x00C694E4
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

		// Token: 0x06034963 RID: 215395 RVA: 0x00C6B3B1 File Offset: 0x00C695B1
		private void OnSkipButtonClickFromButton()
		{
			this.OnSkipButtonClickCore();
		}

		// Token: 0x06034964 RID: 215396 RVA: 0x00C6B3B9 File Offset: 0x00C695B9
		private void OnSkipButtonInput(string actionName, InputDistributeDefine.EActionType value, InputIdentification inputIdentification)
		{
			if (value == InputDistributeDefine.EActionType.Release)
			{
				return;
			}
			this.OnSkipButtonClickCore();
		}

		// Token: 0x06034965 RID: 215397 RVA: 0x00C6B3C8 File Offset: 0x00C695C8
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

		// Token: 0x06034966 RID: 215398 RVA: 0x00C6B4BC File Offset: 0x00C696BC
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

		// Token: 0x06034967 RID: 215399 RVA: 0x00C6B5BC File Offset: 0x00C697BC
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

		// Token: 0x06034968 RID: 215400 RVA: 0x00C6B610 File Offset: 0x00C69810
		public void Disable()
		{
			UUIButtonComponent button = base.GetButton(1);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			this.HandleActionBinding(false);
		}

		// Token: 0x06034969 RID: 215401 RVA: 0x00C6B644 File Offset: 0x00C69844
		private bool OnCheckKey(string actionName, InputDistributeDefine.EActionType actionType)
		{
			return !(actionName == "地图") && !(actionName == "功能菜单");
		}

		// Token: 0x0603496A RID: 215402 RVA: 0x00C6B665 File Offset: 0x00C69865
		public void RefreshActionBinding()
		{
			if (this.HasBindActionGamepad || this.HasBindActionOther)
			{
				this.HandleActionBinding(false);
				this.HandleActionBinding(true);
			}
		}

		// Token: 0x0603496B RID: 215403 RVA: 0x00C6B688 File Offset: 0x00C69888
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

		// Token: 0x0603496C RID: 215404 RVA: 0x00C6B72C File Offset: 0x00C6992C
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

		// Token: 0x0401C061 RID: 114785
		private const string ENTITY_SEQUENCE_ACCELERATE_RATE_RTPC = "global_seq_rate";

		// Token: 0x0401C062 RID: 114786
		private const string BLOCK_KEY_REASON = "实机剧情禁用快捷键";

		// Token: 0x0401C063 RID: 114787
		[Nullable(2)]
		private EffectScreenPlayData_C ScreenEffectCache;

		// Token: 0x0401C064 RID: 114788
		[Nullable(2)]
		private EffectModelPostProcess PostProcessCache;

		// Token: 0x0401C065 RID: 114789
		private bool HasBindActionGamepad;

		// Token: 0x0401C066 RID: 114790
		private bool HasBindActionOther;

		// Token: 0x0401C067 RID: 114791
		[Nullable(2)]
		private InputMultiKeyItem KeyItem;

		// Token: 0x0401C068 RID: 114792
		private int? ScreenEffectHandle;

		// Token: 0x0401C069 RID: 114793
		private int? PostProcessHandle;

		// Token: 0x0401C06A RID: 114794
		private int? AudioHandle;

		// Token: 0x0401C06B RID: 114795
		private bool IsAccelerate;

		// Token: 0x0200B195 RID: 45461
		[NullableContext(0)]
		private enum EEntitySequenceView
		{
			// Token: 0x04035DC1 RID: 220609
			HotKey,
			// Token: 0x04035DC2 RID: 220610
			SkipButton,
			// Token: 0x04035DC3 RID: 220611
			HotKeyCombine
		}
	}
}
