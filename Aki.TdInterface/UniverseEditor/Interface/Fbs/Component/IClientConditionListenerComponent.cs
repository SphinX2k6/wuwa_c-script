using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FA6 RID: 20390
	public struct IClientConditionListenerComponent : IFlatbufferObject
	{
		// Token: 0x170093A3 RID: 37795
		// (get) Token: 0x06020705 RID: 132869 RVA: 0x0048350E File Offset: 0x0048170E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020706 RID: 132870 RVA: 0x0048351B File Offset: 0x0048171B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020707 RID: 132871 RVA: 0x00483524 File Offset: 0x00481724
		public static IClientConditionListenerComponent GetRootAsIClientConditionListenerComponent(ByteBuffer _bb)
		{
			return IClientConditionListenerComponent.GetRootAsIClientConditionListenerComponent(_bb, default(IClientConditionListenerComponent));
		}

		// Token: 0x06020708 RID: 132872 RVA: 0x00483540 File Offset: 0x00481740
		public static IClientConditionListenerComponent GetRootAsIClientConditionListenerComponent(ByteBuffer _bb, IClientConditionListenerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020709 RID: 132873 RVA: 0x0048355D File Offset: 0x0048175D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602070A RID: 132874 RVA: 0x0048356C File Offset: 0x0048176C
		public IClientConditionListenerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093A4 RID: 37796
		// (get) Token: 0x0602070B RID: 132875 RVA: 0x0048357C File Offset: 0x0048177C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602070C RID: 132876 RVA: 0x004835BC File Offset: 0x004817BC
		public IClientConditionListener? Listeners(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IClientConditionListener?(default(IClientConditionListener).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170093A5 RID: 37797
		// (get) Token: 0x0602070D RID: 132877 RVA: 0x0048361C File Offset: 0x0048181C
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

		// Token: 0x170093A6 RID: 37798
		// (get) Token: 0x0602070E RID: 132878 RVA: 0x00483648 File Offset: 0x00481848
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

		// Token: 0x0602070F RID: 132879 RVA: 0x00483684 File Offset: 0x00481884
		public static Offset<IClientConditionListenerComponent> CreateIClientConditionListenerComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ListenersOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IClientConditionListenerComponent.AddListeners(builder, ListenersOffset);
			IClientConditionListenerComponent.AddNullMask(builder, NullMask);
			IClientConditionListenerComponent.AddDisabled(builder, Disabled);
			return IClientConditionListenerComponent.EndIClientConditionListenerComponent(builder);
		}

		// Token: 0x06020710 RID: 132880 RVA: 0x004836A8 File Offset: 0x004818A8
		public static void StartIClientConditionListenerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020711 RID: 132881 RVA: 0x004836B1 File Offset: 0x004818B1
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06020712 RID: 132882 RVA: 0x004836BC File Offset: 0x004818BC
		public static void AddListeners(FlatBufferBuilder builder, VectorOffset listenersOffset)
		{
			builder.AddOffset(1, listenersOffset.Value, 0);
		}

		// Token: 0x06020713 RID: 132883 RVA: 0x004836CC File Offset: 0x004818CC
		public static VectorOffset CreateListenersVector(FlatBufferBuilder builder, Offset<IClientConditionListener>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020714 RID: 132884 RVA: 0x0048370C File Offset: 0x0048190C
		public static VectorOffset CreateListenersVectorBlock(FlatBufferBuilder builder, Offset<IClientConditionListener>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IClientConditionListener>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020715 RID: 132885 RVA: 0x00483726 File Offset: 0x00481926
		public static VectorOffset CreateListenersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IClientConditionListener>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IClientConditionListener>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020716 RID: 132886 RVA: 0x00483744 File Offset: 0x00481944
		public static VectorOffset CreateListenersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IClientConditionListener>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020717 RID: 132887 RVA: 0x0048375D File Offset: 0x0048195D
		public static void StartListenersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020718 RID: 132888 RVA: 0x00483768 File Offset: 0x00481968
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06020719 RID: 132889 RVA: 0x00483773 File Offset: 0x00481973
		public static Offset<IClientConditionListenerComponent> EndIClientConditionListenerComponent(FlatBufferBuilder builder)
		{
			return new Offset<IClientConditionListenerComponent>(builder.EndTable());
		}

		// Token: 0x0602071A RID: 132890 RVA: 0x00483780 File Offset: 0x00481980
		public IClientConditionListenerComponentT UnPack()
		{
			IClientConditionListenerComponentT clientConditionListenerComponentT = new IClientConditionListenerComponentT();
			this.UnPackTo(clientConditionListenerComponentT);
			return clientConditionListenerComponentT;
		}

		// Token: 0x0602071B RID: 132891 RVA: 0x0048379C File Offset: 0x0048199C
		public void UnPackTo(IClientConditionListenerComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Listeners = new List<IClientConditionListenerT>();
			for (int i = 0; i < this.ListenersLength; i++)
			{
				_o.Listeners.Add((this.Listeners(i) != null) ? this.Listeners(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602071C RID: 132892 RVA: 0x00483814 File Offset: 0x00481A14
		public static Offset<IClientConditionListenerComponent> Pack(FlatBufferBuilder builder, IClientConditionListenerComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientConditionListenerComponent>);
			}
			VectorOffset listenersOffset = default(VectorOffset);
			if (_o.Listeners != null)
			{
				Offset<IClientConditionListener>[] array = new Offset<IClientConditionListener>[_o.Listeners.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IClientConditionListener.Pack(builder, _o.Listeners[i]);
				}
				listenersOffset = IClientConditionListenerComponent.CreateListenersVector(builder, array);
			}
			return IClientConditionListenerComponent.CreateIClientConditionListenerComponent(builder, _o.Disabled, listenersOffset, _o.NullMask);
		}

		// Token: 0x0400DE79 RID: 56953
		private Table __p;
	}
}
