using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD8 RID: 3288
	[NetMessage(EMessageId.PhantomMusicInfoResponse)]
	public sealed class PhantomMusicInfoResponse : IMessage<PhantomMusicInfoResponse>, IMessage, IEquatable<PhantomMusicInfoResponse>, IDeepCloneable<PhantomMusicInfoResponse>, IBufferMessage
	{
		// Token: 0x06011CFD RID: 72957 RVA: 0x0029B9AE File Offset: 0x00299BAE
		[NullableContext(1)]
		public static PhantomMusicInfoResponse Create()
		{
			return new PhantomMusicInfoResponse();
		}

		// Token: 0x17003B06 RID: 15110
		// (get) Token: 0x06011CFE RID: 72958 RVA: 0x0029B9B5 File Offset: 0x00299BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B07 RID: 15111
		// (get) Token: 0x06011CFF RID: 72959 RVA: 0x0029B9B8 File Offset: 0x00299BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicInfoResponse.Descriptor;
			}
		}

		// Token: 0x06011D00 RID: 72960 RVA: 0x0029B9BF File Offset: 0x00299BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicInfoResponse()
		{
		}

		// Token: 0x06011D01 RID: 72961 RVA: 0x0029B9E0 File Offset: 0x00299BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicInfoResponse(PhantomMusicInfoResponse other) : this()
		{
			this.curMusicId_ = other.curMusicId_;
			this.errorCode_ = other.errorCode_;
			this.albumTimeInfos_ = other.albumTimeInfos_.Clone();
			this.collectMusicIds_ = other.collectMusicIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011D02 RID: 72962 RVA: 0x0029BA3E File Offset: 0x00299C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicInfoResponse Clone()
		{
			return new PhantomMusicInfoResponse(this);
		}

		// Token: 0x17003B08 RID: 15112
		// (get) Token: 0x06011D03 RID: 72963 RVA: 0x0029BA46 File Offset: 0x00299C46
		// (set) Token: 0x06011D04 RID: 72964 RVA: 0x0029BA4E File Offset: 0x00299C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurMusicId
		{
			get
			{
				return this.curMusicId_;
			}
			set
			{
				this.curMusicId_ = value;
			}
		}

		// Token: 0x17003B09 RID: 15113
		// (get) Token: 0x06011D05 RID: 72965 RVA: 0x0029BA57 File Offset: 0x00299C57
		// (set) Token: 0x06011D06 RID: 72966 RVA: 0x0029BA5F File Offset: 0x00299C5F
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

		// Token: 0x17003B0A RID: 15114
		// (get) Token: 0x06011D07 RID: 72967 RVA: 0x0029BA68 File Offset: 0x00299C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhonographAlbumTimeInfo> AlbumTimeInfos
		{
			get
			{
				return this.albumTimeInfos_;
			}
		}

		// Token: 0x17003B0B RID: 15115
		// (get) Token: 0x06011D08 RID: 72968 RVA: 0x0029BA70 File Offset: 0x00299C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CollectMusicIds
		{
			get
			{
				return this.collectMusicIds_;
			}
		}

		// Token: 0x06011D09 RID: 72969 RVA: 0x0029BA78 File Offset: 0x00299C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicInfoResponse);
		}

		// Token: 0x06011D0A RID: 72970 RVA: 0x0029BA88 File Offset: 0x00299C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicInfoResponse other)
		{
			return other != null && (other == this || (this.CurMusicId == other.CurMusicId && this.ErrorCode == other.ErrorCode && this.albumTimeInfos_.Equals(other.albumTimeInfos_) && this.collectMusicIds_.Equals(other.collectMusicIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011D0B RID: 72971 RVA: 0x0029BAFC File Offset: 0x00299CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurMusicId != 0)
			{
				num ^= this.CurMusicId.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.albumTimeInfos_.GetHashCode();
			num ^= this.collectMusicIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011D0C RID: 72972 RVA: 0x0029BB76 File Offset: 0x00299D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011D0D RID: 72973 RVA: 0x0029BB83 File Offset: 0x00299D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011D0E RID: 72974 RVA: 0x0029BB8C File Offset: 0x00299D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.collectMusicIds_.WriteTo(ref output, PhantomMusicInfoResponse._repeated_collectMusicIds_codec);
			this.albumTimeInfos_.WriteTo(ref output, PhantomMusicInfoResponse._repeated_albumTimeInfos_codec);
			if (this.CurMusicId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.CurMusicId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011D0F RID: 72975 RVA: 0x0029BC08 File Offset: 0x00299E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurMusicId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurMusicId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.albumTimeInfos_.CalculateSize(PhantomMusicInfoResponse._repeated_albumTimeInfos_codec);
			num += this.collectMusicIds_.CalculateSize(PhantomMusicInfoResponse._repeated_collectMusicIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011D10 RID: 72976 RVA: 0x0029BC84 File Offset: 0x00299E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomMusicInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurMusicId != 0)
			{
				this.CurMusicId = other.CurMusicId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.albumTimeInfos_.Add(other.albumTimeInfos_);
			this.collectMusicIds_.Add(other.collectMusicIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011D11 RID: 72977 RVA: 0x0029BCF6 File Offset: 0x00299EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011D12 RID: 72978 RVA: 0x0029BD00 File Offset: 0x00299F00
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4A;
					}
					if (num == 58U)
					{
						this.albumTimeInfos_.AddEntriesFrom(ref input, PhantomMusicInfoResponse._repeated_albumTimeInfos_codec);
						continue;
					}
					if (num == 104U)
					{
						this.CurMusicId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.collectMusicIds_.AddEntriesFrom(ref input, PhantomMusicInfoResponse._repeated_collectMusicIds_codec);
			}
		}

		// Token: 0x04007046 RID: 28742
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007047 RID: 28743
		public const int CurMusicIdFieldNumber = 13;

		// Token: 0x04007048 RID: 28744
		private int curMusicId_;

		// Token: 0x04007049 RID: 28745
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400704A RID: 28746
		private ErrorCode errorCode_;

		// Token: 0x0400704B RID: 28747
		public const int AlbumTimeInfosFieldNumber = 7;

		// Token: 0x0400704C RID: 28748
		private static readonly FieldCodec<PhonographAlbumTimeInfo> _repeated_albumTimeInfos_codec = FieldCodec.ForMessage<PhonographAlbumTimeInfo>(58U, PhonographAlbumTimeInfo.Parser);

		// Token: 0x0400704D RID: 28749
		private readonly RepeatedField<PhonographAlbumTimeInfo> albumTimeInfos_ = new RepeatedField<PhonographAlbumTimeInfo>();

		// Token: 0x0400704E RID: 28750
		public const int CollectMusicIdsFieldNumber = 2;

		// Token: 0x0400704F RID: 28751
		private static readonly FieldCodec<int> _repeated_collectMusicIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007050 RID: 28752
		private readonly RepeatedField<int> collectMusicIds_ = new RepeatedField<int>();
	}
}
