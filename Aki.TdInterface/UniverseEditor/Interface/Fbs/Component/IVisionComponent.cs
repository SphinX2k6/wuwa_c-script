using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B3E RID: 23358
	public struct IVisionComponent : IFlatbufferObject
	{
		// Token: 0x1700B048 RID: 45128
		// (get) Token: 0x06027EC8 RID: 163528 RVA: 0x0057D510 File Offset: 0x0057B710
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027EC9 RID: 163529 RVA: 0x0057D51D File Offset: 0x0057B71D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027ECA RID: 163530 RVA: 0x0057D524 File Offset: 0x0057B724
		public static IVisionComponent GetRootAsIVisionComponent(ByteBuffer _bb)
		{
			return IVisionComponent.GetRootAsIVisionComponent(_bb, default(IVisionComponent));
		}

		// Token: 0x06027ECB RID: 163531 RVA: 0x0057D540 File Offset: 0x0057B740
		public static IVisionComponent GetRootAsIVisionComponent(ByteBuffer _bb, IVisionComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027ECC RID: 163532 RVA: 0x0057D55D File Offset: 0x0057B75D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027ECD RID: 163533 RVA: 0x0057D56C File Offset: 0x0057B76C
		public IVisionComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B049 RID: 45129
		// (get) Token: 0x06027ECE RID: 163534 RVA: 0x0057D57C File Offset: 0x0057B77C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B04A RID: 45130
		// (get) Token: 0x06027ECF RID: 163535 RVA: 0x0057D5BC File Offset: 0x0057B7BC
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

		// Token: 0x1700B04B RID: 45131
		// (get) Token: 0x06027ED0 RID: 163536 RVA: 0x0057D5F8 File Offset: 0x0057B7F8
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

		// Token: 0x06027ED1 RID: 163537 RVA: 0x0057D634 File Offset: 0x0057B834
		public static Offset<IVisionComponent> CreateIVisionComponent(FlatBufferBuilder builder, bool Disabled = false, int VisionId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IVisionComponent.AddVisionId(builder, VisionId);
			IVisionComponent.AddNullMask(builder, NullMask);
			IVisionComponent.AddDisabled(builder, Disabled);
			return IVisionComponent.EndIVisionComponent(builder);
		}

		// Token: 0x06027ED2 RID: 163538 RVA: 0x0057D658 File Offset: 0x0057B858
		public static void StartIVisionComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027ED3 RID: 163539 RVA: 0x0057D661 File Offset: 0x0057B861
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027ED4 RID: 163540 RVA: 0x0057D66C File Offset: 0x0057B86C
		public static void AddVisionId(FlatBufferBuilder builder, int visionId)
		{
			builder.AddInt(1, visionId, 0);
		}

		// Token: 0x06027ED5 RID: 163541 RVA: 0x0057D677 File Offset: 0x0057B877
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06027ED6 RID: 163542 RVA: 0x0057D682 File Offset: 0x0057B882
		public static Offset<IVisionComponent> EndIVisionComponent(FlatBufferBuilder builder)
		{
			return new Offset<IVisionComponent>(builder.EndTable());
		}

		// Token: 0x06027ED7 RID: 163543 RVA: 0x0057D690 File Offset: 0x0057B890
		public IVisionComponentT UnPack()
		{
			IVisionComponentT visionComponentT = new IVisionComponentT();
			this.UnPackTo(visionComponentT);
			return visionComponentT;
		}

		// Token: 0x06027ED8 RID: 163544 RVA: 0x0057D6AB File Offset: 0x0057B8AB
		public void UnPackTo(IVisionComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.VisionId = this.VisionId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027ED9 RID: 163545 RVA: 0x0057D6D4 File Offset: 0x0057B8D4
		public static Offset<IVisionComponent> Pack(FlatBufferBuilder builder, IVisionComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionComponent>);
			}
			return IVisionComponent.CreateIVisionComponent(builder, _o.Disabled, _o.VisionId, _o.NullMask);
		}

		// Token: 0x0400F26A RID: 62058
		private Table __p;
	}
}
