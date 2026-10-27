using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200149D RID: 5277
	[NetMessage(EMessageId.UpdateNodeProgressNotify)]
	public sealed class UpdateNodeProgressNotify : IMessage<UpdateNodeProgressNotify>, IMessage, IEquatable<UpdateNodeProgressNotify>, IDeepCloneable<UpdateNodeProgressNotify>, IBufferMessage
	{
		// Token: 0x0601BE93 RID: 114323 RVA: 0x00408CD0 File Offset: 0x00406ED0
		[NullableContext(1)]
		public static UpdateNodeProgressNotify Create()
		{
			return new UpdateNodeProgressNotify();
		}

		// Token: 0x17005E0F RID: 24079
		// (get) Token: 0x0601BE94 RID: 114324 RVA: 0x00408CD7 File Offset: 0x00406ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E10 RID: 24080
		// (get) Token: 0x0601BE95 RID: 114325 RVA: 0x00408CDA File Offset: 0x00406EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateNodeProgressNotify.Descriptor;
			}
		}

		// Token: 0x0601BE96 RID: 114326 RVA: 0x00408CE1 File Offset: 0x00406EE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateNodeProgressNotify()
		{
		}

		// Token: 0x0601BE97 RID: 114327 RVA: 0x00408CEC File Offset: 0x00406EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateNodeProgressNotify(UpdateNodeProgressNotify other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.progress_ = ((other.progress_ != null) ? other.progress_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BE98 RID: 114328 RVA: 0x00408D50 File Offset: 0x00406F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateNodeProgressNotify Clone()
		{
			return new UpdateNodeProgressNotify(this);
		}

		// Token: 0x17005E11 RID: 24081
		// (get) Token: 0x0601BE99 RID: 114329 RVA: 0x00408D58 File Offset: 0x00406F58
		// (set) Token: 0x0601BE9A RID: 114330 RVA: 0x00408D60 File Offset: 0x00406F60
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

		// Token: 0x17005E12 RID: 24082
		// (get) Token: 0x0601BE9B RID: 114331 RVA: 0x00408D69 File Offset: 0x00406F69
		// (set) Token: 0x0601BE9C RID: 114332 RVA: 0x00408D71 File Offset: 0x00406F71
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

		// Token: 0x17005E13 RID: 24083
		// (get) Token: 0x0601BE9D RID: 114333 RVA: 0x00408D7A File Offset: 0x00406F7A
		// (set) Token: 0x0601BE9E RID: 114334 RVA: 0x00408D82 File Offset: 0x00406F82
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

		// Token: 0x17005E14 RID: 24084
		// (get) Token: 0x0601BE9F RID: 114335 RVA: 0x00408D8B File Offset: 0x00406F8B
		// (set) Token: 0x0601BEA0 RID: 114336 RVA: 0x00408D93 File Offset: 0x00406F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeProgress Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x0601BEA1 RID: 114337 RVA: 0x00408D9C File Offset: 0x00406F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateNodeProgressNotify);
		}

		// Token: 0x0601BEA2 RID: 114338 RVA: 0x00408DAC File Offset: 0x00406FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateNodeProgressNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && object.Equals(this.Progress, other.Progress) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BEA3 RID: 114339 RVA: 0x00408E1C File Offset: 0x0040701C
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
			if (this.progress_ != null)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BEA4 RID: 114340 RVA: 0x00408EA3 File Offset: 0x004070A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BEA5 RID: 114341 RVA: 0x00408EB0 File Offset: 0x004070B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BEA6 RID: 114342 RVA: 0x00408EBC File Offset: 0x004070BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.NodeId);
			}
			if (this.progress_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Progress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BEA7 RID: 114343 RVA: 0x00408F50 File Offset: 0x00407150
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
			if (this.progress_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Progress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BEA8 RID: 114344 RVA: 0x00408FD8 File Offset: 0x004071D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateNodeProgressNotify other)
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
			if (other.progress_ != null)
			{
				if (this.progress_ == null)
				{
					this.Progress = new ChildQuestNodeProgress();
				}
				this.Progress.MergeFrom(other.Progress);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BEA9 RID: 114345 RVA: 0x00409068 File Offset: 0x00407268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BEAA RID: 114346 RVA: 0x00409074 File Offset: 0x00407274
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
				if (num <= 80U)
				{
					if (num == 24U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 80U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 106U)
					{
						if (this.progress_ == null)
						{
							this.Progress = new ChildQuestNodeProgress();
						}
						input.ReadMessage(this.Progress);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A066 RID: 41062
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A067 RID: 41063
		public const int TreeOwnerIdFieldNumber = 10;

		// Token: 0x0400A068 RID: 41064
		private int treeOwnerId_;

		// Token: 0x0400A069 RID: 41065
		public const int TreeIncIdFieldNumber = 3;

		// Token: 0x0400A06A RID: 41066
		private long treeIncId_;

		// Token: 0x0400A06B RID: 41067
		public const int NodeIdFieldNumber = 12;

		// Token: 0x0400A06C RID: 41068
		private int nodeId_;

		// Token: 0x0400A06D RID: 41069
		public const int ProgressFieldNumber = 13;

		// Token: 0x0400A06E RID: 41070
		private ChildQuestNodeProgress progress_;
	}
}
