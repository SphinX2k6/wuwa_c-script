using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E4 RID: 21988
	public struct INavMeshAkiEntitySource : IFlatbufferObject
	{
		// Token: 0x1700A2B6 RID: 41654
		// (get) Token: 0x060247A3 RID: 149411 RVA: 0x005091A7 File Offset: 0x005073A7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060247A4 RID: 149412 RVA: 0x005091B4 File Offset: 0x005073B4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060247A5 RID: 149413 RVA: 0x005091BC File Offset: 0x005073BC
		public static INavMeshAkiEntitySource GetRootAsINavMeshAkiEntitySource(ByteBuffer _bb)
		{
			return INavMeshAkiEntitySource.GetRootAsINavMeshAkiEntitySource(_bb, default(INavMeshAkiEntitySource));
		}

		// Token: 0x060247A6 RID: 149414 RVA: 0x005091D8 File Offset: 0x005073D8
		public static INavMeshAkiEntitySource GetRootAsINavMeshAkiEntitySource(ByteBuffer _bb, INavMeshAkiEntitySource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060247A7 RID: 149415 RVA: 0x005091F5 File Offset: 0x005073F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060247A8 RID: 149416 RVA: 0x00509204 File Offset: 0x00507404
		public INavMeshAkiEntitySource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2B7 RID: 41655
		// (get) Token: 0x060247A9 RID: 149417 RVA: 0x00509214 File Offset: 0x00507414
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

		// Token: 0x1700A2B8 RID: 41656
		// (get) Token: 0x060247AA RID: 149418 RVA: 0x00509250 File Offset: 0x00507450
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

		// Token: 0x060247AB RID: 149419 RVA: 0x0050928C File Offset: 0x0050748C
		public static Offset<INavMeshAkiEntitySource> CreateINavMeshAkiEntitySource(FlatBufferBuilder builder, ENavMeshSourceType Type = ENavMeshSourceType.AkiEntitySource, int SourceId = 0)
		{
			builder.StartTable(2);
			INavMeshAkiEntitySource.AddSourceId(builder, SourceId);
			INavMeshAkiEntitySource.AddType(builder, Type);
			return INavMeshAkiEntitySource.EndINavMeshAkiEntitySource(builder);
		}

		// Token: 0x060247AC RID: 149420 RVA: 0x005092A9 File Offset: 0x005074A9
		public static void StartINavMeshAkiEntitySource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060247AD RID: 149421 RVA: 0x005092B2 File Offset: 0x005074B2
		public static void AddType(FlatBufferBuilder builder, ENavMeshSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060247AE RID: 149422 RVA: 0x005092BD File Offset: 0x005074BD
		public static void AddSourceId(FlatBufferBuilder builder, int sourceId)
		{
			builder.AddInt(1, sourceId, 0);
		}

		// Token: 0x060247AF RID: 149423 RVA: 0x005092C8 File Offset: 0x005074C8
		public static Offset<INavMeshAkiEntitySource> EndINavMeshAkiEntitySource(FlatBufferBuilder builder)
		{
			return new Offset<INavMeshAkiEntitySource>(builder.EndTable());
		}

		// Token: 0x060247B0 RID: 149424 RVA: 0x005092D8 File Offset: 0x005074D8
		public INavMeshAkiEntitySourceT UnPack()
		{
			INavMeshAkiEntitySourceT navMeshAkiEntitySourceT = new INavMeshAkiEntitySourceT();
			this.UnPackTo(navMeshAkiEntitySourceT);
			return navMeshAkiEntitySourceT;
		}

		// Token: 0x060247B1 RID: 149425 RVA: 0x005092F3 File Offset: 0x005074F3
		public void UnPackTo(INavMeshAkiEntitySourceT _o)
		{
			_o.Type = this.Type;
			_o.SourceId = this.SourceId;
		}

		// Token: 0x060247B2 RID: 149426 RVA: 0x00509310 File Offset: 0x00507510
		public static Offset<INavMeshAkiEntitySource> Pack(FlatBufferBuilder builder, INavMeshAkiEntitySourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<INavMeshAkiEntitySource>);
			}
			return INavMeshAkiEntitySource.CreateINavMeshAkiEntitySource(builder, _o.Type, _o.SourceId);
		}

		// Token: 0x0400E94E RID: 59726
		private Table __p;
	}
}
