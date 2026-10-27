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
	// Token: 0x02004AB5 RID: 19125
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelTargetPanel : UiPanelBase
	{
		// Token: 0x060318D6 RID: 202966 RVA: 0x00B7DA44 File Offset: 0x00B7BC44
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

		// Token: 0x060318D7 RID: 202967 RVA: 0x00B7DA8F File Offset: 0x00B7BC8F
		protected override void OnBeforeCreate()
		{
		}

		// Token: 0x060318D8 RID: 202968 RVA: 0x00B7DA94 File Offset: 0x00B7BC94
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

		// Token: 0x060318D9 RID: 202969 RVA: 0x00B7DB84 File Offset: 0x00B7BD84
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseLevelTargetPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseLevelTargetPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060318DA RID: 202970 RVA: 0x00B7DBC7 File Offset: 0x00B7BDC7
		protected override void OnStart()
		{
		}

		// Token: 0x060318DB RID: 202971 RVA: 0x00B7DBC9 File Offset: 0x00B7BDC9
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x060318DC RID: 202972 RVA: 0x00B7DBCB File Offset: 0x00B7BDCB
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x060318DD RID: 202973 RVA: 0x00B7DBCD File Offset: 0x00B7BDCD
		public void UpdateData(TrapDefenseLevelData data)
		{
			this.LevelData = data;
			this.LayoutTarget.RefreshByData(data.GetTargetInfoList(), null, false);
			this.PanelRewardInfo.UpdateData(data);
			this.PanelWaveInfo.UpdateData(data);
			this.PanelGoToInfo.UpdateData(data);
		}

		// Token: 0x060318DE RID: 202974 RVA: 0x00B7DC0D File Offset: 0x00B7BE0D
		public TrapDefenseLevelTargetItem CreateItemTarget()
		{
			return new TrapDefenseLevelTargetItem();
		}

		// Token: 0x0401A7AD RID: 108461
		public TrapDefenseLevelData LevelData;

		// Token: 0x0401A7AE RID: 108462
		public GenericLayout<TrapDefenseLevelTargetItem, ITrapDefenseLevelTargetItemData> LayoutTarget;

		// Token: 0x0401A7AF RID: 108463
		public TrapDefenseLevelRewardPanel PanelRewardInfo;

		// Token: 0x0401A7B0 RID: 108464
		public TrapDefenseLevelWavePanel PanelWaveInfo;

		// Token: 0x0401A7B1 RID: 108465
		public TrapDefenseLevelGoToPanel PanelGoToInfo;

		// Token: 0x0200AC19 RID: 44057
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040344B3 RID: 214195
			public const int LayoutTarget = 0;

			// Token: 0x040344B4 RID: 214196
			public const int ItemTarget = 1;

			// Token: 0x040344B5 RID: 214197
			public const int ItemRewardRoot = 2;

			// Token: 0x040344B6 RID: 214198
			public const int ItemRewardInfo = 3;

			// Token: 0x040344B7 RID: 214199
			public const int ItemWaveInfo = 4;

			// Token: 0x040344B8 RID: 214200
			public const int ItemGoTo = 5;
		}
	}
}
