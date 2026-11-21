using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F6 RID: 22518
	public struct IFollowDecorationComponent : IFlatbufferObject
	{
		// Token: 0x1700A2F4 RID: 41716
		// (get) Token: 0x060246A0 RID: 149152 RVA: 0x00501168 File Offset: 0x004FF368
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060246A1 RID: 149153 RVA: 0x00501175 File Offset: 0x004FF375
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060246A2 RID: 149154 RVA: 0x0050117C File Offset: 0x004FF37C
		public static IFollowDecorationComponent GetRootAsIFollowDecorationComponent(ByteBuffer _bb)
		{
			return IFollowDecorationComponent.GetRootAsIFollowDecorationComponent(_bb, default(IFollowDecorationComponent));
		}

		// Token: 0x060246A3 RID: 149155 RVA: 0x00501198 File Offset: 0x004FF398
		public static IFollowDecorationComponent GetRootAsIFollowDecorationComponent(ByteBuffer _bb, IFollowDecorationComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060246A4 RID: 149156 RVA: 0x005011B5 File Offset: 0x004FF3B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060246A5 RID: 149157 RVA: 0x005011C4 File Offset: 0x004FF3C4
		public IFollowDecorationComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2F5 RID: 41717
		// (get) Token: 0x060246A6 RID: 149158 RVA: 0x005011D4 File Offset: 0x004FF3D4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A2F6 RID: 41718
		// (get) Token: 0x060246A7 RID: 149159 RVA: 0x00501214 File Offset: 0x004FF414
		public IFollowDecorationChairConfig? DecorationConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IFollowDecorationChairConfig?(default(IFollowDecorationChairConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A2F7 RID: 41719
		// (get) Token: 0x060246A8 RID: 149160 RVA: 0x00501274 File Offset: 0x004FF474
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

		// Token: 0x060246A9 RID: 149161 RVA: 0x005012B0 File Offset: 0x004FF4B0
		public static Offset<IFollowDecorationComponent> CreateIFollowDecorationComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IFollowDecorationChairConfig> DecorationConfigOffset = default(Offset<IFollowDecorationChairConfig>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IFollowDecorationComponent.AddDecorationConfig(builder, DecorationConfigOffset);
			IFollowDecorationComponent.AddNullMask(builder, NullMask);
			IFollowDecorationComponent.AddDisabled(builder, Disabled);
			return IFollowDecorationComponent.EndIFollowDecorationComponent(builder);
		}

		// Token: 0x060246AA RID: 149162 RVA: 0x005012D4 File Offset: 0x004FF4D4
		public static void StartIFollowDecorationComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060246AB RID: 149163 RVA: 0x005012DD File Offset: 0x004FF4DD
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060246AC RID: 149164 RVA: 0x005012E8 File Offset: 0x004FF4E8
		public static void AddDecorationConfig(FlatBufferBuilder builder, Offset<IFollowDecorationChairConfig> decorationConfigOffset)
		{
			builder.AddOffset(1, decorationConfigOffset.Value, 0);
		}

		// Token: 0x060246AD RID: 149165 RVA: 0x005012F8 File Offset: 0x004FF4F8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060246AE RID: 149166 RVA: 0x00501303 File Offset: 0x004FF503
		public static Offset<IFollowDecorationComponent> EndIFollowDecorationComponent(FlatBufferBuilder builder)
		{
			return new Offset<IFollowDecorationComponent>(builder.EndTable());
		}

		// Token: 0x060246AF RID: 149167 RVA: 0x00501310 File Offset: 0x004FF510
		public IFollowDecorationComponentT UnPack()
		{
			IFollowDecorationComponentT followDecorationComponentT = new IFollowDecorationComponentT();
			this.UnPackTo(followDecorationComponentT);
			return followDecorationComponentT;
		}

		// Token: 0x060246B0 RID: 149168 RVA: 0x0050132C File Offset: 0x004FF52C
		public void UnPackTo(IFollowDecorationComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.DecorationConfig = ((this.DecorationConfig != null) ? this.DecorationConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060246B1 RID: 149169 RVA: 0x00501380 File Offset: 0x004FF580
		public static Offset<IFollowDecorationComponent> Pack(FlatBufferBuilder builder, IFollowDecorationComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowDecorationComponent>);
			}
			Offset<IFollowDecorationChairConfig> decorationConfigOffset = (_o.DecorationConfig == null) ? default(Offset<IFollowDecorationChairConfig>) : IFollowDecorationChairConfig.Pack(builder, _o.DecorationConfig);
			return IFollowDecorationComponent.CreateIFollowDecorationComponent(builder, _o.Disabled, decorationConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F001 RID: 61441
		private Table __p;
	}
}
