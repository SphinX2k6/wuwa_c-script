using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057EA RID: 22506
	public struct IRandomInteractOption : IFlatbufferObject
	{
		// Token: 0x1700A819 RID: 43033
		// (get) Token: 0x06025D1A RID: 154906 RVA: 0x0053743C File Offset: 0x0053563C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025D1B RID: 154907 RVA: 0x00537449 File Offset: 0x00535649
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025D1C RID: 154908 RVA: 0x00537450 File Offset: 0x00535650
		public static IRandomInteractOption GetRootAsIRandomInteractOption(ByteBuffer _bb)
		{
			return IRandomInteractOption.GetRootAsIRandomInteractOption(_bb, default(IRandomInteractOption));
		}

		// Token: 0x06025D1D RID: 154909 RVA: 0x0053746C File Offset: 0x0053566C
		public static IRandomInteractOption GetRootAsIRandomInteractOption(ByteBuffer _bb, IRandomInteractOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025D1E RID: 154910 RVA: 0x00537489 File Offset: 0x00535689
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025D1F RID: 154911 RVA: 0x00537498 File Offset: 0x00535698
		public IRandomInteractOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A81A RID: 43034
		// (get) Token: 0x06025D20 RID: 154912 RVA: 0x005374A8 File Offset: 0x005356A8
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

		// Token: 0x1700A81B RID: 43035
		// (get) Token: 0x06025D21 RID: 154913 RVA: 0x005374E4 File Offset: 0x005356E4
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

		// Token: 0x06025D22 RID: 154914 RVA: 0x00537541 File Offset: 0x00535741
		public static Offset<IRandomInteractOption> CreateIRandomInteractOption(FlatBufferBuilder builder, int Weight = 0, Offset<IInteractOption> OptionOffset = default(Offset<IInteractOption>))
		{
			builder.StartTable(2);
			IRandomInteractOption.AddOption(builder, OptionOffset);
			IRandomInteractOption.AddWeight(builder, Weight);
			return IRandomInteractOption.EndIRandomInteractOption(builder);
		}

		// Token: 0x06025D23 RID: 154915 RVA: 0x0053755E File Offset: 0x0053575E
		public static void StartIRandomInteractOption(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025D24 RID: 154916 RVA: 0x00537567 File Offset: 0x00535767
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(0, weight, 0);
		}

		// Token: 0x06025D25 RID: 154917 RVA: 0x00537572 File Offset: 0x00535772
		public static void AddOption(FlatBufferBuilder builder, Offset<IInteractOption> optionOffset)
		{
			builder.AddOffset(1, optionOffset.Value, 0);
		}

		// Token: 0x06025D26 RID: 154918 RVA: 0x00537582 File Offset: 0x00535782
		public static Offset<IRandomInteractOption> EndIRandomInteractOption(FlatBufferBuilder builder)
		{
			return new Offset<IRandomInteractOption>(builder.EndTable());
		}

		// Token: 0x06025D27 RID: 154919 RVA: 0x00537590 File Offset: 0x00535790
		public IRandomInteractOptionT UnPack()
		{
			IRandomInteractOptionT randomInteractOptionT = new IRandomInteractOptionT();
			this.UnPackTo(randomInteractOptionT);
			return randomInteractOptionT;
		}

		// Token: 0x06025D28 RID: 154920 RVA: 0x005375AC File Offset: 0x005357AC
		public void UnPackTo(IRandomInteractOptionT _o)
		{
			_o.Weight = this.Weight;
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
		}

		// Token: 0x06025D29 RID: 154921 RVA: 0x005375F4 File Offset: 0x005357F4
		public static Offset<IRandomInteractOption> Pack(FlatBufferBuilder builder, IRandomInteractOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRandomInteractOption>);
			}
			Offset<IInteractOption> optionOffset = (_o.Option == null) ? default(Offset<IInteractOption>) : IInteractOption.Pack(builder, _o.Option);
			return IRandomInteractOption.CreateIRandomInteractOption(builder, _o.Weight, optionOffset);
		}

		// Token: 0x0400ECDC RID: 60636
		private Table __p;
	}
}
