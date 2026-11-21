using System;
using System.Diagnostics.CodeAnalysis;

namespace System.Reflection
{
	// Token: 0x02000780 RID: 1920
	internal static class SignatureTypeExtensions
	{
		// Token: 0x06007AFD RID: 31485 RVA: 0x00121D4C File Offset: 0x0011FF4C
		public static bool MatchesParameterTypeExactly(this Type pattern, ParameterInfo parameter)
		{
			SignatureType signatureType = pattern as SignatureType;
			if (signatureType != null)
			{
				return signatureType.MatchesExactly(parameter.ParameterType);
			}
			return pattern == parameter.ParameterType;
		}

		// Token: 0x06007AFE RID: 31486 RVA: 0x00121D7C File Offset: 0x0011FF7C
		internal static bool MatchesExactly(this SignatureType pattern, Type actual)
		{
			if (pattern.IsSZArray)
			{
				return actual.IsSZArray && pattern.ElementType.MatchesExactly(actual.GetElementType());
			}
			if (pattern.IsVariableBoundArray)
			{
				return actual.IsVariableBoundArray && pattern.GetArrayRank() == actual.GetArrayRank() && pattern.ElementType.MatchesExactly(actual.GetElementType());
			}
			if (pattern.IsByRef)
			{
				return actual.IsByRef && pattern.ElementType.MatchesExactly(actual.GetElementType());
			}
			if (pattern.IsPointer)
			{
				return actual.IsPointer && pattern.ElementType.MatchesExactly(actual.GetElementType());
			}
			if (!pattern.IsConstructedGenericType)
			{
				return pattern.IsGenericMethodParameter && actual.IsGenericMethodParameter && pattern.GenericParameterPosition == actual.GenericParameterPosition;
			}
			if (!actual.IsConstructedGenericType)
			{
				return false;
			}
			if (!(pattern.GetGenericTypeDefinition() == actual.GetGenericTypeDefinition()))
			{
				return false;
			}
			Type[] genericTypeArguments = pattern.GenericTypeArguments;
			Type[] genericTypeArguments2 = actual.GenericTypeArguments;
			int num = genericTypeArguments.Length;
			if (num != genericTypeArguments2.Length)
			{
				return false;
			}
			for (int i = 0; i < num; i++)
			{
				Type type = genericTypeArguments[i];
				SignatureType signatureType = type as SignatureType;
				if (signatureType != null)
				{
					if (!signatureType.MatchesExactly(genericTypeArguments2[i]))
					{
						return false;
					}
				}
				else if (type != genericTypeArguments2[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06007AFF RID: 31487 RVA: 0x00121EC9 File Offset: 0x001200C9
		internal static Type TryResolveAgainstGenericMethod(this SignatureType signatureType, MethodInfo genericMethod)
		{
			return signatureType.TryResolve(genericMethod.GetGenericArguments());
		}

		// Token: 0x06007B00 RID: 31488 RVA: 0x00121ED8 File Offset: 0x001200D8
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "Used to find matching method overloads. Only used for assignability checks.")]
		[UnconditionalSuppressMessage("AotAnalysis", "IL3050:AotUnfriendlyApi", Justification = "Used to find matching method overloads. Only used for assignability checks.")]
		private static Type TryResolve(this SignatureType signatureType, Type[] genericMethodParameters)
		{
			if (signatureType.IsSZArray)
			{
				Type type = signatureType.ElementType.TryResolve(genericMethodParameters);
				if (type == null)
				{
					return null;
				}
				return type.TryMakeArrayType();
			}
			else if (signatureType.IsVariableBoundArray)
			{
				Type type2 = signatureType.ElementType.TryResolve(genericMethodParameters);
				if (type2 == null)
				{
					return null;
				}
				return type2.TryMakeArrayType(signatureType.GetArrayRank());
			}
			else if (signatureType.IsByRef)
			{
				Type type3 = signatureType.ElementType.TryResolve(genericMethodParameters);
				if (type3 == null)
				{
					return null;
				}
				return type3.TryMakeByRefType();
			}
			else if (signatureType.IsPointer)
			{
				Type type4 = signatureType.ElementType.TryResolve(genericMethodParameters);
				if (type4 == null)
				{
					return null;
				}
				return type4.TryMakePointerType();
			}
			else
			{
				if (signatureType.IsConstructedGenericType)
				{
					Type[] genericTypeArguments = signatureType.GenericTypeArguments;
					int num = genericTypeArguments.Length;
					Type[] array = new Type[num];
					for (int i = 0; i < num; i++)
					{
						Type type5 = genericTypeArguments[i];
						SignatureType signatureType2 = type5 as SignatureType;
						if (signatureType2 != null)
						{
							array[i] = signatureType2.TryResolve(genericMethodParameters);
							if (array[i] == null)
							{
								return null;
							}
						}
						else
						{
							array[i] = type5;
						}
					}
					return signatureType.GetGenericTypeDefinition().TryMakeGenericType(array);
				}
				if (!signatureType.IsGenericMethodParameter)
				{
					return null;
				}
				int genericParameterPosition = signatureType.GenericParameterPosition;
				if (genericParameterPosition >= genericMethodParameters.Length)
				{
					return null;
				}
				return genericMethodParameters[genericParameterPosition];
			}
		}

		// Token: 0x06007B01 RID: 31489 RVA: 0x00121FEC File Offset: 0x001201EC
		[UnconditionalSuppressMessage("AotAnalysis", "IL3050:AotUnfriendlyApi", Justification = "Used to find matching method overloads. Only used for assignability checks.")]
		private static Type TryMakeArrayType(this Type type)
		{
			Type result;
			try
			{
				result = type.MakeArrayType();
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06007B02 RID: 31490 RVA: 0x00122018 File Offset: 0x00120218
		[UnconditionalSuppressMessage("AotAnalysis", "IL3050:AotUnfriendlyApi", Justification = "Used to find matching method overloads. Only used for assignability checks.")]
		private static Type TryMakeArrayType(this Type type, int rank)
		{
			Type result;
			try
			{
				result = type.MakeArrayType(rank);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06007B03 RID: 31491 RVA: 0x00122048 File Offset: 0x00120248
		private static Type TryMakeByRefType(this Type type)
		{
			Type result;
			try
			{
				result = type.MakeByRefType();
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06007B04 RID: 31492 RVA: 0x00122074 File Offset: 0x00120274
		private static Type TryMakePointerType(this Type type)
		{
			Type result;
			try
			{
				result = type.MakePointerType();
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06007B05 RID: 31493 RVA: 0x001220A0 File Offset: 0x001202A0
		[RequiresUnreferencedCode("Wrapper around MakeGenericType which itself has RequiresUnreferencedCode")]
		[RequiresDynamicCode("Wrapper around MakeGenericType which itself has RequiresDynamicCode")]
		private static Type TryMakeGenericType(this Type type, Type[] instantiation)
		{
			Type result;
			try
			{
				result = type.MakeGenericType(instantiation);
			}
			catch
			{
				result = null;
			}
			return result;
		}
	}
}
