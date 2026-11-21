using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Core.Extension
{
	// Token: 0x02000134 RID: 308
	public static class VectorExtension
	{
		// Token: 0x06000B4E RID: 2894 RVA: 0x000357C0 File Offset: 0x000339C0
		[NullableContext(1)]
		public static bool ContainsNaN(this IVector value)
		{
			global::Vector vector = value as global::Vector;
			if (vector != null)
			{
				return vector.ContainsNaN();
			}
			if (value is FVector)
			{
				return ((FVector)value).ContainsNaN();
			}
			return value is FVectorDouble && ((FVectorDouble)value).ContainsNaN();
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00035810 File Offset: 0x00033A10
		[NullableContext(2)]
		public static Aki.Protocol.Vector ToProtocolVector(Aki.Config.Vector? vector)
		{
			if (vector == null)
			{
				return null;
			}
			return new Aki.Protocol.Vector
			{
				X = vector.Value.X,
				Y = vector.Value.Y,
				Z = vector.Value.Z
			};
		}
	}
}
