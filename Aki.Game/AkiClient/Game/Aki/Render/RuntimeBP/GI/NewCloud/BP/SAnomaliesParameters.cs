using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D64 RID: 15716
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SAnomaliesParameters.SAnomaliesParameters")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SAnomaliesParameters : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060268CB RID: 157899 RVA: 0x009782F6 File Offset: 0x009764F6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAnomaliesParameters._ScriptStructPtr != 0) ? SAnomaliesParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SAnomaliesParameters.SAnomaliesParameters", ref SAnomaliesParameters._ScriptStructPtr);
		}

		// Token: 0x170052EC RID: 21228
		// (get) Token: 0x060268CC RID: 157900 RVA: 0x0097831A File Offset: 0x0097651A
		// (set) Token: 0x060268CD RID: 157901 RVA: 0x0097832E File Offset: 0x0097652E
		public unsafe UTexture Color
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + SAnomaliesParameters.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SAnomaliesParameters.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170052ED RID: 21229
		// (get) Token: 0x060268CE RID: 157902 RVA: 0x00978343 File Offset: 0x00976543
		// (set) Token: 0x060268CF RID: 157903 RVA: 0x00978353 File Offset: 0x00976553
		public unsafe float CloudAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAnomaliesParameters.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAnomaliesParameters.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170052EE RID: 21230
		// (get) Token: 0x060268D0 RID: 157904 RVA: 0x00978364 File Offset: 0x00976564
		// (set) Token: 0x060268D1 RID: 157905 RVA: 0x00978378 File Offset: 0x00976578
		public unsafe UTexture NoiseMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + SAnomaliesParameters.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SAnomaliesParameters.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170052EF RID: 21231
		// (get) Token: 0x060268D2 RID: 157906 RVA: 0x0097838D File Offset: 0x0097658D
		// (set) Token: 0x060268D3 RID: 157907 RVA: 0x0097839D File Offset: 0x0097659D
		public unsafe float NoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAnomaliesParameters.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAnomaliesParameters.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170052F0 RID: 21232
		// (get) Token: 0x060268D4 RID: 157908 RVA: 0x009783AE File Offset: 0x009765AE
		// (set) Token: 0x060268D5 RID: 157909 RVA: 0x009783BE File Offset: 0x009765BE
		public unsafe float NoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAnomaliesParameters.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAnomaliesParameters.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170052F1 RID: 21233
		// (get) Token: 0x060268D6 RID: 157910 RVA: 0x009783CF File Offset: 0x009765CF
		// (set) Token: 0x060268D7 RID: 157911 RVA: 0x009783DF File Offset: 0x009765DF
		public unsafe float NoiseTilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAnomaliesParameters.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAnomaliesParameters.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170052F2 RID: 21234
		// (get) Token: 0x060268D8 RID: 157912 RVA: 0x009783F0 File Offset: 0x009765F0
		// (set) Token: 0x060268D9 RID: 157913 RVA: 0x00978400 File Offset: 0x00976600
		public unsafe float luminance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAnomaliesParameters.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAnomaliesParameters.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170052F3 RID: 21235
		// (get) Token: 0x060268DA RID: 157914 RVA: 0x00978411 File Offset: 0x00976611
		// (set) Token: 0x060268DB RID: 157915 RVA: 0x00978421 File Offset: 0x00976621
		public unsafe bool Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAnomaliesParameters.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAnomaliesParameters.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170052F4 RID: 21236
		// (get) Token: 0x060268DC RID: 157916 RVA: 0x00978432 File Offset: 0x00976632
		// (set) Token: 0x060268DD RID: 157917 RVA: 0x00978446 File Offset: 0x00976646
		public unsafe UStaticMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + SAnomaliesParameters.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SAnomaliesParameters.__PropertyOffset_8, value);
			}
		}

		// Token: 0x060268DE RID: 157918 RVA: 0x0097845B File Offset: 0x0097665B
		public SAnomaliesParameters()
		{
		}

		// Token: 0x060268DF RID: 157919 RVA: 0x00978464 File Offset: 0x00976664
		[NullableContext(1)]
		public SAnomaliesParameters(UTexture Color, float CloudAngle, UTexture NoiseMap, float NoiseSpeed, float NoiseStrength, float NoiseTilling, float luminance, bool Rotation, UStaticMesh Mesh)
		{
			this.Color = Color;
			this.CloudAngle = CloudAngle;
			this.NoiseMap = NoiseMap;
			this.NoiseSpeed = NoiseSpeed;
			this.NoiseStrength = NoiseStrength;
			this.NoiseTilling = NoiseTilling;
			this.luminance = luminance;
			this.Rotation = Rotation;
			this.Mesh = Mesh;
		}

		// Token: 0x060268E0 RID: 157920 RVA: 0x009784BC File Offset: 0x009766BC
		protected override IntPtr GetUStructPtr()
		{
			return SAnomaliesParameters.StaticStruct();
		}

		// Token: 0x060268E1 RID: 157921 RVA: 0x009784C8 File Offset: 0x009766C8
		public SAnomaliesParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060268E2 RID: 157922 RVA: 0x009784D2 File Offset: 0x009766D2
		public SAnomaliesParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060268E3 RID: 157923 RVA: 0x009784DD File Offset: 0x009766DD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAnomaliesParameters(Pointer, false, true);
		}

		// Token: 0x060268E4 RID: 157924 RVA: 0x009784E7 File Offset: 0x009766E7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAnomaliesParameters(Pointer, MemoryOwner);
		}

		// Token: 0x040135FE RID: 79358
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SAnomaliesParameters.SAnomaliesParameters";

		// Token: 0x040135FF RID: 79359
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013600 RID: 79360
		internal static int __PropertyOffset_0;

		// Token: 0x04013601 RID: 79361
		internal static int __PropertyOffset_1;

		// Token: 0x04013602 RID: 79362
		internal static int __PropertyOffset_2;

		// Token: 0x04013603 RID: 79363
		internal static int __PropertyOffset_3;

		// Token: 0x04013604 RID: 79364
		internal static int __PropertyOffset_4;

		// Token: 0x04013605 RID: 79365
		internal static int __PropertyOffset_5;

		// Token: 0x04013606 RID: 79366
		internal static int __PropertyOffset_6;

		// Token: 0x04013607 RID: 79367
		internal static int __PropertyOffset_7;

		// Token: 0x04013608 RID: 79368
		internal static int __PropertyOffset_8;
	}
}
