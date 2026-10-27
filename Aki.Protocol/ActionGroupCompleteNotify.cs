using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200006D RID: 109
	[NetMessage(EMessageId.ActionGroupCompleteNotify)]
	public sealed class ActionGroupCompleteNotify : IMessage<ActionGroupCompleteNotify>, IMessage, IEquatable<ActionGroupCompleteNotify>, IDeepCloneable<ActionGroupCompleteNotify>, IBufferMessage
	{
		// Token: 0x06001718 RID: 5912 RVA: 0x0003C665 File Offset: 0x0003A865
		[NullableContext(1)]
		public static ActionGroupCompleteNotify Create()
		{
			return new ActionGroupCompleteNotify();
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x0003C66C File Offset: 0x0003A86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x0003C66F File Offset: 0x0003A86F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionGroupCompleteNotify.Descriptor;
			}
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x0003C676 File Offset: 0x0003A876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupCompleteNotify()
		{
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x0003C67E File Offset: 0x0003A87E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupCompleteNotify(ActionGroupCompleteNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x0003C6AF File Offset: 0x0003A8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupCompleteNotify Clone()
		{
			return new ActionGroupCompleteNotify(this);
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x0003C6B7 File Offset: 0x0003A8B7
		// (set) Token: 0x0600171F RID: 5919 RVA: 0x0003C6BF File Offset: 0x0003A8BF
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

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x0003C6C8 File Offset: 0x0003A8C8
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x0003C6D0 File Offset: 0x0003A8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x0003C6D9 File Offset: 0x0003A8D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionGroupCompleteNotify);
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x0003C6E7 File Offset: 0x0003A8E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionGroupCompleteNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x0003C728 File Offset: 0x0003A928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x0003C780 File Offset: 0x0003A980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x0003C78D File Offset: 0x0003A98D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x0003C798 File Offset: 0x0003A998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IncId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x0003C7F4 File Offset: 0x0003A9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x0003C84C File Offset: 0x0003AA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionGroupCompleteNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x0003C89C File Offset: 0x0003AA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x0003C8A8 File Offset: 0x0003AAA8
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
				if (num != 24U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002110 RID: 8464
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002111 RID: 8465
		public const int PlayerIdFieldNumber = 12;

		// Token: 0x04002112 RID: 8466
		private int playerId_;

		// Token: 0x04002113 RID: 8467
		public const int IncIdFieldNumber = 3;

		// Token: 0x04002114 RID: 8468
		private int incId_;
	}
}
