using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C20 RID: 3104
	public struct BossPilingBuff : IFlatbufferObject
	{
		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06005410 RID: 21520 RVA: 0x00205FF1 File Offset: 0x002041F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005411 RID: 21521 RVA: 0x00205FFE File Offset: 0x002041FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005412 RID: 21522 RVA: 0x00206008 File Offset: 0x00204208
		public static BossPilingBuff GetRootAsBossPilingBuff(ByteBuffer _bb)
		{
			return BossPilingBuff.GetRootAsBossPilingBuff(_bb, default(BossPilingBuff));
		}

		// Token: 0x06005413 RID: 21523 RVA: 0x00206024 File Offset: 0x00204224
		public static BossPilingBuff GetRootAsBossPilingBuff(ByteBuffer _bb, BossPilingBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005414 RID: 21524 RVA: 0x00206041 File Offset: 0x00204241
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005415 RID: 21525 RVA: 0x00206050 File Offset: 0x00204250
		public BossPilingBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06005416 RID: 21526 RVA: 0x00206060 File Offset: 0x00204260
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

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06005417 RID: 21527 RVA: 0x0020609C File Offset: 0x0020429C
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06005418 RID: 21528 RVA: 0x002060DC File Offset: 0x002042DC
		public string Name
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

		// Token: 0x06005419 RID: 21529 RVA: 0x00206113 File Offset: 0x00204313
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600541A RID: 21530 RVA: 0x00206122 File Offset: 0x00204322
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x0600541B RID: 21531 RVA: 0x0020613C File Offset: 0x0020433C
		public string Icon
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

		// Token: 0x0600541C RID: 21532 RVA: 0x00206174 File Offset: 0x00204374
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600541D RID: 21533 RVA: 0x00206184 File Offset: 0x00204384
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x0600541E RID: 21534 RVA: 0x0020619C File Offset: 0x0020439C
		public int Quality
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

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x0600541F RID: 21535 RVA: 0x002061DC File Offset: 0x002043DC
		public string Desc
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

		// Token: 0x06005420 RID: 21536 RVA: 0x00206214 File Offset: 0x00204414
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005421 RID: 21537 RVA: 0x00206224 File Offset: 0x00204424
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06005422 RID: 21538 RVA: 0x0020623C File Offset: 0x0020443C
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06005423 RID: 21539 RVA: 0x00206278 File Offset: 0x00204478
		public int DescArgsLength
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

		// Token: 0x06005424 RID: 21540 RVA: 0x002062A4 File Offset: 0x002044A4
		[NullableContext(1)]
		public string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x06005425 RID: 21541 RVA: 0x002062B1 File Offset: 0x002044B1
		[NullableContext(1)]
		public IEnumerable<string> DescArgsIter()
		{
			BossPilingBuff.<DescArgsIter>d__30 <DescArgsIter>d__ = new BossPilingBuff.<DescArgsIter>d__30(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x0400511B RID: 20763
		private Table __p;
	}
}
