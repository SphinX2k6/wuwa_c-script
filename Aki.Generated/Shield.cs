using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A7 RID: 4263
	public struct Shield : IFlatbufferObject
	{
		// Token: 0x170035AC RID: 13740
		// (get) Token: 0x0600D18C RID: 53644 RVA: 0x0030E491 File Offset: 0x0030C691
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D18D RID: 53645 RVA: 0x0030E49E File Offset: 0x0030C69E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D18E RID: 53646 RVA: 0x0030E4A8 File Offset: 0x0030C6A8
		public static Shield GetRootAsShield(ByteBuffer _bb)
		{
			return Shield.GetRootAsShield(_bb, default(Shield));
		}

		// Token: 0x0600D18F RID: 53647 RVA: 0x0030E4C4 File Offset: 0x0030C6C4
		public static Shield GetRootAsShield(ByteBuffer _bb, Shield obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D190 RID: 53648 RVA: 0x0030E4E1 File Offset: 0x0030C6E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D191 RID: 53649 RVA: 0x0030E4F0 File Offset: 0x0030C6F0
		public Shield __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035AD RID: 13741
		// (get) Token: 0x0600D192 RID: 53650 RVA: 0x0030E500 File Offset: 0x0030C700
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170035AE RID: 13742
		// (get) Token: 0x0600D193 RID: 53651 RVA: 0x0030E53C File Offset: 0x0030C73C
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170035AF RID: 13743
		// (get) Token: 0x0600D194 RID: 53652 RVA: 0x0030E578 File Offset: 0x0030C778
		public int RefrenceAttribute
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170035B0 RID: 13744
		// (get) Token: 0x0600D195 RID: 53653 RVA: 0x0030E5B4 File Offset: 0x0030C7B4
		public int AttributeType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170035B1 RID: 13745
		// (get) Token: 0x0600D196 RID: 53654 RVA: 0x0030E5F4 File Offset: 0x0030C7F4
		public int FormationPropValueType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170035B2 RID: 13746
		// (get) Token: 0x0600D197 RID: 53655 RVA: 0x0030E634 File Offset: 0x0030C834
		public int RefrenceTarget
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D198 RID: 53656 RVA: 0x0030E674 File Offset: 0x0030C874
		public float AttributeRate(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170035B3 RID: 13747
		// (get) Token: 0x0600D199 RID: 53657 RVA: 0x0030E6B8 File Offset: 0x0030C8B8
		public int AttributeRateLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D19A RID: 53658 RVA: 0x0030E6E4 File Offset: 0x0030C8E4
		public Span<float> GetAttributeRateBytes()
		{
			return this.__p.__vector_as_span<float>(16, 4);
		}

		// Token: 0x0600D19B RID: 53659 RVA: 0x0030E6F4 File Offset: 0x0030C8F4
		public float[] GetAttributeRateArray()
		{
			return this.__p.__vector_as_array<float>(16) ?? Array.Empty<float>();
		}

		// Token: 0x0600D19C RID: 53660 RVA: 0x0030E70C File Offset: 0x0030C90C
		public float Value(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170035B4 RID: 13748
		// (get) Token: 0x0600D19D RID: 53661 RVA: 0x0030E750 File Offset: 0x0030C950
		public int ValueLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D19E RID: 53662 RVA: 0x0030E77C File Offset: 0x0030C97C
		public Span<float> GetValueBytes()
		{
			return this.__p.__vector_as_span<float>(18, 4);
		}

		// Token: 0x0600D19F RID: 53663 RVA: 0x0030E78C File Offset: 0x0030C98C
		public float[] GetValueArray()
		{
			return this.__p.__vector_as_array<float>(18) ?? Array.Empty<float>();
		}

		// Token: 0x0600D1A0 RID: 53664 RVA: 0x0030E7A4 File Offset: 0x0030C9A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttributeRateIter()或GetAttributeRateBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] AttributeRate()
		{
			Shield shield = this;
			return shield.GetAttributeRateArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600D1A1 RID: 53665 RVA: 0x0030E7C8 File Offset: 0x0030C9C8
		[NullableContext(1)]
		public readonly IEnumerable<float> AttributeRateIter()
		{
			Shield.<AttributeRateIter>d__31 <AttributeRateIter>d__ = new Shield.<AttributeRateIter>d__31(-2);
			<AttributeRateIter>d__.<>3__<>4__this = this;
			return <AttributeRateIter>d__;
		}

		// Token: 0x0600D1A2 RID: 53666 RVA: 0x0030E7E0 File Offset: 0x0030C9E0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ValueIter()或GetValueBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Value()
		{
			Shield shield = this;
			return shield.GetValueArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600D1A3 RID: 53667 RVA: 0x0030E804 File Offset: 0x0030CA04
		[NullableContext(1)]
		public readonly IEnumerable<float> ValueIter()
		{
			Shield.<ValueIter>d__33 <ValueIter>d__ = new Shield.<ValueIter>d__33(-2);
			<ValueIter>d__.<>3__<>4__this = this;
			return <ValueIter>d__;
		}

		// Token: 0x040051B6 RID: 20918
		private Table __p;
	}
}
