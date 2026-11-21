using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004004 RID: 16388
	public struct IBoxTriggerTipShape : IFlatbufferObject
	{
		// Token: 0x17006F10 RID: 28432
		// (get) Token: 0x060166F7 RID: 91895 RVA: 0x00336478 File Offset: 0x00334678
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060166F8 RID: 91896 RVA: 0x00336485 File Offset: 0x00334685
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060166F9 RID: 91897 RVA: 0x0033648C File Offset: 0x0033468C
		public static IBoxTriggerTipShape GetRootAsIBoxTriggerTipShape(ByteBuffer _bb)
		{
			return IBoxTriggerTipShape.GetRootAsIBoxTriggerTipShape(_bb, default(IBoxTriggerTipShape));
		}

		// Token: 0x060166FA RID: 91898 RVA: 0x003364A8 File Offset: 0x003346A8
		public static IBoxTriggerTipShape GetRootAsIBoxTriggerTipShape(ByteBuffer _bb, IBoxTriggerTipShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060166FB RID: 91899 RVA: 0x003364C5 File Offset: 0x003346C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060166FC RID: 91900 RVA: 0x003364D4 File Offset: 0x003346D4
		public IBoxTriggerTipShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F11 RID: 28433
		// (get) Token: 0x060166FD RID: 91901 RVA: 0x003364E4 File Offset: 0x003346E4
		public ETriggerTipShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerTipShape.Box;
				}
				return (ETriggerTipShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006F12 RID: 28434
		// (get) Token: 0x060166FE RID: 91902 RVA: 0x00336520 File Offset: 0x00334720
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

		// Token: 0x17006F13 RID: 28435
		// (get) Token: 0x060166FF RID: 91903 RVA: 0x00336580 File Offset: 0x00334780
		public IVectorInfo? Size
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006F14 RID: 28436
		// (get) Token: 0x06016700 RID: 91904 RVA: 0x003365E0 File Offset: 0x003347E0
		public IVectorInfo? Rotator
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06016701 RID: 91905 RVA: 0x0033663E File Offset: 0x0033483E
		public static Offset<IBoxTriggerTipShape> CreateIBoxTriggerTipShape(FlatBufferBuilder builder, ETriggerTipShape Type = ETriggerTipShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> SizeOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotatorOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IBoxTriggerTipShape.AddRotator(builder, RotatorOffset);
			IBoxTriggerTipShape.AddSize(builder, SizeOffset);
			IBoxTriggerTipShape.AddCenter(builder, CenterOffset);
			IBoxTriggerTipShape.AddType(builder, Type);
			return IBoxTriggerTipShape.EndIBoxTriggerTipShape(builder);
		}

		// Token: 0x06016702 RID: 91906 RVA: 0x0033666A File Offset: 0x0033486A
		public static void StartIBoxTriggerTipShape(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016703 RID: 91907 RVA: 0x00336673 File Offset: 0x00334873
		public static void AddType(FlatBufferBuilder builder, ETriggerTipShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016704 RID: 91908 RVA: 0x0033667E File Offset: 0x0033487E
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x06016705 RID: 91909 RVA: 0x0033668E File Offset: 0x0033488E
		public static void AddSize(FlatBufferBuilder builder, Offset<IVectorInfo> sizeOffset)
		{
			builder.AddOffset(2, sizeOffset.Value, 0);
		}

		// Token: 0x06016706 RID: 91910 RVA: 0x0033669E File Offset: 0x0033489E
		public static void AddRotator(FlatBufferBuilder builder, Offset<IVectorInfo> rotatorOffset)
		{
			builder.AddOffset(3, rotatorOffset.Value, 0);
		}

		// Token: 0x06016707 RID: 91911 RVA: 0x003366AE File Offset: 0x003348AE
		public static Offset<IBoxTriggerTipShape> EndIBoxTriggerTipShape(FlatBufferBuilder builder)
		{
			return new Offset<IBoxTriggerTipShape>(builder.EndTable());
		}

		// Token: 0x06016708 RID: 91912 RVA: 0x003366BC File Offset: 0x003348BC
		public IBoxTriggerTipShapeT UnPack()
		{
			IBoxTriggerTipShapeT boxTriggerTipShapeT = new IBoxTriggerTipShapeT();
			this.UnPackTo(boxTriggerTipShapeT);
			return boxTriggerTipShapeT;
		}

		// Token: 0x06016709 RID: 91913 RVA: 0x003366D8 File Offset: 0x003348D8
		public void UnPackTo(IBoxTriggerTipShapeT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Size = ((this.Size != null) ? this.Size.Value.UnPack() : null);
			_o.Rotator = ((this.Rotator != null) ? this.Rotator.Value.UnPack() : null);
		}

		// Token: 0x0601670A RID: 91914 RVA: 0x00336780 File Offset: 0x00334980
		public static Offset<IBoxTriggerTipShape> Pack(FlatBufferBuilder builder, IBoxTriggerTipShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBoxTriggerTipShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			Offset<IVectorInfo> sizeOffset = (_o.Size == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Size);
			Offset<IVectorInfo> rotatorOffset = (_o.Rotator == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotator);
			return IBoxTriggerTipShape.CreateIBoxTriggerTipShape(builder, _o.Type, centerOffset, sizeOffset, rotatorOffset);
		}

		// Token: 0x0400BB52 RID: 47954
		private Table __p;
	}
}
