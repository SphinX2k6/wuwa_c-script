using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005502 RID: 21762
	public struct IClientConditionListenerComponent : IFlatbufferObject
	{
		// Token: 0x17009B7B RID: 39803
		// (get) Token: 0x060225F9 RID: 140793 RVA: 0x004BC9F2 File Offset: 0x004BABF2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060225FA RID: 140794 RVA: 0x004BC9FF File Offset: 0x004BABFF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060225FB RID: 140795 RVA: 0x004BCA08 File Offset: 0x004BAC08
		public static IClientConditionListenerComponent GetRootAsIClientConditionListenerComponent(ByteBuffer _bb)
		{
			return IClientConditionListenerComponent.GetRootAsIClientConditionListenerComponent(_bb, default(IClientConditionListenerComponent));
		}

		// Token: 0x060225FC RID: 140796 RVA: 0x004BCA24 File Offset: 0x004BAC24
		public static IClientConditionListenerComponent GetRootAsIClientConditionListenerComponent(ByteBuffer _bb, IClientConditionListenerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060225FD RID: 140797 RVA: 0x004BCA41 File Offset: 0x004BAC41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060225FE RID: 140798 RVA: 0x004BCA50 File Offset: 0x004BAC50
		public IClientConditionListenerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B7C RID: 39804
		// (get) Token: 0x060225FF RID: 140799 RVA: 0x004BCA60 File Offset: 0x004BAC60
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06022600 RID: 140800 RVA: 0x004BCAA0 File Offset: 0x004BACA0
		public IClientConditionListener? Listeners(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IClientConditionListener?(default(IClientConditionListener).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B7D RID: 39805
		// (get) Token: 0x06022601 RID: 140801 RVA: 0x004BCB00 File Offset: 0x004BAD00
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

		// Token: 0x17009B7E RID: 39806
		// (get) Token: 0x06022602 RID: 140802 RVA: 0x004BCB2C File Offset: 0x004BAD2C
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

		// Token: 0x06022603 RID: 140803 RVA: 0x004BCB68 File Offset: 0x004BAD68
		public static Offset<IClientConditionListenerComponent> CreateIClientConditionListenerComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ListenersOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IClientConditionListenerComponent.AddListeners(builder, ListenersOffset);
			IClientConditionListenerComponent.AddNullMask(builder, NullMask);
			IClientConditionListenerComponent.AddDisabled(builder, Disabled);
			return IClientConditionListenerComponent.EndIClientConditionListenerComponent(builder);
		}

		// Token: 0x06022604 RID: 140804 RVA: 0x004BCB8C File Offset: 0x004BAD8C
		public static void StartIClientConditionListenerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022605 RID: 140805 RVA: 0x004BCB95 File Offset: 0x004BAD95
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022606 RID: 140806 RVA: 0x004BCBA0 File Offset: 0x004BADA0
		public static void AddListeners(FlatBufferBuilder builder, VectorOffset listenersOffset)
		{
			builder.AddOffset(1, listenersOffset.Value, 0);
		}

		// Token: 0x06022607 RID: 140807 RVA: 0x004BCBB0 File Offset: 0x004BADB0
		public static VectorOffset CreateListenersVector(FlatBufferBuilder builder, Offset<IClientConditionListener>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022608 RID: 140808 RVA: 0x004BCBF0 File Offset: 0x004BADF0
		public static VectorOffset CreateListenersVectorBlock(FlatBufferBuilder builder, Offset<IClientConditionListener>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IClientConditionListener>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022609 RID: 140809 RVA: 0x004BCC0A File Offset: 0x004BAE0A
		public static VectorOffset CreateListenersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IClientConditionListener>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IClientConditionListener>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602260A RID: 140810 RVA: 0x004BCC28 File Offset: 0x004BAE28
		public static VectorOffset CreateListenersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IClientConditionListener>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602260B RID: 140811 RVA: 0x004BCC41 File Offset: 0x004BAE41
		public static void StartListenersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602260C RID: 140812 RVA: 0x004BCC4C File Offset: 0x004BAE4C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602260D RID: 140813 RVA: 0x004BCC57 File Offset: 0x004BAE57
		public static Offset<IClientConditionListenerComponent> EndIClientConditionListenerComponent(FlatBufferBuilder builder)
		{
			return new Offset<IClientConditionListenerComponent>(builder.EndTable());
		}

		// Token: 0x0602260E RID: 140814 RVA: 0x004BCC64 File Offset: 0x004BAE64
		public IClientConditionListenerComponentT UnPack()
		{
			IClientConditionListenerComponentT clientConditionListenerComponentT = new IClientConditionListenerComponentT();
			this.UnPackTo(clientConditionListenerComponentT);
			return clientConditionListenerComponentT;
		}

		// Token: 0x0602260F RID: 140815 RVA: 0x004BCC80 File Offset: 0x004BAE80
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

		// Token: 0x06022610 RID: 140816 RVA: 0x004BCCF8 File Offset: 0x004BAEF8
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

		// Token: 0x0400EA67 RID: 60007
		private Table __p;
	}
}
