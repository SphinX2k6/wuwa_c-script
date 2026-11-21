using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E59 RID: 32345
	public class TBlendAnimTypeUnion
	{
		// Token: 0x1700F203 RID: 61955
		// (get) Token: 0x0603A6E1 RID: 239329 RVA: 0x007DE0C6 File Offset: 0x007DC2C6
		// (set) Token: 0x0603A6E2 RID: 239330 RVA: 0x007DE0CE File Offset: 0x007DC2CE
		public TBlendAnimType Type { get; set; }

		// Token: 0x1700F204 RID: 61956
		// (get) Token: 0x0603A6E3 RID: 239331 RVA: 0x007DE0D7 File Offset: 0x007DC2D7
		// (set) Token: 0x0603A6E4 RID: 239332 RVA: 0x007DE0DF File Offset: 0x007DC2DF
		public object Value { get; set; }

		// Token: 0x0603A6E5 RID: 239333 RVA: 0x007DE0E8 File Offset: 0x007DC2E8
		public TBlendAnimTypeUnion()
		{
			this.Type = TBlendAnimType.NONE;
			this.Value = null;
		}

		// Token: 0x0603A6E6 RID: 239334 RVA: 0x007DE0FE File Offset: 0x007DC2FE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A6E7 RID: 239335 RVA: 0x007DE110 File Offset: 0x007DC310
		public ISetAnimSequenceBlendAnimTypeT AsISetAnimSequenceBlendAnimType()
		{
			return this.As<ISetAnimSequenceBlendAnimTypeT>();
		}

		// Token: 0x0603A6E8 RID: 239336 RVA: 0x007DE118 File Offset: 0x007DC318
		public static TBlendAnimTypeUnion FromISetAnimSequenceBlendAnimType(ISetAnimSequenceBlendAnimTypeT _isetanimsequenceblendanimtype)
		{
			return new TBlendAnimTypeUnion
			{
				Type = TBlendAnimType.ISetAnimSequenceBlendAnimType,
				Value = _isetanimsequenceblendanimtype
			};
		}

		// Token: 0x0603A6E9 RID: 239337 RVA: 0x007DE12D File Offset: 0x007DC32D
		public ISetStateMachineBlendAnimTypeT AsISetStateMachineBlendAnimType()
		{
			return this.As<ISetStateMachineBlendAnimTypeT>();
		}

		// Token: 0x0603A6EA RID: 239338 RVA: 0x007DE135 File Offset: 0x007DC335
		public static TBlendAnimTypeUnion FromISetStateMachineBlendAnimType(ISetStateMachineBlendAnimTypeT _isetstatemachineblendanimtype)
		{
			return new TBlendAnimTypeUnion
			{
				Type = TBlendAnimType.ISetStateMachineBlendAnimType,
				Value = _isetstatemachineblendanimtype
			};
		}

		// Token: 0x0603A6EB RID: 239339 RVA: 0x007DE14C File Offset: 0x007DC34C
		public static int Pack(FlatBufferBuilder builder, TBlendAnimTypeUnion _o)
		{
			TBlendAnimType type = _o.Type;
			if (type == TBlendAnimType.ISetAnimSequenceBlendAnimType)
			{
				return ISetAnimSequenceBlendAnimType.Pack(builder, _o.AsISetAnimSequenceBlendAnimType()).Value;
			}
			if (type != TBlendAnimType.ISetStateMachineBlendAnimType)
			{
				return 0;
			}
			return ISetStateMachineBlendAnimType.Pack(builder, _o.AsISetStateMachineBlendAnimType()).Value;
		}
	}
}
