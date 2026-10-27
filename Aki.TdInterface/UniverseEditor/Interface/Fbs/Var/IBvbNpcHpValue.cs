using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A75 RID: 14965
	public struct IBvbNpcHpValue : IFlatbufferObject
	{
		// Token: 0x17006687 RID: 26247
		// (get) Token: 0x06014499 RID: 83097 RVA: 0x002F6589 File Offset: 0x002F4789
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601449A RID: 83098 RVA: 0x002F6596 File Offset: 0x002F4796
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601449B RID: 83099 RVA: 0x002F65A0 File Offset: 0x002F47A0
		public static IBvbNpcHpValue GetRootAsIBvbNpcHpValue(ByteBuffer _bb)
		{
			return IBvbNpcHpValue.GetRootAsIBvbNpcHpValue(_bb, default(IBvbNpcHpValue));
		}

		// Token: 0x0601449C RID: 83100 RVA: 0x002F65BC File Offset: 0x002F47BC
		public static IBvbNpcHpValue GetRootAsIBvbNpcHpValue(ByteBuffer _bb, IBvbNpcHpValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601449D RID: 83101 RVA: 0x002F65D9 File Offset: 0x002F47D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601449E RID: 83102 RVA: 0x002F65E8 File Offset: 0x002F47E8
		public IBvbNpcHpValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006688 RID: 26248
		// (get) Token: 0x0601449F RID: 83103 RVA: 0x002F65F8 File Offset: 0x002F47F8
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

		// Token: 0x060144A0 RID: 83104 RVA: 0x002F6634 File Offset: 0x002F4834
		public static Offset<IBvbNpcHpValue> CreateIBvbNpcHpValue(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbNpcHpValue.AddType(builder, Type);
			return IBvbNpcHpValue.EndIBvbNpcHpValue(builder);
		}

		// Token: 0x060144A1 RID: 83105 RVA: 0x002F664A File Offset: 0x002F484A
		public static void StartIBvbNpcHpValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060144A2 RID: 83106 RVA: 0x002F6653 File Offset: 0x002F4853
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060144A3 RID: 83107 RVA: 0x002F665E File Offset: 0x002F485E
		public static Offset<IBvbNpcHpValue> EndIBvbNpcHpValue(FlatBufferBuilder builder)
		{
			return new Offset<IBvbNpcHpValue>(builder.EndTable());
		}

		// Token: 0x060144A4 RID: 83108 RVA: 0x002F666C File Offset: 0x002F486C
		public IBvbNpcHpValueT UnPack()
		{
			IBvbNpcHpValueT bvbNpcHpValueT = new IBvbNpcHpValueT();
			this.UnPackTo(bvbNpcHpValueT);
			return bvbNpcHpValueT;
		}

		// Token: 0x060144A5 RID: 83109 RVA: 0x002F6687 File Offset: 0x002F4887
		public void UnPackTo(IBvbNpcHpValueT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060144A6 RID: 83110 RVA: 0x002F6698 File Offset: 0x002F4898
		public static Offset<IBvbNpcHpValue> Pack(FlatBufferBuilder builder, IBvbNpcHpValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbNpcHpValue>);
			}
			return IBvbNpcHpValue.CreateIBvbNpcHpValue(builder, _o.Type);
		}

		// Token: 0x0400AEF4 RID: 44788
		private Table __p;
	}
}
