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
	// Token: 0x02004EFE RID: 20222
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityInstanceEntranceScrollItem : UiPanelBase, IDynamicScrollItem<ActivityEntranceItemData>
	{
		// Token: 0x06032D1D RID: 208157 RVA: 0x00E44584 File Offset: 0x00E42784
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

		// Token: 0x06032D1E RID: 208158 RVA: 0x00E445D0 File Offset: 0x00E427D0
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

		// Token: 0x06032D1F RID: 208159 RVA: 0x00E4467C File Offset: 0x00E4287C
		private UniTask InitChildItem()
		{
			ActivityInstanceEntranceScrollItem.<InitChildItem>d__9 <InitChildItem>d__;
			<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitChildItem>d__.<>4__this = this;
			<InitChildItem>d__.<>1__state = -1;
			<InitChildItem>d__.<>t__builder.Start<ActivityInstanceEntranceScrollItem.<InitChildItem>d__9>(ref <InitChildItem>d__);
			return <InitChildItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032D20 RID: 208160 RVA: 0x00E446C0 File Offset: 0x00E428C0
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

		// Token: 0x06032D21 RID: 208161 RVA: 0x00E4471C File Offset: 0x00E4291C
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

		// Token: 0x06032D22 RID: 208162 RVA: 0x00E447E0 File Offset: 0x00E429E0
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x0401AFA5 RID: 110501
		protected ActivityEntranceItemData Data;

		// Token: 0x0401AFA6 RID: 110502
		private MainContentItem MainContentItem;

		// Token: 0x0401AFA7 RID: 110503
		private SubContentItem SubContentItem;

		// Token: 0x0401AFA8 RID: 110504
		private MainContentItem LockMainContentItem;

		// Token: 0x0401AFA9 RID: 110505
		private SubContentItem LockSubContentItem;

		// Token: 0x0401AFAA RID: 110506
		private UUIItem CurrentUsingItem;

		// Token: 0x0200AC59 RID: 44121
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04035517 RID: 218391
			InstanceSeriesItem,
			// Token: 0x04035518 RID: 218392
			InstanceItem,
			// Token: 0x04035519 RID: 218393
			LockInstanceSeriesItem,
			// Token: 0x0403551A RID: 218394
			LockInstanceItem
		}
	}
}
