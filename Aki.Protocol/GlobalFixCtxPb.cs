using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F8 RID: 1784
	public sealed class GlobalFixCtxPb : IMessage<GlobalFixCtxPb>, IMessage, IEquatable<GlobalFixCtxPb>, IDeepCloneable<GlobalFixCtxPb>, IBufferMessage
	{
		// Token: 0x0600A28B RID: 41611 RVA: 0x00189138 File Offset: 0x00187338
		[NullableContext(1)]
		public static GlobalFixCtxPb Create()
		{
			return new GlobalFixCtxPb();
		}

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x0600A28C RID: 41612 RVA: 0x0018913F File Offset: 0x0018733F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x0600A28D RID: 41613 RVA: 0x00189142 File Offset: 0x00187342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GlobalFixCtxPb.Descriptor;
			}
		}

		// Token: 0x0600A28E RID: 41614 RVA: 0x00189149 File Offset: 0x00187349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GlobalFixCtxPb()
		{
		}

		// Token: 0x0600A28F RID: 41615 RVA: 0x00189151 File Offset: 0x00187351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GlobalFixCtxPb(GlobalFixCtxPb other) : this()
		{
			this.fixId_ = other.fixId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A290 RID: 41616 RVA: 0x00189176 File Offset: 0x00187376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GlobalFixCtxPb Clone()
		{
			return new GlobalFixCtxPb(this);
		}

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x0600A291 RID: 41617 RVA: 0x0018917E File Offset: 0x0018737E
		// (set) Token: 0x0600A292 RID: 41618 RVA: 0x00189186 File Offset: 0x00187386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FixId
		{
			get
			{
				return this.fixId_;
			}
			set
			{
				this.fixId_ = value;
			}
		}

		// Token: 0x0600A293 RID: 41619 RVA: 0x0018918F File Offset: 0x0018738F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GlobalFixCtxPb);
		}

		// Token: 0x0600A294 RID: 41620 RVA: 0x0018919D File Offset: 0x0018739D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GlobalFixCtxPb other)
		{
			return other != null && (other == this || (this.FixId == other.FixId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A295 RID: 41621 RVA: 0x001891CC File Offset: 0x001873CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FixId != 0)
			{
				num ^= this.FixId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A296 RID: 41622 RVA: 0x0018920B File Offset: 0x0018740B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A297 RID: 41623 RVA: 0x00189218 File Offset: 0x00187418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A298 RID: 41624 RVA: 0x00189221 File Offset: 0x00187421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FixId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FixId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A299 RID: 41625 RVA: 0x00189254 File Offset: 0x00187454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FixId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FixId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A29A RID: 41626 RVA: 0x00189292 File Offset: 0x00187492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GlobalFixCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FixId != 0)
			{
				this.FixId = other.FixId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A29B RID: 41627 RVA: 0x001892C3 File Offset: 0x001874C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A29C RID: 41628 RVA: 0x001892CC File Offset: 0x001874CC
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FixId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004B4F RID: 19279
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B50 RID: 19280
		public const int FixIdFieldNumber = 1;

		// Token: 0x04004B51 RID: 19281
		private int fixId_;
	}
}
