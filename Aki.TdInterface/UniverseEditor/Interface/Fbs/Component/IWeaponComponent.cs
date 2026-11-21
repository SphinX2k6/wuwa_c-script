using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200617E RID: 24958
	public struct IWeaponComponent : IFlatbufferObject
	{
		// Token: 0x1700BA0F RID: 47631
		// (get) Token: 0x0602A667 RID: 173671 RVA: 0x005C8EBC File Offset: 0x005C70BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A668 RID: 173672 RVA: 0x005C8EC9 File Offset: 0x005C70C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A669 RID: 173673 RVA: 0x005C8ED0 File Offset: 0x005C70D0
		public static IWeaponComponent GetRootAsIWeaponComponent(ByteBuffer _bb)
		{
			return IWeaponComponent.GetRootAsIWeaponComponent(_bb, default(IWeaponComponent));
		}

		// Token: 0x0602A66A RID: 173674 RVA: 0x005C8EEC File Offset: 0x005C70EC
		public static IWeaponComponent GetRootAsIWeaponComponent(ByteBuffer _bb, IWeaponComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A66B RID: 173675 RVA: 0x005C8F09 File Offset: 0x005C7109
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A66C RID: 173676 RVA: 0x005C8F18 File Offset: 0x005C7118
		public IWeaponComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA10 RID: 47632
		// (get) Token: 0x0602A66D RID: 173677 RVA: 0x005C8F28 File Offset: 0x005C7128
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BA11 RID: 47633
		// (get) Token: 0x0602A66E RID: 173678 RVA: 0x005C8F68 File Offset: 0x005C7168
		public int WeaponId
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

		// Token: 0x1700BA12 RID: 47634
		// (get) Token: 0x0602A66F RID: 173679 RVA: 0x005C8FA4 File Offset: 0x005C71A4
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

		// Token: 0x0602A670 RID: 173680 RVA: 0x005C8FE0 File Offset: 0x005C71E0
		public static Offset<IWeaponComponent> CreateIWeaponComponent(FlatBufferBuilder builder, bool Disabled = false, int WeaponId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IWeaponComponent.AddWeaponId(builder, WeaponId);
			IWeaponComponent.AddNullMask(builder, NullMask);
			IWeaponComponent.AddDisabled(builder, Disabled);
			return IWeaponComponent.EndIWeaponComponent(builder);
		}

		// Token: 0x0602A671 RID: 173681 RVA: 0x005C9004 File Offset: 0x005C7204
		public static void StartIWeaponComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A672 RID: 173682 RVA: 0x005C900D File Offset: 0x005C720D
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A673 RID: 173683 RVA: 0x005C9018 File Offset: 0x005C7218
		public static void AddWeaponId(FlatBufferBuilder builder, int weaponId)
		{
			builder.AddInt(1, weaponId, 0);
		}

		// Token: 0x0602A674 RID: 173684 RVA: 0x005C9023 File Offset: 0x005C7223
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602A675 RID: 173685 RVA: 0x005C902E File Offset: 0x005C722E
		public static Offset<IWeaponComponent> EndIWeaponComponent(FlatBufferBuilder builder)
		{
			return new Offset<IWeaponComponent>(builder.EndTable());
		}

		// Token: 0x0602A676 RID: 173686 RVA: 0x005C903C File Offset: 0x005C723C
		public IWeaponComponentT UnPack()
		{
			IWeaponComponentT weaponComponentT = new IWeaponComponentT();
			this.UnPackTo(weaponComponentT);
			return weaponComponentT;
		}

		// Token: 0x0602A677 RID: 173687 RVA: 0x005C9057 File Offset: 0x005C7257
		public void UnPackTo(IWeaponComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.WeaponId = this.WeaponId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A678 RID: 173688 RVA: 0x005C9080 File Offset: 0x005C7280
		public static Offset<IWeaponComponent> Pack(FlatBufferBuilder builder, IWeaponComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWeaponComponent>);
			}
			return IWeaponComponent.CreateIWeaponComponent(builder, _o.Disabled, _o.WeaponId, _o.NullMask);
		}

		// Token: 0x0400FFBC RID: 65468
		private Table __p;
	}
}
