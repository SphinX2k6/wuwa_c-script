using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A28 RID: 23080
	public struct ITargetGearGroupComponent : IFlatbufferObject
	{
		// Token: 0x1700AD92 RID: 44434
		// (get) Token: 0x0602737A RID: 160634 RVA: 0x00565592 File Offset: 0x00563792
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602737B RID: 160635 RVA: 0x0056559F File Offset: 0x0056379F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602737C RID: 160636 RVA: 0x005655A8 File Offset: 0x005637A8
		public static ITargetGearGroupComponent GetRootAsITargetGearGroupComponent(ByteBuffer _bb)
		{
			return ITargetGearGroupComponent.GetRootAsITargetGearGroupComponent(_bb, default(ITargetGearGroupComponent));
		}

		// Token: 0x0602737D RID: 160637 RVA: 0x005655C4 File Offset: 0x005637C4
		public static ITargetGearGroupComponent GetRootAsITargetGearGroupComponent(ByteBuffer _bb, ITargetGearGroupComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602737E RID: 160638 RVA: 0x005655E1 File Offset: 0x005637E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602737F RID: 160639 RVA: 0x005655F0 File Offset: 0x005637F0
		public ITargetGearGroupComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD93 RID: 44435
		// (get) Token: 0x06027380 RID: 160640 RVA: 0x00565600 File Offset: 0x00563800
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AD94 RID: 44436
		// (get) Token: 0x06027381 RID: 160641 RVA: 0x00565640 File Offset: 0x00563840
		public string Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027382 RID: 160642 RVA: 0x00565677 File Offset: 0x00563877
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06027383 RID: 160643 RVA: 0x00565686 File Offset: 0x00563886
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06027384 RID: 160644 RVA: 0x00565694 File Offset: 0x00563894
		public ITargetGearGroupConfig? GroupConfigs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ITargetGearGroupConfig?(default(ITargetGearGroupConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AD95 RID: 44437
		// (get) Token: 0x06027385 RID: 160645 RVA: 0x005656F4 File Offset: 0x005638F4
		public int GroupConfigsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700AD96 RID: 44438
		// (get) Token: 0x06027386 RID: 160646 RVA: 0x00565720 File Offset: 0x00563920
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

		// Token: 0x06027387 RID: 160647 RVA: 0x0056575D File Offset: 0x0056395D
		public static Offset<ITargetGearGroupComponent> CreateITargetGearGroupComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset TypeOffset = default(StringOffset), VectorOffset GroupConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ITargetGearGroupComponent.AddGroupConfigs(builder, GroupConfigsOffset);
			ITargetGearGroupComponent.AddType(builder, TypeOffset);
			ITargetGearGroupComponent.AddNullMask(builder, NullMask);
			ITargetGearGroupComponent.AddDisabled(builder, Disabled);
			return ITargetGearGroupComponent.EndITargetGearGroupComponent(builder);
		}

		// Token: 0x06027388 RID: 160648 RVA: 0x00565789 File Offset: 0x00563989
		public static void StartITargetGearGroupComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06027389 RID: 160649 RVA: 0x00565792 File Offset: 0x00563992
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602738A RID: 160650 RVA: 0x0056579D File Offset: 0x0056399D
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(1, typeOffset.Value, 0);
		}

		// Token: 0x0602738B RID: 160651 RVA: 0x005657AD File Offset: 0x005639AD
		public static void AddGroupConfigs(FlatBufferBuilder builder, VectorOffset groupConfigsOffset)
		{
			builder.AddOffset(2, groupConfigsOffset.Value, 0);
		}

		// Token: 0x0602738C RID: 160652 RVA: 0x005657C0 File Offset: 0x005639C0
		public static VectorOffset CreateGroupConfigsVector(FlatBufferBuilder builder, Offset<ITargetGearGroupConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602738D RID: 160653 RVA: 0x00565800 File Offset: 0x00563A00
		public static VectorOffset CreateGroupConfigsVectorBlock(FlatBufferBuilder builder, Offset<ITargetGearGroupConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITargetGearGroupConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602738E RID: 160654 RVA: 0x0056581A File Offset: 0x00563A1A
		public static VectorOffset CreateGroupConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITargetGearGroupConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITargetGearGroupConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602738F RID: 160655 RVA: 0x00565838 File Offset: 0x00563A38
		public static VectorOffset CreateGroupConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITargetGearGroupConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027390 RID: 160656 RVA: 0x00565851 File Offset: 0x00563A51
		public static void StartGroupConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027391 RID: 160657 RVA: 0x0056585C File Offset: 0x00563A5C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06027392 RID: 160658 RVA: 0x00565867 File Offset: 0x00563A67
		public static Offset<ITargetGearGroupComponent> EndITargetGearGroupComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITargetGearGroupComponent>(builder.EndTable());
		}

		// Token: 0x06027393 RID: 160659 RVA: 0x00565874 File Offset: 0x00563A74
		public ITargetGearGroupComponentT UnPack()
		{
			ITargetGearGroupComponentT targetGearGroupComponentT = new ITargetGearGroupComponentT();
			this.UnPackTo(targetGearGroupComponentT);
			return targetGearGroupComponentT;
		}

		// Token: 0x06027394 RID: 160660 RVA: 0x00565890 File Offset: 0x00563A90
		public void UnPackTo(ITargetGearGroupComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Type = this.Type;
			_o.GroupConfigs = new List<ITargetGearGroupConfigT>();
			for (int i = 0; i < this.GroupConfigsLength; i++)
			{
				_o.GroupConfigs.Add((this.GroupConfigs(i) != null) ? this.GroupConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027395 RID: 160661 RVA: 0x00565914 File Offset: 0x00563B14
		public static Offset<ITargetGearGroupComponent> Pack(FlatBufferBuilder builder, ITargetGearGroupComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetGearGroupComponent>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			VectorOffset groupConfigsOffset = default(VectorOffset);
			if (_o.GroupConfigs != null)
			{
				Offset<ITargetGearGroupConfig>[] array = new Offset<ITargetGearGroupConfig>[_o.GroupConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITargetGearGroupConfig.Pack(builder, _o.GroupConfigs[i]);
				}
				groupConfigsOffset = ITargetGearGroupComponent.CreateGroupConfigsVector(builder, array);
			}
			return ITargetGearGroupComponent.CreateITargetGearGroupComponent(builder, _o.Disabled, typeOffset, groupConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400F08A RID: 61578
		private Table __p;
	}
}
