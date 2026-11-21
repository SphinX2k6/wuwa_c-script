using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043FA RID: 17402
	public struct IProgressBar : IFlatbufferObject
	{
		// Token: 0x170077EC RID: 30700
		// (get) Token: 0x06018BC1 RID: 101313 RVA: 0x0038681A File Offset: 0x00384A1A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018BC2 RID: 101314 RVA: 0x00386827 File Offset: 0x00384A27
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018BC3 RID: 101315 RVA: 0x00386830 File Offset: 0x00384A30
		public static IProgressBar GetRootAsIProgressBar(ByteBuffer _bb)
		{
			return IProgressBar.GetRootAsIProgressBar(_bb, default(IProgressBar));
		}

		// Token: 0x06018BC4 RID: 101316 RVA: 0x0038684C File Offset: 0x00384A4C
		public static IProgressBar GetRootAsIProgressBar(ByteBuffer _bb, IProgressBar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018BC5 RID: 101317 RVA: 0x00386869 File Offset: 0x00384A69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018BC6 RID: 101318 RVA: 0x00386878 File Offset: 0x00384A78
		public IProgressBar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077ED RID: 30701
		// (get) Token: 0x06018BC7 RID: 101319 RVA: 0x00386888 File Offset: 0x00384A88
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

		// Token: 0x170077EE RID: 30702
		// (get) Token: 0x06018BC8 RID: 101320 RVA: 0x003868C4 File Offset: 0x00384AC4
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

		// Token: 0x06018BC9 RID: 101321 RVA: 0x00386921 File Offset: 0x00384B21
		public static Offset<IProgressBar> CreateIProgressBar(FlatBufferBuilder builder, EProgressBarStyle ProgressStyle = EProgressBarStyle.Default, Offset<IProgressCalculate> ProgressCalculateOffset = default(Offset<IProgressCalculate>))
		{
			builder.StartTable(2);
			IProgressBar.AddProgressCalculate(builder, ProgressCalculateOffset);
			IProgressBar.AddProgressStyle(builder, ProgressStyle);
			return IProgressBar.EndIProgressBar(builder);
		}

		// Token: 0x06018BCA RID: 101322 RVA: 0x0038693E File Offset: 0x00384B3E
		public static void StartIProgressBar(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018BCB RID: 101323 RVA: 0x00386947 File Offset: 0x00384B47
		public static void AddProgressStyle(FlatBufferBuilder builder, EProgressBarStyle progressStyle)
		{
			builder.AddByte(0, (byte)progressStyle, 0);
		}

		// Token: 0x06018BCC RID: 101324 RVA: 0x00386952 File Offset: 0x00384B52
		public static void AddProgressCalculate(FlatBufferBuilder builder, Offset<IProgressCalculate> progressCalculateOffset)
		{
			builder.AddOffset(1, progressCalculateOffset.Value, 0);
		}

		// Token: 0x06018BCD RID: 101325 RVA: 0x00386962 File Offset: 0x00384B62
		public static Offset<IProgressBar> EndIProgressBar(FlatBufferBuilder builder)
		{
			return new Offset<IProgressBar>(builder.EndTable());
		}

		// Token: 0x06018BCE RID: 101326 RVA: 0x00386970 File Offset: 0x00384B70
		public IProgressBarT UnPack()
		{
			IProgressBarT progressBarT = new IProgressBarT();
			this.UnPackTo(progressBarT);
			return progressBarT;
		}

		// Token: 0x06018BCF RID: 101327 RVA: 0x0038698C File Offset: 0x00384B8C
		public void UnPackTo(IProgressBarT _o)
		{
			_o.ProgressStyle = this.ProgressStyle;
			_o.ProgressCalculate = ((this.ProgressCalculate != null) ? this.ProgressCalculate.Value.UnPack() : null);
		}

		// Token: 0x06018BD0 RID: 101328 RVA: 0x003869D4 File Offset: 0x00384BD4
		public static Offset<IProgressBar> Pack(FlatBufferBuilder builder, IProgressBarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProgressBar>);
			}
			Offset<IProgressCalculate> progressCalculateOffset = (_o.ProgressCalculate == null) ? default(Offset<IProgressCalculate>) : IProgressCalculate.Pack(builder, _o.ProgressCalculate);
			return IProgressBar.CreateIProgressBar(builder, _o.ProgressStyle, progressCalculateOffset);
		}

		// Token: 0x0400C40B RID: 50187
		private Table __p;
	}
}
