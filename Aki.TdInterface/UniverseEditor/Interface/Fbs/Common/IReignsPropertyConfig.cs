using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006497 RID: 25751
	public struct IReignsPropertyConfig : IFlatbufferObject
	{
		// Token: 0x1700BE01 RID: 48641
		// (get) Token: 0x0602BC59 RID: 179289 RVA: 0x005F477C File Offset: 0x005F297C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BC5A RID: 179290 RVA: 0x005F4789 File Offset: 0x005F2989
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BC5B RID: 179291 RVA: 0x005F4790 File Offset: 0x005F2990
		public static IReignsPropertyConfig GetRootAsIReignsPropertyConfig(ByteBuffer _bb)
		{
			return IReignsPropertyConfig.GetRootAsIReignsPropertyConfig(_bb, default(IReignsPropertyConfig));
		}

		// Token: 0x0602BC5C RID: 179292 RVA: 0x005F47AC File Offset: 0x005F29AC
		public static IReignsPropertyConfig GetRootAsIReignsPropertyConfig(ByteBuffer _bb, IReignsPropertyConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BC5D RID: 179293 RVA: 0x005F47C9 File Offset: 0x005F29C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BC5E RID: 179294 RVA: 0x005F47D8 File Offset: 0x005F29D8
		public IReignsPropertyConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE02 RID: 48642
		// (get) Token: 0x0602BC5F RID: 179295 RVA: 0x005F47E8 File Offset: 0x005F29E8
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

		// Token: 0x1700BE03 RID: 48643
		// (get) Token: 0x0602BC60 RID: 179296 RVA: 0x005F4824 File Offset: 0x005F2A24
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

		// Token: 0x1700BE04 RID: 48644
		// (get) Token: 0x0602BC61 RID: 179297 RVA: 0x005F4860 File Offset: 0x005F2A60
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

		// Token: 0x1700BE05 RID: 48645
		// (get) Token: 0x0602BC62 RID: 179298 RVA: 0x005F489C File Offset: 0x005F2A9C
		public bool IsDefaultEnable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602BC63 RID: 179299 RVA: 0x005F48DC File Offset: 0x005F2ADC
		public static Offset<IReignsPropertyConfig> CreateIReignsPropertyConfig(FlatBufferBuilder builder, int Id = 0, int BaseValue = 0, int MaxValue = 0, bool IsDefaultEnable = false)
		{
			builder.StartTable(4);
			IReignsPropertyConfig.AddMaxValue(builder, MaxValue);
			IReignsPropertyConfig.AddBaseValue(builder, BaseValue);
			IReignsPropertyConfig.AddId(builder, Id);
			IReignsPropertyConfig.AddIsDefaultEnable(builder, IsDefaultEnable);
			return IReignsPropertyConfig.EndIReignsPropertyConfig(builder);
		}

		// Token: 0x0602BC64 RID: 179300 RVA: 0x005F4908 File Offset: 0x005F2B08
		public static void StartIReignsPropertyConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602BC65 RID: 179301 RVA: 0x005F4911 File Offset: 0x005F2B11
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602BC66 RID: 179302 RVA: 0x005F491C File Offset: 0x005F2B1C
		public static void AddBaseValue(FlatBufferBuilder builder, int baseValue)
		{
			builder.AddInt(1, baseValue, 0);
		}

		// Token: 0x0602BC67 RID: 179303 RVA: 0x005F4927 File Offset: 0x005F2B27
		public static void AddMaxValue(FlatBufferBuilder builder, int maxValue)
		{
			builder.AddInt(2, maxValue, 0);
		}

		// Token: 0x0602BC68 RID: 179304 RVA: 0x005F4932 File Offset: 0x005F2B32
		public static void AddIsDefaultEnable(FlatBufferBuilder builder, bool isDefaultEnable)
		{
			builder.AddBool(3, isDefaultEnable, false);
		}

		// Token: 0x0602BC69 RID: 179305 RVA: 0x005F493D File Offset: 0x005F2B3D
		public static Offset<IReignsPropertyConfig> EndIReignsPropertyConfig(FlatBufferBuilder builder)
		{
			return new Offset<IReignsPropertyConfig>(builder.EndTable());
		}

		// Token: 0x0602BC6A RID: 179306 RVA: 0x005F494C File Offset: 0x005F2B4C
		public IReignsPropertyConfigT UnPack()
		{
			IReignsPropertyConfigT reignsPropertyConfigT = new IReignsPropertyConfigT();
			this.UnPackTo(reignsPropertyConfigT);
			return reignsPropertyConfigT;
		}

		// Token: 0x0602BC6B RID: 179307 RVA: 0x005F4967 File Offset: 0x005F2B67
		public void UnPackTo(IReignsPropertyConfigT _o)
		{
			_o.Id = this.Id;
			_o.BaseValue = this.BaseValue;
			_o.MaxValue = this.MaxValue;
			_o.IsDefaultEnable = this.IsDefaultEnable;
		}

		// Token: 0x0602BC6C RID: 179308 RVA: 0x005F499C File Offset: 0x005F2B9C
		public static Offset<IReignsPropertyConfig> Pack(FlatBufferBuilder builder, IReignsPropertyConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsPropertyConfig>);
			}
			return IReignsPropertyConfig.CreateIReignsPropertyConfig(builder, _o.Id, _o.BaseValue, _o.MaxValue, _o.IsDefaultEnable);
		}

		// Token: 0x040105BE RID: 67006
		private Table __p;
	}
}
