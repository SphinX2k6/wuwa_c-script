using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F78 RID: 20344
	public class QuickHackFixRamManager : QuickHackRamManager
	{
		// Token: 0x060341A4 RID: 213412 RVA: 0x00C3A23B File Offset: 0x00C3843B
		[NullableContext(2)]
		public override void Init(int param, Action<float> onCurrentRamChange = null, Action<float> onMaxRamChange = null)
		{
			base.Init(param, onCurrentRamChange, onMaxRamChange);
			this.CurrentRam = (float)param;
			this.MaxRam = (float)param;
		}

		// Token: 0x060341A5 RID: 213413 RVA: 0x00C3A256 File Offset: 0x00C38456
		public override void Clear()
		{
			base.Clear();
			this.MaxRam = 0f;
			this.CurrentRam = 0f;
		}

		// Token: 0x060341A6 RID: 213414 RVA: 0x00C3A274 File Offset: 0x00C38474
		public override float GetCurrentRam()
		{
			return this.CurrentRam;
		}

		// Token: 0x060341A7 RID: 213415 RVA: 0x00C3A27C File Offset: 0x00C3847C
		public override float GetMaxRam()
		{
			return this.MaxRam;
		}

		// Token: 0x060341A8 RID: 213416 RVA: 0x00C3A284 File Offset: 0x00C38484
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

		// Token: 0x0401BB42 RID: 113474
		private float MaxRam;

		// Token: 0x0401BB43 RID: 113475
		private float CurrentRam;
	}
}
