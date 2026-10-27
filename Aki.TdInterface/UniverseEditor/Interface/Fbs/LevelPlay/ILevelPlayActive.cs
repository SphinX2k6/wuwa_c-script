using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044EB RID: 17643
	public struct ILevelPlayActive : IFlatbufferObject
	{
		// Token: 0x17007D02 RID: 32002
		// (get) Token: 0x0601A78D RID: 108429 RVA: 0x003C8349 File Offset: 0x003C6549
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A78E RID: 108430 RVA: 0x003C8356 File Offset: 0x003C6556
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A78F RID: 108431 RVA: 0x003C8360 File Offset: 0x003C6560
		public static ILevelPlayActive GetRootAsILevelPlayActive(ByteBuffer _bb)
		{
			return ILevelPlayActive.GetRootAsILevelPlayActive(_bb, default(ILevelPlayActive));
		}

		// Token: 0x0601A790 RID: 108432 RVA: 0x003C837C File Offset: 0x003C657C
		public static ILevelPlayActive GetRootAsILevelPlayActive(ByteBuffer _bb, ILevelPlayActive obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A791 RID: 108433 RVA: 0x003C8399 File Offset: 0x003C6599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A792 RID: 108434 RVA: 0x003C83A8 File Offset: 0x003C65A8
		public ILevelPlayActive __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D03 RID: 32003
		// (get) Token: 0x0601A793 RID: 108435 RVA: 0x003C83B8 File Offset: 0x003C65B8
		public ELevelPlayActiveType ActiveType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelPlayActiveType.Default;
				}
				return (ELevelPlayActiveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007D04 RID: 32004
		// (get) Token: 0x0601A794 RID: 108436 RVA: 0x003C83F4 File Offset: 0x003C65F4
		public IConditionGroup? ActiveCondition
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

		// Token: 0x0601A795 RID: 108437 RVA: 0x003C8451 File Offset: 0x003C6651
		public static Offset<ILevelPlayActive> CreateILevelPlayActive(FlatBufferBuilder builder, ELevelPlayActiveType ActiveType = ELevelPlayActiveType.Default, Offset<IConditionGroup> ActiveConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			ILevelPlayActive.AddActiveCondition(builder, ActiveConditionOffset);
			ILevelPlayActive.AddActiveType(builder, ActiveType);
			return ILevelPlayActive.EndILevelPlayActive(builder);
		}

		// Token: 0x0601A796 RID: 108438 RVA: 0x003C846E File Offset: 0x003C666E
		public static void StartILevelPlayActive(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A797 RID: 108439 RVA: 0x003C8477 File Offset: 0x003C6677
		public static void AddActiveType(FlatBufferBuilder builder, ELevelPlayActiveType activeType)
		{
			builder.AddByte(0, (byte)activeType, 0);
		}

		// Token: 0x0601A798 RID: 108440 RVA: 0x003C8482 File Offset: 0x003C6682
		public static void AddActiveCondition(FlatBufferBuilder builder, Offset<IConditionGroup> activeConditionOffset)
		{
			builder.AddOffset(1, activeConditionOffset.Value, 0);
		}

		// Token: 0x0601A799 RID: 108441 RVA: 0x003C8492 File Offset: 0x003C6692
		public static Offset<ILevelPlayActive> EndILevelPlayActive(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayActive>(builder.EndTable());
		}

		// Token: 0x0601A79A RID: 108442 RVA: 0x003C84A0 File Offset: 0x003C66A0
		public ILevelPlayActiveT UnPack()
		{
			ILevelPlayActiveT levelPlayActiveT = new ILevelPlayActiveT();
			this.UnPackTo(levelPlayActiveT);
			return levelPlayActiveT;
		}

		// Token: 0x0601A79B RID: 108443 RVA: 0x003C84BC File Offset: 0x003C66BC
		public void UnPackTo(ILevelPlayActiveT _o)
		{
			_o.ActiveType = this.ActiveType;
			_o.ActiveCondition = ((this.ActiveCondition != null) ? this.ActiveCondition.Value.UnPack() : null);
		}

		// Token: 0x0601A79C RID: 108444 RVA: 0x003C8504 File Offset: 0x003C6704
		public static Offset<ILevelPlayActive> Pack(FlatBufferBuilder builder, ILevelPlayActiveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayActive>);
			}
			Offset<IConditionGroup> activeConditionOffset = (_o.ActiveCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.ActiveCondition);
			return ILevelPlayActive.CreateILevelPlayActive(builder, _o.ActiveType, activeConditionOffset);
		}

		// Token: 0x0400C542 RID: 50498
		private Table __p;
	}
}
