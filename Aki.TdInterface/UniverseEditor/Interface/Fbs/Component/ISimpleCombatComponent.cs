using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F1E RID: 24350
	public struct ISimpleCombatComponent : IFlatbufferObject
	{
		// Token: 0x1700B41B RID: 46107
		// (get) Token: 0x06028DF6 RID: 167414 RVA: 0x00595B70 File Offset: 0x00593D70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028DF7 RID: 167415 RVA: 0x00595B7D File Offset: 0x00593D7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028DF8 RID: 167416 RVA: 0x00595B84 File Offset: 0x00593D84
		public static ISimpleCombatComponent GetRootAsISimpleCombatComponent(ByteBuffer _bb)
		{
			return ISimpleCombatComponent.GetRootAsISimpleCombatComponent(_bb, default(ISimpleCombatComponent));
		}

		// Token: 0x06028DF9 RID: 167417 RVA: 0x00595BA0 File Offset: 0x00593DA0
		public static ISimpleCombatComponent GetRootAsISimpleCombatComponent(ByteBuffer _bb, ISimpleCombatComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028DFA RID: 167418 RVA: 0x00595BBD File Offset: 0x00593DBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028DFB RID: 167419 RVA: 0x00595BCC File Offset: 0x00593DCC
		public ISimpleCombatComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B41C RID: 46108
		// (get) Token: 0x06028DFC RID: 167420 RVA: 0x00595BDC File Offset: 0x00593DDC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B41D RID: 46109
		// (get) Token: 0x06028DFD RID: 167421 RVA: 0x00595C1C File Offset: 0x00593E1C
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B41E RID: 46110
		// (get) Token: 0x06028DFE RID: 167422 RVA: 0x00595C58 File Offset: 0x00593E58
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

		// Token: 0x06028DFF RID: 167423 RVA: 0x00595C94 File Offset: 0x00593E94
		public static Offset<ISimpleCombatComponent> CreateISimpleCombatComponent(FlatBufferBuilder builder, bool Disabled = false, int Id = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISimpleCombatComponent.AddId(builder, Id);
			ISimpleCombatComponent.AddNullMask(builder, NullMask);
			ISimpleCombatComponent.AddDisabled(builder, Disabled);
			return ISimpleCombatComponent.EndISimpleCombatComponent(builder);
		}

		// Token: 0x06028E00 RID: 167424 RVA: 0x00595CB8 File Offset: 0x00593EB8
		public static void StartISimpleCombatComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028E01 RID: 167425 RVA: 0x00595CC1 File Offset: 0x00593EC1
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028E02 RID: 167426 RVA: 0x00595CCC File Offset: 0x00593ECC
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06028E03 RID: 167427 RVA: 0x00595CD7 File Offset: 0x00593ED7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06028E04 RID: 167428 RVA: 0x00595CE2 File Offset: 0x00593EE2
		public static Offset<ISimpleCombatComponent> EndISimpleCombatComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISimpleCombatComponent>(builder.EndTable());
		}

		// Token: 0x06028E05 RID: 167429 RVA: 0x00595CF0 File Offset: 0x00593EF0
		public ISimpleCombatComponentT UnPack()
		{
			ISimpleCombatComponentT simpleCombatComponentT = new ISimpleCombatComponentT();
			this.UnPackTo(simpleCombatComponentT);
			return simpleCombatComponentT;
		}

		// Token: 0x06028E06 RID: 167430 RVA: 0x00595D0B File Offset: 0x00593F0B
		public void UnPackTo(ISimpleCombatComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Id = this.Id;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028E07 RID: 167431 RVA: 0x00595D34 File Offset: 0x00593F34
		public static Offset<ISimpleCombatComponent> Pack(FlatBufferBuilder builder, ISimpleCombatComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISimpleCombatComponent>);
			}
			return ISimpleCombatComponent.CreateISimpleCombatComponent(builder, _o.Disabled, _o.Id, _o.NullMask);
		}

		// Token: 0x0400FBA8 RID: 64424
		private Table __p;
	}
}
