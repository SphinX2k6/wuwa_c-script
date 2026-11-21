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
	// Token: 0x02003786 RID: 14214
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RegionalTerminalBarGameplayItem : GridProxyAbstract<RegionalTerminalGameplayData>
	{
		// Token: 0x06024F15 RID: 151317 RVA: 0x00A6FFC8 File Offset: 0x00A6E1C8
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

		// Token: 0x06024F16 RID: 151318 RVA: 0x00A700D4 File Offset: 0x00A6E2D4
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

		// Token: 0x06024F17 RID: 151319 RVA: 0x00A70150 File Offset: 0x00A6E350
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x06024F18 RID: 151320 RVA: 0x00A70158 File Offset: 0x00A6E358
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

		// Token: 0x06024F19 RID: 151321 RVA: 0x00A701A8 File Offset: 0x00A6E3A8
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

		// Token: 0x06024F1A RID: 151322 RVA: 0x00A70224 File Offset: 0x00A6E424
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

		// Token: 0x06024F1B RID: 151323 RVA: 0x00A70278 File Offset: 0x00A6E478
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

		// Token: 0x04014742 RID: 83778
		[Nullable(2)]
		private RegionalTerminalGameplayData Data;

		// Token: 0x04014743 RID: 83779
		private ERedDotName? RedDotName;

		// Token: 0x04014744 RID: 83780
		private int RedDotId;

		// Token: 0x020094E7 RID: 38119
		public static class EComponents
		{
			// Token: 0x0402E7F4 RID: 190452
			public const int Button = 0;

			// Token: 0x0402E7F5 RID: 190453
			public const int TexIcon = 1;

			// Token: 0x0402E7F6 RID: 190454
			public const int ItemLock = 2;

			// Token: 0x0402E7F7 RID: 190455
			public const int ItemPin = 3;

			// Token: 0x0402E7F8 RID: 190456
			public const int ItemRedDot = 4;
		}
	}
}
