using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000424 RID: 1060
	[NetMessage(EMessageId.EncircleChallengeStartRequest)]
	public sealed class EncircleChallengeStartRequest : IMessage<EncircleChallengeStartRequest>, IMessage, IEquatable<EncircleChallengeStartRequest>, IDeepCloneable<EncircleChallengeStartRequest>, IBufferMessage
	{
		// Token: 0x06006631 RID: 26161 RVA: 0x000F6108 File Offset: 0x000F4308
		[NullableContext(1)]
		public static EncircleChallengeStartRequest Create()
		{
			return new EncircleChallengeStartRequest();
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06006632 RID: 26162 RVA: 0x000F610F File Offset: 0x000F430F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06006633 RID: 26163 RVA: 0x000F6112 File Offset: 0x000F4312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncircleChallengeStartRequest.Descriptor;
			}
		}

		// Token: 0x06006634 RID: 26164 RVA: 0x000F6119 File Offset: 0x000F4319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeStartRequest()
		{
		}

		// Token: 0x06006635 RID: 26165 RVA: 0x000F6121 File Offset: 0x000F4321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeStartRequest(EncircleChallengeStartRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006636 RID: 26166 RVA: 0x000F6146 File Offset: 0x000F4346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeStartRequest Clone()
		{
			return new EncircleChallengeStartRequest(this);
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x06006637 RID: 26167 RVA: 0x000F614E File Offset: 0x000F434E
		// (set) Token: 0x06006638 RID: 26168 RVA: 0x000F6156 File Offset: 0x000F4356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x06006639 RID: 26169 RVA: 0x000F615F File Offset: 0x000F435F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncircleChallengeStartRequest);
		}

		// Token: 0x0600663A RID: 26170 RVA: 0x000F616D File Offset: 0x000F436D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EncircleChallengeStartRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600663B RID: 26171 RVA: 0x000F619C File Offset: 0x000F439C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600663C RID: 26172 RVA: 0x000F61DB File Offset: 0x000F43DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600663D RID: 26173 RVA: 0x000F61E8 File Offset: 0x000F43E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600663E RID: 26174 RVA: 0x000F61F1 File Offset: 0x000F43F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600663F RID: 26175 RVA: 0x000F6224 File Offset: 0x000F4424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006640 RID: 26176 RVA: 0x000F6262 File Offset: 0x000F4462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EncircleChallengeStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006641 RID: 26177 RVA: 0x000F6293 File Offset: 0x000F4493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006642 RID: 26178 RVA: 0x000F629C File Offset: 0x000F449C
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
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400396E RID: 14702
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400396F RID: 14703
		public const int ChallengeIdFieldNumber = 8;

		// Token: 0x04003970 RID: 14704
		private int challengeId_;
	}
}
