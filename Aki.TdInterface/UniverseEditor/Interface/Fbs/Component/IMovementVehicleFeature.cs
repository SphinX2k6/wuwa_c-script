using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B7F RID: 23423
	public struct IMovementVehicleFeature : IFlatbufferObject
	{
		// Token: 0x1700AB35 RID: 43829
		// (get) Token: 0x06026992 RID: 158098 RVA: 0x0054937D File Offset: 0x0054757D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026993 RID: 158099 RVA: 0x0054938A File Offset: 0x0054758A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026994 RID: 158100 RVA: 0x00549394 File Offset: 0x00547594
		public static IMovementVehicleFeature GetRootAsIMovementVehicleFeature(ByteBuffer _bb)
		{
			return IMovementVehicleFeature.GetRootAsIMovementVehicleFeature(_bb, default(IMovementVehicleFeature));
		}

		// Token: 0x06026995 RID: 158101 RVA: 0x005493B0 File Offset: 0x005475B0
		public static IMovementVehicleFeature GetRootAsIMovementVehicleFeature(ByteBuffer _bb, IMovementVehicleFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026996 RID: 158102 RVA: 0x005493CD File Offset: 0x005475CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026997 RID: 158103 RVA: 0x005493DC File Offset: 0x005475DC
		public IMovementVehicleFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB36 RID: 43830
		// (get) Token: 0x06026998 RID: 158104 RVA: 0x005493EC File Offset: 0x005475EC
		public EVehicleFeatureFlag Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleFeatureFlag.None;
				}
				return (EVehicleFeatureFlag)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AB37 RID: 43831
		// (get) Token: 0x06026999 RID: 158105 RVA: 0x00549428 File Offset: 0x00547628
		public int MoveSpline
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AB38 RID: 43832
		// (get) Token: 0x0602699A RID: 158106 RVA: 0x00549464 File Offset: 0x00547664
		public IMovementPerformConfig? MovePerformConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IMovementPerformConfig?(default(IMovementPerformConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AB39 RID: 43833
		// (get) Token: 0x0602699B RID: 158107 RVA: 0x005494C4 File Offset: 0x005476C4
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

		// Token: 0x0602699C RID: 158108 RVA: 0x00549501 File Offset: 0x00547701
		public static Offset<IMovementVehicleFeature> CreateIMovementVehicleFeature(FlatBufferBuilder builder, EVehicleFeatureFlag Type = EVehicleFeatureFlag.None, int MoveSpline = 0, Offset<IMovementPerformConfig> MovePerformConfigOffset = default(Offset<IMovementPerformConfig>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IMovementVehicleFeature.AddMovePerformConfig(builder, MovePerformConfigOffset);
			IMovementVehicleFeature.AddMoveSpline(builder, MoveSpline);
			IMovementVehicleFeature.AddNullMask(builder, NullMask);
			IMovementVehicleFeature.AddType(builder, Type);
			return IMovementVehicleFeature.EndIMovementVehicleFeature(builder);
		}

		// Token: 0x0602699D RID: 158109 RVA: 0x0054952D File Offset: 0x0054772D
		public static void StartIMovementVehicleFeature(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602699E RID: 158110 RVA: 0x00549536 File Offset: 0x00547736
		public static void AddType(FlatBufferBuilder builder, EVehicleFeatureFlag type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602699F RID: 158111 RVA: 0x00549541 File Offset: 0x00547741
		public static void AddMoveSpline(FlatBufferBuilder builder, int moveSpline)
		{
			builder.AddInt(1, moveSpline, 0);
		}

		// Token: 0x060269A0 RID: 158112 RVA: 0x0054954C File Offset: 0x0054774C
		public static void AddMovePerformConfig(FlatBufferBuilder builder, Offset<IMovementPerformConfig> movePerformConfigOffset)
		{
			builder.AddOffset(2, movePerformConfigOffset.Value, 0);
		}

		// Token: 0x060269A1 RID: 158113 RVA: 0x0054955C File Offset: 0x0054775C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060269A2 RID: 158114 RVA: 0x00549567 File Offset: 0x00547767
		public static Offset<IMovementVehicleFeature> EndIMovementVehicleFeature(FlatBufferBuilder builder)
		{
			return new Offset<IMovementVehicleFeature>(builder.EndTable());
		}

		// Token: 0x060269A3 RID: 158115 RVA: 0x00549574 File Offset: 0x00547774
		public IMovementVehicleFeatureT UnPack()
		{
			IMovementVehicleFeatureT movementVehicleFeatureT = new IMovementVehicleFeatureT();
			this.UnPackTo(movementVehicleFeatureT);
			return movementVehicleFeatureT;
		}

		// Token: 0x060269A4 RID: 158116 RVA: 0x00549590 File Offset: 0x00547790
		public void UnPackTo(IMovementVehicleFeatureT _o)
		{
			_o.Type = this.Type;
			_o.MoveSpline = this.MoveSpline;
			_o.MovePerformConfig = ((this.MovePerformConfig != null) ? this.MovePerformConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060269A5 RID: 158117 RVA: 0x005495F0 File Offset: 0x005477F0
		public static Offset<IMovementVehicleFeature> Pack(FlatBufferBuilder builder, IMovementVehicleFeatureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMovementVehicleFeature>);
			}
			Offset<IMovementPerformConfig> movePerformConfigOffset = (_o.MovePerformConfig == null) ? default(Offset<IMovementPerformConfig>) : IMovementPerformConfig.Pack(builder, _o.MovePerformConfig);
			return IMovementVehicleFeature.CreateIMovementVehicleFeature(builder, _o.Type, _o.MoveSpline, movePerformConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F5AB RID: 62891
		private Table __p;
	}
}
