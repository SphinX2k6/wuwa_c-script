using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200586A RID: 22634
	public struct IRewardRefreshConfig : IFlatbufferObject
	{
		// Token: 0x1700A94A RID: 43338
		// (get) Token: 0x0602621F RID: 156191 RVA: 0x00542084 File Offset: 0x00540284
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026220 RID: 156192 RVA: 0x00542091 File Offset: 0x00540291
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026221 RID: 156193 RVA: 0x00542098 File Offset: 0x00540298
		public static IRewardRefreshConfig GetRootAsIRewardRefreshConfig(ByteBuffer _bb)
		{
			return IRewardRefreshConfig.GetRootAsIRewardRefreshConfig(_bb, default(IRewardRefreshConfig));
		}

		// Token: 0x06026222 RID: 156194 RVA: 0x005420B4 File Offset: 0x005402B4
		public static IRewardRefreshConfig GetRootAsIRewardRefreshConfig(ByteBuffer _bb, IRewardRefreshConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026223 RID: 156195 RVA: 0x005420D1 File Offset: 0x005402D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026224 RID: 156196 RVA: 0x005420E0 File Offset: 0x005402E0
		public IRewardRefreshConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A94B RID: 43339
		// (get) Token: 0x06026225 RID: 156197 RVA: 0x005420F0 File Offset: 0x005402F0
		public TRefreshCondition RefreshConditionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TRefreshCondition.NONE;
				}
				return (TRefreshCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026226 RID: 156198 RVA: 0x0054212C File Offset: 0x0054032C
		public TTable? RefreshCondition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026227 RID: 156199 RVA: 0x00542170 File Offset: 0x00540370
		public IRefreshOnDeath RefreshConditionAsIRefreshOnDeath()
		{
			return this.RefreshCondition<IRefreshOnDeath>().Value;
		}

		// Token: 0x06026228 RID: 156200 RVA: 0x0054218C File Offset: 0x0054038C
		public IRefreshOnHostInteract RefreshConditionAsIRefreshOnHostInteract()
		{
			return this.RefreshCondition<IRefreshOnHostInteract>().Value;
		}

		// Token: 0x1700A94C RID: 43340
		// (get) Token: 0x06026229 RID: 156201 RVA: 0x005421A8 File Offset: 0x005403A8
		public TRefreshRule RefreshTypeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TRefreshRule.NONE;
				}
				return (TRefreshRule)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602622A RID: 156202 RVA: 0x005421E4 File Offset: 0x005403E4
		public TTable? RefreshType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602622B RID: 156203 RVA: 0x0054222C File Offset: 0x0054042C
		public ICdRefreshRule RefreshTypeAsICdRefreshRule()
		{
			return this.RefreshType<ICdRefreshRule>().Value;
		}

		// Token: 0x0602622C RID: 156204 RVA: 0x00542248 File Offset: 0x00540448
		public IFixedDateTimeRefreshRule RefreshTypeAsIFixedDateTimeRefreshRule()
		{
			return this.RefreshType<IFixedDateTimeRefreshRule>().Value;
		}

		// Token: 0x0602622D RID: 156205 RVA: 0x00542264 File Offset: 0x00540464
		public IRandomNpcRule RefreshTypeAsIRandomNpcRule()
		{
			return this.RefreshType<IRandomNpcRule>().Value;
		}

		// Token: 0x1700A94D RID: 43341
		// (get) Token: 0x0602622E RID: 156206 RVA: 0x00542280 File Offset: 0x00540480
		public int MaxCount
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A94E RID: 43342
		// (get) Token: 0x0602622F RID: 156207 RVA: 0x005422C0 File Offset: 0x005404C0
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

		// Token: 0x06026230 RID: 156208 RVA: 0x005422FD File Offset: 0x005404FD
		public static Offset<IRewardRefreshConfig> CreateIRewardRefreshConfig(FlatBufferBuilder builder, TRefreshCondition RefreshCondition_type = TRefreshCondition.NONE, int RefreshConditionOffset = 0, TRefreshRule RefreshType_type = TRefreshRule.NONE, int RefreshTypeOffset = 0, int MaxCount = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			IRewardRefreshConfig.AddMaxCount(builder, MaxCount);
			IRewardRefreshConfig.AddRefreshType(builder, RefreshTypeOffset);
			IRewardRefreshConfig.AddRefreshCondition(builder, RefreshConditionOffset);
			IRewardRefreshConfig.AddNullMask(builder, NullMask);
			IRewardRefreshConfig.AddRefreshTypeType(builder, RefreshType_type);
			IRewardRefreshConfig.AddRefreshConditionType(builder, RefreshCondition_type);
			return IRewardRefreshConfig.EndIRewardRefreshConfig(builder);
		}

		// Token: 0x06026231 RID: 156209 RVA: 0x00542339 File Offset: 0x00540539
		public static void StartIRewardRefreshConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06026232 RID: 156210 RVA: 0x00542342 File Offset: 0x00540542
		public static void AddRefreshConditionType(FlatBufferBuilder builder, TRefreshCondition refreshConditionType)
		{
			builder.AddByte(0, (byte)refreshConditionType, 0);
		}

		// Token: 0x06026233 RID: 156211 RVA: 0x0054234D File Offset: 0x0054054D
		public static void AddRefreshCondition(FlatBufferBuilder builder, int refreshConditionOffset)
		{
			builder.AddOffset(1, refreshConditionOffset, 0);
		}

		// Token: 0x06026234 RID: 156212 RVA: 0x00542358 File Offset: 0x00540558
		public static void AddRefreshTypeType(FlatBufferBuilder builder, TRefreshRule refreshTypeType)
		{
			builder.AddByte(2, (byte)refreshTypeType, 0);
		}

		// Token: 0x06026235 RID: 156213 RVA: 0x00542363 File Offset: 0x00540563
		public static void AddRefreshType(FlatBufferBuilder builder, int refreshTypeOffset)
		{
			builder.AddOffset(3, refreshTypeOffset, 0);
		}

		// Token: 0x06026236 RID: 156214 RVA: 0x0054236E File Offset: 0x0054056E
		public static void AddMaxCount(FlatBufferBuilder builder, int maxCount)
		{
			builder.AddInt(4, maxCount, 0);
		}

		// Token: 0x06026237 RID: 156215 RVA: 0x00542379 File Offset: 0x00540579
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06026238 RID: 156216 RVA: 0x00542384 File Offset: 0x00540584
		public static Offset<IRewardRefreshConfig> EndIRewardRefreshConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRewardRefreshConfig>(builder.EndTable());
		}

		// Token: 0x06026239 RID: 156217 RVA: 0x00542394 File Offset: 0x00540594
		public IRewardRefreshConfigT UnPack()
		{
			IRewardRefreshConfigT rewardRefreshConfigT = new IRewardRefreshConfigT();
			this.UnPackTo(rewardRefreshConfigT);
			return rewardRefreshConfigT;
		}

		// Token: 0x0602623A RID: 156218 RVA: 0x005423B0 File Offset: 0x005405B0
		public void UnPackTo(IRewardRefreshConfigT _o)
		{
			_o.RefreshCondition = new TRefreshConditionUnion();
			_o.RefreshCondition.Type = this.RefreshConditionType;
			TRefreshCondition refreshConditionType = this.RefreshConditionType;
			if (refreshConditionType != TRefreshCondition.IRefreshOnDeath)
			{
				if (refreshConditionType == TRefreshCondition.IRefreshOnHostInteract)
				{
					_o.RefreshCondition.Value = ((this.RefreshCondition<IRefreshOnHostInteract>() != null) ? this.RefreshCondition<IRefreshOnHostInteract>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.RefreshCondition.Value = ((this.RefreshCondition<IRefreshOnDeath>() != null) ? this.RefreshCondition<IRefreshOnDeath>().Value.UnPack() : null);
			}
			_o.RefreshType = new TRefreshRuleUnion();
			_o.RefreshType.Type = this.RefreshTypeType;
			switch (this.RefreshTypeType)
			{
			case TRefreshRule.ICdRefreshRule:
				_o.RefreshType.Value = ((this.RefreshType<ICdRefreshRule>() != null) ? this.RefreshType<ICdRefreshRule>().Value.UnPack() : null);
				break;
			case TRefreshRule.IFixedDateTimeRefreshRule:
				_o.RefreshType.Value = ((this.RefreshType<IFixedDateTimeRefreshRule>() != null) ? this.RefreshType<IFixedDateTimeRefreshRule>().Value.UnPack() : null);
				break;
			case TRefreshRule.IRandomNpcRule:
				_o.RefreshType.Value = ((this.RefreshType<IRandomNpcRule>() != null) ? this.RefreshType<IRandomNpcRule>().Value.UnPack() : null);
				break;
			}
			_o.MaxCount = this.MaxCount;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602623B RID: 156219 RVA: 0x00542554 File Offset: 0x00540754
		public static Offset<IRewardRefreshConfig> Pack(FlatBufferBuilder builder, IRewardRefreshConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRewardRefreshConfig>);
			}
			TRefreshCondition refreshCondition_type = (_o.RefreshCondition == null) ? TRefreshCondition.NONE : _o.RefreshCondition.Type;
			int refreshConditionOffset = (_o.RefreshCondition == null) ? 0 : TRefreshConditionUnion.Pack(builder, _o.RefreshCondition);
			TRefreshRule refreshType_type = (_o.RefreshType == null) ? TRefreshRule.NONE : _o.RefreshType.Type;
			int refreshTypeOffset = (_o.RefreshType == null) ? 0 : TRefreshRuleUnion.Pack(builder, _o.RefreshType);
			return IRewardRefreshConfig.CreateIRewardRefreshConfig(builder, refreshCondition_type, refreshConditionOffset, refreshType_type, refreshTypeOffset, _o.MaxCount, _o.NullMask);
		}

		// Token: 0x0400EDAC RID: 60844
		private Table __p;
	}
}
