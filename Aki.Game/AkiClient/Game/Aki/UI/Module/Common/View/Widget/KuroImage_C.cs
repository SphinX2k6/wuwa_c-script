using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.Common.View.Widget
{
	// Token: 0x020039D9 RID: 14809
	[UnrealObjectPath("/Game/Aki/UI/Module/Common/View/Widget/KuroImage.KuroImage_C")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class KuroImage_C : UImage, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EF9B RID: 126875 RVA: 0x008A65A6 File Offset: 0x008A47A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (KuroImage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Module/Common/View/Widget/KuroImage.KuroImage_C");
			}
			return KuroImage_C._ClassPtr;
		}

		// Token: 0x0601EF9C RID: 126876 RVA: 0x008A65CC File Offset: 0x008A47CC
		public KuroImage_C() : this(BuiltinUtils.AllocNativeUObject(KuroImage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EF9D RID: 126877 RVA: 0x008A65F4 File Offset: 0x008A47F4
		[NullableContext(1)]
		public KuroImage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KuroImage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601EF9E RID: 126878 RVA: 0x008A6627 File Offset: 0x008A4827
		protected KuroImage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ED30 RID: 60720
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Module/Common/View/Widget/KuroImage.KuroImage_C";

		// Token: 0x0400ED31 RID: 60721
		private static IntPtr _ClassPtr;

		// Token: 0x0400ED32 RID: 60722
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
