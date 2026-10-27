using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007121 RID: 28961
	public struct ISkiConfigType : IFlatbufferObject
	{
		// Token: 0x1700D74A RID: 55114
		// (get) Token: 0x06033590 RID: 210320 RVA: 0x006EBE04 File Offset: 0x006EA004
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033591 RID: 210321 RVA: 0x006EBE11 File Offset: 0x006EA011
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033592 RID: 210322 RVA: 0x006EBE18 File Offset: 0x006EA018
		public static ISkiConfigType GetRootAsISkiConfigType(ByteBuffer _bb)
		{
			return ISkiConfigType.GetRootAsISkiConfigType(_bb, default(ISkiConfigType));
		}

		// Token: 0x06033593 RID: 210323 RVA: 0x006EBE34 File Offset: 0x006EA034
		public static ISkiConfigType GetRootAsISkiConfigType(ByteBuffer _bb, ISkiConfigType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033594 RID: 210324 RVA: 0x006EBE51 File Offset: 0x006EA051
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033595 RID: 210325 RVA: 0x006EBE60 File Offset: 0x006EA060
		public ISkiConfigType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D74B RID: 55115
		// (get) Token: 0x06033596 RID: 210326 RVA: 0x006EBE70 File Offset: 0x006EA070
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

		// Token: 0x1700D74C RID: 55116
		// (get) Token: 0x06033597 RID: 210327 RVA: 0x006EBEAC File Offset: 0x006EA0AC
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

		// Token: 0x06033598 RID: 210328 RVA: 0x006EBEE8 File Offset: 0x006EA0E8
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033599 RID: 210329 RVA: 0x006EBF2C File Offset: 0x006EA12C
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0603359A RID: 210330 RVA: 0x006EBF48 File Offset: 0x006EA148
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0603359B RID: 210331 RVA: 0x006EBF64 File Offset: 0x006EA164
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0603359C RID: 210332 RVA: 0x006EBF80 File Offset: 0x006EA180
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x0603359D RID: 210333 RVA: 0x006EBF9C File Offset: 0x006EA19C
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x0603359E RID: 210334 RVA: 0x006EBFB7 File Offset: 0x006EA1B7
		public static Offset<ISkiConfigType> CreateISkiConfigType(FlatBufferBuilder builder, ESkiConfig Type = ESkiConfig.Open, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0)
		{
			builder.StartTable(3);
			ISkiConfigType.AddTarget(builder, TargetOffset);
			ISkiConfigType.AddTargetType(builder, Target_type);
			ISkiConfigType.AddType(builder, Type);
			return ISkiConfigType.EndISkiConfigType(builder);
		}

		// Token: 0x0603359F RID: 210335 RVA: 0x006EBFDB File Offset: 0x006EA1DB
		public static void StartISkiConfigType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060335A0 RID: 210336 RVA: 0x006EBFE4 File Offset: 0x006EA1E4
		public static void AddType(FlatBufferBuilder builder, ESkiConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060335A1 RID: 210337 RVA: 0x006EBFEF File Offset: 0x006EA1EF
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x060335A2 RID: 210338 RVA: 0x006EBFFA File Offset: 0x006EA1FA
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x060335A3 RID: 210339 RVA: 0x006EC005 File Offset: 0x006EA205
		public static Offset<ISkiConfigType> EndISkiConfigType(FlatBufferBuilder builder)
		{
			return new Offset<ISkiConfigType>(builder.EndTable());
		}

		// Token: 0x060335A4 RID: 210340 RVA: 0x006EC014 File Offset: 0x006EA214
		public ISkiConfigTypeT UnPack()
		{
			ISkiConfigTypeT skiConfigTypeT = new ISkiConfigTypeT();
			this.UnPackTo(skiConfigTypeT);
			return skiConfigTypeT;
		}

		// Token: 0x060335A5 RID: 210341 RVA: 0x006EC030 File Offset: 0x006EA230
		public void UnPackTo(ISkiConfigTypeT _o)
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

		// Token: 0x060335A6 RID: 210342 RVA: 0x006EC19C File Offset: 0x006EA39C
		public static Offset<ISkiConfigType> Pack(FlatBufferBuilder builder, ISkiConfigTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkiConfigType>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return ISkiConfigType.CreateISkiConfigType(builder, _o.Type, target_type, targetOffset);
		}

		// Token: 0x04011BB3 RID: 72627
		private Table __p;
	}
}
