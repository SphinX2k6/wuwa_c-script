using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F5 RID: 1013
	[NetMessage(EMessageId.DollGrabResponse)]
	public sealed class DollGrabResponse : IMessage<DollGrabResponse>, IMessage, IEquatable<DollGrabResponse>, IDeepCloneable<DollGrabResponse>, IBufferMessage
	{
		// Token: 0x0600620B RID: 25099 RVA: 0x000EC3EC File Offset: 0x000EA5EC
		[NullableContext(1)]
		public static DollGrabResponse Create()
		{
			return new DollGrabResponse();
		}

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x0600620C RID: 25100 RVA: 0x000EC3F3 File Offset: 0x000EA5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x0600620D RID: 25101 RVA: 0x000EC3F6 File Offset: 0x000EA5F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabResponse.Descriptor;
			}
		}

		// Token: 0x0600620E RID: 25102 RVA: 0x000EC3FD File Offset: 0x000EA5FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabResponse()
		{
		}

		// Token: 0x0600620F RID: 25103 RVA: 0x000EC410 File Offset: 0x000EA610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabResponse(DollGrabResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.grabItemInfos_ = other.grabItemInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006210 RID: 25104 RVA: 0x000EC446 File Offset: 0x000EA646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabResponse Clone()
		{
			return new DollGrabResponse(this);
		}

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x06006211 RID: 25105 RVA: 0x000EC44E File Offset: 0x000EA64E
		// (set) Token: 0x06006212 RID: 25106 RVA: 0x000EC456 File Offset: 0x000EA656
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

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x06006213 RID: 25107 RVA: 0x000EC45F File Offset: 0x000EA65F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DollGrabItemInfo> GrabItemInfos
		{
			get
			{
				return this.grabItemInfos_;
			}
		}

		// Token: 0x06006214 RID: 25108 RVA: 0x000EC467 File Offset: 0x000EA667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabResponse);
		}

		// Token: 0x06006215 RID: 25109 RVA: 0x000EC478 File Offset: 0x000EA678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.grabItemInfos_.Equals(other.grabItemInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006216 RID: 25110 RVA: 0x000EC4C8 File Offset: 0x000EA6C8
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

		// Token: 0x06006217 RID: 25111 RVA: 0x000EC51B File Offset: 0x000EA71B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006218 RID: 25112 RVA: 0x000EC528 File Offset: 0x000EA728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006219 RID: 25113 RVA: 0x000EC534 File Offset: 0x000EA734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.grabItemInfos_.WriteTo(ref output, DollGrabResponse._repeated_grabItemInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600621A RID: 25114 RVA: 0x000EC584 File Offset: 0x000EA784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.grabItemInfos_.CalculateSize(DollGrabResponse._repeated_grabItemInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600621B RID: 25115 RVA: 0x000EC5D8 File Offset: 0x000EA7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabResponse other)
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

		// Token: 0x0600621C RID: 25116 RVA: 0x000EC625 File Offset: 0x000EA825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600621D RID: 25117 RVA: 0x000EC630 File Offset: 0x000EA830
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
				if (num != 58U)
				{
					if (num != 104U)
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
					this.grabItemInfos_.AddEntriesFrom(ref input, DollGrabResponse._repeated_grabItemInfos_codec);
				}
			}
		}

		// Token: 0x040037BF RID: 14271
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037C0 RID: 14272
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040037C1 RID: 14273
		private ErrorCode errorCode_;

		// Token: 0x040037C2 RID: 14274
		public const int GrabItemInfosFieldNumber = 7;

		// Token: 0x040037C3 RID: 14275
		private static readonly FieldCodec<DollGrabItemInfo> _repeated_grabItemInfos_codec = FieldCodec.ForMessage<DollGrabItemInfo>(58U, DollGrabItemInfo.Parser);

		// Token: 0x040037C4 RID: 14276
		private readonly RepeatedField<DollGrabItemInfo> grabItemInfos_ = new RepeatedField<DollGrabItemInfo>();
	}
}
