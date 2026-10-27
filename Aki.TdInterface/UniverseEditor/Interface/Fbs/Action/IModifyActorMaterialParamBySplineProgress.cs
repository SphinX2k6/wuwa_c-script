using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AA9 RID: 27305
	public struct IModifyActorMaterialParamBySplineProgress : IFlatbufferObject
	{
		// Token: 0x1700CAA2 RID: 51874
		// (get) Token: 0x0602FD96 RID: 195990 RVA: 0x0068273B File Offset: 0x0068093B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FD97 RID: 195991 RVA: 0x00682748 File Offset: 0x00680948
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FD98 RID: 195992 RVA: 0x00682750 File Offset: 0x00680950
		public static IModifyActorMaterialParamBySplineProgress GetRootAsIModifyActorMaterialParamBySplineProgress(ByteBuffer _bb)
		{
			return IModifyActorMaterialParamBySplineProgress.GetRootAsIModifyActorMaterialParamBySplineProgress(_bb, default(IModifyActorMaterialParamBySplineProgress));
		}

		// Token: 0x0602FD99 RID: 195993 RVA: 0x0068276C File Offset: 0x0068096C
		public static IModifyActorMaterialParamBySplineProgress GetRootAsIModifyActorMaterialParamBySplineProgress(ByteBuffer _bb, IModifyActorMaterialParamBySplineProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FD9A RID: 195994 RVA: 0x00682789 File Offset: 0x00680989
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FD9B RID: 195995 RVA: 0x00682798 File Offset: 0x00680998
		public IModifyActorMaterialParamBySplineProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAA3 RID: 51875
		// (get) Token: 0x0602FD9C RID: 195996 RVA: 0x006827A8 File Offset: 0x006809A8
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

		// Token: 0x0602FD9D RID: 195997 RVA: 0x006827E4 File Offset: 0x006809E4
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FD9E RID: 195998 RVA: 0x00682828 File Offset: 0x00680A28
		public IModifyActorMaterialParamBySplineProgressEnterSpline ConfigAsIModifyActorMaterialParamBySplineProgressEnterSpline()
		{
			return this.Config<IModifyActorMaterialParamBySplineProgressEnterSpline>().Value;
		}

		// Token: 0x0602FD9F RID: 195999 RVA: 0x00682844 File Offset: 0x00680A44
		public IModifyActorMaterialParamBySplineProgressExitSpline ConfigAsIModifyActorMaterialParamBySplineProgressExitSpline()
		{
			return this.Config<IModifyActorMaterialParamBySplineProgressExitSpline>().Value;
		}

		// Token: 0x0602FDA0 RID: 196000 RVA: 0x0068285F File Offset: 0x00680A5F
		public static Offset<IModifyActorMaterialParamBySplineProgress> CreateIModifyActorMaterialParamBySplineProgress(FlatBufferBuilder builder, TModifyActorMaterialParamBySplineProgress Config_type = TModifyActorMaterialParamBySplineProgress.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(2);
			IModifyActorMaterialParamBySplineProgress.AddConfig(builder, ConfigOffset);
			IModifyActorMaterialParamBySplineProgress.AddConfigType(builder, Config_type);
			return IModifyActorMaterialParamBySplineProgress.EndIModifyActorMaterialParamBySplineProgress(builder);
		}

		// Token: 0x0602FDA1 RID: 196001 RVA: 0x0068287C File Offset: 0x00680A7C
		public static void StartIModifyActorMaterialParamBySplineProgress(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FDA2 RID: 196002 RVA: 0x00682885 File Offset: 0x00680A85
		public static void AddConfigType(FlatBufferBuilder builder, TModifyActorMaterialParamBySplineProgress configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x0602FDA3 RID: 196003 RVA: 0x00682890 File Offset: 0x00680A90
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x0602FDA4 RID: 196004 RVA: 0x0068289B File Offset: 0x00680A9B
		public static Offset<IModifyActorMaterialParamBySplineProgress> EndIModifyActorMaterialParamBySplineProgress(FlatBufferBuilder builder)
		{
			return new Offset<IModifyActorMaterialParamBySplineProgress>(builder.EndTable());
		}

		// Token: 0x0602FDA5 RID: 196005 RVA: 0x006828A8 File Offset: 0x00680AA8
		public IModifyActorMaterialParamBySplineProgressT UnPack()
		{
			IModifyActorMaterialParamBySplineProgressT modifyActorMaterialParamBySplineProgressT = new IModifyActorMaterialParamBySplineProgressT();
			this.UnPackTo(modifyActorMaterialParamBySplineProgressT);
			return modifyActorMaterialParamBySplineProgressT;
		}

		// Token: 0x0602FDA6 RID: 196006 RVA: 0x006828C4 File Offset: 0x00680AC4
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

		// Token: 0x0602FDA7 RID: 196007 RVA: 0x00682968 File Offset: 0x00680B68
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

		// Token: 0x040112E5 RID: 70373
		private Table __p;
	}
}
