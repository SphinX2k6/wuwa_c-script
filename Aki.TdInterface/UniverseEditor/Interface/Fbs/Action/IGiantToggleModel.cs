using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F2F RID: 28463
	public struct IGiantToggleModel : IFlatbufferObject
	{
		// Token: 0x1700D0A3 RID: 53411
		// (get) Token: 0x06031412 RID: 201746 RVA: 0x006AC539 File Offset: 0x006AA739
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031413 RID: 201747 RVA: 0x006AC546 File Offset: 0x006AA746
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031414 RID: 201748 RVA: 0x006AC550 File Offset: 0x006AA750
		public static IGiantToggleModel GetRootAsIGiantToggleModel(ByteBuffer _bb)
		{
			return IGiantToggleModel.GetRootAsIGiantToggleModel(_bb, default(IGiantToggleModel));
		}

		// Token: 0x06031415 RID: 201749 RVA: 0x006AC56C File Offset: 0x006AA76C
		public static IGiantToggleModel GetRootAsIGiantToggleModel(ByteBuffer _bb, IGiantToggleModel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031416 RID: 201750 RVA: 0x006AC589 File Offset: 0x006AA789
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031417 RID: 201751 RVA: 0x006AC598 File Offset: 0x006AA798
		public IGiantToggleModel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0A4 RID: 53412
		// (get) Token: 0x06031418 RID: 201752 RVA: 0x006AC5A8 File Offset: 0x006AA7A8
		public bool IsEnabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06031419 RID: 201753 RVA: 0x006AC5E7 File Offset: 0x006AA7E7
		public static Offset<IGiantToggleModel> CreateIGiantToggleModel(FlatBufferBuilder builder, bool IsEnabled = false)
		{
			builder.StartTable(1);
			IGiantToggleModel.AddIsEnabled(builder, IsEnabled);
			return IGiantToggleModel.EndIGiantToggleModel(builder);
		}

		// Token: 0x0603141A RID: 201754 RVA: 0x006AC5FD File Offset: 0x006AA7FD
		public static void StartIGiantToggleModel(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603141B RID: 201755 RVA: 0x006AC606 File Offset: 0x006AA806
		public static void AddIsEnabled(FlatBufferBuilder builder, bool isEnabled)
		{
			builder.AddBool(0, isEnabled, false);
		}

		// Token: 0x0603141C RID: 201756 RVA: 0x006AC611 File Offset: 0x006AA811
		public static Offset<IGiantToggleModel> EndIGiantToggleModel(FlatBufferBuilder builder)
		{
			return new Offset<IGiantToggleModel>(builder.EndTable());
		}

		// Token: 0x0603141D RID: 201757 RVA: 0x006AC620 File Offset: 0x006AA820
		public IGiantToggleModelT UnPack()
		{
			IGiantToggleModelT giantToggleModelT = new IGiantToggleModelT();
			this.UnPackTo(giantToggleModelT);
			return giantToggleModelT;
		}

		// Token: 0x0603141E RID: 201758 RVA: 0x006AC63B File Offset: 0x006AA83B
		public void UnPackTo(IGiantToggleModelT _o)
		{
			_o.IsEnabled = this.IsEnabled;
		}

		// Token: 0x0603141F RID: 201759 RVA: 0x006AC64C File Offset: 0x006AA84C
		public static Offset<IGiantToggleModel> Pack(FlatBufferBuilder builder, IGiantToggleModelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantToggleModel>);
			}
			return IGiantToggleModel.CreateIGiantToggleModel(builder, _o.IsEnabled);
		}

		// Token: 0x04011E35 RID: 73269
		private Table __p;
	}
}
