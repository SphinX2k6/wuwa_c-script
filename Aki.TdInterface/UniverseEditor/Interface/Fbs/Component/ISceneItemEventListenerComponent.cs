using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ECE RID: 24270
	public struct ISceneItemEventListenerComponent : IFlatbufferObject
	{
		// Token: 0x1700B34F RID: 45903
		// (get) Token: 0x06028AD2 RID: 166610 RVA: 0x0058F697 File Offset: 0x0058D897
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028AD3 RID: 166611 RVA: 0x0058F6A4 File Offset: 0x0058D8A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028AD4 RID: 166612 RVA: 0x0058F6AC File Offset: 0x0058D8AC
		public static ISceneItemEventListenerComponent GetRootAsISceneItemEventListenerComponent(ByteBuffer _bb)
		{
			return ISceneItemEventListenerComponent.GetRootAsISceneItemEventListenerComponent(_bb, default(ISceneItemEventListenerComponent));
		}

		// Token: 0x06028AD5 RID: 166613 RVA: 0x0058F6C8 File Offset: 0x0058D8C8
		public static ISceneItemEventListenerComponent GetRootAsISceneItemEventListenerComponent(ByteBuffer _bb, ISceneItemEventListenerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028AD6 RID: 166614 RVA: 0x0058F6E5 File Offset: 0x0058D8E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028AD7 RID: 166615 RVA: 0x0058F6F4 File Offset: 0x0058D8F4
		public ISceneItemEventListenerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B350 RID: 45904
		// (get) Token: 0x06028AD8 RID: 166616 RVA: 0x0058F704 File Offset: 0x0058D904
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06028AD9 RID: 166617 RVA: 0x0058F744 File Offset: 0x0058D944
		public ISceneItemEventConfig? Events(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISceneItemEventConfig?(default(ISceneItemEventConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B351 RID: 45905
		// (get) Token: 0x06028ADA RID: 166618 RVA: 0x0058F7A4 File Offset: 0x0058D9A4
		public int EventsLength
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

		// Token: 0x1700B352 RID: 45906
		// (get) Token: 0x06028ADB RID: 166619 RVA: 0x0058F7D0 File Offset: 0x0058D9D0
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

		// Token: 0x06028ADC RID: 166620 RVA: 0x0058F80C File Offset: 0x0058DA0C
		public static Offset<ISceneItemEventListenerComponent> CreateISceneItemEventListenerComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset EventsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ISceneItemEventListenerComponent.AddEvents(builder, EventsOffset);
			ISceneItemEventListenerComponent.AddNullMask(builder, NullMask);
			ISceneItemEventListenerComponent.AddDisabled(builder, Disabled);
			return ISceneItemEventListenerComponent.EndISceneItemEventListenerComponent(builder);
		}

		// Token: 0x06028ADD RID: 166621 RVA: 0x0058F830 File Offset: 0x0058DA30
		public static void StartISceneItemEventListenerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028ADE RID: 166622 RVA: 0x0058F839 File Offset: 0x0058DA39
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028ADF RID: 166623 RVA: 0x0058F844 File Offset: 0x0058DA44
		public static void AddEvents(FlatBufferBuilder builder, VectorOffset eventsOffset)
		{
			builder.AddOffset(1, eventsOffset.Value, 0);
		}

		// Token: 0x06028AE0 RID: 166624 RVA: 0x0058F854 File Offset: 0x0058DA54
		public static VectorOffset CreateEventsVector(FlatBufferBuilder builder, Offset<ISceneItemEventConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028AE1 RID: 166625 RVA: 0x0058F894 File Offset: 0x0058DA94
		public static VectorOffset CreateEventsVectorBlock(FlatBufferBuilder builder, Offset<ISceneItemEventConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISceneItemEventConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028AE2 RID: 166626 RVA: 0x0058F8AE File Offset: 0x0058DAAE
		public static VectorOffset CreateEventsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISceneItemEventConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISceneItemEventConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028AE3 RID: 166627 RVA: 0x0058F8CC File Offset: 0x0058DACC
		public static VectorOffset CreateEventsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISceneItemEventConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028AE4 RID: 166628 RVA: 0x0058F8E5 File Offset: 0x0058DAE5
		public static void StartEventsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028AE5 RID: 166629 RVA: 0x0058F8F0 File Offset: 0x0058DAF0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06028AE6 RID: 166630 RVA: 0x0058F8FB File Offset: 0x0058DAFB
		public static Offset<ISceneItemEventListenerComponent> EndISceneItemEventListenerComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemEventListenerComponent>(builder.EndTable());
		}

		// Token: 0x06028AE7 RID: 166631 RVA: 0x0058F908 File Offset: 0x0058DB08
		public ISceneItemEventListenerComponentT UnPack()
		{
			ISceneItemEventListenerComponentT sceneItemEventListenerComponentT = new ISceneItemEventListenerComponentT();
			this.UnPackTo(sceneItemEventListenerComponentT);
			return sceneItemEventListenerComponentT;
		}

		// Token: 0x06028AE8 RID: 166632 RVA: 0x0058F924 File Offset: 0x0058DB24
		public void UnPackTo(ISceneItemEventListenerComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Events = new List<ISceneItemEventConfigT>();
			for (int i = 0; i < this.EventsLength; i++)
			{
				_o.Events.Add((this.Events(i) != null) ? this.Events(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028AE9 RID: 166633 RVA: 0x0058F99C File Offset: 0x0058DB9C
		public static Offset<ISceneItemEventListenerComponent> Pack(FlatBufferBuilder builder, ISceneItemEventListenerComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemEventListenerComponent>);
			}
			VectorOffset eventsOffset = default(VectorOffset);
			if (_o.Events != null)
			{
				Offset<ISceneItemEventConfig>[] array = new Offset<ISceneItemEventConfig>[_o.Events.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISceneItemEventConfig.Pack(builder, _o.Events[i]);
				}
				eventsOffset = ISceneItemEventListenerComponent.CreateEventsVector(builder, array);
			}
			return ISceneItemEventListenerComponent.CreateISceneItemEventListenerComponent(builder, _o.Disabled, eventsOffset, _o.NullMask);
		}

		// Token: 0x0400FB2A RID: 64298
		private Table __p;
	}
}
