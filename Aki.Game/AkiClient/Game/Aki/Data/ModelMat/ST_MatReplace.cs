using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.ModelMat
{
	// Token: 0x02003EF6 RID: 16118
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/ModelMat/ST_MatReplace.ST_MatReplace")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class ST_MatReplace : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028D1C RID: 167196 RVA: 0x009B5528 File Offset: 0x009B3728
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (ST_MatReplace._ScriptStructPtr != 0) ? ST_MatReplace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/ModelMat/ST_MatReplace.ST_MatReplace", ref ST_MatReplace._ScriptStructPtr);
		}

		// Token: 0x17005FC0 RID: 24512
		// (get) Token: 0x06028D1D RID: 167197 RVA: 0x009B554C File Offset: 0x009B374C
		// (set) Token: 0x06028D1E RID: 167198 RVA: 0x009B5560 File Offset: 0x009B3760
		[Nullable(2)]
		public unsafe UStaticMesh StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + ST_MatReplace.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ST_MatReplace.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005FC1 RID: 24513
		// (get) Token: 0x06028D1F RID: 167199 RVA: 0x009B5578 File Offset: 0x009B3778
		// (set) Token: 0x06028D20 RID: 167200 RVA: 0x009B55BB File Offset: 0x009B37BB
		public TArray<UMaterialInstance> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)ST_MatReplace.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x06028D21 RID: 167201 RVA: 0x009B55C9 File Offset: 0x009B37C9
		public ST_MatReplace()
		{
		}

		// Token: 0x06028D22 RID: 167202 RVA: 0x009B55D1 File Offset: 0x009B37D1
		public ST_MatReplace(UStaticMesh StaticMesh, TArray<UMaterialInstance> Materials)
		{
			this.StaticMesh = StaticMesh;
			this.Materials = Materials;
		}

		// Token: 0x06028D23 RID: 167203 RVA: 0x009B55E7 File Offset: 0x009B37E7
		protected override IntPtr GetUStructPtr()
		{
			return ST_MatReplace.StaticStruct();
		}

		// Token: 0x06028D24 RID: 167204 RVA: 0x009B55F3 File Offset: 0x009B37F3
		[NullableContext(2)]
		public ST_MatReplace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028D25 RID: 167205 RVA: 0x009B55FD File Offset: 0x009B37FD
		public ST_MatReplace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028D26 RID: 167206 RVA: 0x009B5608 File Offset: 0x009B3808
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new ST_MatReplace(Pointer, false, true);
		}

		// Token: 0x06028D27 RID: 167207 RVA: 0x009B5612 File Offset: 0x009B3812
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new ST_MatReplace(Pointer, MemoryOwner);
		}

		// Token: 0x04014DF1 RID: 85489
		public const string __ObjectPath = "/Game/Aki/Data/ModelMat/ST_MatReplace.ST_MatReplace";

		// Token: 0x04014DF2 RID: 85490
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014DF3 RID: 85491
		internal static int __PropertyOffset_0;

		// Token: 0x04014DF4 RID: 85492
		internal static int __PropertyOffset_1;

		// Token: 0x04014DF5 RID: 85493
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Materials;
	}
}
