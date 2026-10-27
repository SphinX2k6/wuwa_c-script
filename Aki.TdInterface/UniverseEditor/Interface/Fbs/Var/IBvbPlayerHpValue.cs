using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A7E RID: 14974
	public struct IBvbPlayerHpValue : IFlatbufferObject
	{
		// Token: 0x17006690 RID: 26256
		// (get) Token: 0x060144CF RID: 83151 RVA: 0x002F69F1 File Offset: 0x002F4BF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060144D0 RID: 83152 RVA: 0x002F69FE File Offset: 0x002F4BFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060144D1 RID: 83153 RVA: 0x002F6A08 File Offset: 0x002F4C08
		public static IBvbPlayerHpValue GetRootAsIBvbPlayerHpValue(ByteBuffer _bb)
		{
			return IBvbPlayerHpValue.GetRootAsIBvbPlayerHpValue(_bb, default(IBvbPlayerHpValue));
		}

		// Token: 0x060144D2 RID: 83154 RVA: 0x002F6A24 File Offset: 0x002F4C24
		public static IBvbPlayerHpValue GetRootAsIBvbPlayerHpValue(ByteBuffer _bb, IBvbPlayerHpValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060144D3 RID: 83155 RVA: 0x002F6A41 File Offset: 0x002F4C41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060144D4 RID: 83156 RVA: 0x002F6A50 File Offset: 0x002F4C50
		public IBvbPlayerHpValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006691 RID: 26257
		// (get) Token: 0x060144D5 RID: 83157 RVA: 0x002F6A60 File Offset: 0x002F4C60
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

		// Token: 0x060144D6 RID: 83158 RVA: 0x002F6A9C File Offset: 0x002F4C9C
		public static Offset<IBvbPlayerHpValue> CreateIBvbPlayerHpValue(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbPlayerHpValue.AddType(builder, Type);
			return IBvbPlayerHpValue.EndIBvbPlayerHpValue(builder);
		}

		// Token: 0x060144D7 RID: 83159 RVA: 0x002F6AB2 File Offset: 0x002F4CB2
		public static void StartIBvbPlayerHpValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060144D8 RID: 83160 RVA: 0x002F6ABB File Offset: 0x002F4CBB
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060144D9 RID: 83161 RVA: 0x002F6AC6 File Offset: 0x002F4CC6
		public static Offset<IBvbPlayerHpValue> EndIBvbPlayerHpValue(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayerHpValue>(builder.EndTable());
		}

		// Token: 0x060144DA RID: 83162 RVA: 0x002F6AD4 File Offset: 0x002F4CD4
		public IBvbPlayerHpValueT UnPack()
		{
			IBvbPlayerHpValueT bvbPlayerHpValueT = new IBvbPlayerHpValueT();
			this.UnPackTo(bvbPlayerHpValueT);
			return bvbPlayerHpValueT;
		}

		// Token: 0x060144DB RID: 83163 RVA: 0x002F6AEF File Offset: 0x002F4CEF
		public void UnPackTo(IBvbPlayerHpValueT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060144DC RID: 83164 RVA: 0x002F6B00 File Offset: 0x002F4D00
		public static Offset<IBvbPlayerHpValue> Pack(FlatBufferBuilder builder, IBvbPlayerHpValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbPlayerHpValue>);
			}
			return IBvbPlayerHpValue.CreateIBvbPlayerHpValue(builder, _o.Type);
		}

		// Token: 0x0400AEFA RID: 44794
		private Table __p;
	}
}
