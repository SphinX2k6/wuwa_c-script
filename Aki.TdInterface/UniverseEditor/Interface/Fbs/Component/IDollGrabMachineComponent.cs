using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050A2 RID: 20642
	public struct IDollGrabMachineComponent : IFlatbufferObject
	{
		// Token: 0x170095F1 RID: 38385
		// (get) Token: 0x06021251 RID: 135761 RVA: 0x0049AF3E File Offset: 0x0049913E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021252 RID: 135762 RVA: 0x0049AF4B File Offset: 0x0049914B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021253 RID: 135763 RVA: 0x0049AF54 File Offset: 0x00499154
		public static IDollGrabMachineComponent GetRootAsIDollGrabMachineComponent(ByteBuffer _bb)
		{
			return IDollGrabMachineComponent.GetRootAsIDollGrabMachineComponent(_bb, default(IDollGrabMachineComponent));
		}

		// Token: 0x06021254 RID: 135764 RVA: 0x0049AF70 File Offset: 0x00499170
		public static IDollGrabMachineComponent GetRootAsIDollGrabMachineComponent(ByteBuffer _bb, IDollGrabMachineComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021255 RID: 135765 RVA: 0x0049AF8D File Offset: 0x0049918D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021256 RID: 135766 RVA: 0x0049AF9C File Offset: 0x0049919C
		public IDollGrabMachineComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095F2 RID: 38386
		// (get) Token: 0x06021257 RID: 135767 RVA: 0x0049AFAC File Offset: 0x004991AC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170095F3 RID: 38387
		// (get) Token: 0x06021258 RID: 135768 RVA: 0x0049AFEC File Offset: 0x004991EC
		public EDollGrabShowcaseBelongType BelongType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EDollGrabShowcaseBelongType.LandOfXuanfang;
				}
				return (EDollGrabShowcaseBelongType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170095F4 RID: 38388
		// (get) Token: 0x06021259 RID: 135769 RVA: 0x0049B028 File Offset: 0x00499228
		public float TimeLimit
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170095F5 RID: 38389
		// (get) Token: 0x0602125A RID: 135770 RVA: 0x0049B068 File Offset: 0x00499268
		public float PlayCost
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602125B RID: 135771 RVA: 0x0049B0AC File Offset: 0x004992AC
		public IDollGrabItem? Items(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IDollGrabItem?(default(IDollGrabItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170095F6 RID: 38390
		// (get) Token: 0x0602125C RID: 135772 RVA: 0x0049B110 File Offset: 0x00499310
		public int ItemsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170095F7 RID: 38391
		// (get) Token: 0x0602125D RID: 135773 RVA: 0x0049B13C File Offset: 0x0049933C
		public IDollGrabInfiniteModeData? InfiniteModeData
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IDollGrabInfiniteModeData?(default(IDollGrabInfiniteModeData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170095F8 RID: 38392
		// (get) Token: 0x0602125E RID: 135774 RVA: 0x0049B19C File Offset: 0x0049939C
		public string AkEvent
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602125F RID: 135775 RVA: 0x0049B1D4 File Offset: 0x004993D4
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06021260 RID: 135776 RVA: 0x0049B1E4 File Offset: 0x004993E4
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x170095F9 RID: 38393
		// (get) Token: 0x06021261 RID: 135777 RVA: 0x0049B1F4 File Offset: 0x004993F4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021262 RID: 135778 RVA: 0x0049B234 File Offset: 0x00499434
		public static Offset<IDollGrabMachineComponent> CreateIDollGrabMachineComponent(FlatBufferBuilder builder, bool Disabled = false, EDollGrabShowcaseBelongType BelongType = EDollGrabShowcaseBelongType.LandOfXuanfang, float TimeLimit = 0f, float PlayCost = 0f, VectorOffset ItemsOffset = default(VectorOffset), Offset<IDollGrabInfiniteModeData> InfiniteModeDataOffset = default(Offset<IDollGrabInfiniteModeData>), StringOffset AkEventOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
			IDollGrabMachineComponent.AddAkEvent(builder, AkEventOffset);
			IDollGrabMachineComponent.AddInfiniteModeData(builder, InfiniteModeDataOffset);
			IDollGrabMachineComponent.AddItems(builder, ItemsOffset);
			IDollGrabMachineComponent.AddPlayCost(builder, PlayCost);
			IDollGrabMachineComponent.AddTimeLimit(builder, TimeLimit);
			IDollGrabMachineComponent.AddNullMask(builder, NullMask);
			IDollGrabMachineComponent.AddBelongType(builder, BelongType);
			IDollGrabMachineComponent.AddDisabled(builder, Disabled);
			return IDollGrabMachineComponent.EndIDollGrabMachineComponent(builder);
		}

		// Token: 0x06021263 RID: 135779 RVA: 0x0049B28B File Offset: 0x0049948B
		public static void StartIDollGrabMachineComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06021264 RID: 135780 RVA: 0x0049B294 File Offset: 0x00499494
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021265 RID: 135781 RVA: 0x0049B29F File Offset: 0x0049949F
		public static void AddBelongType(FlatBufferBuilder builder, EDollGrabShowcaseBelongType belongType)
		{
			builder.AddByte(1, (byte)belongType, 0);
		}

		// Token: 0x06021266 RID: 135782 RVA: 0x0049B2AA File Offset: 0x004994AA
		public static void AddTimeLimit(FlatBufferBuilder builder, float timeLimit)
		{
			builder.AddFloat(2, timeLimit, 0.0);
		}

		// Token: 0x06021267 RID: 135783 RVA: 0x0049B2BD File Offset: 0x004994BD
		public static void AddPlayCost(FlatBufferBuilder builder, float playCost)
		{
			builder.AddFloat(3, playCost, 0.0);
		}

		// Token: 0x06021268 RID: 135784 RVA: 0x0049B2D0 File Offset: 0x004994D0
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x06021269 RID: 135785 RVA: 0x0049B2E0 File Offset: 0x004994E0
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<IDollGrabItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602126A RID: 135786 RVA: 0x0049B320 File Offset: 0x00499520
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<IDollGrabItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDollGrabItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602126B RID: 135787 RVA: 0x0049B33A File Offset: 0x0049953A
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDollGrabItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDollGrabItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602126C RID: 135788 RVA: 0x0049B358 File Offset: 0x00499558
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDollGrabItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602126D RID: 135789 RVA: 0x0049B371 File Offset: 0x00499571
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602126E RID: 135790 RVA: 0x0049B37C File Offset: 0x0049957C
		public static void AddInfiniteModeData(FlatBufferBuilder builder, Offset<IDollGrabInfiniteModeData> infiniteModeDataOffset)
		{
			builder.AddOffset(5, infiniteModeDataOffset.Value, 0);
		}

		// Token: 0x0602126F RID: 135791 RVA: 0x0049B38C File Offset: 0x0049958C
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(6, akEventOffset.Value, 0);
		}

		// Token: 0x06021270 RID: 135792 RVA: 0x0049B39C File Offset: 0x0049959C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06021271 RID: 135793 RVA: 0x0049B3A7 File Offset: 0x004995A7
		public static Offset<IDollGrabMachineComponent> EndIDollGrabMachineComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabMachineComponent>(builder.EndTable());
		}

		// Token: 0x06021272 RID: 135794 RVA: 0x0049B3B4 File Offset: 0x004995B4
		public IDollGrabMachineComponentT UnPack()
		{
			IDollGrabMachineComponentT dollGrabMachineComponentT = new IDollGrabMachineComponentT();
			this.UnPackTo(dollGrabMachineComponentT);
			return dollGrabMachineComponentT;
		}

		// Token: 0x06021273 RID: 135795 RVA: 0x0049B3D0 File Offset: 0x004995D0
		public void UnPackTo(IDollGrabMachineComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.BelongType = this.BelongType;
			_o.TimeLimit = this.TimeLimit;
			_o.PlayCost = this.PlayCost;
			_o.Items = new List<IDollGrabItemT>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add((this.Items(i) != null) ? this.Items(i).Value.UnPack() : null);
			}
			_o.InfiniteModeData = ((this.InfiniteModeData != null) ? this.InfiniteModeData.Value.UnPack() : null);
			_o.AkEvent = this.AkEvent;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021274 RID: 135796 RVA: 0x0049B4A8 File Offset: 0x004996A8
		public static Offset<IDollGrabMachineComponent> Pack(FlatBufferBuilder builder, IDollGrabMachineComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrabMachineComponent>);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				Offset<IDollGrabItem>[] array = new Offset<IDollGrabItem>[_o.Items.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDollGrabItem.Pack(builder, _o.Items[i]);
				}
				itemsOffset = IDollGrabMachineComponent.CreateItemsVector(builder, array);
			}
			Offset<IDollGrabInfiniteModeData> infiniteModeDataOffset = (_o.InfiniteModeData == null) ? default(Offset<IDollGrabInfiniteModeData>) : IDollGrabInfiniteModeData.Pack(builder, _o.InfiniteModeData);
			StringOffset akEventOffset = (_o.AkEvent == null) ? default(StringOffset) : builder.CreateString(_o.AkEvent);
			return IDollGrabMachineComponent.CreateIDollGrabMachineComponent(builder, _o.Disabled, _o.BelongType, _o.TimeLimit, _o.PlayCost, itemsOffset, infiniteModeDataOffset, akEventOffset, _o.NullMask);
		}

		// Token: 0x0400E0C0 RID: 57536
		private Table __p;
	}
}
