using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048C5 RID: 18629
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class GridProxyAbstract<[Nullable(2)] TData> : UiPanelBase, IGridProxy<TData>
	{
		// Token: 0x1700797F RID: 31103
		// (get) Token: 0x06030B0E RID: 199438 RVA: 0x00B4EDC1 File Offset: 0x00B4CFC1
		// (set) Token: 0x06030B0F RID: 199439 RVA: 0x00B4EDC9 File Offset: 0x00B4CFC9
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public IScrollViewDelegate<IGridProxy<TData>, TData> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] set; }

		// Token: 0x17007980 RID: 31104
		// (get) Token: 0x06030B10 RID: 199440 RVA: 0x00B4EDD2 File Offset: 0x00B4CFD2
		// (set) Token: 0x06030B11 RID: 199441 RVA: 0x00B4EDDA File Offset: 0x00B4CFDA
		public int GridIndex { get; set; }

		// Token: 0x17007981 RID: 31105
		// (get) Token: 0x06030B12 RID: 199442 RVA: 0x00B4EDE3 File Offset: 0x00B4CFE3
		// (set) Token: 0x06030B13 RID: 199443 RVA: 0x00B4EDEB File Offset: 0x00B4CFEB
		public int DisplayIndex { get; set; }

		// Token: 0x06030B14 RID: 199444 RVA: 0x00B4EDF4 File Offset: 0x00B4CFF4
		public virtual void Refresh(TData data, bool isSelected, int gridIndex)
		{
			throw new NotImplementedException("GridProxyAbstract 必须在子类中实现 Refresh");
		}

		// Token: 0x06030B15 RID: 199445 RVA: 0x00B4EE00 File Offset: 0x00B4D000
		public virtual UniTask RefreshAsync(TData data, bool isSelected, int gridIndex)
		{
			throw new NotImplementedException("GridProxyAbstract 必须在子类中实现 RefreshAsync");
		}

		// Token: 0x06030B16 RID: 199446 RVA: 0x00B4EE0C File Offset: 0x00B4D00C
		public virtual void Clear()
		{
		}

		// Token: 0x06030B17 RID: 199447 RVA: 0x00B4EE0E File Offset: 0x00B4D00E
		public virtual void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06030B18 RID: 199448 RVA: 0x00B4EE10 File Offset: 0x00B4D010
		public virtual void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06030B19 RID: 199449 RVA: 0x00B4EE12 File Offset: 0x00B4D012
		public virtual void CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x06030B1A RID: 199450 RVA: 0x00B4EE1C File Offset: 0x00B4D01C
		public virtual UniTask CreateThenShowByActorAsync(AActor actor)
		{
			return base.CreateThenShowByActorAsync(actor, null, false);
		}

		// Token: 0x06030B1B RID: 199451 RVA: 0x00B4EE27 File Offset: 0x00B4D027
		public virtual UniTask CreateByActorAsync(AActor actor)
		{
			return base.CreateByActorAsync(actor, null, false);
		}

		// Token: 0x06030B1C RID: 199452 RVA: 0x00B4EE32 File Offset: 0x00B4D032
		public virtual object GetKey(TData data, int displayIndex)
		{
			return this.GridIndex;
		}
	}
}
