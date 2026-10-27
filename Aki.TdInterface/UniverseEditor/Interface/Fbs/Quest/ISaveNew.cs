using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004100 RID: 16640
	public struct ISaveNew : IFlatbufferObject
	{
		// Token: 0x17007546 RID: 30022
		// (get) Token: 0x06018421 RID: 99361 RVA: 0x0037DE64 File Offset: 0x0037C064
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018422 RID: 99362 RVA: 0x0037DE71 File Offset: 0x0037C071
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018423 RID: 99363 RVA: 0x0037DE78 File Offset: 0x0037C078
		public static ISaveNew GetRootAsISaveNew(ByteBuffer _bb)
		{
			return ISaveNew.GetRootAsISaveNew(_bb, default(ISaveNew));
		}

		// Token: 0x06018424 RID: 99364 RVA: 0x0037DE94 File Offset: 0x0037C094
		public static ISaveNew GetRootAsISaveNew(ByteBuffer _bb, ISaveNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018425 RID: 99365 RVA: 0x0037DEB1 File Offset: 0x0037C0B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018426 RID: 99366 RVA: 0x0037DEC0 File Offset: 0x0037C0C0
		public ISaveNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007547 RID: 30023
		// (get) Token: 0x06018427 RID: 99367 RVA: 0x0037DED0 File Offset: 0x0037C0D0
		public ESaveConfig Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESaveConfig.SaveNew;
				}
				return (ESaveConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018428 RID: 99368 RVA: 0x0037DF0C File Offset: 0x0037C10C
		public static Offset<ISaveNew> CreateISaveNew(FlatBufferBuilder builder, ESaveConfig Type = ESaveConfig.SaveNew)
		{
			builder.StartTable(1);
			ISaveNew.AddType(builder, Type);
			return ISaveNew.EndISaveNew(builder);
		}

		// Token: 0x06018429 RID: 99369 RVA: 0x0037DF22 File Offset: 0x0037C122
		public static void StartISaveNew(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601842A RID: 99370 RVA: 0x0037DF2B File Offset: 0x0037C12B
		public static void AddType(FlatBufferBuilder builder, ESaveConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601842B RID: 99371 RVA: 0x0037DF36 File Offset: 0x0037C136
		public static Offset<ISaveNew> EndISaveNew(FlatBufferBuilder builder)
		{
			return new Offset<ISaveNew>(builder.EndTable());
		}

		// Token: 0x0601842C RID: 99372 RVA: 0x0037DF44 File Offset: 0x0037C144
		public ISaveNewT UnPack()
		{
			ISaveNewT saveNewT = new ISaveNewT();
			this.UnPackTo(saveNewT);
			return saveNewT;
		}

		// Token: 0x0601842D RID: 99373 RVA: 0x0037DF5F File Offset: 0x0037C15F
		public void UnPackTo(ISaveNewT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601842E RID: 99374 RVA: 0x0037DF70 File Offset: 0x0037C170
		public static Offset<ISaveNew> Pack(FlatBufferBuilder builder, ISaveNewT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISaveNew>);
			}
			return ISaveNew.CreateISaveNew(builder, _o.Type);
		}

		// Token: 0x0400BCA2 RID: 48290
		private Table __p;
	}
}
