using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001055 RID: 4181
	public struct QuestRefMapBlockConfig : IFlatbufferObject
	{
		// Token: 0x17002C2A RID: 11306
		// (get) Token: 0x0600BBCC RID: 48076 RVA: 0x002EC7FE File Offset: 0x002EA9FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BBCD RID: 48077 RVA: 0x002EC80B File Offset: 0x002EAA0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BBCE RID: 48078 RVA: 0x002EC814 File Offset: 0x002EAA14
		public static QuestRefMapBlockConfig GetRootAsQuestRefMapBlockConfig(ByteBuffer _bb)
		{
			return QuestRefMapBlockConfig.GetRootAsQuestRefMapBlockConfig(_bb, default(QuestRefMapBlockConfig));
		}

		// Token: 0x0600BBCF RID: 48079 RVA: 0x002EC830 File Offset: 0x002EAA30
		public static QuestRefMapBlockConfig GetRootAsQuestRefMapBlockConfig(ByteBuffer _bb, QuestRefMapBlockConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BBD0 RID: 48080 RVA: 0x002EC84D File Offset: 0x002EAA4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BBD1 RID: 48081 RVA: 0x002EC85C File Offset: 0x002EAA5C
		public QuestRefMapBlockConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C2B RID: 11307
		// (get) Token: 0x0600BBD2 RID: 48082 RVA: 0x002EC86C File Offset: 0x002EAA6C
		public int QuestId
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

		// Token: 0x0600BBD3 RID: 48083 RVA: 0x002EC8A8 File Offset: 0x002EAAA8
		public int MapBlockId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C2C RID: 11308
		// (get) Token: 0x0600BBD4 RID: 48084 RVA: 0x002EC8E8 File Offset: 0x002EAAE8
		public int MapBlockIdLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BBD5 RID: 48085 RVA: 0x002EC913 File Offset: 0x002EAB13
		public Span<int> GetMapBlockIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600BBD6 RID: 48086 RVA: 0x002EC922 File Offset: 0x002EAB22
		public int[] GetMapBlockIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002C2D RID: 11309
		// (get) Token: 0x0600BBD7 RID: 48087 RVA: 0x002EC93C File Offset: 0x002EAB3C
		public string OnlineBranch
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

		// Token: 0x0600BBD8 RID: 48088 RVA: 0x002EC973 File Offset: 0x002EAB73
		public Span<byte> GetOnlineBranchBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BBD9 RID: 48089 RVA: 0x002EC982 File Offset: 0x002EAB82
		public byte[] GetOnlineBranchArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BBDA RID: 48090 RVA: 0x002EC999 File Offset: 0x002EAB99
		[NullableContext(1)]
		public int[] MapBlockId()
		{
			return this.GetMapBlockIdArray();
		}

		// Token: 0x0600BBDB RID: 48091 RVA: 0x002EC9A1 File Offset: 0x002EABA1
		[NullableContext(1)]
		public IEnumerable<int> MapBlockIdIter()
		{
			QuestRefMapBlockConfig.<MapBlockIdIter>d__20 <MapBlockIdIter>d__ = new QuestRefMapBlockConfig.<MapBlockIdIter>d__20(-2);
			<MapBlockIdIter>d__.<>3__<>4__this = this;
			return <MapBlockIdIter>d__;
		}

		// Token: 0x04005623 RID: 22051
		private Table __p;
	}
}
