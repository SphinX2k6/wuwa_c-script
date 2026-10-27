using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x02007022 RID: 28706
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMotorMoveAudioEvent : IEquatable<EMotorMoveAudioEvent>
	{
		// Token: 0x06045DD3 RID: 286163 RVA: 0x0115F397 File Offset: 0x0115D597
		private EMotorMoveAudioEvent(string value)
		{
			this.Value = value;
		}

		// Token: 0x06045DD5 RID: 286165 RVA: 0x0115F416 File Offset: 0x0115D616
		public override string ToString()
		{
			return this.Value;
		}

		// Token: 0x06045DD6 RID: 286166 RVA: 0x0115F41E File Offset: 0x0115D61E
		public bool Equals(EMotorMoveAudioEvent other)
		{
			return this.Value == other.Value;
		}

		// Token: 0x06045DD7 RID: 286167 RVA: 0x0115F434 File Offset: 0x0115D634
		public override bool Equals(object obj)
		{
			if (obj is EMotorMoveAudioEvent)
			{
				EMotorMoveAudioEvent other = (EMotorMoveAudioEvent)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06045DD8 RID: 286168 RVA: 0x0115F459 File Offset: 0x0115D659
		public override int GetHashCode()
		{
			string value = this.Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06045DD9 RID: 286169 RVA: 0x0115F46C File Offset: 0x0115D66C
		public static bool operator ==(EMotorMoveAudioEvent left, EMotorMoveAudioEvent right)
		{
			return left.Equals(right);
		}

		// Token: 0x06045DDA RID: 286170 RVA: 0x0115F476 File Offset: 0x0115D676
		public static bool operator !=(EMotorMoveAudioEvent left, EMotorMoveAudioEvent right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04024847 RID: 149575
		public readonly string Value;

		// Token: 0x04024848 RID: 149576
		public static readonly EMotorMoveAudioEvent WheelRoll = new EMotorMoveAudioEvent("play_sfx_motor_wheel");

		// Token: 0x04024849 RID: 149577
		public static readonly EMotorMoveAudioEvent NitroAcceleration = new EMotorMoveAudioEvent("play_sfx_motor_nos");

		// Token: 0x0402484A RID: 149578
		public static readonly EMotorMoveAudioEvent MotorEngine = new EMotorMoveAudioEvent("play_sfx_motor_engine");

		// Token: 0x0402484B RID: 149579
		public static readonly EMotorMoveAudioEvent DriftingState = new EMotorMoveAudioEvent("play_sfx_motor_drift");

		// Token: 0x0402484C RID: 149580
		public static readonly EMotorMoveAudioEvent BrakingTurn = new EMotorMoveAudioEvent("play_sfx_motor_burnout");

		// Token: 0x0402484D RID: 149581
		public static readonly EMotorMoveAudioEvent Glide = new EMotorMoveAudioEvent("play_sfx_motor_gliding_loop");

		// Token: 0x0402484E RID: 149582
		public static readonly EMotorMoveAudioEvent GlideSprint = new EMotorMoveAudioEvent("play_sfx_motor_gliding_nos_loop");

		// Token: 0x0402484F RID: 149583
		public const string WheelRoll_Value = "play_sfx_motor_wheel";

		// Token: 0x04024850 RID: 149584
		public const string NitroAcceleration_Value = "play_sfx_motor_nos";

		// Token: 0x04024851 RID: 149585
		public const string MotorEngine_Value = "play_sfx_motor_engine";

		// Token: 0x04024852 RID: 149586
		public const string DriftingState_Value = "play_sfx_motor_drift";

		// Token: 0x04024853 RID: 149587
		public const string BrakingTurn_Value = "play_sfx_motor_burnout";

		// Token: 0x04024854 RID: 149588
		public const string Glide_Value = "play_sfx_motor_gliding_loop";

		// Token: 0x04024855 RID: 149589
		public const string GlideSprint_Value = "play_sfx_motor_gliding_nos_loop";
	}
}
