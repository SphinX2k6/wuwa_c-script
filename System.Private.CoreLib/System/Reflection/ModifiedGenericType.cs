using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Reflection
{
	// Token: 0x0200075F RID: 1887
	internal sealed class ModifiedGenericType : ModifiedType
	{
		// Token: 0x06007969 RID: 31081 RVA: 0x00120191 File Offset: 0x0011E391
		internal ModifiedGenericType(Type unmodifiedType, ModifiedType.TypeSignature typeSignature) : base(unmodifiedType, typeSignature)
		{
		}

		// Token: 0x0600796A RID: 31082 RVA: 0x00120362 File Offset: 0x0011E562
		public override Type[] GetGenericArguments()
		{
			return (Type[])(this._genericArguments ?? this.<GetGenericArguments>g__Initialize|2_0()).Clone();
		}

		// Token: 0x0600796B RID: 31083 RVA: 0x00120380 File Offset: 0x0011E580
		[CompilerGenerated]
		private Type[] <GetGenericArguments>g__Initialize|2_0()
		{
			Type[] genericArguments = base.UnmodifiedType.GetGenericArguments();
			for (int i = 0; i < genericArguments.Length; i++)
			{
				genericArguments[i] = base.GetTypeParameter(genericArguments[i], i);
			}
			Interlocked.CompareExchange<Type[]>(ref this._genericArguments, genericArguments, null);
			return this._genericArguments;
		}

		// Token: 0x040016CB RID: 5835
		private Type[] _genericArguments;
	}
}
