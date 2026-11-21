using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007228 RID: 29224
	public struct IMontageConfig : IFlatbufferObject
	{
		// Token: 0x1700D5E8 RID: 54760
		// (get) Token: 0x06032DA4 RID: 208292 RVA: 0x006DDB19 File Offset: 0x006DBD19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032DA5 RID: 208293 RVA: 0x006DDB26 File Offset: 0x006DBD26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032DA6 RID: 208294 RVA: 0x006DDB30 File Offset: 0x006DBD30
		public static IMontageConfig GetRootAsIMontageConfig(ByteBuffer _bb)
		{
			return IMontageConfig.GetRootAsIMontageConfig(_bb, default(IMontageConfig));
		}

		// Token: 0x06032DA7 RID: 208295 RVA: 0x006DDB4C File Offset: 0x006DBD4C
		public static IMontageConfig GetRootAsIMontageConfig(ByteBuffer _bb, IMontageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032DA8 RID: 208296 RVA: 0x006DDB69 File Offset: 0x006DBD69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032DA9 RID: 208297 RVA: 0x006DDB78 File Offset: 0x006DBD78
		public IMontageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5E9 RID: 54761
		// (get) Token: 0x06032DAA RID: 208298 RVA: 0x006DDB88 File Offset: 0x006DBD88
		public EMontageConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMontageConfigType.Asset;
				}
				return (EMontageConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032DAB RID: 208299 RVA: 0x006DDBC4 File Offset: 0x006DBDC4
		public static Offset<IMontageConfig> CreateIMontageConfig(FlatBufferBuilder builder, EMontageConfigType Type = EMontageConfigType.Asset)
		{
			builder.StartTable(1);
			IMontageConfig.AddType(builder, Type);
			return IMontageConfig.EndIMontageConfig(builder);
		}

		// Token: 0x06032DAC RID: 208300 RVA: 0x006DDBDA File Offset: 0x006DBDDA
		public static void StartIMontageConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032DAD RID: 208301 RVA: 0x006DDBE3 File Offset: 0x006DBDE3
		public static void AddType(FlatBufferBuilder builder, EMontageConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032DAE RID: 208302 RVA: 0x006DDBEE File Offset: 0x006DBDEE
		public static Offset<IMontageConfig> EndIMontageConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMontageConfig>(builder.EndTable());
		}

		// Token: 0x06032DAF RID: 208303 RVA: 0x006DDBFC File Offset: 0x006DBDFC
		public IMontageConfigT UnPack()
		{
			IMontageConfigT montageConfigT = new IMontageConfigT();
			this.UnPackTo(montageConfigT);
			return montageConfigT;
		}

		// Token: 0x06032DB0 RID: 208304 RVA: 0x006DDC17 File Offset: 0x006DBE17
		public void UnPackTo(IMontageConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032DB1 RID: 208305 RVA: 0x006DDC28 File Offset: 0x006DBE28
		public static Offset<IMontageConfig> Pack(FlatBufferBuilder builder, IMontageConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMontageConfig>);
			}
			return IMontageConfig.CreateIMontageConfig(builder, _o.Type);
		}

		// Token: 0x04012259 RID: 74329
		private Table __p;
	}
}
