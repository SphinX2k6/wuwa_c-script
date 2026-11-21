using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A7F RID: 31359
	public struct ITalkEffectActionType : IFlatbufferObject
	{
		// Token: 0x1700E5B3 RID: 58803
		// (get) Token: 0x0603745F RID: 226399 RVA: 0x0076181F File Offset: 0x0075FA1F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037460 RID: 226400 RVA: 0x0076182C File Offset: 0x0075FA2C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037461 RID: 226401 RVA: 0x00761834 File Offset: 0x0075FA34
		public static ITalkEffectActionType GetRootAsITalkEffectActionType(ByteBuffer _bb)
		{
			return ITalkEffectActionType.GetRootAsITalkEffectActionType(_bb, default(ITalkEffectActionType));
		}

		// Token: 0x06037462 RID: 226402 RVA: 0x00761850 File Offset: 0x0075FA50
		public static ITalkEffectActionType GetRootAsITalkEffectActionType(ByteBuffer _bb, ITalkEffectActionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037463 RID: 226403 RVA: 0x0076186D File Offset: 0x0075FA6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037464 RID: 226404 RVA: 0x0076187C File Offset: 0x0075FA7C
		public ITalkEffectActionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E5B4 RID: 58804
		// (get) Token: 0x06037465 RID: 226405 RVA: 0x0076188C File Offset: 0x0075FA8C
		public ETalkEffectActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkEffectActionType.Play;
				}
				return (ETalkEffectActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06037466 RID: 226406 RVA: 0x007618C8 File Offset: 0x0075FAC8
		public static Offset<ITalkEffectActionType> CreateITalkEffectActionType(FlatBufferBuilder builder, ETalkEffectActionType Type = ETalkEffectActionType.Play)
		{
			builder.StartTable(1);
			ITalkEffectActionType.AddType(builder, Type);
			return ITalkEffectActionType.EndITalkEffectActionType(builder);
		}

		// Token: 0x06037467 RID: 226407 RVA: 0x007618DE File Offset: 0x0075FADE
		public static void StartITalkEffectActionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06037468 RID: 226408 RVA: 0x007618E7 File Offset: 0x0075FAE7
		public static void AddType(FlatBufferBuilder builder, ETalkEffectActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037469 RID: 226409 RVA: 0x007618F2 File Offset: 0x0075FAF2
		public static Offset<ITalkEffectActionType> EndITalkEffectActionType(FlatBufferBuilder builder)
		{
			return new Offset<ITalkEffectActionType>(builder.EndTable());
		}

		// Token: 0x0603746A RID: 226410 RVA: 0x00761900 File Offset: 0x0075FB00
		public ITalkEffectActionTypeT UnPack()
		{
			ITalkEffectActionTypeT talkEffectActionTypeT = new ITalkEffectActionTypeT();
			this.UnPackTo(talkEffectActionTypeT);
			return talkEffectActionTypeT;
		}

		// Token: 0x0603746B RID: 226411 RVA: 0x0076191B File Offset: 0x0075FB1B
		public void UnPackTo(ITalkEffectActionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603746C RID: 226412 RVA: 0x0076192C File Offset: 0x0075FB2C
		public static Offset<ITalkEffectActionType> Pack(FlatBufferBuilder builder, ITalkEffectActionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkEffectActionType>);
			}
			return ITalkEffectActionType.CreateITalkEffectActionType(builder, _o.Type);
		}

		// Token: 0x04012DC4 RID: 77252
		private Table __p;
	}
}
