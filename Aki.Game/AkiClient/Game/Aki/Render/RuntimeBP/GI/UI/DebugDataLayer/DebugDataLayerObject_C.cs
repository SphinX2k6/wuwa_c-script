using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.UI.DebugDataLayer
{
	// Token: 0x02003D3D RID: 15677
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/UI/DebugDataLayer/DebugDataLayerObject.DebugDataLayerObject_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 65)]
	public class DebugDataLayerObject_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602612E RID: 155950 RVA: 0x0096AA66 File Offset: 0x00968C66
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (DebugDataLayerObject_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/UI/DebugDataLayer/DebugDataLayerObject.DebugDataLayerObject_C");
			}
			return DebugDataLayerObject_C._ClassPtr;
		}

		// Token: 0x0602612F RID: 155951 RVA: 0x0096AA8C File Offset: 0x00968C8C
		public DebugDataLayerObject_C() : this(BuiltinUtils.AllocNativeUObject(DebugDataLayerObject_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026130 RID: 155952 RVA: 0x0096AAB4 File Offset: 0x00968CB4
		public DebugDataLayerObject_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(DebugDataLayerObject_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700504B RID: 20555
		// (get) Token: 0x06026131 RID: 155953 RVA: 0x0096AAE7 File Offset: 0x00968CE7
		// (set) Token: 0x06026132 RID: 155954 RVA: 0x0096AAFB File Offset: 0x00968CFB
		public unsafe string DataLayerName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)DebugDataLayerObject_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)DebugDataLayerObject_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x1700504C RID: 20556
		// (get) Token: 0x06026133 RID: 155955 RVA: 0x0096AB10 File Offset: 0x00968D10
		// (set) Token: 0x06026134 RID: 155956 RVA: 0x0096AB20 File Offset: 0x00968D20
		public unsafe bool DataLayerEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DebugDataLayerObject_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)DebugDataLayerObject_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026135 RID: 155957 RVA: 0x0096AB31 File Offset: 0x00968D31
		protected DebugDataLayerObject_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130EF RID: 78063
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/UI/DebugDataLayer/DebugDataLayerObject.DebugDataLayerObject_C";

		// Token: 0x040130F0 RID: 78064
		private static IntPtr _ClassPtr;

		// Token: 0x040130F1 RID: 78065
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130F2 RID: 78066
		internal static int __PropertyOffset_0;

		// Token: 0x040130F3 RID: 78067
		internal static int __PropertyOffset_1;
	}
}
