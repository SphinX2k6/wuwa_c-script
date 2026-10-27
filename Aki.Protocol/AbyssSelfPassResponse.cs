using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000049 RID: 73
	[NetMessage(EMessageId.AbyssSelfPassResponse)]
	public sealed class AbyssSelfPassResponse : IMessage<AbyssSelfPassResponse>, IMessage, IEquatable<AbyssSelfPassResponse>, IDeepCloneable<AbyssSelfPassResponse>, IBufferMessage
	{
		// Token: 0x06001442 RID: 5186 RVA: 0x000365D9 File Offset: 0x000347D9
		[NullableContext(1)]
		public static AbyssSelfPassResponse Create()
		{
			return new AbyssSelfPassResponse();
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x000365E0 File Offset: 0x000347E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x000365E3 File Offset: 0x000347E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssSelfPassResponse.Descriptor;
			}
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x000365EA File Offset: 0x000347EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssSelfPassResponse()
		{
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x000365FD File Offset: 0x000347FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssSelfPassResponse(AbyssSelfPassResponse other) : this()
		{
			this.selfPassData_ = other.selfPassData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00036627 File Offset: 0x00034827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssSelfPassResponse Clone()
		{
			return new AbyssSelfPassResponse(this);
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x0003662F File Offset: 0x0003482F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssChallengeInfo> SelfPassData
		{
			get
			{
				return this.selfPassData_;
			}
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00036637 File Offset: 0x00034837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssSelfPassResponse);
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00036645 File Offset: 0x00034845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssSelfPassResponse other)
		{
			return other != null && (other == this || (this.selfPassData_.Equals(other.selfPassData_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00036678 File Offset: 0x00034878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.selfPassData_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x000366AC File Offset: 0x000348AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x000366B9 File Offset: 0x000348B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x000366C2 File Offset: 0x000348C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.selfPassData_.WriteTo(ref output, AbyssSelfPassResponse._repeated_selfPassData_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x000366EC File Offset: 0x000348EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.selfPassData_.CalculateSize(AbyssSelfPassResponse._repeated_selfPassData_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00036725 File Offset: 0x00034925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssSelfPassResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.selfPassData_.Add(other.selfPassData_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00036753 File Offset: 0x00034953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x0003675C File Offset: 0x0003495C
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.selfPassData_.AddEntriesFrom(ref input, AbyssSelfPassResponse._repeated_selfPassData_codec);
				}
			}
		}

		// Token: 0x0400204A RID: 8266
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400204B RID: 8267
		public const int SelfPassDataFieldNumber = 13;

		// Token: 0x0400204C RID: 8268
		private static readonly FieldCodec<AbyssChallengeInfo> _repeated_selfPassData_codec = FieldCodec.ForMessage<AbyssChallengeInfo>(106U, AbyssChallengeInfo.Parser);

		// Token: 0x0400204D RID: 8269
		private readonly RepeatedField<AbyssChallengeInfo> selfPassData_ = new RepeatedField<AbyssChallengeInfo>();
	}
}
