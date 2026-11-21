using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200575A RID: 22362
	public struct IExploreSkillLonelyDollPollutant : IFlatbufferObject
	{
		// Token: 0x1700A1A2 RID: 41378
		// (get) Token: 0x060240B4 RID: 147636 RVA: 0x004F5352 File Offset: 0x004F3552
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060240B5 RID: 147637 RVA: 0x004F535F File Offset: 0x004F355F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060240B6 RID: 147638 RVA: 0x004F5368 File Offset: 0x004F3568
		public static IExploreSkillLonelyDollPollutant GetRootAsIExploreSkillLonelyDollPollutant(ByteBuffer _bb)
		{
			return IExploreSkillLonelyDollPollutant.GetRootAsIExploreSkillLonelyDollPollutant(_bb, default(IExploreSkillLonelyDollPollutant));
		}

		// Token: 0x060240B7 RID: 147639 RVA: 0x004F5384 File Offset: 0x004F3584
		public static IExploreSkillLonelyDollPollutant GetRootAsIExploreSkillLonelyDollPollutant(ByteBuffer _bb, IExploreSkillLonelyDollPollutant obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060240B8 RID: 147640 RVA: 0x004F53A1 File Offset: 0x004F35A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060240B9 RID: 147641 RVA: 0x004F53B0 File Offset: 0x004F35B0
		public IExploreSkillLonelyDollPollutant __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1A3 RID: 41379
		// (get) Token: 0x060240BA RID: 147642 RVA: 0x004F53C0 File Offset: 0x004F35C0
		public EExploreSkillInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return (EExploreSkillInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060240BB RID: 147643 RVA: 0x004F53FC File Offset: 0x004F35FC
		public static Offset<IExploreSkillLonelyDollPollutant> CreateIExploreSkillLonelyDollPollutant(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant)
		{
			builder.StartTable(1);
			IExploreSkillLonelyDollPollutant.AddType(builder, Type);
			return IExploreSkillLonelyDollPollutant.EndIExploreSkillLonelyDollPollutant(builder);
		}

		// Token: 0x060240BC RID: 147644 RVA: 0x004F5412 File Offset: 0x004F3612
		public static void StartIExploreSkillLonelyDollPollutant(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060240BD RID: 147645 RVA: 0x004F541B File Offset: 0x004F361B
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060240BE RID: 147646 RVA: 0x004F5426 File Offset: 0x004F3626
		public static Offset<IExploreSkillLonelyDollPollutant> EndIExploreSkillLonelyDollPollutant(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillLonelyDollPollutant>(builder.EndTable());
		}

		// Token: 0x060240BF RID: 147647 RVA: 0x004F5434 File Offset: 0x004F3634
		public IExploreSkillLonelyDollPollutantT UnPack()
		{
			IExploreSkillLonelyDollPollutantT exploreSkillLonelyDollPollutantT = new IExploreSkillLonelyDollPollutantT();
			this.UnPackTo(exploreSkillLonelyDollPollutantT);
			return exploreSkillLonelyDollPollutantT;
		}

		// Token: 0x060240C0 RID: 147648 RVA: 0x004F544F File Offset: 0x004F364F
		public void UnPackTo(IExploreSkillLonelyDollPollutantT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060240C1 RID: 147649 RVA: 0x004F5460 File Offset: 0x004F3660
		public static Offset<IExploreSkillLonelyDollPollutant> Pack(FlatBufferBuilder builder, IExploreSkillLonelyDollPollutantT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillLonelyDollPollutant>);
			}
			return IExploreSkillLonelyDollPollutant.CreateIExploreSkillLonelyDollPollutant(builder, _o.Type);
		}

		// Token: 0x0400EF25 RID: 61221
		private Table __p;
	}
}
