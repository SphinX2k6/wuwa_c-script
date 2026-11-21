using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F09 RID: 3849
	public struct MoraleFlagType : IFlatbufferObject
	{
		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x06009C23 RID: 39971 RVA: 0x002A75BE File Offset: 0x002A57BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009C24 RID: 39972 RVA: 0x002A75CB File Offset: 0x002A57CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009C25 RID: 39973 RVA: 0x002A75D4 File Offset: 0x002A57D4
		public static MoraleFlagType GetRootAsMoraleFlagType(ByteBuffer _bb)
		{
			return MoraleFlagType.GetRootAsMoraleFlagType(_bb, default(MoraleFlagType));
		}

		// Token: 0x06009C26 RID: 39974 RVA: 0x002A75F0 File Offset: 0x002A57F0
		public static MoraleFlagType GetRootAsMoraleFlagType(ByteBuffer _bb, MoraleFlagType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009C27 RID: 39975 RVA: 0x002A760D File Offset: 0x002A580D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009C28 RID: 39976 RVA: 0x002A761C File Offset: 0x002A581C
		public MoraleFlagType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x06009C29 RID: 39977 RVA: 0x002A762C File Offset: 0x002A582C
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

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x06009C2A RID: 39978 RVA: 0x002A7668 File Offset: 0x002A5868
		public int TypeId
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

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x06009C2B RID: 39979 RVA: 0x002A76A4 File Offset: 0x002A58A4
		public int ShowUiMap
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

		// Token: 0x06009C2C RID: 39980 RVA: 0x002A76E0 File Offset: 0x002A58E0
		public string IconPathNormal(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x06009C2D RID: 39981 RVA: 0x002A771C File Offset: 0x002A591C
		public int IconPathNormalLength
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

		// Token: 0x06009C2E RID: 39982 RVA: 0x002A7748 File Offset: 0x002A5948
		public string IconPathActive(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x06009C2F RID: 39983 RVA: 0x002A7784 File Offset: 0x002A5984
		public int IconPathActiveLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x06009C30 RID: 39984 RVA: 0x002A77B0 File Offset: 0x002A59B0
		public string ResId
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

		// Token: 0x06009C31 RID: 39985 RVA: 0x002A77E8 File Offset: 0x002A59E8
		public Span<byte> GetResIdBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009C32 RID: 39986 RVA: 0x002A77F8 File Offset: 0x002A59F8
		public byte[] GetResIdArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x06009C33 RID: 39987 RVA: 0x002A7810 File Offset: 0x002A5A10
		public string DescLightPath
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

		// Token: 0x06009C34 RID: 39988 RVA: 0x002A7848 File Offset: 0x002A5A48
		public Span<byte> GetDescLightPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009C35 RID: 39989 RVA: 0x002A7858 File Offset: 0x002A5A58
		public byte[] GetDescLightPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06009C36 RID: 39990 RVA: 0x002A7870 File Offset: 0x002A5A70
		[NullableContext(1)]
		public string[] IconPathActive()
		{
			return this.IconPathActiveIter().ToArray<string>();
		}

		// Token: 0x06009C37 RID: 39991 RVA: 0x002A787D File Offset: 0x002A5A7D
		[NullableContext(1)]
		public IEnumerable<string> IconPathActiveIter()
		{
			MoraleFlagType.<IconPathActiveIter>d__29 <IconPathActiveIter>d__ = new MoraleFlagType.<IconPathActiveIter>d__29(-2);
			<IconPathActiveIter>d__.<>3__<>4__this = this;
			return <IconPathActiveIter>d__;
		}

		// Token: 0x06009C38 RID: 39992 RVA: 0x002A7892 File Offset: 0x002A5A92
		[NullableContext(1)]
		public string[] IconPathNormal()
		{
			return this.IconPathNormalIter().ToArray<string>();
		}

		// Token: 0x06009C39 RID: 39993 RVA: 0x002A789F File Offset: 0x002A5A9F
		[NullableContext(1)]
		public IEnumerable<string> IconPathNormalIter()
		{
			MoraleFlagType.<IconPathNormalIter>d__31 <IconPathNormalIter>d__ = new MoraleFlagType.<IconPathNormalIter>d__31(-2);
			<IconPathNormalIter>d__.<>3__<>4__this = this;
			return <IconPathNormalIter>d__;
		}

		// Token: 0x040054AE RID: 21678
		private Table __p;
	}
}
