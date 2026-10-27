using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005829 RID: 22569
	public struct IRefreshGroupComponent : IFlatbufferObject
	{
		// Token: 0x1700A894 RID: 43156
		// (get) Token: 0x06025F3C RID: 155452 RVA: 0x0053B849 File Offset: 0x00539A49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025F3D RID: 155453 RVA: 0x0053B856 File Offset: 0x00539A56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025F3E RID: 155454 RVA: 0x0053B860 File Offset: 0x00539A60
		public static IRefreshGroupComponent GetRootAsIRefreshGroupComponent(ByteBuffer _bb)
		{
			return IRefreshGroupComponent.GetRootAsIRefreshGroupComponent(_bb, default(IRefreshGroupComponent));
		}

		// Token: 0x06025F3F RID: 155455 RVA: 0x0053B87C File Offset: 0x00539A7C
		public static IRefreshGroupComponent GetRootAsIRefreshGroupComponent(ByteBuffer _bb, IRefreshGroupComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025F40 RID: 155456 RVA: 0x0053B899 File Offset: 0x00539A99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025F41 RID: 155457 RVA: 0x0053B8A8 File Offset: 0x00539AA8
		public IRefreshGroupComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A895 RID: 43157
		// (get) Token: 0x06025F42 RID: 155458 RVA: 0x0053B8B8 File Offset: 0x00539AB8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06025F43 RID: 155459 RVA: 0x0053B8F8 File Offset: 0x00539AF8
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A896 RID: 43158
		// (get) Token: 0x06025F44 RID: 155460 RVA: 0x0053B938 File Offset: 0x00539B38
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

		// Token: 0x06025F45 RID: 155461 RVA: 0x0053B963 File Offset: 0x00539B63
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06025F46 RID: 155462 RVA: 0x0053B972 File Offset: 0x00539B72
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700A897 RID: 43159
		// (get) Token: 0x06025F47 RID: 155463 RVA: 0x0053B980 File Offset: 0x00539B80
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

		// Token: 0x06025F48 RID: 155464 RVA: 0x0053B9BC File Offset: 0x00539BBC
		public TTable? RefreshContent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025F49 RID: 155465 RVA: 0x0053BA04 File Offset: 0x00539C04
		public IAllRefreshContent RefreshContentAsIAllRefreshContent()
		{
			return this.RefreshContent<IAllRefreshContent>().Value;
		}

		// Token: 0x06025F4A RID: 155466 RVA: 0x0053BA20 File Offset: 0x00539C20
		public IRandomEntityRefreshContent RefreshContentAsIRandomEntityRefreshContent()
		{
			return this.RefreshContent<IRandomEntityRefreshContent>().Value;
		}

		// Token: 0x1700A898 RID: 43160
		// (get) Token: 0x06025F4B RID: 155467 RVA: 0x0053BA3C File Offset: 0x00539C3C
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

		// Token: 0x06025F4C RID: 155468 RVA: 0x0053BA7C File Offset: 0x00539C7C
		public TTable? RefreshRule<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025F4D RID: 155469 RVA: 0x0053BAC4 File Offset: 0x00539CC4
		public ICdRefreshRule RefreshRuleAsICdRefreshRule()
		{
			return this.RefreshRule<ICdRefreshRule>().Value;
		}

		// Token: 0x06025F4E RID: 155470 RVA: 0x0053BAE0 File Offset: 0x00539CE0
		public IFixedDateTimeRefreshRule RefreshRuleAsIFixedDateTimeRefreshRule()
		{
			return this.RefreshRule<IFixedDateTimeRefreshRule>().Value;
		}

		// Token: 0x06025F4F RID: 155471 RVA: 0x0053BAFC File Offset: 0x00539CFC
		public IRandomNpcRule RefreshRuleAsIRandomNpcRule()
		{
			return this.RefreshRule<IRandomNpcRule>().Value;
		}

		// Token: 0x1700A899 RID: 43161
		// (get) Token: 0x06025F50 RID: 155472 RVA: 0x0053BB18 File Offset: 0x00539D18
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

		// Token: 0x1700A89A RID: 43162
		// (get) Token: 0x06025F51 RID: 155473 RVA: 0x0053BB78 File Offset: 0x00539D78
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

		// Token: 0x06025F52 RID: 155474 RVA: 0x0053BBB8 File Offset: 0x00539DB8
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

		// Token: 0x06025F53 RID: 155475 RVA: 0x0053BC0F File Offset: 0x00539E0F
		public static void StartIRefreshGroupComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06025F54 RID: 155476 RVA: 0x0053BC18 File Offset: 0x00539E18
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025F55 RID: 155477 RVA: 0x0053BC23 File Offset: 0x00539E23
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06025F56 RID: 155478 RVA: 0x0053BC34 File Offset: 0x00539E34
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06025F57 RID: 155479 RVA: 0x0053BC6B File Offset: 0x00539E6B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06025F58 RID: 155480 RVA: 0x0053BC85 File Offset: 0x00539E85
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06025F59 RID: 155481 RVA: 0x0053BCA3 File Offset: 0x00539EA3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025F5A RID: 155482 RVA: 0x0053BCBC File Offset: 0x00539EBC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025F5B RID: 155483 RVA: 0x0053BCC7 File Offset: 0x00539EC7
		public static void AddRefreshContentType(FlatBufferBuilder builder, TRefreshContent refreshContentType)
		{
			builder.AddByte(2, (byte)refreshContentType, 0);
		}

		// Token: 0x06025F5C RID: 155484 RVA: 0x0053BCD2 File Offset: 0x00539ED2
		public static void AddRefreshContent(FlatBufferBuilder builder, int refreshContentOffset)
		{
			builder.AddOffset(3, refreshContentOffset, 0);
		}

		// Token: 0x06025F5D RID: 155485 RVA: 0x0053BCDD File Offset: 0x00539EDD
		public static void AddRefreshRuleType(FlatBufferBuilder builder, TRefreshRule refreshRuleType)
		{
			builder.AddByte(4, (byte)refreshRuleType, 0);
		}

		// Token: 0x06025F5E RID: 155486 RVA: 0x0053BCE8 File Offset: 0x00539EE8
		public static void AddRefreshRule(FlatBufferBuilder builder, int refreshRuleOffset)
		{
			builder.AddOffset(5, refreshRuleOffset, 0);
		}

		// Token: 0x06025F5F RID: 155487 RVA: 0x0053BCF3 File Offset: 0x00539EF3
		public static void AddStateChangeConfig(FlatBufferBuilder builder, Offset<IStateChangeConfig> stateChangeConfigOffset)
		{
			builder.AddOffset(6, stateChangeConfigOffset.Value, 0);
		}

		// Token: 0x06025F60 RID: 155488 RVA: 0x0053BD03 File Offset: 0x00539F03
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06025F61 RID: 155489 RVA: 0x0053BD0E File Offset: 0x00539F0E
		public static Offset<IRefreshGroupComponent> EndIRefreshGroupComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshGroupComponent>(builder.EndTable());
		}

		// Token: 0x06025F62 RID: 155490 RVA: 0x0053BD1C File Offset: 0x00539F1C
		public IRefreshGroupComponentT UnPack()
		{
			IRefreshGroupComponentT refreshGroupComponentT = new IRefreshGroupComponentT();
			this.UnPackTo(refreshGroupComponentT);
			return refreshGroupComponentT;
		}

		// Token: 0x06025F63 RID: 155491 RVA: 0x0053BD38 File Offset: 0x00539F38
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

		// Token: 0x06025F64 RID: 155492 RVA: 0x0053BF40 File Offset: 0x0053A140
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

		// Token: 0x0400ED38 RID: 60728
		private Table __p;
	}
}
