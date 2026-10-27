using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004310 RID: 17168
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SEffectData.SEffectData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SEffectData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C68E RID: 181902 RVA: 0x00A1F256 File Offset: 0x00A1D456
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEffectData._ScriptStructPtr != 0) ? SEffectData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SEffectData.SEffectData", ref SEffectData._ScriptStructPtr);
		}

		// Token: 0x17006F21 RID: 28449
		// (get) Token: 0x0602C68F RID: 181903 RVA: 0x00A1F27C File Offset: 0x00A1D47C
		// (set) Token: 0x0602C690 RID: 181904 RVA: 0x00A1F2BF File Offset: 0x00A1D4BF
		public TArray<SEffectType> 效果
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SEffectType> result;
				if ((result = this._效果) == null)
				{
					result = (this._效果 = new TArray<SEffectType>(base.NativePtr + (IntPtr)SEffectData.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.效果.CopyAssign(value);
			}
		}

		// Token: 0x0602C691 RID: 181905 RVA: 0x00A1F2CD File Offset: 0x00A1D4CD
		public SEffectData()
		{
		}

		// Token: 0x0602C692 RID: 181906 RVA: 0x00A1F2D5 File Offset: 0x00A1D4D5
		public SEffectData(TArray<SEffectType> 效果)
		{
			this.效果 = 效果;
		}

		// Token: 0x0602C693 RID: 181907 RVA: 0x00A1F2E4 File Offset: 0x00A1D4E4
		protected override IntPtr GetUStructPtr()
		{
			return SEffectData.StaticStruct();
		}

		// Token: 0x0602C694 RID: 181908 RVA: 0x00A1F2F0 File Offset: 0x00A1D4F0
		[NullableContext(2)]
		public SEffectData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C695 RID: 181909 RVA: 0x00A1F2FA File Offset: 0x00A1D4FA
		public SEffectData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C696 RID: 181910 RVA: 0x00A1F305 File Offset: 0x00A1D505
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SEffectData(Pointer, false, true);
		}

		// Token: 0x0602C697 RID: 181911 RVA: 0x00A1F30F File Offset: 0x00A1D50F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SEffectData(Pointer, MemoryOwner);
		}

		// Token: 0x040176A2 RID: 95906
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SEffectData.SEffectData";

		// Token: 0x040176A3 RID: 95907
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040176A4 RID: 95908
		internal static int __PropertyOffset_0;

		// Token: 0x040176A5 RID: 95909
		[Nullable(2)]
		private TArray<SEffectType> _效果;
	}
}
