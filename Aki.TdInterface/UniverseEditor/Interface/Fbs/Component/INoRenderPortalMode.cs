using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005611 RID: 22033
	public struct INoRenderPortalMode : IFlatbufferObject
	{
		// Token: 0x1700A30C RID: 41740
		// (get) Token: 0x06024911 RID: 149777 RVA: 0x0050BBDF File Offset: 0x00509DDF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024912 RID: 149778 RVA: 0x0050BBEC File Offset: 0x00509DEC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024913 RID: 149779 RVA: 0x0050BBF4 File Offset: 0x00509DF4
		public static INoRenderPortalMode GetRootAsINoRenderPortalMode(ByteBuffer _bb)
		{
			return INoRenderPortalMode.GetRootAsINoRenderPortalMode(_bb, default(INoRenderPortalMode));
		}

		// Token: 0x06024914 RID: 149780 RVA: 0x0050BC10 File Offset: 0x00509E10
		public static INoRenderPortalMode GetRootAsINoRenderPortalMode(ByteBuffer _bb, INoRenderPortalMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024915 RID: 149781 RVA: 0x0050BC2D File Offset: 0x00509E2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024916 RID: 149782 RVA: 0x0050BC3C File Offset: 0x00509E3C
		public INoRenderPortalMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A30D RID: 41741
		// (get) Token: 0x06024917 RID: 149783 RVA: 0x0050BC4C File Offset: 0x00509E4C
		public ENoRenderPortalType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENoRenderPortalType.Static;
				}
				return (ENoRenderPortalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A30E RID: 41742
		// (get) Token: 0x06024918 RID: 149784 RVA: 0x0050BC88 File Offset: 0x00509E88
		public EPortalModel PortalModel
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPortalModel.A;
				}
				return (EPortalModel)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024919 RID: 149785 RVA: 0x0050BCC4 File Offset: 0x00509EC4
		public static Offset<INoRenderPortalMode> CreateINoRenderPortalMode(FlatBufferBuilder builder, ENoRenderPortalType Type = ENoRenderPortalType.Static, EPortalModel PortalModel = EPortalModel.A)
		{
			builder.StartTable(2);
			INoRenderPortalMode.AddPortalModel(builder, PortalModel);
			INoRenderPortalMode.AddType(builder, Type);
			return INoRenderPortalMode.EndINoRenderPortalMode(builder);
		}

		// Token: 0x0602491A RID: 149786 RVA: 0x0050BCE1 File Offset: 0x00509EE1
		public static void StartINoRenderPortalMode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602491B RID: 149787 RVA: 0x0050BCEA File Offset: 0x00509EEA
		public static void AddType(FlatBufferBuilder builder, ENoRenderPortalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602491C RID: 149788 RVA: 0x0050BCF5 File Offset: 0x00509EF5
		public static void AddPortalModel(FlatBufferBuilder builder, EPortalModel portalModel)
		{
			builder.AddByte(1, (byte)portalModel, 0);
		}

		// Token: 0x0602491D RID: 149789 RVA: 0x0050BD00 File Offset: 0x00509F00
		public static Offset<INoRenderPortalMode> EndINoRenderPortalMode(FlatBufferBuilder builder)
		{
			return new Offset<INoRenderPortalMode>(builder.EndTable());
		}

		// Token: 0x0602491E RID: 149790 RVA: 0x0050BD10 File Offset: 0x00509F10
		public INoRenderPortalModeT UnPack()
		{
			INoRenderPortalModeT noRenderPortalModeT = new INoRenderPortalModeT();
			this.UnPackTo(noRenderPortalModeT);
			return noRenderPortalModeT;
		}

		// Token: 0x0602491F RID: 149791 RVA: 0x0050BD2B File Offset: 0x00509F2B
		public void UnPackTo(INoRenderPortalModeT _o)
		{
			_o.Type = this.Type;
			_o.PortalModel = this.PortalModel;
		}

		// Token: 0x06024920 RID: 149792 RVA: 0x0050BD48 File Offset: 0x00509F48
		public static Offset<INoRenderPortalMode> Pack(FlatBufferBuilder builder, INoRenderPortalModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoRenderPortalMode>);
			}
			return INoRenderPortalMode.CreateINoRenderPortalMode(builder, _o.Type, _o.PortalModel);
		}

		// Token: 0x0400E992 RID: 59794
		private Table __p;
	}
}
