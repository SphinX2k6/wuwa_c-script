using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200548E RID: 21646
	public struct IItemChangeAdsorbateState : IFlatbufferObject
	{
		// Token: 0x17009F60 RID: 40800
		// (get) Token: 0x060239EB RID: 145899 RVA: 0x004ECCC2 File Offset: 0x004EAEC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060239EC RID: 145900 RVA: 0x004ECCCF File Offset: 0x004EAECF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060239ED RID: 145901 RVA: 0x004ECCD8 File Offset: 0x004EAED8
		public static IItemChangeAdsorbateState GetRootAsIItemChangeAdsorbateState(ByteBuffer _bb)
		{
			return IItemChangeAdsorbateState.GetRootAsIItemChangeAdsorbateState(_bb, default(IItemChangeAdsorbateState));
		}

		// Token: 0x060239EE RID: 145902 RVA: 0x004ECCF4 File Offset: 0x004EAEF4
		public static IItemChangeAdsorbateState GetRootAsIItemChangeAdsorbateState(ByteBuffer _bb, IItemChangeAdsorbateState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060239EF RID: 145903 RVA: 0x004ECD11 File Offset: 0x004EAF11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060239F0 RID: 145904 RVA: 0x004ECD20 File Offset: 0x004EAF20
		public IItemChangeAdsorbateState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060239F1 RID: 145905 RVA: 0x004ECD30 File Offset: 0x004EAF30
		public static void StartIItemChangeAdsorbateState(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x060239F2 RID: 145906 RVA: 0x004ECD39 File Offset: 0x004EAF39
		public static Offset<IItemChangeAdsorbateState> EndIItemChangeAdsorbateState(FlatBufferBuilder builder)
		{
			return new Offset<IItemChangeAdsorbateState>(builder.EndTable());
		}

		// Token: 0x060239F3 RID: 145907 RVA: 0x004ECD48 File Offset: 0x004EAF48
		public IItemChangeAdsorbateStateT UnPack()
		{
			IItemChangeAdsorbateStateT itemChangeAdsorbateStateT = new IItemChangeAdsorbateStateT();
			this.UnPackTo(itemChangeAdsorbateStateT);
			return itemChangeAdsorbateStateT;
		}

		// Token: 0x060239F4 RID: 145908 RVA: 0x004ECD63 File Offset: 0x004EAF63
		public void UnPackTo(IItemChangeAdsorbateStateT _o)
		{
		}

		// Token: 0x060239F5 RID: 145909 RVA: 0x004ECD68 File Offset: 0x004EAF68
		public static Offset<IItemChangeAdsorbateState> Pack(FlatBufferBuilder builder, IItemChangeAdsorbateStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemChangeAdsorbateState>);
			}
			IItemChangeAdsorbateState.StartIItemChangeAdsorbateState(builder);
			return IItemChangeAdsorbateState.EndIItemChangeAdsorbateState(builder);
		}

		// Token: 0x0400E71F RID: 59167
		private Table __p;
	}
}
