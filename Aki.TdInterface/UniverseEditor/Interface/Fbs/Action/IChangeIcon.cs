using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062FF RID: 25343
	public struct IChangeIcon : IFlatbufferObject
	{
		// Token: 0x1700BD2A RID: 48426
		// (get) Token: 0x0602BD19 RID: 179481 RVA: 0x00606CE2 File Offset: 0x00604EE2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BD1A RID: 179482 RVA: 0x00606CEF File Offset: 0x00604EEF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BD1B RID: 179483 RVA: 0x00606CF8 File Offset: 0x00604EF8
		public static IChangeIcon GetRootAsIChangeIcon(ByteBuffer _bb)
		{
			return IChangeIcon.GetRootAsIChangeIcon(_bb, default(IChangeIcon));
		}

		// Token: 0x0602BD1C RID: 179484 RVA: 0x00606D14 File Offset: 0x00604F14
		public static IChangeIcon GetRootAsIChangeIcon(ByteBuffer _bb, IChangeIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BD1D RID: 179485 RVA: 0x00606D31 File Offset: 0x00604F31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BD1E RID: 179486 RVA: 0x00606D40 File Offset: 0x00604F40
		public IChangeIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD2B RID: 48427
		// (get) Token: 0x0602BD1F RID: 179487 RVA: 0x00606D50 File Offset: 0x00604F50
		public int Icon
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD2C RID: 48428
		// (get) Token: 0x0602BD20 RID: 179488 RVA: 0x00606D8C File Offset: 0x00604F8C
		public bool ChangeWhenSelectedInCurrentTalk
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BD2D RID: 48429
		// (get) Token: 0x0602BD21 RID: 179489 RVA: 0x00606DCC File Offset: 0x00604FCC
		public IConditionGroup? ChangeWhenMatchConditions
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BD2E RID: 48430
		// (get) Token: 0x0602BD22 RID: 179490 RVA: 0x00606E2C File Offset: 0x0060502C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BD23 RID: 179491 RVA: 0x00606E69 File Offset: 0x00605069
		public static Offset<IChangeIcon> CreateIChangeIcon(FlatBufferBuilder builder, int Icon = 0, bool ChangeWhenSelectedInCurrentTalk = false, Offset<IConditionGroup> ChangeWhenMatchConditionsOffset = default(Offset<IConditionGroup>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IChangeIcon.AddChangeWhenMatchConditions(builder, ChangeWhenMatchConditionsOffset);
			IChangeIcon.AddIcon(builder, Icon);
			IChangeIcon.AddNullMask(builder, NullMask);
			IChangeIcon.AddChangeWhenSelectedInCurrentTalk(builder, ChangeWhenSelectedInCurrentTalk);
			return IChangeIcon.EndIChangeIcon(builder);
		}

		// Token: 0x0602BD24 RID: 179492 RVA: 0x00606E95 File Offset: 0x00605095
		public static void StartIChangeIcon(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602BD25 RID: 179493 RVA: 0x00606E9E File Offset: 0x0060509E
		public static void AddIcon(FlatBufferBuilder builder, int icon)
		{
			builder.AddInt(0, icon, 0);
		}

		// Token: 0x0602BD26 RID: 179494 RVA: 0x00606EA9 File Offset: 0x006050A9
		public static void AddChangeWhenSelectedInCurrentTalk(FlatBufferBuilder builder, bool changeWhenSelectedInCurrentTalk)
		{
			builder.AddBool(1, changeWhenSelectedInCurrentTalk, false);
		}

		// Token: 0x0602BD27 RID: 179495 RVA: 0x00606EB4 File Offset: 0x006050B4
		public static void AddChangeWhenMatchConditions(FlatBufferBuilder builder, Offset<IConditionGroup> changeWhenMatchConditionsOffset)
		{
			builder.AddOffset(2, changeWhenMatchConditionsOffset.Value, 0);
		}

		// Token: 0x0602BD28 RID: 179496 RVA: 0x00606EC4 File Offset: 0x006050C4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602BD29 RID: 179497 RVA: 0x00606ECF File Offset: 0x006050CF
		public static Offset<IChangeIcon> EndIChangeIcon(FlatBufferBuilder builder)
		{
			return new Offset<IChangeIcon>(builder.EndTable());
		}

		// Token: 0x0602BD2A RID: 179498 RVA: 0x00606EDC File Offset: 0x006050DC
		public IChangeIconT UnPack()
		{
			IChangeIconT changeIconT = new IChangeIconT();
			this.UnPackTo(changeIconT);
			return changeIconT;
		}

		// Token: 0x0602BD2B RID: 179499 RVA: 0x00606EF8 File Offset: 0x006050F8
		public void UnPackTo(IChangeIconT _o)
		{
			_o.Icon = this.Icon;
			_o.ChangeWhenSelectedInCurrentTalk = this.ChangeWhenSelectedInCurrentTalk;
			_o.ChangeWhenMatchConditions = ((this.ChangeWhenMatchConditions != null) ? this.ChangeWhenMatchConditions.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602BD2C RID: 179500 RVA: 0x00606F58 File Offset: 0x00605158
		public static Offset<IChangeIcon> Pack(FlatBufferBuilder builder, IChangeIconT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeIcon>);
			}
			Offset<IConditionGroup> changeWhenMatchConditionsOffset = (_o.ChangeWhenMatchConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.ChangeWhenMatchConditions);
			return IChangeIcon.CreateIChangeIcon(builder, _o.Icon, _o.ChangeWhenSelectedInCurrentTalk, changeWhenMatchConditionsOffset, _o.NullMask);
		}

		// Token: 0x040108BC RID: 67772
		private Table __p;
	}
}
