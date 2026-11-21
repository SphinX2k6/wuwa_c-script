using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005355 RID: 21333
	public struct IActionByHitTypeConfig : IFlatbufferObject
	{
		// Token: 0x1700969B RID: 38555
		// (get) Token: 0x0602134B RID: 136011 RVA: 0x00495277 File Offset: 0x00493477
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602134C RID: 136012 RVA: 0x00495284 File Offset: 0x00493484
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602134D RID: 136013 RVA: 0x0049528C File Offset: 0x0049348C
		public static IActionByHitTypeConfig GetRootAsIActionByHitTypeConfig(ByteBuffer _bb)
		{
			return IActionByHitTypeConfig.GetRootAsIActionByHitTypeConfig(_bb, default(IActionByHitTypeConfig));
		}

		// Token: 0x0602134E RID: 136014 RVA: 0x004952A8 File Offset: 0x004934A8
		public static IActionByHitTypeConfig GetRootAsIActionByHitTypeConfig(ByteBuffer _bb, IActionByHitTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602134F RID: 136015 RVA: 0x004952C5 File Offset: 0x004934C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021350 RID: 136016 RVA: 0x004952D4 File Offset: 0x004934D4
		public IActionByHitTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700969C RID: 38556
		// (get) Token: 0x06021351 RID: 136017 RVA: 0x004952E4 File Offset: 0x004934E4
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

		// Token: 0x06021352 RID: 136018 RVA: 0x00495320 File Offset: 0x00493520
		public TTable? HitBullets<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06021353 RID: 136019 RVA: 0x00495364 File Offset: 0x00493564
		public IHitBulletTypeAllCharacterAttack HitBulletsAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullets<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x06021354 RID: 136020 RVA: 0x00495380 File Offset: 0x00493580
		public IHitBulletTypeCrystalAttack HitBulletsAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullets<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x06021355 RID: 136021 RVA: 0x0049539C File Offset: 0x0049359C
		public IHitBulletTypeFixedBulletId HitBulletsAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullets<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x06021356 RID: 136022 RVA: 0x004953B8 File Offset: 0x004935B8
		public IHitBulletTypeOnlyDropAttack HitBulletsAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullets<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x06021357 RID: 136023 RVA: 0x004953D4 File Offset: 0x004935D4
		public IHitBulletTypePlayerAttack HitBulletsAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullets<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x06021358 RID: 136024 RVA: 0x004953F0 File Offset: 0x004935F0
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletsAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullets<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x1700969D RID: 38557
		// (get) Token: 0x06021359 RID: 136025 RVA: 0x0049540C File Offset: 0x0049360C
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

		// Token: 0x0602135A RID: 136026 RVA: 0x0049546C File Offset: 0x0049366C
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700969E RID: 38558
		// (get) Token: 0x0602135B RID: 136027 RVA: 0x004954D0 File Offset: 0x004936D0
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

		// Token: 0x1700969F RID: 38559
		// (get) Token: 0x0602135C RID: 136028 RVA: 0x004954FC File Offset: 0x004936FC
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

		// Token: 0x0602135D RID: 136029 RVA: 0x00495539 File Offset: 0x00493739
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

		// Token: 0x0602135E RID: 136030 RVA: 0x0049556D File Offset: 0x0049376D
		public static void StartIActionByHitTypeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602135F RID: 136031 RVA: 0x00495576 File Offset: 0x00493776
		public static void AddHitBulletsType(FlatBufferBuilder builder, THitBulletType hitBulletsType)
		{
			builder.AddByte(0, (byte)hitBulletsType, 0);
		}

		// Token: 0x06021360 RID: 136032 RVA: 0x00495581 File Offset: 0x00493781
		public static void AddHitBullets(FlatBufferBuilder builder, int hitBulletsOffset)
		{
			builder.AddOffset(1, hitBulletsOffset, 0);
		}

		// Token: 0x06021361 RID: 136033 RVA: 0x0049558C File Offset: 0x0049378C
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(2, conditionOffset.Value, 0);
		}

		// Token: 0x06021362 RID: 136034 RVA: 0x0049559C File Offset: 0x0049379C
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(3, actionsOffset.Value, 0);
		}

		// Token: 0x06021363 RID: 136035 RVA: 0x004955AC File Offset: 0x004937AC
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021364 RID: 136036 RVA: 0x004955EC File Offset: 0x004937EC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021365 RID: 136037 RVA: 0x00495606 File Offset: 0x00493806
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021366 RID: 136038 RVA: 0x00495624 File Offset: 0x00493824
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021367 RID: 136039 RVA: 0x0049563D File Offset: 0x0049383D
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021368 RID: 136040 RVA: 0x00495648 File Offset: 0x00493848
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06021369 RID: 136041 RVA: 0x00495653 File Offset: 0x00493853
		public static Offset<IActionByHitTypeConfig> EndIActionByHitTypeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IActionByHitTypeConfig>(builder.EndTable());
		}

		// Token: 0x0602136A RID: 136042 RVA: 0x00495660 File Offset: 0x00493860
		public IActionByHitTypeConfigT UnPack()
		{
			IActionByHitTypeConfigT actionByHitTypeConfigT = new IActionByHitTypeConfigT();
			this.UnPackTo(actionByHitTypeConfigT);
			return actionByHitTypeConfigT;
		}

		// Token: 0x0602136B RID: 136043 RVA: 0x0049567C File Offset: 0x0049387C
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

		// Token: 0x0602136C RID: 136044 RVA: 0x004958C4 File Offset: 0x00493AC4
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

		// Token: 0x0400E758 RID: 59224
		private Table __p;
	}
}
