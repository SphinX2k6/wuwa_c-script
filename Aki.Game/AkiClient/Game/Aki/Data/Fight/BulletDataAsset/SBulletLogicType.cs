using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.BulletDataAsset
{
	// Token: 0x02003F81 RID: 16257
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/BulletDataAsset/SBulletLogicType.SBulletLogicType")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SBulletLogicType : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029800 RID: 169984 RVA: 0x009C5A98 File Offset: 0x009C3C98
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletLogicType._ScriptStructPtr != 0) ? SBulletLogicType._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/BulletDataAsset/SBulletLogicType.SBulletLogicType", ref SBulletLogicType._ScriptStructPtr);
		}

		// Token: 0x170063A0 RID: 25504
		// (get) Token: 0x06029801 RID: 169985 RVA: 0x009C5ABC File Offset: 0x009C3CBC
		// (set) Token: 0x06029802 RID: 169986 RVA: 0x009C5AFF File Offset: 0x009C3CFF
		public TArray<BulletLogicType_C> AllBulletLogicType
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BulletLogicType_C> result;
				if ((result = this._AllBulletLogicType) == null)
				{
					result = (this._AllBulletLogicType = new TArray<BulletLogicType_C>(base.NativePtr + (IntPtr)SBulletLogicType.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AllBulletLogicType.CopyAssign(value);
			}
		}

		// Token: 0x06029803 RID: 169987 RVA: 0x009C5B0D File Offset: 0x009C3D0D
		public SBulletLogicType()
		{
		}

		// Token: 0x06029804 RID: 169988 RVA: 0x009C5B15 File Offset: 0x009C3D15
		public SBulletLogicType(TArray<BulletLogicType_C> AllBulletLogicType)
		{
			this.AllBulletLogicType = AllBulletLogicType;
		}

		// Token: 0x06029805 RID: 169989 RVA: 0x009C5B24 File Offset: 0x009C3D24
		protected override IntPtr GetUStructPtr()
		{
			return SBulletLogicType.StaticStruct();
		}

		// Token: 0x06029806 RID: 169990 RVA: 0x009C5B30 File Offset: 0x009C3D30
		[NullableContext(2)]
		public SBulletLogicType(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029807 RID: 169991 RVA: 0x009C5B3A File Offset: 0x009C3D3A
		public SBulletLogicType(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029808 RID: 169992 RVA: 0x009C5B45 File Offset: 0x009C3D45
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletLogicType(Pointer, false, true);
		}

		// Token: 0x06029809 RID: 169993 RVA: 0x009C5B4F File Offset: 0x009C3D4F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletLogicType(Pointer, MemoryOwner);
		}

		// Token: 0x0401545E RID: 87134
		public const string __ObjectPath = "/Game/Aki/Data/Fight/BulletDataAsset/SBulletLogicType.SBulletLogicType";

		// Token: 0x0401545F RID: 87135
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015460 RID: 87136
		internal static int __PropertyOffset_0;

		// Token: 0x04015461 RID: 87137
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BulletLogicType_C> _AllBulletLogicType;
	}
}
