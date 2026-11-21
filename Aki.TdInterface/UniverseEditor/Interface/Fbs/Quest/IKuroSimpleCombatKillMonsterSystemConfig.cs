using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200430D RID: 17165
	public struct IKuroSimpleCombatKillMonsterSystemConfig : IFlatbufferObject
	{
		// Token: 0x17007593 RID: 30099
		// (get) Token: 0x06018234 RID: 98868 RVA: 0x00371A66 File Offset: 0x0036FC66
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018235 RID: 98869 RVA: 0x00371A73 File Offset: 0x0036FC73
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018236 RID: 98870 RVA: 0x00371A7C File Offset: 0x0036FC7C
		public static IKuroSimpleCombatKillMonsterSystemConfig GetRootAsIKuroSimpleCombatKillMonsterSystemConfig(ByteBuffer _bb)
		{
			return IKuroSimpleCombatKillMonsterSystemConfig.GetRootAsIKuroSimpleCombatKillMonsterSystemConfig(_bb, default(IKuroSimpleCombatKillMonsterSystemConfig));
		}

		// Token: 0x06018237 RID: 98871 RVA: 0x00371A98 File Offset: 0x0036FC98
		public static IKuroSimpleCombatKillMonsterSystemConfig GetRootAsIKuroSimpleCombatKillMonsterSystemConfig(ByteBuffer _bb, IKuroSimpleCombatKillMonsterSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018238 RID: 98872 RVA: 0x00371AB5 File Offset: 0x0036FCB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018239 RID: 98873 RVA: 0x00371AC4 File Offset: 0x0036FCC4
		public IKuroSimpleCombatKillMonsterSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007594 RID: 30100
		// (get) Token: 0x0601823A RID: 98874 RVA: 0x00371AD4 File Offset: 0x0036FCD4
		public EEnableSystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnableSystemType.GradingSystem;
				}
				return (EEnableSystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601823B RID: 98875 RVA: 0x00371B10 File Offset: 0x0036FD10
		public static Offset<IKuroSimpleCombatKillMonsterSystemConfig> CreateIKuroSimpleCombatKillMonsterSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem)
		{
			builder.StartTable(1);
			IKuroSimpleCombatKillMonsterSystemConfig.AddType(builder, Type);
			return IKuroSimpleCombatKillMonsterSystemConfig.EndIKuroSimpleCombatKillMonsterSystemConfig(builder);
		}

		// Token: 0x0601823C RID: 98876 RVA: 0x00371B26 File Offset: 0x0036FD26
		public static void StartIKuroSimpleCombatKillMonsterSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601823D RID: 98877 RVA: 0x00371B2F File Offset: 0x0036FD2F
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601823E RID: 98878 RVA: 0x00371B3A File Offset: 0x0036FD3A
		public static Offset<IKuroSimpleCombatKillMonsterSystemConfig> EndIKuroSimpleCombatKillMonsterSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IKuroSimpleCombatKillMonsterSystemConfig>(builder.EndTable());
		}

		// Token: 0x0601823F RID: 98879 RVA: 0x00371B48 File Offset: 0x0036FD48
		public IKuroSimpleCombatKillMonsterSystemConfigT UnPack()
		{
			IKuroSimpleCombatKillMonsterSystemConfigT kuroSimpleCombatKillMonsterSystemConfigT = new IKuroSimpleCombatKillMonsterSystemConfigT();
			this.UnPackTo(kuroSimpleCombatKillMonsterSystemConfigT);
			return kuroSimpleCombatKillMonsterSystemConfigT;
		}

		// Token: 0x06018240 RID: 98880 RVA: 0x00371B63 File Offset: 0x0036FD63
		public void UnPackTo(IKuroSimpleCombatKillMonsterSystemConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018241 RID: 98881 RVA: 0x00371B74 File Offset: 0x0036FD74
		public static Offset<IKuroSimpleCombatKillMonsterSystemConfig> Pack(FlatBufferBuilder builder, IKuroSimpleCombatKillMonsterSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKuroSimpleCombatKillMonsterSystemConfig>);
			}
			return IKuroSimpleCombatKillMonsterSystemConfig.CreateIKuroSimpleCombatKillMonsterSystemConfig(builder, _o.Type);
		}

		// Token: 0x0400C289 RID: 49801
		private Table __p;
	}
}
