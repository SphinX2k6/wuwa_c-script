using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E2A RID: 32298
	public struct IWuWaGoGame : IFlatbufferObject
	{
		// Token: 0x1700F1D9 RID: 61913
		// (get) Token: 0x0603A5C9 RID: 239049 RVA: 0x007DC41D File Offset: 0x007DA61D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A5CA RID: 239050 RVA: 0x007DC42A File Offset: 0x007DA62A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A5CB RID: 239051 RVA: 0x007DC434 File Offset: 0x007DA634
		public static IWuWaGoGame GetRootAsIWuWaGoGame(ByteBuffer _bb)
		{
			return IWuWaGoGame.GetRootAsIWuWaGoGame(_bb, default(IWuWaGoGame));
		}

		// Token: 0x0603A5CC RID: 239052 RVA: 0x007DC450 File Offset: 0x007DA650
		public static IWuWaGoGame GetRootAsIWuWaGoGame(ByteBuffer _bb, IWuWaGoGame obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A5CD RID: 239053 RVA: 0x007DC46D File Offset: 0x007DA66D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A5CE RID: 239054 RVA: 0x007DC47C File Offset: 0x007DA67C
		public IWuWaGoGame __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F1DA RID: 61914
		// (get) Token: 0x0603A5CF RID: 239055 RVA: 0x007DC48C File Offset: 0x007DA68C
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F1DB RID: 61915
		// (get) Token: 0x0603A5D0 RID: 239056 RVA: 0x007DC4C8 File Offset: 0x007DA6C8
		public int LevelCenterId
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

		// Token: 0x0603A5D1 RID: 239057 RVA: 0x007DC504 File Offset: 0x007DA704
		public static Offset<IWuWaGoGame> CreateIWuWaGoGame(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int LevelCenterId = 0)
		{
			builder.StartTable(2);
			IWuWaGoGame.AddLevelCenterId(builder, LevelCenterId);
			IWuWaGoGame.AddType(builder, Type);
			return IWuWaGoGame.EndIWuWaGoGame(builder);
		}

		// Token: 0x0603A5D2 RID: 239058 RVA: 0x007DC521 File Offset: 0x007DA721
		public static void StartIWuWaGoGame(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603A5D3 RID: 239059 RVA: 0x007DC52A File Offset: 0x007DA72A
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A5D4 RID: 239060 RVA: 0x007DC535 File Offset: 0x007DA735
		public static void AddLevelCenterId(FlatBufferBuilder builder, int levelCenterId)
		{
			builder.AddInt(1, levelCenterId, 0);
		}

		// Token: 0x0603A5D5 RID: 239061 RVA: 0x007DC540 File Offset: 0x007DA740
		public static Offset<IWuWaGoGame> EndIWuWaGoGame(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoGame>(builder.EndTable());
		}

		// Token: 0x0603A5D6 RID: 239062 RVA: 0x007DC550 File Offset: 0x007DA750
		public IWuWaGoGameT UnPack()
		{
			IWuWaGoGameT wuWaGoGameT = new IWuWaGoGameT();
			this.UnPackTo(wuWaGoGameT);
			return wuWaGoGameT;
		}

		// Token: 0x0603A5D7 RID: 239063 RVA: 0x007DC56B File Offset: 0x007DA76B
		public void UnPackTo(IWuWaGoGameT _o)
		{
			_o.Type = this.Type;
			_o.LevelCenterId = this.LevelCenterId;
		}

		// Token: 0x0603A5D8 RID: 239064 RVA: 0x007DC588 File Offset: 0x007DA788
		public static Offset<IWuWaGoGame> Pack(FlatBufferBuilder builder, IWuWaGoGameT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoGame>);
			}
			return IWuWaGoGame.CreateIWuWaGoGame(builder, _o.Type, _o.LevelCenterId);
		}

		// Token: 0x040135D2 RID: 79314
		private Table __p;
	}
}
