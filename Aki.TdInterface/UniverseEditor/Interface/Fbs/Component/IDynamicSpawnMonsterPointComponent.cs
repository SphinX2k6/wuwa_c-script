using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005664 RID: 22116
	public struct IDynamicSpawnMonsterPointComponent : IFlatbufferObject
	{
		// Token: 0x17009EFD RID: 40701
		// (get) Token: 0x060235C0 RID: 144832 RVA: 0x004DD728 File Offset: 0x004DB928
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060235C1 RID: 144833 RVA: 0x004DD735 File Offset: 0x004DB935
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060235C2 RID: 144834 RVA: 0x004DD73C File Offset: 0x004DB93C
		public static IDynamicSpawnMonsterPointComponent GetRootAsIDynamicSpawnMonsterPointComponent(ByteBuffer _bb)
		{
			return IDynamicSpawnMonsterPointComponent.GetRootAsIDynamicSpawnMonsterPointComponent(_bb, default(IDynamicSpawnMonsterPointComponent));
		}

		// Token: 0x060235C3 RID: 144835 RVA: 0x004DD758 File Offset: 0x004DB958
		public static IDynamicSpawnMonsterPointComponent GetRootAsIDynamicSpawnMonsterPointComponent(ByteBuffer _bb, IDynamicSpawnMonsterPointComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060235C4 RID: 144836 RVA: 0x004DD775 File Offset: 0x004DB975
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060235C5 RID: 144837 RVA: 0x004DD784 File Offset: 0x004DB984
		public IDynamicSpawnMonsterPointComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009EFE RID: 40702
		// (get) Token: 0x060235C6 RID: 144838 RVA: 0x004DD794 File Offset: 0x004DB994
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009EFF RID: 40703
		// (get) Token: 0x060235C7 RID: 144839 RVA: 0x004DD7D4 File Offset: 0x004DB9D4
		public int TagId
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

		// Token: 0x17009F00 RID: 40704
		// (get) Token: 0x060235C8 RID: 144840 RVA: 0x004DD810 File Offset: 0x004DBA10
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

		// Token: 0x060235C9 RID: 144841 RVA: 0x004DD84C File Offset: 0x004DBA4C
		public static Offset<IDynamicSpawnMonsterPointComponent> CreateIDynamicSpawnMonsterPointComponent(FlatBufferBuilder builder, bool Disabled = false, int TagId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDynamicSpawnMonsterPointComponent.AddTagId(builder, TagId);
			IDynamicSpawnMonsterPointComponent.AddNullMask(builder, NullMask);
			IDynamicSpawnMonsterPointComponent.AddDisabled(builder, Disabled);
			return IDynamicSpawnMonsterPointComponent.EndIDynamicSpawnMonsterPointComponent(builder);
		}

		// Token: 0x060235CA RID: 144842 RVA: 0x004DD870 File Offset: 0x004DBA70
		public static void StartIDynamicSpawnMonsterPointComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060235CB RID: 144843 RVA: 0x004DD879 File Offset: 0x004DBA79
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060235CC RID: 144844 RVA: 0x004DD884 File Offset: 0x004DBA84
		public static void AddTagId(FlatBufferBuilder builder, int tagId)
		{
			builder.AddInt(1, tagId, 0);
		}

		// Token: 0x060235CD RID: 144845 RVA: 0x004DD88F File Offset: 0x004DBA8F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060235CE RID: 144846 RVA: 0x004DD89A File Offset: 0x004DBA9A
		public static Offset<IDynamicSpawnMonsterPointComponent> EndIDynamicSpawnMonsterPointComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSpawnMonsterPointComponent>(builder.EndTable());
		}

		// Token: 0x060235CF RID: 144847 RVA: 0x004DD8A8 File Offset: 0x004DBAA8
		public IDynamicSpawnMonsterPointComponentT UnPack()
		{
			IDynamicSpawnMonsterPointComponentT dynamicSpawnMonsterPointComponentT = new IDynamicSpawnMonsterPointComponentT();
			this.UnPackTo(dynamicSpawnMonsterPointComponentT);
			return dynamicSpawnMonsterPointComponentT;
		}

		// Token: 0x060235D0 RID: 144848 RVA: 0x004DD8C3 File Offset: 0x004DBAC3
		public void UnPackTo(IDynamicSpawnMonsterPointComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.TagId = this.TagId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060235D1 RID: 144849 RVA: 0x004DD8EC File Offset: 0x004DBAEC
		public static Offset<IDynamicSpawnMonsterPointComponent> Pack(FlatBufferBuilder builder, IDynamicSpawnMonsterPointComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicSpawnMonsterPointComponent>);
			}
			return IDynamicSpawnMonsterPointComponent.CreateIDynamicSpawnMonsterPointComponent(builder, _o.Disabled, _o.TagId, _o.NullMask);
		}

		// Token: 0x0400ED65 RID: 60773
		private Table __p;
	}
}
