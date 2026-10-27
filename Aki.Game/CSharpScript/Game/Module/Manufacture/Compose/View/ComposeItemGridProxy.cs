using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x0200566A RID: 22122
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ComposeItemGridProxy : SyncGridProxyAbstract<ComposeItemGridData>
	{
		// Token: 0x06038454 RID: 230484 RVA: 0x00D56150 File Offset: 0x00D54350
		protected override void OnStart()
		{
			this.InnerGrid.SetUseFixedAsync(true);
			this.InnerGrid.Initialize(this.RootActor);
			this.InnerGrid.SetToggleInteractive(true);
			this.InnerGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnToggleStateChanged));
		}

		// Token: 0x06038455 RID: 230485 RVA: 0x00D5619D File Offset: 0x00D5439D
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

		// Token: 0x06038456 RID: 230486 RVA: 0x00D561BC File Offset: 0x00D543BC
		public override void Refresh(ComposeItemGridData data)
		{
			this.CurrentData = data;
			Func<int, bool> isSelectedProvider = data.IsSelectedProvider;
			bool isSelected = isSelectedProvider != null && isSelectedProvider(base.GridIndex);
			this.InnerGrid.RefreshByBaseItemData(data.ItemData, isSelected);
		}

		// Token: 0x06038457 RID: 230487 RVA: 0x00D561FB File Offset: 0x00D543FB
		public void SetSelected(bool selected)
		{
			this.InnerGrid.SetSelected(selected, false);
		}

		// Token: 0x06038458 RID: 230488 RVA: 0x00D5620A File Offset: 0x00D5440A
		public ComposeMediumItemGridInner GetInnerGrid()
		{
			return this.InnerGrid;
		}

		// Token: 0x0401D965 RID: 121189
		private readonly ComposeMediumItemGridInner InnerGrid = new ComposeMediumItemGridInner();

		// Token: 0x0401D966 RID: 121190
		[Nullable(2)]
		public ComposeItemGridData CurrentData;
	}
}
