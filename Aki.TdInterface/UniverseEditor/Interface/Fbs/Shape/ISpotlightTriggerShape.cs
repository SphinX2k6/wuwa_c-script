using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C52 RID: 15442
	public struct ISpotlightTriggerShape : IFlatbufferObject
	{
		// Token: 0x17006A76 RID: 27254
		// (get) Token: 0x06015597 RID: 87447 RVA: 0x003169F0 File Offset: 0x00314BF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015598 RID: 87448 RVA: 0x003169FD File Offset: 0x00314BFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015599 RID: 87449 RVA: 0x00316A04 File Offset: 0x00314C04
		public static ISpotlightTriggerShape GetRootAsISpotlightTriggerShape(ByteBuffer _bb)
		{
			return ISpotlightTriggerShape.GetRootAsISpotlightTriggerShape(_bb, default(ISpotlightTriggerShape));
		}

		// Token: 0x0601559A RID: 87450 RVA: 0x00316A20 File Offset: 0x00314C20
		public static ISpotlightTriggerShape GetRootAsISpotlightTriggerShape(ByteBuffer _bb, ISpotlightTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601559B RID: 87451 RVA: 0x00316A3D File Offset: 0x00314C3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601559C RID: 87452 RVA: 0x00316A4C File Offset: 0x00314C4C
		public ISpotlightTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006A77 RID: 27255
		// (get) Token: 0x0601559D RID: 87453 RVA: 0x00316A5C File Offset: 0x00314C5C
		public ETriggerShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerShape.Box;
				}
				return (ETriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006A78 RID: 27256
		// (get) Token: 0x0601559E RID: 87454 RVA: 0x00316A98 File Offset: 0x00314C98
		public IVectorInfo? Center
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006A79 RID: 27257
		// (get) Token: 0x0601559F RID: 87455 RVA: 0x00316AF8 File Offset: 0x00314CF8
		public int HalfAngle
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006A7A RID: 27258
		// (get) Token: 0x060155A0 RID: 87456 RVA: 0x00316B34 File Offset: 0x00314D34
		public int Height
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006A7B RID: 27259
		// (get) Token: 0x060155A1 RID: 87457 RVA: 0x00316B74 File Offset: 0x00314D74
		public int Yaw
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006A7C RID: 27260
		// (get) Token: 0x060155A2 RID: 87458 RVA: 0x00316BB4 File Offset: 0x00314DB4
		public int Pitch
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006A7D RID: 27261
		// (get) Token: 0x060155A3 RID: 87459 RVA: 0x00316BF4 File Offset: 0x00314DF4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060155A4 RID: 87460 RVA: 0x00316C34 File Offset: 0x00314E34
		public static Offset<ISpotlightTriggerShape> CreateISpotlightTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int HalfAngle = 0, int Height = 0, int Yaw = 0, int Pitch = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			ISpotlightTriggerShape.AddPitch(builder, Pitch);
			ISpotlightTriggerShape.AddYaw(builder, Yaw);
			ISpotlightTriggerShape.AddHeight(builder, Height);
			ISpotlightTriggerShape.AddHalfAngle(builder, HalfAngle);
			ISpotlightTriggerShape.AddCenter(builder, CenterOffset);
			ISpotlightTriggerShape.AddNullMask(builder, NullMask);
			ISpotlightTriggerShape.AddType(builder, Type);
			return ISpotlightTriggerShape.EndISpotlightTriggerShape(builder);
		}

		// Token: 0x060155A5 RID: 87461 RVA: 0x00316C83 File Offset: 0x00314E83
		public static void StartISpotlightTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060155A6 RID: 87462 RVA: 0x00316C8C File Offset: 0x00314E8C
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060155A7 RID: 87463 RVA: 0x00316C97 File Offset: 0x00314E97
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x060155A8 RID: 87464 RVA: 0x00316CA7 File Offset: 0x00314EA7
		public static void AddHalfAngle(FlatBufferBuilder builder, int halfAngle)
		{
			builder.AddInt(2, halfAngle, 0);
		}

		// Token: 0x060155A9 RID: 87465 RVA: 0x00316CB2 File Offset: 0x00314EB2
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(3, height, 0);
		}

		// Token: 0x060155AA RID: 87466 RVA: 0x00316CBD File Offset: 0x00314EBD
		public static void AddYaw(FlatBufferBuilder builder, int yaw)
		{
			builder.AddInt(4, yaw, 0);
		}

		// Token: 0x060155AB RID: 87467 RVA: 0x00316CC8 File Offset: 0x00314EC8
		public static void AddPitch(FlatBufferBuilder builder, int pitch)
		{
			builder.AddInt(5, pitch, 0);
		}

		// Token: 0x060155AC RID: 87468 RVA: 0x00316CD3 File Offset: 0x00314ED3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060155AD RID: 87469 RVA: 0x00316CDE File Offset: 0x00314EDE
		public static Offset<ISpotlightTriggerShape> EndISpotlightTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<ISpotlightTriggerShape>(builder.EndTable());
		}

		// Token: 0x060155AE RID: 87470 RVA: 0x00316CEC File Offset: 0x00314EEC
		public ISpotlightTriggerShapeT UnPack()
		{
			ISpotlightTriggerShapeT spotlightTriggerShapeT = new ISpotlightTriggerShapeT();
			this.UnPackTo(spotlightTriggerShapeT);
			return spotlightTriggerShapeT;
		}

		// Token: 0x060155AF RID: 87471 RVA: 0x00316D08 File Offset: 0x00314F08
		public void UnPackTo(ISpotlightTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.HalfAngle = this.HalfAngle;
			_o.Height = this.Height;
			_o.Yaw = this.Yaw;
			_o.Pitch = this.Pitch;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060155B0 RID: 87472 RVA: 0x00316D8C File Offset: 0x00314F8C
		public static Offset<ISpotlightTriggerShape> Pack(FlatBufferBuilder builder, ISpotlightTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpotlightTriggerShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return ISpotlightTriggerShape.CreateISpotlightTriggerShape(builder, _o.Type, centerOffset, _o.HalfAngle, _o.Height, _o.Yaw, _o.Pitch, _o.NullMask);
		}

		// Token: 0x0400B263 RID: 45667
		private Table __p;
	}
}
