using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071D4 RID: 29140
	public struct IModifyActorMaterialParamBySplineProgress : IFlatbufferObject
	{
		// Token: 0x1700D55A RID: 54618
		// (get) Token: 0x06032AFA RID: 207610 RVA: 0x006D8D71 File Offset: 0x006D6F71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032AFB RID: 207611 RVA: 0x006D8D7E File Offset: 0x006D6F7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032AFC RID: 207612 RVA: 0x006D8D88 File Offset: 0x006D6F88
		public static IModifyActorMaterialParamBySplineProgress GetRootAsIModifyActorMaterialParamBySplineProgress(ByteBuffer _bb)
		{
			return IModifyActorMaterialParamBySplineProgress.GetRootAsIModifyActorMaterialParamBySplineProgress(_bb, default(IModifyActorMaterialParamBySplineProgress));
		}

		// Token: 0x06032AFD RID: 207613 RVA: 0x006D8DA4 File Offset: 0x006D6FA4
		public static IModifyActorMaterialParamBySplineProgress GetRootAsIModifyActorMaterialParamBySplineProgress(ByteBuffer _bb, IModifyActorMaterialParamBySplineProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032AFE RID: 207614 RVA: 0x006D8DC1 File Offset: 0x006D6FC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032AFF RID: 207615 RVA: 0x006D8DD0 File Offset: 0x006D6FD0
		public IModifyActorMaterialParamBySplineProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D55B RID: 54619
		// (get) Token: 0x06032B00 RID: 207616 RVA: 0x006D8DE0 File Offset: 0x006D6FE0
		public TModifyActorMaterialParamBySplineProgress ConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TModifyActorMaterialParamBySplineProgress.NONE;
				}
				return (TModifyActorMaterialParamBySplineProgress)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032B01 RID: 207617 RVA: 0x006D8E1C File Offset: 0x006D701C
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032B02 RID: 207618 RVA: 0x006D8E60 File Offset: 0x006D7060
		public IModifyActorMaterialParamBySplineProgressEnterSpline ConfigAsIModifyActorMaterialParamBySplineProgressEnterSpline()
		{
			return this.Config<IModifyActorMaterialParamBySplineProgressEnterSpline>().Value;
		}

		// Token: 0x06032B03 RID: 207619 RVA: 0x006D8E7C File Offset: 0x006D707C
		public IModifyActorMaterialParamBySplineProgressExitSpline ConfigAsIModifyActorMaterialParamBySplineProgressExitSpline()
		{
			return this.Config<IModifyActorMaterialParamBySplineProgressExitSpline>().Value;
		}

		// Token: 0x06032B04 RID: 207620 RVA: 0x006D8E97 File Offset: 0x006D7097
		public static Offset<IModifyActorMaterialParamBySplineProgress> CreateIModifyActorMaterialParamBySplineProgress(FlatBufferBuilder builder, TModifyActorMaterialParamBySplineProgress Config_type = TModifyActorMaterialParamBySplineProgress.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(2);
			IModifyActorMaterialParamBySplineProgress.AddConfig(builder, ConfigOffset);
			IModifyActorMaterialParamBySplineProgress.AddConfigType(builder, Config_type);
			return IModifyActorMaterialParamBySplineProgress.EndIModifyActorMaterialParamBySplineProgress(builder);
		}

		// Token: 0x06032B05 RID: 207621 RVA: 0x006D8EB4 File Offset: 0x006D70B4
		public static void StartIModifyActorMaterialParamBySplineProgress(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032B06 RID: 207622 RVA: 0x006D8EBD File Offset: 0x006D70BD
		public static void AddConfigType(FlatBufferBuilder builder, TModifyActorMaterialParamBySplineProgress configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x06032B07 RID: 207623 RVA: 0x006D8EC8 File Offset: 0x006D70C8
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x06032B08 RID: 207624 RVA: 0x006D8ED3 File Offset: 0x006D70D3
		public static Offset<IModifyActorMaterialParamBySplineProgress> EndIModifyActorMaterialParamBySplineProgress(FlatBufferBuilder builder)
		{
			return new Offset<IModifyActorMaterialParamBySplineProgress>(builder.EndTable());
		}

		// Token: 0x06032B09 RID: 207625 RVA: 0x006D8EE0 File Offset: 0x006D70E0
		public IModifyActorMaterialParamBySplineProgressT UnPack()
		{
			IModifyActorMaterialParamBySplineProgressT modifyActorMaterialParamBySplineProgressT = new IModifyActorMaterialParamBySplineProgressT();
			this.UnPackTo(modifyActorMaterialParamBySplineProgressT);
			return modifyActorMaterialParamBySplineProgressT;
		}

		// Token: 0x06032B0A RID: 207626 RVA: 0x006D8EFC File Offset: 0x006D70FC
		public void UnPackTo(IModifyActorMaterialParamBySplineProgressT _o)
		{
			_o.Config = new TModifyActorMaterialParamBySplineProgressUnion();
			_o.Config.Type = this.ConfigType;
			TModifyActorMaterialParamBySplineProgress configType = this.ConfigType;
			if (configType == TModifyActorMaterialParamBySplineProgress.IModifyActorMaterialParamBySplineProgressEnterSpline)
			{
				_o.Config.Value = ((this.Config<IModifyActorMaterialParamBySplineProgressEnterSpline>() != null) ? this.Config<IModifyActorMaterialParamBySplineProgressEnterSpline>().Value.UnPack() : null);
				return;
			}
			if (configType != TModifyActorMaterialParamBySplineProgress.IModifyActorMaterialParamBySplineProgressExitSpline)
			{
				return;
			}
			_o.Config.Value = ((this.Config<IModifyActorMaterialParamBySplineProgressExitSpline>() != null) ? this.Config<IModifyActorMaterialParamBySplineProgressExitSpline>().Value.UnPack() : null);
		}

		// Token: 0x06032B0B RID: 207627 RVA: 0x006D8FA0 File Offset: 0x006D71A0
		public static Offset<IModifyActorMaterialParamBySplineProgress> Pack(FlatBufferBuilder builder, IModifyActorMaterialParamBySplineProgressT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyActorMaterialParamBySplineProgress>);
			}
			TModifyActorMaterialParamBySplineProgress config_type = (_o.Config == null) ? TModifyActorMaterialParamBySplineProgress.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TModifyActorMaterialParamBySplineProgressUnion.Pack(builder, _o.Config);
			return IModifyActorMaterialParamBySplineProgress.CreateIModifyActorMaterialParamBySplineProgress(builder, config_type, configOffset);
		}

		// Token: 0x040121E5 RID: 74213
		private Table __p;
	}
}
