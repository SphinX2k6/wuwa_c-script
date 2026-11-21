using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200418D RID: 16781
	public struct ICheckTrapDefenseBdBuffQualityUp : IFlatbufferObject
	{
		// Token: 0x170071B8 RID: 29112
		// (get) Token: 0x060171BF RID: 94655 RVA: 0x0034B31D File Offset: 0x0034951D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060171C0 RID: 94656 RVA: 0x0034B32A File Offset: 0x0034952A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060171C1 RID: 94657 RVA: 0x0034B334 File Offset: 0x00349534
		public static ICheckTrapDefenseBdBuffQualityUp GetRootAsICheckTrapDefenseBdBuffQualityUp(ByteBuffer _bb)
		{
			return ICheckTrapDefenseBdBuffQualityUp.GetRootAsICheckTrapDefenseBdBuffQualityUp(_bb, default(ICheckTrapDefenseBdBuffQualityUp));
		}

		// Token: 0x060171C2 RID: 94658 RVA: 0x0034B350 File Offset: 0x00349550
		public static ICheckTrapDefenseBdBuffQualityUp GetRootAsICheckTrapDefenseBdBuffQualityUp(ByteBuffer _bb, ICheckTrapDefenseBdBuffQualityUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060171C3 RID: 94659 RVA: 0x0034B36D File Offset: 0x0034956D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060171C4 RID: 94660 RVA: 0x0034B37C File Offset: 0x0034957C
		public ICheckTrapDefenseBdBuffQualityUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071B9 RID: 29113
		// (get) Token: 0x060171C5 RID: 94661 RVA: 0x0034B38C File Offset: 0x0034958C
		public ECheckTrapDefenseEvent Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckTrapDefenseEvent.MonsterKilled;
				}
				return (ECheckTrapDefenseEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060171C6 RID: 94662 RVA: 0x0034B3C8 File Offset: 0x003495C8
		public static Offset<ICheckTrapDefenseBdBuffQualityUp> CreateICheckTrapDefenseBdBuffQualityUp(FlatBufferBuilder builder, ECheckTrapDefenseEvent Type = ECheckTrapDefenseEvent.MonsterKilled)
		{
			builder.StartTable(1);
			ICheckTrapDefenseBdBuffQualityUp.AddType(builder, Type);
			return ICheckTrapDefenseBdBuffQualityUp.EndICheckTrapDefenseBdBuffQualityUp(builder);
		}

		// Token: 0x060171C7 RID: 94663 RVA: 0x0034B3DE File Offset: 0x003495DE
		public static void StartICheckTrapDefenseBdBuffQualityUp(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060171C8 RID: 94664 RVA: 0x0034B3E7 File Offset: 0x003495E7
		public static void AddType(FlatBufferBuilder builder, ECheckTrapDefenseEvent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060171C9 RID: 94665 RVA: 0x0034B3F2 File Offset: 0x003495F2
		public static Offset<ICheckTrapDefenseBdBuffQualityUp> EndICheckTrapDefenseBdBuffQualityUp(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTrapDefenseBdBuffQualityUp>(builder.EndTable());
		}

		// Token: 0x060171CA RID: 94666 RVA: 0x0034B400 File Offset: 0x00349600
		public ICheckTrapDefenseBdBuffQualityUpT UnPack()
		{
			ICheckTrapDefenseBdBuffQualityUpT checkTrapDefenseBdBuffQualityUpT = new ICheckTrapDefenseBdBuffQualityUpT();
			this.UnPackTo(checkTrapDefenseBdBuffQualityUpT);
			return checkTrapDefenseBdBuffQualityUpT;
		}

		// Token: 0x060171CB RID: 94667 RVA: 0x0034B41B File Offset: 0x0034961B
		public void UnPackTo(ICheckTrapDefenseBdBuffQualityUpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060171CC RID: 94668 RVA: 0x0034B42C File Offset: 0x0034962C
		public static Offset<ICheckTrapDefenseBdBuffQualityUp> Pack(FlatBufferBuilder builder, ICheckTrapDefenseBdBuffQualityUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTrapDefenseBdBuffQualityUp>);
			}
			return ICheckTrapDefenseBdBuffQualityUp.CreateICheckTrapDefenseBdBuffQualityUp(builder, _o.Type);
		}

		// Token: 0x0400C00C RID: 49164
		private Table __p;
	}
}
