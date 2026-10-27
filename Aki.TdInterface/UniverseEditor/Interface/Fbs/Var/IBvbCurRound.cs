using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A48 RID: 14920
	public struct IBvbCurRound : IFlatbufferObject
	{
		// Token: 0x17006648 RID: 26184
		// (get) Token: 0x0601434A RID: 82762 RVA: 0x002F4130 File Offset: 0x002F2330
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601434B RID: 82763 RVA: 0x002F413D File Offset: 0x002F233D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601434C RID: 82764 RVA: 0x002F4144 File Offset: 0x002F2344
		public static IBvbCurRound GetRootAsIBvbCurRound(ByteBuffer _bb)
		{
			return IBvbCurRound.GetRootAsIBvbCurRound(_bb, default(IBvbCurRound));
		}

		// Token: 0x0601434D RID: 82765 RVA: 0x002F4160 File Offset: 0x002F2360
		public static IBvbCurRound GetRootAsIBvbCurRound(ByteBuffer _bb, IBvbCurRound obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601434E RID: 82766 RVA: 0x002F417D File Offset: 0x002F237D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601434F RID: 82767 RVA: 0x002F418C File Offset: 0x002F238C
		public IBvbCurRound __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006649 RID: 26185
		// (get) Token: 0x06014350 RID: 82768 RVA: 0x002F419C File Offset: 0x002F239C
		public ESystemVarName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemVarName.CommonHotFixVar;
				}
				return (ESystemVarName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014351 RID: 82769 RVA: 0x002F41D8 File Offset: 0x002F23D8
		public static Offset<IBvbCurRound> CreateIBvbCurRound(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbCurRound.AddType(builder, Type);
			return IBvbCurRound.EndIBvbCurRound(builder);
		}

		// Token: 0x06014352 RID: 82770 RVA: 0x002F41EE File Offset: 0x002F23EE
		public static void StartIBvbCurRound(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014353 RID: 82771 RVA: 0x002F41F7 File Offset: 0x002F23F7
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014354 RID: 82772 RVA: 0x002F4202 File Offset: 0x002F2402
		public static Offset<IBvbCurRound> EndIBvbCurRound(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCurRound>(builder.EndTable());
		}

		// Token: 0x06014355 RID: 82773 RVA: 0x002F4210 File Offset: 0x002F2410
		public IBvbCurRoundT UnPack()
		{
			IBvbCurRoundT bvbCurRoundT = new IBvbCurRoundT();
			this.UnPackTo(bvbCurRoundT);
			return bvbCurRoundT;
		}

		// Token: 0x06014356 RID: 82774 RVA: 0x002F422B File Offset: 0x002F242B
		public void UnPackTo(IBvbCurRoundT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06014357 RID: 82775 RVA: 0x002F423C File Offset: 0x002F243C
		public static Offset<IBvbCurRound> Pack(FlatBufferBuilder builder, IBvbCurRoundT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCurRound>);
			}
			return IBvbCurRound.CreateIBvbCurRound(builder, _o.Type);
		}

		// Token: 0x0400AECD RID: 44749
		private Table __p;
	}
}
