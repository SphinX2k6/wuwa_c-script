using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200595D RID: 22877
	public struct IHookPerformanceConfig : IFlatbufferObject
	{
		// Token: 0x1700A61E RID: 42526
		// (get) Token: 0x06025443 RID: 152643 RVA: 0x0051DA0D File Offset: 0x0051BC0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025444 RID: 152644 RVA: 0x0051DA1A File Offset: 0x0051BC1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025445 RID: 152645 RVA: 0x0051DA24 File Offset: 0x0051BC24
		public static IHookPerformanceConfig GetRootAsIHookPerformanceConfig(ByteBuffer _bb)
		{
			return IHookPerformanceConfig.GetRootAsIHookPerformanceConfig(_bb, default(IHookPerformanceConfig));
		}

		// Token: 0x06025446 RID: 152646 RVA: 0x0051DA40 File Offset: 0x0051BC40
		public static IHookPerformanceConfig GetRootAsIHookPerformanceConfig(ByteBuffer _bb, IHookPerformanceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025447 RID: 152647 RVA: 0x0051DA5D File Offset: 0x0051BC5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025448 RID: 152648 RVA: 0x0051DA6C File Offset: 0x0051BC6C
		public IHookPerformanceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A61F RID: 42527
		// (get) Token: 0x06025449 RID: 152649 RVA: 0x0051DA7C File Offset: 0x0051BC7C
		public long HookEffectBuffId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A620 RID: 42528
		// (get) Token: 0x0602544A RID: 152650 RVA: 0x0051DABC File Offset: 0x0051BCBC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602544B RID: 152651 RVA: 0x0051DAF8 File Offset: 0x0051BCF8
		public static Offset<IHookPerformanceConfig> CreateIHookPerformanceConfig(FlatBufferBuilder builder, long HookEffectBuffId = 0L, byte NullMask = 0)
		{
			builder.StartTable(2);
			IHookPerformanceConfig.AddHookEffectBuffId(builder, HookEffectBuffId);
			IHookPerformanceConfig.AddNullMask(builder, NullMask);
			return IHookPerformanceConfig.EndIHookPerformanceConfig(builder);
		}

		// Token: 0x0602544C RID: 152652 RVA: 0x0051DB15 File Offset: 0x0051BD15
		public static void StartIHookPerformanceConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602544D RID: 152653 RVA: 0x0051DB1E File Offset: 0x0051BD1E
		public static void AddHookEffectBuffId(FlatBufferBuilder builder, long hookEffectBuffId)
		{
			builder.AddLong(0, hookEffectBuffId, 0L);
		}

		// Token: 0x0602544E RID: 152654 RVA: 0x0051DB2A File Offset: 0x0051BD2A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602544F RID: 152655 RVA: 0x0051DB35 File Offset: 0x0051BD35
		public static Offset<IHookPerformanceConfig> EndIHookPerformanceConfig(FlatBufferBuilder builder)
		{
			return new Offset<IHookPerformanceConfig>(builder.EndTable());
		}

		// Token: 0x06025450 RID: 152656 RVA: 0x0051DB44 File Offset: 0x0051BD44
		public IHookPerformanceConfigT UnPack()
		{
			IHookPerformanceConfigT hookPerformanceConfigT = new IHookPerformanceConfigT();
			this.UnPackTo(hookPerformanceConfigT);
			return hookPerformanceConfigT;
		}

		// Token: 0x06025451 RID: 152657 RVA: 0x0051DB5F File Offset: 0x0051BD5F
		public void UnPackTo(IHookPerformanceConfigT _o)
		{
			_o.HookEffectBuffId = this.HookEffectBuffId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025452 RID: 152658 RVA: 0x0051DB7C File Offset: 0x0051BD7C
		public static Offset<IHookPerformanceConfig> Pack(FlatBufferBuilder builder, IHookPerformanceConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookPerformanceConfig>);
			}
			return IHookPerformanceConfig.CreateIHookPerformanceConfig(builder, _o.HookEffectBuffId, _o.NullMask);
		}

		// Token: 0x0400F23D RID: 62013
		private Table __p;
	}
}
