using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.GaCha.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.Weapon.Data
{
	// Token: 0x02003797 RID: 14231
	[NullableContext(1)]
	[Nullable(0)]
	public class TWeaponModelTransform
	{
		// Token: 0x06025011 RID: 151569 RVA: 0x00A73F12 File Offset: 0x00A72112
		private TWeaponModelTransform(object value)
		{
			this._value = value;
		}

		// Token: 0x06025012 RID: 151570 RVA: 0x00A73F21 File Offset: 0x00A72121
		public static implicit operator TWeaponModelTransform(WeaponModelTransform value)
		{
			return new TWeaponModelTransform(value);
		}

		// Token: 0x06025013 RID: 151571 RVA: 0x00A73F2E File Offset: 0x00A7212E
		public static implicit operator TWeaponModelTransform(SGachaWeaponTransform value)
		{
			return new TWeaponModelTransform(value);
		}

		// Token: 0x06025014 RID: 151572 RVA: 0x00A73F3C File Offset: 0x00A7213C
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

		// Token: 0x06025015 RID: 151573 RVA: 0x00A73F88 File Offset: 0x00A72188
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

		// Token: 0x06025016 RID: 151574 RVA: 0x00A73FD8 File Offset: 0x00A721D8
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

		// Token: 0x06025017 RID: 151575 RVA: 0x00A74080 File Offset: 0x00A72280
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

		// Token: 0x06025018 RID: 151576 RVA: 0x00A74128 File Offset: 0x00A72328
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

		// Token: 0x06025019 RID: 151577 RVA: 0x00A741D0 File Offset: 0x00A723D0
		public bool HasScabbardValue()
		{
			global::Vector vector = this.ScabbardRotationOffset();
			return vector.X != 0.0 || vector.Y != 0.0 || vector.Z != 0.0;
		}

		// Token: 0x0602501A RID: 151578 RVA: 0x00A7421C File Offset: 0x00A7241C
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

		// Token: 0x0602501B RID: 151579 RVA: 0x00A7426C File Offset: 0x00A7246C
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

		// Token: 0x0602501C RID: 151580 RVA: 0x00A74314 File Offset: 0x00A72514
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

		// Token: 0x0401479E RID: 83870
		private readonly object _value;
	}
}
