using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Mono;

namespace System.Reflection
{
	// Token: 0x02000715 RID: 1813
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimePropertyInfo : PropertyInfo
	{
		// Token: 0x06007802 RID: 30722
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void get_property_info(RuntimePropertyInfo prop, ref MonoPropertyInfo info, PInfo req_info);

		// Token: 0x06007803 RID: 30723
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Type[] GetTypeModifiers(RuntimePropertyInfo prop, bool optional, int genericArgumentPosition = -1);

		// Token: 0x06007804 RID: 30724
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern object get_default_value(RuntimePropertyInfo prop);

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06007805 RID: 30725 RVA: 0x0011D9C0 File Offset: 0x0011BBC0
		internal BindingFlags BindingFlags
		{
			get
			{
				this.CachePropertyInfo(PInfo.GetMethod | PInfo.SetMethod);
				MethodInfo set_method = this.info.set_method;
				bool isPublic;
				if (set_method == null || !set_method.IsPublic)
				{
					MethodInfo get_method = this.info.get_method;
					isPublic = (get_method != null && get_method.IsPublic);
				}
				else
				{
					isPublic = true;
				}
				MethodInfo set_method2 = this.info.set_method;
				bool flag;
				if (set_method2 == null || !set_method2.IsStatic)
				{
					MethodInfo get_method2 = this.info.get_method;
					flag = (get_method2 != null && get_method2.IsStatic);
				}
				else
				{
					flag = true;
				}
				bool isStatic = flag;
				bool isInherited = this.DeclaringType != this.ReflectedType;
				return RuntimePropertyInfo.FilterPreCalculate(isPublic, isInherited, isStatic);
			}
		}

		// Token: 0x06007806 RID: 30726 RVA: 0x0011DA54 File Offset: 0x0011BC54
		private static BindingFlags FilterPreCalculate(bool isPublic, bool isInherited, bool isStatic)
		{
			BindingFlags bindingFlags = isPublic ? BindingFlags.Public : BindingFlags.NonPublic;
			if (isInherited)
			{
				bindingFlags |= BindingFlags.DeclaredOnly;
				if (isStatic)
				{
					bindingFlags |= (BindingFlags.Static | BindingFlags.FlattenHierarchy);
				}
				else
				{
					bindingFlags |= BindingFlags.Instance;
				}
			}
			else if (isStatic)
			{
				bindingFlags |= BindingFlags.Static;
			}
			else
			{
				bindingFlags |= BindingFlags.Instance;
			}
			return bindingFlags;
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06007807 RID: 30727 RVA: 0x0011DA90 File Offset: 0x0011BC90
		public override Module Module
		{
			get
			{
				return this.GetRuntimeModule();
			}
		}

		// Token: 0x06007808 RID: 30728 RVA: 0x0011B6F6 File Offset: 0x001198F6
		internal RuntimeType GetDeclaringTypeInternal()
		{
			return (RuntimeType)this.DeclaringType;
		}

		// Token: 0x06007809 RID: 30729 RVA: 0x0011DA98 File Offset: 0x0011BC98
		internal RuntimeModule GetRuntimeModule()
		{
			return this.GetDeclaringTypeInternal().GetRuntimeModule();
		}

		// Token: 0x0600780A RID: 30730 RVA: 0x0011DAA5 File Offset: 0x0011BCA5
		public override string ToString()
		{
			return this.FormatNameAndSig();
		}

		// Token: 0x0600780B RID: 30731 RVA: 0x0011DAB0 File Offset: 0x0011BCB0
		private string FormatNameAndSig()
		{
			StringBuilder stringBuilder = new StringBuilder(this.PropertyType.FormatTypeName());
			stringBuilder.Append(' ');
			stringBuilder.Append(this.Name);
			ParameterInfo[] indexParameters = this.GetIndexParameters();
			if (indexParameters.Length != 0)
			{
				stringBuilder.Append(" [");
				RuntimeParameterInfo.FormatParameters(stringBuilder, indexParameters, (CallingConventions)0);
				stringBuilder.Append(']');
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600780C RID: 30732 RVA: 0x0011DB17 File Offset: 0x0011BD17
		private void CachePropertyInfo(PInfo flags)
		{
			if ((this.cached & flags) != flags)
			{
				RuntimePropertyInfo.get_property_info(this, ref this.info, flags);
				this.cached |= flags;
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x0600780D RID: 30733 RVA: 0x0011DB3F File Offset: 0x0011BD3F
		public override PropertyAttributes Attributes
		{
			get
			{
				this.CachePropertyInfo(PInfo.Attributes);
				return this.info.attrs;
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x0600780E RID: 30734 RVA: 0x0011DB53 File Offset: 0x0011BD53
		public override bool CanRead
		{
			get
			{
				this.CachePropertyInfo(PInfo.GetMethod);
				return this.info.get_method != null;
			}
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x0600780F RID: 30735 RVA: 0x0011DB6D File Offset: 0x0011BD6D
		public override bool CanWrite
		{
			get
			{
				this.CachePropertyInfo(PInfo.SetMethod);
				return this.info.set_method != null;
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06007810 RID: 30736 RVA: 0x0011DB88 File Offset: 0x0011BD88
		public override Type PropertyType
		{
			get
			{
				this.CachePropertyInfo(PInfo.GetMethod | PInfo.SetMethod);
				if (this.info.get_method != null)
				{
					return this.info.get_method.ReturnType;
				}
				ParameterInfo[] parametersInternal = this.info.set_method.GetParametersInternal();
				if (parametersInternal.Length == 0)
				{
					throw new ArgumentException(SR.SetterHasNoParams, "indexer");
				}
				return parametersInternal[parametersInternal.Length - 1].ParameterType;
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06007811 RID: 30737 RVA: 0x0011DBEF File Offset: 0x0011BDEF
		public override Type ReflectedType
		{
			get
			{
				this.CachePropertyInfo(PInfo.ReflectedType);
				return this.info.parent;
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06007812 RID: 30738 RVA: 0x0011DC03 File Offset: 0x0011BE03
		public override Type DeclaringType
		{
			get
			{
				this.CachePropertyInfo(PInfo.DeclaringType);
				return this.info.declaring_type;
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06007813 RID: 30739 RVA: 0x0011DC18 File Offset: 0x0011BE18
		public override string Name
		{
			get
			{
				this.CachePropertyInfo(PInfo.Name);
				return this.info.name;
			}
		}

		// Token: 0x06007814 RID: 30740 RVA: 0x0011DC30 File Offset: 0x0011BE30
		public override MethodInfo[] GetAccessors(bool nonPublic)
		{
			int num = 0;
			int num2 = 0;
			this.CachePropertyInfo(PInfo.GetMethod | PInfo.SetMethod);
			if (this.info.set_method != null && (nonPublic || this.info.set_method.IsPublic))
			{
				num2 = 1;
			}
			if (this.info.get_method != null && (nonPublic || this.info.get_method.IsPublic))
			{
				num = 1;
			}
			MethodInfo[] array = new MethodInfo[num + num2];
			int num3 = 0;
			if (num2 != 0)
			{
				array[num3++] = this.info.set_method;
			}
			if (num != 0)
			{
				array[num3++] = this.info.get_method;
			}
			return array;
		}

		// Token: 0x06007815 RID: 30741 RVA: 0x0011DCD2 File Offset: 0x0011BED2
		public override MethodInfo GetGetMethod(bool nonPublic)
		{
			this.CachePropertyInfo(PInfo.GetMethod);
			if (this.info.get_method != null && (nonPublic || this.info.get_method.IsPublic))
			{
				return this.info.get_method;
			}
			return null;
		}

		// Token: 0x06007816 RID: 30742 RVA: 0x0011DD10 File Offset: 0x0011BF10
		public override ParameterInfo[] GetIndexParameters()
		{
			this.CachePropertyInfo(PInfo.GetMethod | PInfo.SetMethod);
			ParameterInfo[] parametersInternal;
			int num;
			if (this.info.get_method != null)
			{
				parametersInternal = this.info.get_method.GetParametersInternal();
				num = parametersInternal.Length;
			}
			else
			{
				if (!(this.info.set_method != null))
				{
					return Array.Empty<ParameterInfo>();
				}
				parametersInternal = this.info.set_method.GetParametersInternal();
				num = parametersInternal.Length - 1;
			}
			ParameterInfo[] array = new ParameterInfo[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = RuntimeParameterInfo.New(parametersInternal[i], this);
			}
			return array;
		}

		// Token: 0x06007817 RID: 30743 RVA: 0x0011DDA0 File Offset: 0x0011BFA0
		public override MethodInfo GetSetMethod(bool nonPublic)
		{
			this.CachePropertyInfo(PInfo.SetMethod);
			if (this.info.set_method != null && (nonPublic || this.info.set_method.IsPublic))
			{
				return this.info.set_method;
			}
			return null;
		}

		// Token: 0x06007818 RID: 30744 RVA: 0x0011DDDE File Offset: 0x0011BFDE
		public override object GetConstantValue()
		{
			return RuntimePropertyInfo.get_default_value(this);
		}

		// Token: 0x06007819 RID: 30745 RVA: 0x0011DDDE File Offset: 0x0011BFDE
		public override object GetRawConstantValue()
		{
			return RuntimePropertyInfo.get_default_value(this);
		}

		// Token: 0x0600781A RID: 30746 RVA: 0x0011DDE6 File Offset: 0x0011BFE6
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return CustomAttribute.IsDefined(this, attributeType, false);
		}

		// Token: 0x0600781B RID: 30747 RVA: 0x0011D66A File Offset: 0x0011B86A
		public override object[] GetCustomAttributes(bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, false);
		}

		// Token: 0x0600781C RID: 30748 RVA: 0x0011D673 File Offset: 0x0011B873
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, attributeType, false);
		}

		// Token: 0x0600781D RID: 30749 RVA: 0x0011DDF0 File Offset: 0x0011BFF0
		private static object GetterAdapterFrame<T, R>(RuntimePropertyInfo.Getter<T, R> getter, object obj)
		{
			return getter((T)((object)obj));
		}

		// Token: 0x0600781E RID: 30750 RVA: 0x0011DE03 File Offset: 0x0011C003
		private static object StaticGetterAdapterFrame<R>(RuntimePropertyInfo.StaticGetter<R> getter, object _)
		{
			return getter();
		}

		// Token: 0x0600781F RID: 30751 RVA: 0x0011DE10 File Offset: 0x0011C010
		[DynamicDependency("GetterAdapterFrame`2")]
		[DynamicDependency("StaticGetterAdapterFrame`1")]
		private static RuntimePropertyInfo.GetterAdapter CreateGetterDelegate(MethodInfo method)
		{
			Type[] typeArguments;
			Type typeFromHandle;
			string name;
			if (method.IsStatic)
			{
				typeArguments = new Type[]
				{
					method.ReturnType
				};
				typeFromHandle = typeof(RuntimePropertyInfo.StaticGetter<>);
				name = "StaticGetterAdapterFrame";
			}
			else
			{
				typeArguments = new Type[]
				{
					method.DeclaringType,
					method.ReturnType
				};
				typeFromHandle = typeof(RuntimePropertyInfo.Getter<, >);
				name = "GetterAdapterFrame";
			}
			object firstArgument = Delegate.CreateDelegate(typeFromHandle.MakeGenericType(typeArguments), method);
			MethodInfo methodInfo = typeof(RuntimePropertyInfo).GetMethod(name, BindingFlags.Static | BindingFlags.NonPublic);
			methodInfo = methodInfo.MakeGenericMethod(typeArguments);
			return (RuntimePropertyInfo.GetterAdapter)Delegate.CreateDelegate(typeof(RuntimePropertyInfo.GetterAdapter), firstArgument, methodInfo, true);
		}

		// Token: 0x06007820 RID: 30752 RVA: 0x0011DEB8 File Offset: 0x0011C0B8
		public override object GetValue(object obj, object[] index)
		{
			if ((index == null || index.Length == 0) && RuntimeFeature.IsDynamicCodeSupported)
			{
				if (this.cached_getter == null)
				{
					MethodInfo getMethod = this.GetGetMethod(true);
					if (getMethod == null)
					{
						throw new ArgumentException(SR.Arg_GetMethNotFnd);
					}
					if (this.DeclaringType.IsValueType || this.PropertyType.IsByRef || getMethod.ContainsGenericParameters)
					{
						goto IL_8E;
					}
					this.cached_getter = RuntimePropertyInfo.CreateGetterDelegate(getMethod);
					try
					{
						return this.cached_getter(obj);
					}
					catch (Exception inner)
					{
						throw new TargetInvocationException(inner);
					}
				}
				try
				{
					return this.cached_getter(obj);
				}
				catch (Exception inner2)
				{
					throw new TargetInvocationException(inner2);
				}
			}
			IL_8E:
			return this.GetValue(obj, BindingFlags.Default, null, index, null);
		}

		// Token: 0x06007821 RID: 30753 RVA: 0x0011DF7C File Offset: 0x0011C17C
		public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
			MethodInfo getMethod = this.GetGetMethod(true);
			if (getMethod == null)
			{
				throw new ArgumentException(SR.Arg_GetMethNotFnd);
			}
			object result;
			if (index == null || index.Length == 0)
			{
				result = getMethod.Invoke(obj, invokeAttr, binder, null, culture);
			}
			else
			{
				result = getMethod.Invoke(obj, invokeAttr, binder, index, culture);
			}
			return result;
		}

		// Token: 0x06007822 RID: 30754 RVA: 0x0011DFCC File Offset: 0x0011C1CC
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
			MethodInfo setMethod = this.GetSetMethod(true);
			if (setMethod == null)
			{
				throw new ArgumentException(SR.Arg_SetMethNotFnd);
			}
			object[] array;
			if (index == null || index.Length == 0)
			{
				array = new object[]
				{
					value
				};
			}
			else
			{
				int num = index.Length;
				array = new object[num + 1];
				index.CopyTo(array, 0);
				array[num] = value;
			}
			setMethod.Invoke(obj, invokeAttr, binder, array, culture);
		}

		// Token: 0x06007823 RID: 30755 RVA: 0x0011E034 File Offset: 0x0011C234
		public override Type[] GetOptionalCustomModifiers()
		{
			return this.GetCustomModifiers(true);
		}

		// Token: 0x06007824 RID: 30756 RVA: 0x0011E03D File Offset: 0x0011C23D
		public override Type[] GetRequiredCustomModifiers()
		{
			return this.GetCustomModifiers(false);
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x0011E046 File Offset: 0x0011C246
		private Type[] GetCustomModifiers(bool optional)
		{
			return RuntimePropertyInfo.GetTypeModifiers(this, optional, -1) ?? Type.EmptyTypes;
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x0011E059 File Offset: 0x0011C259
		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return RuntimeCustomAttributeData.GetCustomAttributesInternal(this);
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x0011E061 File Offset: 0x0011C261
		public sealed override bool HasSameMetadataDefinitionAs(MemberInfo other)
		{
			return base.HasSameMetadataDefinitionAsCore<RuntimePropertyInfo>(other);
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06007828 RID: 30760 RVA: 0x0011E06A File Offset: 0x0011C26A
		public override int MetadataToken
		{
			get
			{
				return RuntimePropertyInfo.get_metadata_token(this);
			}
		}

		// Token: 0x06007829 RID: 30761
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int get_metadata_token(RuntimePropertyInfo monoProperty);

		// Token: 0x0600782A RID: 30762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle);

		// Token: 0x0600782B RID: 30763 RVA: 0x0011E074 File Offset: 0x0011C274
		internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType)
		{
			if (handle.Value == IntPtr.Zero)
			{
				throw new ArgumentException(SR.Argument_InvalidHandle);
			}
			PropertyInfo propertyInfo = RuntimePropertyInfo.internal_from_handle_type(handle.Value, reflectedType.Value);
			if (propertyInfo == null)
			{
				throw new ArgumentException(SR.Argument_FieldPropertyEventAndTypeHandleIncompatibility);
			}
			return propertyInfo;
		}

		// Token: 0x0600782C RID: 30764 RVA: 0x0011E0C1 File Offset: 0x0011C2C1
		internal Type[] GetCustomModifiersFromModifiedType(bool optional, int genericArgumentPosition)
		{
			return RuntimePropertyInfo.GetTypeModifiers(this, optional, genericArgumentPosition) ?? Type.EmptyTypes;
		}

		// Token: 0x0600782D RID: 30765 RVA: 0x0011E0D4 File Offset: 0x0011C2D4
		public override Type GetModifiedPropertyType()
		{
			return ModifiedType.Create(this.PropertyType, this, 0);
		}

		// Token: 0x040015CE RID: 5582
		internal IntPtr klass;

		// Token: 0x040015CF RID: 5583
		internal IntPtr prop;

		// Token: 0x040015D0 RID: 5584
		private MonoPropertyInfo info;

		// Token: 0x040015D1 RID: 5585
		private PInfo cached;

		// Token: 0x040015D2 RID: 5586
		private RuntimePropertyInfo.GetterAdapter cached_getter;

		// Token: 0x02000716 RID: 1814
		// (Invoke) Token: 0x06007830 RID: 30768
		private delegate object GetterAdapter(object _this);

		// Token: 0x02000717 RID: 1815
		// (Invoke) Token: 0x06007832 RID: 30770
		private delegate R Getter<T, R>(T _this);

		// Token: 0x02000718 RID: 1816
		// (Invoke) Token: 0x06007834 RID: 30772
		private delegate R StaticGetter<R>();
	}
}
