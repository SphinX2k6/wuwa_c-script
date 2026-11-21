using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006151 RID: 24913
	public struct IVisionCaptureComponent : IFlatbufferObject
	{
		// Token: 0x1700B987 RID: 47495
		// (get) Token: 0x0602A46E RID: 173166 RVA: 0x005C4C82 File Offset: 0x005C2E82
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A46F RID: 173167 RVA: 0x005C4C8F File Offset: 0x005C2E8F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A470 RID: 173168 RVA: 0x005C4C98 File Offset: 0x005C2E98
		public static IVisionCaptureComponent GetRootAsIVisionCaptureComponent(ByteBuffer _bb)
		{
			return IVisionCaptureComponent.GetRootAsIVisionCaptureComponent(_bb, default(IVisionCaptureComponent));
		}

		// Token: 0x0602A471 RID: 173169 RVA: 0x005C4CB4 File Offset: 0x005C2EB4
		public static IVisionCaptureComponent GetRootAsIVisionCaptureComponent(ByteBuffer _bb, IVisionCaptureComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A472 RID: 173170 RVA: 0x005C4CD1 File Offset: 0x005C2ED1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A473 RID: 173171 RVA: 0x005C4CE0 File Offset: 0x005C2EE0
		public IVisionCaptureComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B988 RID: 47496
		// (get) Token: 0x0602A474 RID: 173172 RVA: 0x005C4CF0 File Offset: 0x005C2EF0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B989 RID: 47497
		// (get) Token: 0x0602A475 RID: 173173 RVA: 0x005C4D30 File Offset: 0x005C2F30
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

		// Token: 0x1700B98A RID: 47498
		// (get) Token: 0x0602A476 RID: 173174 RVA: 0x005C4D6C File Offset: 0x005C2F6C
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

		// Token: 0x1700B98B RID: 47499
		// (get) Token: 0x0602A477 RID: 173175 RVA: 0x005C4DA8 File Offset: 0x005C2FA8
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

		// Token: 0x0602A478 RID: 173176 RVA: 0x005C4DE5 File Offset: 0x005C2FE5
		public static Offset<IVisionCaptureComponent> CreateIVisionCaptureComponent(FlatBufferBuilder builder, bool Disabled = false, int VisionCaptureId = 0, int VisionCaptureProb = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisionCaptureComponent.AddVisionCaptureProb(builder, VisionCaptureProb);
			IVisionCaptureComponent.AddVisionCaptureId(builder, VisionCaptureId);
			IVisionCaptureComponent.AddNullMask(builder, NullMask);
			IVisionCaptureComponent.AddDisabled(builder, Disabled);
			return IVisionCaptureComponent.EndIVisionCaptureComponent(builder);
		}

		// Token: 0x0602A479 RID: 173177 RVA: 0x005C4E11 File Offset: 0x005C3011
		public static void StartIVisionCaptureComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602A47A RID: 173178 RVA: 0x005C4E1A File Offset: 0x005C301A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A47B RID: 173179 RVA: 0x005C4E25 File Offset: 0x005C3025
		public static void AddVisionCaptureId(FlatBufferBuilder builder, int visionCaptureId)
		{
			builder.AddInt(1, visionCaptureId, 0);
		}

		// Token: 0x0602A47C RID: 173180 RVA: 0x005C4E30 File Offset: 0x005C3030
		public static void AddVisionCaptureProb(FlatBufferBuilder builder, int visionCaptureProb)
		{
			builder.AddInt(2, visionCaptureProb, 0);
		}

		// Token: 0x0602A47D RID: 173181 RVA: 0x005C4E3B File Offset: 0x005C303B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602A47E RID: 173182 RVA: 0x005C4E46 File Offset: 0x005C3046
		public static Offset<IVisionCaptureComponent> EndIVisionCaptureComponent(FlatBufferBuilder builder)
		{
			return new Offset<IVisionCaptureComponent>(builder.EndTable());
		}

		// Token: 0x0602A47F RID: 173183 RVA: 0x005C4E54 File Offset: 0x005C3054
		public IVisionCaptureComponentT UnPack()
		{
			IVisionCaptureComponentT visionCaptureComponentT = new IVisionCaptureComponentT();
			this.UnPackTo(visionCaptureComponentT);
			return visionCaptureComponentT;
		}

		// Token: 0x0602A480 RID: 173184 RVA: 0x005C4E6F File Offset: 0x005C306F
		public void UnPackTo(IVisionCaptureComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.VisionCaptureId = this.VisionCaptureId;
			_o.VisionCaptureProb = this.VisionCaptureProb;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A481 RID: 173185 RVA: 0x005C4EA4 File Offset: 0x005C30A4
		public static Offset<IVisionCaptureComponent> Pack(FlatBufferBuilder builder, IVisionCaptureComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionCaptureComponent>);
			}
			return IVisionCaptureComponent.CreateIVisionCaptureComponent(builder, _o.Disabled, _o.VisionCaptureId, _o.VisionCaptureProb, _o.NullMask);
		}

		// Token: 0x0400FF6B RID: 65387
		private Table __p;
	}
}
