using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE1 RID: 3553
	public sealed class PublicAbyssInfo : IMessage<PublicAbyssInfo>, IMessage, IEquatable<PublicAbyssInfo>, IDeepCloneable<PublicAbyssInfo>, IBufferMessage
	{
		// Token: 0x06013238 RID: 78392 RVA: 0x002CA0DD File Offset: 0x002C82DD
		[NullableContext(1)]
		public static PublicAbyssInfo Create()
		{
			return new PublicAbyssInfo();
		}

		// Token: 0x17003F81 RID: 16257
		// (get) Token: 0x06013239 RID: 78393 RVA: 0x002CA0E4 File Offset: 0x002C82E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F82 RID: 16258
		// (get) Token: 0x0601323A RID: 78394 RVA: 0x002CA0E7 File Offset: 0x002C82E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PublicAbyssInfo.Descriptor;
			}
		}

		// Token: 0x0601323B RID: 78395 RVA: 0x002CA0EE File Offset: 0x002C82EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicAbyssInfo()
		{
		}

		// Token: 0x0601323C RID: 78396 RVA: 0x002CA10C File Offset: 0x002C830C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicAbyssInfo(PublicAbyssInfo other) : this()
		{
			this.challengeInfo_ = other.challengeInfo_.Clone();
			this.playerId_ = other.playerId_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601323D RID: 78397 RVA: 0x002CA159 File Offset: 0x002C8359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicAbyssInfo Clone()
		{
			return new PublicAbyssInfo(this);
		}

		// Token: 0x17003F83 RID: 16259
		// (get) Token: 0x0601323E RID: 78398 RVA: 0x002CA161 File Offset: 0x002C8361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssChallengeInfo> ChallengeInfo
		{
			get
			{
				return this.challengeInfo_;
			}
		}

		// Token: 0x17003F84 RID: 16260
		// (get) Token: 0x0601323F RID: 78399 RVA: 0x002CA169 File Offset: 0x002C8369
		// (set) Token: 0x06013240 RID: 78400 RVA: 0x002CA171 File Offset: 0x002C8371
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

		// Token: 0x17003F85 RID: 16261
		// (get) Token: 0x06013241 RID: 78401 RVA: 0x002CA17A File Offset: 0x002C837A
		// (set) Token: 0x06013242 RID: 78402 RVA: 0x002CA182 File Offset: 0x002C8382
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

		// Token: 0x06013243 RID: 78403 RVA: 0x002CA195 File Offset: 0x002C8395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PublicAbyssInfo);
		}

		// Token: 0x06013244 RID: 78404 RVA: 0x002CA1A4 File Offset: 0x002C83A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PublicAbyssInfo other)
		{
			return other != null && (other == this || (this.challengeInfo_.Equals(other.challengeInfo_) && this.PlayerId == other.PlayerId && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013245 RID: 78405 RVA: 0x002CA208 File Offset: 0x002C8408
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

		// Token: 0x06013246 RID: 78406 RVA: 0x002CA270 File Offset: 0x002C8470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013247 RID: 78407 RVA: 0x002CA27D File Offset: 0x002C847D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013248 RID: 78408 RVA: 0x002CA288 File Offset: 0x002C8488
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

		// Token: 0x06013249 RID: 78409 RVA: 0x002CA2F8 File Offset: 0x002C84F8
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

		// Token: 0x0601324A RID: 78410 RVA: 0x002CA368 File Offset: 0x002C8568
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

		// Token: 0x0601324B RID: 78411 RVA: 0x002CA3CE File Offset: 0x002C85CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601324C RID: 78412 RVA: 0x002CA3D8 File Offset: 0x002C85D8
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

		// Token: 0x0400764E RID: 30286
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400764F RID: 30287
		public const int ChallengeInfoFieldNumber = 1;

		// Token: 0x04007650 RID: 30288
		private static readonly FieldCodec<AbyssChallengeInfo> _repeated_challengeInfo_codec = FieldCodec.ForMessage<AbyssChallengeInfo>(10U, AbyssChallengeInfo.Parser);

		// Token: 0x04007651 RID: 30289
		private readonly RepeatedField<AbyssChallengeInfo> challengeInfo_ = new RepeatedField<AbyssChallengeInfo>();

		// Token: 0x04007652 RID: 30290
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04007653 RID: 30291
		private int playerId_;

		// Token: 0x04007654 RID: 30292
		public const int NameFieldNumber = 4;

		// Token: 0x04007655 RID: 30293
		private string name_ = "";
	}
}
