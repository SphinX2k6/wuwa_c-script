using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200753A RID: 30010
	public struct IPrompt : IFlatbufferObject
	{
		// Token: 0x1700DCCA RID: 56522
		// (get) Token: 0x06034A09 RID: 215561 RVA: 0x00714CB9 File Offset: 0x00712EB9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034A0A RID: 215562 RVA: 0x00714CC6 File Offset: 0x00712EC6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034A0B RID: 215563 RVA: 0x00714CD0 File Offset: 0x00712ED0
		public static IPrompt GetRootAsIPrompt(ByteBuffer _bb)
		{
			return IPrompt.GetRootAsIPrompt(_bb, default(IPrompt));
		}

		// Token: 0x06034A0C RID: 215564 RVA: 0x00714CEC File Offset: 0x00712EEC
		public static IPrompt GetRootAsIPrompt(ByteBuffer _bb, IPrompt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034A0D RID: 215565 RVA: 0x00714D09 File Offset: 0x00712F09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034A0E RID: 215566 RVA: 0x00714D18 File Offset: 0x00712F18
		public IPrompt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCCB RID: 56523
		// (get) Token: 0x06034A0F RID: 215567 RVA: 0x00714D28 File Offset: 0x00712F28
		public int GeneralTextId
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

		// Token: 0x06034A10 RID: 215568 RVA: 0x00714D64 File Offset: 0x00712F64
		public static Offset<IPrompt> CreateIPrompt(FlatBufferBuilder builder, int GeneralTextId = 0)
		{
			builder.StartTable(1);
			IPrompt.AddGeneralTextId(builder, GeneralTextId);
			return IPrompt.EndIPrompt(builder);
		}

		// Token: 0x06034A11 RID: 215569 RVA: 0x00714D7A File Offset: 0x00712F7A
		public static void StartIPrompt(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034A12 RID: 215570 RVA: 0x00714D83 File Offset: 0x00712F83
		public static void AddGeneralTextId(FlatBufferBuilder builder, int generalTextId)
		{
			builder.AddInt(0, generalTextId, 0);
		}

		// Token: 0x06034A13 RID: 215571 RVA: 0x00714D8E File Offset: 0x00712F8E
		public static Offset<IPrompt> EndIPrompt(FlatBufferBuilder builder)
		{
			return new Offset<IPrompt>(builder.EndTable());
		}

		// Token: 0x06034A14 RID: 215572 RVA: 0x00714D9C File Offset: 0x00712F9C
		public IPromptT UnPack()
		{
			IPromptT promptT = new IPromptT();
			this.UnPackTo(promptT);
			return promptT;
		}

		// Token: 0x06034A15 RID: 215573 RVA: 0x00714DB7 File Offset: 0x00712FB7
		public void UnPackTo(IPromptT _o)
		{
			_o.GeneralTextId = this.GeneralTextId;
		}

		// Token: 0x06034A16 RID: 215574 RVA: 0x00714DC8 File Offset: 0x00712FC8
		public static Offset<IPrompt> Pack(FlatBufferBuilder builder, IPromptT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPrompt>);
			}
			return IPrompt.CreateIPrompt(builder, _o.GeneralTextId);
		}

		// Token: 0x04012719 RID: 75545
		private Table __p;
	}
}
