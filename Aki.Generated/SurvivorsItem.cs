using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001232 RID: 4658
	public struct SurvivorsItem : IFlatbufferObject
	{
		// Token: 0x17003C1E RID: 15390
		// (get) Token: 0x0600E7C1 RID: 59329 RVA: 0x0034F0D9 File Offset: 0x0034D2D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E7C2 RID: 59330 RVA: 0x0034F0E6 File Offset: 0x0034D2E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E7C3 RID: 59331 RVA: 0x0034F0F0 File Offset: 0x0034D2F0
		public static SurvivorsItem GetRootAsSurvivorsItem(ByteBuffer _bb)
		{
			return SurvivorsItem.GetRootAsSurvivorsItem(_bb, default(SurvivorsItem));
		}

		// Token: 0x0600E7C4 RID: 59332 RVA: 0x0034F10C File Offset: 0x0034D30C
		public static SurvivorsItem GetRootAsSurvivorsItem(ByteBuffer _bb, SurvivorsItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E7C5 RID: 59333 RVA: 0x0034F129 File Offset: 0x0034D329
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E7C6 RID: 59334 RVA: 0x0034F138 File Offset: 0x0034D338
		public SurvivorsItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C1F RID: 15391
		// (get) Token: 0x0600E7C7 RID: 59335 RVA: 0x0034F148 File Offset: 0x0034D348
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

		// Token: 0x17003C20 RID: 15392
		// (get) Token: 0x0600E7C8 RID: 59336 RVA: 0x0034F184 File Offset: 0x0034D384
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E7C9 RID: 59337 RVA: 0x0034F1C0 File Offset: 0x0034D3C0
		public int Effect(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C21 RID: 15393
		// (get) Token: 0x0600E7CA RID: 59338 RVA: 0x0034F200 File Offset: 0x0034D400
		public int EffectLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E7CB RID: 59339 RVA: 0x0034F22B File Offset: 0x0034D42B
		public Span<int> GetEffectBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600E7CC RID: 59340 RVA: 0x0034F23A File Offset: 0x0034D43A
		public int[] GetEffectArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17003C22 RID: 15394
		// (get) Token: 0x0600E7CD RID: 59341 RVA: 0x0034F254 File Offset: 0x0034D454
		public string Name
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E7CE RID: 59342 RVA: 0x0034F28C File Offset: 0x0034D48C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E7CF RID: 59343 RVA: 0x0034F29C File Offset: 0x0034D49C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C23 RID: 15395
		// (get) Token: 0x0600E7D0 RID: 59344 RVA: 0x0034F2B4 File Offset: 0x0034D4B4
		public string Desc
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

		// Token: 0x0600E7D1 RID: 59345 RVA: 0x0034F2EC File Offset: 0x0034D4EC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E7D2 RID: 59346 RVA: 0x0034F2FC File Offset: 0x0034D4FC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C24 RID: 15396
		// (get) Token: 0x0600E7D3 RID: 59347 RVA: 0x0034F314 File Offset: 0x0034D514
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E7D4 RID: 59348 RVA: 0x0034F34C File Offset: 0x0034D54C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E7D5 RID: 59349 RVA: 0x0034F35C File Offset: 0x0034D55C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C25 RID: 15397
		// (get) Token: 0x0600E7D6 RID: 59350 RVA: 0x0034F374 File Offset: 0x0034D574
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E7D7 RID: 59351 RVA: 0x0034F3B1 File Offset: 0x0034D5B1
		[NullableContext(1)]
		public int[] Effect()
		{
			return this.GetEffectArray();
		}

		// Token: 0x0600E7D8 RID: 59352 RVA: 0x0034F3B9 File Offset: 0x0034D5B9
		[NullableContext(1)]
		public IEnumerable<int> EffectIter()
		{
			SurvivorsItem.<EffectIter>d__32 <EffectIter>d__ = new SurvivorsItem.<EffectIter>d__32(-2);
			<EffectIter>d__.<>3__<>4__this = this;
			return <EffectIter>d__;
		}

		// Token: 0x04005875 RID: 22645
		private Table __p;
	}
}
