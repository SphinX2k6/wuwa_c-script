using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005097 RID: 20631
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class RoverlikeMultiUseGridProxyAbstract<[Nullable(2)] TData> : UiPanelBase, IGridProxy<TData>, ISyncGridProxy<TData>, ISyncGridProxy
	{
		// Token: 0x170064E5 RID: 25829
		// (get) Token: 0x06033A58 RID: 211544 RVA: 0x00E74F3C File Offset: 0x00E7313C
		// (set) Token: 0x06033A59 RID: 211545 RVA: 0x00E74F44 File Offset: 0x00E73144
		public int GridIndex { get; set; }

		// Token: 0x170064E6 RID: 25830
		// (get) Token: 0x06033A5A RID: 211546 RVA: 0x00E74F4D File Offset: 0x00E7314D
		// (set) Token: 0x06033A5B RID: 211547 RVA: 0x00E74F55 File Offset: 0x00E73155
		public int DisplayIndex { get; set; }

		// Token: 0x170064E7 RID: 25831
		// (get) Token: 0x06033A5C RID: 211548 RVA: 0x00E74F5E File Offset: 0x00E7315E
		// (set) Token: 0x06033A5D RID: 211549 RVA: 0x00E74F66 File Offset: 0x00E73166
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

		// Token: 0x06033A5E RID: 211550 RVA: 0x00E74F74 File Offset: 0x00E73174
		public virtual void Refresh(TData data, bool isSelected, int gridIndex)
		{
		}

		// Token: 0x06033A5F RID: 211551 RVA: 0x00E74F76 File Offset: 0x00E73176
		public virtual void Refresh(TData data)
		{
			this.Refresh(data, false, this.GridIndex);
		}

		// Token: 0x06033A60 RID: 211552 RVA: 0x00E74F88 File Offset: 0x00E73188
		void ISyncGridProxy.Refresh(object data)
		{
			if (data is TData)
			{
				TData data2 = (TData)((object)data);
				this.Refresh(data2);
			}
		}

		// Token: 0x06033A61 RID: 211553 RVA: 0x00E74FAB File Offset: 0x00E731AB
		public virtual void Clear()
		{
		}

		// Token: 0x06033A62 RID: 211554 RVA: 0x00E74FAD File Offset: 0x00E731AD
		public virtual void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06033A63 RID: 211555 RVA: 0x00E74FAF File Offset: 0x00E731AF
		public virtual void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06033A64 RID: 211556 RVA: 0x00E74FB1 File Offset: 0x00E731B1
		public void CreateByActor(AActor actor)
		{
			base.CreateByActor(actor, null);
		}

		// Token: 0x06033A65 RID: 211557 RVA: 0x00E74FBB File Offset: 0x00E731BB
		public virtual void CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x06033A66 RID: 211558 RVA: 0x00E74FC5 File Offset: 0x00E731C5
		public virtual object GetKey(TData data, int displayIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x0401B64F RID: 112207
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
