using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E8 RID: 5096
	[NetMessage(EMessageId.TrackMoonRoleDataResponse)]
	public sealed class TrackMoonRoleDataResponse : IMessage<TrackMoonRoleDataResponse>, IMessage, IEquatable<TrackMoonRoleDataResponse>, IDeepCloneable<TrackMoonRoleDataResponse>, IBufferMessage
	{
		// Token: 0x0601B01F RID: 110623 RVA: 0x003E9466 File Offset: 0x003E7666
		[NullableContext(1)]
		public static TrackMoonRoleDataResponse Create()
		{
			return new TrackMoonRoleDataResponse();
		}

		// Token: 0x17005B04 RID: 23300
		// (get) Token: 0x0601B020 RID: 110624 RVA: 0x003E946D File Offset: 0x003E766D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B05 RID: 23301
		// (get) Token: 0x0601B021 RID: 110625 RVA: 0x003E9470 File Offset: 0x003E7670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonRoleDataResponse.Descriptor;
			}
		}

		// Token: 0x0601B022 RID: 110626 RVA: 0x003E9477 File Offset: 0x003E7677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRoleDataResponse()
		{
		}

		// Token: 0x0601B023 RID: 110627 RVA: 0x003E948A File Offset: 0x003E768A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRoleDataResponse(TrackMoonRoleDataResponse other) : this()
		{
			this.entrustRoleInfos_ = other.entrustRoleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B024 RID: 110628 RVA: 0x003E94B4 File Offset: 0x003E76B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonRoleDataResponse Clone()
		{
			return new TrackMoonRoleDataResponse(this);
		}

		// Token: 0x17005B06 RID: 23302
		// (get) Token: 0x0601B025 RID: 110629 RVA: 0x003E94BC File Offset: 0x003E76BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntrustRoleInfo> EntrustRoleInfos
		{
			get
			{
				return this.entrustRoleInfos_;
			}
		}

		// Token: 0x0601B026 RID: 110630 RVA: 0x003E94C4 File Offset: 0x003E76C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonRoleDataResponse);
		}

		// Token: 0x0601B027 RID: 110631 RVA: 0x003E94D2 File Offset: 0x003E76D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonRoleDataResponse other)
		{
			return other != null && (other == this || (this.entrustRoleInfos_.Equals(other.entrustRoleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B028 RID: 110632 RVA: 0x003E9508 File Offset: 0x003E7708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entrustRoleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B029 RID: 110633 RVA: 0x003E953C File Offset: 0x003E773C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B02A RID: 110634 RVA: 0x003E9549 File Offset: 0x003E7749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B02B RID: 110635 RVA: 0x003E9552 File Offset: 0x003E7752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entrustRoleInfos_.WriteTo(ref output, TrackMoonRoleDataResponse._repeated_entrustRoleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B02C RID: 110636 RVA: 0x003E957C File Offset: 0x003E777C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entrustRoleInfos_.CalculateSize(TrackMoonRoleDataResponse._repeated_entrustRoleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B02D RID: 110637 RVA: 0x003E95B5 File Offset: 0x003E77B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonRoleDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.entrustRoleInfos_.Add(other.entrustRoleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B02E RID: 110638 RVA: 0x003E95E3 File Offset: 0x003E77E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B02F RID: 110639 RVA: 0x003E95EC File Offset: 0x003E77EC
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entrustRoleInfos_.AddEntriesFrom(ref input, TrackMoonRoleDataResponse._repeated_entrustRoleInfos_codec);
				}
			}
		}

		// Token: 0x04009C5A RID: 40026
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C5B RID: 40027
		public const int EntrustRoleInfosFieldNumber = 12;

		// Token: 0x04009C5C RID: 40028
		private static readonly FieldCodec<EntrustRoleInfo> _repeated_entrustRoleInfos_codec = FieldCodec.ForMessage<EntrustRoleInfo>(98U, EntrustRoleInfo.Parser);

		// Token: 0x04009C5D RID: 40029
		private readonly RepeatedField<EntrustRoleInfo> entrustRoleInfos_ = new RepeatedField<EntrustRoleInfo>();
	}
}
