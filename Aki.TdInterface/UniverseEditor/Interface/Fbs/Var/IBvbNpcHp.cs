using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A72 RID: 14962
	public struct IBvbNpcHp : IFlatbufferObject
	{
		// Token: 0x17006684 RID: 26244
		// (get) Token: 0x06014487 RID: 83079 RVA: 0x002F6411 File Offset: 0x002F4611
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014488 RID: 83080 RVA: 0x002F641E File Offset: 0x002F461E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014489 RID: 83081 RVA: 0x002F6428 File Offset: 0x002F4628
		public static IBvbNpcHp GetRootAsIBvbNpcHp(ByteBuffer _bb)
		{
			return IBvbNpcHp.GetRootAsIBvbNpcHp(_bb, default(IBvbNpcHp));
		}

		// Token: 0x0601448A RID: 83082 RVA: 0x002F6444 File Offset: 0x002F4644
		public static IBvbNpcHp GetRootAsIBvbNpcHp(ByteBuffer _bb, IBvbNpcHp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601448B RID: 83083 RVA: 0x002F6461 File Offset: 0x002F4661
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601448C RID: 83084 RVA: 0x002F6470 File Offset: 0x002F4670
		public IBvbNpcHp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006685 RID: 26245
		// (get) Token: 0x0601448D RID: 83085 RVA: 0x002F6480 File Offset: 0x002F4680
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

		// Token: 0x0601448E RID: 83086 RVA: 0x002F64BC File Offset: 0x002F46BC
		public static Offset<IBvbNpcHp> CreateIBvbNpcHp(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbNpcHp.AddType(builder, Type);
			return IBvbNpcHp.EndIBvbNpcHp(builder);
		}

		// Token: 0x0601448F RID: 83087 RVA: 0x002F64D2 File Offset: 0x002F46D2
		public static void StartIBvbNpcHp(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014490 RID: 83088 RVA: 0x002F64DB File Offset: 0x002F46DB
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014491 RID: 83089 RVA: 0x002F64E6 File Offset: 0x002F46E6
		public static Offset<IBvbNpcHp> EndIBvbNpcHp(FlatBufferBuilder builder)
		{
			return new Offset<IBvbNpcHp>(builder.EndTable());
		}

		// Token: 0x06014492 RID: 83090 RVA: 0x002F64F4 File Offset: 0x002F46F4
		public IBvbNpcHpT UnPack()
		{
			IBvbNpcHpT bvbNpcHpT = new IBvbNpcHpT();
			this.UnPackTo(bvbNpcHpT);
			return bvbNpcHpT;
		}

		// Token: 0x06014493 RID: 83091 RVA: 0x002F650F File Offset: 0x002F470F
		public void UnPackTo(IBvbNpcHpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06014494 RID: 83092 RVA: 0x002F6520 File Offset: 0x002F4720
		public static Offset<IBvbNpcHp> Pack(FlatBufferBuilder builder, IBvbNpcHpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbNpcHp>);
			}
			return IBvbNpcHp.CreateIBvbNpcHp(builder, _o.Type);
		}

		// Token: 0x0400AEF2 RID: 44786
		private Table __p;
	}
}
