using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050E4 RID: 20708
	public struct IDynamicLevelPlayComponent : IFlatbufferObject
	{
		// Token: 0x170096BE RID: 38590
		// (get) Token: 0x06021553 RID: 136531 RVA: 0x004A10C6 File Offset: 0x0049F2C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021554 RID: 136532 RVA: 0x004A10D3 File Offset: 0x0049F2D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021555 RID: 136533 RVA: 0x004A10DC File Offset: 0x0049F2DC
		public static IDynamicLevelPlayComponent GetRootAsIDynamicLevelPlayComponent(ByteBuffer _bb)
		{
			return IDynamicLevelPlayComponent.GetRootAsIDynamicLevelPlayComponent(_bb, default(IDynamicLevelPlayComponent));
		}

		// Token: 0x06021556 RID: 136534 RVA: 0x004A10F8 File Offset: 0x0049F2F8
		public static IDynamicLevelPlayComponent GetRootAsIDynamicLevelPlayComponent(ByteBuffer _bb, IDynamicLevelPlayComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021557 RID: 136535 RVA: 0x004A1115 File Offset: 0x0049F315
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021558 RID: 136536 RVA: 0x004A1124 File Offset: 0x0049F324
		public IDynamicLevelPlayComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096BF RID: 38591
		// (get) Token: 0x06021559 RID: 136537 RVA: 0x004A1134 File Offset: 0x0049F334
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170096C0 RID: 38592
		// (get) Token: 0x0602155A RID: 136538 RVA: 0x004A1174 File Offset: 0x0049F374
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

		// Token: 0x170096C1 RID: 38593
		// (get) Token: 0x0602155B RID: 136539 RVA: 0x004A11B0 File Offset: 0x0049F3B0
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

		// Token: 0x0602155C RID: 136540 RVA: 0x004A11EC File Offset: 0x0049F3EC
		public static Offset<IDynamicLevelPlayComponent> CreateIDynamicLevelPlayComponent(FlatBufferBuilder builder, bool Disabled = false, int DynamicLevelPlayId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDynamicLevelPlayComponent.AddDynamicLevelPlayId(builder, DynamicLevelPlayId);
			IDynamicLevelPlayComponent.AddNullMask(builder, NullMask);
			IDynamicLevelPlayComponent.AddDisabled(builder, Disabled);
			return IDynamicLevelPlayComponent.EndIDynamicLevelPlayComponent(builder);
		}

		// Token: 0x0602155D RID: 136541 RVA: 0x004A1210 File Offset: 0x0049F410
		public static void StartIDynamicLevelPlayComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602155E RID: 136542 RVA: 0x004A1219 File Offset: 0x0049F419
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602155F RID: 136543 RVA: 0x004A1224 File Offset: 0x0049F424
		public static void AddDynamicLevelPlayId(FlatBufferBuilder builder, int dynamicLevelPlayId)
		{
			builder.AddInt(1, dynamicLevelPlayId, 0);
		}

		// Token: 0x06021560 RID: 136544 RVA: 0x004A122F File Offset: 0x0049F42F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06021561 RID: 136545 RVA: 0x004A123A File Offset: 0x0049F43A
		public static Offset<IDynamicLevelPlayComponent> EndIDynamicLevelPlayComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicLevelPlayComponent>(builder.EndTable());
		}

		// Token: 0x06021562 RID: 136546 RVA: 0x004A1248 File Offset: 0x0049F448
		public IDynamicLevelPlayComponentT UnPack()
		{
			IDynamicLevelPlayComponentT dynamicLevelPlayComponentT = new IDynamicLevelPlayComponentT();
			this.UnPackTo(dynamicLevelPlayComponentT);
			return dynamicLevelPlayComponentT;
		}

		// Token: 0x06021563 RID: 136547 RVA: 0x004A1263 File Offset: 0x0049F463
		public void UnPackTo(IDynamicLevelPlayComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.DynamicLevelPlayId = this.DynamicLevelPlayId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021564 RID: 136548 RVA: 0x004A128C File Offset: 0x0049F48C
		public static Offset<IDynamicLevelPlayComponent> Pack(FlatBufferBuilder builder, IDynamicLevelPlayComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicLevelPlayComponent>);
			}
			return IDynamicLevelPlayComponent.CreateIDynamicLevelPlayComponent(builder, _o.Disabled, _o.DynamicLevelPlayId, _o.NullMask);
		}

		// Token: 0x0400E136 RID: 57654
		private Table __p;
	}
}
