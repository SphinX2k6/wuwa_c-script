using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E3F RID: 24127
	public struct IRefreshSingle : IFlatbufferObject
	{
		// Token: 0x1700B1D0 RID: 45520
		// (get) Token: 0x060284D9 RID: 165081 RVA: 0x00582922 File Offset: 0x00580B22
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060284DA RID: 165082 RVA: 0x0058292F File Offset: 0x00580B2F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060284DB RID: 165083 RVA: 0x00582938 File Offset: 0x00580B38
		public static IRefreshSingle GetRootAsIRefreshSingle(ByteBuffer _bb)
		{
			return IRefreshSingle.GetRootAsIRefreshSingle(_bb, default(IRefreshSingle));
		}

		// Token: 0x060284DC RID: 165084 RVA: 0x00582954 File Offset: 0x00580B54
		public static IRefreshSingle GetRootAsIRefreshSingle(ByteBuffer _bb, IRefreshSingle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060284DD RID: 165085 RVA: 0x00582971 File Offset: 0x00580B71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060284DE RID: 165086 RVA: 0x00582980 File Offset: 0x00580B80
		public IRefreshSingle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1D1 RID: 45521
		// (get) Token: 0x060284DF RID: 165087 RVA: 0x00582990 File Offset: 0x00580B90
		public int RefreshInterval
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

		// Token: 0x1700B1D2 RID: 45522
		// (get) Token: 0x060284E0 RID: 165088 RVA: 0x005829CC File Offset: 0x00580BCC
		public int MaxRefreshTimes
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

		// Token: 0x1700B1D3 RID: 45523
		// (get) Token: 0x060284E1 RID: 165089 RVA: 0x00582A08 File Offset: 0x00580C08
		public bool DelayRefresh
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B1D4 RID: 45524
		// (get) Token: 0x060284E2 RID: 165090 RVA: 0x00582A48 File Offset: 0x00580C48
		public ITempleGuid? TemplateGuid
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ITempleGuid?(default(ITempleGuid).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060284E3 RID: 165091 RVA: 0x00582AA6 File Offset: 0x00580CA6
		public static Offset<IRefreshSingle> CreateIRefreshSingle(FlatBufferBuilder builder, int RefreshInterval = 0, int MaxRefreshTimes = 0, bool DelayRefresh = false, Offset<ITempleGuid> TemplateGuidOffset = default(Offset<ITempleGuid>))
		{
			builder.StartTable(4);
			IRefreshSingle.AddTemplateGuid(builder, TemplateGuidOffset);
			IRefreshSingle.AddMaxRefreshTimes(builder, MaxRefreshTimes);
			IRefreshSingle.AddRefreshInterval(builder, RefreshInterval);
			IRefreshSingle.AddDelayRefresh(builder, DelayRefresh);
			return IRefreshSingle.EndIRefreshSingle(builder);
		}

		// Token: 0x060284E4 RID: 165092 RVA: 0x00582AD2 File Offset: 0x00580CD2
		public static void StartIRefreshSingle(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060284E5 RID: 165093 RVA: 0x00582ADB File Offset: 0x00580CDB
		public static void AddRefreshInterval(FlatBufferBuilder builder, int refreshInterval)
		{
			builder.AddInt(0, refreshInterval, 0);
		}

		// Token: 0x060284E6 RID: 165094 RVA: 0x00582AE6 File Offset: 0x00580CE6
		public static void AddMaxRefreshTimes(FlatBufferBuilder builder, int maxRefreshTimes)
		{
			builder.AddInt(1, maxRefreshTimes, 0);
		}

		// Token: 0x060284E7 RID: 165095 RVA: 0x00582AF1 File Offset: 0x00580CF1
		public static void AddDelayRefresh(FlatBufferBuilder builder, bool delayRefresh)
		{
			builder.AddBool(2, delayRefresh, false);
		}

		// Token: 0x060284E8 RID: 165096 RVA: 0x00582AFC File Offset: 0x00580CFC
		public static void AddTemplateGuid(FlatBufferBuilder builder, Offset<ITempleGuid> templateGuidOffset)
		{
			builder.AddOffset(3, templateGuidOffset.Value, 0);
		}

		// Token: 0x060284E9 RID: 165097 RVA: 0x00582B0C File Offset: 0x00580D0C
		public static Offset<IRefreshSingle> EndIRefreshSingle(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshSingle>(builder.EndTable());
		}

		// Token: 0x060284EA RID: 165098 RVA: 0x00582B1C File Offset: 0x00580D1C
		public IRefreshSingleT UnPack()
		{
			IRefreshSingleT refreshSingleT = new IRefreshSingleT();
			this.UnPackTo(refreshSingleT);
			return refreshSingleT;
		}

		// Token: 0x060284EB RID: 165099 RVA: 0x00582B38 File Offset: 0x00580D38
		public void UnPackTo(IRefreshSingleT _o)
		{
			_o.RefreshInterval = this.RefreshInterval;
			_o.MaxRefreshTimes = this.MaxRefreshTimes;
			_o.DelayRefresh = this.DelayRefresh;
			_o.TemplateGuid = ((this.TemplateGuid != null) ? this.TemplateGuid.Value.UnPack() : null);
		}

		// Token: 0x060284EC RID: 165100 RVA: 0x00582B98 File Offset: 0x00580D98
		public static Offset<IRefreshSingle> Pack(FlatBufferBuilder builder, IRefreshSingleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefreshSingle>);
			}
			Offset<ITempleGuid> templateGuidOffset = (_o.TemplateGuid == null) ? default(Offset<ITempleGuid>) : ITempleGuid.Pack(builder, _o.TemplateGuid);
			return IRefreshSingle.CreateIRefreshSingle(builder, _o.RefreshInterval, _o.MaxRefreshTimes, _o.DelayRefresh, templateGuidOffset);
		}

		// Token: 0x0400FA38 RID: 64056
		private Table __p;
	}
}
