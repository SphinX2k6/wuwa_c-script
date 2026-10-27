using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E3 RID: 5091
	[NetMessage(EMessageId.TrackMoonEntrustDataResponse)]
	public sealed class TrackMoonEntrustDataResponse : IMessage<TrackMoonEntrustDataResponse>, IMessage, IEquatable<TrackMoonEntrustDataResponse>, IDeepCloneable<TrackMoonEntrustDataResponse>, IBufferMessage
	{
		// Token: 0x0601AFC7 RID: 110535 RVA: 0x003E8BAA File Offset: 0x003E6DAA
		[NullableContext(1)]
		public static TrackMoonEntrustDataResponse Create()
		{
			return new TrackMoonEntrustDataResponse();
		}

		// Token: 0x17005AF6 RID: 23286
		// (get) Token: 0x0601AFC8 RID: 110536 RVA: 0x003E8BB1 File Offset: 0x003E6DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AF7 RID: 23287
		// (get) Token: 0x0601AFC9 RID: 110537 RVA: 0x003E8BB4 File Offset: 0x003E6DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonEntrustDataResponse.Descriptor;
			}
		}

		// Token: 0x0601AFCA RID: 110538 RVA: 0x003E8BBB File Offset: 0x003E6DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonEntrustDataResponse()
		{
		}

		// Token: 0x0601AFCB RID: 110539 RVA: 0x003E8BCE File Offset: 0x003E6DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonEntrustDataResponse(TrackMoonEntrustDataResponse other) : this()
		{
			this.entrustInfos_ = other.entrustInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AFCC RID: 110540 RVA: 0x003E8BF8 File Offset: 0x003E6DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonEntrustDataResponse Clone()
		{
			return new TrackMoonEntrustDataResponse(this);
		}

		// Token: 0x17005AF8 RID: 23288
		// (get) Token: 0x0601AFCD RID: 110541 RVA: 0x003E8C00 File Offset: 0x003E6E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntrustInfo> EntrustInfos
		{
			get
			{
				return this.entrustInfos_;
			}
		}

		// Token: 0x0601AFCE RID: 110542 RVA: 0x003E8C08 File Offset: 0x003E6E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonEntrustDataResponse);
		}

		// Token: 0x0601AFCF RID: 110543 RVA: 0x003E8C16 File Offset: 0x003E6E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonEntrustDataResponse other)
		{
			return other != null && (other == this || (this.entrustInfos_.Equals(other.entrustInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AFD0 RID: 110544 RVA: 0x003E8C4C File Offset: 0x003E6E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entrustInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AFD1 RID: 110545 RVA: 0x003E8C80 File Offset: 0x003E6E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AFD2 RID: 110546 RVA: 0x003E8C8D File Offset: 0x003E6E8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AFD3 RID: 110547 RVA: 0x003E8C96 File Offset: 0x003E6E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entrustInfos_.WriteTo(ref output, TrackMoonEntrustDataResponse._repeated_entrustInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AFD4 RID: 110548 RVA: 0x003E8CC0 File Offset: 0x003E6EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entrustInfos_.CalculateSize(TrackMoonEntrustDataResponse._repeated_entrustInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AFD5 RID: 110549 RVA: 0x003E8CF9 File Offset: 0x003E6EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonEntrustDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.entrustInfos_.Add(other.entrustInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AFD6 RID: 110550 RVA: 0x003E8D27 File Offset: 0x003E6F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AFD7 RID: 110551 RVA: 0x003E8D30 File Offset: 0x003E6F30
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entrustInfos_.AddEntriesFrom(ref input, TrackMoonEntrustDataResponse._repeated_entrustInfos_codec);
				}
			}
		}

		// Token: 0x04009C49 RID: 40009
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C4A RID: 40010
		public const int EntrustInfosFieldNumber = 5;

		// Token: 0x04009C4B RID: 40011
		private static readonly FieldCodec<EntrustInfo> _repeated_entrustInfos_codec = FieldCodec.ForMessage<EntrustInfo>(42U, EntrustInfo.Parser);

		// Token: 0x04009C4C RID: 40012
		private readonly RepeatedField<EntrustInfo> entrustInfos_ = new RepeatedField<EntrustInfo>();
	}
}
