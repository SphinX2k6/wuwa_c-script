using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007142 RID: 28994
	public struct ILiveUiHideConfig : IFlatbufferObject
	{
		// Token: 0x1700D43D RID: 54333
		// (get) Token: 0x060325EC RID: 206316 RVA: 0x006CF516 File Offset: 0x006CD716
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060325ED RID: 206317 RVA: 0x006CF523 File Offset: 0x006CD723
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060325EE RID: 206318 RVA: 0x006CF52C File Offset: 0x006CD72C
		public static ILiveUiHideConfig GetRootAsILiveUiHideConfig(ByteBuffer _bb)
		{
			return ILiveUiHideConfig.GetRootAsILiveUiHideConfig(_bb, default(ILiveUiHideConfig));
		}

		// Token: 0x060325EF RID: 206319 RVA: 0x006CF548 File Offset: 0x006CD748
		public static ILiveUiHideConfig GetRootAsILiveUiHideConfig(ByteBuffer _bb, ILiveUiHideConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060325F0 RID: 206320 RVA: 0x006CF565 File Offset: 0x006CD765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060325F1 RID: 206321 RVA: 0x006CF574 File Offset: 0x006CD774
		public ILiveUiHideConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D43E RID: 54334
		// (get) Token: 0x060325F2 RID: 206322 RVA: 0x006CF584 File Offset: 0x006CD784
		public ELiveUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveUiType.Start;
				}
				return (ELiveUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060325F3 RID: 206323 RVA: 0x006CF5C0 File Offset: 0x006CD7C0
		public static Offset<ILiveUiHideConfig> CreateILiveUiHideConfig(FlatBufferBuilder builder, ELiveUiType Type = ELiveUiType.Start)
		{
			builder.StartTable(1);
			ILiveUiHideConfig.AddType(builder, Type);
			return ILiveUiHideConfig.EndILiveUiHideConfig(builder);
		}

		// Token: 0x060325F4 RID: 206324 RVA: 0x006CF5D6 File Offset: 0x006CD7D6
		public static void StartILiveUiHideConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060325F5 RID: 206325 RVA: 0x006CF5DF File Offset: 0x006CD7DF
		public static void AddType(FlatBufferBuilder builder, ELiveUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060325F6 RID: 206326 RVA: 0x006CF5EA File Offset: 0x006CD7EA
		public static Offset<ILiveUiHideConfig> EndILiveUiHideConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILiveUiHideConfig>(builder.EndTable());
		}

		// Token: 0x060325F7 RID: 206327 RVA: 0x006CF5F8 File Offset: 0x006CD7F8
		public ILiveUiHideConfigT UnPack()
		{
			ILiveUiHideConfigT liveUiHideConfigT = new ILiveUiHideConfigT();
			this.UnPackTo(liveUiHideConfigT);
			return liveUiHideConfigT;
		}

		// Token: 0x060325F8 RID: 206328 RVA: 0x006CF613 File Offset: 0x006CD813
		public void UnPackTo(ILiveUiHideConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060325F9 RID: 206329 RVA: 0x006CF624 File Offset: 0x006CD824
		public static Offset<ILiveUiHideConfig> Pack(FlatBufferBuilder builder, ILiveUiHideConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveUiHideConfig>);
			}
			return ILiveUiHideConfig.CreateILiveUiHideConfig(builder, _o.Type);
		}

		// Token: 0x0401212D RID: 74029
		private Table __p;
	}
}
