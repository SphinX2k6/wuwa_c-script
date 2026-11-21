using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072C2 RID: 29378
	public struct IMp4FrameEvent : IFlatbufferObject
	{
		// Token: 0x1700D76B RID: 55147
		// (get) Token: 0x0603336F RID: 209775 RVA: 0x006E8FC0 File Offset: 0x006E71C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033370 RID: 209776 RVA: 0x006E8FCD File Offset: 0x006E71CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033371 RID: 209777 RVA: 0x006E8FD4 File Offset: 0x006E71D4
		public static IMp4FrameEvent GetRootAsIMp4FrameEvent(ByteBuffer _bb)
		{
			return IMp4FrameEvent.GetRootAsIMp4FrameEvent(_bb, default(IMp4FrameEvent));
		}

		// Token: 0x06033372 RID: 209778 RVA: 0x006E8FF0 File Offset: 0x006E71F0
		public static IMp4FrameEvent GetRootAsIMp4FrameEvent(ByteBuffer _bb, IMp4FrameEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033373 RID: 209779 RVA: 0x006E900D File Offset: 0x006E720D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033374 RID: 209780 RVA: 0x006E901C File Offset: 0x006E721C
		public IMp4FrameEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D76C RID: 55148
		// (get) Token: 0x06033375 RID: 209781 RVA: 0x006E902C File Offset: 0x006E722C
		public float Second
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033376 RID: 209782 RVA: 0x006E906C File Offset: 0x006E726C
		public IActionInfo? EventActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D76D RID: 55149
		// (get) Token: 0x06033377 RID: 209783 RVA: 0x006E90CC File Offset: 0x006E72CC
		public int EventActionsLength
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

		// Token: 0x06033378 RID: 209784 RVA: 0x006E90F7 File Offset: 0x006E72F7
		public static Offset<IMp4FrameEvent> CreateIMp4FrameEvent(FlatBufferBuilder builder, float Second = 0f, VectorOffset EventActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IMp4FrameEvent.AddEventActions(builder, EventActionsOffset);
			IMp4FrameEvent.AddSecond(builder, Second);
			return IMp4FrameEvent.EndIMp4FrameEvent(builder);
		}

		// Token: 0x06033379 RID: 209785 RVA: 0x006E9114 File Offset: 0x006E7314
		public static void StartIMp4FrameEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603337A RID: 209786 RVA: 0x006E911D File Offset: 0x006E731D
		public static void AddSecond(FlatBufferBuilder builder, float second)
		{
			builder.AddFloat(0, second, 0.0);
		}

		// Token: 0x0603337B RID: 209787 RVA: 0x006E9130 File Offset: 0x006E7330
		public static void AddEventActions(FlatBufferBuilder builder, VectorOffset eventActionsOffset)
		{
			builder.AddOffset(1, eventActionsOffset.Value, 0);
		}

		// Token: 0x0603337C RID: 209788 RVA: 0x006E9140 File Offset: 0x006E7340
		public static VectorOffset CreateEventActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603337D RID: 209789 RVA: 0x006E9180 File Offset: 0x006E7380
		public static VectorOffset CreateEventActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603337E RID: 209790 RVA: 0x006E919A File Offset: 0x006E739A
		public static VectorOffset CreateEventActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603337F RID: 209791 RVA: 0x006E91B8 File Offset: 0x006E73B8
		public static VectorOffset CreateEventActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033380 RID: 209792 RVA: 0x006E91D1 File Offset: 0x006E73D1
		public static void StartEventActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033381 RID: 209793 RVA: 0x006E91DC File Offset: 0x006E73DC
		public static Offset<IMp4FrameEvent> EndIMp4FrameEvent(FlatBufferBuilder builder)
		{
			return new Offset<IMp4FrameEvent>(builder.EndTable());
		}

		// Token: 0x06033382 RID: 209794 RVA: 0x006E91EC File Offset: 0x006E73EC
		public IMp4FrameEventT UnPack()
		{
			IMp4FrameEventT mp4FrameEventT = new IMp4FrameEventT();
			this.UnPackTo(mp4FrameEventT);
			return mp4FrameEventT;
		}

		// Token: 0x06033383 RID: 209795 RVA: 0x006E9208 File Offset: 0x006E7408
		public void UnPackTo(IMp4FrameEventT _o)
		{
			_o.Second = this.Second;
			_o.EventActions = new List<IActionInfoT>();
			for (int i = 0; i < this.EventActionsLength; i++)
			{
				_o.EventActions.Add((this.EventActions(i) != null) ? this.EventActions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06033384 RID: 209796 RVA: 0x006E9274 File Offset: 0x006E7474
		public static Offset<IMp4FrameEvent> Pack(FlatBufferBuilder builder, IMp4FrameEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMp4FrameEvent>);
			}
			VectorOffset eventActionsOffset = default(VectorOffset);
			if (_o.EventActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.EventActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.EventActions[i]);
				}
				eventActionsOffset = IMp4FrameEvent.CreateEventActionsVector(builder, array);
			}
			return IMp4FrameEvent.CreateIMp4FrameEvent(builder, _o.Second, eventActionsOffset);
		}

		// Token: 0x04012360 RID: 74592
		private Table __p;
	}
}
