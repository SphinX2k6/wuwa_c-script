using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F53 RID: 20307
	public struct ICheckIsGramophonePlayingMusic : IFlatbufferObject
	{
		// Token: 0x1700911F RID: 37151
		// (get) Token: 0x0601F985 RID: 129413 RVA: 0x0046524A File Offset: 0x0046344A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F986 RID: 129414 RVA: 0x00465257 File Offset: 0x00463457
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F987 RID: 129415 RVA: 0x00465260 File Offset: 0x00463460
		public static ICheckIsGramophonePlayingMusic GetRootAsICheckIsGramophonePlayingMusic(ByteBuffer _bb)
		{
			return ICheckIsGramophonePlayingMusic.GetRootAsICheckIsGramophonePlayingMusic(_bb, default(ICheckIsGramophonePlayingMusic));
		}

		// Token: 0x0601F988 RID: 129416 RVA: 0x0046527C File Offset: 0x0046347C
		public static ICheckIsGramophonePlayingMusic GetRootAsICheckIsGramophonePlayingMusic(ByteBuffer _bb, ICheckIsGramophonePlayingMusic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F989 RID: 129417 RVA: 0x00465299 File Offset: 0x00463499
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F98A RID: 129418 RVA: 0x004652A8 File Offset: 0x004634A8
		public ICheckIsGramophonePlayingMusic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009120 RID: 37152
		// (get) Token: 0x0601F98B RID: 129419 RVA: 0x004652B8 File Offset: 0x004634B8
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009121 RID: 37153
		// (get) Token: 0x0601F98C RID: 129420 RVA: 0x004652F4 File Offset: 0x004634F4
		public int TargetGramophone
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009122 RID: 37154
		// (get) Token: 0x0601F98D RID: 129421 RVA: 0x00465330 File Offset: 0x00463530
		public IGramophoneCheckCondition? CheckCondition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IGramophoneCheckCondition?(default(IGramophoneCheckCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601F98E RID: 129422 RVA: 0x0046538D File Offset: 0x0046358D
		public static Offset<ICheckIsGramophonePlayingMusic> CreateICheckIsGramophonePlayingMusic(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int TargetGramophone = 0, Offset<IGramophoneCheckCondition> CheckConditionOffset = default(Offset<IGramophoneCheckCondition>))
		{
			builder.StartTable(3);
			ICheckIsGramophonePlayingMusic.AddCheckCondition(builder, CheckConditionOffset);
			ICheckIsGramophonePlayingMusic.AddTargetGramophone(builder, TargetGramophone);
			ICheckIsGramophonePlayingMusic.AddType(builder, Type);
			return ICheckIsGramophonePlayingMusic.EndICheckIsGramophonePlayingMusic(builder);
		}

		// Token: 0x0601F98F RID: 129423 RVA: 0x004653B1 File Offset: 0x004635B1
		public static void StartICheckIsGramophonePlayingMusic(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F990 RID: 129424 RVA: 0x004653BA File Offset: 0x004635BA
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F991 RID: 129425 RVA: 0x004653C5 File Offset: 0x004635C5
		public static void AddTargetGramophone(FlatBufferBuilder builder, int targetGramophone)
		{
			builder.AddInt(1, targetGramophone, 0);
		}

		// Token: 0x0601F992 RID: 129426 RVA: 0x004653D0 File Offset: 0x004635D0
		public static void AddCheckCondition(FlatBufferBuilder builder, Offset<IGramophoneCheckCondition> checkConditionOffset)
		{
			builder.AddOffset(2, checkConditionOffset.Value, 0);
		}

		// Token: 0x0601F993 RID: 129427 RVA: 0x004653E0 File Offset: 0x004635E0
		public static Offset<ICheckIsGramophonePlayingMusic> EndICheckIsGramophonePlayingMusic(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsGramophonePlayingMusic>(builder.EndTable());
		}

		// Token: 0x0601F994 RID: 129428 RVA: 0x004653F0 File Offset: 0x004635F0
		public ICheckIsGramophonePlayingMusicT UnPack()
		{
			ICheckIsGramophonePlayingMusicT checkIsGramophonePlayingMusicT = new ICheckIsGramophonePlayingMusicT();
			this.UnPackTo(checkIsGramophonePlayingMusicT);
			return checkIsGramophonePlayingMusicT;
		}

		// Token: 0x0601F995 RID: 129429 RVA: 0x0046540C File Offset: 0x0046360C
		public void UnPackTo(ICheckIsGramophonePlayingMusicT _o)
		{
			_o.Type = this.Type;
			_o.TargetGramophone = this.TargetGramophone;
			_o.CheckCondition = ((this.CheckCondition != null) ? this.CheckCondition.Value.UnPack() : null);
		}

		// Token: 0x0601F996 RID: 129430 RVA: 0x00465460 File Offset: 0x00463660
		public static Offset<ICheckIsGramophonePlayingMusic> Pack(FlatBufferBuilder builder, ICheckIsGramophonePlayingMusicT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsGramophonePlayingMusic>);
			}
			Offset<IGramophoneCheckCondition> checkConditionOffset = (_o.CheckCondition == null) ? default(Offset<IGramophoneCheckCondition>) : IGramophoneCheckCondition.Pack(builder, _o.CheckCondition);
			return ICheckIsGramophonePlayingMusic.CreateICheckIsGramophonePlayingMusic(builder, _o.Type, _o.TargetGramophone, checkConditionOffset);
		}

		// Token: 0x0400DDD7 RID: 56791
		private Table __p;
	}
}
