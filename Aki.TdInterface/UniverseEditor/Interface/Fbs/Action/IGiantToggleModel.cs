using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200688E RID: 26766
	public struct IGiantToggleModel : IFlatbufferObject
	{
		// Token: 0x1700C6BD RID: 50877
		// (get) Token: 0x0602EAD8 RID: 191192 RVA: 0x0065D4B9 File Offset: 0x0065B6B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EAD9 RID: 191193 RVA: 0x0065D4C6 File Offset: 0x0065B6C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EADA RID: 191194 RVA: 0x0065D4D0 File Offset: 0x0065B6D0
		public static IGiantToggleModel GetRootAsIGiantToggleModel(ByteBuffer _bb)
		{
			return IGiantToggleModel.GetRootAsIGiantToggleModel(_bb, default(IGiantToggleModel));
		}

		// Token: 0x0602EADB RID: 191195 RVA: 0x0065D4EC File Offset: 0x0065B6EC
		public static IGiantToggleModel GetRootAsIGiantToggleModel(ByteBuffer _bb, IGiantToggleModel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EADC RID: 191196 RVA: 0x0065D509 File Offset: 0x0065B709
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EADD RID: 191197 RVA: 0x0065D518 File Offset: 0x0065B718
		public IGiantToggleModel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6BE RID: 50878
		// (get) Token: 0x0602EADE RID: 191198 RVA: 0x0065D528 File Offset: 0x0065B728
		public bool IsEnabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602EADF RID: 191199 RVA: 0x0065D567 File Offset: 0x0065B767
		public static Offset<IGiantToggleModel> CreateIGiantToggleModel(FlatBufferBuilder builder, bool IsEnabled = false)
		{
			builder.StartTable(1);
			IGiantToggleModel.AddIsEnabled(builder, IsEnabled);
			return IGiantToggleModel.EndIGiantToggleModel(builder);
		}

		// Token: 0x0602EAE0 RID: 191200 RVA: 0x0065D57D File Offset: 0x0065B77D
		public static void StartIGiantToggleModel(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EAE1 RID: 191201 RVA: 0x0065D586 File Offset: 0x0065B786
		public static void AddIsEnabled(FlatBufferBuilder builder, bool isEnabled)
		{
			builder.AddBool(0, isEnabled, false);
		}

		// Token: 0x0602EAE2 RID: 191202 RVA: 0x0065D591 File Offset: 0x0065B791
		public static Offset<IGiantToggleModel> EndIGiantToggleModel(FlatBufferBuilder builder)
		{
			return new Offset<IGiantToggleModel>(builder.EndTable());
		}

		// Token: 0x0602EAE3 RID: 191203 RVA: 0x0065D5A0 File Offset: 0x0065B7A0
		public IGiantToggleModelT UnPack()
		{
			IGiantToggleModelT giantToggleModelT = new IGiantToggleModelT();
			this.UnPackTo(giantToggleModelT);
			return giantToggleModelT;
		}

		// Token: 0x0602EAE4 RID: 191204 RVA: 0x0065D5BB File Offset: 0x0065B7BB
		public void UnPackTo(IGiantToggleModelT _o)
		{
			_o.IsEnabled = this.IsEnabled;
		}

		// Token: 0x0602EAE5 RID: 191205 RVA: 0x0065D5CC File Offset: 0x0065B7CC
		public static Offset<IGiantToggleModel> Pack(FlatBufferBuilder builder, IGiantToggleModelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantToggleModel>);
			}
			return IGiantToggleModel.CreateIGiantToggleModel(builder, _o.IsEnabled);
		}

		// Token: 0x04010FE0 RID: 69600
		private Table __p;
	}
}
