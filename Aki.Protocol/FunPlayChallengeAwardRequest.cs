using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000667 RID: 1639
	[NetMessage(EMessageId.FunPlayChallengeAwardRequest)]
	public sealed class FunPlayChallengeAwardRequest : IMessage<FunPlayChallengeAwardRequest>, IMessage, IEquatable<FunPlayChallengeAwardRequest>, IDeepCloneable<FunPlayChallengeAwardRequest>, IBufferMessage
	{
		// Token: 0x060096AB RID: 38571 RVA: 0x0016BBED File Offset: 0x00169DED
		[NullableContext(1)]
		public static FunPlayChallengeAwardRequest Create()
		{
			return new FunPlayChallengeAwardRequest();
		}

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x060096AC RID: 38572 RVA: 0x0016BBF4 File Offset: 0x00169DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x060096AD RID: 38573 RVA: 0x0016BBF7 File Offset: 0x00169DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FunPlayChallengeAwardRequest.Descriptor;
			}
		}

		// Token: 0x060096AE RID: 38574 RVA: 0x0016BBFE File Offset: 0x00169DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeAwardRequest()
		{
		}

		// Token: 0x060096AF RID: 38575 RVA: 0x0016BC06 File Offset: 0x00169E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeAwardRequest(FunPlayChallengeAwardRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060096B0 RID: 38576 RVA: 0x0016BC2B File Offset: 0x00169E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeAwardRequest Clone()
		{
			return new FunPlayChallengeAwardRequest(this);
		}

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x060096B1 RID: 38577 RVA: 0x0016BC33 File Offset: 0x00169E33
		// (set) Token: 0x060096B2 RID: 38578 RVA: 0x0016BC3B File Offset: 0x00169E3B
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

		// Token: 0x060096B3 RID: 38579 RVA: 0x0016BC44 File Offset: 0x00169E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FunPlayChallengeAwardRequest);
		}

		// Token: 0x060096B4 RID: 38580 RVA: 0x0016BC52 File Offset: 0x00169E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FunPlayChallengeAwardRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060096B5 RID: 38581 RVA: 0x0016BC80 File Offset: 0x00169E80
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

		// Token: 0x060096B6 RID: 38582 RVA: 0x0016BCBF File Offset: 0x00169EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060096B7 RID: 38583 RVA: 0x0016BCCC File Offset: 0x00169ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060096B8 RID: 38584 RVA: 0x0016BCD5 File Offset: 0x00169ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060096B9 RID: 38585 RVA: 0x0016BD08 File Offset: 0x00169F08
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

		// Token: 0x060096BA RID: 38586 RVA: 0x0016BD46 File Offset: 0x00169F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FunPlayChallengeAwardRequest other)
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

		// Token: 0x060096BB RID: 38587 RVA: 0x0016BD77 File Offset: 0x00169F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060096BC RID: 38588 RVA: 0x0016BD80 File Offset: 0x00169F80
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400481C RID: 18460
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400481D RID: 18461
		public const int ChallengeIdFieldNumber = 2;

		// Token: 0x0400481E RID: 18462
		private int challengeId_;
	}
}
