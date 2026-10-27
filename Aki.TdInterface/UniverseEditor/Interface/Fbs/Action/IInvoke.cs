using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069B1 RID: 27057
	public struct IInvoke : IFlatbufferObject
	{
		// Token: 0x1700C8B5 RID: 51381
		// (get) Token: 0x0602F469 RID: 193641 RVA: 0x006706C9 File Offset: 0x0066E8C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F46A RID: 193642 RVA: 0x006706D6 File Offset: 0x0066E8D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F46B RID: 193643 RVA: 0x006706E0 File Offset: 0x0066E8E0
		public static IInvoke GetRootAsIInvoke(ByteBuffer _bb)
		{
			return IInvoke.GetRootAsIInvoke(_bb, default(IInvoke));
		}

		// Token: 0x0602F46C RID: 193644 RVA: 0x006706FC File Offset: 0x0066E8FC
		public static IInvoke GetRootAsIInvoke(ByteBuffer _bb, IInvoke obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F46D RID: 193645 RVA: 0x00670719 File Offset: 0x0066E919
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F46E RID: 193646 RVA: 0x00670728 File Offset: 0x0066E928
		public IInvoke __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8B6 RID: 51382
		// (get) Token: 0x0602F46F RID: 193647 RVA: 0x00670738 File Offset: 0x0066E938
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

		// Token: 0x1700C8B7 RID: 51383
		// (get) Token: 0x0602F470 RID: 193648 RVA: 0x00670774 File Offset: 0x0066E974
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

		// Token: 0x0602F471 RID: 193649 RVA: 0x006707D1 File Offset: 0x0066E9D1
		public static Offset<IInvoke> CreateIInvoke(FlatBufferBuilder builder, int Who = 0, Offset<IActionInfo> ActionInfoOffset = default(Offset<IActionInfo>))
		{
			builder.StartTable(2);
			IInvoke.AddActionInfo(builder, ActionInfoOffset);
			IInvoke.AddWho(builder, Who);
			return IInvoke.EndIInvoke(builder);
		}

		// Token: 0x0602F472 RID: 193650 RVA: 0x006707EE File Offset: 0x0066E9EE
		public static void StartIInvoke(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F473 RID: 193651 RVA: 0x006707F7 File Offset: 0x0066E9F7
		public static void AddWho(FlatBufferBuilder builder, int who)
		{
			builder.AddInt(0, who, 0);
		}

		// Token: 0x0602F474 RID: 193652 RVA: 0x00670802 File Offset: 0x0066EA02
		public static void AddActionInfo(FlatBufferBuilder builder, Offset<IActionInfo> actionInfoOffset)
		{
			builder.AddOffset(1, actionInfoOffset.Value, 0);
		}

		// Token: 0x0602F475 RID: 193653 RVA: 0x00670812 File Offset: 0x0066EA12
		public static Offset<IInvoke> EndIInvoke(FlatBufferBuilder builder)
		{
			return new Offset<IInvoke>(builder.EndTable());
		}

		// Token: 0x0602F476 RID: 193654 RVA: 0x00670820 File Offset: 0x0066EA20
		public IInvokeT UnPack()
		{
			IInvokeT invokeT = new IInvokeT();
			this.UnPackTo(invokeT);
			return invokeT;
		}

		// Token: 0x0602F477 RID: 193655 RVA: 0x0067083C File Offset: 0x0066EA3C
		public void UnPackTo(IInvokeT _o)
		{
			_o.Who = this.Who;
			_o.ActionInfo = ((this.ActionInfo != null) ? this.ActionInfo.Value.UnPack() : null);
		}

		// Token: 0x0602F478 RID: 193656 RVA: 0x00670884 File Offset: 0x0066EA84
		public static Offset<IInvoke> Pack(FlatBufferBuilder builder, IInvokeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInvoke>);
			}
			Offset<IActionInfo> actionInfoOffset = (_o.ActionInfo == null) ? default(Offset<IActionInfo>) : IActionInfo.Pack(builder, _o.ActionInfo);
			return IInvoke.CreateIInvoke(builder, _o.Who, actionInfoOffset);
		}

		// Token: 0x0401115F RID: 69983
		private Table __p;
	}
}
