using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.BulletDataAsset
{
	// Token: 0x02003F82 RID: 16258
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/BulletDataAsset/SBulletLogicTypeRow.SBulletLogicTypeRow")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class SBulletLogicTypeRow : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602980A RID: 169994 RVA: 0x009C5B58 File Offset: 0x009C3D58
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletLogicTypeRow._ScriptStructPtr != 0) ? SBulletLogicTypeRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/BulletDataAsset/SBulletLogicTypeRow.SBulletLogicTypeRow", ref SBulletLogicTypeRow._ScriptStructPtr);
		}

		// Token: 0x170063A1 RID: 25505
		// (get) Token: 0x0602980B RID: 169995 RVA: 0x009C5B7C File Offset: 0x009C3D7C
		// (set) Token: 0x0602980C RID: 169996 RVA: 0x009C5B90 File Offset: 0x009C3D90
		[Nullable(2)]
		public unsafe BulletLogicType_C Ref
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BulletLogicType_C>(base.NativePtr / (IntPtr)sizeof(void*) + SBulletLogicTypeRow.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SBulletLogicTypeRow.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602980D RID: 169997 RVA: 0x009C5BA5 File Offset: 0x009C3DA5
		public SBulletLogicTypeRow()
		{
		}

		// Token: 0x0602980E RID: 169998 RVA: 0x009C5BAD File Offset: 0x009C3DAD
		[NullableContext(1)]
		public SBulletLogicTypeRow(BulletLogicType_C Ref)
		{
			this.Ref = Ref;
		}

		// Token: 0x0602980F RID: 169999 RVA: 0x009C5BBC File Offset: 0x009C3DBC
		protected override IntPtr GetUStructPtr()
		{
			return SBulletLogicTypeRow.StaticStruct();
		}

		// Token: 0x06029810 RID: 170000 RVA: 0x009C5BC8 File Offset: 0x009C3DC8
		[NullableContext(2)]
		public SBulletLogicTypeRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029811 RID: 170001 RVA: 0x009C5BD2 File Offset: 0x009C3DD2
		public SBulletLogicTypeRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029812 RID: 170002 RVA: 0x009C5BDD File Offset: 0x009C3DDD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletLogicTypeRow(Pointer, false, true);
		}

		// Token: 0x06029813 RID: 170003 RVA: 0x009C5BE7 File Offset: 0x009C3DE7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletLogicTypeRow(Pointer, MemoryOwner);
		}

		// Token: 0x04015462 RID: 87138
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Fight/BulletDataAsset/SBulletLogicTypeRow.SBulletLogicTypeRow";

		// Token: 0x04015463 RID: 87139
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015464 RID: 87140
		internal static int __PropertyOffset_0;
	}
}
