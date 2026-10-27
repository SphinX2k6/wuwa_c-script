using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048DB RID: 18651
	[NullableContext(1)]
	[Nullable(0)]
	public class LoopAutoScrollView<TItem, [Nullable(2)] TData> where TItem : class, ILoopAutoScrollItem<TData>
	{
		// Token: 0x06030C15 RID: 199701 RVA: 0x00B52074 File Offset: 0x00B50274
		public LoopAutoScrollView(UUIItem viewport, UUIItem templateItem, UUIItem parent, Func<TItem> createFunction, bool isHorizontal = true)
		{
			this.Viewport = viewport;
			this.TemplateItem = templateItem;
			this.TemplateItem.SetUIActive(false);
			this.Parent = parent;
			this.CreateFunction = createFunction;
			this.Horizontal = isHorizontal;
		}

		// Token: 0x06030C16 RID: 199702 RVA: 0x00B520F0 File Offset: 0x00B502F0
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

		// Token: 0x06030C17 RID: 199703 RVA: 0x00B5213B File Offset: 0x00B5033B
		public void StartAutoScroll(float speed)
		{
			this.Speed = speed;
			this.StopAutoScroll();
			this.IsRunning = true;
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.OnTick), "LoopAutoScrollView", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
		}

		// Token: 0x06030C18 RID: 199704 RVA: 0x00B5217B File Offset: 0x00B5037B
		public void StopAutoScroll()
		{
			this.IsRunning = false;
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
				this.TickId = -1;
			}
		}

		// Token: 0x06030C19 RID: 199705 RVA: 0x00B521A5 File Offset: 0x00B503A5
		private int CalcTotalItemCount()
		{
			return (int)Math.Ceiling((double)(this.Horizontal ? this.Viewport.GetWidth() : this.Viewport.GetHeight()) / (double)this.ItemLength) + this.BufferCount;
		}

		// Token: 0x06030C1A RID: 199706 RVA: 0x00B521E0 File Offset: 0x00B503E0
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

		// Token: 0x06030C1B RID: 199707 RVA: 0x00B52310 File Offset: 0x00B50510
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

		// Token: 0x0401A2E0 RID: 107232
		protected bool Horizontal = true;

		// Token: 0x0401A2E1 RID: 107233
		private readonly UUIItem Viewport;

		// Token: 0x0401A2E2 RID: 107234
		private readonly UUIItem TemplateItem;

		// Token: 0x0401A2E3 RID: 107235
		private IReadOnlyList<TData> Data = Array.Empty<TData>();

		// Token: 0x0401A2E4 RID: 107236
		private readonly List<TItem> Items = new List<TItem>();

		// Token: 0x0401A2E5 RID: 107237
		private readonly List<TItem> ActiveItems = new List<TItem>();

		// Token: 0x0401A2E6 RID: 107238
		private float Speed;

		// Token: 0x0401A2E7 RID: 107239
		private readonly int BufferCount = 2;

		// Token: 0x0401A2E8 RID: 107240
		private bool IsRunning;

		// Token: 0x0401A2E9 RID: 107241
		protected float ItemLength;

		// Token: 0x0401A2EA RID: 107242
		private int WindowStartIndex;

		// Token: 0x0401A2EB RID: 107243
		private float AccumulatedOffset;

		// Token: 0x0401A2EC RID: 107244
		private int TickId = -1;

		// Token: 0x0401A2ED RID: 107245
		private readonly Func<TItem> CreateFunction;

		// Token: 0x0401A2EE RID: 107246
		private int TotalItemCount;

		// Token: 0x0401A2EF RID: 107247
		private readonly UUIItem Parent;
	}
}
