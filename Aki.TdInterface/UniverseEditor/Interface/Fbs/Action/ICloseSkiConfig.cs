using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AA4 RID: 27300
	public struct ICloseSkiConfig : IFlatbufferObject
	{
		// Token: 0x1700C885 RID: 51333
		// (get) Token: 0x0602EDA9 RID: 191913 RVA: 0x0066256C File Offset: 0x0066076C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EDAA RID: 191914 RVA: 0x00662579 File Offset: 0x00660779
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EDAB RID: 191915 RVA: 0x00662580 File Offset: 0x00660780
		public static ICloseSkiConfig GetRootAsICloseSkiConfig(ByteBuffer _bb)
		{
			return ICloseSkiConfig.GetRootAsICloseSkiConfig(_bb, default(ICloseSkiConfig));
		}

		// Token: 0x0602EDAC RID: 191916 RVA: 0x0066259C File Offset: 0x0066079C
		public static ICloseSkiConfig GetRootAsICloseSkiConfig(ByteBuffer _bb, ICloseSkiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EDAD RID: 191917 RVA: 0x006625B9 File Offset: 0x006607B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EDAE RID: 191918 RVA: 0x006625C8 File Offset: 0x006607C8
		public ICloseSkiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C886 RID: 51334
		// (get) Token: 0x0602EDAF RID: 191919 RVA: 0x006625D8 File Offset: 0x006607D8
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

		// Token: 0x1700C887 RID: 51335
		// (get) Token: 0x0602EDB0 RID: 191920 RVA: 0x00662614 File Offset: 0x00660814
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

		// Token: 0x0602EDB1 RID: 191921 RVA: 0x00662650 File Offset: 0x00660850
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602EDB2 RID: 191922 RVA: 0x00662694 File Offset: 0x00660894
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0602EDB3 RID: 191923 RVA: 0x006626B0 File Offset: 0x006608B0
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0602EDB4 RID: 191924 RVA: 0x006626CC File Offset: 0x006608CC
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0602EDB5 RID: 191925 RVA: 0x006626E8 File Offset: 0x006608E8
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x0602EDB6 RID: 191926 RVA: 0x00662704 File Offset: 0x00660904
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x0602EDB7 RID: 191927 RVA: 0x0066271F File Offset: 0x0066091F
		public static Offset<ICloseSkiConfig> CreateICloseSkiConfig(FlatBufferBuilder builder, ESkiConfig Type = ESkiConfig.Open, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0)
		{
			builder.StartTable(3);
			ICloseSkiConfig.AddTarget(builder, TargetOffset);
			ICloseSkiConfig.AddTargetType(builder, Target_type);
			ICloseSkiConfig.AddType(builder, Type);
			return ICloseSkiConfig.EndICloseSkiConfig(builder);
		}

		// Token: 0x0602EDB8 RID: 191928 RVA: 0x00662743 File Offset: 0x00660943
		public static void StartICloseSkiConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602EDB9 RID: 191929 RVA: 0x0066274C File Offset: 0x0066094C
		public static void AddType(FlatBufferBuilder builder, ESkiConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EDBA RID: 191930 RVA: 0x00662757 File Offset: 0x00660957
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602EDBB RID: 191931 RVA: 0x00662762 File Offset: 0x00660962
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602EDBC RID: 191932 RVA: 0x0066276D File Offset: 0x0066096D
		public static Offset<ICloseSkiConfig> EndICloseSkiConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICloseSkiConfig>(builder.EndTable());
		}

		// Token: 0x0602EDBD RID: 191933 RVA: 0x0066277C File Offset: 0x0066097C
		public ICloseSkiConfigT UnPack()
		{
			ICloseSkiConfigT closeSkiConfigT = new ICloseSkiConfigT();
			this.UnPackTo(closeSkiConfigT);
			return closeSkiConfigT;
		}

		// Token: 0x0602EDBE RID: 191934 RVA: 0x00662798 File Offset: 0x00660998
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

		// Token: 0x0602EDBF RID: 191935 RVA: 0x00662904 File Offset: 0x00660B04
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

		// Token: 0x0401183E RID: 71742
		private Table __p;
	}
}
