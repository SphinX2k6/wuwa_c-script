using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005207 RID: 20999
	public struct IExploreSkillSearchTargetCfg : IFlatbufferObject
	{
		// Token: 0x170099D1 RID: 39377
		// (get) Token: 0x060221E6 RID: 139750 RVA: 0x004BC115 File Offset: 0x004BA315
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060221E7 RID: 139751 RVA: 0x004BC122 File Offset: 0x004BA322
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060221E8 RID: 139752 RVA: 0x004BC12C File Offset: 0x004BA32C
		public static IExploreSkillSearchTargetCfg GetRootAsIExploreSkillSearchTargetCfg(ByteBuffer _bb)
		{
			return IExploreSkillSearchTargetCfg.GetRootAsIExploreSkillSearchTargetCfg(_bb, default(IExploreSkillSearchTargetCfg));
		}

		// Token: 0x060221E9 RID: 139753 RVA: 0x004BC148 File Offset: 0x004BA348
		public static IExploreSkillSearchTargetCfg GetRootAsIExploreSkillSearchTargetCfg(ByteBuffer _bb, IExploreSkillSearchTargetCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060221EA RID: 139754 RVA: 0x004BC165 File Offset: 0x004BA365
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060221EB RID: 139755 RVA: 0x004BC174 File Offset: 0x004BA374
		public IExploreSkillSearchTargetCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099D2 RID: 39378
		// (get) Token: 0x060221EC RID: 139756 RVA: 0x004BC184 File Offset: 0x004BA384
		public EExploreSkillSearchTargetCfg Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreSkillSearchTargetCfg.AngleWeight;
				}
				return (EExploreSkillSearchTargetCfg)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060221ED RID: 139757 RVA: 0x004BC1C0 File Offset: 0x004BA3C0
		public static Offset<IExploreSkillSearchTargetCfg> CreateIExploreSkillSearchTargetCfg(FlatBufferBuilder builder, EExploreSkillSearchTargetCfg Type = EExploreSkillSearchTargetCfg.AngleWeight)
		{
			builder.StartTable(1);
			IExploreSkillSearchTargetCfg.AddType(builder, Type);
			return IExploreSkillSearchTargetCfg.EndIExploreSkillSearchTargetCfg(builder);
		}

		// Token: 0x060221EE RID: 139758 RVA: 0x004BC1D6 File Offset: 0x004BA3D6
		public static void StartIExploreSkillSearchTargetCfg(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060221EF RID: 139759 RVA: 0x004BC1DF File Offset: 0x004BA3DF
		public static void AddType(FlatBufferBuilder builder, EExploreSkillSearchTargetCfg type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060221F0 RID: 139760 RVA: 0x004BC1EA File Offset: 0x004BA3EA
		public static Offset<IExploreSkillSearchTargetCfg> EndIExploreSkillSearchTargetCfg(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillSearchTargetCfg>(builder.EndTable());
		}

		// Token: 0x060221F1 RID: 139761 RVA: 0x004BC1F8 File Offset: 0x004BA3F8
		public IExploreSkillSearchTargetCfgT UnPack()
		{
			IExploreSkillSearchTargetCfgT exploreSkillSearchTargetCfgT = new IExploreSkillSearchTargetCfgT();
			this.UnPackTo(exploreSkillSearchTargetCfgT);
			return exploreSkillSearchTargetCfgT;
		}

		// Token: 0x060221F2 RID: 139762 RVA: 0x004BC213 File Offset: 0x004BA413
		public void UnPackTo(IExploreSkillSearchTargetCfgT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060221F3 RID: 139763 RVA: 0x004BC224 File Offset: 0x004BA424
		public static Offset<IExploreSkillSearchTargetCfg> Pack(FlatBufferBuilder builder, IExploreSkillSearchTargetCfgT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillSearchTargetCfg>);
			}
			return IExploreSkillSearchTargetCfg.CreateIExploreSkillSearchTargetCfg(builder, _o.Type);
		}

		// Token: 0x0400E338 RID: 58168
		private Table __p;
	}
}
