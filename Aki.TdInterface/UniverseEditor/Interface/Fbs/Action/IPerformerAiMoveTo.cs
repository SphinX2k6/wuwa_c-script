using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C81 RID: 27777
	public struct IPerformerAiMoveTo : IFlatbufferObject
	{
		// Token: 0x1700CEDB RID: 52955
		// (get) Token: 0x06030F1C RID: 200476 RVA: 0x006A547A File Offset: 0x006A367A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030F1D RID: 200477 RVA: 0x006A5487 File Offset: 0x006A3687
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030F1E RID: 200478 RVA: 0x006A5490 File Offset: 0x006A3690
		public static IPerformerAiMoveTo GetRootAsIPerformerAiMoveTo(ByteBuffer _bb)
		{
			return IPerformerAiMoveTo.GetRootAsIPerformerAiMoveTo(_bb, default(IPerformerAiMoveTo));
		}

		// Token: 0x06030F1F RID: 200479 RVA: 0x006A54AC File Offset: 0x006A36AC
		public static IPerformerAiMoveTo GetRootAsIPerformerAiMoveTo(ByteBuffer _bb, IPerformerAiMoveTo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030F20 RID: 200480 RVA: 0x006A54C9 File Offset: 0x006A36C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030F21 RID: 200481 RVA: 0x006A54D8 File Offset: 0x006A36D8
		public IPerformerAiMoveTo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEDC RID: 52956
		// (get) Token: 0x06030F22 RID: 200482 RVA: 0x006A54E8 File Offset: 0x006A36E8
		public TPerformerAiMoveToConfig ConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TPerformerAiMoveToConfig.NONE;
				}
				return (TPerformerAiMoveToConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030F23 RID: 200483 RVA: 0x006A5524 File Offset: 0x006A3724
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030F24 RID: 200484 RVA: 0x006A5568 File Offset: 0x006A3768
		public IPerformerAiMoveToEntity ConfigAsIPerformerAiMoveToEntity()
		{
			return this.Config<IPerformerAiMoveToEntity>().Value;
		}

		// Token: 0x06030F25 RID: 200485 RVA: 0x006A5584 File Offset: 0x006A3784
		public IPerformerAiMoveToPlayer ConfigAsIPerformerAiMoveToPlayer()
		{
			return this.Config<IPerformerAiMoveToPlayer>().Value;
		}

		// Token: 0x06030F26 RID: 200486 RVA: 0x006A55A0 File Offset: 0x006A37A0
		public IPerformerAiMoveToPosition ConfigAsIPerformerAiMoveToPosition()
		{
			return this.Config<IPerformerAiMoveToPosition>().Value;
		}

		// Token: 0x1700CEDD RID: 52957
		// (get) Token: 0x06030F27 RID: 200487 RVA: 0x006A55BC File Offset: 0x006A37BC
		public float StopDistance
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CEDE RID: 52958
		// (get) Token: 0x06030F28 RID: 200488 RVA: 0x006A55FC File Offset: 0x006A37FC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030F29 RID: 200489 RVA: 0x006A5639 File Offset: 0x006A3839
		public static Offset<IPerformerAiMoveTo> CreateIPerformerAiMoveTo(FlatBufferBuilder builder, TPerformerAiMoveToConfig Config_type = TPerformerAiMoveToConfig.NONE, int ConfigOffset = 0, float StopDistance = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IPerformerAiMoveTo.AddStopDistance(builder, StopDistance);
			IPerformerAiMoveTo.AddConfig(builder, ConfigOffset);
			IPerformerAiMoveTo.AddNullMask(builder, NullMask);
			IPerformerAiMoveTo.AddConfigType(builder, Config_type);
			return IPerformerAiMoveTo.EndIPerformerAiMoveTo(builder);
		}

		// Token: 0x06030F2A RID: 200490 RVA: 0x006A5665 File Offset: 0x006A3865
		public static void StartIPerformerAiMoveTo(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06030F2B RID: 200491 RVA: 0x006A566E File Offset: 0x006A386E
		public static void AddConfigType(FlatBufferBuilder builder, TPerformerAiMoveToConfig configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x06030F2C RID: 200492 RVA: 0x006A5679 File Offset: 0x006A3879
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x06030F2D RID: 200493 RVA: 0x006A5684 File Offset: 0x006A3884
		public static void AddStopDistance(FlatBufferBuilder builder, float stopDistance)
		{
			builder.AddFloat(2, stopDistance, 0.0);
		}

		// Token: 0x06030F2E RID: 200494 RVA: 0x006A5697 File Offset: 0x006A3897
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06030F2F RID: 200495 RVA: 0x006A56A2 File Offset: 0x006A38A2
		public static Offset<IPerformerAiMoveTo> EndIPerformerAiMoveTo(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiMoveTo>(builder.EndTable());
		}

		// Token: 0x06030F30 RID: 200496 RVA: 0x006A56B0 File Offset: 0x006A38B0
		public IPerformerAiMoveToT UnPack()
		{
			IPerformerAiMoveToT performerAiMoveToT = new IPerformerAiMoveToT();
			this.UnPackTo(performerAiMoveToT);
			return performerAiMoveToT;
		}

		// Token: 0x06030F31 RID: 200497 RVA: 0x006A56CC File Offset: 0x006A38CC
		public void UnPackTo(IPerformerAiMoveToT _o)
		{
			_o.Config = new TPerformerAiMoveToConfigUnion();
			_o.Config.Type = this.ConfigType;
			switch (this.ConfigType)
			{
			case TPerformerAiMoveToConfig.IPerformerAiMoveToEntity:
				_o.Config.Value = ((this.Config<IPerformerAiMoveToEntity>() != null) ? this.Config<IPerformerAiMoveToEntity>().Value.UnPack() : null);
				break;
			case TPerformerAiMoveToConfig.IPerformerAiMoveToPlayer:
				_o.Config.Value = ((this.Config<IPerformerAiMoveToPlayer>() != null) ? this.Config<IPerformerAiMoveToPlayer>().Value.UnPack() : null);
				break;
			case TPerformerAiMoveToConfig.IPerformerAiMoveToPosition:
				_o.Config.Value = ((this.Config<IPerformerAiMoveToPosition>() != null) ? this.Config<IPerformerAiMoveToPosition>().Value.UnPack() : null);
				break;
			}
			_o.StopDistance = this.StopDistance;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030F32 RID: 200498 RVA: 0x006A57D4 File Offset: 0x006A39D4
		public static Offset<IPerformerAiMoveTo> Pack(FlatBufferBuilder builder, IPerformerAiMoveToT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiMoveTo>);
			}
			TPerformerAiMoveToConfig config_type = (_o.Config == null) ? TPerformerAiMoveToConfig.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TPerformerAiMoveToConfigUnion.Pack(builder, _o.Config);
			return IPerformerAiMoveTo.CreateIPerformerAiMoveTo(builder, config_type, configOffset, _o.StopDistance, _o.NullMask);
		}

		// Token: 0x040115D5 RID: 71125
		private Table __p;
	}
}
