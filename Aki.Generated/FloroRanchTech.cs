using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D9D RID: 3485
	public struct FloroRanchTech : IFlatbufferObject
	{
		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x06007AB9 RID: 31417 RVA: 0x0025D198 File Offset: 0x0025B398
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007ABA RID: 31418 RVA: 0x0025D1A5 File Offset: 0x0025B3A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007ABB RID: 31419 RVA: 0x0025D1AC File Offset: 0x0025B3AC
		public static FloroRanchTech GetRootAsFloroRanchTech(ByteBuffer _bb)
		{
			return FloroRanchTech.GetRootAsFloroRanchTech(_bb, default(FloroRanchTech));
		}

		// Token: 0x06007ABC RID: 31420 RVA: 0x0025D1C8 File Offset: 0x0025B3C8
		public static FloroRanchTech GetRootAsFloroRanchTech(ByteBuffer _bb, FloroRanchTech obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007ABD RID: 31421 RVA: 0x0025D1E5 File Offset: 0x0025B3E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007ABE RID: 31422 RVA: 0x0025D1F4 File Offset: 0x0025B3F4
		public FloroRanchTech __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x06007ABF RID: 31423 RVA: 0x0025D204 File Offset: 0x0025B404
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

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x06007AC0 RID: 31424 RVA: 0x0025D240 File Offset: 0x0025B440
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

		// Token: 0x06007AC1 RID: 31425 RVA: 0x0025D27C File Offset: 0x0025B47C
		public int PreNode(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x06007AC2 RID: 31426 RVA: 0x0025D2BC File Offset: 0x0025B4BC
		public int PreNodeLength
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

		// Token: 0x06007AC3 RID: 31427 RVA: 0x0025D2E7 File Offset: 0x0025B4E7
		public Span<int> GetPreNodeBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007AC4 RID: 31428 RVA: 0x0025D2F6 File Offset: 0x0025B4F6
		public int[] GetPreNodeArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x06007AC5 RID: 31429 RVA: 0x0025D310 File Offset: 0x0025B510
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

		// Token: 0x06007AC6 RID: 31430 RVA: 0x0025D348 File Offset: 0x0025B548
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007AC7 RID: 31431 RVA: 0x0025D358 File Offset: 0x0025B558
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x06007AC8 RID: 31432 RVA: 0x0025D370 File Offset: 0x0025B570
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

		// Token: 0x06007AC9 RID: 31433 RVA: 0x0025D3A8 File Offset: 0x0025B5A8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007ACA RID: 31434 RVA: 0x0025D3B8 File Offset: 0x0025B5B8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x06007ACB RID: 31435 RVA: 0x0025D3D0 File Offset: 0x0025B5D0
		public int Effect
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

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x06007ACC RID: 31436 RVA: 0x0025D410 File Offset: 0x0025B610
		public int Cost
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

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x06007ACD RID: 31437 RVA: 0x0025D450 File Offset: 0x0025B650
		public int Column
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x06007ACE RID: 31438 RVA: 0x0025D490 File Offset: 0x0025B690
		public int Row
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06007ACF RID: 31439 RVA: 0x0025D4D0 File Offset: 0x0025B6D0
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007AD0 RID: 31440 RVA: 0x0025D508 File Offset: 0x0025B708
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007AD1 RID: 31441 RVA: 0x0025D518 File Offset: 0x0025B718
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06007AD2 RID: 31442 RVA: 0x0025D530 File Offset: 0x0025B730
		[NullableContext(1)]
		public int[] PreNode()
		{
			return this.GetPreNodeArray();
		}

		// Token: 0x06007AD3 RID: 31443 RVA: 0x0025D538 File Offset: 0x0025B738
		[NullableContext(1)]
		public IEnumerable<int> PreNodeIter()
		{
			FloroRanchTech.<PreNodeIter>d__38 <PreNodeIter>d__ = new FloroRanchTech.<PreNodeIter>d__38(-2);
			<PreNodeIter>d__.<>3__<>4__this = this;
			return <PreNodeIter>d__;
		}

		// Token: 0x0400530A RID: 21258
		private Table __p;
	}
}
