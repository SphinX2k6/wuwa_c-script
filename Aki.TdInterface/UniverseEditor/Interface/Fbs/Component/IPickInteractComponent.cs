using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D3D RID: 23869
	public struct IPickInteractComponent : IFlatbufferObject
	{
		// Token: 0x1700AF91 RID: 44945
		// (get) Token: 0x06027B2F RID: 162607 RVA: 0x0056E798 File Offset: 0x0056C998
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027B30 RID: 162608 RVA: 0x0056E7A5 File Offset: 0x0056C9A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027B31 RID: 162609 RVA: 0x0056E7AC File Offset: 0x0056C9AC
		public static IPickInteractComponent GetRootAsIPickInteractComponent(ByteBuffer _bb)
		{
			return IPickInteractComponent.GetRootAsIPickInteractComponent(_bb, default(IPickInteractComponent));
		}

		// Token: 0x06027B32 RID: 162610 RVA: 0x0056E7C8 File Offset: 0x0056C9C8
		public static IPickInteractComponent GetRootAsIPickInteractComponent(ByteBuffer _bb, IPickInteractComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027B33 RID: 162611 RVA: 0x0056E7E5 File Offset: 0x0056C9E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027B34 RID: 162612 RVA: 0x0056E7F4 File Offset: 0x0056C9F4
		public IPickInteractComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF92 RID: 44946
		// (get) Token: 0x06027B35 RID: 162613 RVA: 0x0056E804 File Offset: 0x0056CA04
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF93 RID: 44947
		// (get) Token: 0x06027B36 RID: 162614 RVA: 0x0056E844 File Offset: 0x0056CA44
		public IChessmanPickInteraction? PickInteractType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IChessmanPickInteraction?(default(IChessmanPickInteraction).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AF94 RID: 44948
		// (get) Token: 0x06027B37 RID: 162615 RVA: 0x0056E8A4 File Offset: 0x0056CAA4
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

		// Token: 0x06027B38 RID: 162616 RVA: 0x0056E8E0 File Offset: 0x0056CAE0
		public static Offset<IPickInteractComponent> CreateIPickInteractComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IChessmanPickInteraction> PickInteractTypeOffset = default(Offset<IChessmanPickInteraction>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IPickInteractComponent.AddPickInteractType(builder, PickInteractTypeOffset);
			IPickInteractComponent.AddNullMask(builder, NullMask);
			IPickInteractComponent.AddDisabled(builder, Disabled);
			return IPickInteractComponent.EndIPickInteractComponent(builder);
		}

		// Token: 0x06027B39 RID: 162617 RVA: 0x0056E904 File Offset: 0x0056CB04
		public static void StartIPickInteractComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027B3A RID: 162618 RVA: 0x0056E90D File Offset: 0x0056CB0D
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027B3B RID: 162619 RVA: 0x0056E918 File Offset: 0x0056CB18
		public static void AddPickInteractType(FlatBufferBuilder builder, Offset<IChessmanPickInteraction> pickInteractTypeOffset)
		{
			builder.AddOffset(1, pickInteractTypeOffset.Value, 0);
		}

		// Token: 0x06027B3C RID: 162620 RVA: 0x0056E928 File Offset: 0x0056CB28
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06027B3D RID: 162621 RVA: 0x0056E933 File Offset: 0x0056CB33
		public static Offset<IPickInteractComponent> EndIPickInteractComponent(FlatBufferBuilder builder)
		{
			return new Offset<IPickInteractComponent>(builder.EndTable());
		}

		// Token: 0x06027B3E RID: 162622 RVA: 0x0056E940 File Offset: 0x0056CB40
		public IPickInteractComponentT UnPack()
		{
			IPickInteractComponentT pickInteractComponentT = new IPickInteractComponentT();
			this.UnPackTo(pickInteractComponentT);
			return pickInteractComponentT;
		}

		// Token: 0x06027B3F RID: 162623 RVA: 0x0056E95C File Offset: 0x0056CB5C
		public void UnPackTo(IPickInteractComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.PickInteractType = ((this.PickInteractType != null) ? this.PickInteractType.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027B40 RID: 162624 RVA: 0x0056E9B0 File Offset: 0x0056CBB0
		public static Offset<IPickInteractComponent> Pack(FlatBufferBuilder builder, IPickInteractComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPickInteractComponent>);
			}
			Offset<IChessmanPickInteraction> pickInteractTypeOffset = (_o.PickInteractType == null) ? default(Offset<IChessmanPickInteraction>) : IChessmanPickInteraction.Pack(builder, _o.PickInteractType);
			return IPickInteractComponent.CreateIPickInteractComponent(builder, _o.Disabled, pickInteractTypeOffset, _o.NullMask);
		}

		// Token: 0x0400F8A5 RID: 63653
		private Table __p;
	}
}
