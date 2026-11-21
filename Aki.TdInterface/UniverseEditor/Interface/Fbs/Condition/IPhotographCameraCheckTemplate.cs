using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200516F RID: 20847
	public struct IPhotographCameraCheckTemplate : IFlatbufferObject
	{
		// Token: 0x1700955A RID: 38234
		// (get) Token: 0x06020CC7 RID: 134343 RVA: 0x0048A850 File Offset: 0x00488A50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020CC8 RID: 134344 RVA: 0x0048A85D File Offset: 0x00488A5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020CC9 RID: 134345 RVA: 0x0048A864 File Offset: 0x00488A64
		public static IPhotographCameraCheckTemplate GetRootAsIPhotographCameraCheckTemplate(ByteBuffer _bb)
		{
			return IPhotographCameraCheckTemplate.GetRootAsIPhotographCameraCheckTemplate(_bb, default(IPhotographCameraCheckTemplate));
		}

		// Token: 0x06020CCA RID: 134346 RVA: 0x0048A880 File Offset: 0x00488A80
		public static IPhotographCameraCheckTemplate GetRootAsIPhotographCameraCheckTemplate(ByteBuffer _bb, IPhotographCameraCheckTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020CCB RID: 134347 RVA: 0x0048A89D File Offset: 0x00488A9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020CCC RID: 134348 RVA: 0x0048A8AC File Offset: 0x00488AAC
		public IPhotographCameraCheckTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700955B RID: 38235
		// (get) Token: 0x06020CCD RID: 134349 RVA: 0x0048A8BC File Offset: 0x00488ABC
		public EPhotographCameraCheckType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotographCameraCheckType.CameraTemplate;
				}
				return (EPhotographCameraCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700955C RID: 38236
		// (get) Token: 0x06020CCE RID: 134350 RVA: 0x0048A8F8 File Offset: 0x00488AF8
		public int TemplateId
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

		// Token: 0x06020CCF RID: 134351 RVA: 0x0048A934 File Offset: 0x00488B34
		public static Offset<IPhotographCameraCheckTemplate> CreateIPhotographCameraCheckTemplate(FlatBufferBuilder builder, EPhotographCameraCheckType Type = EPhotographCameraCheckType.CameraTemplate, int TemplateId = 0)
		{
			builder.StartTable(2);
			IPhotographCameraCheckTemplate.AddTemplateId(builder, TemplateId);
			IPhotographCameraCheckTemplate.AddType(builder, Type);
			return IPhotographCameraCheckTemplate.EndIPhotographCameraCheckTemplate(builder);
		}

		// Token: 0x06020CD0 RID: 134352 RVA: 0x0048A951 File Offset: 0x00488B51
		public static void StartIPhotographCameraCheckTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020CD1 RID: 134353 RVA: 0x0048A95A File Offset: 0x00488B5A
		public static void AddType(FlatBufferBuilder builder, EPhotographCameraCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020CD2 RID: 134354 RVA: 0x0048A965 File Offset: 0x00488B65
		public static void AddTemplateId(FlatBufferBuilder builder, int templateId)
		{
			builder.AddInt(1, templateId, 0);
		}

		// Token: 0x06020CD3 RID: 134355 RVA: 0x0048A970 File Offset: 0x00488B70
		public static Offset<IPhotographCameraCheckTemplate> EndIPhotographCameraCheckTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographCameraCheckTemplate>(builder.EndTable());
		}

		// Token: 0x06020CD4 RID: 134356 RVA: 0x0048A980 File Offset: 0x00488B80
		public IPhotographCameraCheckTemplateT UnPack()
		{
			IPhotographCameraCheckTemplateT photographCameraCheckTemplateT = new IPhotographCameraCheckTemplateT();
			this.UnPackTo(photographCameraCheckTemplateT);
			return photographCameraCheckTemplateT;
		}

		// Token: 0x06020CD5 RID: 134357 RVA: 0x0048A99B File Offset: 0x00488B9B
		public void UnPackTo(IPhotographCameraCheckTemplateT _o)
		{
			_o.Type = this.Type;
			_o.TemplateId = this.TemplateId;
		}

		// Token: 0x06020CD6 RID: 134358 RVA: 0x0048A9B8 File Offset: 0x00488BB8
		public static Offset<IPhotographCameraCheckTemplate> Pack(FlatBufferBuilder builder, IPhotographCameraCheckTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographCameraCheckTemplate>);
			}
			return IPhotographCameraCheckTemplate.CreateIPhotographCameraCheckTemplate(builder, _o.Type, _o.TemplateId);
		}

		// Token: 0x0400E14F RID: 57679
		private Table __p;
	}
}
