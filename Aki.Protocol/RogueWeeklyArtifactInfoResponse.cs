using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200101B RID: 4123
	[NetMessage(EMessageId.RogueWeeklyArtifactInfoResponse)]
	public sealed class RogueWeeklyArtifactInfoResponse : IMessage<RogueWeeklyArtifactInfoResponse>, IMessage, IEquatable<RogueWeeklyArtifactInfoResponse>, IDeepCloneable<RogueWeeklyArtifactInfoResponse>, IBufferMessage
	{
		// Token: 0x06016106 RID: 90374 RVA: 0x00335432 File Offset: 0x00333632
		[NullableContext(1)]
		public static RogueWeeklyArtifactInfoResponse Create()
		{
			return new RogueWeeklyArtifactInfoResponse();
		}

		// Token: 0x170049C3 RID: 18883
		// (get) Token: 0x06016107 RID: 90375 RVA: 0x00335439 File Offset: 0x00333639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049C4 RID: 18884
		// (get) Token: 0x06016108 RID: 90376 RVA: 0x0033543C File Offset: 0x0033363C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyArtifactInfoResponse.Descriptor;
			}
		}

		// Token: 0x06016109 RID: 90377 RVA: 0x00335443 File Offset: 0x00333643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactInfoResponse()
		{
		}

		// Token: 0x0601610A RID: 90378 RVA: 0x00335456 File Offset: 0x00333656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactInfoResponse(RogueWeeklyArtifactInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rogueWeeklyEntrys_ = other.rogueWeeklyEntrys_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601610B RID: 90379 RVA: 0x0033548C File Offset: 0x0033368C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactInfoResponse Clone()
		{
			return new RogueWeeklyArtifactInfoResponse(this);
		}

		// Token: 0x170049C5 RID: 18885
		// (get) Token: 0x0601610C RID: 90380 RVA: 0x00335494 File Offset: 0x00333694
		// (set) Token: 0x0601610D RID: 90381 RVA: 0x0033549C File Offset: 0x0033369C
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

		// Token: 0x170049C6 RID: 18886
		// (get) Token: 0x0601610E RID: 90382 RVA: 0x003354A5 File Offset: 0x003336A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueWeeklyEntry> RogueWeeklyEntrys
		{
			get
			{
				return this.rogueWeeklyEntrys_;
			}
		}

		// Token: 0x0601610F RID: 90383 RVA: 0x003354AD File Offset: 0x003336AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyArtifactInfoResponse);
		}

		// Token: 0x06016110 RID: 90384 RVA: 0x003354BC File Offset: 0x003336BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyArtifactInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.rogueWeeklyEntrys_.Equals(other.rogueWeeklyEntrys_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016111 RID: 90385 RVA: 0x0033550C File Offset: 0x0033370C
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

		// Token: 0x06016112 RID: 90386 RVA: 0x0033555F File Offset: 0x0033375F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016113 RID: 90387 RVA: 0x0033556C File Offset: 0x0033376C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016114 RID: 90388 RVA: 0x00335578 File Offset: 0x00333778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueWeeklyEntrys_.WriteTo(ref output, RogueWeeklyArtifactInfoResponse._repeated_rogueWeeklyEntrys_codec);
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

		// Token: 0x06016115 RID: 90389 RVA: 0x003355C8 File Offset: 0x003337C8
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

		// Token: 0x06016116 RID: 90390 RVA: 0x0033561C File Offset: 0x0033381C
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

		// Token: 0x06016117 RID: 90391 RVA: 0x00335669 File Offset: 0x00333869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016118 RID: 90392 RVA: 0x00335674 File Offset: 0x00333874
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
				if (num != 74U)
				{
					if (num != 112U)
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
					this.rogueWeeklyEntrys_.AddEntriesFrom(ref input, RogueWeeklyArtifactInfoResponse._repeated_rogueWeeklyEntrys_codec);
				}
			}
		}

		// Token: 0x0400849E RID: 33950
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400849F RID: 33951
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040084A0 RID: 33952
		private ErrorCode errorCode_;

		// Token: 0x040084A1 RID: 33953
		public const int RogueWeeklyEntrysFieldNumber = 9;

		// Token: 0x040084A2 RID: 33954
		private static readonly FieldCodec<RogueWeeklyEntry> _repeated_rogueWeeklyEntrys_codec = FieldCodec.ForMessage<RogueWeeklyEntry>(74U, RogueWeeklyEntry.Parser);

		// Token: 0x040084A3 RID: 33955
		private readonly RepeatedField<RogueWeeklyEntry> rogueWeeklyEntrys_ = new RepeatedField<RogueWeeklyEntry>();
	}
}
