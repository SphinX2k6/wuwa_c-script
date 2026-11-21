using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056D9 RID: 22233
	public struct IEntityCustomAudioComponent : IFlatbufferObject
	{
		// Token: 0x1700A03A RID: 41018
		// (get) Token: 0x06023A82 RID: 146050 RVA: 0x004E7010 File Offset: 0x004E5210
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023A83 RID: 146051 RVA: 0x004E701D File Offset: 0x004E521D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023A84 RID: 146052 RVA: 0x004E7024 File Offset: 0x004E5224
		public static IEntityCustomAudioComponent GetRootAsIEntityCustomAudioComponent(ByteBuffer _bb)
		{
			return IEntityCustomAudioComponent.GetRootAsIEntityCustomAudioComponent(_bb, default(IEntityCustomAudioComponent));
		}

		// Token: 0x06023A85 RID: 146053 RVA: 0x004E7040 File Offset: 0x004E5240
		public static IEntityCustomAudioComponent GetRootAsIEntityCustomAudioComponent(ByteBuffer _bb, IEntityCustomAudioComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023A86 RID: 146054 RVA: 0x004E705D File Offset: 0x004E525D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023A87 RID: 146055 RVA: 0x004E706C File Offset: 0x004E526C
		public IEntityCustomAudioComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A03B RID: 41019
		// (get) Token: 0x06023A88 RID: 146056 RVA: 0x004E707C File Offset: 0x004E527C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A03C RID: 41020
		// (get) Token: 0x06023A89 RID: 146057 RVA: 0x004E70BC File Offset: 0x004E52BC
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

		// Token: 0x06023A8A RID: 146058 RVA: 0x004E70F8 File Offset: 0x004E52F8
		public TTable? AkEventType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023A8B RID: 146059 RVA: 0x004E713C File Offset: 0x004E533C
		public IBoxAkEvent AkEventTypeAsIBoxAkEvent()
		{
			return this.AkEventType<IBoxAkEvent>().Value;
		}

		// Token: 0x06023A8C RID: 146060 RVA: 0x004E7158 File Offset: 0x004E5358
		public IDefaultAkEvent AkEventTypeAsIDefaultAkEvent()
		{
			return this.AkEventType<IDefaultAkEvent>().Value;
		}

		// Token: 0x06023A8D RID: 146061 RVA: 0x004E7174 File Offset: 0x004E5374
		public IPointAkEvent AkEventTypeAsIPointAkEvent()
		{
			return this.AkEventType<IPointAkEvent>().Value;
		}

		// Token: 0x1700A03D RID: 41021
		// (get) Token: 0x06023A8E RID: 146062 RVA: 0x004E7190 File Offset: 0x004E5390
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

		// Token: 0x1700A03E RID: 41022
		// (get) Token: 0x06023A8F RID: 146063 RVA: 0x004E71D0 File Offset: 0x004E53D0
		public TAudioControlType AudioControlTypeType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TAudioControlType.NONE;
				}
				return (TAudioControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023A90 RID: 146064 RVA: 0x004E7210 File Offset: 0x004E5410
		public TTable? AudioControlType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023A91 RID: 146065 RVA: 0x004E7258 File Offset: 0x004E5458
		public IGramophoneAudioControl AudioControlTypeAsIGramophoneAudioControl()
		{
			return this.AudioControlType<IGramophoneAudioControl>().Value;
		}

		// Token: 0x06023A92 RID: 146066 RVA: 0x004E7274 File Offset: 0x004E5474
		public ITrafficAudioControl AudioControlTypeAsITrafficAudioControl()
		{
			return this.AudioControlType<ITrafficAudioControl>().Value;
		}

		// Token: 0x1700A03F RID: 41023
		// (get) Token: 0x06023A93 RID: 146067 RVA: 0x004E7290 File Offset: 0x004E5490
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023A94 RID: 146068 RVA: 0x004E72D0 File Offset: 0x004E54D0
		public static Offset<IEntityCustomAudioComponent> CreateIEntityCustomAudioComponent(FlatBufferBuilder builder, bool Disabled = false, TAkEventType AkEventType_type = TAkEventType.NONE, int AkEventTypeOffset = 0, EAudioRangeType AudioRangeType = EAudioRangeType.SceneActorRefComp, TAudioControlType AudioControlType_type = TAudioControlType.NONE, int AudioControlTypeOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			IEntityCustomAudioComponent.AddAudioControlType(builder, AudioControlTypeOffset);
			IEntityCustomAudioComponent.AddAkEventType(builder, AkEventTypeOffset);
			IEntityCustomAudioComponent.AddNullMask(builder, NullMask);
			IEntityCustomAudioComponent.AddAudioControlTypeType(builder, AudioControlType_type);
			IEntityCustomAudioComponent.AddAudioRangeType(builder, AudioRangeType);
			IEntityCustomAudioComponent.AddAkEventTypeType(builder, AkEventType_type);
			IEntityCustomAudioComponent.AddDisabled(builder, Disabled);
			return IEntityCustomAudioComponent.EndIEntityCustomAudioComponent(builder);
		}

		// Token: 0x06023A95 RID: 146069 RVA: 0x004E731F File Offset: 0x004E551F
		public static void StartIEntityCustomAudioComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06023A96 RID: 146070 RVA: 0x004E7328 File Offset: 0x004E5528
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023A97 RID: 146071 RVA: 0x004E7333 File Offset: 0x004E5533
		public static void AddAkEventTypeType(FlatBufferBuilder builder, TAkEventType akEventTypeType)
		{
			builder.AddByte(1, (byte)akEventTypeType, 0);
		}

		// Token: 0x06023A98 RID: 146072 RVA: 0x004E733E File Offset: 0x004E553E
		public static void AddAkEventType(FlatBufferBuilder builder, int akEventTypeOffset)
		{
			builder.AddOffset(2, akEventTypeOffset, 0);
		}

		// Token: 0x06023A99 RID: 146073 RVA: 0x004E7349 File Offset: 0x004E5549
		public static void AddAudioRangeType(FlatBufferBuilder builder, EAudioRangeType audioRangeType)
		{
			builder.AddByte(3, (byte)audioRangeType, 0);
		}

		// Token: 0x06023A9A RID: 146074 RVA: 0x004E7354 File Offset: 0x004E5554
		public static void AddAudioControlTypeType(FlatBufferBuilder builder, TAudioControlType audioControlTypeType)
		{
			builder.AddByte(4, (byte)audioControlTypeType, 0);
		}

		// Token: 0x06023A9B RID: 146075 RVA: 0x004E735F File Offset: 0x004E555F
		public static void AddAudioControlType(FlatBufferBuilder builder, int audioControlTypeOffset)
		{
			builder.AddOffset(5, audioControlTypeOffset, 0);
		}

		// Token: 0x06023A9C RID: 146076 RVA: 0x004E736A File Offset: 0x004E556A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06023A9D RID: 146077 RVA: 0x004E7375 File Offset: 0x004E5575
		public static Offset<IEntityCustomAudioComponent> EndIEntityCustomAudioComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityCustomAudioComponent>(builder.EndTable());
		}

		// Token: 0x06023A9E RID: 146078 RVA: 0x004E7384 File Offset: 0x004E5584
		public IEntityCustomAudioComponentT UnPack()
		{
			IEntityCustomAudioComponentT entityCustomAudioComponentT = new IEntityCustomAudioComponentT();
			this.UnPackTo(entityCustomAudioComponentT);
			return entityCustomAudioComponentT;
		}

		// Token: 0x06023A9F RID: 146079 RVA: 0x004E73A0 File Offset: 0x004E55A0
		public void UnPackTo(IEntityCustomAudioComponentT _o)
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
			_o.AudioControlType = new TAudioControlTypeUnion();
			_o.AudioControlType.Type = this.AudioControlTypeType;
			TAudioControlType audioControlTypeType = this.AudioControlTypeType;
			if (audioControlTypeType != TAudioControlType.IGramophoneAudioControl)
			{
				if (audioControlTypeType == TAudioControlType.ITrafficAudioControl)
				{
					_o.AudioControlType.Value = ((this.AudioControlType<ITrafficAudioControl>() != null) ? this.AudioControlType<ITrafficAudioControl>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.AudioControlType.Value = ((this.AudioControlType<IGramophoneAudioControl>() != null) ? this.AudioControlType<IGramophoneAudioControl>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023AA0 RID: 146080 RVA: 0x004E7554 File Offset: 0x004E5754
		public static Offset<IEntityCustomAudioComponent> Pack(FlatBufferBuilder builder, IEntityCustomAudioComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityCustomAudioComponent>);
			}
			TAkEventType akEventType_type = (_o.AkEventType == null) ? TAkEventType.NONE : _o.AkEventType.Type;
			int akEventTypeOffset = (_o.AkEventType == null) ? 0 : TAkEventTypeUnion.Pack(builder, _o.AkEventType);
			TAudioControlType audioControlType_type = (_o.AudioControlType == null) ? TAudioControlType.NONE : _o.AudioControlType.Type;
			int audioControlTypeOffset = (_o.AudioControlType == null) ? 0 : TAudioControlTypeUnion.Pack(builder, _o.AudioControlType);
			return IEntityCustomAudioComponent.CreateIEntityCustomAudioComponent(builder, _o.Disabled, akEventType_type, akEventTypeOffset, _o.AudioRangeType, audioControlType_type, audioControlTypeOffset, _o.NullMask);
		}

		// Token: 0x0400EE38 RID: 60984
		private Table __p;
	}
}
