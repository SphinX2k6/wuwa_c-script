using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006708 RID: 26376
	public struct IExecClientBattleActionType : IFlatbufferObject
	{
		// Token: 0x1700C3F6 RID: 50166
		// (get) Token: 0x0602DDFD RID: 187901 RVA: 0x0064606D File Offset: 0x0064426D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DDFE RID: 187902 RVA: 0x0064607A File Offset: 0x0064427A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DDFF RID: 187903 RVA: 0x00646084 File Offset: 0x00644284
		public static IExecClientBattleActionType GetRootAsIExecClientBattleActionType(ByteBuffer _bb)
		{
			return IExecClientBattleActionType.GetRootAsIExecClientBattleActionType(_bb, default(IExecClientBattleActionType));
		}

		// Token: 0x0602DE00 RID: 187904 RVA: 0x006460A0 File Offset: 0x006442A0
		public static IExecClientBattleActionType GetRootAsIExecClientBattleActionType(ByteBuffer _bb, IExecClientBattleActionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DE01 RID: 187905 RVA: 0x006460BD File Offset: 0x006442BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DE02 RID: 187906 RVA: 0x006460CC File Offset: 0x006442CC
		public IExecClientBattleActionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3F7 RID: 50167
		// (get) Token: 0x0602DE03 RID: 187907 RVA: 0x006460DC File Offset: 0x006442DC
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

		// Token: 0x0602DE04 RID: 187908 RVA: 0x00646118 File Offset: 0x00644318
		public static Offset<IExecClientBattleActionType> CreateIExecClientBattleActionType(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter)
		{
			builder.StartTable(1);
			IExecClientBattleActionType.AddType(builder, Type);
			return IExecClientBattleActionType.EndIExecClientBattleActionType(builder);
		}

		// Token: 0x0602DE05 RID: 187909 RVA: 0x0064612E File Offset: 0x0064432E
		public static void StartIExecClientBattleActionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DE06 RID: 187910 RVA: 0x00646137 File Offset: 0x00644337
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DE07 RID: 187911 RVA: 0x00646142 File Offset: 0x00644342
		public static Offset<IExecClientBattleActionType> EndIExecClientBattleActionType(FlatBufferBuilder builder)
		{
			return new Offset<IExecClientBattleActionType>(builder.EndTable());
		}

		// Token: 0x0602DE08 RID: 187912 RVA: 0x00646150 File Offset: 0x00644350
		public IExecClientBattleActionTypeT UnPack()
		{
			IExecClientBattleActionTypeT execClientBattleActionTypeT = new IExecClientBattleActionTypeT();
			this.UnPackTo(execClientBattleActionTypeT);
			return execClientBattleActionTypeT;
		}

		// Token: 0x0602DE09 RID: 187913 RVA: 0x0064616B File Offset: 0x0064436B
		public void UnPackTo(IExecClientBattleActionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DE0A RID: 187914 RVA: 0x0064617C File Offset: 0x0064437C
		public static Offset<IExecClientBattleActionType> Pack(FlatBufferBuilder builder, IExecClientBattleActionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExecClientBattleActionType>);
			}
			return IExecClientBattleActionType.CreateIExecClientBattleActionType(builder, _o.Type);
		}

		// Token: 0x04010DE4 RID: 69092
		private Table __p;
	}
}
