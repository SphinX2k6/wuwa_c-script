using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B62 RID: 2914
	[NetMessage(EMessageId.NormalMonsterManualInfoRequest)]
	public sealed class NormalMonsterManualInfoRequest : IMessage<NormalMonsterManualInfoRequest>, IMessage, IEquatable<NormalMonsterManualInfoRequest>, IDeepCloneable<NormalMonsterManualInfoRequest>, IBufferMessage
	{
		// Token: 0x0600FC7C RID: 64636 RVA: 0x0024C3DC File Offset: 0x0024A5DC
		[NullableContext(1)]
		public static NormalMonsterManualInfoRequest Create()
		{
			return new NormalMonsterManualInfoRequest();
		}

		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x0600FC7D RID: 64637 RVA: 0x0024C3E3 File Offset: 0x0024A5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x0600FC7E RID: 64638 RVA: 0x0024C3E6 File Offset: 0x0024A5E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalMonsterManualInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600FC7F RID: 64639 RVA: 0x0024C3ED File Offset: 0x0024A5ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalMonsterManualInfoRequest()
		{
		}

		// Token: 0x0600FC80 RID: 64640 RVA: 0x0024C3F5 File Offset: 0x0024A5F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalMonsterManualInfoRequest(NormalMonsterManualInfoRequest other) : this()
		{
			this.detectionId_ = other.detectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FC81 RID: 64641 RVA: 0x0024C41A File Offset: 0x0024A61A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalMonsterManualInfoRequest Clone()
		{
			return new NormalMonsterManualInfoRequest(this);
		}

		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x0600FC82 RID: 64642 RVA: 0x0024C422 File Offset: 0x0024A622
		// (set) Token: 0x0600FC83 RID: 64643 RVA: 0x0024C42A File Offset: 0x0024A62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DetectionId
		{
			get
			{
				return this.detectionId_;
			}
			set
			{
				this.detectionId_ = value;
			}
		}

		// Token: 0x0600FC84 RID: 64644 RVA: 0x0024C433 File Offset: 0x0024A633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalMonsterManualInfoRequest);
		}

		// Token: 0x0600FC85 RID: 64645 RVA: 0x0024C441 File Offset: 0x0024A641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalMonsterManualInfoRequest other)
		{
			return other != null && (other == this || (this.DetectionId == other.DetectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FC86 RID: 64646 RVA: 0x0024C470 File Offset: 0x0024A670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DetectionId != 0)
			{
				num ^= this.DetectionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FC87 RID: 64647 RVA: 0x0024C4AF File Offset: 0x0024A6AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FC88 RID: 64648 RVA: 0x0024C4BC File Offset: 0x0024A6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FC89 RID: 64649 RVA: 0x0024C4C5 File Offset: 0x0024A6C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DetectionId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.DetectionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FC8A RID: 64650 RVA: 0x0024C4F8 File Offset: 0x0024A6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DetectionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DetectionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FC8B RID: 64651 RVA: 0x0024C536 File Offset: 0x0024A736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NormalMonsterManualInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DetectionId != 0)
			{
				this.DetectionId = other.DetectionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FC8C RID: 64652 RVA: 0x0024C567 File Offset: 0x0024A767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FC8D RID: 64653 RVA: 0x0024C570 File Offset: 0x0024A770
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DetectionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040064C6 RID: 25798
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064C7 RID: 25799
		public const int DetectionIdFieldNumber = 8;

		// Token: 0x040064C8 RID: 25800
		private int detectionId_;
	}
}
