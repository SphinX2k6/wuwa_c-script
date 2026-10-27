using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B44 RID: 23364
	public struct IVisionItemComponent : IFlatbufferObject
	{
		// Token: 0x1700B05E RID: 45150
		// (get) Token: 0x06027F0C RID: 163596 RVA: 0x0057DD06 File Offset: 0x0057BF06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027F0D RID: 163597 RVA: 0x0057DD13 File Offset: 0x0057BF13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027F0E RID: 163598 RVA: 0x0057DD1C File Offset: 0x0057BF1C
		public static IVisionItemComponent GetRootAsIVisionItemComponent(ByteBuffer _bb)
		{
			return IVisionItemComponent.GetRootAsIVisionItemComponent(_bb, default(IVisionItemComponent));
		}

		// Token: 0x06027F0F RID: 163599 RVA: 0x0057DD38 File Offset: 0x0057BF38
		public static IVisionItemComponent GetRootAsIVisionItemComponent(ByteBuffer _bb, IVisionItemComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027F10 RID: 163600 RVA: 0x0057DD55 File Offset: 0x0057BF55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027F11 RID: 163601 RVA: 0x0057DD64 File Offset: 0x0057BF64
		public IVisionItemComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B05F RID: 45151
		// (get) Token: 0x06027F12 RID: 163602 RVA: 0x0057DD74 File Offset: 0x0057BF74
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B060 RID: 45152
		// (get) Token: 0x06027F13 RID: 163603 RVA: 0x0057DDB4 File Offset: 0x0057BFB4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027F14 RID: 163604 RVA: 0x0057DDF0 File Offset: 0x0057BFF0
		public static Offset<IVisionItemComponent> CreateIVisionItemComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IVisionItemComponent.AddNullMask(builder, NullMask);
			IVisionItemComponent.AddDisabled(builder, Disabled);
			return IVisionItemComponent.EndIVisionItemComponent(builder);
		}

		// Token: 0x06027F15 RID: 163605 RVA: 0x0057DE0D File Offset: 0x0057C00D
		public static void StartIVisionItemComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027F16 RID: 163606 RVA: 0x0057DE16 File Offset: 0x0057C016
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027F17 RID: 163607 RVA: 0x0057DE21 File Offset: 0x0057C021
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06027F18 RID: 163608 RVA: 0x0057DE2C File Offset: 0x0057C02C
		public static Offset<IVisionItemComponent> EndIVisionItemComponent(FlatBufferBuilder builder)
		{
			return new Offset<IVisionItemComponent>(builder.EndTable());
		}

		// Token: 0x06027F19 RID: 163609 RVA: 0x0057DE3C File Offset: 0x0057C03C
		public IVisionItemComponentT UnPack()
		{
			IVisionItemComponentT visionItemComponentT = new IVisionItemComponentT();
			this.UnPackTo(visionItemComponentT);
			return visionItemComponentT;
		}

		// Token: 0x06027F1A RID: 163610 RVA: 0x0057DE57 File Offset: 0x0057C057
		public void UnPackTo(IVisionItemComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027F1B RID: 163611 RVA: 0x0057DE74 File Offset: 0x0057C074
		public static Offset<IVisionItemComponent> Pack(FlatBufferBuilder builder, IVisionItemComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionItemComponent>);
			}
			return IVisionItemComponent.CreateIVisionItemComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400F276 RID: 62070
		private Table __p;
	}
}
