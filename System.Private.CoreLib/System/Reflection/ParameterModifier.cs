using System;

namespace System.Reflection
{
	// Token: 0x0200076C RID: 1900
	public readonly struct ParameterModifier
	{
		// Token: 0x060079F4 RID: 31220 RVA: 0x0012162D File Offset: 0x0011F82D
		public ParameterModifier(int parameterCount)
		{
			if (parameterCount <= 0)
			{
				throw new ArgumentException(SR.Arg_ParmArraySize);
			}
			this._byRef = new bool[parameterCount];
		}

		// Token: 0x17000FA5 RID: 4005
		public bool this[int index]
		{
			get
			{
				return this._byRef[index];
			}
			set
			{
				this._byRef[index] = value;
			}
		}

		// Token: 0x040016F9 RID: 5881
		private readonly bool[] _byRef;
	}
}
