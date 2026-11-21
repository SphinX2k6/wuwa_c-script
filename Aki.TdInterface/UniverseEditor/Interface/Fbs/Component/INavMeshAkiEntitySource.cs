using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B82 RID: 23426
	public struct INavMeshAkiEntitySource : IFlatbufferObject
	{
		// Token: 0x1700AB3E RID: 43838
		// (get) Token: 0x060269B0 RID: 158128 RVA: 0x0054971F File Offset: 0x0054791F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060269B1 RID: 158129 RVA: 0x0054972C File Offset: 0x0054792C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060269B2 RID: 158130 RVA: 0x00549734 File Offset: 0x00547934
		public static INavMeshAkiEntitySource GetRootAsINavMeshAkiEntitySource(ByteBuffer _bb)
		{
			return INavMeshAkiEntitySource.GetRootAsINavMeshAkiEntitySource(_bb, default(INavMeshAkiEntitySource));
		}

		// Token: 0x060269B3 RID: 158131 RVA: 0x00549750 File Offset: 0x00547950
		public static INavMeshAkiEntitySource GetRootAsINavMeshAkiEntitySource(ByteBuffer _bb, INavMeshAkiEntitySource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060269B4 RID: 158132 RVA: 0x0054976D File Offset: 0x0054796D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060269B5 RID: 158133 RVA: 0x0054977C File Offset: 0x0054797C
		public INavMeshAkiEntitySource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB3F RID: 43839
		// (get) Token: 0x060269B6 RID: 158134 RVA: 0x0054978C File Offset: 0x0054798C
		public ENavMeshSourceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENavMeshSourceType.AkiEntitySource;
				}
				return (ENavMeshSourceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AB40 RID: 43840
		// (get) Token: 0x060269B7 RID: 158135 RVA: 0x005497C8 File Offset: 0x005479C8
		public int SourceId
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

		// Token: 0x060269B8 RID: 158136 RVA: 0x00549804 File Offset: 0x00547A04
		public static Offset<INavMeshAkiEntitySource> CreateINavMeshAkiEntitySource(FlatBufferBuilder builder, ENavMeshSourceType Type = ENavMeshSourceType.AkiEntitySource, int SourceId = 0)
		{
			builder.StartTable(2);
			INavMeshAkiEntitySource.AddSourceId(builder, SourceId);
			INavMeshAkiEntitySource.AddType(builder, Type);
			return INavMeshAkiEntitySource.EndINavMeshAkiEntitySource(builder);
		}

		// Token: 0x060269B9 RID: 158137 RVA: 0x00549821 File Offset: 0x00547A21
		public static void StartINavMeshAkiEntitySource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060269BA RID: 158138 RVA: 0x0054982A File Offset: 0x00547A2A
		public static void AddType(FlatBufferBuilder builder, ENavMeshSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060269BB RID: 158139 RVA: 0x00549835 File Offset: 0x00547A35
		public static void AddSourceId(FlatBufferBuilder builder, int sourceId)
		{
			builder.AddInt(1, sourceId, 0);
		}

		// Token: 0x060269BC RID: 158140 RVA: 0x00549840 File Offset: 0x00547A40
		public static Offset<INavMeshAkiEntitySource> EndINavMeshAkiEntitySource(FlatBufferBuilder builder)
		{
			return new Offset<INavMeshAkiEntitySource>(builder.EndTable());
		}

		// Token: 0x060269BD RID: 158141 RVA: 0x00549850 File Offset: 0x00547A50
		public INavMeshAkiEntitySourceT UnPack()
		{
			INavMeshAkiEntitySourceT navMeshAkiEntitySourceT = new INavMeshAkiEntitySourceT();
			this.UnPackTo(navMeshAkiEntitySourceT);
			return navMeshAkiEntitySourceT;
		}

		// Token: 0x060269BE RID: 158142 RVA: 0x0054986B File Offset: 0x00547A6B
		public void UnPackTo(INavMeshAkiEntitySourceT _o)
		{
			_o.Type = this.Type;
			_o.SourceId = this.SourceId;
		}

		// Token: 0x060269BF RID: 158143 RVA: 0x00549888 File Offset: 0x00547A88
		public static Offset<INavMeshAkiEntitySource> Pack(FlatBufferBuilder builder, INavMeshAkiEntitySourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<INavMeshAkiEntitySource>);
			}
			return INavMeshAkiEntitySource.CreateINavMeshAkiEntitySource(builder, _o.Type, _o.SourceId);
		}

		// Token: 0x0400F5B0 RID: 62896
		private Table __p;
	}
}
