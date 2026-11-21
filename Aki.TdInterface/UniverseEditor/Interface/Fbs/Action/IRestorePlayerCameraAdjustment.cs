using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200763F RID: 30271
	public struct IRestorePlayerCameraAdjustment : IFlatbufferObject
	{
		// Token: 0x1700DE58 RID: 56920
		// (get) Token: 0x060351DE RID: 217566 RVA: 0x00721F60 File Offset: 0x00720160
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060351DF RID: 217567 RVA: 0x00721F6D File Offset: 0x0072016D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060351E0 RID: 217568 RVA: 0x00721F74 File Offset: 0x00720174
		public static IRestorePlayerCameraAdjustment GetRootAsIRestorePlayerCameraAdjustment(ByteBuffer _bb)
		{
			return IRestorePlayerCameraAdjustment.GetRootAsIRestorePlayerCameraAdjustment(_bb, default(IRestorePlayerCameraAdjustment));
		}

		// Token: 0x060351E1 RID: 217569 RVA: 0x00721F90 File Offset: 0x00720190
		public static IRestorePlayerCameraAdjustment GetRootAsIRestorePlayerCameraAdjustment(ByteBuffer _bb, IRestorePlayerCameraAdjustment obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060351E2 RID: 217570 RVA: 0x00721FAD File Offset: 0x007201AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060351E3 RID: 217571 RVA: 0x00721FBC File Offset: 0x007201BC
		public IRestorePlayerCameraAdjustment __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE59 RID: 56921
		// (get) Token: 0x060351E4 RID: 217572 RVA: 0x00721FCC File Offset: 0x007201CC
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

		// Token: 0x1700DE5A RID: 56922
		// (get) Token: 0x060351E5 RID: 217573 RVA: 0x0072202C File Offset: 0x0072022C
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

		// Token: 0x060351E6 RID: 217574 RVA: 0x00722063 File Offset: 0x00720263
		public Span<byte> GetSubScreenKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060351E7 RID: 217575 RVA: 0x00722072 File Offset: 0x00720272
		public byte[] GetSubScreenKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060351E8 RID: 217576 RVA: 0x00722080 File Offset: 0x00720280
		public static Offset<IRestorePlayerCameraAdjustment> CreateIRestorePlayerCameraAdjustment(FlatBufferBuilder builder, Offset<IResetFocusConfig> ResetFocusOffset = default(Offset<IResetFocusConfig>), StringOffset SubScreenKeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRestorePlayerCameraAdjustment.AddSubScreenKey(builder, SubScreenKeyOffset);
			IRestorePlayerCameraAdjustment.AddResetFocus(builder, ResetFocusOffset);
			return IRestorePlayerCameraAdjustment.EndIRestorePlayerCameraAdjustment(builder);
		}

		// Token: 0x060351E9 RID: 217577 RVA: 0x0072209D File Offset: 0x0072029D
		public static void StartIRestorePlayerCameraAdjustment(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060351EA RID: 217578 RVA: 0x007220A6 File Offset: 0x007202A6
		public static void AddResetFocus(FlatBufferBuilder builder, Offset<IResetFocusConfig> resetFocusOffset)
		{
			builder.AddOffset(0, resetFocusOffset.Value, 0);
		}

		// Token: 0x060351EB RID: 217579 RVA: 0x007220B6 File Offset: 0x007202B6
		public static void AddSubScreenKey(FlatBufferBuilder builder, StringOffset subScreenKeyOffset)
		{
			builder.AddOffset(1, subScreenKeyOffset.Value, 0);
		}

		// Token: 0x060351EC RID: 217580 RVA: 0x007220C6 File Offset: 0x007202C6
		public static Offset<IRestorePlayerCameraAdjustment> EndIRestorePlayerCameraAdjustment(FlatBufferBuilder builder)
		{
			return new Offset<IRestorePlayerCameraAdjustment>(builder.EndTable());
		}

		// Token: 0x060351ED RID: 217581 RVA: 0x007220D4 File Offset: 0x007202D4
		public IRestorePlayerCameraAdjustmentT UnPack()
		{
			IRestorePlayerCameraAdjustmentT restorePlayerCameraAdjustmentT = new IRestorePlayerCameraAdjustmentT();
			this.UnPackTo(restorePlayerCameraAdjustmentT);
			return restorePlayerCameraAdjustmentT;
		}

		// Token: 0x060351EE RID: 217582 RVA: 0x007220F0 File Offset: 0x007202F0
		public void UnPackTo(IRestorePlayerCameraAdjustmentT _o)
		{
			_o.ResetFocus = ((this.ResetFocus != null) ? this.ResetFocus.Value.UnPack() : null);
			_o.SubScreenKey = this.SubScreenKey;
		}

		// Token: 0x060351EF RID: 217583 RVA: 0x00722138 File Offset: 0x00720338
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

		// Token: 0x04012834 RID: 75828
		private Table __p;
	}
}
