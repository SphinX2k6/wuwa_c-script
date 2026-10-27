using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007415 RID: 29717
	public struct IToggleScanSplineEffect : IFlatbufferObject
	{
		// Token: 0x1700E1AB RID: 57771
		// (get) Token: 0x06035FBD RID: 221117 RVA: 0x00758346 File Offset: 0x00756546
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035FBE RID: 221118 RVA: 0x00758353 File Offset: 0x00756553
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035FBF RID: 221119 RVA: 0x0075835C File Offset: 0x0075655C
		public static IToggleScanSplineEffect GetRootAsIToggleScanSplineEffect(ByteBuffer _bb)
		{
			return IToggleScanSplineEffect.GetRootAsIToggleScanSplineEffect(_bb, default(IToggleScanSplineEffect));
		}

		// Token: 0x06035FC0 RID: 221120 RVA: 0x00758378 File Offset: 0x00756578
		public static IToggleScanSplineEffect GetRootAsIToggleScanSplineEffect(ByteBuffer _bb, IToggleScanSplineEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035FC1 RID: 221121 RVA: 0x00758395 File Offset: 0x00756595
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035FC2 RID: 221122 RVA: 0x007583A4 File Offset: 0x007565A4
		public IToggleScanSplineEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1AC RID: 57772
		// (get) Token: 0x06035FC3 RID: 221123 RVA: 0x007583B4 File Offset: 0x007565B4
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

		// Token: 0x06035FC4 RID: 221124 RVA: 0x007583F0 File Offset: 0x007565F0
		public static Offset<IToggleScanSplineEffect> CreateIToggleScanSplineEffect(FlatBufferBuilder builder, ETraceSplineOptionType Type = ETraceSplineOptionType.Open)
		{
			builder.StartTable(1);
			IToggleScanSplineEffect.AddType(builder, Type);
			return IToggleScanSplineEffect.EndIToggleScanSplineEffect(builder);
		}

		// Token: 0x06035FC5 RID: 221125 RVA: 0x00758406 File Offset: 0x00756606
		public static void StartIToggleScanSplineEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035FC6 RID: 221126 RVA: 0x0075840F File Offset: 0x0075660F
		public static void AddType(FlatBufferBuilder builder, ETraceSplineOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035FC7 RID: 221127 RVA: 0x0075841A File Offset: 0x0075661A
		public static Offset<IToggleScanSplineEffect> EndIToggleScanSplineEffect(FlatBufferBuilder builder)
		{
			return new Offset<IToggleScanSplineEffect>(builder.EndTable());
		}

		// Token: 0x06035FC8 RID: 221128 RVA: 0x00758428 File Offset: 0x00756628
		public IToggleScanSplineEffectT UnPack()
		{
			IToggleScanSplineEffectT toggleScanSplineEffectT = new IToggleScanSplineEffectT();
			this.UnPackTo(toggleScanSplineEffectT);
			return toggleScanSplineEffectT;
		}

		// Token: 0x06035FC9 RID: 221129 RVA: 0x00758443 File Offset: 0x00756643
		public void UnPackTo(IToggleScanSplineEffectT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035FCA RID: 221130 RVA: 0x00758454 File Offset: 0x00756654
		public static Offset<IToggleScanSplineEffect> Pack(FlatBufferBuilder builder, IToggleScanSplineEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleScanSplineEffect>);
			}
			return IToggleScanSplineEffect.CreateIToggleScanSplineEffect(builder, _o.Type);
		}

		// Token: 0x04012288 RID: 74376
		private Table __p;
	}
}
