using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200102B RID: 4139
	[NetMessage(EMessageId.RogueWeeklyArtifactInfoResponse)]
	public sealed class RogueWeeklyArtifactInfoResponse : IMessage<RogueWeeklyArtifactInfoResponse>, IMessage, IEquatable<RogueWeeklyArtifactInfoResponse>, IDeepCloneable<RogueWeeklyArtifactInfoResponse>, IBufferMessage
	{
		// Token: 0x060161EB RID: 90603 RVA: 0x00336AF2 File Offset: 0x00334CF2
		[NullableContext(1)]
		public static RogueWeeklyArtifactInfoResponse Create()
		{
			return new RogueWeeklyArtifactInfoResponse();
		}

		// Token: 0x170049ED RID: 18925
		// (get) Token: 0x060161EC RID: 90604 RVA: 0x00336AF9 File Offset: 0x00334CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049EE RID: 18926
		// (get) Token: 0x060161ED RID: 90605 RVA: 0x00336AFC File Offset: 0x00334CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyArtifactInfoResponse.Descriptor;
			}
		}

		// Token: 0x060161EE RID: 90606 RVA: 0x00336B03 File Offset: 0x00334D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactInfoResponse()
		{
		}

		// Token: 0x060161EF RID: 90607 RVA: 0x00336B16 File Offset: 0x00334D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactInfoResponse(RogueWeeklyArtifactInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rogueWeeklyEntrys_ = other.rogueWeeklyEntrys_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060161F0 RID: 90608 RVA: 0x00336B4C File Offset: 0x00334D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactInfoResponse Clone()
		{
			return new RogueWeeklyArtifactInfoResponse(this);
		}

		// Token: 0x170049EF RID: 18927
		// (get) Token: 0x060161F1 RID: 90609 RVA: 0x00336B54 File Offset: 0x00334D54
		// (set) Token: 0x060161F2 RID: 90610 RVA: 0x00336B5C File Offset: 0x00334D5C
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

		// Token: 0x170049F0 RID: 18928
		// (get) Token: 0x060161F3 RID: 90611 RVA: 0x00336B65 File Offset: 0x00334D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueWeeklyEntry> RogueWeeklyEntrys
		{
			get
			{
				return this.rogueWeeklyEntrys_;
			}
		}

		// Token: 0x060161F4 RID: 90612 RVA: 0x00336B6D File Offset: 0x00334D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyArtifactInfoResponse);
		}

		// Token: 0x060161F5 RID: 90613 RVA: 0x00336B7C File Offset: 0x00334D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyArtifactInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.rogueWeeklyEntrys_.Equals(other.rogueWeeklyEntrys_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060161F6 RID: 90614 RVA: 0x00336BCC File Offset: 0x00334DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.rogueWeeklyEntrys_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060161F7 RID: 90615 RVA: 0x00336C1F File Offset: 0x00334E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060161F8 RID: 90616 RVA: 0x00336C2C File Offset: 0x00334E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060161F9 RID: 90617 RVA: 0x00336C38 File Offset: 0x00334E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.rogueWeeklyEntrys_.WriteTo(ref output, RogueWeeklyArtifactInfoResponse._repeated_rogueWeeklyEntrys_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060161FA RID: 90618 RVA: 0x00336C88 File Offset: 0x00334E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.rogueWeeklyEntrys_.CalculateSize(RogueWeeklyArtifactInfoResponse._repeated_rogueWeeklyEntrys_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060161FB RID: 90619 RVA: 0x00336CDC File Offset: 0x00334EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyArtifactInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.rogueWeeklyEntrys_.Add(other.rogueWeeklyEntrys_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060161FC RID: 90620 RVA: 0x00336D29 File Offset: 0x00334F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060161FD RID: 90621 RVA: 0x00336D34 File Offset: 0x00334F34
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
				if (num != 16U)
				{
					if (num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.rogueWeeklyEntrys_.AddEntriesFrom(ref input, RogueWeeklyArtifactInfoResponse._repeated_rogueWeeklyEntrys_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008474 RID: 33908
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008475 RID: 33909
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04008476 RID: 33910
		private ErrorCode errorCode_;

		// Token: 0x04008477 RID: 33911
		public const int RogueWeeklyEntrysFieldNumber = 3;

		// Token: 0x04008478 RID: 33912
		private static readonly FieldCodec<RogueWeeklyEntry> _repeated_rogueWeeklyEntrys_codec = FieldCodec.ForMessage<RogueWeeklyEntry>(26U, RogueWeeklyEntry.Parser);

		// Token: 0x04008479 RID: 33913
		private readonly RepeatedField<RogueWeeklyEntry> rogueWeeklyEntrys_ = new RepeatedField<RogueWeeklyEntry>();
	}
}
