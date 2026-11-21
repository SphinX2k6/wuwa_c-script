using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Reflection
{
	// Token: 0x0200075D RID: 1885
	internal sealed class ModifiedHasElementType : ModifiedType
	{
		// Token: 0x06007960 RID: 31072 RVA: 0x00120191 File Offset: 0x0011E391
		internal ModifiedHasElementType(Type unmodifiedType, ModifiedType.TypeSignature typeSignature) : base(unmodifiedType, typeSignature)
		{
		}

		// Token: 0x06007961 RID: 31073 RVA: 0x0012019B File Offset: 0x0011E39B
		public override Type GetElementType()
		{
			return this._elementType ?? this.<GetElementType>g__Initialize|2_0();
		}

		// Token: 0x06007962 RID: 31074 RVA: 0x001201AD File Offset: 0x0011E3AD
		[CompilerGenerated]
		private Type <GetElementType>g__Initialize|2_0()
		{
			Interlocked.CompareExchange<Type>(ref this._elementType, base.GetTypeParameter(base.UnmodifiedType.GetElementType(), 0), null);
			return this._elementType;
		}

		// Token: 0x040016C8 RID: 5832
		private Type _elementType;
	}
}
