using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C3A RID: 15418
	public struct ISectorTipsActor : IFlatbufferObject
	{
		// Token: 0x17006A2E RID: 27182
		// (get) Token: 0x060154A7 RID: 87207 RVA: 0x00314E15 File Offset: 0x00313015
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060154A8 RID: 87208 RVA: 0x00314E22 File Offset: 0x00313022
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060154A9 RID: 87209 RVA: 0x00314E2C File Offset: 0x0031302C
		public static ISectorTipsActor GetRootAsISectorTipsActor(ByteBuffer _bb)
		{
			return ISectorTipsActor.GetRootAsISectorTipsActor(_bb, default(ISectorTipsActor));
		}

		// Token: 0x060154AA RID: 87210 RVA: 0x00314E48 File Offset: 0x00313048
		public static ISectorTipsActor GetRootAsISectorTipsActor(ByteBuffer _bb, ISectorTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060154AB RID: 87211 RVA: 0x00314E65 File Offset: 0x00313065
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060154AC RID: 87212 RVA: 0x00314E74 File Offset: 0x00313074
		public ISectorTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006A2F RID: 27183
		// (get) Token: 0x060154AD RID: 87213 RVA: 0x00314E84 File Offset: 0x00313084
		public ETipsActorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETipsActorType.Sphere;
				}
				return (ETipsActorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006A30 RID: 27184
		// (get) Token: 0x060154AE RID: 87214 RVA: 0x00314EC0 File Offset: 0x003130C0
		public ETipsActorColorType ColorType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETipsActorColorType.Inner;
				}
				return (ETipsActorColorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006A31 RID: 27185
		// (get) Token: 0x060154AF RID: 87215 RVA: 0x00314EFC File Offset: 0x003130FC
		public float Radius
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006A32 RID: 27186
		// (get) Token: 0x060154B0 RID: 87216 RVA: 0x00314F3C File Offset: 0x0031313C
		public float Angle
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006A33 RID: 27187
		// (get) Token: 0x060154B1 RID: 87217 RVA: 0x00314F80 File Offset: 0x00313180
		public float Offset
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006A34 RID: 27188
		// (get) Token: 0x060154B2 RID: 87218 RVA: 0x00314FC4 File Offset: 0x003131C4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060154B3 RID: 87219 RVA: 0x00315001 File Offset: 0x00313201
		public static Offset<ISectorTipsActor> CreateISectorTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, float Radius = 0f, float Angle = 0f, float Offset = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			ISectorTipsActor.AddOffset(builder, Offset);
			ISectorTipsActor.AddAngle(builder, Angle);
			ISectorTipsActor.AddRadius(builder, Radius);
			ISectorTipsActor.AddNullMask(builder, NullMask);
			ISectorTipsActor.AddColorType(builder, ColorType);
			ISectorTipsActor.AddType(builder, Type);
			return ISectorTipsActor.EndISectorTipsActor(builder);
		}

		// Token: 0x060154B4 RID: 87220 RVA: 0x0031503D File Offset: 0x0031323D
		public static void StartISectorTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060154B5 RID: 87221 RVA: 0x00315046 File Offset: 0x00313246
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060154B6 RID: 87222 RVA: 0x00315051 File Offset: 0x00313251
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x060154B7 RID: 87223 RVA: 0x0031505C File Offset: 0x0031325C
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(2, radius, 0.0);
		}

		// Token: 0x060154B8 RID: 87224 RVA: 0x0031506F File Offset: 0x0031326F
		public static void AddAngle(FlatBufferBuilder builder, float angle)
		{
			builder.AddFloat(3, angle, 0.0);
		}

		// Token: 0x060154B9 RID: 87225 RVA: 0x00315082 File Offset: 0x00313282
		public static void AddOffset(FlatBufferBuilder builder, float offset)
		{
			builder.AddFloat(4, offset, 0.0);
		}

		// Token: 0x060154BA RID: 87226 RVA: 0x00315095 File Offset: 0x00313295
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060154BB RID: 87227 RVA: 0x003150A0 File Offset: 0x003132A0
		public static Offset<ISectorTipsActor> EndISectorTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ISectorTipsActor>(builder.EndTable());
		}

		// Token: 0x060154BC RID: 87228 RVA: 0x003150B0 File Offset: 0x003132B0
		public ISectorTipsActorT UnPack()
		{
			ISectorTipsActorT sectorTipsActorT = new ISectorTipsActorT();
			this.UnPackTo(sectorTipsActorT);
			return sectorTipsActorT;
		}

		// Token: 0x060154BD RID: 87229 RVA: 0x003150CC File Offset: 0x003132CC
		public void UnPackTo(ISectorTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.Radius = this.Radius;
			_o.Angle = this.Angle;
			_o.Offset = this.Offset;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060154BE RID: 87230 RVA: 0x00315124 File Offset: 0x00313324
		public static Offset<ISectorTipsActor> Pack(FlatBufferBuilder builder, ISectorTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISectorTipsActor>);
			}
			return ISectorTipsActor.CreateISectorTipsActor(builder, _o.Type, _o.ColorType, _o.Radius, _o.Angle, _o.Offset, _o.NullMask);
		}

		// Token: 0x0400B23B RID: 45627
		private Table __p;
	}
}
