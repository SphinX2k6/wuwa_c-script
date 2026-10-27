using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.YangYangBirds.NM
{
	// Token: 0x02003A79 RID: 14969
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 80)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/YangYangBirds/NM/SYYBirdNiagaraEvent.SYYBirdNiagaraEvent")]
	[StructLayout(LayoutKind.Explicit, Pack = 16, Size = 80)]
	public struct SYYBirdNiagaraEvent : IEqualityOperators<SYYBirdNiagaraEvent, SYYBirdNiagaraEvent, bool>, IEquatable<SYYBirdNiagaraEvent>, IUnrealScriptStruct
	{
		// Token: 0x0601FB69 RID: 129897 RVA: 0x008C0844 File Offset: 0x008BEA44
		public SYYBirdNiagaraEvent(FVector Position, FVector Velocity, FVector TargetPosition, FVector TargetTangent, int CurrAnimId, int TargetAnimId, float AnimFrame, bool InTransition, FVector4 CustomData)
		{
			this.Position = Position;
			this.Velocity = Velocity;
			this.TargetPosition = TargetPosition;
			this.TargetTangent = TargetTangent;
			this.CurrAnimId = CurrAnimId;
			this.TargetAnimId = TargetAnimId;
			this.AnimFrame = AnimFrame;
			this.InTransition = InTransition;
			this.CustomData = CustomData;
		}

		// Token: 0x0601FB6A RID: 129898 RVA: 0x008C0898 File Offset: 0x008BEA98
		public static bool operator ==(SYYBirdNiagaraEvent left, SYYBirdNiagaraEvent right)
		{
			return left.Position == right.Position && left.Velocity == right.Velocity && left.TargetPosition == right.TargetPosition && left.TargetTangent == right.TargetTangent && left.CurrAnimId == right.CurrAnimId && left.TargetAnimId == right.TargetAnimId && left.AnimFrame == right.AnimFrame && left.InTransition == right.InTransition && left.CustomData == right.CustomData;
		}

		// Token: 0x0601FB6B RID: 129899 RVA: 0x008C093F File Offset: 0x008BEB3F
		public static bool operator !=(SYYBirdNiagaraEvent left, SYYBirdNiagaraEvent right)
		{
			return !(left == right);
		}

		// Token: 0x0601FB6C RID: 129900 RVA: 0x008C094B File Offset: 0x008BEB4B
		public bool Equals(SYYBirdNiagaraEvent other)
		{
			return this == other;
		}

		// Token: 0x0601FB6D RID: 129901 RVA: 0x008C095C File Offset: 0x008BEB5C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SYYBirdNiagaraEvent)
			{
				SYYBirdNiagaraEvent other = (SYYBirdNiagaraEvent)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601FB6E RID: 129902 RVA: 0x008C0984 File Offset: 0x008BEB84
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<FVector>(this.Position);
			hashCode.Add<FVector>(this.Velocity);
			hashCode.Add<FVector>(this.TargetPosition);
			hashCode.Add<FVector>(this.TargetTangent);
			hashCode.Add<int>(this.CurrAnimId);
			hashCode.Add<int>(this.TargetAnimId);
			hashCode.Add<float>(this.AnimFrame);
			hashCode.Add<bool>(this.InTransition);
			hashCode.Add<FVector4>(this.CustomData);
			return hashCode.ToHashCode();
		}

		// Token: 0x0601FB6F RID: 129903 RVA: 0x008C0A15 File Offset: 0x008BEC15
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SYYBirdNiagaraEvent._ScriptStructPtr != 0) ? SYYBirdNiagaraEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/YangYangBirds/NM/SYYBirdNiagaraEvent.SYYBirdNiagaraEvent", ref SYYBirdNiagaraEvent._ScriptStructPtr);
		}

		// Token: 0x0400F45D RID: 62557
		[FieldOffset(0)]
		public FVector Position;

		// Token: 0x0400F45E RID: 62558
		[FieldOffset(12)]
		public FVector Velocity;

		// Token: 0x0400F45F RID: 62559
		[FieldOffset(24)]
		public FVector TargetPosition;

		// Token: 0x0400F460 RID: 62560
		[FieldOffset(36)]
		public FVector TargetTangent;

		// Token: 0x0400F461 RID: 62561
		[FieldOffset(48)]
		public int CurrAnimId;

		// Token: 0x0400F462 RID: 62562
		[FieldOffset(52)]
		public int TargetAnimId;

		// Token: 0x0400F463 RID: 62563
		[FieldOffset(56)]
		public float AnimFrame;

		// Token: 0x0400F464 RID: 62564
		[FieldOffset(60)]
		public bool InTransition;

		// Token: 0x0400F465 RID: 62565
		[FieldOffset(64)]
		public FVector4 CustomData;

		// Token: 0x0400F466 RID: 62566
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/YangYangBirds/NM/SYYBirdNiagaraEvent.SYYBirdNiagaraEvent";

		// Token: 0x0400F467 RID: 62567
		private static IntPtr _ScriptStructPtr;
	}
}
