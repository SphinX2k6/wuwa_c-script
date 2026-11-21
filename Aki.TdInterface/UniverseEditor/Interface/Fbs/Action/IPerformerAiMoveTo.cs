using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073E8 RID: 29672
	public struct IPerformerAiMoveTo : IFlatbufferObject
	{
		// Token: 0x1700D9F6 RID: 55798
		// (get) Token: 0x06033E77 RID: 212599 RVA: 0x006FF97A File Offset: 0x006FDB7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033E78 RID: 212600 RVA: 0x006FF987 File Offset: 0x006FDB87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033E79 RID: 212601 RVA: 0x006FF990 File Offset: 0x006FDB90
		public static IPerformerAiMoveTo GetRootAsIPerformerAiMoveTo(ByteBuffer _bb)
		{
			return IPerformerAiMoveTo.GetRootAsIPerformerAiMoveTo(_bb, default(IPerformerAiMoveTo));
		}

		// Token: 0x06033E7A RID: 212602 RVA: 0x006FF9AC File Offset: 0x006FDBAC
		public static IPerformerAiMoveTo GetRootAsIPerformerAiMoveTo(ByteBuffer _bb, IPerformerAiMoveTo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033E7B RID: 212603 RVA: 0x006FF9C9 File Offset: 0x006FDBC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033E7C RID: 212604 RVA: 0x006FF9D8 File Offset: 0x006FDBD8
		public IPerformerAiMoveTo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9F7 RID: 55799
		// (get) Token: 0x06033E7D RID: 212605 RVA: 0x006FF9E8 File Offset: 0x006FDBE8
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

		// Token: 0x06033E7E RID: 212606 RVA: 0x006FFA24 File Offset: 0x006FDC24
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033E7F RID: 212607 RVA: 0x006FFA68 File Offset: 0x006FDC68
		public IPerformerAiMoveToEntity ConfigAsIPerformerAiMoveToEntity()
		{
			return this.Config<IPerformerAiMoveToEntity>().Value;
		}

		// Token: 0x06033E80 RID: 212608 RVA: 0x006FFA84 File Offset: 0x006FDC84
		public IPerformerAiMoveToPlayer ConfigAsIPerformerAiMoveToPlayer()
		{
			return this.Config<IPerformerAiMoveToPlayer>().Value;
		}

		// Token: 0x06033E81 RID: 212609 RVA: 0x006FFAA0 File Offset: 0x006FDCA0
		public IPerformerAiMoveToPosition ConfigAsIPerformerAiMoveToPosition()
		{
			return this.Config<IPerformerAiMoveToPosition>().Value;
		}

		// Token: 0x1700D9F8 RID: 55800
		// (get) Token: 0x06033E82 RID: 212610 RVA: 0x006FFABC File Offset: 0x006FDCBC
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

		// Token: 0x1700D9F9 RID: 55801
		// (get) Token: 0x06033E83 RID: 212611 RVA: 0x006FFAFC File Offset: 0x006FDCFC
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

		// Token: 0x06033E84 RID: 212612 RVA: 0x006FFB39 File Offset: 0x006FDD39
		public static Offset<IPerformerAiMoveTo> CreateIPerformerAiMoveTo(FlatBufferBuilder builder, TPerformerAiMoveToConfig Config_type = TPerformerAiMoveToConfig.NONE, int ConfigOffset = 0, float StopDistance = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IPerformerAiMoveTo.AddStopDistance(builder, StopDistance);
			IPerformerAiMoveTo.AddConfig(builder, ConfigOffset);
			IPerformerAiMoveTo.AddNullMask(builder, NullMask);
			IPerformerAiMoveTo.AddConfigType(builder, Config_type);
			return IPerformerAiMoveTo.EndIPerformerAiMoveTo(builder);
		}

		// Token: 0x06033E85 RID: 212613 RVA: 0x006FFB65 File Offset: 0x006FDD65
		public static void StartIPerformerAiMoveTo(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06033E86 RID: 212614 RVA: 0x006FFB6E File Offset: 0x006FDD6E
		public static void AddConfigType(FlatBufferBuilder builder, TPerformerAiMoveToConfig configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x06033E87 RID: 212615 RVA: 0x006FFB79 File Offset: 0x006FDD79
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x06033E88 RID: 212616 RVA: 0x006FFB84 File Offset: 0x006FDD84
		public static void AddStopDistance(FlatBufferBuilder builder, float stopDistance)
		{
			builder.AddFloat(2, stopDistance, 0.0);
		}

		// Token: 0x06033E89 RID: 212617 RVA: 0x006FFB97 File Offset: 0x006FDD97
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06033E8A RID: 212618 RVA: 0x006FFBA2 File Offset: 0x006FDDA2
		public static Offset<IPerformerAiMoveTo> EndIPerformerAiMoveTo(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiMoveTo>(builder.EndTable());
		}

		// Token: 0x06033E8B RID: 212619 RVA: 0x006FFBB0 File Offset: 0x006FDDB0
		public IPerformerAiMoveToT UnPack()
		{
			IPerformerAiMoveToT performerAiMoveToT = new IPerformerAiMoveToT();
			this.UnPackTo(performerAiMoveToT);
			return performerAiMoveToT;
		}

		// Token: 0x06033E8C RID: 212620 RVA: 0x006FFBCC File Offset: 0x006FDDCC
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

		// Token: 0x06033E8D RID: 212621 RVA: 0x006FFCD4 File Offset: 0x006FDED4
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

		// Token: 0x0401252D RID: 75053
		private Table __p;
	}
}
