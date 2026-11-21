using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BE1 RID: 31713
	public struct IToggleDragActorPlay : IFlatbufferObject
	{
		// Token: 0x1700ED91 RID: 60817
		// (get) Token: 0x06039292 RID: 234130 RVA: 0x007B93D8 File Offset: 0x007B75D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039293 RID: 234131 RVA: 0x007B93E5 File Offset: 0x007B75E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039294 RID: 234132 RVA: 0x007B93EC File Offset: 0x007B75EC
		public static IToggleDragActorPlay GetRootAsIToggleDragActorPlay(ByteBuffer _bb)
		{
			return IToggleDragActorPlay.GetRootAsIToggleDragActorPlay(_bb, default(IToggleDragActorPlay));
		}

		// Token: 0x06039295 RID: 234133 RVA: 0x007B9408 File Offset: 0x007B7608
		public static IToggleDragActorPlay GetRootAsIToggleDragActorPlay(ByteBuffer _bb, IToggleDragActorPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039296 RID: 234134 RVA: 0x007B9425 File Offset: 0x007B7625
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039297 RID: 234135 RVA: 0x007B9434 File Offset: 0x007B7634
		public IToggleDragActorPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED92 RID: 60818
		// (get) Token: 0x06039298 RID: 234136 RVA: 0x007B9444 File Offset: 0x007B7644
		public TToggleDragActorPlay ConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TToggleDragActorPlay.NONE;
				}
				return (TToggleDragActorPlay)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039299 RID: 234137 RVA: 0x007B9480 File Offset: 0x007B7680
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603929A RID: 234138 RVA: 0x007B94C4 File Offset: 0x007B76C4
		public IToggleDragActorPlayDisable ConfigAsIToggleDragActorPlayDisable()
		{
			return this.Config<IToggleDragActorPlayDisable>().Value;
		}

		// Token: 0x0603929B RID: 234139 RVA: 0x007B94E0 File Offset: 0x007B76E0
		public IToggleDragActorPlayEnable ConfigAsIToggleDragActorPlayEnable()
		{
			return this.Config<IToggleDragActorPlayEnable>().Value;
		}

		// Token: 0x0603929C RID: 234140 RVA: 0x007B94FB File Offset: 0x007B76FB
		public static Offset<IToggleDragActorPlay> CreateIToggleDragActorPlay(FlatBufferBuilder builder, TToggleDragActorPlay Config_type = TToggleDragActorPlay.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(2);
			IToggleDragActorPlay.AddConfig(builder, ConfigOffset);
			IToggleDragActorPlay.AddConfigType(builder, Config_type);
			return IToggleDragActorPlay.EndIToggleDragActorPlay(builder);
		}

		// Token: 0x0603929D RID: 234141 RVA: 0x007B9518 File Offset: 0x007B7718
		public static void StartIToggleDragActorPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603929E RID: 234142 RVA: 0x007B9521 File Offset: 0x007B7721
		public static void AddConfigType(FlatBufferBuilder builder, TToggleDragActorPlay configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x0603929F RID: 234143 RVA: 0x007B952C File Offset: 0x007B772C
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x060392A0 RID: 234144 RVA: 0x007B9537 File Offset: 0x007B7737
		public static Offset<IToggleDragActorPlay> EndIToggleDragActorPlay(FlatBufferBuilder builder)
		{
			return new Offset<IToggleDragActorPlay>(builder.EndTable());
		}

		// Token: 0x060392A1 RID: 234145 RVA: 0x007B9544 File Offset: 0x007B7744
		public IToggleDragActorPlayT UnPack()
		{
			IToggleDragActorPlayT toggleDragActorPlayT = new IToggleDragActorPlayT();
			this.UnPackTo(toggleDragActorPlayT);
			return toggleDragActorPlayT;
		}

		// Token: 0x060392A2 RID: 234146 RVA: 0x007B9560 File Offset: 0x007B7760
		public void UnPackTo(IToggleDragActorPlayT _o)
		{
			_o.Config = new TToggleDragActorPlayUnion();
			_o.Config.Type = this.ConfigType;
			TToggleDragActorPlay configType = this.ConfigType;
			if (configType == TToggleDragActorPlay.IToggleDragActorPlayDisable)
			{
				_o.Config.Value = ((this.Config<IToggleDragActorPlayDisable>() != null) ? this.Config<IToggleDragActorPlayDisable>().Value.UnPack() : null);
				return;
			}
			if (configType != TToggleDragActorPlay.IToggleDragActorPlayEnable)
			{
				return;
			}
			_o.Config.Value = ((this.Config<IToggleDragActorPlayEnable>() != null) ? this.Config<IToggleDragActorPlayEnable>().Value.UnPack() : null);
		}

		// Token: 0x060392A3 RID: 234147 RVA: 0x007B9604 File Offset: 0x007B7804
		public static Offset<IToggleDragActorPlay> Pack(FlatBufferBuilder builder, IToggleDragActorPlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleDragActorPlay>);
			}
			TToggleDragActorPlay config_type = (_o.Config == null) ? TToggleDragActorPlay.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TToggleDragActorPlayUnion.Pack(builder, _o.Config);
			return IToggleDragActorPlay.CreateIToggleDragActorPlay(builder, config_type, configOffset);
		}

		// Token: 0x04013275 RID: 78453
		private Table __p;
	}
}
