using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006970 RID: 26992
	public struct IChangeIcon : IFlatbufferObject
	{
		// Token: 0x1700C6B4 RID: 50868
		// (get) Token: 0x0602E482 RID: 189570 RVA: 0x00651CEE File Offset: 0x0064FEEE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E483 RID: 189571 RVA: 0x00651CFB File Offset: 0x0064FEFB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E484 RID: 189572 RVA: 0x00651D04 File Offset: 0x0064FF04
		public static IChangeIcon GetRootAsIChangeIcon(ByteBuffer _bb)
		{
			return IChangeIcon.GetRootAsIChangeIcon(_bb, default(IChangeIcon));
		}

		// Token: 0x0602E485 RID: 189573 RVA: 0x00651D20 File Offset: 0x0064FF20
		public static IChangeIcon GetRootAsIChangeIcon(ByteBuffer _bb, IChangeIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E486 RID: 189574 RVA: 0x00651D3D File Offset: 0x0064FF3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E487 RID: 189575 RVA: 0x00651D4C File Offset: 0x0064FF4C
		public IChangeIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6B5 RID: 50869
		// (get) Token: 0x0602E488 RID: 189576 RVA: 0x00651D5C File Offset: 0x0064FF5C
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

		// Token: 0x1700C6B6 RID: 50870
		// (get) Token: 0x0602E489 RID: 189577 RVA: 0x00651D98 File Offset: 0x0064FF98
		public bool ChangeWhenSelectedInCurrentTalk
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C6B7 RID: 50871
		// (get) Token: 0x0602E48A RID: 189578 RVA: 0x00651DD8 File Offset: 0x0064FFD8
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

		// Token: 0x1700C6B8 RID: 50872
		// (get) Token: 0x0602E48B RID: 189579 RVA: 0x00651E38 File Offset: 0x00650038
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

		// Token: 0x0602E48C RID: 189580 RVA: 0x00651E75 File Offset: 0x00650075
		public static Offset<IChangeIcon> CreateIChangeIcon(FlatBufferBuilder builder, int Icon = 0, bool ChangeWhenSelectedInCurrentTalk = false, Offset<IConditionGroup> ChangeWhenMatchConditionsOffset = default(Offset<IConditionGroup>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IChangeIcon.AddChangeWhenMatchConditions(builder, ChangeWhenMatchConditionsOffset);
			IChangeIcon.AddIcon(builder, Icon);
			IChangeIcon.AddNullMask(builder, NullMask);
			IChangeIcon.AddChangeWhenSelectedInCurrentTalk(builder, ChangeWhenSelectedInCurrentTalk);
			return IChangeIcon.EndIChangeIcon(builder);
		}

		// Token: 0x0602E48D RID: 189581 RVA: 0x00651EA1 File Offset: 0x006500A1
		public static void StartIChangeIcon(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602E48E RID: 189582 RVA: 0x00651EAA File Offset: 0x006500AA
		public static void AddIcon(FlatBufferBuilder builder, int icon)
		{
			builder.AddInt(0, icon, 0);
		}

		// Token: 0x0602E48F RID: 189583 RVA: 0x00651EB5 File Offset: 0x006500B5
		public static void AddChangeWhenSelectedInCurrentTalk(FlatBufferBuilder builder, bool changeWhenSelectedInCurrentTalk)
		{
			builder.AddBool(1, changeWhenSelectedInCurrentTalk, false);
		}

		// Token: 0x0602E490 RID: 189584 RVA: 0x00651EC0 File Offset: 0x006500C0
		public static void AddChangeWhenMatchConditions(FlatBufferBuilder builder, Offset<IConditionGroup> changeWhenMatchConditionsOffset)
		{
			builder.AddOffset(2, changeWhenMatchConditionsOffset.Value, 0);
		}

		// Token: 0x0602E491 RID: 189585 RVA: 0x00651ED0 File Offset: 0x006500D0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602E492 RID: 189586 RVA: 0x00651EDB File Offset: 0x006500DB
		public static Offset<IChangeIcon> EndIChangeIcon(FlatBufferBuilder builder)
		{
			return new Offset<IChangeIcon>(builder.EndTable());
		}

		// Token: 0x0602E493 RID: 189587 RVA: 0x00651EE8 File Offset: 0x006500E8
		public IChangeIconT UnPack()
		{
			IChangeIconT changeIconT = new IChangeIconT();
			this.UnPackTo(changeIconT);
			return changeIconT;
		}

		// Token: 0x0602E494 RID: 189588 RVA: 0x00651F04 File Offset: 0x00650104
		public void UnPackTo(IChangeIconT _o)
		{
			_o.Icon = this.Icon;
			_o.ChangeWhenSelectedInCurrentTalk = this.ChangeWhenSelectedInCurrentTalk;
			_o.ChangeWhenMatchConditions = ((this.ChangeWhenMatchConditions != null) ? this.ChangeWhenMatchConditions.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E495 RID: 189589 RVA: 0x00651F64 File Offset: 0x00650164
		public static Offset<IChangeIcon> Pack(FlatBufferBuilder builder, IChangeIconT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeIcon>);
			}
			Offset<IConditionGroup> changeWhenMatchConditionsOffset = (_o.ChangeWhenMatchConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.ChangeWhenMatchConditions);
			return IChangeIcon.CreateIChangeIcon(builder, _o.Icon, _o.ChangeWhenSelectedInCurrentTalk, changeWhenMatchConditionsOffset, _o.NullMask);
		}

		// Token: 0x040116D2 RID: 71378
		private Table __p;
	}
}
