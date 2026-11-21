using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200092C RID: 2348
	internal readonly struct PropertyValue
	{
		// Token: 0x06008DC4 RID: 36292 RVA: 0x0015DC59 File Offset: 0x0015BE59
		private PropertyValue(object value)
		{
			this._reference = value;
			this._scalar = default(PropertyValue.Scalar);
			this._scalarLength = 0;
		}

		// Token: 0x06008DC5 RID: 36293 RVA: 0x0015DC75 File Offset: 0x0015BE75
		private PropertyValue(PropertyValue.Scalar scalar, int scalarLength)
		{
			this._reference = null;
			this._scalar = scalar;
			this._scalarLength = scalarLength;
		}

		// Token: 0x06008DC6 RID: 36294 RVA: 0x0015DC8C File Offset: 0x0015BE8C
		private PropertyValue(bool value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsBoolean = value
			}, 1);
		}

		// Token: 0x06008DC7 RID: 36295 RVA: 0x0015DCB4 File Offset: 0x0015BEB4
		private PropertyValue(byte value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsByte = value
			}, 1);
		}

		// Token: 0x06008DC8 RID: 36296 RVA: 0x0015DCDC File Offset: 0x0015BEDC
		private PropertyValue(sbyte value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsSByte = value
			}, 1);
		}

		// Token: 0x06008DC9 RID: 36297 RVA: 0x0015DD04 File Offset: 0x0015BF04
		private PropertyValue(char value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsChar = value
			}, 2);
		}

		// Token: 0x06008DCA RID: 36298 RVA: 0x0015DD2C File Offset: 0x0015BF2C
		private PropertyValue(short value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsInt16 = value
			}, 2);
		}

		// Token: 0x06008DCB RID: 36299 RVA: 0x0015DD54 File Offset: 0x0015BF54
		private PropertyValue(ushort value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsUInt16 = value
			}, 2);
		}

		// Token: 0x06008DCC RID: 36300 RVA: 0x0015DD7C File Offset: 0x0015BF7C
		private PropertyValue(int value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsInt32 = value
			}, 4);
		}

		// Token: 0x06008DCD RID: 36301 RVA: 0x0015DDA4 File Offset: 0x0015BFA4
		private PropertyValue(uint value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsUInt32 = value
			}, 4);
		}

		// Token: 0x06008DCE RID: 36302 RVA: 0x0015DDCC File Offset: 0x0015BFCC
		private PropertyValue(long value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsInt64 = value
			}, 8);
		}

		// Token: 0x06008DCF RID: 36303 RVA: 0x0015DDF4 File Offset: 0x0015BFF4
		private PropertyValue(ulong value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsUInt64 = value
			}, 8);
		}

		// Token: 0x06008DD0 RID: 36304 RVA: 0x0015DE1C File Offset: 0x0015C01C
		private PropertyValue(IntPtr value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsIntPtr = value
			}, 8);
		}

		// Token: 0x06008DD1 RID: 36305 RVA: 0x0015DE48 File Offset: 0x0015C048
		private PropertyValue(UIntPtr value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsUIntPtr = value
			}, 8);
		}

		// Token: 0x06008DD2 RID: 36306 RVA: 0x0015DE74 File Offset: 0x0015C074
		private PropertyValue(float value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsSingle = value
			}, 4);
		}

		// Token: 0x06008DD3 RID: 36307 RVA: 0x0015DE9C File Offset: 0x0015C09C
		private PropertyValue(double value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsDouble = value
			}, 8);
		}

		// Token: 0x06008DD4 RID: 36308 RVA: 0x0015DEC4 File Offset: 0x0015C0C4
		private PropertyValue(Guid value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsGuid = value
			}, sizeof(Guid));
		}

		// Token: 0x06008DD5 RID: 36309 RVA: 0x0015DEF0 File Offset: 0x0015C0F0
		private PropertyValue(DateTime value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsDateTime = value
			}, sizeof(DateTime));
		}

		// Token: 0x06008DD6 RID: 36310 RVA: 0x0015DF1C File Offset: 0x0015C11C
		private PropertyValue(DateTimeOffset value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsDateTimeOffset = value
			}, sizeof(DateTimeOffset));
		}

		// Token: 0x06008DD7 RID: 36311 RVA: 0x0015DF48 File Offset: 0x0015C148
		private PropertyValue(TimeSpan value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsTimeSpan = value
			}, sizeof(TimeSpan));
		}

		// Token: 0x06008DD8 RID: 36312 RVA: 0x0015DF74 File Offset: 0x0015C174
		private PropertyValue(decimal value)
		{
			this = new PropertyValue(new PropertyValue.Scalar
			{
				AsDecimal = value
			}, 16);
		}

		// Token: 0x06008DD9 RID: 36313 RVA: 0x0015DF9C File Offset: 0x0015C19C
		public static Func<object, PropertyValue> GetFactory(Type type)
		{
			if (type == typeof(bool))
			{
				return (object value) => new PropertyValue((bool)value);
			}
			if (type == typeof(byte))
			{
				return (object value) => new PropertyValue((byte)value);
			}
			if (type == typeof(sbyte))
			{
				return (object value) => new PropertyValue((sbyte)value);
			}
			if (type == typeof(char))
			{
				return (object value) => new PropertyValue((char)value);
			}
			if (type == typeof(short))
			{
				return (object value) => new PropertyValue((short)value);
			}
			if (type == typeof(ushort))
			{
				return (object value) => new PropertyValue((ushort)value);
			}
			if (type == typeof(int))
			{
				return (object value) => new PropertyValue((int)value);
			}
			if (type == typeof(uint))
			{
				return (object value) => new PropertyValue((uint)value);
			}
			if (type == typeof(long))
			{
				return (object value) => new PropertyValue((long)value);
			}
			if (type == typeof(ulong))
			{
				return (object value) => new PropertyValue((ulong)value);
			}
			if (type == typeof(IntPtr))
			{
				return (object value) => new PropertyValue((IntPtr)value);
			}
			if (type == typeof(UIntPtr))
			{
				return (object value) => new PropertyValue((UIntPtr)value);
			}
			if (type == typeof(float))
			{
				return (object value) => new PropertyValue((float)value);
			}
			if (type == typeof(double))
			{
				return (object value) => new PropertyValue((double)value);
			}
			if (type == typeof(Guid))
			{
				return (object value) => new PropertyValue((Guid)value);
			}
			if (type == typeof(DateTime))
			{
				return (object value) => new PropertyValue((DateTime)value);
			}
			if (type == typeof(DateTimeOffset))
			{
				return (object value) => new PropertyValue((DateTimeOffset)value);
			}
			if (type == typeof(TimeSpan))
			{
				return (object value) => new PropertyValue((TimeSpan)value);
			}
			if (type == typeof(decimal))
			{
				return (object value) => new PropertyValue((decimal)value);
			}
			return (object value) => new PropertyValue(value);
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x06008DDA RID: 36314 RVA: 0x0015E37E File Offset: 0x0015C57E
		public object ReferenceValue
		{
			get
			{
				return this._reference;
			}
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x06008DDB RID: 36315 RVA: 0x0015E386 File Offset: 0x0015C586
		public PropertyValue.Scalar ScalarValue
		{
			get
			{
				return this._scalar;
			}
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06008DDC RID: 36316 RVA: 0x0015E38E File Offset: 0x0015C58E
		public int ScalarLength
		{
			get
			{
				return this._scalarLength;
			}
		}

		// Token: 0x06008DDD RID: 36317 RVA: 0x0015E396 File Offset: 0x0015C596
		public static Func<PropertyValue, PropertyValue> GetPropertyGetter(PropertyInfo property)
		{
			if (property.DeclaringType.IsValueType)
			{
				return PropertyValue.GetBoxedValueTypePropertyGetter(property);
			}
			return PropertyValue.GetReferenceTypePropertyGetter(property);
		}

		// Token: 0x06008DDE RID: 36318 RVA: 0x0015E3B4 File Offset: 0x0015C5B4
		private static Func<PropertyValue, PropertyValue> GetBoxedValueTypePropertyGetter(PropertyInfo property)
		{
			Type type = property.PropertyType;
			if (type.IsEnum)
			{
				type = Enum.GetUnderlyingType(type);
			}
			Func<object, PropertyValue> factory = PropertyValue.GetFactory(type);
			return (PropertyValue container) => factory(property.GetValue(container.ReferenceValue));
		}

		// Token: 0x06008DDF RID: 36319 RVA: 0x0015E3FF File Offset: 0x0015C5FF
		[UnconditionalSuppressMessage("AotAnalysis", "IL3050:AotUnfriendlyApi", Justification = "Instantiation over a reference type. See comments above.")]
		private static Func<PropertyValue, PropertyValue> GetReferenceTypePropertyGetter(PropertyInfo property)
		{
			return ((PropertyValue.TypeHelper)Activator.CreateInstance(typeof(PropertyValue.ReferenceTypeHelper<>).MakeGenericType(new Type[]
			{
				property.DeclaringType
			}))).GetPropertyGetter(property);
		}

		// Token: 0x0400210E RID: 8462
		private readonly object _reference;

		// Token: 0x0400210F RID: 8463
		private readonly PropertyValue.Scalar _scalar;

		// Token: 0x04002110 RID: 8464
		private readonly int _scalarLength;

		// Token: 0x0200092D RID: 2349
		[StructLayout(LayoutKind.Explicit)]
		public struct Scalar
		{
			// Token: 0x04002111 RID: 8465
			[FieldOffset(0)]
			public bool AsBoolean;

			// Token: 0x04002112 RID: 8466
			[FieldOffset(0)]
			public byte AsByte;

			// Token: 0x04002113 RID: 8467
			[FieldOffset(0)]
			public sbyte AsSByte;

			// Token: 0x04002114 RID: 8468
			[FieldOffset(0)]
			public char AsChar;

			// Token: 0x04002115 RID: 8469
			[FieldOffset(0)]
			public short AsInt16;

			// Token: 0x04002116 RID: 8470
			[FieldOffset(0)]
			public ushort AsUInt16;

			// Token: 0x04002117 RID: 8471
			[FieldOffset(0)]
			public int AsInt32;

			// Token: 0x04002118 RID: 8472
			[FieldOffset(0)]
			public uint AsUInt32;

			// Token: 0x04002119 RID: 8473
			[FieldOffset(0)]
			public long AsInt64;

			// Token: 0x0400211A RID: 8474
			[FieldOffset(0)]
			public ulong AsUInt64;

			// Token: 0x0400211B RID: 8475
			[FieldOffset(0)]
			public IntPtr AsIntPtr;

			// Token: 0x0400211C RID: 8476
			[FieldOffset(0)]
			public UIntPtr AsUIntPtr;

			// Token: 0x0400211D RID: 8477
			[FieldOffset(0)]
			public float AsSingle;

			// Token: 0x0400211E RID: 8478
			[FieldOffset(0)]
			public double AsDouble;

			// Token: 0x0400211F RID: 8479
			[FieldOffset(0)]
			public Guid AsGuid;

			// Token: 0x04002120 RID: 8480
			[FieldOffset(0)]
			public DateTime AsDateTime;

			// Token: 0x04002121 RID: 8481
			[FieldOffset(0)]
			public DateTimeOffset AsDateTimeOffset;

			// Token: 0x04002122 RID: 8482
			[FieldOffset(0)]
			public TimeSpan AsTimeSpan;

			// Token: 0x04002123 RID: 8483
			[FieldOffset(0)]
			public decimal AsDecimal;
		}

		// Token: 0x0200092E RID: 2350
		private abstract class TypeHelper
		{
			// Token: 0x06008DE0 RID: 36320
			public abstract Func<PropertyValue, PropertyValue> GetPropertyGetter(PropertyInfo property);

			// Token: 0x06008DE1 RID: 36321 RVA: 0x0015E42F File Offset: 0x0015C62F
			[UnconditionalSuppressMessage("AotAnalysis", "IL3050:AotUnfriendlyApi", Justification = "Instantiation over a reference type. See comments above.")]
			protected static Delegate GetGetMethod(PropertyInfo property, Type propertyType)
			{
				return property.GetMethod.CreateDelegate(typeof(Func<, >).MakeGenericType(new Type[]
				{
					property.DeclaringType,
					propertyType
				}));
			}
		}

		// Token: 0x0200092F RID: 2351
		private sealed class ReferenceTypeHelper<TContainer> : PropertyValue.TypeHelper where TContainer : class
		{
			// Token: 0x06008DE3 RID: 36323 RVA: 0x0015E45E File Offset: 0x0015C65E
			private static Func<TContainer, TProperty> GetGetMethod<TProperty>(PropertyInfo property) where TProperty : struct
			{
				return property.GetMethod.CreateDelegate<Func<TContainer, TProperty>>();
			}

			// Token: 0x06008DE4 RID: 36324 RVA: 0x0015E46C File Offset: 0x0015C66C
			public override Func<PropertyValue, PropertyValue> GetPropertyGetter(PropertyInfo property)
			{
				Type type = property.PropertyType;
				if (!type.IsValueType)
				{
					Func<TContainer, object> getter = (Func<TContainer, object>)PropertyValue.TypeHelper.GetGetMethod(property, type);
					return (PropertyValue container) => new PropertyValue(getter((TContainer)((object)container.ReferenceValue)));
				}
				if (type.IsEnum)
				{
					type = Enum.GetUnderlyingType(type);
				}
				if (type == typeof(bool))
				{
					Func<TContainer, bool> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<bool>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(byte))
				{
					Func<TContainer, byte> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<byte>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(sbyte))
				{
					Func<TContainer, sbyte> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<sbyte>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(char))
				{
					Func<TContainer, char> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<char>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(short))
				{
					Func<TContainer, short> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<short>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(ushort))
				{
					Func<TContainer, ushort> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<ushort>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(int))
				{
					Func<TContainer, int> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<int>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(uint))
				{
					Func<TContainer, uint> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<uint>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(long))
				{
					Func<TContainer, long> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<long>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(ulong))
				{
					Func<TContainer, ulong> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<ulong>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(IntPtr))
				{
					Func<TContainer, IntPtr> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<IntPtr>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(UIntPtr))
				{
					Func<TContainer, UIntPtr> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<UIntPtr>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(float))
				{
					Func<TContainer, float> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<float>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(double))
				{
					Func<TContainer, double> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<double>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(Guid))
				{
					Func<TContainer, Guid> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<Guid>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(DateTime))
				{
					Func<TContainer, DateTime> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<DateTime>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(DateTimeOffset))
				{
					Func<TContainer, DateTimeOffset> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<DateTimeOffset>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(TimeSpan))
				{
					Func<TContainer, TimeSpan> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<TimeSpan>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				if (type == typeof(decimal))
				{
					Func<TContainer, decimal> f = PropertyValue.ReferenceTypeHelper<TContainer>.GetGetMethod<decimal>(property);
					return (PropertyValue container) => new PropertyValue(f((TContainer)((object)container.ReferenceValue)));
				}
				return (PropertyValue container) => new PropertyValue(property.GetValue(container.ReferenceValue));
			}
		}
	}
}
