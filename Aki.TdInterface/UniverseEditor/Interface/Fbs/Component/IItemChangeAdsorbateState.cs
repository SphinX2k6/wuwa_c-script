using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A14 RID: 23060
	public struct IItemChangeAdsorbateState : IFlatbufferObject
	{
		// Token: 0x1700A79A RID: 42906
		// (get) Token: 0x06025AA3 RID: 154275 RVA: 0x00529D36 File Offset: 0x00527F36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025AA4 RID: 154276 RVA: 0x00529D43 File Offset: 0x00527F43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025AA5 RID: 154277 RVA: 0x00529D4C File Offset: 0x00527F4C
		public static IItemChangeAdsorbateState GetRootAsIItemChangeAdsorbateState(ByteBuffer _bb)
		{
			return IItemChangeAdsorbateState.GetRootAsIItemChangeAdsorbateState(_bb, default(IItemChangeAdsorbateState));
		}

		// Token: 0x06025AA6 RID: 154278 RVA: 0x00529D68 File Offset: 0x00527F68
		public static IItemChangeAdsorbateState GetRootAsIItemChangeAdsorbateState(ByteBuffer _bb, IItemChangeAdsorbateState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025AA7 RID: 154279 RVA: 0x00529D85 File Offset: 0x00527F85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025AA8 RID: 154280 RVA: 0x00529D94 File Offset: 0x00527F94
		public IItemChangeAdsorbateState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06025AA9 RID: 154281 RVA: 0x00529DA4 File Offset: 0x00527FA4
		public static void StartIItemChangeAdsorbateState(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06025AAA RID: 154282 RVA: 0x00529DAD File Offset: 0x00527FAD
		public static Offset<IItemChangeAdsorbateState> EndIItemChangeAdsorbateState(FlatBufferBuilder builder)
		{
			return new Offset<IItemChangeAdsorbateState>(builder.EndTable());
		}

		// Token: 0x06025AAB RID: 154283 RVA: 0x00529DBC File Offset: 0x00527FBC
		public IItemChangeAdsorbateStateT UnPack()
		{
			IItemChangeAdsorbateStateT itemChangeAdsorbateStateT = new IItemChangeAdsorbateStateT();
			this.UnPackTo(itemChangeAdsorbateStateT);
			return itemChangeAdsorbateStateT;
		}

		// Token: 0x06025AAC RID: 154284 RVA: 0x00529DD7 File Offset: 0x00527FD7
		public void UnPackTo(IItemChangeAdsorbateStateT _o)
		{
		}

		// Token: 0x06025AAD RID: 154285 RVA: 0x00529DDC File Offset: 0x00527FDC
		public static Offset<IItemChangeAdsorbateState> Pack(FlatBufferBuilder builder, IItemChangeAdsorbateStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemChangeAdsorbateState>);
			}
			IItemChangeAdsorbateState.StartIItemChangeAdsorbateState(builder);
			return IItemChangeAdsorbateState.EndIItemChangeAdsorbateState(builder);
		}

		// Token: 0x0400F350 RID: 62288
		private Table __p;
	}
}
