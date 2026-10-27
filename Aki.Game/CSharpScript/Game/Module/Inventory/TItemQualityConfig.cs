using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Inventory
{
	// Token: 0x02005837 RID: 22583
	[NullableContext(2)]
	[Nullable(0)]
	public class TItemQualityConfig
	{
		// Token: 0x06039638 RID: 235064 RVA: 0x00D9E18B File Offset: 0x00D9C38B
		[NullableContext(1)]
		private TItemQualityConfig(object value)
		{
			this._value = value;
		}

		// Token: 0x06039639 RID: 235065 RVA: 0x00D9E19A File Offset: 0x00D9C39A
		[NullableContext(1)]
		public static implicit operator TItemQualityConfig(AbyssQuality value)
		{
			return new TItemQualityConfig(value);
		}

		// Token: 0x0603963A RID: 235066 RVA: 0x00D9E1A7 File Offset: 0x00D9C3A7
		[NullableContext(1)]
		public static implicit operator TItemQualityConfig(QualityInfo value)
		{
			return new TItemQualityConfig(value);
		}

		// Token: 0x0603963B RID: 235067 RVA: 0x00D9E1B4 File Offset: 0x00D9C3B4
		[NullableContext(1)]
		public static implicit operator TItemQualityConfig(HonamiStoryItemQuality value)
		{
			return new TItemQualityConfig(value);
		}

		// Token: 0x0603963C RID: 235068 RVA: 0x00D9E1C1 File Offset: 0x00D9C3C1
		public bool Is<T>()
		{
			return this._value is T;
		}

		// Token: 0x0603963D RID: 235069 RVA: 0x00D9E1D4 File Offset: 0x00D9C3D4
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

		// Token: 0x0603963E RID: 235070 RVA: 0x00D9E209 File Offset: 0x00D9C409
		[NullableContext(1)]
		public T AsClass<T>() where T : class
		{
			return this._value as T;
		}

		// Token: 0x17008A31 RID: 35377
		// (get) Token: 0x0603963F RID: 235071 RVA: 0x00D9E21C File Offset: 0x00D9C41C
		public string TextColor
		{
			get
			{
				object value = this._value;
				if (value is AbyssQuality)
				{
					return ((AbyssQuality)value).TextColor;
				}
				value = this._value;
				if (value is QualityInfo)
				{
					return ((QualityInfo)value).TextColor;
				}
				value = this._value;
				if (value is HonamiStoryItemQuality)
				{
					return ((HonamiStoryItemQuality)value).TextColor;
				}
				return null;
			}
		}

		// Token: 0x17008A32 RID: 35378
		// (get) Token: 0x06039640 RID: 235072 RVA: 0x00D9E284 File Offset: 0x00D9C484
		public string AcquireQualityTexPath
		{
			get
			{
				object value = this._value;
				if (value is AbyssQuality)
				{
					return ((AbyssQuality)value).AcquireQualityTexPath;
				}
				value = this._value;
				if (value is QualityInfo)
				{
					return ((QualityInfo)value).AcquireQualityTexPath;
				}
				value = this._value;
				if (value is HonamiStoryItemQuality)
				{
					return ((HonamiStoryItemQuality)value).AcquireQualityTexPath;
				}
				return null;
			}
		}

		// Token: 0x17008A33 RID: 35379
		// (get) Token: 0x06039641 RID: 235073 RVA: 0x00D9E2EC File Offset: 0x00D9C4EC
		public string AcquireQualitySpritePath
		{
			get
			{
				object value = this._value;
				if (value is AbyssQuality)
				{
					return ((AbyssQuality)value).AcquireQualitySpritePath;
				}
				value = this._value;
				if (value is QualityInfo)
				{
					return ((QualityInfo)value).AcquireQualitySpritePath;
				}
				value = this._value;
				if (value is HonamiStoryItemQuality)
				{
					return ((HonamiStoryItemQuality)value).AcquireQualitySpritePath;
				}
				return null;
			}
		}

		// Token: 0x17008A34 RID: 35380
		// (get) Token: 0x06039642 RID: 235074 RVA: 0x00D9E354 File Offset: 0x00D9C554
		public int? Id
		{
			get
			{
				object value = this._value;
				if (value is AbyssQuality)
				{
					return new int?(((AbyssQuality)value).Id);
				}
				value = this._value;
				if (value is QualityInfo)
				{
					return new int?(((QualityInfo)value).Id);
				}
				value = this._value;
				if (value is HonamiStoryItemQuality)
				{
					return new int?(((HonamiStoryItemQuality)value).Id);
				}
				return null;
			}
		}

		// Token: 0x17008A35 RID: 35381
		// (get) Token: 0x06039643 RID: 235075 RVA: 0x00D9E3D4 File Offset: 0x00D9C5D4
		public string AcquireNewItemQualityTexPath
		{
			get
			{
				object value = this._value;
				if (value is AbyssQuality)
				{
					return ((AbyssQuality)value).AcquireNewItemQualityTexPath;
				}
				value = this._value;
				if (value is QualityInfo)
				{
					return ((QualityInfo)value).AcquireNewItemQualityTexPath;
				}
				value = this._value;
				if (value is HonamiStoryItemQuality)
				{
					return ((HonamiStoryItemQuality)value).AcquireNewItemQualityTexPath;
				}
				return null;
			}
		}

		// Token: 0x17008A36 RID: 35382
		// (get) Token: 0x06039644 RID: 235076 RVA: 0x00D9E43C File Offset: 0x00D9C63C
		public string TextureAcquireFlow
		{
			get
			{
				object value = this._value;
				if (value is AbyssQuality)
				{
					return ((AbyssQuality)value).TextureAcquireFlow;
				}
				value = this._value;
				if (value is QualityInfo)
				{
					return ((QualityInfo)value).TextureAcquireFlow;
				}
				value = this._value;
				if (value is HonamiStoryItemQuality)
				{
					return ((HonamiStoryItemQuality)value).TextureAcquireFlow;
				}
				return null;
			}
		}

		// Token: 0x17008A37 RID: 35383
		// (get) Token: 0x06039645 RID: 235077 RVA: 0x00D9E4A4 File Offset: 0x00D9C6A4
		public string TextureAcquireBg
		{
			get
			{
				object value = this._value;
				if (value is AbyssQuality)
				{
					return ((AbyssQuality)value).TextureAcquireBg;
				}
				value = this._value;
				if (value is QualityInfo)
				{
					return ((QualityInfo)value).TextureAcquireBg;
				}
				value = this._value;
				if (value is HonamiStoryItemQuality)
				{
					return ((HonamiStoryItemQuality)value).TextureAcquireBg;
				}
				return null;
			}
		}

		// Token: 0x0401E040 RID: 122944
		[Nullable(1)]
		private readonly object _value;
	}
}
