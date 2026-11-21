using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EAE RID: 28334
	public struct IFlowTemplateMode : IFlatbufferObject
	{
		// Token: 0x1700CFD6 RID: 53206
		// (get) Token: 0x06031047 RID: 200775 RVA: 0x006A6098 File Offset: 0x006A4298
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031048 RID: 200776 RVA: 0x006A60A5 File Offset: 0x006A42A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031049 RID: 200777 RVA: 0x006A60AC File Offset: 0x006A42AC
		public static IFlowTemplateMode GetRootAsIFlowTemplateMode(ByteBuffer _bb)
		{
			return IFlowTemplateMode.GetRootAsIFlowTemplateMode(_bb, default(IFlowTemplateMode));
		}

		// Token: 0x0603104A RID: 200778 RVA: 0x006A60C8 File Offset: 0x006A42C8
		public static IFlowTemplateMode GetRootAsIFlowTemplateMode(ByteBuffer _bb, IFlowTemplateMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603104B RID: 200779 RVA: 0x006A60E5 File Offset: 0x006A42E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603104C RID: 200780 RVA: 0x006A60F4 File Offset: 0x006A42F4
		public IFlowTemplateMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFD7 RID: 53207
		// (get) Token: 0x0603104D RID: 200781 RVA: 0x006A6104 File Offset: 0x006A4304
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

		// Token: 0x1700CFD8 RID: 53208
		// (get) Token: 0x0603104E RID: 200782 RVA: 0x006A6140 File Offset: 0x006A4340
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

		// Token: 0x0603104F RID: 200783 RVA: 0x006A617C File Offset: 0x006A437C
		public static Offset<IFlowTemplateMode> CreateIFlowTemplateMode(FlatBufferBuilder builder, int Id = 0, int CameraId = 0)
		{
			builder.StartTable(2);
			IFlowTemplateMode.AddCameraId(builder, CameraId);
			IFlowTemplateMode.AddId(builder, Id);
			return IFlowTemplateMode.EndIFlowTemplateMode(builder);
		}

		// Token: 0x06031050 RID: 200784 RVA: 0x006A6199 File Offset: 0x006A4399
		public static void StartIFlowTemplateMode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031051 RID: 200785 RVA: 0x006A61A2 File Offset: 0x006A43A2
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06031052 RID: 200786 RVA: 0x006A61AD File Offset: 0x006A43AD
		public static void AddCameraId(FlatBufferBuilder builder, int cameraId)
		{
			builder.AddInt(1, cameraId, 0);
		}

		// Token: 0x06031053 RID: 200787 RVA: 0x006A61B8 File Offset: 0x006A43B8
		public static Offset<IFlowTemplateMode> EndIFlowTemplateMode(FlatBufferBuilder builder)
		{
			return new Offset<IFlowTemplateMode>(builder.EndTable());
		}

		// Token: 0x06031054 RID: 200788 RVA: 0x006A61C8 File Offset: 0x006A43C8
		public IFlowTemplateModeT UnPack()
		{
			IFlowTemplateModeT flowTemplateModeT = new IFlowTemplateModeT();
			this.UnPackTo(flowTemplateModeT);
			return flowTemplateModeT;
		}

		// Token: 0x06031055 RID: 200789 RVA: 0x006A61E3 File Offset: 0x006A43E3
		public void UnPackTo(IFlowTemplateModeT _o)
		{
			_o.Id = this.Id;
			_o.CameraId = this.CameraId;
		}

		// Token: 0x06031056 RID: 200790 RVA: 0x006A6200 File Offset: 0x006A4400
		public static Offset<IFlowTemplateMode> Pack(FlatBufferBuilder builder, IFlowTemplateModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowTemplateMode>);
			}
			return IFlowTemplateMode.CreateIFlowTemplateMode(builder, _o.Id, _o.CameraId);
		}

		// Token: 0x04011DA2 RID: 73122
		private Table __p;
	}
}
