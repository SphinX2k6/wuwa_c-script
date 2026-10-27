using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC9 RID: 4041
	[NetMessage(EMessageId.RoguelikeWriteCatBossRewardResponse)]
	public sealed class RoguelikeWriteCatBossRewardResponse : IMessage<RoguelikeWriteCatBossRewardResponse>, IMessage, IEquatable<RoguelikeWriteCatBossRewardResponse>, IDeepCloneable<RoguelikeWriteCatBossRewardResponse>, IBufferMessage
	{
		// Token: 0x060159A8 RID: 88488 RVA: 0x00322CE0 File Offset: 0x00320EE0
		[NullableContext(1)]
		public static RoguelikeWriteCatBossRewardResponse Create()
		{
			return new RoguelikeWriteCatBossRewardResponse();
		}

		// Token: 0x1700480C RID: 18444
		// (get) Token: 0x060159A9 RID: 88489 RVA: 0x00322CE7 File Offset: 0x00320EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700480D RID: 18445
		// (get) Token: 0x060159AA RID: 88490 RVA: 0x00322CEA File Offset: 0x00320EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeWriteCatBossRewardResponse.Descriptor;
			}
		}

		// Token: 0x060159AB RID: 88491 RVA: 0x00322CF1 File Offset: 0x00320EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatBossRewardResponse()
		{
		}

		// Token: 0x060159AC RID: 88492 RVA: 0x00322CF9 File Offset: 0x00320EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatBossRewardResponse(RoguelikeWriteCatBossRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060159AD RID: 88493 RVA: 0x00322D1E File Offset: 0x00320F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatBossRewardResponse Clone()
		{
			return new RoguelikeWriteCatBossRewardResponse(this);
		}

		// Token: 0x1700480E RID: 18446
		// (get) Token: 0x060159AE RID: 88494 RVA: 0x00322D26 File Offset: 0x00320F26
		// (set) Token: 0x060159AF RID: 88495 RVA: 0x00322D2E File Offset: 0x00320F2E
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

		// Token: 0x060159B0 RID: 88496 RVA: 0x00322D37 File Offset: 0x00320F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeWriteCatBossRewardResponse);
		}

		// Token: 0x060159B1 RID: 88497 RVA: 0x00322D45 File Offset: 0x00320F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeWriteCatBossRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060159B2 RID: 88498 RVA: 0x00322D74 File Offset: 0x00320F74
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

		// Token: 0x060159B3 RID: 88499 RVA: 0x00322DB9 File Offset: 0x00320FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060159B4 RID: 88500 RVA: 0x00322DC6 File Offset: 0x00320FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060159B5 RID: 88501 RVA: 0x00322DCF File Offset: 0x00320FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060159B6 RID: 88502 RVA: 0x00322E04 File Offset: 0x00321004
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

		// Token: 0x060159B7 RID: 88503 RVA: 0x00322E42 File Offset: 0x00321042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeWriteCatBossRewardResponse other)
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

		// Token: 0x060159B8 RID: 88504 RVA: 0x00322E73 File Offset: 0x00321073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060159B9 RID: 88505 RVA: 0x00322E7C File Offset: 0x0032107C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040081C7 RID: 33223
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081C8 RID: 33224
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040081C9 RID: 33225
		private ErrorCode errorCode_;
	}
}
