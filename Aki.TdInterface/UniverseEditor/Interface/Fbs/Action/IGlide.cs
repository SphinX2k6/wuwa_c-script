using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006894 RID: 26772
	public struct IGlide : IFlatbufferObject
	{
		// Token: 0x1700C6C4 RID: 50884
		// (get) Token: 0x0602EB0C RID: 191244 RVA: 0x0065DB6A File Offset: 0x0065BD6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EB0D RID: 191245 RVA: 0x0065DB77 File Offset: 0x0065BD77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EB0E RID: 191246 RVA: 0x0065DB80 File Offset: 0x0065BD80
		public static IGlide GetRootAsIGlide(ByteBuffer _bb)
		{
			return IGlide.GetRootAsIGlide(_bb, default(IGlide));
		}

		// Token: 0x0602EB0F RID: 191247 RVA: 0x0065DB9C File Offset: 0x0065BD9C
		public static IGlide GetRootAsIGlide(ByteBuffer _bb, IGlide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EB10 RID: 191248 RVA: 0x0065DBB9 File Offset: 0x0065BDB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EB11 RID: 191249 RVA: 0x0065DBC8 File Offset: 0x0065BDC8
		public IGlide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6C5 RID: 50885
		// (get) Token: 0x0602EB12 RID: 191250 RVA: 0x0065DBD8 File Offset: 0x0065BDD8
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

		// Token: 0x0602EB13 RID: 191251 RVA: 0x0065DC14 File Offset: 0x0065BE14
		public static Offset<IGlide> CreateIGlide(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IGlide.AddType(builder, Type);
			return IGlide.EndIGlide(builder);
		}

		// Token: 0x0602EB14 RID: 191252 RVA: 0x0065DC2A File Offset: 0x0065BE2A
		public static void StartIGlide(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EB15 RID: 191253 RVA: 0x0065DC33 File Offset: 0x0065BE33
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EB16 RID: 191254 RVA: 0x0065DC3E File Offset: 0x0065BE3E
		public static Offset<IGlide> EndIGlide(FlatBufferBuilder builder)
		{
			return new Offset<IGlide>(builder.EndTable());
		}

		// Token: 0x0602EB17 RID: 191255 RVA: 0x0065DC4C File Offset: 0x0065BE4C
		public IGlideT UnPack()
		{
			IGlideT glideT = new IGlideT();
			this.UnPackTo(glideT);
			return glideT;
		}

		// Token: 0x0602EB18 RID: 191256 RVA: 0x0065DC67 File Offset: 0x0065BE67
		public void UnPackTo(IGlideT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EB19 RID: 191257 RVA: 0x0065DC78 File Offset: 0x0065BE78
		public static Offset<IGlide> Pack(FlatBufferBuilder builder, IGlideT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGlide>);
			}
			return IGlide.CreateIGlide(builder, _o.Type);
		}

		// Token: 0x04010FE4 RID: 69604
		private Table __p;
	}
}
