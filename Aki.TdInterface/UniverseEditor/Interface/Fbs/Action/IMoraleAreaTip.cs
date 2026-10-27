using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B06 RID: 27398
	public struct IMoraleAreaTip : IFlatbufferObject
	{
		// Token: 0x1700CB69 RID: 52073
		// (get) Token: 0x060300CE RID: 196814 RVA: 0x0068858C File Offset: 0x0068678C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060300CF RID: 196815 RVA: 0x00688599 File Offset: 0x00686799
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060300D0 RID: 196816 RVA: 0x006885A0 File Offset: 0x006867A0
		public static IMoraleAreaTip GetRootAsIMoraleAreaTip(ByteBuffer _bb)
		{
			return IMoraleAreaTip.GetRootAsIMoraleAreaTip(_bb, default(IMoraleAreaTip));
		}

		// Token: 0x060300D1 RID: 196817 RVA: 0x006885BC File Offset: 0x006867BC
		public static IMoraleAreaTip GetRootAsIMoraleAreaTip(ByteBuffer _bb, IMoraleAreaTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060300D2 RID: 196818 RVA: 0x006885D9 File Offset: 0x006867D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060300D3 RID: 196819 RVA: 0x006885E8 File Offset: 0x006867E8
		public IMoraleAreaTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB6A RID: 52074
		// (get) Token: 0x060300D4 RID: 196820 RVA: 0x006885F8 File Offset: 0x006867F8
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB6B RID: 52075
		// (get) Token: 0x060300D5 RID: 196821 RVA: 0x00688634 File Offset: 0x00686834
		public string TidAreaNameText
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060300D6 RID: 196822 RVA: 0x0068866B File Offset: 0x0068686B
		public Span<byte> GetTidAreaNameTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060300D7 RID: 196823 RVA: 0x0068867A File Offset: 0x0068687A
		public byte[] GetTidAreaNameTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700CB6C RID: 52076
		// (get) Token: 0x060300D8 RID: 196824 RVA: 0x00688688 File Offset: 0x00686888
		public string TidRecommendText
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060300D9 RID: 196825 RVA: 0x006886BF File Offset: 0x006868BF
		public Span<byte> GetTidRecommendTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060300DA RID: 196826 RVA: 0x006886CE File Offset: 0x006868CE
		public byte[] GetTidRecommendTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700CB6D RID: 52077
		// (get) Token: 0x060300DB RID: 196827 RVA: 0x006886DC File Offset: 0x006868DC
		public EMoraleAreaType AreaType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EMoraleAreaType.MoraleArea1;
				}
				return (EMoraleAreaType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB6E RID: 52078
		// (get) Token: 0x060300DC RID: 196828 RVA: 0x0068871C File Offset: 0x0068691C
		public EMoraleUiType UiType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EMoraleUiType.MoraleUi24;
				}
				return (EMoraleUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB6F RID: 52079
		// (get) Token: 0x060300DD RID: 196829 RVA: 0x0068875C File Offset: 0x0068695C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060300DE RID: 196830 RVA: 0x00688799 File Offset: 0x00686999
		public static Offset<IMoraleAreaTip> CreateIMoraleAreaTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidAreaNameTextOffset = default(StringOffset), StringOffset TidRecommendTextOffset = default(StringOffset), EMoraleAreaType AreaType = EMoraleAreaType.MoraleArea1, EMoraleUiType UiType = EMoraleUiType.MoraleUi24, byte NullMask = 0)
		{
			builder.StartTable(6);
			IMoraleAreaTip.AddTidRecommendText(builder, TidRecommendTextOffset);
			IMoraleAreaTip.AddTidAreaNameText(builder, TidAreaNameTextOffset);
			IMoraleAreaTip.AddNullMask(builder, NullMask);
			IMoraleAreaTip.AddUiType(builder, UiType);
			IMoraleAreaTip.AddAreaType(builder, AreaType);
			IMoraleAreaTip.AddType(builder, Type);
			return IMoraleAreaTip.EndIMoraleAreaTip(builder);
		}

		// Token: 0x060300DF RID: 196831 RVA: 0x006887D5 File Offset: 0x006869D5
		public static void StartIMoraleAreaTip(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060300E0 RID: 196832 RVA: 0x006887DE File Offset: 0x006869DE
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060300E1 RID: 196833 RVA: 0x006887E9 File Offset: 0x006869E9
		public static void AddTidAreaNameText(FlatBufferBuilder builder, StringOffset tidAreaNameTextOffset)
		{
			builder.AddOffset(1, tidAreaNameTextOffset.Value, 0);
		}

		// Token: 0x060300E2 RID: 196834 RVA: 0x006887F9 File Offset: 0x006869F9
		public static void AddTidRecommendText(FlatBufferBuilder builder, StringOffset tidRecommendTextOffset)
		{
			builder.AddOffset(2, tidRecommendTextOffset.Value, 0);
		}

		// Token: 0x060300E3 RID: 196835 RVA: 0x00688809 File Offset: 0x00686A09
		public static void AddAreaType(FlatBufferBuilder builder, EMoraleAreaType areaType)
		{
			builder.AddByte(3, (byte)areaType, 0);
		}

		// Token: 0x060300E4 RID: 196836 RVA: 0x00688814 File Offset: 0x00686A14
		public static void AddUiType(FlatBufferBuilder builder, EMoraleUiType uiType)
		{
			builder.AddByte(4, (byte)uiType, 0);
		}

		// Token: 0x060300E5 RID: 196837 RVA: 0x0068881F File Offset: 0x00686A1F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060300E6 RID: 196838 RVA: 0x0068882A File Offset: 0x00686A2A
		public static Offset<IMoraleAreaTip> EndIMoraleAreaTip(FlatBufferBuilder builder)
		{
			return new Offset<IMoraleAreaTip>(builder.EndTable());
		}

		// Token: 0x060300E7 RID: 196839 RVA: 0x00688838 File Offset: 0x00686A38
		public IMoraleAreaTipT UnPack()
		{
			IMoraleAreaTipT moraleAreaTipT = new IMoraleAreaTipT();
			this.UnPackTo(moraleAreaTipT);
			return moraleAreaTipT;
		}

		// Token: 0x060300E8 RID: 196840 RVA: 0x00688854 File Offset: 0x00686A54
		public void UnPackTo(IMoraleAreaTipT _o)
		{
			_o.Type = this.Type;
			_o.TidAreaNameText = this.TidAreaNameText;
			_o.TidRecommendText = this.TidRecommendText;
			_o.AreaType = this.AreaType;
			_o.UiType = this.UiType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060300E9 RID: 196841 RVA: 0x006888AC File Offset: 0x00686AAC
		public static Offset<IMoraleAreaTip> Pack(FlatBufferBuilder builder, IMoraleAreaTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoraleAreaTip>);
			}
			StringOffset tidAreaNameTextOffset = (_o.TidAreaNameText == null) ? default(StringOffset) : builder.CreateString(_o.TidAreaNameText);
			StringOffset tidRecommendTextOffset = (_o.TidRecommendText == null) ? default(StringOffset) : builder.CreateString(_o.TidRecommendText);
			return IMoraleAreaTip.CreateIMoraleAreaTip(builder, _o.Type, tidAreaNameTextOffset, tidRecommendTextOffset, _o.AreaType, _o.UiType, _o.NullMask);
		}

		// Token: 0x04011377 RID: 70519
		private Table __p;
	}
}
