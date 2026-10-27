using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CA0 RID: 19616
	public struct IQuestPreConditionDungeonBase : IFlatbufferObject
	{
		// Token: 0x17008E6D RID: 36461
		// (get) Token: 0x0601F1DB RID: 127451 RVA: 0x00458CAE File Offset: 0x00456EAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F1DC RID: 127452 RVA: 0x00458CBB File Offset: 0x00456EBB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F1DD RID: 127453 RVA: 0x00458CC4 File Offset: 0x00456EC4
		public static IQuestPreConditionDungeonBase GetRootAsIQuestPreConditionDungeonBase(ByteBuffer _bb)
		{
			return IQuestPreConditionDungeonBase.GetRootAsIQuestPreConditionDungeonBase(_bb, default(IQuestPreConditionDungeonBase));
		}

		// Token: 0x0601F1DE RID: 127454 RVA: 0x00458CE0 File Offset: 0x00456EE0
		public static IQuestPreConditionDungeonBase GetRootAsIQuestPreConditionDungeonBase(ByteBuffer _bb, IQuestPreConditionDungeonBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F1DF RID: 127455 RVA: 0x00458CFD File Offset: 0x00456EFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F1E0 RID: 127456 RVA: 0x00458D0C File Offset: 0x00456F0C
		public IQuestPreConditionDungeonBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E6E RID: 36462
		// (get) Token: 0x0601F1E1 RID: 127457 RVA: 0x00458D1C File Offset: 0x00456F1C
		public EQuestPreConditionDungeonType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EQuestPreConditionDungeonType.DungeonId;
				}
				return (EQuestPreConditionDungeonType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F1E2 RID: 127458 RVA: 0x00458D58 File Offset: 0x00456F58
		public static Offset<IQuestPreConditionDungeonBase> CreateIQuestPreConditionDungeonBase(FlatBufferBuilder builder, EQuestPreConditionDungeonType Type = EQuestPreConditionDungeonType.DungeonId)
		{
			builder.StartTable(1);
			IQuestPreConditionDungeonBase.AddType(builder, Type);
			return IQuestPreConditionDungeonBase.EndIQuestPreConditionDungeonBase(builder);
		}

		// Token: 0x0601F1E3 RID: 127459 RVA: 0x00458D6E File Offset: 0x00456F6E
		public static void StartIQuestPreConditionDungeonBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F1E4 RID: 127460 RVA: 0x00458D77 File Offset: 0x00456F77
		public static void AddType(FlatBufferBuilder builder, EQuestPreConditionDungeonType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F1E5 RID: 127461 RVA: 0x00458D82 File Offset: 0x00456F82
		public static Offset<IQuestPreConditionDungeonBase> EndIQuestPreConditionDungeonBase(FlatBufferBuilder builder)
		{
			return new Offset<IQuestPreConditionDungeonBase>(builder.EndTable());
		}

		// Token: 0x0601F1E6 RID: 127462 RVA: 0x00458D90 File Offset: 0x00456F90
		public IQuestPreConditionDungeonBaseT UnPack()
		{
			IQuestPreConditionDungeonBaseT questPreConditionDungeonBaseT = new IQuestPreConditionDungeonBaseT();
			this.UnPackTo(questPreConditionDungeonBaseT);
			return questPreConditionDungeonBaseT;
		}

		// Token: 0x0601F1E7 RID: 127463 RVA: 0x00458DAB File Offset: 0x00456FAB
		public void UnPackTo(IQuestPreConditionDungeonBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F1E8 RID: 127464 RVA: 0x00458DBC File Offset: 0x00456FBC
		public static Offset<IQuestPreConditionDungeonBase> Pack(FlatBufferBuilder builder, IQuestPreConditionDungeonBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestPreConditionDungeonBase>);
			}
			return IQuestPreConditionDungeonBase.CreateIQuestPreConditionDungeonBase(builder, _o.Type);
		}

		// Token: 0x0400D65B RID: 54875
		private Table __p;
	}
}
