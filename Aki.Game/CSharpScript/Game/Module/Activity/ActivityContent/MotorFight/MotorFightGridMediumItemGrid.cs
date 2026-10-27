using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006411 RID: 25617
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightGridMediumItemGrid : MediumItemGrid
	{
		// Token: 0x17009474 RID: 38004
		// (get) Token: 0x060406EA RID: 263914 RVA: 0x00F9620C File Offset: 0x00F9440C
		public new MotorFightItemData Data
		{
			get
			{
				return this.Data as MotorFightItemData;
			}
		}

		// Token: 0x060406EB RID: 263915 RVA: 0x00F96219 File Offset: 0x00F94419
		protected override void OnStart()
		{
			this.GetItemGridExtendToggle().bLockStateOnSelect = true;
			base.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnClickToggle));
			base.SetUseFixedAsync(true);
		}

		// Token: 0x060406EC RID: 263916 RVA: 0x00F96240 File Offset: 0x00F94440
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

		// Token: 0x060406ED RID: 263917 RVA: 0x00F962DF File Offset: 0x00F944DF
		private void OnClickToggle(MediumItemGridExtendCallback _)
		{
			this.Data.ReadItemRedDot();
			base.SetNewVisible(new bool?(false));
			this.OnClickCallBack(this.Data);
		}

		// Token: 0x060406EE RID: 263918 RVA: 0x00F9630C File Offset: 0x00F9450C
		public void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			this.GetItemGridExtendToggle().SetToggleState(state2, false, false, false);
		}

		// Token: 0x0402180A RID: 137226
		public Action<MotorFightItemData> OnClickCallBack = delegate(MotorFightItemData <p0>)
		{
		};
	}
}
