using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200401C RID: 16412
	public struct ICylinderTriggerShape : IFlatbufferObject
	{
		// Token: 0x17006F5B RID: 28507
		// (get) Token: 0x060167FB RID: 92155 RVA: 0x00338758 File Offset: 0x00336958
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060167FC RID: 92156 RVA: 0x00338765 File Offset: 0x00336965
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060167FD RID: 92157 RVA: 0x0033876C File Offset: 0x0033696C
		public static ICylinderTriggerShape GetRootAsICylinderTriggerShape(ByteBuffer _bb)
		{
			return ICylinderTriggerShape.GetRootAsICylinderTriggerShape(_bb, default(ICylinderTriggerShape));
		}

		// Token: 0x060167FE RID: 92158 RVA: 0x00338788 File Offset: 0x00336988
		public static ICylinderTriggerShape GetRootAsICylinderTriggerShape(ByteBuffer _bb, ICylinderTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060167FF RID: 92159 RVA: 0x003387A5 File Offset: 0x003369A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016800 RID: 92160 RVA: 0x003387B4 File Offset: 0x003369B4
		public ICylinderTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F5C RID: 28508
		// (get) Token: 0x06016801 RID: 92161 RVA: 0x003387C4 File Offset: 0x003369C4
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

		// Token: 0x17006F5D RID: 28509
		// (get) Token: 0x06016802 RID: 92162 RVA: 0x00338800 File Offset: 0x00336A00
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

		// Token: 0x17006F5E RID: 28510
		// (get) Token: 0x06016803 RID: 92163 RVA: 0x00338860 File Offset: 0x00336A60
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

		// Token: 0x17006F5F RID: 28511
		// (get) Token: 0x06016804 RID: 92164 RVA: 0x0033889C File Offset: 0x00336A9C
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

		// Token: 0x06016805 RID: 92165 RVA: 0x003388D9 File Offset: 0x00336AD9
		public static Offset<ICylinderTriggerShape> CreateICylinderTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0, int Height = 0)
		{
			builder.StartTable(4);
			ICylinderTriggerShape.AddHeight(builder, Height);
			ICylinderTriggerShape.AddRadius(builder, Radius);
			ICylinderTriggerShape.AddCenter(builder, CenterOffset);
			ICylinderTriggerShape.AddType(builder, Type);
			return ICylinderTriggerShape.EndICylinderTriggerShape(builder);
		}

		// Token: 0x06016806 RID: 92166 RVA: 0x00338905 File Offset: 0x00336B05
		public static void StartICylinderTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016807 RID: 92167 RVA: 0x0033890E File Offset: 0x00336B0E
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016808 RID: 92168 RVA: 0x00338919 File Offset: 0x00336B19
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x06016809 RID: 92169 RVA: 0x00338929 File Offset: 0x00336B29
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x0601680A RID: 92170 RVA: 0x00338934 File Offset: 0x00336B34
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(3, height, 0);
		}

		// Token: 0x0601680B RID: 92171 RVA: 0x0033893F File Offset: 0x00336B3F
		public static Offset<ICylinderTriggerShape> EndICylinderTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<ICylinderTriggerShape>(builder.EndTable());
		}

		// Token: 0x0601680C RID: 92172 RVA: 0x0033894C File Offset: 0x00336B4C
		public ICylinderTriggerShapeT UnPack()
		{
			ICylinderTriggerShapeT cylinderTriggerShapeT = new ICylinderTriggerShapeT();
			this.UnPackTo(cylinderTriggerShapeT);
			return cylinderTriggerShapeT;
		}

		// Token: 0x0601680D RID: 92173 RVA: 0x00338968 File Offset: 0x00336B68
		public void UnPackTo(ICylinderTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.Height = this.Height;
		}

		// Token: 0x0601680E RID: 92174 RVA: 0x003389C8 File Offset: 0x00336BC8
		public static Offset<ICylinderTriggerShape> Pack(FlatBufferBuilder builder, ICylinderTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICylinderTriggerShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return ICylinderTriggerShape.CreateICylinderTriggerShape(builder, _o.Type, centerOffset, _o.Radius, _o.Height);
		}

		// Token: 0x0400BB7B RID: 47995
		private Table __p;
	}
}
