using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C9 RID: 22985
	public struct IInteractEntityPartBindBase : IFlatbufferObject
	{
		// Token: 0x1700A712 RID: 42770
		// (get) Token: 0x06025855 RID: 153685 RVA: 0x00525DB7 File Offset: 0x00523FB7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025856 RID: 153686 RVA: 0x00525DC4 File Offset: 0x00523FC4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025857 RID: 153687 RVA: 0x00525DCC File Offset: 0x00523FCC
		public static IInteractEntityPartBindBase GetRootAsIInteractEntityPartBindBase(ByteBuffer _bb)
		{
			return IInteractEntityPartBindBase.GetRootAsIInteractEntityPartBindBase(_bb, default(IInteractEntityPartBindBase));
		}

		// Token: 0x06025858 RID: 153688 RVA: 0x00525DE8 File Offset: 0x00523FE8
		public static IInteractEntityPartBindBase GetRootAsIInteractEntityPartBindBase(ByteBuffer _bb, IInteractEntityPartBindBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025859 RID: 153689 RVA: 0x00525E05 File Offset: 0x00524005
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602585A RID: 153690 RVA: 0x00525E14 File Offset: 0x00524014
		public IInteractEntityPartBindBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A713 RID: 42771
		// (get) Token: 0x0602585B RID: 153691 RVA: 0x00525E24 File Offset: 0x00524024
		public EInteractEntityPartBindType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractEntityPartBindType.Prefab;
				}
				return (EInteractEntityPartBindType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602585C RID: 153692 RVA: 0x00525E60 File Offset: 0x00524060
		public static Offset<IInteractEntityPartBindBase> CreateIInteractEntityPartBindBase(FlatBufferBuilder builder, EInteractEntityPartBindType Type = EInteractEntityPartBindType.Prefab)
		{
			builder.StartTable(1);
			IInteractEntityPartBindBase.AddType(builder, Type);
			return IInteractEntityPartBindBase.EndIInteractEntityPartBindBase(builder);
		}

		// Token: 0x0602585D RID: 153693 RVA: 0x00525E76 File Offset: 0x00524076
		public static void StartIInteractEntityPartBindBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602585E RID: 153694 RVA: 0x00525E7F File Offset: 0x0052407F
		public static void AddType(FlatBufferBuilder builder, EInteractEntityPartBindType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602585F RID: 153695 RVA: 0x00525E8A File Offset: 0x0052408A
		public static Offset<IInteractEntityPartBindBase> EndIInteractEntityPartBindBase(FlatBufferBuilder builder)
		{
			return new Offset<IInteractEntityPartBindBase>(builder.EndTable());
		}

		// Token: 0x06025860 RID: 153696 RVA: 0x00525E98 File Offset: 0x00524098
		public IInteractEntityPartBindBaseT UnPack()
		{
			IInteractEntityPartBindBaseT interactEntityPartBindBaseT = new IInteractEntityPartBindBaseT();
			this.UnPackTo(interactEntityPartBindBaseT);
			return interactEntityPartBindBaseT;
		}

		// Token: 0x06025861 RID: 153697 RVA: 0x00525EB3 File Offset: 0x005240B3
		public void UnPackTo(IInteractEntityPartBindBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025862 RID: 153698 RVA: 0x00525EC4 File Offset: 0x005240C4
		public static Offset<IInteractEntityPartBindBase> Pack(FlatBufferBuilder builder, IInteractEntityPartBindBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractEntityPartBindBase>);
			}
			return IInteractEntityPartBindBase.CreateIInteractEntityPartBindBase(builder, _o.Type);
		}

		// Token: 0x0400F2E6 RID: 62182
		private Table __p;
	}
}
