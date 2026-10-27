using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004013 RID: 16403
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataInteraction.SReBulletDataInteraction")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class SReBulletDataInteraction : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602A07F RID: 172159 RVA: 0x009D3CC4 File Offset: 0x009D1EC4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataInteraction._ScriptStructPtr != 0) ? SReBulletDataInteraction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataInteraction.SReBulletDataInteraction", ref SReBulletDataInteraction._ScriptStructPtr);
		}

		// Token: 0x17006664 RID: 26212
		// (get) Token: 0x0602A080 RID: 172160 RVA: 0x009D3CE8 File Offset: 0x009D1EE8
		// (set) Token: 0x0602A081 RID: 172161 RVA: 0x009D3D07 File Offset: 0x009D1F07
		public TSoftObjectPtr<BulletSceneInteraction_C> 水面交互
		{
			get
			{
				return new TSoftObjectPtr<BulletSceneInteraction_C>(base.NativePtr + (IntPtr)SReBulletDataInteraction.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataInteraction.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006665 RID: 26213
		// (get) Token: 0x0602A082 RID: 172162 RVA: 0x009D3D2C File Offset: 0x009D1F2C
		// (set) Token: 0x0602A083 RID: 172163 RVA: 0x009D3D4B File Offset: 0x009D1F4B
		public TSoftObjectPtr<BP_SceneBattleInteract_C> 场景物件交互
		{
			get
			{
				return new TSoftObjectPtr<BP_SceneBattleInteract_C>(base.NativePtr + (IntPtr)SReBulletDataInteraction.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataInteraction.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602A084 RID: 172164 RVA: 0x009D3D70 File Offset: 0x009D1F70
		public SReBulletDataInteraction()
		{
		}

		// Token: 0x0602A085 RID: 172165 RVA: 0x009D3D78 File Offset: 0x009D1F78
		public SReBulletDataInteraction(TSoftObjectPtr<BulletSceneInteraction_C> 水面交互, TSoftObjectPtr<BP_SceneBattleInteract_C> 场景物件交互)
		{
			this.水面交互 = 水面交互;
			this.场景物件交互 = 场景物件交互;
		}

		// Token: 0x0602A086 RID: 172166 RVA: 0x009D3D8E File Offset: 0x009D1F8E
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataInteraction.StaticStruct();
		}

		// Token: 0x0602A087 RID: 172167 RVA: 0x009D3D9A File Offset: 0x009D1F9A
		[NullableContext(2)]
		public SReBulletDataInteraction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A088 RID: 172168 RVA: 0x009D3DA4 File Offset: 0x009D1FA4
		public SReBulletDataInteraction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A089 RID: 172169 RVA: 0x009D3DAF File Offset: 0x009D1FAF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataInteraction(Pointer, false, true);
		}

		// Token: 0x0602A08A RID: 172170 RVA: 0x009D3DB9 File Offset: 0x009D1FB9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataInteraction(Pointer, MemoryOwner);
		}

		// Token: 0x04015A53 RID: 88659
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataInteraction.SReBulletDataInteraction";

		// Token: 0x04015A54 RID: 88660
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015A55 RID: 88661
		internal static int __PropertyOffset_0;

		// Token: 0x04015A56 RID: 88662
		internal static int __PropertyOffset_1;
	}
}
