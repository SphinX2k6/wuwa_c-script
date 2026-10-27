using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.Setting.EffectDataAsset
{
	// Token: 0x02003E6D RID: 15981
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelAudio.BP_EffectModelAudio_C")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class BP_EffectModelAudio_C : BP_EffectModelBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060283AB RID: 164779 RVA: 0x009A709F File Offset: 0x009A529F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectModelAudio_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelAudio.BP_EffectModelAudio_C");
			}
			return BP_EffectModelAudio_C._ClassPtr;
		}

		// Token: 0x060283AC RID: 164780 RVA: 0x009A70C4 File Offset: 0x009A52C4
		public BP_EffectModelAudio_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelAudio_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060283AD RID: 164781 RVA: 0x009A70EC File Offset: 0x009A52EC
		public BP_EffectModelAudio_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectModelAudio_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C7E RID: 23678
		// (get) Token: 0x060283AE RID: 164782 RVA: 0x009A7120 File Offset: 0x009A5320
		// (set) Token: 0x060283AF RID: 164783 RVA: 0x009A7159 File Offset: 0x009A5359
		public FSoftObjectPath AudioEventSoft
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._AudioEventSoft) == null)
				{
					result = (this._AudioEventSoft = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_EffectModelAudio_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_EffectModelAudio_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005C7F RID: 23679
		// (get) Token: 0x060283B0 RID: 164784 RVA: 0x009A717C File Offset: 0x009A537C
		// (set) Token: 0x060283B1 RID: 164785 RVA: 0x009A71B5 File Offset: 0x009A53B5
		public TArray<string> SwitchList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SwitchList) == null)
				{
					result = (this._SwitchList = new TArray<string>(base.NativePtr + (IntPtr)BP_EffectModelAudio_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.SwitchList.CopyAssign(value);
			}
		}

		// Token: 0x17005C80 RID: 23680
		// (get) Token: 0x060283B2 RID: 164786 RVA: 0x009A71C3 File Offset: 0x009A53C3
		// (set) Token: 0x060283B3 RID: 164787 RVA: 0x009A71D3 File Offset: 0x009A53D3
		public unsafe float ActivateDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelAudio_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelAudio_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005C81 RID: 23681
		// (get) Token: 0x060283B4 RID: 164788 RVA: 0x009A71E4 File Offset: 0x009A53E4
		// (set) Token: 0x060283B5 RID: 164789 RVA: 0x009A71F4 File Offset: 0x009A53F4
		public unsafe bool IsStatic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelAudio_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelAudio_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C82 RID: 23682
		// (get) Token: 0x060283B6 RID: 164790 RVA: 0x009A7205 File Offset: 0x009A5405
		// (set) Token: 0x060283B7 RID: 164791 RVA: 0x009A7215 File Offset: 0x009A5415
		public unsafe float FadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectModelAudio_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectModelAudio_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005C83 RID: 23683
		// (get) Token: 0x060283B8 RID: 164792 RVA: 0x009A7226 File Offset: 0x009A5426
		// (set) Token: 0x060283B9 RID: 164793 RVA: 0x009A723A File Offset: 0x009A543A
		[Nullable(2)]
		public unsafe UAkAudioEvent AudioEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelAudio_C.__PropertyOffset_5);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectModelAudio_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x060283BA RID: 164794 RVA: 0x009A724F File Offset: 0x009A544F
		protected BP_EffectModelAudio_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040147AF RID: 83887
		public new const string __ObjectPath = "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectModelAudio.BP_EffectModelAudio_C";

		// Token: 0x040147B0 RID: 83888
		private static IntPtr _ClassPtr;

		// Token: 0x040147B1 RID: 83889
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040147B2 RID: 83890
		internal new static int __PropertyOffset_0;

		// Token: 0x040147B3 RID: 83891
		[Nullable(2)]
		private FSoftObjectPath _AudioEventSoft;

		// Token: 0x040147B4 RID: 83892
		internal new static int __PropertyOffset_1;

		// Token: 0x040147B5 RID: 83893
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SwitchList;

		// Token: 0x040147B6 RID: 83894
		internal new static int __PropertyOffset_2;

		// Token: 0x040147B7 RID: 83895
		internal new static int __PropertyOffset_3;

		// Token: 0x040147B8 RID: 83896
		internal new static int __PropertyOffset_4;

		// Token: 0x040147B9 RID: 83897
		internal new static int __PropertyOffset_5;
	}
}
