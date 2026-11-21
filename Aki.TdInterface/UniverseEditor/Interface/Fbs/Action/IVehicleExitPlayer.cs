using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D13 RID: 32019
	public struct IVehicleExitPlayer : IFlatbufferObject
	{
		// Token: 0x1700EFA8 RID: 61352
		// (get) Token: 0x06039C94 RID: 236692 RVA: 0x007CBA38 File Offset: 0x007C9C38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039C95 RID: 236693 RVA: 0x007CBA45 File Offset: 0x007C9C45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039C96 RID: 236694 RVA: 0x007CBA4C File Offset: 0x007C9C4C
		public static IVehicleExitPlayer GetRootAsIVehicleExitPlayer(ByteBuffer _bb)
		{
			return IVehicleExitPlayer.GetRootAsIVehicleExitPlayer(_bb, default(IVehicleExitPlayer));
		}

		// Token: 0x06039C97 RID: 236695 RVA: 0x007CBA68 File Offset: 0x007C9C68
		public static IVehicleExitPlayer GetRootAsIVehicleExitPlayer(ByteBuffer _bb, IVehicleExitPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039C98 RID: 236696 RVA: 0x007CBA85 File Offset: 0x007C9C85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039C99 RID: 236697 RVA: 0x007CBA94 File Offset: 0x007C9C94
		public IVehicleExitPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EFA9 RID: 61353
		// (get) Token: 0x06039C9A RID: 236698 RVA: 0x007CBAA4 File Offset: 0x007C9CA4
		public bool DestroyVehicle
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EFAA RID: 61354
		// (get) Token: 0x06039C9B RID: 236699 RVA: 0x007CBAE4 File Offset: 0x007C9CE4
		public TExitVehicleType ExitTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TExitVehicleType.NONE;
				}
				return (TExitVehicleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039C9C RID: 236700 RVA: 0x007CBB20 File Offset: 0x007C9D20
		public TTable? ExitType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039C9D RID: 236701 RVA: 0x007CBB64 File Offset: 0x007C9D64
		public IExitVehicleLaunch ExitTypeAsIExitVehicleLaunch()
		{
			return this.ExitType<IExitVehicleLaunch>().Value;
		}

		// Token: 0x06039C9E RID: 236702 RVA: 0x007CBB80 File Offset: 0x007C9D80
		public IExitVehicleSeatStandUp ExitTypeAsIExitVehicleSeatStandUp()
		{
			return this.ExitType<IExitVehicleSeatStandUp>().Value;
		}

		// Token: 0x06039C9F RID: 236703 RVA: 0x007CBB9C File Offset: 0x007C9D9C
		public IExitVehicleStandUp ExitTypeAsIExitVehicleStandUp()
		{
			return this.ExitType<IExitVehicleStandUp>().Value;
		}

		// Token: 0x06039CA0 RID: 236704 RVA: 0x007CBBB8 File Offset: 0x007C9DB8
		public IExitVehicleTeleport ExitTypeAsIExitVehicleTeleport()
		{
			return this.ExitType<IExitVehicleTeleport>().Value;
		}

		// Token: 0x1700EFAB RID: 61355
		// (get) Token: 0x06039CA1 RID: 236705 RVA: 0x007CBBD4 File Offset: 0x007C9DD4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039CA2 RID: 236706 RVA: 0x007CBC11 File Offset: 0x007C9E11
		public static Offset<IVehicleExitPlayer> CreateIVehicleExitPlayer(FlatBufferBuilder builder, bool DestroyVehicle = false, TExitVehicleType ExitType_type = TExitVehicleType.NONE, int ExitTypeOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IVehicleExitPlayer.AddExitType(builder, ExitTypeOffset);
			IVehicleExitPlayer.AddNullMask(builder, NullMask);
			IVehicleExitPlayer.AddExitTypeType(builder, ExitType_type);
			IVehicleExitPlayer.AddDestroyVehicle(builder, DestroyVehicle);
			return IVehicleExitPlayer.EndIVehicleExitPlayer(builder);
		}

		// Token: 0x06039CA3 RID: 236707 RVA: 0x007CBC3D File Offset: 0x007C9E3D
		public static void StartIVehicleExitPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06039CA4 RID: 236708 RVA: 0x007CBC46 File Offset: 0x007C9E46
		public static void AddDestroyVehicle(FlatBufferBuilder builder, bool destroyVehicle)
		{
			builder.AddBool(0, destroyVehicle, false);
		}

		// Token: 0x06039CA5 RID: 236709 RVA: 0x007CBC51 File Offset: 0x007C9E51
		public static void AddExitTypeType(FlatBufferBuilder builder, TExitVehicleType exitTypeType)
		{
			builder.AddByte(1, (byte)exitTypeType, 0);
		}

		// Token: 0x06039CA6 RID: 236710 RVA: 0x007CBC5C File Offset: 0x007C9E5C
		public static void AddExitType(FlatBufferBuilder builder, int exitTypeOffset)
		{
			builder.AddOffset(2, exitTypeOffset, 0);
		}

		// Token: 0x06039CA7 RID: 236711 RVA: 0x007CBC67 File Offset: 0x007C9E67
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06039CA8 RID: 236712 RVA: 0x007CBC72 File Offset: 0x007C9E72
		public static Offset<IVehicleExitPlayer> EndIVehicleExitPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleExitPlayer>(builder.EndTable());
		}

		// Token: 0x06039CA9 RID: 236713 RVA: 0x007CBC80 File Offset: 0x007C9E80
		public IVehicleExitPlayerT UnPack()
		{
			IVehicleExitPlayerT vehicleExitPlayerT = new IVehicleExitPlayerT();
			this.UnPackTo(vehicleExitPlayerT);
			return vehicleExitPlayerT;
		}

		// Token: 0x06039CAA RID: 236714 RVA: 0x007CBC9C File Offset: 0x007C9E9C
		public void UnPackTo(IVehicleExitPlayerT _o)
		{
			_o.DestroyVehicle = this.DestroyVehicle;
			_o.ExitType = new TExitVehicleTypeUnion();
			_o.ExitType.Type = this.ExitTypeType;
			switch (this.ExitTypeType)
			{
			case TExitVehicleType.IExitVehicleLaunch:
				_o.ExitType.Value = ((this.ExitType<IExitVehicleLaunch>() != null) ? this.ExitType<IExitVehicleLaunch>().Value.UnPack() : null);
				break;
			case TExitVehicleType.IExitVehicleSeatStandUp:
				_o.ExitType.Value = ((this.ExitType<IExitVehicleSeatStandUp>() != null) ? this.ExitType<IExitVehicleSeatStandUp>().Value.UnPack() : null);
				break;
			case TExitVehicleType.IExitVehicleStandUp:
				_o.ExitType.Value = ((this.ExitType<IExitVehicleStandUp>() != null) ? this.ExitType<IExitVehicleStandUp>().Value.UnPack() : null);
				break;
			case TExitVehicleType.IExitVehicleTeleport:
				_o.ExitType.Value = ((this.ExitType<IExitVehicleTeleport>() != null) ? this.ExitType<IExitVehicleTeleport>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06039CAB RID: 236715 RVA: 0x007CBDE4 File Offset: 0x007C9FE4
		public static Offset<IVehicleExitPlayer> Pack(FlatBufferBuilder builder, IVehicleExitPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleExitPlayer>);
			}
			TExitVehicleType exitType_type = (_o.ExitType == null) ? TExitVehicleType.NONE : _o.ExitType.Type;
			int exitTypeOffset = (_o.ExitType == null) ? 0 : TExitVehicleTypeUnion.Pack(builder, _o.ExitType);
			return IVehicleExitPlayer.CreateIVehicleExitPlayer(builder, _o.DestroyVehicle, exitType_type, exitTypeOffset, _o.NullMask);
		}

		// Token: 0x0401343C RID: 78908
		private Table __p;
	}
}
