using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x02003852 RID: 14418
	[NullableContext(1)]
	[Nullable(0)]
	public class LoopAutoScrollView<TItem, [Nullable(2)] TData> where TItem : class, ILoopAutoScrollItem<TData>
	{
		// Token: 0x06025742 RID: 153410 RVA: 0x00A8CEE4 File Offset: 0x00A8B0E4
		public LoopAutoScrollView(UUIItem viewport, UUIItem templateItem, UUIItem parent, Func<TItem> createFunction, bool isHorizontal = true)
		{
			this.Viewport = viewport;
			this.TemplateItem = templateItem;
			this.TemplateItem.SetUIActive(false);
			this.Parent = parent;
			this.CreateFunction = createFunction;
			this.Horizontal = isHorizontal;
		}

		// Token: 0x06025743 RID: 153411 RVA: 0x00A8CF60 File Offset: 0x00A8B160
		public UniTask ReloadItems(IReadOnlyList<TData> data)
		{
			LoopAutoScrollView<TItem, TData>.<ReloadItems>d__17 <ReloadItems>d__;
			<ReloadItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ReloadItems>d__.<>4__this = this;
			<ReloadItems>d__.data = data;
			<ReloadItems>d__.<>1__state = -1;
			<ReloadItems>d__.<>t__builder.Start<LoopAutoScrollView<TItem, TData>.<ReloadItems>d__17>(ref <ReloadItems>d__);
			return <ReloadItems>d__.<>t__builder.Task;
		}

		// Token: 0x06025744 RID: 153412 RVA: 0x00A8CFAB File Offset: 0x00A8B1AB
		public void StartAutoScroll(float speed)
		{
			this.Speed = speed;
			this.StopAutoScroll();
			this.IsRunning = true;
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.OnTick), "LoopAutoScrollView", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
		}

		// Token: 0x06025745 RID: 153413 RVA: 0x00A8CFEB File Offset: 0x00A8B1EB
		public void StopAutoScroll()
		{
			this.IsRunning = false;
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
				this.TickId = -1;
			}
		}

		// Token: 0x06025746 RID: 153414 RVA: 0x00A8D015 File Offset: 0x00A8B215
		private int CalcTotalItemCount()
		{
			return (int)Math.Ceiling((double)(this.Horizontal ? this.Viewport.GetWidth() : this.Viewport.GetHeight()) / (double)this.ItemLength) + this.BufferCount;
		}

		// Token: 0x06025747 RID: 153415 RVA: 0x00A8D050 File Offset: 0x00A8B250
		private void OnTick(float deltaTime)
		{
			if (!this.IsRunning || this.Speed == 0f || this.ActiveItems.Count <= 0)
			{
				return;
			}
			float num = -(this.Speed * deltaTime);
			foreach (TItem titem in this.ActiveItems)
			{
				UUIItem rootItem = titem.GetRootItem();
				if (this.Horizontal)
				{
					rootItem.SetAnchorOffsetX(rootItem.GetAnchorOffsetX() + num);
				}
				else
				{
					rootItem.SetAnchorOffsetY(rootItem.GetAnchorOffsetY() + num);
				}
			}
			this.AccumulatedOffset += num;
			if (Math.Abs(this.AccumulatedOffset) >= this.ItemLength)
			{
				int num2 = (int)Math.Floor((double)(Math.Abs(this.AccumulatedOffset) / this.ItemLength));
				bool flag = this.AccumulatedOffset < 0f;
				for (int i = 0; i < num2; i++)
				{
					this.Recycle(flag);
				}
				float num3 = (float)((flag ? -1 : 1) * num2) * this.ItemLength;
				this.AccumulatedOffset -= num3;
			}
		}

		// Token: 0x06025748 RID: 153416 RVA: 0x00A8D180 File Offset: 0x00A8B380
		private void Recycle(bool isForward)
		{
			if (this.TotalItemCount <= 0 || this.ActiveItems.Count <= 0 || this.Data.Count <= 0)
			{
				return;
			}
			int count = this.Data.Count;
			TItem titem = default(TItem);
			int index;
			if (isForward)
			{
				titem = this.ActiveItems[0];
				this.ActiveItems.RemoveAt(0);
				this.WindowStartIndex = (this.WindowStartIndex + 1) % count;
				index = (this.WindowStartIndex + this.TotalItemCount - this.BufferCount) % count;
				List<TItem> activeItems = this.ActiveItems;
				UUIItem rootItem = activeItems[activeItems.Count - 1].GetRootItem();
				UUIItem rootItem2 = titem.GetRootItem();
				if (this.Horizontal)
				{
					rootItem2.SetAnchorOffsetX(rootItem.GetAnchorOffsetX() + this.ItemLength);
				}
				else
				{
					rootItem2.SetAnchorOffsetY(rootItem.GetAnchorOffsetY() + this.ItemLength);
				}
				this.ActiveItems.Add(titem);
			}
			else
			{
				List<TItem> activeItems2 = this.ActiveItems;
				titem = activeItems2[activeItems2.Count - 1];
				this.ActiveItems.RemoveAt(this.ActiveItems.Count - 1);
				this.WindowStartIndex = (this.WindowStartIndex - 1 + count) % count;
				index = this.WindowStartIndex;
				UUIItem rootItem3 = this.ActiveItems[0].GetRootItem();
				UUIItem rootItem4 = titem.GetRootItem();
				if (this.Horizontal)
				{
					rootItem4.SetAnchorOffsetX(rootItem3.GetAnchorOffsetX() - this.ItemLength);
				}
				else
				{
					rootItem4.SetAnchorOffsetY(rootItem3.GetAnchorOffsetY() - this.ItemLength);
				}
				this.ActiveItems.Insert(0, titem);
			}
			TItem titem2 = titem;
			if (titem2 == null)
			{
				return;
			}
			titem2.Refresh(this.Data[index]);
		}

		// Token: 0x04014B53 RID: 84819
		protected bool Horizontal = true;

		// Token: 0x04014B54 RID: 84820
		private readonly UUIItem Viewport;

		// Token: 0x04014B55 RID: 84821
		private readonly UUIItem TemplateItem;

		// Token: 0x04014B56 RID: 84822
		private IReadOnlyList<TData> Data = Array.Empty<TData>();

		// Token: 0x04014B57 RID: 84823
		private readonly List<TItem> Items = new List<TItem>();

		// Token: 0x04014B58 RID: 84824
		private readonly List<TItem> ActiveItems = new List<TItem>();

		// Token: 0x04014B59 RID: 84825
		private float Speed;

		// Token: 0x04014B5A RID: 84826
		private readonly int BufferCount = 2;

		// Token: 0x04014B5B RID: 84827
		private bool IsRunning;

		// Token: 0x04014B5C RID: 84828
		protected float ItemLength;

		// Token: 0x04014B5D RID: 84829
		private int WindowStartIndex;

		// Token: 0x04014B5E RID: 84830
		private float AccumulatedOffset;

		// Token: 0x04014B5F RID: 84831
		private int TickId = -1;

		// Token: 0x04014B60 RID: 84832
		private readonly Func<TItem> CreateFunction;

		// Token: 0x04014B61 RID: 84833
		private int TotalItemCount;

		// Token: 0x04014B62 RID: 84834
		private readonly UUIItem Parent;
	}
}
