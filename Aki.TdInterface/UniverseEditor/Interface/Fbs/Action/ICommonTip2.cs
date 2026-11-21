using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AEB RID: 27371
	public struct ICommonTip2 : IFlatbufferObject
	{
		// Token: 0x1700C905 RID: 51461
		// (get) Token: 0x0602F0D2 RID: 192722 RVA: 0x0066B584 File Offset: 0x00669784
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F0D3 RID: 192723 RVA: 0x0066B591 File Offset: 0x00669791
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F0D4 RID: 192724 RVA: 0x0066B598 File Offset: 0x00669798
		public static ICommonTip2 GetRootAsICommonTip2(ByteBuffer _bb)
		{
			return ICommonTip2.GetRootAsICommonTip2(_bb, default(ICommonTip2));
		}

		// Token: 0x0602F0D5 RID: 192725 RVA: 0x0066B5B4 File Offset: 0x006697B4
		public static ICommonTip2 GetRootAsICommonTip2(ByteBuffer _bb, ICommonTip2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F0D6 RID: 192726 RVA: 0x0066B5D1 File Offset: 0x006697D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F0D7 RID: 192727 RVA: 0x0066B5E0 File Offset: 0x006697E0
		public ICommonTip2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C906 RID: 51462
		// (get) Token: 0x0602F0D8 RID: 192728 RVA: 0x0066B5F0 File Offset: 0x006697F0
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

		// Token: 0x0602F0D9 RID: 192729 RVA: 0x0066B64D File Offset: 0x0066984D
		public static Offset<ICommonTip2> CreateICommonTip2(FlatBufferBuilder builder, Offset<ICommonTip2PrepareCountdown> TipOptionOffset = default(Offset<ICommonTip2PrepareCountdown>))
		{
			builder.StartTable(1);
			ICommonTip2.AddTipOption(builder, TipOptionOffset);
			return ICommonTip2.EndICommonTip2(builder);
		}

		// Token: 0x0602F0DA RID: 192730 RVA: 0x0066B663 File Offset: 0x00669863
		public static void StartICommonTip2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F0DB RID: 192731 RVA: 0x0066B66C File Offset: 0x0066986C
		public static void AddTipOption(FlatBufferBuilder builder, Offset<ICommonTip2PrepareCountdown> tipOptionOffset)
		{
			builder.AddOffset(0, tipOptionOffset.Value, 0);
		}

		// Token: 0x0602F0DC RID: 192732 RVA: 0x0066B67C File Offset: 0x0066987C
		public static Offset<ICommonTip2> EndICommonTip2(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTip2>(builder.EndTable());
		}

		// Token: 0x0602F0DD RID: 192733 RVA: 0x0066B68C File Offset: 0x0066988C
		public ICommonTip2T UnPack()
		{
			ICommonTip2T commonTip2T = new ICommonTip2T();
			this.UnPackTo(commonTip2T);
			return commonTip2T;
		}

		// Token: 0x0602F0DE RID: 192734 RVA: 0x0066B6A8 File Offset: 0x006698A8
		public void UnPackTo(ICommonTip2T _o)
		{
			_o.TipOption = ((this.TipOption != null) ? this.TipOption.Value.UnPack() : null);
		}

		// Token: 0x0602F0DF RID: 192735 RVA: 0x0066B6E4 File Offset: 0x006698E4
		public static Offset<ICommonTip2> Pack(FlatBufferBuilder builder, ICommonTip2T _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTip2>);
			}
			Offset<ICommonTip2PrepareCountdown> tipOptionOffset = (_o.TipOption == null) ? default(Offset<ICommonTip2PrepareCountdown>) : ICommonTip2PrepareCountdown.Pack(builder, _o.TipOption);
			return ICommonTip2.CreateICommonTip2(builder, tipOptionOffset);
		}

		// Token: 0x04011898 RID: 71832
		private Table __p;
	}
}
