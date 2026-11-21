using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200751F RID: 29983
	public struct IPreprocessOperationConfig : IFlatbufferObject
	{
		// Token: 0x1700DCA2 RID: 56482
		// (get) Token: 0x06034957 RID: 215383 RVA: 0x00713BA4 File Offset: 0x00711DA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034958 RID: 215384 RVA: 0x00713BB1 File Offset: 0x00711DB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034959 RID: 215385 RVA: 0x00713BB8 File Offset: 0x00711DB8
		public static IPreprocessOperationConfig GetRootAsIPreprocessOperationConfig(ByteBuffer _bb)
		{
			return IPreprocessOperationConfig.GetRootAsIPreprocessOperationConfig(_bb, default(IPreprocessOperationConfig));
		}

		// Token: 0x0603495A RID: 215386 RVA: 0x00713BD4 File Offset: 0x00711DD4
		public static IPreprocessOperationConfig GetRootAsIPreprocessOperationConfig(ByteBuffer _bb, IPreprocessOperationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603495B RID: 215387 RVA: 0x00713BF1 File Offset: 0x00711DF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603495C RID: 215388 RVA: 0x00713C00 File Offset: 0x00711E00
		public IPreprocessOperationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCA3 RID: 56483
		// (get) Token: 0x0603495D RID: 215389 RVA: 0x00713C10 File Offset: 0x00711E10
		public EPreprocessOperation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPreprocessOperation.FloatingSubtitleLanguageDiff;
				}
				return (EPreprocessOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603495E RID: 215390 RVA: 0x00713C4C File Offset: 0x00711E4C
		public static Offset<IPreprocessOperationConfig> CreateIPreprocessOperationConfig(FlatBufferBuilder builder, EPreprocessOperation Type = EPreprocessOperation.FloatingSubtitleLanguageDiff)
		{
			builder.StartTable(1);
			IPreprocessOperationConfig.AddType(builder, Type);
			return IPreprocessOperationConfig.EndIPreprocessOperationConfig(builder);
		}

		// Token: 0x0603495F RID: 215391 RVA: 0x00713C62 File Offset: 0x00711E62
		public static void StartIPreprocessOperationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034960 RID: 215392 RVA: 0x00713C6B File Offset: 0x00711E6B
		public static void AddType(FlatBufferBuilder builder, EPreprocessOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034961 RID: 215393 RVA: 0x00713C76 File Offset: 0x00711E76
		public static Offset<IPreprocessOperationConfig> EndIPreprocessOperationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPreprocessOperationConfig>(builder.EndTable());
		}

		// Token: 0x06034962 RID: 215394 RVA: 0x00713C84 File Offset: 0x00711E84
		public IPreprocessOperationConfigT UnPack()
		{
			IPreprocessOperationConfigT preprocessOperationConfigT = new IPreprocessOperationConfigT();
			this.UnPackTo(preprocessOperationConfigT);
			return preprocessOperationConfigT;
		}

		// Token: 0x06034963 RID: 215395 RVA: 0x00713C9F File Offset: 0x00711E9F
		public void UnPackTo(IPreprocessOperationConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034964 RID: 215396 RVA: 0x00713CB0 File Offset: 0x00711EB0
		public static Offset<IPreprocessOperationConfig> Pack(FlatBufferBuilder builder, IPreprocessOperationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreprocessOperationConfig>);
			}
			return IPreprocessOperationConfig.CreateIPreprocessOperationConfig(builder, _o.Type);
		}

		// Token: 0x040126F3 RID: 75507
		private Table __p;
	}
}
