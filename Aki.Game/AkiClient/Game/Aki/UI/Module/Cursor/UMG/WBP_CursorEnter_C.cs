using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.Cursor.UMG
{
	// Token: 0x020039D6 RID: 14806
	[UnrealObjectPath("/Game/Aki/UI/Module/Cursor/UMG/WBP_CursorEnter.WBP_CursorEnter_C")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public class WBP_CursorEnter_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EF86 RID: 126854 RVA: 0x008A62C9 File Offset: 0x008A44C9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WBP_CursorEnter_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Module/Cursor/UMG/WBP_CursorEnter.WBP_CursorEnter_C");
			}
			return WBP_CursorEnter_C._ClassPtr;
		}

		// Token: 0x0601EF87 RID: 126855 RVA: 0x008A62F0 File Offset: 0x008A44F0
		public WBP_CursorEnter_C() : this(BuiltinUtils.AllocNativeUObject(WBP_CursorEnter_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EF88 RID: 126856 RVA: 0x008A6318 File Offset: 0x008A4518
		[NullableContext(1)]
		public WBP_CursorEnter_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WBP_CursorEnter_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170029A5 RID: 10661
		// (get) Token: 0x0601EF89 RID: 126857 RVA: 0x008A634B File Offset: 0x008A454B
		// (set) Token: 0x0601EF8A RID: 126858 RVA: 0x008A635F File Offset: 0x008A455F
		[Nullable(2)]
		public unsafe UImage Image_35
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_CursorEnter_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_CursorEnter_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0601EF8B RID: 126859 RVA: 0x008A6374 File Offset: 0x008A4574
		protected WBP_CursorEnter_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ED21 RID: 60705
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Module/Cursor/UMG/WBP_CursorEnter.WBP_CursorEnter_C";

		// Token: 0x0400ED22 RID: 60706
		private static IntPtr _ClassPtr;

		// Token: 0x0400ED23 RID: 60707
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ED24 RID: 60708
		internal static int __PropertyOffset_0;
	}
}
