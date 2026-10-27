using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E44 RID: 20036
	public struct IActionByHitTypeConfig : IFlatbufferObject
	{
		// Token: 0x17008F62 RID: 36706
		// (get) Token: 0x0601F700 RID: 128768 RVA: 0x0046125F File Offset: 0x0045F45F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F701 RID: 128769 RVA: 0x0046126C File Offset: 0x0045F46C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F702 RID: 128770 RVA: 0x00461274 File Offset: 0x0045F474
		public static IActionByHitTypeConfig GetRootAsIActionByHitTypeConfig(ByteBuffer _bb)
		{
			return IActionByHitTypeConfig.GetRootAsIActionByHitTypeConfig(_bb, default(IActionByHitTypeConfig));
		}

		// Token: 0x0601F703 RID: 128771 RVA: 0x00461290 File Offset: 0x0045F490
		public static IActionByHitTypeConfig GetRootAsIActionByHitTypeConfig(ByteBuffer _bb, IActionByHitTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F704 RID: 128772 RVA: 0x004612AD File Offset: 0x0045F4AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F705 RID: 128773 RVA: 0x004612BC File Offset: 0x0045F4BC
		public IActionByHitTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F63 RID: 36707
		// (get) Token: 0x0601F706 RID: 128774 RVA: 0x004612CC File Offset: 0x0045F4CC
		public THitBulletType HitBulletsType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return THitBulletType.NONE;
				}
				return (THitBulletType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F707 RID: 128775 RVA: 0x00461308 File Offset: 0x0045F508
		public TTable? HitBullets<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F708 RID: 128776 RVA: 0x0046134C File Offset: 0x0045F54C
		public IHitBulletTypeAllCharacterAttack HitBulletsAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullets<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x0601F709 RID: 128777 RVA: 0x00461368 File Offset: 0x0045F568
		public IHitBulletTypeCrystalAttack HitBulletsAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullets<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x0601F70A RID: 128778 RVA: 0x00461384 File Offset: 0x0045F584
		public IHitBulletTypeFixedBulletId HitBulletsAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullets<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x0601F70B RID: 128779 RVA: 0x004613A0 File Offset: 0x0045F5A0
		public IHitBulletTypeOnlyDropAttack HitBulletsAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullets<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x0601F70C RID: 128780 RVA: 0x004613BC File Offset: 0x0045F5BC
		public IHitBulletTypePlayerAttack HitBulletsAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullets<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x0601F70D RID: 128781 RVA: 0x004613D8 File Offset: 0x0045F5D8
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletsAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullets<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x17008F64 RID: 36708
		// (get) Token: 0x0601F70E RID: 128782 RVA: 0x004613F4 File Offset: 0x0045F5F4
		public IConditionGroup? Condition
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

		// Token: 0x0601F70F RID: 128783 RVA: 0x00461454 File Offset: 0x0045F654
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008F65 RID: 36709
		// (get) Token: 0x0601F710 RID: 128784 RVA: 0x004614B8 File Offset: 0x0045F6B8
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17008F66 RID: 36710
		// (get) Token: 0x0601F711 RID: 128785 RVA: 0x004614E4 File Offset: 0x0045F6E4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F712 RID: 128786 RVA: 0x00461521 File Offset: 0x0045F721
		public static Offset<IActionByHitTypeConfig> CreateIActionByHitTypeConfig(FlatBufferBuilder builder, THitBulletType HitBullets_type = THitBulletType.NONE, int HitBulletsOffset = 0, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IActionByHitTypeConfig.AddActions(builder, ActionsOffset);
			IActionByHitTypeConfig.AddCondition(builder, ConditionOffset);
			IActionByHitTypeConfig.AddHitBullets(builder, HitBulletsOffset);
			IActionByHitTypeConfig.AddNullMask(builder, NullMask);
			IActionByHitTypeConfig.AddHitBulletsType(builder, HitBullets_type);
			return IActionByHitTypeConfig.EndIActionByHitTypeConfig(builder);
		}

		// Token: 0x0601F713 RID: 128787 RVA: 0x00461555 File Offset: 0x0045F755
		public static void StartIActionByHitTypeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601F714 RID: 128788 RVA: 0x0046155E File Offset: 0x0045F75E
		public static void AddHitBulletsType(FlatBufferBuilder builder, THitBulletType hitBulletsType)
		{
			builder.AddByte(0, (byte)hitBulletsType, 0);
		}

		// Token: 0x0601F715 RID: 128789 RVA: 0x00461569 File Offset: 0x0045F769
		public static void AddHitBullets(FlatBufferBuilder builder, int hitBulletsOffset)
		{
			builder.AddOffset(1, hitBulletsOffset, 0);
		}

		// Token: 0x0601F716 RID: 128790 RVA: 0x00461574 File Offset: 0x0045F774
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(2, conditionOffset.Value, 0);
		}

		// Token: 0x0601F717 RID: 128791 RVA: 0x00461584 File Offset: 0x0045F784
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(3, actionsOffset.Value, 0);
		}

		// Token: 0x0601F718 RID: 128792 RVA: 0x00461594 File Offset: 0x0045F794
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F719 RID: 128793 RVA: 0x004615D4 File Offset: 0x0045F7D4
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F71A RID: 128794 RVA: 0x004615EE File Offset: 0x0045F7EE
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F71B RID: 128795 RVA: 0x0046160C File Offset: 0x0045F80C
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F71C RID: 128796 RVA: 0x00461625 File Offset: 0x0045F825
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F71D RID: 128797 RVA: 0x00461630 File Offset: 0x0045F830
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601F71E RID: 128798 RVA: 0x0046163B File Offset: 0x0045F83B
		public static Offset<IActionByHitTypeConfig> EndIActionByHitTypeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IActionByHitTypeConfig>(builder.EndTable());
		}

		// Token: 0x0601F71F RID: 128799 RVA: 0x00461648 File Offset: 0x0045F848
		public IActionByHitTypeConfigT UnPack()
		{
			IActionByHitTypeConfigT actionByHitTypeConfigT = new IActionByHitTypeConfigT();
			this.UnPackTo(actionByHitTypeConfigT);
			return actionByHitTypeConfigT;
		}

		// Token: 0x0601F720 RID: 128800 RVA: 0x00461664 File Offset: 0x0045F864
		public void UnPackTo(IActionByHitTypeConfigT _o)
		{
			_o.HitBullets = new THitBulletTypeUnion();
			_o.HitBullets.Type = this.HitBulletsType;
			switch (this.HitBulletsType)
			{
			case THitBulletType.IHitBulletTypeAllCharacterAttack:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypeAllCharacterAttack>() != null) ? this.HitBullets<IHitBulletTypeAllCharacterAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeCrystalAttack:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypeCrystalAttack>() != null) ? this.HitBullets<IHitBulletTypeCrystalAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeFixedBulletId:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypeFixedBulletId>() != null) ? this.HitBullets<IHitBulletTypeFixedBulletId>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeOnlyDropAttack:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypeOnlyDropAttack>() != null) ? this.HitBullets<IHitBulletTypeOnlyDropAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypePlayerAttack:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypePlayerAttack>() != null) ? this.HitBullets<IHitBulletTypePlayerAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypePlayerOrThrenodianAttack:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypePlayerOrThrenodianAttack>() != null) ? this.HitBullets<IHitBulletTypePlayerOrThrenodianAttack>().Value.UnPack() : null);
				break;
			}
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F721 RID: 128801 RVA: 0x004618AC File Offset: 0x0045FAAC
		public static Offset<IActionByHitTypeConfig> Pack(FlatBufferBuilder builder, IActionByHitTypeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActionByHitTypeConfig>);
			}
			THitBulletType hitBullets_type = (_o.HitBullets == null) ? THitBulletType.NONE : _o.HitBullets.Type;
			int hitBulletsOffset = (_o.HitBullets == null) ? 0 : THitBulletTypeUnion.Pack(builder, _o.HitBullets);
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IActionByHitTypeConfig.CreateActionsVector(builder, array);
			}
			return IActionByHitTypeConfig.CreateIActionByHitTypeConfig(builder, hitBullets_type, hitBulletsOffset, conditionOffset, actionsOffset, _o.NullMask);
		}

		// Token: 0x0400DBDE RID: 56286
		private Table __p;
	}
}
