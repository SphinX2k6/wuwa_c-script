using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F14 RID: 3860
	[NetMessage(EMessageId.ResetLocationForZRangeNotify)]
	public sealed class ResetLocationForZRangeNotify : IMessage<ResetLocationForZRangeNotify>, IMessage, IEquatable<ResetLocationForZRangeNotify>, IDeepCloneable<ResetLocationForZRangeNotify>, IBufferMessage
	{
		// Token: 0x06014AFD RID: 84733 RVA: 0x003011DD File Offset: 0x002FF3DD
		[NullableContext(1)]
		public static ResetLocationForZRangeNotify Create()
		{
			return new ResetLocationForZRangeNotify();
		}

		// Token: 0x170044C6 RID: 17606
		// (get) Token: 0x06014AFE RID: 84734 RVA: 0x003011E4 File Offset: 0x002FF3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044C7 RID: 17607
		// (get) Token: 0x06014AFF RID: 84735 RVA: 0x003011E7 File Offset: 0x002FF3E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResetLocationForZRangeNotify.Descriptor;
			}
		}

		// Token: 0x06014B00 RID: 84736 RVA: 0x003011EE File Offset: 0x002FF3EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetLocationForZRangeNotify()
		{
		}

		// Token: 0x06014B01 RID: 84737 RVA: 0x003011F8 File Offset: 0x002FF3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetLocationForZRangeNotify(ResetLocationForZRangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.resetLocation_ = ((other.resetLocation_ != null) ? other.resetLocation_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this.notifyRot_ = other.notifyRot_;
			this.changeInitPos_ = other.changeInitPos_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014B02 RID: 84738 RVA: 0x00301278 File Offset: 0x002FF478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetLocationForZRangeNotify Clone()
		{
			return new ResetLocationForZRangeNotify(this);
		}

		// Token: 0x170044C8 RID: 17608
		// (get) Token: 0x06014B03 RID: 84739 RVA: 0x00301280 File Offset: 0x002FF480
		// (set) Token: 0x06014B04 RID: 84740 RVA: 0x00301288 File Offset: 0x002FF488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170044C9 RID: 17609
		// (get) Token: 0x06014B05 RID: 84741 RVA: 0x00301291 File Offset: 0x002FF491
		// (set) Token: 0x06014B06 RID: 84742 RVA: 0x00301299 File Offset: 0x002FF499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector ResetLocation
		{
			get
			{
				return this.resetLocation_;
			}
			set
			{
				this.resetLocation_ = value;
			}
		}

		// Token: 0x170044CA RID: 17610
		// (get) Token: 0x06014B07 RID: 84743 RVA: 0x003012A2 File Offset: 0x002FF4A2
		// (set) Token: 0x06014B08 RID: 84744 RVA: 0x003012AA File Offset: 0x002FF4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rotation
		{
			get
			{
				return this.rotation_;
			}
			set
			{
				this.rotation_ = value;
			}
		}

		// Token: 0x170044CB RID: 17611
		// (get) Token: 0x06014B09 RID: 84745 RVA: 0x003012B3 File Offset: 0x002FF4B3
		// (set) Token: 0x06014B0A RID: 84746 RVA: 0x003012BB File Offset: 0x002FF4BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NotifyRot
		{
			get
			{
				return this.notifyRot_;
			}
			set
			{
				this.notifyRot_ = value;
			}
		}

		// Token: 0x170044CC RID: 17612
		// (get) Token: 0x06014B0B RID: 84747 RVA: 0x003012C4 File Offset: 0x002FF4C4
		// (set) Token: 0x06014B0C RID: 84748 RVA: 0x003012CC File Offset: 0x002FF4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ChangeInitPos
		{
			get
			{
				return this.changeInitPos_;
			}
			set
			{
				this.changeInitPos_ = value;
			}
		}

		// Token: 0x06014B0D RID: 84749 RVA: 0x003012D5 File Offset: 0x002FF4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResetLocationForZRangeNotify);
		}

		// Token: 0x06014B0E RID: 84750 RVA: 0x003012E4 File Offset: 0x002FF4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResetLocationForZRangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.ResetLocation, other.ResetLocation) && object.Equals(this.Rotation, other.Rotation) && this.NotifyRot == other.NotifyRot && this.ChangeInitPos == other.ChangeInitPos && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014B0F RID: 84751 RVA: 0x00301368 File Offset: 0x002FF568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.resetLocation_ != null)
			{
				num ^= this.ResetLocation.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this.NotifyRot)
			{
				num ^= this.NotifyRot.GetHashCode();
			}
			if (this.ChangeInitPos)
			{
				num ^= this.ChangeInitPos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014B10 RID: 84752 RVA: 0x00301405 File Offset: 0x002FF605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014B11 RID: 84753 RVA: 0x00301412 File Offset: 0x002FF612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014B12 RID: 84754 RVA: 0x0030141C File Offset: 0x002FF61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rotation_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Rotation);
			}
			if (this.resetLocation_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.ResetLocation);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this.NotifyRot)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.NotifyRot);
			}
			if (this.ChangeInitPos)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.ChangeInitPos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014B13 RID: 84755 RVA: 0x003014CC File Offset: 0x002FF6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.resetLocation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ResetLocation);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this.NotifyRot)
			{
				num += 2;
			}
			if (this.ChangeInitPos)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014B14 RID: 84756 RVA: 0x00301554 File Offset: 0x002FF754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResetLocationForZRangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.resetLocation_ != null)
			{
				if (this.resetLocation_ == null)
				{
					this.ResetLocation = new Vector();
				}
				this.ResetLocation.MergeFrom(other.ResetLocation);
			}
			if (other.rotation_ != null)
			{
				if (this.rotation_ == null)
				{
					this.Rotation = new Rotator();
				}
				this.Rotation.MergeFrom(other.Rotation);
			}
			if (other.NotifyRot)
			{
				this.NotifyRot = other.NotifyRot;
			}
			if (other.ChangeInitPos)
			{
				this.ChangeInitPos = other.ChangeInitPos;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014B15 RID: 84757 RVA: 0x00301610 File Offset: 0x002FF810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014B16 RID: 84758 RVA: 0x0030161C File Offset: 0x002FF81C
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
				if (num <= 66U)
				{
					if (num == 34U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Rotator();
						}
						input.ReadMessage(this.Rotation);
						continue;
					}
					if (num == 66U)
					{
						if (this.resetLocation_ == null)
						{
							this.ResetLocation = new Vector();
						}
						input.ReadMessage(this.ResetLocation);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 88U)
					{
						this.NotifyRot = input.ReadBool();
						continue;
					}
					if (num == 104U)
					{
						this.ChangeInitPos = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007D6F RID: 32111
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D70 RID: 32112
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04007D71 RID: 32113
		private long entityId_;

		// Token: 0x04007D72 RID: 32114
		public const int ResetLocationFieldNumber = 8;

		// Token: 0x04007D73 RID: 32115
		private Vector resetLocation_;

		// Token: 0x04007D74 RID: 32116
		public const int RotationFieldNumber = 4;

		// Token: 0x04007D75 RID: 32117
		private Rotator rotation_;

		// Token: 0x04007D76 RID: 32118
		public const int NotifyRotFieldNumber = 11;

		// Token: 0x04007D77 RID: 32119
		private bool notifyRot_;

		// Token: 0x04007D78 RID: 32120
		public const int ChangeInitPosFieldNumber = 13;

		// Token: 0x04007D79 RID: 32121
		private bool changeInitPos_;
	}
}
