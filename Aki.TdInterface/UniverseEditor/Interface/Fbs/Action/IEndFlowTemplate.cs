using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D1C RID: 27932
	public struct IEndFlowTemplate : IFlatbufferObject
	{
		// Token: 0x1700CCED RID: 52461
		// (get) Token: 0x060302C2 RID: 197314 RVA: 0x0068CE24 File Offset: 0x0068B024
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060302C3 RID: 197315 RVA: 0x0068CE31 File Offset: 0x0068B031
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060302C4 RID: 197316 RVA: 0x0068CE38 File Offset: 0x0068B038
		public static IEndFlowTemplate GetRootAsIEndFlowTemplate(ByteBuffer _bb)
		{
			return IEndFlowTemplate.GetRootAsIEndFlowTemplate(_bb, default(IEndFlowTemplate));
		}

		// Token: 0x060302C5 RID: 197317 RVA: 0x0068CE54 File Offset: 0x0068B054
		public static IEndFlowTemplate GetRootAsIEndFlowTemplate(ByteBuffer _bb, IEndFlowTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060302C6 RID: 197318 RVA: 0x0068CE71 File Offset: 0x0068B071
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060302C7 RID: 197319 RVA: 0x0068CE80 File Offset: 0x0068B080
		public IEndFlowTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCEE RID: 52462
		// (get) Token: 0x060302C8 RID: 197320 RVA: 0x0068CE90 File Offset: 0x0068B090
		public bool IsResetPosition
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060302C9 RID: 197321 RVA: 0x0068CECF File Offset: 0x0068B0CF
		public static Offset<IEndFlowTemplate> CreateIEndFlowTemplate(FlatBufferBuilder builder, bool IsResetPosition = false)
		{
			builder.StartTable(1);
			IEndFlowTemplate.AddIsResetPosition(builder, IsResetPosition);
			return IEndFlowTemplate.EndIEndFlowTemplate(builder);
		}

		// Token: 0x060302CA RID: 197322 RVA: 0x0068CEE5 File Offset: 0x0068B0E5
		public static void StartIEndFlowTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060302CB RID: 197323 RVA: 0x0068CEEE File Offset: 0x0068B0EE
		public static void AddIsResetPosition(FlatBufferBuilder builder, bool isResetPosition)
		{
			builder.AddBool(0, isResetPosition, false);
		}

		// Token: 0x060302CC RID: 197324 RVA: 0x0068CEF9 File Offset: 0x0068B0F9
		public static Offset<IEndFlowTemplate> EndIEndFlowTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IEndFlowTemplate>(builder.EndTable());
		}

		// Token: 0x060302CD RID: 197325 RVA: 0x0068CF08 File Offset: 0x0068B108
		public IEndFlowTemplateT UnPack()
		{
			IEndFlowTemplateT endFlowTemplateT = new IEndFlowTemplateT();
			this.UnPackTo(endFlowTemplateT);
			return endFlowTemplateT;
		}

		// Token: 0x060302CE RID: 197326 RVA: 0x0068CF23 File Offset: 0x0068B123
		public void UnPackTo(IEndFlowTemplateT _o)
		{
			_o.IsResetPosition = this.IsResetPosition;
		}

		// Token: 0x060302CF RID: 197327 RVA: 0x0068CF34 File Offset: 0x0068B134
		public static Offset<IEndFlowTemplate> Pack(FlatBufferBuilder builder, IEndFlowTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEndFlowTemplate>);
			}
			return IEndFlowTemplate.CreateIEndFlowTemplate(builder, _o.IsResetPosition);
		}

		// Token: 0x04011B81 RID: 72577
		private Table __p;
	}
}
