using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005091 RID: 20625
	public struct ICompareFishingTechLevel : IFlatbufferObject
	{
		// Token: 0x170093AD RID: 37805
		// (get) Token: 0x0602044C RID: 132172 RVA: 0x00478934 File Offset: 0x00476B34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602044D RID: 132173 RVA: 0x00478941 File Offset: 0x00476B41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602044E RID: 132174 RVA: 0x00478948 File Offset: 0x00476B48
		public static ICompareFishingTechLevel GetRootAsICompareFishingTechLevel(ByteBuffer _bb)
		{
			return ICompareFishingTechLevel.GetRootAsICompareFishingTechLevel(_bb, default(ICompareFishingTechLevel));
		}

		// Token: 0x0602044F RID: 132175 RVA: 0x00478964 File Offset: 0x00476B64
		public static ICompareFishingTechLevel GetRootAsICompareFishingTechLevel(ByteBuffer _bb, ICompareFishingTechLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020450 RID: 132176 RVA: 0x00478981 File Offset: 0x00476B81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020451 RID: 132177 RVA: 0x00478990 File Offset: 0x00476B90
		public ICompareFishingTechLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093AE RID: 37806
		// (get) Token: 0x06020452 RID: 132178 RVA: 0x004789A0 File Offset: 0x00476BA0
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170093AF RID: 37807
		// (get) Token: 0x06020453 RID: 132179 RVA: 0x004789DC File Offset: 0x00476BDC
		public int TechId
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

		// Token: 0x170093B0 RID: 37808
		// (get) Token: 0x06020454 RID: 132180 RVA: 0x00478A18 File Offset: 0x00476C18
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170093B1 RID: 37809
		// (get) Token: 0x06020455 RID: 132181 RVA: 0x00478A54 File Offset: 0x00476C54
		public int TechLevel
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

		// Token: 0x06020456 RID: 132182 RVA: 0x00478A91 File Offset: 0x00476C91
		public static Offset<ICompareFishingTechLevel> CreateICompareFishingTechLevel(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int TechId = 0, ECompare Compare = ECompare.Eq, int TechLevel = 0)
		{
			builder.StartTable(4);
			ICompareFishingTechLevel.AddTechLevel(builder, TechLevel);
			ICompareFishingTechLevel.AddTechId(builder, TechId);
			ICompareFishingTechLevel.AddCompare(builder, Compare);
			ICompareFishingTechLevel.AddType(builder, Type);
			return ICompareFishingTechLevel.EndICompareFishingTechLevel(builder);
		}

		// Token: 0x06020457 RID: 132183 RVA: 0x00478ABD File Offset: 0x00476CBD
		public static void StartICompareFishingTechLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020458 RID: 132184 RVA: 0x00478AC6 File Offset: 0x00476CC6
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020459 RID: 132185 RVA: 0x00478AD1 File Offset: 0x00476CD1
		public static void AddTechId(FlatBufferBuilder builder, int techId)
		{
			builder.AddInt(1, techId, 0);
		}

		// Token: 0x0602045A RID: 132186 RVA: 0x00478ADC File Offset: 0x00476CDC
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0602045B RID: 132187 RVA: 0x00478AE7 File Offset: 0x00476CE7
		public static void AddTechLevel(FlatBufferBuilder builder, int techLevel)
		{
			builder.AddInt(3, techLevel, 0);
		}

		// Token: 0x0602045C RID: 132188 RVA: 0x00478AF2 File Offset: 0x00476CF2
		public static Offset<ICompareFishingTechLevel> EndICompareFishingTechLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICompareFishingTechLevel>(builder.EndTable());
		}

		// Token: 0x0602045D RID: 132189 RVA: 0x00478B00 File Offset: 0x00476D00
		public ICompareFishingTechLevelT UnPack()
		{
			ICompareFishingTechLevelT compareFishingTechLevelT = new ICompareFishingTechLevelT();
			this.UnPackTo(compareFishingTechLevelT);
			return compareFishingTechLevelT;
		}

		// Token: 0x0602045E RID: 132190 RVA: 0x00478B1B File Offset: 0x00476D1B
		public void UnPackTo(ICompareFishingTechLevelT _o)
		{
			_o.Type = this.Type;
			_o.TechId = this.TechId;
			_o.Compare = this.Compare;
			_o.TechLevel = this.TechLevel;
		}

		// Token: 0x0602045F RID: 132191 RVA: 0x00478B50 File Offset: 0x00476D50
		public static Offset<ICompareFishingTechLevel> Pack(FlatBufferBuilder builder, ICompareFishingTechLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareFishingTechLevel>);
			}
			return ICompareFishingTechLevel.CreateICompareFishingTechLevel(builder, _o.Type, _o.TechId, _o.Compare, _o.TechLevel);
		}

		// Token: 0x0400DF8B RID: 57227
		private Table __p;
	}
}
