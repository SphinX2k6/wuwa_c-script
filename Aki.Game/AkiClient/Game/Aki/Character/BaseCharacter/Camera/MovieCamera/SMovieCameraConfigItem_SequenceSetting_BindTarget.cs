using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020033F4 RID: 13300
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting_BindTarget.SMovieCameraConfigItem_SequenceSetting_BindTarget")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 132)]
	public class SMovieCameraConfigItem_SequenceSetting_BindTarget : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021BCF RID: 138191 RVA: 0x00967FA0 File Offset: 0x009661A0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovieCameraConfigItem_SequenceSetting_BindTarget._ScriptStructPtr != 0) ? SMovieCameraConfigItem_SequenceSetting_BindTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting_BindTarget.SMovieCameraConfigItem_SequenceSetting_BindTarget", ref SMovieCameraConfigItem_SequenceSetting_BindTarget._ScriptStructPtr);
		}

		// Token: 0x170045F2 RID: 17906
		// (get) Token: 0x06021BD0 RID: 138192 RVA: 0x00967FC4 File Offset: 0x009661C4
		// (set) Token: 0x06021BD1 RID: 138193 RVA: 0x00967FD8 File Offset: 0x009661D8
		public unsafe TEnumAsByte<EMovieCameraSequenceSettingBindTargetType> BindTargetType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_BindTargetType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_BindTargetType) = value;
			}
		}

		// Token: 0x170045F3 RID: 17907
		// (get) Token: 0x06021BD2 RID: 138194 RVA: 0x00967FED File Offset: 0x009661ED
		// (set) Token: 0x06021BD3 RID: 138195 RVA: 0x00968001 File Offset: 0x00966201
		public unsafe FName AttachSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_AttachSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_AttachSocketName) = value;
			}
		}

		// Token: 0x170045F4 RID: 17908
		// (get) Token: 0x06021BD4 RID: 138196 RVA: 0x00968016 File Offset: 0x00966216
		// (set) Token: 0x06021BD5 RID: 138197 RVA: 0x0096802A File Offset: 0x0096622A
		public unsafe FVectorDouble AttachLocationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_AttachLocationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_AttachLocationOffset) = value;
			}
		}

		// Token: 0x170045F5 RID: 17909
		// (get) Token: 0x06021BD6 RID: 138198 RVA: 0x0096803F File Offset: 0x0096623F
		// (set) Token: 0x06021BD7 RID: 138199 RVA: 0x00968053 File Offset: 0x00966253
		public unsafe FRotator AttachRotatorOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_AttachRotatorOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_AttachRotatorOffset) = value;
			}
		}

		// Token: 0x170045F6 RID: 17910
		// (get) Token: 0x06021BD8 RID: 138200 RVA: 0x00968068 File Offset: 0x00966268
		// (set) Token: 0x06021BD9 RID: 138201 RVA: 0x0096807C File Offset: 0x0096627C
		public unsafe FVectorDouble SpecificLocationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_SpecificLocationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_SpecificLocationOffset) = value;
			}
		}

		// Token: 0x170045F7 RID: 17911
		// (get) Token: 0x06021BDA RID: 138202 RVA: 0x00968091 File Offset: 0x00966291
		// (set) Token: 0x06021BDB RID: 138203 RVA: 0x009680A5 File Offset: 0x009662A5
		public unsafe FRotator SpecificRotatorOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_SpecificRotatorOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_SpecificRotatorOffset) = value;
			}
		}

		// Token: 0x170045F8 RID: 17912
		// (get) Token: 0x06021BDC RID: 138204 RVA: 0x009680BA File Offset: 0x009662BA
		// (set) Token: 0x06021BDD RID: 138205 RVA: 0x009680CE File Offset: 0x009662CE
		public unsafe FVectorDouble WorldLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_WorldLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_WorldLocation) = value;
			}
		}

		// Token: 0x170045F9 RID: 17913
		// (get) Token: 0x06021BDE RID: 138206 RVA: 0x009680E3 File Offset: 0x009662E3
		// (set) Token: 0x06021BDF RID: 138207 RVA: 0x009680F7 File Offset: 0x009662F7
		public unsafe FRotator WorldRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_WorldRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_SequenceSetting_BindTarget.__PropertyOffset_WorldRotation) = value;
			}
		}

		// Token: 0x06021BE0 RID: 138208 RVA: 0x0096810C File Offset: 0x0096630C
		public SMovieCameraConfigItem_SequenceSetting_BindTarget()
		{
		}

		// Token: 0x06021BE1 RID: 138209 RVA: 0x00968114 File Offset: 0x00966314
		protected override IntPtr GetUStructPtr()
		{
			return SMovieCameraConfigItem_SequenceSetting_BindTarget.StaticStruct();
		}

		// Token: 0x06021BE2 RID: 138210 RVA: 0x00968120 File Offset: 0x00966320
		[NullableContext(2)]
		public SMovieCameraConfigItem_SequenceSetting_BindTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021BE3 RID: 138211 RVA: 0x0096812A File Offset: 0x0096632A
		public SMovieCameraConfigItem_SequenceSetting_BindTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021BE4 RID: 138212 RVA: 0x00968135 File Offset: 0x00966335
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovieCameraConfigItem_SequenceSetting_BindTarget(Pointer, false, true);
		}

		// Token: 0x06021BE5 RID: 138213 RVA: 0x0096813F File Offset: 0x0096633F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovieCameraConfigItem_SequenceSetting_BindTarget(Pointer, MemoryOwner);
		}

		// Token: 0x04012963 RID: 76131
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_SequenceSetting_BindTarget.SMovieCameraConfigItem_SequenceSetting_BindTarget";

		// Token: 0x04012964 RID: 76132
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012965 RID: 76133
		internal static int __PropertyOffset_BindTargetType;

		// Token: 0x04012966 RID: 76134
		internal static int __PropertyOffset_AttachSocketName;

		// Token: 0x04012967 RID: 76135
		internal static int __PropertyOffset_AttachLocationOffset;

		// Token: 0x04012968 RID: 76136
		internal static int __PropertyOffset_AttachRotatorOffset;

		// Token: 0x04012969 RID: 76137
		internal static int __PropertyOffset_SpecificLocationOffset;

		// Token: 0x0401296A RID: 76138
		internal static int __PropertyOffset_SpecificRotatorOffset;

		// Token: 0x0401296B RID: 76139
		internal static int __PropertyOffset_WorldLocation;

		// Token: 0x0401296C RID: 76140
		internal static int __PropertyOffset_WorldRotation;
	}
}
