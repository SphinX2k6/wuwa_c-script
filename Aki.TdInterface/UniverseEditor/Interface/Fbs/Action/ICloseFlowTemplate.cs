using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200641B RID: 25627
	public struct ICloseFlowTemplate : IFlatbufferObject
	{
		// Token: 0x1700BECE RID: 48846
		// (get) Token: 0x0602C575 RID: 181621 RVA: 0x00615C3E File Offset: 0x00613E3E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C576 RID: 181622 RVA: 0x00615C4B File Offset: 0x00613E4B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C577 RID: 181623 RVA: 0x00615C54 File Offset: 0x00613E54
		public static ICloseFlowTemplate GetRootAsICloseFlowTemplate(ByteBuffer _bb)
		{
			return ICloseFlowTemplate.GetRootAsICloseFlowTemplate(_bb, default(ICloseFlowTemplate));
		}

		// Token: 0x0602C578 RID: 181624 RVA: 0x00615C70 File Offset: 0x00613E70
		public static ICloseFlowTemplate GetRootAsICloseFlowTemplate(ByteBuffer _bb, ICloseFlowTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C579 RID: 181625 RVA: 0x00615C8D File Offset: 0x00613E8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C57A RID: 181626 RVA: 0x00615C9C File Offset: 0x00613E9C
		public ICloseFlowTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BECF RID: 48847
		// (get) Token: 0x0602C57B RID: 181627 RVA: 0x00615CAC File Offset: 0x00613EAC
		public bool IsResetPosition
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BED0 RID: 48848
		// (get) Token: 0x0602C57C RID: 181628 RVA: 0x00615CEC File Offset: 0x00613EEC
		public IEndState? EndState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IEndState?(default(IEndState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BED1 RID: 48849
		// (get) Token: 0x0602C57D RID: 181629 RVA: 0x00615D4C File Offset: 0x00613F4C
		public bool ExitFilmAspectRatio
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BED2 RID: 48850
		// (get) Token: 0x0602C57E RID: 181630 RVA: 0x00615D8C File Offset: 0x00613F8C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C57F RID: 181631 RVA: 0x00615DC9 File Offset: 0x00613FC9
		public static Offset<ICloseFlowTemplate> CreateICloseFlowTemplate(FlatBufferBuilder builder, bool IsResetPosition = false, Offset<IEndState> EndStateOffset = default(Offset<IEndState>), bool ExitFilmAspectRatio = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ICloseFlowTemplate.AddEndState(builder, EndStateOffset);
			ICloseFlowTemplate.AddNullMask(builder, NullMask);
			ICloseFlowTemplate.AddExitFilmAspectRatio(builder, ExitFilmAspectRatio);
			ICloseFlowTemplate.AddIsResetPosition(builder, IsResetPosition);
			return ICloseFlowTemplate.EndICloseFlowTemplate(builder);
		}

		// Token: 0x0602C580 RID: 181632 RVA: 0x00615DF5 File Offset: 0x00613FF5
		public static void StartICloseFlowTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602C581 RID: 181633 RVA: 0x00615DFE File Offset: 0x00613FFE
		public static void AddIsResetPosition(FlatBufferBuilder builder, bool isResetPosition)
		{
			builder.AddBool(0, isResetPosition, false);
		}

		// Token: 0x0602C582 RID: 181634 RVA: 0x00615E09 File Offset: 0x00614009
		public static void AddEndState(FlatBufferBuilder builder, Offset<IEndState> endStateOffset)
		{
			builder.AddOffset(1, endStateOffset.Value, 0);
		}

		// Token: 0x0602C583 RID: 181635 RVA: 0x00615E19 File Offset: 0x00614019
		public static void AddExitFilmAspectRatio(FlatBufferBuilder builder, bool exitFilmAspectRatio)
		{
			builder.AddBool(2, exitFilmAspectRatio, false);
		}

		// Token: 0x0602C584 RID: 181636 RVA: 0x00615E24 File Offset: 0x00614024
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602C585 RID: 181637 RVA: 0x00615E2F File Offset: 0x0061402F
		public static Offset<ICloseFlowTemplate> EndICloseFlowTemplate(FlatBufferBuilder builder)
		{
			return new Offset<ICloseFlowTemplate>(builder.EndTable());
		}

		// Token: 0x0602C586 RID: 181638 RVA: 0x00615E3C File Offset: 0x0061403C
		public ICloseFlowTemplateT UnPack()
		{
			ICloseFlowTemplateT closeFlowTemplateT = new ICloseFlowTemplateT();
			this.UnPackTo(closeFlowTemplateT);
			return closeFlowTemplateT;
		}

		// Token: 0x0602C587 RID: 181639 RVA: 0x00615E58 File Offset: 0x00614058
		public void UnPackTo(ICloseFlowTemplateT _o)
		{
			_o.IsResetPosition = this.IsResetPosition;
			_o.EndState = ((this.EndState != null) ? this.EndState.Value.UnPack() : null);
			_o.ExitFilmAspectRatio = this.ExitFilmAspectRatio;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C588 RID: 181640 RVA: 0x00615EB8 File Offset: 0x006140B8
		public static Offset<ICloseFlowTemplate> Pack(FlatBufferBuilder builder, ICloseFlowTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseFlowTemplate>);
			}
			Offset<IEndState> endStateOffset = (_o.EndState == null) ? default(Offset<IEndState>) : IEndState.Pack(builder, _o.EndState);
			return ICloseFlowTemplate.CreateICloseFlowTemplate(builder, _o.IsResetPosition, endStateOffset, _o.ExitFilmAspectRatio, _o.NullMask);
		}

		// Token: 0x04010A08 RID: 68104
		private Table __p;
	}
}
