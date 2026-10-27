using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DBF RID: 28095
	public struct IPrompt : IFlatbufferObject
	{
		// Token: 0x1700D182 RID: 53634
		// (get) Token: 0x06031A0D RID: 203277 RVA: 0x006B95D1 File Offset: 0x006B77D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031A0E RID: 203278 RVA: 0x006B95DE File Offset: 0x006B77DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031A0F RID: 203279 RVA: 0x006B95E8 File Offset: 0x006B77E8
		public static IPrompt GetRootAsIPrompt(ByteBuffer _bb)
		{
			return IPrompt.GetRootAsIPrompt(_bb, default(IPrompt));
		}

		// Token: 0x06031A10 RID: 203280 RVA: 0x006B9604 File Offset: 0x006B7804
		public static IPrompt GetRootAsIPrompt(ByteBuffer _bb, IPrompt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031A11 RID: 203281 RVA: 0x006B9621 File Offset: 0x006B7821
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031A12 RID: 203282 RVA: 0x006B9630 File Offset: 0x006B7830
		public IPrompt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D183 RID: 53635
		// (get) Token: 0x06031A13 RID: 203283 RVA: 0x006B9640 File Offset: 0x006B7840
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

		// Token: 0x06031A14 RID: 203284 RVA: 0x006B967C File Offset: 0x006B787C
		public static Offset<IPrompt> CreateIPrompt(FlatBufferBuilder builder, int GeneralTextId = 0)
		{
			builder.StartTable(1);
			IPrompt.AddGeneralTextId(builder, GeneralTextId);
			return IPrompt.EndIPrompt(builder);
		}

		// Token: 0x06031A15 RID: 203285 RVA: 0x006B9692 File Offset: 0x006B7892
		public static void StartIPrompt(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031A16 RID: 203286 RVA: 0x006B969B File Offset: 0x006B789B
		public static void AddGeneralTextId(FlatBufferBuilder builder, int generalTextId)
		{
			builder.AddInt(0, generalTextId, 0);
		}

		// Token: 0x06031A17 RID: 203287 RVA: 0x006B96A6 File Offset: 0x006B78A6
		public static Offset<IPrompt> EndIPrompt(FlatBufferBuilder builder)
		{
			return new Offset<IPrompt>(builder.EndTable());
		}

		// Token: 0x06031A18 RID: 203288 RVA: 0x006B96B4 File Offset: 0x006B78B4
		public IPromptT UnPack()
		{
			IPromptT promptT = new IPromptT();
			this.UnPackTo(promptT);
			return promptT;
		}

		// Token: 0x06031A19 RID: 203289 RVA: 0x006B96CF File Offset: 0x006B78CF
		public void UnPackTo(IPromptT _o)
		{
			_o.GeneralTextId = this.GeneralTextId;
		}

		// Token: 0x06031A1A RID: 203290 RVA: 0x006B96E0 File Offset: 0x006B78E0
		public static Offset<IPrompt> Pack(FlatBufferBuilder builder, IPromptT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPrompt>);
			}
			return IPrompt.CreateIPrompt(builder, _o.GeneralTextId);
		}

		// Token: 0x0401179D RID: 71581
		private Table __p;
	}
}
