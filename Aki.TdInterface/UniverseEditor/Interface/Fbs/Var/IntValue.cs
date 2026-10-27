using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AA5 RID: 15013
	public struct IntValue : IFlatbufferObject
	{
		// Token: 0x170066F1 RID: 26353
		// (get) Token: 0x0601464C RID: 83532 RVA: 0x002F95BC File Offset: 0x002F77BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601464D RID: 83533 RVA: 0x002F95C9 File Offset: 0x002F77C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601464E RID: 83534 RVA: 0x002F95D0 File Offset: 0x002F77D0
		public static IntValue GetRootAsIntValue(ByteBuffer _bb)
		{
			return IntValue.GetRootAsIntValue(_bb, default(IntValue));
		}

		// Token: 0x0601464F RID: 83535 RVA: 0x002F95EC File Offset: 0x002F77EC
		public static IntValue GetRootAsIntValue(ByteBuffer _bb, IntValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014650 RID: 83536 RVA: 0x002F9609 File Offset: 0x002F7809
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014651 RID: 83537 RVA: 0x002F9618 File Offset: 0x002F7818
		public IntValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170066F2 RID: 26354
		// (get) Token: 0x06014652 RID: 83538 RVA: 0x002F9628 File Offset: 0x002F7828
		public int Value
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

		// Token: 0x06014653 RID: 83539 RVA: 0x002F9664 File Offset: 0x002F7864
		public static Offset<IntValue> CreateIntValue(FlatBufferBuilder builder, int value = 0)
		{
			builder.StartTable(1);
			IntValue.AddValue(builder, value);
			return IntValue.EndIntValue(builder);
		}

		// Token: 0x06014654 RID: 83540 RVA: 0x002F967A File Offset: 0x002F787A
		public static void StartIntValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014655 RID: 83541 RVA: 0x002F9683 File Offset: 0x002F7883
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(0, value, 0);
		}

		// Token: 0x06014656 RID: 83542 RVA: 0x002F968E File Offset: 0x002F788E
		public static Offset<IntValue> EndIntValue(FlatBufferBuilder builder)
		{
			return new Offset<IntValue>(builder.EndTable());
		}

		// Token: 0x06014657 RID: 83543 RVA: 0x002F969C File Offset: 0x002F789C
		public IntValueT UnPack()
		{
			IntValueT intValueT = new IntValueT();
			this.UnPackTo(intValueT);
			return intValueT;
		}

		// Token: 0x06014658 RID: 83544 RVA: 0x002F96B7 File Offset: 0x002F78B7
		public void UnPackTo(IntValueT _o)
		{
			_o.Value = this.Value;
		}

		// Token: 0x06014659 RID: 83545 RVA: 0x002F96C8 File Offset: 0x002F78C8
		public static Offset<IntValue> Pack(FlatBufferBuilder builder, IntValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IntValue>);
			}
			return IntValue.CreateIntValue(builder, _o.Value);
		}

		// Token: 0x0400AF31 RID: 44849
		private Table __p;
	}
}
