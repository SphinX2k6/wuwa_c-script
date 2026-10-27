using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200514A RID: 20810
	public struct IEnterScreenWeight : IFlatbufferObject
	{
		// Token: 0x170097C7 RID: 38855
		// (get) Token: 0x06021962 RID: 137570 RVA: 0x004A97C4 File Offset: 0x004A79C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021963 RID: 137571 RVA: 0x004A97D1 File Offset: 0x004A79D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021964 RID: 137572 RVA: 0x004A97D8 File Offset: 0x004A79D8
		public static IEnterScreenWeight GetRootAsIEnterScreenWeight(ByteBuffer _bb)
		{
			return IEnterScreenWeight.GetRootAsIEnterScreenWeight(_bb, default(IEnterScreenWeight));
		}

		// Token: 0x06021965 RID: 137573 RVA: 0x004A97F4 File Offset: 0x004A79F4
		public static IEnterScreenWeight GetRootAsIEnterScreenWeight(ByteBuffer _bb, IEnterScreenWeight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021966 RID: 137574 RVA: 0x004A9811 File Offset: 0x004A7A11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021967 RID: 137575 RVA: 0x004A9820 File Offset: 0x004A7A20
		public IEnterScreenWeight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097C8 RID: 38856
		// (get) Token: 0x06021968 RID: 137576 RVA: 0x004A9830 File Offset: 0x004A7A30
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

		// Token: 0x170097C9 RID: 38857
		// (get) Token: 0x06021969 RID: 137577 RVA: 0x004A986C File Offset: 0x004A7A6C
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

		// Token: 0x0602196A RID: 137578 RVA: 0x004A98A8 File Offset: 0x004A7AA8
		public static Offset<IEnterScreenWeight> CreateIEnterScreenWeight(FlatBufferBuilder builder, EExploreSkillSearchTargetCfg Type = EExploreSkillSearchTargetCfg.AngleWeight, int Weight = 0)
		{
			builder.StartTable(2);
			IEnterScreenWeight.AddWeight(builder, Weight);
			IEnterScreenWeight.AddType(builder, Type);
			return IEnterScreenWeight.EndIEnterScreenWeight(builder);
		}

		// Token: 0x0602196B RID: 137579 RVA: 0x004A98C5 File Offset: 0x004A7AC5
		public static void StartIEnterScreenWeight(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602196C RID: 137580 RVA: 0x004A98CE File Offset: 0x004A7ACE
		public static void AddType(FlatBufferBuilder builder, EExploreSkillSearchTargetCfg type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602196D RID: 137581 RVA: 0x004A98D9 File Offset: 0x004A7AD9
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(1, weight, 0);
		}

		// Token: 0x0602196E RID: 137582 RVA: 0x004A98E4 File Offset: 0x004A7AE4
		public static Offset<IEnterScreenWeight> EndIEnterScreenWeight(FlatBufferBuilder builder)
		{
			return new Offset<IEnterScreenWeight>(builder.EndTable());
		}

		// Token: 0x0602196F RID: 137583 RVA: 0x004A98F4 File Offset: 0x004A7AF4
		public IEnterScreenWeightT UnPack()
		{
			IEnterScreenWeightT enterScreenWeightT = new IEnterScreenWeightT();
			this.UnPackTo(enterScreenWeightT);
			return enterScreenWeightT;
		}

		// Token: 0x06021970 RID: 137584 RVA: 0x004A990F File Offset: 0x004A7B0F
		public void UnPackTo(IEnterScreenWeightT _o)
		{
			_o.Type = this.Type;
			_o.Weight = this.Weight;
		}

		// Token: 0x06021971 RID: 137585 RVA: 0x004A992C File Offset: 0x004A7B2C
		public static Offset<IEnterScreenWeight> Pack(FlatBufferBuilder builder, IEnterScreenWeightT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterScreenWeight>);
			}
			return IEnterScreenWeight.CreateIEnterScreenWeight(builder, _o.Type, _o.Weight);
		}

		// Token: 0x0400E1E6 RID: 57830
		private Table __p;
	}
}
