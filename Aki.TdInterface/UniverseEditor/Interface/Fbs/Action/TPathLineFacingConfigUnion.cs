using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F70 RID: 32624
	public class TPathLineFacingConfigUnion
	{
		// Token: 0x1700F2C3 RID: 62147
		// (get) Token: 0x0603ACE1 RID: 240865 RVA: 0x007E785E File Offset: 0x007E5A5E
		// (set) Token: 0x0603ACE2 RID: 240866 RVA: 0x007E7866 File Offset: 0x007E5A66
		public TPathLineFacingConfig Type { get; set; }

		// Token: 0x1700F2C4 RID: 62148
		// (get) Token: 0x0603ACE3 RID: 240867 RVA: 0x007E786F File Offset: 0x007E5A6F
		// (set) Token: 0x0603ACE4 RID: 240868 RVA: 0x007E7877 File Offset: 0x007E5A77
		public object Value { get; set; }

		// Token: 0x0603ACE5 RID: 240869 RVA: 0x007E7880 File Offset: 0x007E5A80
		public TPathLineFacingConfigUnion()
		{
			this.Type = TPathLineFacingConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603ACE6 RID: 240870 RVA: 0x007E7896 File Offset: 0x007E5A96
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ACE7 RID: 240871 RVA: 0x007E78A8 File Offset: 0x007E5AA8
		public IPathLineFacingCurrentDirectionT AsIPathLineFacingCurrentDirection()
		{
			return this.As<IPathLineFacingCurrentDirectionT>();
		}

		// Token: 0x0603ACE8 RID: 240872 RVA: 0x007E78B0 File Offset: 0x007E5AB0
		public static TPathLineFacingConfigUnion FromIPathLineFacingCurrentDirection(IPathLineFacingCurrentDirectionT _ipathlinefacingcurrentdirection)
		{
			return new TPathLineFacingConfigUnion
			{
				Type = TPathLineFacingConfig.IPathLineFacingCurrentDirection,
				Value = _ipathlinefacingcurrentdirection
			};
		}

		// Token: 0x0603ACE9 RID: 240873 RVA: 0x007E78C5 File Offset: 0x007E5AC5
		public IPathLineFacingCustomDirectionT AsIPathLineFacingCustomDirection()
		{
			return this.As<IPathLineFacingCustomDirectionT>();
		}

		// Token: 0x0603ACEA RID: 240874 RVA: 0x007E78CD File Offset: 0x007E5ACD
		public static TPathLineFacingConfigUnion FromIPathLineFacingCustomDirection(IPathLineFacingCustomDirectionT _ipathlinefacingcustomdirection)
		{
			return new TPathLineFacingConfigUnion
			{
				Type = TPathLineFacingConfig.IPathLineFacingCustomDirection,
				Value = _ipathlinefacingcustomdirection
			};
		}

		// Token: 0x0603ACEB RID: 240875 RVA: 0x007E78E4 File Offset: 0x007E5AE4
		public static int Pack(FlatBufferBuilder builder, TPathLineFacingConfigUnion _o)
		{
			TPathLineFacingConfig type = _o.Type;
			if (type == TPathLineFacingConfig.IPathLineFacingCurrentDirection)
			{
				return IPathLineFacingCurrentDirection.Pack(builder, _o.AsIPathLineFacingCurrentDirection()).Value;
			}
			if (type != TPathLineFacingConfig.IPathLineFacingCustomDirection)
			{
				return 0;
			}
			return IPathLineFacingCustomDirection.Pack(builder, _o.AsIPathLineFacingCustomDirection()).Value;
		}
	}
}
