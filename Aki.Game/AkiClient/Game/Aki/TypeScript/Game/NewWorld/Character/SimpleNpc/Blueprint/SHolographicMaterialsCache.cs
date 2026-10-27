using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.TypeScript.Game.NewWorld.Character.SimpleNpc.Blueprint
{
	// Token: 0x02003A16 RID: 14870
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/SHolographicMaterialsCache.SHolographicMaterialsCache")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SHolographicMaterialsCache : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F321 RID: 127777 RVA: 0x008AFB94 File Offset: 0x008ADD94
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SHolographicMaterialsCache._ScriptStructPtr != 0) ? SHolographicMaterialsCache._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/SHolographicMaterialsCache.SHolographicMaterialsCache", ref SHolographicMaterialsCache._ScriptStructPtr);
		}

		// Token: 0x17002A39 RID: 10809
		// (get) Token: 0x0601F322 RID: 127778 RVA: 0x008AFBB8 File Offset: 0x008ADDB8
		// (set) Token: 0x0601F323 RID: 127779 RVA: 0x008AFBFB File Offset: 0x008ADDFB
		public TArray<SMaterialParamCache> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialParamCache> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<SMaterialParamCache>(base.NativePtr + (IntPtr)SHolographicMaterialsCache.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x0601F324 RID: 127780 RVA: 0x008AFC09 File Offset: 0x008ADE09
		public SHolographicMaterialsCache()
		{
		}

		// Token: 0x0601F325 RID: 127781 RVA: 0x008AFC11 File Offset: 0x008ADE11
		public SHolographicMaterialsCache(TArray<SMaterialParamCache> Materials)
		{
			this.Materials = Materials;
		}

		// Token: 0x0601F326 RID: 127782 RVA: 0x008AFC20 File Offset: 0x008ADE20
		protected override IntPtr GetUStructPtr()
		{
			return SHolographicMaterialsCache.StaticStruct();
		}

		// Token: 0x0601F327 RID: 127783 RVA: 0x008AFC2C File Offset: 0x008ADE2C
		[NullableContext(2)]
		public SHolographicMaterialsCache(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F328 RID: 127784 RVA: 0x008AFC36 File Offset: 0x008ADE36
		public SHolographicMaterialsCache(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F329 RID: 127785 RVA: 0x008AFC41 File Offset: 0x008ADE41
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SHolographicMaterialsCache(Pointer, false, true);
		}

		// Token: 0x0601F32A RID: 127786 RVA: 0x008AFC4B File Offset: 0x008ADE4B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SHolographicMaterialsCache(Pointer, MemoryOwner);
		}

		// Token: 0x0400EF24 RID: 61220
		public const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/SHolographicMaterialsCache.SHolographicMaterialsCache";

		// Token: 0x0400EF25 RID: 61221
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EF26 RID: 61222
		internal static int __PropertyOffset_0;

		// Token: 0x0400EF27 RID: 61223
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialParamCache> _Materials;
	}
}
