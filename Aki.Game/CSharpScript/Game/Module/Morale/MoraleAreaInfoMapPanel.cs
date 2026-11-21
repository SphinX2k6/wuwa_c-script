using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Morale.Data;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x0200437D RID: 17277
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleAreaInfoMapPanel : UiPanelBase
	{
		// Token: 0x0602BA1B RID: 178715 RVA: 0x00C3FC7C File Offset: 0x00C3DE7C
		public UniTask Init(MoraleAreaData areaData, UUIItem parentItem)
		{
			MoraleAreaInfoMapPanel.<Init>d__6 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.areaData = areaData;
			<Init>d__.parentItem = parentItem;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleAreaInfoMapPanel.<Init>d__6>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA1C RID: 178716 RVA: 0x00C3FCD0 File Offset: 0x00C3DED0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602BA1D RID: 178717 RVA: 0x00C3FD5C File Offset: 0x00C3DF5C
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleAreaInfoMapPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleAreaInfoMapPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA1E RID: 178718 RVA: 0x00C3FD9F File Offset: 0x00C3DF9F
		public void UpdateData()
		{
			this.PlotPanel.UpdateData();
			this.UpdateFlagData();
		}

		// Token: 0x0602BA1F RID: 178719 RVA: 0x00C3FDB4 File Offset: 0x00C3DFB4
		public void UpdateFlagState()
		{
			foreach (MoraleAreaInfoFlagItem moraleAreaInfoFlagItem in this.FlagItemList)
			{
				moraleAreaInfoFlagItem.UpdateSelectState();
			}
		}

		// Token: 0x0602BA20 RID: 178720 RVA: 0x00C3FE04 File Offset: 0x00C3E004
		private void UpdateFlagData()
		{
			foreach (MoraleAreaInfoFlagItem moraleAreaInfoFlagItem in this.FlagItemList)
			{
				moraleAreaInfoFlagItem.UpdateData();
				MoraleAreaPlotItem moraleAreaPlotItem;
				if (this.PlotPanel.PlotMap.TryGetValue(moraleAreaInfoFlagItem.FlagData.Config.FlagPosPlotId, out moraleAreaPlotItem))
				{
					moraleAreaInfoFlagItem.UpdatePosition(moraleAreaPlotItem.GetRootItem());
				}
			}
		}

		// Token: 0x0602BA21 RID: 178721 RVA: 0x00C3FE88 File Offset: 0x00C3E088
		private void OnClickFlagItem(MoraleAreaFlagData flagData)
		{
			Action<MoraleAreaFlagData> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(flagData);
		}

		// Token: 0x0602BA22 RID: 178722 RVA: 0x00C3FE9C File Offset: 0x00C3E09C
		public void PlayStartSequence()
		{
			foreach (MoraleAreaInfoFlagItem moraleAreaInfoFlagItem in this.FlagItemList)
			{
				moraleAreaInfoFlagItem.PlayStartSequence();
			}
		}

		// Token: 0x0602BA23 RID: 178723 RVA: 0x00C3FEEC File Offset: 0x00C3E0EC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx([Nullable(new byte[]
		{
			2,
			1
		})] string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			if (configParams[0] == "BossFlag")
			{
				foreach (MoraleAreaInfoFlagItem moraleAreaInfoFlagItem in this.FlagItemList)
				{
					if (moraleAreaInfoFlagItem.FlagData.IsHighDifficultyChallenge())
					{
						UUIItem rootItem = moraleAreaInfoFlagItem.GetRootItem();
						UUIItem[] result;
						if (rootItem == null)
						{
							result = null;
						}
						else
						{
							UUIItem[] array = new UUIItem[2];
							array[0] = rootItem;
							result = array;
							array[1] = rootItem;
						}
						return result;
					}
				}
			}
			return null;
		}

		// Token: 0x040178B1 RID: 96433
		public MoraleAreaPlotPanel PlotPanel;

		// Token: 0x040178B2 RID: 96434
		public List<MoraleAreaInfoFlagItem> FlagItemList = new List<MoraleAreaInfoFlagItem>();

		// Token: 0x040178B3 RID: 96435
		public Dictionary<int, MoraleAreaInfoFlagItem> FlagItemMap = new Dictionary<int, MoraleAreaInfoFlagItem>();

		// Token: 0x040178B4 RID: 96436
		public MoraleAreaData AreaData;

		// Token: 0x040178B5 RID: 96437
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MoraleAreaFlagData> ClickCallback;

		// Token: 0x0200A03E RID: 41022
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04031C85 RID: 203909
			ItemBg,
			// Token: 0x04031C86 RID: 203910
			ItemAreaPlotPanel,
			// Token: 0x04031C87 RID: 203911
			ItemFlagRoot
		}
	}
}
