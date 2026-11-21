using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200772C RID: 30508
	public struct ISendBattleStateType : IFlatbufferObject
	{
		// Token: 0x1700DFB2 RID: 57266
		// (get) Token: 0x06035879 RID: 219257 RVA: 0x0072CF98 File Offset: 0x0072B198
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603587A RID: 219258 RVA: 0x0072CFA5 File Offset: 0x0072B1A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603587B RID: 219259 RVA: 0x0072CFAC File Offset: 0x0072B1AC
		public static ISendBattleStateType GetRootAsISendBattleStateType(ByteBuffer _bb)
		{
			return ISendBattleStateType.GetRootAsISendBattleStateType(_bb, default(ISendBattleStateType));
		}

		// Token: 0x0603587C RID: 219260 RVA: 0x0072CFC8 File Offset: 0x0072B1C8
		public static ISendBattleStateType GetRootAsISendBattleStateType(ByteBuffer _bb, ISendBattleStateType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603587D RID: 219261 RVA: 0x0072CFE5 File Offset: 0x0072B1E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603587E RID: 219262 RVA: 0x0072CFF4 File Offset: 0x0072B1F4
		public ISendBattleStateType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFB3 RID: 57267
		// (get) Token: 0x0603587F RID: 219263 RVA: 0x0072D004 File Offset: 0x0072B204
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

		// Token: 0x06035880 RID: 219264 RVA: 0x0072D040 File Offset: 0x0072B240
		public static Offset<ISendBattleStateType> CreateISendBattleStateType(FlatBufferBuilder builder, ESetBattleStateType Type = ESetBattleStateType.SetBattleTag)
		{
			builder.StartTable(1);
			ISendBattleStateType.AddType(builder, Type);
			return ISendBattleStateType.EndISendBattleStateType(builder);
		}

		// Token: 0x06035881 RID: 219265 RVA: 0x0072D056 File Offset: 0x0072B256
		public static void StartISendBattleStateType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035882 RID: 219266 RVA: 0x0072D05F File Offset: 0x0072B25F
		public static void AddType(FlatBufferBuilder builder, ESetBattleStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035883 RID: 219267 RVA: 0x0072D06A File Offset: 0x0072B26A
		public static Offset<ISendBattleStateType> EndISendBattleStateType(FlatBufferBuilder builder)
		{
			return new Offset<ISendBattleStateType>(builder.EndTable());
		}

		// Token: 0x06035884 RID: 219268 RVA: 0x0072D078 File Offset: 0x0072B278
		public ISendBattleStateTypeT UnPack()
		{
			ISendBattleStateTypeT sendBattleStateTypeT = new ISendBattleStateTypeT();
			this.UnPackTo(sendBattleStateTypeT);
			return sendBattleStateTypeT;
		}

		// Token: 0x06035885 RID: 219269 RVA: 0x0072D093 File Offset: 0x0072B293
		public void UnPackTo(ISendBattleStateTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035886 RID: 219270 RVA: 0x0072D0A4 File Offset: 0x0072B2A4
		public static Offset<ISendBattleStateType> Pack(FlatBufferBuilder builder, ISendBattleStateTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISendBattleStateType>);
			}
			return ISendBattleStateType.CreateISendBattleStateType(builder, _o.Type);
		}

		// Token: 0x04012943 RID: 76099
		private Table __p;
	}
}
