using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014DC RID: 5340
	[NetMessage(EMessageId.TrialRoleSkinRewardRequest)]
	public sealed class TrialRoleSkinRewardRequest : IMessage<TrialRoleSkinRewardRequest>, IMessage, IEquatable<TrialRoleSkinRewardRequest>, IDeepCloneable<TrialRoleSkinRewardRequest>, IBufferMessage
	{
		// Token: 0x0601C52E RID: 116014 RVA: 0x0041C470 File Offset: 0x0041A670
		[NullableContext(1)]
		public static TrialRoleSkinRewardRequest Create()
		{
			return new TrialRoleSkinRewardRequest();
		}

		// Token: 0x17005FE2 RID: 24546
		// (get) Token: 0x0601C52F RID: 116015 RVA: 0x0041C477 File Offset: 0x0041A677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FE3 RID: 24547
		// (get) Token: 0x0601C530 RID: 116016 RVA: 0x0041C47A File Offset: 0x0041A67A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrialRoleSkinRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601C531 RID: 116017 RVA: 0x0041C481 File Offset: 0x0041A681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleSkinRewardRequest()
		{
		}

		// Token: 0x0601C532 RID: 116018 RVA: 0x0041C489 File Offset: 0x0041A689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleSkinRewardRequest(TrialRoleSkinRewardRequest other) : this()
		{
			this.roleSkinTrialInfoId_ = other.roleSkinTrialInfoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C533 RID: 116019 RVA: 0x0041C4AE File Offset: 0x0041A6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleSkinRewardRequest Clone()
		{
			return new TrialRoleSkinRewardRequest(this);
		}

		// Token: 0x17005FE4 RID: 24548
		// (get) Token: 0x0601C534 RID: 116020 RVA: 0x0041C4B6 File Offset: 0x0041A6B6
		// (set) Token: 0x0601C535 RID: 116021 RVA: 0x0041C4BE File Offset: 0x0041A6BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleSkinTrialInfoId
		{
			get
			{
				return this.roleSkinTrialInfoId_;
			}
			set
			{
				this.roleSkinTrialInfoId_ = value;
			}
		}

		// Token: 0x0601C536 RID: 116022 RVA: 0x0041C4C7 File Offset: 0x0041A6C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrialRoleSkinRewardRequest);
		}

		// Token: 0x0601C537 RID: 116023 RVA: 0x0041C4D5 File Offset: 0x0041A6D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrialRoleSkinRewardRequest other)
		{
			return other != null && (other == this || (this.RoleSkinTrialInfoId == other.RoleSkinTrialInfoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C538 RID: 116024 RVA: 0x0041C504 File Offset: 0x0041A704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleSkinTrialInfoId != 0)
			{
				num ^= this.RoleSkinTrialInfoId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C539 RID: 116025 RVA: 0x0041C543 File Offset: 0x0041A743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C53A RID: 116026 RVA: 0x0041C550 File Offset: 0x0041A750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C53B RID: 116027 RVA: 0x0041C559 File Offset: 0x0041A759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleSkinTrialInfoId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleSkinTrialInfoId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C53C RID: 116028 RVA: 0x0041C58C File Offset: 0x0041A78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleSkinTrialInfoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleSkinTrialInfoId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C53D RID: 116029 RVA: 0x0041C5CA File Offset: 0x0041A7CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrialRoleSkinRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleSkinTrialInfoId != 0)
			{
				this.RoleSkinTrialInfoId = other.RoleSkinTrialInfoId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C53E RID: 116030 RVA: 0x0041C5FB File Offset: 0x0041A7FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C53F RID: 116031 RVA: 0x0041C604 File Offset: 0x0041A804
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleSkinTrialInfoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A3B6 RID: 41910
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3B7 RID: 41911
		public const int RoleSkinTrialInfoIdFieldNumber = 1;

		// Token: 0x0400A3B8 RID: 41912
		private int roleSkinTrialInfoId_;
	}
}
