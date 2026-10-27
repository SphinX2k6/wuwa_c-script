using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D69 RID: 15721
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SPOICloudParameters.SPOICloudParameters")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 65)]
	public class SPOICloudParameters : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026920 RID: 157984 RVA: 0x00978952 File Offset: 0x00976B52
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPOICloudParameters._ScriptStructPtr != 0) ? SPOICloudParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SPOICloudParameters.SPOICloudParameters", ref SPOICloudParameters._ScriptStructPtr);
		}

		// Token: 0x17005303 RID: 21251
		// (get) Token: 0x06026921 RID: 157985 RVA: 0x00978976 File Offset: 0x00976B76
		// (set) Token: 0x06026922 RID: 157986 RVA: 0x0097898A File Offset: 0x00976B8A
		public unsafe UTexture Mask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + SPOICloudParameters.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SPOICloudParameters.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005304 RID: 21252
		// (get) Token: 0x06026923 RID: 157987 RVA: 0x0097899F File Offset: 0x00976B9F
		// (set) Token: 0x06026924 RID: 157988 RVA: 0x009789AF File Offset: 0x00976BAF
		public unsafe bool YesUV1NoUV2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005305 RID: 21253
		// (get) Token: 0x06026925 RID: 157989 RVA: 0x009789C0 File Offset: 0x00976BC0
		// (set) Token: 0x06026926 RID: 157990 RVA: 0x009789D0 File Offset: 0x00976BD0
		public unsafe int UVTiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005306 RID: 21254
		// (get) Token: 0x06026927 RID: 157991 RVA: 0x009789E1 File Offset: 0x00976BE1
		// (set) Token: 0x06026928 RID: 157992 RVA: 0x009789F1 File Offset: 0x00976BF1
		public unsafe float CloudAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005307 RID: 21255
		// (get) Token: 0x06026929 RID: 157993 RVA: 0x00978A02 File Offset: 0x00976C02
		// (set) Token: 0x0602692A RID: 157994 RVA: 0x00978A12 File Offset: 0x00976C12
		public unsafe float CloudSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005308 RID: 21256
		// (get) Token: 0x0602692B RID: 157995 RVA: 0x00978A23 File Offset: 0x00976C23
		// (set) Token: 0x0602692C RID: 157996 RVA: 0x00978A33 File Offset: 0x00976C33
		public unsafe bool CloudRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005309 RID: 21257
		// (get) Token: 0x0602692D RID: 157997 RVA: 0x00978A44 File Offset: 0x00976C44
		// (set) Token: 0x0602692E RID: 157998 RVA: 0x00978A58 File Offset: 0x00976C58
		public unsafe UTexture NoiseMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + SPOICloudParameters.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SPOICloudParameters.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700530A RID: 21258
		// (get) Token: 0x0602692F RID: 157999 RVA: 0x00978A6D File Offset: 0x00976C6D
		// (set) Token: 0x06026930 RID: 158000 RVA: 0x00978A7D File Offset: 0x00976C7D
		public unsafe float NoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700530B RID: 21259
		// (get) Token: 0x06026931 RID: 158001 RVA: 0x00978A8E File Offset: 0x00976C8E
		// (set) Token: 0x06026932 RID: 158002 RVA: 0x00978A9E File Offset: 0x00976C9E
		public unsafe float NoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700530C RID: 21260
		// (get) Token: 0x06026933 RID: 158003 RVA: 0x00978AAF File Offset: 0x00976CAF
		// (set) Token: 0x06026934 RID: 158004 RVA: 0x00978ABF File Offset: 0x00976CBF
		public unsafe float NoiseTilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700530D RID: 21261
		// (get) Token: 0x06026935 RID: 158005 RVA: 0x00978AD0 File Offset: 0x00976CD0
		// (set) Token: 0x06026936 RID: 158006 RVA: 0x00978AE4 File Offset: 0x00976CE4
		public unsafe UStaticMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + SPOICloudParameters.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SPOICloudParameters.__PropertyOffset_10, value);
			}
		}

		// Token: 0x1700530E RID: 21262
		// (get) Token: 0x06026937 RID: 158007 RVA: 0x00978AF9 File Offset: 0x00976CF9
		// (set) Token: 0x06026938 RID: 158008 RVA: 0x00978B09 File Offset: 0x00976D09
		public unsafe bool SDF_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPOICloudParameters.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026939 RID: 158009 RVA: 0x00978B1A File Offset: 0x00976D1A
		public SPOICloudParameters()
		{
		}

		// Token: 0x0602693A RID: 158010 RVA: 0x00978B24 File Offset: 0x00976D24
		[NullableContext(1)]
		public SPOICloudParameters(UTexture Mask, bool YesUV1NoUV2, int UVTiling, float CloudAngle, float CloudSpeed, bool CloudRotation, UTexture NoiseMap, float NoiseSpeed, float NoiseStrength, float NoiseTilling, UStaticMesh Mesh, bool SDF_)
		{
			this.Mask = Mask;
			this.YesUV1NoUV2 = YesUV1NoUV2;
			this.UVTiling = UVTiling;
			this.CloudAngle = CloudAngle;
			this.CloudSpeed = CloudSpeed;
			this.CloudRotation = CloudRotation;
			this.NoiseMap = NoiseMap;
			this.NoiseSpeed = NoiseSpeed;
			this.NoiseStrength = NoiseStrength;
			this.NoiseTilling = NoiseTilling;
			this.Mesh = Mesh;
			this.SDF_ = SDF_;
		}

		// Token: 0x0602693B RID: 158011 RVA: 0x00978B94 File Offset: 0x00976D94
		protected override IntPtr GetUStructPtr()
		{
			return SPOICloudParameters.StaticStruct();
		}

		// Token: 0x0602693C RID: 158012 RVA: 0x00978BA0 File Offset: 0x00976DA0
		public SPOICloudParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602693D RID: 158013 RVA: 0x00978BAA File Offset: 0x00976DAA
		public SPOICloudParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602693E RID: 158014 RVA: 0x00978BB5 File Offset: 0x00976DB5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPOICloudParameters(Pointer, false, true);
		}

		// Token: 0x0602693F RID: 158015 RVA: 0x00978BBF File Offset: 0x00976DBF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPOICloudParameters(Pointer, MemoryOwner);
		}

		// Token: 0x04013621 RID: 79393
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SPOICloudParameters.SPOICloudParameters";

		// Token: 0x04013622 RID: 79394
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013623 RID: 79395
		internal static int __PropertyOffset_0;

		// Token: 0x04013624 RID: 79396
		internal static int __PropertyOffset_1;

		// Token: 0x04013625 RID: 79397
		internal static int __PropertyOffset_2;

		// Token: 0x04013626 RID: 79398
		internal static int __PropertyOffset_3;

		// Token: 0x04013627 RID: 79399
		internal static int __PropertyOffset_4;

		// Token: 0x04013628 RID: 79400
		internal static int __PropertyOffset_5;

		// Token: 0x04013629 RID: 79401
		internal static int __PropertyOffset_6;

		// Token: 0x0401362A RID: 79402
		internal static int __PropertyOffset_7;

		// Token: 0x0401362B RID: 79403
		internal static int __PropertyOffset_8;

		// Token: 0x0401362C RID: 79404
		internal static int __PropertyOffset_9;

		// Token: 0x0401362D RID: 79405
		internal static int __PropertyOffset_10;

		// Token: 0x0401362E RID: 79406
		internal static int __PropertyOffset_11;
	}
}
