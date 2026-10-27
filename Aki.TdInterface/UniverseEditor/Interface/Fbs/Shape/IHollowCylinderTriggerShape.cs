using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C1C RID: 15388
	public struct IHollowCylinderTriggerShape : IFlatbufferObject
	{
		// Token: 0x170069DF RID: 27103
		// (get) Token: 0x0601538D RID: 86925 RVA: 0x00312C54 File Offset: 0x00310E54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601538E RID: 86926 RVA: 0x00312C61 File Offset: 0x00310E61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601538F RID: 86927 RVA: 0x00312C68 File Offset: 0x00310E68
		public static IHollowCylinderTriggerShape GetRootAsIHollowCylinderTriggerShape(ByteBuffer _bb)
		{
			return IHollowCylinderTriggerShape.GetRootAsIHollowCylinderTriggerShape(_bb, default(IHollowCylinderTriggerShape));
		}

		// Token: 0x06015390 RID: 86928 RVA: 0x00312C84 File Offset: 0x00310E84
		public static IHollowCylinderTriggerShape GetRootAsIHollowCylinderTriggerShape(ByteBuffer _bb, IHollowCylinderTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015391 RID: 86929 RVA: 0x00312CA1 File Offset: 0x00310EA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015392 RID: 86930 RVA: 0x00312CB0 File Offset: 0x00310EB0
		public IHollowCylinderTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170069E0 RID: 27104
		// (get) Token: 0x06015393 RID: 86931 RVA: 0x00312CC0 File Offset: 0x00310EC0
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

		// Token: 0x170069E1 RID: 27105
		// (get) Token: 0x06015394 RID: 86932 RVA: 0x00312CFC File Offset: 0x00310EFC
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

		// Token: 0x170069E2 RID: 27106
		// (get) Token: 0x06015395 RID: 86933 RVA: 0x00312D5C File Offset: 0x00310F5C
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

		// Token: 0x170069E3 RID: 27107
		// (get) Token: 0x06015396 RID: 86934 RVA: 0x00312D98 File Offset: 0x00310F98
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

		// Token: 0x170069E4 RID: 27108
		// (get) Token: 0x06015397 RID: 86935 RVA: 0x00312DD8 File Offset: 0x00310FD8
		public int InnerRadius
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

		// Token: 0x06015398 RID: 86936 RVA: 0x00312E15 File Offset: 0x00311015
		public static Offset<IHollowCylinderTriggerShape> CreateIHollowCylinderTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0, int Height = 0, int InnerRadius = 0)
		{
			builder.StartTable(5);
			IHollowCylinderTriggerShape.AddInnerRadius(builder, InnerRadius);
			IHollowCylinderTriggerShape.AddHeight(builder, Height);
			IHollowCylinderTriggerShape.AddRadius(builder, Radius);
			IHollowCylinderTriggerShape.AddCenter(builder, CenterOffset);
			IHollowCylinderTriggerShape.AddType(builder, Type);
			return IHollowCylinderTriggerShape.EndIHollowCylinderTriggerShape(builder);
		}

		// Token: 0x06015399 RID: 86937 RVA: 0x00312E49 File Offset: 0x00311049
		public static void StartIHollowCylinderTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601539A RID: 86938 RVA: 0x00312E52 File Offset: 0x00311052
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601539B RID: 86939 RVA: 0x00312E5D File Offset: 0x0031105D
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x0601539C RID: 86940 RVA: 0x00312E6D File Offset: 0x0031106D
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x0601539D RID: 86941 RVA: 0x00312E78 File Offset: 0x00311078
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(3, height, 0);
		}

		// Token: 0x0601539E RID: 86942 RVA: 0x00312E83 File Offset: 0x00311083
		public static void AddInnerRadius(FlatBufferBuilder builder, int innerRadius)
		{
			builder.AddInt(4, innerRadius, 0);
		}

		// Token: 0x0601539F RID: 86943 RVA: 0x00312E8E File Offset: 0x0031108E
		public static Offset<IHollowCylinderTriggerShape> EndIHollowCylinderTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<IHollowCylinderTriggerShape>(builder.EndTable());
		}

		// Token: 0x060153A0 RID: 86944 RVA: 0x00312E9C File Offset: 0x0031109C
		public IHollowCylinderTriggerShapeT UnPack()
		{
			IHollowCylinderTriggerShapeT hollowCylinderTriggerShapeT = new IHollowCylinderTriggerShapeT();
			this.UnPackTo(hollowCylinderTriggerShapeT);
			return hollowCylinderTriggerShapeT;
		}

		// Token: 0x060153A1 RID: 86945 RVA: 0x00312EB8 File Offset: 0x003110B8
		public void UnPackTo(IHollowCylinderTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.Height = this.Height;
			_o.InnerRadius = this.InnerRadius;
		}

		// Token: 0x060153A2 RID: 86946 RVA: 0x00312F24 File Offset: 0x00311124
		public static Offset<IHollowCylinderTriggerShape> Pack(FlatBufferBuilder builder, IHollowCylinderTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHollowCylinderTriggerShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return IHollowCylinderTriggerShape.CreateIHollowCylinderTriggerShape(builder, _o.Type, centerOffset, _o.Radius, _o.Height, _o.InnerRadius);
		}

		// Token: 0x0400B208 RID: 45576
		private Table __p;
	}
}
