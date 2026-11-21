using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072FE RID: 29438
	public struct INpcExitCurrentInteract : IFlatbufferObject
	{
		// Token: 0x1700D7D7 RID: 55255
		// (get) Token: 0x06033563 RID: 210275 RVA: 0x006EC72B File Offset: 0x006EA92B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033564 RID: 210276 RVA: 0x006EC738 File Offset: 0x006EA938
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033565 RID: 210277 RVA: 0x006EC740 File Offset: 0x006EA940
		public static INpcExitCurrentInteract GetRootAsINpcExitCurrentInteract(ByteBuffer _bb)
		{
			return INpcExitCurrentInteract.GetRootAsINpcExitCurrentInteract(_bb, default(INpcExitCurrentInteract));
		}

		// Token: 0x06033566 RID: 210278 RVA: 0x006EC75C File Offset: 0x006EA95C
		public static INpcExitCurrentInteract GetRootAsINpcExitCurrentInteract(ByteBuffer _bb, INpcExitCurrentInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033567 RID: 210279 RVA: 0x006EC779 File Offset: 0x006EA979
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033568 RID: 210280 RVA: 0x006EC788 File Offset: 0x006EA988
		public INpcExitCurrentInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7D8 RID: 55256
		// (get) Token: 0x06033569 RID: 210281 RVA: 0x006EC798 File Offset: 0x006EA998
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

		// Token: 0x1700D7D9 RID: 55257
		// (get) Token: 0x0603356A RID: 210282 RVA: 0x006EC7D4 File Offset: 0x006EA9D4
		public bool KeepState
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D7DA RID: 55258
		// (get) Token: 0x0603356B RID: 210283 RVA: 0x006EC814 File Offset: 0x006EAA14
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

		// Token: 0x0603356C RID: 210284 RVA: 0x006EC850 File Offset: 0x006EAA50
		public static Offset<INpcExitCurrentInteract> CreateINpcExitCurrentInteract(FlatBufferBuilder builder, ENpcLeisureInteract Type = ENpcLeisureInteract.SitDown, bool KeepState = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			INpcExitCurrentInteract.AddNullMask(builder, NullMask);
			INpcExitCurrentInteract.AddKeepState(builder, KeepState);
			INpcExitCurrentInteract.AddType(builder, Type);
			return INpcExitCurrentInteract.EndINpcExitCurrentInteract(builder);
		}

		// Token: 0x0603356D RID: 210285 RVA: 0x006EC874 File Offset: 0x006EAA74
		public static void StartINpcExitCurrentInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603356E RID: 210286 RVA: 0x006EC87D File Offset: 0x006EAA7D
		public static void AddType(FlatBufferBuilder builder, ENpcLeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603356F RID: 210287 RVA: 0x006EC888 File Offset: 0x006EAA88
		public static void AddKeepState(FlatBufferBuilder builder, bool keepState)
		{
			builder.AddBool(1, keepState, false);
		}

		// Token: 0x06033570 RID: 210288 RVA: 0x006EC893 File Offset: 0x006EAA93
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06033571 RID: 210289 RVA: 0x006EC89E File Offset: 0x006EAA9E
		public static Offset<INpcExitCurrentInteract> EndINpcExitCurrentInteract(FlatBufferBuilder builder)
		{
			return new Offset<INpcExitCurrentInteract>(builder.EndTable());
		}

		// Token: 0x06033572 RID: 210290 RVA: 0x006EC8AC File Offset: 0x006EAAAC
		public INpcExitCurrentInteractT UnPack()
		{
			INpcExitCurrentInteractT npcExitCurrentInteractT = new INpcExitCurrentInteractT();
			this.UnPackTo(npcExitCurrentInteractT);
			return npcExitCurrentInteractT;
		}

		// Token: 0x06033573 RID: 210291 RVA: 0x006EC8C7 File Offset: 0x006EAAC7
		public void UnPackTo(INpcExitCurrentInteractT _o)
		{
			_o.Type = this.Type;
			_o.KeepState = this.KeepState;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033574 RID: 210292 RVA: 0x006EC8F0 File Offset: 0x006EAAF0
		public static Offset<INpcExitCurrentInteract> Pack(FlatBufferBuilder builder, INpcExitCurrentInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcExitCurrentInteract>);
			}
			return INpcExitCurrentInteract.CreateINpcExitCurrentInteract(builder, _o.Type, _o.KeepState, _o.NullMask);
		}

		// Token: 0x040123B8 RID: 74680
		private Table __p;
	}
}
