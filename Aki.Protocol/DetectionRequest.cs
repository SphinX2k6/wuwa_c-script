using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003CE RID: 974
	[NetMessage(EMessageId.DetectionRequest)]
	public sealed class DetectionRequest : IMessage<DetectionRequest>, IMessage, IEquatable<DetectionRequest>, IDeepCloneable<DetectionRequest>, IBufferMessage
	{
		// Token: 0x06005EFC RID: 24316 RVA: 0x000E5DA6 File Offset: 0x000E3FA6
		[NullableContext(1)]
		public static DetectionRequest Create()
		{
			return new DetectionRequest();
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06005EFD RID: 24317 RVA: 0x000E5DAD File Offset: 0x000E3FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x06005EFE RID: 24318 RVA: 0x000E5DB0 File Offset: 0x000E3FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionRequest.Descriptor;
			}
		}

		// Token: 0x06005EFF RID: 24319 RVA: 0x000E5DB7 File Offset: 0x000E3FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionRequest()
		{
		}

		// Token: 0x06005F00 RID: 24320 RVA: 0x000E5DCC File Offset: 0x000E3FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionRequest(DetectionRequest other) : this()
		{
			this.detectionType_ = other.detectionType_;
			this.detectionId_ = other.detectionId_.Clone();
			this.detectionConfId_ = other.detectionConfId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F01 RID: 24321 RVA: 0x000E5E19 File Offset: 0x000E4019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionRequest Clone()
		{
			return new DetectionRequest(this);
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x06005F02 RID: 24322 RVA: 0x000E5E21 File Offset: 0x000E4021
		// (set) Token: 0x06005F03 RID: 24323 RVA: 0x000E5E29 File Offset: 0x000E4029
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

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x06005F04 RID: 24324 RVA: 0x000E5E32 File Offset: 0x000E4032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DetectionId
		{
			get
			{
				return this.detectionId_;
			}
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x06005F05 RID: 24325 RVA: 0x000E5E3A File Offset: 0x000E403A
		// (set) Token: 0x06005F06 RID: 24326 RVA: 0x000E5E42 File Offset: 0x000E4042
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

		// Token: 0x06005F07 RID: 24327 RVA: 0x000E5E4B File Offset: 0x000E404B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionRequest);
		}

		// Token: 0x06005F08 RID: 24328 RVA: 0x000E5E5C File Offset: 0x000E405C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionRequest other)
		{
			return other != null && (other == this || (this.DetectionType == other.DetectionType && this.detectionId_.Equals(other.detectionId_) && this.DetectionConfId == other.DetectionConfId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F09 RID: 24329 RVA: 0x000E5EBC File Offset: 0x000E40BC
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

		// Token: 0x06005F0A RID: 24330 RVA: 0x000E5F28 File Offset: 0x000E4128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005F0B RID: 24331 RVA: 0x000E5F35 File Offset: 0x000E4135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F0C RID: 24332 RVA: 0x000E5F40 File Offset: 0x000E4140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DetectionType != DetectionType.NormalMonster)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.DetectionType);
			}
			if (this.DetectionConfId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.DetectionConfId);
			}
			this.detectionId_.WriteTo(ref output, DetectionRequest._repeated_detectionId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F0D RID: 24333 RVA: 0x000E5FAC File Offset: 0x000E41AC
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

		// Token: 0x06005F0E RID: 24334 RVA: 0x000E6018 File Offset: 0x000E4218
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

		// Token: 0x06005F0F RID: 24335 RVA: 0x000E6079 File Offset: 0x000E4279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F10 RID: 24336 RVA: 0x000E6084 File Offset: 0x000E4284
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
				if (num <= 48U)
				{
					if (num == 16U)
					{
						this.DetectionType = (DetectionType)input.ReadEnum();
						continue;
					}
					if (num == 48U)
					{
						this.DetectionConfId = input.ReadInt32();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.detectionId_.AddEntriesFrom(ref input, DetectionRequest._repeated_detectionId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040036ED RID: 14061
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036EE RID: 14062
		public const int DetectionTypeFieldNumber = 2;

		// Token: 0x040036EF RID: 14063
		private DetectionType detectionType_;

		// Token: 0x040036F0 RID: 14064
		public const int DetectionIdFieldNumber = 15;

		// Token: 0x040036F1 RID: 14065
		private static readonly FieldCodec<int> _repeated_detectionId_codec = FieldCodec.ForInt32(122U);

		// Token: 0x040036F2 RID: 14066
		private readonly RepeatedField<int> detectionId_ = new RepeatedField<int>();

		// Token: 0x040036F3 RID: 14067
		public const int DetectionConfIdFieldNumber = 6;

		// Token: 0x040036F4 RID: 14068
		private int detectionConfId_;
	}
}
