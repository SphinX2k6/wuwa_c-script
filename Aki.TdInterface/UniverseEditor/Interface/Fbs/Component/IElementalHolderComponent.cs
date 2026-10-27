using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200512C RID: 20780
	public struct IElementalHolderComponent : IFlatbufferObject
	{
		// Token: 0x17009779 RID: 38777
		// (get) Token: 0x06021834 RID: 137268 RVA: 0x004A7456 File Offset: 0x004A5656
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021835 RID: 137269 RVA: 0x004A7463 File Offset: 0x004A5663
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021836 RID: 137270 RVA: 0x004A746C File Offset: 0x004A566C
		public static IElementalHolderComponent GetRootAsIElementalHolderComponent(ByteBuffer _bb)
		{
			return IElementalHolderComponent.GetRootAsIElementalHolderComponent(_bb, default(IElementalHolderComponent));
		}

		// Token: 0x06021837 RID: 137271 RVA: 0x004A7488 File Offset: 0x004A5688
		public static IElementalHolderComponent GetRootAsIElementalHolderComponent(ByteBuffer _bb, IElementalHolderComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021838 RID: 137272 RVA: 0x004A74A5 File Offset: 0x004A56A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021839 RID: 137273 RVA: 0x004A74B4 File Offset: 0x004A56B4
		public IElementalHolderComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700977A RID: 38778
		// (get) Token: 0x0602183A RID: 137274 RVA: 0x004A74C4 File Offset: 0x004A56C4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700977B RID: 38779
		// (get) Token: 0x0602183B RID: 137275 RVA: 0x004A7504 File Offset: 0x004A5704
		public IElementalAbilityConfig? AbilityConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IElementalAbilityConfig?(default(IElementalAbilityConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700977C RID: 38780
		// (get) Token: 0x0602183C RID: 137276 RVA: 0x004A7564 File Offset: 0x004A5764
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

		// Token: 0x0602183D RID: 137277 RVA: 0x004A75A0 File Offset: 0x004A57A0
		public static Offset<IElementalHolderComponent> CreateIElementalHolderComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IElementalAbilityConfig> AbilityConfigOffset = default(Offset<IElementalAbilityConfig>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IElementalHolderComponent.AddAbilityConfig(builder, AbilityConfigOffset);
			IElementalHolderComponent.AddNullMask(builder, NullMask);
			IElementalHolderComponent.AddDisabled(builder, Disabled);
			return IElementalHolderComponent.EndIElementalHolderComponent(builder);
		}

		// Token: 0x0602183E RID: 137278 RVA: 0x004A75C4 File Offset: 0x004A57C4
		public static void StartIElementalHolderComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602183F RID: 137279 RVA: 0x004A75CD File Offset: 0x004A57CD
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021840 RID: 137280 RVA: 0x004A75D8 File Offset: 0x004A57D8
		public static void AddAbilityConfig(FlatBufferBuilder builder, Offset<IElementalAbilityConfig> abilityConfigOffset)
		{
			builder.AddOffset(1, abilityConfigOffset.Value, 0);
		}

		// Token: 0x06021841 RID: 137281 RVA: 0x004A75E8 File Offset: 0x004A57E8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06021842 RID: 137282 RVA: 0x004A75F3 File Offset: 0x004A57F3
		public static Offset<IElementalHolderComponent> EndIElementalHolderComponent(FlatBufferBuilder builder)
		{
			return new Offset<IElementalHolderComponent>(builder.EndTable());
		}

		// Token: 0x06021843 RID: 137283 RVA: 0x004A7600 File Offset: 0x004A5800
		public IElementalHolderComponentT UnPack()
		{
			IElementalHolderComponentT elementalHolderComponentT = new IElementalHolderComponentT();
			this.UnPackTo(elementalHolderComponentT);
			return elementalHolderComponentT;
		}

		// Token: 0x06021844 RID: 137284 RVA: 0x004A761C File Offset: 0x004A581C
		public void UnPackTo(IElementalHolderComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.AbilityConfig = ((this.AbilityConfig != null) ? this.AbilityConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021845 RID: 137285 RVA: 0x004A7670 File Offset: 0x004A5870
		public static Offset<IElementalHolderComponent> Pack(FlatBufferBuilder builder, IElementalHolderComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalHolderComponent>);
			}
			Offset<IElementalAbilityConfig> abilityConfigOffset = (_o.AbilityConfig == null) ? default(Offset<IElementalAbilityConfig>) : IElementalAbilityConfig.Pack(builder, _o.AbilityConfig);
			return IElementalHolderComponent.CreateIElementalHolderComponent(builder, _o.Disabled, abilityConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E1AE RID: 57774
		private Table __p;
	}
}
