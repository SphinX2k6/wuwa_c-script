using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C0 RID: 1216
	public sealed class EntitySimplyMoveInfo : IMessage<EntitySimplyMoveInfo>, IMessage, IEquatable<EntitySimplyMoveInfo>, IDeepCloneable<EntitySimplyMoveInfo>, IBufferMessage
	{
		// Token: 0x060073A8 RID: 29608 RVA: 0x0011B700 File Offset: 0x00119900
		[NullableContext(1)]
		public static EntitySimplyMoveInfo Create()
		{
			return new EntitySimplyMoveInfo();
		}

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x060073A9 RID: 29609 RVA: 0x0011B707 File Offset: 0x00119907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntitySimplyMoveInfo> Parser
		{
			get
			{
				return EntitySimplyMoveInfo._parser;
			}
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x060073AA RID: 29610 RVA: 0x0011B70E File Offset: 0x0011990E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x060073AB RID: 29611 RVA: 0x0011B711 File Offset: 0x00119911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntitySimplyMoveInfo.Descriptor;
			}
		}

		// Token: 0x060073AC RID: 29612 RVA: 0x0011B718 File Offset: 0x00119918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySimplyMoveInfo()
		{
		}

		// Token: 0x060073AD RID: 29613 RVA: 0x0011B720 File Offset: 0x00119920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySimplyMoveInfo(EntitySimplyMoveInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060073AE RID: 29614 RVA: 0x0011B788 File Offset: 0x00119988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySimplyMoveInfo Clone()
		{
			return new EntitySimplyMoveInfo(this);
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x060073AF RID: 29615 RVA: 0x0011B790 File Offset: 0x00119990
		// (set) Token: 0x060073B0 RID: 29616 RVA: 0x0011B798 File Offset: 0x00119998
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

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x060073B1 RID: 29617 RVA: 0x0011B7A1 File Offset: 0x001199A1
		// (set) Token: 0x060073B2 RID: 29618 RVA: 0x0011B7A9 File Offset: 0x001199A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x060073B3 RID: 29619 RVA: 0x0011B7B2 File Offset: 0x001199B2
		// (set) Token: 0x060073B4 RID: 29620 RVA: 0x0011B7BA File Offset: 0x001199BA
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

		// Token: 0x060073B5 RID: 29621 RVA: 0x0011B7C3 File Offset: 0x001199C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntitySimplyMoveInfo);
		}

		// Token: 0x060073B6 RID: 29622 RVA: 0x0011B7D4 File Offset: 0x001199D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntitySimplyMoveInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060073B7 RID: 29623 RVA: 0x0011B838 File Offset: 0x00119A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060073B8 RID: 29624 RVA: 0x0011B8A3 File Offset: 0x00119AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x0011B8B0 File Offset: 0x00119AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060073BA RID: 29626 RVA: 0x0011B8BC File Offset: 0x00119ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Location);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060073BB RID: 29627 RVA: 0x0011B930 File Offset: 0x00119B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060073BC RID: 29628 RVA: 0x0011B9A0 File Offset: 0x00119BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntitySimplyMoveInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			if (other.rotation_ != null)
			{
				if (this.rotation_ == null)
				{
					this.Rotation = new Rotator();
				}
				this.Rotation.MergeFrom(other.Rotation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060073BD RID: 29629 RVA: 0x0011BA34 File Offset: 0x00119C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073BE RID: 29630 RVA: 0x0011BA40 File Offset: 0x00119C40
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.rotation_ == null)
							{
								this.Rotation = new Rotator();
							}
							input.ReadMessage(this.Rotation);
						}
					}
					else
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003D31 RID: 15665
		private static readonly MessageParser<EntitySimplyMoveInfo> _parser = new MessageParser<EntitySimplyMoveInfo>(() => new EntitySimplyMoveInfo());

		// Token: 0x04003D32 RID: 15666
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D33 RID: 15667
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003D34 RID: 15668
		private long entityId_;

		// Token: 0x04003D35 RID: 15669
		public const int LocationFieldNumber = 2;

		// Token: 0x04003D36 RID: 15670
		private Vector location_;

		// Token: 0x04003D37 RID: 15671
		public const int RotationFieldNumber = 3;

		// Token: 0x04003D38 RID: 15672
		private Rotator rotation_;
	}
}
