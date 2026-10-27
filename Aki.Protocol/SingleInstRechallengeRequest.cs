using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200122F RID: 4655
	[NetMessage(EMessageId.SingleInstRechallengeRequest)]
	public sealed class SingleInstRechallengeRequest : IMessage<SingleInstRechallengeRequest>, IMessage, IEquatable<SingleInstRechallengeRequest>, IDeepCloneable<SingleInstRechallengeRequest>, IBufferMessage
	{
		// Token: 0x06018CEE RID: 101614 RVA: 0x0039C222 File Offset: 0x0039A422
		[NullableContext(1)]
		public static SingleInstRechallengeRequest Create()
		{
			return new SingleInstRechallengeRequest();
		}

		// Token: 0x170053A0 RID: 21408
		// (get) Token: 0x06018CEF RID: 101615 RVA: 0x0039C229 File Offset: 0x0039A429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053A1 RID: 21409
		// (get) Token: 0x06018CF0 RID: 101616 RVA: 0x0039C22C File Offset: 0x0039A42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SingleInstRechallengeRequest.Descriptor;
			}
		}

		// Token: 0x06018CF1 RID: 101617 RVA: 0x0039C233 File Offset: 0x0039A433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleInstRechallengeRequest()
		{
		}

		// Token: 0x06018CF2 RID: 101618 RVA: 0x0039C254 File Offset: 0x0039A454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleInstRechallengeRequest(SingleInstRechallengeRequest other) : this()
		{
			this.roleIds_ = other.roleIds_.Clone();
			this.towerDefencePhantomId_ = other.towerDefencePhantomId_.Clone();
			this.enterInstContext_ = ((other.enterInstContext_ != null) ? other.enterInstContext_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018CF3 RID: 101619 RVA: 0x0039C2B6 File Offset: 0x0039A4B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleInstRechallengeRequest Clone()
		{
			return new SingleInstRechallengeRequest(this);
		}

		// Token: 0x170053A2 RID: 21410
		// (get) Token: 0x06018CF4 RID: 101620 RVA: 0x0039C2BE File Offset: 0x0039A4BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x170053A3 RID: 21411
		// (get) Token: 0x06018CF5 RID: 101621 RVA: 0x0039C2C6 File Offset: 0x0039A4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TowerDefencePhantomId
		{
			get
			{
				return this.towerDefencePhantomId_;
			}
		}

		// Token: 0x170053A4 RID: 21412
		// (get) Token: 0x06018CF6 RID: 101622 RVA: 0x0039C2CE File Offset: 0x0039A4CE
		// (set) Token: 0x06018CF7 RID: 101623 RVA: 0x0039C2D6 File Offset: 0x0039A4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstContext EnterInstContext
		{
			get
			{
				return this.enterInstContext_;
			}
			set
			{
				this.enterInstContext_ = value;
			}
		}

		// Token: 0x06018CF8 RID: 101624 RVA: 0x0039C2DF File Offset: 0x0039A4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SingleInstRechallengeRequest);
		}

		// Token: 0x06018CF9 RID: 101625 RVA: 0x0039C2F0 File Offset: 0x0039A4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SingleInstRechallengeRequest other)
		{
			return other != null && (other == this || (this.roleIds_.Equals(other.roleIds_) && this.towerDefencePhantomId_.Equals(other.towerDefencePhantomId_) && object.Equals(this.EnterInstContext, other.EnterInstContext) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018CFA RID: 101626 RVA: 0x0039C358 File Offset: 0x0039A558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleIds_.GetHashCode();
			num ^= this.towerDefencePhantomId_.GetHashCode();
			if (this.enterInstContext_ != null)
			{
				num ^= this.EnterInstContext.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018CFB RID: 101627 RVA: 0x0039C3B0 File Offset: 0x0039A5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018CFC RID: 101628 RVA: 0x0039C3BD File Offset: 0x0039A5BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018CFD RID: 101629 RVA: 0x0039C3C8 File Offset: 0x0039A5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.towerDefencePhantomId_.WriteTo(ref output, SingleInstRechallengeRequest._repeated_towerDefencePhantomId_codec);
			if (this.enterInstContext_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.EnterInstContext);
			}
			this.roleIds_.WriteTo(ref output, SingleInstRechallengeRequest._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018CFE RID: 101630 RVA: 0x0039C428 File Offset: 0x0039A628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleIds_.CalculateSize(SingleInstRechallengeRequest._repeated_roleIds_codec);
			num += this.towerDefencePhantomId_.CalculateSize(SingleInstRechallengeRequest._repeated_towerDefencePhantomId_codec);
			if (this.enterInstContext_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EnterInstContext);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018CFF RID: 101631 RVA: 0x0039C48C File Offset: 0x0039A68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SingleInstRechallengeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.roleIds_.Add(other.roleIds_);
			this.towerDefencePhantomId_.Add(other.towerDefencePhantomId_);
			if (other.enterInstContext_ != null)
			{
				if (this.enterInstContext_ == null)
				{
					this.EnterInstContext = new EnterInstContext();
				}
				this.EnterInstContext.MergeFrom(other.EnterInstContext);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018D00 RID: 101632 RVA: 0x0039C502 File Offset: 0x0039A702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018D01 RID: 101633 RVA: 0x0039C50C File Offset: 0x0039A70C
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
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.towerDefencePhantomId_.AddEntriesFrom(ref input, SingleInstRechallengeRequest._repeated_towerDefencePhantomId_codec);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.enterInstContext_ == null)
						{
							this.EnterInstContext = new EnterInstContext();
						}
						input.ReadMessage(this.EnterInstContext);
						continue;
					}
					if (num == 112U || num == 114U)
					{
						this.roleIds_.AddEntriesFrom(ref input, SingleInstRechallengeRequest._repeated_roleIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400925C RID: 37468
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400925D RID: 37469
		public const int RoleIdsFieldNumber = 14;

		// Token: 0x0400925E RID: 37470
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x0400925F RID: 37471
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04009260 RID: 37472
		public const int TowerDefencePhantomIdFieldNumber = 3;

		// Token: 0x04009261 RID: 37473
		private static readonly FieldCodec<int> _repeated_towerDefencePhantomId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04009262 RID: 37474
		private readonly RepeatedField<int> towerDefencePhantomId_ = new RepeatedField<int>();

		// Token: 0x04009263 RID: 37475
		public const int EnterInstContextFieldNumber = 8;

		// Token: 0x04009264 RID: 37476
		private EnterInstContext enterInstContext_;
	}
}
