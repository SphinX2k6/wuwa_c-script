using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005691 RID: 22161
	public struct IElementalHolderComponent : IFlatbufferObject
	{
		// Token: 0x17009F66 RID: 40806
		// (get) Token: 0x06023788 RID: 145288 RVA: 0x004E13E2 File Offset: 0x004DF5E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023789 RID: 145289 RVA: 0x004E13EF File Offset: 0x004DF5EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602378A RID: 145290 RVA: 0x004E13F8 File Offset: 0x004DF5F8
		public static IElementalHolderComponent GetRootAsIElementalHolderComponent(ByteBuffer _bb)
		{
			return IElementalHolderComponent.GetRootAsIElementalHolderComponent(_bb, default(IElementalHolderComponent));
		}

		// Token: 0x0602378B RID: 145291 RVA: 0x004E1414 File Offset: 0x004DF614
		public static IElementalHolderComponent GetRootAsIElementalHolderComponent(ByteBuffer _bb, IElementalHolderComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602378C RID: 145292 RVA: 0x004E1431 File Offset: 0x004DF631
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602378D RID: 145293 RVA: 0x004E1440 File Offset: 0x004DF640
		public IElementalHolderComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F67 RID: 40807
		// (get) Token: 0x0602378E RID: 145294 RVA: 0x004E1450 File Offset: 0x004DF650
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009F68 RID: 40808
		// (get) Token: 0x0602378F RID: 145295 RVA: 0x004E1490 File Offset: 0x004DF690
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

		// Token: 0x17009F69 RID: 40809
		// (get) Token: 0x06023790 RID: 145296 RVA: 0x004E14F0 File Offset: 0x004DF6F0
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

		// Token: 0x06023791 RID: 145297 RVA: 0x004E152C File Offset: 0x004DF72C
		public static Offset<IElementalHolderComponent> CreateIElementalHolderComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IElementalAbilityConfig> AbilityConfigOffset = default(Offset<IElementalAbilityConfig>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IElementalHolderComponent.AddAbilityConfig(builder, AbilityConfigOffset);
			IElementalHolderComponent.AddNullMask(builder, NullMask);
			IElementalHolderComponent.AddDisabled(builder, Disabled);
			return IElementalHolderComponent.EndIElementalHolderComponent(builder);
		}

		// Token: 0x06023792 RID: 145298 RVA: 0x004E1550 File Offset: 0x004DF750
		public static void StartIElementalHolderComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06023793 RID: 145299 RVA: 0x004E1559 File Offset: 0x004DF759
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023794 RID: 145300 RVA: 0x004E1564 File Offset: 0x004DF764
		public static void AddAbilityConfig(FlatBufferBuilder builder, Offset<IElementalAbilityConfig> abilityConfigOffset)
		{
			builder.AddOffset(1, abilityConfigOffset.Value, 0);
		}

		// Token: 0x06023795 RID: 145301 RVA: 0x004E1574 File Offset: 0x004DF774
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06023796 RID: 145302 RVA: 0x004E157F File Offset: 0x004DF77F
		public static Offset<IElementalHolderComponent> EndIElementalHolderComponent(FlatBufferBuilder builder)
		{
			return new Offset<IElementalHolderComponent>(builder.EndTable());
		}

		// Token: 0x06023797 RID: 145303 RVA: 0x004E158C File Offset: 0x004DF78C
		public IElementalHolderComponentT UnPack()
		{
			IElementalHolderComponentT elementalHolderComponentT = new IElementalHolderComponentT();
			this.UnPackTo(elementalHolderComponentT);
			return elementalHolderComponentT;
		}

		// Token: 0x06023798 RID: 145304 RVA: 0x004E15A8 File Offset: 0x004DF7A8
		public void UnPackTo(IElementalHolderComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.AbilityConfig = ((this.AbilityConfig != null) ? this.AbilityConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023799 RID: 145305 RVA: 0x004E15FC File Offset: 0x004DF7FC
		public static Offset<IElementalHolderComponent> Pack(FlatBufferBuilder builder, IElementalHolderComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalHolderComponent>);
			}
			Offset<IElementalAbilityConfig> abilityConfigOffset = (_o.AbilityConfig == null) ? default(Offset<IElementalAbilityConfig>) : IElementalAbilityConfig.Pack(builder, _o.AbilityConfig);
			return IElementalHolderComponent.CreateIElementalHolderComponent(builder, _o.Disabled, abilityConfigOffset, _o.NullMask);
		}

		// Token: 0x0400EDAB RID: 60843
		private Table __p;
	}
}
