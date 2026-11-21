using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.GaCha.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.Gacha.Data
{
	// Token: 0x020049F3 RID: 18931
	[NullableContext(1)]
	[Nullable(0)]
	public class TGachaWeaponTransform
	{
		// Token: 0x0602F705 RID: 194309 RVA: 0x00D3B38B File Offset: 0x00D3958B
		[NullableContext(2)]
		private TGachaWeaponTransform(object value)
		{
			this._value = value;
		}

		// Token: 0x0602F706 RID: 194310 RVA: 0x00D3B39A File Offset: 0x00D3959A
		public static implicit operator TGachaWeaponTransform(GachaWeaponTransform? value)
		{
			return new TGachaWeaponTransform(value);
		}

		// Token: 0x0602F707 RID: 194311 RVA: 0x00D3B3A7 File Offset: 0x00D395A7
		public static implicit operator TGachaWeaponTransform(SGachaWeaponTransform? value)
		{
			return new TGachaWeaponTransform(value);
		}

		// Token: 0x0602F708 RID: 194312 RVA: 0x00D3B3B4 File Offset: 0x00D395B4
		[NullableContext(2)]
		public bool Is<T>()
		{
			return this._value is T;
		}

		// Token: 0x0602F709 RID: 194313 RVA: 0x00D3B3C4 File Offset: 0x00D395C4
		[NullableContext(0)]
		public T? As<T>() where T : struct
		{
			object value = this._value;
			if (value is T)
			{
				T value2 = (T)((object)value);
				return new T?(value2);
			}
			return null;
		}

		// Token: 0x0602F70A RID: 194314 RVA: 0x00D3B3F9 File Offset: 0x00D395F9
		[return: Nullable(2)]
		public T AsClass<T>() where T : class
		{
			return this._value as T;
		}

		// Token: 0x17005F94 RID: 24468
		// (get) Token: 0x0602F70B RID: 194315 RVA: 0x00D3B40C File Offset: 0x00D3960C
		public bool ShowScabbard
		{
			get
			{
				object value = this._value;
				if (value is GachaWeaponTransform)
				{
					return ((GachaWeaponTransform)value).ShowScabbard;
				}
				value = this._value;
				if (value is SGachaWeaponTransform)
				{
					SGachaWeaponTransform sgachaWeaponTransform = (SGachaWeaponTransform)value;
					return sgachaWeaponTransform.ShowScabbard;
				}
				return false;
			}
		}

		// Token: 0x17005F95 RID: 24469
		// (get) Token: 0x0602F70C RID: 194316 RVA: 0x00D3B458 File Offset: 0x00D39658
		public float Size
		{
			get
			{
				object value = this._value;
				if (value is GachaWeaponTransform)
				{
					return ((GachaWeaponTransform)value).Size;
				}
				value = this._value;
				if (value is SGachaWeaponTransform)
				{
					SGachaWeaponTransform sgachaWeaponTransform = (SGachaWeaponTransform)value;
					return sgachaWeaponTransform.Size;
				}
				return 0f;
			}
		}

		// Token: 0x17005F96 RID: 24470
		// (get) Token: 0x0602F70D RID: 194317 RVA: 0x00D3B4A8 File Offset: 0x00D396A8
		public float RotateTime
		{
			get
			{
				object value = this._value;
				if (value is GachaWeaponTransform)
				{
					return (float)((GachaWeaponTransform)value).RotateTime;
				}
				value = this._value;
				if (value is SGachaWeaponTransform)
				{
					SGachaWeaponTransform sgachaWeaponTransform = (SGachaWeaponTransform)value;
					return sgachaWeaponTransform.RotateTime;
				}
				return 0f;
			}
		}

		// Token: 0x17005F97 RID: 24471
		// (get) Token: 0x0602F70E RID: 194318 RVA: 0x00D3B4F8 File Offset: 0x00D396F8
		public global::Vector Rotation
		{
			get
			{
				global::Vector vector = global::Vector.Create();
				object value = this._value;
				if (value is GachaWeaponTransform)
				{
					Aki.Config.Vector? rotation = ((GachaWeaponTransform)value).Rotation;
					if (rotation != null)
					{
						vector.Set((double)rotation.Value.X, (double)rotation.Value.Y, (double)rotation.Value.Z);
					}
				}
				else
				{
					value = this._value;
					if (value is SGachaWeaponTransform)
					{
						SGachaWeaponTransform sgachaWeaponTransform = (SGachaWeaponTransform)value;
						FVector rotation2 = sgachaWeaponTransform.Rotation;
						vector.Set((double)rotation2.X, (double)rotation2.Y, (double)rotation2.Z);
					}
				}
				return vector;
			}
		}

		// Token: 0x17005F98 RID: 24472
		// (get) Token: 0x0602F70F RID: 194319 RVA: 0x00D3B5AC File Offset: 0x00D397AC
		public global::Vector Location
		{
			get
			{
				global::Vector vector = global::Vector.Create();
				object value = this._value;
				if (value is GachaWeaponTransform)
				{
					Aki.Config.Vector? location = ((GachaWeaponTransform)value).Location;
					if (location != null)
					{
						vector.Set((double)location.Value.X, (double)location.Value.Y, (double)location.Value.Z);
					}
				}
				else
				{
					value = this._value;
					if (value is SGachaWeaponTransform)
					{
						SGachaWeaponTransform sgachaWeaponTransform = (SGachaWeaponTransform)value;
						FVector location2 = sgachaWeaponTransform.Location;
						vector.Set((double)location2.X, (double)location2.Y, (double)location2.Z);
					}
				}
				return vector;
			}
		}

		// Token: 0x17005F99 RID: 24473
		// (get) Token: 0x0602F710 RID: 194320 RVA: 0x00D3B660 File Offset: 0x00D39860
		public global::Vector AxisRotate
		{
			get
			{
				global::Vector vector = global::Vector.Create();
				object value = this._value;
				if (value is GachaWeaponTransform)
				{
					Aki.Config.Vector? axisRotate = ((GachaWeaponTransform)value).AxisRotate;
					if (axisRotate != null)
					{
						vector.Set((double)axisRotate.Value.X, (double)axisRotate.Value.Y, (double)axisRotate.Value.Z);
					}
				}
				else
				{
					value = this._value;
					if (value is SGachaWeaponTransform)
					{
						SGachaWeaponTransform sgachaWeaponTransform = (SGachaWeaponTransform)value;
						FVector axisRotate2 = sgachaWeaponTransform.AxisRotate;
						vector.Set((double)axisRotate2.X, (double)axisRotate2.Y, (double)axisRotate2.Z);
					}
				}
				return vector;
			}
		}

		// Token: 0x17005F9A RID: 24474
		// (get) Token: 0x0602F711 RID: 194321 RVA: 0x00D3B714 File Offset: 0x00D39914
		public global::Vector ScabbardOffset
		{
			get
			{
				global::Vector vector = global::Vector.Create();
				object value = this._value;
				if (value is GachaWeaponTransform)
				{
					Aki.Config.Vector? scabbardOffset = ((GachaWeaponTransform)value).ScabbardOffset;
					if (scabbardOffset != null)
					{
						vector.Set((double)scabbardOffset.Value.X, (double)scabbardOffset.Value.Y, (double)scabbardOffset.Value.Z);
					}
				}
				else
				{
					value = this._value;
					if (value is SGachaWeaponTransform)
					{
						SGachaWeaponTransform sgachaWeaponTransform = (SGachaWeaponTransform)value;
						FVector scabbardOffset2 = sgachaWeaponTransform.ScabbardOffset;
						vector.Set((double)scabbardOffset2.X, (double)scabbardOffset2.Y, (double)scabbardOffset2.Z);
					}
				}
				return vector;
			}
		}

		// Token: 0x0401923C RID: 102972
		[Nullable(2)]
		private readonly object _value;
	}
}
