using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200751D RID: 29981
	public struct IVehicleExitPlayer : IFlatbufferObject
	{
		// Token: 0x1700E37E RID: 58238
		// (get) Token: 0x0603687E RID: 223358 RVA: 0x00768790 File Offset: 0x00766990
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603687F RID: 223359 RVA: 0x0076879D File Offset: 0x0076699D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036880 RID: 223360 RVA: 0x007687A4 File Offset: 0x007669A4
		public static IVehicleExitPlayer GetRootAsIVehicleExitPlayer(ByteBuffer _bb)
		{
			return IVehicleExitPlayer.GetRootAsIVehicleExitPlayer(_bb, default(IVehicleExitPlayer));
		}

		// Token: 0x06036881 RID: 223361 RVA: 0x007687C0 File Offset: 0x007669C0
		public static IVehicleExitPlayer GetRootAsIVehicleExitPlayer(ByteBuffer _bb, IVehicleExitPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036882 RID: 223362 RVA: 0x007687DD File Offset: 0x007669DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036883 RID: 223363 RVA: 0x007687EC File Offset: 0x007669EC
		public IVehicleExitPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E37F RID: 58239
		// (get) Token: 0x06036884 RID: 223364 RVA: 0x007687FC File Offset: 0x007669FC
		public bool DestroyVehicle
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E380 RID: 58240
		// (get) Token: 0x06036885 RID: 223365 RVA: 0x0076883C File Offset: 0x00766A3C
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

		// Token: 0x06036886 RID: 223366 RVA: 0x00768878 File Offset: 0x00766A78
		public TTable? ExitType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036887 RID: 223367 RVA: 0x007688BC File Offset: 0x00766ABC
		public IExitVehicleLaunch ExitTypeAsIExitVehicleLaunch()
		{
			return this.ExitType<IExitVehicleLaunch>().Value;
		}

		// Token: 0x06036888 RID: 223368 RVA: 0x007688D8 File Offset: 0x00766AD8
		public IExitVehicleSeatStandUp ExitTypeAsIExitVehicleSeatStandUp()
		{
			return this.ExitType<IExitVehicleSeatStandUp>().Value;
		}

		// Token: 0x06036889 RID: 223369 RVA: 0x007688F4 File Offset: 0x00766AF4
		public IExitVehicleStandUp ExitTypeAsIExitVehicleStandUp()
		{
			return this.ExitType<IExitVehicleStandUp>().Value;
		}

		// Token: 0x0603688A RID: 223370 RVA: 0x00768910 File Offset: 0x00766B10
		public IExitVehicleTeleport ExitTypeAsIExitVehicleTeleport()
		{
			return this.ExitType<IExitVehicleTeleport>().Value;
		}

		// Token: 0x1700E381 RID: 58241
		// (get) Token: 0x0603688B RID: 223371 RVA: 0x0076892C File Offset: 0x00766B2C
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

		// Token: 0x0603688C RID: 223372 RVA: 0x00768969 File Offset: 0x00766B69
		public static Offset<IVehicleExitPlayer> CreateIVehicleExitPlayer(FlatBufferBuilder builder, bool DestroyVehicle = false, TExitVehicleType ExitType_type = TExitVehicleType.NONE, int ExitTypeOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IVehicleExitPlayer.AddExitType(builder, ExitTypeOffset);
			IVehicleExitPlayer.AddNullMask(builder, NullMask);
			IVehicleExitPlayer.AddExitTypeType(builder, ExitType_type);
			IVehicleExitPlayer.AddDestroyVehicle(builder, DestroyVehicle);
			return IVehicleExitPlayer.EndIVehicleExitPlayer(builder);
		}

		// Token: 0x0603688D RID: 223373 RVA: 0x00768995 File Offset: 0x00766B95
		public static void StartIVehicleExitPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603688E RID: 223374 RVA: 0x0076899E File Offset: 0x00766B9E
		public static void AddDestroyVehicle(FlatBufferBuilder builder, bool destroyVehicle)
		{
			builder.AddBool(0, destroyVehicle, false);
		}

		// Token: 0x0603688F RID: 223375 RVA: 0x007689A9 File Offset: 0x00766BA9
		public static void AddExitTypeType(FlatBufferBuilder builder, TExitVehicleType exitTypeType)
		{
			builder.AddByte(1, (byte)exitTypeType, 0);
		}

		// Token: 0x06036890 RID: 223376 RVA: 0x007689B4 File Offset: 0x00766BB4
		public static void AddExitType(FlatBufferBuilder builder, int exitTypeOffset)
		{
			builder.AddOffset(2, exitTypeOffset, 0);
		}

		// Token: 0x06036891 RID: 223377 RVA: 0x007689BF File Offset: 0x00766BBF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06036892 RID: 223378 RVA: 0x007689CA File Offset: 0x00766BCA
		public static Offset<IVehicleExitPlayer> EndIVehicleExitPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleExitPlayer>(builder.EndTable());
		}

		// Token: 0x06036893 RID: 223379 RVA: 0x007689D8 File Offset: 0x00766BD8
		public IVehicleExitPlayerT UnPack()
		{
			IVehicleExitPlayerT vehicleExitPlayerT = new IVehicleExitPlayerT();
			this.UnPackTo(vehicleExitPlayerT);
			return vehicleExitPlayerT;
		}

		// Token: 0x06036894 RID: 223380 RVA: 0x007689F4 File Offset: 0x00766BF4
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

		// Token: 0x06036895 RID: 223381 RVA: 0x00768B3C File Offset: 0x00766D3C
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

		// Token: 0x0401240B RID: 74763
		private Table __p;
	}
}
