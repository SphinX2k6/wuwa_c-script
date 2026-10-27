using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005727 RID: 22311
	public struct IPetalGrabRoleMotionInteract : IFlatbufferObject
	{
		// Token: 0x1700A636 RID: 42550
		// (get) Token: 0x06025542 RID: 152898 RVA: 0x00526801 File Offset: 0x00524A01
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025543 RID: 152899 RVA: 0x0052680E File Offset: 0x00524A0E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025544 RID: 152900 RVA: 0x00526818 File Offset: 0x00524A18
		public static IPetalGrabRoleMotionInteract GetRootAsIPetalGrabRoleMotionInteract(ByteBuffer _bb)
		{
			return IPetalGrabRoleMotionInteract.GetRootAsIPetalGrabRoleMotionInteract(_bb, default(IPetalGrabRoleMotionInteract));
		}

		// Token: 0x06025545 RID: 152901 RVA: 0x00526834 File Offset: 0x00524A34
		public static IPetalGrabRoleMotionInteract GetRootAsIPetalGrabRoleMotionInteract(ByteBuffer _bb, IPetalGrabRoleMotionInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025546 RID: 152902 RVA: 0x00526851 File Offset: 0x00524A51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025547 RID: 152903 RVA: 0x00526860 File Offset: 0x00524A60
		public IPetalGrabRoleMotionInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A637 RID: 42551
		// (get) Token: 0x06025548 RID: 152904 RVA: 0x00526870 File Offset: 0x00524A70
		public ERoleMotionInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoleMotionInteractType.PetalGrab;
				}
				return (ERoleMotionInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A638 RID: 42552
		// (get) Token: 0x06025549 RID: 152905 RVA: 0x005268AC File Offset: 0x00524AAC
		public EPetalGrabHandType HandOption
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPetalGrabHandType.LeftHand;
				}
				return (EPetalGrabHandType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A639 RID: 42553
		// (get) Token: 0x0602554A RID: 152906 RVA: 0x005268E8 File Offset: 0x00524AE8
		public IPosAndRot? GrabPointOffset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPosAndRot?(default(IPosAndRot).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602554B RID: 152907 RVA: 0x00526948 File Offset: 0x00524B48
		public IPetalGrabEvent? GrabEvents(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IPetalGrabEvent?(default(IPetalGrabEvent).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A63A RID: 42554
		// (get) Token: 0x0602554C RID: 152908 RVA: 0x005269AC File Offset: 0x00524BAC
		public int GrabEventsLength
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

		// Token: 0x1700A63B RID: 42555
		// (get) Token: 0x0602554D RID: 152909 RVA: 0x005269D8 File Offset: 0x00524BD8
		public int NextPointEntityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A63C RID: 42556
		// (get) Token: 0x0602554E RID: 152910 RVA: 0x00526A18 File Offset: 0x00524C18
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602554F RID: 152911 RVA: 0x00526A55 File Offset: 0x00524C55
		public static Offset<IPetalGrabRoleMotionInteract> CreateIPetalGrabRoleMotionInteract(FlatBufferBuilder builder, ERoleMotionInteractType Type = ERoleMotionInteractType.PetalGrab, EPetalGrabHandType HandOption = EPetalGrabHandType.LeftHand, Offset<IPosAndRot> GrabPointOffsetOffset = default(Offset<IPosAndRot>), VectorOffset GrabEventsOffset = default(VectorOffset), int NextPointEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			IPetalGrabRoleMotionInteract.AddNextPointEntityId(builder, NextPointEntityId);
			IPetalGrabRoleMotionInteract.AddGrabEvents(builder, GrabEventsOffset);
			IPetalGrabRoleMotionInteract.AddGrabPointOffset(builder, GrabPointOffsetOffset);
			IPetalGrabRoleMotionInteract.AddNullMask(builder, NullMask);
			IPetalGrabRoleMotionInteract.AddHandOption(builder, HandOption);
			IPetalGrabRoleMotionInteract.AddType(builder, Type);
			return IPetalGrabRoleMotionInteract.EndIPetalGrabRoleMotionInteract(builder);
		}

		// Token: 0x06025550 RID: 152912 RVA: 0x00526A91 File Offset: 0x00524C91
		public static void StartIPetalGrabRoleMotionInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06025551 RID: 152913 RVA: 0x00526A9A File Offset: 0x00524C9A
		public static void AddType(FlatBufferBuilder builder, ERoleMotionInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025552 RID: 152914 RVA: 0x00526AA5 File Offset: 0x00524CA5
		public static void AddHandOption(FlatBufferBuilder builder, EPetalGrabHandType handOption)
		{
			builder.AddByte(1, (byte)handOption, 0);
		}

		// Token: 0x06025553 RID: 152915 RVA: 0x00526AB0 File Offset: 0x00524CB0
		public static void AddGrabPointOffset(FlatBufferBuilder builder, Offset<IPosAndRot> grabPointOffsetOffset)
		{
			builder.AddOffset(2, grabPointOffsetOffset.Value, 0);
		}

		// Token: 0x06025554 RID: 152916 RVA: 0x00526AC0 File Offset: 0x00524CC0
		public static void AddGrabEvents(FlatBufferBuilder builder, VectorOffset grabEventsOffset)
		{
			builder.AddOffset(3, grabEventsOffset.Value, 0);
		}

		// Token: 0x06025555 RID: 152917 RVA: 0x00526AD0 File Offset: 0x00524CD0
		public static VectorOffset CreateGrabEventsVector(FlatBufferBuilder builder, Offset<IPetalGrabEvent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025556 RID: 152918 RVA: 0x00526B10 File Offset: 0x00524D10
		public static VectorOffset CreateGrabEventsVectorBlock(FlatBufferBuilder builder, Offset<IPetalGrabEvent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPetalGrabEvent>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025557 RID: 152919 RVA: 0x00526B2A File Offset: 0x00524D2A
		public static VectorOffset CreateGrabEventsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPetalGrabEvent>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPetalGrabEvent>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025558 RID: 152920 RVA: 0x00526B48 File Offset: 0x00524D48
		public static VectorOffset CreateGrabEventsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPetalGrabEvent>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025559 RID: 152921 RVA: 0x00526B61 File Offset: 0x00524D61
		public static void StartGrabEventsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602555A RID: 152922 RVA: 0x00526B6C File Offset: 0x00524D6C
		public static void AddNextPointEntityId(FlatBufferBuilder builder, int nextPointEntityId)
		{
			builder.AddInt(4, nextPointEntityId, 0);
		}

		// Token: 0x0602555B RID: 152923 RVA: 0x00526B77 File Offset: 0x00524D77
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602555C RID: 152924 RVA: 0x00526B82 File Offset: 0x00524D82
		public static Offset<IPetalGrabRoleMotionInteract> EndIPetalGrabRoleMotionInteract(FlatBufferBuilder builder)
		{
			return new Offset<IPetalGrabRoleMotionInteract>(builder.EndTable());
		}

		// Token: 0x0602555D RID: 152925 RVA: 0x00526B90 File Offset: 0x00524D90
		public IPetalGrabRoleMotionInteractT UnPack()
		{
			IPetalGrabRoleMotionInteractT petalGrabRoleMotionInteractT = new IPetalGrabRoleMotionInteractT();
			this.UnPackTo(petalGrabRoleMotionInteractT);
			return petalGrabRoleMotionInteractT;
		}

		// Token: 0x0602555E RID: 152926 RVA: 0x00526BAC File Offset: 0x00524DAC
		public void UnPackTo(IPetalGrabRoleMotionInteractT _o)
		{
			_o.Type = this.Type;
			_o.HandOption = this.HandOption;
			_o.GrabPointOffset = ((this.GrabPointOffset != null) ? this.GrabPointOffset.Value.UnPack() : null);
			_o.GrabEvents = new List<IPetalGrabEventT>();
			for (int i = 0; i < this.GrabEventsLength; i++)
			{
				_o.GrabEvents.Add((this.GrabEvents(i) != null) ? this.GrabEvents(i).Value.UnPack() : null);
			}
			_o.NextPointEntityId = this.NextPointEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602555F RID: 152927 RVA: 0x00526C6C File Offset: 0x00524E6C
		public static Offset<IPetalGrabRoleMotionInteract> Pack(FlatBufferBuilder builder, IPetalGrabRoleMotionInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPetalGrabRoleMotionInteract>);
			}
			Offset<IPosAndRot> grabPointOffsetOffset = (_o.GrabPointOffset == null) ? default(Offset<IPosAndRot>) : IPosAndRot.Pack(builder, _o.GrabPointOffset);
			VectorOffset grabEventsOffset = default(VectorOffset);
			if (_o.GrabEvents != null)
			{
				Offset<IPetalGrabEvent>[] array = new Offset<IPetalGrabEvent>[_o.GrabEvents.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPetalGrabEvent.Pack(builder, _o.GrabEvents[i]);
				}
				grabEventsOffset = IPetalGrabRoleMotionInteract.CreateGrabEventsVector(builder, array);
			}
			return IPetalGrabRoleMotionInteract.CreateIPetalGrabRoleMotionInteract(builder, _o.Type, _o.HandOption, grabPointOffsetOffset, grabEventsOffset, _o.NextPointEntityId, _o.NullMask);
		}

		// Token: 0x0400EB9C RID: 60316
		private Table __p;
	}
}
