using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200025D RID: 605
	[NullableContext(2)]
	[Nullable(0)]
	public class Partial<T>
	{
		// Token: 0x06000F63 RID: 3939 RVA: 0x0005B6A4 File Offset: 0x000598A4
		public Partial(T value)
		{
			this.Value = value;
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x0005B6B4 File Offset: 0x000598B4
		public U GetValue<U>([Nullable(1)] Func<T, U> selector)
		{
			if (this.Value == null)
			{
				return default(U);
			}
			return selector(this.Value);
		}

		// Token: 0x040009FB RID: 2555
		private readonly T Value;
	}
}
