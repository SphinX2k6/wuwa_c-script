using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FC3 RID: 24515
	public struct IStateRepPerfItem : IFlatbufferObject
	{
		// Token: 0x1700B589 RID: 46473
		// (get) Token: 0x060293F4 RID: 168948 RVA: 0x005A13A3 File Offset: 0x0059F5A3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060293F5 RID: 168949 RVA: 0x005A13B0 File Offset: 0x0059F5B0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060293F6 RID: 168950 RVA: 0x005A13B8 File Offset: 0x0059F5B8
		public static IStateRepPerfItem GetRootAsIStateRepPerfItem(ByteBuffer _bb)
		{
			return IStateRepPerfItem.GetRootAsIStateRepPerfItem(_bb, default(IStateRepPerfItem));
		}

		// Token: 0x060293F7 RID: 168951 RVA: 0x005A13D4 File Offset: 0x0059F5D4
		public static IStateRepPerfItem GetRootAsIStateRepPerfItem(ByteBuffer _bb, IStateRepPerfItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060293F8 RID: 168952 RVA: 0x005A13F1 File Offset: 0x0059F5F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060293F9 RID: 168953 RVA: 0x005A1400 File Offset: 0x0059F600
		public IStateRepPerfItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B58A RID: 46474
		// (get) Token: 0x060293FA RID: 168954 RVA: 0x005A1410 File Offset: 0x0059F610
		public string StateTag
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

		// Token: 0x060293FB RID: 168955 RVA: 0x005A1447 File Offset: 0x0059F647
		public Span<byte> GetStateTagBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060293FC RID: 168956 RVA: 0x005A1456 File Offset: 0x0059F656
		public byte[] GetStateTagArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B58B RID: 46475
		// (get) Token: 0x060293FD RID: 168957 RVA: 0x005A1464 File Offset: 0x0059F664
		public TStateRepPerf ReplacePerformanceType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TStateRepPerf.NONE;
				}
				return (TStateRepPerf)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060293FE RID: 168958 RVA: 0x005A14A0 File Offset: 0x0059F6A0
		public TTable? ReplacePerformance<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060293FF RID: 168959 RVA: 0x005A14E4 File Offset: 0x0059F6E4
		public IStateRepPerfEffects ReplacePerformanceAsIStateRepPerfEffects()
		{
			return this.ReplacePerformance<IStateRepPerfEffects>().Value;
		}

		// Token: 0x06029400 RID: 168960 RVA: 0x005A1500 File Offset: 0x0059F700
		public IStateRepPerfMontagePath ReplacePerformanceAsIStateRepPerfMontagePath()
		{
			return this.ReplacePerformance<IStateRepPerfMontagePath>().Value;
		}

		// Token: 0x06029401 RID: 168961 RVA: 0x005A151C File Offset: 0x0059F71C
		public IStateRepPerfSkillId ReplacePerformanceAsIStateRepPerfSkillId()
		{
			return this.ReplacePerformance<IStateRepPerfSkillId>().Value;
		}

		// Token: 0x06029402 RID: 168962 RVA: 0x005A1537 File Offset: 0x0059F737
		public static Offset<IStateRepPerfItem> CreateIStateRepPerfItem(FlatBufferBuilder builder, StringOffset StateTagOffset = default(StringOffset), TStateRepPerf ReplacePerformance_type = TStateRepPerf.NONE, int ReplacePerformanceOffset = 0)
		{
			builder.StartTable(3);
			IStateRepPerfItem.AddReplacePerformance(builder, ReplacePerformanceOffset);
			IStateRepPerfItem.AddStateTag(builder, StateTagOffset);
			IStateRepPerfItem.AddReplacePerformanceType(builder, ReplacePerformance_type);
			return IStateRepPerfItem.EndIStateRepPerfItem(builder);
		}

		// Token: 0x06029403 RID: 168963 RVA: 0x005A155B File Offset: 0x0059F75B
		public static void StartIStateRepPerfItem(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06029404 RID: 168964 RVA: 0x005A1564 File Offset: 0x0059F764
		public static void AddStateTag(FlatBufferBuilder builder, StringOffset stateTagOffset)
		{
			builder.AddOffset(0, stateTagOffset.Value, 0);
		}

		// Token: 0x06029405 RID: 168965 RVA: 0x005A1574 File Offset: 0x0059F774
		public static void AddReplacePerformanceType(FlatBufferBuilder builder, TStateRepPerf replacePerformanceType)
		{
			builder.AddByte(1, (byte)replacePerformanceType, 0);
		}

		// Token: 0x06029406 RID: 168966 RVA: 0x005A157F File Offset: 0x0059F77F
		public static void AddReplacePerformance(FlatBufferBuilder builder, int replacePerformanceOffset)
		{
			builder.AddOffset(2, replacePerformanceOffset, 0);
		}

		// Token: 0x06029407 RID: 168967 RVA: 0x005A158A File Offset: 0x0059F78A
		public static Offset<IStateRepPerfItem> EndIStateRepPerfItem(FlatBufferBuilder builder)
		{
			return new Offset<IStateRepPerfItem>(builder.EndTable());
		}

		// Token: 0x06029408 RID: 168968 RVA: 0x005A1598 File Offset: 0x0059F798
		public IStateRepPerfItemT UnPack()
		{
			IStateRepPerfItemT stateRepPerfItemT = new IStateRepPerfItemT();
			this.UnPackTo(stateRepPerfItemT);
			return stateRepPerfItemT;
		}

		// Token: 0x06029409 RID: 168969 RVA: 0x005A15B4 File Offset: 0x0059F7B4
		public void UnPackTo(IStateRepPerfItemT _o)
		{
			_o.StateTag = this.StateTag;
			_o.ReplacePerformance = new TStateRepPerfUnion();
			_o.ReplacePerformance.Type = this.ReplacePerformanceType;
			switch (this.ReplacePerformanceType)
			{
			case TStateRepPerf.IStateRepPerfEffects:
				_o.ReplacePerformance.Value = ((this.ReplacePerformance<IStateRepPerfEffects>() != null) ? this.ReplacePerformance<IStateRepPerfEffects>().Value.UnPack() : null);
				return;
			case TStateRepPerf.IStateRepPerfMontagePath:
				_o.ReplacePerformance.Value = ((this.ReplacePerformance<IStateRepPerfMontagePath>() != null) ? this.ReplacePerformance<IStateRepPerfMontagePath>().Value.UnPack() : null);
				return;
			case TStateRepPerf.IStateRepPerfSkillId:
				_o.ReplacePerformance.Value = ((this.ReplacePerformance<IStateRepPerfSkillId>() != null) ? this.ReplacePerformance<IStateRepPerfSkillId>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602940A RID: 168970 RVA: 0x005A16A8 File Offset: 0x0059F8A8
		public static Offset<IStateRepPerfItem> Pack(FlatBufferBuilder builder, IStateRepPerfItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateRepPerfItem>);
			}
			StringOffset stateTagOffset = (_o.StateTag == null) ? default(StringOffset) : builder.CreateString(_o.StateTag);
			TStateRepPerf replacePerformance_type = (_o.ReplacePerformance == null) ? TStateRepPerf.NONE : _o.ReplacePerformance.Type;
			int replacePerformanceOffset = (_o.ReplacePerformance == null) ? 0 : TStateRepPerfUnion.Pack(builder, _o.ReplacePerformance);
			return IStateRepPerfItem.CreateIStateRepPerfItem(builder, stateTagOffset, replacePerformance_type, replacePerformanceOffset);
		}

		// Token: 0x0400FCBE RID: 64702
		private Table __p;
	}
}
