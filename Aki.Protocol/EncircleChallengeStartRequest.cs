using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200043B RID: 1083
	[NetMessage(EMessageId.EncircleChallengeStartRequest)]
	public sealed class EncircleChallengeStartRequest : IMessage<EncircleChallengeStartRequest>, IMessage, IEquatable<EncircleChallengeStartRequest>, IDeepCloneable<EncircleChallengeStartRequest>, IBufferMessage
	{
		// Token: 0x060067C1 RID: 26561 RVA: 0x000F9284 File Offset: 0x000F7484
		[NullableContext(1)]
		public static EncircleChallengeStartRequest Create()
		{
			return new EncircleChallengeStartRequest();
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x060067C2 RID: 26562 RVA: 0x000F928B File Offset: 0x000F748B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x060067C3 RID: 26563 RVA: 0x000F928E File Offset: 0x000F748E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncircleChallengeStartRequest.Descriptor;
			}
		}

		// Token: 0x060067C4 RID: 26564 RVA: 0x000F9295 File Offset: 0x000F7495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeStartRequest()
		{
		}

		// Token: 0x060067C5 RID: 26565 RVA: 0x000F929D File Offset: 0x000F749D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeStartRequest(EncircleChallengeStartRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060067C6 RID: 26566 RVA: 0x000F92C2 File Offset: 0x000F74C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeStartRequest Clone()
		{
			return new EncircleChallengeStartRequest(this);
		}

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x060067C7 RID: 26567 RVA: 0x000F92CA File Offset: 0x000F74CA
		// (set) Token: 0x060067C8 RID: 26568 RVA: 0x000F92D2 File Offset: 0x000F74D2
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

		// Token: 0x060067C9 RID: 26569 RVA: 0x000F92DB File Offset: 0x000F74DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncircleChallengeStartRequest);
		}

		// Token: 0x060067CA RID: 26570 RVA: 0x000F92E9 File Offset: 0x000F74E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EncircleChallengeStartRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060067CB RID: 26571 RVA: 0x000F9318 File Offset: 0x000F7518
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

		// Token: 0x060067CC RID: 26572 RVA: 0x000F9357 File Offset: 0x000F7557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060067CD RID: 26573 RVA: 0x000F9364 File Offset: 0x000F7564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060067CE RID: 26574 RVA: 0x000F936D File Offset: 0x000F756D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060067CF RID: 26575 RVA: 0x000F93A0 File Offset: 0x000F75A0
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

		// Token: 0x060067D0 RID: 26576 RVA: 0x000F93DE File Offset: 0x000F75DE
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

		// Token: 0x060067D1 RID: 26577 RVA: 0x000F940F File Offset: 0x000F760F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060067D2 RID: 26578 RVA: 0x000F9418 File Offset: 0x000F7618
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003981 RID: 14721
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003982 RID: 14722
		public const int ChallengeIdFieldNumber = 7;

		// Token: 0x04003983 RID: 14723
		private int challengeId_;
	}
}
