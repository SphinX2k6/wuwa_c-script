using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003FF2 RID: 16370
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Core/Fight/ConditionBulletSceneInteraction.ConditionBulletSceneInteraction")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class ConditionBulletSceneInteraction : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029F92 RID: 171922 RVA: 0x009D240B File Offset: 0x009D060B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (ConditionBulletSceneInteraction._ScriptStructPtr != 0) ? ConditionBulletSceneInteraction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/ConditionBulletSceneInteraction.ConditionBulletSceneInteraction", ref ConditionBulletSceneInteraction._ScriptStructPtr);
		}

		// Token: 0x17006616 RID: 26134
		// (get) Token: 0x06029F93 RID: 171923 RVA: 0x009D242F File Offset: 0x009D062F
		// (set) Token: 0x06029F94 RID: 171924 RVA: 0x009D243F File Offset: 0x009D063F
		public unsafe float RangeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ConditionBulletSceneInteraction.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ConditionBulletSceneInteraction.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006617 RID: 26135
		// (get) Token: 0x06029F95 RID: 171925 RVA: 0x009D2450 File Offset: 0x009D0650
		// (set) Token: 0x06029F96 RID: 171926 RVA: 0x009D246F File Offset: 0x009D066F
		public TSoftObjectPtr<BulletSceneInteraction_C> Config
		{
			get
			{
				return new TSoftObjectPtr<BulletSceneInteraction_C>(base.NativePtr + (IntPtr)ConditionBulletSceneInteraction.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)ConditionBulletSceneInteraction.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06029F97 RID: 171927 RVA: 0x009D2494 File Offset: 0x009D0694
		public ConditionBulletSceneInteraction()
		{
		}

		// Token: 0x06029F98 RID: 171928 RVA: 0x009D249C File Offset: 0x009D069C
		public ConditionBulletSceneInteraction(float RangeMin, TSoftObjectPtr<BulletSceneInteraction_C> Config)
		{
			this.RangeMin = RangeMin;
			this.Config = Config;
		}

		// Token: 0x06029F99 RID: 171929 RVA: 0x009D24B2 File Offset: 0x009D06B2
		protected override IntPtr GetUStructPtr()
		{
			return ConditionBulletSceneInteraction.StaticStruct();
		}

		// Token: 0x06029F9A RID: 171930 RVA: 0x009D24BE File Offset: 0x009D06BE
		[NullableContext(2)]
		public ConditionBulletSceneInteraction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029F9B RID: 171931 RVA: 0x009D24C8 File Offset: 0x009D06C8
		public ConditionBulletSceneInteraction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029F9C RID: 171932 RVA: 0x009D24D3 File Offset: 0x009D06D3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new ConditionBulletSceneInteraction(Pointer, false, true);
		}

		// Token: 0x06029F9D RID: 171933 RVA: 0x009D24DD File Offset: 0x009D06DD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new ConditionBulletSceneInteraction(Pointer, MemoryOwner);
		}

		// Token: 0x0401591C RID: 88348
		public const string __ObjectPath = "/Game/Aki/Core/Fight/ConditionBulletSceneInteraction.ConditionBulletSceneInteraction";

		// Token: 0x0401591D RID: 88349
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401591E RID: 88350
		internal static int __PropertyOffset_0;

		// Token: 0x0401591F RID: 88351
		internal static int __PropertyOffset_1;
	}
}
