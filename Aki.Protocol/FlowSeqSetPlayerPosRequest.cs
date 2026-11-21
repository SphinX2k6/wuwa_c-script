using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005ED RID: 1517
	[NetMessage(EMessageId.FlowSeqSetPlayerPosRequest)]
	public sealed class FlowSeqSetPlayerPosRequest : IMessage<FlowSeqSetPlayerPosRequest>, IMessage, IEquatable<FlowSeqSetPlayerPosRequest>, IDeepCloneable<FlowSeqSetPlayerPosRequest>, IBufferMessage
	{
		// Token: 0x06008CD1 RID: 36049 RVA: 0x00155DCC File Offset: 0x00153FCC
		[NullableContext(1)]
		public static FlowSeqSetPlayerPosRequest Create()
		{
			return new FlowSeqSetPlayerPosRequest();
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x06008CD2 RID: 36050 RVA: 0x00155DD3 File Offset: 0x00153FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x06008CD3 RID: 36051 RVA: 0x00155DD6 File Offset: 0x00153FD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowSeqSetPlayerPosRequest.Descriptor;
			}
		}

		// Token: 0x06008CD4 RID: 36052 RVA: 0x00155DDD File Offset: 0x00153FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowSeqSetPlayerPosRequest()
		{
		}

		// Token: 0x06008CD5 RID: 36053 RVA: 0x00155DE8 File Offset: 0x00153FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowSeqSetPlayerPosRequest(FlowSeqSetPlayerPosRequest other) : this()
		{
			this.flowIncId_ = other.flowIncId_;
			this.talkActionId_ = other.talkActionId_;
			this.talkId_ = other.talkId_;
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.z_ = other.z_;
			this.a_ = other.a_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008CD6 RID: 36054 RVA: 0x00155E60 File Offset: 0x00154060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowSeqSetPlayerPosRequest Clone()
		{
			return new FlowSeqSetPlayerPosRequest(this);
		}

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x06008CD7 RID: 36055 RVA: 0x00155E68 File Offset: 0x00154068
		// (set) Token: 0x06008CD8 RID: 36056 RVA: 0x00155E70 File Offset: 0x00154070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FlowIncId
		{
			get
			{
				return this.flowIncId_;
			}
			set
			{
				this.flowIncId_ = value;
			}
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x06008CD9 RID: 36057 RVA: 0x00155E79 File Offset: 0x00154079
		// (set) Token: 0x06008CDA RID: 36058 RVA: 0x00155E81 File Offset: 0x00154081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TalkActionId
		{
			get
			{
				return this.talkActionId_;
			}
			set
			{
				this.talkActionId_ = value;
			}
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x06008CDB RID: 36059 RVA: 0x00155E8A File Offset: 0x0015408A
		// (set) Token: 0x06008CDC RID: 36060 RVA: 0x00155E92 File Offset: 0x00154092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TalkId
		{
			get
			{
				return this.talkId_;
			}
			set
			{
				this.talkId_ = value;
			}
		}

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x06008CDD RID: 36061 RVA: 0x00155E9B File Offset: 0x0015409B
		// (set) Token: 0x06008CDE RID: 36062 RVA: 0x00155EA3 File Offset: 0x001540A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float X
		{
			get
			{
				return this.x_;
			}
			set
			{
				this.x_ = value;
			}
		}

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x06008CDF RID: 36063 RVA: 0x00155EAC File Offset: 0x001540AC
		// (set) Token: 0x06008CE0 RID: 36064 RVA: 0x00155EB4 File Offset: 0x001540B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Y
		{
			get
			{
				return this.y_;
			}
			set
			{
				this.y_ = value;
			}
		}

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x06008CE1 RID: 36065 RVA: 0x00155EBD File Offset: 0x001540BD
		// (set) Token: 0x06008CE2 RID: 36066 RVA: 0x00155EC5 File Offset: 0x001540C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Z
		{
			get
			{
				return this.z_;
			}
			set
			{
				this.z_ = value;
			}
		}

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x06008CE3 RID: 36067 RVA: 0x00155ECE File Offset: 0x001540CE
		// (set) Token: 0x06008CE4 RID: 36068 RVA: 0x00155ED6 File Offset: 0x001540D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float A
		{
			get
			{
				return this.a_;
			}
			set
			{
				this.a_ = value;
			}
		}

		// Token: 0x06008CE5 RID: 36069 RVA: 0x00155EDF File Offset: 0x001540DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowSeqSetPlayerPosRequest);
		}

		// Token: 0x06008CE6 RID: 36070 RVA: 0x00155EF0 File Offset: 0x001540F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowSeqSetPlayerPosRequest other)
		{
			return other != null && (other == this || (this.FlowIncId == other.FlowIncId && this.TalkActionId == other.TalkActionId && this.TalkId == other.TalkId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Z, other.Z) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.A, other.A) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008CE7 RID: 36071 RVA: 0x00155FB4 File Offset: 0x001541B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlowIncId != 0L)
			{
				num ^= this.FlowIncId.GetHashCode();
			}
			if (this.TalkActionId != 0)
			{
				num ^= this.TalkActionId.GetHashCode();
			}
			if (this.TalkId != 0)
			{
				num ^= this.TalkId.GetHashCode();
			}
			if (this.X != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.X);
			}
			if (this.Y != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Y);
			}
			if (this.Z != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Z);
			}
			if (this.A != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.A);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008CE8 RID: 36072 RVA: 0x001560A5 File Offset: 0x001542A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008CE9 RID: 36073 RVA: 0x001560B2 File Offset: 0x001542B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008CEA RID: 36074 RVA: 0x001560BC File Offset: 0x001542BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalkId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TalkId);
			}
			if (this.Z != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Z);
			}
			if (this.TalkActionId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TalkActionId);
			}
			if (this.FlowIncId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.FlowIncId);
			}
			if (this.X != 0f)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.X);
			}
			if (this.Y != 0f)
			{
				output.WriteRawTag(109);
				output.WriteFloat(this.Y);
			}
			if (this.A != 0f)
			{
				output.WriteRawTag(125);
				output.WriteFloat(this.A);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008CEB RID: 36075 RVA: 0x001561B4 File Offset: 0x001543B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlowIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FlowIncId);
			}
			if (this.TalkActionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TalkActionId);
			}
			if (this.TalkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TalkId);
			}
			if (this.X != 0f)
			{
				num += 5;
			}
			if (this.Y != 0f)
			{
				num += 5;
			}
			if (this.Z != 0f)
			{
				num += 5;
			}
			if (this.A != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008CEC RID: 36076 RVA: 0x00156268 File Offset: 0x00154468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowSeqSetPlayerPosRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlowIncId != 0L)
			{
				this.FlowIncId = other.FlowIncId;
			}
			if (other.TalkActionId != 0)
			{
				this.TalkActionId = other.TalkActionId;
			}
			if (other.TalkId != 0)
			{
				this.TalkId = other.TalkId;
			}
			if (other.X != 0f)
			{
				this.X = other.X;
			}
			if (other.Y != 0f)
			{
				this.Y = other.Y;
			}
			if (other.Z != 0f)
			{
				this.Z = other.Z;
			}
			if (other.A != 0f)
			{
				this.A = other.A;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008CED RID: 36077 RVA: 0x00156330 File Offset: 0x00154530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008CEE RID: 36078 RVA: 0x0015633C File Offset: 0x0015453C
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
					if (num == 8U)
					{
						this.TalkId = input.ReadInt32();
						continue;
					}
					if (num == 29U)
					{
						this.Z = input.ReadFloat();
						continue;
					}
					if (num == 48U)
					{
						this.TalkActionId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 101U)
				{
					if (num == 56U)
					{
						this.FlowIncId = input.ReadInt64();
						continue;
					}
					if (num == 101U)
					{
						this.X = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 109U)
					{
						this.Y = input.ReadFloat();
						continue;
					}
					if (num == 125U)
					{
						this.A = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004538 RID: 17720
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004539 RID: 17721
		public const int FlowIncIdFieldNumber = 7;

		// Token: 0x0400453A RID: 17722
		private long flowIncId_;

		// Token: 0x0400453B RID: 17723
		public const int TalkActionIdFieldNumber = 6;

		// Token: 0x0400453C RID: 17724
		private int talkActionId_;

		// Token: 0x0400453D RID: 17725
		public const int TalkIdFieldNumber = 1;

		// Token: 0x0400453E RID: 17726
		private int talkId_;

		// Token: 0x0400453F RID: 17727
		public const int XFieldNumber = 12;

		// Token: 0x04004540 RID: 17728
		private float x_;

		// Token: 0x04004541 RID: 17729
		public const int YFieldNumber = 13;

		// Token: 0x04004542 RID: 17730
		private float y_;

		// Token: 0x04004543 RID: 17731
		public const int ZFieldNumber = 3;

		// Token: 0x04004544 RID: 17732
		private float z_;

		// Token: 0x04004545 RID: 17733
		public const int AFieldNumber = 15;

		// Token: 0x04004546 RID: 17734
		private float a_;
	}
}
