using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x02004640 RID: 17984
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ComposeItemGridProxy : SyncGridProxyAbstract<ComposeItemGridData>
	{
		// Token: 0x0602D352 RID: 185170 RVA: 0x00CA40DC File Offset: 0x00CA22DC
		protected override void OnStart()
		{
			this.InnerGrid.SetUseFixedAsync(true);
			this.InnerGrid.Initialize(this.RootActor);
			this.InnerGrid.SetToggleInteractive(true);
			this.InnerGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnToggleStateChanged));
		}

		// Token: 0x0602D353 RID: 185171 RVA: 0x00CA4129 File Offset: 0x00CA2329
		private void OnToggleStateChanged(MediumItemGridExtendCallback callbackParameter)
		{
			ComposeItemGridData currentData = this.CurrentData;
			if (currentData == null)
			{
				return;
			}
			Action<MediumItemGridExtendCallback> onToggleStateChanged = currentData.OnToggleStateChanged;
			if (onToggleStateChanged == null)
			{
				return;
			}
			onToggleStateChanged(callbackParameter);
		}

		// Token: 0x0602D354 RID: 185172 RVA: 0x00CA4148 File Offset: 0x00CA2348
		public override void Refresh(ComposeItemGridData data)
		{
			this.CurrentData = data;
			Func<int, bool> isSelectedProvider = data.IsSelectedProvider;
			bool isSelected = isSelectedProvider != null && isSelectedProvider(base.GridIndex);
			this.InnerGrid.RefreshByBaseItemData(data.ItemData, isSelected);
		}

		// Token: 0x0602D355 RID: 185173 RVA: 0x00CA4187 File Offset: 0x00CA2387
		public void SetSelected(bool selected)
		{
			this.InnerGrid.SetSelected(selected, false);
		}

		// Token: 0x0602D356 RID: 185174 RVA: 0x00CA4196 File Offset: 0x00CA2396
		public ComposeMediumItemGridInner GetInnerGrid()
		{
			return this.InnerGrid;
		}

		// Token: 0x040183F0 RID: 99312
		private readonly ComposeMediumItemGridInner InnerGrid = new ComposeMediumItemGridInner();

		// Token: 0x040183F1 RID: 99313
		[Nullable(2)]
		public ComposeItemGridData CurrentData;
	}
}
