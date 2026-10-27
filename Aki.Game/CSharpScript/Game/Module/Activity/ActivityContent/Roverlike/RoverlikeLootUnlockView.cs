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
	// Token: 0x02006168 RID: 24936
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeLootUnlockView : UiViewBase
	{
		// Token: 0x170091B8 RID: 37304
		// (get) Token: 0x0603F07E RID: 258174 RVA: 0x00F3B04C File Offset: 0x00F3924C
		[Nullable(2)]
		private IRoverlikeLootUnlockViewOpenParam Param
		{
			[NullableContext(2)]
			get
			{
				return this.OpenParam as IRoverlikeLootUnlockViewOpenParam;
			}
		}

		// Token: 0x0603F07F RID: 258175 RVA: 0x00F3B059 File Offset: 0x00F39259
		public RoverlikeLootUnlockView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603F080 RID: 258176 RVA: 0x00F3B064 File Offset: 0x00F39264
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

		// Token: 0x0603F081 RID: 258177 RVA: 0x00F3B12C File Offset: 0x00F3932C
		protected override void OnStart()
		{
			IRoverlikeLootUnlockViewOpenParam param = this.Param;
			this.OnClosed = ((param != null) ? param.OnClosed : null);
			this.LootLayout = new GenericLayout<RoverlikeLootItem, RoverlikeLootGainEntry>(base.GetHorizontalLayout(1), new Func<RoverlikeLootItem>(this.CreateLootItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
			this.RefreshLootLayout();
		}

		// Token: 0x0603F082 RID: 258178 RVA: 0x00F3B188 File Offset: 0x00F39388
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

		// Token: 0x0603F083 RID: 258179 RVA: 0x00F3B1A4 File Offset: 0x00F393A4
		private void RefreshLootLayout()
		{
			List<RoverlikeLootGainEntry> data = this.BuildLootDataList();
			this.LootLayout.RefreshByData(data, null, true);
		}

		// Token: 0x0603F084 RID: 258180 RVA: 0x00F3B1C8 File Offset: 0x00F393C8
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

		// Token: 0x0603F085 RID: 258181 RVA: 0x00F3B244 File Offset: 0x00F39444
		private RoverlikeLootItem CreateLootItem()
		{
			return new RoverlikeLootItem();
		}

		// Token: 0x0603F086 RID: 258182 RVA: 0x00F3B24B File Offset: 0x00F3944B
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x04020E10 RID: 134672
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeLootItem, RoverlikeLootGainEntry> LootLayout;

		// Token: 0x04020E11 RID: 134673
		[Nullable(2)]
		private Action OnClosed;

		// Token: 0x0200C3CC RID: 50124
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B159 RID: 242009
			public const int BtnClose = 0;

			// Token: 0x0403B15A RID: 242010
			public const int PnlHor = 1;

			// Token: 0x0403B15B RID: 242011
			public const int LootItem = 2;
		}
	}
}
