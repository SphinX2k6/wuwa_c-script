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
	// Token: 0x0200504D RID: 20557
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class SolarSpeedTabCellPanel : GridProxyAbstract<ISolarSpeedTabCellPanelData>
	{
		// Token: 0x06033748 RID: 210760 RVA: 0x00E68CD8 File Offset: 0x00E66ED8
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

		// Token: 0x06033749 RID: 210761 RVA: 0x00E68DC0 File Offset: 0x00E66FC0
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSpeedTabCellPanel.<OnBeforeStartAsync>d__1 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSpeedTabCellPanel.<OnBeforeStartAsync>d__1>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603374A RID: 210762 RVA: 0x00E68E03 File Offset: 0x00E67003
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.CanExecuteChange.Unbind();
		}

		// Token: 0x0603374B RID: 210763 RVA: 0x00E68E1B File Offset: 0x00E6701B
		public override void Refresh(ISolarSpeedTabCellPanelData data, bool isSelected, int gridIndex)
		{
			this.OpenParam = data;
			this.RefreshByOpenParam(data);
		}

		// Token: 0x0603374C RID: 210764 RVA: 0x00E68E2C File Offset: 0x00E6702C
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

		// Token: 0x0603374D RID: 210765 RVA: 0x00E68EAC File Offset: 0x00E670AC
		private void HandleOnClickTab(EToggleState toggleState)
		{
			ISolarSpeedTabCellPanelData solarSpeedTabCellPanelData = this.OpenParam as ISolarSpeedTabCellPanelData;
			ActivitySolarSpeedController.Instance.SyncCurrentChosenLevelId(solarSpeedTabCellPanelData.LevelId);
			EventSystem.Instance.Emit<int>(EEventName.SolarSpeedClickRewardTab, solarSpeedTabCellPanelData.LevelId);
		}

		// Token: 0x0603374E RID: 210766 RVA: 0x00E68EEB File Offset: 0x00E670EB
		private bool HandleCanExecuteChange()
		{
			return !(this.OpenParam as ISolarSpeedTabCellPanelData).IsChosen;
		}

		// Token: 0x0200AD0D RID: 44301
		[NullableContext(0)]
		private class ETabCellComponent
		{
			// Token: 0x0403581E RID: 219166
			public const int RootToggle = 0;

			// Token: 0x0403581F RID: 219167
			public const int NameText = 1;

			// Token: 0x04035820 RID: 219168
			public const int NumberTexture = 2;

			// Token: 0x04035821 RID: 219169
			public const int RedDotItem = 3;
		}
	}
}
