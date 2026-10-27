using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E75 RID: 15989
	public struct IGameDifficultySystemConfig : IFlatbufferObject
	{
		// Token: 0x17006EE2 RID: 28386
		// (get) Token: 0x06016865 RID: 92261 RVA: 0x0034156D File Offset: 0x0033F76D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016866 RID: 92262 RVA: 0x0034157A File Offset: 0x0033F77A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016867 RID: 92263 RVA: 0x00341584 File Offset: 0x0033F784
		public static IGameDifficultySystemConfig GetRootAsIGameDifficultySystemConfig(ByteBuffer _bb)
		{
			return IGameDifficultySystemConfig.GetRootAsIGameDifficultySystemConfig(_bb, default(IGameDifficultySystemConfig));
		}

		// Token: 0x06016868 RID: 92264 RVA: 0x003415A0 File Offset: 0x0033F7A0
		public static IGameDifficultySystemConfig GetRootAsIGameDifficultySystemConfig(ByteBuffer _bb, IGameDifficultySystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016869 RID: 92265 RVA: 0x003415BD File Offset: 0x0033F7BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601686A RID: 92266 RVA: 0x003415CC File Offset: 0x0033F7CC
		public IGameDifficultySystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EE3 RID: 28387
		// (get) Token: 0x0601686B RID: 92267 RVA: 0x003415DC File Offset: 0x0033F7DC
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

		// Token: 0x0601686C RID: 92268 RVA: 0x00341618 File Offset: 0x0033F818
		public static Offset<IGameDifficultySystemConfig> CreateIGameDifficultySystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem)
		{
			builder.StartTable(1);
			IGameDifficultySystemConfig.AddType(builder, Type);
			return IGameDifficultySystemConfig.EndIGameDifficultySystemConfig(builder);
		}

		// Token: 0x0601686D RID: 92269 RVA: 0x0034162E File Offset: 0x0033F82E
		public static void StartIGameDifficultySystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601686E RID: 92270 RVA: 0x00341637 File Offset: 0x0033F837
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601686F RID: 92271 RVA: 0x00341642 File Offset: 0x0033F842
		public static Offset<IGameDifficultySystemConfig> EndIGameDifficultySystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGameDifficultySystemConfig>(builder.EndTable());
		}

		// Token: 0x06016870 RID: 92272 RVA: 0x00341650 File Offset: 0x0033F850
		public IGameDifficultySystemConfigT UnPack()
		{
			IGameDifficultySystemConfigT gameDifficultySystemConfigT = new IGameDifficultySystemConfigT();
			this.UnPackTo(gameDifficultySystemConfigT);
			return gameDifficultySystemConfigT;
		}

		// Token: 0x06016871 RID: 92273 RVA: 0x0034166B File Offset: 0x0033F86B
		public void UnPackTo(IGameDifficultySystemConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016872 RID: 92274 RVA: 0x0034167C File Offset: 0x0033F87C
		public static Offset<IGameDifficultySystemConfig> Pack(FlatBufferBuilder builder, IGameDifficultySystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameDifficultySystemConfig>);
			}
			return IGameDifficultySystemConfig.CreateIGameDifficultySystemConfig(builder, _o.Type);
		}

		// Token: 0x0400B82C RID: 47148
		private Table __p;
	}
}
