using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200711B RID: 28955
	public struct ISitOnGround : IFlatbufferObject
	{
		// Token: 0x1700D742 RID: 55106
		// (get) Token: 0x06033563 RID: 210275 RVA: 0x006EB8B0 File Offset: 0x006E9AB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033564 RID: 210276 RVA: 0x006EB8BD File Offset: 0x006E9ABD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033565 RID: 210277 RVA: 0x006EB8C4 File Offset: 0x006E9AC4
		public static ISitOnGround GetRootAsISitOnGround(ByteBuffer _bb)
		{
			return ISitOnGround.GetRootAsISitOnGround(_bb, default(ISitOnGround));
		}

		// Token: 0x06033566 RID: 210278 RVA: 0x006EB8E0 File Offset: 0x006E9AE0
		public static ISitOnGround GetRootAsISitOnGround(ByteBuffer _bb, ISitOnGround obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033567 RID: 210279 RVA: 0x006EB8FD File Offset: 0x006E9AFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033568 RID: 210280 RVA: 0x006EB90C File Offset: 0x006E9B0C
		public ISitOnGround __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D743 RID: 55107
		// (get) Token: 0x06033569 RID: 210281 RVA: 0x006EB91C File Offset: 0x006E9B1C
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603356A RID: 210282 RVA: 0x006EB958 File Offset: 0x006E9B58
		public static Offset<ISitOnGround> CreateISitOnGround(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			ISitOnGround.AddType(builder, Type);
			return ISitOnGround.EndISitOnGround(builder);
		}

		// Token: 0x0603356B RID: 210283 RVA: 0x006EB96E File Offset: 0x006E9B6E
		public static void StartISitOnGround(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603356C RID: 210284 RVA: 0x006EB977 File Offset: 0x006E9B77
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603356D RID: 210285 RVA: 0x006EB982 File Offset: 0x006E9B82
		public static Offset<ISitOnGround> EndISitOnGround(FlatBufferBuilder builder)
		{
			return new Offset<ISitOnGround>(builder.EndTable());
		}

		// Token: 0x0603356E RID: 210286 RVA: 0x006EB990 File Offset: 0x006E9B90
		public ISitOnGroundT UnPack()
		{
			ISitOnGroundT sitOnGroundT = new ISitOnGroundT();
			this.UnPackTo(sitOnGroundT);
			return sitOnGroundT;
		}

		// Token: 0x0603356F RID: 210287 RVA: 0x006EB9AB File Offset: 0x006E9BAB
		public void UnPackTo(ISitOnGroundT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033570 RID: 210288 RVA: 0x006EB9BC File Offset: 0x006E9BBC
		public static Offset<ISitOnGround> Pack(FlatBufferBuilder builder, ISitOnGroundT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISitOnGround>);
			}
			return ISitOnGround.CreateISitOnGround(builder, _o.Type);
		}

		// Token: 0x04011BAE RID: 72622
		private Table __p;
	}
}
