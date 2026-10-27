using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C1 RID: 22721
	public struct ISceneItemEventListenerComponent : IFlatbufferObject
	{
		// Token: 0x1700AA1F RID: 43551
		// (get) Token: 0x06026570 RID: 157040 RVA: 0x00548B4B File Offset: 0x00546D4B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026571 RID: 157041 RVA: 0x00548B58 File Offset: 0x00546D58
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026572 RID: 157042 RVA: 0x00548B60 File Offset: 0x00546D60
		public static ISceneItemEventListenerComponent GetRootAsISceneItemEventListenerComponent(ByteBuffer _bb)
		{
			return ISceneItemEventListenerComponent.GetRootAsISceneItemEventListenerComponent(_bb, default(ISceneItemEventListenerComponent));
		}

		// Token: 0x06026573 RID: 157043 RVA: 0x00548B7C File Offset: 0x00546D7C
		public static ISceneItemEventListenerComponent GetRootAsISceneItemEventListenerComponent(ByteBuffer _bb, ISceneItemEventListenerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026574 RID: 157044 RVA: 0x00548B99 File Offset: 0x00546D99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026575 RID: 157045 RVA: 0x00548BA8 File Offset: 0x00546DA8
		public ISceneItemEventListenerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA20 RID: 43552
		// (get) Token: 0x06026576 RID: 157046 RVA: 0x00548BB8 File Offset: 0x00546DB8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06026577 RID: 157047 RVA: 0x00548BF8 File Offset: 0x00546DF8
		public ISceneItemEventConfig? Events(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISceneItemEventConfig?(default(ISceneItemEventConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AA21 RID: 43553
		// (get) Token: 0x06026578 RID: 157048 RVA: 0x00548C58 File Offset: 0x00546E58
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

		// Token: 0x1700AA22 RID: 43554
		// (get) Token: 0x06026579 RID: 157049 RVA: 0x00548C84 File Offset: 0x00546E84
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

		// Token: 0x0602657A RID: 157050 RVA: 0x00548CC0 File Offset: 0x00546EC0
		public static Offset<ISceneItemEventListenerComponent> CreateISceneItemEventListenerComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset EventsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ISceneItemEventListenerComponent.AddEvents(builder, EventsOffset);
			ISceneItemEventListenerComponent.AddNullMask(builder, NullMask);
			ISceneItemEventListenerComponent.AddDisabled(builder, Disabled);
			return ISceneItemEventListenerComponent.EndISceneItemEventListenerComponent(builder);
		}

		// Token: 0x0602657B RID: 157051 RVA: 0x00548CE4 File Offset: 0x00546EE4
		public static void StartISceneItemEventListenerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602657C RID: 157052 RVA: 0x00548CED File Offset: 0x00546EED
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602657D RID: 157053 RVA: 0x00548CF8 File Offset: 0x00546EF8
		public static void AddEvents(FlatBufferBuilder builder, VectorOffset eventsOffset)
		{
			builder.AddOffset(1, eventsOffset.Value, 0);
		}

		// Token: 0x0602657E RID: 157054 RVA: 0x00548D08 File Offset: 0x00546F08
		public static VectorOffset CreateEventsVector(FlatBufferBuilder builder, Offset<ISceneItemEventConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602657F RID: 157055 RVA: 0x00548D48 File Offset: 0x00546F48
		public static VectorOffset CreateEventsVectorBlock(FlatBufferBuilder builder, Offset<ISceneItemEventConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISceneItemEventConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026580 RID: 157056 RVA: 0x00548D62 File Offset: 0x00546F62
		public static VectorOffset CreateEventsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISceneItemEventConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISceneItemEventConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026581 RID: 157057 RVA: 0x00548D80 File Offset: 0x00546F80
		public static VectorOffset CreateEventsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISceneItemEventConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026582 RID: 157058 RVA: 0x00548D99 File Offset: 0x00546F99
		public static void StartEventsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026583 RID: 157059 RVA: 0x00548DA4 File Offset: 0x00546FA4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06026584 RID: 157060 RVA: 0x00548DAF File Offset: 0x00546FAF
		public static Offset<ISceneItemEventListenerComponent> EndISceneItemEventListenerComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemEventListenerComponent>(builder.EndTable());
		}

		// Token: 0x06026585 RID: 157061 RVA: 0x00548DBC File Offset: 0x00546FBC
		public ISceneItemEventListenerComponentT UnPack()
		{
			ISceneItemEventListenerComponentT sceneItemEventListenerComponentT = new ISceneItemEventListenerComponentT();
			this.UnPackTo(sceneItemEventListenerComponentT);
			return sceneItemEventListenerComponentT;
		}

		// Token: 0x06026586 RID: 157062 RVA: 0x00548DD8 File Offset: 0x00546FD8
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

		// Token: 0x06026587 RID: 157063 RVA: 0x00548E50 File Offset: 0x00547050
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

		// Token: 0x0400EE37 RID: 60983
		private Table __p;
	}
}
