using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005712 RID: 22290
	public struct IEntityScanFunction : IFlatbufferObject
	{
		// Token: 0x1700A0BA RID: 41146
		// (get) Token: 0x06023CD3 RID: 146643 RVA: 0x004EBCFF File Offset: 0x004E9EFF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023CD4 RID: 146644 RVA: 0x004EBD0C File Offset: 0x004E9F0C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023CD5 RID: 146645 RVA: 0x004EBD14 File Offset: 0x004E9F14
		public static IEntityScanFunction GetRootAsIEntityScanFunction(ByteBuffer _bb)
		{
			return IEntityScanFunction.GetRootAsIEntityScanFunction(_bb, default(IEntityScanFunction));
		}

		// Token: 0x06023CD6 RID: 146646 RVA: 0x004EBD30 File Offset: 0x004E9F30
		public static IEntityScanFunction GetRootAsIEntityScanFunction(ByteBuffer _bb, IEntityScanFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023CD7 RID: 146647 RVA: 0x004EBD4D File Offset: 0x004E9F4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023CD8 RID: 146648 RVA: 0x004EBD5C File Offset: 0x004E9F5C
		public IEntityScanFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0BB RID: 41147
		// (get) Token: 0x06023CD9 RID: 146649 RVA: 0x004EBD6C File Offset: 0x004E9F6C
		public int ScanId
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

		// Token: 0x1700A0BC RID: 41148
		// (get) Token: 0x06023CDA RID: 146650 RVA: 0x004EBDA8 File Offset: 0x004E9FA8
		public bool IsConcealed
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A0BD RID: 41149
		// (get) Token: 0x06023CDB RID: 146651 RVA: 0x004EBDE8 File Offset: 0x004E9FE8
		public IScanTraceEffect? TraceEffect
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IScanTraceEffect?(default(IScanTraceEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A0BE RID: 41150
		// (get) Token: 0x06023CDC RID: 146652 RVA: 0x004EBE48 File Offset: 0x004EA048
		public ESpecificScanType SpecificScanType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ESpecificScanType.None;
				}
				return (ESpecificScanType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A0BF RID: 41151
		// (get) Token: 0x06023CDD RID: 146653 RVA: 0x004EBE88 File Offset: 0x004EA088
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023CDE RID: 146654 RVA: 0x004EBEC5 File Offset: 0x004EA0C5
		public static Offset<IEntityScanFunction> CreateIEntityScanFunction(FlatBufferBuilder builder, int ScanId = 0, bool IsConcealed = false, Offset<IScanTraceEffect> TraceEffectOffset = default(Offset<IScanTraceEffect>), ESpecificScanType SpecificScanType = ESpecificScanType.None, byte NullMask = 0)
		{
			builder.StartTable(5);
			IEntityScanFunction.AddTraceEffect(builder, TraceEffectOffset);
			IEntityScanFunction.AddScanId(builder, ScanId);
			IEntityScanFunction.AddNullMask(builder, NullMask);
			IEntityScanFunction.AddSpecificScanType(builder, SpecificScanType);
			IEntityScanFunction.AddIsConcealed(builder, IsConcealed);
			return IEntityScanFunction.EndIEntityScanFunction(builder);
		}

		// Token: 0x06023CDF RID: 146655 RVA: 0x004EBEF9 File Offset: 0x004EA0F9
		public static void StartIEntityScanFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06023CE0 RID: 146656 RVA: 0x004EBF02 File Offset: 0x004EA102
		public static void AddScanId(FlatBufferBuilder builder, int scanId)
		{
			builder.AddInt(0, scanId, 0);
		}

		// Token: 0x06023CE1 RID: 146657 RVA: 0x004EBF0D File Offset: 0x004EA10D
		public static void AddIsConcealed(FlatBufferBuilder builder, bool isConcealed)
		{
			builder.AddBool(1, isConcealed, false);
		}

		// Token: 0x06023CE2 RID: 146658 RVA: 0x004EBF18 File Offset: 0x004EA118
		public static void AddTraceEffect(FlatBufferBuilder builder, Offset<IScanTraceEffect> traceEffectOffset)
		{
			builder.AddOffset(2, traceEffectOffset.Value, 0);
		}

		// Token: 0x06023CE3 RID: 146659 RVA: 0x004EBF28 File Offset: 0x004EA128
		public static void AddSpecificScanType(FlatBufferBuilder builder, ESpecificScanType specificScanType)
		{
			builder.AddByte(3, (byte)specificScanType, 0);
		}

		// Token: 0x06023CE4 RID: 146660 RVA: 0x004EBF33 File Offset: 0x004EA133
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06023CE5 RID: 146661 RVA: 0x004EBF3E File Offset: 0x004EA13E
		public static Offset<IEntityScanFunction> EndIEntityScanFunction(FlatBufferBuilder builder)
		{
			return new Offset<IEntityScanFunction>(builder.EndTable());
		}

		// Token: 0x06023CE6 RID: 146662 RVA: 0x004EBF4C File Offset: 0x004EA14C
		public IEntityScanFunctionT UnPack()
		{
			IEntityScanFunctionT entityScanFunctionT = new IEntityScanFunctionT();
			this.UnPackTo(entityScanFunctionT);
			return entityScanFunctionT;
		}

		// Token: 0x06023CE7 RID: 146663 RVA: 0x004EBF68 File Offset: 0x004EA168
		public void UnPackTo(IEntityScanFunctionT _o)
		{
			_o.ScanId = this.ScanId;
			_o.IsConcealed = this.IsConcealed;
			_o.TraceEffect = ((this.TraceEffect != null) ? this.TraceEffect.Value.UnPack() : null);
			_o.SpecificScanType = this.SpecificScanType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023CE8 RID: 146664 RVA: 0x004EBFD4 File Offset: 0x004EA1D4
		public static Offset<IEntityScanFunction> Pack(FlatBufferBuilder builder, IEntityScanFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityScanFunction>);
			}
			Offset<IScanTraceEffect> traceEffectOffset = (_o.TraceEffect == null) ? default(Offset<IScanTraceEffect>) : IScanTraceEffect.Pack(builder, _o.TraceEffect);
			return IEntityScanFunction.CreateIEntityScanFunction(builder, _o.ScanId, _o.IsConcealed, traceEffectOffset, _o.SpecificScanType, _o.NullMask);
		}

		// Token: 0x0400EE8E RID: 61070
		private Table __p;
	}
}
