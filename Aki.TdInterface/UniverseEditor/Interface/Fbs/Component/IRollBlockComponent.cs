using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E8F RID: 24207
	public struct IRollBlockComponent : IFlatbufferObject
	{
		// Token: 0x1700B2A2 RID: 45730
		// (get) Token: 0x06028832 RID: 165938 RVA: 0x0058A07E File Offset: 0x0058827E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028833 RID: 165939 RVA: 0x0058A08B File Offset: 0x0058828B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028834 RID: 165940 RVA: 0x0058A094 File Offset: 0x00588294
		public static IRollBlockComponent GetRootAsIRollBlockComponent(ByteBuffer _bb)
		{
			return IRollBlockComponent.GetRootAsIRollBlockComponent(_bb, default(IRollBlockComponent));
		}

		// Token: 0x06028835 RID: 165941 RVA: 0x0058A0B0 File Offset: 0x005882B0
		public static IRollBlockComponent GetRootAsIRollBlockComponent(ByteBuffer _bb, IRollBlockComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028836 RID: 165942 RVA: 0x0058A0CD File Offset: 0x005882CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028837 RID: 165943 RVA: 0x0058A0DC File Offset: 0x005882DC
		public IRollBlockComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2A3 RID: 45731
		// (get) Token: 0x06028838 RID: 165944 RVA: 0x0058A0EC File Offset: 0x005882EC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B2A4 RID: 45732
		// (get) Token: 0x06028839 RID: 165945 RVA: 0x0058A12C File Offset: 0x0058832C
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

		// Token: 0x0602883A RID: 165946 RVA: 0x0058A168 File Offset: 0x00588368
		public static Offset<IRollBlockComponent> CreateIRollBlockComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IRollBlockComponent.AddNullMask(builder, NullMask);
			IRollBlockComponent.AddDisabled(builder, Disabled);
			return IRollBlockComponent.EndIRollBlockComponent(builder);
		}

		// Token: 0x0602883B RID: 165947 RVA: 0x0058A185 File Offset: 0x00588385
		public static void StartIRollBlockComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602883C RID: 165948 RVA: 0x0058A18E File Offset: 0x0058838E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602883D RID: 165949 RVA: 0x0058A199 File Offset: 0x00588399
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602883E RID: 165950 RVA: 0x0058A1A4 File Offset: 0x005883A4
		public static Offset<IRollBlockComponent> EndIRollBlockComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockComponent>(builder.EndTable());
		}

		// Token: 0x0602883F RID: 165951 RVA: 0x0058A1B4 File Offset: 0x005883B4
		public IRollBlockComponentT UnPack()
		{
			IRollBlockComponentT rollBlockComponentT = new IRollBlockComponentT();
			this.UnPackTo(rollBlockComponentT);
			return rollBlockComponentT;
		}

		// Token: 0x06028840 RID: 165952 RVA: 0x0058A1CF File Offset: 0x005883CF
		public void UnPackTo(IRollBlockComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028841 RID: 165953 RVA: 0x0058A1EC File Offset: 0x005883EC
		public static Offset<IRollBlockComponent> Pack(FlatBufferBuilder builder, IRollBlockComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockComponent>);
			}
			return IRollBlockComponent.CreateIRollBlockComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400FAC0 RID: 64192
		private Table __p;
	}
}
