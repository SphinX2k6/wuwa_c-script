using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004684 RID: 18052
	public struct IResetCurrentDungeon : IFlatbufferObject
	{
		// Token: 0x1700802D RID: 32813
		// (get) Token: 0x0601B67F RID: 112255 RVA: 0x003E4F9D File Offset: 0x003E319D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B680 RID: 112256 RVA: 0x003E4FAA File Offset: 0x003E31AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B681 RID: 112257 RVA: 0x003E4FB4 File Offset: 0x003E31B4
		public static IResetCurrentDungeon GetRootAsIResetCurrentDungeon(ByteBuffer _bb)
		{
			return IResetCurrentDungeon.GetRootAsIResetCurrentDungeon(_bb, default(IResetCurrentDungeon));
		}

		// Token: 0x0601B682 RID: 112258 RVA: 0x003E4FD0 File Offset: 0x003E31D0
		public static IResetCurrentDungeon GetRootAsIResetCurrentDungeon(ByteBuffer _bb, IResetCurrentDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B683 RID: 112259 RVA: 0x003E4FED File Offset: 0x003E31ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B684 RID: 112260 RVA: 0x003E4FFC File Offset: 0x003E31FC
		public IResetCurrentDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700802E RID: 32814
		// (get) Token: 0x0601B685 RID: 112261 RVA: 0x003E500C File Offset: 0x003E320C
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B686 RID: 112262 RVA: 0x003E5048 File Offset: 0x003E3248
		public static Offset<IResetCurrentDungeon> CreateIResetCurrentDungeon(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IResetCurrentDungeon.AddType(builder, Type);
			return IResetCurrentDungeon.EndIResetCurrentDungeon(builder);
		}

		// Token: 0x0601B687 RID: 112263 RVA: 0x003E505E File Offset: 0x003E325E
		public static void StartIResetCurrentDungeon(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B688 RID: 112264 RVA: 0x003E5067 File Offset: 0x003E3267
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B689 RID: 112265 RVA: 0x003E5072 File Offset: 0x003E3272
		public static Offset<IResetCurrentDungeon> EndIResetCurrentDungeon(FlatBufferBuilder builder)
		{
			return new Offset<IResetCurrentDungeon>(builder.EndTable());
		}

		// Token: 0x0601B68A RID: 112266 RVA: 0x003E5080 File Offset: 0x003E3280
		public IResetCurrentDungeonT UnPack()
		{
			IResetCurrentDungeonT resetCurrentDungeonT = new IResetCurrentDungeonT();
			this.UnPackTo(resetCurrentDungeonT);
			return resetCurrentDungeonT;
		}

		// Token: 0x0601B68B RID: 112267 RVA: 0x003E509B File Offset: 0x003E329B
		public void UnPackTo(IResetCurrentDungeonT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B68C RID: 112268 RVA: 0x003E50AC File Offset: 0x003E32AC
		public static Offset<IResetCurrentDungeon> Pack(FlatBufferBuilder builder, IResetCurrentDungeonT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetCurrentDungeon>);
			}
			return IResetCurrentDungeon.CreateIResetCurrentDungeon(builder, _o.Type);
		}

		// Token: 0x0400C846 RID: 51270
		private Table __p;
	}
}
