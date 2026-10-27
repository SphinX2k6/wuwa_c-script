using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C7 RID: 26823
	public struct IHandInItemViewStyle : IFlatbufferObject
	{
		// Token: 0x1700C70C RID: 50956
		// (get) Token: 0x0602EC8C RID: 191628 RVA: 0x0066293C File Offset: 0x00660B3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EC8D RID: 191629 RVA: 0x00662949 File Offset: 0x00660B49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EC8E RID: 191630 RVA: 0x00662950 File Offset: 0x00660B50
		public static IHandInItemViewStyle GetRootAsIHandInItemViewStyle(ByteBuffer _bb)
		{
			return IHandInItemViewStyle.GetRootAsIHandInItemViewStyle(_bb, default(IHandInItemViewStyle));
		}

		// Token: 0x0602EC8F RID: 191631 RVA: 0x0066296C File Offset: 0x00660B6C
		public static IHandInItemViewStyle GetRootAsIHandInItemViewStyle(ByteBuffer _bb, IHandInItemViewStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EC90 RID: 191632 RVA: 0x00662989 File Offset: 0x00660B89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EC91 RID: 191633 RVA: 0x00662998 File Offset: 0x00660B98
		public IHandInItemViewStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C70D RID: 50957
		// (get) Token: 0x0602EC92 RID: 191634 RVA: 0x006629A8 File Offset: 0x00660BA8
		public EDeliverItemProbeCollectibleViewStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDeliverItemProbeCollectibleViewStyle.HandInItemStyle;
				}
				return (EDeliverItemProbeCollectibleViewStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EC93 RID: 191635 RVA: 0x006629E4 File Offset: 0x00660BE4
		public static Offset<IHandInItemViewStyle> CreateIHandInItemViewStyle(FlatBufferBuilder builder, EDeliverItemProbeCollectibleViewStyle Type = EDeliverItemProbeCollectibleViewStyle.HandInItemStyle)
		{
			builder.StartTable(1);
			IHandInItemViewStyle.AddType(builder, Type);
			return IHandInItemViewStyle.EndIHandInItemViewStyle(builder);
		}

		// Token: 0x0602EC94 RID: 191636 RVA: 0x006629FA File Offset: 0x00660BFA
		public static void StartIHandInItemViewStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EC95 RID: 191637 RVA: 0x00662A03 File Offset: 0x00660C03
		public static void AddType(FlatBufferBuilder builder, EDeliverItemProbeCollectibleViewStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EC96 RID: 191638 RVA: 0x00662A0E File Offset: 0x00660C0E
		public static Offset<IHandInItemViewStyle> EndIHandInItemViewStyle(FlatBufferBuilder builder)
		{
			return new Offset<IHandInItemViewStyle>(builder.EndTable());
		}

		// Token: 0x0602EC97 RID: 191639 RVA: 0x00662A1C File Offset: 0x00660C1C
		public IHandInItemViewStyleT UnPack()
		{
			IHandInItemViewStyleT handInItemViewStyleT = new IHandInItemViewStyleT();
			this.UnPackTo(handInItemViewStyleT);
			return handInItemViewStyleT;
		}

		// Token: 0x0602EC98 RID: 191640 RVA: 0x00662A37 File Offset: 0x00660C37
		public void UnPackTo(IHandInItemViewStyleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EC99 RID: 191641 RVA: 0x00662A48 File Offset: 0x00660C48
		public static Offset<IHandInItemViewStyle> Pack(FlatBufferBuilder builder, IHandInItemViewStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHandInItemViewStyle>);
			}
			return IHandInItemViewStyle.CreateIHandInItemViewStyle(builder, _o.Type);
		}

		// Token: 0x04011025 RID: 69669
		private Table __p;
	}
}
