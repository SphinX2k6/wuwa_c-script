using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200067F RID: 1663
	[NetMessage(EMessageId.FunPlayChallengeSettleNotify)]
	public sealed class FunPlayChallengeSettleNotify : IMessage<FunPlayChallengeSettleNotify>, IMessage, IEquatable<FunPlayChallengeSettleNotify>, IDeepCloneable<FunPlayChallengeSettleNotify>, IBufferMessage
	{
		// Token: 0x06009852 RID: 38994 RVA: 0x0016F085 File Offset: 0x0016D285
		[NullableContext(1)]
		public static FunPlayChallengeSettleNotify Create()
		{
			return new FunPlayChallengeSettleNotify();
		}

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x06009853 RID: 38995 RVA: 0x0016F08C File Offset: 0x0016D28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x06009854 RID: 38996 RVA: 0x0016F08F File Offset: 0x0016D28F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FunPlayChallengeSettleNotify.Descriptor;
			}
		}

		// Token: 0x06009855 RID: 38997 RVA: 0x0016F096 File Offset: 0x0016D296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeSettleNotify()
		{
		}

		// Token: 0x06009856 RID: 38998 RVA: 0x0016F09E File Offset: 0x0016D29E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeSettleNotify(FunPlayChallengeSettleNotify other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.isSuccess_ = other.isSuccess_;
			this.isActivityOpen_ = other.isActivityOpen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009857 RID: 38999 RVA: 0x0016F0DB File Offset: 0x0016D2DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeSettleNotify Clone()
		{
			return new FunPlayChallengeSettleNotify(this);
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x06009858 RID: 39000 RVA: 0x0016F0E3 File Offset: 0x0016D2E3
		// (set) Token: 0x06009859 RID: 39001 RVA: 0x0016F0EB File Offset: 0x0016D2EB
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

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x0600985A RID: 39002 RVA: 0x0016F0F4 File Offset: 0x0016D2F4
		// (set) Token: 0x0600985B RID: 39003 RVA: 0x0016F0FC File Offset: 0x0016D2FC
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

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x0600985C RID: 39004 RVA: 0x0016F105 File Offset: 0x0016D305
		// (set) Token: 0x0600985D RID: 39005 RVA: 0x0016F10D File Offset: 0x0016D30D
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

		// Token: 0x0600985E RID: 39006 RVA: 0x0016F116 File Offset: 0x0016D316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FunPlayChallengeSettleNotify);
		}

		// Token: 0x0600985F RID: 39007 RVA: 0x0016F124 File Offset: 0x0016D324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FunPlayChallengeSettleNotify other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.IsSuccess == other.IsSuccess && this.IsActivityOpen == other.IsActivityOpen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009860 RID: 39008 RVA: 0x0016F180 File Offset: 0x0016D380
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

		// Token: 0x06009861 RID: 39009 RVA: 0x0016F1F1 File Offset: 0x0016D3F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009862 RID: 39010 RVA: 0x0016F1FE File Offset: 0x0016D3FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009863 RID: 39011 RVA: 0x0016F208 File Offset: 0x0016D408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsActivityOpen)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsActivityOpen);
			}
			if (this.IsSuccess)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsSuccess);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009864 RID: 39012 RVA: 0x0016F27C File Offset: 0x0016D47C
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

		// Token: 0x06009865 RID: 39013 RVA: 0x0016F2D4 File Offset: 0x0016D4D4
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

		// Token: 0x06009866 RID: 39014 RVA: 0x0016F338 File Offset: 0x0016D538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009867 RID: 39015 RVA: 0x0016F344 File Offset: 0x0016D544
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
					if (num != 40U)
					{
						if (num != 72U)
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
						this.IsSuccess = input.ReadBool();
					}
				}
				else
				{
					this.IsActivityOpen = input.ReadBool();
				}
			}
		}

		// Token: 0x0400483A RID: 18490
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400483B RID: 18491
		public const int ChallengeIdFieldNumber = 9;

		// Token: 0x0400483C RID: 18492
		private int challengeId_;

		// Token: 0x0400483D RID: 18493
		public const int IsSuccessFieldNumber = 5;

		// Token: 0x0400483E RID: 18494
		private bool isSuccess_;

		// Token: 0x0400483F RID: 18495
		public const int IsActivityOpenFieldNumber = 1;

		// Token: 0x04004840 RID: 18496
		private bool isActivityOpen_;
	}
}
