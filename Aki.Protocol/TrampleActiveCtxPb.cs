using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001465 RID: 5221
	public sealed class TrampleActiveCtxPb : IMessage<TrampleActiveCtxPb>, IMessage, IEquatable<TrampleActiveCtxPb>, IDeepCloneable<TrampleActiveCtxPb>, IBufferMessage
	{
		// Token: 0x0601BB78 RID: 113528 RVA: 0x004063E4 File Offset: 0x004045E4
		[NullableContext(1)]
		public static TrampleActiveCtxPb Create()
		{
			return new TrampleActiveCtxPb();
		}

		// Token: 0x17005DC4 RID: 24004
		// (get) Token: 0x0601BB79 RID: 113529 RVA: 0x004063EB File Offset: 0x004045EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DC5 RID: 24005
		// (get) Token: 0x0601BB7A RID: 113530 RVA: 0x004063EE File Offset: 0x004045EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrampleActiveCtxPb.Descriptor;
			}
		}

		// Token: 0x0601BB7B RID: 113531 RVA: 0x004063F5 File Offset: 0x004045F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleActiveCtxPb()
		{
		}

		// Token: 0x0601BB7C RID: 113532 RVA: 0x004063FD File Offset: 0x004045FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleActiveCtxPb(TrampleActiveCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BB7D RID: 113533 RVA: 0x00406432 File Offset: 0x00404632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleActiveCtxPb Clone()
		{
			return new TrampleActiveCtxPb(this);
		}

		// Token: 0x17005DC6 RID: 24006
		// (get) Token: 0x0601BB7E RID: 113534 RVA: 0x0040643A File Offset: 0x0040463A
		// (set) Token: 0x0601BB7F RID: 113535 RVA: 0x00406442 File Offset: 0x00404642
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

		// Token: 0x0601BB80 RID: 113536 RVA: 0x0040644B File Offset: 0x0040464B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrampleActiveCtxPb);
		}

		// Token: 0x0601BB81 RID: 113537 RVA: 0x00406459 File Offset: 0x00404659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrampleActiveCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BB82 RID: 113538 RVA: 0x0040648C File Offset: 0x0040468C
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

		// Token: 0x0601BB83 RID: 113539 RVA: 0x004064C8 File Offset: 0x004046C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BB84 RID: 113540 RVA: 0x004064D5 File Offset: 0x004046D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BB85 RID: 113541 RVA: 0x004064DE File Offset: 0x004046DE
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

		// Token: 0x0601BB86 RID: 113542 RVA: 0x00406510 File Offset: 0x00404710
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

		// Token: 0x0601BB87 RID: 113543 RVA: 0x00406550 File Offset: 0x00404750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrampleActiveCtxPb other)
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

		// Token: 0x0601BB88 RID: 113544 RVA: 0x004065A4 File Offset: 0x004047A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BB89 RID: 113545 RVA: 0x004065B0 File Offset: 0x004047B0
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

		// Token: 0x0400A0D8 RID: 41176
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0D9 RID: 41177
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x0400A0DA RID: 41178
		private EntityCtxPb entityCtx_;
	}
}
