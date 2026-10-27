using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066FC RID: 26364
	public struct IExecBattleActionType : IFlatbufferObject
	{
		// Token: 0x1700C3EB RID: 50155
		// (get) Token: 0x0602DD9F RID: 187807 RVA: 0x006453AD File Offset: 0x006435AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DDA0 RID: 187808 RVA: 0x006453BA File Offset: 0x006435BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DDA1 RID: 187809 RVA: 0x006453C4 File Offset: 0x006435C4
		public static IExecBattleActionType GetRootAsIExecBattleActionType(ByteBuffer _bb)
		{
			return IExecBattleActionType.GetRootAsIExecBattleActionType(_bb, default(IExecBattleActionType));
		}

		// Token: 0x0602DDA2 RID: 187810 RVA: 0x006453E0 File Offset: 0x006435E0
		public static IExecBattleActionType GetRootAsIExecBattleActionType(ByteBuffer _bb, IExecBattleActionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DDA3 RID: 187811 RVA: 0x006453FD File Offset: 0x006435FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DDA4 RID: 187812 RVA: 0x0064540C File Offset: 0x0064360C
		public IExecBattleActionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3EC RID: 50156
		// (get) Token: 0x0602DDA5 RID: 187813 RVA: 0x0064541C File Offset: 0x0064361C
		public EExecBattleActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExecBattleActionType.SetBattleTags;
				}
				return (EExecBattleActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DDA6 RID: 187814 RVA: 0x00645458 File Offset: 0x00643658
		public static Offset<IExecBattleActionType> CreateIExecBattleActionType(FlatBufferBuilder builder, EExecBattleActionType Type = EExecBattleActionType.SetBattleTags)
		{
			builder.StartTable(1);
			IExecBattleActionType.AddType(builder, Type);
			return IExecBattleActionType.EndIExecBattleActionType(builder);
		}

		// Token: 0x0602DDA7 RID: 187815 RVA: 0x0064546E File Offset: 0x0064366E
		public static void StartIExecBattleActionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DDA8 RID: 187816 RVA: 0x00645477 File Offset: 0x00643677
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DDA9 RID: 187817 RVA: 0x00645482 File Offset: 0x00643682
		public static Offset<IExecBattleActionType> EndIExecBattleActionType(FlatBufferBuilder builder)
		{
			return new Offset<IExecBattleActionType>(builder.EndTable());
		}

		// Token: 0x0602DDAA RID: 187818 RVA: 0x00645490 File Offset: 0x00643690
		public IExecBattleActionTypeT UnPack()
		{
			IExecBattleActionTypeT execBattleActionTypeT = new IExecBattleActionTypeT();
			this.UnPackTo(execBattleActionTypeT);
			return execBattleActionTypeT;
		}

		// Token: 0x0602DDAB RID: 187819 RVA: 0x006454AB File Offset: 0x006436AB
		public void UnPackTo(IExecBattleActionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DDAC RID: 187820 RVA: 0x006454BC File Offset: 0x006436BC
		public static Offset<IExecBattleActionType> Pack(FlatBufferBuilder builder, IExecBattleActionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExecBattleActionType>);
			}
			return IExecBattleActionType.CreateIExecBattleActionType(builder, _o.Type);
		}

		// Token: 0x04010DD2 RID: 69074
		private Table __p;
	}
}
