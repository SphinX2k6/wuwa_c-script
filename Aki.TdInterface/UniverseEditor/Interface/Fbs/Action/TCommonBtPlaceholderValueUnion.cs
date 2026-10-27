using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200768D RID: 30349
	public class TCommonBtPlaceholderValueUnion
	{
		// Token: 0x1700E5F1 RID: 58865
		// (get) Token: 0x0603736C RID: 226156 RVA: 0x0077BAFC File Offset: 0x00779CFC
		// (set) Token: 0x0603736D RID: 226157 RVA: 0x0077BB04 File Offset: 0x00779D04
		public TCommonBtPlaceholderValue Type { get; set; }

		// Token: 0x1700E5F2 RID: 58866
		// (get) Token: 0x0603736E RID: 226158 RVA: 0x0077BB0D File Offset: 0x00779D0D
		// (set) Token: 0x0603736F RID: 226159 RVA: 0x0077BB15 File Offset: 0x00779D15
		public object Value { get; set; }

		// Token: 0x06037370 RID: 226160 RVA: 0x0077BB1E File Offset: 0x00779D1E
		public TCommonBtPlaceholderValueUnion()
		{
			this.Type = TCommonBtPlaceholderValue.NONE;
			this.Value = null;
		}

		// Token: 0x06037371 RID: 226161 RVA: 0x0077BB34 File Offset: 0x00779D34
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037372 RID: 226162 RVA: 0x0077BB46 File Offset: 0x00779D46
		public ICommonBtOverrideActionInfoT AsICommonBtOverrideActionInfo()
		{
			return this.As<ICommonBtOverrideActionInfoT>();
		}

		// Token: 0x06037373 RID: 226163 RVA: 0x0077BB4E File Offset: 0x00779D4E
		public static TCommonBtPlaceholderValueUnion FromICommonBtOverrideActionInfo(ICommonBtOverrideActionInfoT _icommonbtoverrideactioninfo)
		{
			return new TCommonBtPlaceholderValueUnion
			{
				Type = TCommonBtPlaceholderValue.ICommonBtOverrideActionInfo,
				Value = _icommonbtoverrideactioninfo
			};
		}

		// Token: 0x06037374 RID: 226164 RVA: 0x0077BB63 File Offset: 0x00779D63
		public ICommonBtOverrideConditionInfoT AsICommonBtOverrideConditionInfo()
		{
			return this.As<ICommonBtOverrideConditionInfoT>();
		}

		// Token: 0x06037375 RID: 226165 RVA: 0x0077BB6B File Offset: 0x00779D6B
		public static TCommonBtPlaceholderValueUnion FromICommonBtOverrideConditionInfo(ICommonBtOverrideConditionInfoT _icommonbtoverrideconditioninfo)
		{
			return new TCommonBtPlaceholderValueUnion
			{
				Type = TCommonBtPlaceholderValue.ICommonBtOverrideConditionInfo,
				Value = _icommonbtoverrideconditioninfo
			};
		}

		// Token: 0x06037376 RID: 226166 RVA: 0x0077BB80 File Offset: 0x00779D80
		public static int Pack(FlatBufferBuilder builder, TCommonBtPlaceholderValueUnion _o)
		{
			TCommonBtPlaceholderValue type = _o.Type;
			if (type == TCommonBtPlaceholderValue.ICommonBtOverrideActionInfo)
			{
				return ICommonBtOverrideActionInfo.Pack(builder, _o.AsICommonBtOverrideActionInfo()).Value;
			}
			if (type != TCommonBtPlaceholderValue.ICommonBtOverrideConditionInfo)
			{
				return 0;
			}
			return ICommonBtOverrideConditionInfo.Pack(builder, _o.AsICommonBtOverrideConditionInfo()).Value;
		}
	}
}
