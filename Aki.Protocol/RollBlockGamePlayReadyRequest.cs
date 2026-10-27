using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010DB RID: 4315
	[NetMessage(EMessageId.RollBlockGamePlayReadyRequest)]
	public sealed class RollBlockGamePlayReadyRequest : IMessage<RollBlockGamePlayReadyRequest>, IMessage, IEquatable<RollBlockGamePlayReadyRequest>, IDeepCloneable<RollBlockGamePlayReadyRequest>, IBufferMessage
	{
		// Token: 0x0601705D RID: 94301 RVA: 0x003579B8 File Offset: 0x00355BB8
		[NullableContext(1)]
		public static RollBlockGamePlayReadyRequest Create()
		{
			return new RollBlockGamePlayReadyRequest();
		}

		// Token: 0x17004D23 RID: 19747
		// (get) Token: 0x0601705E RID: 94302 RVA: 0x003579BF File Offset: 0x00355BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D24 RID: 19748
		// (get) Token: 0x0601705F RID: 94303 RVA: 0x003579C2 File Offset: 0x00355BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockGamePlayReadyRequest.Descriptor;
			}
		}

		// Token: 0x06017060 RID: 94304 RVA: 0x003579C9 File Offset: 0x00355BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayReadyRequest()
		{
		}

		// Token: 0x06017061 RID: 94305 RVA: 0x003579D1 File Offset: 0x00355BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayReadyRequest(RollBlockGamePlayReadyRequest other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017062 RID: 94306 RVA: 0x003579F6 File Offset: 0x00355BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayReadyRequest Clone()
		{
			return new RollBlockGamePlayReadyRequest(this);
		}

		// Token: 0x17004D25 RID: 19749
		// (get) Token: 0x06017063 RID: 94307 RVA: 0x003579FE File Offset: 0x00355BFE
		// (set) Token: 0x06017064 RID: 94308 RVA: 0x00357A06 File Offset: 0x00355C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x06017065 RID: 94309 RVA: 0x00357A0F File Offset: 0x00355C0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockGamePlayReadyRequest);
		}

		// Token: 0x06017066 RID: 94310 RVA: 0x00357A1D File Offset: 0x00355C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockGamePlayReadyRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017067 RID: 94311 RVA: 0x00357A4C File Offset: 0x00355C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017068 RID: 94312 RVA: 0x00357A8B File Offset: 0x00355C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017069 RID: 94313 RVA: 0x00357A98 File Offset: 0x00355C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601706A RID: 94314 RVA: 0x00357AA1 File Offset: 0x00355CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601706B RID: 94315 RVA: 0x00357AD4 File Offset: 0x00355CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601706C RID: 94316 RVA: 0x00357B12 File Offset: 0x00355D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockGamePlayReadyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601706D RID: 94317 RVA: 0x00357B43 File Offset: 0x00355D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601706E RID: 94318 RVA: 0x00357B4C File Offset: 0x00355D4C
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
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008919 RID: 35097
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400891A RID: 35098
		public const int IncIdFieldNumber = 15;

		// Token: 0x0400891B RID: 35099
		private int incId_;
	}
}
