using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DFA RID: 15866
	public struct IEnterDungeonCondition : IFlatbufferObject
	{
		// Token: 0x17006DA4 RID: 28068
		// (get) Token: 0x06016303 RID: 90883 RVA: 0x0033456D File Offset: 0x0033276D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016304 RID: 90884 RVA: 0x0033457A File Offset: 0x0033277A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016305 RID: 90885 RVA: 0x00334584 File Offset: 0x00332784
		public static IEnterDungeonCondition GetRootAsIEnterDungeonCondition(ByteBuffer _bb)
		{
			return IEnterDungeonCondition.GetRootAsIEnterDungeonCondition(_bb, default(IEnterDungeonCondition));
		}

		// Token: 0x06016306 RID: 90886 RVA: 0x003345A0 File Offset: 0x003327A0
		public static IEnterDungeonCondition GetRootAsIEnterDungeonCondition(ByteBuffer _bb, IEnterDungeonCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016307 RID: 90887 RVA: 0x003345BD File Offset: 0x003327BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016308 RID: 90888 RVA: 0x003345CC File Offset: 0x003327CC
		public IEnterDungeonCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DA5 RID: 28069
		// (get) Token: 0x06016309 RID: 90889 RVA: 0x003345DC File Offset: 0x003327DC
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006DA6 RID: 28070
		// (get) Token: 0x0601630A RID: 90890 RVA: 0x00334618 File Offset: 0x00332818
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006DA7 RID: 28071
		// (get) Token: 0x0601630B RID: 90891 RVA: 0x00334678 File Offset: 0x00332878
		public TEnterDungeon EnterTypeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TEnterDungeon.NONE;
				}
				return (TEnterDungeon)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601630C RID: 90892 RVA: 0x003346B4 File Offset: 0x003328B4
		public TTable? EnterType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601630D RID: 90893 RVA: 0x003346FC File Offset: 0x003328FC
		public IEnterDungeonIdCondition EnterTypeAsIEnterDungeonIdCondition()
		{
			return this.EnterType<IEnterDungeonIdCondition>().Value;
		}

		// Token: 0x0601630E RID: 90894 RVA: 0x00334718 File Offset: 0x00332918
		public IEnterDungeonSubTypeCondition EnterTypeAsIEnterDungeonSubTypeCondition()
		{
			return this.EnterType<IEnterDungeonSubTypeCondition>().Value;
		}

		// Token: 0x0601630F RID: 90895 RVA: 0x00334733 File Offset: 0x00332933
		public static Offset<IEnterDungeonCondition> CreateIEnterDungeonCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TEnterDungeon EnterType_type = TEnterDungeon.NONE, int EnterTypeOffset = 0)
		{
			builder.StartTable(4);
			IEnterDungeonCondition.AddEnterType(builder, EnterTypeOffset);
			IEnterDungeonCondition.AddPreConditions(builder, PreConditionsOffset);
			IEnterDungeonCondition.AddEnterTypeType(builder, EnterType_type);
			IEnterDungeonCondition.AddType(builder, Type);
			return IEnterDungeonCondition.EndIEnterDungeonCondition(builder);
		}

		// Token: 0x06016310 RID: 90896 RVA: 0x0033475F File Offset: 0x0033295F
		public static void StartIEnterDungeonCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016311 RID: 90897 RVA: 0x00334768 File Offset: 0x00332968
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016312 RID: 90898 RVA: 0x00334773 File Offset: 0x00332973
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016313 RID: 90899 RVA: 0x00334783 File Offset: 0x00332983
		public static void AddEnterTypeType(FlatBufferBuilder builder, TEnterDungeon enterTypeType)
		{
			builder.AddByte(2, (byte)enterTypeType, 0);
		}

		// Token: 0x06016314 RID: 90900 RVA: 0x0033478E File Offset: 0x0033298E
		public static void AddEnterType(FlatBufferBuilder builder, int enterTypeOffset)
		{
			builder.AddOffset(3, enterTypeOffset, 0);
		}

		// Token: 0x06016315 RID: 90901 RVA: 0x00334799 File Offset: 0x00332999
		public static Offset<IEnterDungeonCondition> EndIEnterDungeonCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEnterDungeonCondition>(builder.EndTable());
		}

		// Token: 0x06016316 RID: 90902 RVA: 0x003347A8 File Offset: 0x003329A8
		public IEnterDungeonConditionT UnPack()
		{
			IEnterDungeonConditionT enterDungeonConditionT = new IEnterDungeonConditionT();
			this.UnPackTo(enterDungeonConditionT);
			return enterDungeonConditionT;
		}

		// Token: 0x06016317 RID: 90903 RVA: 0x003347C4 File Offset: 0x003329C4
		public void UnPackTo(IEnterDungeonConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.EnterType = new TEnterDungeonUnion();
			_o.EnterType.Type = this.EnterTypeType;
			TEnterDungeon enterTypeType = this.EnterTypeType;
			if (enterTypeType == TEnterDungeon.IEnterDungeonIdCondition)
			{
				_o.EnterType.Value = ((this.EnterType<IEnterDungeonIdCondition>() != null) ? this.EnterType<IEnterDungeonIdCondition>().Value.UnPack() : null);
				return;
			}
			if (enterTypeType != TEnterDungeon.IEnterDungeonSubTypeCondition)
			{
				return;
			}
			_o.EnterType.Value = ((this.EnterType<IEnterDungeonSubTypeCondition>() != null) ? this.EnterType<IEnterDungeonSubTypeCondition>().Value.UnPack() : null);
		}

		// Token: 0x06016318 RID: 90904 RVA: 0x003348A8 File Offset: 0x00332AA8
		public static Offset<IEnterDungeonCondition> Pack(FlatBufferBuilder builder, IEnterDungeonConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterDungeonCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TEnterDungeon enterType_type = (_o.EnterType == null) ? TEnterDungeon.NONE : _o.EnterType.Type;
			int enterTypeOffset = (_o.EnterType == null) ? 0 : TEnterDungeonUnion.Pack(builder, _o.EnterType);
			return IEnterDungeonCondition.CreateIEnterDungeonCondition(builder, _o.Type, preConditionsOffset, enterType_type, enterTypeOffset);
		}

		// Token: 0x0400B764 RID: 46948
		private Table __p;
	}
}
