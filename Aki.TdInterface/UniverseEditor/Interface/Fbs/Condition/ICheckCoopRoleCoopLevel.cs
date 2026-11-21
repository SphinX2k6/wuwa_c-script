using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E66 RID: 20070
	public struct ICheckCoopRoleCoopLevel : IFlatbufferObject
	{
		// Token: 0x17008F1A RID: 36634
		// (get) Token: 0x0601F133 RID: 127283 RVA: 0x004563D6 File Offset: 0x004545D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F134 RID: 127284 RVA: 0x004563E3 File Offset: 0x004545E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F135 RID: 127285 RVA: 0x004563EC File Offset: 0x004545EC
		public static ICheckCoopRoleCoopLevel GetRootAsICheckCoopRoleCoopLevel(ByteBuffer _bb)
		{
			return ICheckCoopRoleCoopLevel.GetRootAsICheckCoopRoleCoopLevel(_bb, default(ICheckCoopRoleCoopLevel));
		}

		// Token: 0x0601F136 RID: 127286 RVA: 0x00456408 File Offset: 0x00454608
		public static ICheckCoopRoleCoopLevel GetRootAsICheckCoopRoleCoopLevel(ByteBuffer _bb, ICheckCoopRoleCoopLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F137 RID: 127287 RVA: 0x00456425 File Offset: 0x00454625
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F138 RID: 127288 RVA: 0x00456434 File Offset: 0x00454634
		public ICheckCoopRoleCoopLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F1B RID: 36635
		// (get) Token: 0x0601F139 RID: 127289 RVA: 0x00456444 File Offset: 0x00454644
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

		// Token: 0x17008F1C RID: 36636
		// (get) Token: 0x0601F13A RID: 127290 RVA: 0x00456480 File Offset: 0x00454680
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

		// Token: 0x17008F1D RID: 36637
		// (get) Token: 0x0601F13B RID: 127291 RVA: 0x004564BC File Offset: 0x004546BC
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

		// Token: 0x17008F1E RID: 36638
		// (get) Token: 0x0601F13C RID: 127292 RVA: 0x004564F8 File Offset: 0x004546F8
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

		// Token: 0x0601F13D RID: 127293 RVA: 0x00456535 File Offset: 0x00454735
		public static Offset<ICheckCoopRoleCoopLevel> CreateICheckCoopRoleCoopLevel(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int CoopRoleId = 0, ECompare Compare = ECompare.Eq, int Level = 0)
		{
			builder.StartTable(4);
			ICheckCoopRoleCoopLevel.AddLevel(builder, Level);
			ICheckCoopRoleCoopLevel.AddCoopRoleId(builder, CoopRoleId);
			ICheckCoopRoleCoopLevel.AddCompare(builder, Compare);
			ICheckCoopRoleCoopLevel.AddType(builder, Type);
			return ICheckCoopRoleCoopLevel.EndICheckCoopRoleCoopLevel(builder);
		}

		// Token: 0x0601F13E RID: 127294 RVA: 0x00456561 File Offset: 0x00454761
		public static void StartICheckCoopRoleCoopLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F13F RID: 127295 RVA: 0x0045656A File Offset: 0x0045476A
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F140 RID: 127296 RVA: 0x00456575 File Offset: 0x00454775
		public static void AddCoopRoleId(FlatBufferBuilder builder, int coopRoleId)
		{
			builder.AddInt(1, coopRoleId, 0);
		}

		// Token: 0x0601F141 RID: 127297 RVA: 0x00456580 File Offset: 0x00454780
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601F142 RID: 127298 RVA: 0x0045658B File Offset: 0x0045478B
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(3, level, 0);
		}

		// Token: 0x0601F143 RID: 127299 RVA: 0x00456596 File Offset: 0x00454796
		public static Offset<ICheckCoopRoleCoopLevel> EndICheckCoopRoleCoopLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckCoopRoleCoopLevel>(builder.EndTable());
		}

		// Token: 0x0601F144 RID: 127300 RVA: 0x004565A4 File Offset: 0x004547A4
		public ICheckCoopRoleCoopLevelT UnPack()
		{
			ICheckCoopRoleCoopLevelT checkCoopRoleCoopLevelT = new ICheckCoopRoleCoopLevelT();
			this.UnPackTo(checkCoopRoleCoopLevelT);
			return checkCoopRoleCoopLevelT;
		}

		// Token: 0x0601F145 RID: 127301 RVA: 0x004565BF File Offset: 0x004547BF
		public void UnPackTo(ICheckCoopRoleCoopLevelT _o)
		{
			_o.Type = this.Type;
			_o.CoopRoleId = this.CoopRoleId;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x0601F146 RID: 127302 RVA: 0x004565F4 File Offset: 0x004547F4
		public static Offset<ICheckCoopRoleCoopLevel> Pack(FlatBufferBuilder builder, ICheckCoopRoleCoopLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckCoopRoleCoopLevel>);
			}
			return ICheckCoopRoleCoopLevel.CreateICheckCoopRoleCoopLevel(builder, _o.Type, _o.CoopRoleId, _o.Compare, _o.Level);
		}

		// Token: 0x0400DC98 RID: 56472
		private Table __p;
	}
}
