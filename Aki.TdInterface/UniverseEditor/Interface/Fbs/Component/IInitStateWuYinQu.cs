using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059B1 RID: 22961
	public struct IInitStateWuYinQu : IFlatbufferObject
	{
		// Token: 0x1700A6B9 RID: 42681
		// (get) Token: 0x0602570F RID: 153359 RVA: 0x00522CBD File Offset: 0x00520EBD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025710 RID: 153360 RVA: 0x00522CCA File Offset: 0x00520ECA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025711 RID: 153361 RVA: 0x00522CD4 File Offset: 0x00520ED4
		public static IInitStateWuYinQu GetRootAsIInitStateWuYinQu(ByteBuffer _bb)
		{
			return IInitStateWuYinQu.GetRootAsIInitStateWuYinQu(_bb, default(IInitStateWuYinQu));
		}

		// Token: 0x06025712 RID: 153362 RVA: 0x00522CF0 File Offset: 0x00520EF0
		public static IInitStateWuYinQu GetRootAsIInitStateWuYinQu(ByteBuffer _bb, IInitStateWuYinQu obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025713 RID: 153363 RVA: 0x00522D0D File Offset: 0x00520F0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025714 RID: 153364 RVA: 0x00522D1C File Offset: 0x00520F1C
		public IInitStateWuYinQu __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6BA RID: 42682
		// (get) Token: 0x06025715 RID: 153365 RVA: 0x00522D2C File Offset: 0x00520F2C
		public EInitStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInitStateType.Birth;
				}
				return (EInitStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025716 RID: 153366 RVA: 0x00522D68 File Offset: 0x00520F68
		public static Offset<IInitStateWuYinQu> CreateIInitStateWuYinQu(FlatBufferBuilder builder, EInitStateType Type = EInitStateType.Birth)
		{
			builder.StartTable(1);
			IInitStateWuYinQu.AddType(builder, Type);
			return IInitStateWuYinQu.EndIInitStateWuYinQu(builder);
		}

		// Token: 0x06025717 RID: 153367 RVA: 0x00522D7E File Offset: 0x00520F7E
		public static void StartIInitStateWuYinQu(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025718 RID: 153368 RVA: 0x00522D87 File Offset: 0x00520F87
		public static void AddType(FlatBufferBuilder builder, EInitStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025719 RID: 153369 RVA: 0x00522D92 File Offset: 0x00520F92
		public static Offset<IInitStateWuYinQu> EndIInitStateWuYinQu(FlatBufferBuilder builder)
		{
			return new Offset<IInitStateWuYinQu>(builder.EndTable());
		}

		// Token: 0x0602571A RID: 153370 RVA: 0x00522DA0 File Offset: 0x00520FA0
		public IInitStateWuYinQuT UnPack()
		{
			IInitStateWuYinQuT initStateWuYinQuT = new IInitStateWuYinQuT();
			this.UnPackTo(initStateWuYinQuT);
			return initStateWuYinQuT;
		}

		// Token: 0x0602571B RID: 153371 RVA: 0x00522DBB File Offset: 0x00520FBB
		public void UnPackTo(IInitStateWuYinQuT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602571C RID: 153372 RVA: 0x00522DCC File Offset: 0x00520FCC
		public static Offset<IInitStateWuYinQu> Pack(FlatBufferBuilder builder, IInitStateWuYinQuT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInitStateWuYinQu>);
			}
			return IInitStateWuYinQu.CreateIInitStateWuYinQu(builder, _o.Type);
		}

		// Token: 0x0400F2A8 RID: 62120
		private Table __p;
	}
}
