using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006828 RID: 26664
	public struct IFlowTemplateMode : IFlatbufferObject
	{
		// Token: 0x1700C612 RID: 50706
		// (get) Token: 0x0602E7BF RID: 190399 RVA: 0x00658158 File Offset: 0x00656358
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E7C0 RID: 190400 RVA: 0x00658165 File Offset: 0x00656365
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E7C1 RID: 190401 RVA: 0x0065816C File Offset: 0x0065636C
		public static IFlowTemplateMode GetRootAsIFlowTemplateMode(ByteBuffer _bb)
		{
			return IFlowTemplateMode.GetRootAsIFlowTemplateMode(_bb, default(IFlowTemplateMode));
		}

		// Token: 0x0602E7C2 RID: 190402 RVA: 0x00658188 File Offset: 0x00656388
		public static IFlowTemplateMode GetRootAsIFlowTemplateMode(ByteBuffer _bb, IFlowTemplateMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E7C3 RID: 190403 RVA: 0x006581A5 File Offset: 0x006563A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E7C4 RID: 190404 RVA: 0x006581B4 File Offset: 0x006563B4
		public IFlowTemplateMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C613 RID: 50707
		// (get) Token: 0x0602E7C5 RID: 190405 RVA: 0x006581C4 File Offset: 0x006563C4
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C614 RID: 50708
		// (get) Token: 0x0602E7C6 RID: 190406 RVA: 0x00658200 File Offset: 0x00656400
		public int CameraId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E7C7 RID: 190407 RVA: 0x0065823C File Offset: 0x0065643C
		public static Offset<IFlowTemplateMode> CreateIFlowTemplateMode(FlatBufferBuilder builder, int Id = 0, int CameraId = 0)
		{
			builder.StartTable(2);
			IFlowTemplateMode.AddCameraId(builder, CameraId);
			IFlowTemplateMode.AddId(builder, Id);
			return IFlowTemplateMode.EndIFlowTemplateMode(builder);
		}

		// Token: 0x0602E7C8 RID: 190408 RVA: 0x00658259 File Offset: 0x00656459
		public static void StartIFlowTemplateMode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E7C9 RID: 190409 RVA: 0x00658262 File Offset: 0x00656462
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602E7CA RID: 190410 RVA: 0x0065826D File Offset: 0x0065646D
		public static void AddCameraId(FlatBufferBuilder builder, int cameraId)
		{
			builder.AddInt(1, cameraId, 0);
		}

		// Token: 0x0602E7CB RID: 190411 RVA: 0x00658278 File Offset: 0x00656478
		public static Offset<IFlowTemplateMode> EndIFlowTemplateMode(FlatBufferBuilder builder)
		{
			return new Offset<IFlowTemplateMode>(builder.EndTable());
		}

		// Token: 0x0602E7CC RID: 190412 RVA: 0x00658288 File Offset: 0x00656488
		public IFlowTemplateModeT UnPack()
		{
			IFlowTemplateModeT flowTemplateModeT = new IFlowTemplateModeT();
			this.UnPackTo(flowTemplateModeT);
			return flowTemplateModeT;
		}

		// Token: 0x0602E7CD RID: 190413 RVA: 0x006582A3 File Offset: 0x006564A3
		public void UnPackTo(IFlowTemplateModeT _o)
		{
			_o.Id = this.Id;
			_o.CameraId = this.CameraId;
		}

		// Token: 0x0602E7CE RID: 190414 RVA: 0x006582C0 File Offset: 0x006564C0
		public static Offset<IFlowTemplateMode> Pack(FlatBufferBuilder builder, IFlowTemplateModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowTemplateMode>);
			}
			return IFlowTemplateMode.CreateIFlowTemplateMode(builder, _o.Id, _o.CameraId);
		}

		// Token: 0x04010F68 RID: 69480
		private Table __p;
	}
}
