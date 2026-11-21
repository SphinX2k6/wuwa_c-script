using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042B0 RID: 17072
	public struct IGameDifficultySystemConfig : IFlatbufferObject
	{
		// Token: 0x170074CA RID: 29898
		// (get) Token: 0x06017E9C RID: 97948 RVA: 0x0036A2F1 File Offset: 0x003684F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017E9D RID: 97949 RVA: 0x0036A2FE File Offset: 0x003684FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017E9E RID: 97950 RVA: 0x0036A308 File Offset: 0x00368508
		public static IGameDifficultySystemConfig GetRootAsIGameDifficultySystemConfig(ByteBuffer _bb)
		{
			return IGameDifficultySystemConfig.GetRootAsIGameDifficultySystemConfig(_bb, default(IGameDifficultySystemConfig));
		}

		// Token: 0x06017E9F RID: 97951 RVA: 0x0036A324 File Offset: 0x00368524
		public static IGameDifficultySystemConfig GetRootAsIGameDifficultySystemConfig(ByteBuffer _bb, IGameDifficultySystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017EA0 RID: 97952 RVA: 0x0036A341 File Offset: 0x00368541
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017EA1 RID: 97953 RVA: 0x0036A350 File Offset: 0x00368550
		public IGameDifficultySystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074CB RID: 29899
		// (get) Token: 0x06017EA2 RID: 97954 RVA: 0x0036A360 File Offset: 0x00368560
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

		// Token: 0x06017EA3 RID: 97955 RVA: 0x0036A39C File Offset: 0x0036859C
		public static Offset<IGameDifficultySystemConfig> CreateIGameDifficultySystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem)
		{
			builder.StartTable(1);
			IGameDifficultySystemConfig.AddType(builder, Type);
			return IGameDifficultySystemConfig.EndIGameDifficultySystemConfig(builder);
		}

		// Token: 0x06017EA4 RID: 97956 RVA: 0x0036A3B2 File Offset: 0x003685B2
		public static void StartIGameDifficultySystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017EA5 RID: 97957 RVA: 0x0036A3BB File Offset: 0x003685BB
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017EA6 RID: 97958 RVA: 0x0036A3C6 File Offset: 0x003685C6
		public static Offset<IGameDifficultySystemConfig> EndIGameDifficultySystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGameDifficultySystemConfig>(builder.EndTable());
		}

		// Token: 0x06017EA7 RID: 97959 RVA: 0x0036A3D4 File Offset: 0x003685D4
		public IGameDifficultySystemConfigT UnPack()
		{
			IGameDifficultySystemConfigT gameDifficultySystemConfigT = new IGameDifficultySystemConfigT();
			this.UnPackTo(gameDifficultySystemConfigT);
			return gameDifficultySystemConfigT;
		}

		// Token: 0x06017EA8 RID: 97960 RVA: 0x0036A3EF File Offset: 0x003685EF
		public void UnPackTo(IGameDifficultySystemConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017EA9 RID: 97961 RVA: 0x0036A400 File Offset: 0x00368600
		public static Offset<IGameDifficultySystemConfig> Pack(FlatBufferBuilder builder, IGameDifficultySystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameDifficultySystemConfig>);
			}
			return IGameDifficultySystemConfig.CreateIGameDifficultySystemConfig(builder, _o.Type);
		}

		// Token: 0x0400C205 RID: 49669
		private Table __p;
	}
}
