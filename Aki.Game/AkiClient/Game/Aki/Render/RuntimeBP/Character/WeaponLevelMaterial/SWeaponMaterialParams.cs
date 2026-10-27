using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.WeaponLevelMaterial
{
	// Token: 0x02003DF7 RID: 15863
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/WeaponLevelMaterial/SWeaponMaterialParams.SWeaponMaterialParams")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class SWeaponMaterialParams : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060279D0 RID: 162256 RVA: 0x00996244 File Offset: 0x00994444
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWeaponMaterialParams._ScriptStructPtr != 0) ? SWeaponMaterialParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/WeaponLevelMaterial/SWeaponMaterialParams.SWeaponMaterialParams", ref SWeaponMaterialParams._ScriptStructPtr);
		}

		// Token: 0x17005904 RID: 22788
		// (get) Token: 0x060279D1 RID: 162257 RVA: 0x00996268 File Offset: 0x00994468
		// (set) Token: 0x060279D2 RID: 162258 RVA: 0x009962AB File Offset: 0x009944AB
		public TMap<string, float> FloatParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, float> result;
				if ((result = this._FloatParams) == null)
				{
					result = (this._FloatParams = new TMap<string, float>(base.NativePtr + (IntPtr)SWeaponMaterialParams.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatParams.CopyAssign(value);
			}
		}

		// Token: 0x17005905 RID: 22789
		// (get) Token: 0x060279D3 RID: 162259 RVA: 0x009962BC File Offset: 0x009944BC
		// (set) Token: 0x060279D4 RID: 162260 RVA: 0x009962FF File Offset: 0x009944FF
		public TMap<string, FLinearColor> ColorParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FLinearColor> result;
				if ((result = this._ColorParams) == null)
				{
					result = (this._ColorParams = new TMap<string, FLinearColor>(base.NativePtr + (IntPtr)SWeaponMaterialParams.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ColorParams.CopyAssign(value);
			}
		}

		// Token: 0x17005906 RID: 22790
		// (get) Token: 0x060279D5 RID: 162261 RVA: 0x00996310 File Offset: 0x00994510
		// (set) Token: 0x060279D6 RID: 162262 RVA: 0x00996353 File Offset: 0x00994553
		public TMap<string, UTexture> TextureParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UTexture> result;
				if ((result = this._TextureParams) == null)
				{
					result = (this._TextureParams = new TMap<string, UTexture>(base.NativePtr + (IntPtr)SWeaponMaterialParams.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TextureParams.CopyAssign(value);
			}
		}

		// Token: 0x060279D7 RID: 162263 RVA: 0x00996361 File Offset: 0x00994561
		public SWeaponMaterialParams()
		{
		}

		// Token: 0x060279D8 RID: 162264 RVA: 0x00996369 File Offset: 0x00994569
		public SWeaponMaterialParams(TMap<string, float> FloatParams, TMap<string, FLinearColor> ColorParams, TMap<string, UTexture> TextureParams)
		{
			this.FloatParams = FloatParams;
			this.ColorParams = ColorParams;
			this.TextureParams = TextureParams;
		}

		// Token: 0x060279D9 RID: 162265 RVA: 0x00996386 File Offset: 0x00994586
		protected override IntPtr GetUStructPtr()
		{
			return SWeaponMaterialParams.StaticStruct();
		}

		// Token: 0x060279DA RID: 162266 RVA: 0x00996392 File Offset: 0x00994592
		[NullableContext(2)]
		public SWeaponMaterialParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060279DB RID: 162267 RVA: 0x0099639C File Offset: 0x0099459C
		public SWeaponMaterialParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060279DC RID: 162268 RVA: 0x009963A7 File Offset: 0x009945A7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWeaponMaterialParams(Pointer, false, true);
		}

		// Token: 0x060279DD RID: 162269 RVA: 0x009963B1 File Offset: 0x009945B1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWeaponMaterialParams(Pointer, MemoryOwner);
		}

		// Token: 0x0401408C RID: 82060
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/WeaponLevelMaterial/SWeaponMaterialParams.SWeaponMaterialParams";

		// Token: 0x0401408D RID: 82061
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401408E RID: 82062
		internal static int __PropertyOffset_0;

		// Token: 0x0401408F RID: 82063
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, float> _FloatParams;

		// Token: 0x04014090 RID: 82064
		internal static int __PropertyOffset_1;

		// Token: 0x04014091 RID: 82065
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FLinearColor> _ColorParams;

		// Token: 0x04014092 RID: 82066
		internal static int __PropertyOffset_2;

		// Token: 0x04014093 RID: 82067
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UTexture> _TextureParams;
	}
}
