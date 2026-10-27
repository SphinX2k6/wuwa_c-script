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
	// Token: 0x0200539A RID: 21402
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleAreaInfoMapPanel : UiPanelBase
	{
		// Token: 0x06036AD5 RID: 223957 RVA: 0x00CF0BD4 File Offset: 0x00CEEDD4
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

		// Token: 0x06036AD6 RID: 223958 RVA: 0x00CF0C28 File Offset: 0x00CEEE28
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

		// Token: 0x06036AD7 RID: 223959 RVA: 0x00CF0CB4 File Offset: 0x00CEEEB4
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleAreaInfoMapPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleAreaInfoMapPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036AD8 RID: 223960 RVA: 0x00CF0CF7 File Offset: 0x00CEEEF7
		public void UpdateData()
		{
			this.PlotPanel.UpdateData();
			this.UpdateFlagData();
		}

		// Token: 0x06036AD9 RID: 223961 RVA: 0x00CF0D0C File Offset: 0x00CEEF0C
		public void UpdateFlagState()
		{
			foreach (MoraleAreaInfoFlagItem moraleAreaInfoFlagItem in this.FlagItemList)
			{
				moraleAreaInfoFlagItem.UpdateSelectState();
			}
		}

		// Token: 0x06036ADA RID: 223962 RVA: 0x00CF0D5C File Offset: 0x00CEEF5C
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

		// Token: 0x06036ADB RID: 223963 RVA: 0x00CF0DE0 File Offset: 0x00CEEFE0
		private void OnClickFlagItem(MoraleAreaFlagData flagData)
		{
			Action<MoraleAreaFlagData> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(flagData);
		}

		// Token: 0x06036ADC RID: 223964 RVA: 0x00CF0DF4 File Offset: 0x00CEEFF4
		public void PlayStartSequence()
		{
			foreach (MoraleAreaInfoFlagItem moraleAreaInfoFlagItem in this.FlagItemList)
			{
				moraleAreaInfoFlagItem.PlayStartSequence();
			}
		}

		// Token: 0x06036ADD RID: 223965 RVA: 0x00CF0E44 File Offset: 0x00CEF044
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

		// Token: 0x0401CE19 RID: 118297
		public MoraleAreaPlotPanel PlotPanel;

		// Token: 0x0401CE1A RID: 118298
		public List<MoraleAreaInfoFlagItem> FlagItemList = new List<MoraleAreaInfoFlagItem>();

		// Token: 0x0401CE1B RID: 118299
		public Dictionary<int, MoraleAreaInfoFlagItem> FlagItemMap = new Dictionary<int, MoraleAreaInfoFlagItem>();

		// Token: 0x0401CE1C RID: 118300
		public MoraleAreaData AreaData;

		// Token: 0x0401CE1D RID: 118301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MoraleAreaFlagData> ClickCallback;

		// Token: 0x0200B606 RID: 46598
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04037230 RID: 225840
			ItemBg,
			// Token: 0x04037231 RID: 225841
			ItemAreaPlotPanel,
			// Token: 0x04037232 RID: 225842
			ItemFlagRoot
		}
	}
}
