using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050E6 RID: 20710
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeLootUnlockView : UiViewBase
	{
		// Token: 0x1700651A RID: 25882
		// (get) Token: 0x06033D3E RID: 212286 RVA: 0x00E81F20 File Offset: 0x00E80120
		[Nullable(2)]
		private IRoverlikeLootUnlockViewOpenParam Param
		{
			[NullableContext(2)]
			get
			{
				return this.OpenParam as IRoverlikeLootUnlockViewOpenParam;
			}
		}

		// Token: 0x06033D3F RID: 212287 RVA: 0x00E81F2D File Offset: 0x00E8012D
		public RoverlikeLootUnlockView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033D40 RID: 212288 RVA: 0x00E81F38 File Offset: 0x00E80138
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033D41 RID: 212289 RVA: 0x00E82000 File Offset: 0x00E80200
		protected override void OnStart()
		{
			IRoverlikeLootUnlockViewOpenParam param = this.Param;
			this.OnClosed = ((param != null) ? param.OnClosed : null);
			this.LootLayout = new GenericLayout<RoverlikeLootItem, RoverlikeLootGainEntry>(base.GetHorizontalLayout(1), new Func<RoverlikeLootItem>(this.CreateLootItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
			this.RefreshLootLayout();
		}

		// Token: 0x06033D42 RID: 212290 RVA: 0x00E8205C File Offset: 0x00E8025C
		protected override void OnBeforeDestroy()
		{
			Action onClosed = this.OnClosed;
			this.OnClosed = null;
			if (onClosed == null)
			{
				return;
			}
			onClosed();
		}

		// Token: 0x06033D43 RID: 212291 RVA: 0x00E82078 File Offset: 0x00E80278
		private void RefreshLootLayout()
		{
			List<RoverlikeLootGainEntry> data = this.BuildLootDataList();
			this.LootLayout.RefreshByData(data, null, true);
		}

		// Token: 0x06033D44 RID: 212292 RVA: 0x00E8209C File Offset: 0x00E8029C
		private List<RoverlikeLootGainEntry> BuildLootDataList()
		{
			IRoverlikeLootUnlockViewOpenParam param = this.Param;
			List<RoverRogueGainEntry> list = ((param != null) ? param.Loots : null) ?? new List<RoverRogueGainEntry>();
			List<RoverlikeLootGainEntry> list2 = new List<RoverlikeLootGainEntry>();
			foreach (RoverRogueGainEntry proto in list)
			{
				list2.Add(new RoverlikeLootGainEntry(proto)
				{
					Unlock = true
				});
			}
			return list2;
		}

		// Token: 0x06033D45 RID: 212293 RVA: 0x00E82118 File Offset: 0x00E80318
		private RoverlikeLootItem CreateLootItem()
		{
			return new RoverlikeLootItem();
		}

		// Token: 0x06033D46 RID: 212294 RVA: 0x00E8211F File Offset: 0x00E8031F
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401B73D RID: 112445
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeLootItem, RoverlikeLootGainEntry> LootLayout;

		// Token: 0x0401B73E RID: 112446
		[Nullable(2)]
		private Action OnClosed;

		// Token: 0x0200ADB3 RID: 44467
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035ABA RID: 219834
			public const int BtnClose = 0;

			// Token: 0x04035ABB RID: 219835
			public const int PnlHor = 1;

			// Token: 0x04035ABC RID: 219836
			public const int LootItem = 2;
		}
	}
}
