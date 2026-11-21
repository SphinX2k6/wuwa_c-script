using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x0200652D RID: 25901
	public struct IBulletConfig : IFlatbufferObject
	{
		// Token: 0x1700BF17 RID: 48919
		// (get) Token: 0x0602C256 RID: 180822 RVA: 0x0060351F File Offset: 0x0060171F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C257 RID: 180823 RVA: 0x0060352C File Offset: 0x0060172C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C258 RID: 180824 RVA: 0x00603534 File Offset: 0x00601734
		public static IBulletConfig GetRootAsIBulletConfig(ByteBuffer _bb)
		{
			return IBulletConfig.GetRootAsIBulletConfig(_bb, default(IBulletConfig));
		}

		// Token: 0x0602C259 RID: 180825 RVA: 0x00603550 File Offset: 0x00601750
		public static IBulletConfig GetRootAsIBulletConfig(ByteBuffer _bb, IBulletConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C25A RID: 180826 RVA: 0x0060356D File Offset: 0x0060176D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C25B RID: 180827 RVA: 0x0060357C File Offset: 0x0060177C
		public IBulletConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF18 RID: 48920
		// (get) Token: 0x0602C25C RID: 180828 RVA: 0x0060358C File Offset: 0x0060178C
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF19 RID: 48921
		// (get) Token: 0x0602C25D RID: 180829 RVA: 0x006035C8 File Offset: 0x006017C8
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C25E RID: 180830 RVA: 0x006035FF File Offset: 0x006017FF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602C25F RID: 180831 RVA: 0x0060360E File Offset: 0x0060180E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602C260 RID: 180832 RVA: 0x0060361C File Offset: 0x0060181C
		public static Offset<IBulletConfig> CreateIBulletConfig(FlatBufferBuilder builder, int Id = 0, StringOffset NameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IBulletConfig.AddName(builder, NameOffset);
			IBulletConfig.AddId(builder, Id);
			return IBulletConfig.EndIBulletConfig(builder);
		}

		// Token: 0x0602C261 RID: 180833 RVA: 0x00603639 File Offset: 0x00601839
		public static void StartIBulletConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C262 RID: 180834 RVA: 0x00603642 File Offset: 0x00601842
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602C263 RID: 180835 RVA: 0x0060364D File Offset: 0x0060184D
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0602C264 RID: 180836 RVA: 0x0060365D File Offset: 0x0060185D
		public static Offset<IBulletConfig> EndIBulletConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBulletConfig>(builder.EndTable());
		}

		// Token: 0x0602C265 RID: 180837 RVA: 0x0060366C File Offset: 0x0060186C
		public IBulletConfigT UnPack()
		{
			IBulletConfigT bulletConfigT = new IBulletConfigT();
			this.UnPackTo(bulletConfigT);
			return bulletConfigT;
		}

		// Token: 0x0602C266 RID: 180838 RVA: 0x00603687 File Offset: 0x00601887
		public void UnPackTo(IBulletConfigT _o)
		{
			_o.Id = this.Id;
			_o.Name = this.Name;
		}

		// Token: 0x0602C267 RID: 180839 RVA: 0x006036A4 File Offset: 0x006018A4
		public static Offset<IBulletConfig> Pack(FlatBufferBuilder builder, IBulletConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBulletConfig>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return IBulletConfig.CreateIBulletConfig(builder, _o.Id, nameOffset);
		}

		// Token: 0x04010752 RID: 67410
		private Table __p;
	}
}
