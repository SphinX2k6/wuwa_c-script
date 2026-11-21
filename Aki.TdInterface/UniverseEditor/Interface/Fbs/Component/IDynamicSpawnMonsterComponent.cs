using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200565E RID: 22110
	public struct IDynamicSpawnMonsterComponent : IFlatbufferObject
	{
		// Token: 0x17009EE5 RID: 40677
		// (get) Token: 0x0602356D RID: 144749 RVA: 0x004DC9F7 File Offset: 0x004DABF7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602356E RID: 144750 RVA: 0x004DCA04 File Offset: 0x004DAC04
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602356F RID: 144751 RVA: 0x004DCA0C File Offset: 0x004DAC0C
		public static IDynamicSpawnMonsterComponent GetRootAsIDynamicSpawnMonsterComponent(ByteBuffer _bb)
		{
			return IDynamicSpawnMonsterComponent.GetRootAsIDynamicSpawnMonsterComponent(_bb, default(IDynamicSpawnMonsterComponent));
		}

		// Token: 0x06023570 RID: 144752 RVA: 0x004DCA28 File Offset: 0x004DAC28
		public static IDynamicSpawnMonsterComponent GetRootAsIDynamicSpawnMonsterComponent(ByteBuffer _bb, IDynamicSpawnMonsterComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023571 RID: 144753 RVA: 0x004DCA45 File Offset: 0x004DAC45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023572 RID: 144754 RVA: 0x004DCA54 File Offset: 0x004DAC54
		public IDynamicSpawnMonsterComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009EE6 RID: 40678
		// (get) Token: 0x06023573 RID: 144755 RVA: 0x004DCA64 File Offset: 0x004DAC64
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06023574 RID: 144756 RVA: 0x004DCAA4 File Offset: 0x004DACA4
		public IConditionSpawnMonster? Group(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IConditionSpawnMonster?(default(IConditionSpawnMonster).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009EE7 RID: 40679
		// (get) Token: 0x06023575 RID: 144757 RVA: 0x004DCB04 File Offset: 0x004DAD04
		public int GroupLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009EE8 RID: 40680
		// (get) Token: 0x06023576 RID: 144758 RVA: 0x004DCB30 File Offset: 0x004DAD30
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023577 RID: 144759 RVA: 0x004DCB6C File Offset: 0x004DAD6C
		public static Offset<IDynamicSpawnMonsterComponent> CreateIDynamicSpawnMonsterComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset GroupOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IDynamicSpawnMonsterComponent.AddGroup(builder, GroupOffset);
			IDynamicSpawnMonsterComponent.AddNullMask(builder, NullMask);
			IDynamicSpawnMonsterComponent.AddDisabled(builder, Disabled);
			return IDynamicSpawnMonsterComponent.EndIDynamicSpawnMonsterComponent(builder);
		}

		// Token: 0x06023578 RID: 144760 RVA: 0x004DCB90 File Offset: 0x004DAD90
		public static void StartIDynamicSpawnMonsterComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06023579 RID: 144761 RVA: 0x004DCB99 File Offset: 0x004DAD99
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602357A RID: 144762 RVA: 0x004DCBA4 File Offset: 0x004DADA4
		public static void AddGroup(FlatBufferBuilder builder, VectorOffset groupOffset)
		{
			builder.AddOffset(1, groupOffset.Value, 0);
		}

		// Token: 0x0602357B RID: 144763 RVA: 0x004DCBB4 File Offset: 0x004DADB4
		public static VectorOffset CreateGroupVector(FlatBufferBuilder builder, Offset<IConditionSpawnMonster>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602357C RID: 144764 RVA: 0x004DCBF4 File Offset: 0x004DADF4
		public static VectorOffset CreateGroupVectorBlock(FlatBufferBuilder builder, Offset<IConditionSpawnMonster>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionSpawnMonster>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602357D RID: 144765 RVA: 0x004DCC0E File Offset: 0x004DAE0E
		public static VectorOffset CreateGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionSpawnMonster>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionSpawnMonster>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602357E RID: 144766 RVA: 0x004DCC2C File Offset: 0x004DAE2C
		public static VectorOffset CreateGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionSpawnMonster>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602357F RID: 144767 RVA: 0x004DCC45 File Offset: 0x004DAE45
		public static void StartGroupVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023580 RID: 144768 RVA: 0x004DCC50 File Offset: 0x004DAE50
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06023581 RID: 144769 RVA: 0x004DCC5B File Offset: 0x004DAE5B
		public static Offset<IDynamicSpawnMonsterComponent> EndIDynamicSpawnMonsterComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSpawnMonsterComponent>(builder.EndTable());
		}

		// Token: 0x06023582 RID: 144770 RVA: 0x004DCC68 File Offset: 0x004DAE68
		public IDynamicSpawnMonsterComponentT UnPack()
		{
			IDynamicSpawnMonsterComponentT dynamicSpawnMonsterComponentT = new IDynamicSpawnMonsterComponentT();
			this.UnPackTo(dynamicSpawnMonsterComponentT);
			return dynamicSpawnMonsterComponentT;
		}

		// Token: 0x06023583 RID: 144771 RVA: 0x004DCC84 File Offset: 0x004DAE84
		public void UnPackTo(IDynamicSpawnMonsterComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Group = new List<IConditionSpawnMonsterT>();
			for (int i = 0; i < this.GroupLength; i++)
			{
				_o.Group.Add((this.Group(i) != null) ? this.Group(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023584 RID: 144772 RVA: 0x004DCCFC File Offset: 0x004DAEFC
		public static Offset<IDynamicSpawnMonsterComponent> Pack(FlatBufferBuilder builder, IDynamicSpawnMonsterComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicSpawnMonsterComponent>);
			}
			VectorOffset groupOffset = default(VectorOffset);
			if (_o.Group != null)
			{
				Offset<IConditionSpawnMonster>[] array = new Offset<IConditionSpawnMonster>[_o.Group.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IConditionSpawnMonster.Pack(builder, _o.Group[i]);
				}
				groupOffset = IDynamicSpawnMonsterComponent.CreateGroupVector(builder, array);
			}
			return IDynamicSpawnMonsterComponent.CreateIDynamicSpawnMonsterComponent(builder, _o.Disabled, groupOffset, _o.NullMask);
		}

		// Token: 0x0400ED58 RID: 60760
		private Table __p;
	}
}
