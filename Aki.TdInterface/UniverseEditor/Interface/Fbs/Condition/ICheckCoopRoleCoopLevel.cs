using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049AC RID: 18860
	public struct ICheckCoopRoleCoopLevel : IFlatbufferObject
	{
		// Token: 0x17008858 RID: 34904
		// (get) Token: 0x0601D6F4 RID: 120564 RVA: 0x00425C8E File Offset: 0x00423E8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D6F5 RID: 120565 RVA: 0x00425C9B File Offset: 0x00423E9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D6F6 RID: 120566 RVA: 0x00425CA4 File Offset: 0x00423EA4
		public static ICheckCoopRoleCoopLevel GetRootAsICheckCoopRoleCoopLevel(ByteBuffer _bb)
		{
			return ICheckCoopRoleCoopLevel.GetRootAsICheckCoopRoleCoopLevel(_bb, default(ICheckCoopRoleCoopLevel));
		}

		// Token: 0x0601D6F7 RID: 120567 RVA: 0x00425CC0 File Offset: 0x00423EC0
		public static ICheckCoopRoleCoopLevel GetRootAsICheckCoopRoleCoopLevel(ByteBuffer _bb, ICheckCoopRoleCoopLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D6F8 RID: 120568 RVA: 0x00425CDD File Offset: 0x00423EDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D6F9 RID: 120569 RVA: 0x00425CEC File Offset: 0x00423EEC
		public ICheckCoopRoleCoopLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008859 RID: 34905
		// (get) Token: 0x0601D6FA RID: 120570 RVA: 0x00425CFC File Offset: 0x00423EFC
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700885A RID: 34906
		// (get) Token: 0x0601D6FB RID: 120571 RVA: 0x00425D38 File Offset: 0x00423F38
		public int CoopRoleId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700885B RID: 34907
		// (get) Token: 0x0601D6FC RID: 120572 RVA: 0x00425D74 File Offset: 0x00423F74
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700885C RID: 34908
		// (get) Token: 0x0601D6FD RID: 120573 RVA: 0x00425DB0 File Offset: 0x00423FB0
		public int Level
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D6FE RID: 120574 RVA: 0x00425DED File Offset: 0x00423FED
		public static Offset<ICheckCoopRoleCoopLevel> CreateICheckCoopRoleCoopLevel(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int CoopRoleId = 0, ECompare Compare = ECompare.Eq, int Level = 0)
		{
			builder.StartTable(4);
			ICheckCoopRoleCoopLevel.AddLevel(builder, Level);
			ICheckCoopRoleCoopLevel.AddCoopRoleId(builder, CoopRoleId);
			ICheckCoopRoleCoopLevel.AddCompare(builder, Compare);
			ICheckCoopRoleCoopLevel.AddType(builder, Type);
			return ICheckCoopRoleCoopLevel.EndICheckCoopRoleCoopLevel(builder);
		}

		// Token: 0x0601D6FF RID: 120575 RVA: 0x00425E19 File Offset: 0x00424019
		public static void StartICheckCoopRoleCoopLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601D700 RID: 120576 RVA: 0x00425E22 File Offset: 0x00424022
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D701 RID: 120577 RVA: 0x00425E2D File Offset: 0x0042402D
		public static void AddCoopRoleId(FlatBufferBuilder builder, int coopRoleId)
		{
			builder.AddInt(1, coopRoleId, 0);
		}

		// Token: 0x0601D702 RID: 120578 RVA: 0x00425E38 File Offset: 0x00424038
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601D703 RID: 120579 RVA: 0x00425E43 File Offset: 0x00424043
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(3, level, 0);
		}

		// Token: 0x0601D704 RID: 120580 RVA: 0x00425E4E File Offset: 0x0042404E
		public static Offset<ICheckCoopRoleCoopLevel> EndICheckCoopRoleCoopLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckCoopRoleCoopLevel>(builder.EndTable());
		}

		// Token: 0x0601D705 RID: 120581 RVA: 0x00425E5C File Offset: 0x0042405C
		public ICheckCoopRoleCoopLevelT UnPack()
		{
			ICheckCoopRoleCoopLevelT checkCoopRoleCoopLevelT = new ICheckCoopRoleCoopLevelT();
			this.UnPackTo(checkCoopRoleCoopLevelT);
			return checkCoopRoleCoopLevelT;
		}

		// Token: 0x0601D706 RID: 120582 RVA: 0x00425E77 File Offset: 0x00424077
		public void UnPackTo(ICheckCoopRoleCoopLevelT _o)
		{
			_o.Type = this.Type;
			_o.CoopRoleId = this.CoopRoleId;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x0601D707 RID: 120583 RVA: 0x00425EAC File Offset: 0x004240AC
		public static Offset<ICheckCoopRoleCoopLevel> Pack(FlatBufferBuilder builder, ICheckCoopRoleCoopLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckCoopRoleCoopLevel>);
			}
			return ICheckCoopRoleCoopLevel.CreateICheckCoopRoleCoopLevel(builder, _o.Type, _o.CoopRoleId, _o.Compare, _o.Level);
		}

		// Token: 0x0400D1CC RID: 53708
		private Table __p;
	}
}
