using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056AF RID: 22191
	public struct IEnterScreenWeight : IFlatbufferObject
	{
		// Token: 0x17009FB4 RID: 40884
		// (get) Token: 0x060238B6 RID: 145590 RVA: 0x004E3750 File Offset: 0x004E1950
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060238B7 RID: 145591 RVA: 0x004E375D File Offset: 0x004E195D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060238B8 RID: 145592 RVA: 0x004E3764 File Offset: 0x004E1964
		public static IEnterScreenWeight GetRootAsIEnterScreenWeight(ByteBuffer _bb)
		{
			return IEnterScreenWeight.GetRootAsIEnterScreenWeight(_bb, default(IEnterScreenWeight));
		}

		// Token: 0x060238B9 RID: 145593 RVA: 0x004E3780 File Offset: 0x004E1980
		public static IEnterScreenWeight GetRootAsIEnterScreenWeight(ByteBuffer _bb, IEnterScreenWeight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060238BA RID: 145594 RVA: 0x004E379D File Offset: 0x004E199D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060238BB RID: 145595 RVA: 0x004E37AC File Offset: 0x004E19AC
		public IEnterScreenWeight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FB5 RID: 40885
		// (get) Token: 0x060238BC RID: 145596 RVA: 0x004E37BC File Offset: 0x004E19BC
		public EExploreSkillSearchTargetCfg Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreSkillSearchTargetCfg.AngleWeight;
				}
				return (EExploreSkillSearchTargetCfg)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009FB6 RID: 40886
		// (get) Token: 0x060238BD RID: 145597 RVA: 0x004E37F8 File Offset: 0x004E19F8
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

		// Token: 0x060238BE RID: 145598 RVA: 0x004E3834 File Offset: 0x004E1A34
		public static Offset<IEnterScreenWeight> CreateIEnterScreenWeight(FlatBufferBuilder builder, EExploreSkillSearchTargetCfg Type = EExploreSkillSearchTargetCfg.AngleWeight, int Weight = 0)
		{
			builder.StartTable(2);
			IEnterScreenWeight.AddWeight(builder, Weight);
			IEnterScreenWeight.AddType(builder, Type);
			return IEnterScreenWeight.EndIEnterScreenWeight(builder);
		}

		// Token: 0x060238BF RID: 145599 RVA: 0x004E3851 File Offset: 0x004E1A51
		public static void StartIEnterScreenWeight(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060238C0 RID: 145600 RVA: 0x004E385A File Offset: 0x004E1A5A
		public static void AddType(FlatBufferBuilder builder, EExploreSkillSearchTargetCfg type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060238C1 RID: 145601 RVA: 0x004E3865 File Offset: 0x004E1A65
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(1, weight, 0);
		}

		// Token: 0x060238C2 RID: 145602 RVA: 0x004E3870 File Offset: 0x004E1A70
		public static Offset<IEnterScreenWeight> EndIEnterScreenWeight(FlatBufferBuilder builder)
		{
			return new Offset<IEnterScreenWeight>(builder.EndTable());
		}

		// Token: 0x060238C3 RID: 145603 RVA: 0x004E3880 File Offset: 0x004E1A80
		public IEnterScreenWeightT UnPack()
		{
			IEnterScreenWeightT enterScreenWeightT = new IEnterScreenWeightT();
			this.UnPackTo(enterScreenWeightT);
			return enterScreenWeightT;
		}

		// Token: 0x060238C4 RID: 145604 RVA: 0x004E389B File Offset: 0x004E1A9B
		public void UnPackTo(IEnterScreenWeightT _o)
		{
			_o.Type = this.Type;
			_o.Weight = this.Weight;
		}

		// Token: 0x060238C5 RID: 145605 RVA: 0x004E38B8 File Offset: 0x004E1AB8
		public static Offset<IEnterScreenWeight> Pack(FlatBufferBuilder builder, IEnterScreenWeightT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterScreenWeight>);
			}
			return IEnterScreenWeight.CreateIEnterScreenWeight(builder, _o.Type, _o.Weight);
		}

		// Token: 0x0400EDE3 RID: 60899
		private Table __p;
	}
}
