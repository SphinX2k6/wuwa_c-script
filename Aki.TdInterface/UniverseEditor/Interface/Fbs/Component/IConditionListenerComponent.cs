using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FF7 RID: 20471
	public struct IConditionListenerComponent : IFlatbufferObject
	{
		// Token: 0x1700944D RID: 37965
		// (get) Token: 0x06020B87 RID: 134023 RVA: 0x0048CB87 File Offset: 0x0048AD87
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020B88 RID: 134024 RVA: 0x0048CB94 File Offset: 0x0048AD94
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020B89 RID: 134025 RVA: 0x0048CB9C File Offset: 0x0048AD9C
		public static IConditionListenerComponent GetRootAsIConditionListenerComponent(ByteBuffer _bb)
		{
			return IConditionListenerComponent.GetRootAsIConditionListenerComponent(_bb, default(IConditionListenerComponent));
		}

		// Token: 0x06020B8A RID: 134026 RVA: 0x0048CBB8 File Offset: 0x0048ADB8
		public static IConditionListenerComponent GetRootAsIConditionListenerComponent(ByteBuffer _bb, IConditionListenerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020B8B RID: 134027 RVA: 0x0048CBD5 File Offset: 0x0048ADD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020B8C RID: 134028 RVA: 0x0048CBE4 File Offset: 0x0048ADE4
		public IConditionListenerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700944E RID: 37966
		// (get) Token: 0x06020B8D RID: 134029 RVA: 0x0048CBF4 File Offset: 0x0048ADF4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06020B8E RID: 134030 RVA: 0x0048CC34 File Offset: 0x0048AE34
		public ICondtionListener? Listeners(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICondtionListener?(default(ICondtionListener).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700944F RID: 37967
		// (get) Token: 0x06020B8F RID: 134031 RVA: 0x0048CC94 File Offset: 0x0048AE94
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

		// Token: 0x17009450 RID: 37968
		// (get) Token: 0x06020B90 RID: 134032 RVA: 0x0048CCC0 File Offset: 0x0048AEC0
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

		// Token: 0x06020B91 RID: 134033 RVA: 0x0048CCFC File Offset: 0x0048AEFC
		public static Offset<IConditionListenerComponent> CreateIConditionListenerComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ListenersOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IConditionListenerComponent.AddListeners(builder, ListenersOffset);
			IConditionListenerComponent.AddNullMask(builder, NullMask);
			IConditionListenerComponent.AddDisabled(builder, Disabled);
			return IConditionListenerComponent.EndIConditionListenerComponent(builder);
		}

		// Token: 0x06020B92 RID: 134034 RVA: 0x0048CD20 File Offset: 0x0048AF20
		public static void StartIConditionListenerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020B93 RID: 134035 RVA: 0x0048CD29 File Offset: 0x0048AF29
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06020B94 RID: 134036 RVA: 0x0048CD34 File Offset: 0x0048AF34
		public static void AddListeners(FlatBufferBuilder builder, VectorOffset listenersOffset)
		{
			builder.AddOffset(1, listenersOffset.Value, 0);
		}

		// Token: 0x06020B95 RID: 134037 RVA: 0x0048CD44 File Offset: 0x0048AF44
		public static VectorOffset CreateListenersVector(FlatBufferBuilder builder, Offset<ICondtionListener>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020B96 RID: 134038 RVA: 0x0048CD84 File Offset: 0x0048AF84
		public static VectorOffset CreateListenersVectorBlock(FlatBufferBuilder builder, Offset<ICondtionListener>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICondtionListener>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020B97 RID: 134039 RVA: 0x0048CD9E File Offset: 0x0048AF9E
		public static VectorOffset CreateListenersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICondtionListener>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICondtionListener>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020B98 RID: 134040 RVA: 0x0048CDBC File Offset: 0x0048AFBC
		public static VectorOffset CreateListenersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICondtionListener>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020B99 RID: 134041 RVA: 0x0048CDD5 File Offset: 0x0048AFD5
		public static void StartListenersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020B9A RID: 134042 RVA: 0x0048CDE0 File Offset: 0x0048AFE0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06020B9B RID: 134043 RVA: 0x0048CDEB File Offset: 0x0048AFEB
		public static Offset<IConditionListenerComponent> EndIConditionListenerComponent(FlatBufferBuilder builder)
		{
			return new Offset<IConditionListenerComponent>(builder.EndTable());
		}

		// Token: 0x06020B9C RID: 134044 RVA: 0x0048CDF8 File Offset: 0x0048AFF8
		public IConditionListenerComponentT UnPack()
		{
			IConditionListenerComponentT conditionListenerComponentT = new IConditionListenerComponentT();
			this.UnPackTo(conditionListenerComponentT);
			return conditionListenerComponentT;
		}

		// Token: 0x06020B9D RID: 134045 RVA: 0x0048CE14 File Offset: 0x0048B014
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

		// Token: 0x06020B9E RID: 134046 RVA: 0x0048CE8C File Offset: 0x0048B08C
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

		// Token: 0x0400DFB0 RID: 57264
		private Table __p;
	}
}
