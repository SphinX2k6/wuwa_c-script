using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200561A RID: 22042
	public struct INpcBumpShow : IFlatbufferObject
	{
		// Token: 0x1700A318 RID: 41752
		// (get) Token: 0x0602494B RID: 149835 RVA: 0x0050C1A0 File Offset: 0x0050A3A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602494C RID: 149836 RVA: 0x0050C1AD File Offset: 0x0050A3AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602494D RID: 149837 RVA: 0x0050C1B4 File Offset: 0x0050A3B4
		public static INpcBumpShow GetRootAsINpcBumpShow(ByteBuffer _bb)
		{
			return INpcBumpShow.GetRootAsINpcBumpShow(_bb, default(INpcBumpShow));
		}

		// Token: 0x0602494E RID: 149838 RVA: 0x0050C1D0 File Offset: 0x0050A3D0
		public static INpcBumpShow GetRootAsINpcBumpShow(ByteBuffer _bb, INpcBumpShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602494F RID: 149839 RVA: 0x0050C1ED File Offset: 0x0050A3ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024950 RID: 149840 RVA: 0x0050C1FC File Offset: 0x0050A3FC
		public INpcBumpShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A319 RID: 41753
		// (get) Token: 0x06024951 RID: 149841 RVA: 0x0050C20C File Offset: 0x0050A40C
		public INpcPerformBubble? BumpBubble
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new INpcPerformBubble?(default(INpcPerformBubble).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024952 RID: 149842 RVA: 0x0050C269 File Offset: 0x0050A469
		public static Offset<INpcBumpShow> CreateINpcBumpShow(FlatBufferBuilder builder, Offset<INpcPerformBubble> BumpBubbleOffset = default(Offset<INpcPerformBubble>))
		{
			builder.StartTable(1);
			INpcBumpShow.AddBumpBubble(builder, BumpBubbleOffset);
			return INpcBumpShow.EndINpcBumpShow(builder);
		}

		// Token: 0x06024953 RID: 149843 RVA: 0x0050C27F File Offset: 0x0050A47F
		public static void StartINpcBumpShow(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024954 RID: 149844 RVA: 0x0050C288 File Offset: 0x0050A488
		public static void AddBumpBubble(FlatBufferBuilder builder, Offset<INpcPerformBubble> bumpBubbleOffset)
		{
			builder.AddOffset(0, bumpBubbleOffset.Value, 0);
		}

		// Token: 0x06024955 RID: 149845 RVA: 0x0050C298 File Offset: 0x0050A498
		public static Offset<INpcBumpShow> EndINpcBumpShow(FlatBufferBuilder builder)
		{
			return new Offset<INpcBumpShow>(builder.EndTable());
		}

		// Token: 0x06024956 RID: 149846 RVA: 0x0050C2A8 File Offset: 0x0050A4A8
		public INpcBumpShowT UnPack()
		{
			INpcBumpShowT npcBumpShowT = new INpcBumpShowT();
			this.UnPackTo(npcBumpShowT);
			return npcBumpShowT;
		}

		// Token: 0x06024957 RID: 149847 RVA: 0x0050C2C4 File Offset: 0x0050A4C4
		public void UnPackTo(INpcBumpShowT _o)
		{
			_o.BumpBubble = ((this.BumpBubble != null) ? this.BumpBubble.Value.UnPack() : null);
		}

		// Token: 0x06024958 RID: 149848 RVA: 0x0050C300 File Offset: 0x0050A500
		public static Offset<INpcBumpShow> Pack(FlatBufferBuilder builder, INpcBumpShowT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcBumpShow>);
			}
			Offset<INpcPerformBubble> bumpBubbleOffset = (_o.BumpBubble == null) ? default(Offset<INpcPerformBubble>) : INpcPerformBubble.Pack(builder, _o.BumpBubble);
			return INpcBumpShow.CreateINpcBumpShow(builder, bumpBubbleOffset);
		}

		// Token: 0x0400E99E RID: 59806
		private Table __p;
	}
}
