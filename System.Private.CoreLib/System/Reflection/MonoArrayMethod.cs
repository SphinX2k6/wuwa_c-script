using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x0200071A RID: 1818
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class MonoArrayMethod : MethodInfo
	{
		// Token: 0x0600783D RID: 30781 RVA: 0x0011E12B File Offset: 0x0011C32B
		internal MonoArrayMethod(Type arrayClass, string methodName, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
		{
			this.name = methodName;
			this.parent = arrayClass;
			this.ret = returnType;
			this.parameters = (Type[])parameterTypes.Clone();
			this.call_conv = callingConvention;
		}

		// Token: 0x0600783E RID: 30782 RVA: 0x00007B62 File Offset: 0x00005D62
		public override MethodInfo GetBaseDefinition()
		{
			return this;
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x0600783F RID: 30783 RVA: 0x0011E162 File Offset: 0x0011C362
		public override Type ReturnType
		{
			get
			{
				return this.ret;
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06007840 RID: 30784 RVA: 0x0001A4BA File Offset: 0x000186BA
		public override ICustomAttributeProvider ReturnTypeCustomAttributes
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06007841 RID: 30785 RVA: 0x00007B65 File Offset: 0x00005D65
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return MethodImplAttributes.IL;
		}

		// Token: 0x06007842 RID: 30786 RVA: 0x0011E16A File Offset: 0x0011C36A
		public override ParameterInfo[] GetParameters()
		{
			return this.GetParametersInternal();
		}

		// Token: 0x06007843 RID: 30787 RVA: 0x0011E172 File Offset: 0x0011C372
		internal override ParameterInfo[] GetParametersInternal()
		{
			return Array.Empty<ParameterInfo>();
		}

		// Token: 0x06007844 RID: 30788 RVA: 0x00007B65 File Offset: 0x00005D65
		internal override int GetParametersCount()
		{
			return 0;
		}

		// Token: 0x06007845 RID: 30789 RVA: 0x0000FD41 File Offset: 0x0000DF41
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06007846 RID: 30790 RVA: 0x0011E179 File Offset: 0x0011C379
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				return this.mhandle;
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06007847 RID: 30791 RVA: 0x00007B65 File Offset: 0x00005D65
		public override MethodAttributes Attributes
		{
			get
			{
				return MethodAttributes.PrivateScope;
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06007848 RID: 30792 RVA: 0x0011E181 File Offset: 0x0011C381
		public override Type ReflectedType
		{
			get
			{
				return this.parent;
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06007849 RID: 30793 RVA: 0x0011E181 File Offset: 0x0011C381
		public override Type DeclaringType
		{
			get
			{
				return this.parent;
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x0600784A RID: 30794 RVA: 0x0011E189 File Offset: 0x0011C389
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x0600784B RID: 30795 RVA: 0x00009CC2 File Offset: 0x00007EC2
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return CustomAttribute.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x0600784C RID: 30796 RVA: 0x0011B1F4 File Offset: 0x001193F4
		public override object[] GetCustomAttributes(bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, inherit);
		}

		// Token: 0x0600784D RID: 30797 RVA: 0x0011B1FD File Offset: 0x001193FD
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x0600784E RID: 30798 RVA: 0x0011E194 File Offset: 0x0011C394
		public override string ToString()
		{
			string text = string.Empty;
			ParameterInfo[] array = this.GetParameters();
			for (int i = 0; i < array.Length; i++)
			{
				if (i > 0)
				{
					text += ", ";
				}
				text += array[i].ParameterType.Name;
			}
			if (this.ReturnType != null)
			{
				return string.Concat(new string[]
				{
					this.ReturnType.Name,
					" ",
					this.Name,
					"(",
					text,
					")"
				});
			}
			return string.Concat(new string[]
			{
				"void ",
				this.Name,
				"(",
				text,
				")"
			});
		}

		// Token: 0x040015DA RID: 5594
		internal RuntimeMethodHandle mhandle;

		// Token: 0x040015DB RID: 5595
		internal Type parent;

		// Token: 0x040015DC RID: 5596
		internal Type ret;

		// Token: 0x040015DD RID: 5597
		internal Type[] parameters;

		// Token: 0x040015DE RID: 5598
		internal string name;

		// Token: 0x040015DF RID: 5599
		internal int table_idx;

		// Token: 0x040015E0 RID: 5600
		internal CallingConventions call_conv;
	}
}
