using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mono;

namespace System.Reflection
{
	// Token: 0x02000707 RID: 1799
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeEventInfo : EventInfo
	{
		// Token: 0x060076FA RID: 30458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_event_info(RuntimeEventInfo ev, out MonoEventInfo info);

		// Token: 0x060076FB RID: 30459 RVA: 0x0011B6D0 File Offset: 0x001198D0
		internal static MonoEventInfo GetEventInfo(RuntimeEventInfo ev)
		{
			MonoEventInfo result;
			RuntimeEventInfo.get_event_info(ev, out result);
			return result;
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x060076FC RID: 30460 RVA: 0x0011B6E6 File Offset: 0x001198E6
		public override Module Module
		{
			get
			{
				return this.GetRuntimeModule();
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x060076FD RID: 30461 RVA: 0x0011B6EE File Offset: 0x001198EE
		internal BindingFlags BindingFlags
		{
			get
			{
				return this.GetBindingFlags();
			}
		}

		// Token: 0x060076FE RID: 30462 RVA: 0x0011B6F6 File Offset: 0x001198F6
		internal RuntimeType GetDeclaringTypeInternal()
		{
			return (RuntimeType)this.DeclaringType;
		}

		// Token: 0x060076FF RID: 30463 RVA: 0x0011B703 File Offset: 0x00119903
		internal RuntimeModule GetRuntimeModule()
		{
			return this.GetDeclaringTypeInternal().GetRuntimeModule();
		}

		// Token: 0x06007700 RID: 30464 RVA: 0x0011B710 File Offset: 0x00119910
		internal BindingFlags GetBindingFlags()
		{
			MonoEventInfo eventInfo = RuntimeEventInfo.GetEventInfo(this);
			MethodInfo methodInfo;
			if ((methodInfo = eventInfo.add_method) == null)
			{
				methodInfo = (eventInfo.remove_method ?? eventInfo.raise_method);
			}
			MethodInfo methodInfo2 = methodInfo;
			return RuntimeType.FilterPreCalculate(methodInfo2 != null && methodInfo2.IsPublic, this.GetDeclaringTypeInternal() != this.ReflectedType, methodInfo2 != null && methodInfo2.IsStatic);
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06007701 RID: 30465 RVA: 0x0011B779 File Offset: 0x00119979
		public override EventAttributes Attributes
		{
			get
			{
				return RuntimeEventInfo.GetEventInfo(this).attrs;
			}
		}

		// Token: 0x06007702 RID: 30466 RVA: 0x0011B788 File Offset: 0x00119988
		public override MethodInfo GetAddMethod(bool nonPublic)
		{
			MonoEventInfo eventInfo = RuntimeEventInfo.GetEventInfo(this);
			if (nonPublic || (eventInfo.add_method != null && eventInfo.add_method.IsPublic))
			{
				return eventInfo.add_method;
			}
			return null;
		}

		// Token: 0x06007703 RID: 30467 RVA: 0x0011B7C4 File Offset: 0x001199C4
		public override MethodInfo GetRaiseMethod(bool nonPublic)
		{
			MonoEventInfo eventInfo = RuntimeEventInfo.GetEventInfo(this);
			if (nonPublic || (eventInfo.raise_method != null && eventInfo.raise_method.IsPublic))
			{
				return eventInfo.raise_method;
			}
			return null;
		}

		// Token: 0x06007704 RID: 30468 RVA: 0x0011B800 File Offset: 0x00119A00
		public override MethodInfo GetRemoveMethod(bool nonPublic)
		{
			MonoEventInfo eventInfo = RuntimeEventInfo.GetEventInfo(this);
			if (nonPublic || (eventInfo.remove_method != null && eventInfo.remove_method.IsPublic))
			{
				return eventInfo.remove_method;
			}
			return null;
		}

		// Token: 0x06007705 RID: 30469 RVA: 0x0011B83C File Offset: 0x00119A3C
		public override MethodInfo[] GetOtherMethods(bool nonPublic)
		{
			MonoEventInfo eventInfo = RuntimeEventInfo.GetEventInfo(this);
			if (nonPublic)
			{
				return eventInfo.other_methods;
			}
			int num = 0;
			MethodInfo[] other_methods = eventInfo.other_methods;
			for (int i = 0; i < other_methods.Length; i++)
			{
				if (other_methods[i].IsPublic)
				{
					num++;
				}
			}
			if (num == eventInfo.other_methods.Length)
			{
				return eventInfo.other_methods;
			}
			MethodInfo[] array = new MethodInfo[num];
			num = 0;
			foreach (MethodInfo methodInfo in eventInfo.other_methods)
			{
				if (methodInfo.IsPublic)
				{
					array[num++] = methodInfo;
				}
			}
			return array;
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06007706 RID: 30470 RVA: 0x0011B8D1 File Offset: 0x00119AD1
		public override Type DeclaringType
		{
			get
			{
				return RuntimeEventInfo.GetEventInfo(this).declaring_type;
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06007707 RID: 30471 RVA: 0x0011B8DE File Offset: 0x00119ADE
		public override Type ReflectedType
		{
			get
			{
				return RuntimeEventInfo.GetEventInfo(this).reflected_type;
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06007708 RID: 30472 RVA: 0x0011B8EB File Offset: 0x00119AEB
		public override string Name
		{
			get
			{
				return RuntimeEventInfo.GetEventInfo(this).name;
			}
		}

		// Token: 0x06007709 RID: 30473 RVA: 0x0011B8F8 File Offset: 0x00119AF8
		public override string ToString()
		{
			Type eventHandlerType = this.EventHandlerType;
			return ((eventHandlerType != null) ? eventHandlerType.ToString() : null) + " " + this.Name;
		}

		// Token: 0x0600770A RID: 30474 RVA: 0x00009CC2 File Offset: 0x00007EC2
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return CustomAttribute.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x0600770B RID: 30475 RVA: 0x0011B1F4 File Offset: 0x001193F4
		public override object[] GetCustomAttributes(bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, inherit);
		}

		// Token: 0x0600770C RID: 30476 RVA: 0x0011B1FD File Offset: 0x001193FD
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x0600770D RID: 30477 RVA: 0x0011B91C File Offset: 0x00119B1C
		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return RuntimeCustomAttributeData.GetCustomAttributesInternal(this);
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x0600770E RID: 30478 RVA: 0x0011B924 File Offset: 0x00119B24
		public override int MetadataToken
		{
			get
			{
				return RuntimeEventInfo.get_metadata_token(this);
			}
		}

		// Token: 0x0600770F RID: 30479 RVA: 0x0011B92C File Offset: 0x00119B2C
		public sealed override bool HasSameMetadataDefinitionAs(MemberInfo other)
		{
			return base.HasSameMetadataDefinitionAsCore<RuntimeEventInfo>(other);
		}

		// Token: 0x06007710 RID: 30480
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int get_metadata_token(RuntimeEventInfo monoEvent);

		// Token: 0x06007711 RID: 30481
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle);

		// Token: 0x06007712 RID: 30482 RVA: 0x0011B938 File Offset: 0x00119B38
		internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType)
		{
			if (handle.Value == IntPtr.Zero)
			{
				throw new ArgumentException(SR.Argument_InvalidHandle);
			}
			EventInfo eventInfo = RuntimeEventInfo.internal_from_handle_type(handle.Value, reflectedType.Value);
			if (eventInfo == null)
			{
				throw new ArgumentException(SR.Argument_FieldPropertyEventAndTypeHandleIncompatibility);
			}
			return eventInfo;
		}

		// Token: 0x0400157D RID: 5501
		private IntPtr klass;

		// Token: 0x0400157E RID: 5502
		private IntPtr handle;
	}
}
