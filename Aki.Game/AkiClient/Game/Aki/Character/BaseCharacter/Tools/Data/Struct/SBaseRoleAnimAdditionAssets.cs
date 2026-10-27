using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Tools.Data.Struct
{
	// Token: 0x0200434B RID: 17227
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Tools/Data/Struct/SBaseRoleAnimAdditionAssets.SBaseRoleAnimAdditionAssets")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SBaseRoleAnimAdditionAssets : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CAC6 RID: 182982 RVA: 0x00A25703 File Offset: 0x00A23903
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBaseRoleAnimAdditionAssets._ScriptStructPtr != 0) ? SBaseRoleAnimAdditionAssets._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Tools/Data/Struct/SBaseRoleAnimAdditionAssets.SBaseRoleAnimAdditionAssets", ref SBaseRoleAnimAdditionAssets._ScriptStructPtr);
		}

		// Token: 0x17007069 RID: 28777
		// (get) Token: 0x0602CAC7 RID: 182983 RVA: 0x00A25728 File Offset: 0x00A23928
		// (set) Token: 0x0602CAC8 RID: 182984 RVA: 0x00A2576B File Offset: 0x00A2396B
		public TArray<string> Paths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Paths) == null)
				{
					result = (this._Paths = new TArray<string>(base.NativePtr + (IntPtr)SBaseRoleAnimAdditionAssets.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Paths.CopyAssign(value);
			}
		}

		// Token: 0x1700706A RID: 28778
		// (get) Token: 0x0602CAC9 RID: 182985 RVA: 0x00A2577C File Offset: 0x00A2397C
		// (set) Token: 0x0602CACA RID: 182986 RVA: 0x00A257BF File Offset: 0x00A239BF
		public TArray<string> Anims
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Anims) == null)
				{
					result = (this._Anims = new TArray<string>(base.NativePtr + (IntPtr)SBaseRoleAnimAdditionAssets.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Anims.CopyAssign(value);
			}
		}

		// Token: 0x1700706B RID: 28779
		// (get) Token: 0x0602CACB RID: 182987 RVA: 0x00A257D0 File Offset: 0x00A239D0
		// (set) Token: 0x0602CACC RID: 182988 RVA: 0x00A25813 File Offset: 0x00A23A13
		public TArray<string> Ribbons
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Ribbons) == null)
				{
					result = (this._Ribbons = new TArray<string>(base.NativePtr + (IntPtr)SBaseRoleAnimAdditionAssets.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Ribbons.CopyAssign(value);
			}
		}

		// Token: 0x1700706C RID: 28780
		// (get) Token: 0x0602CACD RID: 182989 RVA: 0x00A25824 File Offset: 0x00A23A24
		// (set) Token: 0x0602CACE RID: 182990 RVA: 0x00A25867 File Offset: 0x00A23A67
		public TArray<string> Blendspaces
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Blendspaces) == null)
				{
					result = (this._Blendspaces = new TArray<string>(base.NativePtr + (IntPtr)SBaseRoleAnimAdditionAssets.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Blendspaces.CopyAssign(value);
			}
		}

		// Token: 0x0602CACF RID: 182991 RVA: 0x00A25875 File Offset: 0x00A23A75
		public SBaseRoleAnimAdditionAssets()
		{
		}

		// Token: 0x0602CAD0 RID: 182992 RVA: 0x00A2587D File Offset: 0x00A23A7D
		public SBaseRoleAnimAdditionAssets(TArray<string> Paths, TArray<string> Anims, TArray<string> Ribbons, TArray<string> Blendspaces)
		{
			this.Paths = Paths;
			this.Anims = Anims;
			this.Ribbons = Ribbons;
			this.Blendspaces = Blendspaces;
		}

		// Token: 0x0602CAD1 RID: 182993 RVA: 0x00A258A2 File Offset: 0x00A23AA2
		protected override IntPtr GetUStructPtr()
		{
			return SBaseRoleAnimAdditionAssets.StaticStruct();
		}

		// Token: 0x0602CAD2 RID: 182994 RVA: 0x00A258AE File Offset: 0x00A23AAE
		[NullableContext(2)]
		public SBaseRoleAnimAdditionAssets(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CAD3 RID: 182995 RVA: 0x00A258B8 File Offset: 0x00A23AB8
		public SBaseRoleAnimAdditionAssets(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CAD4 RID: 182996 RVA: 0x00A258C3 File Offset: 0x00A23AC3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBaseRoleAnimAdditionAssets(Pointer, false, true);
		}

		// Token: 0x0602CAD5 RID: 182997 RVA: 0x00A258CD File Offset: 0x00A23ACD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBaseRoleAnimAdditionAssets(Pointer, MemoryOwner);
		}

		// Token: 0x040178CE RID: 96462
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Tools/Data/Struct/SBaseRoleAnimAdditionAssets.SBaseRoleAnimAdditionAssets";

		// Token: 0x040178CF RID: 96463
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040178D0 RID: 96464
		internal static int __PropertyOffset_0;

		// Token: 0x040178D1 RID: 96465
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Paths;

		// Token: 0x040178D2 RID: 96466
		internal static int __PropertyOffset_1;

		// Token: 0x040178D3 RID: 96467
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Anims;

		// Token: 0x040178D4 RID: 96468
		internal static int __PropertyOffset_2;

		// Token: 0x040178D5 RID: 96469
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Ribbons;

		// Token: 0x040178D6 RID: 96470
		internal static int __PropertyOffset_3;

		// Token: 0x040178D7 RID: 96471
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Blendspaces;
	}
}
