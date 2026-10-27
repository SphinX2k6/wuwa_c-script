using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BEC RID: 7148
	[NullableContext(1)]
	[Nullable(0)]
	public class IModifySelfSceneItemAttributeTag : ModifySceneItemAttributeTag
	{
		// Token: 0x06009911 RID: 39185 RVA: 0x001606FC File Offset: 0x0015E8FC
		private IModifySelfSceneItemAttributeTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IModifySelfSceneItemAttributeTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IModifySelfSceneItemAttributeTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IModifySelfSceneItemAttributeTag_SetValue());
			}
			return result;
		}

		// Token: 0x06009912 RID: 39186 RVA: 0x00160734 File Offset: 0x0015E934
		public static IModifySelfSceneItemAttributeTag Create([Nullable(2)] IModifySelfSceneItemAttributeTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifySelfSceneItemAttributeTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009913 RID: 39187 RVA: 0x00160747 File Offset: 0x0015E947
		public static IModifySelfSceneItemAttributeTag CreateFromSetValue([Nullable(2)] IModifySelfSceneItemAttributeTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IModifySelfSceneItemAttributeTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009914 RID: 39188 RVA: 0x0016075A File Offset: 0x0015E95A
		public new IModifySelfSceneItemAttributeTag_SetValue ToSetValue()
		{
			return new IModifySelfSceneItemAttributeTag_SetValue
			{
				Type = this.Type,
				IsAddTag = this.IsAddTag,
				PerformanceTag = this.PerformanceTag
			};
		}

		// Token: 0x17002FFD RID: 12285
		// (get) Token: 0x06009915 RID: 39189 RVA: 0x00160785 File Offset: 0x0015E985
		// (set) Token: 0x06009916 RID: 39190 RVA: 0x001607B0 File Offset: 0x0015E9B0
		public override EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EChangeEntityPrefabPerformanceType.Target;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002FFE RID: 12286
		// (get) Token: 0x06009917 RID: 39191 RVA: 0x001607BE File Offset: 0x0015E9BE
		// (set) Token: 0x06009918 RID: 39192 RVA: 0x001607E9 File Offset: 0x0015E9E9
		public override bool IsAddTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAddTag;
				}
				return this.PocoInterface != null && this.PocoInterface.IsAddTag;
			}
			set
			{
				this.GetOrCreatePoco().IsAddTag = value;
			}
		}

		// Token: 0x17002FFF RID: 12287
		// (get) Token: 0x06009919 RID: 39193 RVA: 0x001607F7 File Offset: 0x0015E9F7
		// (set) Token: 0x0600991A RID: 39194 RVA: 0x0016081E File Offset: 0x0015EA1E
		public override List<int> PerformanceTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformanceTag;
				}
				IModifySelfSceneItemAttributeTag_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PerformanceTag;
			}
			set
			{
				this.GetOrCreatePoco().PerformanceTag = value;
			}
		}

		// Token: 0x04005D40 RID: 23872
		[Nullable(2)]
		protected new IModifySelfSceneItemAttributeTag FbInstance;

		// Token: 0x04005D41 RID: 23873
		[Nullable(2)]
		protected new IModifySelfSceneItemAttributeTag_SetValue PocoInterface;
	}
}
