using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C0 RID: 4288
	[NetMessage(EMessageId.RoleTowerChallengeSettleRequest)]
	public sealed class RoleTowerChallengeSettleRequest : IMessage<RoleTowerChallengeSettleRequest>, IMessage, IEquatable<RoleTowerChallengeSettleRequest>, IDeepCloneable<RoleTowerChallengeSettleRequest>, IBufferMessage
	{
		// Token: 0x06016EC3 RID: 93891 RVA: 0x0035583C File Offset: 0x00353A3C
		[NullableContext(1)]
		public static RoleTowerChallengeSettleRequest Create()
		{
			return new RoleTowerChallengeSettleRequest();
		}

		// Token: 0x17004CE3 RID: 19683
		// (get) Token: 0x06016EC4 RID: 93892 RVA: 0x00355843 File Offset: 0x00353A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CE4 RID: 19684
		// (get) Token: 0x06016EC5 RID: 93893 RVA: 0x00355846 File Offset: 0x00353A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerChallengeSettleRequest.Descriptor;
			}
		}

		// Token: 0x06016EC6 RID: 93894 RVA: 0x0035584D File Offset: 0x00353A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSettleRequest()
		{
		}

		// Token: 0x06016EC7 RID: 93895 RVA: 0x00355855 File Offset: 0x00353A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSettleRequest(RoleTowerChallengeSettleRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016EC8 RID: 93896 RVA: 0x0035587A File Offset: 0x00353A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSettleRequest Clone()
		{
			return new RoleTowerChallengeSettleRequest(this);
		}

		// Token: 0x17004CE5 RID: 19685
		// (get) Token: 0x06016EC9 RID: 93897 RVA: 0x00355882 File Offset: 0x00353A82
		// (set) Token: 0x06016ECA RID: 93898 RVA: 0x0035588A File Offset: 0x00353A8A
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

		// Token: 0x06016ECB RID: 93899 RVA: 0x00355893 File Offset: 0x00353A93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerChallengeSettleRequest);
		}

		// Token: 0x06016ECC RID: 93900 RVA: 0x003558A1 File Offset: 0x00353AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerChallengeSettleRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016ECD RID: 93901 RVA: 0x003558D0 File Offset: 0x00353AD0
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

		// Token: 0x06016ECE RID: 93902 RVA: 0x0035590F File Offset: 0x00353B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016ECF RID: 93903 RVA: 0x0035591C File Offset: 0x00353B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016ED0 RID: 93904 RVA: 0x00355925 File Offset: 0x00353B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06016ED1 RID: 93905 RVA: 0x00355958 File Offset: 0x00353B58
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

		// Token: 0x06016ED2 RID: 93906 RVA: 0x00355996 File Offset: 0x00353B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerChallengeSettleRequest other)
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

		// Token: 0x06016ED3 RID: 93907 RVA: 0x003559C7 File Offset: 0x00353BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016ED4 RID: 93908 RVA: 0x003559D0 File Offset: 0x00353BD0
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008941 RID: 35137
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008942 RID: 35138
		public const int ChallengeIdFieldNumber = 9;

		// Token: 0x04008943 RID: 35139
		private int challengeId_;
	}
}
