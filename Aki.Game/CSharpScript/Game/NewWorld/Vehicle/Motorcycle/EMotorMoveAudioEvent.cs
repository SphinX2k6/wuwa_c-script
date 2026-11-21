using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x020061A3 RID: 24995
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMotorMoveAudioEvent : IEquatable<EMotorMoveAudioEvent>
	{
		// Token: 0x0603BF93 RID: 245651 RVA: 0x01109745 File Offset: 0x01107945
		private EMotorMoveAudioEvent(string value)
		{
			this.Value = value;
		}

		// Token: 0x0603BF95 RID: 245653 RVA: 0x011097C6 File Offset: 0x011079C6
		public override string ToString()
		{
			return this.Value;
		}

		// Token: 0x0603BF96 RID: 245654 RVA: 0x011097CE File Offset: 0x011079CE
		public bool Equals(EMotorMoveAudioEvent other)
		{
			return this.Value == other.Value;
		}

		// Token: 0x0603BF97 RID: 245655 RVA: 0x011097E4 File Offset: 0x011079E4
		public override bool Equals(object obj)
		{
			if (obj is EMotorMoveAudioEvent)
			{
				EMotorMoveAudioEvent other = (EMotorMoveAudioEvent)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0603BF98 RID: 245656 RVA: 0x01109809 File Offset: 0x01107A09
		public override int GetHashCode()
		{
			string value = this.Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0603BF99 RID: 245657 RVA: 0x0110981C File Offset: 0x01107A1C
		public static bool operator ==(EMotorMoveAudioEvent left, EMotorMoveAudioEvent right)
		{
			return left.Equals(right);
		}

		// Token: 0x0603BF9A RID: 245658 RVA: 0x01109826 File Offset: 0x01107A26
		public static bool operator !=(EMotorMoveAudioEvent left, EMotorMoveAudioEvent right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401FAFD RID: 129789
		public readonly string Value;

		// Token: 0x0401FAFE RID: 129790
		public static readonly EMotorMoveAudioEvent WheelRoll = new EMotorMoveAudioEvent("play_sfx_motor_wheel");

		// Token: 0x0401FAFF RID: 129791
		public static readonly EMotorMoveAudioEvent NitroAcceleration = new EMotorMoveAudioEvent("play_sfx_motor_nos");

		// Token: 0x0401FB00 RID: 129792
		public static readonly EMotorMoveAudioEvent MotorEngine = new EMotorMoveAudioEvent("play_sfx_motor_engine");

		// Token: 0x0401FB01 RID: 129793
		public static readonly EMotorMoveAudioEvent DriftingState = new EMotorMoveAudioEvent("play_sfx_motor_drift");

		// Token: 0x0401FB02 RID: 129794
		public static readonly EMotorMoveAudioEvent BrakingTurn = new EMotorMoveAudioEvent("play_sfx_motor_burnout");

		// Token: 0x0401FB03 RID: 129795
		public static readonly EMotorMoveAudioEvent Glide = new EMotorMoveAudioEvent("play_sfx_motor_gliding_loop");

		// Token: 0x0401FB04 RID: 129796
		public static readonly EMotorMoveAudioEvent GlideSprint = new EMotorMoveAudioEvent("play_sfx_motor_gliding_nos_loop");

		// Token: 0x0401FB05 RID: 129797
		public const string WheelRoll_Value = "play_sfx_motor_wheel";

		// Token: 0x0401FB06 RID: 129798
		public const string NitroAcceleration_Value = "play_sfx_motor_nos";

		// Token: 0x0401FB07 RID: 129799
		public const string MotorEngine_Value = "play_sfx_motor_engine";

		// Token: 0x0401FB08 RID: 129800
		public const string DriftingState_Value = "play_sfx_motor_drift";

		// Token: 0x0401FB09 RID: 129801
		public const string BrakingTurn_Value = "play_sfx_motor_burnout";

		// Token: 0x0401FB0A RID: 129802
		public const string Glide_Value = "play_sfx_motor_gliding_loop";

		// Token: 0x0401FB0B RID: 129803
		public const string GlideSprint_Value = "play_sfx_motor_gliding_nos_loop";
	}
}
