using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.UI.DebugPostProcess
{
	// Token: 0x02003D3A RID: 15674
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/UI/DebugPostProcess/UDebugPostProcessListInfo.UDebugPostProcessListInfo_C")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 233)]
	public class UDebugPostProcessListInfo_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060260DC RID: 155868 RVA: 0x0096A042 File Offset: 0x00968242
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (UDebugPostProcessListInfo_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/UI/DebugPostProcess/UDebugPostProcessListInfo.UDebugPostProcessListInfo_C");
			}
			return UDebugPostProcessListInfo_C._ClassPtr;
		}

		// Token: 0x060260DD RID: 155869 RVA: 0x0096A068 File Offset: 0x00968268
		public UDebugPostProcessListInfo_C() : this(BuiltinUtils.AllocNativeUObject(UDebugPostProcessListInfo_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260DE RID: 155870 RVA: 0x0096A090 File Offset: 0x00968290
		public UDebugPostProcessListInfo_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDebugPostProcessListInfo_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005030 RID: 20528
		// (get) Token: 0x060260DF RID: 155871 RVA: 0x0096A0C4 File Offset: 0x009682C4
		// (set) Token: 0x060260E0 RID: 155872 RVA: 0x0096A0FD File Offset: 0x009682FD
		public FPostprocessGIDebugInfo Info
		{
			get
			{
				base.FastCheckIsValid();
				FPostprocessGIDebugInfo result;
				if ((result = this._Info) == null)
				{
					result = (this._Info = new FPostprocessGIDebugInfo(base.NativePtr + (IntPtr)UDebugPostProcessListInfo_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPostprocessGIDebugInfo.StaticStruct(), base.NativePtr + (IntPtr)UDebugPostProcessListInfo_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005031 RID: 20529
		// (get) Token: 0x060260E1 RID: 155873 RVA: 0x0096A11E File Offset: 0x0096831E
		// (set) Token: 0x060260E2 RID: 155874 RVA: 0x0096A12E File Offset: 0x0096832E
		public unsafe bool OverrideProperties
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDebugPostProcessListInfo_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDebugPostProcessListInfo_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x060260E3 RID: 155875 RVA: 0x0096A13F File Offset: 0x0096833F
		protected UDebugPostProcessListInfo_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130BE RID: 78014
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/UI/DebugPostProcess/UDebugPostProcessListInfo.UDebugPostProcessListInfo_C";

		// Token: 0x040130BF RID: 78015
		private static IntPtr _ClassPtr;

		// Token: 0x040130C0 RID: 78016
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130C1 RID: 78017
		internal static int __PropertyOffset_0;

		// Token: 0x040130C2 RID: 78018
		[Nullable(2)]
		private FPostprocessGIDebugInfo _Info;

		// Token: 0x040130C3 RID: 78019
		internal static int __PropertyOffset_1;
	}
}
