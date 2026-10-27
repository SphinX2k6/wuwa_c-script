using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200642D RID: 25645
	public struct ICloseSimpleGameplay : IFlatbufferObject
	{
		// Token: 0x1700BEF6 RID: 48886
		// (get) Token: 0x0602C60D RID: 181773 RVA: 0x00616BCD File Offset: 0x00614DCD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C60E RID: 181774 RVA: 0x00616BDA File Offset: 0x00614DDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C60F RID: 181775 RVA: 0x00616BE4 File Offset: 0x00614DE4
		public static ICloseSimpleGameplay GetRootAsICloseSimpleGameplay(ByteBuffer _bb)
		{
			return ICloseSimpleGameplay.GetRootAsICloseSimpleGameplay(_bb, default(ICloseSimpleGameplay));
		}

		// Token: 0x0602C610 RID: 181776 RVA: 0x00616C00 File Offset: 0x00614E00
		public static ICloseSimpleGameplay GetRootAsICloseSimpleGameplay(ByteBuffer _bb, ICloseSimpleGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C611 RID: 181777 RVA: 0x00616C1D File Offset: 0x00614E1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C612 RID: 181778 RVA: 0x00616C2C File Offset: 0x00614E2C
		public ICloseSimpleGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEF7 RID: 48887
		// (get) Token: 0x0602C613 RID: 181779 RVA: 0x00616C3C File Offset: 0x00614E3C
		public TCloseUiGame GameplayConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TCloseUiGame.NONE;
				}
				return (TCloseUiGame)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C614 RID: 181780 RVA: 0x00616C78 File Offset: 0x00614E78
		public TTable? GameplayConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C615 RID: 181781 RVA: 0x00616CBC File Offset: 0x00614EBC
		public ICloseBrokenRock GameplayConfigAsICloseBrokenRock()
		{
			return this.GameplayConfig<ICloseBrokenRock>().Value;
		}

		// Token: 0x0602C616 RID: 181782 RVA: 0x00616CD8 File Offset: 0x00614ED8
		public ICloseDragActor GameplayConfigAsICloseDragActor()
		{
			return this.GameplayConfig<ICloseDragActor>().Value;
		}

		// Token: 0x0602C617 RID: 181783 RVA: 0x00616CF4 File Offset: 0x00614EF4
		public ICloseRideFlyingCar GameplayConfigAsICloseRideFlyingCar()
		{
			return this.GameplayConfig<ICloseRideFlyingCar>().Value;
		}

		// Token: 0x0602C618 RID: 181784 RVA: 0x00616D0F File Offset: 0x00614F0F
		public static Offset<ICloseSimpleGameplay> CreateICloseSimpleGameplay(FlatBufferBuilder builder, TCloseUiGame GameplayConfig_type = TCloseUiGame.NONE, int GameplayConfigOffset = 0)
		{
			builder.StartTable(2);
			ICloseSimpleGameplay.AddGameplayConfig(builder, GameplayConfigOffset);
			ICloseSimpleGameplay.AddGameplayConfigType(builder, GameplayConfig_type);
			return ICloseSimpleGameplay.EndICloseSimpleGameplay(builder);
		}

		// Token: 0x0602C619 RID: 181785 RVA: 0x00616D2C File Offset: 0x00614F2C
		public static void StartICloseSimpleGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C61A RID: 181786 RVA: 0x00616D35 File Offset: 0x00614F35
		public static void AddGameplayConfigType(FlatBufferBuilder builder, TCloseUiGame gameplayConfigType)
		{
			builder.AddByte(0, (byte)gameplayConfigType, 0);
		}

		// Token: 0x0602C61B RID: 181787 RVA: 0x00616D40 File Offset: 0x00614F40
		public static void AddGameplayConfig(FlatBufferBuilder builder, int gameplayConfigOffset)
		{
			builder.AddOffset(1, gameplayConfigOffset, 0);
		}

		// Token: 0x0602C61C RID: 181788 RVA: 0x00616D4B File Offset: 0x00614F4B
		public static Offset<ICloseSimpleGameplay> EndICloseSimpleGameplay(FlatBufferBuilder builder)
		{
			return new Offset<ICloseSimpleGameplay>(builder.EndTable());
		}

		// Token: 0x0602C61D RID: 181789 RVA: 0x00616D58 File Offset: 0x00614F58
		public ICloseSimpleGameplayT UnPack()
		{
			ICloseSimpleGameplayT closeSimpleGameplayT = new ICloseSimpleGameplayT();
			this.UnPackTo(closeSimpleGameplayT);
			return closeSimpleGameplayT;
		}

		// Token: 0x0602C61E RID: 181790 RVA: 0x00616D74 File Offset: 0x00614F74
		public void UnPackTo(ICloseSimpleGameplayT _o)
		{
			_o.GameplayConfig = new TCloseUiGameUnion();
			_o.GameplayConfig.Type = this.GameplayConfigType;
			switch (this.GameplayConfigType)
			{
			case TCloseUiGame.ICloseBrokenRock:
				_o.GameplayConfig.Value = ((this.GameplayConfig<ICloseBrokenRock>() != null) ? this.GameplayConfig<ICloseBrokenRock>().Value.UnPack() : null);
				return;
			case TCloseUiGame.ICloseDragActor:
				_o.GameplayConfig.Value = ((this.GameplayConfig<ICloseDragActor>() != null) ? this.GameplayConfig<ICloseDragActor>().Value.UnPack() : null);
				return;
			case TCloseUiGame.ICloseRideFlyingCar:
				_o.GameplayConfig.Value = ((this.GameplayConfig<ICloseRideFlyingCar>() != null) ? this.GameplayConfig<ICloseRideFlyingCar>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602C61F RID: 181791 RVA: 0x00616E5C File Offset: 0x0061505C
		public static Offset<ICloseSimpleGameplay> Pack(FlatBufferBuilder builder, ICloseSimpleGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseSimpleGameplay>);
			}
			TCloseUiGame gameplayConfig_type = (_o.GameplayConfig == null) ? TCloseUiGame.NONE : _o.GameplayConfig.Type;
			int gameplayConfigOffset = (_o.GameplayConfig == null) ? 0 : TCloseUiGameUnion.Pack(builder, _o.GameplayConfig);
			return ICloseSimpleGameplay.CreateICloseSimpleGameplay(builder, gameplayConfig_type, gameplayConfigOffset);
		}

		// Token: 0x04010A1F RID: 68127
		private Table __p;
	}
}
