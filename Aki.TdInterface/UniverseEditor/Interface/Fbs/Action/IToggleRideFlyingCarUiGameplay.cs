using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BFF RID: 31743
	public struct IToggleRideFlyingCarUiGameplay : IFlatbufferObject
	{
		// Token: 0x1700EDC0 RID: 60864
		// (get) Token: 0x06039370 RID: 234352 RVA: 0x007BAABA File Offset: 0x007B8CBA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039371 RID: 234353 RVA: 0x007BAAC7 File Offset: 0x007B8CC7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039372 RID: 234354 RVA: 0x007BAAD0 File Offset: 0x007B8CD0
		public static IToggleRideFlyingCarUiGameplay GetRootAsIToggleRideFlyingCarUiGameplay(ByteBuffer _bb)
		{
			return IToggleRideFlyingCarUiGameplay.GetRootAsIToggleRideFlyingCarUiGameplay(_bb, default(IToggleRideFlyingCarUiGameplay));
		}

		// Token: 0x06039373 RID: 234355 RVA: 0x007BAAEC File Offset: 0x007B8CEC
		public static IToggleRideFlyingCarUiGameplay GetRootAsIToggleRideFlyingCarUiGameplay(ByteBuffer _bb, IToggleRideFlyingCarUiGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039374 RID: 234356 RVA: 0x007BAB09 File Offset: 0x007B8D09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039375 RID: 234357 RVA: 0x007BAB18 File Offset: 0x007B8D18
		public IToggleRideFlyingCarUiGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EDC1 RID: 60865
		// (get) Token: 0x06039376 RID: 234358 RVA: 0x007BAB28 File Offset: 0x007B8D28
		public TToggleRideFlyingCarUiGameplay ConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TToggleRideFlyingCarUiGameplay.NONE;
				}
				return (TToggleRideFlyingCarUiGameplay)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039377 RID: 234359 RVA: 0x007BAB64 File Offset: 0x007B8D64
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039378 RID: 234360 RVA: 0x007BABA8 File Offset: 0x007B8DA8
		public IDisableRideFlyingCarUiGameplay ConfigAsIDisableRideFlyingCarUiGameplay()
		{
			return this.Config<IDisableRideFlyingCarUiGameplay>().Value;
		}

		// Token: 0x06039379 RID: 234361 RVA: 0x007BABC4 File Offset: 0x007B8DC4
		public IEnableRideFlyingCarUiGameplay ConfigAsIEnableRideFlyingCarUiGameplay()
		{
			return this.Config<IEnableRideFlyingCarUiGameplay>().Value;
		}

		// Token: 0x0603937A RID: 234362 RVA: 0x007BABDF File Offset: 0x007B8DDF
		public static Offset<IToggleRideFlyingCarUiGameplay> CreateIToggleRideFlyingCarUiGameplay(FlatBufferBuilder builder, TToggleRideFlyingCarUiGameplay Config_type = TToggleRideFlyingCarUiGameplay.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(2);
			IToggleRideFlyingCarUiGameplay.AddConfig(builder, ConfigOffset);
			IToggleRideFlyingCarUiGameplay.AddConfigType(builder, Config_type);
			return IToggleRideFlyingCarUiGameplay.EndIToggleRideFlyingCarUiGameplay(builder);
		}

		// Token: 0x0603937B RID: 234363 RVA: 0x007BABFC File Offset: 0x007B8DFC
		public static void StartIToggleRideFlyingCarUiGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603937C RID: 234364 RVA: 0x007BAC05 File Offset: 0x007B8E05
		public static void AddConfigType(FlatBufferBuilder builder, TToggleRideFlyingCarUiGameplay configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x0603937D RID: 234365 RVA: 0x007BAC10 File Offset: 0x007B8E10
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x0603937E RID: 234366 RVA: 0x007BAC1B File Offset: 0x007B8E1B
		public static Offset<IToggleRideFlyingCarUiGameplay> EndIToggleRideFlyingCarUiGameplay(FlatBufferBuilder builder)
		{
			return new Offset<IToggleRideFlyingCarUiGameplay>(builder.EndTable());
		}

		// Token: 0x0603937F RID: 234367 RVA: 0x007BAC28 File Offset: 0x007B8E28
		public IToggleRideFlyingCarUiGameplayT UnPack()
		{
			IToggleRideFlyingCarUiGameplayT toggleRideFlyingCarUiGameplayT = new IToggleRideFlyingCarUiGameplayT();
			this.UnPackTo(toggleRideFlyingCarUiGameplayT);
			return toggleRideFlyingCarUiGameplayT;
		}

		// Token: 0x06039380 RID: 234368 RVA: 0x007BAC44 File Offset: 0x007B8E44
		public void UnPackTo(IToggleRideFlyingCarUiGameplayT _o)
		{
			_o.Config = new TToggleRideFlyingCarUiGameplayUnion();
			_o.Config.Type = this.ConfigType;
			TToggleRideFlyingCarUiGameplay configType = this.ConfigType;
			if (configType == TToggleRideFlyingCarUiGameplay.IDisableRideFlyingCarUiGameplay)
			{
				_o.Config.Value = ((this.Config<IDisableRideFlyingCarUiGameplay>() != null) ? this.Config<IDisableRideFlyingCarUiGameplay>().Value.UnPack() : null);
				return;
			}
			if (configType != TToggleRideFlyingCarUiGameplay.IEnableRideFlyingCarUiGameplay)
			{
				return;
			}
			_o.Config.Value = ((this.Config<IEnableRideFlyingCarUiGameplay>() != null) ? this.Config<IEnableRideFlyingCarUiGameplay>().Value.UnPack() : null);
		}

		// Token: 0x06039381 RID: 234369 RVA: 0x007BACE8 File Offset: 0x007B8EE8
		public static Offset<IToggleRideFlyingCarUiGameplay> Pack(FlatBufferBuilder builder, IToggleRideFlyingCarUiGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleRideFlyingCarUiGameplay>);
			}
			TToggleRideFlyingCarUiGameplay config_type = (_o.Config == null) ? TToggleRideFlyingCarUiGameplay.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TToggleRideFlyingCarUiGameplayUnion.Pack(builder, _o.Config);
			return IToggleRideFlyingCarUiGameplay.CreateIToggleRideFlyingCarUiGameplay(builder, config_type, configOffset);
		}

		// Token: 0x040132A4 RID: 78500
		private Table __p;
	}
}
