using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056BB RID: 22203
	public struct IEntityAudioComponent : IFlatbufferObject
	{
		// Token: 0x17009FCC RID: 40908
		// (get) Token: 0x0602391A RID: 145690 RVA: 0x004E41E3 File Offset: 0x004E23E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602391B RID: 145691 RVA: 0x004E41F0 File Offset: 0x004E23F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602391C RID: 145692 RVA: 0x004E41F8 File Offset: 0x004E23F8
		public static IEntityAudioComponent GetRootAsIEntityAudioComponent(ByteBuffer _bb)
		{
			return IEntityAudioComponent.GetRootAsIEntityAudioComponent(_bb, default(IEntityAudioComponent));
		}

		// Token: 0x0602391D RID: 145693 RVA: 0x004E4214 File Offset: 0x004E2414
		public static IEntityAudioComponent GetRootAsIEntityAudioComponent(ByteBuffer _bb, IEntityAudioComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602391E RID: 145694 RVA: 0x004E4231 File Offset: 0x004E2431
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602391F RID: 145695 RVA: 0x004E4240 File Offset: 0x004E2440
		public IEntityAudioComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FCD RID: 40909
		// (get) Token: 0x06023920 RID: 145696 RVA: 0x004E4250 File Offset: 0x004E2450
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009FCE RID: 40910
		// (get) Token: 0x06023921 RID: 145697 RVA: 0x004E4290 File Offset: 0x004E2490
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

		// Token: 0x06023922 RID: 145698 RVA: 0x004E42CC File Offset: 0x004E24CC
		public TTable? AkEventType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023923 RID: 145699 RVA: 0x004E4310 File Offset: 0x004E2510
		public IBoxAkEvent AkEventTypeAsIBoxAkEvent()
		{
			return this.AkEventType<IBoxAkEvent>().Value;
		}

		// Token: 0x06023924 RID: 145700 RVA: 0x004E432C File Offset: 0x004E252C
		public IDefaultAkEvent AkEventTypeAsIDefaultAkEvent()
		{
			return this.AkEventType<IDefaultAkEvent>().Value;
		}

		// Token: 0x06023925 RID: 145701 RVA: 0x004E4348 File Offset: 0x004E2548
		public IPointAkEvent AkEventTypeAsIPointAkEvent()
		{
			return this.AkEventType<IPointAkEvent>().Value;
		}

		// Token: 0x17009FCF RID: 40911
		// (get) Token: 0x06023926 RID: 145702 RVA: 0x004E4364 File Offset: 0x004E2564
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

		// Token: 0x17009FD0 RID: 40912
		// (get) Token: 0x06023927 RID: 145703 RVA: 0x004E43A4 File Offset: 0x004E25A4
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

		// Token: 0x06023928 RID: 145704 RVA: 0x004E43E1 File Offset: 0x004E25E1
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

		// Token: 0x06023929 RID: 145705 RVA: 0x004E4415 File Offset: 0x004E2615
		public static void StartIEntityAudioComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602392A RID: 145706 RVA: 0x004E441E File Offset: 0x004E261E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602392B RID: 145707 RVA: 0x004E4429 File Offset: 0x004E2629
		public static void AddAkEventTypeType(FlatBufferBuilder builder, TAkEventType akEventTypeType)
		{
			builder.AddByte(1, (byte)akEventTypeType, 0);
		}

		// Token: 0x0602392C RID: 145708 RVA: 0x004E4434 File Offset: 0x004E2634
		public static void AddAkEventType(FlatBufferBuilder builder, int akEventTypeOffset)
		{
			builder.AddOffset(2, akEventTypeOffset, 0);
		}

		// Token: 0x0602392D RID: 145709 RVA: 0x004E443F File Offset: 0x004E263F
		public static void AddAudioRangeType(FlatBufferBuilder builder, EAudioRangeType audioRangeType)
		{
			builder.AddByte(3, (byte)audioRangeType, 0);
		}

		// Token: 0x0602392E RID: 145710 RVA: 0x004E444A File Offset: 0x004E264A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602392F RID: 145711 RVA: 0x004E4455 File Offset: 0x004E2655
		public static Offset<IEntityAudioComponent> EndIEntityAudioComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityAudioComponent>(builder.EndTable());
		}

		// Token: 0x06023930 RID: 145712 RVA: 0x004E4464 File Offset: 0x004E2664
		public IEntityAudioComponentT UnPack()
		{
			IEntityAudioComponentT entityAudioComponentT = new IEntityAudioComponentT();
			this.UnPackTo(entityAudioComponentT);
			return entityAudioComponentT;
		}

		// Token: 0x06023931 RID: 145713 RVA: 0x004E4480 File Offset: 0x004E2680
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

		// Token: 0x06023932 RID: 145714 RVA: 0x004E4594 File Offset: 0x004E2794
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

		// Token: 0x0400EDF1 RID: 60913
		private Table __p;
	}
}
