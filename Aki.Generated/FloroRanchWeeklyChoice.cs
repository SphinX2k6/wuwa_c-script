using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA4 RID: 3492
	public struct FloroRanchWeeklyChoice : IFlatbufferObject
	{
		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x06007B39 RID: 31545 RVA: 0x0025E408 File Offset: 0x0025C608
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007B3A RID: 31546 RVA: 0x0025E415 File Offset: 0x0025C615
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007B3B RID: 31547 RVA: 0x0025E41C File Offset: 0x0025C61C
		public static FloroRanchWeeklyChoice GetRootAsFloroRanchWeeklyChoice(ByteBuffer _bb)
		{
			return FloroRanchWeeklyChoice.GetRootAsFloroRanchWeeklyChoice(_bb, default(FloroRanchWeeklyChoice));
		}

		// Token: 0x06007B3C RID: 31548 RVA: 0x0025E438 File Offset: 0x0025C638
		public static FloroRanchWeeklyChoice GetRootAsFloroRanchWeeklyChoice(ByteBuffer _bb, FloroRanchWeeklyChoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007B3D RID: 31549 RVA: 0x0025E455 File Offset: 0x0025C655
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007B3E RID: 31550 RVA: 0x0025E464 File Offset: 0x0025C664
		public FloroRanchWeeklyChoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x06007B3F RID: 31551 RVA: 0x0025E474 File Offset: 0x0025C674
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

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x06007B40 RID: 31552 RVA: 0x0025E4B0 File Offset: 0x0025C6B0
		public string Desc
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

		// Token: 0x06007B41 RID: 31553 RVA: 0x0025E4E7 File Offset: 0x0025C6E7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007B42 RID: 31554 RVA: 0x0025E4F6 File Offset: 0x0025C6F6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06007B43 RID: 31555 RVA: 0x0025E510 File Offset: 0x0025C710
		public string NameParam(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x06007B44 RID: 31556 RVA: 0x0025E54C File Offset: 0x0025C74C
		public int NameParamLength
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

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x06007B45 RID: 31557 RVA: 0x0025E578 File Offset: 0x0025C778
		public int NeedRemoveToyCount
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

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x06007B46 RID: 31558 RVA: 0x0025E5B8 File Offset: 0x0025C7B8
		public int NeedEmptyGridCount
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

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x06007B47 RID: 31559 RVA: 0x0025E5F8 File Offset: 0x0025C7F8
		public int ToyRelateQuality
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

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x06007B48 RID: 31560 RVA: 0x0025E638 File Offset: 0x0025C838
		public int GetToyRelateQuality
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

		// Token: 0x06007B49 RID: 31561 RVA: 0x0025E675 File Offset: 0x0025C875
		[NullableContext(1)]
		public string[] NameParam()
		{
			return this.NameParamIter().ToArray<string>();
		}

		// Token: 0x06007B4A RID: 31562 RVA: 0x0025E682 File Offset: 0x0025C882
		[NullableContext(1)]
		public IEnumerable<string> NameParamIter()
		{
			FloroRanchWeeklyChoice.<NameParamIter>d__26 <NameParamIter>d__ = new FloroRanchWeeklyChoice.<NameParamIter>d__26(-2);
			<NameParamIter>d__.<>3__<>4__this = this;
			return <NameParamIter>d__;
		}

		// Token: 0x04005314 RID: 21268
		private Table __p;
	}
}
