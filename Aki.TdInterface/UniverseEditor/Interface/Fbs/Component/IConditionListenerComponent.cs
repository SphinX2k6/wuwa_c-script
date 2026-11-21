using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005556 RID: 21846
	public struct IConditionListenerComponent : IFlatbufferObject
	{
		// Token: 0x17009C2E RID: 39982
		// (get) Token: 0x06022AA7 RID: 141991 RVA: 0x004C65D7 File Offset: 0x004C47D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022AA8 RID: 141992 RVA: 0x004C65E4 File Offset: 0x004C47E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022AA9 RID: 141993 RVA: 0x004C65EC File Offset: 0x004C47EC
		public static IConditionListenerComponent GetRootAsIConditionListenerComponent(ByteBuffer _bb)
		{
			return IConditionListenerComponent.GetRootAsIConditionListenerComponent(_bb, default(IConditionListenerComponent));
		}

		// Token: 0x06022AAA RID: 141994 RVA: 0x004C6608 File Offset: 0x004C4808
		public static IConditionListenerComponent GetRootAsIConditionListenerComponent(ByteBuffer _bb, IConditionListenerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022AAB RID: 141995 RVA: 0x004C6625 File Offset: 0x004C4825
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022AAC RID: 141996 RVA: 0x004C6634 File Offset: 0x004C4834
		public IConditionListenerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C2F RID: 39983
		// (get) Token: 0x06022AAD RID: 141997 RVA: 0x004C6644 File Offset: 0x004C4844
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06022AAE RID: 141998 RVA: 0x004C6684 File Offset: 0x004C4884
		public ICondtionListener? Listeners(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICondtionListener?(default(ICondtionListener).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C30 RID: 39984
		// (get) Token: 0x06022AAF RID: 141999 RVA: 0x004C66E4 File Offset: 0x004C48E4
		public int ListenersLength
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

		// Token: 0x17009C31 RID: 39985
		// (get) Token: 0x06022AB0 RID: 142000 RVA: 0x004C6710 File Offset: 0x004C4910
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

		// Token: 0x06022AB1 RID: 142001 RVA: 0x004C674C File Offset: 0x004C494C
		public static Offset<IConditionListenerComponent> CreateIConditionListenerComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ListenersOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IConditionListenerComponent.AddListeners(builder, ListenersOffset);
			IConditionListenerComponent.AddNullMask(builder, NullMask);
			IConditionListenerComponent.AddDisabled(builder, Disabled);
			return IConditionListenerComponent.EndIConditionListenerComponent(builder);
		}

		// Token: 0x06022AB2 RID: 142002 RVA: 0x004C6770 File Offset: 0x004C4970
		public static void StartIConditionListenerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022AB3 RID: 142003 RVA: 0x004C6779 File Offset: 0x004C4979
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022AB4 RID: 142004 RVA: 0x004C6784 File Offset: 0x004C4984
		public static void AddListeners(FlatBufferBuilder builder, VectorOffset listenersOffset)
		{
			builder.AddOffset(1, listenersOffset.Value, 0);
		}

		// Token: 0x06022AB5 RID: 142005 RVA: 0x004C6794 File Offset: 0x004C4994
		public static VectorOffset CreateListenersVector(FlatBufferBuilder builder, Offset<ICondtionListener>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022AB6 RID: 142006 RVA: 0x004C67D4 File Offset: 0x004C49D4
		public static VectorOffset CreateListenersVectorBlock(FlatBufferBuilder builder, Offset<ICondtionListener>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICondtionListener>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022AB7 RID: 142007 RVA: 0x004C67EE File Offset: 0x004C49EE
		public static VectorOffset CreateListenersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICondtionListener>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICondtionListener>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022AB8 RID: 142008 RVA: 0x004C680C File Offset: 0x004C4A0C
		public static VectorOffset CreateListenersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICondtionListener>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022AB9 RID: 142009 RVA: 0x004C6825 File Offset: 0x004C4A25
		public static void StartListenersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022ABA RID: 142010 RVA: 0x004C6830 File Offset: 0x004C4A30
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06022ABB RID: 142011 RVA: 0x004C683B File Offset: 0x004C4A3B
		public static Offset<IConditionListenerComponent> EndIConditionListenerComponent(FlatBufferBuilder builder)
		{
			return new Offset<IConditionListenerComponent>(builder.EndTable());
		}

		// Token: 0x06022ABC RID: 142012 RVA: 0x004C6848 File Offset: 0x004C4A48
		public IConditionListenerComponentT UnPack()
		{
			IConditionListenerComponentT conditionListenerComponentT = new IConditionListenerComponentT();
			this.UnPackTo(conditionListenerComponentT);
			return conditionListenerComponentT;
		}

		// Token: 0x06022ABD RID: 142013 RVA: 0x004C6864 File Offset: 0x004C4A64
		public void UnPackTo(IConditionListenerComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Listeners = new List<ICondtionListenerT>();
			for (int i = 0; i < this.ListenersLength; i++)
			{
				_o.Listeners.Add((this.Listeners(i) != null) ? this.Listeners(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022ABE RID: 142014 RVA: 0x004C68DC File Offset: 0x004C4ADC
		public static Offset<IConditionListenerComponent> Pack(FlatBufferBuilder builder, IConditionListenerComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionListenerComponent>);
			}
			VectorOffset listenersOffset = default(VectorOffset);
			if (_o.Listeners != null)
			{
				Offset<ICondtionListener>[] array = new Offset<ICondtionListener>[_o.Listeners.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICondtionListener.Pack(builder, _o.Listeners[i]);
				}
				listenersOffset = IConditionListenerComponent.CreateListenersVector(builder, array);
			}
			return IConditionListenerComponent.CreateIConditionListenerComponent(builder, _o.Disabled, listenersOffset, _o.NullMask);
		}

		// Token: 0x0400EBA6 RID: 60326
		private Table __p;
	}
}
