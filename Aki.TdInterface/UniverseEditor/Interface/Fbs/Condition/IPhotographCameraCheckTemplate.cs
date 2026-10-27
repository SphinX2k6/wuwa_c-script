using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C76 RID: 19574
	public struct IPhotographCameraCheckTemplate : IFlatbufferObject
	{
		// Token: 0x17008E2C RID: 36396
		// (get) Token: 0x0601F0A5 RID: 127141 RVA: 0x00456D00 File Offset: 0x00454F00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F0A6 RID: 127142 RVA: 0x00456D0D File Offset: 0x00454F0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F0A7 RID: 127143 RVA: 0x00456D14 File Offset: 0x00454F14
		public static IPhotographCameraCheckTemplate GetRootAsIPhotographCameraCheckTemplate(ByteBuffer _bb)
		{
			return IPhotographCameraCheckTemplate.GetRootAsIPhotographCameraCheckTemplate(_bb, default(IPhotographCameraCheckTemplate));
		}

		// Token: 0x0601F0A8 RID: 127144 RVA: 0x00456D30 File Offset: 0x00454F30
		public static IPhotographCameraCheckTemplate GetRootAsIPhotographCameraCheckTemplate(ByteBuffer _bb, IPhotographCameraCheckTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F0A9 RID: 127145 RVA: 0x00456D4D File Offset: 0x00454F4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F0AA RID: 127146 RVA: 0x00456D5C File Offset: 0x00454F5C
		public IPhotographCameraCheckTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E2D RID: 36397
		// (get) Token: 0x0601F0AB RID: 127147 RVA: 0x00456D6C File Offset: 0x00454F6C
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

		// Token: 0x17008E2E RID: 36398
		// (get) Token: 0x0601F0AC RID: 127148 RVA: 0x00456DA8 File Offset: 0x00454FA8
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

		// Token: 0x0601F0AD RID: 127149 RVA: 0x00456DE4 File Offset: 0x00454FE4
		public static Offset<IPhotographCameraCheckTemplate> CreateIPhotographCameraCheckTemplate(FlatBufferBuilder builder, EPhotographCameraCheckType Type = EPhotographCameraCheckType.CameraTemplate, int TemplateId = 0)
		{
			builder.StartTable(2);
			IPhotographCameraCheckTemplate.AddTemplateId(builder, TemplateId);
			IPhotographCameraCheckTemplate.AddType(builder, Type);
			return IPhotographCameraCheckTemplate.EndIPhotographCameraCheckTemplate(builder);
		}

		// Token: 0x0601F0AE RID: 127150 RVA: 0x00456E01 File Offset: 0x00455001
		public static void StartIPhotographCameraCheckTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F0AF RID: 127151 RVA: 0x00456E0A File Offset: 0x0045500A
		public static void AddType(FlatBufferBuilder builder, EPhotographCameraCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F0B0 RID: 127152 RVA: 0x00456E15 File Offset: 0x00455015
		public static void AddTemplateId(FlatBufferBuilder builder, int templateId)
		{
			builder.AddInt(1, templateId, 0);
		}

		// Token: 0x0601F0B1 RID: 127153 RVA: 0x00456E20 File Offset: 0x00455020
		public static Offset<IPhotographCameraCheckTemplate> EndIPhotographCameraCheckTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographCameraCheckTemplate>(builder.EndTable());
		}

		// Token: 0x0601F0B2 RID: 127154 RVA: 0x00456E30 File Offset: 0x00455030
		public IPhotographCameraCheckTemplateT UnPack()
		{
			IPhotographCameraCheckTemplateT photographCameraCheckTemplateT = new IPhotographCameraCheckTemplateT();
			this.UnPackTo(photographCameraCheckTemplateT);
			return photographCameraCheckTemplateT;
		}

		// Token: 0x0601F0B3 RID: 127155 RVA: 0x00456E4B File Offset: 0x0045504B
		public void UnPackTo(IPhotographCameraCheckTemplateT _o)
		{
			_o.Type = this.Type;
			_o.TemplateId = this.TemplateId;
		}

		// Token: 0x0601F0B4 RID: 127156 RVA: 0x00456E68 File Offset: 0x00455068
		public static Offset<IPhotographCameraCheckTemplate> Pack(FlatBufferBuilder builder, IPhotographCameraCheckTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographCameraCheckTemplate>);
			}
			return IPhotographCameraCheckTemplate.CreateIPhotographCameraCheckTemplate(builder, _o.Type, _o.TemplateId);
		}

		// Token: 0x0400D628 RID: 54824
		private Table __p;
	}
}
