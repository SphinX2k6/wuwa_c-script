using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200538F RID: 21391
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightGridMediumItemGrid : MediumItemGrid
	{
		// Token: 0x170067D6 RID: 26582
		// (get) Token: 0x060353AB RID: 218027 RVA: 0x00EDD1AC File Offset: 0x00EDB3AC
		public new MotorFightItemData Data
		{
			get
			{
				return this.Data as MotorFightItemData;
			}
		}

		// Token: 0x060353AC RID: 218028 RVA: 0x00EDD1B9 File Offset: 0x00EDB3B9
		protected override void OnStart()
		{
			this.GetItemGridExtendToggle().bLockStateOnSelect = true;
			base.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnClickToggle));
			base.SetUseFixedAsync(true);
		}

		// Token: 0x060353AD RID: 218029 RVA: 0x00EDD1E0 File Offset: 0x00EDB3E0
		public void Refresh(MotorFightItemData data)
		{
			this.Data = data;
			MotorFightQuality? motorFightQuality = MotorFightConfig.Instance.GetMotorFightQuality(data.Quality);
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				Data = data,
				QualityIcon = motorFightQuality.Value.SmallGridBg,
				IconPath = data.Icon,
				BottomTextId = data.Name,
				IsLockVisible = new bool?(!data.IsUnLock),
				IsDisable = new bool?(!data.IsUnLock),
				IsNewVisible = new bool?(data.HasItemRedDot)
			};
			base.Apply<PropMediumItemGrid>(parameters);
		}

		// Token: 0x060353AE RID: 218030 RVA: 0x00EDD27F File Offset: 0x00EDB47F
		private void OnClickToggle(MediumItemGridExtendCallback _)
		{
			this.Data.ReadItemRedDot();
			base.SetNewVisible(new bool?(false));
			this.OnClickCallBack(this.Data);
		}

		// Token: 0x060353AF RID: 218031 RVA: 0x00EDD2AC File Offset: 0x00EDB4AC
		public void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			this.GetItemGridExtendToggle().SetToggleState(state2, false, false, false);
		}

		// Token: 0x0401C139 RID: 115001
		public Action<MotorFightItemData> OnClickCallBack = delegate(MotorFightItemData <p0>)
		{
		};
	}
}
