using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051AD RID: 20909
	public struct IEntityScanFunction : IFlatbufferObject
	{
		// Token: 0x170098CB RID: 39115
		// (get) Token: 0x06021D7B RID: 138619 RVA: 0x004B1C97 File Offset: 0x004AFE97
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021D7C RID: 138620 RVA: 0x004B1CA4 File Offset: 0x004AFEA4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021D7D RID: 138621 RVA: 0x004B1CAC File Offset: 0x004AFEAC
		public static IEntityScanFunction GetRootAsIEntityScanFunction(ByteBuffer _bb)
		{
			return IEntityScanFunction.GetRootAsIEntityScanFunction(_bb, default(IEntityScanFunction));
		}

		// Token: 0x06021D7E RID: 138622 RVA: 0x004B1CC8 File Offset: 0x004AFEC8
		public static IEntityScanFunction GetRootAsIEntityScanFunction(ByteBuffer _bb, IEntityScanFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021D7F RID: 138623 RVA: 0x004B1CE5 File Offset: 0x004AFEE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021D80 RID: 138624 RVA: 0x004B1CF4 File Offset: 0x004AFEF4
		public IEntityScanFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170098CC RID: 39116
		// (get) Token: 0x06021D81 RID: 138625 RVA: 0x004B1D04 File Offset: 0x004AFF04
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

		// Token: 0x170098CD RID: 39117
		// (get) Token: 0x06021D82 RID: 138626 RVA: 0x004B1D40 File Offset: 0x004AFF40
		public bool IsConcealed
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170098CE RID: 39118
		// (get) Token: 0x06021D83 RID: 138627 RVA: 0x004B1D80 File Offset: 0x004AFF80
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

		// Token: 0x170098CF RID: 39119
		// (get) Token: 0x06021D84 RID: 138628 RVA: 0x004B1DE0 File Offset: 0x004AFFE0
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

		// Token: 0x170098D0 RID: 39120
		// (get) Token: 0x06021D85 RID: 138629 RVA: 0x004B1E20 File Offset: 0x004B0020
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

		// Token: 0x06021D86 RID: 138630 RVA: 0x004B1E5D File Offset: 0x004B005D
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

		// Token: 0x06021D87 RID: 138631 RVA: 0x004B1E91 File Offset: 0x004B0091
		public static void StartIEntityScanFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06021D88 RID: 138632 RVA: 0x004B1E9A File Offset: 0x004B009A
		public static void AddScanId(FlatBufferBuilder builder, int scanId)
		{
			builder.AddInt(0, scanId, 0);
		}

		// Token: 0x06021D89 RID: 138633 RVA: 0x004B1EA5 File Offset: 0x004B00A5
		public static void AddIsConcealed(FlatBufferBuilder builder, bool isConcealed)
		{
			builder.AddBool(1, isConcealed, false);
		}

		// Token: 0x06021D8A RID: 138634 RVA: 0x004B1EB0 File Offset: 0x004B00B0
		public static void AddTraceEffect(FlatBufferBuilder builder, Offset<IScanTraceEffect> traceEffectOffset)
		{
			builder.AddOffset(2, traceEffectOffset.Value, 0);
		}

		// Token: 0x06021D8B RID: 138635 RVA: 0x004B1EC0 File Offset: 0x004B00C0
		public static void AddSpecificScanType(FlatBufferBuilder builder, ESpecificScanType specificScanType)
		{
			builder.AddByte(3, (byte)specificScanType, 0);
		}

		// Token: 0x06021D8C RID: 138636 RVA: 0x004B1ECB File Offset: 0x004B00CB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06021D8D RID: 138637 RVA: 0x004B1ED6 File Offset: 0x004B00D6
		public static Offset<IEntityScanFunction> EndIEntityScanFunction(FlatBufferBuilder builder)
		{
			return new Offset<IEntityScanFunction>(builder.EndTable());
		}

		// Token: 0x06021D8E RID: 138638 RVA: 0x004B1EE4 File Offset: 0x004B00E4
		public IEntityScanFunctionT UnPack()
		{
			IEntityScanFunctionT entityScanFunctionT = new IEntityScanFunctionT();
			this.UnPackTo(entityScanFunctionT);
			return entityScanFunctionT;
		}

		// Token: 0x06021D8F RID: 138639 RVA: 0x004B1F00 File Offset: 0x004B0100
		public void UnPackTo(IEntityScanFunctionT _o)
		{
			_o.ScanId = this.ScanId;
			_o.IsConcealed = this.IsConcealed;
			_o.TraceEffect = ((this.TraceEffect != null) ? this.TraceEffect.Value.UnPack() : null);
			_o.SpecificScanType = this.SpecificScanType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021D90 RID: 138640 RVA: 0x004B1F6C File Offset: 0x004B016C
		public static Offset<IEntityScanFunction> Pack(FlatBufferBuilder builder, IEntityScanFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityScanFunction>);
			}
			Offset<IScanTraceEffect> traceEffectOffset = (_o.TraceEffect == null) ? default(Offset<IScanTraceEffect>) : IScanTraceEffect.Pack(builder, _o.TraceEffect);
			return IEntityScanFunction.CreateIEntityScanFunction(builder, _o.ScanId, _o.IsConcealed, traceEffectOffset, _o.SpecificScanType, _o.NullMask);
		}

		// Token: 0x0400E290 RID: 58000
		private Table __p;
	}
}
