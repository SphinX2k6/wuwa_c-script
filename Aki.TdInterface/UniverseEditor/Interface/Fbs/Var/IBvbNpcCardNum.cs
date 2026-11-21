using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E44 RID: 15940
	public struct IBvbNpcCardNum : IFlatbufferObject
	{
		// Token: 0x17006BAB RID: 27563
		// (get) Token: 0x0601576D RID: 87917 RVA: 0x00319195 File Offset: 0x00317395
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601576E RID: 87918 RVA: 0x003191A2 File Offset: 0x003173A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601576F RID: 87919 RVA: 0x003191AC File Offset: 0x003173AC
		public static IBvbNpcCardNum GetRootAsIBvbNpcCardNum(ByteBuffer _bb)
		{
			return IBvbNpcCardNum.GetRootAsIBvbNpcCardNum(_bb, default(IBvbNpcCardNum));
		}

		// Token: 0x06015770 RID: 87920 RVA: 0x003191C8 File Offset: 0x003173C8
		public static IBvbNpcCardNum GetRootAsIBvbNpcCardNum(ByteBuffer _bb, IBvbNpcCardNum obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015771 RID: 87921 RVA: 0x003191E5 File Offset: 0x003173E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015772 RID: 87922 RVA: 0x003191F4 File Offset: 0x003173F4
		public IBvbNpcCardNum __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BAC RID: 27564
		// (get) Token: 0x06015773 RID: 87923 RVA: 0x00319204 File Offset: 0x00317404
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

		// Token: 0x06015774 RID: 87924 RVA: 0x00319240 File Offset: 0x00317440
		public static Offset<IBvbNpcCardNum> CreateIBvbNpcCardNum(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbNpcCardNum.AddType(builder, Type);
			return IBvbNpcCardNum.EndIBvbNpcCardNum(builder);
		}

		// Token: 0x06015775 RID: 87925 RVA: 0x00319256 File Offset: 0x00317456
		public static void StartIBvbNpcCardNum(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015776 RID: 87926 RVA: 0x0031925F File Offset: 0x0031745F
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015777 RID: 87927 RVA: 0x0031926A File Offset: 0x0031746A
		public static Offset<IBvbNpcCardNum> EndIBvbNpcCardNum(FlatBufferBuilder builder)
		{
			return new Offset<IBvbNpcCardNum>(builder.EndTable());
		}

		// Token: 0x06015778 RID: 87928 RVA: 0x00319278 File Offset: 0x00317478
		public IBvbNpcCardNumT UnPack()
		{
			IBvbNpcCardNumT bvbNpcCardNumT = new IBvbNpcCardNumT();
			this.UnPackTo(bvbNpcCardNumT);
			return bvbNpcCardNumT;
		}

		// Token: 0x06015779 RID: 87929 RVA: 0x00319293 File Offset: 0x00317493
		public void UnPackTo(IBvbNpcCardNumT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601577A RID: 87930 RVA: 0x003192A4 File Offset: 0x003174A4
		public static Offset<IBvbNpcCardNum> Pack(FlatBufferBuilder builder, IBvbNpcCardNumT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbNpcCardNum>);
			}
			return IBvbNpcCardNum.CreateIBvbNpcCardNum(builder, _o.Type);
		}

		// Token: 0x0400B80E RID: 47118
		private Table __p;
	}
}
