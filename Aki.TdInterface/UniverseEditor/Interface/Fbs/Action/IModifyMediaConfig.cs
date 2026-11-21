using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071F8 RID: 29176
	public struct IModifyMediaConfig : IFlatbufferObject
	{
		// Token: 0x1700D591 RID: 54673
		// (get) Token: 0x06032C16 RID: 207894 RVA: 0x006DB1EC File Offset: 0x006D93EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032C17 RID: 207895 RVA: 0x006DB1F9 File Offset: 0x006D93F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032C18 RID: 207896 RVA: 0x006DB200 File Offset: 0x006D9400
		public static IModifyMediaConfig GetRootAsIModifyMediaConfig(ByteBuffer _bb)
		{
			return IModifyMediaConfig.GetRootAsIModifyMediaConfig(_bb, default(IModifyMediaConfig));
		}

		// Token: 0x06032C19 RID: 207897 RVA: 0x006DB21C File Offset: 0x006D941C
		public static IModifyMediaConfig GetRootAsIModifyMediaConfig(ByteBuffer _bb, IModifyMediaConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032C1A RID: 207898 RVA: 0x006DB239 File Offset: 0x006D9439
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032C1B RID: 207899 RVA: 0x006DB248 File Offset: 0x006D9448
		public IModifyMediaConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D592 RID: 54674
		// (get) Token: 0x06032C1C RID: 207900 RVA: 0x006DB258 File Offset: 0x006D9458
		public EModifyActorMediaType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EModifyActorMediaType.ChangeMediaPlayDA;
				}
				return (EModifyActorMediaType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032C1D RID: 207901 RVA: 0x006DB294 File Offset: 0x006D9494
		public static Offset<IModifyMediaConfig> CreateIModifyMediaConfig(FlatBufferBuilder builder, EModifyActorMediaType Type = EModifyActorMediaType.ChangeMediaPlayDA)
		{
			builder.StartTable(1);
			IModifyMediaConfig.AddType(builder, Type);
			return IModifyMediaConfig.EndIModifyMediaConfig(builder);
		}

		// Token: 0x06032C1E RID: 207902 RVA: 0x006DB2AA File Offset: 0x006D94AA
		public static void StartIModifyMediaConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032C1F RID: 207903 RVA: 0x006DB2B3 File Offset: 0x006D94B3
		public static void AddType(FlatBufferBuilder builder, EModifyActorMediaType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032C20 RID: 207904 RVA: 0x006DB2BE File Offset: 0x006D94BE
		public static Offset<IModifyMediaConfig> EndIModifyMediaConfig(FlatBufferBuilder builder)
		{
			return new Offset<IModifyMediaConfig>(builder.EndTable());
		}

		// Token: 0x06032C21 RID: 207905 RVA: 0x006DB2CC File Offset: 0x006D94CC
		public IModifyMediaConfigT UnPack()
		{
			IModifyMediaConfigT modifyMediaConfigT = new IModifyMediaConfigT();
			this.UnPackTo(modifyMediaConfigT);
			return modifyMediaConfigT;
		}

		// Token: 0x06032C22 RID: 207906 RVA: 0x006DB2E7 File Offset: 0x006D94E7
		public void UnPackTo(IModifyMediaConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032C23 RID: 207907 RVA: 0x006DB2F8 File Offset: 0x006D94F8
		public static Offset<IModifyMediaConfig> Pack(FlatBufferBuilder builder, IModifyMediaConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyMediaConfig>);
			}
			return IModifyMediaConfig.CreateIModifyMediaConfig(builder, _o.Type);
		}

		// Token: 0x04012217 RID: 74263
		private Table __p;
	}
}
