using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A9 RID: 22697
	public struct ISceneItemAiComponent : IFlatbufferObject
	{
		// Token: 0x1700A9F3 RID: 43507
		// (get) Token: 0x060264AE RID: 156846 RVA: 0x005475A3 File Offset: 0x005457A3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060264AF RID: 156847 RVA: 0x005475B0 File Offset: 0x005457B0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060264B0 RID: 156848 RVA: 0x005475B8 File Offset: 0x005457B8
		public static ISceneItemAiComponent GetRootAsISceneItemAiComponent(ByteBuffer _bb)
		{
			return ISceneItemAiComponent.GetRootAsISceneItemAiComponent(_bb, default(ISceneItemAiComponent));
		}

		// Token: 0x060264B1 RID: 156849 RVA: 0x005475D4 File Offset: 0x005457D4
		public static ISceneItemAiComponent GetRootAsISceneItemAiComponent(ByteBuffer _bb, ISceneItemAiComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060264B2 RID: 156850 RVA: 0x005475F1 File Offset: 0x005457F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060264B3 RID: 156851 RVA: 0x00547600 File Offset: 0x00545800
		public ISceneItemAiComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9F4 RID: 43508
		// (get) Token: 0x060264B4 RID: 156852 RVA: 0x00547610 File Offset: 0x00545810
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A9F5 RID: 43509
		// (get) Token: 0x060264B5 RID: 156853 RVA: 0x00547650 File Offset: 0x00545850
		public ISceneItemPatrol? AiConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISceneItemPatrol?(default(ISceneItemPatrol).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A9F6 RID: 43510
		// (get) Token: 0x060264B6 RID: 156854 RVA: 0x005476B0 File Offset: 0x005458B0
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

		// Token: 0x060264B7 RID: 156855 RVA: 0x005476EC File Offset: 0x005458EC
		public static Offset<ISceneItemAiComponent> CreateISceneItemAiComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<ISceneItemPatrol> AiConfigOffset = default(Offset<ISceneItemPatrol>), byte NullMask = 0)
		{
			builder.StartTable(3);
			ISceneItemAiComponent.AddAiConfig(builder, AiConfigOffset);
			ISceneItemAiComponent.AddNullMask(builder, NullMask);
			ISceneItemAiComponent.AddDisabled(builder, Disabled);
			return ISceneItemAiComponent.EndISceneItemAiComponent(builder);
		}

		// Token: 0x060264B8 RID: 156856 RVA: 0x00547710 File Offset: 0x00545910
		public static void StartISceneItemAiComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060264B9 RID: 156857 RVA: 0x00547719 File Offset: 0x00545919
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060264BA RID: 156858 RVA: 0x00547724 File Offset: 0x00545924
		public static void AddAiConfig(FlatBufferBuilder builder, Offset<ISceneItemPatrol> aiConfigOffset)
		{
			builder.AddOffset(1, aiConfigOffset.Value, 0);
		}

		// Token: 0x060264BB RID: 156859 RVA: 0x00547734 File Offset: 0x00545934
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060264BC RID: 156860 RVA: 0x0054773F File Offset: 0x0054593F
		public static Offset<ISceneItemAiComponent> EndISceneItemAiComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemAiComponent>(builder.EndTable());
		}

		// Token: 0x060264BD RID: 156861 RVA: 0x0054774C File Offset: 0x0054594C
		public ISceneItemAiComponentT UnPack()
		{
			ISceneItemAiComponentT sceneItemAiComponentT = new ISceneItemAiComponentT();
			this.UnPackTo(sceneItemAiComponentT);
			return sceneItemAiComponentT;
		}

		// Token: 0x060264BE RID: 156862 RVA: 0x00547768 File Offset: 0x00545968
		public void UnPackTo(ISceneItemAiComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.AiConfig = ((this.AiConfig != null) ? this.AiConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060264BF RID: 156863 RVA: 0x005477BC File Offset: 0x005459BC
		public static Offset<ISceneItemAiComponent> Pack(FlatBufferBuilder builder, ISceneItemAiComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemAiComponent>);
			}
			Offset<ISceneItemPatrol> aiConfigOffset = (_o.AiConfig == null) ? default(Offset<ISceneItemPatrol>) : ISceneItemPatrol.Pack(builder, _o.AiConfig);
			return ISceneItemAiComponent.CreateISceneItemAiComponent(builder, _o.Disabled, aiConfigOffset, _o.NullMask);
		}

		// Token: 0x0400EE14 RID: 60948
		private Table __p;
	}
}
