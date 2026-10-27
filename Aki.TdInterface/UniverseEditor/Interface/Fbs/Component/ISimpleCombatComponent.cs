using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005911 RID: 22801
	public struct ISimpleCombatComponent : IFlatbufferObject
	{
		// Token: 0x1700AAE7 RID: 43751
		// (get) Token: 0x0602688C RID: 157836 RVA: 0x0054EF04 File Offset: 0x0054D104
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602688D RID: 157837 RVA: 0x0054EF11 File Offset: 0x0054D111
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602688E RID: 157838 RVA: 0x0054EF18 File Offset: 0x0054D118
		public static ISimpleCombatComponent GetRootAsISimpleCombatComponent(ByteBuffer _bb)
		{
			return ISimpleCombatComponent.GetRootAsISimpleCombatComponent(_bb, default(ISimpleCombatComponent));
		}

		// Token: 0x0602688F RID: 157839 RVA: 0x0054EF34 File Offset: 0x0054D134
		public static ISimpleCombatComponent GetRootAsISimpleCombatComponent(ByteBuffer _bb, ISimpleCombatComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026890 RID: 157840 RVA: 0x0054EF51 File Offset: 0x0054D151
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026891 RID: 157841 RVA: 0x0054EF60 File Offset: 0x0054D160
		public ISimpleCombatComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AAE8 RID: 43752
		// (get) Token: 0x06026892 RID: 157842 RVA: 0x0054EF70 File Offset: 0x0054D170
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AAE9 RID: 43753
		// (get) Token: 0x06026893 RID: 157843 RVA: 0x0054EFB0 File Offset: 0x0054D1B0
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

		// Token: 0x1700AAEA RID: 43754
		// (get) Token: 0x06026894 RID: 157844 RVA: 0x0054EFEC File Offset: 0x0054D1EC
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

		// Token: 0x06026895 RID: 157845 RVA: 0x0054F028 File Offset: 0x0054D228
		public static Offset<ISimpleCombatComponent> CreateISimpleCombatComponent(FlatBufferBuilder builder, bool Disabled = false, int Id = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISimpleCombatComponent.AddId(builder, Id);
			ISimpleCombatComponent.AddNullMask(builder, NullMask);
			ISimpleCombatComponent.AddDisabled(builder, Disabled);
			return ISimpleCombatComponent.EndISimpleCombatComponent(builder);
		}

		// Token: 0x06026896 RID: 157846 RVA: 0x0054F04C File Offset: 0x0054D24C
		public static void StartISimpleCombatComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026897 RID: 157847 RVA: 0x0054F055 File Offset: 0x0054D255
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026898 RID: 157848 RVA: 0x0054F060 File Offset: 0x0054D260
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06026899 RID: 157849 RVA: 0x0054F06B File Offset: 0x0054D26B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602689A RID: 157850 RVA: 0x0054F076 File Offset: 0x0054D276
		public static Offset<ISimpleCombatComponent> EndISimpleCombatComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISimpleCombatComponent>(builder.EndTable());
		}

		// Token: 0x0602689B RID: 157851 RVA: 0x0054F084 File Offset: 0x0054D284
		public ISimpleCombatComponentT UnPack()
		{
			ISimpleCombatComponentT simpleCombatComponentT = new ISimpleCombatComponentT();
			this.UnPackTo(simpleCombatComponentT);
			return simpleCombatComponentT;
		}

		// Token: 0x0602689C RID: 157852 RVA: 0x0054F09F File Offset: 0x0054D29F
		public void UnPackTo(ISimpleCombatComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Id = this.Id;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602689D RID: 157853 RVA: 0x0054F0C8 File Offset: 0x0054D2C8
		public static Offset<ISimpleCombatComponent> Pack(FlatBufferBuilder builder, ISimpleCombatComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISimpleCombatComponent>);
			}
			return ISimpleCombatComponent.CreateISimpleCombatComponent(builder, _o.Disabled, _o.Id, _o.NullMask);
		}

		// Token: 0x0400EEB3 RID: 61107
		private Table __p;
	}
}
