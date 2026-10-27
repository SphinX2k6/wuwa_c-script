using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D79 RID: 15737
	public struct ICheckTrapDefenseEventBase : IFlatbufferObject
	{
		// Token: 0x17006C01 RID: 27649
		// (get) Token: 0x06015C99 RID: 89241 RVA: 0x0032421D File Offset: 0x0032241D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015C9A RID: 89242 RVA: 0x0032422A File Offset: 0x0032242A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015C9B RID: 89243 RVA: 0x00324234 File Offset: 0x00322434
		public static ICheckTrapDefenseEventBase GetRootAsICheckTrapDefenseEventBase(ByteBuffer _bb)
		{
			return ICheckTrapDefenseEventBase.GetRootAsICheckTrapDefenseEventBase(_bb, default(ICheckTrapDefenseEventBase));
		}

		// Token: 0x06015C9C RID: 89244 RVA: 0x00324250 File Offset: 0x00322450
		public static ICheckTrapDefenseEventBase GetRootAsICheckTrapDefenseEventBase(ByteBuffer _bb, ICheckTrapDefenseEventBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015C9D RID: 89245 RVA: 0x0032426D File Offset: 0x0032246D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015C9E RID: 89246 RVA: 0x0032427C File Offset: 0x0032247C
		public ICheckTrapDefenseEventBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C02 RID: 27650
		// (get) Token: 0x06015C9F RID: 89247 RVA: 0x0032428C File Offset: 0x0032248C
		public ECheckTrapDefenseEvent Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckTrapDefenseEvent.MonsterKilled;
				}
				return (ECheckTrapDefenseEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015CA0 RID: 89248 RVA: 0x003242C8 File Offset: 0x003224C8
		public static Offset<ICheckTrapDefenseEventBase> CreateICheckTrapDefenseEventBase(FlatBufferBuilder builder, ECheckTrapDefenseEvent Type = ECheckTrapDefenseEvent.MonsterKilled)
		{
			builder.StartTable(1);
			ICheckTrapDefenseEventBase.AddType(builder, Type);
			return ICheckTrapDefenseEventBase.EndICheckTrapDefenseEventBase(builder);
		}

		// Token: 0x06015CA1 RID: 89249 RVA: 0x003242DE File Offset: 0x003224DE
		public static void StartICheckTrapDefenseEventBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015CA2 RID: 89250 RVA: 0x003242E7 File Offset: 0x003224E7
		public static void AddType(FlatBufferBuilder builder, ECheckTrapDefenseEvent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015CA3 RID: 89251 RVA: 0x003242F2 File Offset: 0x003224F2
		public static Offset<ICheckTrapDefenseEventBase> EndICheckTrapDefenseEventBase(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTrapDefenseEventBase>(builder.EndTable());
		}

		// Token: 0x06015CA4 RID: 89252 RVA: 0x00324300 File Offset: 0x00322500
		public ICheckTrapDefenseEventBaseT UnPack()
		{
			ICheckTrapDefenseEventBaseT checkTrapDefenseEventBaseT = new ICheckTrapDefenseEventBaseT();
			this.UnPackTo(checkTrapDefenseEventBaseT);
			return checkTrapDefenseEventBaseT;
		}

		// Token: 0x06015CA5 RID: 89253 RVA: 0x0032431B File Offset: 0x0032251B
		public void UnPackTo(ICheckTrapDefenseEventBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015CA6 RID: 89254 RVA: 0x0032432C File Offset: 0x0032252C
		public static Offset<ICheckTrapDefenseEventBase> Pack(FlatBufferBuilder builder, ICheckTrapDefenseEventBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTrapDefenseEventBase>);
			}
			return ICheckTrapDefenseEventBase.CreateICheckTrapDefenseEventBase(builder, _o.Type);
		}

		// Token: 0x0400B661 RID: 46689
		private Table __p;
	}
}
