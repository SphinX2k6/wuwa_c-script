using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006480 RID: 25728
	public struct ICommonTip2 : IFlatbufferObject
	{
		// Token: 0x1700BF78 RID: 49016
		// (get) Token: 0x0602C958 RID: 182616 RVA: 0x0061F9B0 File Offset: 0x0061DBB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C959 RID: 182617 RVA: 0x0061F9BD File Offset: 0x0061DBBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C95A RID: 182618 RVA: 0x0061F9C4 File Offset: 0x0061DBC4
		public static ICommonTip2 GetRootAsICommonTip2(ByteBuffer _bb)
		{
			return ICommonTip2.GetRootAsICommonTip2(_bb, default(ICommonTip2));
		}

		// Token: 0x0602C95B RID: 182619 RVA: 0x0061F9E0 File Offset: 0x0061DBE0
		public static ICommonTip2 GetRootAsICommonTip2(ByteBuffer _bb, ICommonTip2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C95C RID: 182620 RVA: 0x0061F9FD File Offset: 0x0061DBFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C95D RID: 182621 RVA: 0x0061FA0C File Offset: 0x0061DC0C
		public ICommonTip2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF79 RID: 49017
		// (get) Token: 0x0602C95E RID: 182622 RVA: 0x0061FA1C File Offset: 0x0061DC1C
		public ICommonTip2PrepareCountdown? TipOption
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ICommonTip2PrepareCountdown?(default(ICommonTip2PrepareCountdown).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602C95F RID: 182623 RVA: 0x0061FA79 File Offset: 0x0061DC79
		public static Offset<ICommonTip2> CreateICommonTip2(FlatBufferBuilder builder, Offset<ICommonTip2PrepareCountdown> TipOptionOffset = default(Offset<ICommonTip2PrepareCountdown>))
		{
			builder.StartTable(1);
			ICommonTip2.AddTipOption(builder, TipOptionOffset);
			return ICommonTip2.EndICommonTip2(builder);
		}

		// Token: 0x0602C960 RID: 182624 RVA: 0x0061FA8F File Offset: 0x0061DC8F
		public static void StartICommonTip2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C961 RID: 182625 RVA: 0x0061FA98 File Offset: 0x0061DC98
		public static void AddTipOption(FlatBufferBuilder builder, Offset<ICommonTip2PrepareCountdown> tipOptionOffset)
		{
			builder.AddOffset(0, tipOptionOffset.Value, 0);
		}

		// Token: 0x0602C962 RID: 182626 RVA: 0x0061FAA8 File Offset: 0x0061DCA8
		public static Offset<ICommonTip2> EndICommonTip2(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTip2>(builder.EndTable());
		}

		// Token: 0x0602C963 RID: 182627 RVA: 0x0061FAB8 File Offset: 0x0061DCB8
		public ICommonTip2T UnPack()
		{
			ICommonTip2T commonTip2T = new ICommonTip2T();
			this.UnPackTo(commonTip2T);
			return commonTip2T;
		}

		// Token: 0x0602C964 RID: 182628 RVA: 0x0061FAD4 File Offset: 0x0061DCD4
		public void UnPackTo(ICommonTip2T _o)
		{
			_o.TipOption = ((this.TipOption != null) ? this.TipOption.Value.UnPack() : null);
		}

		// Token: 0x0602C965 RID: 182629 RVA: 0x0061FB10 File Offset: 0x0061DD10
		public static Offset<ICommonTip2> Pack(FlatBufferBuilder builder, ICommonTip2T _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTip2>);
			}
			Offset<ICommonTip2PrepareCountdown> tipOptionOffset = (_o.TipOption == null) ? default(Offset<ICommonTip2PrepareCountdown>) : ICommonTip2PrepareCountdown.Pack(builder, _o.TipOption);
			return ICommonTip2.CreateICommonTip2(builder, tipOptionOffset);
		}

		// Token: 0x04010A87 RID: 68231
		private Table __p;
	}
}
