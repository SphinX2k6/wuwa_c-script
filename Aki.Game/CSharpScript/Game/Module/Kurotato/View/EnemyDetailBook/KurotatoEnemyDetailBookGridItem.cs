using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Kurotato.Data;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.EnemyDetailBook
{
	// Token: 0x02004744 RID: 18244
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoEnemyDetailBookGridItem : LoopScrollMediumItemGrid<KurotatoEnemyData>
	{
		// Token: 0x0602DCB7 RID: 187575 RVA: 0x00CD0AFD File Offset: 0x00CCECFD
		protected override void OnRefresh(KurotatoEnemyData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.SetSelected(isSelected, true);
			this.UpdateView();
		}

		// Token: 0x0602DCB8 RID: 187576 RVA: 0x00CD0B14 File Offset: 0x00CCED14
		public void UpdateView()
		{
			PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid();
			propMediumItemGrid.IconPath = this.Data.IconPath;
			propMediumItemGrid.QualityIcon = this.Data.GetQualityPathGrid();
			propMediumItemGrid.TagPathList = this.Data.GetGridTagPathList().ToArray();
			string rightTopValue;
			if (this.Data.CountNum <= 1)
			{
				rightTopValue = "";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("×");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Data.CountNum);
				rightTopValue = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			propMediumItemGrid.RightTopValue = rightTopValue;
			propMediumItemGrid.Data = this.Data;
			PropMediumItemGrid parameters = propMediumItemGrid;
			base.Apply<PropMediumItemGrid>(parameters);
		}

		// Token: 0x0602DCB9 RID: 187577 RVA: 0x00CD0BBB File Offset: 0x00CCEDBB
		protected override void OnExtendToggleClicked()
		{
			Action<KurotatoEnemyData> onItemClickCallback = this.OnItemClickCallback;
			if (onItemClickCallback == null)
			{
				return;
			}
			onItemClickCallback(this.Data);
		}

		// Token: 0x0602DCBA RID: 187578 RVA: 0x00CD0BD3 File Offset: 0x00CCEDD3
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x0602DCBB RID: 187579 RVA: 0x00CD0BDD File Offset: 0x00CCEDDD
		protected override bool OnCanExecuteChange()
		{
			return this.CanExecuteChangeCb == null || this.CanExecuteChangeCb(this.Data);
		}

		// Token: 0x0602DCBC RID: 187580 RVA: 0x00CD0BFA File Offset: 0x00CCEDFA
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x0602DCBD RID: 187581 RVA: 0x00CD0C04 File Offset: 0x00CCEE04
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.OnExtendToggleClicked();
				return;
			}
			if (this.IsSelected)
			{
				this.SetSelected(true, false);
			}
		}

		// Token: 0x040187B0 RID: 100272
		[Nullable(2)]
		public new KurotatoEnemyData Data;

		// Token: 0x040187B1 RID: 100273
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<KurotatoEnemyData> OnItemClickCallback;

		// Token: 0x040187B2 RID: 100274
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<KurotatoEnemyData, bool> CanExecuteChangeCb;
	}
}
