using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x02000329 RID: 809
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.All)]
	public class DefaultValueAttribute : Attribute
	{
		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06003A0B RID: 14859 RVA: 0x000C1130 File Offset: 0x000BF330
		[FeatureSwitchDefinition("System.ComponentModel.DefaultValueAttribute.IsSupported")]
		[FeatureGuard(typeof(RequiresUnreferencedCodeAttribute))]
		internal static bool IsSupported
		{
			get
			{
				bool flag;
				return !AppContext.TryGetSwitch("System.ComponentModel.DefaultValueAttribute.IsSupported", out flag) || flag;
			}
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x000C1150 File Offset: 0x000BF350
		[NullableContext(1)]
		public DefaultValueAttribute([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type type, [Nullable(2)] string value)
		{
			if (!DefaultValueAttribute.IsSupported)
			{
				this._value = DefaultValueAttribute.s_throwSentinel;
				return;
			}
			if (type == null)
			{
				return;
			}
			try
			{
				object value2;
				if (DefaultValueAttribute.<.ctor>g__TryConvertFromInvariantString|5_0(type, value, out value2))
				{
					this._value = value2;
				}
				else if (type.IsSubclassOf(typeof(Enum)) && value != null)
				{
					this._value = Enum.Parse(type, value, true);
				}
				else if (type == typeof(TimeSpan) && value != null)
				{
					this._value = TimeSpan.Parse(value);
				}
				else
				{
					this._value = Convert.ChangeType(value, type, CultureInfo.InvariantCulture);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x000C120C File Offset: 0x000BF40C
		public DefaultValueAttribute(char value)
		{
			this._value = value;
		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x000C1220 File Offset: 0x000BF420
		public DefaultValueAttribute(byte value)
		{
			this._value = value;
		}

		// Token: 0x06003A0F RID: 14863 RVA: 0x000C1234 File Offset: 0x000BF434
		public DefaultValueAttribute(short value)
		{
			this._value = value;
		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x000C1248 File Offset: 0x000BF448
		public DefaultValueAttribute(int value)
		{
			this._value = value;
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x000C125C File Offset: 0x000BF45C
		public DefaultValueAttribute(long value)
		{
			this._value = value;
		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x000C1270 File Offset: 0x000BF470
		public DefaultValueAttribute(float value)
		{
			this._value = value;
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x000C1284 File Offset: 0x000BF484
		public DefaultValueAttribute(double value)
		{
			this._value = value;
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x000C1298 File Offset: 0x000BF498
		public DefaultValueAttribute(bool value)
		{
			this._value = value;
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x000C12AC File Offset: 0x000BF4AC
		public DefaultValueAttribute(string value)
		{
			this._value = value;
		}

		// Token: 0x06003A16 RID: 14870 RVA: 0x000C12AC File Offset: 0x000BF4AC
		public DefaultValueAttribute(object value)
		{
			this._value = value;
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x000C12BB File Offset: 0x000BF4BB
		[CLSCompliant(false)]
		public DefaultValueAttribute(sbyte value)
		{
			this._value = value;
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x000C12CF File Offset: 0x000BF4CF
		[CLSCompliant(false)]
		public DefaultValueAttribute(ushort value)
		{
			this._value = value;
		}

		// Token: 0x06003A19 RID: 14873 RVA: 0x000C12E3 File Offset: 0x000BF4E3
		[CLSCompliant(false)]
		public DefaultValueAttribute(uint value)
		{
			this._value = value;
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x000C12F7 File Offset: 0x000BF4F7
		[CLSCompliant(false)]
		public DefaultValueAttribute(ulong value)
		{
			this._value = value;
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06003A1B RID: 14875 RVA: 0x000C130B File Offset: 0x000BF50B
		public virtual object Value
		{
			get
			{
				if (!DefaultValueAttribute.IsSupported && this._value == DefaultValueAttribute.s_throwSentinel)
				{
					throw new ArgumentException(SR.RuntimeInstanceNotAllowed);
				}
				return this._value;
			}
		}

		// Token: 0x06003A1C RID: 14876 RVA: 0x000C1334 File Offset: 0x000BF534
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj == this)
			{
				return true;
			}
			DefaultValueAttribute defaultValueAttribute = obj as DefaultValueAttribute;
			if (defaultValueAttribute == null)
			{
				return false;
			}
			if (this.Value == null)
			{
				return defaultValueAttribute.Value == null;
			}
			return this.Value.Equals(defaultValueAttribute.Value);
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x000C1376 File Offset: 0x000BF576
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x000C137E File Offset: 0x000BF57E
		protected void SetValue(object value)
		{
			this._value = value;
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x000C13A0 File Offset: 0x000BF5A0
		[CompilerGenerated]
		[RequiresUnreferencedCode("DefaultValueAttribute usage of TypeConverter is not compatible with trimming.")]
		internal static bool <.ctor>g__TryConvertFromInvariantString|5_0([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type typeToConvert, string stringValue, out object conversionResult)
		{
			conversionResult = null;
			if (DefaultValueAttribute.s_convertFromInvariantString == null)
			{
				Type type = Type.GetType("System.ComponentModel.TypeDescriptor, System.ComponentModel.TypeConverter", false);
				MethodInfo methodInfo = (type != null) ? type.GetMethod("ConvertFromInvariantString", BindingFlags.Static | BindingFlags.NonPublic) : null;
				DefaultValueAttribute.s_convertFromInvariantString = ((methodInfo == null) ? new object() : methodInfo.CreateDelegate<Func<Type, string, object>>());
			}
			Func<Type, string, object> func = DefaultValueAttribute.s_convertFromInvariantString as Func<Type, string, object>;
			if (func == null)
			{
				return false;
			}
			try
			{
				conversionResult = func(typeToConvert, stringValue);
			}
			catch
			{
				return false;
			}
			return true;
		}

		// Token: 0x04000BDD RID: 3037
		private object _value;

		// Token: 0x04000BDE RID: 3038
		private static object s_convertFromInvariantString;

		// Token: 0x04000BDF RID: 3039
		private static readonly object s_throwSentinel = DefaultValueAttribute.IsSupported ? null : new object();
	}
}
