using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200066B RID: 1643
	[NetMessage(EMessageId.FunPlayChallengeSettleNotify)]
	public sealed class FunPlayChallengeSettleNotify : IMessage<FunPlayChallengeSettleNotify>, IMessage, IEquatable<FunPlayChallengeSettleNotify>, IDeepCloneable<FunPlayChallengeSettleNotify>, IBufferMessage
	{
		// Token: 0x060096FC RID: 38652 RVA: 0x0016C651 File Offset: 0x0016A851
		[NullableContext(1)]
		public static FunPlayChallengeSettleNotify Create()
		{
			return new FunPlayChallengeSettleNotify();
		}

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x060096FD RID: 38653 RVA: 0x0016C658 File Offset: 0x0016A858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x060096FE RID: 38654 RVA: 0x0016C65B File Offset: 0x0016A85B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FunPlayChallengeSettleNotify.Descriptor;
			}
		}

		// Token: 0x060096FF RID: 38655 RVA: 0x0016C662 File Offset: 0x0016A862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeSettleNotify()
		{
		}

		// Token: 0x06009700 RID: 38656 RVA: 0x0016C66A File Offset: 0x0016A86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeSettleNotify(FunPlayChallengeSettleNotify other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.isSuccess_ = other.isSuccess_;
			this.isActivityOpen_ = other.isActivityOpen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009701 RID: 38657 RVA: 0x0016C6A7 File Offset: 0x0016A8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeSettleNotify Clone()
		{
			return new FunPlayChallengeSettleNotify(this);
		}

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x06009702 RID: 38658 RVA: 0x0016C6AF File Offset: 0x0016A8AF
		// (set) Token: 0x06009703 RID: 38659 RVA: 0x0016C6B7 File Offset: 0x0016A8B7
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

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x06009704 RID: 38660 RVA: 0x0016C6C0 File Offset: 0x0016A8C0
		// (set) Token: 0x06009705 RID: 38661 RVA: 0x0016C6C8 File Offset: 0x0016A8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuccess
		{
			get
			{
				return this.isSuccess_;
			}
			set
			{
				this.isSuccess_ = value;
			}
		}

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x06009706 RID: 38662 RVA: 0x0016C6D1 File Offset: 0x0016A8D1
		// (set) Token: 0x06009707 RID: 38663 RVA: 0x0016C6D9 File Offset: 0x0016A8D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsActivityOpen
		{
			get
			{
				return this.isActivityOpen_;
			}
			set
			{
				this.isActivityOpen_ = value;
			}
		}

		// Token: 0x06009708 RID: 38664 RVA: 0x0016C6E2 File Offset: 0x0016A8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FunPlayChallengeSettleNotify);
		}

		// Token: 0x06009709 RID: 38665 RVA: 0x0016C6F0 File Offset: 0x0016A8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FunPlayChallengeSettleNotify other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.IsSuccess == other.IsSuccess && this.IsActivityOpen == other.IsActivityOpen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600970A RID: 38666 RVA: 0x0016C74C File Offset: 0x0016A94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.IsSuccess)
			{
				num ^= this.IsSuccess.GetHashCode();
			}
			if (this.IsActivityOpen)
			{
				num ^= this.IsActivityOpen.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600970B RID: 38667 RVA: 0x0016C7BD File Offset: 0x0016A9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600970C RID: 38668 RVA: 0x0016C7CA File Offset: 0x0016A9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600970D RID: 38669 RVA: 0x0016C7D4 File Offset: 0x0016A9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsSuccess)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsSuccess);
			}
			if (this.IsActivityOpen)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsActivityOpen);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600970E RID: 38670 RVA: 0x0016C84C File Offset: 0x0016AA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.IsSuccess)
			{
				num += 2;
			}
			if (this.IsActivityOpen)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600970F RID: 38671 RVA: 0x0016C8A4 File Offset: 0x0016AAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FunPlayChallengeSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.IsSuccess)
			{
				this.IsSuccess = other.IsSuccess;
			}
			if (other.IsActivityOpen)
			{
				this.IsActivityOpen = other.IsActivityOpen;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009710 RID: 38672 RVA: 0x0016C908 File Offset: 0x0016AB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009711 RID: 38673 RVA: 0x0016C914 File Offset: 0x0016AB14
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
				if (num != 32U)
				{
					if (num != 72U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ChallengeId = input.ReadInt32();
						}
					}
					else
					{
						this.IsActivityOpen = input.ReadBool();
					}
				}
				else
				{
					this.IsSuccess = input.ReadBool();
				}
			}
		}

		// Token: 0x04004833 RID: 18483
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004834 RID: 18484
		public const int ChallengeIdFieldNumber = 12;

		// Token: 0x04004835 RID: 18485
		private int challengeId_;

		// Token: 0x04004836 RID: 18486
		public const int IsSuccessFieldNumber = 4;

		// Token: 0x04004837 RID: 18487
		private bool isSuccess_;

		// Token: 0x04004838 RID: 18488
		public const int IsActivityOpenFieldNumber = 9;

		// Token: 0x04004839 RID: 18489
		private bool isActivityOpen_;
	}
}
