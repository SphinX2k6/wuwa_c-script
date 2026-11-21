using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A95 RID: 27285
	public struct ICloseFlowTemplate : IFlatbufferObject
	{
		// Token: 0x1700C860 RID: 51296
		// (get) Token: 0x0602ED23 RID: 191779 RVA: 0x00661751 File Offset: 0x0065F951
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ED24 RID: 191780 RVA: 0x0066175E File Offset: 0x0065F95E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ED25 RID: 191781 RVA: 0x00661768 File Offset: 0x0065F968
		public static ICloseFlowTemplate GetRootAsICloseFlowTemplate(ByteBuffer _bb)
		{
			return ICloseFlowTemplate.GetRootAsICloseFlowTemplate(_bb, default(ICloseFlowTemplate));
		}

		// Token: 0x0602ED26 RID: 191782 RVA: 0x00661784 File Offset: 0x0065F984
		public static ICloseFlowTemplate GetRootAsICloseFlowTemplate(ByteBuffer _bb, ICloseFlowTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ED27 RID: 191783 RVA: 0x006617A1 File Offset: 0x0065F9A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ED28 RID: 191784 RVA: 0x006617B0 File Offset: 0x0065F9B0
		public ICloseFlowTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C861 RID: 51297
		// (get) Token: 0x0602ED29 RID: 191785 RVA: 0x006617C0 File Offset: 0x0065F9C0
		public bool IsResetPosition
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C862 RID: 51298
		// (get) Token: 0x0602ED2A RID: 191786 RVA: 0x00661800 File Offset: 0x0065FA00
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

		// Token: 0x1700C863 RID: 51299
		// (get) Token: 0x0602ED2B RID: 191787 RVA: 0x00661860 File Offset: 0x0065FA60
		public bool ExitFilmAspectRatio
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C864 RID: 51300
		// (get) Token: 0x0602ED2C RID: 191788 RVA: 0x006618A0 File Offset: 0x0065FAA0
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

		// Token: 0x0602ED2D RID: 191789 RVA: 0x006618DD File Offset: 0x0065FADD
		public static Offset<ICloseFlowTemplate> CreateICloseFlowTemplate(FlatBufferBuilder builder, bool IsResetPosition = false, Offset<IEndState> EndStateOffset = default(Offset<IEndState>), bool ExitFilmAspectRatio = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ICloseFlowTemplate.AddEndState(builder, EndStateOffset);
			ICloseFlowTemplate.AddNullMask(builder, NullMask);
			ICloseFlowTemplate.AddExitFilmAspectRatio(builder, ExitFilmAspectRatio);
			ICloseFlowTemplate.AddIsResetPosition(builder, IsResetPosition);
			return ICloseFlowTemplate.EndICloseFlowTemplate(builder);
		}

		// Token: 0x0602ED2E RID: 191790 RVA: 0x00661909 File Offset: 0x0065FB09
		public static void StartICloseFlowTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602ED2F RID: 191791 RVA: 0x00661912 File Offset: 0x0065FB12
		public static void AddIsResetPosition(FlatBufferBuilder builder, bool isResetPosition)
		{
			builder.AddBool(0, isResetPosition, false);
		}

		// Token: 0x0602ED30 RID: 191792 RVA: 0x0066191D File Offset: 0x0065FB1D
		public static void AddEndState(FlatBufferBuilder builder, Offset<IEndState> endStateOffset)
		{
			builder.AddOffset(1, endStateOffset.Value, 0);
		}

		// Token: 0x0602ED31 RID: 191793 RVA: 0x0066192D File Offset: 0x0065FB2D
		public static void AddExitFilmAspectRatio(FlatBufferBuilder builder, bool exitFilmAspectRatio)
		{
			builder.AddBool(2, exitFilmAspectRatio, false);
		}

		// Token: 0x0602ED32 RID: 191794 RVA: 0x00661938 File Offset: 0x0065FB38
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602ED33 RID: 191795 RVA: 0x00661943 File Offset: 0x0065FB43
		public static Offset<ICloseFlowTemplate> EndICloseFlowTemplate(FlatBufferBuilder builder)
		{
			return new Offset<ICloseFlowTemplate>(builder.EndTable());
		}

		// Token: 0x0602ED34 RID: 191796 RVA: 0x00661950 File Offset: 0x0065FB50
		public ICloseFlowTemplateT UnPack()
		{
			ICloseFlowTemplateT closeFlowTemplateT = new ICloseFlowTemplateT();
			this.UnPackTo(closeFlowTemplateT);
			return closeFlowTemplateT;
		}

		// Token: 0x0602ED35 RID: 191797 RVA: 0x0066196C File Offset: 0x0065FB6C
		public void UnPackTo(ICloseFlowTemplateT _o)
		{
			_o.IsResetPosition = this.IsResetPosition;
			_o.EndState = ((this.EndState != null) ? this.EndState.Value.UnPack() : null);
			_o.ExitFilmAspectRatio = this.ExitFilmAspectRatio;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602ED36 RID: 191798 RVA: 0x006619CC File Offset: 0x0065FBCC
		public static Offset<ICloseFlowTemplate> Pack(FlatBufferBuilder builder, ICloseFlowTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseFlowTemplate>);
			}
			Offset<IEndState> endStateOffset = (_o.EndState == null) ? default(Offset<IEndState>) : IEndState.Pack(builder, _o.EndState);
			return ICloseFlowTemplate.CreateICloseFlowTemplate(builder, _o.IsResetPosition, endStateOffset, _o.ExitFilmAspectRatio, _o.NullMask);
		}

		// Token: 0x04011829 RID: 71721
		private Table __p;
	}
}
