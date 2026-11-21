using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200576F RID: 22383
	public struct IExploreSkillSearchTargetCfg : IFlatbufferObject
	{
		// Token: 0x1700A1CD RID: 41421
		// (get) Token: 0x0602417C RID: 147836 RVA: 0x004F6BD9 File Offset: 0x004F4DD9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602417D RID: 147837 RVA: 0x004F6BE6 File Offset: 0x004F4DE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602417E RID: 147838 RVA: 0x004F6BF0 File Offset: 0x004F4DF0
		public static IExploreSkillSearchTargetCfg GetRootAsIExploreSkillSearchTargetCfg(ByteBuffer _bb)
		{
			return IExploreSkillSearchTargetCfg.GetRootAsIExploreSkillSearchTargetCfg(_bb, default(IExploreSkillSearchTargetCfg));
		}

		// Token: 0x0602417F RID: 147839 RVA: 0x004F6C0C File Offset: 0x004F4E0C
		public static IExploreSkillSearchTargetCfg GetRootAsIExploreSkillSearchTargetCfg(ByteBuffer _bb, IExploreSkillSearchTargetCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024180 RID: 147840 RVA: 0x004F6C29 File Offset: 0x004F4E29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024181 RID: 147841 RVA: 0x004F6C38 File Offset: 0x004F4E38
		public IExploreSkillSearchTargetCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1CE RID: 41422
		// (get) Token: 0x06024182 RID: 147842 RVA: 0x004F6C48 File Offset: 0x004F4E48
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

		// Token: 0x06024183 RID: 147843 RVA: 0x004F6C84 File Offset: 0x004F4E84
		public static Offset<IExploreSkillSearchTargetCfg> CreateIExploreSkillSearchTargetCfg(FlatBufferBuilder builder, EExploreSkillSearchTargetCfg Type = EExploreSkillSearchTargetCfg.AngleWeight)
		{
			builder.StartTable(1);
			IExploreSkillSearchTargetCfg.AddType(builder, Type);
			return IExploreSkillSearchTargetCfg.EndIExploreSkillSearchTargetCfg(builder);
		}

		// Token: 0x06024184 RID: 147844 RVA: 0x004F6C9A File Offset: 0x004F4E9A
		public static void StartIExploreSkillSearchTargetCfg(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024185 RID: 147845 RVA: 0x004F6CA3 File Offset: 0x004F4EA3
		public static void AddType(FlatBufferBuilder builder, EExploreSkillSearchTargetCfg type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024186 RID: 147846 RVA: 0x004F6CAE File Offset: 0x004F4EAE
		public static Offset<IExploreSkillSearchTargetCfg> EndIExploreSkillSearchTargetCfg(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillSearchTargetCfg>(builder.EndTable());
		}

		// Token: 0x06024187 RID: 147847 RVA: 0x004F6CBC File Offset: 0x004F4EBC
		public IExploreSkillSearchTargetCfgT UnPack()
		{
			IExploreSkillSearchTargetCfgT exploreSkillSearchTargetCfgT = new IExploreSkillSearchTargetCfgT();
			this.UnPackTo(exploreSkillSearchTargetCfgT);
			return exploreSkillSearchTargetCfgT;
		}

		// Token: 0x06024188 RID: 147848 RVA: 0x004F6CD7 File Offset: 0x004F4ED7
		public void UnPackTo(IExploreSkillSearchTargetCfgT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024189 RID: 147849 RVA: 0x004F6CE8 File Offset: 0x004F4EE8
		public static Offset<IExploreSkillSearchTargetCfg> Pack(FlatBufferBuilder builder, IExploreSkillSearchTargetCfgT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillSearchTargetCfg>);
			}
			return IExploreSkillSearchTargetCfg.CreateIExploreSkillSearchTargetCfg(builder, _o.Type);
		}

		// Token: 0x0400EF3E RID: 61246
		private Table __p;
	}
}
