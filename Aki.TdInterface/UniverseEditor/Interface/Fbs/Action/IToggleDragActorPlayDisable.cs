using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073FA RID: 29690
	public struct IToggleDragActorPlayDisable : IFlatbufferObject
	{
		// Token: 0x1700E17F RID: 57727
		// (get) Token: 0x06035EF5 RID: 220917 RVA: 0x00756F59 File Offset: 0x00755159
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035EF6 RID: 220918 RVA: 0x00756F66 File Offset: 0x00755166
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035EF7 RID: 220919 RVA: 0x00756F70 File Offset: 0x00755170
		public static IToggleDragActorPlayDisable GetRootAsIToggleDragActorPlayDisable(ByteBuffer _bb)
		{
			return IToggleDragActorPlayDisable.GetRootAsIToggleDragActorPlayDisable(_bb, default(IToggleDragActorPlayDisable));
		}

		// Token: 0x06035EF8 RID: 220920 RVA: 0x00756F8C File Offset: 0x0075518C
		public static IToggleDragActorPlayDisable GetRootAsIToggleDragActorPlayDisable(ByteBuffer _bb, IToggleDragActorPlayDisable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035EF9 RID: 220921 RVA: 0x00756FA9 File Offset: 0x007551A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035EFA RID: 220922 RVA: 0x00756FB8 File Offset: 0x007551B8
		public IToggleDragActorPlayDisable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E180 RID: 57728
		// (get) Token: 0x06035EFB RID: 220923 RVA: 0x00756FC8 File Offset: 0x007551C8
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

		// Token: 0x06035EFC RID: 220924 RVA: 0x00757004 File Offset: 0x00755204
		public static Offset<IToggleDragActorPlayDisable> CreateIToggleDragActorPlayDisable(FlatBufferBuilder builder, EToggleDragActorPlayType Type = EToggleDragActorPlayType.Enable)
		{
			builder.StartTable(1);
			IToggleDragActorPlayDisable.AddType(builder, Type);
			return IToggleDragActorPlayDisable.EndIToggleDragActorPlayDisable(builder);
		}

		// Token: 0x06035EFD RID: 220925 RVA: 0x0075701A File Offset: 0x0075521A
		public static void StartIToggleDragActorPlayDisable(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035EFE RID: 220926 RVA: 0x00757023 File Offset: 0x00755223
		public static void AddType(FlatBufferBuilder builder, EToggleDragActorPlayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035EFF RID: 220927 RVA: 0x0075702E File Offset: 0x0075522E
		public static Offset<IToggleDragActorPlayDisable> EndIToggleDragActorPlayDisable(FlatBufferBuilder builder)
		{
			return new Offset<IToggleDragActorPlayDisable>(builder.EndTable());
		}

		// Token: 0x06035F00 RID: 220928 RVA: 0x0075703C File Offset: 0x0075523C
		public IToggleDragActorPlayDisableT UnPack()
		{
			IToggleDragActorPlayDisableT toggleDragActorPlayDisableT = new IToggleDragActorPlayDisableT();
			this.UnPackTo(toggleDragActorPlayDisableT);
			return toggleDragActorPlayDisableT;
		}

		// Token: 0x06035F01 RID: 220929 RVA: 0x00757057 File Offset: 0x00755257
		public void UnPackTo(IToggleDragActorPlayDisableT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035F02 RID: 220930 RVA: 0x00757068 File Offset: 0x00755268
		public static Offset<IToggleDragActorPlayDisable> Pack(FlatBufferBuilder builder, IToggleDragActorPlayDisableT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleDragActorPlayDisable>);
			}
			return IToggleDragActorPlayDisable.CreateIToggleDragActorPlayDisable(builder, _o.Type);
		}

		// Token: 0x0401225B RID: 74331
		private Table __p;
	}
}
