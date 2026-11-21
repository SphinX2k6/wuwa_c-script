using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E6 RID: 4326
	[NetMessage(EMessageId.RoleTowerSaveDeleteRequest)]
	public sealed class RoleTowerSaveDeleteRequest : IMessage<RoleTowerSaveDeleteRequest>, IMessage, IEquatable<RoleTowerSaveDeleteRequest>, IDeepCloneable<RoleTowerSaveDeleteRequest>, IBufferMessage
	{
		// Token: 0x06017210 RID: 94736 RVA: 0x0035D853 File Offset: 0x0035BA53
		[NullableContext(1)]
		public static RoleTowerSaveDeleteRequest Create()
		{
			return new RoleTowerSaveDeleteRequest();
		}

		// Token: 0x17004DAC RID: 19884
		// (get) Token: 0x06017211 RID: 94737 RVA: 0x0035D85A File Offset: 0x0035BA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DAD RID: 19885
		// (get) Token: 0x06017212 RID: 94738 RVA: 0x0035D85D File Offset: 0x0035BA5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerSaveDeleteRequest.Descriptor;
			}
		}

		// Token: 0x06017213 RID: 94739 RVA: 0x0035D864 File Offset: 0x0035BA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerSaveDeleteRequest()
		{
		}

		// Token: 0x06017214 RID: 94740 RVA: 0x0035D86C File Offset: 0x0035BA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerSaveDeleteRequest(RoleTowerSaveDeleteRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017215 RID: 94741 RVA: 0x0035D891 File Offset: 0x0035BA91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerSaveDeleteRequest Clone()
		{
			return new RoleTowerSaveDeleteRequest(this);
		}

		// Token: 0x17004DAE RID: 19886
		// (get) Token: 0x06017216 RID: 94742 RVA: 0x0035D899 File Offset: 0x0035BA99
		// (set) Token: 0x06017217 RID: 94743 RVA: 0x0035D8A1 File Offset: 0x0035BAA1
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

		// Token: 0x06017218 RID: 94744 RVA: 0x0035D8AA File Offset: 0x0035BAAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerSaveDeleteRequest);
		}

		// Token: 0x06017219 RID: 94745 RVA: 0x0035D8B8 File Offset: 0x0035BAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerSaveDeleteRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601721A RID: 94746 RVA: 0x0035D8E8 File Offset: 0x0035BAE8
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

		// Token: 0x0601721B RID: 94747 RVA: 0x0035D927 File Offset: 0x0035BB27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601721C RID: 94748 RVA: 0x0035D934 File Offset: 0x0035BB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601721D RID: 94749 RVA: 0x0035D93D File Offset: 0x0035BB3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601721E RID: 94750 RVA: 0x0035D970 File Offset: 0x0035BB70
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

		// Token: 0x0601721F RID: 94751 RVA: 0x0035D9AE File Offset: 0x0035BBAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerSaveDeleteRequest other)
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

		// Token: 0x06017220 RID: 94752 RVA: 0x0035D9DF File Offset: 0x0035BBDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017221 RID: 94753 RVA: 0x0035D9E8 File Offset: 0x0035BBE8
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008A70 RID: 35440
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A71 RID: 35441
		public const int ChallengeIdFieldNumber = 5;

		// Token: 0x04008A72 RID: 35442
		private int challengeId_;
	}
}
