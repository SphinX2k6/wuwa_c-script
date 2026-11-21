using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055D1 RID: 21969
	public struct IDamageTextOptimizationConfig : IFlatbufferObject
	{
		// Token: 0x17009D46 RID: 40262
		// (get) Token: 0x06022F41 RID: 143169 RVA: 0x004CFA3F File Offset: 0x004CDC3F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022F42 RID: 143170 RVA: 0x004CFA4C File Offset: 0x004CDC4C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022F43 RID: 143171 RVA: 0x004CFA54 File Offset: 0x004CDC54
		public static IDamageTextOptimizationConfig GetRootAsIDamageTextOptimizationConfig(ByteBuffer _bb)
		{
			return IDamageTextOptimizationConfig.GetRootAsIDamageTextOptimizationConfig(_bb, default(IDamageTextOptimizationConfig));
		}

		// Token: 0x06022F44 RID: 143172 RVA: 0x004CFA70 File Offset: 0x004CDC70
		public static IDamageTextOptimizationConfig GetRootAsIDamageTextOptimizationConfig(ByteBuffer _bb, IDamageTextOptimizationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022F45 RID: 143173 RVA: 0x004CFA8D File Offset: 0x004CDC8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022F46 RID: 143174 RVA: 0x004CFA9C File Offset: 0x004CDC9C
		public IDamageTextOptimizationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D47 RID: 40263
		// (get) Token: 0x06022F47 RID: 143175 RVA: 0x004CFAAC File Offset: 0x004CDCAC
		public EPerformanceOptimizationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformanceOptimizationType.PlaneMovementOptimization;
				}
				return (EPerformanceOptimizationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009D48 RID: 40264
		// (get) Token: 0x06022F48 RID: 143176 RVA: 0x004CFAE8 File Offset: 0x004CDCE8
		public bool UseRange
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009D49 RID: 40265
		// (get) Token: 0x06022F49 RID: 143177 RVA: 0x004CFB28 File Offset: 0x004CDD28
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

		// Token: 0x06022F4A RID: 143178 RVA: 0x004CFB64 File Offset: 0x004CDD64
		public static Offset<IDamageTextOptimizationConfig> CreateIDamageTextOptimizationConfig(FlatBufferBuilder builder, EPerformanceOptimizationType Type = EPerformanceOptimizationType.PlaneMovementOptimization, bool UseRange = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDamageTextOptimizationConfig.AddNullMask(builder, NullMask);
			IDamageTextOptimizationConfig.AddUseRange(builder, UseRange);
			IDamageTextOptimizationConfig.AddType(builder, Type);
			return IDamageTextOptimizationConfig.EndIDamageTextOptimizationConfig(builder);
		}

		// Token: 0x06022F4B RID: 143179 RVA: 0x004CFB88 File Offset: 0x004CDD88
		public static void StartIDamageTextOptimizationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022F4C RID: 143180 RVA: 0x004CFB91 File Offset: 0x004CDD91
		public static void AddType(FlatBufferBuilder builder, EPerformanceOptimizationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022F4D RID: 143181 RVA: 0x004CFB9C File Offset: 0x004CDD9C
		public static void AddUseRange(FlatBufferBuilder builder, bool useRange)
		{
			builder.AddBool(1, useRange, false);
		}

		// Token: 0x06022F4E RID: 143182 RVA: 0x004CFBA7 File Offset: 0x004CDDA7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06022F4F RID: 143183 RVA: 0x004CFBB2 File Offset: 0x004CDDB2
		public static Offset<IDamageTextOptimizationConfig> EndIDamageTextOptimizationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDamageTextOptimizationConfig>(builder.EndTable());
		}

		// Token: 0x06022F50 RID: 143184 RVA: 0x004CFBC0 File Offset: 0x004CDDC0
		public IDamageTextOptimizationConfigT UnPack()
		{
			IDamageTextOptimizationConfigT damageTextOptimizationConfigT = new IDamageTextOptimizationConfigT();
			this.UnPackTo(damageTextOptimizationConfigT);
			return damageTextOptimizationConfigT;
		}

		// Token: 0x06022F51 RID: 143185 RVA: 0x004CFBDB File Offset: 0x004CDDDB
		public void UnPackTo(IDamageTextOptimizationConfigT _o)
		{
			_o.Type = this.Type;
			_o.UseRange = this.UseRange;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022F52 RID: 143186 RVA: 0x004CFC04 File Offset: 0x004CDE04
		public static Offset<IDamageTextOptimizationConfig> Pack(FlatBufferBuilder builder, IDamageTextOptimizationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDamageTextOptimizationConfig>);
			}
			return IDamageTextOptimizationConfig.CreateIDamageTextOptimizationConfig(builder, _o.Type, _o.UseRange, _o.NullMask);
		}

		// Token: 0x0400EC69 RID: 60521
		private Table __p;
	}
}
