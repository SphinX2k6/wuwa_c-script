using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200006E RID: 110
	[NetMessage(EMessageId.ActionGroupCompleteNotify)]
	public sealed class ActionGroupCompleteNotify : IMessage<ActionGroupCompleteNotify>, IMessage, IEquatable<ActionGroupCompleteNotify>, IDeepCloneable<ActionGroupCompleteNotify>, IBufferMessage
	{
		// Token: 0x0600175B RID: 5979 RVA: 0x0003D00D File Offset: 0x0003B20D
		[NullableContext(1)]
		public static ActionGroupCompleteNotify Create()
		{
			return new ActionGroupCompleteNotify();
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x0003D014 File Offset: 0x0003B214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x0003D017 File Offset: 0x0003B217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionGroupCompleteNotify.Descriptor;
			}
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x0003D01E File Offset: 0x0003B21E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupCompleteNotify()
		{
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x0003D026 File Offset: 0x0003B226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupCompleteNotify(ActionGroupCompleteNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x0003D057 File Offset: 0x0003B257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupCompleteNotify Clone()
		{
			return new ActionGroupCompleteNotify(this);
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x0003D05F File Offset: 0x0003B25F
		// (set) Token: 0x06001762 RID: 5986 RVA: 0x0003D067 File Offset: 0x0003B267
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

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x0003D070 File Offset: 0x0003B270
		// (set) Token: 0x06001764 RID: 5988 RVA: 0x0003D078 File Offset: 0x0003B278
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

		// Token: 0x06001765 RID: 5989 RVA: 0x0003D081 File Offset: 0x0003B281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionGroupCompleteNotify);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x0003D08F File Offset: 0x0003B28F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionGroupCompleteNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x0003D0D0 File Offset: 0x0003B2D0
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

		// Token: 0x06001768 RID: 5992 RVA: 0x0003D128 File Offset: 0x0003B328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x0003D135 File Offset: 0x0003B335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x0003D140 File Offset: 0x0003B340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x0003D198 File Offset: 0x0003B398
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

		// Token: 0x0600176C RID: 5996 RVA: 0x0003D1F0 File Offset: 0x0003B3F0
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

		// Token: 0x0600176D RID: 5997 RVA: 0x0003D240 File Offset: 0x0003B440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0003D24C File Offset: 0x0003B44C
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IncId = input.ReadInt32();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400216F RID: 8559
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002170 RID: 8560
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04002171 RID: 8561
		private int playerId_;

		// Token: 0x04002172 RID: 8562
		public const int IncIdFieldNumber = 13;

		// Token: 0x04002173 RID: 8563
		private int incId_;
	}
}
