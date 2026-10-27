using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x02004437 RID: 17463
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Audio/SAudioSpaceDTStruct.SAudioSpaceDTStruct")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SAudioSpaceDTStruct : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D318 RID: 185112 RVA: 0x00A35D08 File Offset: 0x00A33F08
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAudioSpaceDTStruct._ScriptStructPtr != 0) ? SAudioSpaceDTStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Audio/SAudioSpaceDTStruct.SAudioSpaceDTStruct", ref SAudioSpaceDTStruct._ScriptStructPtr);
		}

		// Token: 0x17007279 RID: 29305
		// (get) Token: 0x0602D319 RID: 185113 RVA: 0x00A35D2C File Offset: 0x00A33F2C
		// (set) Token: 0x0602D31A RID: 185114 RVA: 0x00A35D40 File Offset: 0x00A33F40
		public unsafe string AudioSpaceActorName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SAudioSpaceDTStruct.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SAudioSpaceDTStruct.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x1700727A RID: 29306
		// (get) Token: 0x0602D31B RID: 185115 RVA: 0x00A35D55 File Offset: 0x00A33F55
		// (set) Token: 0x0602D31C RID: 185116 RVA: 0x00A35D69 File Offset: 0x00A33F69
		public unsafe FVector AudioSpaceLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAudioSpaceDTStruct.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAudioSpaceDTStruct.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700727B RID: 29307
		// (get) Token: 0x0602D31D RID: 185117 RVA: 0x00A35D7E File Offset: 0x00A33F7E
		// (set) Token: 0x0602D31E RID: 185118 RVA: 0x00A35D92 File Offset: 0x00A33F92
		[Nullable(2)]
		public unsafe UAkAudioEvent InSpaceEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + SAudioSpaceDTStruct.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SAudioSpaceDTStruct.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700727C RID: 29308
		// (get) Token: 0x0602D31F RID: 185119 RVA: 0x00A35DA7 File Offset: 0x00A33FA7
		// (set) Token: 0x0602D320 RID: 185120 RVA: 0x00A35DBB File Offset: 0x00A33FBB
		[Nullable(2)]
		public unsafe UAkAudioEvent OutOfSpaceEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + SAudioSpaceDTStruct.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SAudioSpaceDTStruct.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700727D RID: 29309
		// (get) Token: 0x0602D321 RID: 185121 RVA: 0x00A35DD0 File Offset: 0x00A33FD0
		// (set) Token: 0x0602D322 RID: 185122 RVA: 0x00A35E13 File Offset: 0x00A34013
		public TArray<BP_SAudioCondition> ModifyAudioCondition
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_SAudioCondition> result;
				if ((result = this._ModifyAudioCondition) == null)
				{
					result = (this._ModifyAudioCondition = new TArray<BP_SAudioCondition>(base.NativePtr + (IntPtr)SAudioSpaceDTStruct.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyAudioCondition.CopyAssign(value);
			}
		}

		// Token: 0x0602D323 RID: 185123 RVA: 0x00A35E21 File Offset: 0x00A34021
		public SAudioSpaceDTStruct()
		{
		}

		// Token: 0x0602D324 RID: 185124 RVA: 0x00A35E29 File Offset: 0x00A34029
		public SAudioSpaceDTStruct(string AudioSpaceActorName, FVector AudioSpaceLocation, UAkAudioEvent InSpaceEvent, UAkAudioEvent OutOfSpaceEvent, TArray<BP_SAudioCondition> ModifyAudioCondition)
		{
			this.AudioSpaceActorName = AudioSpaceActorName;
			this.AudioSpaceLocation = AudioSpaceLocation;
			this.InSpaceEvent = InSpaceEvent;
			this.OutOfSpaceEvent = OutOfSpaceEvent;
			this.ModifyAudioCondition = ModifyAudioCondition;
		}

		// Token: 0x0602D325 RID: 185125 RVA: 0x00A35E56 File Offset: 0x00A34056
		protected override IntPtr GetUStructPtr()
		{
			return SAudioSpaceDTStruct.StaticStruct();
		}

		// Token: 0x0602D326 RID: 185126 RVA: 0x00A35E62 File Offset: 0x00A34062
		[NullableContext(2)]
		public SAudioSpaceDTStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D327 RID: 185127 RVA: 0x00A35E6C File Offset: 0x00A3406C
		public SAudioSpaceDTStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D328 RID: 185128 RVA: 0x00A35E77 File Offset: 0x00A34077
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAudioSpaceDTStruct(Pointer, false, true);
		}

		// Token: 0x0602D329 RID: 185129 RVA: 0x00A35E81 File Offset: 0x00A34081
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAudioSpaceDTStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04018060 RID: 98400
		public const string __ObjectPath = "/Game/Aki/Audio/SAudioSpaceDTStruct.SAudioSpaceDTStruct";

		// Token: 0x04018061 RID: 98401
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04018062 RID: 98402
		internal static int __PropertyOffset_0;

		// Token: 0x04018063 RID: 98403
		internal static int __PropertyOffset_1;

		// Token: 0x04018064 RID: 98404
		internal static int __PropertyOffset_2;

		// Token: 0x04018065 RID: 98405
		internal static int __PropertyOffset_3;

		// Token: 0x04018066 RID: 98406
		internal static int __PropertyOffset_4;

		// Token: 0x04018067 RID: 98407
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_SAudioCondition> _ModifyAudioCondition;
	}
}
