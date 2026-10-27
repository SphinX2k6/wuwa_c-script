using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F24 RID: 3876
	[NetMessage(EMessageId.ResetLocationForZRangeNotify)]
	public sealed class ResetLocationForZRangeNotify : IMessage<ResetLocationForZRangeNotify>, IMessage, IEquatable<ResetLocationForZRangeNotify>, IDeepCloneable<ResetLocationForZRangeNotify>, IBufferMessage
	{
		// Token: 0x06014BE2 RID: 84962 RVA: 0x00302899 File Offset: 0x00300A99
		[NullableContext(1)]
		public static ResetLocationForZRangeNotify Create()
		{
			return new ResetLocationForZRangeNotify();
		}

		// Token: 0x170044F0 RID: 17648
		// (get) Token: 0x06014BE3 RID: 84963 RVA: 0x003028A0 File Offset: 0x00300AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044F1 RID: 17649
		// (get) Token: 0x06014BE4 RID: 84964 RVA: 0x003028A3 File Offset: 0x00300AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResetLocationForZRangeNotify.Descriptor;
			}
		}

		// Token: 0x06014BE5 RID: 84965 RVA: 0x003028AA File Offset: 0x00300AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetLocationForZRangeNotify()
		{
		}

		// Token: 0x06014BE6 RID: 84966 RVA: 0x003028B4 File Offset: 0x00300AB4
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

		// Token: 0x06014BE7 RID: 84967 RVA: 0x00302934 File Offset: 0x00300B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetLocationForZRangeNotify Clone()
		{
			return new ResetLocationForZRangeNotify(this);
		}

		// Token: 0x170044F2 RID: 17650
		// (get) Token: 0x06014BE8 RID: 84968 RVA: 0x0030293C File Offset: 0x00300B3C
		// (set) Token: 0x06014BE9 RID: 84969 RVA: 0x00302944 File Offset: 0x00300B44
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

		// Token: 0x170044F3 RID: 17651
		// (get) Token: 0x06014BEA RID: 84970 RVA: 0x0030294D File Offset: 0x00300B4D
		// (set) Token: 0x06014BEB RID: 84971 RVA: 0x00302955 File Offset: 0x00300B55
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

		// Token: 0x170044F4 RID: 17652
		// (get) Token: 0x06014BEC RID: 84972 RVA: 0x0030295E File Offset: 0x00300B5E
		// (set) Token: 0x06014BED RID: 84973 RVA: 0x00302966 File Offset: 0x00300B66
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

		// Token: 0x170044F5 RID: 17653
		// (get) Token: 0x06014BEE RID: 84974 RVA: 0x0030296F File Offset: 0x00300B6F
		// (set) Token: 0x06014BEF RID: 84975 RVA: 0x00302977 File Offset: 0x00300B77
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

		// Token: 0x170044F6 RID: 17654
		// (get) Token: 0x06014BF0 RID: 84976 RVA: 0x00302980 File Offset: 0x00300B80
		// (set) Token: 0x06014BF1 RID: 84977 RVA: 0x00302988 File Offset: 0x00300B88
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

		// Token: 0x06014BF2 RID: 84978 RVA: 0x00302991 File Offset: 0x00300B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResetLocationForZRangeNotify);
		}

		// Token: 0x06014BF3 RID: 84979 RVA: 0x003029A0 File Offset: 0x00300BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResetLocationForZRangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.ResetLocation, other.ResetLocation) && object.Equals(this.Rotation, other.Rotation) && this.NotifyRot == other.NotifyRot && this.ChangeInitPos == other.ChangeInitPos && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014BF4 RID: 84980 RVA: 0x00302A24 File Offset: 0x00300C24
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

		// Token: 0x06014BF5 RID: 84981 RVA: 0x00302AC1 File Offset: 0x00300CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014BF6 RID: 84982 RVA: 0x00302ACE File Offset: 0x00300CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014BF7 RID: 84983 RVA: 0x00302AD8 File Offset: 0x00300CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.NotifyRot)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.NotifyRot);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Rotation);
			}
			if (this.ChangeInitPos)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.ChangeInitPos);
			}
			if (this.resetLocation_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.ResetLocation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014BF8 RID: 84984 RVA: 0x00302B88 File Offset: 0x00300D88
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

		// Token: 0x06014BF9 RID: 84985 RVA: 0x00302C10 File Offset: 0x00300E10
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

		// Token: 0x06014BFA RID: 84986 RVA: 0x00302CCC File Offset: 0x00300ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014BFB RID: 84987 RVA: 0x00302CD8 File Offset: 0x00300ED8
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
				if (num <= 56U)
				{
					if (num == 40U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.NotifyRot = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Rotator();
						}
						input.ReadMessage(this.Rotation);
						continue;
					}
					if (num == 96U)
					{
						this.ChangeInitPos = input.ReadBool();
						continue;
					}
					if (num == 106U)
					{
						if (this.resetLocation_ == null)
						{
							this.ResetLocation = new Vector();
						}
						input.ReadMessage(this.ResetLocation);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007D45 RID: 32069
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D46 RID: 32070
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04007D47 RID: 32071
		private long entityId_;

		// Token: 0x04007D48 RID: 32072
		public const int ResetLocationFieldNumber = 13;

		// Token: 0x04007D49 RID: 32073
		private Vector resetLocation_;

		// Token: 0x04007D4A RID: 32074
		public const int RotationFieldNumber = 11;

		// Token: 0x04007D4B RID: 32075
		private Rotator rotation_;

		// Token: 0x04007D4C RID: 32076
		public const int NotifyRotFieldNumber = 7;

		// Token: 0x04007D4D RID: 32077
		private bool notifyRot_;

		// Token: 0x04007D4E RID: 32078
		public const int ChangeInitPosFieldNumber = 12;

		// Token: 0x04007D4F RID: 32079
		private bool changeInitPos_;
	}
}
