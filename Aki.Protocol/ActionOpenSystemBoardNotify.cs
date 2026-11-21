using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000072 RID: 114
	[NetMessage(EMessageId.ActionOpenSystemBoardNotify)]
	public sealed class ActionOpenSystemBoardNotify : IMessage<ActionOpenSystemBoardNotify>, IMessage, IEquatable<ActionOpenSystemBoardNotify>, IDeepCloneable<ActionOpenSystemBoardNotify>, IBufferMessage
	{
		// Token: 0x060017B5 RID: 6069 RVA: 0x0003DE76 File Offset: 0x0003C076
		[NullableContext(1)]
		public static ActionOpenSystemBoardNotify Create()
		{
			return new ActionOpenSystemBoardNotify();
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x0003DE7D File Offset: 0x0003C07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060017B7 RID: 6071 RVA: 0x0003DE80 File Offset: 0x0003C080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionOpenSystemBoardNotify.Descriptor;
			}
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x0003DE87 File Offset: 0x0003C087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOpenSystemBoardNotify()
		{
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x0003DE90 File Offset: 0x0003C090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOpenSystemBoardNotify(ActionOpenSystemBoardNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.param_ = ((other.param_ != null) ? other.param_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x0003DEDC File Offset: 0x0003C0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionOpenSystemBoardNotify Clone()
		{
			return new ActionOpenSystemBoardNotify(this);
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x0003DEE4 File Offset: 0x0003C0E4
		// (set) Token: 0x060017BC RID: 6076 RVA: 0x0003DEEC File Offset: 0x0003C0EC
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

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x0003DEF5 File Offset: 0x0003C0F5
		// (set) Token: 0x060017BE RID: 6078 RVA: 0x0003DEFD File Offset: 0x0003C0FD
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

		// Token: 0x060017BF RID: 6079 RVA: 0x0003DF06 File Offset: 0x0003C106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionOpenSystemBoardNotify);
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x0003DF14 File Offset: 0x0003C114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionOpenSystemBoardNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this.Param, other.Param) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x0003DF64 File Offset: 0x0003C164
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

		// Token: 0x060017C2 RID: 6082 RVA: 0x0003DFB9 File Offset: 0x0003C1B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x0003DFC6 File Offset: 0x0003C1C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x0003DFD0 File Offset: 0x0003C1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.param_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Param);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x0003E02C File Offset: 0x0003C22C
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

		// Token: 0x060017C6 RID: 6086 RVA: 0x0003E084 File Offset: 0x0003C284
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

		// Token: 0x060017C7 RID: 6087 RVA: 0x0003E0EC File Offset: 0x0003C2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x0003E0F8 File Offset: 0x0003C2F8
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
				if (num != 42U)
				{
					if (num != 104U)
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
					if (this.param_ == null)
					{
						this.Param = new ActionOpenSystemParam();
					}
					input.ReadMessage(this.Param);
				}
			}
		}

		// Token: 0x0400218D RID: 8589
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400218E RID: 8590
		public const int PlayerIdFieldNumber = 13;

		// Token: 0x0400218F RID: 8591
		private int playerId_;

		// Token: 0x04002190 RID: 8592
		public const int ParamFieldNumber = 5;

		// Token: 0x04002191 RID: 8593
		private ActionOpenSystemParam param_;
	}
}
