using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077BE RID: 30654
	public struct ISetGlobalTimeScale : IFlatbufferObject
	{
		// Token: 0x1700E0BE RID: 57534
		// (get) Token: 0x06035D8A RID: 220554 RVA: 0x00736FAE File Offset: 0x007351AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035D8B RID: 220555 RVA: 0x00736FBB File Offset: 0x007351BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035D8C RID: 220556 RVA: 0x00736FC4 File Offset: 0x007351C4
		public static ISetGlobalTimeScale GetRootAsISetGlobalTimeScale(ByteBuffer _bb)
		{
			return ISetGlobalTimeScale.GetRootAsISetGlobalTimeScale(_bb, default(ISetGlobalTimeScale));
		}

		// Token: 0x06035D8D RID: 220557 RVA: 0x00736FE0 File Offset: 0x007351E0
		public static ISetGlobalTimeScale GetRootAsISetGlobalTimeScale(ByteBuffer _bb, ISetGlobalTimeScale obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035D8E RID: 220558 RVA: 0x00736FFD File Offset: 0x007351FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035D8F RID: 220559 RVA: 0x0073700C File Offset: 0x0073520C
		public ISetGlobalTimeScale __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0BF RID: 57535
		// (get) Token: 0x06035D90 RID: 220560 RVA: 0x0073701C File Offset: 0x0073521C
		public ETimeScaleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeScaleType.Global;
				}
				return (ETimeScaleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E0C0 RID: 57536
		// (get) Token: 0x06035D91 RID: 220561 RVA: 0x00737058 File Offset: 0x00735258
		public TSetGlobalTimeScale ConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TSetGlobalTimeScale.NONE;
				}
				return (TSetGlobalTimeScale)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035D92 RID: 220562 RVA: 0x00737094 File Offset: 0x00735294
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035D93 RID: 220563 RVA: 0x007370D8 File Offset: 0x007352D8
		public ICloseGlobalTimeScale ConfigAsICloseGlobalTimeScale()
		{
			return this.Config<ICloseGlobalTimeScale>().Value;
		}

		// Token: 0x06035D94 RID: 220564 RVA: 0x007370F4 File Offset: 0x007352F4
		public IOpenGlobalTimeScale ConfigAsIOpenGlobalTimeScale()
		{
			return this.Config<IOpenGlobalTimeScale>().Value;
		}

		// Token: 0x06035D95 RID: 220565 RVA: 0x0073710F File Offset: 0x0073530F
		public static Offset<ISetGlobalTimeScale> CreateISetGlobalTimeScale(FlatBufferBuilder builder, ETimeScaleType Type = ETimeScaleType.Global, TSetGlobalTimeScale Config_type = TSetGlobalTimeScale.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(3);
			ISetGlobalTimeScale.AddConfig(builder, ConfigOffset);
			ISetGlobalTimeScale.AddConfigType(builder, Config_type);
			ISetGlobalTimeScale.AddType(builder, Type);
			return ISetGlobalTimeScale.EndISetGlobalTimeScale(builder);
		}

		// Token: 0x06035D96 RID: 220566 RVA: 0x00737133 File Offset: 0x00735333
		public static void StartISetGlobalTimeScale(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06035D97 RID: 220567 RVA: 0x0073713C File Offset: 0x0073533C
		public static void AddType(FlatBufferBuilder builder, ETimeScaleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035D98 RID: 220568 RVA: 0x00737147 File Offset: 0x00735347
		public static void AddConfigType(FlatBufferBuilder builder, TSetGlobalTimeScale configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x06035D99 RID: 220569 RVA: 0x00737152 File Offset: 0x00735352
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x06035D9A RID: 220570 RVA: 0x0073715D File Offset: 0x0073535D
		public static Offset<ISetGlobalTimeScale> EndISetGlobalTimeScale(FlatBufferBuilder builder)
		{
			return new Offset<ISetGlobalTimeScale>(builder.EndTable());
		}

		// Token: 0x06035D9B RID: 220571 RVA: 0x0073716C File Offset: 0x0073536C
		public ISetGlobalTimeScaleT UnPack()
		{
			ISetGlobalTimeScaleT setGlobalTimeScaleT = new ISetGlobalTimeScaleT();
			this.UnPackTo(setGlobalTimeScaleT);
			return setGlobalTimeScaleT;
		}

		// Token: 0x06035D9C RID: 220572 RVA: 0x00737188 File Offset: 0x00735388
		public void UnPackTo(ISetGlobalTimeScaleT _o)
		{
			_o.Type = this.Type;
			_o.Config = new TSetGlobalTimeScaleUnion();
			_o.Config.Type = this.ConfigType;
			TSetGlobalTimeScale configType = this.ConfigType;
			if (configType == TSetGlobalTimeScale.ICloseGlobalTimeScale)
			{
				_o.Config.Value = ((this.Config<ICloseGlobalTimeScale>() != null) ? this.Config<ICloseGlobalTimeScale>().Value.UnPack() : null);
				return;
			}
			if (configType != TSetGlobalTimeScale.IOpenGlobalTimeScale)
			{
				return;
			}
			_o.Config.Value = ((this.Config<IOpenGlobalTimeScale>() != null) ? this.Config<IOpenGlobalTimeScale>().Value.UnPack() : null);
		}

		// Token: 0x06035D9D RID: 220573 RVA: 0x00737238 File Offset: 0x00735438
		public static Offset<ISetGlobalTimeScale> Pack(FlatBufferBuilder builder, ISetGlobalTimeScaleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetGlobalTimeScale>);
			}
			TSetGlobalTimeScale config_type = (_o.Config == null) ? TSetGlobalTimeScale.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TSetGlobalTimeScaleUnion.Pack(builder, _o.Config);
			return ISetGlobalTimeScale.CreateISetGlobalTimeScale(builder, _o.Type, config_type, configOffset);
		}

		// Token: 0x040129FB RID: 76283
		private Table __p;
	}
}
