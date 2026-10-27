using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C97 RID: 19607
	public struct IPreLevelPlayCondtion : IFlatbufferObject
	{
		// Token: 0x17008E5C RID: 36444
		// (get) Token: 0x0601F195 RID: 127381 RVA: 0x0045861E File Offset: 0x0045681E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F196 RID: 127382 RVA: 0x0045862B File Offset: 0x0045682B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F197 RID: 127383 RVA: 0x00458634 File Offset: 0x00456834
		public static IPreLevelPlayCondtion GetRootAsIPreLevelPlayCondtion(ByteBuffer _bb)
		{
			return IPreLevelPlayCondtion.GetRootAsIPreLevelPlayCondtion(_bb, default(IPreLevelPlayCondtion));
		}

		// Token: 0x0601F198 RID: 127384 RVA: 0x00458650 File Offset: 0x00456850
		public static IPreLevelPlayCondtion GetRootAsIPreLevelPlayCondtion(ByteBuffer _bb, IPreLevelPlayCondtion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F199 RID: 127385 RVA: 0x0045866D File Offset: 0x0045686D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F19A RID: 127386 RVA: 0x0045867C File Offset: 0x0045687C
		public IPreLevelPlayCondtion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E5D RID: 36445
		// (get) Token: 0x0601F19B RID: 127387 RVA: 0x0045868C File Offset: 0x0045688C
		public EAccessQuestCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAccessQuestCondition.ExploreLevel;
				}
				return (EAccessQuestCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E5E RID: 36446
		// (get) Token: 0x0601F19C RID: 127388 RVA: 0x004586C8 File Offset: 0x004568C8
		public int PreLevelPlay
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

		// Token: 0x0601F19D RID: 127389 RVA: 0x00458704 File Offset: 0x00456904
		public static Offset<IPreLevelPlayCondtion> CreateIPreLevelPlayCondtion(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, int PreLevelPlay = 0)
		{
			builder.StartTable(2);
			IPreLevelPlayCondtion.AddPreLevelPlay(builder, PreLevelPlay);
			IPreLevelPlayCondtion.AddType(builder, Type);
			return IPreLevelPlayCondtion.EndIPreLevelPlayCondtion(builder);
		}

		// Token: 0x0601F19E RID: 127390 RVA: 0x00458721 File Offset: 0x00456921
		public static void StartIPreLevelPlayCondtion(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F19F RID: 127391 RVA: 0x0045872A File Offset: 0x0045692A
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F1A0 RID: 127392 RVA: 0x00458735 File Offset: 0x00456935
		public static void AddPreLevelPlay(FlatBufferBuilder builder, int preLevelPlay)
		{
			builder.AddInt(1, preLevelPlay, 0);
		}

		// Token: 0x0601F1A1 RID: 127393 RVA: 0x00458740 File Offset: 0x00456940
		public static Offset<IPreLevelPlayCondtion> EndIPreLevelPlayCondtion(FlatBufferBuilder builder)
		{
			return new Offset<IPreLevelPlayCondtion>(builder.EndTable());
		}

		// Token: 0x0601F1A2 RID: 127394 RVA: 0x00458750 File Offset: 0x00456950
		public IPreLevelPlayCondtionT UnPack()
		{
			IPreLevelPlayCondtionT preLevelPlayCondtionT = new IPreLevelPlayCondtionT();
			this.UnPackTo(preLevelPlayCondtionT);
			return preLevelPlayCondtionT;
		}

		// Token: 0x0601F1A3 RID: 127395 RVA: 0x0045876B File Offset: 0x0045696B
		public void UnPackTo(IPreLevelPlayCondtionT _o)
		{
			_o.Type = this.Type;
			_o.PreLevelPlay = this.PreLevelPlay;
		}

		// Token: 0x0601F1A4 RID: 127396 RVA: 0x00458788 File Offset: 0x00456988
		public static Offset<IPreLevelPlayCondtion> Pack(FlatBufferBuilder builder, IPreLevelPlayCondtionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreLevelPlayCondtion>);
			}
			return IPreLevelPlayCondtion.CreateIPreLevelPlayCondtion(builder, _o.Type, _o.PreLevelPlay);
		}

		// Token: 0x0400D651 RID: 54865
		private Table __p;
	}
}
