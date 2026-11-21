using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x02000709 RID: 1801
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeFieldInfo : RtFieldInfo
	{
		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06007715 RID: 30485 RVA: 0x0011B995 File Offset: 0x00119B95
		public override Module Module
		{
			get
			{
				return this.GetRuntimeModule();
			}
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x0011B6F6 File Offset: 0x001198F6
		internal RuntimeType GetDeclaringTypeInternal()
		{
			return (RuntimeType)this.DeclaringType;
		}

		// Token: 0x06007717 RID: 30487 RVA: 0x0011B99D File Offset: 0x00119B9D
		internal RuntimeModule GetRuntimeModule()
		{
			return this.GetDeclaringTypeInternal().GetRuntimeModule();
		}

		// Token: 0x06007718 RID: 30488 RVA: 0x0011B9AA File Offset: 0x00119BAA
		[DebuggerStepThrough]
		[DebuggerHidden]
		public unsafe override void SetValueDirect(TypedReference obj, object value)
		{
			if (obj.IsNull)
			{
				throw new ArgumentException(SR.Arg_TypedReference_Null);
			}
			RuntimeFieldHandle.SetValueDirect(this, (RuntimeType)this.FieldType, (void*)(&obj), value, (RuntimeType)this.DeclaringType);
		}

		// Token: 0x06007719 RID: 30489 RVA: 0x0011B9E0 File Offset: 0x00119BE0
		[DebuggerStepThrough]
		[DebuggerHidden]
		public unsafe override object GetValueDirect(TypedReference obj)
		{
			if (obj.IsNull)
			{
				throw new ArgumentException(SR.Arg_TypedReference_Null);
			}
			return RuntimeFieldHandle.GetValueDirect(this, (RuntimeType)this.FieldType, (void*)(&obj), (RuntimeType)this.DeclaringType);
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x0600771A RID: 30490 RVA: 0x0011BA15 File Offset: 0x00119C15
		public override FieldAttributes Attributes
		{
			get
			{
				return this.attrs;
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x0600771B RID: 30491 RVA: 0x0011BA1D File Offset: 0x00119C1D
		public override RuntimeFieldHandle FieldHandle
		{
			get
			{
				return this.fhandle;
			}
		}

		// Token: 0x0600771C RID: 30492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Type ResolveType();

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x0600771D RID: 30493 RVA: 0x0011BA28 File Offset: 0x00119C28
		public override Type FieldType
		{
			get
			{
				Type result;
				if ((result = this.type) == null)
				{
					result = (this.type = this.ResolveType());
				}
				return result;
			}
		}

		// Token: 0x0600771E RID: 30494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Type GetParentType(bool declaring);

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x0600771F RID: 30495 RVA: 0x0011BA4E File Offset: 0x00119C4E
		public override Type ReflectedType
		{
			get
			{
				return this.GetParentType(false);
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06007720 RID: 30496 RVA: 0x0011BA58 File Offset: 0x00119C58
		public override Type DeclaringType
		{
			get
			{
				Type parentType = this.GetParentType(true);
				if (!(parentType.Name != "<Module>"))
				{
					return null;
				}
				return parentType;
			}
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06007721 RID: 30497 RVA: 0x0011BA82 File Offset: 0x00119C82
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x06007722 RID: 30498 RVA: 0x00009CC2 File Offset: 0x00007EC2
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return CustomAttribute.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x06007723 RID: 30499 RVA: 0x0011B1F4 File Offset: 0x001193F4
		public override object[] GetCustomAttributes(bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, inherit);
		}

		// Token: 0x06007724 RID: 30500 RVA: 0x0011B1FD File Offset: 0x001193FD
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x06007725 RID: 30501
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal override extern int GetFieldOffset();

		// Token: 0x06007726 RID: 30502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern object GetValueInternal(object obj);

		// Token: 0x06007727 RID: 30503 RVA: 0x0011BA8C File Offset: 0x00119C8C
		public override object GetValue(object obj)
		{
			if (!base.IsStatic)
			{
				if (obj == null)
				{
					throw new TargetException(SR.RFLCT_Targ_StatFldReqTarg);
				}
				if (!this.DeclaringType.IsAssignableFrom(obj.GetType()))
				{
					throw new ArgumentException(SR.Format(SR.Arg_FieldDeclTarget, this.Name, this.DeclaringType, obj.GetType()), "obj");
				}
			}
			if (!base.IsLiteral)
			{
				this.CheckGeneric();
			}
			return this.GetValueInternal(obj);
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x0011BAFE File Offset: 0x00119CFE
		public override string ToString()
		{
			return this.FieldType.FormatTypeName() + " " + this.name;
		}

		// Token: 0x06007729 RID: 30505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetValueInternal(FieldInfo fi, object obj, object value);

		// Token: 0x0600772A RID: 30506 RVA: 0x0011BB1C File Offset: 0x00119D1C
		public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
			if (!base.IsStatic)
			{
				if (obj == null)
				{
					throw new TargetException(SR.RFLCT_Targ_StatFldReqTarg);
				}
				if (!this.DeclaringType.IsAssignableFrom(obj.GetType()))
				{
					throw new ArgumentException(SR.Format(SR.Arg_FieldDeclTarget, this.Name, this.DeclaringType, obj.GetType()), "obj");
				}
			}
			if (base.IsLiteral)
			{
				throw new FieldAccessException(SR.Acc_ReadOnly);
			}
			if (binder == null)
			{
				binder = Type.DefaultBinder;
			}
			this.CheckGeneric();
			if (val != null)
			{
				RuntimeType runtimeType = (RuntimeType)this.FieldType;
				if (val.GetType() != runtimeType)
				{
					runtimeType.CheckValue(ref val, binder, culture, invokeAttr);
				}
			}
			RuntimeFieldInfo.SetValueInternal(this, obj, val);
		}

		// Token: 0x0600772B RID: 30507
		[MethodImpl(MethodImplOptions.InternalCall)]
		public override extern object GetRawConstantValue();

		// Token: 0x0600772C RID: 30508 RVA: 0x0011BBCB File Offset: 0x00119DCB
		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return RuntimeCustomAttributeData.GetCustomAttributesInternal(this);
		}

		// Token: 0x0600772D RID: 30509 RVA: 0x0011BBD4 File Offset: 0x00119DD4
		private void CheckGeneric()
		{
			Type declaringType = this.DeclaringType;
			if (declaringType != null && declaringType.ContainsGenericParameters)
			{
				throw new InvalidOperationException(SR.Arg_UnboundGenField);
			}
		}

		// Token: 0x0600772E RID: 30510 RVA: 0x0011BC04 File Offset: 0x00119E04
		public sealed override bool HasSameMetadataDefinitionAs(MemberInfo other)
		{
			return base.HasSameMetadataDefinitionAsCore<RuntimeFieldInfo>(other);
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x0600772F RID: 30511 RVA: 0x0011BC0D File Offset: 0x00119E0D
		public override int MetadataToken
		{
			get
			{
				return RuntimeFieldInfo.get_metadata_token(this);
			}
		}

		// Token: 0x06007730 RID: 30512
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int get_metadata_token(RuntimeFieldInfo monoField);

		// Token: 0x06007731 RID: 30513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Type[] GetTypeModifiers(bool optional, int genericArgumentPosition = -1);

		// Token: 0x06007732 RID: 30514 RVA: 0x0011BC15 File Offset: 0x00119E15
		public override Type[] GetOptionalCustomModifiers()
		{
			return this.GetCustomModifiers(true);
		}

		// Token: 0x06007733 RID: 30515 RVA: 0x0011BC1E File Offset: 0x00119E1E
		public override Type[] GetRequiredCustomModifiers()
		{
			return this.GetCustomModifiers(false);
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x0011BC27 File Offset: 0x00119E27
		private Type[] GetCustomModifiers(bool optional)
		{
			return this.GetTypeModifiers(optional, -1) ?? Type.EmptyTypes;
		}

		// Token: 0x06007735 RID: 30517 RVA: 0x0011BC3A File Offset: 0x00119E3A
		internal Type[] GetCustomModifiersFromModifiedType(bool optional, int genericArgumentPosition)
		{
			return this.GetTypeModifiers(optional, genericArgumentPosition) ?? Type.EmptyTypes;
		}

		// Token: 0x06007736 RID: 30518 RVA: 0x0011BC4D File Offset: 0x00119E4D
		public override Type GetModifiedFieldType()
		{
			return ModifiedType.Create(this.FieldType, this, 0);
		}

		// Token: 0x0400157F RID: 5503
		internal IntPtr klass;

		// Token: 0x04001580 RID: 5504
		internal RuntimeFieldHandle fhandle;

		// Token: 0x04001581 RID: 5505
		private string name;

		// Token: 0x04001582 RID: 5506
		private Type type;

		// Token: 0x04001583 RID: 5507
		private FieldAttributes attrs;
	}
}
