using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006561 RID: 25953
	public struct IDelayRemoveType : IFlatbufferObject
	{
		// Token: 0x1700C0DF RID: 49375
		// (get) Token: 0x0602D070 RID: 184432 RVA: 0x0062DEE1 File Offset: 0x0062C0E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D071 RID: 184433 RVA: 0x0062DEEE File Offset: 0x0062C0EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D072 RID: 184434 RVA: 0x0062DEF8 File Offset: 0x0062C0F8
		public static IDelayRemoveType GetRootAsIDelayRemoveType(ByteBuffer _bb)
		{
			return IDelayRemoveType.GetRootAsIDelayRemoveType(_bb, default(IDelayRemoveType));
		}

		// Token: 0x0602D073 RID: 184435 RVA: 0x0062DF14 File Offset: 0x0062C114
		public static IDelayRemoveType GetRootAsIDelayRemoveType(ByteBuffer _bb, IDelayRemoveType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D074 RID: 184436 RVA: 0x0062DF31 File Offset: 0x0062C131
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D075 RID: 184437 RVA: 0x0062DF40 File Offset: 0x0062C140
		public IDelayRemoveType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0E0 RID: 49376
		// (get) Token: 0x0602D076 RID: 184438 RVA: 0x0062DF50 File Offset: 0x0062C150
		public EDelayRemoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDelayRemoveType.DelayRemoveAfterSkillFinish;
				}
				return (EDelayRemoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D077 RID: 184439 RVA: 0x0062DF8C File Offset: 0x0062C18C
		public static Offset<IDelayRemoveType> CreateIDelayRemoveType(FlatBufferBuilder builder, EDelayRemoveType Type = EDelayRemoveType.DelayRemoveAfterSkillFinish)
		{
			builder.StartTable(1);
			IDelayRemoveType.AddType(builder, Type);
			return IDelayRemoveType.EndIDelayRemoveType(builder);
		}

		// Token: 0x0602D078 RID: 184440 RVA: 0x0062DFA2 File Offset: 0x0062C1A2
		public static void StartIDelayRemoveType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D079 RID: 184441 RVA: 0x0062DFAB File Offset: 0x0062C1AB
		public static void AddType(FlatBufferBuilder builder, EDelayRemoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D07A RID: 184442 RVA: 0x0062DFB6 File Offset: 0x0062C1B6
		public static Offset<IDelayRemoveType> EndIDelayRemoveType(FlatBufferBuilder builder)
		{
			return new Offset<IDelayRemoveType>(builder.EndTable());
		}

		// Token: 0x0602D07B RID: 184443 RVA: 0x0062DFC4 File Offset: 0x0062C1C4
		public IDelayRemoveTypeT UnPack()
		{
			IDelayRemoveTypeT delayRemoveTypeT = new IDelayRemoveTypeT();
			this.UnPackTo(delayRemoveTypeT);
			return delayRemoveTypeT;
		}

		// Token: 0x0602D07C RID: 184444 RVA: 0x0062DFDF File Offset: 0x0062C1DF
		public void UnPackTo(IDelayRemoveTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D07D RID: 184445 RVA: 0x0062DFF0 File Offset: 0x0062C1F0
		public static Offset<IDelayRemoveType> Pack(FlatBufferBuilder builder, IDelayRemoveTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDelayRemoveType>);
			}
			return IDelayRemoveType.CreateIDelayRemoveType(builder, _o.Type);
		}

		// Token: 0x04010BB3 RID: 68531
		private Table __p;
	}
}
