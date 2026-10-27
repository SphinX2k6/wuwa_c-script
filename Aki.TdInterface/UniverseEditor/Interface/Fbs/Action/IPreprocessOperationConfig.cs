using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DA4 RID: 28068
	public struct IPreprocessOperationConfig : IFlatbufferObject
	{
		// Token: 0x1700D15A RID: 53594
		// (get) Token: 0x0603195B RID: 203099 RVA: 0x006B84BC File Offset: 0x006B66BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603195C RID: 203100 RVA: 0x006B84C9 File Offset: 0x006B66C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603195D RID: 203101 RVA: 0x006B84D0 File Offset: 0x006B66D0
		public static IPreprocessOperationConfig GetRootAsIPreprocessOperationConfig(ByteBuffer _bb)
		{
			return IPreprocessOperationConfig.GetRootAsIPreprocessOperationConfig(_bb, default(IPreprocessOperationConfig));
		}

		// Token: 0x0603195E RID: 203102 RVA: 0x006B84EC File Offset: 0x006B66EC
		public static IPreprocessOperationConfig GetRootAsIPreprocessOperationConfig(ByteBuffer _bb, IPreprocessOperationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603195F RID: 203103 RVA: 0x006B8509 File Offset: 0x006B6709
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031960 RID: 203104 RVA: 0x006B8518 File Offset: 0x006B6718
		public IPreprocessOperationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D15B RID: 53595
		// (get) Token: 0x06031961 RID: 203105 RVA: 0x006B8528 File Offset: 0x006B6728
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

		// Token: 0x06031962 RID: 203106 RVA: 0x006B8564 File Offset: 0x006B6764
		public static Offset<IPreprocessOperationConfig> CreateIPreprocessOperationConfig(FlatBufferBuilder builder, EPreprocessOperation Type = EPreprocessOperation.FloatingSubtitleLanguageDiff)
		{
			builder.StartTable(1);
			IPreprocessOperationConfig.AddType(builder, Type);
			return IPreprocessOperationConfig.EndIPreprocessOperationConfig(builder);
		}

		// Token: 0x06031963 RID: 203107 RVA: 0x006B857A File Offset: 0x006B677A
		public static void StartIPreprocessOperationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031964 RID: 203108 RVA: 0x006B8583 File Offset: 0x006B6783
		public static void AddType(FlatBufferBuilder builder, EPreprocessOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031965 RID: 203109 RVA: 0x006B858E File Offset: 0x006B678E
		public static Offset<IPreprocessOperationConfig> EndIPreprocessOperationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPreprocessOperationConfig>(builder.EndTable());
		}

		// Token: 0x06031966 RID: 203110 RVA: 0x006B859C File Offset: 0x006B679C
		public IPreprocessOperationConfigT UnPack()
		{
			IPreprocessOperationConfigT preprocessOperationConfigT = new IPreprocessOperationConfigT();
			this.UnPackTo(preprocessOperationConfigT);
			return preprocessOperationConfigT;
		}

		// Token: 0x06031967 RID: 203111 RVA: 0x006B85B7 File Offset: 0x006B67B7
		public void UnPackTo(IPreprocessOperationConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031968 RID: 203112 RVA: 0x006B85C8 File Offset: 0x006B67C8
		public static Offset<IPreprocessOperationConfig> Pack(FlatBufferBuilder builder, IPreprocessOperationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreprocessOperationConfig>);
			}
			return IPreprocessOperationConfig.CreateIPreprocessOperationConfig(builder, _o.Type);
		}

		// Token: 0x04011777 RID: 71543
		private Table __p;
	}
}
