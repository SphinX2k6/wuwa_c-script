using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E1 RID: 21985
	public struct IMovementVehicleFeature : IFlatbufferObject
	{
		// Token: 0x1700A2AD RID: 41645
		// (get) Token: 0x06024785 RID: 149381 RVA: 0x00508E05 File Offset: 0x00507005
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024786 RID: 149382 RVA: 0x00508E12 File Offset: 0x00507012
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024787 RID: 149383 RVA: 0x00508E1C File Offset: 0x0050701C
		public static IMovementVehicleFeature GetRootAsIMovementVehicleFeature(ByteBuffer _bb)
		{
			return IMovementVehicleFeature.GetRootAsIMovementVehicleFeature(_bb, default(IMovementVehicleFeature));
		}

		// Token: 0x06024788 RID: 149384 RVA: 0x00508E38 File Offset: 0x00507038
		public static IMovementVehicleFeature GetRootAsIMovementVehicleFeature(ByteBuffer _bb, IMovementVehicleFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024789 RID: 149385 RVA: 0x00508E55 File Offset: 0x00507055
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602478A RID: 149386 RVA: 0x00508E64 File Offset: 0x00507064
		public IMovementVehicleFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2AE RID: 41646
		// (get) Token: 0x0602478B RID: 149387 RVA: 0x00508E74 File Offset: 0x00507074
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

		// Token: 0x1700A2AF RID: 41647
		// (get) Token: 0x0602478C RID: 149388 RVA: 0x00508EB0 File Offset: 0x005070B0
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

		// Token: 0x1700A2B0 RID: 41648
		// (get) Token: 0x0602478D RID: 149389 RVA: 0x00508EEC File Offset: 0x005070EC
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

		// Token: 0x1700A2B1 RID: 41649
		// (get) Token: 0x0602478E RID: 149390 RVA: 0x00508F4C File Offset: 0x0050714C
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

		// Token: 0x0602478F RID: 149391 RVA: 0x00508F89 File Offset: 0x00507189
		public static Offset<IMovementVehicleFeature> CreateIMovementVehicleFeature(FlatBufferBuilder builder, EVehicleFeatureFlag Type = EVehicleFeatureFlag.None, int MoveSpline = 0, Offset<IMovementPerformConfig> MovePerformConfigOffset = default(Offset<IMovementPerformConfig>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IMovementVehicleFeature.AddMovePerformConfig(builder, MovePerformConfigOffset);
			IMovementVehicleFeature.AddMoveSpline(builder, MoveSpline);
			IMovementVehicleFeature.AddNullMask(builder, NullMask);
			IMovementVehicleFeature.AddType(builder, Type);
			return IMovementVehicleFeature.EndIMovementVehicleFeature(builder);
		}

		// Token: 0x06024790 RID: 149392 RVA: 0x00508FB5 File Offset: 0x005071B5
		public static void StartIMovementVehicleFeature(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06024791 RID: 149393 RVA: 0x00508FBE File Offset: 0x005071BE
		public static void AddType(FlatBufferBuilder builder, EVehicleFeatureFlag type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024792 RID: 149394 RVA: 0x00508FC9 File Offset: 0x005071C9
		public static void AddMoveSpline(FlatBufferBuilder builder, int moveSpline)
		{
			builder.AddInt(1, moveSpline, 0);
		}

		// Token: 0x06024793 RID: 149395 RVA: 0x00508FD4 File Offset: 0x005071D4
		public static void AddMovePerformConfig(FlatBufferBuilder builder, Offset<IMovementPerformConfig> movePerformConfigOffset)
		{
			builder.AddOffset(2, movePerformConfigOffset.Value, 0);
		}

		// Token: 0x06024794 RID: 149396 RVA: 0x00508FE4 File Offset: 0x005071E4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06024795 RID: 149397 RVA: 0x00508FEF File Offset: 0x005071EF
		public static Offset<IMovementVehicleFeature> EndIMovementVehicleFeature(FlatBufferBuilder builder)
		{
			return new Offset<IMovementVehicleFeature>(builder.EndTable());
		}

		// Token: 0x06024796 RID: 149398 RVA: 0x00508FFC File Offset: 0x005071FC
		public IMovementVehicleFeatureT UnPack()
		{
			IMovementVehicleFeatureT movementVehicleFeatureT = new IMovementVehicleFeatureT();
			this.UnPackTo(movementVehicleFeatureT);
			return movementVehicleFeatureT;
		}

		// Token: 0x06024797 RID: 149399 RVA: 0x00509018 File Offset: 0x00507218
		public void UnPackTo(IMovementVehicleFeatureT _o)
		{
			_o.Type = this.Type;
			_o.MoveSpline = this.MoveSpline;
			_o.MovePerformConfig = ((this.MovePerformConfig != null) ? this.MovePerformConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024798 RID: 149400 RVA: 0x00509078 File Offset: 0x00507278
		public static Offset<IMovementVehicleFeature> Pack(FlatBufferBuilder builder, IMovementVehicleFeatureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMovementVehicleFeature>);
			}
			Offset<IMovementPerformConfig> movePerformConfigOffset = (_o.MovePerformConfig == null) ? default(Offset<IMovementPerformConfig>) : IMovementPerformConfig.Pack(builder, _o.MovePerformConfig);
			return IMovementVehicleFeature.CreateIMovementVehicleFeature(builder, _o.Type, _o.MoveSpline, movePerformConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E949 RID: 59721
		private Table __p;
	}
}
