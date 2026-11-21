using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EC8 RID: 32456
	public class TEntityDecorationConfigUnion
	{
		// Token: 0x1700F253 RID: 62035
		// (get) Token: 0x0603A937 RID: 239927 RVA: 0x007E1D1E File Offset: 0x007DFF1E
		// (set) Token: 0x0603A938 RID: 239928 RVA: 0x007E1D26 File Offset: 0x007DFF26
		public TEntityDecorationConfig Type { get; set; }

		// Token: 0x1700F254 RID: 62036
		// (get) Token: 0x0603A939 RID: 239929 RVA: 0x007E1D2F File Offset: 0x007DFF2F
		// (set) Token: 0x0603A93A RID: 239930 RVA: 0x007E1D37 File Offset: 0x007DFF37
		public object Value { get; set; }

		// Token: 0x0603A93B RID: 239931 RVA: 0x007E1D40 File Offset: 0x007DFF40
		public TEntityDecorationConfigUnion()
		{
			this.Type = TEntityDecorationConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603A93C RID: 239932 RVA: 0x007E1D56 File Offset: 0x007DFF56
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A93D RID: 239933 RVA: 0x007E1D68 File Offset: 0x007DFF68
		public IAddEntityDecorationT AsIAddEntityDecoration()
		{
			return this.As<IAddEntityDecorationT>();
		}

		// Token: 0x0603A93E RID: 239934 RVA: 0x007E1D70 File Offset: 0x007DFF70
		public static TEntityDecorationConfigUnion FromIAddEntityDecoration(IAddEntityDecorationT _iaddentitydecoration)
		{
			return new TEntityDecorationConfigUnion
			{
				Type = TEntityDecorationConfig.IAddEntityDecoration,
				Value = _iaddentitydecoration
			};
		}

		// Token: 0x0603A93F RID: 239935 RVA: 0x007E1D85 File Offset: 0x007DFF85
		public IRemoveEntityDecorationT AsIRemoveEntityDecoration()
		{
			return this.As<IRemoveEntityDecorationT>();
		}

		// Token: 0x0603A940 RID: 239936 RVA: 0x007E1D8D File Offset: 0x007DFF8D
		public static TEntityDecorationConfigUnion FromIRemoveEntityDecoration(IRemoveEntityDecorationT _iremoveentitydecoration)
		{
			return new TEntityDecorationConfigUnion
			{
				Type = TEntityDecorationConfig.IRemoveEntityDecoration,
				Value = _iremoveentitydecoration
			};
		}

		// Token: 0x0603A941 RID: 239937 RVA: 0x007E1DA4 File Offset: 0x007DFFA4
		public static int Pack(FlatBufferBuilder builder, TEntityDecorationConfigUnion _o)
		{
			TEntityDecorationConfig type = _o.Type;
			if (type == TEntityDecorationConfig.IAddEntityDecoration)
			{
				return IAddEntityDecoration.Pack(builder, _o.AsIAddEntityDecoration()).Value;
			}
			if (type != TEntityDecorationConfig.IRemoveEntityDecoration)
			{
				return 0;
			}
			return IRemoveEntityDecoration.Pack(builder, _o.AsIRemoveEntityDecoration()).Value;
		}
	}
}
