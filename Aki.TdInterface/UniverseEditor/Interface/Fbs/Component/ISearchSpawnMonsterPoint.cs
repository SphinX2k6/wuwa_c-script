using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F01 RID: 24321
	public struct ISearchSpawnMonsterPoint : IFlatbufferObject
	{
		// Token: 0x1700B3D9 RID: 46041
		// (get) Token: 0x06028CE6 RID: 167142 RVA: 0x00593B94 File Offset: 0x00591D94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028CE7 RID: 167143 RVA: 0x00593BA1 File Offset: 0x00591DA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028CE8 RID: 167144 RVA: 0x00593BA8 File Offset: 0x00591DA8
		public static ISearchSpawnMonsterPoint GetRootAsISearchSpawnMonsterPoint(ByteBuffer _bb)
		{
			return ISearchSpawnMonsterPoint.GetRootAsISearchSpawnMonsterPoint(_bb, default(ISearchSpawnMonsterPoint));
		}

		// Token: 0x06028CE9 RID: 167145 RVA: 0x00593BC4 File Offset: 0x00591DC4
		public static ISearchSpawnMonsterPoint GetRootAsISearchSpawnMonsterPoint(ByteBuffer _bb, ISearchSpawnMonsterPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028CEA RID: 167146 RVA: 0x00593BE1 File Offset: 0x00591DE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028CEB RID: 167147 RVA: 0x00593BF0 File Offset: 0x00591DF0
		public ISearchSpawnMonsterPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3DA RID: 46042
		// (get) Token: 0x06028CEC RID: 167148 RVA: 0x00593C00 File Offset: 0x00591E00
		public ERangeConstraint Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERangeConstraint.SearchSpawnMonsterPoint;
				}
				return (ERangeConstraint)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3DB RID: 46043
		// (get) Token: 0x06028CED RID: 167149 RVA: 0x00593C3C File Offset: 0x00591E3C
		public int Radius
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

		// Token: 0x1700B3DC RID: 46044
		// (get) Token: 0x06028CEE RID: 167150 RVA: 0x00593C78 File Offset: 0x00591E78
		public int TagId
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

		// Token: 0x1700B3DD RID: 46045
		// (get) Token: 0x06028CEF RID: 167151 RVA: 0x00593CB4 File Offset: 0x00591EB4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028CF0 RID: 167152 RVA: 0x00593CF1 File Offset: 0x00591EF1
		public static Offset<ISearchSpawnMonsterPoint> CreateISearchSpawnMonsterPoint(FlatBufferBuilder builder, ERangeConstraint Type = ERangeConstraint.SearchSpawnMonsterPoint, int Radius = 0, int TagId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISearchSpawnMonsterPoint.AddTagId(builder, TagId);
			ISearchSpawnMonsterPoint.AddRadius(builder, Radius);
			ISearchSpawnMonsterPoint.AddNullMask(builder, NullMask);
			ISearchSpawnMonsterPoint.AddType(builder, Type);
			return ISearchSpawnMonsterPoint.EndISearchSpawnMonsterPoint(builder);
		}

		// Token: 0x06028CF1 RID: 167153 RVA: 0x00593D1D File Offset: 0x00591F1D
		public static void StartISearchSpawnMonsterPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06028CF2 RID: 167154 RVA: 0x00593D26 File Offset: 0x00591F26
		public static void AddType(FlatBufferBuilder builder, ERangeConstraint type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028CF3 RID: 167155 RVA: 0x00593D31 File Offset: 0x00591F31
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(1, radius, 0);
		}

		// Token: 0x06028CF4 RID: 167156 RVA: 0x00593D3C File Offset: 0x00591F3C
		public static void AddTagId(FlatBufferBuilder builder, int tagId)
		{
			builder.AddInt(2, tagId, 0);
		}

		// Token: 0x06028CF5 RID: 167157 RVA: 0x00593D47 File Offset: 0x00591F47
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06028CF6 RID: 167158 RVA: 0x00593D52 File Offset: 0x00591F52
		public static Offset<ISearchSpawnMonsterPoint> EndISearchSpawnMonsterPoint(FlatBufferBuilder builder)
		{
			return new Offset<ISearchSpawnMonsterPoint>(builder.EndTable());
		}

		// Token: 0x06028CF7 RID: 167159 RVA: 0x00593D60 File Offset: 0x00591F60
		public ISearchSpawnMonsterPointT UnPack()
		{
			ISearchSpawnMonsterPointT searchSpawnMonsterPointT = new ISearchSpawnMonsterPointT();
			this.UnPackTo(searchSpawnMonsterPointT);
			return searchSpawnMonsterPointT;
		}

		// Token: 0x06028CF8 RID: 167160 RVA: 0x00593D7B File Offset: 0x00591F7B
		public void UnPackTo(ISearchSpawnMonsterPointT _o)
		{
			_o.Type = this.Type;
			_o.Radius = this.Radius;
			_o.TagId = this.TagId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028CF9 RID: 167161 RVA: 0x00593DB0 File Offset: 0x00591FB0
		public static Offset<ISearchSpawnMonsterPoint> Pack(FlatBufferBuilder builder, ISearchSpawnMonsterPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISearchSpawnMonsterPoint>);
			}
			return ISearchSpawnMonsterPoint.CreateISearchSpawnMonsterPoint(builder, _o.Type, _o.Radius, _o.TagId, _o.NullMask);
		}

		// Token: 0x0400FB82 RID: 64386
		private Table __p;
	}
}
