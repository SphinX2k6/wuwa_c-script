using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Core.Extension
{
	// Token: 0x02000137 RID: 311
	public static class VectorExtension
	{
		// Token: 0x06000AFC RID: 2812 RVA: 0x00034D6C File Offset: 0x00032F6C
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

		// Token: 0x06000AFD RID: 2813 RVA: 0x00034DBC File Offset: 0x00032FBC
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
