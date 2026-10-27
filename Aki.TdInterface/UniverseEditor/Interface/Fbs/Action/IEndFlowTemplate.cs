using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066A2 RID: 26274
	public struct IEndFlowTemplate : IFlatbufferObject
	{
		// Token: 0x1700C33C RID: 49980
		// (get) Token: 0x0602DAA5 RID: 187045 RVA: 0x0063FB70 File Offset: 0x0063DD70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DAA6 RID: 187046 RVA: 0x0063FB7D File Offset: 0x0063DD7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DAA7 RID: 187047 RVA: 0x0063FB84 File Offset: 0x0063DD84
		public static IEndFlowTemplate GetRootAsIEndFlowTemplate(ByteBuffer _bb)
		{
			return IEndFlowTemplate.GetRootAsIEndFlowTemplate(_bb, default(IEndFlowTemplate));
		}

		// Token: 0x0602DAA8 RID: 187048 RVA: 0x0063FBA0 File Offset: 0x0063DDA0
		public static IEndFlowTemplate GetRootAsIEndFlowTemplate(ByteBuffer _bb, IEndFlowTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DAA9 RID: 187049 RVA: 0x0063FBBD File Offset: 0x0063DDBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DAAA RID: 187050 RVA: 0x0063FBCC File Offset: 0x0063DDCC
		public IEndFlowTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C33D RID: 49981
		// (get) Token: 0x0602DAAB RID: 187051 RVA: 0x0063FBDC File Offset: 0x0063DDDC
		public bool IsResetPosition
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602DAAC RID: 187052 RVA: 0x0063FC1B File Offset: 0x0063DE1B
		public static Offset<IEndFlowTemplate> CreateIEndFlowTemplate(FlatBufferBuilder builder, bool IsResetPosition = false)
		{
			builder.StartTable(1);
			IEndFlowTemplate.AddIsResetPosition(builder, IsResetPosition);
			return IEndFlowTemplate.EndIEndFlowTemplate(builder);
		}

		// Token: 0x0602DAAD RID: 187053 RVA: 0x0063FC31 File Offset: 0x0063DE31
		public static void StartIEndFlowTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DAAE RID: 187054 RVA: 0x0063FC3A File Offset: 0x0063DE3A
		public static void AddIsResetPosition(FlatBufferBuilder builder, bool isResetPosition)
		{
			builder.AddBool(0, isResetPosition, false);
		}

		// Token: 0x0602DAAF RID: 187055 RVA: 0x0063FC45 File Offset: 0x0063DE45
		public static Offset<IEndFlowTemplate> EndIEndFlowTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IEndFlowTemplate>(builder.EndTable());
		}

		// Token: 0x0602DAB0 RID: 187056 RVA: 0x0063FC54 File Offset: 0x0063DE54
		public IEndFlowTemplateT UnPack()
		{
			IEndFlowTemplateT endFlowTemplateT = new IEndFlowTemplateT();
			this.UnPackTo(endFlowTemplateT);
			return endFlowTemplateT;
		}

		// Token: 0x0602DAB1 RID: 187057 RVA: 0x0063FC6F File Offset: 0x0063DE6F
		public void UnPackTo(IEndFlowTemplateT _o)
		{
			_o.IsResetPosition = this.IsResetPosition;
		}

		// Token: 0x0602DAB2 RID: 187058 RVA: 0x0063FC80 File Offset: 0x0063DE80
		public static Offset<IEndFlowTemplate> Pack(FlatBufferBuilder builder, IEndFlowTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEndFlowTemplate>);
			}
			return IEndFlowTemplate.CreateIEndFlowTemplate(builder, _o.IsResetPosition);
		}

		// Token: 0x04010D5B RID: 68955
		private Table __p;
	}
}
