using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B1 RID: 1713
	[NetMessage(EMessageId.GetDetectionTargetRequest)]
	public sealed class GetDetectionTargetRequest : IMessage<GetDetectionTargetRequest>, IMessage, IEquatable<GetDetectionTargetRequest>, IDeepCloneable<GetDetectionTargetRequest>, IBufferMessage
	{
		// Token: 0x06009D37 RID: 40247 RVA: 0x0017E13C File Offset: 0x0017C33C
		[NullableContext(1)]
		public static GetDetectionTargetRequest Create()
		{
			return new GetDetectionTargetRequest();
		}

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x06009D38 RID: 40248 RVA: 0x0017E143 File Offset: 0x0017C343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x06009D39 RID: 40249 RVA: 0x0017E146 File Offset: 0x0017C346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDetectionTargetRequest.Descriptor;
			}
		}

		// Token: 0x06009D3A RID: 40250 RVA: 0x0017E14D File Offset: 0x0017C34D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionTargetRequest()
		{
		}

		// Token: 0x06009D3B RID: 40251 RVA: 0x0017E155 File Offset: 0x0017C355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionTargetRequest(GetDetectionTargetRequest other) : this()
		{
			this.detectionId_ = other.detectionId_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D3C RID: 40252 RVA: 0x0017E186 File Offset: 0x0017C386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionTargetRequest Clone()
		{
			return new GetDetectionTargetRequest(this);
		}

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x06009D3D RID: 40253 RVA: 0x0017E18E File Offset: 0x0017C38E
		// (set) Token: 0x06009D3E RID: 40254 RVA: 0x0017E196 File Offset: 0x0017C396
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

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x06009D3F RID: 40255 RVA: 0x0017E19F File Offset: 0x0017C39F
		// (set) Token: 0x06009D40 RID: 40256 RVA: 0x0017E1A7 File Offset: 0x0017C3A7
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

		// Token: 0x06009D41 RID: 40257 RVA: 0x0017E1B0 File Offset: 0x0017C3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDetectionTargetRequest);
		}

		// Token: 0x06009D42 RID: 40258 RVA: 0x0017E1BE File Offset: 0x0017C3BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetDetectionTargetRequest other)
		{
			return other != null && (other == this || (this.DetectionId == other.DetectionId && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D43 RID: 40259 RVA: 0x0017E1FC File Offset: 0x0017C3FC
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

		// Token: 0x06009D44 RID: 40260 RVA: 0x0017E25A File Offset: 0x0017C45A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009D45 RID: 40261 RVA: 0x0017E267 File Offset: 0x0017C467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D46 RID: 40262 RVA: 0x0017E270 File Offset: 0x0017C470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DetectionId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.DetectionId);
			}
			if (this.Type != DetectionType.NormalMonster)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D47 RID: 40263 RVA: 0x0017E2CC File Offset: 0x0017C4CC
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

		// Token: 0x06009D48 RID: 40264 RVA: 0x0017E324 File Offset: 0x0017C524
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

		// Token: 0x06009D49 RID: 40265 RVA: 0x0017E374 File Offset: 0x0017C574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D4A RID: 40266 RVA: 0x0017E380 File Offset: 0x0017C580
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
				if (num != 48U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Type = (DetectionType)input.ReadEnum();
					}
				}
				else
				{
					this.DetectionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004A2E RID: 18990
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A2F RID: 18991
		public const int DetectionIdFieldNumber = 6;

		// Token: 0x04004A30 RID: 18992
		private int detectionId_;

		// Token: 0x04004A31 RID: 18993
		public const int TypeFieldNumber = 10;

		// Token: 0x04004A32 RID: 18994
		private DetectionType type_;
	}
}
