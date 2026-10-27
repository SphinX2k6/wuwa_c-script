using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007400 RID: 29696
	public struct IToggleDragActorPlayType : IFlatbufferObject
	{
		// Token: 0x1700E193 RID: 57747
		// (get) Token: 0x06035F3B RID: 220987 RVA: 0x00757761 File Offset: 0x00755961
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035F3C RID: 220988 RVA: 0x0075776E File Offset: 0x0075596E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035F3D RID: 220989 RVA: 0x00757778 File Offset: 0x00755978
		public static IToggleDragActorPlayType GetRootAsIToggleDragActorPlayType(ByteBuffer _bb)
		{
			return IToggleDragActorPlayType.GetRootAsIToggleDragActorPlayType(_bb, default(IToggleDragActorPlayType));
		}

		// Token: 0x06035F3E RID: 220990 RVA: 0x00757794 File Offset: 0x00755994
		public static IToggleDragActorPlayType GetRootAsIToggleDragActorPlayType(ByteBuffer _bb, IToggleDragActorPlayType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035F3F RID: 220991 RVA: 0x007577B1 File Offset: 0x007559B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035F40 RID: 220992 RVA: 0x007577C0 File Offset: 0x007559C0
		public IToggleDragActorPlayType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E194 RID: 57748
		// (get) Token: 0x06035F41 RID: 220993 RVA: 0x007577D0 File Offset: 0x007559D0
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

		// Token: 0x06035F42 RID: 220994 RVA: 0x0075780C File Offset: 0x00755A0C
		public static Offset<IToggleDragActorPlayType> CreateIToggleDragActorPlayType(FlatBufferBuilder builder, EToggleDragActorPlayType Type = EToggleDragActorPlayType.Enable)
		{
			builder.StartTable(1);
			IToggleDragActorPlayType.AddType(builder, Type);
			return IToggleDragActorPlayType.EndIToggleDragActorPlayType(builder);
		}

		// Token: 0x06035F43 RID: 220995 RVA: 0x00757822 File Offset: 0x00755A22
		public static void StartIToggleDragActorPlayType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035F44 RID: 220996 RVA: 0x0075782B File Offset: 0x00755A2B
		public static void AddType(FlatBufferBuilder builder, EToggleDragActorPlayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035F45 RID: 220997 RVA: 0x00757836 File Offset: 0x00755A36
		public static Offset<IToggleDragActorPlayType> EndIToggleDragActorPlayType(FlatBufferBuilder builder)
		{
			return new Offset<IToggleDragActorPlayType>(builder.EndTable());
		}

		// Token: 0x06035F46 RID: 220998 RVA: 0x00757844 File Offset: 0x00755A44
		public IToggleDragActorPlayTypeT UnPack()
		{
			IToggleDragActorPlayTypeT toggleDragActorPlayTypeT = new IToggleDragActorPlayTypeT();
			this.UnPackTo(toggleDragActorPlayTypeT);
			return toggleDragActorPlayTypeT;
		}

		// Token: 0x06035F47 RID: 220999 RVA: 0x0075785F File Offset: 0x00755A5F
		public void UnPackTo(IToggleDragActorPlayTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035F48 RID: 221000 RVA: 0x00757870 File Offset: 0x00755A70
		public static Offset<IToggleDragActorPlayType> Pack(FlatBufferBuilder builder, IToggleDragActorPlayTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleDragActorPlayType>);
			}
			return IToggleDragActorPlayType.CreateIToggleDragActorPlayType(builder, _o.Type);
		}

		// Token: 0x04012266 RID: 74342
		private Table __p;
	}
}
