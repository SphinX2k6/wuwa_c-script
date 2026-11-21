using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B7 RID: 951
	[NetMessage(EMessageId.DetectionRequest)]
	public sealed class DetectionRequest : IMessage<DetectionRequest>, IMessage, IEquatable<DetectionRequest>, IDeepCloneable<DetectionRequest>, IBufferMessage
	{
		// Token: 0x06005D6C RID: 23916 RVA: 0x000E2C22 File Offset: 0x000E0E22
		[NullableContext(1)]
		public static DetectionRequest Create()
		{
			return new DetectionRequest();
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06005D6D RID: 23917 RVA: 0x000E2C29 File Offset: 0x000E0E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06005D6E RID: 23918 RVA: 0x000E2C2C File Offset: 0x000E0E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionRequest.Descriptor;
			}
		}

		// Token: 0x06005D6F RID: 23919 RVA: 0x000E2C33 File Offset: 0x000E0E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionRequest()
		{
		}

		// Token: 0x06005D70 RID: 23920 RVA: 0x000E2C48 File Offset: 0x000E0E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionRequest(DetectionRequest other) : this()
		{
			this.detectionType_ = other.detectionType_;
			this.detectionId_ = other.detectionId_.Clone();
			this.detectionConfId_ = other.detectionConfId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D71 RID: 23921 RVA: 0x000E2C95 File Offset: 0x000E0E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionRequest Clone()
		{
			return new DetectionRequest(this);
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x06005D72 RID: 23922 RVA: 0x000E2C9D File Offset: 0x000E0E9D
		// (set) Token: 0x06005D73 RID: 23923 RVA: 0x000E2CA5 File Offset: 0x000E0EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionType DetectionType
		{
			get
			{
				return this.detectionType_;
			}
			set
			{
				this.detectionType_ = value;
			}
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06005D74 RID: 23924 RVA: 0x000E2CAE File Offset: 0x000E0EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DetectionId
		{
			get
			{
				return this.detectionId_;
			}
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x06005D75 RID: 23925 RVA: 0x000E2CB6 File Offset: 0x000E0EB6
		// (set) Token: 0x06005D76 RID: 23926 RVA: 0x000E2CBE File Offset: 0x000E0EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DetectionConfId
		{
			get
			{
				return this.detectionConfId_;
			}
			set
			{
				this.detectionConfId_ = value;
			}
		}

		// Token: 0x06005D77 RID: 23927 RVA: 0x000E2CC7 File Offset: 0x000E0EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionRequest);
		}

		// Token: 0x06005D78 RID: 23928 RVA: 0x000E2CD8 File Offset: 0x000E0ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionRequest other)
		{
			return other != null && (other == this || (this.DetectionType == other.DetectionType && this.detectionId_.Equals(other.detectionId_) && this.DetectionConfId == other.DetectionConfId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D79 RID: 23929 RVA: 0x000E2D38 File Offset: 0x000E0F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DetectionType != DetectionType.NormalMonster)
			{
				num ^= this.DetectionType.GetHashCode();
			}
			num ^= this.detectionId_.GetHashCode();
			if (this.DetectionConfId != 0)
			{
				num ^= this.DetectionConfId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D7A RID: 23930 RVA: 0x000E2DA4 File Offset: 0x000E0FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005D7B RID: 23931 RVA: 0x000E2DB1 File Offset: 0x000E0FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D7C RID: 23932 RVA: 0x000E2DBC File Offset: 0x000E0FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DetectionConfId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.DetectionConfId);
			}
			this.detectionId_.WriteTo(ref output, DetectionRequest._repeated_detectionId_codec);
			if (this.DetectionType != DetectionType.NormalMonster)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.DetectionType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D7D RID: 23933 RVA: 0x000E2E28 File Offset: 0x000E1028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DetectionType != DetectionType.NormalMonster)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.DetectionType);
			}
			num += this.detectionId_.CalculateSize(DetectionRequest._repeated_detectionId_codec);
			if (this.DetectionConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DetectionConfId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D7E RID: 23934 RVA: 0x000E2E94 File Offset: 0x000E1094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DetectionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DetectionType != DetectionType.NormalMonster)
			{
				this.DetectionType = other.DetectionType;
			}
			this.detectionId_.Add(other.detectionId_);
			if (other.DetectionConfId != 0)
			{
				this.DetectionConfId = other.DetectionConfId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D7F RID: 23935 RVA: 0x000E2EF5 File Offset: 0x000E10F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D80 RID: 23936 RVA: 0x000E2F00 File Offset: 0x000E1100
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
				if (num <= 104U)
				{
					if (num == 80U)
					{
						this.DetectionConfId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 106U)
					{
						goto IL_46;
					}
					if (num == 112U)
					{
						this.DetectionType = (DetectionType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.detectionId_.AddEntriesFrom(ref input, DetectionRequest._repeated_detectionId_codec);
			}
		}

		// Token: 0x040036DA RID: 14042
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036DB RID: 14043
		public const int DetectionTypeFieldNumber = 14;

		// Token: 0x040036DC RID: 14044
		private DetectionType detectionType_;

		// Token: 0x040036DD RID: 14045
		public const int DetectionIdFieldNumber = 13;

		// Token: 0x040036DE RID: 14046
		private static readonly FieldCodec<int> _repeated_detectionId_codec = FieldCodec.ForInt32(106U);

		// Token: 0x040036DF RID: 14047
		private readonly RepeatedField<int> detectionId_ = new RepeatedField<int>();

		// Token: 0x040036E0 RID: 14048
		public const int DetectionConfIdFieldNumber = 10;

		// Token: 0x040036E1 RID: 14049
		private int detectionConfId_;
	}
}
