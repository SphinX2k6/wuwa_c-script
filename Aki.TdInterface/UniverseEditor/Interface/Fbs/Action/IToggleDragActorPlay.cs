using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073F7 RID: 29687
	public struct IToggleDragActorPlay : IFlatbufferObject
	{
		// Token: 0x1700E17C RID: 57724
		// (get) Token: 0x06035EDF RID: 220895 RVA: 0x00756C64 File Offset: 0x00754E64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035EE0 RID: 220896 RVA: 0x00756C71 File Offset: 0x00754E71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035EE1 RID: 220897 RVA: 0x00756C78 File Offset: 0x00754E78
		public static IToggleDragActorPlay GetRootAsIToggleDragActorPlay(ByteBuffer _bb)
		{
			return IToggleDragActorPlay.GetRootAsIToggleDragActorPlay(_bb, default(IToggleDragActorPlay));
		}

		// Token: 0x06035EE2 RID: 220898 RVA: 0x00756C94 File Offset: 0x00754E94
		public static IToggleDragActorPlay GetRootAsIToggleDragActorPlay(ByteBuffer _bb, IToggleDragActorPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035EE3 RID: 220899 RVA: 0x00756CB1 File Offset: 0x00754EB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035EE4 RID: 220900 RVA: 0x00756CC0 File Offset: 0x00754EC0
		public IToggleDragActorPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E17D RID: 57725
		// (get) Token: 0x06035EE5 RID: 220901 RVA: 0x00756CD0 File Offset: 0x00754ED0
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

		// Token: 0x06035EE6 RID: 220902 RVA: 0x00756D0C File Offset: 0x00754F0C
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035EE7 RID: 220903 RVA: 0x00756D50 File Offset: 0x00754F50
		public IToggleDragActorPlayDisable ConfigAsIToggleDragActorPlayDisable()
		{
			return this.Config<IToggleDragActorPlayDisable>().Value;
		}

		// Token: 0x06035EE8 RID: 220904 RVA: 0x00756D6C File Offset: 0x00754F6C
		public IToggleDragActorPlayEnable ConfigAsIToggleDragActorPlayEnable()
		{
			return this.Config<IToggleDragActorPlayEnable>().Value;
		}

		// Token: 0x06035EE9 RID: 220905 RVA: 0x00756D87 File Offset: 0x00754F87
		public static Offset<IToggleDragActorPlay> CreateIToggleDragActorPlay(FlatBufferBuilder builder, TToggleDragActorPlay Config_type = TToggleDragActorPlay.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(2);
			IToggleDragActorPlay.AddConfig(builder, ConfigOffset);
			IToggleDragActorPlay.AddConfigType(builder, Config_type);
			return IToggleDragActorPlay.EndIToggleDragActorPlay(builder);
		}

		// Token: 0x06035EEA RID: 220906 RVA: 0x00756DA4 File Offset: 0x00754FA4
		public static void StartIToggleDragActorPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035EEB RID: 220907 RVA: 0x00756DAD File Offset: 0x00754FAD
		public static void AddConfigType(FlatBufferBuilder builder, TToggleDragActorPlay configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x06035EEC RID: 220908 RVA: 0x00756DB8 File Offset: 0x00754FB8
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x06035EED RID: 220909 RVA: 0x00756DC3 File Offset: 0x00754FC3
		public static Offset<IToggleDragActorPlay> EndIToggleDragActorPlay(FlatBufferBuilder builder)
		{
			return new Offset<IToggleDragActorPlay>(builder.EndTable());
		}

		// Token: 0x06035EEE RID: 220910 RVA: 0x00756DD0 File Offset: 0x00754FD0
		public IToggleDragActorPlayT UnPack()
		{
			IToggleDragActorPlayT toggleDragActorPlayT = new IToggleDragActorPlayT();
			this.UnPackTo(toggleDragActorPlayT);
			return toggleDragActorPlayT;
		}

		// Token: 0x06035EEF RID: 220911 RVA: 0x00756DEC File Offset: 0x00754FEC
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

		// Token: 0x06035EF0 RID: 220912 RVA: 0x00756E90 File Offset: 0x00755090
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

		// Token: 0x04012259 RID: 74329
		private Table __p;
	}
}
