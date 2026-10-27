using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED5 RID: 3797
	public struct PhantomBattleMapParam : IFlatbufferObject
	{
		// Token: 0x1700265C RID: 9820
		// (get) Token: 0x0600A772 RID: 42866 RVA: 0x002B0A0D File Offset: 0x002AEC0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A773 RID: 42867 RVA: 0x002B0A1A File Offset: 0x002AEC1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A774 RID: 42868 RVA: 0x002B0A24 File Offset: 0x002AEC24
		public static PhantomBattleMapParam GetRootAsPhantomBattleMapParam(ByteBuffer _bb)
		{
			return PhantomBattleMapParam.GetRootAsPhantomBattleMapParam(_bb, default(PhantomBattleMapParam));
		}

		// Token: 0x0600A775 RID: 42869 RVA: 0x002B0A40 File Offset: 0x002AEC40
		public static PhantomBattleMapParam GetRootAsPhantomBattleMapParam(ByteBuffer _bb, PhantomBattleMapParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A776 RID: 42870 RVA: 0x002B0A5D File Offset: 0x002AEC5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A777 RID: 42871 RVA: 0x002B0A6C File Offset: 0x002AEC6C
		public PhantomBattleMapParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700265D RID: 9821
		// (get) Token: 0x0600A778 RID: 42872 RVA: 0x002B0A7C File Offset: 0x002AEC7C
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

		// Token: 0x1700265E RID: 9822
		// (get) Token: 0x0600A779 RID: 42873 RVA: 0x002B0AB8 File Offset: 0x002AECB8
		public int MapId
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

		// Token: 0x1700265F RID: 9823
		// (get) Token: 0x0600A77A RID: 42874 RVA: 0x002B0AF4 File Offset: 0x002AECF4
		public int BigMapDefaultScale
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

		// Token: 0x17002660 RID: 9824
		// (get) Token: 0x0600A77B RID: 42875 RVA: 0x002B0B30 File Offset: 0x002AED30
		public int BigMapMinScale
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

		// Token: 0x17002661 RID: 9825
		// (get) Token: 0x0600A77C RID: 42876 RVA: 0x002B0B70 File Offset: 0x002AED70
		public int BigMapMaxScale
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

		// Token: 0x0600A77D RID: 42877 RVA: 0x002B0BB0 File Offset: 0x002AEDB0
		public string TileRange(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002662 RID: 9826
		// (get) Token: 0x0600A77E RID: 42878 RVA: 0x002B0BEC File Offset: 0x002AEDEC
		public int TileRangeLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002663 RID: 9827
		// (get) Token: 0x0600A77F RID: 42879 RVA: 0x002B0C18 File Offset: 0x002AEE18
		public string MapName
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

		// Token: 0x0600A780 RID: 42880 RVA: 0x002B0C50 File Offset: 0x002AEE50
		public Span<byte> GetMapNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A781 RID: 42881 RVA: 0x002B0C60 File Offset: 0x002AEE60
		public byte[] GetMapNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A782 RID: 42882 RVA: 0x002B0C78 File Offset: 0x002AEE78
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TileRangeIter()或GetTileRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TileRange()
		{
			return this.TileRangeIter().ToArray<string>();
		}

		// Token: 0x0600A783 RID: 42883 RVA: 0x002B0C85 File Offset: 0x002AEE85
		[NullableContext(1)]
		public readonly IEnumerable<string> TileRangeIter()
		{
			PhantomBattleMapParam.<TileRangeIter>d__26 <TileRangeIter>d__ = new PhantomBattleMapParam.<TileRangeIter>d__26(-2);
			<TileRangeIter>d__.<>3__<>4__this = this;
			return <TileRangeIter>d__;
		}

		// Token: 0x04004F93 RID: 20371
		private Table __p;
	}
}
