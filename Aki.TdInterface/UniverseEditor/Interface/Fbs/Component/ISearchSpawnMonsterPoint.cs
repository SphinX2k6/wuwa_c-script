using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058F4 RID: 22772
	public struct ISearchSpawnMonsterPoint : IFlatbufferObject
	{
		// Token: 0x1700AAA5 RID: 43685
		// (get) Token: 0x0602677C RID: 157564 RVA: 0x0054CF28 File Offset: 0x0054B128
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602677D RID: 157565 RVA: 0x0054CF35 File Offset: 0x0054B135
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602677E RID: 157566 RVA: 0x0054CF3C File Offset: 0x0054B13C
		public static ISearchSpawnMonsterPoint GetRootAsISearchSpawnMonsterPoint(ByteBuffer _bb)
		{
			return ISearchSpawnMonsterPoint.GetRootAsISearchSpawnMonsterPoint(_bb, default(ISearchSpawnMonsterPoint));
		}

		// Token: 0x0602677F RID: 157567 RVA: 0x0054CF58 File Offset: 0x0054B158
		public static ISearchSpawnMonsterPoint GetRootAsISearchSpawnMonsterPoint(ByteBuffer _bb, ISearchSpawnMonsterPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026780 RID: 157568 RVA: 0x0054CF75 File Offset: 0x0054B175
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026781 RID: 157569 RVA: 0x0054CF84 File Offset: 0x0054B184
		public ISearchSpawnMonsterPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AAA6 RID: 43686
		// (get) Token: 0x06026782 RID: 157570 RVA: 0x0054CF94 File Offset: 0x0054B194
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

		// Token: 0x1700AAA7 RID: 43687
		// (get) Token: 0x06026783 RID: 157571 RVA: 0x0054CFD0 File Offset: 0x0054B1D0
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

		// Token: 0x1700AAA8 RID: 43688
		// (get) Token: 0x06026784 RID: 157572 RVA: 0x0054D00C File Offset: 0x0054B20C
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

		// Token: 0x1700AAA9 RID: 43689
		// (get) Token: 0x06026785 RID: 157573 RVA: 0x0054D048 File Offset: 0x0054B248
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

		// Token: 0x06026786 RID: 157574 RVA: 0x0054D085 File Offset: 0x0054B285
		public static Offset<ISearchSpawnMonsterPoint> CreateISearchSpawnMonsterPoint(FlatBufferBuilder builder, ERangeConstraint Type = ERangeConstraint.SearchSpawnMonsterPoint, int Radius = 0, int TagId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISearchSpawnMonsterPoint.AddTagId(builder, TagId);
			ISearchSpawnMonsterPoint.AddRadius(builder, Radius);
			ISearchSpawnMonsterPoint.AddNullMask(builder, NullMask);
			ISearchSpawnMonsterPoint.AddType(builder, Type);
			return ISearchSpawnMonsterPoint.EndISearchSpawnMonsterPoint(builder);
		}

		// Token: 0x06026787 RID: 157575 RVA: 0x0054D0B1 File Offset: 0x0054B2B1
		public static void StartISearchSpawnMonsterPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06026788 RID: 157576 RVA: 0x0054D0BA File Offset: 0x0054B2BA
		public static void AddType(FlatBufferBuilder builder, ERangeConstraint type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026789 RID: 157577 RVA: 0x0054D0C5 File Offset: 0x0054B2C5
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(1, radius, 0);
		}

		// Token: 0x0602678A RID: 157578 RVA: 0x0054D0D0 File Offset: 0x0054B2D0
		public static void AddTagId(FlatBufferBuilder builder, int tagId)
		{
			builder.AddInt(2, tagId, 0);
		}

		// Token: 0x0602678B RID: 157579 RVA: 0x0054D0DB File Offset: 0x0054B2DB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602678C RID: 157580 RVA: 0x0054D0E6 File Offset: 0x0054B2E6
		public static Offset<ISearchSpawnMonsterPoint> EndISearchSpawnMonsterPoint(FlatBufferBuilder builder)
		{
			return new Offset<ISearchSpawnMonsterPoint>(builder.EndTable());
		}

		// Token: 0x0602678D RID: 157581 RVA: 0x0054D0F4 File Offset: 0x0054B2F4
		public ISearchSpawnMonsterPointT UnPack()
		{
			ISearchSpawnMonsterPointT searchSpawnMonsterPointT = new ISearchSpawnMonsterPointT();
			this.UnPackTo(searchSpawnMonsterPointT);
			return searchSpawnMonsterPointT;
		}

		// Token: 0x0602678E RID: 157582 RVA: 0x0054D10F File Offset: 0x0054B30F
		public void UnPackTo(ISearchSpawnMonsterPointT _o)
		{
			_o.Type = this.Type;
			_o.Radius = this.Radius;
			_o.TagId = this.TagId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602678F RID: 157583 RVA: 0x0054D144 File Offset: 0x0054B344
		public static Offset<ISearchSpawnMonsterPoint> Pack(FlatBufferBuilder builder, ISearchSpawnMonsterPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISearchSpawnMonsterPoint>);
			}
			return ISearchSpawnMonsterPoint.CreateISearchSpawnMonsterPoint(builder, _o.Type, _o.Radius, _o.TagId, _o.NullMask);
		}

		// Token: 0x0400EE8D RID: 61069
		private Table __p;
	}
}
