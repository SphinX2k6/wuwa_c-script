using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A5D RID: 14941
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelTargetPanel : UiPanelBase
	{
		// Token: 0x06026666 RID: 157286 RVA: 0x00AC19F8 File Offset: 0x00ABFBF8
		public UniTask Init(UUIItem item)
		{
			TrapDefenseLevelTargetPanel.<Init>d__6 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<TrapDefenseLevelTargetPanel.<Init>d__6>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06026667 RID: 157287 RVA: 0x00AC1A43 File Offset: 0x00ABFC43
		protected override void OnBeforeCreate()
		{
		}

		// Token: 0x06026668 RID: 157288 RVA: 0x00AC1A48 File Offset: 0x00ABFC48
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026669 RID: 157289 RVA: 0x00AC1B38 File Offset: 0x00ABFD38
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseLevelTargetPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseLevelTargetPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602666A RID: 157290 RVA: 0x00AC1B7B File Offset: 0x00ABFD7B
		protected override void OnStart()
		{
		}

		// Token: 0x0602666B RID: 157291 RVA: 0x00AC1B7D File Offset: 0x00ABFD7D
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x0602666C RID: 157292 RVA: 0x00AC1B7F File Offset: 0x00ABFD7F
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0602666D RID: 157293 RVA: 0x00AC1B81 File Offset: 0x00ABFD81
		public void UpdateData(TrapDefenseLevelData data)
		{
			this.LevelData = data;
			this.LayoutTarget.RefreshByData(data.GetTargetInfoList(), null, false);
			this.PanelRewardInfo.UpdateData(data);
			this.PanelWaveInfo.UpdateData(data);
			this.PanelGoToInfo.UpdateData(data);
		}

		// Token: 0x0602666E RID: 157294 RVA: 0x00AC1BC1 File Offset: 0x00ABFDC1
		public TrapDefenseLevelTargetItem CreateItemTarget()
		{
			return new TrapDefenseLevelTargetItem();
		}

		// Token: 0x040150FF RID: 86271
		public TrapDefenseLevelData LevelData;

		// Token: 0x04015100 RID: 86272
		public GenericLayout<TrapDefenseLevelTargetItem, ITrapDefenseLevelTargetItemData> LayoutTarget;

		// Token: 0x04015101 RID: 86273
		public TrapDefenseLevelRewardPanel PanelRewardInfo;

		// Token: 0x04015102 RID: 86274
		public TrapDefenseLevelWavePanel PanelWaveInfo;

		// Token: 0x04015103 RID: 86275
		public TrapDefenseLevelGoToPanel PanelGoToInfo;

		// Token: 0x02009639 RID: 38457
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EE64 RID: 192100
			public const int LayoutTarget = 0;

			// Token: 0x0402EE65 RID: 192101
			public const int ItemTarget = 1;

			// Token: 0x0402EE66 RID: 192102
			public const int ItemRewardRoot = 2;

			// Token: 0x0402EE67 RID: 192103
			public const int ItemRewardInfo = 3;

			// Token: 0x0402EE68 RID: 192104
			public const int ItemWaveInfo = 4;

			// Token: 0x0402EE69 RID: 192105
			public const int ItemGoTo = 5;
		}
	}
}
