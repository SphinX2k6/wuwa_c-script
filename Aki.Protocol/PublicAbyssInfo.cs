using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF1 RID: 3569
	public sealed class PublicAbyssInfo : IMessage<PublicAbyssInfo>, IMessage, IEquatable<PublicAbyssInfo>, IDeepCloneable<PublicAbyssInfo>, IBufferMessage
	{
		// Token: 0x0601331D RID: 78621 RVA: 0x002CB7A1 File Offset: 0x002C99A1
		[NullableContext(1)]
		public static PublicAbyssInfo Create()
		{
			return new PublicAbyssInfo();
		}

		// Token: 0x17003FAB RID: 16299
		// (get) Token: 0x0601331E RID: 78622 RVA: 0x002CB7A8 File Offset: 0x002C99A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FAC RID: 16300
		// (get) Token: 0x0601331F RID: 78623 RVA: 0x002CB7AB File Offset: 0x002C99AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PublicAbyssInfo.Descriptor;
			}
		}

		// Token: 0x06013320 RID: 78624 RVA: 0x002CB7B2 File Offset: 0x002C99B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicAbyssInfo()
		{
		}

		// Token: 0x06013321 RID: 78625 RVA: 0x002CB7D0 File Offset: 0x002C99D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicAbyssInfo(PublicAbyssInfo other) : this()
		{
			this.challengeInfo_ = other.challengeInfo_.Clone();
			this.playerId_ = other.playerId_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013322 RID: 78626 RVA: 0x002CB81D File Offset: 0x002C9A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicAbyssInfo Clone()
		{
			return new PublicAbyssInfo(this);
		}

		// Token: 0x17003FAD RID: 16301
		// (get) Token: 0x06013323 RID: 78627 RVA: 0x002CB825 File Offset: 0x002C9A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssChallengeInfo> ChallengeInfo
		{
			get
			{
				return this.challengeInfo_;
			}
		}

		// Token: 0x17003FAE RID: 16302
		// (get) Token: 0x06013324 RID: 78628 RVA: 0x002CB82D File Offset: 0x002C9A2D
		// (set) Token: 0x06013325 RID: 78629 RVA: 0x002CB835 File Offset: 0x002C9A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17003FAF RID: 16303
		// (get) Token: 0x06013326 RID: 78630 RVA: 0x002CB83E File Offset: 0x002C9A3E
		// (set) Token: 0x06013327 RID: 78631 RVA: 0x002CB846 File Offset: 0x002C9A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06013328 RID: 78632 RVA: 0x002CB859 File Offset: 0x002C9A59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PublicAbyssInfo);
		}

		// Token: 0x06013329 RID: 78633 RVA: 0x002CB868 File Offset: 0x002C9A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PublicAbyssInfo other)
		{
			return other != null && (other == this || (this.challengeInfo_.Equals(other.challengeInfo_) && this.PlayerId == other.PlayerId && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601332A RID: 78634 RVA: 0x002CB8CC File Offset: 0x002C9ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.challengeInfo_.GetHashCode();
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601332B RID: 78635 RVA: 0x002CB934 File Offset: 0x002C9B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601332C RID: 78636 RVA: 0x002CB941 File Offset: 0x002C9B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601332D RID: 78637 RVA: 0x002CB94C File Offset: 0x002C9B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challengeInfo_.WriteTo(ref output, PublicAbyssInfo._repeated_challengeInfo_codec);
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601332E RID: 78638 RVA: 0x002CB9BC File Offset: 0x002C9BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challengeInfo_.CalculateSize(PublicAbyssInfo._repeated_challengeInfo_codec);
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601332F RID: 78639 RVA: 0x002CBA2C File Offset: 0x002C9C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PublicAbyssInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.challengeInfo_.Add(other.challengeInfo_);
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013330 RID: 78640 RVA: 0x002CBA92 File Offset: 0x002C9C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013331 RID: 78641 RVA: 0x002CBA9C File Offset: 0x002C9C9C
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
				if (num != 10U)
				{
					if (num != 24U)
					{
						if (num != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Name = input.ReadString();
						}
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.challengeInfo_.AddEntriesFrom(ref input, PublicAbyssInfo._repeated_challengeInfo_codec);
				}
			}
		}

		// Token: 0x04007624 RID: 30244
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007625 RID: 30245
		public const int ChallengeInfoFieldNumber = 1;

		// Token: 0x04007626 RID: 30246
		private static readonly FieldCodec<AbyssChallengeInfo> _repeated_challengeInfo_codec = FieldCodec.ForMessage<AbyssChallengeInfo>(10U, AbyssChallengeInfo.Parser);

		// Token: 0x04007627 RID: 30247
		private readonly RepeatedField<AbyssChallengeInfo> challengeInfo_ = new RepeatedField<AbyssChallengeInfo>();

		// Token: 0x04007628 RID: 30248
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04007629 RID: 30249
		private int playerId_;

		// Token: 0x0400762A RID: 30250
		public const int NameFieldNumber = 4;

		// Token: 0x0400762B RID: 30251
		private string name_ = "";
	}
}
