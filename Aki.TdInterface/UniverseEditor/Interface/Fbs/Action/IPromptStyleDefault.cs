using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DD1 RID: 28113
	public struct IPromptStyleDefault : IFlatbufferObject
	{
		// Token: 0x1700D197 RID: 53655
		// (get) Token: 0x06031A81 RID: 203393 RVA: 0x006BA009 File Offset: 0x006B8209
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031A82 RID: 203394 RVA: 0x006BA016 File Offset: 0x006B8216
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031A83 RID: 203395 RVA: 0x006BA020 File Offset: 0x006B8220
		public static IPromptStyleDefault GetRootAsIPromptStyleDefault(ByteBuffer _bb)
		{
			return IPromptStyleDefault.GetRootAsIPromptStyleDefault(_bb, default(IPromptStyleDefault));
		}

		// Token: 0x06031A84 RID: 203396 RVA: 0x006BA03C File Offset: 0x006B823C
		public static IPromptStyleDefault GetRootAsIPromptStyleDefault(ByteBuffer _bb, IPromptStyleDefault obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031A85 RID: 203397 RVA: 0x006BA059 File Offset: 0x006B8259
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031A86 RID: 203398 RVA: 0x006BA068 File Offset: 0x006B8268
		public IPromptStyleDefault __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D198 RID: 53656
		// (get) Token: 0x06031A87 RID: 203399 RVA: 0x006BA078 File Offset: 0x006B8278
		public EPromptStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPromptStyle.Default;
				}
				return (EPromptStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031A88 RID: 203400 RVA: 0x006BA0B4 File Offset: 0x006B82B4
		public static Offset<IPromptStyleDefault> CreateIPromptStyleDefault(FlatBufferBuilder builder, EPromptStyle Type = EPromptStyle.Default)
		{
			builder.StartTable(1);
			IPromptStyleDefault.AddType(builder, Type);
			return IPromptStyleDefault.EndIPromptStyleDefault(builder);
		}

		// Token: 0x06031A89 RID: 203401 RVA: 0x006BA0CA File Offset: 0x006B82CA
		public static void StartIPromptStyleDefault(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031A8A RID: 203402 RVA: 0x006BA0D3 File Offset: 0x006B82D3
		public static void AddType(FlatBufferBuilder builder, EPromptStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031A8B RID: 203403 RVA: 0x006BA0DE File Offset: 0x006B82DE
		public static Offset<IPromptStyleDefault> EndIPromptStyleDefault(FlatBufferBuilder builder)
		{
			return new Offset<IPromptStyleDefault>(builder.EndTable());
		}

		// Token: 0x06031A8C RID: 203404 RVA: 0x006BA0EC File Offset: 0x006B82EC
		public IPromptStyleDefaultT UnPack()
		{
			IPromptStyleDefaultT promptStyleDefaultT = new IPromptStyleDefaultT();
			this.UnPackTo(promptStyleDefaultT);
			return promptStyleDefaultT;
		}

		// Token: 0x06031A8D RID: 203405 RVA: 0x006BA107 File Offset: 0x006B8307
		public void UnPackTo(IPromptStyleDefaultT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031A8E RID: 203406 RVA: 0x006BA118 File Offset: 0x006B8318
		public static Offset<IPromptStyleDefault> Pack(FlatBufferBuilder builder, IPromptStyleDefaultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPromptStyleDefault>);
			}
			return IPromptStyleDefault.CreateIPromptStyleDefault(builder, _o.Type);
		}

		// Token: 0x040117B2 RID: 71602
		private Table __p;
	}
}
