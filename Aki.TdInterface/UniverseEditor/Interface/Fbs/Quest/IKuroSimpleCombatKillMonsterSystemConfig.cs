using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003ECF RID: 16079
	public struct IKuroSimpleCombatKillMonsterSystemConfig : IFlatbufferObject
	{
		// Token: 0x17006FA4 RID: 28580
		// (get) Token: 0x06016BDD RID: 93149 RVA: 0x0034889A File Offset: 0x00346A9A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016BDE RID: 93150 RVA: 0x003488A7 File Offset: 0x00346AA7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016BDF RID: 93151 RVA: 0x003488B0 File Offset: 0x00346AB0
		public static IKuroSimpleCombatKillMonsterSystemConfig GetRootAsIKuroSimpleCombatKillMonsterSystemConfig(ByteBuffer _bb)
		{
			return IKuroSimpleCombatKillMonsterSystemConfig.GetRootAsIKuroSimpleCombatKillMonsterSystemConfig(_bb, default(IKuroSimpleCombatKillMonsterSystemConfig));
		}

		// Token: 0x06016BE0 RID: 93152 RVA: 0x003488CC File Offset: 0x00346ACC
		public static IKuroSimpleCombatKillMonsterSystemConfig GetRootAsIKuroSimpleCombatKillMonsterSystemConfig(ByteBuffer _bb, IKuroSimpleCombatKillMonsterSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016BE1 RID: 93153 RVA: 0x003488E9 File Offset: 0x00346AE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016BE2 RID: 93154 RVA: 0x003488F8 File Offset: 0x00346AF8
		public IKuroSimpleCombatKillMonsterSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FA5 RID: 28581
		// (get) Token: 0x06016BE3 RID: 93155 RVA: 0x00348908 File Offset: 0x00346B08
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

		// Token: 0x06016BE4 RID: 93156 RVA: 0x00348944 File Offset: 0x00346B44
		public static Offset<IKuroSimpleCombatKillMonsterSystemConfig> CreateIKuroSimpleCombatKillMonsterSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem)
		{
			builder.StartTable(1);
			IKuroSimpleCombatKillMonsterSystemConfig.AddType(builder, Type);
			return IKuroSimpleCombatKillMonsterSystemConfig.EndIKuroSimpleCombatKillMonsterSystemConfig(builder);
		}

		// Token: 0x06016BE5 RID: 93157 RVA: 0x0034895A File Offset: 0x00346B5A
		public static void StartIKuroSimpleCombatKillMonsterSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016BE6 RID: 93158 RVA: 0x00348963 File Offset: 0x00346B63
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016BE7 RID: 93159 RVA: 0x0034896E File Offset: 0x00346B6E
		public static Offset<IKuroSimpleCombatKillMonsterSystemConfig> EndIKuroSimpleCombatKillMonsterSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IKuroSimpleCombatKillMonsterSystemConfig>(builder.EndTable());
		}

		// Token: 0x06016BE8 RID: 93160 RVA: 0x0034897C File Offset: 0x00346B7C
		public IKuroSimpleCombatKillMonsterSystemConfigT UnPack()
		{
			IKuroSimpleCombatKillMonsterSystemConfigT kuroSimpleCombatKillMonsterSystemConfigT = new IKuroSimpleCombatKillMonsterSystemConfigT();
			this.UnPackTo(kuroSimpleCombatKillMonsterSystemConfigT);
			return kuroSimpleCombatKillMonsterSystemConfigT;
		}

		// Token: 0x06016BE9 RID: 93161 RVA: 0x00348997 File Offset: 0x00346B97
		public void UnPackTo(IKuroSimpleCombatKillMonsterSystemConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016BEA RID: 93162 RVA: 0x003489A8 File Offset: 0x00346BA8
		public static Offset<IKuroSimpleCombatKillMonsterSystemConfig> Pack(FlatBufferBuilder builder, IKuroSimpleCombatKillMonsterSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKuroSimpleCombatKillMonsterSystemConfig>);
			}
			return IKuroSimpleCombatKillMonsterSystemConfig.CreateIKuroSimpleCombatKillMonsterSystemConfig(builder, _o.Type);
		}

		// Token: 0x0400B8AC RID: 47276
		private Table __p;
	}
}
