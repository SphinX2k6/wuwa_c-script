using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005174 RID: 20852
	public struct IEntityCustomAudioComponent : IFlatbufferObject
	{
		// Token: 0x1700984B RID: 38987
		// (get) Token: 0x06021B2A RID: 138026 RVA: 0x004ACFF0 File Offset: 0x004AB1F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021B2B RID: 138027 RVA: 0x004ACFFD File Offset: 0x004AB1FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021B2C RID: 138028 RVA: 0x004AD004 File Offset: 0x004AB204
		public static IEntityCustomAudioComponent GetRootAsIEntityCustomAudioComponent(ByteBuffer _bb)
		{
			return IEntityCustomAudioComponent.GetRootAsIEntityCustomAudioComponent(_bb, default(IEntityCustomAudioComponent));
		}

		// Token: 0x06021B2D RID: 138029 RVA: 0x004AD020 File Offset: 0x004AB220
		public static IEntityCustomAudioComponent GetRootAsIEntityCustomAudioComponent(ByteBuffer _bb, IEntityCustomAudioComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021B2E RID: 138030 RVA: 0x004AD03D File Offset: 0x004AB23D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021B2F RID: 138031 RVA: 0x004AD04C File Offset: 0x004AB24C
		public IEntityCustomAudioComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700984C RID: 38988
		// (get) Token: 0x06021B30 RID: 138032 RVA: 0x004AD05C File Offset: 0x004AB25C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700984D RID: 38989
		// (get) Token: 0x06021B31 RID: 138033 RVA: 0x004AD09C File Offset: 0x004AB29C
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

		// Token: 0x06021B32 RID: 138034 RVA: 0x004AD0D8 File Offset: 0x004AB2D8
		public TTable? AkEventType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06021B33 RID: 138035 RVA: 0x004AD11C File Offset: 0x004AB31C
		public IBoxAkEvent AkEventTypeAsIBoxAkEvent()
		{
			return this.AkEventType<IBoxAkEvent>().Value;
		}

		// Token: 0x06021B34 RID: 138036 RVA: 0x004AD138 File Offset: 0x004AB338
		public IDefaultAkEvent AkEventTypeAsIDefaultAkEvent()
		{
			return this.AkEventType<IDefaultAkEvent>().Value;
		}

		// Token: 0x06021B35 RID: 138037 RVA: 0x004AD154 File Offset: 0x004AB354
		public IPointAkEvent AkEventTypeAsIPointAkEvent()
		{
			return this.AkEventType<IPointAkEvent>().Value;
		}

		// Token: 0x1700984E RID: 38990
		// (get) Token: 0x06021B36 RID: 138038 RVA: 0x004AD170 File Offset: 0x004AB370
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

		// Token: 0x1700984F RID: 38991
		// (get) Token: 0x06021B37 RID: 138039 RVA: 0x004AD1B0 File Offset: 0x004AB3B0
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

		// Token: 0x06021B38 RID: 138040 RVA: 0x004AD1F0 File Offset: 0x004AB3F0
		public TTable? AudioControlType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06021B39 RID: 138041 RVA: 0x004AD238 File Offset: 0x004AB438
		public IGramophoneAudioControl AudioControlTypeAsIGramophoneAudioControl()
		{
			return this.AudioControlType<IGramophoneAudioControl>().Value;
		}

		// Token: 0x06021B3A RID: 138042 RVA: 0x004AD254 File Offset: 0x004AB454
		public ITrafficAudioControl AudioControlTypeAsITrafficAudioControl()
		{
			return this.AudioControlType<ITrafficAudioControl>().Value;
		}

		// Token: 0x17009850 RID: 38992
		// (get) Token: 0x06021B3B RID: 138043 RVA: 0x004AD270 File Offset: 0x004AB470
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

		// Token: 0x06021B3C RID: 138044 RVA: 0x004AD2B0 File Offset: 0x004AB4B0
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

		// Token: 0x06021B3D RID: 138045 RVA: 0x004AD2FF File Offset: 0x004AB4FF
		public static void StartIEntityCustomAudioComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06021B3E RID: 138046 RVA: 0x004AD308 File Offset: 0x004AB508
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021B3F RID: 138047 RVA: 0x004AD313 File Offset: 0x004AB513
		public static void AddAkEventTypeType(FlatBufferBuilder builder, TAkEventType akEventTypeType)
		{
			builder.AddByte(1, (byte)akEventTypeType, 0);
		}

		// Token: 0x06021B40 RID: 138048 RVA: 0x004AD31E File Offset: 0x004AB51E
		public static void AddAkEventType(FlatBufferBuilder builder, int akEventTypeOffset)
		{
			builder.AddOffset(2, akEventTypeOffset, 0);
		}

		// Token: 0x06021B41 RID: 138049 RVA: 0x004AD329 File Offset: 0x004AB529
		public static void AddAudioRangeType(FlatBufferBuilder builder, EAudioRangeType audioRangeType)
		{
			builder.AddByte(3, (byte)audioRangeType, 0);
		}

		// Token: 0x06021B42 RID: 138050 RVA: 0x004AD334 File Offset: 0x004AB534
		public static void AddAudioControlTypeType(FlatBufferBuilder builder, TAudioControlType audioControlTypeType)
		{
			builder.AddByte(4, (byte)audioControlTypeType, 0);
		}

		// Token: 0x06021B43 RID: 138051 RVA: 0x004AD33F File Offset: 0x004AB53F
		public static void AddAudioControlType(FlatBufferBuilder builder, int audioControlTypeOffset)
		{
			builder.AddOffset(5, audioControlTypeOffset, 0);
		}

		// Token: 0x06021B44 RID: 138052 RVA: 0x004AD34A File Offset: 0x004AB54A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06021B45 RID: 138053 RVA: 0x004AD355 File Offset: 0x004AB555
		public static Offset<IEntityCustomAudioComponent> EndIEntityCustomAudioComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityCustomAudioComponent>(builder.EndTable());
		}

		// Token: 0x06021B46 RID: 138054 RVA: 0x004AD364 File Offset: 0x004AB564
		public IEntityCustomAudioComponentT UnPack()
		{
			IEntityCustomAudioComponentT entityCustomAudioComponentT = new IEntityCustomAudioComponentT();
			this.UnPackTo(entityCustomAudioComponentT);
			return entityCustomAudioComponentT;
		}

		// Token: 0x06021B47 RID: 138055 RVA: 0x004AD380 File Offset: 0x004AB580
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

		// Token: 0x06021B48 RID: 138056 RVA: 0x004AD534 File Offset: 0x004AB734
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

		// Token: 0x0400E23A RID: 57914
		private Table __p;
	}
}
