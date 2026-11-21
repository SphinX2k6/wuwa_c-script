using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200114E RID: 4430
	public struct RoleTowerFloor : IFlatbufferObject
	{
		// Token: 0x1700340D RID: 13325
		// (get) Token: 0x0600D205 RID: 53765 RVA: 0x0031D9E3 File Offset: 0x0031BBE3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D206 RID: 53766 RVA: 0x0031D9F0 File Offset: 0x0031BBF0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D207 RID: 53767 RVA: 0x0031D9F8 File Offset: 0x0031BBF8
		public static RoleTowerFloor GetRootAsRoleTowerFloor(ByteBuffer _bb)
		{
			return RoleTowerFloor.GetRootAsRoleTowerFloor(_bb, default(RoleTowerFloor));
		}

		// Token: 0x0600D208 RID: 53768 RVA: 0x0031DA14 File Offset: 0x0031BC14
		public static RoleTowerFloor GetRootAsRoleTowerFloor(ByteBuffer _bb, RoleTowerFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D209 RID: 53769 RVA: 0x0031DA31 File Offset: 0x0031BC31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D20A RID: 53770 RVA: 0x0031DA40 File Offset: 0x0031BC40
		public RoleTowerFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700340E RID: 13326
		// (get) Token: 0x0600D20B RID: 53771 RVA: 0x0031DA50 File Offset: 0x0031BC50
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

		// Token: 0x1700340F RID: 13327
		// (get) Token: 0x0600D20C RID: 53772 RVA: 0x0031DA8C File Offset: 0x0031BC8C
		public int FloorGroupId
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

		// Token: 0x17003410 RID: 13328
		// (get) Token: 0x0600D20D RID: 53773 RVA: 0x0031DAC8 File Offset: 0x0031BCC8
		public int Stage
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

		// Token: 0x17003411 RID: 13329
		// (get) Token: 0x0600D20E RID: 53774 RVA: 0x0031DB04 File Offset: 0x0031BD04
		public int Branch
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

		// Token: 0x17003412 RID: 13330
		// (get) Token: 0x0600D20F RID: 53775 RVA: 0x0031DB44 File Offset: 0x0031BD44
		public int FloorIndex
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

		// Token: 0x17003413 RID: 13331
		// (get) Token: 0x0600D210 RID: 53776 RVA: 0x0031DB84 File Offset: 0x0031BD84
		public int FloorType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003414 RID: 13332
		// (get) Token: 0x0600D211 RID: 53777 RVA: 0x0031DBC4 File Offset: 0x0031BDC4
		public string FloorName
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

		// Token: 0x0600D212 RID: 53778 RVA: 0x0031DBFC File Offset: 0x0031BDFC
		public Span<byte> GetFloorNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D213 RID: 53779 RVA: 0x0031DC0C File Offset: 0x0031BE0C
		public byte[] GetFloorNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003415 RID: 13333
		// (get) Token: 0x0600D214 RID: 53780 RVA: 0x0031DC24 File Offset: 0x0031BE24
		public string FloorShortName
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

		// Token: 0x0600D215 RID: 53781 RVA: 0x0031DC5C File Offset: 0x0031BE5C
		public Span<byte> GetFloorShortNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D216 RID: 53782 RVA: 0x0031DC6C File Offset: 0x0031BE6C
		public byte[] GetFloorShortNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003416 RID: 13334
		// (get) Token: 0x0600D217 RID: 53783 RVA: 0x0031DC84 File Offset: 0x0031BE84
		public string FloorIcon
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

		// Token: 0x0600D218 RID: 53784 RVA: 0x0031DCBC File Offset: 0x0031BEBC
		public Span<byte> GetFloorIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D219 RID: 53785 RVA: 0x0031DCCC File Offset: 0x0031BECC
		public byte[] GetFloorIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003417 RID: 13335
		// (get) Token: 0x0600D21A RID: 53786 RVA: 0x0031DCE4 File Offset: 0x0031BEE4
		public string MechanismDesc
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

		// Token: 0x0600D21B RID: 53787 RVA: 0x0031DD1C File Offset: 0x0031BF1C
		public Span<byte> GetMechanismDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D21C RID: 53788 RVA: 0x0031DD2C File Offset: 0x0031BF2C
		public byte[] GetMechanismDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D21D RID: 53789 RVA: 0x0031DD44 File Offset: 0x0031BF44
		public int MonsterPreview(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003418 RID: 13336
		// (get) Token: 0x0600D21E RID: 53790 RVA: 0x0031DD84 File Offset: 0x0031BF84
		public int MonsterPreviewLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D21F RID: 53791 RVA: 0x0031DDB0 File Offset: 0x0031BFB0
		public Span<int> GetMonsterPreviewBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600D220 RID: 53792 RVA: 0x0031DDC0 File Offset: 0x0031BFC0
		public int[] GetMonsterPreviewArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600D221 RID: 53793 RVA: 0x0031DDD8 File Offset: 0x0031BFD8
		[NullableContext(1)]
		public int[] MonsterPreview()
		{
			return this.GetMonsterPreviewArray();
		}

		// Token: 0x0600D222 RID: 53794 RVA: 0x0031DDE0 File Offset: 0x0031BFE0
		[NullableContext(1)]
		public IEnumerable<int> MonsterPreviewIter()
		{
			RoleTowerFloor.<MonsterPreviewIter>d__42 <MonsterPreviewIter>d__ = new RoleTowerFloor.<MonsterPreviewIter>d__42(-2);
			<MonsterPreviewIter>d__.<>3__<>4__this = this;
			return <MonsterPreviewIter>d__;
		}

		// Token: 0x04005753 RID: 22355
		private Table __p;
	}
}
