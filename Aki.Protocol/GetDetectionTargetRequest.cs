using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C5 RID: 1733
	[NetMessage(EMessageId.GetDetectionTargetRequest)]
	public sealed class GetDetectionTargetRequest : IMessage<GetDetectionTargetRequest>, IMessage, IEquatable<GetDetectionTargetRequest>, IDeepCloneable<GetDetectionTargetRequest>, IBufferMessage
	{
		// Token: 0x06009E8D RID: 40589 RVA: 0x00180B70 File Offset: 0x0017ED70
		[NullableContext(1)]
		public static GetDetectionTargetRequest Create()
		{
			return new GetDetectionTargetRequest();
		}

		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x06009E8E RID: 40590 RVA: 0x00180B77 File Offset: 0x0017ED77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x06009E8F RID: 40591 RVA: 0x00180B7A File Offset: 0x0017ED7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDetectionTargetRequest.Descriptor;
			}
		}

		// Token: 0x06009E90 RID: 40592 RVA: 0x00180B81 File Offset: 0x0017ED81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionTargetRequest()
		{
		}

		// Token: 0x06009E91 RID: 40593 RVA: 0x00180B89 File Offset: 0x0017ED89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionTargetRequest(GetDetectionTargetRequest other) : this()
		{
			this.detectionId_ = other.detectionId_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E92 RID: 40594 RVA: 0x00180BBA File Offset: 0x0017EDBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionTargetRequest Clone()
		{
			return new GetDetectionTargetRequest(this);
		}

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x06009E93 RID: 40595 RVA: 0x00180BC2 File Offset: 0x0017EDC2
		// (set) Token: 0x06009E94 RID: 40596 RVA: 0x00180BCA File Offset: 0x0017EDCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DetectionId
		{
			get
			{
				return this.detectionId_;
			}
			set
			{
				this.detectionId_ = value;
			}
		}

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x06009E95 RID: 40597 RVA: 0x00180BD3 File Offset: 0x0017EDD3
		// (set) Token: 0x06009E96 RID: 40598 RVA: 0x00180BDB File Offset: 0x0017EDDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x06009E97 RID: 40599 RVA: 0x00180BE4 File Offset: 0x0017EDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDetectionTargetRequest);
		}

		// Token: 0x06009E98 RID: 40600 RVA: 0x00180BF2 File Offset: 0x0017EDF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetDetectionTargetRequest other)
		{
			return other != null && (other == this || (this.DetectionId == other.DetectionId && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E99 RID: 40601 RVA: 0x00180C30 File Offset: 0x0017EE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DetectionId != 0)
			{
				num ^= this.DetectionId.GetHashCode();
			}
			if (this.Type != DetectionType.NormalMonster)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009E9A RID: 40602 RVA: 0x00180C8E File Offset: 0x0017EE8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E9B RID: 40603 RVA: 0x00180C9B File Offset: 0x0017EE9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E9C RID: 40604 RVA: 0x00180CA4 File Offset: 0x0017EEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != DetectionType.NormalMonster)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Type);
			}
			if (this.DetectionId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.DetectionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E9D RID: 40605 RVA: 0x00180D00 File Offset: 0x0017EF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DetectionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DetectionId);
			}
			if (this.Type != DetectionType.NormalMonster)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009E9E RID: 40606 RVA: 0x00180D58 File Offset: 0x0017EF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetDetectionTargetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DetectionId != 0)
			{
				this.DetectionId = other.DetectionId;
			}
			if (other.Type != DetectionType.NormalMonster)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E9F RID: 40607 RVA: 0x00180DA8 File Offset: 0x0017EFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009EA0 RID: 40608 RVA: 0x00180DB4 File Offset: 0x0017EFB4
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
				if (num != 40U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.DetectionId = input.ReadInt32();
					}
				}
				else
				{
					this.Type = (DetectionType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004A35 RID: 18997
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A36 RID: 18998
		public const int DetectionIdFieldNumber = 14;

		// Token: 0x04004A37 RID: 18999
		private int detectionId_;

		// Token: 0x04004A38 RID: 19000
		public const int TypeFieldNumber = 5;

		// Token: 0x04004A39 RID: 19001
		private DetectionType type_;
	}
}
