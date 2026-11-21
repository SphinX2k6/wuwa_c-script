using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061EF RID: 25071
	public struct IWuWaGoSpikeTrap : IFlatbufferObject
	{
		// Token: 0x1700BAF8 RID: 47864
		// (get) Token: 0x0602AA77 RID: 174711 RVA: 0x005D1016 File Offset: 0x005CF216
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AA78 RID: 174712 RVA: 0x005D1023 File Offset: 0x005CF223
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AA79 RID: 174713 RVA: 0x005D102C File Offset: 0x005CF22C
		public static IWuWaGoSpikeTrap GetRootAsIWuWaGoSpikeTrap(ByteBuffer _bb)
		{
			return IWuWaGoSpikeTrap.GetRootAsIWuWaGoSpikeTrap(_bb, default(IWuWaGoSpikeTrap));
		}

		// Token: 0x0602AA7A RID: 174714 RVA: 0x005D1048 File Offset: 0x005CF248
		public static IWuWaGoSpikeTrap GetRootAsIWuWaGoSpikeTrap(ByteBuffer _bb, IWuWaGoSpikeTrap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AA7B RID: 174715 RVA: 0x005D1065 File Offset: 0x005CF265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AA7C RID: 174716 RVA: 0x005D1074 File Offset: 0x005CF274
		public IWuWaGoSpikeTrap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAF9 RID: 47865
		// (get) Token: 0x0602AA7D RID: 174717 RVA: 0x005D1084 File Offset: 0x005CF284
		public EWuWaGoEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return (EWuWaGoEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BAFA RID: 47866
		// (get) Token: 0x0602AA7E RID: 174718 RVA: 0x005D10C0 File Offset: 0x005CF2C0
		public IWuWaGoGridLinkData? LinkData
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IWuWaGoGridLinkData?(default(IWuWaGoGridLinkData).__assign(num + this.__p.bb_pos, this.__p.bb));
			}
		}

		// Token: 0x0602AA7F RID: 174719 RVA: 0x005D1112 File Offset: 0x005CF312
		public static Offset<IWuWaGoSpikeTrap> CreateIWuWaGoSpikeTrap(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter, IWuWaGoGridLinkDataT LinkData = null)
		{
			builder.StartTable(2);
			IWuWaGoSpikeTrap.AddLinkData(builder, IWuWaGoGridLinkData.Pack(builder, LinkData));
			IWuWaGoSpikeTrap.AddType(builder, Type);
			return IWuWaGoSpikeTrap.EndIWuWaGoSpikeTrap(builder);
		}

		// Token: 0x0602AA80 RID: 174720 RVA: 0x005D1135 File Offset: 0x005CF335
		public static void StartIWuWaGoSpikeTrap(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602AA81 RID: 174721 RVA: 0x005D113E File Offset: 0x005CF33E
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602AA82 RID: 174722 RVA: 0x005D1149 File Offset: 0x005CF349
		public static void AddLinkData(FlatBufferBuilder builder, Offset<IWuWaGoGridLinkData> linkDataOffset)
		{
			builder.AddStruct(1, linkDataOffset.Value, 0);
		}

		// Token: 0x0602AA83 RID: 174723 RVA: 0x005D1159 File Offset: 0x005CF359
		public static Offset<IWuWaGoSpikeTrap> EndIWuWaGoSpikeTrap(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoSpikeTrap>(builder.EndTable());
		}

		// Token: 0x0602AA84 RID: 174724 RVA: 0x005D1168 File Offset: 0x005CF368
		public IWuWaGoSpikeTrapT UnPack()
		{
			IWuWaGoSpikeTrapT wuWaGoSpikeTrapT = new IWuWaGoSpikeTrapT();
			this.UnPackTo(wuWaGoSpikeTrapT);
			return wuWaGoSpikeTrapT;
		}

		// Token: 0x0602AA85 RID: 174725 RVA: 0x005D1184 File Offset: 0x005CF384
		public void UnPackTo(IWuWaGoSpikeTrapT _o)
		{
			_o.Type = this.Type;
			_o.LinkData = ((this.LinkData != null) ? this.LinkData.Value.UnPack() : null);
		}

		// Token: 0x0602AA86 RID: 174726 RVA: 0x005D11CC File Offset: 0x005CF3CC
		public static Offset<IWuWaGoSpikeTrap> Pack(FlatBufferBuilder builder, IWuWaGoSpikeTrapT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoSpikeTrap>);
			}
			return IWuWaGoSpikeTrap.CreateIWuWaGoSpikeTrap(builder, _o.Type, _o.LinkData);
		}

		// Token: 0x04010060 RID: 65632
		private Table __p;
	}
}
