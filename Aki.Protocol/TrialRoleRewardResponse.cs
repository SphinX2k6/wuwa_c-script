using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001468 RID: 5224
	[NetMessage(EMessageId.TrialRoleRewardResponse)]
	public sealed class TrialRoleRewardResponse : IMessage<TrialRoleRewardResponse>, IMessage, IEquatable<TrialRoleRewardResponse>, IDeepCloneable<TrialRoleRewardResponse>, IBufferMessage
	{
		// Token: 0x0601BA91 RID: 113297 RVA: 0x00400FC5 File Offset: 0x003FF1C5
		[NullableContext(1)]
		public static TrialRoleRewardResponse Create()
		{
			return new TrialRoleRewardResponse();
		}

		// Token: 0x17005D4A RID: 23882
		// (get) Token: 0x0601BA92 RID: 113298 RVA: 0x00400FCC File Offset: 0x003FF1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D4B RID: 23883
		// (get) Token: 0x0601BA93 RID: 113299 RVA: 0x00400FCF File Offset: 0x003FF1CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrialRoleRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601BA94 RID: 113300 RVA: 0x00400FD6 File Offset: 0x003FF1D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleRewardResponse()
		{
		}

		// Token: 0x0601BA95 RID: 113301 RVA: 0x00400FDE File Offset: 0x003FF1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleRewardResponse(TrialRoleRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BA96 RID: 113302 RVA: 0x00401003 File Offset: 0x003FF203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleRewardResponse Clone()
		{
			return new TrialRoleRewardResponse(this);
		}

		// Token: 0x17005D4C RID: 23884
		// (get) Token: 0x0601BA97 RID: 113303 RVA: 0x0040100B File Offset: 0x003FF20B
		// (set) Token: 0x0601BA98 RID: 113304 RVA: 0x00401013 File Offset: 0x003FF213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0601BA99 RID: 113305 RVA: 0x0040101C File Offset: 0x003FF21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrialRoleRewardResponse);
		}

		// Token: 0x0601BA9A RID: 113306 RVA: 0x0040102A File Offset: 0x003FF22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrialRoleRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BA9B RID: 113307 RVA: 0x00401058 File Offset: 0x003FF258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BA9C RID: 113308 RVA: 0x0040109D File Offset: 0x003FF29D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BA9D RID: 113309 RVA: 0x004010AA File Offset: 0x003FF2AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA9E RID: 113310 RVA: 0x004010B3 File Offset: 0x003FF2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BA9F RID: 113311 RVA: 0x004010E8 File Offset: 0x003FF2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BAA0 RID: 113312 RVA: 0x00401126 File Offset: 0x003FF326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrialRoleRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BAA1 RID: 113313 RVA: 0x00401157 File Offset: 0x003FF357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BAA2 RID: 113314 RVA: 0x00401160 File Offset: 0x003FF360
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009F6C RID: 40812
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F6D RID: 40813
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04009F6E RID: 40814
		private ErrorCode errorCode_;
	}
}
