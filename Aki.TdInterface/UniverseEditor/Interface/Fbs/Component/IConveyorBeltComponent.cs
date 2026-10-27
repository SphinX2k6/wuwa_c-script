using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200502A RID: 20522
	public struct IConveyorBeltComponent : IFlatbufferObject
	{
		// Token: 0x170094F4 RID: 38132
		// (get) Token: 0x06020E0D RID: 134669 RVA: 0x00492821 File Offset: 0x00490A21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020E0E RID: 134670 RVA: 0x0049282E File Offset: 0x00490A2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020E0F RID: 134671 RVA: 0x00492838 File Offset: 0x00490A38
		public static IConveyorBeltComponent GetRootAsIConveyorBeltComponent(ByteBuffer _bb)
		{
			return IConveyorBeltComponent.GetRootAsIConveyorBeltComponent(_bb, default(IConveyorBeltComponent));
		}

		// Token: 0x06020E10 RID: 134672 RVA: 0x00492854 File Offset: 0x00490A54
		public static IConveyorBeltComponent GetRootAsIConveyorBeltComponent(ByteBuffer _bb, IConveyorBeltComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020E11 RID: 134673 RVA: 0x00492871 File Offset: 0x00490A71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020E12 RID: 134674 RVA: 0x00492880 File Offset: 0x00490A80
		public IConveyorBeltComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094F5 RID: 38133
		// (get) Token: 0x06020E13 RID: 134675 RVA: 0x00492890 File Offset: 0x00490A90
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06020E14 RID: 134676 RVA: 0x004928D0 File Offset: 0x00490AD0
		public IConveyorBeltState? StateGroups(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IConveyorBeltState?(default(IConveyorBeltState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170094F6 RID: 38134
		// (get) Token: 0x06020E15 RID: 134677 RVA: 0x00492930 File Offset: 0x00490B30
		public int StateGroupsLength
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

		// Token: 0x170094F7 RID: 38135
		// (get) Token: 0x06020E16 RID: 134678 RVA: 0x0049295C File Offset: 0x00490B5C
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

		// Token: 0x06020E17 RID: 134679 RVA: 0x00492998 File Offset: 0x00490B98
		public static Offset<IConveyorBeltComponent> CreateIConveyorBeltComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset StateGroupsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IConveyorBeltComponent.AddStateGroups(builder, StateGroupsOffset);
			IConveyorBeltComponent.AddNullMask(builder, NullMask);
			IConveyorBeltComponent.AddDisabled(builder, Disabled);
			return IConveyorBeltComponent.EndIConveyorBeltComponent(builder);
		}

		// Token: 0x06020E18 RID: 134680 RVA: 0x004929BC File Offset: 0x00490BBC
		public static void StartIConveyorBeltComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020E19 RID: 134681 RVA: 0x004929C5 File Offset: 0x00490BC5
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06020E1A RID: 134682 RVA: 0x004929D0 File Offset: 0x00490BD0
		public static void AddStateGroups(FlatBufferBuilder builder, VectorOffset stateGroupsOffset)
		{
			builder.AddOffset(1, stateGroupsOffset.Value, 0);
		}

		// Token: 0x06020E1B RID: 134683 RVA: 0x004929E0 File Offset: 0x00490BE0
		public static VectorOffset CreateStateGroupsVector(FlatBufferBuilder builder, Offset<IConveyorBeltState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020E1C RID: 134684 RVA: 0x00492A20 File Offset: 0x00490C20
		public static VectorOffset CreateStateGroupsVectorBlock(FlatBufferBuilder builder, Offset<IConveyorBeltState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConveyorBeltState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020E1D RID: 134685 RVA: 0x00492A3A File Offset: 0x00490C3A
		public static VectorOffset CreateStateGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConveyorBeltState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConveyorBeltState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020E1E RID: 134686 RVA: 0x00492A58 File Offset: 0x00490C58
		public static VectorOffset CreateStateGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConveyorBeltState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020E1F RID: 134687 RVA: 0x00492A71 File Offset: 0x00490C71
		public static void StartStateGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020E20 RID: 134688 RVA: 0x00492A7C File Offset: 0x00490C7C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06020E21 RID: 134689 RVA: 0x00492A87 File Offset: 0x00490C87
		public static Offset<IConveyorBeltComponent> EndIConveyorBeltComponent(FlatBufferBuilder builder)
		{
			return new Offset<IConveyorBeltComponent>(builder.EndTable());
		}

		// Token: 0x06020E22 RID: 134690 RVA: 0x00492A94 File Offset: 0x00490C94
		public IConveyorBeltComponentT UnPack()
		{
			IConveyorBeltComponentT conveyorBeltComponentT = new IConveyorBeltComponentT();
			this.UnPackTo(conveyorBeltComponentT);
			return conveyorBeltComponentT;
		}

		// Token: 0x06020E23 RID: 134691 RVA: 0x00492AB0 File Offset: 0x00490CB0
		public void UnPackTo(IConveyorBeltComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.StateGroups = new List<IConveyorBeltStateT>();
			for (int i = 0; i < this.StateGroupsLength; i++)
			{
				_o.StateGroups.Add((this.StateGroups(i) != null) ? this.StateGroups(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020E24 RID: 134692 RVA: 0x00492B28 File Offset: 0x00490D28
		public static Offset<IConveyorBeltComponent> Pack(FlatBufferBuilder builder, IConveyorBeltComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConveyorBeltComponent>);
			}
			VectorOffset stateGroupsOffset = default(VectorOffset);
			if (_o.StateGroups != null)
			{
				Offset<IConveyorBeltState>[] array = new Offset<IConveyorBeltState>[_o.StateGroups.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IConveyorBeltState.Pack(builder, _o.StateGroups[i]);
				}
				stateGroupsOffset = IConveyorBeltComponent.CreateStateGroupsVector(builder, array);
			}
			return IConveyorBeltComponent.CreateIConveyorBeltComponent(builder, _o.Disabled, stateGroupsOffset, _o.NullMask);
		}

		// Token: 0x0400E016 RID: 57366
		private Table __p;
	}
}
