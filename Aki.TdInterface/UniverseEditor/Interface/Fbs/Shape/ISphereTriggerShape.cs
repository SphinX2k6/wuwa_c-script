using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C43 RID: 15427
	public struct ISphereTriggerShape : IFlatbufferObject
	{
		// Token: 0x17006A4B RID: 27211
		// (get) Token: 0x06015505 RID: 87301 RVA: 0x003159C8 File Offset: 0x00313BC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015506 RID: 87302 RVA: 0x003159D5 File Offset: 0x00313BD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015507 RID: 87303 RVA: 0x003159DC File Offset: 0x00313BDC
		public static ISphereTriggerShape GetRootAsISphereTriggerShape(ByteBuffer _bb)
		{
			return ISphereTriggerShape.GetRootAsISphereTriggerShape(_bb, default(ISphereTriggerShape));
		}

		// Token: 0x06015508 RID: 87304 RVA: 0x003159F8 File Offset: 0x00313BF8
		public static ISphereTriggerShape GetRootAsISphereTriggerShape(ByteBuffer _bb, ISphereTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015509 RID: 87305 RVA: 0x00315A15 File Offset: 0x00313C15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601550A RID: 87306 RVA: 0x00315A24 File Offset: 0x00313C24
		public ISphereTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006A4C RID: 27212
		// (get) Token: 0x0601550B RID: 87307 RVA: 0x00315A34 File Offset: 0x00313C34
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

		// Token: 0x17006A4D RID: 27213
		// (get) Token: 0x0601550C RID: 87308 RVA: 0x00315A70 File Offset: 0x00313C70
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

		// Token: 0x17006A4E RID: 27214
		// (get) Token: 0x0601550D RID: 87309 RVA: 0x00315AD0 File Offset: 0x00313CD0
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

		// Token: 0x0601550E RID: 87310 RVA: 0x00315B0C File Offset: 0x00313D0C
		public static Offset<ISphereTriggerShape> CreateISphereTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0)
		{
			builder.StartTable(3);
			ISphereTriggerShape.AddRadius(builder, Radius);
			ISphereTriggerShape.AddCenter(builder, CenterOffset);
			ISphereTriggerShape.AddType(builder, Type);
			return ISphereTriggerShape.EndISphereTriggerShape(builder);
		}

		// Token: 0x0601550F RID: 87311 RVA: 0x00315B30 File Offset: 0x00313D30
		public static void StartISphereTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015510 RID: 87312 RVA: 0x00315B39 File Offset: 0x00313D39
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015511 RID: 87313 RVA: 0x00315B44 File Offset: 0x00313D44
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(1, centerOffset.Value, 0);
		}

		// Token: 0x06015512 RID: 87314 RVA: 0x00315B54 File Offset: 0x00313D54
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x06015513 RID: 87315 RVA: 0x00315B5F File Offset: 0x00313D5F
		public static Offset<ISphereTriggerShape> EndISphereTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<ISphereTriggerShape>(builder.EndTable());
		}

		// Token: 0x06015514 RID: 87316 RVA: 0x00315B6C File Offset: 0x00313D6C
		public ISphereTriggerShapeT UnPack()
		{
			ISphereTriggerShapeT sphereTriggerShapeT = new ISphereTriggerShapeT();
			this.UnPackTo(sphereTriggerShapeT);
			return sphereTriggerShapeT;
		}

		// Token: 0x06015515 RID: 87317 RVA: 0x00315B88 File Offset: 0x00313D88
		public void UnPackTo(ISphereTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
		}

		// Token: 0x06015516 RID: 87318 RVA: 0x00315BDC File Offset: 0x00313DDC
		public static Offset<ISphereTriggerShape> Pack(FlatBufferBuilder builder, ISphereTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISphereTriggerShape>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return ISphereTriggerShape.CreateISphereTriggerShape(builder, _o.Type, centerOffset, _o.Radius);
		}

		// Token: 0x0400B24B RID: 45643
		private Table __p;
	}
}
