using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005607 RID: 22023
	public struct IDollGrabMachineComponent : IFlatbufferObject
	{
		// Token: 0x17009DDE RID: 40414
		// (get) Token: 0x060231A5 RID: 143781 RVA: 0x004D4ECA File Offset: 0x004D30CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060231A6 RID: 143782 RVA: 0x004D4ED7 File Offset: 0x004D30D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060231A7 RID: 143783 RVA: 0x004D4EE0 File Offset: 0x004D30E0
		public static IDollGrabMachineComponent GetRootAsIDollGrabMachineComponent(ByteBuffer _bb)
		{
			return IDollGrabMachineComponent.GetRootAsIDollGrabMachineComponent(_bb, default(IDollGrabMachineComponent));
		}

		// Token: 0x060231A8 RID: 143784 RVA: 0x004D4EFC File Offset: 0x004D30FC
		public static IDollGrabMachineComponent GetRootAsIDollGrabMachineComponent(ByteBuffer _bb, IDollGrabMachineComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060231A9 RID: 143785 RVA: 0x004D4F19 File Offset: 0x004D3119
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060231AA RID: 143786 RVA: 0x004D4F28 File Offset: 0x004D3128
		public IDollGrabMachineComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009DDF RID: 40415
		// (get) Token: 0x060231AB RID: 143787 RVA: 0x004D4F38 File Offset: 0x004D3138
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009DE0 RID: 40416
		// (get) Token: 0x060231AC RID: 143788 RVA: 0x004D4F78 File Offset: 0x004D3178
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

		// Token: 0x17009DE1 RID: 40417
		// (get) Token: 0x060231AD RID: 143789 RVA: 0x004D4FB4 File Offset: 0x004D31B4
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

		// Token: 0x17009DE2 RID: 40418
		// (get) Token: 0x060231AE RID: 143790 RVA: 0x004D4FF4 File Offset: 0x004D31F4
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

		// Token: 0x060231AF RID: 143791 RVA: 0x004D5038 File Offset: 0x004D3238
		public IDollGrabItem? Items(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IDollGrabItem?(default(IDollGrabItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009DE3 RID: 40419
		// (get) Token: 0x060231B0 RID: 143792 RVA: 0x004D509C File Offset: 0x004D329C
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

		// Token: 0x17009DE4 RID: 40420
		// (get) Token: 0x060231B1 RID: 143793 RVA: 0x004D50C8 File Offset: 0x004D32C8
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

		// Token: 0x17009DE5 RID: 40421
		// (get) Token: 0x060231B2 RID: 143794 RVA: 0x004D5128 File Offset: 0x004D3328
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

		// Token: 0x060231B3 RID: 143795 RVA: 0x004D5160 File Offset: 0x004D3360
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060231B4 RID: 143796 RVA: 0x004D5170 File Offset: 0x004D3370
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x17009DE6 RID: 40422
		// (get) Token: 0x060231B5 RID: 143797 RVA: 0x004D5180 File Offset: 0x004D3380
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

		// Token: 0x060231B6 RID: 143798 RVA: 0x004D51C0 File Offset: 0x004D33C0
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

		// Token: 0x060231B7 RID: 143799 RVA: 0x004D5217 File Offset: 0x004D3417
		public static void StartIDollGrabMachineComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060231B8 RID: 143800 RVA: 0x004D5220 File Offset: 0x004D3420
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060231B9 RID: 143801 RVA: 0x004D522B File Offset: 0x004D342B
		public static void AddBelongType(FlatBufferBuilder builder, EDollGrabShowcaseBelongType belongType)
		{
			builder.AddByte(1, (byte)belongType, 0);
		}

		// Token: 0x060231BA RID: 143802 RVA: 0x004D5236 File Offset: 0x004D3436
		public static void AddTimeLimit(FlatBufferBuilder builder, float timeLimit)
		{
			builder.AddFloat(2, timeLimit, 0.0);
		}

		// Token: 0x060231BB RID: 143803 RVA: 0x004D5249 File Offset: 0x004D3449
		public static void AddPlayCost(FlatBufferBuilder builder, float playCost)
		{
			builder.AddFloat(3, playCost, 0.0);
		}

		// Token: 0x060231BC RID: 143804 RVA: 0x004D525C File Offset: 0x004D345C
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(4, itemsOffset.Value, 0);
		}

		// Token: 0x060231BD RID: 143805 RVA: 0x004D526C File Offset: 0x004D346C
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<IDollGrabItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060231BE RID: 143806 RVA: 0x004D52AC File Offset: 0x004D34AC
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<IDollGrabItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDollGrabItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x060231BF RID: 143807 RVA: 0x004D52C6 File Offset: 0x004D34C6
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDollGrabItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDollGrabItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x060231C0 RID: 143808 RVA: 0x004D52E4 File Offset: 0x004D34E4
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDollGrabItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060231C1 RID: 143809 RVA: 0x004D52FD File Offset: 0x004D34FD
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060231C2 RID: 143810 RVA: 0x004D5308 File Offset: 0x004D3508
		public static void AddInfiniteModeData(FlatBufferBuilder builder, Offset<IDollGrabInfiniteModeData> infiniteModeDataOffset)
		{
			builder.AddOffset(5, infiniteModeDataOffset.Value, 0);
		}

		// Token: 0x060231C3 RID: 143811 RVA: 0x004D5318 File Offset: 0x004D3518
		public static void AddAkEvent(FlatBufferBuilder builder, StringOffset akEventOffset)
		{
			builder.AddOffset(6, akEventOffset.Value, 0);
		}

		// Token: 0x060231C4 RID: 143812 RVA: 0x004D5328 File Offset: 0x004D3528
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060231C5 RID: 143813 RVA: 0x004D5333 File Offset: 0x004D3533
		public static Offset<IDollGrabMachineComponent> EndIDollGrabMachineComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabMachineComponent>(builder.EndTable());
		}

		// Token: 0x060231C6 RID: 143814 RVA: 0x004D5340 File Offset: 0x004D3540
		public IDollGrabMachineComponentT UnPack()
		{
			IDollGrabMachineComponentT dollGrabMachineComponentT = new IDollGrabMachineComponentT();
			this.UnPackTo(dollGrabMachineComponentT);
			return dollGrabMachineComponentT;
		}

		// Token: 0x060231C7 RID: 143815 RVA: 0x004D535C File Offset: 0x004D355C
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

		// Token: 0x060231C8 RID: 143816 RVA: 0x004D5434 File Offset: 0x004D3634
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

		// Token: 0x0400ECBD RID: 60605
		private Table __p;
	}
}
