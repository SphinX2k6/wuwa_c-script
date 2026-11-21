using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E59 RID: 15961
	public struct IBvbPlayerHpValue : IFlatbufferObject
	{
		// Token: 0x17006BC0 RID: 27584
		// (get) Token: 0x060157EB RID: 88043 RVA: 0x00319BDD File Offset: 0x00317DDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060157EC RID: 88044 RVA: 0x00319BEA File Offset: 0x00317DEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060157ED RID: 88045 RVA: 0x00319BF4 File Offset: 0x00317DF4
		public static IBvbPlayerHpValue GetRootAsIBvbPlayerHpValue(ByteBuffer _bb)
		{
			return IBvbPlayerHpValue.GetRootAsIBvbPlayerHpValue(_bb, default(IBvbPlayerHpValue));
		}

		// Token: 0x060157EE RID: 88046 RVA: 0x00319C10 File Offset: 0x00317E10
		public static IBvbPlayerHpValue GetRootAsIBvbPlayerHpValue(ByteBuffer _bb, IBvbPlayerHpValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060157EF RID: 88047 RVA: 0x00319C2D File Offset: 0x00317E2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060157F0 RID: 88048 RVA: 0x00319C3C File Offset: 0x00317E3C
		public IBvbPlayerHpValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BC1 RID: 27585
		// (get) Token: 0x060157F1 RID: 88049 RVA: 0x00319C4C File Offset: 0x00317E4C
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

		// Token: 0x060157F2 RID: 88050 RVA: 0x00319C88 File Offset: 0x00317E88
		public static Offset<IBvbPlayerHpValue> CreateIBvbPlayerHpValue(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbPlayerHpValue.AddType(builder, Type);
			return IBvbPlayerHpValue.EndIBvbPlayerHpValue(builder);
		}

		// Token: 0x060157F3 RID: 88051 RVA: 0x00319C9E File Offset: 0x00317E9E
		public static void StartIBvbPlayerHpValue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060157F4 RID: 88052 RVA: 0x00319CA7 File Offset: 0x00317EA7
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060157F5 RID: 88053 RVA: 0x00319CB2 File Offset: 0x00317EB2
		public static Offset<IBvbPlayerHpValue> EndIBvbPlayerHpValue(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayerHpValue>(builder.EndTable());
		}

		// Token: 0x060157F6 RID: 88054 RVA: 0x00319CC0 File Offset: 0x00317EC0
		public IBvbPlayerHpValueT UnPack()
		{
			IBvbPlayerHpValueT bvbPlayerHpValueT = new IBvbPlayerHpValueT();
			this.UnPackTo(bvbPlayerHpValueT);
			return bvbPlayerHpValueT;
		}

		// Token: 0x060157F7 RID: 88055 RVA: 0x00319CDB File Offset: 0x00317EDB
		public void UnPackTo(IBvbPlayerHpValueT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060157F8 RID: 88056 RVA: 0x00319CEC File Offset: 0x00317EEC
		public static Offset<IBvbPlayerHpValue> Pack(FlatBufferBuilder builder, IBvbPlayerHpValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbPlayerHpValue>);
			}
			return IBvbPlayerHpValue.CreateIBvbPlayerHpValue(builder, _o.Type);
		}

		// Token: 0x0400B81C RID: 47132
		private Table __p;
	}
}
