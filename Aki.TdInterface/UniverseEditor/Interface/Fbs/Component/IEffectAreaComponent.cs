using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200510B RID: 20747
	public struct IEffectAreaComponent : IFlatbufferObject
	{
		// Token: 0x1700972C RID: 38700
		// (get) Token: 0x060216DC RID: 136924 RVA: 0x004A4388 File Offset: 0x004A2588
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060216DD RID: 136925 RVA: 0x004A4395 File Offset: 0x004A2595
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060216DE RID: 136926 RVA: 0x004A439C File Offset: 0x004A259C
		public static IEffectAreaComponent GetRootAsIEffectAreaComponent(ByteBuffer _bb)
		{
			return IEffectAreaComponent.GetRootAsIEffectAreaComponent(_bb, default(IEffectAreaComponent));
		}

		// Token: 0x060216DF RID: 136927 RVA: 0x004A43B8 File Offset: 0x004A25B8
		public static IEffectAreaComponent GetRootAsIEffectAreaComponent(ByteBuffer _bb, IEffectAreaComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060216E0 RID: 136928 RVA: 0x004A43D5 File Offset: 0x004A25D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060216E1 RID: 136929 RVA: 0x004A43E4 File Offset: 0x004A25E4
		public IEffectAreaComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700972D RID: 38701
		// (get) Token: 0x060216E2 RID: 136930 RVA: 0x004A43F4 File Offset: 0x004A25F4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700972E RID: 38702
		// (get) Token: 0x060216E3 RID: 136931 RVA: 0x004A4434 File Offset: 0x004A2634
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

		// Token: 0x1700972F RID: 38703
		// (get) Token: 0x060216E4 RID: 136932 RVA: 0x004A4494 File Offset: 0x004A2694
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

		// Token: 0x060216E5 RID: 136933 RVA: 0x004A44D0 File Offset: 0x004A26D0
		public static Offset<IEffectAreaComponent> CreateIEffectAreaComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IBuffArea> ConfigOffset = default(Offset<IBuffArea>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IEffectAreaComponent.AddConfig(builder, ConfigOffset);
			IEffectAreaComponent.AddNullMask(builder, NullMask);
			IEffectAreaComponent.AddDisabled(builder, Disabled);
			return IEffectAreaComponent.EndIEffectAreaComponent(builder);
		}

		// Token: 0x060216E6 RID: 136934 RVA: 0x004A44F4 File Offset: 0x004A26F4
		public static void StartIEffectAreaComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060216E7 RID: 136935 RVA: 0x004A44FD File Offset: 0x004A26FD
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060216E8 RID: 136936 RVA: 0x004A4508 File Offset: 0x004A2708
		public static void AddConfig(FlatBufferBuilder builder, Offset<IBuffArea> configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x060216E9 RID: 136937 RVA: 0x004A4518 File Offset: 0x004A2718
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060216EA RID: 136938 RVA: 0x004A4523 File Offset: 0x004A2723
		public static Offset<IEffectAreaComponent> EndIEffectAreaComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEffectAreaComponent>(builder.EndTable());
		}

		// Token: 0x060216EB RID: 136939 RVA: 0x004A4530 File Offset: 0x004A2730
		public IEffectAreaComponentT UnPack()
		{
			IEffectAreaComponentT effectAreaComponentT = new IEffectAreaComponentT();
			this.UnPackTo(effectAreaComponentT);
			return effectAreaComponentT;
		}

		// Token: 0x060216EC RID: 136940 RVA: 0x004A454C File Offset: 0x004A274C
		public void UnPackTo(IEffectAreaComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060216ED RID: 136941 RVA: 0x004A45A0 File Offset: 0x004A27A0
		public static Offset<IEffectAreaComponent> Pack(FlatBufferBuilder builder, IEffectAreaComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectAreaComponent>);
			}
			Offset<IBuffArea> configOffset = (_o.Config == null) ? default(Offset<IBuffArea>) : IBuffArea.Pack(builder, _o.Config);
			return IEffectAreaComponent.CreateIEffectAreaComponent(builder, _o.Disabled, configOffset, _o.NullMask);
		}

		// Token: 0x0400E178 RID: 57720
		private Table __p;
	}
}
