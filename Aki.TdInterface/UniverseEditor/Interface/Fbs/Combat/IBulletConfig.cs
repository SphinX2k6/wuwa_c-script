using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02005EEA RID: 24298
	public struct IBulletConfig : IFlatbufferObject
	{
		// Token: 0x1700B5AC RID: 46508
		// (get) Token: 0x06029BA2 RID: 170914 RVA: 0x005BA03B File Offset: 0x005B823B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029BA3 RID: 170915 RVA: 0x005BA048 File Offset: 0x005B8248
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029BA4 RID: 170916 RVA: 0x005BA050 File Offset: 0x005B8250
		public static IBulletConfig GetRootAsIBulletConfig(ByteBuffer _bb)
		{
			return IBulletConfig.GetRootAsIBulletConfig(_bb, default(IBulletConfig));
		}

		// Token: 0x06029BA5 RID: 170917 RVA: 0x005BA06C File Offset: 0x005B826C
		public static IBulletConfig GetRootAsIBulletConfig(ByteBuffer _bb, IBulletConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029BA6 RID: 170918 RVA: 0x005BA089 File Offset: 0x005B8289
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029BA7 RID: 170919 RVA: 0x005BA098 File Offset: 0x005B8298
		public IBulletConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B5AD RID: 46509
		// (get) Token: 0x06029BA8 RID: 170920 RVA: 0x005BA0A8 File Offset: 0x005B82A8
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

		// Token: 0x1700B5AE RID: 46510
		// (get) Token: 0x06029BA9 RID: 170921 RVA: 0x005BA0E4 File Offset: 0x005B82E4
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

		// Token: 0x06029BAA RID: 170922 RVA: 0x005BA11B File Offset: 0x005B831B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06029BAB RID: 170923 RVA: 0x005BA12A File Offset: 0x005B832A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06029BAC RID: 170924 RVA: 0x005BA138 File Offset: 0x005B8338
		public static Offset<IBulletConfig> CreateIBulletConfig(FlatBufferBuilder builder, int Id = 0, StringOffset NameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IBulletConfig.AddName(builder, NameOffset);
			IBulletConfig.AddId(builder, Id);
			return IBulletConfig.EndIBulletConfig(builder);
		}

		// Token: 0x06029BAD RID: 170925 RVA: 0x005BA155 File Offset: 0x005B8355
		public static void StartIBulletConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029BAE RID: 170926 RVA: 0x005BA15E File Offset: 0x005B835E
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06029BAF RID: 170927 RVA: 0x005BA169 File Offset: 0x005B8369
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x06029BB0 RID: 170928 RVA: 0x005BA179 File Offset: 0x005B8379
		public static Offset<IBulletConfig> EndIBulletConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBulletConfig>(builder.EndTable());
		}

		// Token: 0x06029BB1 RID: 170929 RVA: 0x005BA188 File Offset: 0x005B8388
		public IBulletConfigT UnPack()
		{
			IBulletConfigT bulletConfigT = new IBulletConfigT();
			this.UnPackTo(bulletConfigT);
			return bulletConfigT;
		}

		// Token: 0x06029BB2 RID: 170930 RVA: 0x005BA1A3 File Offset: 0x005B83A3
		public void UnPackTo(IBulletConfigT _o)
		{
			_o.Id = this.Id;
			_o.Name = this.Name;
		}

		// Token: 0x06029BB3 RID: 170931 RVA: 0x005BA1C0 File Offset: 0x005B83C0
		public static Offset<IBulletConfig> Pack(FlatBufferBuilder builder, IBulletConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBulletConfig>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return IBulletConfig.CreateIBulletConfig(builder, _o.Id, nameOffset);
		}

		// Token: 0x0400F9EE RID: 63982
		private Table __p;
	}
}
