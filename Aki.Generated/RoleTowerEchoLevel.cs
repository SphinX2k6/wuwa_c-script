using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200114D RID: 4429
	public struct RoleTowerEchoLevel : IFlatbufferObject
	{
		// Token: 0x17003403 RID: 13315
		// (get) Token: 0x0600D1ED RID: 53741 RVA: 0x0031D69C File Offset: 0x0031B89C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D1EE RID: 53742 RVA: 0x0031D6A9 File Offset: 0x0031B8A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D1EF RID: 53743 RVA: 0x0031D6B0 File Offset: 0x0031B8B0
		public static RoleTowerEchoLevel GetRootAsRoleTowerEchoLevel(ByteBuffer _bb)
		{
			return RoleTowerEchoLevel.GetRootAsRoleTowerEchoLevel(_bb, default(RoleTowerEchoLevel));
		}

		// Token: 0x0600D1F0 RID: 53744 RVA: 0x0031D6CC File Offset: 0x0031B8CC
		public static RoleTowerEchoLevel GetRootAsRoleTowerEchoLevel(ByteBuffer _bb, RoleTowerEchoLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D1F1 RID: 53745 RVA: 0x0031D6E9 File Offset: 0x0031B8E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D1F2 RID: 53746 RVA: 0x0031D6F8 File Offset: 0x0031B8F8
		public RoleTowerEchoLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003404 RID: 13316
		// (get) Token: 0x0600D1F3 RID: 53747 RVA: 0x0031D708 File Offset: 0x0031B908
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

		// Token: 0x17003405 RID: 13317
		// (get) Token: 0x0600D1F4 RID: 53748 RVA: 0x0031D744 File Offset: 0x0031B944
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

		// Token: 0x17003406 RID: 13318
		// (get) Token: 0x0600D1F5 RID: 53749 RVA: 0x0031D780 File Offset: 0x0031B980
		public int LevelIndex
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

		// Token: 0x17003407 RID: 13319
		// (get) Token: 0x0600D1F6 RID: 53750 RVA: 0x0031D7BC File Offset: 0x0031B9BC
		public int Exp
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

		// Token: 0x17003408 RID: 13320
		// (get) Token: 0x0600D1F7 RID: 53751 RVA: 0x0031D7FC File Offset: 0x0031B9FC
		public string Name
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

		// Token: 0x0600D1F8 RID: 53752 RVA: 0x0031D834 File Offset: 0x0031BA34
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D1F9 RID: 53753 RVA: 0x0031D844 File Offset: 0x0031BA44
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003409 RID: 13321
		// (get) Token: 0x0600D1FA RID: 53754 RVA: 0x0031D85C File Offset: 0x0031BA5C
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

		// Token: 0x0600D1FB RID: 53755 RVA: 0x0031D894 File Offset: 0x0031BA94
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D1FC RID: 53756 RVA: 0x0031D8A4 File Offset: 0x0031BAA4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D1FD RID: 53757 RVA: 0x0031D8BC File Offset: 0x0031BABC
		public string DescParam(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700340A RID: 13322
		// (get) Token: 0x0600D1FE RID: 53758 RVA: 0x0031D8F8 File Offset: 0x0031BAF8
		public int DescParamLength
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

		// Token: 0x1700340B RID: 13323
		// (get) Token: 0x0600D1FF RID: 53759 RVA: 0x0031D924 File Offset: 0x0031BB24
		public string DetailDesc
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

		// Token: 0x0600D200 RID: 53760 RVA: 0x0031D95C File Offset: 0x0031BB5C
		public Span<byte> GetDetailDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D201 RID: 53761 RVA: 0x0031D96C File Offset: 0x0031BB6C
		public byte[] GetDetailDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700340C RID: 13324
		// (get) Token: 0x0600D202 RID: 53762 RVA: 0x0031D984 File Offset: 0x0031BB84
		public int SubPropExtraRate
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

		// Token: 0x0600D203 RID: 53763 RVA: 0x0031D9C1 File Offset: 0x0031BBC1
		[NullableContext(1)]
		public string[] DescParam()
		{
			return this.DescParamIter().ToArray<string>();
		}

		// Token: 0x0600D204 RID: 53764 RVA: 0x0031D9CE File Offset: 0x0031BBCE
		[NullableContext(1)]
		public IEnumerable<string> DescParamIter()
		{
			RoleTowerEchoLevel.<DescParamIter>d__34 <DescParamIter>d__ = new RoleTowerEchoLevel.<DescParamIter>d__34(-2);
			<DescParamIter>d__.<>3__<>4__this = this;
			return <DescParamIter>d__;
		}

		// Token: 0x04005752 RID: 22354
		private Table __p;
	}
}
