using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006FB RID: 1787
	[NetMessage(EMessageId.GmEntityFsmGroupInfoResponse)]
	public sealed class GmEntityFsmGroupInfoResponse : IMessage<GmEntityFsmGroupInfoResponse>, IMessage, IEquatable<GmEntityFsmGroupInfoResponse>, IDeepCloneable<GmEntityFsmGroupInfoResponse>, IBufferMessage
	{
		// Token: 0x0600A2C1 RID: 41665 RVA: 0x001896F1 File Offset: 0x001878F1
		[NullableContext(1)]
		public static GmEntityFsmGroupInfoResponse Create()
		{
			return new GmEntityFsmGroupInfoResponse();
		}

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x0600A2C2 RID: 41666 RVA: 0x001896F8 File Offset: 0x001878F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x0600A2C3 RID: 41667 RVA: 0x001896FB File Offset: 0x001878FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmEntityFsmGroupInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600A2C4 RID: 41668 RVA: 0x00189702 File Offset: 0x00187902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmGroupInfoResponse()
		{
		}

		// Token: 0x0600A2C5 RID: 41669 RVA: 0x00189715 File Offset: 0x00187915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmGroupInfoResponse(GmEntityFsmGroupInfoResponse other) : this()
		{
			this.entityId_ = other.entityId_;
			this.gmEntityFsmMachineInfos_ = other.gmEntityFsmMachineInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A2C6 RID: 41670 RVA: 0x0018974B File Offset: 0x0018794B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmGroupInfoResponse Clone()
		{
			return new GmEntityFsmGroupInfoResponse(this);
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x0600A2C7 RID: 41671 RVA: 0x00189753 File Offset: 0x00187953
		// (set) Token: 0x0600A2C8 RID: 41672 RVA: 0x0018975B File Offset: 0x0018795B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x0600A2C9 RID: 41673 RVA: 0x00189764 File Offset: 0x00187964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GmEntityFsmMachineInfo> GmEntityFsmMachineInfos
		{
			get
			{
				return this.gmEntityFsmMachineInfos_;
			}
		}

		// Token: 0x0600A2CA RID: 41674 RVA: 0x0018976C File Offset: 0x0018796C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmEntityFsmGroupInfoResponse);
		}

		// Token: 0x0600A2CB RID: 41675 RVA: 0x0018977C File Offset: 0x0018797C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmEntityFsmGroupInfoResponse other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.gmEntityFsmMachineInfos_.Equals(other.gmEntityFsmMachineInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A2CC RID: 41676 RVA: 0x001897CC File Offset: 0x001879CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.gmEntityFsmMachineInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A2CD RID: 41677 RVA: 0x00189819 File Offset: 0x00187A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A2CE RID: 41678 RVA: 0x00189826 File Offset: 0x00187A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A2CF RID: 41679 RVA: 0x00189830 File Offset: 0x00187A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gmEntityFsmMachineInfos_.WriteTo(ref output, GmEntityFsmGroupInfoResponse._repeated_gmEntityFsmMachineInfos_codec);
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A2D0 RID: 41680 RVA: 0x00189880 File Offset: 0x00187A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.gmEntityFsmMachineInfos_.CalculateSize(GmEntityFsmGroupInfoResponse._repeated_gmEntityFsmMachineInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A2D1 RID: 41681 RVA: 0x001898D4 File Offset: 0x00187AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmEntityFsmGroupInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.gmEntityFsmMachineInfos_.Add(other.gmEntityFsmMachineInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A2D2 RID: 41682 RVA: 0x00189921 File Offset: 0x00187B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A2D3 RID: 41683 RVA: 0x0018992C File Offset: 0x00187B2C
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
				if (num != 82U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.gmEntityFsmMachineInfos_.AddEntriesFrom(ref input, GmEntityFsmGroupInfoResponse._repeated_gmEntityFsmMachineInfos_codec);
				}
			}
		}

		// Token: 0x04004B58 RID: 19288
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B59 RID: 19289
		public const int EntityIdFieldNumber = 11;

		// Token: 0x04004B5A RID: 19290
		private long entityId_;

		// Token: 0x04004B5B RID: 19291
		public const int GmEntityFsmMachineInfosFieldNumber = 10;

		// Token: 0x04004B5C RID: 19292
		private static readonly FieldCodec<GmEntityFsmMachineInfo> _repeated_gmEntityFsmMachineInfos_codec = FieldCodec.ForMessage<GmEntityFsmMachineInfo>(82U, GmEntityFsmMachineInfo.Parser);

		// Token: 0x04004B5D RID: 19293
		private readonly RepeatedField<GmEntityFsmMachineInfo> gmEntityFsmMachineInfos_ = new RepeatedField<GmEntityFsmMachineInfo>();
	}
}
