using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001037 RID: 4151
	[NetMessage(EMessageId.RogueWeeklyRewardResponse)]
	public sealed class RogueWeeklyRewardResponse : IMessage<RogueWeeklyRewardResponse>, IMessage, IEquatable<RogueWeeklyRewardResponse>, IDeepCloneable<RogueWeeklyRewardResponse>, IBufferMessage
	{
		// Token: 0x06016354 RID: 90964 RVA: 0x0033A6CC File Offset: 0x003388CC
		[NullableContext(1)]
		public static RogueWeeklyRewardResponse Create()
		{
			return new RogueWeeklyRewardResponse();
		}

		// Token: 0x17004A43 RID: 19011
		// (get) Token: 0x06016355 RID: 90965 RVA: 0x0033A6D3 File Offset: 0x003388D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A44 RID: 19012
		// (get) Token: 0x06016356 RID: 90966 RVA: 0x0033A6D6 File Offset: 0x003388D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyRewardResponse.Descriptor;
			}
		}

		// Token: 0x06016357 RID: 90967 RVA: 0x0033A6DD File Offset: 0x003388DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyRewardResponse()
		{
		}

		// Token: 0x06016358 RID: 90968 RVA: 0x0033A6E5 File Offset: 0x003388E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyRewardResponse(RogueWeeklyRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016359 RID: 90969 RVA: 0x0033A70A File Offset: 0x0033890A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyRewardResponse Clone()
		{
			return new RogueWeeklyRewardResponse(this);
		}

		// Token: 0x17004A45 RID: 19013
		// (get) Token: 0x0601635A RID: 90970 RVA: 0x0033A712 File Offset: 0x00338912
		// (set) Token: 0x0601635B RID: 90971 RVA: 0x0033A71A File Offset: 0x0033891A
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

		// Token: 0x0601635C RID: 90972 RVA: 0x0033A723 File Offset: 0x00338923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyRewardResponse);
		}

		// Token: 0x0601635D RID: 90973 RVA: 0x0033A731 File Offset: 0x00338931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601635E RID: 90974 RVA: 0x0033A760 File Offset: 0x00338960
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

		// Token: 0x0601635F RID: 90975 RVA: 0x0033A7A5 File Offset: 0x003389A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016360 RID: 90976 RVA: 0x0033A7B2 File Offset: 0x003389B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016361 RID: 90977 RVA: 0x0033A7BB File Offset: 0x003389BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016362 RID: 90978 RVA: 0x0033A7F0 File Offset: 0x003389F0
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

		// Token: 0x06016363 RID: 90979 RVA: 0x0033A82E File Offset: 0x00338A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyRewardResponse other)
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

		// Token: 0x06016364 RID: 90980 RVA: 0x0033A85F File Offset: 0x00338A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016365 RID: 90981 RVA: 0x0033A868 File Offset: 0x00338A68
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400854E RID: 34126
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400854F RID: 34127
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04008550 RID: 34128
		private ErrorCode errorCode_;
	}
}
