using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BEE RID: 7150
	[NullableContext(1)]
	[Nullable(0)]
	public class IModifyTargetSceneItemAttributeTag : ModifySceneItemAttributeTag
	{
		// Token: 0x0600991D RID: 39197 RVA: 0x0016083C File Offset: 0x0015EA3C
		private IModifyTargetSceneItemAttributeTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IModifyTargetSceneItemAttributeTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IModifyTargetSceneItemAttributeTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IModifyTargetSceneItemAttributeTag_SetValue());
			}
			return result;
		}

		// Token: 0x0600991E RID: 39198 RVA: 0x00160874 File Offset: 0x0015EA74
		public static IModifyTargetSceneItemAttributeTag Create([Nullable(2)] IModifyTargetSceneItemAttributeTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyTargetSceneItemAttributeTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600991F RID: 39199 RVA: 0x00160887 File Offset: 0x0015EA87
		public static IModifyTargetSceneItemAttributeTag CreateFromSetValue([Nullable(2)] IModifyTargetSceneItemAttributeTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IModifyTargetSceneItemAttributeTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009920 RID: 39200 RVA: 0x0016089A File Offset: 0x0015EA9A
		public new IModifyTargetSceneItemAttributeTag_SetValue ToSetValue()
		{
			return new IModifyTargetSceneItemAttributeTag_SetValue
			{
				Type = this.Type,
				IsAddTag = this.IsAddTag,
				PerformanceTag = this.PerformanceTag,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17003000 RID: 12288
		// (get) Token: 0x06009921 RID: 39201 RVA: 0x001608D1 File Offset: 0x0015EAD1
		// (set) Token: 0x06009922 RID: 39202 RVA: 0x001608FC File Offset: 0x0015EAFC
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

		// Token: 0x17003001 RID: 12289
		// (get) Token: 0x06009923 RID: 39203 RVA: 0x0016090A File Offset: 0x0015EB0A
		// (set) Token: 0x06009924 RID: 39204 RVA: 0x00160935 File Offset: 0x0015EB35
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

		// Token: 0x17003002 RID: 12290
		// (get) Token: 0x06009925 RID: 39205 RVA: 0x00160943 File Offset: 0x0015EB43
		// (set) Token: 0x06009926 RID: 39206 RVA: 0x0016096A File Offset: 0x0015EB6A
		public override List<int> PerformanceTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformanceTag;
				}
				IModifyTargetSceneItemAttributeTag_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003003 RID: 12291
		// (get) Token: 0x06009927 RID: 39207 RVA: 0x00160978 File Offset: 0x0015EB78
		// (set) Token: 0x06009928 RID: 39208 RVA: 0x0016099F File Offset: 0x0015EB9F
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IModifyTargetSceneItemAttributeTag_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x04005D45 RID: 23877
		[Nullable(2)]
		protected new IModifyTargetSceneItemAttributeTag FbInstance;

		// Token: 0x04005D46 RID: 23878
		[Nullable(2)]
		protected new IModifyTargetSceneItemAttributeTag_SetValue PocoInterface;
	}
}
