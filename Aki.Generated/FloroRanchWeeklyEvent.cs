using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC1 RID: 3265
	public struct FloroRanchWeeklyEvent : IFlatbufferObject
	{
		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x06007540 RID: 30016 RVA: 0x0023F96B File Offset: 0x0023DB6B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007541 RID: 30017 RVA: 0x0023F978 File Offset: 0x0023DB78
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007542 RID: 30018 RVA: 0x0023F980 File Offset: 0x0023DB80
		public static FloroRanchWeeklyEvent GetRootAsFloroRanchWeeklyEvent(ByteBuffer _bb)
		{
			return FloroRanchWeeklyEvent.GetRootAsFloroRanchWeeklyEvent(_bb, default(FloroRanchWeeklyEvent));
		}

		// Token: 0x06007543 RID: 30019 RVA: 0x0023F99C File Offset: 0x0023DB9C
		public static FloroRanchWeeklyEvent GetRootAsFloroRanchWeeklyEvent(ByteBuffer _bb, FloroRanchWeeklyEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007544 RID: 30020 RVA: 0x0023F9B9 File Offset: 0x0023DBB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007545 RID: 30021 RVA: 0x0023F9C8 File Offset: 0x0023DBC8
		public FloroRanchWeeklyEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x06007546 RID: 30022 RVA: 0x0023F9D8 File Offset: 0x0023DBD8
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

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06007547 RID: 30023 RVA: 0x0023FA14 File Offset: 0x0023DC14
		public string Title
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

		// Token: 0x06007548 RID: 30024 RVA: 0x0023FA4B File Offset: 0x0023DC4B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007549 RID: 30025 RVA: 0x0023FA5A File Offset: 0x0023DC5A
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x0600754A RID: 30026 RVA: 0x0023FA74 File Offset: 0x0023DC74
		public string Desc
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

		// Token: 0x0600754B RID: 30027 RVA: 0x0023FAAB File Offset: 0x0023DCAB
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600754C RID: 30028 RVA: 0x0023FABA File Offset: 0x0023DCBA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D31 RID: 19761
		private Table __p;
	}
}
