using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B69 RID: 15209
	public class TWoodenBoxProliferateSpawnConfigUnion
	{
		// Token: 0x17006830 RID: 26672
		// (get) Token: 0x06014CE5 RID: 85221 RVA: 0x00305A14 File Offset: 0x00303C14
		// (set) Token: 0x06014CE6 RID: 85222 RVA: 0x00305A1C File Offset: 0x00303C1C
		public TWoodenBoxProliferateSpawnConfig Type { get; set; }

		// Token: 0x17006831 RID: 26673
		// (get) Token: 0x06014CE7 RID: 85223 RVA: 0x00305A25 File Offset: 0x00303C25
		// (set) Token: 0x06014CE8 RID: 85224 RVA: 0x00305A2D File Offset: 0x00303C2D
		public object Value { get; set; }

		// Token: 0x06014CE9 RID: 85225 RVA: 0x00305A36 File Offset: 0x00303C36
		public TWoodenBoxProliferateSpawnConfigUnion()
		{
			this.Type = TWoodenBoxProliferateSpawnConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06014CEA RID: 85226 RVA: 0x00305A4C File Offset: 0x00303C4C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06014CEB RID: 85227 RVA: 0x00305A5E File Offset: 0x00303C5E
		public IWoodenBoxProliferatePositionListT AsIWoodenBoxProliferatePositionList()
		{
			return this.As<IWoodenBoxProliferatePositionListT>();
		}

		// Token: 0x06014CEC RID: 85228 RVA: 0x00305A66 File Offset: 0x00303C66
		public static TWoodenBoxProliferateSpawnConfigUnion FromIWoodenBoxProliferatePositionList(IWoodenBoxProliferatePositionListT _iwoodenboxproliferatepositionlist)
		{
			return new TWoodenBoxProliferateSpawnConfigUnion
			{
				Type = TWoodenBoxProliferateSpawnConfig.IWoodenBoxProliferatePositionList,
				Value = _iwoodenboxproliferatepositionlist
			};
		}

		// Token: 0x06014CED RID: 85229 RVA: 0x00305A7B File Offset: 0x00303C7B
		public IWoodenBoxProliferateRandomInRangeT AsIWoodenBoxProliferateRandomInRange()
		{
			return this.As<IWoodenBoxProliferateRandomInRangeT>();
		}

		// Token: 0x06014CEE RID: 85230 RVA: 0x00305A83 File Offset: 0x00303C83
		public static TWoodenBoxProliferateSpawnConfigUnion FromIWoodenBoxProliferateRandomInRange(IWoodenBoxProliferateRandomInRangeT _iwoodenboxproliferaterandominrange)
		{
			return new TWoodenBoxProliferateSpawnConfigUnion
			{
				Type = TWoodenBoxProliferateSpawnConfig.IWoodenBoxProliferateRandomInRange,
				Value = _iwoodenboxproliferaterandominrange
			};
		}

		// Token: 0x06014CEF RID: 85231 RVA: 0x00305A98 File Offset: 0x00303C98
		public static int Pack(FlatBufferBuilder builder, TWoodenBoxProliferateSpawnConfigUnion _o)
		{
			TWoodenBoxProliferateSpawnConfig type = _o.Type;
			if (type == TWoodenBoxProliferateSpawnConfig.IWoodenBoxProliferatePositionList)
			{
				return IWoodenBoxProliferatePositionList.Pack(builder, _o.AsIWoodenBoxProliferatePositionList()).Value;
			}
			if (type != TWoodenBoxProliferateSpawnConfig.IWoodenBoxProliferateRandomInRange)
			{
				return 0;
			}
			return IWoodenBoxProliferateRandomInRange.Pack(builder, _o.AsIWoodenBoxProliferateRandomInRange()).Value;
		}
	}
}
