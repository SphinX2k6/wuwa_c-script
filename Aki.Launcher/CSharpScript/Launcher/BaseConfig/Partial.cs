using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000258 RID: 600
	[NullableContext(2)]
	[Nullable(0)]
	public class Partial<T>
	{
		// Token: 0x06000F1C RID: 3868 RVA: 0x00058878 File Offset: 0x00056A78
		public Partial(T value)
		{
			this.Value = value;
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00058888 File Offset: 0x00056A88
		public U GetValue<U>([Nullable(1)] Func<T, U> selector)
		{
			if (this.Value == null)
			{
				return default(U);
			}
			return selector(this.Value);
		}

		// Token: 0x040009B1 RID: 2481
		private readonly T Value;
	}
}
