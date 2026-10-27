using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050F9 RID: 20729
	public struct IDynamicSpawnMonsterComponent : IFlatbufferObject
	{
		// Token: 0x170096F8 RID: 38648
		// (get) Token: 0x06021619 RID: 136729 RVA: 0x004A2A6B File Offset: 0x004A0C6B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602161A RID: 136730 RVA: 0x004A2A78 File Offset: 0x004A0C78
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602161B RID: 136731 RVA: 0x004A2A80 File Offset: 0x004A0C80
		public static IDynamicSpawnMonsterComponent GetRootAsIDynamicSpawnMonsterComponent(ByteBuffer _bb)
		{
			return IDynamicSpawnMonsterComponent.GetRootAsIDynamicSpawnMonsterComponent(_bb, default(IDynamicSpawnMonsterComponent));
		}

		// Token: 0x0602161C RID: 136732 RVA: 0x004A2A9C File Offset: 0x004A0C9C
		public static IDynamicSpawnMonsterComponent GetRootAsIDynamicSpawnMonsterComponent(ByteBuffer _bb, IDynamicSpawnMonsterComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602161D RID: 136733 RVA: 0x004A2AB9 File Offset: 0x004A0CB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602161E RID: 136734 RVA: 0x004A2AC8 File Offset: 0x004A0CC8
		public IDynamicSpawnMonsterComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096F9 RID: 38649
		// (get) Token: 0x0602161F RID: 136735 RVA: 0x004A2AD8 File Offset: 0x004A0CD8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06021620 RID: 136736 RVA: 0x004A2B18 File Offset: 0x004A0D18
		public IConditionSpawnMonster? Group(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IConditionSpawnMonster?(default(IConditionSpawnMonster).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170096FA RID: 38650
		// (get) Token: 0x06021621 RID: 136737 RVA: 0x004A2B78 File Offset: 0x004A0D78
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

		// Token: 0x170096FB RID: 38651
		// (get) Token: 0x06021622 RID: 136738 RVA: 0x004A2BA4 File Offset: 0x004A0DA4
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

		// Token: 0x06021623 RID: 136739 RVA: 0x004A2BE0 File Offset: 0x004A0DE0
		public static Offset<IDynamicSpawnMonsterComponent> CreateIDynamicSpawnMonsterComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset GroupOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IDynamicSpawnMonsterComponent.AddGroup(builder, GroupOffset);
			IDynamicSpawnMonsterComponent.AddNullMask(builder, NullMask);
			IDynamicSpawnMonsterComponent.AddDisabled(builder, Disabled);
			return IDynamicSpawnMonsterComponent.EndIDynamicSpawnMonsterComponent(builder);
		}

		// Token: 0x06021624 RID: 136740 RVA: 0x004A2C04 File Offset: 0x004A0E04
		public static void StartIDynamicSpawnMonsterComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021625 RID: 136741 RVA: 0x004A2C0D File Offset: 0x004A0E0D
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021626 RID: 136742 RVA: 0x004A2C18 File Offset: 0x004A0E18
		public static void AddGroup(FlatBufferBuilder builder, VectorOffset groupOffset)
		{
			builder.AddOffset(1, groupOffset.Value, 0);
		}

		// Token: 0x06021627 RID: 136743 RVA: 0x004A2C28 File Offset: 0x004A0E28
		public static VectorOffset CreateGroupVector(FlatBufferBuilder builder, Offset<IConditionSpawnMonster>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021628 RID: 136744 RVA: 0x004A2C68 File Offset: 0x004A0E68
		public static VectorOffset CreateGroupVectorBlock(FlatBufferBuilder builder, Offset<IConditionSpawnMonster>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionSpawnMonster>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021629 RID: 136745 RVA: 0x004A2C82 File Offset: 0x004A0E82
		public static VectorOffset CreateGroupVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionSpawnMonster>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionSpawnMonster>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602162A RID: 136746 RVA: 0x004A2CA0 File Offset: 0x004A0EA0
		public static VectorOffset CreateGroupVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionSpawnMonster>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602162B RID: 136747 RVA: 0x004A2CB9 File Offset: 0x004A0EB9
		public static void StartGroupVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602162C RID: 136748 RVA: 0x004A2CC4 File Offset: 0x004A0EC4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602162D RID: 136749 RVA: 0x004A2CCF File Offset: 0x004A0ECF
		public static Offset<IDynamicSpawnMonsterComponent> EndIDynamicSpawnMonsterComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSpawnMonsterComponent>(builder.EndTable());
		}

		// Token: 0x0602162E RID: 136750 RVA: 0x004A2CDC File Offset: 0x004A0EDC
		public IDynamicSpawnMonsterComponentT UnPack()
		{
			IDynamicSpawnMonsterComponentT dynamicSpawnMonsterComponentT = new IDynamicSpawnMonsterComponentT();
			this.UnPackTo(dynamicSpawnMonsterComponentT);
			return dynamicSpawnMonsterComponentT;
		}

		// Token: 0x0602162F RID: 136751 RVA: 0x004A2CF8 File Offset: 0x004A0EF8
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

		// Token: 0x06021630 RID: 136752 RVA: 0x004A2D70 File Offset: 0x004A0F70
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

		// Token: 0x0400E15B RID: 57691
		private Table __p;
	}
}
