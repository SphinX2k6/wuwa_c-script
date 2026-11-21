using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008DE RID: 2270
	internal struct EventParameterInfo
	{
		// Token: 0x06008B9D RID: 35741 RVA: 0x0015195F File Offset: 0x0014FB5F
		internal void SetInfo(string name, Type type, TraceLoggingTypeInfo typeInfo = null)
		{
			this.ParameterName = name;
			this.ParameterType = type;
			this.TypeInfo = typeInfo;
		}

		// Token: 0x06008B9E RID: 35742 RVA: 0x00151978 File Offset: 0x0014FB78
		internal unsafe bool GenerateMetadata(byte* pMetadataBlob, ref uint offset, uint blobSize)
		{
			TypeCode typeCodeExtended = EventParameterInfo.GetTypeCodeExtended(this.ParameterType);
			if (typeCodeExtended == TypeCode.Object)
			{
				EventPipeMetadataGenerator.WriteToBuffer<uint>(pMetadataBlob, blobSize, ref offset, 1U);
				InvokeTypeInfo invokeTypeInfo = this.TypeInfo as InvokeTypeInfo;
				if (invokeTypeInfo == null)
				{
					return false;
				}
				PropertyAnalysis[] properties = invokeTypeInfo.properties;
				if (properties != null)
				{
					EventPipeMetadataGenerator.WriteToBuffer<uint>(pMetadataBlob, blobSize, ref offset, (uint)properties.Length);
					PropertyAnalysis[] array = properties;
					for (int i = 0; i < array.Length; i++)
					{
						if (!EventParameterInfo.GenerateMetadataForProperty(array[i], pMetadataBlob, ref offset, blobSize))
						{
							return false;
						}
					}
				}
				else
				{
					EventPipeMetadataGenerator.WriteToBuffer<uint>(pMetadataBlob, blobSize, ref offset, 0U);
				}
				EventPipeMetadataGenerator.WriteToBuffer<char>(pMetadataBlob, blobSize, ref offset, '\0');
			}
			else
			{
				EventPipeMetadataGenerator.WriteToBuffer<uint>(pMetadataBlob, blobSize, ref offset, (uint)typeCodeExtended);
				string parameterName = this.ParameterName;
				char* ptr;
				if (parameterName == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = parameterName.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* src = ptr;
				EventPipeMetadataGenerator.WriteToBuffer(pMetadataBlob, blobSize, ref offset, (byte*)src, (uint)((this.ParameterName.Length + 1) * 2));
				char* ptr2 = null;
			}
			return true;
		}

		// Token: 0x06008B9F RID: 35743 RVA: 0x00151A40 File Offset: 0x0014FC40
		private unsafe static bool GenerateMetadataForProperty(PropertyAnalysis property, byte* pMetadataBlob, ref uint offset, uint blobSize)
		{
			InvokeTypeInfo invokeTypeInfo = property.typeInfo as InvokeTypeInfo;
			if (invokeTypeInfo != null)
			{
				EventPipeMetadataGenerator.WriteToBuffer<uint>(pMetadataBlob, blobSize, ref offset, 1U);
				PropertyAnalysis[] properties = invokeTypeInfo.properties;
				if (properties != null)
				{
					EventPipeMetadataGenerator.WriteToBuffer<uint>(pMetadataBlob, blobSize, ref offset, (uint)properties.Length);
					PropertyAnalysis[] array = properties;
					for (int i = 0; i < array.Length; i++)
					{
						if (!EventParameterInfo.GenerateMetadataForProperty(array[i], pMetadataBlob, ref offset, blobSize))
						{
							return false;
						}
					}
				}
				else
				{
					EventPipeMetadataGenerator.WriteToBuffer<uint>(pMetadataBlob, blobSize, ref offset, 0U);
				}
				string name = property.name;
				char* ptr;
				if (name == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = name.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* src = ptr;
				EventPipeMetadataGenerator.WriteToBuffer(pMetadataBlob, blobSize, ref offset, (byte*)src, (uint)((property.name.Length + 1) * 2));
				char* ptr2 = null;
			}
			else
			{
				TypeCode typeCodeExtended = EventParameterInfo.GetTypeCodeExtended(property.typeInfo.DataType);
				if (typeCodeExtended == TypeCode.Object)
				{
					return false;
				}
				EventPipeMetadataGenerator.WriteToBuffer<uint>(pMetadataBlob, blobSize, ref offset, (uint)typeCodeExtended);
				string name2 = property.name;
				char* ptr3;
				if (name2 == null)
				{
					ptr3 = null;
				}
				else
				{
					fixed (char* ptr2 = name2.GetPinnableReference())
					{
						ptr3 = ptr2;
					}
				}
				char* src2 = ptr3;
				EventPipeMetadataGenerator.WriteToBuffer(pMetadataBlob, blobSize, ref offset, (byte*)src2, (uint)((property.name.Length + 1) * 2));
				char* ptr2 = null;
			}
			return true;
		}

		// Token: 0x06008BA0 RID: 35744 RVA: 0x00151B3B File Offset: 0x0014FD3B
		internal unsafe bool GenerateMetadataV2(byte* pMetadataBlob, ref uint offset, uint blobSize)
		{
			return this.TypeInfo != null && EventParameterInfo.GenerateMetadataForNamedTypeV2(this.ParameterName, this.TypeInfo, pMetadataBlob, ref offset, blobSize);
		}

		// Token: 0x06008BA1 RID: 35745 RVA: 0x00151B5C File Offset: 0x0014FD5C
		private unsafe static bool GenerateMetadataForNamedTypeV2(string name, TraceLoggingTypeInfo typeInfo, byte* pMetadataBlob, ref uint offset, uint blobSize)
		{
			uint value;
			if (!EventParameterInfo.GetMetadataLengthForNamedTypeV2(name, typeInfo, out value))
			{
				return false;
			}
			EventPipeMetadataGenerator.WriteToBuffer<uint>(pMetadataBlob, blobSize, ref offset, value);
			char* ptr;
			if (name == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = name.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			char* src = ptr;
			EventPipeMetadataGenerator.WriteToBuffer(pMetadataBlob, blobSize, ref offset, (byte*)src, (uint)((name.Length + 1) * 2));
			char* ptr2 = null;
			return EventParameterInfo.GenerateMetadataForTypeV2(typeInfo, pMetadataBlob, ref offset, blobSize);
		}

		// Token: 0x06008BA2 RID: 35746 RVA: 0x00151BB4 File Offset: 0x0014FDB4
		private unsafe static bool GenerateMetadataForTypeV2(TraceLoggingTypeInfo typeInfo, byte* pMetadataBlob, ref uint offset, uint blobSize)
		{
			InvokeTypeInfo invokeTypeInfo = typeInfo as InvokeTypeInfo;
			if (invokeTypeInfo != null)
			{
				EventPipeMetadataGenerator.WriteToBuffer<uint>(pMetadataBlob, blobSize, ref offset, 1U);
				PropertyAnalysis[] properties = invokeTypeInfo.properties;
				if (properties != null)
				{
					EventPipeMetadataGenerator.WriteToBuffer<uint>(pMetadataBlob, blobSize, ref offset, (uint)properties.Length);
					foreach (PropertyAnalysis propertyAnalysis in properties)
					{
						if (!EventParameterInfo.GenerateMetadataForNamedTypeV2(propertyAnalysis.name, propertyAnalysis.typeInfo, pMetadataBlob, ref offset, blobSize))
						{
							return false;
						}
					}
				}
				else
				{
					EventPipeMetadataGenerator.WriteToBuffer<uint>(pMetadataBlob, blobSize, ref offset, 0U);
				}
			}
			else
			{
				EnumerableTypeInfo enumerableTypeInfo = typeInfo as EnumerableTypeInfo;
				if (enumerableTypeInfo != null)
				{
					EventPipeMetadataGenerator.WriteToBuffer<int>(pMetadataBlob, blobSize, ref offset, 19);
					EventParameterInfo.GenerateMetadataForTypeV2(enumerableTypeInfo.ElementInfo, pMetadataBlob, ref offset, blobSize);
				}
				else
				{
					ScalarArrayTypeInfo scalarArrayTypeInfo = typeInfo as ScalarArrayTypeInfo;
					if (scalarArrayTypeInfo != null)
					{
						if (!scalarArrayTypeInfo.DataType.HasElementType)
						{
							return false;
						}
						TraceLoggingTypeInfo typeInfo2;
						if (!EventParameterInfo.GetTypeInfoFromType(scalarArrayTypeInfo.DataType.GetElementType(), out typeInfo2))
						{
							return false;
						}
						EventPipeMetadataGenerator.WriteToBuffer<int>(pMetadataBlob, blobSize, ref offset, 19);
						EventParameterInfo.GenerateMetadataForTypeV2(typeInfo2, pMetadataBlob, ref offset, blobSize);
					}
					else
					{
						TypeCode typeCodeExtended = EventParameterInfo.GetTypeCodeExtended(typeInfo.DataType);
						if (typeCodeExtended == TypeCode.Object)
						{
							return false;
						}
						EventPipeMetadataGenerator.WriteToBuffer<uint>(pMetadataBlob, blobSize, ref offset, (uint)typeCodeExtended);
					}
				}
			}
			return true;
		}

		// Token: 0x06008BA3 RID: 35747 RVA: 0x00151CBC File Offset: 0x0014FEBC
		internal static bool GetTypeInfoFromType(Type type, out TraceLoggingTypeInfo typeInfo)
		{
			if (type == typeof(bool))
			{
				typeInfo = ScalarTypeInfo.Boolean();
				return true;
			}
			if (type == typeof(byte))
			{
				typeInfo = ScalarTypeInfo.Byte();
				return true;
			}
			if (type == typeof(sbyte))
			{
				typeInfo = ScalarTypeInfo.SByte();
				return true;
			}
			if (type == typeof(char))
			{
				typeInfo = ScalarTypeInfo.Char();
				return true;
			}
			if (type == typeof(short))
			{
				typeInfo = ScalarTypeInfo.Int16();
				return true;
			}
			if (type == typeof(ushort))
			{
				typeInfo = ScalarTypeInfo.UInt16();
				return true;
			}
			if (type == typeof(int))
			{
				typeInfo = ScalarTypeInfo.Int32();
				return true;
			}
			if (type == typeof(uint))
			{
				typeInfo = ScalarTypeInfo.UInt32();
				return true;
			}
			if (type == typeof(long))
			{
				typeInfo = ScalarTypeInfo.Int64();
				return true;
			}
			if (type == typeof(ulong))
			{
				typeInfo = ScalarTypeInfo.UInt64();
				return true;
			}
			if (type == typeof(IntPtr))
			{
				typeInfo = ScalarTypeInfo.IntPtr();
				return true;
			}
			if (type == typeof(UIntPtr))
			{
				typeInfo = ScalarTypeInfo.UIntPtr();
				return true;
			}
			if (type == typeof(float))
			{
				typeInfo = ScalarTypeInfo.Single();
				return true;
			}
			if (type == typeof(double))
			{
				typeInfo = ScalarTypeInfo.Double();
				return true;
			}
			if (type == typeof(Guid))
			{
				typeInfo = ScalarTypeInfo.Guid();
				return true;
			}
			typeInfo = null;
			return false;
		}

		// Token: 0x06008BA4 RID: 35748 RVA: 0x00151E64 File Offset: 0x00150064
		internal bool GetMetadataLength(out uint size)
		{
			size = 0U;
			if (EventParameterInfo.GetTypeCodeExtended(this.ParameterType) == TypeCode.Object)
			{
				InvokeTypeInfo invokeTypeInfo = this.TypeInfo as InvokeTypeInfo;
				if (invokeTypeInfo == null)
				{
					return false;
				}
				size += 8U;
				PropertyAnalysis[] properties = invokeTypeInfo.properties;
				if (properties != null)
				{
					foreach (PropertyAnalysis property in properties)
					{
						size += EventParameterInfo.GetMetadataLengthForProperty(property);
					}
				}
				size += 2U;
			}
			else
			{
				size += (uint)(4 + (this.ParameterName.Length + 1) * 2);
			}
			return true;
		}

		// Token: 0x06008BA5 RID: 35749 RVA: 0x00151EE4 File Offset: 0x001500E4
		private static uint GetMetadataLengthForProperty(PropertyAnalysis property)
		{
			uint num = 0U;
			InvokeTypeInfo invokeTypeInfo = property.typeInfo as InvokeTypeInfo;
			if (invokeTypeInfo != null)
			{
				num += 8U;
				PropertyAnalysis[] properties = invokeTypeInfo.properties;
				if (properties != null)
				{
					foreach (PropertyAnalysis property2 in properties)
					{
						num += EventParameterInfo.GetMetadataLengthForProperty(property2);
					}
				}
				num += (uint)((property.name.Length + 1) * 2);
			}
			else
			{
				num += (uint)(4 + (property.name.Length + 1) * 2);
			}
			return num;
		}

		// Token: 0x06008BA6 RID: 35750 RVA: 0x00151F60 File Offset: 0x00150160
		private static TypeCode GetTypeCodeExtended(Type parameterType)
		{
			if (parameterType == typeof(Guid))
			{
				return (TypeCode)17;
			}
			if (parameterType == typeof(IntPtr))
			{
				return TypeCode.Int64;
			}
			if (parameterType == typeof(UIntPtr))
			{
				return TypeCode.UInt64;
			}
			return Type.GetTypeCode(parameterType);
		}

		// Token: 0x06008BA7 RID: 35751 RVA: 0x00151FBE File Offset: 0x001501BE
		internal bool GetMetadataLengthV2(out uint size)
		{
			return EventParameterInfo.GetMetadataLengthForNamedTypeV2(this.ParameterName, this.TypeInfo, out size);
		}

		// Token: 0x06008BA8 RID: 35752 RVA: 0x00151FD4 File Offset: 0x001501D4
		private static bool GetMetadataLengthForTypeV2(TraceLoggingTypeInfo typeInfo, out uint size)
		{
			size = 0U;
			if (typeInfo == null)
			{
				return false;
			}
			InvokeTypeInfo invokeTypeInfo = typeInfo as InvokeTypeInfo;
			if (invokeTypeInfo != null)
			{
				size += 8U;
				PropertyAnalysis[] properties = invokeTypeInfo.properties;
				if (properties != null)
				{
					foreach (PropertyAnalysis propertyAnalysis in properties)
					{
						uint num;
						if (!EventParameterInfo.GetMetadataLengthForNamedTypeV2(propertyAnalysis.name, propertyAnalysis.typeInfo, out num))
						{
							return false;
						}
						size += num;
					}
				}
			}
			else
			{
				EnumerableTypeInfo enumerableTypeInfo = typeInfo as EnumerableTypeInfo;
				if (enumerableTypeInfo != null)
				{
					size += 4U;
					uint num2;
					if (!EventParameterInfo.GetMetadataLengthForTypeV2(enumerableTypeInfo.ElementInfo, out num2))
					{
						return false;
					}
					size += num2;
				}
				else
				{
					ScalarArrayTypeInfo scalarArrayTypeInfo = typeInfo as ScalarArrayTypeInfo;
					if (scalarArrayTypeInfo != null)
					{
						TraceLoggingTypeInfo typeInfo2;
						if (!scalarArrayTypeInfo.DataType.HasElementType || !EventParameterInfo.GetTypeInfoFromType(scalarArrayTypeInfo.DataType.GetElementType(), out typeInfo2))
						{
							return false;
						}
						size += 4U;
						uint num3;
						if (!EventParameterInfo.GetMetadataLengthForTypeV2(typeInfo2, out num3))
						{
							return false;
						}
						size += num3;
					}
					else
					{
						size += 4U;
					}
				}
			}
			return true;
		}

		// Token: 0x06008BA9 RID: 35753 RVA: 0x001520C4 File Offset: 0x001502C4
		private static bool GetMetadataLengthForNamedTypeV2(string name, TraceLoggingTypeInfo typeInfo, out uint size)
		{
			size = (uint)(4 + (name.Length + 1) * 2);
			uint num;
			if (!EventParameterInfo.GetMetadataLengthForTypeV2(typeInfo, out num))
			{
				return false;
			}
			size += num;
			return true;
		}

		// Token: 0x04001F82 RID: 8066
		internal string ParameterName;

		// Token: 0x04001F83 RID: 8067
		internal Type ParameterType;

		// Token: 0x04001F84 RID: 8068
		internal TraceLoggingTypeInfo TypeInfo;
	}
}
