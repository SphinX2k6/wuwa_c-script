using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BC1 RID: 27585
	public struct INpcLeisureInteractType : IFlatbufferObject
	{
		// Token: 0x1700CCFF RID: 52479
		// (get) Token: 0x0603074F RID: 198479 RVA: 0x0069494D File Offset: 0x00692B4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030750 RID: 198480 RVA: 0x0069495A File Offset: 0x00692B5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030751 RID: 198481 RVA: 0x00694964 File Offset: 0x00692B64
		public static INpcLeisureInteractType GetRootAsINpcLeisureInteractType(ByteBuffer _bb)
		{
			return INpcLeisureInteractType.GetRootAsINpcLeisureInteractType(_bb, default(INpcLeisureInteractType));
		}

		// Token: 0x06030752 RID: 198482 RVA: 0x00694980 File Offset: 0x00692B80
		public static INpcLeisureInteractType GetRootAsINpcLeisureInteractType(ByteBuffer _bb, INpcLeisureInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030753 RID: 198483 RVA: 0x0069499D File Offset: 0x00692B9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030754 RID: 198484 RVA: 0x006949AC File Offset: 0x00692BAC
		public INpcLeisureInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD00 RID: 52480
		// (get) Token: 0x06030755 RID: 198485 RVA: 0x006949BC File Offset: 0x00692BBC
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

		// Token: 0x1700CD01 RID: 52481
		// (get) Token: 0x06030756 RID: 198486 RVA: 0x006949F8 File Offset: 0x00692BF8
		public bool KeepState
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CD02 RID: 52482
		// (get) Token: 0x06030757 RID: 198487 RVA: 0x00694A38 File Offset: 0x00692C38
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

		// Token: 0x06030758 RID: 198488 RVA: 0x00694A74 File Offset: 0x00692C74
		public static Offset<INpcLeisureInteractType> CreateINpcLeisureInteractType(FlatBufferBuilder builder, ENpcLeisureInteract Type = ENpcLeisureInteract.SitDown, bool KeepState = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			INpcLeisureInteractType.AddNullMask(builder, NullMask);
			INpcLeisureInteractType.AddKeepState(builder, KeepState);
			INpcLeisureInteractType.AddType(builder, Type);
			return INpcLeisureInteractType.EndINpcLeisureInteractType(builder);
		}

		// Token: 0x06030759 RID: 198489 RVA: 0x00694A98 File Offset: 0x00692C98
		public static void StartINpcLeisureInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603075A RID: 198490 RVA: 0x00694AA1 File Offset: 0x00692CA1
		public static void AddType(FlatBufferBuilder builder, ENpcLeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603075B RID: 198491 RVA: 0x00694AAC File Offset: 0x00692CAC
		public static void AddKeepState(FlatBufferBuilder builder, bool keepState)
		{
			builder.AddBool(1, keepState, false);
		}

		// Token: 0x0603075C RID: 198492 RVA: 0x00694AB7 File Offset: 0x00692CB7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0603075D RID: 198493 RVA: 0x00694AC2 File Offset: 0x00692CC2
		public static Offset<INpcLeisureInteractType> EndINpcLeisureInteractType(FlatBufferBuilder builder)
		{
			return new Offset<INpcLeisureInteractType>(builder.EndTable());
		}

		// Token: 0x0603075E RID: 198494 RVA: 0x00694AD0 File Offset: 0x00692CD0
		public INpcLeisureInteractTypeT UnPack()
		{
			INpcLeisureInteractTypeT npcLeisureInteractTypeT = new INpcLeisureInteractTypeT();
			this.UnPackTo(npcLeisureInteractTypeT);
			return npcLeisureInteractTypeT;
		}

		// Token: 0x0603075F RID: 198495 RVA: 0x00694AEB File Offset: 0x00692CEB
		public void UnPackTo(INpcLeisureInteractTypeT _o)
		{
			_o.Type = this.Type;
			_o.KeepState = this.KeepState;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030760 RID: 198496 RVA: 0x00694B14 File Offset: 0x00692D14
		public static Offset<INpcLeisureInteractType> Pack(FlatBufferBuilder builder, INpcLeisureInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcLeisureInteractType>);
			}
			return INpcLeisureInteractType.CreateINpcLeisureInteractType(builder, _o.Type, _o.KeepState, _o.NullMask);
		}

		// Token: 0x04011497 RID: 70807
		private Table __p;
	}
}
