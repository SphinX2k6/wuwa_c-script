using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078E7 RID: 30951
	public struct ISitOnGround : IFlatbufferObject
	{
		// Token: 0x1700E325 RID: 58149
		// (get) Token: 0x06036805 RID: 223237 RVA: 0x0074BEBC File Offset: 0x0074A0BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036806 RID: 223238 RVA: 0x0074BEC9 File Offset: 0x0074A0C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036807 RID: 223239 RVA: 0x0074BED0 File Offset: 0x0074A0D0
		public static ISitOnGround GetRootAsISitOnGround(ByteBuffer _bb)
		{
			return ISitOnGround.GetRootAsISitOnGround(_bb, default(ISitOnGround));
		}

		// Token: 0x06036808 RID: 223240 RVA: 0x0074BEEC File Offset: 0x0074A0EC
		public static ISitOnGround GetRootAsISitOnGround(ByteBuffer _bb, ISitOnGround obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036809 RID: 223241 RVA: 0x0074BF09 File Offset: 0x0074A109
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603680A RID: 223242 RVA: 0x0074BF18 File Offset: 0x0074A118
		public ISitOnGround __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E326 RID: 58150
		// (get) Token: 0x0603680B RID: 223243 RVA: 0x0074BF28 File Offset: 0x0074A128
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

		// Token: 0x0603680C RID: 223244 RVA: 0x0074BF64 File Offset: 0x0074A164
		public static Offset<ISitOnGround> CreateISitOnGround(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			ISitOnGround.AddType(builder, Type);
			return ISitOnGround.EndISitOnGround(builder);
		}

		// Token: 0x0603680D RID: 223245 RVA: 0x0074BF7A File Offset: 0x0074A17A
		public static void StartISitOnGround(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603680E RID: 223246 RVA: 0x0074BF83 File Offset: 0x0074A183
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603680F RID: 223247 RVA: 0x0074BF8E File Offset: 0x0074A18E
		public static Offset<ISitOnGround> EndISitOnGround(FlatBufferBuilder builder)
		{
			return new Offset<ISitOnGround>(builder.EndTable());
		}

		// Token: 0x06036810 RID: 223248 RVA: 0x0074BF9C File Offset: 0x0074A19C
		public ISitOnGroundT UnPack()
		{
			ISitOnGroundT sitOnGroundT = new ISitOnGroundT();
			this.UnPackTo(sitOnGroundT);
			return sitOnGroundT;
		}

		// Token: 0x06036811 RID: 223249 RVA: 0x0074BFB7 File Offset: 0x0074A1B7
		public void UnPackTo(ISitOnGroundT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036812 RID: 223250 RVA: 0x0074BFC8 File Offset: 0x0074A1C8
		public static Offset<ISitOnGround> Pack(FlatBufferBuilder builder, ISitOnGroundT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISitOnGround>);
			}
			return ISitOnGround.CreateISitOnGround(builder, _o.Type);
		}

		// Token: 0x04012B9C RID: 76700
		private Table __p;
	}
}
