using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004055 RID: 16469
	public struct ISphereTriggerTipShape : IFlatbufferObject
	{
		// Token: 0x17007003 RID: 28675
		// (get) Token: 0x06016A33 RID: 92723 RVA: 0x0033CB7F File Offset: 0x0033AD7F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016A34 RID: 92724 RVA: 0x0033CB8C File Offset: 0x0033AD8C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016A35 RID: 92725 RVA: 0x0033CB94 File Offset: 0x0033AD94
		public static ISphereTriggerTipShape GetRootAsISphereTriggerTipShape(ByteBuffer _bb)
		{
			return ISphereTriggerTipShape.GetRootAsISphereTriggerTipShape(_bb, default(ISphereTriggerTipShape));
		}

		// Token: 0x06016A36 RID: 92726 RVA: 0x0033CBB0 File Offset: 0x0033ADB0
		public static ISphereTriggerTipShape GetRootAsISphereTriggerTipShape(ByteBuffer _bb, ISphereTriggerTipShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016A37 RID: 92727 RVA: 0x0033CBCD File Offset: 0x0033ADCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016A38 RID: 92728 RVA: 0x0033CBDC File Offset: 0x0033ADDC
		public ISphereTriggerTipShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007004 RID: 28676
		// (get) Token: 0x06016A39 RID: 92729 RVA: 0x0033CBEC File Offset: 0x0033ADEC
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

		// Token: 0x17007005 RID: 28677
		// (get) Token: 0x06016A3A RID: 92730 RVA: 0x0033CC28 File Offset: 0x0033AE28
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

		// Token: 0x17007006 RID: 28678
		// (get) Token: 0x06016A3B RID: 92731 RVA: 0x0033CC88 File Offset: 0x0033AE88
		public int Radius
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

		// Token: 0x06016A3C RID: 92732 RVA: 0x0033CCC4 File Offset: 0x0033AEC4
		public static Offset<ISphereTriggerTipShape> CreateISphereTriggerTipShape(FlatBufferBuilder builder, ETriggerTipShape Type = ETriggerTipShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0)
		{
			builder.StartTable(3);
			ISphereTriggerTipShape.AddRadius(builder, Radius);
			ISphereTriggerTipShape.AddCenter(builder, CenterOffset);
			ISphereTriggerTipShape.AddType(builder, Type);
			return ISphereTriggerTipShape.EndISphereTriggerTipShape(builder);
		}

		// Token: 0x06016A3D RID: 92733 RVA: 0x0033CCE8 File Offset: 0x0033AEE8
		public static void StartISphereTriggerTipShape(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016A3E RID: 92734 RVA: 0x0033CCF1 File Offset: 0x0033AEF1
		public static void AddType(FlatBufferBuilder builder, ETriggerTipShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016A3F RID: 92735 RVA: 0x0033CCFC File Offset: 0x0033AEFC
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x06016A40 RID: 92736 RVA: 0x0033CD0C File Offset: 0x0033AF0C
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x06016A41 RID: 92737 RVA: 0x0033CD17 File Offset: 0x0033AF17
		public static Offset<ISphereTriggerTipShape> EndISphereTriggerTipShape(FlatBufferBuilder builder)
		{
			return new Offset<ISphereTriggerTipShape>(builder.EndTable());
		}

		// Token: 0x06016A42 RID: 92738 RVA: 0x0033CD24 File Offset: 0x0033AF24
		public ISphereTriggerTipShapeT UnPack()
		{
			ISphereTriggerTipShapeT sphereTriggerTipShapeT = new ISphereTriggerTipShapeT();
			this.UnPackTo(sphereTriggerTipShapeT);
			return sphereTriggerTipShapeT;
		}

		// Token: 0x06016A43 RID: 92739 RVA: 0x0033CD40 File Offset: 0x0033AF40
		public void UnPackTo(ISphereTriggerTipShapeT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
		}

		// Token: 0x06016A44 RID: 92740 RVA: 0x0033CD94 File Offset: 0x0033AF94
		public static Offset<ISphereTriggerTipShape> Pack(FlatBufferBuilder builder, ISphereTriggerTipShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISphereTriggerTipShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return ISphereTriggerTipShape.CreateISphereTriggerTipShape(builder, _o.Type, centerOffset, _o.Radius);
		}

		// Token: 0x0400BBDF RID: 48095
		private Table __p;
	}
}
