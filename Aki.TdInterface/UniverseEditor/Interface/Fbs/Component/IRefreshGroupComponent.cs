using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E30 RID: 24112
	public struct IRefreshGroupComponent : IFlatbufferObject
	{
		// Token: 0x1700B1B8 RID: 45496
		// (get) Token: 0x0602845C RID: 164956 RVA: 0x005819D5 File Offset: 0x0057FBD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602845D RID: 164957 RVA: 0x005819E2 File Offset: 0x0057FBE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602845E RID: 164958 RVA: 0x005819EC File Offset: 0x0057FBEC
		public static IRefreshGroupComponent GetRootAsIRefreshGroupComponent(ByteBuffer _bb)
		{
			return IRefreshGroupComponent.GetRootAsIRefreshGroupComponent(_bb, default(IRefreshGroupComponent));
		}

		// Token: 0x0602845F RID: 164959 RVA: 0x00581A08 File Offset: 0x0057FC08
		public static IRefreshGroupComponent GetRootAsIRefreshGroupComponent(ByteBuffer _bb, IRefreshGroupComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028460 RID: 164960 RVA: 0x00581A25 File Offset: 0x0057FC25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028461 RID: 164961 RVA: 0x00581A34 File Offset: 0x0057FC34
		public IRefreshGroupComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1B9 RID: 45497
		// (get) Token: 0x06028462 RID: 164962 RVA: 0x00581A44 File Offset: 0x0057FC44
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06028463 RID: 164963 RVA: 0x00581A84 File Offset: 0x0057FC84
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B1BA RID: 45498
		// (get) Token: 0x06028464 RID: 164964 RVA: 0x00581AC4 File Offset: 0x0057FCC4
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06028465 RID: 164965 RVA: 0x00581AEF File Offset: 0x0057FCEF
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06028466 RID: 164966 RVA: 0x00581AFE File Offset: 0x0057FCFE
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700B1BB RID: 45499
		// (get) Token: 0x06028467 RID: 164967 RVA: 0x00581B0C File Offset: 0x0057FD0C
		public TRefreshContent RefreshContentType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TRefreshContent.NONE;
				}
				return (TRefreshContent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028468 RID: 164968 RVA: 0x00581B48 File Offset: 0x0057FD48
		public TTable? RefreshContent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028469 RID: 164969 RVA: 0x00581B90 File Offset: 0x0057FD90
		public IAllRefreshContent RefreshContentAsIAllRefreshContent()
		{
			return this.RefreshContent<IAllRefreshContent>().Value;
		}

		// Token: 0x0602846A RID: 164970 RVA: 0x00581BAC File Offset: 0x0057FDAC
		public IRandomEntityRefreshContent RefreshContentAsIRandomEntityRefreshContent()
		{
			return this.RefreshContent<IRandomEntityRefreshContent>().Value;
		}

		// Token: 0x1700B1BC RID: 45500
		// (get) Token: 0x0602846B RID: 164971 RVA: 0x00581BC8 File Offset: 0x0057FDC8
		public TRefreshRule RefreshRuleType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TRefreshRule.NONE;
				}
				return (TRefreshRule)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602846C RID: 164972 RVA: 0x00581C08 File Offset: 0x0057FE08
		public TTable? RefreshRule<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602846D RID: 164973 RVA: 0x00581C50 File Offset: 0x0057FE50
		public ICdRefreshRule RefreshRuleAsICdRefreshRule()
		{
			return this.RefreshRule<ICdRefreshRule>().Value;
		}

		// Token: 0x0602846E RID: 164974 RVA: 0x00581C6C File Offset: 0x0057FE6C
		public IFixedDateTimeRefreshRule RefreshRuleAsIFixedDateTimeRefreshRule()
		{
			return this.RefreshRule<IFixedDateTimeRefreshRule>().Value;
		}

		// Token: 0x0602846F RID: 164975 RVA: 0x00581C88 File Offset: 0x0057FE88
		public IRandomNpcRule RefreshRuleAsIRandomNpcRule()
		{
			return this.RefreshRule<IRandomNpcRule>().Value;
		}

		// Token: 0x1700B1BD RID: 45501
		// (get) Token: 0x06028470 RID: 164976 RVA: 0x00581CA4 File Offset: 0x0057FEA4
		public IStateChangeConfig? StateChangeConfig
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IStateChangeConfig?(default(IStateChangeConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B1BE RID: 45502
		// (get) Token: 0x06028471 RID: 164977 RVA: 0x00581D04 File Offset: 0x0057FF04
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028472 RID: 164978 RVA: 0x00581D44 File Offset: 0x0057FF44
		public static Offset<IRefreshGroupComponent> CreateIRefreshGroupComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset EntityIdsOffset = default(VectorOffset), TRefreshContent RefreshContent_type = TRefreshContent.NONE, int RefreshContentOffset = 0, TRefreshRule RefreshRule_type = TRefreshRule.NONE, int RefreshRuleOffset = 0, Offset<IStateChangeConfig> StateChangeConfigOffset = default(Offset<IStateChangeConfig>), byte NullMask = 0)
		{
			builder.StartTable(8);
			IRefreshGroupComponent.AddStateChangeConfig(builder, StateChangeConfigOffset);
			IRefreshGroupComponent.AddRefreshRule(builder, RefreshRuleOffset);
			IRefreshGroupComponent.AddRefreshContent(builder, RefreshContentOffset);
			IRefreshGroupComponent.AddEntityIds(builder, EntityIdsOffset);
			IRefreshGroupComponent.AddNullMask(builder, NullMask);
			IRefreshGroupComponent.AddRefreshRuleType(builder, RefreshRule_type);
			IRefreshGroupComponent.AddRefreshContentType(builder, RefreshContent_type);
			IRefreshGroupComponent.AddDisabled(builder, Disabled);
			return IRefreshGroupComponent.EndIRefreshGroupComponent(builder);
		}

		// Token: 0x06028473 RID: 164979 RVA: 0x00581D9B File Offset: 0x0057FF9B
		public static void StartIRefreshGroupComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06028474 RID: 164980 RVA: 0x00581DA4 File Offset: 0x0057FFA4
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028475 RID: 164981 RVA: 0x00581DAF File Offset: 0x0057FFAF
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06028476 RID: 164982 RVA: 0x00581DC0 File Offset: 0x0057FFC0
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06028477 RID: 164983 RVA: 0x00581DF7 File Offset: 0x0057FFF7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06028478 RID: 164984 RVA: 0x00581E11 File Offset: 0x00580011
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06028479 RID: 164985 RVA: 0x00581E2F File Offset: 0x0058002F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602847A RID: 164986 RVA: 0x00581E48 File Offset: 0x00580048
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602847B RID: 164987 RVA: 0x00581E53 File Offset: 0x00580053
		public static void AddRefreshContentType(FlatBufferBuilder builder, TRefreshContent refreshContentType)
		{
			builder.AddByte(2, (byte)refreshContentType, 0);
		}

		// Token: 0x0602847C RID: 164988 RVA: 0x00581E5E File Offset: 0x0058005E
		public static void AddRefreshContent(FlatBufferBuilder builder, int refreshContentOffset)
		{
			builder.AddOffset(3, refreshContentOffset, 0);
		}

		// Token: 0x0602847D RID: 164989 RVA: 0x00581E69 File Offset: 0x00580069
		public static void AddRefreshRuleType(FlatBufferBuilder builder, TRefreshRule refreshRuleType)
		{
			builder.AddByte(4, (byte)refreshRuleType, 0);
		}

		// Token: 0x0602847E RID: 164990 RVA: 0x00581E74 File Offset: 0x00580074
		public static void AddRefreshRule(FlatBufferBuilder builder, int refreshRuleOffset)
		{
			builder.AddOffset(5, refreshRuleOffset, 0);
		}

		// Token: 0x0602847F RID: 164991 RVA: 0x00581E7F File Offset: 0x0058007F
		public static void AddStateChangeConfig(FlatBufferBuilder builder, Offset<IStateChangeConfig> stateChangeConfigOffset)
		{
			builder.AddOffset(6, stateChangeConfigOffset.Value, 0);
		}

		// Token: 0x06028480 RID: 164992 RVA: 0x00581E8F File Offset: 0x0058008F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06028481 RID: 164993 RVA: 0x00581E9A File Offset: 0x0058009A
		public static Offset<IRefreshGroupComponent> EndIRefreshGroupComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshGroupComponent>(builder.EndTable());
		}

		// Token: 0x06028482 RID: 164994 RVA: 0x00581EA8 File Offset: 0x005800A8
		public IRefreshGroupComponentT UnPack()
		{
			IRefreshGroupComponentT refreshGroupComponentT = new IRefreshGroupComponentT();
			this.UnPackTo(refreshGroupComponentT);
			return refreshGroupComponentT;
		}

		// Token: 0x06028483 RID: 164995 RVA: 0x00581EC4 File Offset: 0x005800C4
		public void UnPackTo(IRefreshGroupComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.RefreshContent = new TRefreshContentUnion();
			_o.RefreshContent.Type = this.RefreshContentType;
			TRefreshContent refreshContentType = this.RefreshContentType;
			if (refreshContentType != TRefreshContent.IAllRefreshContent)
			{
				if (refreshContentType == TRefreshContent.IRandomEntityRefreshContent)
				{
					_o.RefreshContent.Value = ((this.RefreshContent<IRandomEntityRefreshContent>() != null) ? this.RefreshContent<IRandomEntityRefreshContent>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.RefreshContent.Value = ((this.RefreshContent<IAllRefreshContent>() != null) ? this.RefreshContent<IAllRefreshContent>().Value.UnPack() : null);
			}
			_o.RefreshRule = new TRefreshRuleUnion();
			_o.RefreshRule.Type = this.RefreshRuleType;
			switch (this.RefreshRuleType)
			{
			case TRefreshRule.ICdRefreshRule:
				_o.RefreshRule.Value = ((this.RefreshRule<ICdRefreshRule>() != null) ? this.RefreshRule<ICdRefreshRule>().Value.UnPack() : null);
				break;
			case TRefreshRule.IFixedDateTimeRefreshRule:
				_o.RefreshRule.Value = ((this.RefreshRule<IFixedDateTimeRefreshRule>() != null) ? this.RefreshRule<IFixedDateTimeRefreshRule>().Value.UnPack() : null);
				break;
			case TRefreshRule.IRandomNpcRule:
				_o.RefreshRule.Value = ((this.RefreshRule<IRandomNpcRule>() != null) ? this.RefreshRule<IRandomNpcRule>().Value.UnPack() : null);
				break;
			}
			_o.StateChangeConfig = ((this.StateChangeConfig != null) ? this.StateChangeConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028484 RID: 164996 RVA: 0x005820CC File Offset: 0x005802CC
		public static Offset<IRefreshGroupComponent> Pack(FlatBufferBuilder builder, IRefreshGroupComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefreshGroupComponent>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IRefreshGroupComponent.CreateEntityIdsVector(builder, data);
			}
			TRefreshContent refreshContent_type = (_o.RefreshContent == null) ? TRefreshContent.NONE : _o.RefreshContent.Type;
			int refreshContentOffset = (_o.RefreshContent == null) ? 0 : TRefreshContentUnion.Pack(builder, _o.RefreshContent);
			TRefreshRule refreshRule_type = (_o.RefreshRule == null) ? TRefreshRule.NONE : _o.RefreshRule.Type;
			int refreshRuleOffset = (_o.RefreshRule == null) ? 0 : TRefreshRuleUnion.Pack(builder, _o.RefreshRule);
			Offset<IStateChangeConfig> stateChangeConfigOffset = (_o.StateChangeConfig == null) ? default(Offset<IStateChangeConfig>) : IStateChangeConfig.Pack(builder, _o.StateChangeConfig);
			return IRefreshGroupComponent.CreateIRefreshGroupComponent(builder, _o.Disabled, entityIdsOffset, refreshContent_type, refreshContentOffset, refreshRule_type, refreshRuleOffset, stateChangeConfigOffset, _o.NullMask);
		}

		// Token: 0x0400FA23 RID: 64035
		private Table __p;
	}
}
