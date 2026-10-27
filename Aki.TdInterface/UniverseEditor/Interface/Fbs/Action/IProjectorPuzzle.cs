using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DBC RID: 28092
	public struct IProjectorPuzzle : IFlatbufferObject
	{
		// Token: 0x1700D17F RID: 53631
		// (get) Token: 0x060319FB RID: 203259 RVA: 0x006B945C File Offset: 0x006B765C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060319FC RID: 203260 RVA: 0x006B9469 File Offset: 0x006B7669
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060319FD RID: 203261 RVA: 0x006B9470 File Offset: 0x006B7670
		public static IProjectorPuzzle GetRootAsIProjectorPuzzle(ByteBuffer _bb)
		{
			return IProjectorPuzzle.GetRootAsIProjectorPuzzle(_bb, default(IProjectorPuzzle));
		}

		// Token: 0x060319FE RID: 203262 RVA: 0x006B948C File Offset: 0x006B768C
		public static IProjectorPuzzle GetRootAsIProjectorPuzzle(ByteBuffer _bb, IProjectorPuzzle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060319FF RID: 203263 RVA: 0x006B94A9 File Offset: 0x006B76A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031A00 RID: 203264 RVA: 0x006B94B8 File Offset: 0x006B76B8
		public IProjectorPuzzle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D180 RID: 53632
		// (get) Token: 0x06031A01 RID: 203265 RVA: 0x006B94C8 File Offset: 0x006B76C8
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031A02 RID: 203266 RVA: 0x006B9504 File Offset: 0x006B7704
		public static Offset<IProjectorPuzzle> CreateIProjectorPuzzle(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher)
		{
			builder.StartTable(1);
			IProjectorPuzzle.AddType(builder, Type);
			return IProjectorPuzzle.EndIProjectorPuzzle(builder);
		}

		// Token: 0x06031A03 RID: 203267 RVA: 0x006B951A File Offset: 0x006B771A
		public static void StartIProjectorPuzzle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031A04 RID: 203268 RVA: 0x006B9523 File Offset: 0x006B7723
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031A05 RID: 203269 RVA: 0x006B952E File Offset: 0x006B772E
		public static Offset<IProjectorPuzzle> EndIProjectorPuzzle(FlatBufferBuilder builder)
		{
			return new Offset<IProjectorPuzzle>(builder.EndTable());
		}

		// Token: 0x06031A06 RID: 203270 RVA: 0x006B953C File Offset: 0x006B773C
		public IProjectorPuzzleT UnPack()
		{
			IProjectorPuzzleT projectorPuzzleT = new IProjectorPuzzleT();
			this.UnPackTo(projectorPuzzleT);
			return projectorPuzzleT;
		}

		// Token: 0x06031A07 RID: 203271 RVA: 0x006B9557 File Offset: 0x006B7757
		public void UnPackTo(IProjectorPuzzleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031A08 RID: 203272 RVA: 0x006B9568 File Offset: 0x006B7768
		public static Offset<IProjectorPuzzle> Pack(FlatBufferBuilder builder, IProjectorPuzzleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProjectorPuzzle>);
			}
			return IProjectorPuzzle.CreateIProjectorPuzzle(builder, _o.Type);
		}

		// Token: 0x0401179B RID: 71579
		private Table __p;
	}
}
