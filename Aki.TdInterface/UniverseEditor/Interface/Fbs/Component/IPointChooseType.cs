using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005751 RID: 22353
	public struct IPointChooseType : IFlatbufferObject
	{
		// Token: 0x1700A6C7 RID: 42695
		// (get) Token: 0x06025759 RID: 153433 RVA: 0x0052B324 File Offset: 0x00529524
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602575A RID: 153434 RVA: 0x0052B331 File Offset: 0x00529531
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602575B RID: 153435 RVA: 0x0052B338 File Offset: 0x00529538
		public static IPointChooseType GetRootAsIPointChooseType(ByteBuffer _bb)
		{
			return IPointChooseType.GetRootAsIPointChooseType(_bb, default(IPointChooseType));
		}

		// Token: 0x0602575C RID: 153436 RVA: 0x0052B354 File Offset: 0x00529554
		public static IPointChooseType GetRootAsIPointChooseType(ByteBuffer _bb, IPointChooseType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602575D RID: 153437 RVA: 0x0052B371 File Offset: 0x00529571
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602575E RID: 153438 RVA: 0x0052B380 File Offset: 0x00529580
		public IPointChooseType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6C8 RID: 42696
		// (get) Token: 0x0602575F RID: 153439 RVA: 0x0052B390 File Offset: 0x00529590
		public EPointChooseType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPointChooseType.SpawnMonsterPoint;
				}
				return (EPointChooseType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025760 RID: 153440 RVA: 0x0052B3CC File Offset: 0x005295CC
		public static Offset<IPointChooseType> CreateIPointChooseType(FlatBufferBuilder builder, EPointChooseType Type = EPointChooseType.SpawnMonsterPoint)
		{
			builder.StartTable(1);
			IPointChooseType.AddType(builder, Type);
			return IPointChooseType.EndIPointChooseType(builder);
		}

		// Token: 0x06025761 RID: 153441 RVA: 0x0052B3E2 File Offset: 0x005295E2
		public static void StartIPointChooseType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025762 RID: 153442 RVA: 0x0052B3EB File Offset: 0x005295EB
		public static void AddType(FlatBufferBuilder builder, EPointChooseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025763 RID: 153443 RVA: 0x0052B3F6 File Offset: 0x005295F6
		public static Offset<IPointChooseType> EndIPointChooseType(FlatBufferBuilder builder)
		{
			return new Offset<IPointChooseType>(builder.EndTable());
		}

		// Token: 0x06025764 RID: 153444 RVA: 0x0052B404 File Offset: 0x00529604
		public IPointChooseTypeT UnPack()
		{
			IPointChooseTypeT pointChooseTypeT = new IPointChooseTypeT();
			this.UnPackTo(pointChooseTypeT);
			return pointChooseTypeT;
		}

		// Token: 0x06025765 RID: 153445 RVA: 0x0052B41F File Offset: 0x0052961F
		public void UnPackTo(IPointChooseTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025766 RID: 153446 RVA: 0x0052B430 File Offset: 0x00529630
		public static Offset<IPointChooseType> Pack(FlatBufferBuilder builder, IPointChooseTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPointChooseType>);
			}
			return IPointChooseType.CreateIPointChooseType(builder, _o.Type);
		}

		// Token: 0x0400EBF0 RID: 60400
		private Table __p;
	}
}
