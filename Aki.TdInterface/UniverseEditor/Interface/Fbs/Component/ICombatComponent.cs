using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FC4 RID: 20420
	public struct ICombatComponent : IFlatbufferObject
	{
		// Token: 0x170093E2 RID: 37858
		// (get) Token: 0x0602081D RID: 133149 RVA: 0x004857BA File Offset: 0x004839BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602081E RID: 133150 RVA: 0x004857C7 File Offset: 0x004839C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602081F RID: 133151 RVA: 0x004857D0 File Offset: 0x004839D0
		public static ICombatComponent GetRootAsICombatComponent(ByteBuffer _bb)
		{
			return ICombatComponent.GetRootAsICombatComponent(_bb, default(ICombatComponent));
		}

		// Token: 0x06020820 RID: 133152 RVA: 0x004857EC File Offset: 0x004839EC
		public static ICombatComponent GetRootAsICombatComponent(ByteBuffer _bb, ICombatComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020821 RID: 133153 RVA: 0x00485809 File Offset: 0x00483A09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020822 RID: 133154 RVA: 0x00485818 File Offset: 0x00483A18
		public ICombatComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093E3 RID: 37859
		// (get) Token: 0x06020823 RID: 133155 RVA: 0x00485828 File Offset: 0x00483A28
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170093E4 RID: 37860
		// (get) Token: 0x06020824 RID: 133156 RVA: 0x00485868 File Offset: 0x00483A68
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

		// Token: 0x06020825 RID: 133157 RVA: 0x004858A4 File Offset: 0x00483AA4
		public static Offset<ICombatComponent> CreateICombatComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			ICombatComponent.AddNullMask(builder, NullMask);
			ICombatComponent.AddDisabled(builder, Disabled);
			return ICombatComponent.EndICombatComponent(builder);
		}

		// Token: 0x06020826 RID: 133158 RVA: 0x004858C1 File Offset: 0x00483AC1
		public static void StartICombatComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020827 RID: 133159 RVA: 0x004858CA File Offset: 0x00483ACA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06020828 RID: 133160 RVA: 0x004858D5 File Offset: 0x00483AD5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06020829 RID: 133161 RVA: 0x004858E0 File Offset: 0x00483AE0
		public static Offset<ICombatComponent> EndICombatComponent(FlatBufferBuilder builder)
		{
			return new Offset<ICombatComponent>(builder.EndTable());
		}

		// Token: 0x0602082A RID: 133162 RVA: 0x004858F0 File Offset: 0x00483AF0
		public ICombatComponentT UnPack()
		{
			ICombatComponentT combatComponentT = new ICombatComponentT();
			this.UnPackTo(combatComponentT);
			return combatComponentT;
		}

		// Token: 0x0602082B RID: 133163 RVA: 0x0048590B File Offset: 0x00483B0B
		public void UnPackTo(ICombatComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602082C RID: 133164 RVA: 0x00485928 File Offset: 0x00483B28
		public static Offset<ICombatComponent> Pack(FlatBufferBuilder builder, ICombatComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICombatComponent>);
			}
			return ICombatComponent.CreateICombatComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400DEA2 RID: 56994
		private Table __p;
	}
}
