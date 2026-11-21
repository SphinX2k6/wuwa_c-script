using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DB5 RID: 23989
	public struct IPullingFoundation : IFlatbufferObject
	{
		// Token: 0x1700B0B5 RID: 45237
		// (get) Token: 0x06027FDC RID: 163804 RVA: 0x00578617 File Offset: 0x00576817
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027FDD RID: 163805 RVA: 0x00578624 File Offset: 0x00576824
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027FDE RID: 163806 RVA: 0x0057862C File Offset: 0x0057682C
		public static IPullingFoundation GetRootAsIPullingFoundation(ByteBuffer _bb)
		{
			return IPullingFoundation.GetRootAsIPullingFoundation(_bb, default(IPullingFoundation));
		}

		// Token: 0x06027FDF RID: 163807 RVA: 0x00578648 File Offset: 0x00576848
		public static IPullingFoundation GetRootAsIPullingFoundation(ByteBuffer _bb, IPullingFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027FE0 RID: 163808 RVA: 0x00578665 File Offset: 0x00576865
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027FE1 RID: 163809 RVA: 0x00578674 File Offset: 0x00576874
		public IPullingFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0B6 RID: 45238
		// (get) Token: 0x06027FE2 RID: 163810 RVA: 0x00578684 File Offset: 0x00576884
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B0B7 RID: 45239
		// (get) Token: 0x06027FE3 RID: 163811 RVA: 0x005786C4 File Offset: 0x005768C4
		public IPullingCategoryMatchingFoundation? Config
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPullingCategoryMatchingFoundation?(default(IPullingCategoryMatchingFoundation).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B0B8 RID: 45240
		// (get) Token: 0x06027FE4 RID: 163812 RVA: 0x00578724 File Offset: 0x00576924
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027FE5 RID: 163813 RVA: 0x00578760 File Offset: 0x00576960
		public static Offset<IPullingFoundation> CreateIPullingFoundation(FlatBufferBuilder builder, bool Disabled = false, Offset<IPullingCategoryMatchingFoundation> ConfigOffset = default(Offset<IPullingCategoryMatchingFoundation>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IPullingFoundation.AddConfig(builder, ConfigOffset);
			IPullingFoundation.AddNullMask(builder, NullMask);
			IPullingFoundation.AddDisabled(builder, Disabled);
			return IPullingFoundation.EndIPullingFoundation(builder);
		}

		// Token: 0x06027FE6 RID: 163814 RVA: 0x00578784 File Offset: 0x00576984
		public static void StartIPullingFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027FE7 RID: 163815 RVA: 0x0057878D File Offset: 0x0057698D
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027FE8 RID: 163816 RVA: 0x00578798 File Offset: 0x00576998
		public static void AddConfig(FlatBufferBuilder builder, Offset<IPullingCategoryMatchingFoundation> configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x06027FE9 RID: 163817 RVA: 0x005787A8 File Offset: 0x005769A8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06027FEA RID: 163818 RVA: 0x005787B3 File Offset: 0x005769B3
		public static Offset<IPullingFoundation> EndIPullingFoundation(FlatBufferBuilder builder)
		{
			return new Offset<IPullingFoundation>(builder.EndTable());
		}

		// Token: 0x06027FEB RID: 163819 RVA: 0x005787C0 File Offset: 0x005769C0
		public IPullingFoundationT UnPack()
		{
			IPullingFoundationT pullingFoundationT = new IPullingFoundationT();
			this.UnPackTo(pullingFoundationT);
			return pullingFoundationT;
		}

		// Token: 0x06027FEC RID: 163820 RVA: 0x005787DC File Offset: 0x005769DC
		public void UnPackTo(IPullingFoundationT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027FED RID: 163821 RVA: 0x00578830 File Offset: 0x00576A30
		public static Offset<IPullingFoundation> Pack(FlatBufferBuilder builder, IPullingFoundationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPullingFoundation>);
			}
			Offset<IPullingCategoryMatchingFoundation> configOffset = (_o.Config == null) ? default(Offset<IPullingCategoryMatchingFoundation>) : IPullingCategoryMatchingFoundation.Pack(builder, _o.Config);
			return IPullingFoundation.CreateIPullingFoundation(builder, _o.Disabled, configOffset, _o.NullMask);
		}

		// Token: 0x0400F970 RID: 63856
		private Table __p;
	}
}
