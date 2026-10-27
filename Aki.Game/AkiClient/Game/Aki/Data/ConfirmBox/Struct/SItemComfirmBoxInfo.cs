using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.ConfirmBox.Struct
{
	// Token: 0x02003F9E RID: 16286
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(60, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 60)]
	[UnrealObjectPath("/Game/Aki/Data/ConfirmBox/Struct/SItemComfirmBoxInfo.SItemComfirmBoxInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 60)]
	public struct SItemComfirmBoxInfo : IEqualityOperators<SItemComfirmBoxInfo, SItemComfirmBoxInfo, bool>, IEquatable<SItemComfirmBoxInfo>, IUnrealScriptStruct
	{
		// Token: 0x060299B3 RID: 170419 RVA: 0x009C86D6 File Offset: 0x009C68D6
		public SItemComfirmBoxInfo(FName Name, FName Title, FName Tips, FName ConfirmText, FName CancelText)
		{
			this.Name = Name;
			this.Title = Title;
			this.Tips = Tips;
			this.ConfirmText = ConfirmText;
			this.CancelText = CancelText;
		}

		// Token: 0x060299B4 RID: 170420 RVA: 0x009C8700 File Offset: 0x009C6900
		public static bool operator ==(SItemComfirmBoxInfo left, SItemComfirmBoxInfo right)
		{
			return left.Name == right.Name && left.Title == right.Title && left.Tips == right.Tips && left.ConfirmText == right.ConfirmText && left.CancelText == right.CancelText;
		}

		// Token: 0x060299B5 RID: 170421 RVA: 0x009C876C File Offset: 0x009C696C
		public static bool operator !=(SItemComfirmBoxInfo left, SItemComfirmBoxInfo right)
		{
			return !(left == right);
		}

		// Token: 0x060299B6 RID: 170422 RVA: 0x009C8778 File Offset: 0x009C6978
		public bool Equals(SItemComfirmBoxInfo other)
		{
			return this == other;
		}

		// Token: 0x060299B7 RID: 170423 RVA: 0x009C8788 File Offset: 0x009C6988
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SItemComfirmBoxInfo)
			{
				SItemComfirmBoxInfo other = (SItemComfirmBoxInfo)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060299B8 RID: 170424 RVA: 0x009C87AD File Offset: 0x009C69AD
		public override int GetHashCode()
		{
			return HashCode.Combine<FName, FName, FName, FName, FName>(this.Name, this.Title, this.Tips, this.ConfirmText, this.CancelText);
		}

		// Token: 0x060299B9 RID: 170425 RVA: 0x009C87D2 File Offset: 0x009C69D2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SItemComfirmBoxInfo._ScriptStructPtr != 0) ? SItemComfirmBoxInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/ConfirmBox/Struct/SItemComfirmBoxInfo.SItemComfirmBoxInfo", ref SItemComfirmBoxInfo._ScriptStructPtr);
		}

		// Token: 0x04015591 RID: 87441
		[FieldOffset(0)]
		public FName Name;

		// Token: 0x04015592 RID: 87442
		[FieldOffset(12)]
		public FName Title;

		// Token: 0x04015593 RID: 87443
		[FieldOffset(24)]
		public FName Tips;

		// Token: 0x04015594 RID: 87444
		[FieldOffset(36)]
		public FName ConfirmText;

		// Token: 0x04015595 RID: 87445
		[FieldOffset(48)]
		public FName CancelText;

		// Token: 0x04015596 RID: 87446
		public const string __ObjectPath = "/Game/Aki/Data/ConfirmBox/Struct/SItemComfirmBoxInfo.SItemComfirmBoxInfo";

		// Token: 0x04015597 RID: 87447
		private static IntPtr _ScriptStructPtr;
	}
}
