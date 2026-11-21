using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200749C RID: 29852
	public class IPlayGuestUiAnimationType_UnionUnion
	{
		// Token: 0x1700DB44 RID: 56132
		// (get) Token: 0x06034424 RID: 214052 RVA: 0x00709A5D File Offset: 0x00707C5D
		// (set) Token: 0x06034425 RID: 214053 RVA: 0x00709A65 File Offset: 0x00707C65
		public IPlayGuestUiAnimationType_Union Type { get; set; }

		// Token: 0x1700DB45 RID: 56133
		// (get) Token: 0x06034426 RID: 214054 RVA: 0x00709A6E File Offset: 0x00707C6E
		// (set) Token: 0x06034427 RID: 214055 RVA: 0x00709A76 File Offset: 0x00707C76
		public object Value { get; set; }

		// Token: 0x06034428 RID: 214056 RVA: 0x00709A7F File Offset: 0x00707C7F
		public IPlayGuestUiAnimationType_UnionUnion()
		{
			this.Type = IPlayGuestUiAnimationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06034429 RID: 214057 RVA: 0x00709A95 File Offset: 0x00707C95
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603442A RID: 214058 RVA: 0x00709AA7 File Offset: 0x00707CA7
		public IPlayGuestUiAnimationTypeT AsIPlayGuestUiAnimationType()
		{
			return this.As<IPlayGuestUiAnimationTypeT>();
		}

		// Token: 0x0603442B RID: 214059 RVA: 0x00709AAF File Offset: 0x00707CAF
		public static IPlayGuestUiAnimationType_UnionUnion FromIPlayGuestUiAnimationType(IPlayGuestUiAnimationTypeT _iplayguestuianimationtype)
		{
			return new IPlayGuestUiAnimationType_UnionUnion
			{
				Type = IPlayGuestUiAnimationType_Union.IPlayGuestUiAnimationType,
				Value = _iplayguestuianimationtype
			};
		}

		// Token: 0x0603442C RID: 214060 RVA: 0x00709AC4 File Offset: 0x00707CC4
		public IPlayGuestCartethyiaT AsIPlayGuestCartethyia()
		{
			return this.As<IPlayGuestCartethyiaT>();
		}

		// Token: 0x0603442D RID: 214061 RVA: 0x00709ACC File Offset: 0x00707CCC
		public static IPlayGuestUiAnimationType_UnionUnion FromIPlayGuestCartethyia(IPlayGuestCartethyiaT _iplayguestcartethyia)
		{
			return new IPlayGuestUiAnimationType_UnionUnion
			{
				Type = IPlayGuestUiAnimationType_Union.IPlayGuestCartethyia,
				Value = _iplayguestcartethyia
			};
		}

		// Token: 0x0603442E RID: 214062 RVA: 0x00709AE4 File Offset: 0x00707CE4
		public static int Pack(FlatBufferBuilder builder, IPlayGuestUiAnimationType_UnionUnion _o)
		{
			IPlayGuestUiAnimationType_Union type = _o.Type;
			if (type == IPlayGuestUiAnimationType_Union.IPlayGuestUiAnimationType)
			{
				return IPlayGuestUiAnimationType.Pack(builder, _o.AsIPlayGuestUiAnimationType()).Value;
			}
			if (type != IPlayGuestUiAnimationType_Union.IPlayGuestCartethyia)
			{
				return 0;
			}
			return IPlayGuestCartethyia.Pack(builder, _o.AsIPlayGuestCartethyia()).Value;
		}
	}
}
