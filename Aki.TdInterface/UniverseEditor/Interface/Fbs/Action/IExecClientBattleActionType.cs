using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D88 RID: 28040
	public struct IExecClientBattleActionType : IFlatbufferObject
	{
		// Token: 0x1700CDAC RID: 52652
		// (get) Token: 0x06030641 RID: 198209 RVA: 0x0069376D File Offset: 0x0069196D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030642 RID: 198210 RVA: 0x0069377A File Offset: 0x0069197A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030643 RID: 198211 RVA: 0x00693784 File Offset: 0x00691984
		public static IExecClientBattleActionType GetRootAsIExecClientBattleActionType(ByteBuffer _bb)
		{
			return IExecClientBattleActionType.GetRootAsIExecClientBattleActionType(_bb, default(IExecClientBattleActionType));
		}

		// Token: 0x06030644 RID: 198212 RVA: 0x006937A0 File Offset: 0x006919A0
		public static IExecClientBattleActionType GetRootAsIExecClientBattleActionType(ByteBuffer _bb, IExecClientBattleActionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030645 RID: 198213 RVA: 0x006937BD File Offset: 0x006919BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030646 RID: 198214 RVA: 0x006937CC File Offset: 0x006919CC
		public IExecClientBattleActionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDAD RID: 52653
		// (get) Token: 0x06030647 RID: 198215 RVA: 0x006937DC File Offset: 0x006919DC
		public EExecClientBattleActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExecClientBattleActionType.SendTagEventToControlCharacter;
				}
				return (EExecClientBattleActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030648 RID: 198216 RVA: 0x00693818 File Offset: 0x00691A18
		public static Offset<IExecClientBattleActionType> CreateIExecClientBattleActionType(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter)
		{
			builder.StartTable(1);
			IExecClientBattleActionType.AddType(builder, Type);
			return IExecClientBattleActionType.EndIExecClientBattleActionType(builder);
		}

		// Token: 0x06030649 RID: 198217 RVA: 0x0069382E File Offset: 0x00691A2E
		public static void StartIExecClientBattleActionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603064A RID: 198218 RVA: 0x00693837 File Offset: 0x00691A37
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603064B RID: 198219 RVA: 0x00693842 File Offset: 0x00691A42
		public static Offset<IExecClientBattleActionType> EndIExecClientBattleActionType(FlatBufferBuilder builder)
		{
			return new Offset<IExecClientBattleActionType>(builder.EndTable());
		}

		// Token: 0x0603064C RID: 198220 RVA: 0x00693850 File Offset: 0x00691A50
		public IExecClientBattleActionTypeT UnPack()
		{
			IExecClientBattleActionTypeT execClientBattleActionTypeT = new IExecClientBattleActionTypeT();
			this.UnPackTo(execClientBattleActionTypeT);
			return execClientBattleActionTypeT;
		}

		// Token: 0x0603064D RID: 198221 RVA: 0x0069386B File Offset: 0x00691A6B
		public void UnPackTo(IExecClientBattleActionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603064E RID: 198222 RVA: 0x0069387C File Offset: 0x00691A7C
		public static Offset<IExecClientBattleActionType> Pack(FlatBufferBuilder builder, IExecClientBattleActionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExecClientBattleActionType>);
			}
			return IExecClientBattleActionType.CreateIExecClientBattleActionType(builder, _o.Type);
		}

		// Token: 0x04011C15 RID: 72725
		private Table __p;
	}
}
