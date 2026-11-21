using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007204 RID: 29188
	public struct IModifySceneUiSubtitle : IFlatbufferObject
	{
		// Token: 0x1700D59F RID: 54687
		// (get) Token: 0x06032C64 RID: 207972 RVA: 0x006DB960 File Offset: 0x006D9B60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032C65 RID: 207973 RVA: 0x006DB96D File Offset: 0x006D9B6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032C66 RID: 207974 RVA: 0x006DB974 File Offset: 0x006D9B74
		public static IModifySceneUiSubtitle GetRootAsIModifySceneUiSubtitle(ByteBuffer _bb)
		{
			return IModifySceneUiSubtitle.GetRootAsIModifySceneUiSubtitle(_bb, default(IModifySceneUiSubtitle));
		}

		// Token: 0x06032C67 RID: 207975 RVA: 0x006DB990 File Offset: 0x006D9B90
		public static IModifySceneUiSubtitle GetRootAsIModifySceneUiSubtitle(ByteBuffer _bb, IModifySceneUiSubtitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032C68 RID: 207976 RVA: 0x006DB9AD File Offset: 0x006D9BAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032C69 RID: 207977 RVA: 0x006DB9BC File Offset: 0x006D9BBC
		public IModifySceneUiSubtitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5A0 RID: 54688
		// (get) Token: 0x06032C6A RID: 207978 RVA: 0x006DB9CC File Offset: 0x006D9BCC
		public TSceneUiSubtitleOperation ConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TSceneUiSubtitleOperation.NONE;
				}
				return (TSceneUiSubtitleOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032C6B RID: 207979 RVA: 0x006DBA08 File Offset: 0x006D9C08
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032C6C RID: 207980 RVA: 0x006DBA4C File Offset: 0x006D9C4C
		public IRemoveSceneUiSubtitle ConfigAsIRemoveSceneUiSubtitle()
		{
			return this.Config<IRemoveSceneUiSubtitle>().Value;
		}

		// Token: 0x06032C6D RID: 207981 RVA: 0x006DBA68 File Offset: 0x006D9C68
		public ISpawnSceneUiSubtitle ConfigAsISpawnSceneUiSubtitle()
		{
			return this.Config<ISpawnSceneUiSubtitle>().Value;
		}

		// Token: 0x06032C6E RID: 207982 RVA: 0x006DBA83 File Offset: 0x006D9C83
		public static Offset<IModifySceneUiSubtitle> CreateIModifySceneUiSubtitle(FlatBufferBuilder builder, TSceneUiSubtitleOperation Config_type = TSceneUiSubtitleOperation.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(2);
			IModifySceneUiSubtitle.AddConfig(builder, ConfigOffset);
			IModifySceneUiSubtitle.AddConfigType(builder, Config_type);
			return IModifySceneUiSubtitle.EndIModifySceneUiSubtitle(builder);
		}

		// Token: 0x06032C6F RID: 207983 RVA: 0x006DBAA0 File Offset: 0x006D9CA0
		public static void StartIModifySceneUiSubtitle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032C70 RID: 207984 RVA: 0x006DBAA9 File Offset: 0x006D9CA9
		public static void AddConfigType(FlatBufferBuilder builder, TSceneUiSubtitleOperation configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x06032C71 RID: 207985 RVA: 0x006DBAB4 File Offset: 0x006D9CB4
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x06032C72 RID: 207986 RVA: 0x006DBABF File Offset: 0x006D9CBF
		public static Offset<IModifySceneUiSubtitle> EndIModifySceneUiSubtitle(FlatBufferBuilder builder)
		{
			return new Offset<IModifySceneUiSubtitle>(builder.EndTable());
		}

		// Token: 0x06032C73 RID: 207987 RVA: 0x006DBACC File Offset: 0x006D9CCC
		public IModifySceneUiSubtitleT UnPack()
		{
			IModifySceneUiSubtitleT modifySceneUiSubtitleT = new IModifySceneUiSubtitleT();
			this.UnPackTo(modifySceneUiSubtitleT);
			return modifySceneUiSubtitleT;
		}

		// Token: 0x06032C74 RID: 207988 RVA: 0x006DBAE8 File Offset: 0x006D9CE8
		public void UnPackTo(IModifySceneUiSubtitleT _o)
		{
			_o.Config = new TSceneUiSubtitleOperationUnion();
			_o.Config.Type = this.ConfigType;
			TSceneUiSubtitleOperation configType = this.ConfigType;
			if (configType == TSceneUiSubtitleOperation.IRemoveSceneUiSubtitle)
			{
				_o.Config.Value = ((this.Config<IRemoveSceneUiSubtitle>() != null) ? this.Config<IRemoveSceneUiSubtitle>().Value.UnPack() : null);
				return;
			}
			if (configType != TSceneUiSubtitleOperation.ISpawnSceneUiSubtitle)
			{
				return;
			}
			_o.Config.Value = ((this.Config<ISpawnSceneUiSubtitle>() != null) ? this.Config<ISpawnSceneUiSubtitle>().Value.UnPack() : null);
		}

		// Token: 0x06032C75 RID: 207989 RVA: 0x006DBB8C File Offset: 0x006D9D8C
		public static Offset<IModifySceneUiSubtitle> Pack(FlatBufferBuilder builder, IModifySceneUiSubtitleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifySceneUiSubtitle>);
			}
			TSceneUiSubtitleOperation config_type = (_o.Config == null) ? TSceneUiSubtitleOperation.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TSceneUiSubtitleOperationUnion.Pack(builder, _o.Config);
			return IModifySceneUiSubtitle.CreateIModifySceneUiSubtitle(builder, config_type, configOffset);
		}

		// Token: 0x0401222A RID: 74282
		private Table __p;
	}
}
