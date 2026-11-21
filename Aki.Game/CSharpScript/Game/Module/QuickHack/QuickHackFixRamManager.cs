using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F41 RID: 16193
	public class QuickHackFixRamManager : QuickHackRamManager
	{
		// Token: 0x06029012 RID: 167954 RVA: 0x00B839E7 File Offset: 0x00B81BE7
		[NullableContext(2)]
		public override void Init(int param, Action<float> onCurrentRamChange = null, Action<float> onMaxRamChange = null)
		{
			base.Init(param, onCurrentRamChange, onMaxRamChange);
			this.CurrentRam = (float)param;
			this.MaxRam = (float)param;
		}

		// Token: 0x06029013 RID: 167955 RVA: 0x00B83A02 File Offset: 0x00B81C02
		public override void Clear()
		{
			base.Clear();
			this.MaxRam = 0f;
			this.CurrentRam = 0f;
		}

		// Token: 0x06029014 RID: 167956 RVA: 0x00B83A20 File Offset: 0x00B81C20
		public override float GetCurrentRam()
		{
			return this.CurrentRam;
		}

		// Token: 0x06029015 RID: 167957 RVA: 0x00B83A28 File Offset: 0x00B81C28
		public override float GetMaxRam()
		{
			return this.MaxRam;
		}

		// Token: 0x06029016 RID: 167958 RVA: 0x00B83A30 File Offset: 0x00B81C30
		public override void ChangeRam(float addValue)
		{
			this.CurrentRam += addValue;
			Action<float> onCurrentRamChange = this.OnCurrentRamChange;
			if (onCurrentRamChange == null)
			{
				return;
			}
			onCurrentRamChange(this.CurrentRam);
		}

		// Token: 0x04016517 RID: 91415
		private float MaxRam;

		// Token: 0x04016518 RID: 91416
		private float CurrentRam;
	}
}
