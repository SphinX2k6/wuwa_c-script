using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008046 RID: 32838
	public class TVillageInfrBuildTypeUnion
	{
		// Token: 0x1700F351 RID: 62289
		// (get) Token: 0x0603B12D RID: 241965 RVA: 0x007EE052 File Offset: 0x007EC252
		// (set) Token: 0x0603B12E RID: 241966 RVA: 0x007EE05A File Offset: 0x007EC25A
		public TVillageInfrBuildType Type { get; set; }

		// Token: 0x1700F352 RID: 62290
		// (get) Token: 0x0603B12F RID: 241967 RVA: 0x007EE063 File Offset: 0x007EC263
		// (set) Token: 0x0603B130 RID: 241968 RVA: 0x007EE06B File Offset: 0x007EC26B
		public object Value { get; set; }

		// Token: 0x0603B131 RID: 241969 RVA: 0x007EE074 File Offset: 0x007EC274
		public TVillageInfrBuildTypeUnion()
		{
			this.Type = TVillageInfrBuildType.NONE;
			this.Value = null;
		}

		// Token: 0x0603B132 RID: 241970 RVA: 0x007EE08A File Offset: 0x007EC28A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B133 RID: 241971 RVA: 0x007EE09C File Offset: 0x007EC29C
		public IVillageInfrTreeProcessT AsIVillageInfrTreeProcess()
		{
			return this.As<IVillageInfrTreeProcessT>();
		}

		// Token: 0x0603B134 RID: 241972 RVA: 0x007EE0A4 File Offset: 0x007EC2A4
		public static TVillageInfrBuildTypeUnion FromIVillageInfrTreeProcess(IVillageInfrTreeProcessT _ivillageinfrtreeprocess)
		{
			return new TVillageInfrBuildTypeUnion
			{
				Type = TVillageInfrBuildType.IVillageInfrTreeProcess,
				Value = _ivillageinfrtreeprocess
			};
		}

		// Token: 0x0603B135 RID: 241973 RVA: 0x007EE0B9 File Offset: 0x007EC2B9
		public IVillageInfrVillageLevelT AsIVillageInfrVillageLevel()
		{
			return this.As<IVillageInfrVillageLevelT>();
		}

		// Token: 0x0603B136 RID: 241974 RVA: 0x007EE0C1 File Offset: 0x007EC2C1
		public static TVillageInfrBuildTypeUnion FromIVillageInfrVillageLevel(IVillageInfrVillageLevelT _ivillageinfrvillagelevel)
		{
			return new TVillageInfrBuildTypeUnion
			{
				Type = TVillageInfrBuildType.IVillageInfrVillageLevel,
				Value = _ivillageinfrvillagelevel
			};
		}

		// Token: 0x0603B137 RID: 241975 RVA: 0x007EE0D8 File Offset: 0x007EC2D8
		public static int Pack(FlatBufferBuilder builder, TVillageInfrBuildTypeUnion _o)
		{
			TVillageInfrBuildType type = _o.Type;
			if (type == TVillageInfrBuildType.IVillageInfrTreeProcess)
			{
				return IVillageInfrTreeProcess.Pack(builder, _o.AsIVillageInfrTreeProcess()).Value;
			}
			if (type != TVillageInfrBuildType.IVillageInfrVillageLevel)
			{
				return 0;
			}
			return IVillageInfrVillageLevel.Pack(builder, _o.AsIVillageInfrVillageLevel()).Value;
		}
	}
}
