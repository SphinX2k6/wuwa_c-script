using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007756 RID: 30550
	public struct ISetActorVar : IFlatbufferObject
	{
		// Token: 0x1700DFEC RID: 57324
		// (get) Token: 0x060359D2 RID: 219602 RVA: 0x0072F9C7 File Offset: 0x0072DBC7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060359D3 RID: 219603 RVA: 0x0072F9D4 File Offset: 0x0072DBD4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060359D4 RID: 219604 RVA: 0x0072F9DC File Offset: 0x0072DBDC
		public static ISetActorVar GetRootAsISetActorVar(ByteBuffer _bb)
		{
			return ISetActorVar.GetRootAsISetActorVar(_bb, default(ISetActorVar));
		}

		// Token: 0x060359D5 RID: 219605 RVA: 0x0072F9F8 File Offset: 0x0072DBF8
		public static ISetActorVar GetRootAsISetActorVar(ByteBuffer _bb, ISetActorVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060359D6 RID: 219606 RVA: 0x0072FA15 File Offset: 0x0072DC15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060359D7 RID: 219607 RVA: 0x0072FA24 File Offset: 0x0072DC24
		public ISetActorVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFED RID: 57325
		// (get) Token: 0x060359D8 RID: 219608 RVA: 0x0072FA34 File Offset: 0x0072DC34
		public IActorRef? ActorRef
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DFEE RID: 57326
		// (get) Token: 0x060359D9 RID: 219609 RVA: 0x0072FA94 File Offset: 0x0072DC94
		public string VarLeft
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060359DA RID: 219610 RVA: 0x0072FACB File Offset: 0x0072DCCB
		public Span<byte> GetVarLeftBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060359DB RID: 219611 RVA: 0x0072FADA File Offset: 0x0072DCDA
		public byte[] GetVarLeftArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700DFEF RID: 57327
		// (get) Token: 0x060359DC RID: 219612 RVA: 0x0072FAE8 File Offset: 0x0072DCE8
		public TVarRef VarRightType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060359DD RID: 219613 RVA: 0x0072FB24 File Offset: 0x0072DD24
		public TTable? VarRight<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060359DE RID: 219614 RVA: 0x0072FB6C File Offset: 0x0072DD6C
		public IConstVarRef VarRightAsIConstVarRef()
		{
			return this.VarRight<IConstVarRef>().Value;
		}

		// Token: 0x060359DF RID: 219615 RVA: 0x0072FB88 File Offset: 0x0072DD88
		public IGlobalVarRef VarRightAsIGlobalVarRef()
		{
			return this.VarRight<IGlobalVarRef>().Value;
		}

		// Token: 0x060359E0 RID: 219616 RVA: 0x0072FBA4 File Offset: 0x0072DDA4
		public IOtherVarRef VarRightAsIOtherVarRef()
		{
			return this.VarRight<IOtherVarRef>().Value;
		}

		// Token: 0x060359E1 RID: 219617 RVA: 0x0072FBC0 File Offset: 0x0072DDC0
		public ISelfVarRef VarRightAsISelfVarRef()
		{
			return this.VarRight<ISelfVarRef>().Value;
		}

		// Token: 0x060359E2 RID: 219618 RVA: 0x0072FBDC File Offset: 0x0072DDDC
		public ISystemVarRef VarRightAsISystemVarRef()
		{
			return this.VarRight<ISystemVarRef>().Value;
		}

		// Token: 0x060359E3 RID: 219619 RVA: 0x0072FBF7 File Offset: 0x0072DDF7
		public static Offset<ISetActorVar> CreateISetActorVar(FlatBufferBuilder builder, Offset<IActorRef> ActorRefOffset = default(Offset<IActorRef>), StringOffset VarLeftOffset = default(StringOffset), TVarRef VarRight_type = TVarRef.NONE, int VarRightOffset = 0)
		{
			builder.StartTable(4);
			ISetActorVar.AddVarRight(builder, VarRightOffset);
			ISetActorVar.AddVarLeft(builder, VarLeftOffset);
			ISetActorVar.AddActorRef(builder, ActorRefOffset);
			ISetActorVar.AddVarRightType(builder, VarRight_type);
			return ISetActorVar.EndISetActorVar(builder);
		}

		// Token: 0x060359E4 RID: 219620 RVA: 0x0072FC23 File Offset: 0x0072DE23
		public static void StartISetActorVar(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060359E5 RID: 219621 RVA: 0x0072FC2C File Offset: 0x0072DE2C
		public static void AddActorRef(FlatBufferBuilder builder, Offset<IActorRef> actorRefOffset)
		{
			builder.AddOffset(0, actorRefOffset.Value, 0);
		}

		// Token: 0x060359E6 RID: 219622 RVA: 0x0072FC3C File Offset: 0x0072DE3C
		public static void AddVarLeft(FlatBufferBuilder builder, StringOffset varLeftOffset)
		{
			builder.AddOffset(1, varLeftOffset.Value, 0);
		}

		// Token: 0x060359E7 RID: 219623 RVA: 0x0072FC4C File Offset: 0x0072DE4C
		public static void AddVarRightType(FlatBufferBuilder builder, TVarRef varRightType)
		{
			builder.AddByte(2, (byte)varRightType, 0);
		}

		// Token: 0x060359E8 RID: 219624 RVA: 0x0072FC57 File Offset: 0x0072DE57
		public static void AddVarRight(FlatBufferBuilder builder, int varRightOffset)
		{
			builder.AddOffset(3, varRightOffset, 0);
		}

		// Token: 0x060359E9 RID: 219625 RVA: 0x0072FC62 File Offset: 0x0072DE62
		public static Offset<ISetActorVar> EndISetActorVar(FlatBufferBuilder builder)
		{
			return new Offset<ISetActorVar>(builder.EndTable());
		}

		// Token: 0x060359EA RID: 219626 RVA: 0x0072FC70 File Offset: 0x0072DE70
		public ISetActorVarT UnPack()
		{
			ISetActorVarT setActorVarT = new ISetActorVarT();
			this.UnPackTo(setActorVarT);
			return setActorVarT;
		}

		// Token: 0x060359EB RID: 219627 RVA: 0x0072FC8C File Offset: 0x0072DE8C
		public void UnPackTo(ISetActorVarT _o)
		{
			_o.ActorRef = ((this.ActorRef != null) ? this.ActorRef.Value.UnPack() : null);
			_o.VarLeft = this.VarLeft;
			_o.VarRight = new TVarRefUnion();
			_o.VarRight.Type = this.VarRightType;
			switch (this.VarRightType)
			{
			case TVarRef.IConstVarRef:
				_o.VarRight.Value = ((this.VarRight<IConstVarRef>() != null) ? this.VarRight<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.VarRight.Value = ((this.VarRight<IGlobalVarRef>() != null) ? this.VarRight<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.VarRight.Value = ((this.VarRight<IOtherVarRef>() != null) ? this.VarRight<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.VarRight.Value = ((this.VarRight<ISelfVarRef>() != null) ? this.VarRight<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.VarRight.Value = ((this.VarRight<ISystemVarRef>() != null) ? this.VarRight<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060359EC RID: 219628 RVA: 0x0072FE2C File Offset: 0x0072E02C
		public static Offset<ISetActorVar> Pack(FlatBufferBuilder builder, ISetActorVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetActorVar>);
			}
			Offset<IActorRef> actorRefOffset = (_o.ActorRef == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.ActorRef);
			StringOffset varLeftOffset = (_o.VarLeft == null) ? default(StringOffset) : builder.CreateString(_o.VarLeft);
			TVarRef varRight_type = (_o.VarRight == null) ? TVarRef.NONE : _o.VarRight.Type;
			int varRightOffset = (_o.VarRight == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRight);
			return ISetActorVar.CreateISetActorVar(builder, actorRefOffset, varLeftOffset, varRight_type, varRightOffset);
		}

		// Token: 0x0401296D RID: 76141
		private Table __p;
	}
}
