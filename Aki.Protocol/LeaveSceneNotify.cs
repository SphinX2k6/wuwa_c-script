using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E0 RID: 2272
	[NetMessage(EMessageId.LeaveSceneNotify)]
	public sealed class LeaveSceneNotify : IMessage<LeaveSceneNotify>, IMessage, IEquatable<LeaveSceneNotify>, IDeepCloneable<LeaveSceneNotify>, IBufferMessage
	{
		// Token: 0x0600C93C RID: 51516 RVA: 0x001DBA41 File Offset: 0x001D9C41
		[NullableContext(1)]
		public static LeaveSceneNotify Create()
		{
			return new LeaveSceneNotify();
		}

		// Token: 0x1700289B RID: 10395
		// (get) Token: 0x0600C93D RID: 51517 RVA: 0x001DBA48 File Offset: 0x001D9C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700289C RID: 10396
		// (get) Token: 0x0600C93E RID: 51518 RVA: 0x001DBA4B File Offset: 0x001D9C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveSceneNotify.Descriptor;
			}
		}

		// Token: 0x0600C93F RID: 51519 RVA: 0x001DBA52 File Offset: 0x001D9C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveSceneNotify()
		{
		}

		// Token: 0x0600C940 RID: 51520 RVA: 0x001DBA68 File Offset: 0x001D9C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveSceneNotify(LeaveSceneNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.sceneId_ = other.sceneId_;
			this.transitionOption_ = ((other.transitionOption_ != null) ? other.transitionOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C941 RID: 51521 RVA: 0x001DBAC0 File Offset: 0x001D9CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveSceneNotify Clone()
		{
			return new LeaveSceneNotify(this);
		}

		// Token: 0x1700289D RID: 10397
		// (get) Token: 0x0600C942 RID: 51522 RVA: 0x001DBAC8 File Offset: 0x001D9CC8
		// (set) Token: 0x0600C943 RID: 51523 RVA: 0x001DBAD0 File Offset: 0x001D9CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x1700289E RID: 10398
		// (get) Token: 0x0600C944 RID: 51524 RVA: 0x001DBAD9 File Offset: 0x001D9CD9
		// (set) Token: 0x0600C945 RID: 51525 RVA: 0x001DBAE1 File Offset: 0x001D9CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SceneId
		{
			get
			{
				return this.sceneId_;
			}
			set
			{
				this.sceneId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700289F RID: 10399
		// (get) Token: 0x0600C946 RID: 51526 RVA: 0x001DBAF4 File Offset: 0x001D9CF4
		// (set) Token: 0x0600C947 RID: 51527 RVA: 0x001DBAFC File Offset: 0x001D9CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionOptionPb TransitionOption
		{
			get
			{
				return this.transitionOption_;
			}
			set
			{
				this.transitionOption_ = value;
			}
		}

		// Token: 0x0600C948 RID: 51528 RVA: 0x001DBB05 File Offset: 0x001D9D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveSceneNotify);
		}

		// Token: 0x0600C949 RID: 51529 RVA: 0x001DBB14 File Offset: 0x001D9D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveSceneNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.SceneId != other.SceneId) && object.Equals(this.TransitionOption, other.TransitionOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C94A RID: 51530 RVA: 0x001DBB78 File Offset: 0x001D9D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.SceneId.Length != 0)
			{
				num ^= this.SceneId.GetHashCode();
			}
			if (this.transitionOption_ != null)
			{
				num ^= this.TransitionOption.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C94B RID: 51531 RVA: 0x001DBBE8 File Offset: 0x001D9DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C94C RID: 51532 RVA: 0x001DBBF5 File Offset: 0x001D9DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C94D RID: 51533 RVA: 0x001DBC00 File Offset: 0x001D9E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneId.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.SceneId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PlayerId);
			}
			if (this.transitionOption_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.TransitionOption);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C94E RID: 51534 RVA: 0x001DBC7C File Offset: 0x001D9E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.SceneId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SceneId);
			}
			if (this.transitionOption_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransitionOption);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C94F RID: 51535 RVA: 0x001DBCF0 File Offset: 0x001D9EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveSceneNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.SceneId.Length != 0)
			{
				this.SceneId = other.SceneId;
			}
			if (other.transitionOption_ != null)
			{
				if (this.transitionOption_ == null)
				{
					this.TransitionOption = new TransitionOptionPb();
				}
				this.TransitionOption.MergeFrom(other.TransitionOption);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C950 RID: 51536 RVA: 0x001DBD71 File Offset: 0x001D9F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C951 RID: 51537 RVA: 0x001DBD7C File Offset: 0x001D9F7C
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
				if (num != 34U)
				{
					if (num != 56U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.transitionOption_ == null)
							{
								this.TransitionOption = new TransitionOptionPb();
							}
							input.ReadMessage(this.TransitionOption);
						}
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.SceneId = input.ReadString();
				}
			}
		}

		// Token: 0x04005626 RID: 22054
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005627 RID: 22055
		public const int PlayerIdFieldNumber = 7;

		// Token: 0x04005628 RID: 22056
		private int playerId_;

		// Token: 0x04005629 RID: 22057
		public const int SceneIdFieldNumber = 4;

		// Token: 0x0400562A RID: 22058
		private string sceneId_ = "";

		// Token: 0x0400562B RID: 22059
		public const int TransitionOptionFieldNumber = 12;

		// Token: 0x0400562C RID: 22060
		private TransitionOptionPb transitionOption_;
	}
}
