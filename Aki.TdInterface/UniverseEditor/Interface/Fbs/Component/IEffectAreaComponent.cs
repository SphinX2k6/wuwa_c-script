using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005670 RID: 22128
	public struct IEffectAreaComponent : IFlatbufferObject
	{
		// Token: 0x17009F19 RID: 40729
		// (get) Token: 0x06023630 RID: 144944 RVA: 0x004DE314 File Offset: 0x004DC514
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023631 RID: 144945 RVA: 0x004DE321 File Offset: 0x004DC521
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023632 RID: 144946 RVA: 0x004DE328 File Offset: 0x004DC528
		public static IEffectAreaComponent GetRootAsIEffectAreaComponent(ByteBuffer _bb)
		{
			return IEffectAreaComponent.GetRootAsIEffectAreaComponent(_bb, default(IEffectAreaComponent));
		}

		// Token: 0x06023633 RID: 144947 RVA: 0x004DE344 File Offset: 0x004DC544
		public static IEffectAreaComponent GetRootAsIEffectAreaComponent(ByteBuffer _bb, IEffectAreaComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023634 RID: 144948 RVA: 0x004DE361 File Offset: 0x004DC561
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023635 RID: 144949 RVA: 0x004DE370 File Offset: 0x004DC570
		public IEffectAreaComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F1A RID: 40730
		// (get) Token: 0x06023636 RID: 144950 RVA: 0x004DE380 File Offset: 0x004DC580
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009F1B RID: 40731
		// (get) Token: 0x06023637 RID: 144951 RVA: 0x004DE3C0 File Offset: 0x004DC5C0
		public IBuffArea? Config
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IBuffArea?(default(IBuffArea).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009F1C RID: 40732
		// (get) Token: 0x06023638 RID: 144952 RVA: 0x004DE420 File Offset: 0x004DC620
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

		// Token: 0x06023639 RID: 144953 RVA: 0x004DE45C File Offset: 0x004DC65C
		public static Offset<IEffectAreaComponent> CreateIEffectAreaComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IBuffArea> ConfigOffset = default(Offset<IBuffArea>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IEffectAreaComponent.AddConfig(builder, ConfigOffset);
			IEffectAreaComponent.AddNullMask(builder, NullMask);
			IEffectAreaComponent.AddDisabled(builder, Disabled);
			return IEffectAreaComponent.EndIEffectAreaComponent(builder);
		}

		// Token: 0x0602363A RID: 144954 RVA: 0x004DE480 File Offset: 0x004DC680
		public static void StartIEffectAreaComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602363B RID: 144955 RVA: 0x004DE489 File Offset: 0x004DC689
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602363C RID: 144956 RVA: 0x004DE494 File Offset: 0x004DC694
		public static void AddConfig(FlatBufferBuilder builder, Offset<IBuffArea> configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x0602363D RID: 144957 RVA: 0x004DE4A4 File Offset: 0x004DC6A4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602363E RID: 144958 RVA: 0x004DE4AF File Offset: 0x004DC6AF
		public static Offset<IEffectAreaComponent> EndIEffectAreaComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEffectAreaComponent>(builder.EndTable());
		}

		// Token: 0x0602363F RID: 144959 RVA: 0x004DE4BC File Offset: 0x004DC6BC
		public IEffectAreaComponentT UnPack()
		{
			IEffectAreaComponentT effectAreaComponentT = new IEffectAreaComponentT();
			this.UnPackTo(effectAreaComponentT);
			return effectAreaComponentT;
		}

		// Token: 0x06023640 RID: 144960 RVA: 0x004DE4D8 File Offset: 0x004DC6D8
		public void UnPackTo(IEffectAreaComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023641 RID: 144961 RVA: 0x004DE52C File Offset: 0x004DC72C
		public static Offset<IEffectAreaComponent> Pack(FlatBufferBuilder builder, IEffectAreaComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectAreaComponent>);
			}
			Offset<IBuffArea> configOffset = (_o.Config == null) ? default(Offset<IBuffArea>) : IBuffArea.Pack(builder, _o.Config);
			return IEffectAreaComponent.CreateIEffectAreaComponent(builder, _o.Disabled, configOffset, _o.NullMask);
		}

		// Token: 0x0400ED75 RID: 60789
		private Table __p;
	}
}
