using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Inventory
{
	// Token: 0x0200480E RID: 18446
	[NullableContext(2)]
	[Nullable(0)]
	public class TItemQualityConfig
	{
		// Token: 0x0602E54B RID: 189771 RVA: 0x00CED027 File Offset: 0x00CEB227
		[NullableContext(1)]
		private TItemQualityConfig(object value)
		{
			this._value = value;
		}

		// Token: 0x0602E54C RID: 189772 RVA: 0x00CED036 File Offset: 0x00CEB236
		[NullableContext(1)]
		public static implicit operator TItemQualityConfig(AbyssQuality value)
		{
			return new TItemQualityConfig(value);
		}

		// Token: 0x0602E54D RID: 189773 RVA: 0x00CED043 File Offset: 0x00CEB243
		[NullableContext(1)]
		public static implicit operator TItemQualityConfig(QualityInfo value)
		{
			return new TItemQualityConfig(value);
		}

		// Token: 0x0602E54E RID: 189774 RVA: 0x00CED050 File Offset: 0x00CEB250
		[NullableContext(1)]
		public static implicit operator TItemQualityConfig(HonamiStoryItemQuality value)
		{
			return new TItemQualityConfig(value);
		}

		// Token: 0x0602E54F RID: 189775 RVA: 0x00CED05D File Offset: 0x00CEB25D
		public bool Is<T>()
		{
			return this._value is T;
		}

		// Token: 0x0602E550 RID: 189776 RVA: 0x00CED070 File Offset: 0x00CEB270
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

		// Token: 0x0602E551 RID: 189777 RVA: 0x00CED0A5 File Offset: 0x00CEB2A5
		[NullableContext(1)]
		public T AsClass<T>() where T : class
		{
			return this._value as T;
		}

		// Token: 0x17005DFA RID: 24058
		// (get) Token: 0x0602E552 RID: 189778 RVA: 0x00CED0B8 File Offset: 0x00CEB2B8
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

		// Token: 0x17005DFB RID: 24059
		// (get) Token: 0x0602E553 RID: 189779 RVA: 0x00CED120 File Offset: 0x00CEB320
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

		// Token: 0x17005DFC RID: 24060
		// (get) Token: 0x0602E554 RID: 189780 RVA: 0x00CED188 File Offset: 0x00CEB388
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

		// Token: 0x17005DFD RID: 24061
		// (get) Token: 0x0602E555 RID: 189781 RVA: 0x00CED1F0 File Offset: 0x00CEB3F0
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

		// Token: 0x17005DFE RID: 24062
		// (get) Token: 0x0602E556 RID: 189782 RVA: 0x00CED270 File Offset: 0x00CEB470
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

		// Token: 0x17005DFF RID: 24063
		// (get) Token: 0x0602E557 RID: 189783 RVA: 0x00CED2D8 File Offset: 0x00CEB4D8
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

		// Token: 0x17005E00 RID: 24064
		// (get) Token: 0x0602E558 RID: 189784 RVA: 0x00CED340 File Offset: 0x00CEB540
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

		// Token: 0x04018AD9 RID: 101081
		[Nullable(1)]
		private readonly object _value;
	}
}
