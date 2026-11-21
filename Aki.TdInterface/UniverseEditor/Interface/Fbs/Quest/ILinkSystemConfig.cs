using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004346 RID: 17222
	public struct ILinkSystemConfig : IFlatbufferObject
	{
		// Token: 0x170075DB RID: 30171
		// (get) Token: 0x060183D5 RID: 99285 RVA: 0x003745FD File Offset: 0x003727FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060183D6 RID: 99286 RVA: 0x0037460A File Offset: 0x0037280A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060183D7 RID: 99287 RVA: 0x00374614 File Offset: 0x00372814
		public static ILinkSystemConfig GetRootAsILinkSystemConfig(ByteBuffer _bb)
		{
			return ILinkSystemConfig.GetRootAsILinkSystemConfig(_bb, default(ILinkSystemConfig));
		}

		// Token: 0x060183D8 RID: 99288 RVA: 0x00374630 File Offset: 0x00372830
		public static ILinkSystemConfig GetRootAsILinkSystemConfig(ByteBuffer _bb, ILinkSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060183D9 RID: 99289 RVA: 0x0037464D File Offset: 0x0037284D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060183DA RID: 99290 RVA: 0x0037465C File Offset: 0x0037285C
		public ILinkSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170075DC RID: 30172
		// (get) Token: 0x060183DB RID: 99291 RVA: 0x0037466C File Offset: 0x0037286C
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

		// Token: 0x170075DD RID: 30173
		// (get) Token: 0x060183DC RID: 99292 RVA: 0x003746A8 File Offset: 0x003728A8
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

		// Token: 0x060183DD RID: 99293 RVA: 0x003746E4 File Offset: 0x003728E4
		public static Offset<ILinkSystemConfig> CreateILinkSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, int LinkDataId = 0)
		{
			builder.StartTable(2);
			ILinkSystemConfig.AddLinkDataId(builder, LinkDataId);
			ILinkSystemConfig.AddType(builder, Type);
			return ILinkSystemConfig.EndILinkSystemConfig(builder);
		}

		// Token: 0x060183DE RID: 99294 RVA: 0x00374701 File Offset: 0x00372901
		public static void StartILinkSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060183DF RID: 99295 RVA: 0x0037470A File Offset: 0x0037290A
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060183E0 RID: 99296 RVA: 0x00374715 File Offset: 0x00372915
		public static void AddLinkDataId(FlatBufferBuilder builder, int linkDataId)
		{
			builder.AddInt(1, linkDataId, 0);
		}

		// Token: 0x060183E1 RID: 99297 RVA: 0x00374720 File Offset: 0x00372920
		public static Offset<ILinkSystemConfig> EndILinkSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILinkSystemConfig>(builder.EndTable());
		}

		// Token: 0x060183E2 RID: 99298 RVA: 0x00374730 File Offset: 0x00372930
		public ILinkSystemConfigT UnPack()
		{
			ILinkSystemConfigT linkSystemConfigT = new ILinkSystemConfigT();
			this.UnPackTo(linkSystemConfigT);
			return linkSystemConfigT;
		}

		// Token: 0x060183E3 RID: 99299 RVA: 0x0037474B File Offset: 0x0037294B
		public void UnPackTo(ILinkSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.LinkDataId = this.LinkDataId;
		}

		// Token: 0x060183E4 RID: 99300 RVA: 0x00374768 File Offset: 0x00372968
		public static Offset<ILinkSystemConfig> Pack(FlatBufferBuilder builder, ILinkSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILinkSystemConfig>);
			}
			return ILinkSystemConfig.CreateILinkSystemConfig(builder, _o.Type, _o.LinkDataId);
		}

		// Token: 0x0400C2C2 RID: 49858
		private Table __p;
	}
}
