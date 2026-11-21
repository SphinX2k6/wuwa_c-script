using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D3A RID: 32058
	public struct IVillageInfrTreeProcess : IFlatbufferObject
	{
		// Token: 0x1700EFEE RID: 61422
		// (get) Token: 0x06039DF4 RID: 237044 RVA: 0x007CEA68 File Offset: 0x007CCC68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039DF5 RID: 237045 RVA: 0x007CEA75 File Offset: 0x007CCC75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039DF6 RID: 237046 RVA: 0x007CEA7C File Offset: 0x007CCC7C
		public static IVillageInfrTreeProcess GetRootAsIVillageInfrTreeProcess(ByteBuffer _bb)
		{
			return IVillageInfrTreeProcess.GetRootAsIVillageInfrTreeProcess(_bb, default(IVillageInfrTreeProcess));
		}

		// Token: 0x06039DF7 RID: 237047 RVA: 0x007CEA98 File Offset: 0x007CCC98
		public static IVillageInfrTreeProcess GetRootAsIVillageInfrTreeProcess(ByteBuffer _bb, IVillageInfrTreeProcess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039DF8 RID: 237048 RVA: 0x007CEAB5 File Offset: 0x007CCCB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039DF9 RID: 237049 RVA: 0x007CEAC4 File Offset: 0x007CCCC4
		public IVillageInfrTreeProcess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EFEF RID: 61423
		// (get) Token: 0x06039DFA RID: 237050 RVA: 0x007CEAD4 File Offset: 0x007CCCD4
		public EVillageInfrBuildType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVillageInfrBuildType.Village;
				}
				return (EVillageInfrBuildType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EFF0 RID: 61424
		// (get) Token: 0x06039DFB RID: 237051 RVA: 0x007CEB10 File Offset: 0x007CCD10
		public int Id
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

		// Token: 0x06039DFC RID: 237052 RVA: 0x007CEB4C File Offset: 0x007CCD4C
		public static Offset<IVillageInfrTreeProcess> CreateIVillageInfrTreeProcess(FlatBufferBuilder builder, EVillageInfrBuildType Type = EVillageInfrBuildType.Village, int Id = 0)
		{
			builder.StartTable(2);
			IVillageInfrTreeProcess.AddId(builder, Id);
			IVillageInfrTreeProcess.AddType(builder, Type);
			return IVillageInfrTreeProcess.EndIVillageInfrTreeProcess(builder);
		}

		// Token: 0x06039DFD RID: 237053 RVA: 0x007CEB69 File Offset: 0x007CCD69
		public static void StartIVillageInfrTreeProcess(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039DFE RID: 237054 RVA: 0x007CEB72 File Offset: 0x007CCD72
		public static void AddType(FlatBufferBuilder builder, EVillageInfrBuildType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039DFF RID: 237055 RVA: 0x007CEB7D File Offset: 0x007CCD7D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06039E00 RID: 237056 RVA: 0x007CEB88 File Offset: 0x007CCD88
		public static Offset<IVillageInfrTreeProcess> EndIVillageInfrTreeProcess(FlatBufferBuilder builder)
		{
			return new Offset<IVillageInfrTreeProcess>(builder.EndTable());
		}

		// Token: 0x06039E01 RID: 237057 RVA: 0x007CEB98 File Offset: 0x007CCD98
		public IVillageInfrTreeProcessT UnPack()
		{
			IVillageInfrTreeProcessT villageInfrTreeProcessT = new IVillageInfrTreeProcessT();
			this.UnPackTo(villageInfrTreeProcessT);
			return villageInfrTreeProcessT;
		}

		// Token: 0x06039E02 RID: 237058 RVA: 0x007CEBB3 File Offset: 0x007CCDB3
		public void UnPackTo(IVillageInfrTreeProcessT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06039E03 RID: 237059 RVA: 0x007CEBD0 File Offset: 0x007CCDD0
		public static Offset<IVillageInfrTreeProcess> Pack(FlatBufferBuilder builder, IVillageInfrTreeProcessT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVillageInfrTreeProcess>);
			}
			return IVillageInfrTreeProcess.CreateIVillageInfrTreeProcess(builder, _o.Type, _o.Id);
		}

		// Token: 0x0401346B RID: 78955
		private Table __p;
	}
}
