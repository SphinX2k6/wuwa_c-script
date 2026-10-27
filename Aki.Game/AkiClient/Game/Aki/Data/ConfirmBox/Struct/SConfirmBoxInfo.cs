using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.ConfirmBox.Struct
{
	// Token: 0x02003F9D RID: 16285
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/ConfirmBox/Struct/SConfirmBoxInfo.SConfirmBoxInfo")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SConfirmBoxInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060299A3 RID: 170403 RVA: 0x009C8584 File Offset: 0x009C6784
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SConfirmBoxInfo._ScriptStructPtr != 0) ? SConfirmBoxInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/ConfirmBox/Struct/SConfirmBoxInfo.SConfirmBoxInfo", ref SConfirmBoxInfo._ScriptStructPtr);
		}

		// Token: 0x1700642D RID: 25645
		// (get) Token: 0x060299A4 RID: 170404 RVA: 0x009C85A8 File Offset: 0x009C67A8
		// (set) Token: 0x060299A5 RID: 170405 RVA: 0x009C85BC File Offset: 0x009C67BC
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SConfirmBoxInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SConfirmBoxInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700642E RID: 25646
		// (get) Token: 0x060299A6 RID: 170406 RVA: 0x009C85D1 File Offset: 0x009C67D1
		// (set) Token: 0x060299A7 RID: 170407 RVA: 0x009C85E5 File Offset: 0x009C67E5
		public unsafe FName Title
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SConfirmBoxInfo.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SConfirmBoxInfo.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700642F RID: 25647
		// (get) Token: 0x060299A8 RID: 170408 RVA: 0x009C85FA File Offset: 0x009C67FA
		// (set) Token: 0x060299A9 RID: 170409 RVA: 0x009C860E File Offset: 0x009C680E
		public unsafe FName Content
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SConfirmBoxInfo.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SConfirmBoxInfo.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006430 RID: 25648
		// (get) Token: 0x060299AA RID: 170410 RVA: 0x009C8624 File Offset: 0x009C6824
		// (set) Token: 0x060299AB RID: 170411 RVA: 0x009C8667 File Offset: 0x009C6867
		public TArray<FName> Options
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Options) == null)
				{
					result = (this._Options = new TArray<FName>(base.NativePtr + (IntPtr)SConfirmBoxInfo.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Options.CopyAssign(value);
			}
		}

		// Token: 0x060299AC RID: 170412 RVA: 0x009C8675 File Offset: 0x009C6875
		public SConfirmBoxInfo()
		{
		}

		// Token: 0x060299AD RID: 170413 RVA: 0x009C867D File Offset: 0x009C687D
		public SConfirmBoxInfo(FName Name, FName Title, FName Content, TArray<FName> Options)
		{
			this.Name = Name;
			this.Title = Title;
			this.Content = Content;
			this.Options = Options;
		}

		// Token: 0x060299AE RID: 170414 RVA: 0x009C86A2 File Offset: 0x009C68A2
		protected override IntPtr GetUStructPtr()
		{
			return SConfirmBoxInfo.StaticStruct();
		}

		// Token: 0x060299AF RID: 170415 RVA: 0x009C86AE File Offset: 0x009C68AE
		[NullableContext(2)]
		public SConfirmBoxInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060299B0 RID: 170416 RVA: 0x009C86B8 File Offset: 0x009C68B8
		public SConfirmBoxInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060299B1 RID: 170417 RVA: 0x009C86C3 File Offset: 0x009C68C3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SConfirmBoxInfo(Pointer, false, true);
		}

		// Token: 0x060299B2 RID: 170418 RVA: 0x009C86CD File Offset: 0x009C68CD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SConfirmBoxInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0401558A RID: 87434
		public const string __ObjectPath = "/Game/Aki/Data/ConfirmBox/Struct/SConfirmBoxInfo.SConfirmBoxInfo";

		// Token: 0x0401558B RID: 87435
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401558C RID: 87436
		internal static int __PropertyOffset_0;

		// Token: 0x0401558D RID: 87437
		internal static int __PropertyOffset_1;

		// Token: 0x0401558E RID: 87438
		internal static int __PropertyOffset_2;

		// Token: 0x0401558F RID: 87439
		internal static int __PropertyOffset_3;

		// Token: 0x04015590 RID: 87440
		[Nullable(2)]
		private TArray<FName> _Options;
	}
}
