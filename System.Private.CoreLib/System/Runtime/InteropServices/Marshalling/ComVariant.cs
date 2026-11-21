using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.Marshalling
{
	// Token: 0x0200060F RID: 1551
	[StructLayout(LayoutKind.Explicit)]
	public struct ComVariant : IDisposable
	{
		// Token: 0x060071E4 RID: 29156 RVA: 0x00110C58 File Offset: 0x0010EE58
		public unsafe void Dispose()
		{
			fixed (ComVariant* ptr = &this)
			{
				void* pObject = (void*)ptr;
				Interop.Ole32.PropVariantClear(pObject);
			}
		}

		// Token: 0x060071E5 RID: 29157 RVA: 0x00110C74 File Offset: 0x0010EE74
		[NullableContext(1)]
		public static ComVariant Create<[Nullable(2)] T>([DisallowNull] T value)
		{
			ComVariant @null;
			Unsafe.SkipInit<ComVariant>(out @null);
			if (typeof(T) == typeof(DBNull))
			{
				@null = ComVariant.Null;
			}
			else if (typeof(T) == typeof(short))
			{
				@null.VarType = VarEnum.VT_I2;
				@null._typeUnion._unionTypes._i2 = (short)((object)value);
			}
			else if (typeof(T) == typeof(int))
			{
				@null.VarType = VarEnum.VT_I4;
				@null._typeUnion._unionTypes._i4 = (int)((object)value);
			}
			else if (typeof(T) == typeof(float))
			{
				@null.VarType = VarEnum.VT_R4;
				@null._typeUnion._unionTypes._r4 = (float)((object)value);
			}
			else if (typeof(T) == typeof(double))
			{
				@null.VarType = VarEnum.VT_R8;
				@null._typeUnion._unionTypes._r8 = (double)((object)value);
			}
			else if (typeof(T) == typeof(CurrencyWrapper))
			{
				@null.VarType = VarEnum.VT_CY;
				@null._typeUnion._unionTypes._cy = decimal.ToOACurrency(((CurrencyWrapper)((object)value)).WrappedObject);
			}
			else if (typeof(T) == typeof(DateTime))
			{
				@null.VarType = VarEnum.VT_DATE;
				@null._typeUnion._unionTypes._date = ((DateTime)((object)value)).ToOADate();
			}
			else if (typeof(T) == typeof(BStrWrapper))
			{
				@null.VarType = VarEnum.VT_BSTR;
				@null._typeUnion._unionTypes._bstr = Marshal.StringToBSTR(((BStrWrapper)((object)value)).WrappedObject);
			}
			else if (typeof(T) == typeof(string))
			{
				@null.VarType = VarEnum.VT_BSTR;
				@null._typeUnion._unionTypes._bstr = Marshal.StringToBSTR((string)((object)value));
			}
			else if (typeof(T) == typeof(ErrorWrapper))
			{
				@null.VarType = VarEnum.VT_ERROR;
				@null._typeUnion._unionTypes._error = ((ErrorWrapper)((object)value)).ErrorCode;
			}
			else if (typeof(T) == typeof(bool))
			{
				@null.VarType = VarEnum.VT_BOOL;
				@null._typeUnion._unionTypes._bool = (((bool)((object)value)) ? -1 : 0);
			}
			else if (typeof(T) == typeof(decimal))
			{
				@null._decimal = (decimal)((object)value);
				@null.VarType = VarEnum.VT_DECIMAL;
			}
			else if (typeof(T) == typeof(sbyte))
			{
				@null.VarType = VarEnum.VT_I1;
				@null._typeUnion._unionTypes._i1 = (sbyte)((object)value);
			}
			else if (typeof(T) == typeof(byte))
			{
				@null.VarType = VarEnum.VT_UI1;
				@null._typeUnion._unionTypes._ui1 = (byte)((object)value);
			}
			else if (typeof(T) == typeof(ushort))
			{
				@null.VarType = VarEnum.VT_UI2;
				@null._typeUnion._unionTypes._ui2 = (ushort)((object)value);
			}
			else if (typeof(T) == typeof(uint))
			{
				@null.VarType = VarEnum.VT_UI4;
				@null._typeUnion._unionTypes._ui4 = (uint)((object)value);
			}
			else if (typeof(T) == typeof(long))
			{
				@null.VarType = VarEnum.VT_I8;
				@null._typeUnion._unionTypes._i8 = (long)((object)value);
			}
			else
			{
				if (!(typeof(T) == typeof(ulong)))
				{
					throw new ArgumentException(SR.UnsupportedType, "T");
				}
				@null.VarType = VarEnum.VT_UI8;
				@null._typeUnion._unionTypes._ui8 = (ulong)((object)value);
			}
			return @null;
		}

		// Token: 0x060071E6 RID: 29158 RVA: 0x00111168 File Offset: 0x0010F368
		public static ComVariant CreateRaw<[IsUnmanaged] T>(VarEnum vt, T rawValue) where T : struct, ValueType
		{
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(sizeof(T), sizeof(ComVariant.UnionTypes), "T");
			if (vt == VarEnum.VT_DECIMAL)
			{
				throw new ArgumentException(SR.ComVariant_VT_DECIMAL_NotSupported_CreateRaw, "vt");
			}
			if (vt == VarEnum.VT_VARIANT)
			{
				throw new ArgumentException(SR.ComVariant_VT_VARIANT_In_Variant, "vt");
			}
			if (!vt.HasFlag(VarEnum.VT_ARRAY) || !true)
			{
			}
			ComVariant result;
			Unsafe.SkipInit<ComVariant>(out result);
			result.VarType = vt;
			ref T rawDataRef = ref result.GetRawDataRef<T>();
			ValueTuple<VarEnum, int> valueTuple = new ValueTuple<VarEnum, int>(vt, sizeof(T));
			VarEnum item = valueTuple.Item1;
			T t;
			switch (item)
			{
			case VarEnum.VT_I2:
			case VarEnum.VT_BOOL:
			case VarEnum.VT_UI2:
				if (valueTuple.Item2 != 2)
				{
					goto IL_205;
				}
				t = rawValue;
				goto IL_2DA;
			case VarEnum.VT_I4:
			case VarEnum.VT_R4:
			case VarEnum.VT_ERROR:
			case VarEnum.VT_UI4:
			case VarEnum.VT_INT:
			case VarEnum.VT_UINT:
			case VarEnum.VT_HRESULT:
				if (valueTuple.Item2 != 4)
				{
					goto IL_205;
				}
				t = rawValue;
				goto IL_2DA;
			case VarEnum.VT_R8:
			case VarEnum.VT_DATE:
			case VarEnum.VT_I8:
			case VarEnum.VT_UI8:
				if (valueTuple.Item2 != 8)
				{
					goto IL_205;
				}
				t = rawValue;
				goto IL_2DA;
			case VarEnum.VT_CY:
				break;
			case VarEnum.VT_BSTR:
			case VarEnum.VT_DISPATCH:
			case VarEnum.VT_UNKNOWN:
			case VarEnum.VT_SAFEARRAY:
			case VarEnum.VT_LPSTR:
			case VarEnum.VT_LPWSTR:
				goto IL_1D5;
			case VarEnum.VT_VARIANT:
			case VarEnum.VT_DECIMAL:
			case (VarEnum)15:
			case VarEnum.VT_VOID:
			case VarEnum.VT_PTR:
			case VarEnum.VT_CARRAY:
			case VarEnum.VT_USERDEFINED:
			case (VarEnum)32:
			case (VarEnum)33:
			case (VarEnum)34:
			case (VarEnum)35:
				goto IL_209;
			case VarEnum.VT_I1:
			case VarEnum.VT_UI1:
				if (valueTuple.Item2 != 1)
				{
					goto IL_205;
				}
				t = rawValue;
				goto IL_2DA;
			case VarEnum.VT_RECORD:
				goto IL_1F0;
			default:
				switch (item)
				{
				case VarEnum.VT_FILETIME:
					break;
				case VarEnum.VT_BLOB:
				case VarEnum.VT_BLOB_OBJECT:
					goto IL_209;
				case VarEnum.VT_STREAM:
				case VarEnum.VT_STORAGE:
				case VarEnum.VT_STREAMED_OBJECT:
				case VarEnum.VT_STORED_OBJECT:
				case VarEnum.VT_CF:
				case VarEnum.VT_CLSID:
				case (VarEnum)73:
					goto IL_1D5;
				default:
					if (item != (VarEnum)16420)
					{
						goto IL_209;
					}
					goto IL_1F0;
				}
				break;
			}
			if (valueTuple.Item2 != 8)
			{
				goto IL_205;
			}
			t = rawValue;
			goto IL_2DA;
			IL_1D5:
			if (sizeof(T) == 8)
			{
				t = rawValue;
				goto IL_2DA;
			}
			goto IL_205;
			IL_1F0:
			if (sizeof(T) == sizeof(ComVariant.Record))
			{
				t = rawValue;
				goto IL_2DA;
			}
			IL_205:
			int num = 2;
			goto IL_20B;
			IL_209:
			num = 5;
			IL_20B:
			if (!vt.HasFlag(VarEnum.VT_BYREF) || sizeof(T) != 8)
			{
				if (num != 2)
				{
					if (num != 5)
					{
						goto IL_237;
					}
					num = 6;
				}
				else
				{
					num = 3;
				}
				if (!vt.HasFlag(VarEnum.VT_VECTOR) || sizeof(T) != sizeof(ComVariant.Vector<byte>))
				{
					if (num != 3)
					{
						if (num != 6)
						{
							goto IL_271;
						}
						num = 7;
					}
					else
					{
						num = 4;
					}
					if (!vt.HasFlag(VarEnum.VT_ARRAY) || sizeof(T) != 8)
					{
						if (num != 4)
						{
							if (num != 7)
							{
								goto IL_2AA;
							}
							if (item == VarEnum.VT_BLOB || item == VarEnum.VT_BLOB_OBJECT)
							{
								if (sizeof(T) == sizeof(ComVariant.Blob))
								{
									t = rawValue;
									goto IL_2DA;
								}
							}
						}
						throw new ArgumentException(SR.Format(SR.ComVariant_SizeMustMatchVariantSize, "T", "vt"));
					}
					IL_2AA:
					t = rawValue;
					goto IL_2DA;
				}
				IL_271:
				t = rawValue;
				goto IL_2DA;
			}
			IL_237:
			t = rawValue;
			IL_2DA:
			rawDataRef = t;
			return result;
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x060071E7 RID: 29159 RVA: 0x00111457 File Offset: 0x0010F657
		public static ComVariant Null { get; } = new ComVariant
		{
			VarType = VarEnum.VT_NULL
		};

		// Token: 0x060071E8 RID: 29160 RVA: 0x0011145E File Offset: 0x0010F65E
		private readonly void ThrowIfNotVarType(params VarEnum[] requiredType)
		{
			if (Array.IndexOf<VarEnum>(requiredType, this.VarType) == -1)
			{
				throw new InvalidOperationException(SR.Format(SR.ComVariant_TypeIsNotSupportedType, this.VarType, string.Join<VarEnum>(", ", requiredType)));
			}
		}

		// Token: 0x060071E9 RID: 29161 RVA: 0x00111498 File Offset: 0x0010F698
		[NullableContext(2)]
		public readonly T As<T>()
		{
			if (this.VarType == VarEnum.VT_EMPTY)
			{
				return default(T);
			}
			if (typeof(T) == typeof(DBNull))
			{
				this.ThrowIfNotVarType(new VarEnum[]
				{
					VarEnum.VT_NULL
				});
				return (T)((object)DBNull.Value);
			}
			if (typeof(T) == typeof(short))
			{
				this.ThrowIfNotVarType(new VarEnum[]
				{
					VarEnum.VT_I2
				});
				return (T)((object)this._typeUnion._unionTypes._i2);
			}
			if (typeof(T) == typeof(int))
			{
				this.ThrowIfNotVarType(new VarEnum[]
				{
					VarEnum.VT_I4,
					VarEnum.VT_ERROR,
					VarEnum.VT_INT
				});
				return (T)((object)this._typeUnion._unionTypes._i4);
			}
			if (typeof(T) == typeof(float))
			{
				this.ThrowIfNotVarType(new VarEnum[]
				{
					VarEnum.VT_R4
				});
				return (T)((object)this._typeUnion._unionTypes._r4);
			}
			if (typeof(T) == typeof(double))
			{
				this.ThrowIfNotVarType(new VarEnum[]
				{
					VarEnum.VT_R8
				});
				return (T)((object)this._typeUnion._unionTypes._r8);
			}
			if (typeof(T) == typeof(CurrencyWrapper))
			{
				this.ThrowIfNotVarType(new VarEnum[]
				{
					VarEnum.VT_CY
				});
				return (T)((object)new CurrencyWrapper(decimal.FromOACurrency(this._typeUnion._unionTypes._cy)));
			}
			if (typeof(T) == typeof(DateTime))
			{
				this.ThrowIfNotVarType(new VarEnum[]
				{
					VarEnum.VT_DATE
				});
				return (T)((object)DateTime.FromOADate(this._typeUnion._unionTypes._date));
			}
			if (typeof(T) == typeof(BStrWrapper))
			{
				this.ThrowIfNotVarType(new VarEnum[]
				{
					VarEnum.VT_BSTR
				});
				return (T)((object)new BStrWrapper(Marshal.PtrToStringBSTR(this._typeUnion._unionTypes._bstr)));
			}
			if (typeof(T) == typeof(string))
			{
				this.ThrowIfNotVarType(new VarEnum[]
				{
					VarEnum.VT_BSTR
				});
				if (this._typeUnion._unionTypes._bstr == IntPtr.Zero)
				{
					return default(T);
				}
				return (T)((object)Marshal.PtrToStringBSTR(this._typeUnion._unionTypes._bstr));
			}
			else
			{
				if (typeof(T) == typeof(ErrorWrapper))
				{
					this.ThrowIfNotVarType(new VarEnum[]
					{
						VarEnum.VT_ERROR
					});
					return (T)((object)new ErrorWrapper(this._typeUnion._unionTypes._error));
				}
				if (typeof(T) == typeof(bool))
				{
					this.ThrowIfNotVarType(new VarEnum[]
					{
						VarEnum.VT_BOOL
					});
					return (T)((object)(this._typeUnion._unionTypes._bool != 0));
				}
				if (typeof(T) == typeof(decimal))
				{
					this.ThrowIfNotVarType(new VarEnum[]
					{
						VarEnum.VT_DECIMAL
					});
					ComVariant comVariant = this;
					comVariant.VarType = VarEnum.VT_EMPTY;
					return (T)((object)comVariant._decimal);
				}
				if (typeof(T) == typeof(sbyte))
				{
					this.ThrowIfNotVarType(new VarEnum[]
					{
						VarEnum.VT_I1
					});
					return (T)((object)this._typeUnion._unionTypes._i1);
				}
				if (typeof(T) == typeof(byte))
				{
					this.ThrowIfNotVarType(new VarEnum[]
					{
						VarEnum.VT_UI1
					});
					return (T)((object)this._typeUnion._unionTypes._ui1);
				}
				if (typeof(T) == typeof(ushort))
				{
					this.ThrowIfNotVarType(new VarEnum[]
					{
						VarEnum.VT_UI2
					});
					return (T)((object)this._typeUnion._unionTypes._ui2);
				}
				if (typeof(T) == typeof(uint))
				{
					this.ThrowIfNotVarType(new VarEnum[]
					{
						VarEnum.VT_UI4,
						VarEnum.VT_UINT
					});
					return (T)((object)this._typeUnion._unionTypes._ui4);
				}
				if (typeof(T) == typeof(long))
				{
					this.ThrowIfNotVarType(new VarEnum[]
					{
						VarEnum.VT_I8
					});
					return (T)((object)this._typeUnion._unionTypes._i8);
				}
				if (typeof(T) == typeof(ulong))
				{
					this.ThrowIfNotVarType(new VarEnum[]
					{
						VarEnum.VT_UI8
					});
					return (T)((object)this._typeUnion._unionTypes._ui8);
				}
				throw new ArgumentException(SR.UnsupportedType, "T");
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x060071EA RID: 29162 RVA: 0x001119EF File Offset: 0x0010FBEF
		// (set) Token: 0x060071EB RID: 29163 RVA: 0x001119FC File Offset: 0x0010FBFC
		public VarEnum VarType
		{
			readonly get
			{
				return (VarEnum)this._typeUnion._vt;
			}
			private set
			{
				this._typeUnion._vt = (ushort)value;
			}
		}

		// Token: 0x060071EC RID: 29164 RVA: 0x00111A0C File Offset: 0x0010FC0C
		[UnscopedRef]
		public ref T GetRawDataRef<[IsUnmanaged] T>() where T : struct, ValueType
		{
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(sizeof(T), sizeof(ComVariant.UnionTypes), "T");
			if (typeof(T) == typeof(decimal))
			{
				throw new ArgumentException(SR.ComVariant_VT_DECIMAL_NotSupported_RawDataRef, "T");
			}
			return Unsafe.As<ComVariant.UnionTypes, T>(ref this._typeUnion._unionTypes);
		}

		// Token: 0x04001348 RID: 4936
		[FieldOffset(0)]
		private ComVariant.TypeUnion _typeUnion;

		// Token: 0x04001349 RID: 4937
		[FieldOffset(0)]
		private decimal _decimal;

		// Token: 0x02000610 RID: 1552
		private struct TypeUnion
		{
			// Token: 0x0400134B RID: 4939
			public ushort _vt;

			// Token: 0x0400134C RID: 4940
			public ushort _wReserved1;

			// Token: 0x0400134D RID: 4941
			public ushort _wReserved2;

			// Token: 0x0400134E RID: 4942
			public ushort _wReserved3;

			// Token: 0x0400134F RID: 4943
			public ComVariant.UnionTypes _unionTypes;
		}

		// Token: 0x02000611 RID: 1553
		private struct Record
		{
			// Token: 0x04001350 RID: 4944
			public IntPtr _record;

			// Token: 0x04001351 RID: 4945
			public IntPtr _recordInfo;
		}

		// Token: 0x02000612 RID: 1554
		private struct Blob
		{
			// Token: 0x04001352 RID: 4946
			public int _size;

			// Token: 0x04001353 RID: 4947
			public IntPtr _data;
		}

		// Token: 0x02000613 RID: 1555
		private struct Vector<[IsUnmanaged] T> where T : struct, ValueType
		{
			// Token: 0x04001354 RID: 4948
			public int _numElements;

			// Token: 0x04001355 RID: 4949
			public unsafe T* _data;
		}

		// Token: 0x02000614 RID: 1556
		private struct VersionedStream
		{
			// Token: 0x04001356 RID: 4950
			public Guid _version;

			// Token: 0x04001357 RID: 4951
			public IntPtr _stream;
		}

		// Token: 0x02000615 RID: 1557
		private struct ClipboardData
		{
			// Token: 0x04001358 RID: 4952
			public uint _size;

			// Token: 0x04001359 RID: 4953
			public int _format;

			// Token: 0x0400135A RID: 4954
			public IntPtr _data;
		}

		// Token: 0x02000616 RID: 1558
		[StructLayout(LayoutKind.Explicit)]
		private struct UnionTypes
		{
			// Token: 0x0400135B RID: 4955
			[FieldOffset(0)]
			public sbyte _i1;

			// Token: 0x0400135C RID: 4956
			[FieldOffset(0)]
			public short _i2;

			// Token: 0x0400135D RID: 4957
			[FieldOffset(0)]
			public int _i4;

			// Token: 0x0400135E RID: 4958
			[FieldOffset(0)]
			public long _i8;

			// Token: 0x0400135F RID: 4959
			[FieldOffset(0)]
			public byte _ui1;

			// Token: 0x04001360 RID: 4960
			[FieldOffset(0)]
			public ushort _ui2;

			// Token: 0x04001361 RID: 4961
			[FieldOffset(0)]
			public uint _ui4;

			// Token: 0x04001362 RID: 4962
			[FieldOffset(0)]
			public ulong _ui8;

			// Token: 0x04001363 RID: 4963
			[FieldOffset(0)]
			public int _int;

			// Token: 0x04001364 RID: 4964
			[FieldOffset(0)]
			public uint _uint;

			// Token: 0x04001365 RID: 4965
			[FieldOffset(0)]
			public short _bool;

			// Token: 0x04001366 RID: 4966
			[FieldOffset(0)]
			public int _error;

			// Token: 0x04001367 RID: 4967
			[FieldOffset(0)]
			public float _r4;

			// Token: 0x04001368 RID: 4968
			[FieldOffset(0)]
			public double _r8;

			// Token: 0x04001369 RID: 4969
			[FieldOffset(0)]
			public long _cy;

			// Token: 0x0400136A RID: 4970
			[FieldOffset(0)]
			public double _date;

			// Token: 0x0400136B RID: 4971
			[FieldOffset(0)]
			public IntPtr _bstr;

			// Token: 0x0400136C RID: 4972
			[FieldOffset(0)]
			public IntPtr _unknown;

			// Token: 0x0400136D RID: 4973
			[FieldOffset(0)]
			public IntPtr _dispatch;

			// Token: 0x0400136E RID: 4974
			[FieldOffset(0)]
			public IntPtr _pvarVal;

			// Token: 0x0400136F RID: 4975
			[FieldOffset(0)]
			public IntPtr _byref;

			// Token: 0x04001370 RID: 4976
			[FieldOffset(0)]
			public ComVariant.Record _record;

			// Token: 0x04001371 RID: 4977
			[FieldOffset(0)]
			public ComVariant.Blob _blob;

			// Token: 0x04001372 RID: 4978
			[FieldOffset(0)]
			public unsafe ComVariant.VersionedStream* _versionedStream;

			// Token: 0x04001373 RID: 4979
			[FieldOffset(0)]
			public unsafe ComVariant.ClipboardData* clipboardData;
		}
	}
}
