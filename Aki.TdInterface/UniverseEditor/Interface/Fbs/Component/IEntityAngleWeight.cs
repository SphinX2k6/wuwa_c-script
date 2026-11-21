using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056B2 RID: 22194
	public struct IEntityAngleWeight : IFlatbufferObject
	{
		// Token: 0x17009FB9 RID: 40889
		// (get) Token: 0x060238CC RID: 145612 RVA: 0x004E394E File Offset: 0x004E1B4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060238CD RID: 145613 RVA: 0x004E395B File Offset: 0x004E1B5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060238CE RID: 145614 RVA: 0x004E3964 File Offset: 0x004E1B64
		public static IEntityAngleWeight GetRootAsIEntityAngleWeight(ByteBuffer _bb)
		{
			return IEntityAngleWeight.GetRootAsIEntityAngleWeight(_bb, default(IEntityAngleWeight));
		}

		// Token: 0x060238CF RID: 145615 RVA: 0x004E3980 File Offset: 0x004E1B80
		public static IEntityAngleWeight GetRootAsIEntityAngleWeight(ByteBuffer _bb, IEntityAngleWeight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060238D0 RID: 145616 RVA: 0x004E399D File Offset: 0x004E1B9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060238D1 RID: 145617 RVA: 0x004E39AC File Offset: 0x004E1BAC
		public IEntityAngleWeight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FBA RID: 40890
		// (get) Token: 0x060238D2 RID: 145618 RVA: 0x004E39BC File Offset: 0x004E1BBC
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

		// Token: 0x17009FBB RID: 40891
		// (get) Token: 0x060238D3 RID: 145619 RVA: 0x004E39F8 File Offset: 0x004E1BF8
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

		// Token: 0x060238D4 RID: 145620 RVA: 0x004E3A34 File Offset: 0x004E1C34
		public static Offset<IEntityAngleWeight> CreateIEntityAngleWeight(FlatBufferBuilder builder, int Angle = 0, int Weight = 0)
		{
			builder.StartTable(2);
			IEntityAngleWeight.AddWeight(builder, Weight);
			IEntityAngleWeight.AddAngle(builder, Angle);
			return IEntityAngleWeight.EndIEntityAngleWeight(builder);
		}

		// Token: 0x060238D5 RID: 145621 RVA: 0x004E3A51 File Offset: 0x004E1C51
		public static void StartIEntityAngleWeight(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060238D6 RID: 145622 RVA: 0x004E3A5A File Offset: 0x004E1C5A
		public static void AddAngle(FlatBufferBuilder builder, int angle)
		{
			builder.AddInt(0, angle, 0);
		}

		// Token: 0x060238D7 RID: 145623 RVA: 0x004E3A65 File Offset: 0x004E1C65
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(1, weight, 0);
		}

		// Token: 0x060238D8 RID: 145624 RVA: 0x004E3A70 File Offset: 0x004E1C70
		public static Offset<IEntityAngleWeight> EndIEntityAngleWeight(FlatBufferBuilder builder)
		{
			return new Offset<IEntityAngleWeight>(builder.EndTable());
		}

		// Token: 0x060238D9 RID: 145625 RVA: 0x004E3A80 File Offset: 0x004E1C80
		public IEntityAngleWeightT UnPack()
		{
			IEntityAngleWeightT entityAngleWeightT = new IEntityAngleWeightT();
			this.UnPackTo(entityAngleWeightT);
			return entityAngleWeightT;
		}

		// Token: 0x060238DA RID: 145626 RVA: 0x004E3A9B File Offset: 0x004E1C9B
		public void UnPackTo(IEntityAngleWeightT _o)
		{
			_o.Angle = this.Angle;
			_o.Weight = this.Weight;
		}

		// Token: 0x060238DB RID: 145627 RVA: 0x004E3AB8 File Offset: 0x004E1CB8
		public static Offset<IEntityAngleWeight> Pack(FlatBufferBuilder builder, IEntityAngleWeightT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityAngleWeight>);
			}
			return IEntityAngleWeight.CreateIEntityAngleWeight(builder, _o.Angle, _o.Weight);
		}

		// Token: 0x0400EDE6 RID: 60902
		private Table __p;
	}
}
