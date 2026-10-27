using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D62 RID: 15714
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/PD_CloudPrefab.PD_CloudPrefab_C")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class PD_CloudPrefab_C : UKuroPDCloudPrefab, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060267D3 RID: 157651 RVA: 0x009766C4 File Offset: 0x009748C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_CloudPrefab_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/PD_CloudPrefab.PD_CloudPrefab_C");
			}
			return PD_CloudPrefab_C._ClassPtr;
		}

		// Token: 0x060267D4 RID: 157652 RVA: 0x009766E8 File Offset: 0x009748E8
		public PD_CloudPrefab_C() : this(BuiltinUtils.AllocNativeUObject(PD_CloudPrefab_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060267D5 RID: 157653 RVA: 0x00976710 File Offset: 0x00974910
		[NullableContext(1)]
		public PD_CloudPrefab_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_CloudPrefab_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005274 RID: 21108
		// (get) Token: 0x060267D6 RID: 157654 RVA: 0x00976743 File Offset: 0x00974943
		// (set) Token: 0x060267D7 RID: 157655 RVA: 0x00976757 File Offset: 0x00974957
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<BP_CloudPrefab_C> PrefebBP
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CloudPrefab_C.__PropertyOffset_0);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)PD_CloudPrefab_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x060267D8 RID: 157656 RVA: 0x0097676C File Offset: 0x0097496C
		protected PD_CloudPrefab_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013580 RID: 79232
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/PD_CloudPrefab.PD_CloudPrefab_C";

		// Token: 0x04013581 RID: 79233
		private static IntPtr _ClassPtr;

		// Token: 0x04013582 RID: 79234
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013583 RID: 79235
		internal static int __PropertyOffset_0;
	}
}
