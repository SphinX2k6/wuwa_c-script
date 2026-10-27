using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F1D RID: 3869
	[NetMessage(EMessageId.ReplaceVehicleEntityNotify)]
	public sealed class ReplaceVehicleEntityNotify : IMessage<ReplaceVehicleEntityNotify>, IMessage, IEquatable<ReplaceVehicleEntityNotify>, IDeepCloneable<ReplaceVehicleEntityNotify>, IBufferMessage
	{
		// Token: 0x06014B4E RID: 84814 RVA: 0x00301215 File Offset: 0x002FF415
		[NullableContext(1)]
		public static ReplaceVehicleEntityNotify Create()
		{
			return new ReplaceVehicleEntityNotify();
		}

		// Token: 0x170044D0 RID: 17616
		// (get) Token: 0x06014B4F RID: 84815 RVA: 0x0030121C File Offset: 0x002FF41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044D1 RID: 17617
		// (get) Token: 0x06014B50 RID: 84816 RVA: 0x0030121F File Offset: 0x002FF41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReplaceVehicleEntityNotify.Descriptor;
			}
		}

		// Token: 0x06014B51 RID: 84817 RVA: 0x00301226 File Offset: 0x002FF426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplaceVehicleEntityNotify()
		{
		}

		// Token: 0x06014B52 RID: 84818 RVA: 0x00301230 File Offset: 0x002FF430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplaceVehicleEntityNotify(ReplaceVehicleEntityNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this.isReplace_ = other.isReplace_;
			this.gravityDirection_ = ((other.gravityDirection_ != null) ? other.gravityDirection_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014B53 RID: 84819 RVA: 0x003012C0 File Offset: 0x002FF4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplaceVehicleEntityNotify Clone()
		{
			return new ReplaceVehicleEntityNotify(this);
		}

		// Token: 0x170044D2 RID: 17618
		// (get) Token: 0x06014B54 RID: 84820 RVA: 0x003012C8 File Offset: 0x002FF4C8
		// (set) Token: 0x06014B55 RID: 84821 RVA: 0x003012D0 File Offset: 0x002FF4D0
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

		// Token: 0x170044D3 RID: 17619
		// (get) Token: 0x06014B56 RID: 84822 RVA: 0x003012D9 File Offset: 0x002FF4D9
		// (set) Token: 0x06014B57 RID: 84823 RVA: 0x003012E1 File Offset: 0x002FF4E1
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

		// Token: 0x170044D4 RID: 17620
		// (get) Token: 0x06014B58 RID: 84824 RVA: 0x003012EA File Offset: 0x002FF4EA
		// (set) Token: 0x06014B59 RID: 84825 RVA: 0x003012F2 File Offset: 0x002FF4F2
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

		// Token: 0x170044D5 RID: 17621
		// (get) Token: 0x06014B5A RID: 84826 RVA: 0x003012FB File Offset: 0x002FF4FB
		// (set) Token: 0x06014B5B RID: 84827 RVA: 0x00301303 File Offset: 0x002FF503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReplace
		{
			get
			{
				return this.isReplace_;
			}
			set
			{
				this.isReplace_ = value;
			}
		}

		// Token: 0x170044D6 RID: 17622
		// (get) Token: 0x06014B5C RID: 84828 RVA: 0x0030130C File Offset: 0x002FF50C
		// (set) Token: 0x06014B5D RID: 84829 RVA: 0x00301314 File Offset: 0x002FF514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector GravityDirection
		{
			get
			{
				return this.gravityDirection_;
			}
			set
			{
				this.gravityDirection_ = value;
			}
		}

		// Token: 0x06014B5E RID: 84830 RVA: 0x0030131D File Offset: 0x002FF51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReplaceVehicleEntityNotify);
		}

		// Token: 0x06014B5F RID: 84831 RVA: 0x0030132C File Offset: 0x002FF52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReplaceVehicleEntityNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && this.IsReplace == other.IsReplace && object.Equals(this.GravityDirection, other.GravityDirection) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014B60 RID: 84832 RVA: 0x003013B4 File Offset: 0x002FF5B4
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
			if (this.IsReplace)
			{
				num ^= this.IsReplace.GetHashCode();
			}
			if (this.gravityDirection_ != null)
			{
				num ^= this.GravityDirection.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014B61 RID: 84833 RVA: 0x0030144E File Offset: 0x002FF64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014B62 RID: 84834 RVA: 0x0030145B File Offset: 0x002FF65B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014B63 RID: 84835 RVA: 0x00301464 File Offset: 0x002FF664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Location);
			}
			if (this.gravityDirection_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.GravityDirection);
			}
			if (this.IsReplace)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsReplace);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014B64 RID: 84836 RVA: 0x00301514 File Offset: 0x002FF714
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
			if (this.IsReplace)
			{
				num += 2;
			}
			if (this.gravityDirection_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GravityDirection);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014B65 RID: 84837 RVA: 0x003015A8 File Offset: 0x002FF7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReplaceVehicleEntityNotify other)
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
			if (other.IsReplace)
			{
				this.IsReplace = other.IsReplace;
			}
			if (other.gravityDirection_ != null)
			{
				if (this.gravityDirection_ == null)
				{
					this.GravityDirection = new Vector();
				}
				this.GravityDirection.MergeFrom(other.GravityDirection);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014B66 RID: 84838 RVA: 0x0030167C File Offset: 0x002FF87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014B67 RID: 84839 RVA: 0x00301688 File Offset: 0x002FF888
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
				if (num <= 74U)
				{
					if (num == 40U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 74U)
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						if (this.gravityDirection_ == null)
						{
							this.GravityDirection = new Vector();
						}
						input.ReadMessage(this.GravityDirection);
						continue;
					}
					if (num == 88U)
					{
						this.IsReplace = input.ReadBool();
						continue;
					}
					if (num == 114U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Rotator();
						}
						input.ReadMessage(this.Rotation);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007D1A RID: 32026
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D1B RID: 32027
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04007D1C RID: 32028
		private long entityId_;

		// Token: 0x04007D1D RID: 32029
		public const int LocationFieldNumber = 9;

		// Token: 0x04007D1E RID: 32030
		private Vector location_;

		// Token: 0x04007D1F RID: 32031
		public const int RotationFieldNumber = 14;

		// Token: 0x04007D20 RID: 32032
		private Rotator rotation_;

		// Token: 0x04007D21 RID: 32033
		public const int IsReplaceFieldNumber = 11;

		// Token: 0x04007D22 RID: 32034
		private bool isReplace_;

		// Token: 0x04007D23 RID: 32035
		public const int GravityDirectionFieldNumber = 10;

		// Token: 0x04007D24 RID: 32036
		private Vector gravityDirection_;
	}
}
