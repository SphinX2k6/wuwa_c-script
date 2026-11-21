using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005667 RID: 22119
	public struct IDynamicTeleportComponent : IFlatbufferObject
	{
		// Token: 0x17009F04 RID: 40708
		// (get) Token: 0x060235DA RID: 144858 RVA: 0x004DD9BC File Offset: 0x004DBBBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060235DB RID: 144859 RVA: 0x004DD9C9 File Offset: 0x004DBBC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060235DC RID: 144860 RVA: 0x004DD9D0 File Offset: 0x004DBBD0
		public static IDynamicTeleportComponent GetRootAsIDynamicTeleportComponent(ByteBuffer _bb)
		{
			return IDynamicTeleportComponent.GetRootAsIDynamicTeleportComponent(_bb, default(IDynamicTeleportComponent));
		}

		// Token: 0x060235DD RID: 144861 RVA: 0x004DD9EC File Offset: 0x004DBBEC
		public static IDynamicTeleportComponent GetRootAsIDynamicTeleportComponent(ByteBuffer _bb, IDynamicTeleportComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060235DE RID: 144862 RVA: 0x004DDA09 File Offset: 0x004DBC09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060235DF RID: 144863 RVA: 0x004DDA18 File Offset: 0x004DBC18
		public IDynamicTeleportComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F05 RID: 40709
		// (get) Token: 0x060235E0 RID: 144864 RVA: 0x004DDA28 File Offset: 0x004DBC28
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009F06 RID: 40710
		// (get) Token: 0x060235E1 RID: 144865 RVA: 0x004DDA68 File Offset: 0x004DBC68
		public IPosA? Offset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009F07 RID: 40711
		// (get) Token: 0x060235E2 RID: 144866 RVA: 0x004DDAC8 File Offset: 0x004DBCC8
		public int PhantomSkillId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F08 RID: 40712
		// (get) Token: 0x060235E3 RID: 144867 RVA: 0x004DDB04 File Offset: 0x004DBD04
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060235E4 RID: 144868 RVA: 0x004DDB41 File Offset: 0x004DBD41
		public static Offset<IDynamicTeleportComponent> CreateIDynamicTeleportComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IPosA> OffsetOffset = default(Offset<IPosA>), int PhantomSkillId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDynamicTeleportComponent.AddPhantomSkillId(builder, PhantomSkillId);
			IDynamicTeleportComponent.AddOffset(builder, OffsetOffset);
			IDynamicTeleportComponent.AddNullMask(builder, NullMask);
			IDynamicTeleportComponent.AddDisabled(builder, Disabled);
			return IDynamicTeleportComponent.EndIDynamicTeleportComponent(builder);
		}

		// Token: 0x060235E5 RID: 144869 RVA: 0x004DDB6D File Offset: 0x004DBD6D
		public static void StartIDynamicTeleportComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060235E6 RID: 144870 RVA: 0x004DDB76 File Offset: 0x004DBD76
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060235E7 RID: 144871 RVA: 0x004DDB81 File Offset: 0x004DBD81
		public static void AddOffset(FlatBufferBuilder builder, Offset<IPosA> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x060235E8 RID: 144872 RVA: 0x004DDB91 File Offset: 0x004DBD91
		public static void AddPhantomSkillId(FlatBufferBuilder builder, int phantomSkillId)
		{
			builder.AddInt(2, phantomSkillId, 0);
		}

		// Token: 0x060235E9 RID: 144873 RVA: 0x004DDB9C File Offset: 0x004DBD9C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060235EA RID: 144874 RVA: 0x004DDBA7 File Offset: 0x004DBDA7
		public static Offset<IDynamicTeleportComponent> EndIDynamicTeleportComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicTeleportComponent>(builder.EndTable());
		}

		// Token: 0x060235EB RID: 144875 RVA: 0x004DDBB4 File Offset: 0x004DBDB4
		public IDynamicTeleportComponentT UnPack()
		{
			IDynamicTeleportComponentT dynamicTeleportComponentT = new IDynamicTeleportComponentT();
			this.UnPackTo(dynamicTeleportComponentT);
			return dynamicTeleportComponentT;
		}

		// Token: 0x060235EC RID: 144876 RVA: 0x004DDBD0 File Offset: 0x004DBDD0
		public void UnPackTo(IDynamicTeleportComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.PhantomSkillId = this.PhantomSkillId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060235ED RID: 144877 RVA: 0x004DDC30 File Offset: 0x004DBE30
		public static Offset<IDynamicTeleportComponent> Pack(FlatBufferBuilder builder, IDynamicTeleportComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicTeleportComponent>);
			}
			Offset<IPosA> offsetOffset = (_o.Offset == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Offset);
			return IDynamicTeleportComponent.CreateIDynamicTeleportComponent(builder, _o.Disabled, offsetOffset, _o.PhantomSkillId, _o.NullMask);
		}

		// Token: 0x0400ED69 RID: 60777
		private Table __p;
	}
}
