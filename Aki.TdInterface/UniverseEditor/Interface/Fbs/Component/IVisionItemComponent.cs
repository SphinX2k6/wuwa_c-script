using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200615A RID: 24922
	public struct IVisionItemComponent : IFlatbufferObject
	{
		// Token: 0x1700B9A6 RID: 47526
		// (get) Token: 0x0602A4D0 RID: 173264 RVA: 0x005C5796 File Offset: 0x005C3996
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A4D1 RID: 173265 RVA: 0x005C57A3 File Offset: 0x005C39A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A4D2 RID: 173266 RVA: 0x005C57AC File Offset: 0x005C39AC
		public static IVisionItemComponent GetRootAsIVisionItemComponent(ByteBuffer _bb)
		{
			return IVisionItemComponent.GetRootAsIVisionItemComponent(_bb, default(IVisionItemComponent));
		}

		// Token: 0x0602A4D3 RID: 173267 RVA: 0x005C57C8 File Offset: 0x005C39C8
		public static IVisionItemComponent GetRootAsIVisionItemComponent(ByteBuffer _bb, IVisionItemComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A4D4 RID: 173268 RVA: 0x005C57E5 File Offset: 0x005C39E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A4D5 RID: 173269 RVA: 0x005C57F4 File Offset: 0x005C39F4
		public IVisionItemComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B9A7 RID: 47527
		// (get) Token: 0x0602A4D6 RID: 173270 RVA: 0x005C5804 File Offset: 0x005C3A04
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B9A8 RID: 47528
		// (get) Token: 0x0602A4D7 RID: 173271 RVA: 0x005C5844 File Offset: 0x005C3A44
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

		// Token: 0x0602A4D8 RID: 173272 RVA: 0x005C5880 File Offset: 0x005C3A80
		public static Offset<IVisionItemComponent> CreateIVisionItemComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IVisionItemComponent.AddNullMask(builder, NullMask);
			IVisionItemComponent.AddDisabled(builder, Disabled);
			return IVisionItemComponent.EndIVisionItemComponent(builder);
		}

		// Token: 0x0602A4D9 RID: 173273 RVA: 0x005C589D File Offset: 0x005C3A9D
		public static void StartIVisionItemComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A4DA RID: 173274 RVA: 0x005C58A6 File Offset: 0x005C3AA6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A4DB RID: 173275 RVA: 0x005C58B1 File Offset: 0x005C3AB1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602A4DC RID: 173276 RVA: 0x005C58BC File Offset: 0x005C3ABC
		public static Offset<IVisionItemComponent> EndIVisionItemComponent(FlatBufferBuilder builder)
		{
			return new Offset<IVisionItemComponent>(builder.EndTable());
		}

		// Token: 0x0602A4DD RID: 173277 RVA: 0x005C58CC File Offset: 0x005C3ACC
		public IVisionItemComponentT UnPack()
		{
			IVisionItemComponentT visionItemComponentT = new IVisionItemComponentT();
			this.UnPackTo(visionItemComponentT);
			return visionItemComponentT;
		}

		// Token: 0x0602A4DE RID: 173278 RVA: 0x005C58E7 File Offset: 0x005C3AE7
		public void UnPackTo(IVisionItemComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A4DF RID: 173279 RVA: 0x005C5904 File Offset: 0x005C3B04
		public static Offset<IVisionItemComponent> Pack(FlatBufferBuilder builder, IVisionItemComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionItemComponent>);
			}
			return IVisionItemComponent.CreateIVisionItemComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400FF7C RID: 65404
		private Table __p;
	}
}
