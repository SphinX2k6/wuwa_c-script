using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005511 RID: 21777
	public struct ICollectComponent : IFlatbufferObject
	{
		// Token: 0x17009BA2 RID: 39842
		// (get) Token: 0x060226A3 RID: 140963 RVA: 0x004BE1DE File Offset: 0x004BC3DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060226A4 RID: 140964 RVA: 0x004BE1EB File Offset: 0x004BC3EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060226A5 RID: 140965 RVA: 0x004BE1F4 File Offset: 0x004BC3F4
		public static ICollectComponent GetRootAsICollectComponent(ByteBuffer _bb)
		{
			return ICollectComponent.GetRootAsICollectComponent(_bb, default(ICollectComponent));
		}

		// Token: 0x060226A6 RID: 140966 RVA: 0x004BE210 File Offset: 0x004BC410
		public static ICollectComponent GetRootAsICollectComponent(ByteBuffer _bb, ICollectComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060226A7 RID: 140967 RVA: 0x004BE22D File Offset: 0x004BC42D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060226A8 RID: 140968 RVA: 0x004BE23C File Offset: 0x004BC43C
		public ICollectComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BA3 RID: 39843
		// (get) Token: 0x060226A9 RID: 140969 RVA: 0x004BE24C File Offset: 0x004BC44C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009BA4 RID: 39844
		// (get) Token: 0x060226AA RID: 140970 RVA: 0x004BE28C File Offset: 0x004BC48C
		public bool IsDisableOneClickCollection
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009BA5 RID: 39845
		// (get) Token: 0x060226AB RID: 140971 RVA: 0x004BE2CC File Offset: 0x004BC4CC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060226AC RID: 140972 RVA: 0x004BE308 File Offset: 0x004BC508
		public static Offset<ICollectComponent> CreateICollectComponent(FlatBufferBuilder builder, bool Disabled = false, bool IsDisableOneClickCollection = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICollectComponent.AddNullMask(builder, NullMask);
			ICollectComponent.AddIsDisableOneClickCollection(builder, IsDisableOneClickCollection);
			ICollectComponent.AddDisabled(builder, Disabled);
			return ICollectComponent.EndICollectComponent(builder);
		}

		// Token: 0x060226AD RID: 140973 RVA: 0x004BE32C File Offset: 0x004BC52C
		public static void StartICollectComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060226AE RID: 140974 RVA: 0x004BE335 File Offset: 0x004BC535
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060226AF RID: 140975 RVA: 0x004BE340 File Offset: 0x004BC540
		public static void AddIsDisableOneClickCollection(FlatBufferBuilder builder, bool isDisableOneClickCollection)
		{
			builder.AddBool(1, isDisableOneClickCollection, false);
		}

		// Token: 0x060226B0 RID: 140976 RVA: 0x004BE34B File Offset: 0x004BC54B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060226B1 RID: 140977 RVA: 0x004BE356 File Offset: 0x004BC556
		public static Offset<ICollectComponent> EndICollectComponent(FlatBufferBuilder builder)
		{
			return new Offset<ICollectComponent>(builder.EndTable());
		}

		// Token: 0x060226B2 RID: 140978 RVA: 0x004BE364 File Offset: 0x004BC564
		public ICollectComponentT UnPack()
		{
			ICollectComponentT collectComponentT = new ICollectComponentT();
			this.UnPackTo(collectComponentT);
			return collectComponentT;
		}

		// Token: 0x060226B3 RID: 140979 RVA: 0x004BE37F File Offset: 0x004BC57F
		public void UnPackTo(ICollectComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.IsDisableOneClickCollection = this.IsDisableOneClickCollection;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060226B4 RID: 140980 RVA: 0x004BE3A8 File Offset: 0x004BC5A8
		public static Offset<ICollectComponent> Pack(FlatBufferBuilder builder, ICollectComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICollectComponent>);
			}
			return ICollectComponent.CreateICollectComponent(builder, _o.Disabled, _o.IsDisableOneClickCollection, _o.NullMask);
		}

		// Token: 0x0400EA7D RID: 60029
		private Table __p;
	}
}
