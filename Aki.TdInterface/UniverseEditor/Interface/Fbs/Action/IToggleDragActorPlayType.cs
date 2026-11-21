using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BEA RID: 31722
	public struct IToggleDragActorPlayType : IFlatbufferObject
	{
		// Token: 0x1700EDA8 RID: 60840
		// (get) Token: 0x060392EE RID: 234222 RVA: 0x007B9ED5 File Offset: 0x007B80D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060392EF RID: 234223 RVA: 0x007B9EE2 File Offset: 0x007B80E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060392F0 RID: 234224 RVA: 0x007B9EEC File Offset: 0x007B80EC
		public static IToggleDragActorPlayType GetRootAsIToggleDragActorPlayType(ByteBuffer _bb)
		{
			return IToggleDragActorPlayType.GetRootAsIToggleDragActorPlayType(_bb, default(IToggleDragActorPlayType));
		}

		// Token: 0x060392F1 RID: 234225 RVA: 0x007B9F08 File Offset: 0x007B8108
		public static IToggleDragActorPlayType GetRootAsIToggleDragActorPlayType(ByteBuffer _bb, IToggleDragActorPlayType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060392F2 RID: 234226 RVA: 0x007B9F25 File Offset: 0x007B8125
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060392F3 RID: 234227 RVA: 0x007B9F34 File Offset: 0x007B8134
		public IToggleDragActorPlayType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EDA9 RID: 60841
		// (get) Token: 0x060392F4 RID: 234228 RVA: 0x007B9F44 File Offset: 0x007B8144
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

		// Token: 0x060392F5 RID: 234229 RVA: 0x007B9F80 File Offset: 0x007B8180
		public static Offset<IToggleDragActorPlayType> CreateIToggleDragActorPlayType(FlatBufferBuilder builder, EToggleDragActorPlayType Type = EToggleDragActorPlayType.Enable)
		{
			builder.StartTable(1);
			IToggleDragActorPlayType.AddType(builder, Type);
			return IToggleDragActorPlayType.EndIToggleDragActorPlayType(builder);
		}

		// Token: 0x060392F6 RID: 234230 RVA: 0x007B9F96 File Offset: 0x007B8196
		public static void StartIToggleDragActorPlayType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060392F7 RID: 234231 RVA: 0x007B9F9F File Offset: 0x007B819F
		public static void AddType(FlatBufferBuilder builder, EToggleDragActorPlayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060392F8 RID: 234232 RVA: 0x007B9FAA File Offset: 0x007B81AA
		public static Offset<IToggleDragActorPlayType> EndIToggleDragActorPlayType(FlatBufferBuilder builder)
		{
			return new Offset<IToggleDragActorPlayType>(builder.EndTable());
		}

		// Token: 0x060392F9 RID: 234233 RVA: 0x007B9FB8 File Offset: 0x007B81B8
		public IToggleDragActorPlayTypeT UnPack()
		{
			IToggleDragActorPlayTypeT toggleDragActorPlayTypeT = new IToggleDragActorPlayTypeT();
			this.UnPackTo(toggleDragActorPlayTypeT);
			return toggleDragActorPlayTypeT;
		}

		// Token: 0x060392FA RID: 234234 RVA: 0x007B9FD3 File Offset: 0x007B81D3
		public void UnPackTo(IToggleDragActorPlayTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060392FB RID: 234235 RVA: 0x007B9FE4 File Offset: 0x007B81E4
		public static Offset<IToggleDragActorPlayType> Pack(FlatBufferBuilder builder, IToggleDragActorPlayTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleDragActorPlayType>);
			}
			return IToggleDragActorPlayType.CreateIToggleDragActorPlayType(builder, _o.Type);
		}

		// Token: 0x04013282 RID: 78466
		private Table __p;
	}
}
