using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E57 RID: 24151
	public struct IReignsPropertyConfig : IFlatbufferObject
	{
		// Token: 0x1700B498 RID: 46232
		// (get) Token: 0x060295BD RID: 169405 RVA: 0x005AB8D4 File Offset: 0x005A9AD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060295BE RID: 169406 RVA: 0x005AB8E1 File Offset: 0x005A9AE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060295BF RID: 169407 RVA: 0x005AB8E8 File Offset: 0x005A9AE8
		public static IReignsPropertyConfig GetRootAsIReignsPropertyConfig(ByteBuffer _bb)
		{
			return IReignsPropertyConfig.GetRootAsIReignsPropertyConfig(_bb, default(IReignsPropertyConfig));
		}

		// Token: 0x060295C0 RID: 169408 RVA: 0x005AB904 File Offset: 0x005A9B04
		public static IReignsPropertyConfig GetRootAsIReignsPropertyConfig(ByteBuffer _bb, IReignsPropertyConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060295C1 RID: 169409 RVA: 0x005AB921 File Offset: 0x005A9B21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060295C2 RID: 169410 RVA: 0x005AB930 File Offset: 0x005A9B30
		public IReignsPropertyConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B499 RID: 46233
		// (get) Token: 0x060295C3 RID: 169411 RVA: 0x005AB940 File Offset: 0x005A9B40
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B49A RID: 46234
		// (get) Token: 0x060295C4 RID: 169412 RVA: 0x005AB97C File Offset: 0x005A9B7C
		public int BaseValue
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

		// Token: 0x1700B49B RID: 46235
		// (get) Token: 0x060295C5 RID: 169413 RVA: 0x005AB9B8 File Offset: 0x005A9BB8
		public int MaxValue
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

		// Token: 0x1700B49C RID: 46236
		// (get) Token: 0x060295C6 RID: 169414 RVA: 0x005AB9F4 File Offset: 0x005A9BF4
		public bool IsDefaultEnable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060295C7 RID: 169415 RVA: 0x005ABA34 File Offset: 0x005A9C34
		public static Offset<IReignsPropertyConfig> CreateIReignsPropertyConfig(FlatBufferBuilder builder, int Id = 0, int BaseValue = 0, int MaxValue = 0, bool IsDefaultEnable = false)
		{
			builder.StartTable(4);
			IReignsPropertyConfig.AddMaxValue(builder, MaxValue);
			IReignsPropertyConfig.AddBaseValue(builder, BaseValue);
			IReignsPropertyConfig.AddId(builder, Id);
			IReignsPropertyConfig.AddIsDefaultEnable(builder, IsDefaultEnable);
			return IReignsPropertyConfig.EndIReignsPropertyConfig(builder);
		}

		// Token: 0x060295C8 RID: 169416 RVA: 0x005ABA60 File Offset: 0x005A9C60
		public static void StartIReignsPropertyConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060295C9 RID: 169417 RVA: 0x005ABA69 File Offset: 0x005A9C69
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x060295CA RID: 169418 RVA: 0x005ABA74 File Offset: 0x005A9C74
		public static void AddBaseValue(FlatBufferBuilder builder, int baseValue)
		{
			builder.AddInt(1, baseValue, 0);
		}

		// Token: 0x060295CB RID: 169419 RVA: 0x005ABA7F File Offset: 0x005A9C7F
		public static void AddMaxValue(FlatBufferBuilder builder, int maxValue)
		{
			builder.AddInt(2, maxValue, 0);
		}

		// Token: 0x060295CC RID: 169420 RVA: 0x005ABA8A File Offset: 0x005A9C8A
		public static void AddIsDefaultEnable(FlatBufferBuilder builder, bool isDefaultEnable)
		{
			builder.AddBool(3, isDefaultEnable, false);
		}

		// Token: 0x060295CD RID: 169421 RVA: 0x005ABA95 File Offset: 0x005A9C95
		public static Offset<IReignsPropertyConfig> EndIReignsPropertyConfig(FlatBufferBuilder builder)
		{
			return new Offset<IReignsPropertyConfig>(builder.EndTable());
		}

		// Token: 0x060295CE RID: 169422 RVA: 0x005ABAA4 File Offset: 0x005A9CA4
		public IReignsPropertyConfigT UnPack()
		{
			IReignsPropertyConfigT reignsPropertyConfigT = new IReignsPropertyConfigT();
			this.UnPackTo(reignsPropertyConfigT);
			return reignsPropertyConfigT;
		}

		// Token: 0x060295CF RID: 169423 RVA: 0x005ABABF File Offset: 0x005A9CBF
		public void UnPackTo(IReignsPropertyConfigT _o)
		{
			_o.Id = this.Id;
			_o.BaseValue = this.BaseValue;
			_o.MaxValue = this.MaxValue;
			_o.IsDefaultEnable = this.IsDefaultEnable;
		}

		// Token: 0x060295D0 RID: 169424 RVA: 0x005ABAF4 File Offset: 0x005A9CF4
		public static Offset<IReignsPropertyConfig> Pack(FlatBufferBuilder builder, IReignsPropertyConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsPropertyConfig>);
			}
			return IReignsPropertyConfig.CreateIReignsPropertyConfig(builder, _o.Id, _o.BaseValue, _o.MaxValue, _o.IsDefaultEnable);
		}

		// Token: 0x0400F861 RID: 63585
		private Table __p;
	}
}
