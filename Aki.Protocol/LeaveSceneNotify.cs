using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F1 RID: 2289
	[NetMessage(EMessageId.LeaveSceneNotify)]
	public sealed class LeaveSceneNotify : IMessage<LeaveSceneNotify>, IMessage, IEquatable<LeaveSceneNotify>, IDeepCloneable<LeaveSceneNotify>, IBufferMessage
	{
		// Token: 0x0600CA58 RID: 51800 RVA: 0x001DDD1D File Offset: 0x001DBF1D
		[NullableContext(1)]
		public static LeaveSceneNotify Create()
		{
			return new LeaveSceneNotify();
		}

		// Token: 0x170028DA RID: 10458
		// (get) Token: 0x0600CA59 RID: 51801 RVA: 0x001DDD24 File Offset: 0x001DBF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028DB RID: 10459
		// (get) Token: 0x0600CA5A RID: 51802 RVA: 0x001DDD27 File Offset: 0x001DBF27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveSceneNotify.Descriptor;
			}
		}

		// Token: 0x0600CA5B RID: 51803 RVA: 0x001DDD2E File Offset: 0x001DBF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveSceneNotify()
		{
		}

		// Token: 0x0600CA5C RID: 51804 RVA: 0x001DDD44 File Offset: 0x001DBF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveSceneNotify(LeaveSceneNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.sceneId_ = other.sceneId_;
			this.transitionOption_ = ((other.transitionOption_ != null) ? other.transitionOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA5D RID: 51805 RVA: 0x001DDD9C File Offset: 0x001DBF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveSceneNotify Clone()
		{
			return new LeaveSceneNotify(this);
		}

		// Token: 0x170028DC RID: 10460
		// (get) Token: 0x0600CA5E RID: 51806 RVA: 0x001DDDA4 File Offset: 0x001DBFA4
		// (set) Token: 0x0600CA5F RID: 51807 RVA: 0x001DDDAC File Offset: 0x001DBFAC
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

		// Token: 0x170028DD RID: 10461
		// (get) Token: 0x0600CA60 RID: 51808 RVA: 0x001DDDB5 File Offset: 0x001DBFB5
		// (set) Token: 0x0600CA61 RID: 51809 RVA: 0x001DDDBD File Offset: 0x001DBFBD
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

		// Token: 0x170028DE RID: 10462
		// (get) Token: 0x0600CA62 RID: 51810 RVA: 0x001DDDD0 File Offset: 0x001DBFD0
		// (set) Token: 0x0600CA63 RID: 51811 RVA: 0x001DDDD8 File Offset: 0x001DBFD8
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

		// Token: 0x0600CA64 RID: 51812 RVA: 0x001DDDE1 File Offset: 0x001DBFE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveSceneNotify);
		}

		// Token: 0x0600CA65 RID: 51813 RVA: 0x001DDDF0 File Offset: 0x001DBFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveSceneNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.SceneId != other.SceneId) && object.Equals(this.TransitionOption, other.TransitionOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA66 RID: 51814 RVA: 0x001DDE54 File Offset: 0x001DC054
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

		// Token: 0x0600CA67 RID: 51815 RVA: 0x001DDEC4 File Offset: 0x001DC0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CA68 RID: 51816 RVA: 0x001DDED1 File Offset: 0x001DC0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA69 RID: 51817 RVA: 0x001DDEDC File Offset: 0x001DC0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneId.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.SceneId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PlayerId);
			}
			if (this.transitionOption_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.TransitionOption);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA6A RID: 51818 RVA: 0x001DDF58 File Offset: 0x001DC158
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

		// Token: 0x0600CA6B RID: 51819 RVA: 0x001DDFCC File Offset: 0x001DC1CC
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

		// Token: 0x0600CA6C RID: 51820 RVA: 0x001DE04D File Offset: 0x001DC24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA6D RID: 51821 RVA: 0x001DE058 File Offset: 0x001DC258
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
				if (num != 10U)
				{
					if (num != 40U)
					{
						if (num != 106U)
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

		// Token: 0x0400561F RID: 22047
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005620 RID: 22048
		public const int PlayerIdFieldNumber = 5;

		// Token: 0x04005621 RID: 22049
		private int playerId_;

		// Token: 0x04005622 RID: 22050
		public const int SceneIdFieldNumber = 1;

		// Token: 0x04005623 RID: 22051
		private string sceneId_ = "";

		// Token: 0x04005624 RID: 22052
		public const int TransitionOptionFieldNumber = 13;

		// Token: 0x04005625 RID: 22053
		private TransitionOptionPb transitionOption_;
	}
}
