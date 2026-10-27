using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005838 RID: 22584
	public struct IRefreshSingle : IFlatbufferObject
	{
		// Token: 0x1700A8AC RID: 43180
		// (get) Token: 0x06025FB9 RID: 155577 RVA: 0x0053C796 File Offset: 0x0053A996
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025FBA RID: 155578 RVA: 0x0053C7A3 File Offset: 0x0053A9A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025FBB RID: 155579 RVA: 0x0053C7AC File Offset: 0x0053A9AC
		public static IRefreshSingle GetRootAsIRefreshSingle(ByteBuffer _bb)
		{
			return IRefreshSingle.GetRootAsIRefreshSingle(_bb, default(IRefreshSingle));
		}

		// Token: 0x06025FBC RID: 155580 RVA: 0x0053C7C8 File Offset: 0x0053A9C8
		public static IRefreshSingle GetRootAsIRefreshSingle(ByteBuffer _bb, IRefreshSingle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025FBD RID: 155581 RVA: 0x0053C7E5 File Offset: 0x0053A9E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025FBE RID: 155582 RVA: 0x0053C7F4 File Offset: 0x0053A9F4
		public IRefreshSingle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8AD RID: 43181
		// (get) Token: 0x06025FBF RID: 155583 RVA: 0x0053C804 File Offset: 0x0053AA04
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

		// Token: 0x1700A8AE RID: 43182
		// (get) Token: 0x06025FC0 RID: 155584 RVA: 0x0053C840 File Offset: 0x0053AA40
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

		// Token: 0x1700A8AF RID: 43183
		// (get) Token: 0x06025FC1 RID: 155585 RVA: 0x0053C87C File Offset: 0x0053AA7C
		public bool DelayRefresh
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A8B0 RID: 43184
		// (get) Token: 0x06025FC2 RID: 155586 RVA: 0x0053C8BC File Offset: 0x0053AABC
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

		// Token: 0x06025FC3 RID: 155587 RVA: 0x0053C91A File Offset: 0x0053AB1A
		public static Offset<IRefreshSingle> CreateIRefreshSingle(FlatBufferBuilder builder, int RefreshInterval = 0, int MaxRefreshTimes = 0, bool DelayRefresh = false, Offset<ITempleGuid> TemplateGuidOffset = default(Offset<ITempleGuid>))
		{
			builder.StartTable(4);
			IRefreshSingle.AddTemplateGuid(builder, TemplateGuidOffset);
			IRefreshSingle.AddMaxRefreshTimes(builder, MaxRefreshTimes);
			IRefreshSingle.AddRefreshInterval(builder, RefreshInterval);
			IRefreshSingle.AddDelayRefresh(builder, DelayRefresh);
			return IRefreshSingle.EndIRefreshSingle(builder);
		}

		// Token: 0x06025FC4 RID: 155588 RVA: 0x0053C946 File Offset: 0x0053AB46
		public static void StartIRefreshSingle(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06025FC5 RID: 155589 RVA: 0x0053C94F File Offset: 0x0053AB4F
		public static void AddRefreshInterval(FlatBufferBuilder builder, int refreshInterval)
		{
			builder.AddInt(0, refreshInterval, 0);
		}

		// Token: 0x06025FC6 RID: 155590 RVA: 0x0053C95A File Offset: 0x0053AB5A
		public static void AddMaxRefreshTimes(FlatBufferBuilder builder, int maxRefreshTimes)
		{
			builder.AddInt(1, maxRefreshTimes, 0);
		}

		// Token: 0x06025FC7 RID: 155591 RVA: 0x0053C965 File Offset: 0x0053AB65
		public static void AddDelayRefresh(FlatBufferBuilder builder, bool delayRefresh)
		{
			builder.AddBool(2, delayRefresh, false);
		}

		// Token: 0x06025FC8 RID: 155592 RVA: 0x0053C970 File Offset: 0x0053AB70
		public static void AddTemplateGuid(FlatBufferBuilder builder, Offset<ITempleGuid> templateGuidOffset)
		{
			builder.AddOffset(3, templateGuidOffset.Value, 0);
		}

		// Token: 0x06025FC9 RID: 155593 RVA: 0x0053C980 File Offset: 0x0053AB80
		public static Offset<IRefreshSingle> EndIRefreshSingle(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshSingle>(builder.EndTable());
		}

		// Token: 0x06025FCA RID: 155594 RVA: 0x0053C990 File Offset: 0x0053AB90
		public IRefreshSingleT UnPack()
		{
			IRefreshSingleT refreshSingleT = new IRefreshSingleT();
			this.UnPackTo(refreshSingleT);
			return refreshSingleT;
		}

		// Token: 0x06025FCB RID: 155595 RVA: 0x0053C9AC File Offset: 0x0053ABAC
		public void UnPackTo(IRefreshSingleT _o)
		{
			_o.RefreshInterval = this.RefreshInterval;
			_o.MaxRefreshTimes = this.MaxRefreshTimes;
			_o.DelayRefresh = this.DelayRefresh;
			_o.TemplateGuid = ((this.TemplateGuid != null) ? this.TemplateGuid.Value.UnPack() : null);
		}

		// Token: 0x06025FCC RID: 155596 RVA: 0x0053CA0C File Offset: 0x0053AC0C
		public static Offset<IRefreshSingle> Pack(FlatBufferBuilder builder, IRefreshSingleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefreshSingle>);
			}
			Offset<ITempleGuid> templateGuidOffset = (_o.TemplateGuid == null) ? default(Offset<ITempleGuid>) : ITempleGuid.Pack(builder, _o.TemplateGuid);
			return IRefreshSingle.CreateIRefreshSingle(builder, _o.RefreshInterval, _o.MaxRefreshTimes, _o.DelayRefresh, templateGuidOffset);
		}

		// Token: 0x0400ED4D RID: 60749
		private Table __p;
	}
}
