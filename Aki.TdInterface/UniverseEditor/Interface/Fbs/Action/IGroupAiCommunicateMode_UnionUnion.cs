using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F4B RID: 28491
	public class IGroupAiCommunicateMode_UnionUnion
	{
		// Token: 0x1700D0CD RID: 53453
		// (get) Token: 0x060314F2 RID: 201970 RVA: 0x006ADD75 File Offset: 0x006ABF75
		// (set) Token: 0x060314F3 RID: 201971 RVA: 0x006ADD7D File Offset: 0x006ABF7D
		public IGroupAiCommunicateMode_Union Type { get; set; }

		// Token: 0x1700D0CE RID: 53454
		// (get) Token: 0x060314F4 RID: 201972 RVA: 0x006ADD86 File Offset: 0x006ABF86
		// (set) Token: 0x060314F5 RID: 201973 RVA: 0x006ADD8E File Offset: 0x006ABF8E
		public object Value { get; set; }

		// Token: 0x060314F6 RID: 201974 RVA: 0x006ADD97 File Offset: 0x006ABF97
		public IGroupAiCommunicateMode_UnionUnion()
		{
			this.Type = IGroupAiCommunicateMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060314F7 RID: 201975 RVA: 0x006ADDAD File Offset: 0x006ABFAD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060314F8 RID: 201976 RVA: 0x006ADDBF File Offset: 0x006ABFBF
		public IGroupAiCommunicateModeT AsIGroupAiCommunicateMode()
		{
			return this.As<IGroupAiCommunicateModeT>();
		}

		// Token: 0x060314F9 RID: 201977 RVA: 0x006ADDC7 File Offset: 0x006ABFC7
		public static IGroupAiCommunicateMode_UnionUnion FromIGroupAiCommunicateMode(IGroupAiCommunicateModeT _igroupaicommunicatemode)
		{
			return new IGroupAiCommunicateMode_UnionUnion
			{
				Type = IGroupAiCommunicateMode_Union.IGroupAiCommunicateMode,
				Value = _igroupaicommunicatemode
			};
		}

		// Token: 0x060314FA RID: 201978 RVA: 0x006ADDDC File Offset: 0x006ABFDC
		public IGroupAiCommunicateAddTagT AsIGroupAiCommunicateAddTag()
		{
			return this.As<IGroupAiCommunicateAddTagT>();
		}

		// Token: 0x060314FB RID: 201979 RVA: 0x006ADDE4 File Offset: 0x006ABFE4
		public static IGroupAiCommunicateMode_UnionUnion FromIGroupAiCommunicateAddTag(IGroupAiCommunicateAddTagT _igroupaicommunicateaddtag)
		{
			return new IGroupAiCommunicateMode_UnionUnion
			{
				Type = IGroupAiCommunicateMode_Union.IGroupAiCommunicateAddTag,
				Value = _igroupaicommunicateaddtag
			};
		}

		// Token: 0x060314FC RID: 201980 RVA: 0x006ADDF9 File Offset: 0x006ABFF9
		public IGroupAiCommunicateRemoveTagT AsIGroupAiCommunicateRemoveTag()
		{
			return this.As<IGroupAiCommunicateRemoveTagT>();
		}

		// Token: 0x060314FD RID: 201981 RVA: 0x006ADE01 File Offset: 0x006AC001
		public static IGroupAiCommunicateMode_UnionUnion FromIGroupAiCommunicateRemoveTag(IGroupAiCommunicateRemoveTagT _igroupaicommunicateremovetag)
		{
			return new IGroupAiCommunicateMode_UnionUnion
			{
				Type = IGroupAiCommunicateMode_Union.IGroupAiCommunicateRemoveTag,
				Value = _igroupaicommunicateremovetag
			};
		}

		// Token: 0x060314FE RID: 201982 RVA: 0x006ADE18 File Offset: 0x006AC018
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
