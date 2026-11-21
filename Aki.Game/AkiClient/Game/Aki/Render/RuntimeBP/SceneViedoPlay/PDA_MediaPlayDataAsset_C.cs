using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneViedoPlay
{
	// Token: 0x020030D6 RID: 12502
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneViedoPlay/PDA_MediaPlayDataAsset.PDA_MediaPlayDataAsset_C")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class PDA_MediaPlayDataAsset_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E27A RID: 123514 RVA: 0x0090C71B File Offset: 0x0090A91B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_MediaPlayDataAsset_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneViedoPlay/PDA_MediaPlayDataAsset.PDA_MediaPlayDataAsset_C");
			}
			return PDA_MediaPlayDataAsset_C._ClassPtr;
		}

		// Token: 0x0601E27B RID: 123515 RVA: 0x0090C740 File Offset: 0x0090A940
		public PDA_MediaPlayDataAsset_C() : this(BuiltinUtils.AllocNativeUObject(PDA_MediaPlayDataAsset_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E27C RID: 123516 RVA: 0x0090C768 File Offset: 0x0090A968
		[NullableContext(1)]
		public PDA_MediaPlayDataAsset_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_MediaPlayDataAsset_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700323A RID: 12858
		// (get) Token: 0x0601E27D RID: 123517 RVA: 0x0090C79B File Offset: 0x0090A99B
		// (set) Token: 0x0601E27E RID: 123518 RVA: 0x0090C7AF File Offset: 0x0090A9AF
		public unsafe UStaticMesh StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_StaticMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x1700323B RID: 12859
		// (get) Token: 0x0601E27F RID: 123519 RVA: 0x0090C7C4 File Offset: 0x0090A9C4
		// (set) Token: 0x0601E280 RID: 123520 RVA: 0x0090C7D4 File Offset: 0x0090A9D4
		public unsafe int MaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_MediaPlayDataAsset_C.__PropertyOffset_MaterialIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_MediaPlayDataAsset_C.__PropertyOffset_MaterialIndex) = value;
			}
		}

		// Token: 0x1700323C RID: 12860
		// (get) Token: 0x0601E281 RID: 123521 RVA: 0x0090C7E5 File Offset: 0x0090A9E5
		// (set) Token: 0x0601E282 RID: 123522 RVA: 0x0090C7F9 File Offset: 0x0090A9F9
		public unsafe UMediaSource MediaSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSource>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_MediaSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_MediaSource, value);
			}
		}

		// Token: 0x1700323D RID: 12861
		// (get) Token: 0x0601E283 RID: 123523 RVA: 0x0090C80E File Offset: 0x0090AA0E
		// (set) Token: 0x0601E284 RID: 123524 RVA: 0x0090C822 File Offset: 0x0090AA22
		public unsafe UAkAudioEvent AkEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_AkEvent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_AkEvent, value);
			}
		}

		// Token: 0x1700323E RID: 12862
		// (get) Token: 0x0601E285 RID: 123525 RVA: 0x0090C837 File Offset: 0x0090AA37
		// (set) Token: 0x0601E286 RID: 123526 RVA: 0x0090C84B File Offset: 0x0090AA4B
		public unsafe UMediaSource MediaSource_Male
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSource>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_MediaSource_Male);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_MediaSource_Male, value);
			}
		}

		// Token: 0x1700323F RID: 12863
		// (get) Token: 0x0601E287 RID: 123527 RVA: 0x0090C860 File Offset: 0x0090AA60
		// (set) Token: 0x0601E288 RID: 123528 RVA: 0x0090C874 File Offset: 0x0090AA74
		public unsafe UMediaSource MediaSource_Female
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSource>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_MediaSource_Female);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_MediaPlayDataAsset_C.__PropertyOffset_MediaSource_Female, value);
			}
		}

		// Token: 0x0601E289 RID: 123529 RVA: 0x0090C889 File Offset: 0x0090AA89
		protected PDA_MediaPlayDataAsset_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF32 RID: 65330
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneViedoPlay/PDA_MediaPlayDataAsset.PDA_MediaPlayDataAsset_C";

		// Token: 0x0400FF33 RID: 65331
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF34 RID: 65332
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF35 RID: 65333
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0400FF36 RID: 65334
		internal static int __PropertyOffset_MaterialIndex;

		// Token: 0x0400FF37 RID: 65335
		internal static int __PropertyOffset_MediaSource;

		// Token: 0x0400FF38 RID: 65336
		internal static int __PropertyOffset_AkEvent;

		// Token: 0x0400FF39 RID: 65337
		internal static int __PropertyOffset_MediaSource_Male;

		// Token: 0x0400FF3A RID: 65338
		internal static int __PropertyOffset_MediaSource_Female;
	}
}
