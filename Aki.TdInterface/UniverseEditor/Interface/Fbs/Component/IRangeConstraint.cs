using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057FF RID: 22527
	public struct IRangeConstraint : IFlatbufferObject
	{
		// Token: 0x1700A84E RID: 43086
		// (get) Token: 0x06025DF3 RID: 155123 RVA: 0x0053937A File Offset: 0x0053757A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025DF4 RID: 155124 RVA: 0x00539387 File Offset: 0x00537587
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025DF5 RID: 155125 RVA: 0x00539390 File Offset: 0x00537590
		public static IRangeConstraint GetRootAsIRangeConstraint(ByteBuffer _bb)
		{
			return IRangeConstraint.GetRootAsIRangeConstraint(_bb, default(IRangeConstraint));
		}

		// Token: 0x06025DF6 RID: 155126 RVA: 0x005393AC File Offset: 0x005375AC
		public static IRangeConstraint GetRootAsIRangeConstraint(ByteBuffer _bb, IRangeConstraint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025DF7 RID: 155127 RVA: 0x005393C9 File Offset: 0x005375C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025DF8 RID: 155128 RVA: 0x005393D8 File Offset: 0x005375D8
		public IRangeConstraint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A84F RID: 43087
		// (get) Token: 0x06025DF9 RID: 155129 RVA: 0x005393E8 File Offset: 0x005375E8
		public ERangeConstraint Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERangeConstraint.SearchSpawnMonsterPoint;
				}
				return (ERangeConstraint)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025DFA RID: 155130 RVA: 0x00539424 File Offset: 0x00537624
		public static Offset<IRangeConstraint> CreateIRangeConstraint(FlatBufferBuilder builder, ERangeConstraint Type = ERangeConstraint.SearchSpawnMonsterPoint)
		{
			builder.StartTable(1);
			IRangeConstraint.AddType(builder, Type);
			return IRangeConstraint.EndIRangeConstraint(builder);
		}

		// Token: 0x06025DFB RID: 155131 RVA: 0x0053943A File Offset: 0x0053763A
		public static void StartIRangeConstraint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025DFC RID: 155132 RVA: 0x00539443 File Offset: 0x00537643
		public static void AddType(FlatBufferBuilder builder, ERangeConstraint type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025DFD RID: 155133 RVA: 0x0053944E File Offset: 0x0053764E
		public static Offset<IRangeConstraint> EndIRangeConstraint(FlatBufferBuilder builder)
		{
			return new Offset<IRangeConstraint>(builder.EndTable());
		}

		// Token: 0x06025DFE RID: 155134 RVA: 0x0053945C File Offset: 0x0053765C
		public IRangeConstraintT UnPack()
		{
			IRangeConstraintT rangeConstraintT = new IRangeConstraintT();
			this.UnPackTo(rangeConstraintT);
			return rangeConstraintT;
		}

		// Token: 0x06025DFF RID: 155135 RVA: 0x00539477 File Offset: 0x00537677
		public void UnPackTo(IRangeConstraintT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025E00 RID: 155136 RVA: 0x00539488 File Offset: 0x00537688
		public static Offset<IRangeConstraint> Pack(FlatBufferBuilder builder, IRangeConstraintT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRangeConstraint>);
			}
			return IRangeConstraint.CreateIRangeConstraint(builder, _o.Type);
		}

		// Token: 0x0400ECFA RID: 60666
		private Table __p;
	}
}
