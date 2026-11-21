using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C08 RID: 31752
	public struct IToggleScanSplineEffect : IFlatbufferObject
	{
		// Token: 0x1700EDC8 RID: 60872
		// (get) Token: 0x060393A6 RID: 234406 RVA: 0x007BB074 File Offset: 0x007B9274
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060393A7 RID: 234407 RVA: 0x007BB081 File Offset: 0x007B9281
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060393A8 RID: 234408 RVA: 0x007BB088 File Offset: 0x007B9288
		public static IToggleScanSplineEffect GetRootAsIToggleScanSplineEffect(ByteBuffer _bb)
		{
			return IToggleScanSplineEffect.GetRootAsIToggleScanSplineEffect(_bb, default(IToggleScanSplineEffect));
		}

		// Token: 0x060393A9 RID: 234409 RVA: 0x007BB0A4 File Offset: 0x007B92A4
		public static IToggleScanSplineEffect GetRootAsIToggleScanSplineEffect(ByteBuffer _bb, IToggleScanSplineEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060393AA RID: 234410 RVA: 0x007BB0C1 File Offset: 0x007B92C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060393AB RID: 234411 RVA: 0x007BB0D0 File Offset: 0x007B92D0
		public IToggleScanSplineEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EDC9 RID: 60873
		// (get) Token: 0x060393AC RID: 234412 RVA: 0x007BB0E0 File Offset: 0x007B92E0
		public ETraceSplineOptionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETraceSplineOptionType.Open;
				}
				return (ETraceSplineOptionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060393AD RID: 234413 RVA: 0x007BB11C File Offset: 0x007B931C
		public static Offset<IToggleScanSplineEffect> CreateIToggleScanSplineEffect(FlatBufferBuilder builder, ETraceSplineOptionType Type = ETraceSplineOptionType.Open)
		{
			builder.StartTable(1);
			IToggleScanSplineEffect.AddType(builder, Type);
			return IToggleScanSplineEffect.EndIToggleScanSplineEffect(builder);
		}

		// Token: 0x060393AE RID: 234414 RVA: 0x007BB132 File Offset: 0x007B9332
		public static void StartIToggleScanSplineEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060393AF RID: 234415 RVA: 0x007BB13B File Offset: 0x007B933B
		public static void AddType(FlatBufferBuilder builder, ETraceSplineOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060393B0 RID: 234416 RVA: 0x007BB146 File Offset: 0x007B9346
		public static Offset<IToggleScanSplineEffect> EndIToggleScanSplineEffect(FlatBufferBuilder builder)
		{
			return new Offset<IToggleScanSplineEffect>(builder.EndTable());
		}

		// Token: 0x060393B1 RID: 234417 RVA: 0x007BB154 File Offset: 0x007B9354
		public IToggleScanSplineEffectT UnPack()
		{
			IToggleScanSplineEffectT toggleScanSplineEffectT = new IToggleScanSplineEffectT();
			this.UnPackTo(toggleScanSplineEffectT);
			return toggleScanSplineEffectT;
		}

		// Token: 0x060393B2 RID: 234418 RVA: 0x007BB16F File Offset: 0x007B936F
		public void UnPackTo(IToggleScanSplineEffectT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060393B3 RID: 234419 RVA: 0x007BB180 File Offset: 0x007B9380
		public static Offset<IToggleScanSplineEffect> Pack(FlatBufferBuilder builder, IToggleScanSplineEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleScanSplineEffect>);
			}
			return IToggleScanSplineEffect.CreateIToggleScanSplineEffect(builder, _o.Type);
		}

		// Token: 0x040132AF RID: 78511
		private Table __p;
	}
}
