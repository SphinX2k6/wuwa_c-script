using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x0200383C RID: 14396
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class GridProxyAbstract<[Nullable(2)] TData> : UiPanelBase, IGridProxy<TData>
	{
		// Token: 0x17004CE7 RID: 19687
		// (get) Token: 0x0602563A RID: 153146 RVA: 0x00A89BC9 File Offset: 0x00A87DC9
		// (set) Token: 0x0602563B RID: 153147 RVA: 0x00A89BD1 File Offset: 0x00A87DD1
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

		// Token: 0x17004CE8 RID: 19688
		// (get) Token: 0x0602563C RID: 153148 RVA: 0x00A89BDA File Offset: 0x00A87DDA
		// (set) Token: 0x0602563D RID: 153149 RVA: 0x00A89BE2 File Offset: 0x00A87DE2
		public int GridIndex { get; set; }

		// Token: 0x17004CE9 RID: 19689
		// (get) Token: 0x0602563E RID: 153150 RVA: 0x00A89BEB File Offset: 0x00A87DEB
		// (set) Token: 0x0602563F RID: 153151 RVA: 0x00A89BF3 File Offset: 0x00A87DF3
		public int DisplayIndex { get; set; }

		// Token: 0x06025640 RID: 153152 RVA: 0x00A89BFC File Offset: 0x00A87DFC
		public virtual void Refresh(TData data, bool isSelected, int gridIndex)
		{
			throw new NotImplementedException("GridProxyAbstract 必须在子类中实现 Refresh");
		}

		// Token: 0x06025641 RID: 153153 RVA: 0x00A89C08 File Offset: 0x00A87E08
		public virtual UniTask RefreshAsync(TData data, bool isSelected, int gridIndex)
		{
			throw new NotImplementedException("GridProxyAbstract 必须在子类中实现 RefreshAsync");
		}

		// Token: 0x06025642 RID: 153154 RVA: 0x00A89C14 File Offset: 0x00A87E14
		public virtual void Clear()
		{
		}

		// Token: 0x06025643 RID: 153155 RVA: 0x00A89C16 File Offset: 0x00A87E16
		public virtual void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06025644 RID: 153156 RVA: 0x00A89C18 File Offset: 0x00A87E18
		public virtual void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06025645 RID: 153157 RVA: 0x00A89C1A File Offset: 0x00A87E1A
		public virtual void CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x06025646 RID: 153158 RVA: 0x00A89C24 File Offset: 0x00A87E24
		public virtual UniTask CreateThenShowByActorAsync(AActor actor)
		{
			return base.CreateThenShowByActorAsync(actor, null, false);
		}

		// Token: 0x06025647 RID: 153159 RVA: 0x00A89C2F File Offset: 0x00A87E2F
		public virtual UniTask CreateByActorAsync(AActor actor)
		{
			return base.CreateByActorAsync(actor, null, false);
		}

		// Token: 0x06025648 RID: 153160 RVA: 0x00A89C3A File Offset: 0x00A87E3A
		public virtual object GetKey(TData data, int displayIndex)
		{
			return this.GridIndex;
		}
	}
}
