using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007808 RID: 30728
	public class TVillageInfrBuildTypeUnion
	{
		// Token: 0x1700E6F3 RID: 59123
		// (get) Token: 0x06037B88 RID: 228232 RVA: 0x007886DA File Offset: 0x007868DA
		// (set) Token: 0x06037B89 RID: 228233 RVA: 0x007886E2 File Offset: 0x007868E2
		public TVillageInfrBuildType Type { get; set; }

		// Token: 0x1700E6F4 RID: 59124
		// (get) Token: 0x06037B8A RID: 228234 RVA: 0x007886EB File Offset: 0x007868EB
		// (set) Token: 0x06037B8B RID: 228235 RVA: 0x007886F3 File Offset: 0x007868F3
		public object Value { get; set; }

		// Token: 0x06037B8C RID: 228236 RVA: 0x007886FC File Offset: 0x007868FC
		public TVillageInfrBuildTypeUnion()
		{
			this.Type = TVillageInfrBuildType.NONE;
			this.Value = null;
		}

		// Token: 0x06037B8D RID: 228237 RVA: 0x00788712 File Offset: 0x00786912
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037B8E RID: 228238 RVA: 0x00788724 File Offset: 0x00786924
		public IVillageInfrTreeProcessT AsIVillageInfrTreeProcess()
		{
			return this.As<IVillageInfrTreeProcessT>();
		}

		// Token: 0x06037B8F RID: 228239 RVA: 0x0078872C File Offset: 0x0078692C
		public static TVillageInfrBuildTypeUnion FromIVillageInfrTreeProcess(IVillageInfrTreeProcessT _ivillageinfrtreeprocess)
		{
			return new TVillageInfrBuildTypeUnion
			{
				Type = TVillageInfrBuildType.IVillageInfrTreeProcess,
				Value = _ivillageinfrtreeprocess
			};
		}

		// Token: 0x06037B90 RID: 228240 RVA: 0x00788741 File Offset: 0x00786941
		public IVillageInfrVillageLevelT AsIVillageInfrVillageLevel()
		{
			return this.As<IVillageInfrVillageLevelT>();
		}

		// Token: 0x06037B91 RID: 228241 RVA: 0x00788749 File Offset: 0x00786949
		public static TVillageInfrBuildTypeUnion FromIVillageInfrVillageLevel(IVillageInfrVillageLevelT _ivillageinfrvillagelevel)
		{
			return new TVillageInfrBuildTypeUnion
			{
				Type = TVillageInfrBuildType.IVillageInfrVillageLevel,
				Value = _ivillageinfrvillagelevel
			};
		}

		// Token: 0x06037B92 RID: 228242 RVA: 0x00788760 File Offset: 0x00786960
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
