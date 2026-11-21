using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E4D RID: 15949
	public struct IBvbNpcHp : IFlatbufferObject
	{
		// Token: 0x17006BB4 RID: 27572
		// (get) Token: 0x060157A3 RID: 87971 RVA: 0x003195FD File Offset: 0x003177FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060157A4 RID: 87972 RVA: 0x0031960A File Offset: 0x0031780A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060157A5 RID: 87973 RVA: 0x00319614 File Offset: 0x00317814
		public static IBvbNpcHp GetRootAsIBvbNpcHp(ByteBuffer _bb)
		{
			return IBvbNpcHp.GetRootAsIBvbNpcHp(_bb, default(IBvbNpcHp));
		}

		// Token: 0x060157A6 RID: 87974 RVA: 0x00319630 File Offset: 0x00317830
		public static IBvbNpcHp GetRootAsIBvbNpcHp(ByteBuffer _bb, IBvbNpcHp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060157A7 RID: 87975 RVA: 0x0031964D File Offset: 0x0031784D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060157A8 RID: 87976 RVA: 0x0031965C File Offset: 0x0031785C
		public IBvbNpcHp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BB5 RID: 27573
		// (get) Token: 0x060157A9 RID: 87977 RVA: 0x0031966C File Offset: 0x0031786C
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

		// Token: 0x060157AA RID: 87978 RVA: 0x003196A8 File Offset: 0x003178A8
		public static Offset<IBvbNpcHp> CreateIBvbNpcHp(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbNpcHp.AddType(builder, Type);
			return IBvbNpcHp.EndIBvbNpcHp(builder);
		}

		// Token: 0x060157AB RID: 87979 RVA: 0x003196BE File Offset: 0x003178BE
		public static void StartIBvbNpcHp(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060157AC RID: 87980 RVA: 0x003196C7 File Offset: 0x003178C7
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060157AD RID: 87981 RVA: 0x003196D2 File Offset: 0x003178D2
		public static Offset<IBvbNpcHp> EndIBvbNpcHp(FlatBufferBuilder builder)
		{
			return new Offset<IBvbNpcHp>(builder.EndTable());
		}

		// Token: 0x060157AE RID: 87982 RVA: 0x003196E0 File Offset: 0x003178E0
		public IBvbNpcHpT UnPack()
		{
			IBvbNpcHpT bvbNpcHpT = new IBvbNpcHpT();
			this.UnPackTo(bvbNpcHpT);
			return bvbNpcHpT;
		}

		// Token: 0x060157AF RID: 87983 RVA: 0x003196FB File Offset: 0x003178FB
		public void UnPackTo(IBvbNpcHpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060157B0 RID: 87984 RVA: 0x0031970C File Offset: 0x0031790C
		public static Offset<IBvbNpcHp> Pack(FlatBufferBuilder builder, IBvbNpcHpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbNpcHp>);
			}
			return IBvbNpcHp.CreateIBvbNpcHp(builder, _o.Type);
		}

		// Token: 0x0400B814 RID: 47124
		private Table __p;
	}
}
