using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004953 RID: 18771
	public struct ILevelPlayActive : IFlatbufferObject
	{
		// Token: 0x17008343 RID: 33603
		// (get) Token: 0x0601BF62 RID: 114530 RVA: 0x003F45E8 File Offset: 0x003F27E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BF63 RID: 114531 RVA: 0x003F45F5 File Offset: 0x003F27F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BF64 RID: 114532 RVA: 0x003F45FC File Offset: 0x003F27FC
		public static ILevelPlayActive GetRootAsILevelPlayActive(ByteBuffer _bb)
		{
			return ILevelPlayActive.GetRootAsILevelPlayActive(_bb, default(ILevelPlayActive));
		}

		// Token: 0x0601BF65 RID: 114533 RVA: 0x003F4618 File Offset: 0x003F2818
		public static ILevelPlayActive GetRootAsILevelPlayActive(ByteBuffer _bb, ILevelPlayActive obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BF66 RID: 114534 RVA: 0x003F4635 File Offset: 0x003F2835
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BF67 RID: 114535 RVA: 0x003F4644 File Offset: 0x003F2844
		public ILevelPlayActive __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008344 RID: 33604
		// (get) Token: 0x0601BF68 RID: 114536 RVA: 0x003F4654 File Offset: 0x003F2854
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

		// Token: 0x17008345 RID: 33605
		// (get) Token: 0x0601BF69 RID: 114537 RVA: 0x003F4690 File Offset: 0x003F2890
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

		// Token: 0x0601BF6A RID: 114538 RVA: 0x003F46ED File Offset: 0x003F28ED
		public static Offset<ILevelPlayActive> CreateILevelPlayActive(FlatBufferBuilder builder, ELevelPlayActiveType ActiveType = ELevelPlayActiveType.Default, Offset<IConditionGroup> ActiveConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			ILevelPlayActive.AddActiveCondition(builder, ActiveConditionOffset);
			ILevelPlayActive.AddActiveType(builder, ActiveType);
			return ILevelPlayActive.EndILevelPlayActive(builder);
		}

		// Token: 0x0601BF6B RID: 114539 RVA: 0x003F470A File Offset: 0x003F290A
		public static void StartILevelPlayActive(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601BF6C RID: 114540 RVA: 0x003F4713 File Offset: 0x003F2913
		public static void AddActiveType(FlatBufferBuilder builder, ELevelPlayActiveType activeType)
		{
			builder.AddByte(0, (byte)activeType, 0);
		}

		// Token: 0x0601BF6D RID: 114541 RVA: 0x003F471E File Offset: 0x003F291E
		public static void AddActiveCondition(FlatBufferBuilder builder, Offset<IConditionGroup> activeConditionOffset)
		{
			builder.AddOffset(1, activeConditionOffset.Value, 0);
		}

		// Token: 0x0601BF6E RID: 114542 RVA: 0x003F472E File Offset: 0x003F292E
		public static Offset<ILevelPlayActive> EndILevelPlayActive(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayActive>(builder.EndTable());
		}

		// Token: 0x0601BF6F RID: 114543 RVA: 0x003F473C File Offset: 0x003F293C
		public ILevelPlayActiveT UnPack()
		{
			ILevelPlayActiveT levelPlayActiveT = new ILevelPlayActiveT();
			this.UnPackTo(levelPlayActiveT);
			return levelPlayActiveT;
		}

		// Token: 0x0601BF70 RID: 114544 RVA: 0x003F4758 File Offset: 0x003F2958
		public void UnPackTo(ILevelPlayActiveT _o)
		{
			_o.ActiveType = this.ActiveType;
			_o.ActiveCondition = ((this.ActiveCondition != null) ? this.ActiveCondition.Value.UnPack() : null);
		}

		// Token: 0x0601BF71 RID: 114545 RVA: 0x003F47A0 File Offset: 0x003F29A0
		public static Offset<ILevelPlayActive> Pack(FlatBufferBuilder builder, ILevelPlayActiveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayActive>);
			}
			Offset<IConditionGroup> activeConditionOffset = (_o.ActiveCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.ActiveCondition);
			return ILevelPlayActive.CreateILevelPlayActive(builder, _o.ActiveType, activeConditionOffset);
		}

		// Token: 0x0400CF71 RID: 53105
		private Table __p;
	}
}
