using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004061 RID: 16481
	public struct ISpotlightTriggerShape : IFlatbufferObject
	{
		// Token: 0x17007027 RID: 28711
		// (get) Token: 0x06016AAB RID: 92843 RVA: 0x0033D890 File Offset: 0x0033BA90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016AAC RID: 92844 RVA: 0x0033D89D File Offset: 0x0033BA9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016AAD RID: 92845 RVA: 0x0033D8A4 File Offset: 0x0033BAA4
		public static ISpotlightTriggerShape GetRootAsISpotlightTriggerShape(ByteBuffer _bb)
		{
			return ISpotlightTriggerShape.GetRootAsISpotlightTriggerShape(_bb, default(ISpotlightTriggerShape));
		}

		// Token: 0x06016AAE RID: 92846 RVA: 0x0033D8C0 File Offset: 0x0033BAC0
		public static ISpotlightTriggerShape GetRootAsISpotlightTriggerShape(ByteBuffer _bb, ISpotlightTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016AAF RID: 92847 RVA: 0x0033D8DD File Offset: 0x0033BADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016AB0 RID: 92848 RVA: 0x0033D8EC File Offset: 0x0033BAEC
		public ISpotlightTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007028 RID: 28712
		// (get) Token: 0x06016AB1 RID: 92849 RVA: 0x0033D8FC File Offset: 0x0033BAFC
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

		// Token: 0x17007029 RID: 28713
		// (get) Token: 0x06016AB2 RID: 92850 RVA: 0x0033D938 File Offset: 0x0033BB38
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

		// Token: 0x1700702A RID: 28714
		// (get) Token: 0x06016AB3 RID: 92851 RVA: 0x0033D998 File Offset: 0x0033BB98
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

		// Token: 0x1700702B RID: 28715
		// (get) Token: 0x06016AB4 RID: 92852 RVA: 0x0033D9D4 File Offset: 0x0033BBD4
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

		// Token: 0x1700702C RID: 28716
		// (get) Token: 0x06016AB5 RID: 92853 RVA: 0x0033DA14 File Offset: 0x0033BC14
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

		// Token: 0x1700702D RID: 28717
		// (get) Token: 0x06016AB6 RID: 92854 RVA: 0x0033DA54 File Offset: 0x0033BC54
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

		// Token: 0x1700702E RID: 28718
		// (get) Token: 0x06016AB7 RID: 92855 RVA: 0x0033DA94 File Offset: 0x0033BC94
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

		// Token: 0x06016AB8 RID: 92856 RVA: 0x0033DAD4 File Offset: 0x0033BCD4
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

		// Token: 0x06016AB9 RID: 92857 RVA: 0x0033DB23 File Offset: 0x0033BD23
		public static void StartISpotlightTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06016ABA RID: 92858 RVA: 0x0033DB2C File Offset: 0x0033BD2C
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016ABB RID: 92859 RVA: 0x0033DB37 File Offset: 0x0033BD37
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x06016ABC RID: 92860 RVA: 0x0033DB47 File Offset: 0x0033BD47
		public static void AddHalfAngle(FlatBufferBuilder builder, int halfAngle)
		{
			builder.AddInt(2, halfAngle, 0);
		}

		// Token: 0x06016ABD RID: 92861 RVA: 0x0033DB52 File Offset: 0x0033BD52
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(3, height, 0);
		}

		// Token: 0x06016ABE RID: 92862 RVA: 0x0033DB5D File Offset: 0x0033BD5D
		public static void AddYaw(FlatBufferBuilder builder, int yaw)
		{
			builder.AddInt(4, yaw, 0);
		}

		// Token: 0x06016ABF RID: 92863 RVA: 0x0033DB68 File Offset: 0x0033BD68
		public static void AddPitch(FlatBufferBuilder builder, int pitch)
		{
			builder.AddInt(5, pitch, 0);
		}

		// Token: 0x06016AC0 RID: 92864 RVA: 0x0033DB73 File Offset: 0x0033BD73
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06016AC1 RID: 92865 RVA: 0x0033DB7E File Offset: 0x0033BD7E
		public static Offset<ISpotlightTriggerShape> EndISpotlightTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<ISpotlightTriggerShape>(builder.EndTable());
		}

		// Token: 0x06016AC2 RID: 92866 RVA: 0x0033DB8C File Offset: 0x0033BD8C
		public ISpotlightTriggerShapeT UnPack()
		{
			ISpotlightTriggerShapeT spotlightTriggerShapeT = new ISpotlightTriggerShapeT();
			this.UnPackTo(spotlightTriggerShapeT);
			return spotlightTriggerShapeT;
		}

		// Token: 0x06016AC3 RID: 92867 RVA: 0x0033DBA8 File Offset: 0x0033BDA8
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

		// Token: 0x06016AC4 RID: 92868 RVA: 0x0033DC2C File Offset: 0x0033BE2C
		public static Offset<ISpotlightTriggerShape> Pack(FlatBufferBuilder builder, ISpotlightTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpotlightTriggerShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return ISpotlightTriggerShape.CreateISpotlightTriggerShape(builder, _o.Type, centerOffset, _o.HalfAngle, _o.Height, _o.Yaw, _o.Pitch, _o.NullMask);
		}

		// Token: 0x0400BBF3 RID: 48115
		private Table __p;
	}
}
