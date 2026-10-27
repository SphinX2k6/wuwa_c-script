using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Kurotato.Data;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.EnemyDetailBook
{
	// Token: 0x0200576D RID: 22381
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoEnemyDetailBookGridItem : LoopScrollMediumItemGrid<KurotatoEnemyData>
	{
		// Token: 0x06038DA7 RID: 232871 RVA: 0x00D82001 File Offset: 0x00D80201
		protected override void OnRefresh(KurotatoEnemyData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.SetSelected(isSelected, true);
			this.UpdateView();
		}

		// Token: 0x06038DA8 RID: 232872 RVA: 0x00D82018 File Offset: 0x00D80218
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

		// Token: 0x06038DA9 RID: 232873 RVA: 0x00D820BF File Offset: 0x00D802BF
		protected override void OnExtendToggleClicked()
		{
			Action<KurotatoEnemyData> onItemClickCallback = this.OnItemClickCallback;
			if (onItemClickCallback == null)
			{
				return;
			}
			onItemClickCallback(this.Data);
		}

		// Token: 0x06038DAA RID: 232874 RVA: 0x00D820D7 File Offset: 0x00D802D7
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x06038DAB RID: 232875 RVA: 0x00D820E1 File Offset: 0x00D802E1
		protected override bool OnCanExecuteChange()
		{
			return this.CanExecuteChangeCb == null || this.CanExecuteChangeCb(this.Data);
		}

		// Token: 0x06038DAC RID: 232876 RVA: 0x00D820FE File Offset: 0x00D802FE
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x06038DAD RID: 232877 RVA: 0x00D82108 File Offset: 0x00D80308
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

		// Token: 0x0401DD1A RID: 122138
		[Nullable(2)]
		public new KurotatoEnemyData Data;

		// Token: 0x0401DD1B RID: 122139
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<KurotatoEnemyData> OnItemClickCallback;

		// Token: 0x0401DD1C RID: 122140
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<KurotatoEnemyData, bool> CanExecuteChangeCb;
	}
}
