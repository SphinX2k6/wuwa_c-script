using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056CD RID: 22221
	public struct IEntityBundleChildInfo : IFlatbufferObject
	{
		// Token: 0x17009FEC RID: 40940
		// (get) Token: 0x060239AE RID: 145838 RVA: 0x004E552A File Offset: 0x004E372A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060239AF RID: 145839 RVA: 0x004E5537 File Offset: 0x004E3737
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060239B0 RID: 145840 RVA: 0x004E5540 File Offset: 0x004E3740
		public static IEntityBundleChildInfo GetRootAsIEntityBundleChildInfo(ByteBuffer _bb)
		{
			return IEntityBundleChildInfo.GetRootAsIEntityBundleChildInfo(_bb, default(IEntityBundleChildInfo));
		}

		// Token: 0x060239B1 RID: 145841 RVA: 0x004E555C File Offset: 0x004E375C
		public static IEntityBundleChildInfo GetRootAsIEntityBundleChildInfo(ByteBuffer _bb, IEntityBundleChildInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060239B2 RID: 145842 RVA: 0x004E5579 File Offset: 0x004E3779
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060239B3 RID: 145843 RVA: 0x004E5588 File Offset: 0x004E3788
		public IEntityBundleChildInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FED RID: 40941
		// (get) Token: 0x060239B4 RID: 145844 RVA: 0x004E5598 File Offset: 0x004E3798
		public bool IsDisable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009FEE RID: 40942
		// (get) Token: 0x060239B5 RID: 145845 RVA: 0x004E55D8 File Offset: 0x004E37D8
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

		// Token: 0x17009FEF RID: 40943
		// (get) Token: 0x060239B6 RID: 145846 RVA: 0x004E5614 File Offset: 0x004E3814
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

		// Token: 0x060239B7 RID: 145847 RVA: 0x004E5650 File Offset: 0x004E3850
		public static Offset<IEntityBundleChildInfo> CreateIEntityBundleChildInfo(FlatBufferBuilder builder, bool IsDisable = false, int ChildId = 0, int EntityId = 0)
		{
			builder.StartTable(3);
			IEntityBundleChildInfo.AddEntityId(builder, EntityId);
			IEntityBundleChildInfo.AddChildId(builder, ChildId);
			IEntityBundleChildInfo.AddIsDisable(builder, IsDisable);
			return IEntityBundleChildInfo.EndIEntityBundleChildInfo(builder);
		}

		// Token: 0x060239B8 RID: 145848 RVA: 0x004E5674 File Offset: 0x004E3874
		public static void StartIEntityBundleChildInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060239B9 RID: 145849 RVA: 0x004E567D File Offset: 0x004E387D
		public static void AddIsDisable(FlatBufferBuilder builder, bool isDisable)
		{
			builder.AddBool(0, isDisable, false);
		}

		// Token: 0x060239BA RID: 145850 RVA: 0x004E5688 File Offset: 0x004E3888
		public static void AddChildId(FlatBufferBuilder builder, int childId)
		{
			builder.AddInt(1, childId, 0);
		}

		// Token: 0x060239BB RID: 145851 RVA: 0x004E5693 File Offset: 0x004E3893
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x060239BC RID: 145852 RVA: 0x004E569E File Offset: 0x004E389E
		public static Offset<IEntityBundleChildInfo> EndIEntityBundleChildInfo(FlatBufferBuilder builder)
		{
			return new Offset<IEntityBundleChildInfo>(builder.EndTable());
		}

		// Token: 0x060239BD RID: 145853 RVA: 0x004E56AC File Offset: 0x004E38AC
		public IEntityBundleChildInfoT UnPack()
		{
			IEntityBundleChildInfoT entityBundleChildInfoT = new IEntityBundleChildInfoT();
			this.UnPackTo(entityBundleChildInfoT);
			return entityBundleChildInfoT;
		}

		// Token: 0x060239BE RID: 145854 RVA: 0x004E56C7 File Offset: 0x004E38C7
		public void UnPackTo(IEntityBundleChildInfoT _o)
		{
			_o.IsDisable = this.IsDisable;
			_o.ChildId = this.ChildId;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x060239BF RID: 145855 RVA: 0x004E56F0 File Offset: 0x004E38F0
		public static Offset<IEntityBundleChildInfo> Pack(FlatBufferBuilder builder, IEntityBundleChildInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityBundleChildInfo>);
			}
			return IEntityBundleChildInfo.CreateIEntityBundleChildInfo(builder, _o.IsDisable, _o.ChildId, _o.EntityId);
		}

		// Token: 0x0400EE0F RID: 60943
		private Table __p;
	}
}
