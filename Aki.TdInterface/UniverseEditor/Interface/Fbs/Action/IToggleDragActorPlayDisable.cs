using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BE4 RID: 31716
	public struct IToggleDragActorPlayDisable : IFlatbufferObject
	{
		// Token: 0x1700ED94 RID: 60820
		// (get) Token: 0x060392A8 RID: 234152 RVA: 0x007B96CD File Offset: 0x007B78CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060392A9 RID: 234153 RVA: 0x007B96DA File Offset: 0x007B78DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060392AA RID: 234154 RVA: 0x007B96E4 File Offset: 0x007B78E4
		public static IToggleDragActorPlayDisable GetRootAsIToggleDragActorPlayDisable(ByteBuffer _bb)
		{
			return IToggleDragActorPlayDisable.GetRootAsIToggleDragActorPlayDisable(_bb, default(IToggleDragActorPlayDisable));
		}

		// Token: 0x060392AB RID: 234155 RVA: 0x007B9700 File Offset: 0x007B7900
		public static IToggleDragActorPlayDisable GetRootAsIToggleDragActorPlayDisable(ByteBuffer _bb, IToggleDragActorPlayDisable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060392AC RID: 234156 RVA: 0x007B971D File Offset: 0x007B791D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060392AD RID: 234157 RVA: 0x007B972C File Offset: 0x007B792C
		public IToggleDragActorPlayDisable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED95 RID: 60821
		// (get) Token: 0x060392AE RID: 234158 RVA: 0x007B973C File Offset: 0x007B793C
		public EToggleDragActorPlayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EToggleDragActorPlayType.Enable;
				}
				return (EToggleDragActorPlayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060392AF RID: 234159 RVA: 0x007B9778 File Offset: 0x007B7978
		public static Offset<IToggleDragActorPlayDisable> CreateIToggleDragActorPlayDisable(FlatBufferBuilder builder, EToggleDragActorPlayType Type = EToggleDragActorPlayType.Enable)
		{
			builder.StartTable(1);
			IToggleDragActorPlayDisable.AddType(builder, Type);
			return IToggleDragActorPlayDisable.EndIToggleDragActorPlayDisable(builder);
		}

		// Token: 0x060392B0 RID: 234160 RVA: 0x007B978E File Offset: 0x007B798E
		public static void StartIToggleDragActorPlayDisable(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060392B1 RID: 234161 RVA: 0x007B9797 File Offset: 0x007B7997
		public static void AddType(FlatBufferBuilder builder, EToggleDragActorPlayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060392B2 RID: 234162 RVA: 0x007B97A2 File Offset: 0x007B79A2
		public static Offset<IToggleDragActorPlayDisable> EndIToggleDragActorPlayDisable(FlatBufferBuilder builder)
		{
			return new Offset<IToggleDragActorPlayDisable>(builder.EndTable());
		}

		// Token: 0x060392B3 RID: 234163 RVA: 0x007B97B0 File Offset: 0x007B79B0
		public IToggleDragActorPlayDisableT UnPack()
		{
			IToggleDragActorPlayDisableT toggleDragActorPlayDisableT = new IToggleDragActorPlayDisableT();
			this.UnPackTo(toggleDragActorPlayDisableT);
			return toggleDragActorPlayDisableT;
		}

		// Token: 0x060392B4 RID: 234164 RVA: 0x007B97CB File Offset: 0x007B79CB
		public void UnPackTo(IToggleDragActorPlayDisableT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060392B5 RID: 234165 RVA: 0x007B97DC File Offset: 0x007B79DC
		public static Offset<IToggleDragActorPlayDisable> Pack(FlatBufferBuilder builder, IToggleDragActorPlayDisableT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleDragActorPlayDisable>);
			}
			return IToggleDragActorPlayDisable.CreateIToggleDragActorPlayDisable(builder, _o.Type);
		}

		// Token: 0x04013277 RID: 78455
		private Table __p;
	}
}
