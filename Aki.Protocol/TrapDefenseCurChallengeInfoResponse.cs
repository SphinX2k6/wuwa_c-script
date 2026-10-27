using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200141F RID: 5151
	[NetMessage(EMessageId.TrapDefenseCurChallengeInfoResponse)]
	public sealed class TrapDefenseCurChallengeInfoResponse : IMessage<TrapDefenseCurChallengeInfoResponse>, IMessage, IEquatable<TrapDefenseCurChallengeInfoResponse>, IDeepCloneable<TrapDefenseCurChallengeInfoResponse>, IBufferMessage
	{
		// Token: 0x0601B4D4 RID: 111828 RVA: 0x003F4C2E File Offset: 0x003F2E2E
		[NullableContext(1)]
		public static TrapDefenseCurChallengeInfoResponse Create()
		{
			return new TrapDefenseCurChallengeInfoResponse();
		}

		// Token: 0x17005C18 RID: 23576
		// (get) Token: 0x0601B4D5 RID: 111829 RVA: 0x003F4C35 File Offset: 0x003F2E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C19 RID: 23577
		// (get) Token: 0x0601B4D6 RID: 111830 RVA: 0x003F4C38 File Offset: 0x003F2E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseCurChallengeInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601B4D7 RID: 111831 RVA: 0x003F4C3F File Offset: 0x003F2E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCurChallengeInfoResponse()
		{
		}

		// Token: 0x0601B4D8 RID: 111832 RVA: 0x003F4C52 File Offset: 0x003F2E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCurChallengeInfoResponse(TrapDefenseCurChallengeInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.target_ = other.target_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B4D9 RID: 111833 RVA: 0x003F4C88 File Offset: 0x003F2E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCurChallengeInfoResponse Clone()
		{
			return new TrapDefenseCurChallengeInfoResponse(this);
		}

		// Token: 0x17005C1A RID: 23578
		// (get) Token: 0x0601B4DA RID: 111834 RVA: 0x003F4C90 File Offset: 0x003F2E90
		// (set) Token: 0x0601B4DB RID: 111835 RVA: 0x003F4C98 File Offset: 0x003F2E98
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

		// Token: 0x17005C1B RID: 23579
		// (get) Token: 0x0601B4DC RID: 111836 RVA: 0x003F4CA1 File Offset: 0x003F2EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Target
		{
			get
			{
				return this.target_;
			}
		}

		// Token: 0x0601B4DD RID: 111837 RVA: 0x003F4CA9 File Offset: 0x003F2EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseCurChallengeInfoResponse);
		}

		// Token: 0x0601B4DE RID: 111838 RVA: 0x003F4CB8 File Offset: 0x003F2EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseCurChallengeInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.target_.Equals(other.target_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B4DF RID: 111839 RVA: 0x003F4D08 File Offset: 0x003F2F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.target_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B4E0 RID: 111840 RVA: 0x003F4D5B File Offset: 0x003F2F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B4E1 RID: 111841 RVA: 0x003F4D68 File Offset: 0x003F2F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B4E2 RID: 111842 RVA: 0x003F4D74 File Offset: 0x003F2F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.target_.WriteTo(ref output, TrapDefenseCurChallengeInfoResponse._repeated_target_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B4E3 RID: 111843 RVA: 0x003F4DC4 File Offset: 0x003F2FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.target_.CalculateSize(TrapDefenseCurChallengeInfoResponse._repeated_target_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B4E4 RID: 111844 RVA: 0x003F4E18 File Offset: 0x003F3018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseCurChallengeInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.target_.Add(other.target_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B4E5 RID: 111845 RVA: 0x003F4E65 File Offset: 0x003F3065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B4E6 RID: 111846 RVA: 0x003F4E70 File Offset: 0x003F3070
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
				if (num != 24U && num != 26U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.target_.AddEntriesFrom(ref input, TrapDefenseCurChallengeInfoResponse._repeated_target_codec);
				}
			}
		}

		// Token: 0x04009DCD RID: 40397
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DCE RID: 40398
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04009DCF RID: 40399
		private ErrorCode errorCode_;

		// Token: 0x04009DD0 RID: 40400
		public const int TargetFieldNumber = 3;

		// Token: 0x04009DD1 RID: 40401
		private static readonly FieldCodec<int> _repeated_target_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04009DD2 RID: 40402
		private readonly RepeatedField<int> target_ = new RepeatedField<int>();
	}
}
