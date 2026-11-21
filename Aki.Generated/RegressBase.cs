using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001091 RID: 4241
	public struct RegressBase : IFlatbufferObject
	{
		// Token: 0x17002DF7 RID: 11767
		// (get) Token: 0x0600C0E4 RID: 49380 RVA: 0x002F790C File Offset: 0x002F5B0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C0E5 RID: 49381 RVA: 0x002F7919 File Offset: 0x002F5B19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C0E6 RID: 49382 RVA: 0x002F7920 File Offset: 0x002F5B20
		public static RegressBase GetRootAsRegressBase(ByteBuffer _bb)
		{
			return RegressBase.GetRootAsRegressBase(_bb, default(RegressBase));
		}

		// Token: 0x0600C0E7 RID: 49383 RVA: 0x002F793C File Offset: 0x002F5B3C
		public static RegressBase GetRootAsRegressBase(ByteBuffer _bb, RegressBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C0E8 RID: 49384 RVA: 0x002F7959 File Offset: 0x002F5B59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C0E9 RID: 49385 RVA: 0x002F7968 File Offset: 0x002F5B68
		public RegressBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DF8 RID: 11768
		// (get) Token: 0x0600C0EA RID: 49386 RVA: 0x002F7978 File Offset: 0x002F5B78
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

		// Token: 0x17002DF9 RID: 11769
		// (get) Token: 0x0600C0EB RID: 49387 RVA: 0x002F79B4 File Offset: 0x002F5BB4
		public int EntryType
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

		// Token: 0x0600C0EC RID: 49388 RVA: 0x002F79F0 File Offset: 0x002F5BF0
		public int ArgId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DFA RID: 11770
		// (get) Token: 0x0600C0ED RID: 49389 RVA: 0x002F7A30 File Offset: 0x002F5C30
		public int ArgIdLength
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

		// Token: 0x0600C0EE RID: 49390 RVA: 0x002F7A5B File Offset: 0x002F5C5B
		public Span<int> GetArgIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C0EF RID: 49391 RVA: 0x002F7A6A File Offset: 0x002F5C6A
		public int[] GetArgIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002DFB RID: 11771
		// (get) Token: 0x0600C0F0 RID: 49392 RVA: 0x002F7A84 File Offset: 0x002F5C84
		public int GachaId
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

		// Token: 0x17002DFC RID: 11772
		// (get) Token: 0x0600C0F1 RID: 49393 RVA: 0x002F7AC4 File Offset: 0x002F5CC4
		public string Title
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

		// Token: 0x0600C0F2 RID: 49394 RVA: 0x002F7AFC File Offset: 0x002F5CFC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C0F3 RID: 49395 RVA: 0x002F7B0C File Offset: 0x002F5D0C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DFD RID: 11773
		// (get) Token: 0x0600C0F4 RID: 49396 RVA: 0x002F7B24 File Offset: 0x002F5D24
		public string SubTitle
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

		// Token: 0x0600C0F5 RID: 49397 RVA: 0x002F7B5C File Offset: 0x002F5D5C
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C0F6 RID: 49398 RVA: 0x002F7B6C File Offset: 0x002F5D6C
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DFE RID: 11774
		// (get) Token: 0x0600C0F7 RID: 49399 RVA: 0x002F7B84 File Offset: 0x002F5D84
		public string BgPathF
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C0F8 RID: 49400 RVA: 0x002F7BBC File Offset: 0x002F5DBC
		public Span<byte> GetBgPathFBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C0F9 RID: 49401 RVA: 0x002F7BCC File Offset: 0x002F5DCC
		public byte[] GetBgPathFArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DFF RID: 11775
		// (get) Token: 0x0600C0FA RID: 49402 RVA: 0x002F7BE4 File Offset: 0x002F5DE4
		public string BgPath
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C0FB RID: 49403 RVA: 0x002F7C1C File Offset: 0x002F5E1C
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C0FC RID: 49404 RVA: 0x002F7C2C File Offset: 0x002F5E2C
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E00 RID: 11776
		// (get) Token: 0x0600C0FD RID: 49405 RVA: 0x002F7C44 File Offset: 0x002F5E44
		public string Description
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C0FE RID: 49406 RVA: 0x002F7C7C File Offset: 0x002F5E7C
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C0FF RID: 49407 RVA: 0x002F7C8C File Offset: 0x002F5E8C
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E01 RID: 11777
		// (get) Token: 0x0600C100 RID: 49408 RVA: 0x002F7CA4 File Offset: 0x002F5EA4
		public int RewardPreview
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E02 RID: 11778
		// (get) Token: 0x0600C101 RID: 49409 RVA: 0x002F7CE4 File Offset: 0x002F5EE4
		public int TargetActivityId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E03 RID: 11779
		// (get) Token: 0x0600C102 RID: 49410 RVA: 0x002F7D24 File Offset: 0x002F5F24
		public string JumpBtnDes
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C103 RID: 49411 RVA: 0x002F7D5C File Offset: 0x002F5F5C
		public Span<byte> GetJumpBtnDesBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600C104 RID: 49412 RVA: 0x002F7D6C File Offset: 0x002F5F6C
		public byte[] GetJumpBtnDesArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C105 RID: 49413 RVA: 0x002F7D84 File Offset: 0x002F5F84
		[NullableContext(1)]
		public int[] ArgId()
		{
			return this.GetArgIdArray();
		}

		// Token: 0x0600C106 RID: 49414 RVA: 0x002F7D8C File Offset: 0x002F5F8C
		[NullableContext(1)]
		public IEnumerable<int> ArgIdIter()
		{
			RegressBase.<ArgIdIter>d__48 <ArgIdIter>d__ = new RegressBase.<ArgIdIter>d__48(-2);
			<ArgIdIter>d__.<>3__<>4__this = this;
			return <ArgIdIter>d__;
		}

		// Token: 0x0400566A RID: 22122
		private Table __p;
	}
}
