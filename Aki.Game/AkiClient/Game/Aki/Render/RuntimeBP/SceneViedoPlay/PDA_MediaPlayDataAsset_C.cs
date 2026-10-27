using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneViedoPlay
{
	// Token: 0x02003BAC RID: 15276
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneViedoPlay/PDA_MediaPlayDataAsset.PDA_MediaPlayDataAsset_C")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class PDA_MediaPlayDataAsset_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022184 RID: 139652 RVA: 0x008FEFF8 File Offset: 0x008FD1F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_MediaPlayDataAsset_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneViedoPlay/PDA_MediaPlayDataAsset.PDA_MediaPlayDataAsset_C");
			}
			return PDA_MediaPlayDataAsset_C._ClassPtr;
		}

		// Token: 0x06022185 RID: 139653 RVA: 0x008FF01C File Offset: 0x008FD21C
		public PDA_MediaPlayDataAsset_C() : this(BuiltinUtils.AllocNativeUObject(PDA_MediaPlayDataAsset_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022186 RID: 139654 RVA: 0x008FF044 File Offset: 0x008FD244
		[NullableContext(1)]
		public PDA_MediaPlayDataAsset_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_MediaPlayDataAsset_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039C3 RID: 14787
		// (get) Token: 0x06022187 RID: 139655 RVA: 0x008FF077 File Offset: 0x008FD277
		// (set) Token: 0x06022188 RID: 139656 RVA: 0x008FF08B File Offset: 0x008FD28B
		public unsafe UStaticMesh StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170039C4 RID: 14788
		// (get) Token: 0x06022189 RID: 139657 RVA: 0x008FF0A0 File Offset: 0x008FD2A0
		// (set) Token: 0x0602218A RID: 139658 RVA: 0x008FF0B0 File Offset: 0x008FD2B0
		public unsafe int MaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_MediaPlayDataAsset_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_MediaPlayDataAsset_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170039C5 RID: 14789
		// (get) Token: 0x0602218B RID: 139659 RVA: 0x008FF0C1 File Offset: 0x008FD2C1
		// (set) Token: 0x0602218C RID: 139660 RVA: 0x008FF0D5 File Offset: 0x008FD2D5
		public unsafe UMediaSource MediaSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSource>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170039C6 RID: 14790
		// (get) Token: 0x0602218D RID: 139661 RVA: 0x008FF0EA File Offset: 0x008FD2EA
		// (set) Token: 0x0602218E RID: 139662 RVA: 0x008FF0FE File Offset: 0x008FD2FE
		public unsafe UAkAudioEvent AkEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170039C7 RID: 14791
		// (get) Token: 0x0602218F RID: 139663 RVA: 0x008FF113 File Offset: 0x008FD313
		// (set) Token: 0x06022190 RID: 139664 RVA: 0x008FF127 File Offset: 0x008FD327
		public unsafe UMediaSource MediaSource_Male
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSource>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170039C8 RID: 14792
		// (get) Token: 0x06022191 RID: 139665 RVA: 0x008FF13C File Offset: 0x008FD33C
		// (set) Token: 0x06022192 RID: 139666 RVA: 0x008FF150 File Offset: 0x008FD350
		public unsafe UMediaSource MediaSource_Female
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSource>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x06022193 RID: 139667 RVA: 0x008FF165 File Offset: 0x008FD365
		protected PDA_MediaPlayDataAsset_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010B1A RID: 68378
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneViedoPlay/PDA_MediaPlayDataAsset.PDA_MediaPlayDataAsset_C";

		// Token: 0x04010B1B RID: 68379
		private static IntPtr _ClassPtr;

		// Token: 0x04010B1C RID: 68380
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010B1D RID: 68381
		internal static int __PropertyOffset_0;

		// Token: 0x04010B1E RID: 68382
		internal static int __PropertyOffset_1;

		// Token: 0x04010B1F RID: 68383
		internal static int __PropertyOffset_2;

		// Token: 0x04010B20 RID: 68384
		internal static int __PropertyOffset_3;

		// Token: 0x04010B21 RID: 68385
		internal static int __PropertyOffset_4;

		// Token: 0x04010B22 RID: 68386
		internal static int __PropertyOffset_5;
	}
}
