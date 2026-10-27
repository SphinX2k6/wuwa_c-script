using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F08 RID: 16136
	public struct ILinkSystemConfig : IFlatbufferObject
	{
		// Token: 0x17006FEC RID: 28652
		// (get) Token: 0x06016D7E RID: 93566 RVA: 0x0034B431 File Offset: 0x00349631
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016D7F RID: 93567 RVA: 0x0034B43E File Offset: 0x0034963E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016D80 RID: 93568 RVA: 0x0034B448 File Offset: 0x00349648
		public static ILinkSystemConfig GetRootAsILinkSystemConfig(ByteBuffer _bb)
		{
			return ILinkSystemConfig.GetRootAsILinkSystemConfig(_bb, default(ILinkSystemConfig));
		}

		// Token: 0x06016D81 RID: 93569 RVA: 0x0034B464 File Offset: 0x00349664
		public static ILinkSystemConfig GetRootAsILinkSystemConfig(ByteBuffer _bb, ILinkSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016D82 RID: 93570 RVA: 0x0034B481 File Offset: 0x00349681
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016D83 RID: 93571 RVA: 0x0034B490 File Offset: 0x00349690
		public ILinkSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FED RID: 28653
		// (get) Token: 0x06016D84 RID: 93572 RVA: 0x0034B4A0 File Offset: 0x003496A0
		public EEnableSystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnableSystemType.GradingSystem;
				}
				return (EEnableSystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006FEE RID: 28654
		// (get) Token: 0x06016D85 RID: 93573 RVA: 0x0034B4DC File Offset: 0x003496DC
		public int LinkDataId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016D86 RID: 93574 RVA: 0x0034B518 File Offset: 0x00349718
		public static Offset<ILinkSystemConfig> CreateILinkSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, int LinkDataId = 0)
		{
			builder.StartTable(2);
			ILinkSystemConfig.AddLinkDataId(builder, LinkDataId);
			ILinkSystemConfig.AddType(builder, Type);
			return ILinkSystemConfig.EndILinkSystemConfig(builder);
		}

		// Token: 0x06016D87 RID: 93575 RVA: 0x0034B535 File Offset: 0x00349735
		public static void StartILinkSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016D88 RID: 93576 RVA: 0x0034B53E File Offset: 0x0034973E
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016D89 RID: 93577 RVA: 0x0034B549 File Offset: 0x00349749
		public static void AddLinkDataId(FlatBufferBuilder builder, int linkDataId)
		{
			builder.AddInt(1, linkDataId, 0);
		}

		// Token: 0x06016D8A RID: 93578 RVA: 0x0034B554 File Offset: 0x00349754
		public static Offset<ILinkSystemConfig> EndILinkSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILinkSystemConfig>(builder.EndTable());
		}

		// Token: 0x06016D8B RID: 93579 RVA: 0x0034B564 File Offset: 0x00349764
		public ILinkSystemConfigT UnPack()
		{
			ILinkSystemConfigT linkSystemConfigT = new ILinkSystemConfigT();
			this.UnPackTo(linkSystemConfigT);
			return linkSystemConfigT;
		}

		// Token: 0x06016D8C RID: 93580 RVA: 0x0034B57F File Offset: 0x0034977F
		public void UnPackTo(ILinkSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.LinkDataId = this.LinkDataId;
		}

		// Token: 0x06016D8D RID: 93581 RVA: 0x0034B59C File Offset: 0x0034979C
		public static Offset<ILinkSystemConfig> Pack(FlatBufferBuilder builder, ILinkSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILinkSystemConfig>);
			}
			return ILinkSystemConfig.CreateILinkSystemConfig(builder, _o.Type, _o.LinkDataId);
		}

		// Token: 0x0400B8E5 RID: 47333
		private Table __p;
	}
}
