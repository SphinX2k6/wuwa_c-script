using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004883 RID: 18563
	public struct ILevelPlayAreaConflictSelector : IFlatbufferObject
	{
		// Token: 0x1700869D RID: 34461
		// (get) Token: 0x0601CF3C RID: 118588 RVA: 0x00417634 File Offset: 0x00415834
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CF3D RID: 118589 RVA: 0x00417641 File Offset: 0x00415841
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CF3E RID: 118590 RVA: 0x00417648 File Offset: 0x00415848
		public static ILevelPlayAreaConflictSelector GetRootAsILevelPlayAreaConflictSelector(ByteBuffer _bb)
		{
			return ILevelPlayAreaConflictSelector.GetRootAsILevelPlayAreaConflictSelector(_bb, default(ILevelPlayAreaConflictSelector));
		}

		// Token: 0x0601CF3F RID: 118591 RVA: 0x00417664 File Offset: 0x00415864
		public static ILevelPlayAreaConflictSelector GetRootAsILevelPlayAreaConflictSelector(ByteBuffer _bb, ILevelPlayAreaConflictSelector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CF40 RID: 118592 RVA: 0x00417681 File Offset: 0x00415881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CF41 RID: 118593 RVA: 0x00417690 File Offset: 0x00415890
		public ILevelPlayAreaConflictSelector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700869E RID: 34462
		// (get) Token: 0x0601CF42 RID: 118594 RVA: 0x004176A0 File Offset: 0x004158A0
		public EAreaConflictSelector Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAreaConflictSelector.Quest;
				}
				return (EAreaConflictSelector)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700869F RID: 34463
		// (get) Token: 0x0601CF43 RID: 118595 RVA: 0x004176DC File Offset: 0x004158DC
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170086A0 RID: 34464
		// (get) Token: 0x0601CF44 RID: 118596 RVA: 0x00417718 File Offset: 0x00415918
		public bool CheckEnterArea
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601CF45 RID: 118597 RVA: 0x00417757 File Offset: 0x00415957
		public static Offset<ILevelPlayAreaConflictSelector> CreateILevelPlayAreaConflictSelector(FlatBufferBuilder builder, EAreaConflictSelector Type = EAreaConflictSelector.Quest, int Id = 0, bool CheckEnterArea = false)
		{
			builder.StartTable(3);
			ILevelPlayAreaConflictSelector.AddId(builder, Id);
			ILevelPlayAreaConflictSelector.AddCheckEnterArea(builder, CheckEnterArea);
			ILevelPlayAreaConflictSelector.AddType(builder, Type);
			return ILevelPlayAreaConflictSelector.EndILevelPlayAreaConflictSelector(builder);
		}

		// Token: 0x0601CF46 RID: 118598 RVA: 0x0041777B File Offset: 0x0041597B
		public static void StartILevelPlayAreaConflictSelector(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601CF47 RID: 118599 RVA: 0x00417784 File Offset: 0x00415984
		public static void AddType(FlatBufferBuilder builder, EAreaConflictSelector type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CF48 RID: 118600 RVA: 0x0041778F File Offset: 0x0041598F
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601CF49 RID: 118601 RVA: 0x0041779A File Offset: 0x0041599A
		public static void AddCheckEnterArea(FlatBufferBuilder builder, bool checkEnterArea)
		{
			builder.AddBool(2, checkEnterArea, false);
		}

		// Token: 0x0601CF4A RID: 118602 RVA: 0x004177A5 File Offset: 0x004159A5
		public static Offset<ILevelPlayAreaConflictSelector> EndILevelPlayAreaConflictSelector(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayAreaConflictSelector>(builder.EndTable());
		}

		// Token: 0x0601CF4B RID: 118603 RVA: 0x004177B4 File Offset: 0x004159B4
		public ILevelPlayAreaConflictSelectorT UnPack()
		{
			ILevelPlayAreaConflictSelectorT levelPlayAreaConflictSelectorT = new ILevelPlayAreaConflictSelectorT();
			this.UnPackTo(levelPlayAreaConflictSelectorT);
			return levelPlayAreaConflictSelectorT;
		}

		// Token: 0x0601CF4C RID: 118604 RVA: 0x004177CF File Offset: 0x004159CF
		public void UnPackTo(ILevelPlayAreaConflictSelectorT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.CheckEnterArea = this.CheckEnterArea;
		}

		// Token: 0x0601CF4D RID: 118605 RVA: 0x004177F8 File Offset: 0x004159F8
		public static Offset<ILevelPlayAreaConflictSelector> Pack(FlatBufferBuilder builder, ILevelPlayAreaConflictSelectorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayAreaConflictSelector>);
			}
			return ILevelPlayAreaConflictSelector.CreateILevelPlayAreaConflictSelector(builder, _o.Type, _o.Id, _o.CheckEnterArea);
		}

		// Token: 0x0400CE68 RID: 52840
		private Table __p;
	}
}
