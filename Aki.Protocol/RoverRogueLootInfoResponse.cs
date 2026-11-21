using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200114C RID: 4428
	[NetMessage(EMessageId.RoverRogueLootInfoResponse)]
	public sealed class RoverRogueLootInfoResponse : IMessage<RoverRogueLootInfoResponse>, IMessage, IEquatable<RoverRogueLootInfoResponse>, IDeepCloneable<RoverRogueLootInfoResponse>, IBufferMessage
	{
		// Token: 0x06017A8D RID: 96909 RVA: 0x003718F1 File Offset: 0x0036FAF1
		[NullableContext(1)]
		public static RoverRogueLootInfoResponse Create()
		{
			return new RoverRogueLootInfoResponse();
		}

		// Token: 0x17004F97 RID: 20375
		// (get) Token: 0x06017A8E RID: 96910 RVA: 0x003718F8 File Offset: 0x0036FAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F98 RID: 20376
		// (get) Token: 0x06017A8F RID: 96911 RVA: 0x003718FB File Offset: 0x0036FAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueLootInfoResponse.Descriptor;
			}
		}

		// Token: 0x06017A90 RID: 96912 RVA: 0x00371902 File Offset: 0x0036FB02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfoResponse()
		{
		}

		// Token: 0x06017A91 RID: 96913 RVA: 0x00371915 File Offset: 0x0036FB15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfoResponse(RoverRogueLootInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.loots_ = other.loots_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017A92 RID: 96914 RVA: 0x0037194B File Offset: 0x0036FB4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueLootInfoResponse Clone()
		{
			return new RoverRogueLootInfoResponse(this);
		}

		// Token: 0x17004F99 RID: 20377
		// (get) Token: 0x06017A93 RID: 96915 RVA: 0x00371953 File Offset: 0x0036FB53
		// (set) Token: 0x06017A94 RID: 96916 RVA: 0x0037195B File Offset: 0x0036FB5B
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

		// Token: 0x17004F9A RID: 20378
		// (get) Token: 0x06017A95 RID: 96917 RVA: 0x00371964 File Offset: 0x0036FB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueGainEntry> Loots
		{
			get
			{
				return this.loots_;
			}
		}

		// Token: 0x06017A96 RID: 96918 RVA: 0x0037196C File Offset: 0x0036FB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueLootInfoResponse);
		}

		// Token: 0x06017A97 RID: 96919 RVA: 0x0037197C File Offset: 0x0036FB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueLootInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.loots_.Equals(other.loots_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017A98 RID: 96920 RVA: 0x003719CC File Offset: 0x0036FBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.loots_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017A99 RID: 96921 RVA: 0x00371A1F File Offset: 0x0036FC1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017A9A RID: 96922 RVA: 0x00371A2C File Offset: 0x0036FC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017A9B RID: 96923 RVA: 0x00371A38 File Offset: 0x0036FC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.loots_.WriteTo(ref output, RoverRogueLootInfoResponse._repeated_loots_codec);
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

		// Token: 0x06017A9C RID: 96924 RVA: 0x00371A88 File Offset: 0x0036FC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.loots_.CalculateSize(RoverRogueLootInfoResponse._repeated_loots_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017A9D RID: 96925 RVA: 0x00371ADC File Offset: 0x0036FCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueLootInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.loots_.Add(other.loots_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017A9E RID: 96926 RVA: 0x00371B29 File Offset: 0x0036FD29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017A9F RID: 96927 RVA: 0x00371B34 File Offset: 0x0036FD34
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
				if (num != 18U)
				{
					if (num != 56U)
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
					this.loots_.AddEntriesFrom(ref input, RoverRogueLootInfoResponse._repeated_loots_codec);
				}
			}
		}

		// Token: 0x04008D34 RID: 36148
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D35 RID: 36149
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04008D36 RID: 36150
		private ErrorCode errorCode_;

		// Token: 0x04008D37 RID: 36151
		public const int LootsFieldNumber = 2;

		// Token: 0x04008D38 RID: 36152
		private static readonly FieldCodec<RoverRogueGainEntry> _repeated_loots_codec = FieldCodec.ForMessage<RoverRogueGainEntry>(18U, RoverRogueGainEntry.Parser);

		// Token: 0x04008D39 RID: 36153
		private readonly RepeatedField<RoverRogueGainEntry> loots_ = new RepeatedField<RoverRogueGainEntry>();
	}
}
