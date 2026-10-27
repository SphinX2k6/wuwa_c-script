using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006430 RID: 25648
	public struct ICloseSkiConfig : IFlatbufferObject
	{
		// Token: 0x1700BEF9 RID: 48889
		// (get) Token: 0x0602C624 RID: 181796 RVA: 0x00616F25 File Offset: 0x00615125
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C625 RID: 181797 RVA: 0x00616F32 File Offset: 0x00615132
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C626 RID: 181798 RVA: 0x00616F3C File Offset: 0x0061513C
		public static ICloseSkiConfig GetRootAsICloseSkiConfig(ByteBuffer _bb)
		{
			return ICloseSkiConfig.GetRootAsICloseSkiConfig(_bb, default(ICloseSkiConfig));
		}

		// Token: 0x0602C627 RID: 181799 RVA: 0x00616F58 File Offset: 0x00615158
		public static ICloseSkiConfig GetRootAsICloseSkiConfig(ByteBuffer _bb, ICloseSkiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C628 RID: 181800 RVA: 0x00616F75 File Offset: 0x00615175
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C629 RID: 181801 RVA: 0x00616F84 File Offset: 0x00615184
		public ICloseSkiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEFA RID: 48890
		// (get) Token: 0x0602C62A RID: 181802 RVA: 0x00616F94 File Offset: 0x00615194
		public ESkiConfig Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESkiConfig.Open;
				}
				return (ESkiConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BEFB RID: 48891
		// (get) Token: 0x0602C62B RID: 181803 RVA: 0x00616FD0 File Offset: 0x006151D0
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C62C RID: 181804 RVA: 0x0061700C File Offset: 0x0061520C
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C62D RID: 181805 RVA: 0x00617050 File Offset: 0x00615250
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0602C62E RID: 181806 RVA: 0x0061706C File Offset: 0x0061526C
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0602C62F RID: 181807 RVA: 0x00617088 File Offset: 0x00615288
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0602C630 RID: 181808 RVA: 0x006170A4 File Offset: 0x006152A4
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x0602C631 RID: 181809 RVA: 0x006170C0 File Offset: 0x006152C0
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x0602C632 RID: 181810 RVA: 0x006170DB File Offset: 0x006152DB
		public static Offset<ICloseSkiConfig> CreateICloseSkiConfig(FlatBufferBuilder builder, ESkiConfig Type = ESkiConfig.Open, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0)
		{
			builder.StartTable(3);
			ICloseSkiConfig.AddTarget(builder, TargetOffset);
			ICloseSkiConfig.AddTargetType(builder, Target_type);
			ICloseSkiConfig.AddType(builder, Type);
			return ICloseSkiConfig.EndICloseSkiConfig(builder);
		}

		// Token: 0x0602C633 RID: 181811 RVA: 0x006170FF File Offset: 0x006152FF
		public static void StartICloseSkiConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C634 RID: 181812 RVA: 0x00617108 File Offset: 0x00615308
		public static void AddType(FlatBufferBuilder builder, ESkiConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C635 RID: 181813 RVA: 0x00617113 File Offset: 0x00615313
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602C636 RID: 181814 RVA: 0x0061711E File Offset: 0x0061531E
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602C637 RID: 181815 RVA: 0x00617129 File Offset: 0x00615329
		public static Offset<ICloseSkiConfig> EndICloseSkiConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICloseSkiConfig>(builder.EndTable());
		}

		// Token: 0x0602C638 RID: 181816 RVA: 0x00617138 File Offset: 0x00615338
		public ICloseSkiConfigT UnPack()
		{
			ICloseSkiConfigT closeSkiConfigT = new ICloseSkiConfigT();
			this.UnPackTo(closeSkiConfigT);
			return closeSkiConfigT;
		}

		// Token: 0x0602C639 RID: 181817 RVA: 0x00617154 File Offset: 0x00615354
		public void UnPackTo(ICloseSkiConfigT _o)
		{
			_o.Type = this.Type;
			_o.Target = new TTargetEntityUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Target.Value = ((this.Target<IPlayerEntity>() != null) ? this.Target<IPlayerEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ISelfEntity:
				_o.Target.Value = ((this.Target<ISelfEntity>() != null) ? this.Target<ISelfEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITargetEntity:
				_o.Target.Value = ((this.Target<ITargetEntity>() != null) ? this.Target<ITargetEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITriggeredEntity:
				_o.Target.Value = ((this.Target<ITriggeredEntity>() != null) ? this.Target<ITriggeredEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.IVehicleEntity:
				_o.Target.Value = ((this.Target<IVehicleEntity>() != null) ? this.Target<IVehicleEntity>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602C63A RID: 181818 RVA: 0x006172C0 File Offset: 0x006154C0
		public static Offset<ICloseSkiConfig> Pack(FlatBufferBuilder builder, ICloseSkiConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseSkiConfig>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return ICloseSkiConfig.CreateICloseSkiConfig(builder, _o.Type, target_type, targetOffset);
		}

		// Token: 0x04010A21 RID: 68129
		private Table __p;
	}
}
