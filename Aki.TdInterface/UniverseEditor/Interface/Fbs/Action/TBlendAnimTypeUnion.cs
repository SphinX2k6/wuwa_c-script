using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200764B RID: 30283
	public class TBlendAnimTypeUnion
	{
		// Token: 0x1700E5C5 RID: 58821
		// (get) Token: 0x0603723C RID: 225852 RVA: 0x00779FCA File Offset: 0x007781CA
		// (set) Token: 0x0603723D RID: 225853 RVA: 0x00779FD2 File Offset: 0x007781D2
		public TBlendAnimType Type { get; set; }

		// Token: 0x1700E5C6 RID: 58822
		// (get) Token: 0x0603723E RID: 225854 RVA: 0x00779FDB File Offset: 0x007781DB
		// (set) Token: 0x0603723F RID: 225855 RVA: 0x00779FE3 File Offset: 0x007781E3
		public object Value { get; set; }

		// Token: 0x06037240 RID: 225856 RVA: 0x00779FEC File Offset: 0x007781EC
		public TBlendAnimTypeUnion()
		{
			this.Type = TBlendAnimType.NONE;
			this.Value = null;
		}

		// Token: 0x06037241 RID: 225857 RVA: 0x0077A002 File Offset: 0x00778202
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037242 RID: 225858 RVA: 0x0077A014 File Offset: 0x00778214
		public ISetAnimSequenceBlendAnimTypeT AsISetAnimSequenceBlendAnimType()
		{
			return this.As<ISetAnimSequenceBlendAnimTypeT>();
		}

		// Token: 0x06037243 RID: 225859 RVA: 0x0077A01C File Offset: 0x0077821C
		public static TBlendAnimTypeUnion FromISetAnimSequenceBlendAnimType(ISetAnimSequenceBlendAnimTypeT _isetanimsequenceblendanimtype)
		{
			return new TBlendAnimTypeUnion
			{
				Type = TBlendAnimType.ISetAnimSequenceBlendAnimType,
				Value = _isetanimsequenceblendanimtype
			};
		}

		// Token: 0x06037244 RID: 225860 RVA: 0x0077A031 File Offset: 0x00778231
		public ISetStateMachineBlendAnimTypeT AsISetStateMachineBlendAnimType()
		{
			return this.As<ISetStateMachineBlendAnimTypeT>();
		}

		// Token: 0x06037245 RID: 225861 RVA: 0x0077A039 File Offset: 0x00778239
		public static TBlendAnimTypeUnion FromISetStateMachineBlendAnimType(ISetStateMachineBlendAnimTypeT _isetstatemachineblendanimtype)
		{
			return new TBlendAnimTypeUnion
			{
				Type = TBlendAnimType.ISetStateMachineBlendAnimType,
				Value = _isetstatemachineblendanimtype
			};
		}

		// Token: 0x06037246 RID: 225862 RVA: 0x0077A050 File Offset: 0x00778250
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
