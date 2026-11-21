using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005649 RID: 22089
	public struct IDynamicLevelPlayComponent : IFlatbufferObject
	{
		// Token: 0x17009EAB RID: 40619
		// (get) Token: 0x060234A7 RID: 144551 RVA: 0x004DB052 File Offset: 0x004D9252
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060234A8 RID: 144552 RVA: 0x004DB05F File Offset: 0x004D925F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060234A9 RID: 144553 RVA: 0x004DB068 File Offset: 0x004D9268
		public static IDynamicLevelPlayComponent GetRootAsIDynamicLevelPlayComponent(ByteBuffer _bb)
		{
			return IDynamicLevelPlayComponent.GetRootAsIDynamicLevelPlayComponent(_bb, default(IDynamicLevelPlayComponent));
		}

		// Token: 0x060234AA RID: 144554 RVA: 0x004DB084 File Offset: 0x004D9284
		public static IDynamicLevelPlayComponent GetRootAsIDynamicLevelPlayComponent(ByteBuffer _bb, IDynamicLevelPlayComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060234AB RID: 144555 RVA: 0x004DB0A1 File Offset: 0x004D92A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060234AC RID: 144556 RVA: 0x004DB0B0 File Offset: 0x004D92B0
		public IDynamicLevelPlayComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009EAC RID: 40620
		// (get) Token: 0x060234AD RID: 144557 RVA: 0x004DB0C0 File Offset: 0x004D92C0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009EAD RID: 40621
		// (get) Token: 0x060234AE RID: 144558 RVA: 0x004DB100 File Offset: 0x004D9300
		public int DynamicLevelPlayId
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

		// Token: 0x17009EAE RID: 40622
		// (get) Token: 0x060234AF RID: 144559 RVA: 0x004DB13C File Offset: 0x004D933C
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

		// Token: 0x060234B0 RID: 144560 RVA: 0x004DB178 File Offset: 0x004D9378
		public static Offset<IDynamicLevelPlayComponent> CreateIDynamicLevelPlayComponent(FlatBufferBuilder builder, bool Disabled = false, int DynamicLevelPlayId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDynamicLevelPlayComponent.AddDynamicLevelPlayId(builder, DynamicLevelPlayId);
			IDynamicLevelPlayComponent.AddNullMask(builder, NullMask);
			IDynamicLevelPlayComponent.AddDisabled(builder, Disabled);
			return IDynamicLevelPlayComponent.EndIDynamicLevelPlayComponent(builder);
		}

		// Token: 0x060234B1 RID: 144561 RVA: 0x004DB19C File Offset: 0x004D939C
		public static void StartIDynamicLevelPlayComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060234B2 RID: 144562 RVA: 0x004DB1A5 File Offset: 0x004D93A5
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060234B3 RID: 144563 RVA: 0x004DB1B0 File Offset: 0x004D93B0
		public static void AddDynamicLevelPlayId(FlatBufferBuilder builder, int dynamicLevelPlayId)
		{
			builder.AddInt(1, dynamicLevelPlayId, 0);
		}

		// Token: 0x060234B4 RID: 144564 RVA: 0x004DB1BB File Offset: 0x004D93BB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060234B5 RID: 144565 RVA: 0x004DB1C6 File Offset: 0x004D93C6
		public static Offset<IDynamicLevelPlayComponent> EndIDynamicLevelPlayComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicLevelPlayComponent>(builder.EndTable());
		}

		// Token: 0x060234B6 RID: 144566 RVA: 0x004DB1D4 File Offset: 0x004D93D4
		public IDynamicLevelPlayComponentT UnPack()
		{
			IDynamicLevelPlayComponentT dynamicLevelPlayComponentT = new IDynamicLevelPlayComponentT();
			this.UnPackTo(dynamicLevelPlayComponentT);
			return dynamicLevelPlayComponentT;
		}

		// Token: 0x060234B7 RID: 144567 RVA: 0x004DB1EF File Offset: 0x004D93EF
		public void UnPackTo(IDynamicLevelPlayComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.DynamicLevelPlayId = this.DynamicLevelPlayId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060234B8 RID: 144568 RVA: 0x004DB218 File Offset: 0x004D9418
		public static Offset<IDynamicLevelPlayComponent> Pack(FlatBufferBuilder builder, IDynamicLevelPlayComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicLevelPlayComponent>);
			}
			return IDynamicLevelPlayComponent.CreateIDynamicLevelPlayComponent(builder, _o.Disabled, _o.DynamicLevelPlayId, _o.NullMask);
		}

		// Token: 0x0400ED33 RID: 60723
		private Table __p;
	}
}
