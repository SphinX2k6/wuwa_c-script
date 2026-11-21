using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006154 RID: 24916
	public struct IVisionComponent : IFlatbufferObject
	{
		// Token: 0x1700B990 RID: 47504
		// (get) Token: 0x0602A48C RID: 173196 RVA: 0x005C4FA0 File Offset: 0x005C31A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A48D RID: 173197 RVA: 0x005C4FAD File Offset: 0x005C31AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A48E RID: 173198 RVA: 0x005C4FB4 File Offset: 0x005C31B4
		public static IVisionComponent GetRootAsIVisionComponent(ByteBuffer _bb)
		{
			return IVisionComponent.GetRootAsIVisionComponent(_bb, default(IVisionComponent));
		}

		// Token: 0x0602A48F RID: 173199 RVA: 0x005C4FD0 File Offset: 0x005C31D0
		public static IVisionComponent GetRootAsIVisionComponent(ByteBuffer _bb, IVisionComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A490 RID: 173200 RVA: 0x005C4FED File Offset: 0x005C31ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A491 RID: 173201 RVA: 0x005C4FFC File Offset: 0x005C31FC
		public IVisionComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B991 RID: 47505
		// (get) Token: 0x0602A492 RID: 173202 RVA: 0x005C500C File Offset: 0x005C320C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B992 RID: 47506
		// (get) Token: 0x0602A493 RID: 173203 RVA: 0x005C504C File Offset: 0x005C324C
		public int VisionId
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

		// Token: 0x1700B993 RID: 47507
		// (get) Token: 0x0602A494 RID: 173204 RVA: 0x005C5088 File Offset: 0x005C3288
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A495 RID: 173205 RVA: 0x005C50C4 File Offset: 0x005C32C4
		public static Offset<IVisionComponent> CreateIVisionComponent(FlatBufferBuilder builder, bool Disabled = false, int VisionId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IVisionComponent.AddVisionId(builder, VisionId);
			IVisionComponent.AddNullMask(builder, NullMask);
			IVisionComponent.AddDisabled(builder, Disabled);
			return IVisionComponent.EndIVisionComponent(builder);
		}

		// Token: 0x0602A496 RID: 173206 RVA: 0x005C50E8 File Offset: 0x005C32E8
		public static void StartIVisionComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A497 RID: 173207 RVA: 0x005C50F1 File Offset: 0x005C32F1
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A498 RID: 173208 RVA: 0x005C50FC File Offset: 0x005C32FC
		public static void AddVisionId(FlatBufferBuilder builder, int visionId)
		{
			builder.AddInt(1, visionId, 0);
		}

		// Token: 0x0602A499 RID: 173209 RVA: 0x005C5107 File Offset: 0x005C3307
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602A49A RID: 173210 RVA: 0x005C5112 File Offset: 0x005C3312
		public static Offset<IVisionComponent> EndIVisionComponent(FlatBufferBuilder builder)
		{
			return new Offset<IVisionComponent>(builder.EndTable());
		}

		// Token: 0x0602A49B RID: 173211 RVA: 0x005C5120 File Offset: 0x005C3320
		public IVisionComponentT UnPack()
		{
			IVisionComponentT visionComponentT = new IVisionComponentT();
			this.UnPackTo(visionComponentT);
			return visionComponentT;
		}

		// Token: 0x0602A49C RID: 173212 RVA: 0x005C513B File Offset: 0x005C333B
		public void UnPackTo(IVisionComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.VisionId = this.VisionId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A49D RID: 173213 RVA: 0x005C5164 File Offset: 0x005C3364
		public static Offset<IVisionComponent> Pack(FlatBufferBuilder builder, IVisionComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionComponent>);
			}
			return IVisionComponent.CreateIVisionComponent(builder, _o.Disabled, _o.VisionId, _o.NullMask);
		}

		// Token: 0x0400FF70 RID: 65392
		private Table __p;
	}
}
