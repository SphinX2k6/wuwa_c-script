using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FB9 RID: 16313
	public struct IProgressBar : IFlatbufferObject
	{
		// Token: 0x170071EE RID: 29166
		// (get) Token: 0x06017532 RID: 95538 RVA: 0x0035CC02 File Offset: 0x0035AE02
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017533 RID: 95539 RVA: 0x0035CC0F File Offset: 0x0035AE0F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017534 RID: 95540 RVA: 0x0035CC18 File Offset: 0x0035AE18
		public static IProgressBar GetRootAsIProgressBar(ByteBuffer _bb)
		{
			return IProgressBar.GetRootAsIProgressBar(_bb, default(IProgressBar));
		}

		// Token: 0x06017535 RID: 95541 RVA: 0x0035CC34 File Offset: 0x0035AE34
		public static IProgressBar GetRootAsIProgressBar(ByteBuffer _bb, IProgressBar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017536 RID: 95542 RVA: 0x0035CC51 File Offset: 0x0035AE51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017537 RID: 95543 RVA: 0x0035CC60 File Offset: 0x0035AE60
		public IProgressBar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071EF RID: 29167
		// (get) Token: 0x06017538 RID: 95544 RVA: 0x0035CC70 File Offset: 0x0035AE70
		public EProgressBarStyle ProgressStyle
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProgressBarStyle.Default;
				}
				return (EProgressBarStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170071F0 RID: 29168
		// (get) Token: 0x06017539 RID: 95545 RVA: 0x0035CCAC File Offset: 0x0035AEAC
		public IProgressCalculate? ProgressCalculate
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IProgressCalculate?(default(IProgressCalculate).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601753A RID: 95546 RVA: 0x0035CD09 File Offset: 0x0035AF09
		public static Offset<IProgressBar> CreateIProgressBar(FlatBufferBuilder builder, EProgressBarStyle ProgressStyle = EProgressBarStyle.Default, Offset<IProgressCalculate> ProgressCalculateOffset = default(Offset<IProgressCalculate>))
		{
			builder.StartTable(2);
			IProgressBar.AddProgressCalculate(builder, ProgressCalculateOffset);
			IProgressBar.AddProgressStyle(builder, ProgressStyle);
			return IProgressBar.EndIProgressBar(builder);
		}

		// Token: 0x0601753B RID: 95547 RVA: 0x0035CD26 File Offset: 0x0035AF26
		public static void StartIProgressBar(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601753C RID: 95548 RVA: 0x0035CD2F File Offset: 0x0035AF2F
		public static void AddProgressStyle(FlatBufferBuilder builder, EProgressBarStyle progressStyle)
		{
			builder.AddByte(0, (byte)progressStyle, 0);
		}

		// Token: 0x0601753D RID: 95549 RVA: 0x0035CD3A File Offset: 0x0035AF3A
		public static void AddProgressCalculate(FlatBufferBuilder builder, Offset<IProgressCalculate> progressCalculateOffset)
		{
			builder.AddOffset(1, progressCalculateOffset.Value, 0);
		}

		// Token: 0x0601753E RID: 95550 RVA: 0x0035CD4A File Offset: 0x0035AF4A
		public static Offset<IProgressBar> EndIProgressBar(FlatBufferBuilder builder)
		{
			return new Offset<IProgressBar>(builder.EndTable());
		}

		// Token: 0x0601753F RID: 95551 RVA: 0x0035CD58 File Offset: 0x0035AF58
		public IProgressBarT UnPack()
		{
			IProgressBarT progressBarT = new IProgressBarT();
			this.UnPackTo(progressBarT);
			return progressBarT;
		}

		// Token: 0x06017540 RID: 95552 RVA: 0x0035CD74 File Offset: 0x0035AF74
		public void UnPackTo(IProgressBarT _o)
		{
			_o.ProgressStyle = this.ProgressStyle;
			_o.ProgressCalculate = ((this.ProgressCalculate != null) ? this.ProgressCalculate.Value.UnPack() : null);
		}

		// Token: 0x06017541 RID: 95553 RVA: 0x0035CDBC File Offset: 0x0035AFBC
		public static Offset<IProgressBar> Pack(FlatBufferBuilder builder, IProgressBarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProgressBar>);
			}
			Offset<IProgressCalculate> progressCalculateOffset = (_o.ProgressCalculate == null) ? default(Offset<IProgressCalculate>) : IProgressCalculate.Pack(builder, _o.ProgressCalculate);
			return IProgressBar.CreateIProgressBar(builder, _o.ProgressStyle, progressCalculateOffset);
		}

		// Token: 0x0400BA26 RID: 47654
		private Table __p;
	}
}
