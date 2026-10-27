using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.Cursor.UMG
{
	// Token: 0x020039D7 RID: 14807
	[UnrealObjectPath("/Game/Aki/UI/Module/Cursor/UMG/WBP_CursorPress.WBP_CursorPress_C")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public class WBP_CursorPress_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EF8C RID: 126860 RVA: 0x008A637D File Offset: 0x008A457D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WBP_CursorPress_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Module/Cursor/UMG/WBP_CursorPress.WBP_CursorPress_C");
			}
			return WBP_CursorPress_C._ClassPtr;
		}

		// Token: 0x0601EF8D RID: 126861 RVA: 0x008A63A4 File Offset: 0x008A45A4
		public WBP_CursorPress_C() : this(BuiltinUtils.AllocNativeUObject(WBP_CursorPress_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EF8E RID: 126862 RVA: 0x008A63CC File Offset: 0x008A45CC
		[NullableContext(1)]
		public WBP_CursorPress_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WBP_CursorPress_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170029A6 RID: 10662
		// (get) Token: 0x0601EF8F RID: 126863 RVA: 0x008A63FF File Offset: 0x008A45FF
		// (set) Token: 0x0601EF90 RID: 126864 RVA: 0x008A6413 File Offset: 0x008A4613
		[Nullable(2)]
		public unsafe UImage Image_35
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_CursorPress_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_CursorPress_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0601EF91 RID: 126865 RVA: 0x008A6428 File Offset: 0x008A4628
		protected WBP_CursorPress_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ED25 RID: 60709
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Module/Cursor/UMG/WBP_CursorPress.WBP_CursorPress_C";

		// Token: 0x0400ED26 RID: 60710
		private static IntPtr _ClassPtr;

		// Token: 0x0400ED27 RID: 60711
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ED28 RID: 60712
		internal static int __PropertyOffset_0;
	}
}
