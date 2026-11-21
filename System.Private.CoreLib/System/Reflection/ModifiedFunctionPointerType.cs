using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Reflection
{
	// Token: 0x0200075E RID: 1886
	internal sealed class ModifiedFunctionPointerType : ModifiedType
	{
		// Token: 0x06007963 RID: 31075 RVA: 0x00120191 File Offset: 0x0011E391
		internal ModifiedFunctionPointerType(Type unmodifiedType, ModifiedType.TypeSignature typeSignature) : base(unmodifiedType, typeSignature)
		{
		}

		// Token: 0x06007964 RID: 31076 RVA: 0x001201D4 File Offset: 0x0011E3D4
		public override Type GetFunctionPointerReturnType()
		{
			return this._returnType ?? this.<GetFunctionPointerReturnType>g__Initialize|4_0();
		}

		// Token: 0x06007965 RID: 31077 RVA: 0x001201E6 File Offset: 0x0011E3E6
		public override Type[] GetFunctionPointerParameterTypes()
		{
			return (Type[])(this._parameterTypes ?? this.<GetFunctionPointerParameterTypes>g__Initialize|5_0()).Clone();
		}

		// Token: 0x06007966 RID: 31078 RVA: 0x00120204 File Offset: 0x0011E404
		public override Type[] GetFunctionPointerCallingConventions()
		{
			ArrayBuilder<Type> arrayBuilder = default(ArrayBuilder<Type>);
			switch (base.GetCallingConventionFromFunctionPointer())
			{
			case SignatureCallingConvention.Cdecl:
				arrayBuilder.Add(typeof(CallConvCdecl));
				break;
			case SignatureCallingConvention.StdCall:
				arrayBuilder.Add(typeof(CallConvStdcall));
				break;
			case SignatureCallingConvention.ThisCall:
				arrayBuilder.Add(typeof(CallConvThiscall));
				break;
			case SignatureCallingConvention.FastCall:
				arrayBuilder.Add(typeof(CallConvFastcall));
				break;
			case SignatureCallingConvention.Unmanaged:
				foreach (Type type in this.GetFunctionPointerReturnType().GetOptionalCustomModifiers())
				{
					if (type.FullName.StartsWith("System.Runtime.CompilerServices.CallConv", StringComparison.Ordinal))
					{
						arrayBuilder.Add(type);
					}
				}
				break;
			}
			if (arrayBuilder.Count != 0)
			{
				return arrayBuilder.ToArray();
			}
			return Type.EmptyTypes;
		}

		// Token: 0x06007967 RID: 31079 RVA: 0x001202EF File Offset: 0x0011E4EF
		[CompilerGenerated]
		private Type <GetFunctionPointerReturnType>g__Initialize|4_0()
		{
			Interlocked.CompareExchange<Type>(ref this._returnType, base.GetTypeParameter(base.UnmodifiedType.GetFunctionPointerReturnType(), 0), null);
			return this._returnType;
		}

		// Token: 0x06007968 RID: 31080 RVA: 0x00120318 File Offset: 0x0011E518
		[CompilerGenerated]
		private Type[] <GetFunctionPointerParameterTypes>g__Initialize|5_0()
		{
			Type[] functionPointerParameterTypes = base.UnmodifiedType.GetFunctionPointerParameterTypes();
			for (int i = 0; i < functionPointerParameterTypes.Length; i++)
			{
				functionPointerParameterTypes[i] = base.GetTypeParameter(functionPointerParameterTypes[i], i + 1);
			}
			Interlocked.CompareExchange<Type[]>(ref this._parameterTypes, functionPointerParameterTypes, null);
			return this._parameterTypes;
		}

		// Token: 0x040016C9 RID: 5833
		private Type[] _parameterTypes;

		// Token: 0x040016CA RID: 5834
		private Type _returnType;
	}
}
