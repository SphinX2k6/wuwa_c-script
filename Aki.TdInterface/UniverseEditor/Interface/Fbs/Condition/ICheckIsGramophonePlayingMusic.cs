using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A8D RID: 19085
	public struct ICheckIsGramophonePlayingMusic : IFlatbufferObject
	{
		// Token: 0x17008A43 RID: 35395
		// (get) Token: 0x0601DEE2 RID: 122594 RVA: 0x004340BE File Offset: 0x004322BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DEE3 RID: 122595 RVA: 0x004340CB File Offset: 0x004322CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DEE4 RID: 122596 RVA: 0x004340D4 File Offset: 0x004322D4
		public static ICheckIsGramophonePlayingMusic GetRootAsICheckIsGramophonePlayingMusic(ByteBuffer _bb)
		{
			return ICheckIsGramophonePlayingMusic.GetRootAsICheckIsGramophonePlayingMusic(_bb, default(ICheckIsGramophonePlayingMusic));
		}

		// Token: 0x0601DEE5 RID: 122597 RVA: 0x004340F0 File Offset: 0x004322F0
		public static ICheckIsGramophonePlayingMusic GetRootAsICheckIsGramophonePlayingMusic(ByteBuffer _bb, ICheckIsGramophonePlayingMusic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DEE6 RID: 122598 RVA: 0x0043410D File Offset: 0x0043230D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DEE7 RID: 122599 RVA: 0x0043411C File Offset: 0x0043231C
		public ICheckIsGramophonePlayingMusic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A44 RID: 35396
		// (get) Token: 0x0601DEE8 RID: 122600 RVA: 0x0043412C File Offset: 0x0043232C
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

		// Token: 0x17008A45 RID: 35397
		// (get) Token: 0x0601DEE9 RID: 122601 RVA: 0x00434168 File Offset: 0x00432368
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

		// Token: 0x17008A46 RID: 35398
		// (get) Token: 0x0601DEEA RID: 122602 RVA: 0x004341A4 File Offset: 0x004323A4
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

		// Token: 0x0601DEEB RID: 122603 RVA: 0x00434201 File Offset: 0x00432401
		public static Offset<ICheckIsGramophonePlayingMusic> CreateICheckIsGramophonePlayingMusic(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int TargetGramophone = 0, Offset<IGramophoneCheckCondition> CheckConditionOffset = default(Offset<IGramophoneCheckCondition>))
		{
			builder.StartTable(3);
			ICheckIsGramophonePlayingMusic.AddCheckCondition(builder, CheckConditionOffset);
			ICheckIsGramophonePlayingMusic.AddTargetGramophone(builder, TargetGramophone);
			ICheckIsGramophonePlayingMusic.AddType(builder, Type);
			return ICheckIsGramophonePlayingMusic.EndICheckIsGramophonePlayingMusic(builder);
		}

		// Token: 0x0601DEEC RID: 122604 RVA: 0x00434225 File Offset: 0x00432425
		public static void StartICheckIsGramophonePlayingMusic(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DEED RID: 122605 RVA: 0x0043422E File Offset: 0x0043242E
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DEEE RID: 122606 RVA: 0x00434239 File Offset: 0x00432439
		public static void AddTargetGramophone(FlatBufferBuilder builder, int targetGramophone)
		{
			builder.AddInt(1, targetGramophone, 0);
		}

		// Token: 0x0601DEEF RID: 122607 RVA: 0x00434244 File Offset: 0x00432444
		public static void AddCheckCondition(FlatBufferBuilder builder, Offset<IGramophoneCheckCondition> checkConditionOffset)
		{
			builder.AddOffset(2, checkConditionOffset.Value, 0);
		}

		// Token: 0x0601DEF0 RID: 122608 RVA: 0x00434254 File Offset: 0x00432454
		public static Offset<ICheckIsGramophonePlayingMusic> EndICheckIsGramophonePlayingMusic(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsGramophonePlayingMusic>(builder.EndTable());
		}

		// Token: 0x0601DEF1 RID: 122609 RVA: 0x00434264 File Offset: 0x00432464
		public ICheckIsGramophonePlayingMusicT UnPack()
		{
			ICheckIsGramophonePlayingMusicT checkIsGramophonePlayingMusicT = new ICheckIsGramophonePlayingMusicT();
			this.UnPackTo(checkIsGramophonePlayingMusicT);
			return checkIsGramophonePlayingMusicT;
		}

		// Token: 0x0601DEF2 RID: 122610 RVA: 0x00434280 File Offset: 0x00432480
		public void UnPackTo(ICheckIsGramophonePlayingMusicT _o)
		{
			_o.Type = this.Type;
			_o.TargetGramophone = this.TargetGramophone;
			_o.CheckCondition = ((this.CheckCondition != null) ? this.CheckCondition.Value.UnPack() : null);
		}

		// Token: 0x0601DEF3 RID: 122611 RVA: 0x004342D4 File Offset: 0x004324D4
		public static Offset<ICheckIsGramophonePlayingMusic> Pack(FlatBufferBuilder builder, ICheckIsGramophonePlayingMusicT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsGramophonePlayingMusic>);
			}
			Offset<IGramophoneCheckCondition> checkConditionOffset = (_o.CheckCondition == null) ? default(Offset<IGramophoneCheckCondition>) : IGramophoneCheckCondition.Pack(builder, _o.CheckCondition);
			return ICheckIsGramophonePlayingMusic.CreateICheckIsGramophonePlayingMusic(builder, _o.Type, _o.TargetGramophone, checkConditionOffset);
		}

		// Token: 0x0400D2FC RID: 54012
		private Table __p;
	}
}
