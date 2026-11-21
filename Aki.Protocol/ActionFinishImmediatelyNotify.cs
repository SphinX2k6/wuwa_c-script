using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200006B RID: 107
	[NetMessage(EMessageId.ActionFinishImmediatelyNotify)]
	public sealed class ActionFinishImmediatelyNotify : IMessage<ActionFinishImmediatelyNotify>, IMessage, IEquatable<ActionFinishImmediatelyNotify>, IDeepCloneable<ActionFinishImmediatelyNotify>, IBufferMessage
	{
		// Token: 0x0600171D RID: 5917 RVA: 0x0003C773 File Offset: 0x0003A973
		[NullableContext(1)]
		public static ActionFinishImmediatelyNotify Create()
		{
			return new ActionFinishImmediatelyNotify();
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x0003C77A File Offset: 0x0003A97A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x0003C77D File Offset: 0x0003A97D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionFinishImmediatelyNotify.Descriptor;
			}
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x0003C784 File Offset: 0x0003A984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishImmediatelyNotify()
		{
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x0003C78C File Offset: 0x0003A98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishImmediatelyNotify(ActionFinishImmediatelyNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x0003C7BD File Offset: 0x0003A9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishImmediatelyNotify Clone()
		{
			return new ActionFinishImmediatelyNotify(this);
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x0003C7C5 File Offset: 0x0003A9C5
		// (set) Token: 0x06001724 RID: 5924 RVA: 0x0003C7CD File Offset: 0x0003A9CD
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

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x0003C7D6 File Offset: 0x0003A9D6
		// (set) Token: 0x06001726 RID: 5926 RVA: 0x0003C7DE File Offset: 0x0003A9DE
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

		// Token: 0x06001727 RID: 5927 RVA: 0x0003C7E7 File Offset: 0x0003A9E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionFinishImmediatelyNotify);
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x0003C7F5 File Offset: 0x0003A9F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionFinishImmediatelyNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x0003C834 File Offset: 0x0003AA34
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

		// Token: 0x0600172A RID: 5930 RVA: 0x0003C88C File Offset: 0x0003AA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x0003C899 File Offset: 0x0003AA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x0003C8A4 File Offset: 0x0003AAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.IncId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x0003C900 File Offset: 0x0003AB00
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

		// Token: 0x0600172E RID: 5934 RVA: 0x0003C958 File Offset: 0x0003AB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionFinishImmediatelyNotify other)
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

		// Token: 0x0600172F RID: 5935 RVA: 0x0003C9A8 File Offset: 0x0003ABA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x0003C9B4 File Offset: 0x0003ABB4
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
				if (num != 72U)
				{
					if (num != 88U)
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

		// Token: 0x0400215E RID: 8542
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400215F RID: 8543
		public const int PlayerIdFieldNumber = 11;

		// Token: 0x04002160 RID: 8544
		private int playerId_;

		// Token: 0x04002161 RID: 8545
		public const int IncIdFieldNumber = 9;

		// Token: 0x04002162 RID: 8546
		private int incId_;
	}
}
