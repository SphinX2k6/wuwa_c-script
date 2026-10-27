using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005156 RID: 20822
	public struct IEntityAudioComponent : IFlatbufferObject
	{
		// Token: 0x170097DF RID: 38879
		// (get) Token: 0x060219C6 RID: 137670 RVA: 0x004AA257 File Offset: 0x004A8457
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060219C7 RID: 137671 RVA: 0x004AA264 File Offset: 0x004A8464
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060219C8 RID: 137672 RVA: 0x004AA26C File Offset: 0x004A846C
		public static IEntityAudioComponent GetRootAsIEntityAudioComponent(ByteBuffer _bb)
		{
			return IEntityAudioComponent.GetRootAsIEntityAudioComponent(_bb, default(IEntityAudioComponent));
		}

		// Token: 0x060219C9 RID: 137673 RVA: 0x004AA288 File Offset: 0x004A8488
		public static IEntityAudioComponent GetRootAsIEntityAudioComponent(ByteBuffer _bb, IEntityAudioComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060219CA RID: 137674 RVA: 0x004AA2A5 File Offset: 0x004A84A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060219CB RID: 137675 RVA: 0x004AA2B4 File Offset: 0x004A84B4
		public IEntityAudioComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097E0 RID: 38880
		// (get) Token: 0x060219CC RID: 137676 RVA: 0x004AA2C4 File Offset: 0x004A84C4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170097E1 RID: 38881
		// (get) Token: 0x060219CD RID: 137677 RVA: 0x004AA304 File Offset: 0x004A8504
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

		// Token: 0x060219CE RID: 137678 RVA: 0x004AA340 File Offset: 0x004A8540
		public TTable? AkEventType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060219CF RID: 137679 RVA: 0x004AA384 File Offset: 0x004A8584
		public IBoxAkEvent AkEventTypeAsIBoxAkEvent()
		{
			return this.AkEventType<IBoxAkEvent>().Value;
		}

		// Token: 0x060219D0 RID: 137680 RVA: 0x004AA3A0 File Offset: 0x004A85A0
		public IDefaultAkEvent AkEventTypeAsIDefaultAkEvent()
		{
			return this.AkEventType<IDefaultAkEvent>().Value;
		}

		// Token: 0x060219D1 RID: 137681 RVA: 0x004AA3BC File Offset: 0x004A85BC
		public IPointAkEvent AkEventTypeAsIPointAkEvent()
		{
			return this.AkEventType<IPointAkEvent>().Value;
		}

		// Token: 0x170097E2 RID: 38882
		// (get) Token: 0x060219D2 RID: 137682 RVA: 0x004AA3D8 File Offset: 0x004A85D8
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

		// Token: 0x170097E3 RID: 38883
		// (get) Token: 0x060219D3 RID: 137683 RVA: 0x004AA418 File Offset: 0x004A8618
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060219D4 RID: 137684 RVA: 0x004AA455 File Offset: 0x004A8655
		public static Offset<IEntityAudioComponent> CreateIEntityAudioComponent(FlatBufferBuilder builder, bool Disabled = false, TAkEventType AkEventType_type = TAkEventType.NONE, int AkEventTypeOffset = 0, EAudioRangeType AudioRangeType = EAudioRangeType.SceneActorRefComp, byte NullMask = 0)
		{
			builder.StartTable(5);
			IEntityAudioComponent.AddAkEventType(builder, AkEventTypeOffset);
			IEntityAudioComponent.AddNullMask(builder, NullMask);
			IEntityAudioComponent.AddAudioRangeType(builder, AudioRangeType);
			IEntityAudioComponent.AddAkEventTypeType(builder, AkEventType_type);
			IEntityAudioComponent.AddDisabled(builder, Disabled);
			return IEntityAudioComponent.EndIEntityAudioComponent(builder);
		}

		// Token: 0x060219D5 RID: 137685 RVA: 0x004AA489 File Offset: 0x004A8689
		public static void StartIEntityAudioComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060219D6 RID: 137686 RVA: 0x004AA492 File Offset: 0x004A8692
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060219D7 RID: 137687 RVA: 0x004AA49D File Offset: 0x004A869D
		public static void AddAkEventTypeType(FlatBufferBuilder builder, TAkEventType akEventTypeType)
		{
			builder.AddByte(1, (byte)akEventTypeType, 0);
		}

		// Token: 0x060219D8 RID: 137688 RVA: 0x004AA4A8 File Offset: 0x004A86A8
		public static void AddAkEventType(FlatBufferBuilder builder, int akEventTypeOffset)
		{
			builder.AddOffset(2, akEventTypeOffset, 0);
		}

		// Token: 0x060219D9 RID: 137689 RVA: 0x004AA4B3 File Offset: 0x004A86B3
		public static void AddAudioRangeType(FlatBufferBuilder builder, EAudioRangeType audioRangeType)
		{
			builder.AddByte(3, (byte)audioRangeType, 0);
		}

		// Token: 0x060219DA RID: 137690 RVA: 0x004AA4BE File Offset: 0x004A86BE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060219DB RID: 137691 RVA: 0x004AA4C9 File Offset: 0x004A86C9
		public static Offset<IEntityAudioComponent> EndIEntityAudioComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityAudioComponent>(builder.EndTable());
		}

		// Token: 0x060219DC RID: 137692 RVA: 0x004AA4D8 File Offset: 0x004A86D8
		public IEntityAudioComponentT UnPack()
		{
			IEntityAudioComponentT entityAudioComponentT = new IEntityAudioComponentT();
			this.UnPackTo(entityAudioComponentT);
			return entityAudioComponentT;
		}

		// Token: 0x060219DD RID: 137693 RVA: 0x004AA4F4 File Offset: 0x004A86F4
		public void UnPackTo(IEntityAudioComponentT _o)
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060219DE RID: 137694 RVA: 0x004AA608 File Offset: 0x004A8808
		public static Offset<IEntityAudioComponent> Pack(FlatBufferBuilder builder, IEntityAudioComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityAudioComponent>);
			}
			TAkEventType akEventType_type = (_o.AkEventType == null) ? TAkEventType.NONE : _o.AkEventType.Type;
			int akEventTypeOffset = (_o.AkEventType == null) ? 0 : TAkEventTypeUnion.Pack(builder, _o.AkEventType);
			return IEntityAudioComponent.CreateIEntityAudioComponent(builder, _o.Disabled, akEventType_type, akEventTypeOffset, _o.AudioRangeType, _o.NullMask);
		}

		// Token: 0x0400E1F4 RID: 57844
		private Table __p;
	}
}
