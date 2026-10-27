using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DCE RID: 3534
	[NetMessage(EMessageId.PreheatSignRewardRequest)]
	public sealed class PreheatSignRewardRequest : IMessage<PreheatSignRewardRequest>, IMessage, IEquatable<PreheatSignRewardRequest>, IDeepCloneable<PreheatSignRewardRequest>, IBufferMessage
	{
		// Token: 0x06013067 RID: 77927 RVA: 0x002C5E16 File Offset: 0x002C4016
		[NullableContext(1)]
		public static PreheatSignRewardRequest Create()
		{
			return new PreheatSignRewardRequest();
		}

		// Token: 0x17003F21 RID: 16161
		// (get) Token: 0x06013068 RID: 77928 RVA: 0x002C5E1D File Offset: 0x002C401D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F22 RID: 16162
		// (get) Token: 0x06013069 RID: 77929 RVA: 0x002C5E20 File Offset: 0x002C4020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreheatSignRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601306A RID: 77930 RVA: 0x002C5E27 File Offset: 0x002C4027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignRewardRequest()
		{
		}

		// Token: 0x0601306B RID: 77931 RVA: 0x002C5E2F File Offset: 0x002C402F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignRewardRequest(PreheatSignRewardRequest other) : this()
		{
			this.preheatNodeId_ = other.preheatNodeId_;
			this.answerStatus_ = other.answerStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601306C RID: 77932 RVA: 0x002C5E60 File Offset: 0x002C4060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignRewardRequest Clone()
		{
			return new PreheatSignRewardRequest(this);
		}

		// Token: 0x17003F23 RID: 16163
		// (get) Token: 0x0601306D RID: 77933 RVA: 0x002C5E68 File Offset: 0x002C4068
		// (set) Token: 0x0601306E RID: 77934 RVA: 0x002C5E70 File Offset: 0x002C4070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PreheatNodeId
		{
			get
			{
				return this.preheatNodeId_;
			}
			set
			{
				this.preheatNodeId_ = value;
			}
		}

		// Token: 0x17003F24 RID: 16164
		// (get) Token: 0x0601306F RID: 77935 RVA: 0x002C5E79 File Offset: 0x002C4079
		// (set) Token: 0x06013070 RID: 77936 RVA: 0x002C5E81 File Offset: 0x002C4081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AnswerStatus
		{
			get
			{
				return this.answerStatus_;
			}
			set
			{
				this.answerStatus_ = value;
			}
		}

		// Token: 0x06013071 RID: 77937 RVA: 0x002C5E8A File Offset: 0x002C408A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreheatSignRewardRequest);
		}

		// Token: 0x06013072 RID: 77938 RVA: 0x002C5E98 File Offset: 0x002C4098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreheatSignRewardRequest other)
		{
			return other != null && (other == this || (this.PreheatNodeId == other.PreheatNodeId && this.AnswerStatus == other.AnswerStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013073 RID: 77939 RVA: 0x002C5ED8 File Offset: 0x002C40D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PreheatNodeId != 0)
			{
				num ^= this.PreheatNodeId.GetHashCode();
			}
			if (this.AnswerStatus)
			{
				num ^= this.AnswerStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013074 RID: 77940 RVA: 0x002C5F30 File Offset: 0x002C4130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013075 RID: 77941 RVA: 0x002C5F3D File Offset: 0x002C413D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013076 RID: 77942 RVA: 0x002C5F48 File Offset: 0x002C4148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PreheatNodeId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PreheatNodeId);
			}
			if (this.AnswerStatus)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.AnswerStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013077 RID: 77943 RVA: 0x002C5FA4 File Offset: 0x002C41A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PreheatNodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PreheatNodeId);
			}
			if (this.AnswerStatus)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013078 RID: 77944 RVA: 0x002C5FF0 File Offset: 0x002C41F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PreheatSignRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PreheatNodeId != 0)
			{
				this.PreheatNodeId = other.PreheatNodeId;
			}
			if (other.AnswerStatus)
			{
				this.AnswerStatus = other.AnswerStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013079 RID: 77945 RVA: 0x002C6040 File Offset: 0x002C4240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601307A RID: 77946 RVA: 0x002C604C File Offset: 0x002C424C
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AnswerStatus = input.ReadBool();
					}
				}
				else
				{
					this.PreheatNodeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007578 RID: 30072
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007579 RID: 30073
		public const int PreheatNodeIdFieldNumber = 7;

		// Token: 0x0400757A RID: 30074
		private int preheatNodeId_;

		// Token: 0x0400757B RID: 30075
		public const int AnswerStatusFieldNumber = 14;

		// Token: 0x0400757C RID: 30076
		private bool answerStatus_;
	}
}
