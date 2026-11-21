using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace System.Reflection.Emit
{
	// Token: 0x02000799 RID: 1945
	internal sealed class ConstructorOnTypeBuilderInstantiation : ConstructorInfo
	{
		// Token: 0x06007BD4 RID: 31700 RVA: 0x001243DC File Offset: 0x001225DC
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2075:UnrecognizedReflectionPattern", Justification = "Reflection.Emit is not subject to trimming")]
		internal ConstructorInfo RuntimeResolve()
		{
			return this._type.InternalResolve().GetConstructor(this._ctor);
		}

		// Token: 0x06007BD5 RID: 31701 RVA: 0x001243F4 File Offset: 0x001225F4
		internal override int GetParametersCount()
		{
			return this._ctor.GetParametersCount();
		}

		// Token: 0x06007BD6 RID: 31702 RVA: 0x00124401 File Offset: 0x00122601
		internal static ConstructorInfo GetConstructor(ConstructorInfo constructor, TypeBuilderInstantiation type)
		{
			return new ConstructorOnTypeBuilderInstantiation(constructor, type);
		}

		// Token: 0x06007BD7 RID: 31703 RVA: 0x0012440A File Offset: 0x0012260A
		internal ConstructorOnTypeBuilderInstantiation(ConstructorInfo constructor, TypeBuilderInstantiation type)
		{
			this._ctor = constructor;
			this._type = type;
		}

		// Token: 0x06007BD8 RID: 31704 RVA: 0x00124420 File Offset: 0x00122620
		internal override Type[] GetParameterTypes()
		{
			return this._ctor.GetParameterTypes();
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06007BD9 RID: 31705 RVA: 0x0012442D File Offset: 0x0012262D
		public override MemberTypes MemberType
		{
			get
			{
				return this._ctor.MemberType;
			}
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x06007BDA RID: 31706 RVA: 0x0012443A File Offset: 0x0012263A
		public override string Name
		{
			get
			{
				return this._ctor.Name;
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x06007BDB RID: 31707 RVA: 0x00124447 File Offset: 0x00122647
		public override Type DeclaringType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x06007BDC RID: 31708 RVA: 0x00124447 File Offset: 0x00122647
		public override Type ReflectedType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x06007BDD RID: 31709 RVA: 0x0012444F File Offset: 0x0012264F
		public override object[] GetCustomAttributes(bool inherit)
		{
			return this._ctor.GetCustomAttributes(inherit);
		}

		// Token: 0x06007BDE RID: 31710 RVA: 0x0012445D File Offset: 0x0012265D
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return this._ctor.GetCustomAttributes(attributeType, inherit);
		}

		// Token: 0x06007BDF RID: 31711 RVA: 0x0012446C File Offset: 0x0012266C
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return this._ctor.IsDefined(attributeType, inherit);
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x06007BE0 RID: 31712 RVA: 0x0012447B File Offset: 0x0012267B
		public override int MetadataToken
		{
			get
			{
				return this._ctor.MetadataToken;
			}
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x06007BE1 RID: 31713 RVA: 0x00124488 File Offset: 0x00122688
		public override Module Module
		{
			get
			{
				return this._ctor.Module;
			}
		}

		// Token: 0x06007BE2 RID: 31714 RVA: 0x00124495 File Offset: 0x00122695
		public override ParameterInfo[] GetParameters()
		{
			return this._ctor.GetParameters();
		}

		// Token: 0x06007BE3 RID: 31715 RVA: 0x001244A2 File Offset: 0x001226A2
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return this._ctor.GetMethodImplementationFlags();
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x06007BE4 RID: 31716 RVA: 0x001244AF File Offset: 0x001226AF
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				return this._ctor.MethodHandle;
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x06007BE5 RID: 31717 RVA: 0x001244BC File Offset: 0x001226BC
		public override MethodAttributes Attributes
		{
			get
			{
				return this._ctor.Attributes;
			}
		}

		// Token: 0x06007BE6 RID: 31718 RVA: 0x0001A563 File Offset: 0x00018763
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06007BE7 RID: 31719 RVA: 0x001244C9 File Offset: 0x001226C9
		public override CallingConventions CallingConvention
		{
			get
			{
				return this._ctor.CallingConvention;
			}
		}

		// Token: 0x06007BE8 RID: 31720 RVA: 0x001244D6 File Offset: 0x001226D6
		public override Type[] GetGenericArguments()
		{
			return this._ctor.GetGenericArguments();
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06007BE9 RID: 31721 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsGenericMethodDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06007BEA RID: 31722 RVA: 0x001244E3 File Offset: 0x001226E3
		public override bool ContainsGenericParameters
		{
			get
			{
				return this._type.ContainsGenericParameters;
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06007BEB RID: 31723 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool IsGenericMethod
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007BEC RID: 31724 RVA: 0x00066B61 File Offset: 0x00064D61
		public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x04001783 RID: 6019
		internal ConstructorInfo _ctor;

		// Token: 0x04001784 RID: 6020
		private TypeBuilderInstantiation _type;
	}
}
