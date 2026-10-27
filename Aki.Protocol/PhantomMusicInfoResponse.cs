using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE8 RID: 3304
	[NetMessage(EMessageId.PhantomMusicInfoResponse)]
	public sealed class PhantomMusicInfoResponse : IMessage<PhantomMusicInfoResponse>, IMessage, IEquatable<PhantomMusicInfoResponse>, IDeepCloneable<PhantomMusicInfoResponse>, IBufferMessage
	{
		// Token: 0x06011DF9 RID: 73209 RVA: 0x0029D5C2 File Offset: 0x0029B7C2
		[NullableContext(1)]
		public static PhantomMusicInfoResponse Create()
		{
			return new PhantomMusicInfoResponse();
		}

		// Token: 0x17003B3B RID: 15163
		// (get) Token: 0x06011DFA RID: 73210 RVA: 0x0029D5C9 File Offset: 0x0029B7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B3C RID: 15164
		// (get) Token: 0x06011DFB RID: 73211 RVA: 0x0029D5CC File Offset: 0x0029B7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicInfoResponse.Descriptor;
			}
		}

		// Token: 0x06011DFC RID: 73212 RVA: 0x0029D5D3 File Offset: 0x0029B7D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicInfoResponse()
		{
		}

		// Token: 0x06011DFD RID: 73213 RVA: 0x0029D5F4 File Offset: 0x0029B7F4
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

		// Token: 0x06011DFE RID: 73214 RVA: 0x0029D652 File Offset: 0x0029B852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicInfoResponse Clone()
		{
			return new PhantomMusicInfoResponse(this);
		}

		// Token: 0x17003B3D RID: 15165
		// (get) Token: 0x06011DFF RID: 73215 RVA: 0x0029D65A File Offset: 0x0029B85A
		// (set) Token: 0x06011E00 RID: 73216 RVA: 0x0029D662 File Offset: 0x0029B862
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

		// Token: 0x17003B3E RID: 15166
		// (get) Token: 0x06011E01 RID: 73217 RVA: 0x0029D66B File Offset: 0x0029B86B
		// (set) Token: 0x06011E02 RID: 73218 RVA: 0x0029D673 File Offset: 0x0029B873
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

		// Token: 0x17003B3F RID: 15167
		// (get) Token: 0x06011E03 RID: 73219 RVA: 0x0029D67C File Offset: 0x0029B87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhonographAlbumTimeInfo> AlbumTimeInfos
		{
			get
			{
				return this.albumTimeInfos_;
			}
		}

		// Token: 0x17003B40 RID: 15168
		// (get) Token: 0x06011E04 RID: 73220 RVA: 0x0029D684 File Offset: 0x0029B884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CollectMusicIds
		{
			get
			{
				return this.collectMusicIds_;
			}
		}

		// Token: 0x06011E05 RID: 73221 RVA: 0x0029D68C File Offset: 0x0029B88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicInfoResponse);
		}

		// Token: 0x06011E06 RID: 73222 RVA: 0x0029D69C File Offset: 0x0029B89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicInfoResponse other)
		{
			return other != null && (other == this || (this.CurMusicId == other.CurMusicId && this.ErrorCode == other.ErrorCode && this.albumTimeInfos_.Equals(other.albumTimeInfos_) && this.collectMusicIds_.Equals(other.collectMusicIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011E07 RID: 73223 RVA: 0x0029D710 File Offset: 0x0029B910
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

		// Token: 0x06011E08 RID: 73224 RVA: 0x0029D78A File Offset: 0x0029B98A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011E09 RID: 73225 RVA: 0x0029D797 File Offset: 0x0029B997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011E0A RID: 73226 RVA: 0x0029D7A0 File Offset: 0x0029B9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CurMusicId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CurMusicId);
			}
			this.collectMusicIds_.WriteTo(ref output, PhantomMusicInfoResponse._repeated_collectMusicIds_codec);
			this.albumTimeInfos_.WriteTo(ref output, PhantomMusicInfoResponse._repeated_albumTimeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011E0B RID: 73227 RVA: 0x0029D81C File Offset: 0x0029BA1C
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

		// Token: 0x06011E0C RID: 73228 RVA: 0x0029D898 File Offset: 0x0029BA98
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

		// Token: 0x06011E0D RID: 73229 RVA: 0x0029D90A File Offset: 0x0029BB0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011E0E RID: 73230 RVA: 0x0029D914 File Offset: 0x0029BB14
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
				if (num <= 64U)
				{
					if (num == 48U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 64U)
					{
						this.CurMusicId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U || num == 74U)
					{
						this.collectMusicIds_.AddEntriesFrom(ref input, PhantomMusicInfoResponse._repeated_collectMusicIds_codec);
						continue;
					}
					if (num == 90U)
					{
						this.albumTimeInfos_.AddEntriesFrom(ref input, PhantomMusicInfoResponse._repeated_albumTimeInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400702E RID: 28718
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400702F RID: 28719
		public const int CurMusicIdFieldNumber = 8;

		// Token: 0x04007030 RID: 28720
		private int curMusicId_;

		// Token: 0x04007031 RID: 28721
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04007032 RID: 28722
		private ErrorCode errorCode_;

		// Token: 0x04007033 RID: 28723
		public const int AlbumTimeInfosFieldNumber = 11;

		// Token: 0x04007034 RID: 28724
		private static readonly FieldCodec<PhonographAlbumTimeInfo> _repeated_albumTimeInfos_codec = FieldCodec.ForMessage<PhonographAlbumTimeInfo>(90U, PhonographAlbumTimeInfo.Parser);

		// Token: 0x04007035 RID: 28725
		private readonly RepeatedField<PhonographAlbumTimeInfo> albumTimeInfos_ = new RepeatedField<PhonographAlbumTimeInfo>();

		// Token: 0x04007036 RID: 28726
		public const int CollectMusicIdsFieldNumber = 9;

		// Token: 0x04007037 RID: 28727
		private static readonly FieldCodec<int> _repeated_collectMusicIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04007038 RID: 28728
		private readonly RepeatedField<int> collectMusicIds_ = new RepeatedField<int>();
	}
}
