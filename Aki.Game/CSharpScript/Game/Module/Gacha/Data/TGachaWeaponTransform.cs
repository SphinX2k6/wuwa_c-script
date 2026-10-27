using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.GaCha.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.Gacha.Data
{
	// Token: 0x02005A17 RID: 23063
	[NullableContext(1)]
	[Nullable(0)]
	public class TGachaWeaponTransform
	{
		// Token: 0x0603A7BC RID: 239548 RVA: 0x00DEADF3 File Offset: 0x00DE8FF3
		[NullableContext(2)]
		private TGachaWeaponTransform(object value)
		{
			this._value = value;
		}

		// Token: 0x0603A7BD RID: 239549 RVA: 0x00DEAE02 File Offset: 0x00DE9002
		public static implicit operator TGachaWeaponTransform(GachaWeaponTransform? value)
		{
			return new TGachaWeaponTransform(value);
		}

		// Token: 0x0603A7BE RID: 239550 RVA: 0x00DEAE0F File Offset: 0x00DE900F
		public static implicit operator TGachaWeaponTransform(SGachaWeaponTransform? value)
		{
			return new TGachaWeaponTransform(value);
		}

		// Token: 0x0603A7BF RID: 239551 RVA: 0x00DEAE1C File Offset: 0x00DE901C
		[NullableContext(2)]
		public bool Is<T>()
		{
			return this._value is T;
		}

		// Token: 0x0603A7C0 RID: 239552 RVA: 0x00DEAE2C File Offset: 0x00DE902C
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

		// Token: 0x0603A7C1 RID: 239553 RVA: 0x00DEAE61 File Offset: 0x00DE9061
		[return: Nullable(2)]
		public T AsClass<T>() where T : class
		{
			return this._value as T;
		}

		// Token: 0x17008BC6 RID: 35782
		// (get) Token: 0x0603A7C2 RID: 239554 RVA: 0x00DEAE74 File Offset: 0x00DE9074
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

		// Token: 0x17008BC7 RID: 35783
		// (get) Token: 0x0603A7C3 RID: 239555 RVA: 0x00DEAEC0 File Offset: 0x00DE90C0
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

		// Token: 0x17008BC8 RID: 35784
		// (get) Token: 0x0603A7C4 RID: 239556 RVA: 0x00DEAF10 File Offset: 0x00DE9110
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

		// Token: 0x17008BC9 RID: 35785
		// (get) Token: 0x0603A7C5 RID: 239557 RVA: 0x00DEAF60 File Offset: 0x00DE9160
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

		// Token: 0x17008BCA RID: 35786
		// (get) Token: 0x0603A7C6 RID: 239558 RVA: 0x00DEB014 File Offset: 0x00DE9214
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

		// Token: 0x17008BCB RID: 35787
		// (get) Token: 0x0603A7C7 RID: 239559 RVA: 0x00DEB0C8 File Offset: 0x00DE92C8
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

		// Token: 0x17008BCC RID: 35788
		// (get) Token: 0x0603A7C8 RID: 239560 RVA: 0x00DEB17C File Offset: 0x00DE937C
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

		// Token: 0x0401E795 RID: 124821
		[Nullable(2)]
		private readonly object _value;
	}
}
