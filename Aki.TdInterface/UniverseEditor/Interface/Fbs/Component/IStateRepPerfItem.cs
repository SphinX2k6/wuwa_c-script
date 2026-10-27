using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059B6 RID: 22966
	public struct IStateRepPerfItem : IFlatbufferObject
	{
		// Token: 0x1700AC55 RID: 44117
		// (get) Token: 0x06026E8A RID: 159370 RVA: 0x0055A737 File Offset: 0x00558937
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026E8B RID: 159371 RVA: 0x0055A744 File Offset: 0x00558944
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026E8C RID: 159372 RVA: 0x0055A74C File Offset: 0x0055894C
		public static IStateRepPerfItem GetRootAsIStateRepPerfItem(ByteBuffer _bb)
		{
			return IStateRepPerfItem.GetRootAsIStateRepPerfItem(_bb, default(IStateRepPerfItem));
		}

		// Token: 0x06026E8D RID: 159373 RVA: 0x0055A768 File Offset: 0x00558968
		public static IStateRepPerfItem GetRootAsIStateRepPerfItem(ByteBuffer _bb, IStateRepPerfItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026E8E RID: 159374 RVA: 0x0055A785 File Offset: 0x00558985
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026E8F RID: 159375 RVA: 0x0055A794 File Offset: 0x00558994
		public IStateRepPerfItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC56 RID: 44118
		// (get) Token: 0x06026E90 RID: 159376 RVA: 0x0055A7A4 File Offset: 0x005589A4
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

		// Token: 0x06026E91 RID: 159377 RVA: 0x0055A7DB File Offset: 0x005589DB
		public Span<byte> GetStateTagBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026E92 RID: 159378 RVA: 0x0055A7EA File Offset: 0x005589EA
		public byte[] GetStateTagArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700AC57 RID: 44119
		// (get) Token: 0x06026E93 RID: 159379 RVA: 0x0055A7F8 File Offset: 0x005589F8
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

		// Token: 0x06026E94 RID: 159380 RVA: 0x0055A834 File Offset: 0x00558A34
		public TTable? ReplacePerformance<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026E95 RID: 159381 RVA: 0x0055A878 File Offset: 0x00558A78
		public IStateRepPerfEffects ReplacePerformanceAsIStateRepPerfEffects()
		{
			return this.ReplacePerformance<IStateRepPerfEffects>().Value;
		}

		// Token: 0x06026E96 RID: 159382 RVA: 0x0055A894 File Offset: 0x00558A94
		public IStateRepPerfMontagePath ReplacePerformanceAsIStateRepPerfMontagePath()
		{
			return this.ReplacePerformance<IStateRepPerfMontagePath>().Value;
		}

		// Token: 0x06026E97 RID: 159383 RVA: 0x0055A8B0 File Offset: 0x00558AB0
		public IStateRepPerfSkillId ReplacePerformanceAsIStateRepPerfSkillId()
		{
			return this.ReplacePerformance<IStateRepPerfSkillId>().Value;
		}

		// Token: 0x06026E98 RID: 159384 RVA: 0x0055A8CB File Offset: 0x00558ACB
		public static Offset<IStateRepPerfItem> CreateIStateRepPerfItem(FlatBufferBuilder builder, StringOffset StateTagOffset = default(StringOffset), TStateRepPerf ReplacePerformance_type = TStateRepPerf.NONE, int ReplacePerformanceOffset = 0)
		{
			builder.StartTable(3);
			IStateRepPerfItem.AddReplacePerformance(builder, ReplacePerformanceOffset);
			IStateRepPerfItem.AddStateTag(builder, StateTagOffset);
			IStateRepPerfItem.AddReplacePerformanceType(builder, ReplacePerformance_type);
			return IStateRepPerfItem.EndIStateRepPerfItem(builder);
		}

		// Token: 0x06026E99 RID: 159385 RVA: 0x0055A8EF File Offset: 0x00558AEF
		public static void StartIStateRepPerfItem(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026E9A RID: 159386 RVA: 0x0055A8F8 File Offset: 0x00558AF8
		public static void AddStateTag(FlatBufferBuilder builder, StringOffset stateTagOffset)
		{
			builder.AddOffset(0, stateTagOffset.Value, 0);
		}

		// Token: 0x06026E9B RID: 159387 RVA: 0x0055A908 File Offset: 0x00558B08
		public static void AddReplacePerformanceType(FlatBufferBuilder builder, TStateRepPerf replacePerformanceType)
		{
			builder.AddByte(1, (byte)replacePerformanceType, 0);
		}

		// Token: 0x06026E9C RID: 159388 RVA: 0x0055A913 File Offset: 0x00558B13
		public static void AddReplacePerformance(FlatBufferBuilder builder, int replacePerformanceOffset)
		{
			builder.AddOffset(2, replacePerformanceOffset, 0);
		}

		// Token: 0x06026E9D RID: 159389 RVA: 0x0055A91E File Offset: 0x00558B1E
		public static Offset<IStateRepPerfItem> EndIStateRepPerfItem(FlatBufferBuilder builder)
		{
			return new Offset<IStateRepPerfItem>(builder.EndTable());
		}

		// Token: 0x06026E9E RID: 159390 RVA: 0x0055A92C File Offset: 0x00558B2C
		public IStateRepPerfItemT UnPack()
		{
			IStateRepPerfItemT stateRepPerfItemT = new IStateRepPerfItemT();
			this.UnPackTo(stateRepPerfItemT);
			return stateRepPerfItemT;
		}

		// Token: 0x06026E9F RID: 159391 RVA: 0x0055A948 File Offset: 0x00558B48
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

		// Token: 0x06026EA0 RID: 159392 RVA: 0x0055AA3C File Offset: 0x00558C3C
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

		// Token: 0x0400EFC9 RID: 61385
		private Table __p;
	}
}
