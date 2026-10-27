using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Interaction.Struct
{
	// Token: 0x02003F1E RID: 16158
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 44)]
	[UnrealObjectPath("/Game/Aki/Data/Interaction/Struct/SKuroInteractionConfigExport.SKuroInteractionConfigExport")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 48)]
	public struct SKuroInteractionConfigExport : IEqualityOperators<SKuroInteractionConfigExport, SKuroInteractionConfigExport, bool>, IEquatable<SKuroInteractionConfigExport>, IUnrealScriptStruct
	{
		// Token: 0x06029094 RID: 168084 RVA: 0x009BA318 File Offset: 0x009B8518
		public SKuroInteractionConfigExport(long InteractionID, int StepID, long ConditionGroupID, long EventGroupID, byte OptionLimitType, int OptionLimitTimes, float OptionLimitDuration)
		{
			this.InteractionID = InteractionID;
			this.StepID = StepID;
			this.ConditionGroupID = ConditionGroupID;
			this.EventGroupID = EventGroupID;
			this.OptionLimitType = OptionLimitType;
			this.OptionLimitTimes = OptionLimitTimes;
			this.OptionLimitDuration = OptionLimitDuration;
		}

		// Token: 0x06029095 RID: 168085 RVA: 0x009BA350 File Offset: 0x009B8550
		public static bool operator ==(SKuroInteractionConfigExport left, SKuroInteractionConfigExport right)
		{
			return left.InteractionID == right.InteractionID && left.StepID == right.StepID && left.ConditionGroupID == right.ConditionGroupID && left.EventGroupID == right.EventGroupID && left.OptionLimitType == right.OptionLimitType && left.OptionLimitTimes == right.OptionLimitTimes && left.OptionLimitDuration == right.OptionLimitDuration;
		}

		// Token: 0x06029096 RID: 168086 RVA: 0x009BA3C1 File Offset: 0x009B85C1
		public static bool operator !=(SKuroInteractionConfigExport left, SKuroInteractionConfigExport right)
		{
			return !(left == right);
		}

		// Token: 0x06029097 RID: 168087 RVA: 0x009BA3CD File Offset: 0x009B85CD
		public bool Equals(SKuroInteractionConfigExport other)
		{
			return this == other;
		}

		// Token: 0x06029098 RID: 168088 RVA: 0x009BA3DC File Offset: 0x009B85DC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SKuroInteractionConfigExport)
			{
				SKuroInteractionConfigExport other = (SKuroInteractionConfigExport)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06029099 RID: 168089 RVA: 0x009BA401 File Offset: 0x009B8601
		public override int GetHashCode()
		{
			return HashCode.Combine<long, int, long, long, byte, int, float>(this.InteractionID, this.StepID, this.ConditionGroupID, this.EventGroupID, this.OptionLimitType, this.OptionLimitTimes, this.OptionLimitDuration);
		}

		// Token: 0x0602909A RID: 168090 RVA: 0x009BA432 File Offset: 0x009B8632
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SKuroInteractionConfigExport._ScriptStructPtr != 0) ? SKuroInteractionConfigExport._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Interaction/Struct/SKuroInteractionConfigExport.SKuroInteractionConfigExport", ref SKuroInteractionConfigExport._ScriptStructPtr);
		}

		// Token: 0x04014FF9 RID: 86009
		[FieldOffset(0)]
		public long InteractionID;

		// Token: 0x04014FFA RID: 86010
		[FieldOffset(8)]
		public int StepID;

		// Token: 0x04014FFB RID: 86011
		[FieldOffset(16)]
		public long ConditionGroupID;

		// Token: 0x04014FFC RID: 86012
		[FieldOffset(24)]
		public long EventGroupID;

		// Token: 0x04014FFD RID: 86013
		[FieldOffset(32)]
		public byte OptionLimitType;

		// Token: 0x04014FFE RID: 86014
		[FieldOffset(36)]
		public int OptionLimitTimes;

		// Token: 0x04014FFF RID: 86015
		[FieldOffset(40)]
		public float OptionLimitDuration;

		// Token: 0x04015000 RID: 86016
		public const string __ObjectPath = "/Game/Aki/Data/Interaction/Struct/SKuroInteractionConfigExport.SKuroInteractionConfigExport";

		// Token: 0x04015001 RID: 86017
		private static IntPtr _ScriptStructPtr;
	}
}
