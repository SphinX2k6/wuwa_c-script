using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004235 RID: 16949
	public struct IEnterDungeonCondition : IFlatbufferObject
	{
		// Token: 0x1700738A RID: 29578
		// (get) Token: 0x06017930 RID: 96560 RVA: 0x0035D165 File Offset: 0x0035B365
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017931 RID: 96561 RVA: 0x0035D172 File Offset: 0x0035B372
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017932 RID: 96562 RVA: 0x0035D17C File Offset: 0x0035B37C
		public static IEnterDungeonCondition GetRootAsIEnterDungeonCondition(ByteBuffer _bb)
		{
			return IEnterDungeonCondition.GetRootAsIEnterDungeonCondition(_bb, default(IEnterDungeonCondition));
		}

		// Token: 0x06017933 RID: 96563 RVA: 0x0035D198 File Offset: 0x0035B398
		public static IEnterDungeonCondition GetRootAsIEnterDungeonCondition(ByteBuffer _bb, IEnterDungeonCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017934 RID: 96564 RVA: 0x0035D1B5 File Offset: 0x0035B3B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017935 RID: 96565 RVA: 0x0035D1C4 File Offset: 0x0035B3C4
		public IEnterDungeonCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700738B RID: 29579
		// (get) Token: 0x06017936 RID: 96566 RVA: 0x0035D1D4 File Offset: 0x0035B3D4
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

		// Token: 0x1700738C RID: 29580
		// (get) Token: 0x06017937 RID: 96567 RVA: 0x0035D210 File Offset: 0x0035B410
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

		// Token: 0x1700738D RID: 29581
		// (get) Token: 0x06017938 RID: 96568 RVA: 0x0035D270 File Offset: 0x0035B470
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

		// Token: 0x06017939 RID: 96569 RVA: 0x0035D2AC File Offset: 0x0035B4AC
		public TTable? EnterType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601793A RID: 96570 RVA: 0x0035D2F4 File Offset: 0x0035B4F4
		public IEnterDungeonIdCondition EnterTypeAsIEnterDungeonIdCondition()
		{
			return this.EnterType<IEnterDungeonIdCondition>().Value;
		}

		// Token: 0x0601793B RID: 96571 RVA: 0x0035D310 File Offset: 0x0035B510
		public IEnterDungeonSubTypeCondition EnterTypeAsIEnterDungeonSubTypeCondition()
		{
			return this.EnterType<IEnterDungeonSubTypeCondition>().Value;
		}

		// Token: 0x0601793C RID: 96572 RVA: 0x0035D32B File Offset: 0x0035B52B
		public static Offset<IEnterDungeonCondition> CreateIEnterDungeonCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TEnterDungeon EnterType_type = TEnterDungeon.NONE, int EnterTypeOffset = 0)
		{
			builder.StartTable(4);
			IEnterDungeonCondition.AddEnterType(builder, EnterTypeOffset);
			IEnterDungeonCondition.AddPreConditions(builder, PreConditionsOffset);
			IEnterDungeonCondition.AddEnterTypeType(builder, EnterType_type);
			IEnterDungeonCondition.AddType(builder, Type);
			return IEnterDungeonCondition.EndIEnterDungeonCondition(builder);
		}

		// Token: 0x0601793D RID: 96573 RVA: 0x0035D357 File Offset: 0x0035B557
		public static void StartIEnterDungeonCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601793E RID: 96574 RVA: 0x0035D360 File Offset: 0x0035B560
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601793F RID: 96575 RVA: 0x0035D36B File Offset: 0x0035B56B
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017940 RID: 96576 RVA: 0x0035D37B File Offset: 0x0035B57B
		public static void AddEnterTypeType(FlatBufferBuilder builder, TEnterDungeon enterTypeType)
		{
			builder.AddByte(2, (byte)enterTypeType, 0);
		}

		// Token: 0x06017941 RID: 96577 RVA: 0x0035D386 File Offset: 0x0035B586
		public static void AddEnterType(FlatBufferBuilder builder, int enterTypeOffset)
		{
			builder.AddOffset(3, enterTypeOffset, 0);
		}

		// Token: 0x06017942 RID: 96578 RVA: 0x0035D391 File Offset: 0x0035B591
		public static Offset<IEnterDungeonCondition> EndIEnterDungeonCondition(FlatBufferBuilder builder)
		{
			return new Offset<IEnterDungeonCondition>(builder.EndTable());
		}

		// Token: 0x06017943 RID: 96579 RVA: 0x0035D3A0 File Offset: 0x0035B5A0
		public IEnterDungeonConditionT UnPack()
		{
			IEnterDungeonConditionT enterDungeonConditionT = new IEnterDungeonConditionT();
			this.UnPackTo(enterDungeonConditionT);
			return enterDungeonConditionT;
		}

		// Token: 0x06017944 RID: 96580 RVA: 0x0035D3BC File Offset: 0x0035B5BC
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

		// Token: 0x06017945 RID: 96581 RVA: 0x0035D4A0 File Offset: 0x0035B6A0
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

		// Token: 0x0400C13C RID: 49468
		private Table __p;
	}
}
