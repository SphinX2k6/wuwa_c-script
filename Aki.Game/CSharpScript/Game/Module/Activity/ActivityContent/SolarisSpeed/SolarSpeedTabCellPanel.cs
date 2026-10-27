using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060CF RID: 24783
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class SolarSpeedTabCellPanel : GridProxyAbstract<ISolarSpeedTabCellPanelData>
	{
		// Token: 0x0603EA84 RID: 256644 RVA: 0x00F21F08 File Offset: 0x00F20108
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.HandleOnClickTab));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603EA85 RID: 256645 RVA: 0x00F21FF0 File Offset: 0x00F201F0
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSpeedTabCellPanel.<OnBeforeStartAsync>d__1 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSpeedTabCellPanel.<OnBeforeStartAsync>d__1>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EA86 RID: 256646 RVA: 0x00F22033 File Offset: 0x00F20233
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.CanExecuteChange.Unbind();
		}

		// Token: 0x0603EA87 RID: 256647 RVA: 0x00F2204B File Offset: 0x00F2024B
		public override void Refresh(ISolarSpeedTabCellPanelData data, bool isSelected, int gridIndex)
		{
			this.OpenParam = data;
			this.RefreshByOpenParam(data);
		}

		// Token: 0x0603EA88 RID: 256648 RVA: 0x00F2205C File Offset: 0x00F2025C
		private void RefreshByOpenParam(ISolarSpeedTabCellPanelData data)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(data.IsChosen ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			base.TrySetTextureByPath(data.RomeNumberPath, base.GetTexture(2), null, null);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), data.TitleTextId, Array.Empty<object>());
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(data.IsRedDot);
		}

		// Token: 0x0603EA89 RID: 256649 RVA: 0x00F220DC File Offset: 0x00F202DC
		private void HandleOnClickTab(EToggleState toggleState)
		{
			ISolarSpeedTabCellPanelData solarSpeedTabCellPanelData = this.OpenParam as ISolarSpeedTabCellPanelData;
			ActivitySolarSpeedController.Instance.SyncCurrentChosenLevelId(solarSpeedTabCellPanelData.LevelId);
			EventSystem.Instance.Emit<int>(EEventName.SolarSpeedClickRewardTab, solarSpeedTabCellPanelData.LevelId);
		}

		// Token: 0x0603EA8A RID: 256650 RVA: 0x00F2211B File Offset: 0x00F2031B
		private bool HandleCanExecuteChange()
		{
			return !(this.OpenParam as ISolarSpeedTabCellPanelData).IsChosen;
		}

		// Token: 0x0200C322 RID: 49954
		[NullableContext(0)]
		private class ETabCellComponent
		{
			// Token: 0x0403AEB6 RID: 241334
			public const int RootToggle = 0;

			// Token: 0x0403AEB7 RID: 241335
			public const int NameText = 1;

			// Token: 0x0403AEB8 RID: 241336
			public const int NumberTexture = 2;

			// Token: 0x0403AEB9 RID: 241337
			public const int RedDotItem = 3;
		}
	}
}
