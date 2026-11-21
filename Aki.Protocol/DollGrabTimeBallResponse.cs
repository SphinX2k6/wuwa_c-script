using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E3 RID: 995
	[NetMessage(EMessageId.DollGrabTimeBallResponse)]
	public sealed class DollGrabTimeBallResponse : IMessage<DollGrabTimeBallResponse>, IMessage, IEquatable<DollGrabTimeBallResponse>, IDeepCloneable<DollGrabTimeBallResponse>, IBufferMessage
	{
		// Token: 0x060060DF RID: 24799 RVA: 0x000E9F78 File Offset: 0x000E8178
		[NullableContext(1)]
		public static DollGrabTimeBallResponse Create()
		{
			return new DollGrabTimeBallResponse();
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x060060E0 RID: 24800 RVA: 0x000E9F7F File Offset: 0x000E817F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x060060E1 RID: 24801 RVA: 0x000E9F82 File Offset: 0x000E8182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabTimeBallResponse.Descriptor;
			}
		}

		// Token: 0x060060E2 RID: 24802 RVA: 0x000E9F89 File Offset: 0x000E8189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabTimeBallResponse()
		{
		}

		// Token: 0x060060E3 RID: 24803 RVA: 0x000E9F9C File Offset: 0x000E819C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabTimeBallResponse(DollGrabTimeBallResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.grabItemInfos_ = other.grabItemInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060060E4 RID: 24804 RVA: 0x000E9FD2 File Offset: 0x000E81D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabTimeBallResponse Clone()
		{
			return new DollGrabTimeBallResponse(this);
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x060060E5 RID: 24805 RVA: 0x000E9FDA File Offset: 0x000E81DA
		// (set) Token: 0x060060E6 RID: 24806 RVA: 0x000E9FE2 File Offset: 0x000E81E2
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

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x060060E7 RID: 24807 RVA: 0x000E9FEB File Offset: 0x000E81EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DollGrabItemInfo> GrabItemInfos
		{
			get
			{
				return this.grabItemInfos_;
			}
		}

		// Token: 0x060060E8 RID: 24808 RVA: 0x000E9FF3 File Offset: 0x000E81F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabTimeBallResponse);
		}

		// Token: 0x060060E9 RID: 24809 RVA: 0x000EA004 File Offset: 0x000E8204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabTimeBallResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.grabItemInfos_.Equals(other.grabItemInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060060EA RID: 24810 RVA: 0x000EA054 File Offset: 0x000E8254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.grabItemInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060060EB RID: 24811 RVA: 0x000EA0A7 File Offset: 0x000E82A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060060EC RID: 24812 RVA: 0x000EA0B4 File Offset: 0x000E82B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060ED RID: 24813 RVA: 0x000EA0C0 File Offset: 0x000E82C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.grabItemInfos_.WriteTo(ref output, DollGrabTimeBallResponse._repeated_grabItemInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060060EE RID: 24814 RVA: 0x000EA110 File Offset: 0x000E8310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.grabItemInfos_.CalculateSize(DollGrabTimeBallResponse._repeated_grabItemInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060060EF RID: 24815 RVA: 0x000EA164 File Offset: 0x000E8364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabTimeBallResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.grabItemInfos_.Add(other.grabItemInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060060F0 RID: 24816 RVA: 0x000EA1B1 File Offset: 0x000E83B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060060F1 RID: 24817 RVA: 0x000EA1BC File Offset: 0x000E83BC
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
				if (num != 80U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.grabItemInfos_.AddEntriesFrom(ref input, DollGrabTimeBallResponse._repeated_grabItemInfos_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040037C7 RID: 14279
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037C8 RID: 14280
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040037C9 RID: 14281
		private ErrorCode errorCode_;

		// Token: 0x040037CA RID: 14282
		public const int GrabItemInfosFieldNumber = 15;

		// Token: 0x040037CB RID: 14283
		private static readonly FieldCodec<DollGrabItemInfo> _repeated_grabItemInfos_codec = FieldCodec.ForMessage<DollGrabItemInfo>(122U, DollGrabItemInfo.Parser);

		// Token: 0x040037CC RID: 14284
		private readonly RepeatedField<DollGrabItemInfo> grabItemInfos_ = new RepeatedField<DollGrabItemInfo>();
	}
}
