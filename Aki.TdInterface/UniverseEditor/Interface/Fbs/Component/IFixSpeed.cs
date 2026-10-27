using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005279 RID: 21113
	public struct IFixSpeed : IFlatbufferObject
	{
		// Token: 0x17009AB9 RID: 39609
		// (get) Token: 0x060225E3 RID: 140771 RVA: 0x004C3AA4 File Offset: 0x004C1CA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060225E4 RID: 140772 RVA: 0x004C3AB1 File Offset: 0x004C1CB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060225E5 RID: 140773 RVA: 0x004C3AB8 File Offset: 0x004C1CB8
		public static IFixSpeed GetRootAsIFixSpeed(ByteBuffer _bb)
		{
			return IFixSpeed.GetRootAsIFixSpeed(_bb, default(IFixSpeed));
		}

		// Token: 0x060225E6 RID: 140774 RVA: 0x004C3AD4 File Offset: 0x004C1CD4
		public static IFixSpeed GetRootAsIFixSpeed(ByteBuffer _bb, IFixSpeed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060225E7 RID: 140775 RVA: 0x004C3AF1 File Offset: 0x004C1CF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060225E8 RID: 140776 RVA: 0x004C3B00 File Offset: 0x004C1D00
		public IFixSpeed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009ABA RID: 39610
		// (get) Token: 0x060225E9 RID: 140777 RVA: 0x004C3B10 File Offset: 0x004C1D10
		public EConveyorBeltMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConveyorBeltMoveType.FixSpeed;
				}
				return (EConveyorBeltMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009ABB RID: 39611
		// (get) Token: 0x060225EA RID: 140778 RVA: 0x004C3B4C File Offset: 0x004C1D4C
		public int Speed
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

		// Token: 0x060225EB RID: 140779 RVA: 0x004C3B88 File Offset: 0x004C1D88
		public static Offset<IFixSpeed> CreateIFixSpeed(FlatBufferBuilder builder, EConveyorBeltMoveType Type = EConveyorBeltMoveType.FixSpeed, int Speed = 0)
		{
			builder.StartTable(2);
			IFixSpeed.AddSpeed(builder, Speed);
			IFixSpeed.AddType(builder, Type);
			return IFixSpeed.EndIFixSpeed(builder);
		}

		// Token: 0x060225EC RID: 140780 RVA: 0x004C3BA5 File Offset: 0x004C1DA5
		public static void StartIFixSpeed(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060225ED RID: 140781 RVA: 0x004C3BAE File Offset: 0x004C1DAE
		public static void AddType(FlatBufferBuilder builder, EConveyorBeltMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060225EE RID: 140782 RVA: 0x004C3BB9 File Offset: 0x004C1DB9
		public static void AddSpeed(FlatBufferBuilder builder, int speed)
		{
			builder.AddInt(1, speed, 0);
		}

		// Token: 0x060225EF RID: 140783 RVA: 0x004C3BC4 File Offset: 0x004C1DC4
		public static Offset<IFixSpeed> EndIFixSpeed(FlatBufferBuilder builder)
		{
			return new Offset<IFixSpeed>(builder.EndTable());
		}

		// Token: 0x060225F0 RID: 140784 RVA: 0x004C3BD4 File Offset: 0x004C1DD4
		public IFixSpeedT UnPack()
		{
			IFixSpeedT fixSpeedT = new IFixSpeedT();
			this.UnPackTo(fixSpeedT);
			return fixSpeedT;
		}

		// Token: 0x060225F1 RID: 140785 RVA: 0x004C3BEF File Offset: 0x004C1DEF
		public void UnPackTo(IFixSpeedT _o)
		{
			_o.Type = this.Type;
			_o.Speed = this.Speed;
		}

		// Token: 0x060225F2 RID: 140786 RVA: 0x004C3C0C File Offset: 0x004C1E0C
		public static Offset<IFixSpeed> Pack(FlatBufferBuilder builder, IFixSpeedT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixSpeed>);
			}
			return IFixSpeed.CreateIFixSpeed(builder, _o.Type, _o.Speed);
		}

		// Token: 0x0400E3D8 RID: 58328
		private Table __p;
	}
}
