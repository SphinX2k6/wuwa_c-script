using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FB5 RID: 20405
	public struct ICollectComponent : IFlatbufferObject
	{
		// Token: 0x170093CA RID: 37834
		// (get) Token: 0x060207AF RID: 133039 RVA: 0x00484CFA File Offset: 0x00482EFA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060207B0 RID: 133040 RVA: 0x00484D07 File Offset: 0x00482F07
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060207B1 RID: 133041 RVA: 0x00484D10 File Offset: 0x00482F10
		public static ICollectComponent GetRootAsICollectComponent(ByteBuffer _bb)
		{
			return ICollectComponent.GetRootAsICollectComponent(_bb, default(ICollectComponent));
		}

		// Token: 0x060207B2 RID: 133042 RVA: 0x00484D2C File Offset: 0x00482F2C
		public static ICollectComponent GetRootAsICollectComponent(ByteBuffer _bb, ICollectComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060207B3 RID: 133043 RVA: 0x00484D49 File Offset: 0x00482F49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060207B4 RID: 133044 RVA: 0x00484D58 File Offset: 0x00482F58
		public ICollectComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093CB RID: 37835
		// (get) Token: 0x060207B5 RID: 133045 RVA: 0x00484D68 File Offset: 0x00482F68
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170093CC RID: 37836
		// (get) Token: 0x060207B6 RID: 133046 RVA: 0x00484DA8 File Offset: 0x00482FA8
		public bool IsDisableOneClickCollection
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170093CD RID: 37837
		// (get) Token: 0x060207B7 RID: 133047 RVA: 0x00484DE8 File Offset: 0x00482FE8
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

		// Token: 0x060207B8 RID: 133048 RVA: 0x00484E24 File Offset: 0x00483024
		public static Offset<ICollectComponent> CreateICollectComponent(FlatBufferBuilder builder, bool Disabled = false, bool IsDisableOneClickCollection = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICollectComponent.AddNullMask(builder, NullMask);
			ICollectComponent.AddIsDisableOneClickCollection(builder, IsDisableOneClickCollection);
			ICollectComponent.AddDisabled(builder, Disabled);
			return ICollectComponent.EndICollectComponent(builder);
		}

		// Token: 0x060207B9 RID: 133049 RVA: 0x00484E48 File Offset: 0x00483048
		public static void StartICollectComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060207BA RID: 133050 RVA: 0x00484E51 File Offset: 0x00483051
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060207BB RID: 133051 RVA: 0x00484E5C File Offset: 0x0048305C
		public static void AddIsDisableOneClickCollection(FlatBufferBuilder builder, bool isDisableOneClickCollection)
		{
			builder.AddBool(1, isDisableOneClickCollection, false);
		}

		// Token: 0x060207BC RID: 133052 RVA: 0x00484E67 File Offset: 0x00483067
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060207BD RID: 133053 RVA: 0x00484E72 File Offset: 0x00483072
		public static Offset<ICollectComponent> EndICollectComponent(FlatBufferBuilder builder)
		{
			return new Offset<ICollectComponent>(builder.EndTable());
		}

		// Token: 0x060207BE RID: 133054 RVA: 0x00484E80 File Offset: 0x00483080
		public ICollectComponentT UnPack()
		{
			ICollectComponentT collectComponentT = new ICollectComponentT();
			this.UnPackTo(collectComponentT);
			return collectComponentT;
		}

		// Token: 0x060207BF RID: 133055 RVA: 0x00484E9B File Offset: 0x0048309B
		public void UnPackTo(ICollectComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.IsDisableOneClickCollection = this.IsDisableOneClickCollection;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060207C0 RID: 133056 RVA: 0x00484EC4 File Offset: 0x004830C4
		public static Offset<ICollectComponent> Pack(FlatBufferBuilder builder, ICollectComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICollectComponent>);
			}
			return ICollectComponent.CreateICollectComponent(builder, _o.Disabled, _o.IsDisableOneClickCollection, _o.NullMask);
		}

		// Token: 0x0400DE8F RID: 56975
		private Table __p;
	}
}
