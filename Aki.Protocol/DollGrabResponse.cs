using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003DE RID: 990
	[NetMessage(EMessageId.DollGrabResponse)]
	public sealed class DollGrabResponse : IMessage<DollGrabResponse>, IMessage, IEquatable<DollGrabResponse>, IDeepCloneable<DollGrabResponse>, IBufferMessage
	{
		// Token: 0x0600607B RID: 24699 RVA: 0x000E926C File Offset: 0x000E746C
		[NullableContext(1)]
		public static DollGrabResponse Create()
		{
			return new DollGrabResponse();
		}

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x0600607C RID: 24700 RVA: 0x000E9273 File Offset: 0x000E7473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x0600607D RID: 24701 RVA: 0x000E9276 File Offset: 0x000E7476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabResponse.Descriptor;
			}
		}

		// Token: 0x0600607E RID: 24702 RVA: 0x000E927D File Offset: 0x000E747D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabResponse()
		{
		}

		// Token: 0x0600607F RID: 24703 RVA: 0x000E9290 File Offset: 0x000E7490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabResponse(DollGrabResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.grabItemInfos_ = other.grabItemInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006080 RID: 24704 RVA: 0x000E92C6 File Offset: 0x000E74C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabResponse Clone()
		{
			return new DollGrabResponse(this);
		}

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x06006081 RID: 24705 RVA: 0x000E92CE File Offset: 0x000E74CE
		// (set) Token: 0x06006082 RID: 24706 RVA: 0x000E92D6 File Offset: 0x000E74D6
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

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x06006083 RID: 24707 RVA: 0x000E92DF File Offset: 0x000E74DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DollGrabItemInfo> GrabItemInfos
		{
			get
			{
				return this.grabItemInfos_;
			}
		}

		// Token: 0x06006084 RID: 24708 RVA: 0x000E92E7 File Offset: 0x000E74E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabResponse);
		}

		// Token: 0x06006085 RID: 24709 RVA: 0x000E92F8 File Offset: 0x000E74F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.grabItemInfos_.Equals(other.grabItemInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x000E9348 File Offset: 0x000E7548
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

		// Token: 0x06006087 RID: 24711 RVA: 0x000E939B File Offset: 0x000E759B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006088 RID: 24712 RVA: 0x000E93A8 File Offset: 0x000E75A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006089 RID: 24713 RVA: 0x000E93B4 File Offset: 0x000E75B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.grabItemInfos_.WriteTo(ref output, DollGrabResponse._repeated_grabItemInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600608A RID: 24714 RVA: 0x000E9404 File Offset: 0x000E7604
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

		// Token: 0x0600608B RID: 24715 RVA: 0x000E9458 File Offset: 0x000E7658
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

		// Token: 0x0600608C RID: 24716 RVA: 0x000E94A5 File Offset: 0x000E76A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600608D RID: 24717 RVA: 0x000E94B0 File Offset: 0x000E76B0
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
				if (num != 56U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.grabItemInfos_.AddEntriesFrom(ref input, DollGrabResponse._repeated_grabItemInfos_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040037AC RID: 14252
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037AD RID: 14253
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040037AE RID: 14254
		private ErrorCode errorCode_;

		// Token: 0x040037AF RID: 14255
		public const int GrabItemInfosFieldNumber = 10;

		// Token: 0x040037B0 RID: 14256
		private static readonly FieldCodec<DollGrabItemInfo> _repeated_grabItemInfos_codec = FieldCodec.ForMessage<DollGrabItemInfo>(82U, DollGrabItemInfo.Parser);

		// Token: 0x040037B1 RID: 14257
		private readonly RepeatedField<DollGrabItemInfo> grabItemInfos_ = new RepeatedField<DollGrabItemInfo>();
	}
}
