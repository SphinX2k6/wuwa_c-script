using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006687 RID: 26247
	public struct IEnableSplineMoveModel : IFlatbufferObject
	{
		// Token: 0x1700C312 RID: 49938
		// (get) Token: 0x0602D9DD RID: 186845 RVA: 0x0063E7D5 File Offset: 0x0063C9D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D9DE RID: 186846 RVA: 0x0063E7E2 File Offset: 0x0063C9E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D9DF RID: 186847 RVA: 0x0063E7EC File Offset: 0x0063C9EC
		public static IEnableSplineMoveModel GetRootAsIEnableSplineMoveModel(ByteBuffer _bb)
		{
			return IEnableSplineMoveModel.GetRootAsIEnableSplineMoveModel(_bb, default(IEnableSplineMoveModel));
		}

		// Token: 0x0602D9E0 RID: 186848 RVA: 0x0063E808 File Offset: 0x0063CA08
		public static IEnableSplineMoveModel GetRootAsIEnableSplineMoveModel(ByteBuffer _bb, IEnableSplineMoveModel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D9E1 RID: 186849 RVA: 0x0063E825 File Offset: 0x0063CA25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D9E2 RID: 186850 RVA: 0x0063E834 File Offset: 0x0063CA34
		public IEnableSplineMoveModel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C313 RID: 49939
		// (get) Token: 0x0602D9E3 RID: 186851 RVA: 0x0063E844 File Offset: 0x0063CA44
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

		// Token: 0x0602D9E4 RID: 186852 RVA: 0x0063E880 File Offset: 0x0063CA80
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D9E5 RID: 186853 RVA: 0x0063E8C4 File Offset: 0x0063CAC4
		public ICloseSplineMove ConfigAsICloseSplineMove()
		{
			return this.Config<ICloseSplineMove>().Value;
		}

		// Token: 0x0602D9E6 RID: 186854 RVA: 0x0063E8E0 File Offset: 0x0063CAE0
		public IOpenSplineMove ConfigAsIOpenSplineMove()
		{
			return this.Config<IOpenSplineMove>().Value;
		}

		// Token: 0x0602D9E7 RID: 186855 RVA: 0x0063E8FB File Offset: 0x0063CAFB
		public static Offset<IEnableSplineMoveModel> CreateIEnableSplineMoveModel(FlatBufferBuilder builder, TSplineMoveModel Config_type = TSplineMoveModel.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(2);
			IEnableSplineMoveModel.AddConfig(builder, ConfigOffset);
			IEnableSplineMoveModel.AddConfigType(builder, Config_type);
			return IEnableSplineMoveModel.EndIEnableSplineMoveModel(builder);
		}

		// Token: 0x0602D9E8 RID: 186856 RVA: 0x0063E918 File Offset: 0x0063CB18
		public static void StartIEnableSplineMoveModel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D9E9 RID: 186857 RVA: 0x0063E921 File Offset: 0x0063CB21
		public static void AddConfigType(FlatBufferBuilder builder, TSplineMoveModel configType)
		{
			builder.AddByte(0, (byte)configType, 0);
		}

		// Token: 0x0602D9EA RID: 186858 RVA: 0x0063E92C File Offset: 0x0063CB2C
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(1, configOffset, 0);
		}

		// Token: 0x0602D9EB RID: 186859 RVA: 0x0063E937 File Offset: 0x0063CB37
		public static Offset<IEnableSplineMoveModel> EndIEnableSplineMoveModel(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSplineMoveModel>(builder.EndTable());
		}

		// Token: 0x0602D9EC RID: 186860 RVA: 0x0063E944 File Offset: 0x0063CB44
		public IEnableSplineMoveModelT UnPack()
		{
			IEnableSplineMoveModelT enableSplineMoveModelT = new IEnableSplineMoveModelT();
			this.UnPackTo(enableSplineMoveModelT);
			return enableSplineMoveModelT;
		}

		// Token: 0x0602D9ED RID: 186861 RVA: 0x0063E960 File Offset: 0x0063CB60
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

		// Token: 0x0602D9EE RID: 186862 RVA: 0x0063EA04 File Offset: 0x0063CC04
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

		// Token: 0x04010D3D RID: 68925
		private Table __p;
	}
}
