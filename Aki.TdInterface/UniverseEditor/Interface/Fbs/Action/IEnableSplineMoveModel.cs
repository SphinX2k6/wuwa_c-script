using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D01 RID: 27905
	public struct IEnableSplineMoveModel : IFlatbufferObject
	{
		// Token: 0x1700CCC3 RID: 52419
		// (get) Token: 0x060301FA RID: 197114 RVA: 0x0068BA89 File Offset: 0x00689C89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060301FB RID: 197115 RVA: 0x0068BA96 File Offset: 0x00689C96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060301FC RID: 197116 RVA: 0x0068BAA0 File Offset: 0x00689CA0
		public static IEnableSplineMoveModel GetRootAsIEnableSplineMoveModel(ByteBuffer _bb)
		{
			return IEnableSplineMoveModel.GetRootAsIEnableSplineMoveModel(_bb, default(IEnableSplineMoveModel));
		}

		// Token: 0x060301FD RID: 197117 RVA: 0x0068BABC File Offset: 0x00689CBC
		public static IEnableSplineMoveModel GetRootAsIEnableSplineMoveModel(ByteBuffer _bb, IEnableSplineMoveModel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060301FE RID: 197118 RVA: 0x0068BAD9 File Offset: 0x00689CD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060301FF RID: 197119 RVA: 0x0068BAE8 File Offset: 0x00689CE8
		public IEnableSplineMoveModel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCC4 RID: 52420
		// (get) Token: 0x06030200 RID: 197120 RVA: 0x0068BAF8 File Offset: 0x00689CF8
		public TSplineMoveModel ConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TSplineMoveModel.NONE;
				}
				return (TSplineMoveModel)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030201 RID: 197121 RVA: 0x0068BB34 File Offset: 0x00689D34
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030202 RID: 197122 RVA: 0x0068BB78 File Offset: 0x00689D78
		public ICloseSplineMove ConfigAsICloseSplineMove()
		{
			return this.Config<ICloseSplineMove>().Value;
		}

		// Token: 0x06030203 RID: 197123 RVA: 0x0068BB94 File Offset: 0x00689D94
		public IOpenSplineMove ConfigAsIOpenSplineMove()
		{
			return this.Config<IOpenSplineMove>().Value;
		}

		// Token: 0x06030204 RID: 197124 RVA: 0x0068BBAF File Offset: 0x00689DAF
		public static Offset<IEnableSplineMoveModel> CreateIEnableSplineMoveModel(FlatBufferBuilder builder, TSplineMoveModel Config_type = TSplineMoveModel.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(2);
			IEnableSplineMoveModel.AddConfig(builder, ConfigOffset);
			IEnableSplineMoveModel.AddConfigType(builder, Config_type);
			return IEnableSplineMoveModel.EndIEnableSplineMoveModel(builder);
		}

		// Token: 0x06030205 RID: 197125 RVA: 0x0068BBCC File Offset: 0x00689DCC
		public static void StartIEnableSplineMoveModel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030206 RID: 197126 RVA: 0x0068BBD5 File Offset: 0x00689DD5
		public static void AddConfigType(FlatBufferBuilder builder, TSplineMoveModel configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x06030207 RID: 197127 RVA: 0x0068BBE0 File Offset: 0x00689DE0
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x06030208 RID: 197128 RVA: 0x0068BBEB File Offset: 0x00689DEB
		public static Offset<IEnableSplineMoveModel> EndIEnableSplineMoveModel(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSplineMoveModel>(builder.EndTable());
		}

		// Token: 0x06030209 RID: 197129 RVA: 0x0068BBF8 File Offset: 0x00689DF8
		public IEnableSplineMoveModelT UnPack()
		{
			IEnableSplineMoveModelT enableSplineMoveModelT = new IEnableSplineMoveModelT();
			this.UnPackTo(enableSplineMoveModelT);
			return enableSplineMoveModelT;
		}

		// Token: 0x0603020A RID: 197130 RVA: 0x0068BC14 File Offset: 0x00689E14
		public void UnPackTo(IEnableSplineMoveModelT _o)
		{
			_o.Config = new TSplineMoveModelUnion();
			_o.Config.Type = this.ConfigType;
			TSplineMoveModel configType = this.ConfigType;
			if (configType == TSplineMoveModel.ICloseSplineMove)
			{
				_o.Config.Value = ((this.Config<ICloseSplineMove>() != null) ? this.Config<ICloseSplineMove>().Value.UnPack() : null);
				return;
			}
			if (configType != TSplineMoveModel.IOpenSplineMove)
			{
				return;
			}
			_o.Config.Value = ((this.Config<IOpenSplineMove>() != null) ? this.Config<IOpenSplineMove>().Value.UnPack() : null);
		}

		// Token: 0x0603020B RID: 197131 RVA: 0x0068BCB8 File Offset: 0x00689EB8
		public static Offset<IEnableSplineMoveModel> Pack(FlatBufferBuilder builder, IEnableSplineMoveModelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableSplineMoveModel>);
			}
			TSplineMoveModel config_type = (_o.Config == null) ? TSplineMoveModel.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TSplineMoveModelUnion.Pack(builder, _o.Config);
			return IEnableSplineMoveModel.CreateIEnableSplineMoveModel(builder, config_type, configOffset);
		}

		// Token: 0x04011B63 RID: 72547
		private Table __p;
	}
}
