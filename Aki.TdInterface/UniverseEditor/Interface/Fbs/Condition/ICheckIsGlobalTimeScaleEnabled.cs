using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F50 RID: 20304
	public struct ICheckIsGlobalTimeScaleEnabled : IFlatbufferObject
	{
		// Token: 0x1700911A RID: 37146
		// (get) Token: 0x0601F96F RID: 129391 RVA: 0x0046504C File Offset: 0x0046324C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F970 RID: 129392 RVA: 0x00465059 File Offset: 0x00463259
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F971 RID: 129393 RVA: 0x00465060 File Offset: 0x00463260
		public static ICheckIsGlobalTimeScaleEnabled GetRootAsICheckIsGlobalTimeScaleEnabled(ByteBuffer _bb)
		{
			return ICheckIsGlobalTimeScaleEnabled.GetRootAsICheckIsGlobalTimeScaleEnabled(_bb, default(ICheckIsGlobalTimeScaleEnabled));
		}

		// Token: 0x0601F972 RID: 129394 RVA: 0x0046507C File Offset: 0x0046327C
		public static ICheckIsGlobalTimeScaleEnabled GetRootAsICheckIsGlobalTimeScaleEnabled(ByteBuffer _bb, ICheckIsGlobalTimeScaleEnabled obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F973 RID: 129395 RVA: 0x00465099 File Offset: 0x00463299
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F974 RID: 129396 RVA: 0x004650A8 File Offset: 0x004632A8
		public ICheckIsGlobalTimeScaleEnabled __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700911B RID: 37147
		// (get) Token: 0x0601F975 RID: 129397 RVA: 0x004650B8 File Offset: 0x004632B8
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700911C RID: 37148
		// (get) Token: 0x0601F976 RID: 129398 RVA: 0x004650F4 File Offset: 0x004632F4
		public bool Enabled
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F977 RID: 129399 RVA: 0x00465133 File Offset: 0x00463333
		public static Offset<ICheckIsGlobalTimeScaleEnabled> CreateICheckIsGlobalTimeScaleEnabled(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool Enabled = false)
		{
			builder.StartTable(2);
			ICheckIsGlobalTimeScaleEnabled.AddEnabled(builder, Enabled);
			ICheckIsGlobalTimeScaleEnabled.AddType(builder, Type);
			return ICheckIsGlobalTimeScaleEnabled.EndICheckIsGlobalTimeScaleEnabled(builder);
		}

		// Token: 0x0601F978 RID: 129400 RVA: 0x00465150 File Offset: 0x00463350
		public static void StartICheckIsGlobalTimeScaleEnabled(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F979 RID: 129401 RVA: 0x00465159 File Offset: 0x00463359
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F97A RID: 129402 RVA: 0x00465164 File Offset: 0x00463364
		public static void AddEnabled(FlatBufferBuilder builder, bool enabled)
		{
			builder.AddBool(1, enabled, false);
		}

		// Token: 0x0601F97B RID: 129403 RVA: 0x0046516F File Offset: 0x0046336F
		public static Offset<ICheckIsGlobalTimeScaleEnabled> EndICheckIsGlobalTimeScaleEnabled(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsGlobalTimeScaleEnabled>(builder.EndTable());
		}

		// Token: 0x0601F97C RID: 129404 RVA: 0x0046517C File Offset: 0x0046337C
		public ICheckIsGlobalTimeScaleEnabledT UnPack()
		{
			ICheckIsGlobalTimeScaleEnabledT checkIsGlobalTimeScaleEnabledT = new ICheckIsGlobalTimeScaleEnabledT();
			this.UnPackTo(checkIsGlobalTimeScaleEnabledT);
			return checkIsGlobalTimeScaleEnabledT;
		}

		// Token: 0x0601F97D RID: 129405 RVA: 0x00465197 File Offset: 0x00463397
		public void UnPackTo(ICheckIsGlobalTimeScaleEnabledT _o)
		{
			_o.Type = this.Type;
			_o.Enabled = this.Enabled;
		}

		// Token: 0x0601F97E RID: 129406 RVA: 0x004651B4 File Offset: 0x004633B4
		public static Offset<ICheckIsGlobalTimeScaleEnabled> Pack(FlatBufferBuilder builder, ICheckIsGlobalTimeScaleEnabledT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsGlobalTimeScaleEnabled>);
			}
			return ICheckIsGlobalTimeScaleEnabled.CreateICheckIsGlobalTimeScaleEnabled(builder, _o.Type, _o.Enabled);
		}

		// Token: 0x0400DDD4 RID: 56788
		private Table __p;
	}
}
