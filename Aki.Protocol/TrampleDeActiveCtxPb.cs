using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001466 RID: 5222
	public sealed class TrampleDeActiveCtxPb : IMessage<TrampleDeActiveCtxPb>, IMessage, IEquatable<TrampleDeActiveCtxPb>, IDeepCloneable<TrampleDeActiveCtxPb>, IBufferMessage
	{
		// Token: 0x0601BB8A RID: 113546 RVA: 0x00406608 File Offset: 0x00404808
		[NullableContext(1)]
		public static TrampleDeActiveCtxPb Create()
		{
			return new TrampleDeActiveCtxPb();
		}

		// Token: 0x17005DC7 RID: 24007
		// (get) Token: 0x0601BB8B RID: 113547 RVA: 0x0040660F File Offset: 0x0040480F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DC8 RID: 24008
		// (get) Token: 0x0601BB8C RID: 113548 RVA: 0x00406612 File Offset: 0x00404812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrampleDeActiveCtxPb.Descriptor;
			}
		}

		// Token: 0x0601BB8D RID: 113549 RVA: 0x00406619 File Offset: 0x00404819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleDeActiveCtxPb()
		{
		}

		// Token: 0x0601BB8E RID: 113550 RVA: 0x00406621 File Offset: 0x00404821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleDeActiveCtxPb(TrampleDeActiveCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BB8F RID: 113551 RVA: 0x00406656 File Offset: 0x00404856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleDeActiveCtxPb Clone()
		{
			return new TrampleDeActiveCtxPb(this);
		}

		// Token: 0x17005DC9 RID: 24009
		// (get) Token: 0x0601BB90 RID: 113552 RVA: 0x0040665E File Offset: 0x0040485E
		// (set) Token: 0x0601BB91 RID: 113553 RVA: 0x00406666 File Offset: 0x00404866
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

		// Token: 0x0601BB92 RID: 113554 RVA: 0x0040666F File Offset: 0x0040486F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrampleDeActiveCtxPb);
		}

		// Token: 0x0601BB93 RID: 113555 RVA: 0x0040667D File Offset: 0x0040487D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrampleDeActiveCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BB94 RID: 113556 RVA: 0x004066B0 File Offset: 0x004048B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BB95 RID: 113557 RVA: 0x004066EC File Offset: 0x004048EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BB96 RID: 113558 RVA: 0x004066F9 File Offset: 0x004048F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BB97 RID: 113559 RVA: 0x00406702 File Offset: 0x00404902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BB98 RID: 113560 RVA: 0x00406734 File Offset: 0x00404934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BB99 RID: 113561 RVA: 0x00406774 File Offset: 0x00404974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrampleDeActiveCtxPb other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BB9A RID: 113562 RVA: 0x004067C8 File Offset: 0x004049C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BB9B RID: 113563 RVA: 0x004067D4 File Offset: 0x004049D4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x0400A0DB RID: 41179
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0DC RID: 41180
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x0400A0DD RID: 41181
		private EntityCtxPb entityCtx_;
	}
}
