using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F7A RID: 20346
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class QuickHackRamManager
	{
		// Token: 0x060341B2 RID: 213426 RVA: 0x00C3A3D9 File Offset: 0x00C385D9
		public virtual void Init(int param, Action<float> onCurrentRamChange = null, Action<float> onMaxRamChange = null)
		{
			this.Param = param;
			this.OnCurrentRamChange = onCurrentRamChange;
			this.OnMaxRamChange = onMaxRamChange;
		}

		// Token: 0x060341B3 RID: 213427 RVA: 0x00C3A3F0 File Offset: 0x00C385F0
		public virtual void Clear()
		{
			this.Param = 0;
			this.OnCurrentRamChange = null;
			this.OnMaxRamChange = null;
		}

		// Token: 0x060341B4 RID: 213428
		public abstract float GetCurrentRam();

		// Token: 0x060341B5 RID: 213429
		public abstract float GetMaxRam();

		// Token: 0x060341B6 RID: 213430
		public abstract void ChangeRam(float addValue);

		// Token: 0x0401BB45 RID: 113477
		protected int Param;

		// Token: 0x0401BB46 RID: 113478
		protected Action<float> OnCurrentRamChange;

		// Token: 0x0401BB47 RID: 113479
		protected Action<float> OnMaxRamChange;
	}
}
