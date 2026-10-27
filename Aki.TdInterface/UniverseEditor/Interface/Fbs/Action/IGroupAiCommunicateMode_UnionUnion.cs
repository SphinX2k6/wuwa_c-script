using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068AA RID: 26794
	public class IGroupAiCommunicateMode_UnionUnion
	{
		// Token: 0x1700C6E7 RID: 50919
		// (get) Token: 0x0602EBB8 RID: 191416 RVA: 0x0065ECF5 File Offset: 0x0065CEF5
		// (set) Token: 0x0602EBB9 RID: 191417 RVA: 0x0065ECFD File Offset: 0x0065CEFD
		public IGroupAiCommunicateMode_Union Type { get; set; }

		// Token: 0x1700C6E8 RID: 50920
		// (get) Token: 0x0602EBBA RID: 191418 RVA: 0x0065ED06 File Offset: 0x0065CF06
		// (set) Token: 0x0602EBBB RID: 191419 RVA: 0x0065ED0E File Offset: 0x0065CF0E
		public object Value { get; set; }

		// Token: 0x0602EBBC RID: 191420 RVA: 0x0065ED17 File Offset: 0x0065CF17
		public IGroupAiCommunicateMode_UnionUnion()
		{
			this.Type = IGroupAiCommunicateMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602EBBD RID: 191421 RVA: 0x0065ED2D File Offset: 0x0065CF2D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602EBBE RID: 191422 RVA: 0x0065ED3F File Offset: 0x0065CF3F
		public IGroupAiCommunicateModeT AsIGroupAiCommunicateMode()
		{
			return this.As<IGroupAiCommunicateModeT>();
		}

		// Token: 0x0602EBBF RID: 191423 RVA: 0x0065ED47 File Offset: 0x0065CF47
		public static IGroupAiCommunicateMode_UnionUnion FromIGroupAiCommunicateMode(IGroupAiCommunicateModeT _igroupaicommunicatemode)
		{
			return new IGroupAiCommunicateMode_UnionUnion
			{
				Type = IGroupAiCommunicateMode_Union.IGroupAiCommunicateMode,
				Value = _igroupaicommunicatemode
			};
		}

		// Token: 0x0602EBC0 RID: 191424 RVA: 0x0065ED5C File Offset: 0x0065CF5C
		public IGroupAiCommunicateAddTagT AsIGroupAiCommunicateAddTag()
		{
			return this.As<IGroupAiCommunicateAddTagT>();
		}

		// Token: 0x0602EBC1 RID: 191425 RVA: 0x0065ED64 File Offset: 0x0065CF64
		public static IGroupAiCommunicateMode_UnionUnion FromIGroupAiCommunicateAddTag(IGroupAiCommunicateAddTagT _igroupaicommunicateaddtag)
		{
			return new IGroupAiCommunicateMode_UnionUnion
			{
				Type = IGroupAiCommunicateMode_Union.IGroupAiCommunicateAddTag,
				Value = _igroupaicommunicateaddtag
			};
		}

		// Token: 0x0602EBC2 RID: 191426 RVA: 0x0065ED79 File Offset: 0x0065CF79
		public IGroupAiCommunicateRemoveTagT AsIGroupAiCommunicateRemoveTag()
		{
			return this.As<IGroupAiCommunicateRemoveTagT>();
		}

		// Token: 0x0602EBC3 RID: 191427 RVA: 0x0065ED81 File Offset: 0x0065CF81
		public static IGroupAiCommunicateMode_UnionUnion FromIGroupAiCommunicateRemoveTag(IGroupAiCommunicateRemoveTagT _igroupaicommunicateremovetag)
		{
			return new IGroupAiCommunicateMode_UnionUnion
			{
				Type = IGroupAiCommunicateMode_Union.IGroupAiCommunicateRemoveTag,
				Value = _igroupaicommunicateremovetag
			};
		}

		// Token: 0x0602EBC4 RID: 191428 RVA: 0x0065ED98 File Offset: 0x0065CF98
		public static int Pack(FlatBufferBuilder builder, IGroupAiCommunicateMode_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IGroupAiCommunicateMode_Union.IGroupAiCommunicateMode:
				return IGroupAiCommunicateMode.Pack(builder, _o.AsIGroupAiCommunicateMode()).Value;
			case IGroupAiCommunicateMode_Union.IGroupAiCommunicateAddTag:
				return IGroupAiCommunicateAddTag.Pack(builder, _o.AsIGroupAiCommunicateAddTag()).Value;
			case IGroupAiCommunicateMode_Union.IGroupAiCommunicateRemoveTag:
				return IGroupAiCommunicateRemoveTag.Pack(builder, _o.AsIGroupAiCommunicateRemoveTag()).Value;
			default:
				return 0;
			}
		}
	}
}
