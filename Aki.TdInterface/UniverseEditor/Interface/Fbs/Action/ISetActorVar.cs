using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F90 RID: 28560
	public struct ISetActorVar : IFlatbufferObject
	{
		// Token: 0x1700D41D RID: 54301
		// (get) Token: 0x06032782 RID: 206722 RVA: 0x006D000F File Offset: 0x006CE20F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032783 RID: 206723 RVA: 0x006D001C File Offset: 0x006CE21C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032784 RID: 206724 RVA: 0x006D0024 File Offset: 0x006CE224
		public static ISetActorVar GetRootAsISetActorVar(ByteBuffer _bb)
		{
			return ISetActorVar.GetRootAsISetActorVar(_bb, default(ISetActorVar));
		}

		// Token: 0x06032785 RID: 206725 RVA: 0x006D0040 File Offset: 0x006CE240
		public static ISetActorVar GetRootAsISetActorVar(ByteBuffer _bb, ISetActorVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032786 RID: 206726 RVA: 0x006D005D File Offset: 0x006CE25D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032787 RID: 206727 RVA: 0x006D006C File Offset: 0x006CE26C
		public ISetActorVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D41E RID: 54302
		// (get) Token: 0x06032788 RID: 206728 RVA: 0x006D007C File Offset: 0x006CE27C
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

		// Token: 0x1700D41F RID: 54303
		// (get) Token: 0x06032789 RID: 206729 RVA: 0x006D00DC File Offset: 0x006CE2DC
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

		// Token: 0x0603278A RID: 206730 RVA: 0x006D0113 File Offset: 0x006CE313
		public Span<byte> GetVarLeftBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603278B RID: 206731 RVA: 0x006D0122 File Offset: 0x006CE322
		public byte[] GetVarLeftArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D420 RID: 54304
		// (get) Token: 0x0603278C RID: 206732 RVA: 0x006D0130 File Offset: 0x006CE330
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

		// Token: 0x0603278D RID: 206733 RVA: 0x006D016C File Offset: 0x006CE36C
		public TTable? VarRight<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603278E RID: 206734 RVA: 0x006D01B4 File Offset: 0x006CE3B4
		public IConstVarRef VarRightAsIConstVarRef()
		{
			return this.VarRight<IConstVarRef>().Value;
		}

		// Token: 0x0603278F RID: 206735 RVA: 0x006D01D0 File Offset: 0x006CE3D0
		public IGlobalVarRef VarRightAsIGlobalVarRef()
		{
			return this.VarRight<IGlobalVarRef>().Value;
		}

		// Token: 0x06032790 RID: 206736 RVA: 0x006D01EC File Offset: 0x006CE3EC
		public IOtherVarRef VarRightAsIOtherVarRef()
		{
			return this.VarRight<IOtherVarRef>().Value;
		}

		// Token: 0x06032791 RID: 206737 RVA: 0x006D0208 File Offset: 0x006CE408
		public ISelfVarRef VarRightAsISelfVarRef()
		{
			return this.VarRight<ISelfVarRef>().Value;
		}

		// Token: 0x06032792 RID: 206738 RVA: 0x006D0224 File Offset: 0x006CE424
		public ISystemVarRef VarRightAsISystemVarRef()
		{
			return this.VarRight<ISystemVarRef>().Value;
		}

		// Token: 0x06032793 RID: 206739 RVA: 0x006D023F File Offset: 0x006CE43F
		public static Offset<ISetActorVar> CreateISetActorVar(FlatBufferBuilder builder, Offset<IActorRef> ActorRefOffset = default(Offset<IActorRef>), StringOffset VarLeftOffset = default(StringOffset), TVarRef VarRight_type = TVarRef.NONE, int VarRightOffset = 0)
		{
			builder.StartTable(4);
			ISetActorVar.AddVarRight(builder, VarRightOffset);
			ISetActorVar.AddVarLeft(builder, VarLeftOffset);
			ISetActorVar.AddActorRef(builder, ActorRefOffset);
			ISetActorVar.AddVarRightType(builder, VarRight_type);
			return ISetActorVar.EndISetActorVar(builder);
		}

		// Token: 0x06032794 RID: 206740 RVA: 0x006D026B File Offset: 0x006CE46B
		public static void StartISetActorVar(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06032795 RID: 206741 RVA: 0x006D0274 File Offset: 0x006CE474
		public static void AddActorRef(FlatBufferBuilder builder, Offset<IActorRef> actorRefOffset)
		{
			builder.AddOffset(0, actorRefOffset.Value, 0);
		}

		// Token: 0x06032796 RID: 206742 RVA: 0x006D0284 File Offset: 0x006CE484
		public static void AddVarLeft(FlatBufferBuilder builder, StringOffset varLeftOffset)
		{
			builder.AddOffset(1, varLeftOffset.Value, 0);
		}

		// Token: 0x06032797 RID: 206743 RVA: 0x006D0294 File Offset: 0x006CE494
		public static void AddVarRightType(FlatBufferBuilder builder, TVarRef varRightType)
		{
			builder.AddByte(2, (byte)varRightType, 0);
		}

		// Token: 0x06032798 RID: 206744 RVA: 0x006D029F File Offset: 0x006CE49F
		public static void AddVarRight(FlatBufferBuilder builder, int varRightOffset)
		{
			builder.AddOffset(3, varRightOffset, 0);
		}

		// Token: 0x06032799 RID: 206745 RVA: 0x006D02AA File Offset: 0x006CE4AA
		public static Offset<ISetActorVar> EndISetActorVar(FlatBufferBuilder builder)
		{
			return new Offset<ISetActorVar>(builder.EndTable());
		}

		// Token: 0x0603279A RID: 206746 RVA: 0x006D02B8 File Offset: 0x006CE4B8
		public ISetActorVarT UnPack()
		{
			ISetActorVarT setActorVarT = new ISetActorVarT();
			this.UnPackTo(setActorVarT);
			return setActorVarT;
		}

		// Token: 0x0603279B RID: 206747 RVA: 0x006D02D4 File Offset: 0x006CE4D4
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

		// Token: 0x0603279C RID: 206748 RVA: 0x006D0474 File Offset: 0x006CE674
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

		// Token: 0x0401198B RID: 72075
		private Table __p;
	}
}
