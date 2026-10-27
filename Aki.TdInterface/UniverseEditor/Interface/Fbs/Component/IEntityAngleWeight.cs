using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200514D RID: 20813
	public struct IEntityAngleWeight : IFlatbufferObject
	{
		// Token: 0x170097CC RID: 38860
		// (get) Token: 0x06021978 RID: 137592 RVA: 0x004A99C2 File Offset: 0x004A7BC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021979 RID: 137593 RVA: 0x004A99CF File Offset: 0x004A7BCF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602197A RID: 137594 RVA: 0x004A99D8 File Offset: 0x004A7BD8
		public static IEntityAngleWeight GetRootAsIEntityAngleWeight(ByteBuffer _bb)
		{
			return IEntityAngleWeight.GetRootAsIEntityAngleWeight(_bb, default(IEntityAngleWeight));
		}

		// Token: 0x0602197B RID: 137595 RVA: 0x004A99F4 File Offset: 0x004A7BF4
		public static IEntityAngleWeight GetRootAsIEntityAngleWeight(ByteBuffer _bb, IEntityAngleWeight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602197C RID: 137596 RVA: 0x004A9A11 File Offset: 0x004A7C11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602197D RID: 137597 RVA: 0x004A9A20 File Offset: 0x004A7C20
		public IEntityAngleWeight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097CD RID: 38861
		// (get) Token: 0x0602197E RID: 137598 RVA: 0x004A9A30 File Offset: 0x004A7C30
		public int Angle
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

		// Token: 0x170097CE RID: 38862
		// (get) Token: 0x0602197F RID: 137599 RVA: 0x004A9A6C File Offset: 0x004A7C6C
		public int Weight
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

		// Token: 0x06021980 RID: 137600 RVA: 0x004A9AA8 File Offset: 0x004A7CA8
		public static Offset<IEntityAngleWeight> CreateIEntityAngleWeight(FlatBufferBuilder builder, int Angle = 0, int Weight = 0)
		{
			builder.StartTable(2);
			IEntityAngleWeight.AddWeight(builder, Weight);
			IEntityAngleWeight.AddAngle(builder, Angle);
			return IEntityAngleWeight.EndIEntityAngleWeight(builder);
		}

		// Token: 0x06021981 RID: 137601 RVA: 0x004A9AC5 File Offset: 0x004A7CC5
		public static void StartIEntityAngleWeight(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021982 RID: 137602 RVA: 0x004A9ACE File Offset: 0x004A7CCE
		public static void AddAngle(FlatBufferBuilder builder, int angle)
		{
			builder.AddInt(0, angle, 0);
		}

		// Token: 0x06021983 RID: 137603 RVA: 0x004A9AD9 File Offset: 0x004A7CD9
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(1, weight, 0);
		}

		// Token: 0x06021984 RID: 137604 RVA: 0x004A9AE4 File Offset: 0x004A7CE4
		public static Offset<IEntityAngleWeight> EndIEntityAngleWeight(FlatBufferBuilder builder)
		{
			return new Offset<IEntityAngleWeight>(builder.EndTable());
		}

		// Token: 0x06021985 RID: 137605 RVA: 0x004A9AF4 File Offset: 0x004A7CF4
		public IEntityAngleWeightT UnPack()
		{
			IEntityAngleWeightT entityAngleWeightT = new IEntityAngleWeightT();
			this.UnPackTo(entityAngleWeightT);
			return entityAngleWeightT;
		}

		// Token: 0x06021986 RID: 137606 RVA: 0x004A9B0F File Offset: 0x004A7D0F
		public void UnPackTo(IEntityAngleWeightT _o)
		{
			_o.Angle = this.Angle;
			_o.Weight = this.Weight;
		}

		// Token: 0x06021987 RID: 137607 RVA: 0x004A9B2C File Offset: 0x004A7D2C
		public static Offset<IEntityAngleWeight> Pack(FlatBufferBuilder builder, IEntityAngleWeightT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityAngleWeight>);
			}
			return IEntityAngleWeight.CreateIEntityAngleWeight(builder, _o.Angle, _o.Weight);
		}

		// Token: 0x0400E1E9 RID: 57833
		private Table __p;
	}
}
