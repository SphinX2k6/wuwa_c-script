using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057AE RID: 22446
	public struct IPullingFoundation : IFlatbufferObject
	{
		// Token: 0x1700A791 RID: 42897
		// (get) Token: 0x06025ABC RID: 154300 RVA: 0x0053248B File Offset: 0x0053068B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025ABD RID: 154301 RVA: 0x00532498 File Offset: 0x00530698
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025ABE RID: 154302 RVA: 0x005324A0 File Offset: 0x005306A0
		public static IPullingFoundation GetRootAsIPullingFoundation(ByteBuffer _bb)
		{
			return IPullingFoundation.GetRootAsIPullingFoundation(_bb, default(IPullingFoundation));
		}

		// Token: 0x06025ABF RID: 154303 RVA: 0x005324BC File Offset: 0x005306BC
		public static IPullingFoundation GetRootAsIPullingFoundation(ByteBuffer _bb, IPullingFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025AC0 RID: 154304 RVA: 0x005324D9 File Offset: 0x005306D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025AC1 RID: 154305 RVA: 0x005324E8 File Offset: 0x005306E8
		public IPullingFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A792 RID: 42898
		// (get) Token: 0x06025AC2 RID: 154306 RVA: 0x005324F8 File Offset: 0x005306F8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A793 RID: 42899
		// (get) Token: 0x06025AC3 RID: 154307 RVA: 0x00532538 File Offset: 0x00530738
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

		// Token: 0x1700A794 RID: 42900
		// (get) Token: 0x06025AC4 RID: 154308 RVA: 0x00532598 File Offset: 0x00530798
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

		// Token: 0x06025AC5 RID: 154309 RVA: 0x005325D4 File Offset: 0x005307D4
		public static Offset<IPullingFoundation> CreateIPullingFoundation(FlatBufferBuilder builder, bool Disabled = false, Offset<IPullingCategoryMatchingFoundation> ConfigOffset = default(Offset<IPullingCategoryMatchingFoundation>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IPullingFoundation.AddConfig(builder, ConfigOffset);
			IPullingFoundation.AddNullMask(builder, NullMask);
			IPullingFoundation.AddDisabled(builder, Disabled);
			return IPullingFoundation.EndIPullingFoundation(builder);
		}

		// Token: 0x06025AC6 RID: 154310 RVA: 0x005325F8 File Offset: 0x005307F8
		public static void StartIPullingFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06025AC7 RID: 154311 RVA: 0x00532601 File Offset: 0x00530801
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025AC8 RID: 154312 RVA: 0x0053260C File Offset: 0x0053080C
		public static void AddConfig(FlatBufferBuilder builder, Offset<IPullingCategoryMatchingFoundation> configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x06025AC9 RID: 154313 RVA: 0x0053261C File Offset: 0x0053081C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06025ACA RID: 154314 RVA: 0x00532627 File Offset: 0x00530827
		public static Offset<IPullingFoundation> EndIPullingFoundation(FlatBufferBuilder builder)
		{
			return new Offset<IPullingFoundation>(builder.EndTable());
		}

		// Token: 0x06025ACB RID: 154315 RVA: 0x00532634 File Offset: 0x00530834
		public IPullingFoundationT UnPack()
		{
			IPullingFoundationT pullingFoundationT = new IPullingFoundationT();
			this.UnPackTo(pullingFoundationT);
			return pullingFoundationT;
		}

		// Token: 0x06025ACC RID: 154316 RVA: 0x00532650 File Offset: 0x00530850
		public void UnPackTo(IPullingFoundationT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025ACD RID: 154317 RVA: 0x005326A4 File Offset: 0x005308A4
		public static Offset<IPullingFoundation> Pack(FlatBufferBuilder builder, IPullingFoundationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPullingFoundation>);
			}
			Offset<IPullingCategoryMatchingFoundation> configOffset = (_o.Config == null) ? default(Offset<IPullingCategoryMatchingFoundation>) : IPullingCategoryMatchingFoundation.Pack(builder, _o.Config);
			return IPullingFoundation.CreateIPullingFoundation(builder, _o.Disabled, configOffset, _o.NullMask);
		}

		// Token: 0x0400EC85 RID: 60549
		private Table __p;
	}
}
