using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DF1 RID: 24049
	public struct IRandomInteractOption : IFlatbufferObject
	{
		// Token: 0x1700B13D RID: 45373
		// (get) Token: 0x0602823A RID: 164410 RVA: 0x0057D5C8 File Offset: 0x0057B7C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602823B RID: 164411 RVA: 0x0057D5D5 File Offset: 0x0057B7D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602823C RID: 164412 RVA: 0x0057D5DC File Offset: 0x0057B7DC
		public static IRandomInteractOption GetRootAsIRandomInteractOption(ByteBuffer _bb)
		{
			return IRandomInteractOption.GetRootAsIRandomInteractOption(_bb, default(IRandomInteractOption));
		}

		// Token: 0x0602823D RID: 164413 RVA: 0x0057D5F8 File Offset: 0x0057B7F8
		public static IRandomInteractOption GetRootAsIRandomInteractOption(ByteBuffer _bb, IRandomInteractOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602823E RID: 164414 RVA: 0x0057D615 File Offset: 0x0057B815
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602823F RID: 164415 RVA: 0x0057D624 File Offset: 0x0057B824
		public IRandomInteractOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B13E RID: 45374
		// (get) Token: 0x06028240 RID: 164416 RVA: 0x0057D634 File Offset: 0x0057B834
		public int Weight
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

		// Token: 0x1700B13F RID: 45375
		// (get) Token: 0x06028241 RID: 164417 RVA: 0x0057D670 File Offset: 0x0057B870
		public IInteractOption? Option
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IInteractOption?(default(IInteractOption).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06028242 RID: 164418 RVA: 0x0057D6CD File Offset: 0x0057B8CD
		public static Offset<IRandomInteractOption> CreateIRandomInteractOption(FlatBufferBuilder builder, int Weight = 0, Offset<IInteractOption> OptionOffset = default(Offset<IInteractOption>))
		{
			builder.StartTable(2);
			IRandomInteractOption.AddOption(builder, OptionOffset);
			IRandomInteractOption.AddWeight(builder, Weight);
			return IRandomInteractOption.EndIRandomInteractOption(builder);
		}

		// Token: 0x06028243 RID: 164419 RVA: 0x0057D6EA File Offset: 0x0057B8EA
		public static void StartIRandomInteractOption(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028244 RID: 164420 RVA: 0x0057D6F3 File Offset: 0x0057B8F3
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(0, weight, 0);
		}

		// Token: 0x06028245 RID: 164421 RVA: 0x0057D6FE File Offset: 0x0057B8FE
		public static void AddOption(FlatBufferBuilder builder, Offset<IInteractOption> optionOffset)
		{
			builder.AddOffset(1, optionOffset.Value, 0);
		}

		// Token: 0x06028246 RID: 164422 RVA: 0x0057D70E File Offset: 0x0057B90E
		public static Offset<IRandomInteractOption> EndIRandomInteractOption(FlatBufferBuilder builder)
		{
			return new Offset<IRandomInteractOption>(builder.EndTable());
		}

		// Token: 0x06028247 RID: 164423 RVA: 0x0057D71C File Offset: 0x0057B91C
		public IRandomInteractOptionT UnPack()
		{
			IRandomInteractOptionT randomInteractOptionT = new IRandomInteractOptionT();
			this.UnPackTo(randomInteractOptionT);
			return randomInteractOptionT;
		}

		// Token: 0x06028248 RID: 164424 RVA: 0x0057D738 File Offset: 0x0057B938
		public void UnPackTo(IRandomInteractOptionT _o)
		{
			_o.Weight = this.Weight;
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
		}

		// Token: 0x06028249 RID: 164425 RVA: 0x0057D780 File Offset: 0x0057B980
		public static Offset<IRandomInteractOption> Pack(FlatBufferBuilder builder, IRandomInteractOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRandomInteractOption>);
			}
			Offset<IInteractOption> optionOffset = (_o.Option == null) ? default(Offset<IInteractOption>) : IInteractOption.Pack(builder, _o.Option);
			return IRandomInteractOption.CreateIRandomInteractOption(builder, _o.Weight, optionOffset);
		}

		// Token: 0x0400F9C7 RID: 63943
		private Table __p;
	}
}
