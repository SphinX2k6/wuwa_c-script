using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F17 RID: 24343
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityInstanceEntranceScrollItem : UiPanelBase, IDynamicScrollItem<ActivityEntranceItemData>
	{
		// Token: 0x0603DD82 RID: 253314 RVA: 0x00EF287C File Offset: 0x00EF0A7C
		[NullableContext(1)]
		public UniTask Init(UUIItem actor)
		{
			ActivityInstanceEntranceScrollItem.<Init>d__7 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<ActivityInstanceEntranceScrollItem.<Init>d__7>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603DD83 RID: 253315 RVA: 0x00EF28C8 File Offset: 0x00EF0AC8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603DD84 RID: 253316 RVA: 0x00EF2974 File Offset: 0x00EF0B74
		private UniTask InitChildItem()
		{
			ActivityInstanceEntranceScrollItem.<InitChildItem>d__9 <InitChildItem>d__;
			<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitChildItem>d__.<>4__this = this;
			<InitChildItem>d__.<>1__state = -1;
			<InitChildItem>d__.<>t__builder.Start<ActivityInstanceEntranceScrollItem.<InitChildItem>d__9>(ref <InitChildItem>d__);
			return <InitChildItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603DD85 RID: 253317 RVA: 0x00EF29B8 File Offset: 0x00EF0BB8
		[NullableContext(1)]
		public AUIBaseActor GetUsingItem(ActivityEntranceItemData data)
		{
			bool flag = !data.GetLockState();
			if (data.GetStyle() == 0)
			{
				return (flag ? base.GetItem(0) : base.GetItem(2)).GetOwner() as AUIBaseActor;
			}
			return (flag ? base.GetItem(1) : base.GetItem(3)).GetOwner() as AUIBaseActor;
		}

		// Token: 0x0603DD86 RID: 253318 RVA: 0x00EF2A14 File Offset: 0x00EF0C14
		[NullableContext(1)]
		public void Update(ActivityEntranceItemData data, int index)
		{
			this.Data = data;
			bool flag = !data.GetLockState();
			int style = data.GetStyle();
			if (style == 0)
			{
				if (flag)
				{
					this.MainContentItem.RefreshView(data);
				}
				else
				{
					this.LockMainContentItem.RefreshView(data);
				}
			}
			else if (flag)
			{
				this.SubContentItem.RefreshView(data);
			}
			else
			{
				this.LockSubContentItem.RefreshView(data);
			}
			UUIItem uuiitem;
			if (style == 0)
			{
				uuiitem = (flag ? base.GetItem(0) : base.GetItem(2));
			}
			else
			{
				uuiitem = (flag ? base.GetItem(1) : base.GetItem(3));
			}
			if (this.CurrentUsingItem != uuiitem)
			{
				UUIItem currentUsingItem = this.CurrentUsingItem;
				if (currentUsingItem != null)
				{
					currentUsingItem.SetUIActive(false);
				}
			}
			this.CurrentUsingItem = uuiitem;
			UUIItem currentUsingItem2 = this.CurrentUsingItem;
			if (currentUsingItem2 == null)
			{
				return;
			}
			currentUsingItem2.SetUIActive(true);
		}

		// Token: 0x0603DD87 RID: 253319 RVA: 0x00EF2AD8 File Offset: 0x00EF0CD8
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x040204D3 RID: 132307
		protected ActivityEntranceItemData Data;

		// Token: 0x040204D4 RID: 132308
		private MainContentItem MainContentItem;

		// Token: 0x040204D5 RID: 132309
		private SubContentItem SubContentItem;

		// Token: 0x040204D6 RID: 132310
		private MainContentItem LockMainContentItem;

		// Token: 0x040204D7 RID: 132311
		private SubContentItem LockSubContentItem;

		// Token: 0x040204D8 RID: 132312
		private UUIItem CurrentUsingItem;

		// Token: 0x0200C24C RID: 49740
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403AB25 RID: 240421
			InstanceSeriesItem,
			// Token: 0x0403AB26 RID: 240422
			InstanceItem,
			// Token: 0x0403AB27 RID: 240423
			LockInstanceSeriesItem,
			// Token: 0x0403AB28 RID: 240424
			LockInstanceItem
		}
	}
}
