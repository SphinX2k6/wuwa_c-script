using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200004A RID: 74
	[NetMessage(EMessageId.AbyssShowNameRequest)]
	public sealed class AbyssShowNameRequest : IMessage<AbyssShowNameRequest>, IMessage, IEquatable<AbyssShowNameRequest>, IDeepCloneable<AbyssShowNameRequest>, IBufferMessage
	{
		// Token: 0x06001454 RID: 5204 RVA: 0x000367B9 File Offset: 0x000349B9
		[NullableContext(1)]
		public static AbyssShowNameRequest Create()
		{
			return new AbyssShowNameRequest();
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x000367C0 File Offset: 0x000349C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x000367C3 File Offset: 0x000349C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssShowNameRequest.Descriptor;
			}
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x000367CA File Offset: 0x000349CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssShowNameRequest()
		{
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x000367D2 File Offset: 0x000349D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssShowNameRequest(AbyssShowNameRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.showName_ = other.showName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00036803 File Offset: 0x00034A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssShowNameRequest Clone()
		{
			return new AbyssShowNameRequest(this);
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x0003680B File Offset: 0x00034A0B
		// (set) Token: 0x0600145B RID: 5211 RVA: 0x00036813 File Offset: 0x00034A13
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

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x0003681C File Offset: 0x00034A1C
		// (set) Token: 0x0600145D RID: 5213 RVA: 0x00036824 File Offset: 0x00034A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowName
		{
			get
			{
				return this.showName_;
			}
			set
			{
				this.showName_ = value;
			}
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x0003682D File Offset: 0x00034A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssShowNameRequest);
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x0003683B File Offset: 0x00034A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssShowNameRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.ShowName == other.ShowName && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x0003687C File Offset: 0x00034A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.ShowName)
			{
				num ^= this.ShowName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x000368D4 File Offset: 0x00034AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x000368E1 File Offset: 0x00034AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x000368EC File Offset: 0x00034AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.ShowName)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.ShowName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00036948 File Offset: 0x00034B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.ShowName)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00036994 File Offset: 0x00034B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssShowNameRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.ShowName)
			{
				this.ShowName = other.ShowName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x000369E4 File Offset: 0x00034BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x000369F0 File Offset: 0x00034BF0
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ShowName = input.ReadBool();
					}
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400204E RID: 8270
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400204F RID: 8271
		public const int ChallengeIdFieldNumber = 5;

		// Token: 0x04002050 RID: 8272
		private int challengeId_;

		// Token: 0x04002051 RID: 8273
		public const int ShowNameFieldNumber = 15;

		// Token: 0x04002052 RID: 8274
		private bool showName_;
	}
}
