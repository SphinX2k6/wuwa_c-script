using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000071 RID: 113
	[NetMessage(EMessageId.ActionOpenSystemBoardNotify)]
	public sealed class ActionOpenSystemBoardNotify : IMessage<ActionOpenSystemBoardNotify>, IMessage, IEquatable<ActionOpenSystemBoardNotify>, IDeepCloneable<ActionOpenSystemBoardNotify>, IBufferMessage
	{
		// Token: 0x06001772 RID: 6002 RVA: 0x0003D4D1 File Offset: 0x0003B6D1
		[NullableContext(1)]
		public static ActionOpenSystemBoardNotify Create()
		{
			return new ActionOpenSystemBoardNotify();
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x0003D4D8 File Offset: 0x0003B6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x0003D4DB File Offset: 0x0003B6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionOpenSystemBoardNotify.Descriptor;
			}
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x0003D4E2 File Offset: 0x0003B6E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOpenSystemBoardNotify()
		{
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x0003D4EC File Offset: 0x0003B6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOpenSystemBoardNotify(ActionOpenSystemBoardNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.param_ = ((other.param_ != null) ? other.param_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x0003D538 File Offset: 0x0003B738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOpenSystemBoardNotify Clone()
		{
			return new ActionOpenSystemBoardNotify(this);
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x0003D540 File Offset: 0x0003B740
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x0003D548 File Offset: 0x0003B748
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

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x0003D551 File Offset: 0x0003B751
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x0003D559 File Offset: 0x0003B759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOpenSystemParam Param
		{
			get
			{
				return this.param_;
			}
			set
			{
				this.param_ = value;
			}
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x0003D562 File Offset: 0x0003B762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionOpenSystemBoardNotify);
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x0003D570 File Offset: 0x0003B770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionOpenSystemBoardNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this.Param, other.Param) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x0003D5C0 File Offset: 0x0003B7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.param_ != null)
			{
				num ^= this.Param.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x0003D615 File Offset: 0x0003B815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x0003D622 File Offset: 0x0003B822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x0003D62C File Offset: 0x0003B82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PlayerId);
			}
			if (this.param_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Param);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x0003D688 File Offset: 0x0003B888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.param_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Param);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x0003D6E0 File Offset: 0x0003B8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionOpenSystemBoardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.param_ != null)
			{
				if (this.param_ == null)
				{
					this.Param = new ActionOpenSystemParam();
				}
				this.Param.MergeFrom(other.Param);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x0003D748 File Offset: 0x0003B948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x0003D754 File Offset: 0x0003B954
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
				if (num != 56U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.param_ == null)
						{
							this.Param = new ActionOpenSystemParam();
						}
						input.ReadMessage(this.Param);
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400212E RID: 8494
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400212F RID: 8495
		public const int PlayerIdFieldNumber = 7;

		// Token: 0x04002130 RID: 8496
		private int playerId_;

		// Token: 0x04002131 RID: 8497
		public const int ParamFieldNumber = 10;

		// Token: 0x04002132 RID: 8498
		private ActionOpenSystemParam param_;
	}
}
