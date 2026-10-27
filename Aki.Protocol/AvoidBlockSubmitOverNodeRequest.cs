using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000136 RID: 310
	[NetMessage(EMessageId.AvoidBlockSubmitOverNodeRequest)]
	public sealed class AvoidBlockSubmitOverNodeRequest : IMessage<AvoidBlockSubmitOverNodeRequest>, IMessage, IEquatable<AvoidBlockSubmitOverNodeRequest>, IDeepCloneable<AvoidBlockSubmitOverNodeRequest>, IBufferMessage
	{
		// Token: 0x060028AB RID: 10411 RVA: 0x0006B0B3 File Offset: 0x000692B3
		[NullableContext(1)]
		public static AvoidBlockSubmitOverNodeRequest Create()
		{
			return new AvoidBlockSubmitOverNodeRequest();
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060028AC RID: 10412 RVA: 0x0006B0BA File Offset: 0x000692BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x0006B0BD File Offset: 0x000692BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvoidBlockSubmitOverNodeRequest.Descriptor;
			}
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x0006B0C4 File Offset: 0x000692C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockSubmitOverNodeRequest()
		{
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x0006B0CC File Offset: 0x000692CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockSubmitOverNodeRequest(AvoidBlockSubmitOverNodeRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.win_ = other.win_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x0006B12C File Offset: 0x0006932C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockSubmitOverNodeRequest Clone()
		{
			return new AvoidBlockSubmitOverNodeRequest(this);
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x0006B134 File Offset: 0x00069334
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x0006B13C File Offset: 0x0006933C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeOwnerId
		{
			get
			{
				return this.treeOwnerId_;
			}
			set
			{
				this.treeOwnerId_ = value;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x0006B145 File Offset: 0x00069345
		// (set) Token: 0x060028B4 RID: 10420 RVA: 0x0006B14D File Offset: 0x0006934D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x0006B156 File Offset: 0x00069356
		// (set) Token: 0x060028B6 RID: 10422 RVA: 0x0006B15E File Offset: 0x0006935E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NodeId
		{
			get
			{
				return this.nodeId_;
			}
			set
			{
				this.nodeId_ = value;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060028B7 RID: 10423 RVA: 0x0006B167 File Offset: 0x00069367
		// (set) Token: 0x060028B8 RID: 10424 RVA: 0x0006B16F File Offset: 0x0006936F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Win
		{
			get
			{
				return this.win_;
			}
			set
			{
				this.win_ = value;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x0006B178 File Offset: 0x00069378
		// (set) Token: 0x060028BA RID: 10426 RVA: 0x0006B180 File Offset: 0x00069380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x0006B189 File Offset: 0x00069389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvoidBlockSubmitOverNodeRequest);
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x0006B198 File Offset: 0x00069398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvoidBlockSubmitOverNodeRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.Win == other.Win && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x0006B214 File Offset: 0x00069414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeOwnerId != 0)
			{
				num ^= this.TreeOwnerId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this.NodeId != 0)
			{
				num ^= this.NodeId.GetHashCode();
			}
			if (this.Win)
			{
				num ^= this.Win.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x0006B2B7 File Offset: 0x000694B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x0006B2C4 File Offset: 0x000694C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x0006B2D0 File Offset: 0x000694D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.Win)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.Win);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Score);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.NodeId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x0006B380 File Offset: 0x00069580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this.NodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NodeId);
			}
			if (this.Win)
			{
				num += 2;
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x0006B414 File Offset: 0x00069614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvoidBlockSubmitOverNodeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeOwnerId != 0)
			{
				this.TreeOwnerId = other.TreeOwnerId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			if (other.NodeId != 0)
			{
				this.NodeId = other.NodeId;
			}
			if (other.Win)
			{
				this.Win = other.Win;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x0006B4A0 File Offset: 0x000696A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x0006B4AC File Offset: 0x000696AC
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
				if (num <= 64U)
				{
					if (num == 56U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Win = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040026BA RID: 9914
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026BB RID: 9915
		public const int TreeOwnerIdFieldNumber = 7;

		// Token: 0x040026BC RID: 9916
		private int treeOwnerId_;

		// Token: 0x040026BD RID: 9917
		public const int TreeIncIdFieldNumber = 15;

		// Token: 0x040026BE RID: 9918
		private long treeIncId_;

		// Token: 0x040026BF RID: 9919
		public const int NodeIdFieldNumber = 12;

		// Token: 0x040026C0 RID: 9920
		private int nodeId_;

		// Token: 0x040026C1 RID: 9921
		public const int WinFieldNumber = 8;

		// Token: 0x040026C2 RID: 9922
		private bool win_;

		// Token: 0x040026C3 RID: 9923
		public const int ScoreFieldNumber = 9;

		// Token: 0x040026C4 RID: 9924
		private int score_;
	}
}
