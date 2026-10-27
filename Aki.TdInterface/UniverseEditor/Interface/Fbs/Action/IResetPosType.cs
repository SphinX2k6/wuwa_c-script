using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EA6 RID: 28326
	public struct IResetPosType : IFlatbufferObject
	{
		// Token: 0x1700D2E5 RID: 53989
		// (get) Token: 0x06032103 RID: 205059 RVA: 0x006C5359 File Offset: 0x006C3559
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032104 RID: 205060 RVA: 0x006C5366 File Offset: 0x006C3566
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032105 RID: 205061 RVA: 0x006C5370 File Offset: 0x006C3570
		public static IResetPosType GetRootAsIResetPosType(ByteBuffer _bb)
		{
			return IResetPosType.GetRootAsIResetPosType(_bb, default(IResetPosType));
		}

		// Token: 0x06032106 RID: 205062 RVA: 0x006C538C File Offset: 0x006C358C
		public static IResetPosType GetRootAsIResetPosType(ByteBuffer _bb, IResetPosType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032107 RID: 205063 RVA: 0x006C53A9 File Offset: 0x006C35A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032108 RID: 205064 RVA: 0x006C53B8 File Offset: 0x006C35B8
		public IResetPosType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2E6 RID: 53990
		// (get) Token: 0x06032109 RID: 205065 RVA: 0x006C53C8 File Offset: 0x006C35C8
		public EResetPosType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EResetPosType.PosEntity;
				}
				return (EResetPosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603210A RID: 205066 RVA: 0x006C5404 File Offset: 0x006C3604
		public static Offset<IResetPosType> CreateIResetPosType(FlatBufferBuilder builder, EResetPosType Type = EResetPosType.PosEntity)
		{
			builder.StartTable(1);
			IResetPosType.AddType(builder, Type);
			return IResetPosType.EndIResetPosType(builder);
		}

		// Token: 0x0603210B RID: 205067 RVA: 0x006C541A File Offset: 0x006C361A
		public static void StartIResetPosType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603210C RID: 205068 RVA: 0x006C5423 File Offset: 0x006C3623
		public static void AddType(FlatBufferBuilder builder, EResetPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603210D RID: 205069 RVA: 0x006C542E File Offset: 0x006C362E
		public static Offset<IResetPosType> EndIResetPosType(FlatBufferBuilder builder)
		{
			return new Offset<IResetPosType>(builder.EndTable());
		}

		// Token: 0x0603210E RID: 205070 RVA: 0x006C543C File Offset: 0x006C363C
		public IResetPosTypeT UnPack()
		{
			IResetPosTypeT resetPosTypeT = new IResetPosTypeT();
			this.UnPackTo(resetPosTypeT);
			return resetPosTypeT;
		}

		// Token: 0x0603210F RID: 205071 RVA: 0x006C5457 File Offset: 0x006C3657
		public void UnPackTo(IResetPosTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032110 RID: 205072 RVA: 0x006C5468 File Offset: 0x006C3668
		public static Offset<IResetPosType> Pack(FlatBufferBuilder builder, IResetPosTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetPosType>);
			}
			return IResetPosType.CreateIResetPosType(builder, _o.Type);
		}

		// Token: 0x04011898 RID: 71832
		private Table __p;
	}
}
