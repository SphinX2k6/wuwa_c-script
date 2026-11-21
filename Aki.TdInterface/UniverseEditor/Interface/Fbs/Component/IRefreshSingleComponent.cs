using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E42 RID: 24130
	public struct IRefreshSingleComponent : IFlatbufferObject
	{
		// Token: 0x1700B1D9 RID: 45529
		// (get) Token: 0x060284F7 RID: 165111 RVA: 0x00582CC7 File Offset: 0x00580EC7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060284F8 RID: 165112 RVA: 0x00582CD4 File Offset: 0x00580ED4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060284F9 RID: 165113 RVA: 0x00582CDC File Offset: 0x00580EDC
		public static IRefreshSingleComponent GetRootAsIRefreshSingleComponent(ByteBuffer _bb)
		{
			return IRefreshSingleComponent.GetRootAsIRefreshSingleComponent(_bb, default(IRefreshSingleComponent));
		}

		// Token: 0x060284FA RID: 165114 RVA: 0x00582CF8 File Offset: 0x00580EF8
		public static IRefreshSingleComponent GetRootAsIRefreshSingleComponent(ByteBuffer _bb, IRefreshSingleComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060284FB RID: 165115 RVA: 0x00582D15 File Offset: 0x00580F15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060284FC RID: 165116 RVA: 0x00582D24 File Offset: 0x00580F24
		public IRefreshSingleComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1DA RID: 45530
		// (get) Token: 0x060284FD RID: 165117 RVA: 0x00582D34 File Offset: 0x00580F34
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B1DB RID: 45531
		// (get) Token: 0x060284FE RID: 165118 RVA: 0x00582D74 File Offset: 0x00580F74
		public int RefreshInterval
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

		// Token: 0x1700B1DC RID: 45532
		// (get) Token: 0x060284FF RID: 165119 RVA: 0x00582DB0 File Offset: 0x00580FB0
		public bool DelayRefresh
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B1DD RID: 45533
		// (get) Token: 0x06028500 RID: 165120 RVA: 0x00582DF0 File Offset: 0x00580FF0
		public string TemplateGuid
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028501 RID: 165121 RVA: 0x00582E28 File Offset: 0x00581028
		public Span<byte> GetTemplateGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06028502 RID: 165122 RVA: 0x00582E38 File Offset: 0x00581038
		public byte[] GetTemplateGuidArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700B1DE RID: 45534
		// (get) Token: 0x06028503 RID: 165123 RVA: 0x00582E48 File Offset: 0x00581048
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028504 RID: 165124 RVA: 0x00582E85 File Offset: 0x00581085
		public static Offset<IRefreshSingleComponent> CreateIRefreshSingleComponent(FlatBufferBuilder builder, bool Disabled = false, int RefreshInterval = 0, bool DelayRefresh = false, StringOffset TemplateGuidOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IRefreshSingleComponent.AddTemplateGuid(builder, TemplateGuidOffset);
			IRefreshSingleComponent.AddRefreshInterval(builder, RefreshInterval);
			IRefreshSingleComponent.AddNullMask(builder, NullMask);
			IRefreshSingleComponent.AddDelayRefresh(builder, DelayRefresh);
			IRefreshSingleComponent.AddDisabled(builder, Disabled);
			return IRefreshSingleComponent.EndIRefreshSingleComponent(builder);
		}

		// Token: 0x06028505 RID: 165125 RVA: 0x00582EB9 File Offset: 0x005810B9
		public static void StartIRefreshSingleComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028506 RID: 165126 RVA: 0x00582EC2 File Offset: 0x005810C2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028507 RID: 165127 RVA: 0x00582ECD File Offset: 0x005810CD
		public static void AddRefreshInterval(FlatBufferBuilder builder, int refreshInterval)
		{
			builder.AddInt(1, refreshInterval, 0);
		}

		// Token: 0x06028508 RID: 165128 RVA: 0x00582ED8 File Offset: 0x005810D8
		public static void AddDelayRefresh(FlatBufferBuilder builder, bool delayRefresh)
		{
			builder.AddBool(2, delayRefresh, false);
		}

		// Token: 0x06028509 RID: 165129 RVA: 0x00582EE3 File Offset: 0x005810E3
		public static void AddTemplateGuid(FlatBufferBuilder builder, StringOffset templateGuidOffset)
		{
			builder.AddOffset(3, templateGuidOffset.Value, 0);
		}

		// Token: 0x0602850A RID: 165130 RVA: 0x00582EF3 File Offset: 0x005810F3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602850B RID: 165131 RVA: 0x00582EFE File Offset: 0x005810FE
		public static Offset<IRefreshSingleComponent> EndIRefreshSingleComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshSingleComponent>(builder.EndTable());
		}

		// Token: 0x0602850C RID: 165132 RVA: 0x00582F0C File Offset: 0x0058110C
		public IRefreshSingleComponentT UnPack()
		{
			IRefreshSingleComponentT refreshSingleComponentT = new IRefreshSingleComponentT();
			this.UnPackTo(refreshSingleComponentT);
			return refreshSingleComponentT;
		}

		// Token: 0x0602850D RID: 165133 RVA: 0x00582F27 File Offset: 0x00581127
		public void UnPackTo(IRefreshSingleComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.RefreshInterval = this.RefreshInterval;
			_o.DelayRefresh = this.DelayRefresh;
			_o.TemplateGuid = this.TemplateGuid;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602850E RID: 165134 RVA: 0x00582F68 File Offset: 0x00581168
		public static Offset<IRefreshSingleComponent> Pack(FlatBufferBuilder builder, IRefreshSingleComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefreshSingleComponent>);
			}
			StringOffset templateGuidOffset = (_o.TemplateGuid == null) ? default(StringOffset) : builder.CreateString(_o.TemplateGuid);
			return IRefreshSingleComponent.CreateIRefreshSingleComponent(builder, _o.Disabled, _o.RefreshInterval, _o.DelayRefresh, templateGuidOffset, _o.NullMask);
		}

		// Token: 0x0400FA3D RID: 64061
		private Table __p;
	}
}
