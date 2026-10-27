using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040FA RID: 16634
	public struct ISaveConfigType : IFlatbufferObject
	{
		// Token: 0x17007541 RID: 30017
		// (get) Token: 0x06018401 RID: 99329 RVA: 0x0037DBA1 File Offset: 0x0037BDA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018402 RID: 99330 RVA: 0x0037DBAE File Offset: 0x0037BDAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018403 RID: 99331 RVA: 0x0037DBB8 File Offset: 0x0037BDB8
		public static ISaveConfigType GetRootAsISaveConfigType(ByteBuffer _bb)
		{
			return ISaveConfigType.GetRootAsISaveConfigType(_bb, default(ISaveConfigType));
		}

		// Token: 0x06018404 RID: 99332 RVA: 0x0037DBD4 File Offset: 0x0037BDD4
		public static ISaveConfigType GetRootAsISaveConfigType(ByteBuffer _bb, ISaveConfigType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018405 RID: 99333 RVA: 0x0037DBF1 File Offset: 0x0037BDF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018406 RID: 99334 RVA: 0x0037DC00 File Offset: 0x0037BE00
		public ISaveConfigType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007542 RID: 30018
		// (get) Token: 0x06018407 RID: 99335 RVA: 0x0037DC10 File Offset: 0x0037BE10
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

		// Token: 0x06018408 RID: 99336 RVA: 0x0037DC4C File Offset: 0x0037BE4C
		public static Offset<ISaveConfigType> CreateISaveConfigType(FlatBufferBuilder builder, ESaveConfig Type = ESaveConfig.SaveNew)
		{
			builder.StartTable(1);
			ISaveConfigType.AddType(builder, Type);
			return ISaveConfigType.EndISaveConfigType(builder);
		}

		// Token: 0x06018409 RID: 99337 RVA: 0x0037DC62 File Offset: 0x0037BE62
		public static void StartISaveConfigType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601840A RID: 99338 RVA: 0x0037DC6B File Offset: 0x0037BE6B
		public static void AddType(FlatBufferBuilder builder, ESaveConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601840B RID: 99339 RVA: 0x0037DC76 File Offset: 0x0037BE76
		public static Offset<ISaveConfigType> EndISaveConfigType(FlatBufferBuilder builder)
		{
			return new Offset<ISaveConfigType>(builder.EndTable());
		}

		// Token: 0x0601840C RID: 99340 RVA: 0x0037DC84 File Offset: 0x0037BE84
		public ISaveConfigTypeT UnPack()
		{
			ISaveConfigTypeT saveConfigTypeT = new ISaveConfigTypeT();
			this.UnPackTo(saveConfigTypeT);
			return saveConfigTypeT;
		}

		// Token: 0x0601840D RID: 99341 RVA: 0x0037DC9F File Offset: 0x0037BE9F
		public void UnPackTo(ISaveConfigTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601840E RID: 99342 RVA: 0x0037DCB0 File Offset: 0x0037BEB0
		public static Offset<ISaveConfigType> Pack(FlatBufferBuilder builder, ISaveConfigTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISaveConfigType>);
			}
			return ISaveConfigType.CreateISaveConfigType(builder, _o.Type);
		}

		// Token: 0x0400BC99 RID: 48281
		private Table __p;
	}
}
