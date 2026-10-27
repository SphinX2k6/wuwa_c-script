using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.Cursor.UMG
{
	// Token: 0x020039D5 RID: 14805
	[UnrealObjectPath("/Game/Aki/UI/Module/Cursor/UMG/WBP_CursorDefault.WBP_CursorDefault_C")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public class WBP_CursorDefault_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EF80 RID: 126848 RVA: 0x008A6218 File Offset: 0x008A4418
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WBP_CursorDefault_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Module/Cursor/UMG/WBP_CursorDefault.WBP_CursorDefault_C");
			}
			return WBP_CursorDefault_C._ClassPtr;
		}

		// Token: 0x0601EF81 RID: 126849 RVA: 0x008A623C File Offset: 0x008A443C
		public WBP_CursorDefault_C() : this(BuiltinUtils.AllocNativeUObject(WBP_CursorDefault_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EF82 RID: 126850 RVA: 0x008A6264 File Offset: 0x008A4464
		[NullableContext(1)]
		public WBP_CursorDefault_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WBP_CursorDefault_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170029A4 RID: 10660
		// (get) Token: 0x0601EF83 RID: 126851 RVA: 0x008A6297 File Offset: 0x008A4497
		// (set) Token: 0x0601EF84 RID: 126852 RVA: 0x008A62AB File Offset: 0x008A44AB
		[Nullable(2)]
		public unsafe UImage Image_20
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_CursorDefault_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_CursorDefault_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0601EF85 RID: 126853 RVA: 0x008A62C0 File Offset: 0x008A44C0
		protected WBP_CursorDefault_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ED1D RID: 60701
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Module/Cursor/UMG/WBP_CursorDefault.WBP_CursorDefault_C";

		// Token: 0x0400ED1E RID: 60702
		private static IntPtr _ClassPtr;

		// Token: 0x0400ED1F RID: 60703
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ED20 RID: 60704
		internal static int __PropertyOffset_0;
	}
}
