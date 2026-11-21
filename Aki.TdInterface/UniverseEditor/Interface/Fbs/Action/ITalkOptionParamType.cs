using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B09 RID: 31497
	public struct ITalkOptionParamType : IFlatbufferObject
	{
		// Token: 0x1700EBFA RID: 60410
		// (get) Token: 0x06038B71 RID: 232305 RVA: 0x007AC135 File Offset: 0x007AA335
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038B72 RID: 232306 RVA: 0x007AC142 File Offset: 0x007AA342
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038B73 RID: 232307 RVA: 0x007AC14C File Offset: 0x007AA34C
		public static ITalkOptionParamType GetRootAsITalkOptionParamType(ByteBuffer _bb)
		{
			return ITalkOptionParamType.GetRootAsITalkOptionParamType(_bb, default(ITalkOptionParamType));
		}

		// Token: 0x06038B74 RID: 232308 RVA: 0x007AC168 File Offset: 0x007AA368
		public static ITalkOptionParamType GetRootAsITalkOptionParamType(ByteBuffer _bb, ITalkOptionParamType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038B75 RID: 232309 RVA: 0x007AC185 File Offset: 0x007AA385
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038B76 RID: 232310 RVA: 0x007AC194 File Offset: 0x007AA394
		public ITalkOptionParamType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EBFB RID: 60411
		// (get) Token: 0x06038B77 RID: 232311 RVA: 0x007AC1A4 File Offset: 0x007AA3A4
		public ETalkOptionParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return (ETalkOptionParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038B78 RID: 232312 RVA: 0x007AC1E0 File Offset: 0x007AA3E0
		public static Offset<ITalkOptionParamType> CreateITalkOptionParamType(FlatBufferBuilder builder, ETalkOptionParamType Type = ETalkOptionParamType.QteSucceed)
		{
			builder.StartTable(1);
			ITalkOptionParamType.AddType(builder, Type);
			return ITalkOptionParamType.EndITalkOptionParamType(builder);
		}

		// Token: 0x06038B79 RID: 232313 RVA: 0x007AC1F6 File Offset: 0x007AA3F6
		public static void StartITalkOptionParamType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038B7A RID: 232314 RVA: 0x007AC1FF File Offset: 0x007AA3FF
		public static void AddType(FlatBufferBuilder builder, ETalkOptionParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038B7B RID: 232315 RVA: 0x007AC20A File Offset: 0x007AA40A
		public static Offset<ITalkOptionParamType> EndITalkOptionParamType(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionParamType>(builder.EndTable());
		}

		// Token: 0x06038B7C RID: 232316 RVA: 0x007AC218 File Offset: 0x007AA418
		public ITalkOptionParamTypeT UnPack()
		{
			ITalkOptionParamTypeT talkOptionParamTypeT = new ITalkOptionParamTypeT();
			this.UnPackTo(talkOptionParamTypeT);
			return talkOptionParamTypeT;
		}

		// Token: 0x06038B7D RID: 232317 RVA: 0x007AC233 File Offset: 0x007AA433
		public void UnPackTo(ITalkOptionParamTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038B7E RID: 232318 RVA: 0x007AC244 File Offset: 0x007AA444
		public static Offset<ITalkOptionParamType> Pack(FlatBufferBuilder builder, ITalkOptionParamTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionParamType>);
			}
			return ITalkOptionParamType.CreateITalkOptionParamType(builder, _o.Type);
		}

		// Token: 0x04013124 RID: 78116
		private Table __p;
	}
}
