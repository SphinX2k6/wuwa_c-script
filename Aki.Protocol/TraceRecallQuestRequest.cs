using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200144C RID: 5196
	[NetMessage(EMessageId.TraceRecallQuestRequest)]
	public sealed class TraceRecallQuestRequest : IMessage<TraceRecallQuestRequest>, IMessage, IEquatable<TraceRecallQuestRequest>, IDeepCloneable<TraceRecallQuestRequest>, IBufferMessage
	{
		// Token: 0x0601B99A RID: 113050 RVA: 0x004029CD File Offset: 0x00400BCD
		[NullableContext(1)]
		public static TraceRecallQuestRequest Create()
		{
			return new TraceRecallQuestRequest();
		}

		// Token: 0x17005D6B RID: 23915
		// (get) Token: 0x0601B99B RID: 113051 RVA: 0x004029D4 File Offset: 0x00400BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D6C RID: 23916
		// (get) Token: 0x0601B99C RID: 113052 RVA: 0x004029D7 File Offset: 0x00400BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceRecallQuestRequest.Descriptor;
			}
		}

		// Token: 0x0601B99D RID: 113053 RVA: 0x004029DE File Offset: 0x00400BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestRequest()
		{
		}

		// Token: 0x0601B99E RID: 113054 RVA: 0x004029E6 File Offset: 0x00400BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestRequest(TraceRecallQuestRequest other) : this()
		{
			this.traceType_ = other.traceType_;
			this.recallQuestId_ = other.recallQuestId_;
			this.operate_ = other.operate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B99F RID: 113055 RVA: 0x00402A23 File Offset: 0x00400C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestRequest Clone()
		{
			return new TraceRecallQuestRequest(this);
		}

		// Token: 0x17005D6D RID: 23917
		// (get) Token: 0x0601B9A0 RID: 113056 RVA: 0x00402A2B File Offset: 0x00400C2B
		// (set) Token: 0x0601B9A1 RID: 113057 RVA: 0x00402A33 File Offset: 0x00400C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TraceType
		{
			get
			{
				return this.traceType_;
			}
			set
			{
				this.traceType_ = value;
			}
		}

		// Token: 0x17005D6E RID: 23918
		// (get) Token: 0x0601B9A2 RID: 113058 RVA: 0x00402A3C File Offset: 0x00400C3C
		// (set) Token: 0x0601B9A3 RID: 113059 RVA: 0x00402A44 File Offset: 0x00400C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallQuestId
		{
			get
			{
				return this.recallQuestId_;
			}
			set
			{
				this.recallQuestId_ = value;
			}
		}

		// Token: 0x17005D6F RID: 23919
		// (get) Token: 0x0601B9A4 RID: 113060 RVA: 0x00402A4D File Offset: 0x00400C4D
		// (set) Token: 0x0601B9A5 RID: 113061 RVA: 0x00402A55 File Offset: 0x00400C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Operate
		{
			get
			{
				return this.operate_;
			}
			set
			{
				this.operate_ = value;
			}
		}

		// Token: 0x0601B9A6 RID: 113062 RVA: 0x00402A5E File Offset: 0x00400C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceRecallQuestRequest);
		}

		// Token: 0x0601B9A7 RID: 113063 RVA: 0x00402A6C File Offset: 0x00400C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceRecallQuestRequest other)
		{
			return other != null && (other == this || (this.TraceType == other.TraceType && this.RecallQuestId == other.RecallQuestId && this.Operate == other.Operate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B9A8 RID: 113064 RVA: 0x00402AC8 File Offset: 0x00400CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TraceType != 0)
			{
				num ^= this.TraceType.GetHashCode();
			}
			if (this.RecallQuestId != 0)
			{
				num ^= this.RecallQuestId.GetHashCode();
			}
			if (this.Operate != 0)
			{
				num ^= this.Operate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B9A9 RID: 113065 RVA: 0x00402B39 File Offset: 0x00400D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B9AA RID: 113066 RVA: 0x00402B46 File Offset: 0x00400D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B9AB RID: 113067 RVA: 0x00402B50 File Offset: 0x00400D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this.TraceType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TraceType);
			}
			if (this.Operate != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Operate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B9AC RID: 113068 RVA: 0x00402BC8 File Offset: 0x00400DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TraceType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TraceType);
			}
			if (this.RecallQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallQuestId);
			}
			if (this.Operate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Operate);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B9AD RID: 113069 RVA: 0x00402C38 File Offset: 0x00400E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceRecallQuestRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TraceType != 0)
			{
				this.TraceType = other.TraceType;
			}
			if (other.RecallQuestId != 0)
			{
				this.RecallQuestId = other.RecallQuestId;
			}
			if (other.Operate != 0)
			{
				this.Operate = other.Operate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B9AE RID: 113070 RVA: 0x00402C9C File Offset: 0x00400E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B9AF RID: 113071 RVA: 0x00402CA8 File Offset: 0x00400EA8
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
				if (num != 16U)
				{
					if (num != 56U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Operate = input.ReadInt32();
						}
					}
					else
					{
						this.TraceType = input.ReadInt32();
					}
				}
				else
				{
					this.RecallQuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A06D RID: 41069
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A06E RID: 41070
		public const int TraceTypeFieldNumber = 7;

		// Token: 0x0400A06F RID: 41071
		private int traceType_;

		// Token: 0x0400A070 RID: 41072
		public const int RecallQuestIdFieldNumber = 2;

		// Token: 0x0400A071 RID: 41073
		private int recallQuestId_;

		// Token: 0x0400A072 RID: 41074
		public const int OperateFieldNumber = 11;

		// Token: 0x0400A073 RID: 41075
		private int operate_;
	}
}
