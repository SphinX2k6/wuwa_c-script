using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F43 RID: 16195
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class QuickHackRamManager
	{
		// Token: 0x06029020 RID: 167968 RVA: 0x00B83B85 File Offset: 0x00B81D85
		public virtual void Init(int param, Action<float> onCurrentRamChange = null, Action<float> onMaxRamChange = null)
		{
			this.Param = param;
			this.OnCurrentRamChange = onCurrentRamChange;
			this.OnMaxRamChange = onMaxRamChange;
		}

		// Token: 0x06029021 RID: 167969 RVA: 0x00B83B9C File Offset: 0x00B81D9C
		public virtual void Clear()
		{
			this.Param = 0;
			this.OnCurrentRamChange = null;
			this.OnMaxRamChange = null;
		}

		// Token: 0x06029022 RID: 167970
		public abstract float GetCurrentRam();

		// Token: 0x06029023 RID: 167971
		public abstract float GetMaxRam();

		// Token: 0x06029024 RID: 167972
		public abstract void ChangeRam(float addValue);

		// Token: 0x0401651A RID: 91418
		protected int Param;

		// Token: 0x0401651B RID: 91419
		protected Action<float> OnCurrentRamChange;

		// Token: 0x0401651C RID: 91420
		protected Action<float> OnMaxRamChange;
	}
}
