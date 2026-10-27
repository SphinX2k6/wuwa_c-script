using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000657 RID: 1623
	[NetMessage(EMessageId.FriendRecentlyTeamResponse)]
	public sealed class FriendRecentlyTeamResponse : IMessage<FriendRecentlyTeamResponse>, IMessage, IEquatable<FriendRecentlyTeamResponse>, IDeepCloneable<FriendRecentlyTeamResponse>, IBufferMessage
	{
		// Token: 0x0600951A RID: 38170 RVA: 0x00167F86 File Offset: 0x00166186
		[NullableContext(1)]
		public static FriendRecentlyTeamResponse Create()
		{
			return new FriendRecentlyTeamResponse();
		}

		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x0600951B RID: 38171 RVA: 0x00167F8D File Offset: 0x0016618D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x0600951C RID: 38172 RVA: 0x00167F90 File Offset: 0x00166190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendRecentlyTeamResponse.Descriptor;
			}
		}

		// Token: 0x0600951D RID: 38173 RVA: 0x00167F97 File Offset: 0x00166197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamResponse()
		{
		}

		// Token: 0x0600951E RID: 38174 RVA: 0x00167FAA File Offset: 0x001661AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamResponse(FriendRecentlyTeamResponse other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600951F RID: 38175 RVA: 0x00167FE0 File Offset: 0x001661E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamResponse Clone()
		{
			return new FriendRecentlyTeamResponse(this);
		}

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x06009520 RID: 38176 RVA: 0x00167FE8 File Offset: 0x001661E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecentlyTeamInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x06009521 RID: 38177 RVA: 0x00167FF0 File Offset: 0x001661F0
		// (set) Token: 0x06009522 RID: 38178 RVA: 0x00167FF8 File Offset: 0x001661F8
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

		// Token: 0x06009523 RID: 38179 RVA: 0x00168001 File Offset: 0x00166201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendRecentlyTeamResponse);
		}

		// Token: 0x06009524 RID: 38180 RVA: 0x00168010 File Offset: 0x00166210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendRecentlyTeamResponse other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009525 RID: 38181 RVA: 0x00168060 File Offset: 0x00166260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.infos_.GetHashCode();
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

		// Token: 0x06009526 RID: 38182 RVA: 0x001680B3 File Offset: 0x001662B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009527 RID: 38183 RVA: 0x001680C0 File Offset: 0x001662C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009528 RID: 38184 RVA: 0x001680CC File Offset: 0x001662CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.infos_.WriteTo(ref output, FriendRecentlyTeamResponse._repeated_infos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009529 RID: 38185 RVA: 0x0016811C File Offset: 0x0016631C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.infos_.CalculateSize(FriendRecentlyTeamResponse._repeated_infos_codec);
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

		// Token: 0x0600952A RID: 38186 RVA: 0x00168170 File Offset: 0x00166370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendRecentlyTeamResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.infos_.Add(other.infos_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600952B RID: 38187 RVA: 0x001681BD File Offset: 0x001663BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600952C RID: 38188 RVA: 0x001681C8 File Offset: 0x001663C8
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
				if (num != 42U)
				{
					if (num != 80U)
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
					this.infos_.AddEntriesFrom(ref input, FriendRecentlyTeamResponse._repeated_infos_codec);
				}
			}
		}

		// Token: 0x04004749 RID: 18249
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400474A RID: 18250
		public const int InfosFieldNumber = 5;

		// Token: 0x0400474B RID: 18251
		private static readonly FieldCodec<RecentlyTeamInfo> _repeated_infos_codec = FieldCodec.ForMessage<RecentlyTeamInfo>(42U, RecentlyTeamInfo.Parser);

		// Token: 0x0400474C RID: 18252
		private readonly RepeatedField<RecentlyTeamInfo> infos_ = new RepeatedField<RecentlyTeamInfo>();

		// Token: 0x0400474D RID: 18253
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400474E RID: 18254
		private ErrorCode errorCode_;
	}
}
