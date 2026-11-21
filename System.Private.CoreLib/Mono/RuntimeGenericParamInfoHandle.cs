using System;
using System.Reflection;

namespace Mono
{
	// Token: 0x020009EB RID: 2539
	internal struct RuntimeGenericParamInfoHandle
	{
		// Token: 0x0600941B RID: 37915 RVA: 0x001718AA File Offset: 0x0016FAAA
		internal RuntimeGenericParamInfoHandle(IntPtr ptr)
		{
			this.value = ptr;
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x0600941C RID: 37916 RVA: 0x001718B3 File Offset: 0x0016FAB3
		internal Type[] Constraints
		{
			get
			{
				return this.GetConstraints();
			}
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x0600941D RID: 37917 RVA: 0x001718BB File Offset: 0x0016FABB
		internal unsafe GenericParameterAttributes Attributes
		{
			get
			{
				return (GenericParameterAttributes)this.value->flags;
			}
		}

		// Token: 0x0600941E RID: 37918 RVA: 0x001718C8 File Offset: 0x0016FAC8
		private unsafe Type[] GetConstraints()
		{
			int constraintsCount = this.GetConstraintsCount();
			Type[] array = new Type[constraintsCount];
			for (int i = 0; i < constraintsCount; i++)
			{
				RuntimeClassHandle runtimeClassHandle = new RuntimeClassHandle(*(IntPtr*)(this.value->constraints + (IntPtr)i * (IntPtr)sizeof(RuntimeStructs.MonoClass*) / (IntPtr)sizeof(RuntimeStructs.MonoClass*)));
				array[i] = Type.GetTypeFromHandle(runtimeClassHandle.GetTypeHandle());
			}
			return array;
		}

		// Token: 0x0600941F RID: 37919 RVA: 0x0017191C File Offset: 0x0016FB1C
		private unsafe int GetConstraintsCount()
		{
			int num = 0;
			RuntimeStructs.MonoClass** ptr = this.value->constraints;
			while (ptr != null && *(IntPtr*)ptr != (IntPtr)((UIntPtr)0))
			{
				ptr += sizeof(RuntimeStructs.MonoClass*) / sizeof(RuntimeStructs.MonoClass*);
				num++;
			}
			return num;
		}

		// Token: 0x040022BC RID: 8892
		private unsafe readonly RuntimeStructs.GenericParamInfo* value;
	}
}
