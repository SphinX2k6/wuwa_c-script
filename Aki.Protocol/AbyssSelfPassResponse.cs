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
		// Token: 0x0600146D RID: 5229 RVA: 0x00036B91 File Offset: 0x00034D91
		[NullableContext(1)]
		public static AbyssSelfPassResponse Create()
		{
			return new AbyssSelfPassResponse();
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x00036B98 File Offset: 0x00034D98
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
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x00036B9B File Offset: 0x00034D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssSelfPassResponse.Descriptor;
			}
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00036BA2 File Offset: 0x00034DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssSelfPassResponse()
		{
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00036BB5 File Offset: 0x00034DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssSelfPassResponse(AbyssSelfPassResponse other) : this()
		{
			this.selfPassData_ = other.selfPassData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x00036BDF File Offset: 0x00034DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssSelfPassResponse Clone()
		{
			return new AbyssSelfPassResponse(this);
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x00036BE7 File Offset: 0x00034DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssChallengeInfo> SelfPassData
		{
			get
			{
				return this.selfPassData_;
			}
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00036BEF File Offset: 0x00034DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssSelfPassResponse);
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00036BFD File Offset: 0x00034DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssSelfPassResponse other)
		{
			return other != null && (other == this || (this.selfPassData_.Equals(other.selfPassData_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x00036C30 File Offset: 0x00034E30
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

		// Token: 0x06001477 RID: 5239 RVA: 0x00036C64 File Offset: 0x00034E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00036C71 File Offset: 0x00034E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00036C7A File Offset: 0x00034E7A
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

		// Token: 0x0600147A RID: 5242 RVA: 0x00036CA4 File Offset: 0x00034EA4
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

		// Token: 0x0600147B RID: 5243 RVA: 0x00036CDD File Offset: 0x00034EDD
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

		// Token: 0x0600147C RID: 5244 RVA: 0x00036D0B File Offset: 0x00034F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00036D14 File Offset: 0x00034F14
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.selfPassData_.AddEntriesFrom(ref input, AbyssSelfPassResponse._repeated_selfPassData_codec);
				}
			}
		}

		// Token: 0x040020A0 RID: 8352
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020A1 RID: 8353
		public const int SelfPassDataFieldNumber = 2;

		// Token: 0x040020A2 RID: 8354
		private static readonly FieldCodec<AbyssChallengeInfo> _repeated_selfPassData_codec = FieldCodec.ForMessage<AbyssChallengeInfo>(18U, AbyssChallengeInfo.Parser);

		// Token: 0x040020A3 RID: 8355
		private readonly RepeatedField<AbyssChallengeInfo> selfPassData_ = new RepeatedField<AbyssChallengeInfo>();
	}
}
