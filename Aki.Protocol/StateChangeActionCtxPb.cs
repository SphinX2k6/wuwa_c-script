using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001291 RID: 4753
	public sealed class StateChangeActionCtxPb : IMessage<StateChangeActionCtxPb>, IMessage, IEquatable<StateChangeActionCtxPb>, IDeepCloneable<StateChangeActionCtxPb>, IBufferMessage
	{
		// Token: 0x060194EA RID: 103658 RVA: 0x003AE144 File Offset: 0x003AC344
		[NullableContext(1)]
		public static StateChangeActionCtxPb Create()
		{
			return new StateChangeActionCtxPb();
		}

		// Token: 0x1700555D RID: 21853
		// (get) Token: 0x060194EB RID: 103659 RVA: 0x003AE14B File Offset: 0x003AC34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700555E RID: 21854
		// (get) Token: 0x060194EC RID: 103660 RVA: 0x003AE14E File Offset: 0x003AC34E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StateChangeActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060194ED RID: 103661 RVA: 0x003AE155 File Offset: 0x003AC355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateChangeActionCtxPb()
		{
		}

		// Token: 0x060194EE RID: 103662 RVA: 0x003AE160 File Offset: 0x003AC360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateChangeActionCtxPb(StateChangeActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.stateIndex_ = other.stateIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060194EF RID: 103663 RVA: 0x003AE1AC File Offset: 0x003AC3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateChangeActionCtxPb Clone()
		{
			return new StateChangeActionCtxPb(this);
		}

		// Token: 0x1700555F RID: 21855
		// (get) Token: 0x060194F0 RID: 103664 RVA: 0x003AE1B4 File Offset: 0x003AC3B4
		// (set) Token: 0x060194F1 RID: 103665 RVA: 0x003AE1BC File Offset: 0x003AC3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb EntityCtx
		{
			get
			{
				return this.entityCtx_;
			}
			set
			{
				this.entityCtx_ = value;
			}
		}

		// Token: 0x17005560 RID: 21856
		// (get) Token: 0x060194F2 RID: 103666 RVA: 0x003AE1C5 File Offset: 0x003AC3C5
		// (set) Token: 0x060194F3 RID: 103667 RVA: 0x003AE1CD File Offset: 0x003AC3CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateIndex
		{
			get
			{
				return this.stateIndex_;
			}
			set
			{
				this.stateIndex_ = value;
			}
		}

		// Token: 0x060194F4 RID: 103668 RVA: 0x003AE1D6 File Offset: 0x003AC3D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StateChangeActionCtxPb);
		}

		// Token: 0x060194F5 RID: 103669 RVA: 0x003AE1E4 File Offset: 0x003AC3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StateChangeActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.StateIndex == other.StateIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060194F6 RID: 103670 RVA: 0x003AE234 File Offset: 0x003AC434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.StateIndex != 0)
			{
				num ^= this.StateIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060194F7 RID: 103671 RVA: 0x003AE289 File Offset: 0x003AC489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060194F8 RID: 103672 RVA: 0x003AE296 File Offset: 0x003AC496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060194F9 RID: 103673 RVA: 0x003AE2A0 File Offset: 0x003AC4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.StateIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StateIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060194FA RID: 103674 RVA: 0x003AE2FC File Offset: 0x003AC4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.StateIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060194FB RID: 103675 RVA: 0x003AE354 File Offset: 0x003AC554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StateChangeActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.entityCtx_ != null)
			{
				if (this.entityCtx_ == null)
				{
					this.EntityCtx = new EntityCtxPb();
				}
				this.EntityCtx.MergeFrom(other.EntityCtx);
			}
			if (other.StateIndex != 0)
			{
				this.StateIndex = other.StateIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060194FC RID: 103676 RVA: 0x003AE3BC File Offset: 0x003AC5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060194FD RID: 103677 RVA: 0x003AE3C8 File Offset: 0x003AC5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.StateIndex = input.ReadInt32();
					}
				}
				else
				{
					if (this.entityCtx_ == null)
					{
						this.EntityCtx = new EntityCtxPb();
					}
					input.ReadMessage(this.EntityCtx);
				}
			}
		}

		// Token: 0x040094C4 RID: 38084
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094C5 RID: 38085
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x040094C6 RID: 38086
		private EntityCtxPb entityCtx_;

		// Token: 0x040094C7 RID: 38087
		public const int StateIndexFieldNumber = 2;

		// Token: 0x040094C8 RID: 38088
		private int stateIndex_;
	}
}
