using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D7 RID: 21463
	public struct IHookPerformanceConfig : IFlatbufferObject
	{
		// Token: 0x17009DE4 RID: 40420
		// (get) Token: 0x0602338B RID: 144267 RVA: 0x004E09E1 File Offset: 0x004DEBE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602338C RID: 144268 RVA: 0x004E09EE File Offset: 0x004DEBEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602338D RID: 144269 RVA: 0x004E09F8 File Offset: 0x004DEBF8
		public static IHookPerformanceConfig GetRootAsIHookPerformanceConfig(ByteBuffer _bb)
		{
			return IHookPerformanceConfig.GetRootAsIHookPerformanceConfig(_bb, default(IHookPerformanceConfig));
		}

		// Token: 0x0602338E RID: 144270 RVA: 0x004E0A14 File Offset: 0x004DEC14
		public static IHookPerformanceConfig GetRootAsIHookPerformanceConfig(ByteBuffer _bb, IHookPerformanceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602338F RID: 144271 RVA: 0x004E0A31 File Offset: 0x004DEC31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023390 RID: 144272 RVA: 0x004E0A40 File Offset: 0x004DEC40
		public IHookPerformanceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009DE5 RID: 40421
		// (get) Token: 0x06023391 RID: 144273 RVA: 0x004E0A50 File Offset: 0x004DEC50
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

		// Token: 0x17009DE6 RID: 40422
		// (get) Token: 0x06023392 RID: 144274 RVA: 0x004E0A90 File Offset: 0x004DEC90
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

		// Token: 0x06023393 RID: 144275 RVA: 0x004E0ACC File Offset: 0x004DECCC
		public static Offset<IHookPerformanceConfig> CreateIHookPerformanceConfig(FlatBufferBuilder builder, long HookEffectBuffId = 0L, byte NullMask = 0)
		{
			builder.StartTable(2);
			IHookPerformanceConfig.AddHookEffectBuffId(builder, HookEffectBuffId);
			IHookPerformanceConfig.AddNullMask(builder, NullMask);
			return IHookPerformanceConfig.EndIHookPerformanceConfig(builder);
		}

		// Token: 0x06023394 RID: 144276 RVA: 0x004E0AE9 File Offset: 0x004DECE9
		public static void StartIHookPerformanceConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023395 RID: 144277 RVA: 0x004E0AF2 File Offset: 0x004DECF2
		public static void AddHookEffectBuffId(FlatBufferBuilder builder, long hookEffectBuffId)
		{
			builder.AddLong(0, hookEffectBuffId, 0L);
		}

		// Token: 0x06023396 RID: 144278 RVA: 0x004E0AFE File Offset: 0x004DECFE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06023397 RID: 144279 RVA: 0x004E0B09 File Offset: 0x004DED09
		public static Offset<IHookPerformanceConfig> EndIHookPerformanceConfig(FlatBufferBuilder builder)
		{
			return new Offset<IHookPerformanceConfig>(builder.EndTable());
		}

		// Token: 0x06023398 RID: 144280 RVA: 0x004E0B18 File Offset: 0x004DED18
		public IHookPerformanceConfigT UnPack()
		{
			IHookPerformanceConfigT hookPerformanceConfigT = new IHookPerformanceConfigT();
			this.UnPackTo(hookPerformanceConfigT);
			return hookPerformanceConfigT;
		}

		// Token: 0x06023399 RID: 144281 RVA: 0x004E0B33 File Offset: 0x004DED33
		public void UnPackTo(IHookPerformanceConfigT _o)
		{
			_o.HookEffectBuffId = this.HookEffectBuffId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602339A RID: 144282 RVA: 0x004E0B50 File Offset: 0x004DED50
		public static Offset<IHookPerformanceConfig> Pack(FlatBufferBuilder builder, IHookPerformanceConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookPerformanceConfig>);
			}
			return IHookPerformanceConfig.CreateIHookPerformanceConfig(builder, _o.HookEffectBuffId, _o.NullMask);
		}

		// Token: 0x0400E60C RID: 58892
		private Table __p;
	}
}
