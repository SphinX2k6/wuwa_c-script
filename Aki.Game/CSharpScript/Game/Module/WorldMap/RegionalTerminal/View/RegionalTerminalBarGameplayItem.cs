using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal.View
{
	// Token: 0x02004855 RID: 18517
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RegionalTerminalBarGameplayItem : GridProxyAbstract<RegionalTerminalGameplayData>
	{
		// Token: 0x06030746 RID: 198470 RVA: 0x00B3FD84 File Offset: 0x00B3DF84
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06030747 RID: 198471 RVA: 0x00B3FE90 File Offset: 0x00B3E090
		[NullableContext(1)]
		public override void Refresh(RegionalTerminalGameplayData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			AreaTerminal? areaTerminalByGameplayId = RegionalTerminalConfig.Instance.GetAreaTerminalByGameplayId(this.Data.Id);
			if (areaTerminalByGameplayId == null)
			{
				return;
			}
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				UUIItem uuiitem = texture;
				bool lockState = data.GetLockState();
				FColor? fcolor = new FColor?(texture.changeColor);
				uuiitem.SetChangeColor(lockState, fcolor);
				base.SetTextureShowUntilLoaded(areaTerminalByGameplayId.Value.Icon, texture, null);
			}
			this.BindRedDot();
			this.RefreshFunctional();
		}

		// Token: 0x06030748 RID: 198472 RVA: 0x00B3FF0C File Offset: 0x00B3E10C
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x06030749 RID: 198473 RVA: 0x00B3FF14 File Offset: 0x00B3E114
		private void RefreshFunctional()
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(RegionalTerminalModel.Instance.IsGameplayPin(this.Data.Id));
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(this.Data.GetLockState());
			}
		}

		// Token: 0x0603074A RID: 198474 RVA: 0x00B3FF64 File Offset: 0x00B3E164
		private void BindRedDot()
		{
			this.UnBindRedDot();
			this.RedDotName = this.Data.GetRedDotName();
			this.RedDotId = this.Data.GetRedDotId();
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				if (this.RedDotName != null)
				{
					RedDotController.Instance.BindRedDot(this.RedDotName.Value, item, null, this.RedDotId);
					return;
				}
				item.SetUIActive(this.Data.GetRedDotState());
			}
		}

		// Token: 0x0603074B RID: 198475 RVA: 0x00B3FFE0 File Offset: 0x00B3E1E0
		private void UnBindRedDot()
		{
			if (this.RedDotName != null)
			{
				UUIItem item = base.GetItem(4);
				RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, item, this.RedDotId);
				this.RedDotId = 0;
				this.RedDotName = null;
			}
		}

		// Token: 0x0603074C RID: 198476 RVA: 0x00B40034 File Offset: 0x00B3E234
		private void OnClickButton()
		{
			this.Data.BarFunction();
			if (!this.Data.GetLockState())
			{
				AreaTerminalOpenActivityLogEvent areaTerminalOpenActivityLogEvent = new AreaTerminalOpenActivityLogEvent();
				areaTerminalOpenActivityLogEvent.i_id = this.Data.Id;
				areaTerminalOpenActivityLogEvent.i_type = 1;
				LogReportController.Instance.LogReport(areaTerminalOpenActivityLogEvent);
			}
		}

		// Token: 0x0401A08E RID: 106638
		[Nullable(2)]
		private RegionalTerminalGameplayData Data;

		// Token: 0x0401A08F RID: 106639
		private ERedDotName? RedDotName;

		// Token: 0x0401A090 RID: 106640
		private int RedDotId;

		// Token: 0x0200AB39 RID: 43833
		public static class EComponents
		{
			// Token: 0x0403407C RID: 213116
			public const int Button = 0;

			// Token: 0x0403407D RID: 213117
			public const int TexIcon = 1;

			// Token: 0x0403407E RID: 213118
			public const int ItemLock = 2;

			// Token: 0x0403407F RID: 213119
			public const int ItemPin = 3;

			// Token: 0x04034080 RID: 213120
			public const int ItemRedDot = 4;
		}
	}
}
