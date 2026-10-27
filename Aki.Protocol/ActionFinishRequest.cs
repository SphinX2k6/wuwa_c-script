using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200006B RID: 107
	[NetMessage(EMessageId.ActionFinishRequest)]
	public sealed class ActionFinishRequest : IMessage<ActionFinishRequest>, IMessage, IEquatable<ActionFinishRequest>, IDeepCloneable<ActionFinishRequest>, IBufferMessage
	{
		// Token: 0x060016EE RID: 5870 RVA: 0x0003C064 File Offset: 0x0003A264
		[NullableContext(1)]
		public static ActionFinishRequest Create()
		{
			return new ActionFinishRequest();
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x0003C06B File Offset: 0x0003A26B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x0003C06E File Offset: 0x0003A26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionFinishRequest.Descriptor;
			}
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x0003C075 File Offset: 0x0003A275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishRequest()
		{
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x0003C088 File Offset: 0x0003A288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishRequest(ActionFinishRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this.incId_ = other.incId_;
			this.startIndex_ = other.startIndex_;
			this.errorMsg_ = other.errorMsg_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x0003C0DC File Offset: 0x0003A2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishRequest Clone()
		{
			return new ActionFinishRequest(this);
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x0003C0E4 File Offset: 0x0003A2E4
		// (set) Token: 0x060016F5 RID: 5877 RVA: 0x0003C0EC File Offset: 0x0003A2EC
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

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x0003C0F5 File Offset: 0x0003A2F5
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x0003C0FD File Offset: 0x0003A2FD
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

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x0003C106 File Offset: 0x0003A306
		// (set) Token: 0x060016F9 RID: 5881 RVA: 0x0003C10E File Offset: 0x0003A30E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartIndex
		{
			get
			{
				return this.startIndex_;
			}
			set
			{
				this.startIndex_ = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x0003C117 File Offset: 0x0003A317
		// (set) Token: 0x060016FB RID: 5883 RVA: 0x0003C11F File Offset: 0x0003A31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ErrorMsg
		{
			get
			{
				return this.errorMsg_;
			}
			set
			{
				this.errorMsg_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x0003C132 File Offset: 0x0003A332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionFinishRequest);
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x0003C140 File Offset: 0x0003A340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionFinishRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && this.StartIndex == other.StartIndex && !(this.ErrorMsg != other.ErrorMsg) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0003C1B0 File Offset: 0x0003A3B0
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
			if (this.StartIndex != 0)
			{
				num ^= this.StartIndex.GetHashCode();
			}
			if (this.ErrorMsg.Length != 0)
			{
				num ^= this.ErrorMsg.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x0003C23C File Offset: 0x0003A43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x0003C249 File Offset: 0x0003A449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x0003C254 File Offset: 0x0003A454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StartIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.StartIndex);
			}
			if (this.ErrorMsg.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.ErrorMsg);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x0003C2EC File Offset: 0x0003A4EC
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
			if (this.StartIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartIndex);
			}
			if (this.ErrorMsg.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ErrorMsg);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x0003C378 File Offset: 0x0003A578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionFinishRequest other)
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
			if (other.StartIndex != 0)
			{
				this.StartIndex = other.StartIndex;
			}
			if (other.ErrorMsg.Length != 0)
			{
				this.ErrorMsg = other.ErrorMsg;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x0003C3F5 File Offset: 0x0003A5F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x0003C400 File Offset: 0x0003A600
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
				if (num <= 50U)
				{
					if (num == 24U)
					{
						this.StartIndex = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						this.ErrorMsg = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002104 RID: 8452
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002105 RID: 8453
		public const int PlayerIdFieldNumber = 11;

		// Token: 0x04002106 RID: 8454
		private int playerId_;

		// Token: 0x04002107 RID: 8455
		public const int IncIdFieldNumber = 12;

		// Token: 0x04002108 RID: 8456
		private int incId_;

		// Token: 0x04002109 RID: 8457
		public const int StartIndexFieldNumber = 3;

		// Token: 0x0400210A RID: 8458
		private int startIndex_;

		// Token: 0x0400210B RID: 8459
		public const int ErrorMsgFieldNumber = 6;

		// Token: 0x0400210C RID: 8460
		private string errorMsg_ = "";
	}
}
