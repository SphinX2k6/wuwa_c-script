using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053DF RID: 21471
	public struct IAreaBouns : IFlatbufferObject
	{
		// Token: 0x170097F2 RID: 38898
		// (get) Token: 0x060218B7 RID: 137399 RVA: 0x004A031B File Offset: 0x0049E51B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060218B8 RID: 137400 RVA: 0x004A0328 File Offset: 0x0049E528
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060218B9 RID: 137401 RVA: 0x004A0330 File Offset: 0x0049E530
		public static IAreaBouns GetRootAsIAreaBouns(ByteBuffer _bb)
		{
			return IAreaBouns.GetRootAsIAreaBouns(_bb, default(IAreaBouns));
		}

		// Token: 0x060218BA RID: 137402 RVA: 0x004A034C File Offset: 0x0049E54C
		public static IAreaBouns GetRootAsIAreaBouns(ByteBuffer _bb, IAreaBouns obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060218BB RID: 137403 RVA: 0x004A0369 File Offset: 0x0049E569
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060218BC RID: 137404 RVA: 0x004A0378 File Offset: 0x0049E578
		public IAreaBouns __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097F3 RID: 38899
		// (get) Token: 0x060218BD RID: 137405 RVA: 0x004A0388 File Offset: 0x0049E588
		public EWorldLevelBonus Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWorldLevelBonus.WorldLevelTable;
				}
				return (EWorldLevelBonus)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060218BE RID: 137406 RVA: 0x004A03C4 File Offset: 0x0049E5C4
		public static Offset<IAreaBouns> CreateIAreaBouns(FlatBufferBuilder builder, EWorldLevelBonus Type = EWorldLevelBonus.WorldLevelTable)
		{
			builder.StartTable(1);
			IAreaBouns.AddType(builder, Type);
			return IAreaBouns.EndIAreaBouns(builder);
		}

		// Token: 0x060218BF RID: 137407 RVA: 0x004A03DA File Offset: 0x0049E5DA
		public static void StartIAreaBouns(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060218C0 RID: 137408 RVA: 0x004A03E3 File Offset: 0x0049E5E3
		public static void AddType(FlatBufferBuilder builder, EWorldLevelBonus type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060218C1 RID: 137409 RVA: 0x004A03EE File Offset: 0x0049E5EE
		public static Offset<IAreaBouns> EndIAreaBouns(FlatBufferBuilder builder)
		{
			return new Offset<IAreaBouns>(builder.EndTable());
		}

		// Token: 0x060218C2 RID: 137410 RVA: 0x004A03FC File Offset: 0x0049E5FC
		public IAreaBounsT UnPack()
		{
			IAreaBounsT areaBounsT = new IAreaBounsT();
			this.UnPackTo(areaBounsT);
			return areaBounsT;
		}

		// Token: 0x060218C3 RID: 137411 RVA: 0x004A0417 File Offset: 0x0049E617
		public void UnPackTo(IAreaBounsT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060218C4 RID: 137412 RVA: 0x004A0428 File Offset: 0x0049E628
		public static Offset<IAreaBouns> Pack(FlatBufferBuilder builder, IAreaBounsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAreaBouns>);
			}
			return IAreaBouns.CreateIAreaBouns(builder, _o.Type);
		}

		// Token: 0x0400E83B RID: 59451
		private Table __p;
	}
}
