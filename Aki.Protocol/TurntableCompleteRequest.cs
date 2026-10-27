using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001470 RID: 5232
	[NetMessage(EMessageId.TurntableCompleteRequest)]
	public sealed class TurntableCompleteRequest : IMessage<TurntableCompleteRequest>, IMessage, IEquatable<TurntableCompleteRequest>, IDeepCloneable<TurntableCompleteRequest>, IBufferMessage
	{
		// Token: 0x0601BB2E RID: 113454 RVA: 0x004023A5 File Offset: 0x004005A5
		[NullableContext(1)]
		public static TurntableCompleteRequest Create()
		{
			return new TurntableCompleteRequest();
		}

		// Token: 0x17005D69 RID: 23913
		// (get) Token: 0x0601BB2F RID: 113455 RVA: 0x004023AC File Offset: 0x004005AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D6A RID: 23914
		// (get) Token: 0x0601BB30 RID: 113456 RVA: 0x004023AF File Offset: 0x004005AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TurntableCompleteRequest.Descriptor;
			}
		}

		// Token: 0x0601BB31 RID: 113457 RVA: 0x004023B6 File Offset: 0x004005B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableCompleteRequest()
		{
		}

		// Token: 0x0601BB32 RID: 113458 RVA: 0x004023BE File Offset: 0x004005BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableCompleteRequest(TurntableCompleteRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BB33 RID: 113459 RVA: 0x004023E3 File Offset: 0x004005E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableCompleteRequest Clone()
		{
			return new TurntableCompleteRequest(this);
		}

		// Token: 0x17005D6B RID: 23915
		// (get) Token: 0x0601BB34 RID: 113460 RVA: 0x004023EB File Offset: 0x004005EB
		// (set) Token: 0x0601BB35 RID: 113461 RVA: 0x004023F3 File Offset: 0x004005F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x0601BB36 RID: 113462 RVA: 0x004023FC File Offset: 0x004005FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TurntableCompleteRequest);
		}

		// Token: 0x0601BB37 RID: 113463 RVA: 0x0040240A File Offset: 0x0040060A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TurntableCompleteRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BB38 RID: 113464 RVA: 0x00402438 File Offset: 0x00400638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BB39 RID: 113465 RVA: 0x00402477 File Offset: 0x00400677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BB3A RID: 113466 RVA: 0x00402484 File Offset: 0x00400684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BB3B RID: 113467 RVA: 0x0040248D File Offset: 0x0040068D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BB3C RID: 113468 RVA: 0x004024C0 File Offset: 0x004006C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BB3D RID: 113469 RVA: 0x004024FE File Offset: 0x004006FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TurntableCompleteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BB3E RID: 113470 RVA: 0x0040252F File Offset: 0x0040072F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BB3F RID: 113471 RVA: 0x00402538 File Offset: 0x00400738
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009F94 RID: 40852
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F95 RID: 40853
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04009F96 RID: 40854
		private long entityId_;
	}
}
