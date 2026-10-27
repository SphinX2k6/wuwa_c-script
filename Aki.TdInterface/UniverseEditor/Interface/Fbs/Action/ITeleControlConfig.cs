using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007370 RID: 29552
	public struct ITeleControlConfig : IFlatbufferObject
	{
		// Token: 0x1700E059 RID: 57433
		// (get) Token: 0x06035A1E RID: 219678 RVA: 0x0074D97E File Offset: 0x0074BB7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035A1F RID: 219679 RVA: 0x0074D98B File Offset: 0x0074BB8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035A20 RID: 219680 RVA: 0x0074D994 File Offset: 0x0074BB94
		public static ITeleControlConfig GetRootAsITeleControlConfig(ByteBuffer _bb)
		{
			return ITeleControlConfig.GetRootAsITeleControlConfig(_bb, default(ITeleControlConfig));
		}

		// Token: 0x06035A21 RID: 219681 RVA: 0x0074D9B0 File Offset: 0x0074BBB0
		public static ITeleControlConfig GetRootAsITeleControlConfig(ByteBuffer _bb, ITeleControlConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035A22 RID: 219682 RVA: 0x0074D9CD File Offset: 0x0074BBCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035A23 RID: 219683 RVA: 0x0074D9DC File Offset: 0x0074BBDC
		public ITeleControlConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E05A RID: 57434
		// (get) Token: 0x06035A24 RID: 219684 RVA: 0x0074D9EC File Offset: 0x0074BBEC
		public EExploreStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreStateType.TeleControl;
				}
				return (EExploreStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E05B RID: 57435
		// (get) Token: 0x06035A25 RID: 219685 RVA: 0x0074DA28 File Offset: 0x0074BC28
		public ETeleControlType TeleControlType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETeleControlType.BigWorld;
				}
				return (ETeleControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035A26 RID: 219686 RVA: 0x0074DA64 File Offset: 0x0074BC64
		public static Offset<ITeleControlConfig> CreateITeleControlConfig(FlatBufferBuilder builder, EExploreStateType Type = EExploreStateType.TeleControl, ETeleControlType TeleControlType = ETeleControlType.BigWorld)
		{
			builder.StartTable(2);
			ITeleControlConfig.AddTeleControlType(builder, TeleControlType);
			ITeleControlConfig.AddType(builder, Type);
			return ITeleControlConfig.EndITeleControlConfig(builder);
		}

		// Token: 0x06035A27 RID: 219687 RVA: 0x0074DA81 File Offset: 0x0074BC81
		public static void StartITeleControlConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035A28 RID: 219688 RVA: 0x0074DA8A File Offset: 0x0074BC8A
		public static void AddType(FlatBufferBuilder builder, EExploreStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035A29 RID: 219689 RVA: 0x0074DA95 File Offset: 0x0074BC95
		public static void AddTeleControlType(FlatBufferBuilder builder, ETeleControlType teleControlType)
		{
			builder.AddByte(1, (byte)teleControlType, 0);
		}

		// Token: 0x06035A2A RID: 219690 RVA: 0x0074DAA0 File Offset: 0x0074BCA0
		public static Offset<ITeleControlConfig> EndITeleControlConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITeleControlConfig>(builder.EndTable());
		}

		// Token: 0x06035A2B RID: 219691 RVA: 0x0074DAB0 File Offset: 0x0074BCB0
		public ITeleControlConfigT UnPack()
		{
			ITeleControlConfigT teleControlConfigT = new ITeleControlConfigT();
			this.UnPackTo(teleControlConfigT);
			return teleControlConfigT;
		}

		// Token: 0x06035A2C RID: 219692 RVA: 0x0074DACB File Offset: 0x0074BCCB
		public void UnPackTo(ITeleControlConfigT _o)
		{
			_o.Type = this.Type;
			_o.TeleControlType = this.TeleControlType;
		}

		// Token: 0x06035A2D RID: 219693 RVA: 0x0074DAE8 File Offset: 0x0074BCE8
		public static Offset<ITeleControlConfig> Pack(FlatBufferBuilder builder, ITeleControlConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleControlConfig>);
			}
			return ITeleControlConfig.CreateITeleControlConfig(builder, _o.Type, _o.TeleControlType);
		}

		// Token: 0x0401217F RID: 74111
		private Table __p;
	}
}
