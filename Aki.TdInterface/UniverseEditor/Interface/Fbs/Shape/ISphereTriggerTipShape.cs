using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C46 RID: 15430
	public struct ISphereTriggerTipShape : IFlatbufferObject
	{
		// Token: 0x17006A52 RID: 27218
		// (get) Token: 0x0601551F RID: 87327 RVA: 0x00315CDF File Offset: 0x00313EDF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015520 RID: 87328 RVA: 0x00315CEC File Offset: 0x00313EEC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015521 RID: 87329 RVA: 0x00315CF4 File Offset: 0x00313EF4
		public static ISphereTriggerTipShape GetRootAsISphereTriggerTipShape(ByteBuffer _bb)
		{
			return ISphereTriggerTipShape.GetRootAsISphereTriggerTipShape(_bb, default(ISphereTriggerTipShape));
		}

		// Token: 0x06015522 RID: 87330 RVA: 0x00315D10 File Offset: 0x00313F10
		public static ISphereTriggerTipShape GetRootAsISphereTriggerTipShape(ByteBuffer _bb, ISphereTriggerTipShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015523 RID: 87331 RVA: 0x00315D2D File Offset: 0x00313F2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015524 RID: 87332 RVA: 0x00315D3C File Offset: 0x00313F3C
		public ISphereTriggerTipShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006A53 RID: 27219
		// (get) Token: 0x06015525 RID: 87333 RVA: 0x00315D4C File Offset: 0x00313F4C
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

		// Token: 0x17006A54 RID: 27220
		// (get) Token: 0x06015526 RID: 87334 RVA: 0x00315D88 File Offset: 0x00313F88
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

		// Token: 0x17006A55 RID: 27221
		// (get) Token: 0x06015527 RID: 87335 RVA: 0x00315DE8 File Offset: 0x00313FE8
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

		// Token: 0x06015528 RID: 87336 RVA: 0x00315E24 File Offset: 0x00314024
		public static Offset<ISphereTriggerTipShape> CreateISphereTriggerTipShape(FlatBufferBuilder builder, ETriggerTipShape Type = ETriggerTipShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0)
		{
			builder.StartTable(3);
			ISphereTriggerTipShape.AddRadius(builder, Radius);
			ISphereTriggerTipShape.AddCenter(builder, CenterOffset);
			ISphereTriggerTipShape.AddType(builder, Type);
			return ISphereTriggerTipShape.EndISphereTriggerTipShape(builder);
		}

		// Token: 0x06015529 RID: 87337 RVA: 0x00315E48 File Offset: 0x00314048
		public static void StartISphereTriggerTipShape(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601552A RID: 87338 RVA: 0x00315E51 File Offset: 0x00314051
		public static void AddType(FlatBufferBuilder builder, ETriggerTipShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601552B RID: 87339 RVA: 0x00315E5C File Offset: 0x0031405C
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x0601552C RID: 87340 RVA: 0x00315E6C File Offset: 0x0031406C
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x0601552D RID: 87341 RVA: 0x00315E77 File Offset: 0x00314077
		public static Offset<ISphereTriggerTipShape> EndISphereTriggerTipShape(FlatBufferBuilder builder)
		{
			return new Offset<ISphereTriggerTipShape>(builder.EndTable());
		}

		// Token: 0x0601552E RID: 87342 RVA: 0x00315E84 File Offset: 0x00314084
		public ISphereTriggerTipShapeT UnPack()
		{
			ISphereTriggerTipShapeT sphereTriggerTipShapeT = new ISphereTriggerTipShapeT();
			this.UnPackTo(sphereTriggerTipShapeT);
			return sphereTriggerTipShapeT;
		}

		// Token: 0x0601552F RID: 87343 RVA: 0x00315EA0 File Offset: 0x003140A0
		public void UnPackTo(ISphereTriggerTipShapeT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
		}

		// Token: 0x06015530 RID: 87344 RVA: 0x00315EF4 File Offset: 0x003140F4
		public static Offset<ISphereTriggerTipShape> Pack(FlatBufferBuilder builder, ISphereTriggerTipShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISphereTriggerTipShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return ISphereTriggerTipShape.CreateISphereTriggerTipShape(builder, _o.Type, centerOffset, _o.Radius);
		}

		// Token: 0x0400B24F RID: 45647
		private Table __p;
	}
}
