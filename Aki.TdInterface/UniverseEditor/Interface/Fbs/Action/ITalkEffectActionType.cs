using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072AA RID: 29354
	public struct ITalkEffectActionType : IFlatbufferObject
	{
		// Token: 0x1700D9BA RID: 55738
		// (get) Token: 0x0603415B RID: 213339 RVA: 0x00700483 File Offset: 0x006FE683
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603415C RID: 213340 RVA: 0x00700490 File Offset: 0x006FE690
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603415D RID: 213341 RVA: 0x00700498 File Offset: 0x006FE698
		public static ITalkEffectActionType GetRootAsITalkEffectActionType(ByteBuffer _bb)
		{
			return ITalkEffectActionType.GetRootAsITalkEffectActionType(_bb, default(ITalkEffectActionType));
		}

		// Token: 0x0603415E RID: 213342 RVA: 0x007004B4 File Offset: 0x006FE6B4
		public static ITalkEffectActionType GetRootAsITalkEffectActionType(ByteBuffer _bb, ITalkEffectActionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603415F RID: 213343 RVA: 0x007004D1 File Offset: 0x006FE6D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034160 RID: 213344 RVA: 0x007004E0 File Offset: 0x006FE6E0
		public ITalkEffectActionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9BB RID: 55739
		// (get) Token: 0x06034161 RID: 213345 RVA: 0x007004F0 File Offset: 0x006FE6F0
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

		// Token: 0x06034162 RID: 213346 RVA: 0x0070052C File Offset: 0x006FE72C
		public static Offset<ITalkEffectActionType> CreateITalkEffectActionType(FlatBufferBuilder builder, ETalkEffectActionType Type = ETalkEffectActionType.Play)
		{
			builder.StartTable(1);
			ITalkEffectActionType.AddType(builder, Type);
			return ITalkEffectActionType.EndITalkEffectActionType(builder);
		}

		// Token: 0x06034163 RID: 213347 RVA: 0x00700542 File Offset: 0x006FE742
		public static void StartITalkEffectActionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034164 RID: 213348 RVA: 0x0070054B File Offset: 0x006FE74B
		public static void AddType(FlatBufferBuilder builder, ETalkEffectActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034165 RID: 213349 RVA: 0x00700556 File Offset: 0x006FE756
		public static Offset<ITalkEffectActionType> EndITalkEffectActionType(FlatBufferBuilder builder)
		{
			return new Offset<ITalkEffectActionType>(builder.EndTable());
		}

		// Token: 0x06034166 RID: 213350 RVA: 0x00700564 File Offset: 0x006FE764
		public ITalkEffectActionTypeT UnPack()
		{
			ITalkEffectActionTypeT talkEffectActionTypeT = new ITalkEffectActionTypeT();
			this.UnPackTo(talkEffectActionTypeT);
			return talkEffectActionTypeT;
		}

		// Token: 0x06034167 RID: 213351 RVA: 0x0070057F File Offset: 0x006FE77F
		public void UnPackTo(ITalkEffectActionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034168 RID: 213352 RVA: 0x00700590 File Offset: 0x006FE790
		public static Offset<ITalkEffectActionType> Pack(FlatBufferBuilder builder, ITalkEffectActionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkEffectActionType>);
			}
			return ITalkEffectActionType.CreateITalkEffectActionType(builder, _o.Type);
		}

		// Token: 0x04011DC1 RID: 73153
		private Table __p;
	}
}
