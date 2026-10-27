using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B3B RID: 23355
	public struct IVisionCaptureComponent : IFlatbufferObject
	{
		// Token: 0x1700B03F RID: 45119
		// (get) Token: 0x06027EAA RID: 163498 RVA: 0x0057D1F2 File Offset: 0x0057B3F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027EAB RID: 163499 RVA: 0x0057D1FF File Offset: 0x0057B3FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027EAC RID: 163500 RVA: 0x0057D208 File Offset: 0x0057B408
		public static IVisionCaptureComponent GetRootAsIVisionCaptureComponent(ByteBuffer _bb)
		{
			return IVisionCaptureComponent.GetRootAsIVisionCaptureComponent(_bb, default(IVisionCaptureComponent));
		}

		// Token: 0x06027EAD RID: 163501 RVA: 0x0057D224 File Offset: 0x0057B424
		public static IVisionCaptureComponent GetRootAsIVisionCaptureComponent(ByteBuffer _bb, IVisionCaptureComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027EAE RID: 163502 RVA: 0x0057D241 File Offset: 0x0057B441
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027EAF RID: 163503 RVA: 0x0057D250 File Offset: 0x0057B450
		public IVisionCaptureComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B040 RID: 45120
		// (get) Token: 0x06027EB0 RID: 163504 RVA: 0x0057D260 File Offset: 0x0057B460
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B041 RID: 45121
		// (get) Token: 0x06027EB1 RID: 163505 RVA: 0x0057D2A0 File Offset: 0x0057B4A0
		public int VisionCaptureId
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

		// Token: 0x1700B042 RID: 45122
		// (get) Token: 0x06027EB2 RID: 163506 RVA: 0x0057D2DC File Offset: 0x0057B4DC
		public int VisionCaptureProb
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B043 RID: 45123
		// (get) Token: 0x06027EB3 RID: 163507 RVA: 0x0057D318 File Offset: 0x0057B518
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027EB4 RID: 163508 RVA: 0x0057D355 File Offset: 0x0057B555
		public static Offset<IVisionCaptureComponent> CreateIVisionCaptureComponent(FlatBufferBuilder builder, bool Disabled = false, int VisionCaptureId = 0, int VisionCaptureProb = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisionCaptureComponent.AddVisionCaptureProb(builder, VisionCaptureProb);
			IVisionCaptureComponent.AddVisionCaptureId(builder, VisionCaptureId);
			IVisionCaptureComponent.AddNullMask(builder, NullMask);
			IVisionCaptureComponent.AddDisabled(builder, Disabled);
			return IVisionCaptureComponent.EndIVisionCaptureComponent(builder);
		}

		// Token: 0x06027EB5 RID: 163509 RVA: 0x0057D381 File Offset: 0x0057B581
		public static void StartIVisionCaptureComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06027EB6 RID: 163510 RVA: 0x0057D38A File Offset: 0x0057B58A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027EB7 RID: 163511 RVA: 0x0057D395 File Offset: 0x0057B595
		public static void AddVisionCaptureId(FlatBufferBuilder builder, int visionCaptureId)
		{
			builder.AddInt(1, visionCaptureId, 0);
		}

		// Token: 0x06027EB8 RID: 163512 RVA: 0x0057D3A0 File Offset: 0x0057B5A0
		public static void AddVisionCaptureProb(FlatBufferBuilder builder, int visionCaptureProb)
		{
			builder.AddInt(2, visionCaptureProb, 0);
		}

		// Token: 0x06027EB9 RID: 163513 RVA: 0x0057D3AB File Offset: 0x0057B5AB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06027EBA RID: 163514 RVA: 0x0057D3B6 File Offset: 0x0057B5B6
		public static Offset<IVisionCaptureComponent> EndIVisionCaptureComponent(FlatBufferBuilder builder)
		{
			return new Offset<IVisionCaptureComponent>(builder.EndTable());
		}

		// Token: 0x06027EBB RID: 163515 RVA: 0x0057D3C4 File Offset: 0x0057B5C4
		public IVisionCaptureComponentT UnPack()
		{
			IVisionCaptureComponentT visionCaptureComponentT = new IVisionCaptureComponentT();
			this.UnPackTo(visionCaptureComponentT);
			return visionCaptureComponentT;
		}

		// Token: 0x06027EBC RID: 163516 RVA: 0x0057D3DF File Offset: 0x0057B5DF
		public void UnPackTo(IVisionCaptureComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.VisionCaptureId = this.VisionCaptureId;
			_o.VisionCaptureProb = this.VisionCaptureProb;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027EBD RID: 163517 RVA: 0x0057D414 File Offset: 0x0057B614
		public static Offset<IVisionCaptureComponent> Pack(FlatBufferBuilder builder, IVisionCaptureComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionCaptureComponent>);
			}
			return IVisionCaptureComponent.CreateIVisionCaptureComponent(builder, _o.Disabled, _o.VisionCaptureId, _o.VisionCaptureProb, _o.NullMask);
		}

		// Token: 0x0400F265 RID: 62053
		private Table __p;
	}
}
