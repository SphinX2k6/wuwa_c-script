using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005520 RID: 21792
	public struct ICombatComponent : IFlatbufferObject
	{
		// Token: 0x17009BBA RID: 39866
		// (get) Token: 0x06022711 RID: 141073 RVA: 0x004BEC9E File Offset: 0x004BCE9E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022712 RID: 141074 RVA: 0x004BECAB File Offset: 0x004BCEAB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022713 RID: 141075 RVA: 0x004BECB4 File Offset: 0x004BCEB4
		public static ICombatComponent GetRootAsICombatComponent(ByteBuffer _bb)
		{
			return ICombatComponent.GetRootAsICombatComponent(_bb, default(ICombatComponent));
		}

		// Token: 0x06022714 RID: 141076 RVA: 0x004BECD0 File Offset: 0x004BCED0
		public static ICombatComponent GetRootAsICombatComponent(ByteBuffer _bb, ICombatComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022715 RID: 141077 RVA: 0x004BECED File Offset: 0x004BCEED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022716 RID: 141078 RVA: 0x004BECFC File Offset: 0x004BCEFC
		public ICombatComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BBB RID: 39867
		// (get) Token: 0x06022717 RID: 141079 RVA: 0x004BED0C File Offset: 0x004BCF0C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009BBC RID: 39868
		// (get) Token: 0x06022718 RID: 141080 RVA: 0x004BED4C File Offset: 0x004BCF4C
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

		// Token: 0x06022719 RID: 141081 RVA: 0x004BED88 File Offset: 0x004BCF88
		public static Offset<ICombatComponent> CreateICombatComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			ICombatComponent.AddNullMask(builder, NullMask);
			ICombatComponent.AddDisabled(builder, Disabled);
			return ICombatComponent.EndICombatComponent(builder);
		}

		// Token: 0x0602271A RID: 141082 RVA: 0x004BEDA5 File Offset: 0x004BCFA5
		public static void StartICombatComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602271B RID: 141083 RVA: 0x004BEDAE File Offset: 0x004BCFAE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602271C RID: 141084 RVA: 0x004BEDB9 File Offset: 0x004BCFB9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602271D RID: 141085 RVA: 0x004BEDC4 File Offset: 0x004BCFC4
		public static Offset<ICombatComponent> EndICombatComponent(FlatBufferBuilder builder)
		{
			return new Offset<ICombatComponent>(builder.EndTable());
		}

		// Token: 0x0602271E RID: 141086 RVA: 0x004BEDD4 File Offset: 0x004BCFD4
		public ICombatComponentT UnPack()
		{
			ICombatComponentT combatComponentT = new ICombatComponentT();
			this.UnPackTo(combatComponentT);
			return combatComponentT;
		}

		// Token: 0x0602271F RID: 141087 RVA: 0x004BEDEF File Offset: 0x004BCFEF
		public void UnPackTo(ICombatComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022720 RID: 141088 RVA: 0x004BEE0C File Offset: 0x004BD00C
		public static Offset<ICombatComponent> Pack(FlatBufferBuilder builder, ICombatComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICombatComponent>);
			}
			return ICombatComponent.CreateICombatComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400EA90 RID: 60048
		private Table __p;
	}
}
