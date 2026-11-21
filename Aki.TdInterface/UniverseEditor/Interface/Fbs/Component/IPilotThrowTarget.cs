using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D49 RID: 23881
	public struct IPilotThrowTarget : IFlatbufferObject
	{
		// Token: 0x1700AFC6 RID: 44998
		// (get) Token: 0x06027BE9 RID: 162793 RVA: 0x00570434 File Offset: 0x0056E634
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027BEA RID: 162794 RVA: 0x00570441 File Offset: 0x0056E641
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027BEB RID: 162795 RVA: 0x00570448 File Offset: 0x0056E648
		public static IPilotThrowTarget GetRootAsIPilotThrowTarget(ByteBuffer _bb)
		{
			return IPilotThrowTarget.GetRootAsIPilotThrowTarget(_bb, default(IPilotThrowTarget));
		}

		// Token: 0x06027BEC RID: 162796 RVA: 0x00570464 File Offset: 0x0056E664
		public static IPilotThrowTarget GetRootAsIPilotThrowTarget(ByteBuffer _bb, IPilotThrowTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027BED RID: 162797 RVA: 0x00570481 File Offset: 0x0056E681
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027BEE RID: 162798 RVA: 0x00570490 File Offset: 0x0056E690
		public IPilotThrowTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFC7 RID: 44999
		// (get) Token: 0x06027BEF RID: 162799 RVA: 0x005704A0 File Offset: 0x0056E6A0
		public string TidTargetName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027BF0 RID: 162800 RVA: 0x005704D7 File Offset: 0x0056E6D7
		public Span<byte> GetTidTargetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06027BF1 RID: 162801 RVA: 0x005704E6 File Offset: 0x0056E6E6
		public byte[] GetTidTargetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700AFC8 RID: 45000
		// (get) Token: 0x06027BF2 RID: 162802 RVA: 0x005704F4 File Offset: 0x0056E6F4
		public IVectorInfo? Position
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AFC9 RID: 45001
		// (get) Token: 0x06027BF3 RID: 162803 RVA: 0x00570554 File Offset: 0x0056E754
		public EPilotThrowPointVisualType VisualType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EPilotThrowPointVisualType.Normal;
				}
				return (EPilotThrowPointVisualType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AFCA RID: 45002
		// (get) Token: 0x06027BF4 RID: 162804 RVA: 0x00570590 File Offset: 0x0056E790
		public IConditionGroup? Conditions
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AFCB RID: 45003
		// (get) Token: 0x06027BF5 RID: 162805 RVA: 0x005705F0 File Offset: 0x0056E7F0
		public bool IsQuest
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AFCC RID: 45004
		// (get) Token: 0x06027BF6 RID: 162806 RVA: 0x00570630 File Offset: 0x0056E830
		public float UiScale
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AFCD RID: 45005
		// (get) Token: 0x06027BF7 RID: 162807 RVA: 0x00570674 File Offset: 0x0056E874
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027BF8 RID: 162808 RVA: 0x005706B4 File Offset: 0x0056E8B4
		public static Offset<IPilotThrowTarget> CreateIPilotThrowTarget(FlatBufferBuilder builder, StringOffset TidTargetNameOffset = default(StringOffset), Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), EPilotThrowPointVisualType VisualType = EPilotThrowPointVisualType.Normal, Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>), bool IsQuest = false, float UiScale = 0f, byte NullMask = 0)
		{
			builder.StartTable(7);
			IPilotThrowTarget.AddUiScale(builder, UiScale);
			IPilotThrowTarget.AddConditions(builder, ConditionsOffset);
			IPilotThrowTarget.AddPosition(builder, PositionOffset);
			IPilotThrowTarget.AddTidTargetName(builder, TidTargetNameOffset);
			IPilotThrowTarget.AddNullMask(builder, NullMask);
			IPilotThrowTarget.AddIsQuest(builder, IsQuest);
			IPilotThrowTarget.AddVisualType(builder, VisualType);
			return IPilotThrowTarget.EndIPilotThrowTarget(builder);
		}

		// Token: 0x06027BF9 RID: 162809 RVA: 0x00570703 File Offset: 0x0056E903
		public static void StartIPilotThrowTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06027BFA RID: 162810 RVA: 0x0057070C File Offset: 0x0056E90C
		public static void AddTidTargetName(FlatBufferBuilder builder, StringOffset tidTargetNameOffset)
		{
			builder.AddOffset(0, tidTargetNameOffset.Value, 0);
		}

		// Token: 0x06027BFB RID: 162811 RVA: 0x0057071C File Offset: 0x0056E91C
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x06027BFC RID: 162812 RVA: 0x0057072C File Offset: 0x0056E92C
		public static void AddVisualType(FlatBufferBuilder builder, EPilotThrowPointVisualType visualType)
		{
			builder.AddByte(2, (byte)visualType, 0);
		}

		// Token: 0x06027BFD RID: 162813 RVA: 0x00570737 File Offset: 0x0056E937
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(3, conditionsOffset.Value, 0);
		}

		// Token: 0x06027BFE RID: 162814 RVA: 0x00570747 File Offset: 0x0056E947
		public static void AddIsQuest(FlatBufferBuilder builder, bool isQuest)
		{
			builder.AddBool(4, isQuest, false);
		}

		// Token: 0x06027BFF RID: 162815 RVA: 0x00570752 File Offset: 0x0056E952
		public static void AddUiScale(FlatBufferBuilder builder, float uiScale)
		{
			builder.AddFloat(5, uiScale, 0.0);
		}

		// Token: 0x06027C00 RID: 162816 RVA: 0x00570765 File Offset: 0x0056E965
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06027C01 RID: 162817 RVA: 0x00570770 File Offset: 0x0056E970
		public static Offset<IPilotThrowTarget> EndIPilotThrowTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPilotThrowTarget>(builder.EndTable());
		}

		// Token: 0x06027C02 RID: 162818 RVA: 0x00570780 File Offset: 0x0056E980
		public IPilotThrowTargetT UnPack()
		{
			IPilotThrowTargetT pilotThrowTargetT = new IPilotThrowTargetT();
			this.UnPackTo(pilotThrowTargetT);
			return pilotThrowTargetT;
		}

		// Token: 0x06027C03 RID: 162819 RVA: 0x0057079C File Offset: 0x0056E99C
		public void UnPackTo(IPilotThrowTargetT _o)
		{
			_o.TidTargetName = this.TidTargetName;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.VisualType = this.VisualType;
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
			_o.IsQuest = this.IsQuest;
			_o.UiScale = this.UiScale;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027C04 RID: 162820 RVA: 0x00570844 File Offset: 0x0056EA44
		public static Offset<IPilotThrowTarget> Pack(FlatBufferBuilder builder, IPilotThrowTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPilotThrowTarget>);
			}
			StringOffset tidTargetNameOffset = (_o.TidTargetName == null) ? default(StringOffset) : builder.CreateString(_o.TidTargetName);
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IConditionGroup> conditionsOffset = (_o.Conditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Conditions);
			return IPilotThrowTarget.CreateIPilotThrowTarget(builder, tidTargetNameOffset, positionOffset, _o.VisualType, conditionsOffset, _o.IsQuest, _o.UiScale, _o.NullMask);
		}

		// Token: 0x0400F8C6 RID: 63686
		private Table __p;
	}
}
