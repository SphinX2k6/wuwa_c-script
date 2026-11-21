using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007064 RID: 28772
	public struct IInvoke : IFlatbufferObject
	{
		// Token: 0x1700D2BA RID: 53946
		// (get) Token: 0x06031E45 RID: 204357 RVA: 0x006C0DCD File Offset: 0x006BEFCD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031E46 RID: 204358 RVA: 0x006C0DDA File Offset: 0x006BEFDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031E47 RID: 204359 RVA: 0x006C0DE4 File Offset: 0x006BEFE4
		public static IInvoke GetRootAsIInvoke(ByteBuffer _bb)
		{
			return IInvoke.GetRootAsIInvoke(_bb, default(IInvoke));
		}

		// Token: 0x06031E48 RID: 204360 RVA: 0x006C0E00 File Offset: 0x006BF000
		public static IInvoke GetRootAsIInvoke(ByteBuffer _bb, IInvoke obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031E49 RID: 204361 RVA: 0x006C0E1D File Offset: 0x006BF01D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031E4A RID: 204362 RVA: 0x006C0E2C File Offset: 0x006BF02C
		public IInvoke __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2BB RID: 53947
		// (get) Token: 0x06031E4B RID: 204363 RVA: 0x006C0E3C File Offset: 0x006BF03C
		public int Who
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D2BC RID: 53948
		// (get) Token: 0x06031E4C RID: 204364 RVA: 0x006C0E78 File Offset: 0x006BF078
		public IActionInfo? ActionInfo
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06031E4D RID: 204365 RVA: 0x006C0ED5 File Offset: 0x006BF0D5
		public static Offset<IInvoke> CreateIInvoke(FlatBufferBuilder builder, int Who = 0, Offset<IActionInfo> ActionInfoOffset = default(Offset<IActionInfo>))
		{
			builder.StartTable(2);
			IInvoke.AddActionInfo(builder, ActionInfoOffset);
			IInvoke.AddWho(builder, Who);
			return IInvoke.EndIInvoke(builder);
		}

		// Token: 0x06031E4E RID: 204366 RVA: 0x006C0EF2 File Offset: 0x006BF0F2
		public static void StartIInvoke(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031E4F RID: 204367 RVA: 0x006C0EFB File Offset: 0x006BF0FB
		public static void AddWho(FlatBufferBuilder builder, int who)
		{
			builder.AddInt(0, who, 0);
		}

		// Token: 0x06031E50 RID: 204368 RVA: 0x006C0F06 File Offset: 0x006BF106
		public static void AddActionInfo(FlatBufferBuilder builder, Offset<IActionInfo> actionInfoOffset)
		{
			builder.AddOffset(1, actionInfoOffset.Value, 0);
		}

		// Token: 0x06031E51 RID: 204369 RVA: 0x006C0F16 File Offset: 0x006BF116
		public static Offset<IInvoke> EndIInvoke(FlatBufferBuilder builder)
		{
			return new Offset<IInvoke>(builder.EndTable());
		}

		// Token: 0x06031E52 RID: 204370 RVA: 0x006C0F24 File Offset: 0x006BF124
		public IInvokeT UnPack()
		{
			IInvokeT invokeT = new IInvokeT();
			this.UnPackTo(invokeT);
			return invokeT;
		}

		// Token: 0x06031E53 RID: 204371 RVA: 0x006C0F40 File Offset: 0x006BF140
		public void UnPackTo(IInvokeT _o)
		{
			_o.Who = this.Who;
			_o.ActionInfo = ((this.ActionInfo != null) ? this.ActionInfo.Value.UnPack() : null);
		}

		// Token: 0x06031E54 RID: 204372 RVA: 0x006C0F88 File Offset: 0x006BF188
		public static Offset<IInvoke> Pack(FlatBufferBuilder builder, IInvokeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInvoke>);
			}
			Offset<IActionInfo> actionInfoOffset = (_o.ActionInfo == null) ? default(Offset<IActionInfo>) : IActionInfo.Pack(builder, _o.ActionInfo);
			return IInvoke.CreateIInvoke(builder, _o.Who, actionInfoOffset);
		}

		// Token: 0x04011FCC RID: 73676
		private Table __p;
	}
}
