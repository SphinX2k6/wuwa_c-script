using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075A3 RID: 30115
	public struct IReignsChangeBackground : IFlatbufferObject
	{
		// Token: 0x1700DD77 RID: 56695
		// (get) Token: 0x06034D39 RID: 216377 RVA: 0x0071A291 File Offset: 0x00718491
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034D3A RID: 216378 RVA: 0x0071A29E File Offset: 0x0071849E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034D3B RID: 216379 RVA: 0x0071A2A8 File Offset: 0x007184A8
		public static IReignsChangeBackground GetRootAsIReignsChangeBackground(ByteBuffer _bb)
		{
			return IReignsChangeBackground.GetRootAsIReignsChangeBackground(_bb, default(IReignsChangeBackground));
		}

		// Token: 0x06034D3C RID: 216380 RVA: 0x0071A2C4 File Offset: 0x007184C4
		public static IReignsChangeBackground GetRootAsIReignsChangeBackground(ByteBuffer _bb, IReignsChangeBackground obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034D3D RID: 216381 RVA: 0x0071A2E1 File Offset: 0x007184E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034D3E RID: 216382 RVA: 0x0071A2F0 File Offset: 0x007184F0
		public IReignsChangeBackground __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD78 RID: 56696
		// (get) Token: 0x06034D3F RID: 216383 RVA: 0x0071A300 File Offset: 0x00718500
		public string Background
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

		// Token: 0x06034D40 RID: 216384 RVA: 0x0071A337 File Offset: 0x00718537
		public Span<byte> GetBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06034D41 RID: 216385 RVA: 0x0071A346 File Offset: 0x00718546
		public byte[] GetBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700DD79 RID: 56697
		// (get) Token: 0x06034D42 RID: 216386 RVA: 0x0071A354 File Offset: 0x00718554
		public EReignsBackgroundChangeMode ChangeMode
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EReignsBackgroundChangeMode.Instant;
				}
				return (EReignsBackgroundChangeMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034D43 RID: 216387 RVA: 0x0071A390 File Offset: 0x00718590
		public static Offset<IReignsChangeBackground> CreateIReignsChangeBackground(FlatBufferBuilder builder, StringOffset BackgroundOffset = default(StringOffset), EReignsBackgroundChangeMode ChangeMode = EReignsBackgroundChangeMode.Instant)
		{
			builder.StartTable(2);
			IReignsChangeBackground.AddBackground(builder, BackgroundOffset);
			IReignsChangeBackground.AddChangeMode(builder, ChangeMode);
			return IReignsChangeBackground.EndIReignsChangeBackground(builder);
		}

		// Token: 0x06034D44 RID: 216388 RVA: 0x0071A3AD File Offset: 0x007185AD
		public static void StartIReignsChangeBackground(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034D45 RID: 216389 RVA: 0x0071A3B6 File Offset: 0x007185B6
		public static void AddBackground(FlatBufferBuilder builder, StringOffset backgroundOffset)
		{
			builder.AddOffset(0, backgroundOffset.Value, 0);
		}

		// Token: 0x06034D46 RID: 216390 RVA: 0x0071A3C6 File Offset: 0x007185C6
		public static void AddChangeMode(FlatBufferBuilder builder, EReignsBackgroundChangeMode changeMode)
		{
			builder.AddByte(1, (byte)changeMode, 0);
		}

		// Token: 0x06034D47 RID: 216391 RVA: 0x0071A3D1 File Offset: 0x007185D1
		public static Offset<IReignsChangeBackground> EndIReignsChangeBackground(FlatBufferBuilder builder)
		{
			return new Offset<IReignsChangeBackground>(builder.EndTable());
		}

		// Token: 0x06034D48 RID: 216392 RVA: 0x0071A3E0 File Offset: 0x007185E0
		public IReignsChangeBackgroundT UnPack()
		{
			IReignsChangeBackgroundT reignsChangeBackgroundT = new IReignsChangeBackgroundT();
			this.UnPackTo(reignsChangeBackgroundT);
			return reignsChangeBackgroundT;
		}

		// Token: 0x06034D49 RID: 216393 RVA: 0x0071A3FB File Offset: 0x007185FB
		public void UnPackTo(IReignsChangeBackgroundT _o)
		{
			_o.Background = this.Background;
			_o.ChangeMode = this.ChangeMode;
		}

		// Token: 0x06034D4A RID: 216394 RVA: 0x0071A418 File Offset: 0x00718618
		public static Offset<IReignsChangeBackground> Pack(FlatBufferBuilder builder, IReignsChangeBackgroundT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsChangeBackground>);
			}
			StringOffset backgroundOffset = (_o.Background == null) ? default(StringOffset) : builder.CreateString(_o.Background);
			return IReignsChangeBackground.CreateIReignsChangeBackground(builder, backgroundOffset, _o.ChangeMode);
		}

		// Token: 0x0401278D RID: 75661
		private Table __p;
	}
}
