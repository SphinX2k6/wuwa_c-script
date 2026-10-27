using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C02 RID: 3074
	public struct DrinksDrinkMix : IFlatbufferObject
	{
		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x060063E5 RID: 25573 RVA: 0x0021748C File Offset: 0x0021568C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x00217499 File Offset: 0x00215699
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x002174A0 File Offset: 0x002156A0
		public static DrinksDrinkMix GetRootAsDrinksDrinkMix(ByteBuffer _bb)
		{
			return DrinksDrinkMix.GetRootAsDrinksDrinkMix(_bb, default(DrinksDrinkMix));
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x002174BC File Offset: 0x002156BC
		public static DrinksDrinkMix GetRootAsDrinksDrinkMix(ByteBuffer _bb, DrinksDrinkMix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060063E9 RID: 25577 RVA: 0x002174D9 File Offset: 0x002156D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060063EA RID: 25578 RVA: 0x002174E8 File Offset: 0x002156E8
		public DrinksDrinkMix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x060063EB RID: 25579 RVA: 0x002174F8 File Offset: 0x002156F8
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

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x060063EC RID: 25580 RVA: 0x00217534 File Offset: 0x00215734
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060063ED RID: 25581 RVA: 0x0021756B File Offset: 0x0021576B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060063EE RID: 25582 RVA: 0x0021757A File Offset: 0x0021577A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x060063EF RID: 25583 RVA: 0x00217594 File Offset: 0x00215794
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060063F0 RID: 25584 RVA: 0x002175CB File Offset: 0x002157CB
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x002175DA File Offset: 0x002157DA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x002175F4 File Offset: 0x002157F4
		public int MixArray(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x060063F3 RID: 25587 RVA: 0x00217634 File Offset: 0x00215834
		public int MixArrayLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060063F4 RID: 25588 RVA: 0x00217660 File Offset: 0x00215860
		public Span<int> GetMixArrayBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060063F5 RID: 25589 RVA: 0x00217670 File Offset: 0x00215870
		public int[] GetMixArrayArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x060063F6 RID: 25590 RVA: 0x00217688 File Offset: 0x00215888
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060063F7 RID: 25591 RVA: 0x002176C0 File Offset: 0x002158C0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060063F8 RID: 25592 RVA: 0x002176D0 File Offset: 0x002158D0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x060063F9 RID: 25593 RVA: 0x002176E8 File Offset: 0x002158E8
		public int EffectId
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

		// Token: 0x060063FA RID: 25594 RVA: 0x00217728 File Offset: 0x00215928
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MixArrayIter()或GetMixArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MixArray()
		{
			DrinksDrinkMix drinksDrinkMix = this;
			return drinksDrinkMix.GetMixArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x060063FB RID: 25595 RVA: 0x0021774C File Offset: 0x0021594C
		[NullableContext(1)]
		public readonly IEnumerable<int> MixArrayIter()
		{
			DrinksDrinkMix.<MixArrayIter>d__30 <MixArrayIter>d__ = new DrinksDrinkMix.<MixArrayIter>d__30(-2);
			<MixArrayIter>d__.<>3__<>4__this = this;
			return <MixArrayIter>d__;
		}

		// Token: 0x04004C38 RID: 19512
		private Table __p;
	}
}
