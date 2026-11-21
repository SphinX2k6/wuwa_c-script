using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200100A RID: 4106
	[NetMessage(EMessageId.RogueTowerTrialGiveUpTempArchiveResponse)]
	public sealed class RogueTowerTrialGiveUpTempArchiveResponse : IMessage<RogueTowerTrialGiveUpTempArchiveResponse>, IMessage, IEquatable<RogueTowerTrialGiveUpTempArchiveResponse>, IDeepCloneable<RogueTowerTrialGiveUpTempArchiveResponse>, IBufferMessage
	{
		// Token: 0x06015FBD RID: 90045 RVA: 0x00332BAE File Offset: 0x00330DAE
		[NullableContext(1)]
		public static RogueTowerTrialGiveUpTempArchiveResponse Create()
		{
			return new RogueTowerTrialGiveUpTempArchiveResponse();
		}

		// Token: 0x17004984 RID: 18820
		// (get) Token: 0x06015FBE RID: 90046 RVA: 0x00332BB5 File Offset: 0x00330DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004985 RID: 18821
		// (get) Token: 0x06015FBF RID: 90047 RVA: 0x00332BB8 File Offset: 0x00330DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialGiveUpTempArchiveResponse.Descriptor;
			}
		}

		// Token: 0x06015FC0 RID: 90048 RVA: 0x00332BBF File Offset: 0x00330DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialGiveUpTempArchiveResponse()
		{
		}

		// Token: 0x06015FC1 RID: 90049 RVA: 0x00332BC7 File Offset: 0x00330DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialGiveUpTempArchiveResponse(RogueTowerTrialGiveUpTempArchiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015FC2 RID: 90050 RVA: 0x00332BEC File Offset: 0x00330DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialGiveUpTempArchiveResponse Clone()
		{
			return new RogueTowerTrialGiveUpTempArchiveResponse(this);
		}

		// Token: 0x17004986 RID: 18822
		// (get) Token: 0x06015FC3 RID: 90051 RVA: 0x00332BF4 File Offset: 0x00330DF4
		// (set) Token: 0x06015FC4 RID: 90052 RVA: 0x00332BFC File Offset: 0x00330DFC
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

		// Token: 0x06015FC5 RID: 90053 RVA: 0x00332C05 File Offset: 0x00330E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialGiveUpTempArchiveResponse);
		}

		// Token: 0x06015FC6 RID: 90054 RVA: 0x00332C13 File Offset: 0x00330E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialGiveUpTempArchiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015FC7 RID: 90055 RVA: 0x00332C44 File Offset: 0x00330E44
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

		// Token: 0x06015FC8 RID: 90056 RVA: 0x00332C89 File Offset: 0x00330E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015FC9 RID: 90057 RVA: 0x00332C96 File Offset: 0x00330E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015FCA RID: 90058 RVA: 0x00332C9F File Offset: 0x00330E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015FCB RID: 90059 RVA: 0x00332CD0 File Offset: 0x00330ED0
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

		// Token: 0x06015FCC RID: 90060 RVA: 0x00332D0E File Offset: 0x00330F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialGiveUpTempArchiveResponse other)
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

		// Token: 0x06015FCD RID: 90061 RVA: 0x00332D3F File Offset: 0x00330F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015FCE RID: 90062 RVA: 0x00332D48 File Offset: 0x00330F48
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008453 RID: 33875
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008454 RID: 33876
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04008455 RID: 33877
		private ErrorCode errorCode_;
	}
}
