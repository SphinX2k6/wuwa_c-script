using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D3D RID: 32061
	public struct IVillageInfrVillageLevel : IFlatbufferObject
	{
		// Token: 0x1700EFF3 RID: 61427
		// (get) Token: 0x06039E0A RID: 237066 RVA: 0x007CEC66 File Offset: 0x007CCE66
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039E0B RID: 237067 RVA: 0x007CEC73 File Offset: 0x007CCE73
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039E0C RID: 237068 RVA: 0x007CEC7C File Offset: 0x007CCE7C
		public static IVillageInfrVillageLevel GetRootAsIVillageInfrVillageLevel(ByteBuffer _bb)
		{
			return IVillageInfrVillageLevel.GetRootAsIVillageInfrVillageLevel(_bb, default(IVillageInfrVillageLevel));
		}

		// Token: 0x06039E0D RID: 237069 RVA: 0x007CEC98 File Offset: 0x007CCE98
		public static IVillageInfrVillageLevel GetRootAsIVillageInfrVillageLevel(ByteBuffer _bb, IVillageInfrVillageLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039E0E RID: 237070 RVA: 0x007CECB5 File Offset: 0x007CCEB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039E0F RID: 237071 RVA: 0x007CECC4 File Offset: 0x007CCEC4
		public IVillageInfrVillageLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EFF4 RID: 61428
		// (get) Token: 0x06039E10 RID: 237072 RVA: 0x007CECD4 File Offset: 0x007CCED4
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

		// Token: 0x1700EFF5 RID: 61429
		// (get) Token: 0x06039E11 RID: 237073 RVA: 0x007CED10 File Offset: 0x007CCF10
		public int Level
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

		// Token: 0x06039E12 RID: 237074 RVA: 0x007CED4C File Offset: 0x007CCF4C
		public static Offset<IVillageInfrVillageLevel> CreateIVillageInfrVillageLevel(FlatBufferBuilder builder, EVillageInfrBuildType Type = EVillageInfrBuildType.Village, int Level = 0)
		{
			builder.StartTable(2);
			IVillageInfrVillageLevel.AddLevel(builder, Level);
			IVillageInfrVillageLevel.AddType(builder, Type);
			return IVillageInfrVillageLevel.EndIVillageInfrVillageLevel(builder);
		}

		// Token: 0x06039E13 RID: 237075 RVA: 0x007CED69 File Offset: 0x007CCF69
		public static void StartIVillageInfrVillageLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039E14 RID: 237076 RVA: 0x007CED72 File Offset: 0x007CCF72
		public static void AddType(FlatBufferBuilder builder, EVillageInfrBuildType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039E15 RID: 237077 RVA: 0x007CED7D File Offset: 0x007CCF7D
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(1, level, 0);
		}

		// Token: 0x06039E16 RID: 237078 RVA: 0x007CED88 File Offset: 0x007CCF88
		public static Offset<IVillageInfrVillageLevel> EndIVillageInfrVillageLevel(FlatBufferBuilder builder)
		{
			return new Offset<IVillageInfrVillageLevel>(builder.EndTable());
		}

		// Token: 0x06039E17 RID: 237079 RVA: 0x007CED98 File Offset: 0x007CCF98
		public IVillageInfrVillageLevelT UnPack()
		{
			IVillageInfrVillageLevelT villageInfrVillageLevelT = new IVillageInfrVillageLevelT();
			this.UnPackTo(villageInfrVillageLevelT);
			return villageInfrVillageLevelT;
		}

		// Token: 0x06039E18 RID: 237080 RVA: 0x007CEDB3 File Offset: 0x007CCFB3
		public void UnPackTo(IVillageInfrVillageLevelT _o)
		{
			_o.Type = this.Type;
			_o.Level = this.Level;
		}

		// Token: 0x06039E19 RID: 237081 RVA: 0x007CEDD0 File Offset: 0x007CCFD0
		public static Offset<IVillageInfrVillageLevel> Pack(FlatBufferBuilder builder, IVillageInfrVillageLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVillageInfrVillageLevel>);
			}
			return IVillageInfrVillageLevel.CreateIVillageInfrVillageLevel(builder, _o.Type, _o.Level);
		}

		// Token: 0x0401346E RID: 78958
		private Table __p;
	}
}
