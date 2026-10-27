using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005168 RID: 20840
	public struct IEntityBundleChildInfo : IFlatbufferObject
	{
		// Token: 0x170097FF RID: 38911
		// (get) Token: 0x06021A5A RID: 137818 RVA: 0x004AB59E File Offset: 0x004A979E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021A5B RID: 137819 RVA: 0x004AB5AB File Offset: 0x004A97AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021A5C RID: 137820 RVA: 0x004AB5B4 File Offset: 0x004A97B4
		public static IEntityBundleChildInfo GetRootAsIEntityBundleChildInfo(ByteBuffer _bb)
		{
			return IEntityBundleChildInfo.GetRootAsIEntityBundleChildInfo(_bb, default(IEntityBundleChildInfo));
		}

		// Token: 0x06021A5D RID: 137821 RVA: 0x004AB5D0 File Offset: 0x004A97D0
		public static IEntityBundleChildInfo GetRootAsIEntityBundleChildInfo(ByteBuffer _bb, IEntityBundleChildInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021A5E RID: 137822 RVA: 0x004AB5ED File Offset: 0x004A97ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021A5F RID: 137823 RVA: 0x004AB5FC File Offset: 0x004A97FC
		public IEntityBundleChildInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009800 RID: 38912
		// (get) Token: 0x06021A60 RID: 137824 RVA: 0x004AB60C File Offset: 0x004A980C
		public bool IsDisable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009801 RID: 38913
		// (get) Token: 0x06021A61 RID: 137825 RVA: 0x004AB64C File Offset: 0x004A984C
		public int ChildId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009802 RID: 38914
		// (get) Token: 0x06021A62 RID: 137826 RVA: 0x004AB688 File Offset: 0x004A9888
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021A63 RID: 137827 RVA: 0x004AB6C4 File Offset: 0x004A98C4
		public static Offset<IEntityBundleChildInfo> CreateIEntityBundleChildInfo(FlatBufferBuilder builder, bool IsDisable = false, int ChildId = 0, int EntityId = 0)
		{
			builder.StartTable(3);
			IEntityBundleChildInfo.AddEntityId(builder, EntityId);
			IEntityBundleChildInfo.AddChildId(builder, ChildId);
			IEntityBundleChildInfo.AddIsDisable(builder, IsDisable);
			return IEntityBundleChildInfo.EndIEntityBundleChildInfo(builder);
		}

		// Token: 0x06021A64 RID: 137828 RVA: 0x004AB6E8 File Offset: 0x004A98E8
		public static void StartIEntityBundleChildInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021A65 RID: 137829 RVA: 0x004AB6F1 File Offset: 0x004A98F1
		public static void AddIsDisable(FlatBufferBuilder builder, bool isDisable)
		{
			builder.AddBool(0, isDisable, false);
		}

		// Token: 0x06021A66 RID: 137830 RVA: 0x004AB6FC File Offset: 0x004A98FC
		public static void AddChildId(FlatBufferBuilder builder, int childId)
		{
			builder.AddInt(1, childId, 0);
		}

		// Token: 0x06021A67 RID: 137831 RVA: 0x004AB707 File Offset: 0x004A9907
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x06021A68 RID: 137832 RVA: 0x004AB712 File Offset: 0x004A9912
		public static Offset<IEntityBundleChildInfo> EndIEntityBundleChildInfo(FlatBufferBuilder builder)
		{
			return new Offset<IEntityBundleChildInfo>(builder.EndTable());
		}

		// Token: 0x06021A69 RID: 137833 RVA: 0x004AB720 File Offset: 0x004A9920
		public IEntityBundleChildInfoT UnPack()
		{
			IEntityBundleChildInfoT entityBundleChildInfoT = new IEntityBundleChildInfoT();
			this.UnPackTo(entityBundleChildInfoT);
			return entityBundleChildInfoT;
		}

		// Token: 0x06021A6A RID: 137834 RVA: 0x004AB73B File Offset: 0x004A993B
		public void UnPackTo(IEntityBundleChildInfoT _o)
		{
			_o.IsDisable = this.IsDisable;
			_o.ChildId = this.ChildId;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06021A6B RID: 137835 RVA: 0x004AB764 File Offset: 0x004A9964
		public static Offset<IEntityBundleChildInfo> Pack(FlatBufferBuilder builder, IEntityBundleChildInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityBundleChildInfo>);
			}
			return IEntityBundleChildInfo.CreateIEntityBundleChildInfo(builder, _o.IsDisable, _o.ChildId, _o.EntityId);
		}

		// Token: 0x0400E212 RID: 57874
		private Table __p;
	}
}
