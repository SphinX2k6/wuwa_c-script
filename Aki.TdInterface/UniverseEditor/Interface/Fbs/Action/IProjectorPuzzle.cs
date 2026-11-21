using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007537 RID: 30007
	public struct IProjectorPuzzle : IFlatbufferObject
	{
		// Token: 0x1700DCC7 RID: 56519
		// (get) Token: 0x060349F7 RID: 215543 RVA: 0x00714B44 File Offset: 0x00712D44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060349F8 RID: 215544 RVA: 0x00714B51 File Offset: 0x00712D51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060349F9 RID: 215545 RVA: 0x00714B58 File Offset: 0x00712D58
		public static IProjectorPuzzle GetRootAsIProjectorPuzzle(ByteBuffer _bb)
		{
			return IProjectorPuzzle.GetRootAsIProjectorPuzzle(_bb, default(IProjectorPuzzle));
		}

		// Token: 0x060349FA RID: 215546 RVA: 0x00714B74 File Offset: 0x00712D74
		public static IProjectorPuzzle GetRootAsIProjectorPuzzle(ByteBuffer _bb, IProjectorPuzzle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060349FB RID: 215547 RVA: 0x00714B91 File Offset: 0x00712D91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060349FC RID: 215548 RVA: 0x00714BA0 File Offset: 0x00712DA0
		public IProjectorPuzzle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCC8 RID: 56520
		// (get) Token: 0x060349FD RID: 215549 RVA: 0x00714BB0 File Offset: 0x00712DB0
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

		// Token: 0x060349FE RID: 215550 RVA: 0x00714BEC File Offset: 0x00712DEC
		public static Offset<IProjectorPuzzle> CreateIProjectorPuzzle(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher)
		{
			builder.StartTable(1);
			IProjectorPuzzle.AddType(builder, Type);
			return IProjectorPuzzle.EndIProjectorPuzzle(builder);
		}

		// Token: 0x060349FF RID: 215551 RVA: 0x00714C02 File Offset: 0x00712E02
		public static void StartIProjectorPuzzle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034A00 RID: 215552 RVA: 0x00714C0B File Offset: 0x00712E0B
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034A01 RID: 215553 RVA: 0x00714C16 File Offset: 0x00712E16
		public static Offset<IProjectorPuzzle> EndIProjectorPuzzle(FlatBufferBuilder builder)
		{
			return new Offset<IProjectorPuzzle>(builder.EndTable());
		}

		// Token: 0x06034A02 RID: 215554 RVA: 0x00714C24 File Offset: 0x00712E24
		public IProjectorPuzzleT UnPack()
		{
			IProjectorPuzzleT projectorPuzzleT = new IProjectorPuzzleT();
			this.UnPackTo(projectorPuzzleT);
			return projectorPuzzleT;
		}

		// Token: 0x06034A03 RID: 215555 RVA: 0x00714C3F File Offset: 0x00712E3F
		public void UnPackTo(IProjectorPuzzleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034A04 RID: 215556 RVA: 0x00714C50 File Offset: 0x00712E50
		public static Offset<IProjectorPuzzle> Pack(FlatBufferBuilder builder, IProjectorPuzzleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProjectorPuzzle>);
			}
			return IProjectorPuzzle.CreateIProjectorPuzzle(builder, _o.Type);
		}

		// Token: 0x04012717 RID: 75543
		private Table __p;
	}
}
