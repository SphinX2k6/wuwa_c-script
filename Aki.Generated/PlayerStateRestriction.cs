using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200102C RID: 4140
	public struct PlayerStateRestriction : IFlatbufferObject
	{
		// Token: 0x17002AC3 RID: 10947
		// (get) Token: 0x0600B7DB RID: 47067 RVA: 0x002E4921 File Offset: 0x002E2B21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B7DC RID: 47068 RVA: 0x002E492E File Offset: 0x002E2B2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B7DD RID: 47069 RVA: 0x002E4938 File Offset: 0x002E2B38
		public static PlayerStateRestriction GetRootAsPlayerStateRestriction(ByteBuffer _bb)
		{
			return PlayerStateRestriction.GetRootAsPlayerStateRestriction(_bb, default(PlayerStateRestriction));
		}

		// Token: 0x0600B7DE RID: 47070 RVA: 0x002E4954 File Offset: 0x002E2B54
		public static PlayerStateRestriction GetRootAsPlayerStateRestriction(ByteBuffer _bb, PlayerStateRestriction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B7DF RID: 47071 RVA: 0x002E4971 File Offset: 0x002E2B71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B7E0 RID: 47072 RVA: 0x002E4980 File Offset: 0x002E2B80
		public PlayerStateRestriction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AC4 RID: 10948
		// (get) Token: 0x0600B7E1 RID: 47073 RVA: 0x002E4990 File Offset: 0x002E2B90
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

		// Token: 0x17002AC5 RID: 10949
		// (get) Token: 0x0600B7E2 RID: 47074 RVA: 0x002E49CC File Offset: 0x002E2BCC
		public string Type
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

		// Token: 0x0600B7E3 RID: 47075 RVA: 0x002E4A03 File Offset: 0x002E2C03
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B7E4 RID: 47076 RVA: 0x002E4A12 File Offset: 0x002E2C12
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B7E5 RID: 47077 RVA: 0x002E4A2C File Offset: 0x002E2C2C
		public string IncludedTags(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002AC6 RID: 10950
		// (get) Token: 0x0600B7E6 RID: 47078 RVA: 0x002E4A68 File Offset: 0x002E2C68
		public int IncludedTagsLength
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

		// Token: 0x0600B7E7 RID: 47079 RVA: 0x002E4A94 File Offset: 0x002E2C94
		public string ExcludedTags(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002AC7 RID: 10951
		// (get) Token: 0x0600B7E8 RID: 47080 RVA: 0x002E4AD0 File Offset: 0x002E2CD0
		public int ExcludedTagsLength
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

		// Token: 0x17002AC8 RID: 10952
		// (get) Token: 0x0600B7E9 RID: 47081 RVA: 0x002E4AFC File Offset: 0x002E2CFC
		public int CreatorId
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

		// Token: 0x17002AC9 RID: 10953
		// (get) Token: 0x0600B7EA RID: 47082 RVA: 0x002E4B3C File Offset: 0x002E2D3C
		public string Remark
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

		// Token: 0x0600B7EB RID: 47083 RVA: 0x002E4B74 File Offset: 0x002E2D74
		public Span<byte> GetRemarkBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B7EC RID: 47084 RVA: 0x002E4B84 File Offset: 0x002E2D84
		public byte[] GetRemarkArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B7ED RID: 47085 RVA: 0x002E4B9C File Offset: 0x002E2D9C
		[NullableContext(1)]
		public string[] ExcludedTags()
		{
			return this.ExcludedTagsIter().ToArray<string>();
		}

		// Token: 0x0600B7EE RID: 47086 RVA: 0x002E4BA9 File Offset: 0x002E2DA9
		[NullableContext(1)]
		public IEnumerable<string> ExcludedTagsIter()
		{
			PlayerStateRestriction.<ExcludedTagsIter>d__27 <ExcludedTagsIter>d__ = new PlayerStateRestriction.<ExcludedTagsIter>d__27(-2);
			<ExcludedTagsIter>d__.<>3__<>4__this = this;
			return <ExcludedTagsIter>d__;
		}

		// Token: 0x0600B7EF RID: 47087 RVA: 0x002E4BBE File Offset: 0x002E2DBE
		[NullableContext(1)]
		public string[] IncludedTags()
		{
			return this.IncludedTagsIter().ToArray<string>();
		}

		// Token: 0x0600B7F0 RID: 47088 RVA: 0x002E4BCB File Offset: 0x002E2DCB
		[NullableContext(1)]
		public IEnumerable<string> IncludedTagsIter()
		{
			PlayerStateRestriction.<IncludedTagsIter>d__29 <IncludedTagsIter>d__ = new PlayerStateRestriction.<IncludedTagsIter>d__29(-2);
			<IncludedTagsIter>d__.<>3__<>4__this = this;
			return <IncludedTagsIter>d__;
		}

		// Token: 0x040055F9 RID: 22009
		private Table __p;
	}
}
