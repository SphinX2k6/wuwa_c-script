using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F69 RID: 28521
	public struct ISendBattleStateType : IFlatbufferObject
	{
		// Token: 0x1700D3E6 RID: 54246
		// (get) Token: 0x0603263B RID: 206395 RVA: 0x006CD758 File Offset: 0x006CB958
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603263C RID: 206396 RVA: 0x006CD765 File Offset: 0x006CB965
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603263D RID: 206397 RVA: 0x006CD76C File Offset: 0x006CB96C
		public static ISendBattleStateType GetRootAsISendBattleStateType(ByteBuffer _bb)
		{
			return ISendBattleStateType.GetRootAsISendBattleStateType(_bb, default(ISendBattleStateType));
		}

		// Token: 0x0603263E RID: 206398 RVA: 0x006CD788 File Offset: 0x006CB988
		public static ISendBattleStateType GetRootAsISendBattleStateType(ByteBuffer _bb, ISendBattleStateType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603263F RID: 206399 RVA: 0x006CD7A5 File Offset: 0x006CB9A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032640 RID: 206400 RVA: 0x006CD7B4 File Offset: 0x006CB9B4
		public ISendBattleStateType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3E7 RID: 54247
		// (get) Token: 0x06032641 RID: 206401 RVA: 0x006CD7C4 File Offset: 0x006CB9C4
		public ESetBattleStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetBattleStateType.SetBattleTag;
				}
				return (ESetBattleStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032642 RID: 206402 RVA: 0x006CD800 File Offset: 0x006CBA00
		public static Offset<ISendBattleStateType> CreateISendBattleStateType(FlatBufferBuilder builder, ESetBattleStateType Type = ESetBattleStateType.SetBattleTag)
		{
			builder.StartTable(1);
			ISendBattleStateType.AddType(builder, Type);
			return ISendBattleStateType.EndISendBattleStateType(builder);
		}

		// Token: 0x06032643 RID: 206403 RVA: 0x006CD816 File Offset: 0x006CBA16
		public static void StartISendBattleStateType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032644 RID: 206404 RVA: 0x006CD81F File Offset: 0x006CBA1F
		public static void AddType(FlatBufferBuilder builder, ESetBattleStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032645 RID: 206405 RVA: 0x006CD82A File Offset: 0x006CBA2A
		public static Offset<ISendBattleStateType> EndISendBattleStateType(FlatBufferBuilder builder)
		{
			return new Offset<ISendBattleStateType>(builder.EndTable());
		}

		// Token: 0x06032646 RID: 206406 RVA: 0x006CD838 File Offset: 0x006CBA38
		public ISendBattleStateTypeT UnPack()
		{
			ISendBattleStateTypeT sendBattleStateTypeT = new ISendBattleStateTypeT();
			this.UnPackTo(sendBattleStateTypeT);
			return sendBattleStateTypeT;
		}

		// Token: 0x06032647 RID: 206407 RVA: 0x006CD853 File Offset: 0x006CBA53
		public void UnPackTo(ISendBattleStateTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032648 RID: 206408 RVA: 0x006CD864 File Offset: 0x006CBA64
		public static Offset<ISendBattleStateType> Pack(FlatBufferBuilder builder, ISendBattleStateTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISendBattleStateType>);
			}
			return ISendBattleStateType.CreateISendBattleStateType(builder, _o.Type);
		}

		// Token: 0x04011963 RID: 72035
		private Table __p;
	}
}
