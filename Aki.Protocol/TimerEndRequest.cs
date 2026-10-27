using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200137F RID: 4991
	[NetMessage(EMessageId.TimerEndRequest)]
	public sealed class TimerEndRequest : IMessage<TimerEndRequest>, IMessage, IEquatable<TimerEndRequest>, IDeepCloneable<TimerEndRequest>, IBufferMessage
	{
		// Token: 0x0601A7EB RID: 108523 RVA: 0x003D86B9 File Offset: 0x003D68B9
		[NullableContext(1)]
		public static TimerEndRequest Create()
		{
			return new TimerEndRequest();
		}

		// Token: 0x1700595A RID: 22874
		// (get) Token: 0x0601A7EC RID: 108524 RVA: 0x003D86C0 File Offset: 0x003D68C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700595B RID: 22875
		// (get) Token: 0x0601A7ED RID: 108525 RVA: 0x003D86C3 File Offset: 0x003D68C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimerEndRequest.Descriptor;
			}
		}

		// Token: 0x0601A7EE RID: 108526 RVA: 0x003D86CA File Offset: 0x003D68CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerEndRequest()
		{
		}

		// Token: 0x0601A7EF RID: 108527 RVA: 0x003D86DD File Offset: 0x003D68DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerEndRequest(TimerEndRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.timerType_ = other.timerType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A7F0 RID: 108528 RVA: 0x003D871A File Offset: 0x003D691A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerEndRequest Clone()
		{
			return new TimerEndRequest(this);
		}

		// Token: 0x1700595C RID: 22876
		// (get) Token: 0x0601A7F1 RID: 108529 RVA: 0x003D8722 File Offset: 0x003D6922
		// (set) Token: 0x0601A7F2 RID: 108530 RVA: 0x003D872A File Offset: 0x003D692A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeOwnerId
		{
			get
			{
				return this.treeOwnerId_;
			}
			set
			{
				this.treeOwnerId_ = value;
			}
		}

		// Token: 0x1700595D RID: 22877
		// (get) Token: 0x0601A7F3 RID: 108531 RVA: 0x003D8733 File Offset: 0x003D6933
		// (set) Token: 0x0601A7F4 RID: 108532 RVA: 0x003D873B File Offset: 0x003D693B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x1700595E RID: 22878
		// (get) Token: 0x0601A7F5 RID: 108533 RVA: 0x003D8744 File Offset: 0x003D6944
		// (set) Token: 0x0601A7F6 RID: 108534 RVA: 0x003D874C File Offset: 0x003D694C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TimerType
		{
			get
			{
				return this.timerType_;
			}
			set
			{
				this.timerType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601A7F7 RID: 108535 RVA: 0x003D875F File Offset: 0x003D695F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimerEndRequest);
		}

		// Token: 0x0601A7F8 RID: 108536 RVA: 0x003D8770 File Offset: 0x003D6970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimerEndRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && !(this.TimerType != other.TimerType) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A7F9 RID: 108537 RVA: 0x003D87D0 File Offset: 0x003D69D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeOwnerId != 0)
			{
				num ^= this.TreeOwnerId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this.TimerType.Length != 0)
			{
				num ^= this.TimerType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A7FA RID: 108538 RVA: 0x003D8843 File Offset: 0x003D6A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A7FB RID: 108539 RVA: 0x003D8850 File Offset: 0x003D6A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A7FC RID: 108540 RVA: 0x003D885C File Offset: 0x003D6A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimerType.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.TimerType);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A7FD RID: 108541 RVA: 0x003D88D8 File Offset: 0x003D6AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this.TimerType.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TimerType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A7FE RID: 108542 RVA: 0x003D894C File Offset: 0x003D6B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimerEndRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeOwnerId != 0)
			{
				this.TreeOwnerId = other.TreeOwnerId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			if (other.TimerType.Length != 0)
			{
				this.TimerType = other.TimerType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A7FF RID: 108543 RVA: 0x003D89B5 File Offset: 0x003D6BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A800 RID: 108544 RVA: 0x003D89C0 File Offset: 0x003D6BC0
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
				if (num != 74U)
				{
					if (num != 88U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TreeOwnerId = input.ReadInt32();
						}
					}
					else
					{
						this.TreeIncId = input.ReadInt64();
					}
				}
				else
				{
					this.TimerType = input.ReadString();
				}
			}
		}

		// Token: 0x04009A27 RID: 39463
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A28 RID: 39464
		public const int TreeOwnerIdFieldNumber = 14;

		// Token: 0x04009A29 RID: 39465
		private int treeOwnerId_;

		// Token: 0x04009A2A RID: 39466
		public const int TreeIncIdFieldNumber = 11;

		// Token: 0x04009A2B RID: 39467
		private long treeIncId_;

		// Token: 0x04009A2C RID: 39468
		public const int TimerTypeFieldNumber = 9;

		// Token: 0x04009A2D RID: 39469
		private string timerType_ = "";
	}
}
