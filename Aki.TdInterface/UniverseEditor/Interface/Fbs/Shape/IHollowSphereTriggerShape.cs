using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200402E RID: 16430
	public struct IHollowSphereTriggerShape : IFlatbufferObject
	{
		// Token: 0x17006F9D RID: 28573
		// (get) Token: 0x060168C7 RID: 92359 RVA: 0x00339FD4 File Offset: 0x003381D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060168C8 RID: 92360 RVA: 0x00339FE1 File Offset: 0x003381E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060168C9 RID: 92361 RVA: 0x00339FE8 File Offset: 0x003381E8
		public static IHollowSphereTriggerShape GetRootAsIHollowSphereTriggerShape(ByteBuffer _bb)
		{
			return IHollowSphereTriggerShape.GetRootAsIHollowSphereTriggerShape(_bb, default(IHollowSphereTriggerShape));
		}

		// Token: 0x060168CA RID: 92362 RVA: 0x0033A004 File Offset: 0x00338204
		public static IHollowSphereTriggerShape GetRootAsIHollowSphereTriggerShape(ByteBuffer _bb, IHollowSphereTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060168CB RID: 92363 RVA: 0x0033A021 File Offset: 0x00338221
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060168CC RID: 92364 RVA: 0x0033A030 File Offset: 0x00338230
		public IHollowSphereTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F9E RID: 28574
		// (get) Token: 0x060168CD RID: 92365 RVA: 0x0033A040 File Offset: 0x00338240
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

		// Token: 0x17006F9F RID: 28575
		// (get) Token: 0x060168CE RID: 92366 RVA: 0x0033A07C File Offset: 0x0033827C
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

		// Token: 0x17006FA0 RID: 28576
		// (get) Token: 0x060168CF RID: 92367 RVA: 0x0033A0DC File Offset: 0x003382DC
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

		// Token: 0x17006FA1 RID: 28577
		// (get) Token: 0x060168D0 RID: 92368 RVA: 0x0033A118 File Offset: 0x00338318
		public int InnerRadius
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

		// Token: 0x060168D1 RID: 92369 RVA: 0x0033A155 File Offset: 0x00338355
		public static Offset<IHollowSphereTriggerShape> CreateIHollowSphereTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0, int InnerRadius = 0)
		{
			builder.StartTable(4);
			IHollowSphereTriggerShape.AddInnerRadius(builder, InnerRadius);
			IHollowSphereTriggerShape.AddRadius(builder, Radius);
			IHollowSphereTriggerShape.AddCenter(builder, CenterOffset);
			IHollowSphereTriggerShape.AddType(builder, Type);
			return IHollowSphereTriggerShape.EndIHollowSphereTriggerShape(builder);
		}

		// Token: 0x060168D2 RID: 92370 RVA: 0x0033A181 File Offset: 0x00338381
		public static void StartIHollowSphereTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060168D3 RID: 92371 RVA: 0x0033A18A File Offset: 0x0033838A
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060168D4 RID: 92372 RVA: 0x0033A195 File Offset: 0x00338395
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x060168D5 RID: 92373 RVA: 0x0033A1A5 File Offset: 0x003383A5
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x060168D6 RID: 92374 RVA: 0x0033A1B0 File Offset: 0x003383B0
		public static void AddInnerRadius(FlatBufferBuilder builder, int innerRadius)
		{
			builder.AddInt(3, innerRadius, 0);
		}

		// Token: 0x060168D7 RID: 92375 RVA: 0x0033A1BB File Offset: 0x003383BB
		public static Offset<IHollowSphereTriggerShape> EndIHollowSphereTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<IHollowSphereTriggerShape>(builder.EndTable());
		}

		// Token: 0x060168D8 RID: 92376 RVA: 0x0033A1C8 File Offset: 0x003383C8
		public IHollowSphereTriggerShapeT UnPack()
		{
			IHollowSphereTriggerShapeT hollowSphereTriggerShapeT = new IHollowSphereTriggerShapeT();
			this.UnPackTo(hollowSphereTriggerShapeT);
			return hollowSphereTriggerShapeT;
		}

		// Token: 0x060168D9 RID: 92377 RVA: 0x0033A1E4 File Offset: 0x003383E4
		public void UnPackTo(IHollowSphereTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.InnerRadius = this.InnerRadius;
		}

		// Token: 0x060168DA RID: 92378 RVA: 0x0033A244 File Offset: 0x00338444
		public static Offset<IHollowSphereTriggerShape> Pack(FlatBufferBuilder builder, IHollowSphereTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHollowSphereTriggerShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return IHollowSphereTriggerShape.CreateIHollowSphereTriggerShape(builder, _o.Type, centerOffset, _o.Radius, _o.InnerRadius);
		}

		// Token: 0x0400BB9F RID: 48031
		private Table __p;
	}
}
