using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C22 RID: 15394
	public struct IHollowSphereTriggerShape : IFlatbufferObject
	{
		// Token: 0x170069F5 RID: 27125
		// (get) Token: 0x060153D1 RID: 86993 RVA: 0x0031344C File Offset: 0x0031164C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060153D2 RID: 86994 RVA: 0x00313459 File Offset: 0x00311659
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060153D3 RID: 86995 RVA: 0x00313460 File Offset: 0x00311660
		public static IHollowSphereTriggerShape GetRootAsIHollowSphereTriggerShape(ByteBuffer _bb)
		{
			return IHollowSphereTriggerShape.GetRootAsIHollowSphereTriggerShape(_bb, default(IHollowSphereTriggerShape));
		}

		// Token: 0x060153D4 RID: 86996 RVA: 0x0031347C File Offset: 0x0031167C
		public static IHollowSphereTriggerShape GetRootAsIHollowSphereTriggerShape(ByteBuffer _bb, IHollowSphereTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060153D5 RID: 86997 RVA: 0x00313499 File Offset: 0x00311699
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060153D6 RID: 86998 RVA: 0x003134A8 File Offset: 0x003116A8
		public IHollowSphereTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170069F6 RID: 27126
		// (get) Token: 0x060153D7 RID: 86999 RVA: 0x003134B8 File Offset: 0x003116B8
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

		// Token: 0x170069F7 RID: 27127
		// (get) Token: 0x060153D8 RID: 87000 RVA: 0x003134F4 File Offset: 0x003116F4
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

		// Token: 0x170069F8 RID: 27128
		// (get) Token: 0x060153D9 RID: 87001 RVA: 0x00313554 File Offset: 0x00311754
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

		// Token: 0x170069F9 RID: 27129
		// (get) Token: 0x060153DA RID: 87002 RVA: 0x00313590 File Offset: 0x00311790
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

		// Token: 0x060153DB RID: 87003 RVA: 0x003135CD File Offset: 0x003117CD
		public static Offset<IHollowSphereTriggerShape> CreateIHollowSphereTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0, int InnerRadius = 0)
		{
			builder.StartTable(4);
			IHollowSphereTriggerShape.AddInnerRadius(builder, InnerRadius);
			IHollowSphereTriggerShape.AddRadius(builder, Radius);
			IHollowSphereTriggerShape.AddCenter(builder, CenterOffset);
			IHollowSphereTriggerShape.AddType(builder, Type);
			return IHollowSphereTriggerShape.EndIHollowSphereTriggerShape(builder);
		}

		// Token: 0x060153DC RID: 87004 RVA: 0x003135F9 File Offset: 0x003117F9
		public static void StartIHollowSphereTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060153DD RID: 87005 RVA: 0x00313602 File Offset: 0x00311802
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060153DE RID: 87006 RVA: 0x0031360D File Offset: 0x0031180D
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x060153DF RID: 87007 RVA: 0x0031361D File Offset: 0x0031181D
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x060153E0 RID: 87008 RVA: 0x00313628 File Offset: 0x00311828
		public static void AddInnerRadius(FlatBufferBuilder builder, int innerRadius)
		{
			builder.AddInt(3, innerRadius, 0);
		}

		// Token: 0x060153E1 RID: 87009 RVA: 0x00313633 File Offset: 0x00311833
		public static Offset<IHollowSphereTriggerShape> EndIHollowSphereTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<IHollowSphereTriggerShape>(builder.EndTable());
		}

		// Token: 0x060153E2 RID: 87010 RVA: 0x00313640 File Offset: 0x00311840
		public IHollowSphereTriggerShapeT UnPack()
		{
			IHollowSphereTriggerShapeT hollowSphereTriggerShapeT = new IHollowSphereTriggerShapeT();
			this.UnPackTo(hollowSphereTriggerShapeT);
			return hollowSphereTriggerShapeT;
		}

		// Token: 0x060153E3 RID: 87011 RVA: 0x0031365C File Offset: 0x0031185C
		public void UnPackTo(IHollowSphereTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.InnerRadius = this.InnerRadius;
		}

		// Token: 0x060153E4 RID: 87012 RVA: 0x003136BC File Offset: 0x003118BC
		public static Offset<IHollowSphereTriggerShape> Pack(FlatBufferBuilder builder, IHollowSphereTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHollowSphereTriggerShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return IHollowSphereTriggerShape.CreateIHollowSphereTriggerShape(builder, _o.Type, centerOffset, _o.Radius, _o.InnerRadius);
		}

		// Token: 0x0400B214 RID: 45588
		private Table __p;
	}
}
