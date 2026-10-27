using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200761C RID: 30236
	public struct IWuWaGoGame : IFlatbufferObject
	{
		// Token: 0x1700E59B RID: 58779
		// (get) Token: 0x06037124 RID: 225572 RVA: 0x00778321 File Offset: 0x00776521
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037125 RID: 225573 RVA: 0x0077832E File Offset: 0x0077652E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037126 RID: 225574 RVA: 0x00778338 File Offset: 0x00776538
		public static IWuWaGoGame GetRootAsIWuWaGoGame(ByteBuffer _bb)
		{
			return IWuWaGoGame.GetRootAsIWuWaGoGame(_bb, default(IWuWaGoGame));
		}

		// Token: 0x06037127 RID: 225575 RVA: 0x00778354 File Offset: 0x00776554
		public static IWuWaGoGame GetRootAsIWuWaGoGame(ByteBuffer _bb, IWuWaGoGame obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037128 RID: 225576 RVA: 0x00778371 File Offset: 0x00776571
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037129 RID: 225577 RVA: 0x00778380 File Offset: 0x00776580
		public IWuWaGoGame __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E59C RID: 58780
		// (get) Token: 0x0603712A RID: 225578 RVA: 0x00778390 File Offset: 0x00776590
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

		// Token: 0x1700E59D RID: 58781
		// (get) Token: 0x0603712B RID: 225579 RVA: 0x007783CC File Offset: 0x007765CC
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

		// Token: 0x0603712C RID: 225580 RVA: 0x00778408 File Offset: 0x00776608
		public static Offset<IWuWaGoGame> CreateIWuWaGoGame(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int LevelCenterId = 0)
		{
			builder.StartTable(2);
			IWuWaGoGame.AddLevelCenterId(builder, LevelCenterId);
			IWuWaGoGame.AddType(builder, Type);
			return IWuWaGoGame.EndIWuWaGoGame(builder);
		}

		// Token: 0x0603712D RID: 225581 RVA: 0x00778425 File Offset: 0x00776625
		public static void StartIWuWaGoGame(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603712E RID: 225582 RVA: 0x0077842E File Offset: 0x0077662E
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603712F RID: 225583 RVA: 0x00778439 File Offset: 0x00776639
		public static void AddLevelCenterId(FlatBufferBuilder builder, int levelCenterId)
		{
			builder.AddInt(1, levelCenterId, 0);
		}

		// Token: 0x06037130 RID: 225584 RVA: 0x00778444 File Offset: 0x00776644
		public static Offset<IWuWaGoGame> EndIWuWaGoGame(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoGame>(builder.EndTable());
		}

		// Token: 0x06037131 RID: 225585 RVA: 0x00778454 File Offset: 0x00776654
		public IWuWaGoGameT UnPack()
		{
			IWuWaGoGameT wuWaGoGameT = new IWuWaGoGameT();
			this.UnPackTo(wuWaGoGameT);
			return wuWaGoGameT;
		}

		// Token: 0x06037132 RID: 225586 RVA: 0x0077846F File Offset: 0x0077666F
		public void UnPackTo(IWuWaGoGameT _o)
		{
			_o.Type = this.Type;
			_o.LevelCenterId = this.LevelCenterId;
		}

		// Token: 0x06037133 RID: 225587 RVA: 0x0077848C File Offset: 0x0077668C
		public static Offset<IWuWaGoGame> Pack(FlatBufferBuilder builder, IWuWaGoGameT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoGame>);
			}
			return IWuWaGoGame.CreateIWuWaGoGame(builder, _o.Type, _o.LevelCenterId);
		}

		// Token: 0x04012588 RID: 75144
		private Table __p;
	}
}
