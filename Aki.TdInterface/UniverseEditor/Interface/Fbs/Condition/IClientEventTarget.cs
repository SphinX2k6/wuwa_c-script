using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005061 RID: 20577
	public struct IClientEventTarget : IFlatbufferObject
	{
		// Token: 0x17009349 RID: 37705
		// (get) Token: 0x060202BF RID: 131775 RVA: 0x00476092 File Offset: 0x00474292
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060202C0 RID: 131776 RVA: 0x0047609F File Offset: 0x0047429F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060202C1 RID: 131777 RVA: 0x004760A8 File Offset: 0x004742A8
		public static IClientEventTarget GetRootAsIClientEventTarget(ByteBuffer _bb)
		{
			return IClientEventTarget.GetRootAsIClientEventTarget(_bb, default(IClientEventTarget));
		}

		// Token: 0x060202C2 RID: 131778 RVA: 0x004760C4 File Offset: 0x004742C4
		public static IClientEventTarget GetRootAsIClientEventTarget(ByteBuffer _bb, IClientEventTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060202C3 RID: 131779 RVA: 0x004760E1 File Offset: 0x004742E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060202C4 RID: 131780 RVA: 0x004760F0 File Offset: 0x004742F0
		public IClientEventTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700934A RID: 37706
		// (get) Token: 0x060202C5 RID: 131781 RVA: 0x00476100 File Offset: 0x00474300
		public EClientEventTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientEventTarget.Self;
				}
				return (EClientEventTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060202C6 RID: 131782 RVA: 0x0047613C File Offset: 0x0047433C
		public static Offset<IClientEventTarget> CreateIClientEventTarget(FlatBufferBuilder builder, EClientEventTarget Type = EClientEventTarget.Self)
		{
			builder.StartTable(1);
			IClientEventTarget.AddType(builder, Type);
			return IClientEventTarget.EndIClientEventTarget(builder);
		}

		// Token: 0x060202C7 RID: 131783 RVA: 0x00476152 File Offset: 0x00474352
		public static void StartIClientEventTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060202C8 RID: 131784 RVA: 0x0047615B File Offset: 0x0047435B
		public static void AddType(FlatBufferBuilder builder, EClientEventTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060202C9 RID: 131785 RVA: 0x00476166 File Offset: 0x00474366
		public static Offset<IClientEventTarget> EndIClientEventTarget(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventTarget>(builder.EndTable());
		}

		// Token: 0x060202CA RID: 131786 RVA: 0x00476174 File Offset: 0x00474374
		public IClientEventTargetT UnPack()
		{
			IClientEventTargetT clientEventTargetT = new IClientEventTargetT();
			this.UnPackTo(clientEventTargetT);
			return clientEventTargetT;
		}

		// Token: 0x060202CB RID: 131787 RVA: 0x0047618F File Offset: 0x0047438F
		public void UnPackTo(IClientEventTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060202CC RID: 131788 RVA: 0x004761A0 File Offset: 0x004743A0
		public static Offset<IClientEventTarget> Pack(FlatBufferBuilder builder, IClientEventTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventTarget>);
			}
			return IClientEventTarget.CreateIClientEventTarget(builder, _o.Type);
		}

		// Token: 0x0400DF46 RID: 57158
		private Table __p;
	}
}
