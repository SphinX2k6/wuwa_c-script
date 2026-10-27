using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.GaCha.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.Weapon.Data
{
	// Token: 0x02004866 RID: 18534
	[NullableContext(1)]
	[Nullable(0)]
	public class TWeaponModelTransform
	{
		// Token: 0x06030841 RID: 198721 RVA: 0x00B43CFE File Offset: 0x00B41EFE
		private TWeaponModelTransform(object value)
		{
			this._value = value;
		}

		// Token: 0x06030842 RID: 198722 RVA: 0x00B43D0D File Offset: 0x00B41F0D
		public static implicit operator TWeaponModelTransform(WeaponModelTransform value)
		{
			return new TWeaponModelTransform(value);
		}

		// Token: 0x06030843 RID: 198723 RVA: 0x00B43D1A File Offset: 0x00B41F1A
		public static implicit operator TWeaponModelTransform(SGachaWeaponTransform value)
		{
			return new TWeaponModelTransform(value);
		}

		// Token: 0x06030844 RID: 198724 RVA: 0x00B43D28 File Offset: 0x00B41F28
		public bool ShowScabbard()
		{
			object value = this._value;
			if (value is WeaponModelTransform)
			{
				return ((WeaponModelTransform)value).ShowScabbard;
			}
			value = this._value;
			if (value is SGachaWeaponTransform)
			{
				SGachaWeaponTransform sgachaWeaponTransform = (SGachaWeaponTransform)value;
				return sgachaWeaponTransform.ShowScabbard;
			}
			return false;
		}

		// Token: 0x06030845 RID: 198725 RVA: 0x00B43D74 File Offset: 0x00B41F74
		public float Size()
		{
			object value = this._value;
			if (value is WeaponModelTransform)
			{
				return ((WeaponModelTransform)value).Size;
			}
			value = this._value;
			if (value is SGachaWeaponTransform)
			{
				SGachaWeaponTransform sgachaWeaponTransform = (SGachaWeaponTransform)value;
				return sgachaWeaponTransform.Size;
			}
			return 0f;
		}

		// Token: 0x06030846 RID: 198726 RVA: 0x00B43DC4 File Offset: 0x00B41FC4
		public global::Vector Location()
		{
			global::Vector vector = new global::Vector();
			object value = this._value;
			if (value is WeaponModelTransform)
			{
				Aki.Config.Vector? location = ((WeaponModelTransform)value).Location;
				vector.Set((double)location.Value.X, (double)location.Value.Y, (double)location.Value.Z);
			}
			value = this._value;
			if (value is SGachaWeaponTransform)
			{
				SGachaWeaponTransform sgachaWeaponTransform = (SGachaWeaponTransform)value;
				FVector location2 = sgachaWeaponTransform.Location;
				vector.Set((double)location2.X, (double)location2.Y, (double)location2.Z);
			}
			return vector;
		}

		// Token: 0x06030847 RID: 198727 RVA: 0x00B43E6C File Offset: 0x00B4206C
		public global::Vector ScabbardOffset()
		{
			global::Vector vector = new global::Vector();
			object value = this._value;
			if (value is WeaponModelTransform)
			{
				Aki.Config.Vector? scabbardOffset = ((WeaponModelTransform)value).ScabbardOffset;
				vector.Set((double)scabbardOffset.Value.X, (double)scabbardOffset.Value.Y, (double)scabbardOffset.Value.Z);
			}
			value = this._value;
			if (value is SGachaWeaponTransform)
			{
				SGachaWeaponTransform sgachaWeaponTransform = (SGachaWeaponTransform)value;
				FVector scabbardOffset2 = sgachaWeaponTransform.ScabbardOffset;
				vector.Set((double)scabbardOffset2.X, (double)scabbardOffset2.Y, (double)scabbardOffset2.Z);
			}
			return vector;
		}

		// Token: 0x06030848 RID: 198728 RVA: 0x00B43F14 File Offset: 0x00B42114
		public global::Vector ScabbardRotationOffset()
		{
			global::Vector vector = new global::Vector();
			object value = this._value;
			if (value is WeaponModelTransform)
			{
				Aki.Config.Vector? scabbardRotationOffset = ((WeaponModelTransform)value).ScabbardRotationOffset;
				vector.Set((double)scabbardRotationOffset.Value.X, (double)scabbardRotationOffset.Value.Y, (double)scabbardRotationOffset.Value.Z);
			}
			value = this._value;
			if (value is SGachaWeaponTransform)
			{
				SGachaWeaponTransform sgachaWeaponTransform = (SGachaWeaponTransform)value;
				FVector scabbardRotationOffset2 = sgachaWeaponTransform.ScabbardRotationOffset;
				vector.Set((double)scabbardRotationOffset2.X, (double)scabbardRotationOffset2.Y, (double)scabbardRotationOffset2.Z);
			}
			return vector;
		}

		// Token: 0x06030849 RID: 198729 RVA: 0x00B43FBC File Offset: 0x00B421BC
		public bool HasScabbardValue()
		{
			global::Vector vector = this.ScabbardRotationOffset();
			return vector.X != 0.0 || vector.Y != 0.0 || vector.Z != 0.0;
		}

		// Token: 0x0603084A RID: 198730 RVA: 0x00B44008 File Offset: 0x00B42208
		public float RotateTime()
		{
			object value = this._value;
			if (value is WeaponModelTransform)
			{
				return (float)((WeaponModelTransform)value).RotateTime;
			}
			value = this._value;
			if (value is SGachaWeaponTransform)
			{
				SGachaWeaponTransform sgachaWeaponTransform = (SGachaWeaponTransform)value;
				return sgachaWeaponTransform.RotateTime;
			}
			return 0f;
		}

		// Token: 0x0603084B RID: 198731 RVA: 0x00B44058 File Offset: 0x00B42258
		public global::Vector Rotation()
		{
			global::Vector vector = new global::Vector();
			object value = this._value;
			if (value is WeaponModelTransform)
			{
				Aki.Config.Vector? rotation = ((WeaponModelTransform)value).Rotation;
				vector.Set((double)rotation.Value.X, (double)rotation.Value.Y, (double)rotation.Value.Z);
			}
			value = this._value;
			if (value is SGachaWeaponTransform)
			{
				SGachaWeaponTransform sgachaWeaponTransform = (SGachaWeaponTransform)value;
				FVector rotation2 = sgachaWeaponTransform.Rotation;
				vector.Set((double)rotation2.X, (double)rotation2.Y, (double)rotation2.Z);
			}
			return vector;
		}

		// Token: 0x0603084C RID: 198732 RVA: 0x00B44100 File Offset: 0x00B42300
		public global::Vector AxisRotate()
		{
			global::Vector vector = new global::Vector();
			object value = this._value;
			if (value is WeaponModelTransform)
			{
				Aki.Config.Vector? axisRotate = ((WeaponModelTransform)value).AxisRotate;
				vector.Set((double)axisRotate.Value.X, (double)axisRotate.Value.Y, (double)axisRotate.Value.Z);
			}
			value = this._value;
			if (value is SGachaWeaponTransform)
			{
				SGachaWeaponTransform sgachaWeaponTransform = (SGachaWeaponTransform)value;
				FVector axisRotate2 = sgachaWeaponTransform.AxisRotate;
				vector.Set((double)axisRotate2.X, (double)axisRotate2.Y, (double)axisRotate2.Z);
			}
			return vector;
		}

		// Token: 0x0401A0EB RID: 106731
		private readonly object _value;
	}
}
