using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006119 RID: 24857
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class RoverlikeMultiUseGridProxyAbstract<[Nullable(2)] TData> : UiPanelBase, IGridProxy<TData>, ISyncGridProxy<TData>, ISyncGridProxy
	{
		// Token: 0x17009183 RID: 37251
		// (get) Token: 0x0603ED96 RID: 257430 RVA: 0x00F2E128 File Offset: 0x00F2C328
		// (set) Token: 0x0603ED97 RID: 257431 RVA: 0x00F2E130 File Offset: 0x00F2C330
		public int GridIndex { get; set; }

		// Token: 0x17009184 RID: 37252
		// (get) Token: 0x0603ED98 RID: 257432 RVA: 0x00F2E139 File Offset: 0x00F2C339
		// (set) Token: 0x0603ED99 RID: 257433 RVA: 0x00F2E141 File Offset: 0x00F2C341
		public int DisplayIndex { get; set; }

		// Token: 0x17009185 RID: 37253
		// (get) Token: 0x0603ED9A RID: 257434 RVA: 0x00F2E14A File Offset: 0x00F2C34A
		// (set) Token: 0x0603ED9B RID: 257435 RVA: 0x00F2E152 File Offset: 0x00F2C352
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		IScrollViewDelegate<IGridProxy<TData>, TData> IGridProxy<!0>.ScrollViewDelegate
		{
			[return: Nullable(new byte[]
			{
				2,
				1,
				1,
				1
			})]
			get
			{
				return this.ScrollViewDelegate;
			}
			[param: Nullable(new byte[]
			{
				2,
				1,
				1,
				1
			})]
			set
			{
				this.ScrollViewDelegate = (value as ScrollViewDelegate<IGridProxy<TData>, TData>);
			}
		}

		// Token: 0x0603ED9C RID: 257436 RVA: 0x00F2E160 File Offset: 0x00F2C360
		public virtual void Refresh(TData data, bool isSelected, int gridIndex)
		{
		}

		// Token: 0x0603ED9D RID: 257437 RVA: 0x00F2E162 File Offset: 0x00F2C362
		public virtual void Refresh(TData data)
		{
			this.Refresh(data, false, this.GridIndex);
		}

		// Token: 0x0603ED9E RID: 257438 RVA: 0x00F2E174 File Offset: 0x00F2C374
		void ISyncGridProxy.Refresh(object data)
		{
			if (data is TData)
			{
				TData data2 = (TData)((object)data);
				this.Refresh(data2);
			}
		}

		// Token: 0x0603ED9F RID: 257439 RVA: 0x00F2E197 File Offset: 0x00F2C397
		public virtual void Clear()
		{
		}

		// Token: 0x0603EDA0 RID: 257440 RVA: 0x00F2E199 File Offset: 0x00F2C399
		public virtual void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0603EDA1 RID: 257441 RVA: 0x00F2E19B File Offset: 0x00F2C39B
		public virtual void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0603EDA2 RID: 257442 RVA: 0x00F2E19D File Offset: 0x00F2C39D
		public void CreateByActor(AActor actor)
		{
			base.CreateByActor(actor, null);
		}

		// Token: 0x0603EDA3 RID: 257443 RVA: 0x00F2E1A7 File Offset: 0x00F2C3A7
		public virtual void CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x0603EDA4 RID: 257444 RVA: 0x00F2E1B1 File Offset: 0x00F2C3B1
		public virtual object GetKey(TData data, int displayIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x04020D22 RID: 134434
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public ScrollViewDelegate<IGridProxy<TData>, TData> ScrollViewDelegate;
	}
}
