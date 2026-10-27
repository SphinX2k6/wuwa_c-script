using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EBB RID: 28347
	public struct IRestorePlayerCameraAdjustment : IFlatbufferObject
	{
		// Token: 0x1700D301 RID: 54017
		// (get) Token: 0x0603219E RID: 205214 RVA: 0x006C622C File Offset: 0x006C442C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603219F RID: 205215 RVA: 0x006C6239 File Offset: 0x006C4439
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060321A0 RID: 205216 RVA: 0x006C6240 File Offset: 0x006C4440
		public static IRestorePlayerCameraAdjustment GetRootAsIRestorePlayerCameraAdjustment(ByteBuffer _bb)
		{
			return IRestorePlayerCameraAdjustment.GetRootAsIRestorePlayerCameraAdjustment(_bb, default(IRestorePlayerCameraAdjustment));
		}

		// Token: 0x060321A1 RID: 205217 RVA: 0x006C625C File Offset: 0x006C445C
		public static IRestorePlayerCameraAdjustment GetRootAsIRestorePlayerCameraAdjustment(ByteBuffer _bb, IRestorePlayerCameraAdjustment obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060321A2 RID: 205218 RVA: 0x006C6279 File Offset: 0x006C4479
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060321A3 RID: 205219 RVA: 0x006C6288 File Offset: 0x006C4488
		public IRestorePlayerCameraAdjustment __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D302 RID: 54018
		// (get) Token: 0x060321A4 RID: 205220 RVA: 0x006C6298 File Offset: 0x006C4498
		public IResetFocusConfig? ResetFocus
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IResetFocusConfig?(default(IResetFocusConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D303 RID: 54019
		// (get) Token: 0x060321A5 RID: 205221 RVA: 0x006C62F8 File Offset: 0x006C44F8
		public string SubScreenKey
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060321A6 RID: 205222 RVA: 0x006C632F File Offset: 0x006C452F
		public Span<byte> GetSubScreenKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060321A7 RID: 205223 RVA: 0x006C633E File Offset: 0x006C453E
		public byte[] GetSubScreenKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060321A8 RID: 205224 RVA: 0x006C634C File Offset: 0x006C454C
		public static Offset<IRestorePlayerCameraAdjustment> CreateIRestorePlayerCameraAdjustment(FlatBufferBuilder builder, Offset<IResetFocusConfig> ResetFocusOffset = default(Offset<IResetFocusConfig>), StringOffset SubScreenKeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRestorePlayerCameraAdjustment.AddSubScreenKey(builder, SubScreenKeyOffset);
			IRestorePlayerCameraAdjustment.AddResetFocus(builder, ResetFocusOffset);
			return IRestorePlayerCameraAdjustment.EndIRestorePlayerCameraAdjustment(builder);
		}

		// Token: 0x060321A9 RID: 205225 RVA: 0x006C6369 File Offset: 0x006C4569
		public static void StartIRestorePlayerCameraAdjustment(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060321AA RID: 205226 RVA: 0x006C6372 File Offset: 0x006C4572
		public static void AddResetFocus(FlatBufferBuilder builder, Offset<IResetFocusConfig> resetFocusOffset)
		{
			builder.AddOffset(0, resetFocusOffset.Value, 0);
		}

		// Token: 0x060321AB RID: 205227 RVA: 0x006C6382 File Offset: 0x006C4582
		public static void AddSubScreenKey(FlatBufferBuilder builder, StringOffset subScreenKeyOffset)
		{
			builder.AddOffset(1, subScreenKeyOffset.Value, 0);
		}

		// Token: 0x060321AC RID: 205228 RVA: 0x006C6392 File Offset: 0x006C4592
		public static Offset<IRestorePlayerCameraAdjustment> EndIRestorePlayerCameraAdjustment(FlatBufferBuilder builder)
		{
			return new Offset<IRestorePlayerCameraAdjustment>(builder.EndTable());
		}

		// Token: 0x060321AD RID: 205229 RVA: 0x006C63A0 File Offset: 0x006C45A0
		public IRestorePlayerCameraAdjustmentT UnPack()
		{
			IRestorePlayerCameraAdjustmentT restorePlayerCameraAdjustmentT = new IRestorePlayerCameraAdjustmentT();
			this.UnPackTo(restorePlayerCameraAdjustmentT);
			return restorePlayerCameraAdjustmentT;
		}

		// Token: 0x060321AE RID: 205230 RVA: 0x006C63BC File Offset: 0x006C45BC
		public void UnPackTo(IRestorePlayerCameraAdjustmentT _o)
		{
			_o.ResetFocus = ((this.ResetFocus != null) ? this.ResetFocus.Value.UnPack() : null);
			_o.SubScreenKey = this.SubScreenKey;
		}

		// Token: 0x060321AF RID: 205231 RVA: 0x006C6404 File Offset: 0x006C4604
		public static Offset<IRestorePlayerCameraAdjustment> Pack(FlatBufferBuilder builder, IRestorePlayerCameraAdjustmentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRestorePlayerCameraAdjustment>);
			}
			Offset<IResetFocusConfig> resetFocusOffset = (_o.ResetFocus == null) ? default(Offset<IResetFocusConfig>) : IResetFocusConfig.Pack(builder, _o.ResetFocus);
			StringOffset subScreenKeyOffset = (_o.SubScreenKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenKey);
			return IRestorePlayerCameraAdjustment.CreateIRestorePlayerCameraAdjustment(builder, resetFocusOffset, subScreenKeyOffset);
		}

		// Token: 0x040118AF RID: 71855
		private Table __p;
	}
}
