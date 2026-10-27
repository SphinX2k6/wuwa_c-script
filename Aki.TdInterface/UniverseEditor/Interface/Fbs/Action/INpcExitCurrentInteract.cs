using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BB2 RID: 27570
	public struct INpcExitCurrentInteract : IFlatbufferObject
	{
		// Token: 0x1700CCEB RID: 52459
		// (get) Token: 0x060306E9 RID: 198377 RVA: 0x00693D8B File Offset: 0x00691F8B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060306EA RID: 198378 RVA: 0x00693D98 File Offset: 0x00691F98
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060306EB RID: 198379 RVA: 0x00693DA0 File Offset: 0x00691FA0
		public static INpcExitCurrentInteract GetRootAsINpcExitCurrentInteract(ByteBuffer _bb)
		{
			return INpcExitCurrentInteract.GetRootAsINpcExitCurrentInteract(_bb, default(INpcExitCurrentInteract));
		}

		// Token: 0x060306EC RID: 198380 RVA: 0x00693DBC File Offset: 0x00691FBC
		public static INpcExitCurrentInteract GetRootAsINpcExitCurrentInteract(ByteBuffer _bb, INpcExitCurrentInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060306ED RID: 198381 RVA: 0x00693DD9 File Offset: 0x00691FD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060306EE RID: 198382 RVA: 0x00693DE8 File Offset: 0x00691FE8
		public INpcExitCurrentInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCEC RID: 52460
		// (get) Token: 0x060306EF RID: 198383 RVA: 0x00693DF8 File Offset: 0x00691FF8
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

		// Token: 0x1700CCED RID: 52461
		// (get) Token: 0x060306F0 RID: 198384 RVA: 0x00693E34 File Offset: 0x00692034
		public bool KeepState
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CCEE RID: 52462
		// (get) Token: 0x060306F1 RID: 198385 RVA: 0x00693E74 File Offset: 0x00692074
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

		// Token: 0x060306F2 RID: 198386 RVA: 0x00693EB0 File Offset: 0x006920B0
		public static Offset<INpcExitCurrentInteract> CreateINpcExitCurrentInteract(FlatBufferBuilder builder, ENpcLeisureInteract Type = ENpcLeisureInteract.SitDown, bool KeepState = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			INpcExitCurrentInteract.AddNullMask(builder, NullMask);
			INpcExitCurrentInteract.AddKeepState(builder, KeepState);
			INpcExitCurrentInteract.AddType(builder, Type);
			return INpcExitCurrentInteract.EndINpcExitCurrentInteract(builder);
		}

		// Token: 0x060306F3 RID: 198387 RVA: 0x00693ED4 File Offset: 0x006920D4
		public static void StartINpcExitCurrentInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060306F4 RID: 198388 RVA: 0x00693EDD File Offset: 0x006920DD
		public static void AddType(FlatBufferBuilder builder, ENpcLeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060306F5 RID: 198389 RVA: 0x00693EE8 File Offset: 0x006920E8
		public static void AddKeepState(FlatBufferBuilder builder, bool keepState)
		{
			builder.AddBool(1, keepState, false);
		}

		// Token: 0x060306F6 RID: 198390 RVA: 0x00693EF3 File Offset: 0x006920F3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060306F7 RID: 198391 RVA: 0x00693EFE File Offset: 0x006920FE
		public static Offset<INpcExitCurrentInteract> EndINpcExitCurrentInteract(FlatBufferBuilder builder)
		{
			return new Offset<INpcExitCurrentInteract>(builder.EndTable());
		}

		// Token: 0x060306F8 RID: 198392 RVA: 0x00693F0C File Offset: 0x0069210C
		public INpcExitCurrentInteractT UnPack()
		{
			INpcExitCurrentInteractT npcExitCurrentInteractT = new INpcExitCurrentInteractT();
			this.UnPackTo(npcExitCurrentInteractT);
			return npcExitCurrentInteractT;
		}

		// Token: 0x060306F9 RID: 198393 RVA: 0x00693F27 File Offset: 0x00692127
		public void UnPackTo(INpcExitCurrentInteractT _o)
		{
			_o.Type = this.Type;
			_o.KeepState = this.KeepState;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060306FA RID: 198394 RVA: 0x00693F50 File Offset: 0x00692150
		public static Offset<INpcExitCurrentInteract> Pack(FlatBufferBuilder builder, INpcExitCurrentInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcExitCurrentInteract>);
			}
			return INpcExitCurrentInteract.CreateINpcExitCurrentInteract(builder, _o.Type, _o.KeepState, _o.NullMask);
		}

		// Token: 0x04011486 RID: 70790
		private Table __p;
	}
}
