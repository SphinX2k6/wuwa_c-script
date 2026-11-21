using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200734C RID: 29516
	public struct INpcSwingGetUp : IFlatbufferObject
	{
		// Token: 0x1700D85E RID: 55390
		// (get) Token: 0x060337B6 RID: 210870 RVA: 0x006F0664 File Offset: 0x006EE864
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060337B7 RID: 210871 RVA: 0x006F0671 File Offset: 0x006EE871
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060337B8 RID: 210872 RVA: 0x006F0678 File Offset: 0x006EE878
		public static INpcSwingGetUp GetRootAsINpcSwingGetUp(ByteBuffer _bb)
		{
			return INpcSwingGetUp.GetRootAsINpcSwingGetUp(_bb, default(INpcSwingGetUp));
		}

		// Token: 0x060337B9 RID: 210873 RVA: 0x006F0694 File Offset: 0x006EE894
		public static INpcSwingGetUp GetRootAsINpcSwingGetUp(ByteBuffer _bb, INpcSwingGetUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060337BA RID: 210874 RVA: 0x006F06B1 File Offset: 0x006EE8B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060337BB RID: 210875 RVA: 0x006F06C0 File Offset: 0x006EE8C0
		public INpcSwingGetUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D85F RID: 55391
		// (get) Token: 0x060337BC RID: 210876 RVA: 0x006F06D0 File Offset: 0x006EE8D0
		public ENpcLeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcLeisureInteract.SitDown;
				}
				return (ENpcLeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D860 RID: 55392
		// (get) Token: 0x060337BD RID: 210877 RVA: 0x006F070C File Offset: 0x006EE90C
		public bool KeepState
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D861 RID: 55393
		// (get) Token: 0x060337BE RID: 210878 RVA: 0x006F074C File Offset: 0x006EE94C
		public int TargetNpcId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D862 RID: 55394
		// (get) Token: 0x060337BF RID: 210879 RVA: 0x006F0788 File Offset: 0x006EE988
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060337C0 RID: 210880 RVA: 0x006F07C5 File Offset: 0x006EE9C5
		public static Offset<INpcSwingGetUp> CreateINpcSwingGetUp(FlatBufferBuilder builder, ENpcLeisureInteract Type = ENpcLeisureInteract.SitDown, bool KeepState = false, int TargetNpcId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			INpcSwingGetUp.AddTargetNpcId(builder, TargetNpcId);
			INpcSwingGetUp.AddNullMask(builder, NullMask);
			INpcSwingGetUp.AddKeepState(builder, KeepState);
			INpcSwingGetUp.AddType(builder, Type);
			return INpcSwingGetUp.EndINpcSwingGetUp(builder);
		}

		// Token: 0x060337C1 RID: 210881 RVA: 0x006F07F1 File Offset: 0x006EE9F1
		public static void StartINpcSwingGetUp(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060337C2 RID: 210882 RVA: 0x006F07FA File Offset: 0x006EE9FA
		public static void AddType(FlatBufferBuilder builder, ENpcLeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060337C3 RID: 210883 RVA: 0x006F0805 File Offset: 0x006EEA05
		public static void AddKeepState(FlatBufferBuilder builder, bool keepState)
		{
			builder.AddBool(1, keepState, false);
		}

		// Token: 0x060337C4 RID: 210884 RVA: 0x006F0810 File Offset: 0x006EEA10
		public static void AddTargetNpcId(FlatBufferBuilder builder, int targetNpcId)
		{
			builder.AddInt(2, targetNpcId, 0);
		}

		// Token: 0x060337C5 RID: 210885 RVA: 0x006F081B File Offset: 0x006EEA1B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060337C6 RID: 210886 RVA: 0x006F0826 File Offset: 0x006EEA26
		public static Offset<INpcSwingGetUp> EndINpcSwingGetUp(FlatBufferBuilder builder)
		{
			return new Offset<INpcSwingGetUp>(builder.EndTable());
		}

		// Token: 0x060337C7 RID: 210887 RVA: 0x006F0834 File Offset: 0x006EEA34
		public INpcSwingGetUpT UnPack()
		{
			INpcSwingGetUpT npcSwingGetUpT = new INpcSwingGetUpT();
			this.UnPackTo(npcSwingGetUpT);
			return npcSwingGetUpT;
		}

		// Token: 0x060337C8 RID: 210888 RVA: 0x006F084F File Offset: 0x006EEA4F
		public void UnPackTo(INpcSwingGetUpT _o)
		{
			_o.Type = this.Type;
			_o.KeepState = this.KeepState;
			_o.TargetNpcId = this.TargetNpcId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060337C9 RID: 210889 RVA: 0x006F0884 File Offset: 0x006EEA84
		public static Offset<INpcSwingGetUp> Pack(FlatBufferBuilder builder, INpcSwingGetUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcSwingGetUp>);
			}
			return INpcSwingGetUp.CreateINpcSwingGetUp(builder, _o.Type, _o.KeepState, _o.TargetNpcId, _o.NullMask);
		}

		// Token: 0x04012424 RID: 74788
		private Table __p;
	}
}
