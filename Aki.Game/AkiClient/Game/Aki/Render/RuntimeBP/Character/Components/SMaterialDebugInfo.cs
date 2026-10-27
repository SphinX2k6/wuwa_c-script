using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Components
{
	// Token: 0x02003E2E RID: 15918
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Components/SMaterialDebugInfo.SMaterialDebugInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 24)]
	public struct SMaterialDebugInfo : IEqualityOperators<SMaterialDebugInfo, SMaterialDebugInfo, bool>, IEquatable<SMaterialDebugInfo>, IUnrealScriptStruct
	{
		// Token: 0x06027EC9 RID: 163529 RVA: 0x0099F690 File Offset: 0x0099D890
		public SMaterialDebugInfo(FName CurrentController, FName RenderingContent)
		{
			this.CurrentController = CurrentController;
			this.RenderingContent = RenderingContent;
		}

		// Token: 0x06027ECA RID: 163530 RVA: 0x0099F6A0 File Offset: 0x0099D8A0
		public static bool operator ==(SMaterialDebugInfo left, SMaterialDebugInfo right)
		{
			return left.CurrentController == right.CurrentController && left.RenderingContent == right.RenderingContent;
		}

		// Token: 0x06027ECB RID: 163531 RVA: 0x0099F6C8 File Offset: 0x0099D8C8
		public static bool operator !=(SMaterialDebugInfo left, SMaterialDebugInfo right)
		{
			return !(left == right);
		}

		// Token: 0x06027ECC RID: 163532 RVA: 0x0099F6D4 File Offset: 0x0099D8D4
		public bool Equals(SMaterialDebugInfo other)
		{
			return this == other;
		}

		// Token: 0x06027ECD RID: 163533 RVA: 0x0099F6E4 File Offset: 0x0099D8E4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SMaterialDebugInfo)
			{
				SMaterialDebugInfo other = (SMaterialDebugInfo)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06027ECE RID: 163534 RVA: 0x0099F709 File Offset: 0x0099D909
		public override int GetHashCode()
		{
			return HashCode.Combine<FName, FName>(this.CurrentController, this.RenderingContent);
		}

		// Token: 0x06027ECF RID: 163535 RVA: 0x0099F71C File Offset: 0x0099D91C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMaterialDebugInfo._ScriptStructPtr != 0) ? SMaterialDebugInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/Components/SMaterialDebugInfo.SMaterialDebugInfo", ref SMaterialDebugInfo._ScriptStructPtr);
		}

		// Token: 0x04014430 RID: 82992
		[FieldOffset(0)]
		public FName CurrentController;

		// Token: 0x04014431 RID: 82993
		[FieldOffset(12)]
		public FName RenderingContent;

		// Token: 0x04014432 RID: 82994
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Components/SMaterialDebugInfo.SMaterialDebugInfo";

		// Token: 0x04014433 RID: 82995
		private static IntPtr _ScriptStructPtr;
	}
}
