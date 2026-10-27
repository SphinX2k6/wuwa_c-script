using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.BulletCampAsset
{
	// Token: 0x02003F83 RID: 16259
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/BulletCampAsset/SBulletCamp.SBulletCamp")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SBulletCamp : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029814 RID: 170004 RVA: 0x009C5BF0 File Offset: 0x009C3DF0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletCamp._ScriptStructPtr != 0) ? SBulletCamp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/BulletCampAsset/SBulletCamp.SBulletCamp", ref SBulletCamp._ScriptStructPtr);
		}

		// Token: 0x170063A2 RID: 25506
		// (get) Token: 0x06029815 RID: 170005 RVA: 0x009C5C14 File Offset: 0x009C3E14
		// (set) Token: 0x06029816 RID: 170006 RVA: 0x009C5C57 File Offset: 0x009C3E57
		public TArray<BulletCampType_C> AllType
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BulletCampType_C> result;
				if ((result = this._AllType) == null)
				{
					result = (this._AllType = new TArray<BulletCampType_C>(base.NativePtr + (IntPtr)SBulletCamp.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AllType.CopyAssign(value);
			}
		}

		// Token: 0x06029817 RID: 170007 RVA: 0x009C5C65 File Offset: 0x009C3E65
		public SBulletCamp()
		{
		}

		// Token: 0x06029818 RID: 170008 RVA: 0x009C5C6D File Offset: 0x009C3E6D
		public SBulletCamp(TArray<BulletCampType_C> AllType)
		{
			this.AllType = AllType;
		}

		// Token: 0x06029819 RID: 170009 RVA: 0x009C5C7C File Offset: 0x009C3E7C
		protected override IntPtr GetUStructPtr()
		{
			return SBulletCamp.StaticStruct();
		}

		// Token: 0x0602981A RID: 170010 RVA: 0x009C5C88 File Offset: 0x009C3E88
		[NullableContext(2)]
		public SBulletCamp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602981B RID: 170011 RVA: 0x009C5C92 File Offset: 0x009C3E92
		public SBulletCamp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602981C RID: 170012 RVA: 0x009C5C9D File Offset: 0x009C3E9D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletCamp(Pointer, false, true);
		}

		// Token: 0x0602981D RID: 170013 RVA: 0x009C5CA7 File Offset: 0x009C3EA7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletCamp(Pointer, MemoryOwner);
		}

		// Token: 0x04015465 RID: 87141
		public const string __ObjectPath = "/Game/Aki/Data/Fight/BulletCampAsset/SBulletCamp.SBulletCamp";

		// Token: 0x04015466 RID: 87142
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015467 RID: 87143
		internal static int __PropertyOffset_0;

		// Token: 0x04015468 RID: 87144
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BulletCampType_C> _AllType;
	}
}
