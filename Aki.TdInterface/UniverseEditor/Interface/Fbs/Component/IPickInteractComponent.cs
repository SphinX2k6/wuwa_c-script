using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005736 RID: 22326
	public struct IPickInteractComponent : IFlatbufferObject
	{
		// Token: 0x1700A66D RID: 42605
		// (get) Token: 0x0602560F RID: 153103 RVA: 0x0052860C File Offset: 0x0052680C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025610 RID: 153104 RVA: 0x00528619 File Offset: 0x00526819
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025611 RID: 153105 RVA: 0x00528620 File Offset: 0x00526820
		public static IPickInteractComponent GetRootAsIPickInteractComponent(ByteBuffer _bb)
		{
			return IPickInteractComponent.GetRootAsIPickInteractComponent(_bb, default(IPickInteractComponent));
		}

		// Token: 0x06025612 RID: 153106 RVA: 0x0052863C File Offset: 0x0052683C
		public static IPickInteractComponent GetRootAsIPickInteractComponent(ByteBuffer _bb, IPickInteractComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025613 RID: 153107 RVA: 0x00528659 File Offset: 0x00526859
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025614 RID: 153108 RVA: 0x00528668 File Offset: 0x00526868
		public IPickInteractComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A66E RID: 42606
		// (get) Token: 0x06025615 RID: 153109 RVA: 0x00528678 File Offset: 0x00526878
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A66F RID: 42607
		// (get) Token: 0x06025616 RID: 153110 RVA: 0x005286B8 File Offset: 0x005268B8
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

		// Token: 0x1700A670 RID: 42608
		// (get) Token: 0x06025617 RID: 153111 RVA: 0x00528718 File Offset: 0x00526918
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

		// Token: 0x06025618 RID: 153112 RVA: 0x00528754 File Offset: 0x00526954
		public static Offset<IPickInteractComponent> CreateIPickInteractComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IChessmanPickInteraction> PickInteractTypeOffset = default(Offset<IChessmanPickInteraction>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IPickInteractComponent.AddPickInteractType(builder, PickInteractTypeOffset);
			IPickInteractComponent.AddNullMask(builder, NullMask);
			IPickInteractComponent.AddDisabled(builder, Disabled);
			return IPickInteractComponent.EndIPickInteractComponent(builder);
		}

		// Token: 0x06025619 RID: 153113 RVA: 0x00528778 File Offset: 0x00526978
		public static void StartIPickInteractComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602561A RID: 153114 RVA: 0x00528781 File Offset: 0x00526981
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602561B RID: 153115 RVA: 0x0052878C File Offset: 0x0052698C
		public static void AddPickInteractType(FlatBufferBuilder builder, Offset<IChessmanPickInteraction> pickInteractTypeOffset)
		{
			builder.AddOffset(1, pickInteractTypeOffset.Value, 0);
		}

		// Token: 0x0602561C RID: 153116 RVA: 0x0052879C File Offset: 0x0052699C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602561D RID: 153117 RVA: 0x005287A7 File Offset: 0x005269A7
		public static Offset<IPickInteractComponent> EndIPickInteractComponent(FlatBufferBuilder builder)
		{
			return new Offset<IPickInteractComponent>(builder.EndTable());
		}

		// Token: 0x0602561E RID: 153118 RVA: 0x005287B4 File Offset: 0x005269B4
		public IPickInteractComponentT UnPack()
		{
			IPickInteractComponentT pickInteractComponentT = new IPickInteractComponentT();
			this.UnPackTo(pickInteractComponentT);
			return pickInteractComponentT;
		}

		// Token: 0x0602561F RID: 153119 RVA: 0x005287D0 File Offset: 0x005269D0
		public void UnPackTo(IPickInteractComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.PickInteractType = ((this.PickInteractType != null) ? this.PickInteractType.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025620 RID: 153120 RVA: 0x00528824 File Offset: 0x00526A24
		public static Offset<IPickInteractComponent> Pack(FlatBufferBuilder builder, IPickInteractComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPickInteractComponent>);
			}
			Offset<IChessmanPickInteraction> pickInteractTypeOffset = (_o.PickInteractType == null) ? default(Offset<IChessmanPickInteraction>) : IChessmanPickInteraction.Pack(builder, _o.PickInteractType);
			return IPickInteractComponent.CreateIPickInteractComponent(builder, _o.Disabled, pickInteractTypeOffset, _o.NullMask);
		}

		// Token: 0x0400EBBA RID: 60346
		private Table __p;
	}
}
