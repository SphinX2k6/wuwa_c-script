using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005718 RID: 22296
	public struct IEntityStateAudioComponent : IFlatbufferObject
	{
		// Token: 0x1700A0CA RID: 41162
		// (get) Token: 0x06023D0F RID: 146703 RVA: 0x004EC398 File Offset: 0x004EA598
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023D10 RID: 146704 RVA: 0x004EC3A5 File Offset: 0x004EA5A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023D11 RID: 146705 RVA: 0x004EC3AC File Offset: 0x004EA5AC
		public static IEntityStateAudioComponent GetRootAsIEntityStateAudioComponent(ByteBuffer _bb)
		{
			return IEntityStateAudioComponent.GetRootAsIEntityStateAudioComponent(_bb, default(IEntityStateAudioComponent));
		}

		// Token: 0x06023D12 RID: 146706 RVA: 0x004EC3C8 File Offset: 0x004EA5C8
		public static IEntityStateAudioComponent GetRootAsIEntityStateAudioComponent(ByteBuffer _bb, IEntityStateAudioComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023D13 RID: 146707 RVA: 0x004EC3E5 File Offset: 0x004EA5E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023D14 RID: 146708 RVA: 0x004EC3F4 File Offset: 0x004EA5F4
		public IEntityStateAudioComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0CB RID: 41163
		// (get) Token: 0x06023D15 RID: 146709 RVA: 0x004EC404 File Offset: 0x004EA604
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A0CC RID: 41164
		// (get) Token: 0x06023D16 RID: 146710 RVA: 0x004EC444 File Offset: 0x004EA644
		public TAkEventType AkEventTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TAkEventType.NONE;
				}
				return (TAkEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023D17 RID: 146711 RVA: 0x004EC480 File Offset: 0x004EA680
		public TTable? AkEventType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023D18 RID: 146712 RVA: 0x004EC4C4 File Offset: 0x004EA6C4
		public IBoxAkEvent AkEventTypeAsIBoxAkEvent()
		{
			return this.AkEventType<IBoxAkEvent>().Value;
		}

		// Token: 0x06023D19 RID: 146713 RVA: 0x004EC4E0 File Offset: 0x004EA6E0
		public IDefaultAkEvent AkEventTypeAsIDefaultAkEvent()
		{
			return this.AkEventType<IDefaultAkEvent>().Value;
		}

		// Token: 0x06023D1A RID: 146714 RVA: 0x004EC4FC File Offset: 0x004EA6FC
		public IPointAkEvent AkEventTypeAsIPointAkEvent()
		{
			return this.AkEventType<IPointAkEvent>().Value;
		}

		// Token: 0x1700A0CD RID: 41165
		// (get) Token: 0x06023D1B RID: 146715 RVA: 0x004EC518 File Offset: 0x004EA718
		public EAudioRangeType AudioRangeType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EAudioRangeType.SceneActorRefComp;
				}
				return (EAudioRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023D1C RID: 146716 RVA: 0x004EC558 File Offset: 0x004EA758
		public IEntityStateAudioConfig? Config(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IEntityStateAudioConfig?(default(IEntityStateAudioConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A0CE RID: 41166
		// (get) Token: 0x06023D1D RID: 146717 RVA: 0x004EC5BC File Offset: 0x004EA7BC
		public int ConfigLength
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

		// Token: 0x1700A0CF RID: 41167
		// (get) Token: 0x06023D1E RID: 146718 RVA: 0x004EC5E8 File Offset: 0x004EA7E8
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

		// Token: 0x06023D1F RID: 146719 RVA: 0x004EC625 File Offset: 0x004EA825
		public static Offset<IEntityStateAudioComponent> CreateIEntityStateAudioComponent(FlatBufferBuilder builder, bool Disabled = false, TAkEventType AkEventType_type = TAkEventType.NONE, int AkEventTypeOffset = 0, EAudioRangeType AudioRangeType = EAudioRangeType.SceneActorRefComp, VectorOffset ConfigOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IEntityStateAudioComponent.AddConfig(builder, ConfigOffset);
			IEntityStateAudioComponent.AddAkEventType(builder, AkEventTypeOffset);
			IEntityStateAudioComponent.AddNullMask(builder, NullMask);
			IEntityStateAudioComponent.AddAudioRangeType(builder, AudioRangeType);
			IEntityStateAudioComponent.AddAkEventTypeType(builder, AkEventType_type);
			IEntityStateAudioComponent.AddDisabled(builder, Disabled);
			return IEntityStateAudioComponent.EndIEntityStateAudioComponent(builder);
		}

		// Token: 0x06023D20 RID: 146720 RVA: 0x004EC661 File Offset: 0x004EA861
		public static void StartIEntityStateAudioComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06023D21 RID: 146721 RVA: 0x004EC66A File Offset: 0x004EA86A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023D22 RID: 146722 RVA: 0x004EC675 File Offset: 0x004EA875
		public static void AddAkEventTypeType(FlatBufferBuilder builder, TAkEventType akEventTypeType)
		{
			builder.AddByte(1, (byte)akEventTypeType, 0);
		}

		// Token: 0x06023D23 RID: 146723 RVA: 0x004EC680 File Offset: 0x004EA880
		public static void AddAkEventType(FlatBufferBuilder builder, int akEventTypeOffset)
		{
			builder.AddOffset(2, akEventTypeOffset, 0);
		}

		// Token: 0x06023D24 RID: 146724 RVA: 0x004EC68B File Offset: 0x004EA88B
		public static void AddAudioRangeType(FlatBufferBuilder builder, EAudioRangeType audioRangeType)
		{
			builder.AddByte(3, (byte)audioRangeType, 0);
		}

		// Token: 0x06023D25 RID: 146725 RVA: 0x004EC696 File Offset: 0x004EA896
		public static void AddConfig(FlatBufferBuilder builder, VectorOffset configOffset)
		{
			builder.AddOffset(4, configOffset.Value, 0);
		}

		// Token: 0x06023D26 RID: 146726 RVA: 0x004EC6A8 File Offset: 0x004EA8A8
		public static VectorOffset CreateConfigVector(FlatBufferBuilder builder, Offset<IEntityStateAudioConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023D27 RID: 146727 RVA: 0x004EC6E8 File Offset: 0x004EA8E8
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, Offset<IEntityStateAudioConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityStateAudioConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023D28 RID: 146728 RVA: 0x004EC702 File Offset: 0x004EA902
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityStateAudioConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityStateAudioConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023D29 RID: 146729 RVA: 0x004EC720 File Offset: 0x004EA920
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityStateAudioConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023D2A RID: 146730 RVA: 0x004EC739 File Offset: 0x004EA939
		public static void StartConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023D2B RID: 146731 RVA: 0x004EC744 File Offset: 0x004EA944
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06023D2C RID: 146732 RVA: 0x004EC74F File Offset: 0x004EA94F
		public static Offset<IEntityStateAudioComponent> EndIEntityStateAudioComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityStateAudioComponent>(builder.EndTable());
		}

		// Token: 0x06023D2D RID: 146733 RVA: 0x004EC75C File Offset: 0x004EA95C
		public IEntityStateAudioComponentT UnPack()
		{
			IEntityStateAudioComponentT entityStateAudioComponentT = new IEntityStateAudioComponentT();
			this.UnPackTo(entityStateAudioComponentT);
			return entityStateAudioComponentT;
		}

		// Token: 0x06023D2E RID: 146734 RVA: 0x004EC778 File Offset: 0x004EA978
		public void UnPackTo(IEntityStateAudioComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.AkEventType = new TAkEventTypeUnion();
			_o.AkEventType.Type = this.AkEventTypeType;
			switch (this.AkEventTypeType)
			{
			case TAkEventType.IBoxAkEvent:
				_o.AkEventType.Value = ((this.AkEventType<IBoxAkEvent>() != null) ? this.AkEventType<IBoxAkEvent>().Value.UnPack() : null);
				break;
			case TAkEventType.IDefaultAkEvent:
				_o.AkEventType.Value = ((this.AkEventType<IDefaultAkEvent>() != null) ? this.AkEventType<IDefaultAkEvent>().Value.UnPack() : null);
				break;
			case TAkEventType.IPointAkEvent:
				_o.AkEventType.Value = ((this.AkEventType<IPointAkEvent>() != null) ? this.AkEventType<IPointAkEvent>().Value.UnPack() : null);
				break;
			}
			_o.AudioRangeType = this.AudioRangeType;
			_o.Config = new List<IEntityStateAudioConfigT>();
			for (int i = 0; i < this.ConfigLength; i++)
			{
				_o.Config.Add((this.Config(i) != null) ? this.Config(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023D2F RID: 146735 RVA: 0x004EC8E4 File Offset: 0x004EAAE4
		public static Offset<IEntityStateAudioComponent> Pack(FlatBufferBuilder builder, IEntityStateAudioComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityStateAudioComponent>);
			}
			TAkEventType akEventType_type = (_o.AkEventType == null) ? TAkEventType.NONE : _o.AkEventType.Type;
			int akEventTypeOffset = (_o.AkEventType == null) ? 0 : TAkEventTypeUnion.Pack(builder, _o.AkEventType);
			VectorOffset configOffset = default(VectorOffset);
			if (_o.Config != null)
			{
				Offset<IEntityStateAudioConfig>[] array = new Offset<IEntityStateAudioConfig>[_o.Config.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityStateAudioConfig.Pack(builder, _o.Config[i]);
				}
				configOffset = IEntityStateAudioComponent.CreateConfigVector(builder, array);
			}
			return IEntityStateAudioComponent.CreateIEntityStateAudioComponent(builder, _o.Disabled, akEventType_type, akEventTypeOffset, _o.AudioRangeType, configOffset, _o.NullMask);
		}

		// Token: 0x0400EE97 RID: 61079
		private Table __p;
	}
}
