using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004082 RID: 16514
	public struct ITurntableConnectorTipsActor : IFlatbufferObject
	{
		// Token: 0x1700706A RID: 28778
		// (get) Token: 0x06016BC3 RID: 93123 RVA: 0x0033F7C8 File Offset: 0x0033D9C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016BC4 RID: 93124 RVA: 0x0033F7D5 File Offset: 0x0033D9D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016BC5 RID: 93125 RVA: 0x0033F7DC File Offset: 0x0033D9DC
		public static ITurntableConnectorTipsActor GetRootAsITurntableConnectorTipsActor(ByteBuffer _bb)
		{
			return ITurntableConnectorTipsActor.GetRootAsITurntableConnectorTipsActor(_bb, default(ITurntableConnectorTipsActor));
		}

		// Token: 0x06016BC6 RID: 93126 RVA: 0x0033F7F8 File Offset: 0x0033D9F8
		public static ITurntableConnectorTipsActor GetRootAsITurntableConnectorTipsActor(ByteBuffer _bb, ITurntableConnectorTipsActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016BC7 RID: 93127 RVA: 0x0033F815 File Offset: 0x0033DA15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016BC8 RID: 93128 RVA: 0x0033F824 File Offset: 0x0033DA24
		public ITurntableConnectorTipsActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700706B RID: 28779
		// (get) Token: 0x06016BC9 RID: 93129 RVA: 0x0033F834 File Offset: 0x0033DA34
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

		// Token: 0x1700706C RID: 28780
		// (get) Token: 0x06016BCA RID: 93130 RVA: 0x0033F870 File Offset: 0x0033DA70
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

		// Token: 0x1700706D RID: 28781
		// (get) Token: 0x06016BCB RID: 93131 RVA: 0x0033F8AC File Offset: 0x0033DAAC
		public string MeshPath
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016BCC RID: 93132 RVA: 0x0033F8E3 File Offset: 0x0033DAE3
		public Span<byte> GetMeshPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06016BCD RID: 93133 RVA: 0x0033F8F2 File Offset: 0x0033DAF2
		public byte[] GetMeshPathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700706E RID: 28782
		// (get) Token: 0x06016BCE RID: 93134 RVA: 0x0033F900 File Offset: 0x0033DB00
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016BCF RID: 93135 RVA: 0x0033F93D File Offset: 0x0033DB3D
		public static Offset<ITurntableConnectorTipsActor> CreateITurntableConnectorTipsActor(FlatBufferBuilder builder, ETipsActorType Type = ETipsActorType.Sphere, ETipsActorColorType ColorType = ETipsActorColorType.Inner, StringOffset MeshPathOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ITurntableConnectorTipsActor.AddMeshPath(builder, MeshPathOffset);
			ITurntableConnectorTipsActor.AddNullMask(builder, NullMask);
			ITurntableConnectorTipsActor.AddColorType(builder, ColorType);
			ITurntableConnectorTipsActor.AddType(builder, Type);
			return ITurntableConnectorTipsActor.EndITurntableConnectorTipsActor(builder);
		}

		// Token: 0x06016BD0 RID: 93136 RVA: 0x0033F969 File Offset: 0x0033DB69
		public static void StartITurntableConnectorTipsActor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016BD1 RID: 93137 RVA: 0x0033F972 File Offset: 0x0033DB72
		public static void AddType(FlatBufferBuilder builder, ETipsActorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016BD2 RID: 93138 RVA: 0x0033F97D File Offset: 0x0033DB7D
		public static void AddColorType(FlatBufferBuilder builder, ETipsActorColorType colorType)
		{
			builder.AddByte(1, (byte)colorType, 0);
		}

		// Token: 0x06016BD3 RID: 93139 RVA: 0x0033F988 File Offset: 0x0033DB88
		public static void AddMeshPath(FlatBufferBuilder builder, StringOffset meshPathOffset)
		{
			builder.AddOffset(2, meshPathOffset.Value, 0);
		}

		// Token: 0x06016BD4 RID: 93140 RVA: 0x0033F998 File Offset: 0x0033DB98
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06016BD5 RID: 93141 RVA: 0x0033F9A3 File Offset: 0x0033DBA3
		public static Offset<ITurntableConnectorTipsActor> EndITurntableConnectorTipsActor(FlatBufferBuilder builder)
		{
			return new Offset<ITurntableConnectorTipsActor>(builder.EndTable());
		}

		// Token: 0x06016BD6 RID: 93142 RVA: 0x0033F9B0 File Offset: 0x0033DBB0
		public ITurntableConnectorTipsActorT UnPack()
		{
			ITurntableConnectorTipsActorT turntableConnectorTipsActorT = new ITurntableConnectorTipsActorT();
			this.UnPackTo(turntableConnectorTipsActorT);
			return turntableConnectorTipsActorT;
		}

		// Token: 0x06016BD7 RID: 93143 RVA: 0x0033F9CB File Offset: 0x0033DBCB
		public void UnPackTo(ITurntableConnectorTipsActorT _o)
		{
			_o.Type = this.Type;
			_o.ColorType = this.ColorType;
			_o.MeshPath = this.MeshPath;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016BD8 RID: 93144 RVA: 0x0033FA00 File Offset: 0x0033DC00
		public static Offset<ITurntableConnectorTipsActor> Pack(FlatBufferBuilder builder, ITurntableConnectorTipsActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITurntableConnectorTipsActor>);
			}
			StringOffset meshPathOffset = (_o.MeshPath == null) ? default(StringOffset) : builder.CreateString(_o.MeshPath);
			return ITurntableConnectorTipsActor.CreateITurntableConnectorTipsActor(builder, _o.Type, _o.ColorType, meshPathOffset, _o.NullMask);
		}

		// Token: 0x0400BC39 RID: 48185
		private Table __p;
	}
}
