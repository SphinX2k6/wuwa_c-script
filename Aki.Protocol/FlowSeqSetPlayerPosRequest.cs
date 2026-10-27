using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000602 RID: 1538
	[NetMessage(EMessageId.FlowSeqSetPlayerPosRequest)]
	public sealed class FlowSeqSetPlayerPosRequest : IMessage<FlowSeqSetPlayerPosRequest>, IMessage, IEquatable<FlowSeqSetPlayerPosRequest>, IDeepCloneable<FlowSeqSetPlayerPosRequest>, IBufferMessage
	{
		// Token: 0x06008E39 RID: 36409 RVA: 0x001589D1 File Offset: 0x00156BD1
		[NullableContext(1)]
		public static FlowSeqSetPlayerPosRequest Create()
		{
			return new FlowSeqSetPlayerPosRequest();
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x06008E3A RID: 36410 RVA: 0x001589D8 File Offset: 0x00156BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x06008E3B RID: 36411 RVA: 0x001589DB File Offset: 0x00156BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowSeqSetPlayerPosRequest.Descriptor;
			}
		}

		// Token: 0x06008E3C RID: 36412 RVA: 0x001589E2 File Offset: 0x00156BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowSeqSetPlayerPosRequest()
		{
		}

		// Token: 0x06008E3D RID: 36413 RVA: 0x001589EC File Offset: 0x00156BEC
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

		// Token: 0x06008E3E RID: 36414 RVA: 0x00158A64 File Offset: 0x00156C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowSeqSetPlayerPosRequest Clone()
		{
			return new FlowSeqSetPlayerPosRequest(this);
		}

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x06008E3F RID: 36415 RVA: 0x00158A6C File Offset: 0x00156C6C
		// (set) Token: 0x06008E40 RID: 36416 RVA: 0x00158A74 File Offset: 0x00156C74
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

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x06008E41 RID: 36417 RVA: 0x00158A7D File Offset: 0x00156C7D
		// (set) Token: 0x06008E42 RID: 36418 RVA: 0x00158A85 File Offset: 0x00156C85
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

		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x06008E43 RID: 36419 RVA: 0x00158A8E File Offset: 0x00156C8E
		// (set) Token: 0x06008E44 RID: 36420 RVA: 0x00158A96 File Offset: 0x00156C96
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

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x06008E45 RID: 36421 RVA: 0x00158A9F File Offset: 0x00156C9F
		// (set) Token: 0x06008E46 RID: 36422 RVA: 0x00158AA7 File Offset: 0x00156CA7
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

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x06008E47 RID: 36423 RVA: 0x00158AB0 File Offset: 0x00156CB0
		// (set) Token: 0x06008E48 RID: 36424 RVA: 0x00158AB8 File Offset: 0x00156CB8
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

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x06008E49 RID: 36425 RVA: 0x00158AC1 File Offset: 0x00156CC1
		// (set) Token: 0x06008E4A RID: 36426 RVA: 0x00158AC9 File Offset: 0x00156CC9
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

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x06008E4B RID: 36427 RVA: 0x00158AD2 File Offset: 0x00156CD2
		// (set) Token: 0x06008E4C RID: 36428 RVA: 0x00158ADA File Offset: 0x00156CDA
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

		// Token: 0x06008E4D RID: 36429 RVA: 0x00158AE3 File Offset: 0x00156CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowSeqSetPlayerPosRequest);
		}

		// Token: 0x06008E4E RID: 36430 RVA: 0x00158AF4 File Offset: 0x00156CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowSeqSetPlayerPosRequest other)
		{
			return other != null && (other == this || (this.FlowIncId == other.FlowIncId && this.TalkActionId == other.TalkActionId && this.TalkId == other.TalkId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Z, other.Z) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.A, other.A) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E4F RID: 36431 RVA: 0x00158BB8 File Offset: 0x00156DB8
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

		// Token: 0x06008E50 RID: 36432 RVA: 0x00158CA9 File Offset: 0x00156EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008E51 RID: 36433 RVA: 0x00158CB6 File Offset: 0x00156EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E52 RID: 36434 RVA: 0x00158CC0 File Offset: 0x00156EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowIncId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.FlowIncId);
			}
			if (this.TalkActionId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TalkActionId);
			}
			if (this.Y != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Y);
			}
			if (this.Z != 0f)
			{
				output.WriteRawTag(77);
				output.WriteFloat(this.Z);
			}
			if (this.A != 0f)
			{
				output.WriteRawTag(93);
				output.WriteFloat(this.A);
			}
			if (this.X != 0f)
			{
				output.WriteRawTag(109);
				output.WriteFloat(this.X);
			}
			if (this.TalkId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TalkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E53 RID: 36435 RVA: 0x00158DB8 File Offset: 0x00156FB8
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

		// Token: 0x06008E54 RID: 36436 RVA: 0x00158E6C File Offset: 0x0015706C
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

		// Token: 0x06008E55 RID: 36437 RVA: 0x00158F34 File Offset: 0x00157134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E56 RID: 36438 RVA: 0x00158F40 File Offset: 0x00157140
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
				if (num <= 29U)
				{
					if (num == 8U)
					{
						this.FlowIncId = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.TalkActionId = input.ReadInt32();
						continue;
					}
					if (num == 29U)
					{
						this.Y = input.ReadFloat();
						continue;
					}
				}
				else if (num <= 93U)
				{
					if (num == 77U)
					{
						this.Z = input.ReadFloat();
						continue;
					}
					if (num == 93U)
					{
						this.A = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 109U)
					{
						this.X = input.ReadFloat();
						continue;
					}
					if (num == 112U)
					{
						this.TalkId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004542 RID: 17730
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004543 RID: 17731
		public const int FlowIncIdFieldNumber = 1;

		// Token: 0x04004544 RID: 17732
		private long flowIncId_;

		// Token: 0x04004545 RID: 17733
		public const int TalkActionIdFieldNumber = 2;

		// Token: 0x04004546 RID: 17734
		private int talkActionId_;

		// Token: 0x04004547 RID: 17735
		public const int TalkIdFieldNumber = 14;

		// Token: 0x04004548 RID: 17736
		private int talkId_;

		// Token: 0x04004549 RID: 17737
		public const int XFieldNumber = 13;

		// Token: 0x0400454A RID: 17738
		private float x_;

		// Token: 0x0400454B RID: 17739
		public const int YFieldNumber = 3;

		// Token: 0x0400454C RID: 17740
		private float y_;

		// Token: 0x0400454D RID: 17741
		public const int ZFieldNumber = 9;

		// Token: 0x0400454E RID: 17742
		private float z_;

		// Token: 0x0400454F RID: 17743
		public const int AFieldNumber = 11;

		// Token: 0x04004550 RID: 17744
		private float a_;
	}
}
