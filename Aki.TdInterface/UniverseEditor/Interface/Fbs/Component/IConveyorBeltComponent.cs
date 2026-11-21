using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005589 RID: 21897
	public struct IConveyorBeltComponent : IFlatbufferObject
	{
		// Token: 0x17009CD5 RID: 40149
		// (get) Token: 0x06022D2D RID: 142637 RVA: 0x004CC271 File Offset: 0x004CA471
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022D2E RID: 142638 RVA: 0x004CC27E File Offset: 0x004CA47E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022D2F RID: 142639 RVA: 0x004CC288 File Offset: 0x004CA488
		public static IConveyorBeltComponent GetRootAsIConveyorBeltComponent(ByteBuffer _bb)
		{
			return IConveyorBeltComponent.GetRootAsIConveyorBeltComponent(_bb, default(IConveyorBeltComponent));
		}

		// Token: 0x06022D30 RID: 142640 RVA: 0x004CC2A4 File Offset: 0x004CA4A4
		public static IConveyorBeltComponent GetRootAsIConveyorBeltComponent(ByteBuffer _bb, IConveyorBeltComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022D31 RID: 142641 RVA: 0x004CC2C1 File Offset: 0x004CA4C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022D32 RID: 142642 RVA: 0x004CC2D0 File Offset: 0x004CA4D0
		public IConveyorBeltComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CD6 RID: 40150
		// (get) Token: 0x06022D33 RID: 142643 RVA: 0x004CC2E0 File Offset: 0x004CA4E0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06022D34 RID: 142644 RVA: 0x004CC320 File Offset: 0x004CA520
		public IConveyorBeltState? StateGroups(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IConveyorBeltState?(default(IConveyorBeltState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009CD7 RID: 40151
		// (get) Token: 0x06022D35 RID: 142645 RVA: 0x004CC380 File Offset: 0x004CA580
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

		// Token: 0x17009CD8 RID: 40152
		// (get) Token: 0x06022D36 RID: 142646 RVA: 0x004CC3AC File Offset: 0x004CA5AC
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

		// Token: 0x06022D37 RID: 142647 RVA: 0x004CC3E8 File Offset: 0x004CA5E8
		public static Offset<IConveyorBeltComponent> CreateIConveyorBeltComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset StateGroupsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IConveyorBeltComponent.AddStateGroups(builder, StateGroupsOffset);
			IConveyorBeltComponent.AddNullMask(builder, NullMask);
			IConveyorBeltComponent.AddDisabled(builder, Disabled);
			return IConveyorBeltComponent.EndIConveyorBeltComponent(builder);
		}

		// Token: 0x06022D38 RID: 142648 RVA: 0x004CC40C File Offset: 0x004CA60C
		public static void StartIConveyorBeltComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022D39 RID: 142649 RVA: 0x004CC415 File Offset: 0x004CA615
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022D3A RID: 142650 RVA: 0x004CC420 File Offset: 0x004CA620
		public static void AddStateGroups(FlatBufferBuilder builder, VectorOffset stateGroupsOffset)
		{
			builder.AddOffset(1, stateGroupsOffset.Value, 0);
		}

		// Token: 0x06022D3B RID: 142651 RVA: 0x004CC430 File Offset: 0x004CA630
		public static VectorOffset CreateStateGroupsVector(FlatBufferBuilder builder, Offset<IConveyorBeltState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022D3C RID: 142652 RVA: 0x004CC470 File Offset: 0x004CA670
		public static VectorOffset CreateStateGroupsVectorBlock(FlatBufferBuilder builder, Offset<IConveyorBeltState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConveyorBeltState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022D3D RID: 142653 RVA: 0x004CC48A File Offset: 0x004CA68A
		public static VectorOffset CreateStateGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConveyorBeltState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConveyorBeltState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022D3E RID: 142654 RVA: 0x004CC4A8 File Offset: 0x004CA6A8
		public static VectorOffset CreateStateGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConveyorBeltState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022D3F RID: 142655 RVA: 0x004CC4C1 File Offset: 0x004CA6C1
		public static void StartStateGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022D40 RID: 142656 RVA: 0x004CC4CC File Offset: 0x004CA6CC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06022D41 RID: 142657 RVA: 0x004CC4D7 File Offset: 0x004CA6D7
		public static Offset<IConveyorBeltComponent> EndIConveyorBeltComponent(FlatBufferBuilder builder)
		{
			return new Offset<IConveyorBeltComponent>(builder.EndTable());
		}

		// Token: 0x06022D42 RID: 142658 RVA: 0x004CC4E4 File Offset: 0x004CA6E4
		public IConveyorBeltComponentT UnPack()
		{
			IConveyorBeltComponentT conveyorBeltComponentT = new IConveyorBeltComponentT();
			this.UnPackTo(conveyorBeltComponentT);
			return conveyorBeltComponentT;
		}

		// Token: 0x06022D43 RID: 142659 RVA: 0x004CC500 File Offset: 0x004CA700
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

		// Token: 0x06022D44 RID: 142660 RVA: 0x004CC578 File Offset: 0x004CA778
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

		// Token: 0x0400EC0C RID: 60428
		private Table __p;
	}
}
