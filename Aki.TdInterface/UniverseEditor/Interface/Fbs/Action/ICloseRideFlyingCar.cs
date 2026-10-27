using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200642A RID: 25642
	public struct ICloseRideFlyingCar : IFlatbufferObject
	{
		// Token: 0x1700BEF3 RID: 48883
		// (get) Token: 0x0602C5FB RID: 181755 RVA: 0x00616A58 File Offset: 0x00614C58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C5FC RID: 181756 RVA: 0x00616A65 File Offset: 0x00614C65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C5FD RID: 181757 RVA: 0x00616A6C File Offset: 0x00614C6C
		public static ICloseRideFlyingCar GetRootAsICloseRideFlyingCar(ByteBuffer _bb)
		{
			return ICloseRideFlyingCar.GetRootAsICloseRideFlyingCar(_bb, default(ICloseRideFlyingCar));
		}

		// Token: 0x0602C5FE RID: 181758 RVA: 0x00616A88 File Offset: 0x00614C88
		public static ICloseRideFlyingCar GetRootAsICloseRideFlyingCar(ByteBuffer _bb, ICloseRideFlyingCar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C5FF RID: 181759 RVA: 0x00616AA5 File Offset: 0x00614CA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C600 RID: 181760 RVA: 0x00616AB4 File Offset: 0x00614CB4
		public ICloseRideFlyingCar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEF4 RID: 48884
		// (get) Token: 0x0602C601 RID: 181761 RVA: 0x00616AC4 File Offset: 0x00614CC4
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C602 RID: 181762 RVA: 0x00616B00 File Offset: 0x00614D00
		public static Offset<ICloseRideFlyingCar> CreateICloseRideFlyingCar(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher)
		{
			builder.StartTable(1);
			ICloseRideFlyingCar.AddType(builder, Type);
			return ICloseRideFlyingCar.EndICloseRideFlyingCar(builder);
		}

		// Token: 0x0602C603 RID: 181763 RVA: 0x00616B16 File Offset: 0x00614D16
		public static void StartICloseRideFlyingCar(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C604 RID: 181764 RVA: 0x00616B1F File Offset: 0x00614D1F
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C605 RID: 181765 RVA: 0x00616B2A File Offset: 0x00614D2A
		public static Offset<ICloseRideFlyingCar> EndICloseRideFlyingCar(FlatBufferBuilder builder)
		{
			return new Offset<ICloseRideFlyingCar>(builder.EndTable());
		}

		// Token: 0x0602C606 RID: 181766 RVA: 0x00616B38 File Offset: 0x00614D38
		public ICloseRideFlyingCarT UnPack()
		{
			ICloseRideFlyingCarT closeRideFlyingCarT = new ICloseRideFlyingCarT();
			this.UnPackTo(closeRideFlyingCarT);
			return closeRideFlyingCarT;
		}

		// Token: 0x0602C607 RID: 181767 RVA: 0x00616B53 File Offset: 0x00614D53
		public void UnPackTo(ICloseRideFlyingCarT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C608 RID: 181768 RVA: 0x00616B64 File Offset: 0x00614D64
		public static Offset<ICloseRideFlyingCar> Pack(FlatBufferBuilder builder, ICloseRideFlyingCarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseRideFlyingCar>);
			}
			return ICloseRideFlyingCar.CreateICloseRideFlyingCar(builder, _o.Type);
		}

		// Token: 0x04010A1D RID: 68125
		private Table __p;
	}
}
