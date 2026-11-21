using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001449 RID: 5193
	[NetMessage(EMessageId.TraceQuestRequest)]
	public sealed class TraceQuestRequest : IMessage<TraceQuestRequest>, IMessage, IEquatable<TraceQuestRequest>, IDeepCloneable<TraceQuestRequest>, IBufferMessage
	{
		// Token: 0x0601B960 RID: 112992 RVA: 0x004022CD File Offset: 0x004004CD
		[NullableContext(1)]
		public static TraceQuestRequest Create()
		{
			return new TraceQuestRequest();
		}

		// Token: 0x17005D60 RID: 23904
		// (get) Token: 0x0601B961 RID: 112993 RVA: 0x004022D4 File Offset: 0x004004D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D61 RID: 23905
		// (get) Token: 0x0601B962 RID: 112994 RVA: 0x004022D7 File Offset: 0x004004D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceQuestRequest.Descriptor;
			}
		}

		// Token: 0x0601B963 RID: 112995 RVA: 0x004022DE File Offset: 0x004004DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestRequest()
		{
		}

		// Token: 0x0601B964 RID: 112996 RVA: 0x004022E6 File Offset: 0x004004E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestRequest(TraceQuestRequest other) : this()
		{
			this.traceType_ = other.traceType_;
			this.questId_ = other.questId_;
			this.operate_ = other.operate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B965 RID: 112997 RVA: 0x00402323 File Offset: 0x00400523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceQuestRequest Clone()
		{
			return new TraceQuestRequest(this);
		}

		// Token: 0x17005D62 RID: 23906
		// (get) Token: 0x0601B966 RID: 112998 RVA: 0x0040232B File Offset: 0x0040052B
		// (set) Token: 0x0601B967 RID: 112999 RVA: 0x00402333 File Offset: 0x00400533
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

		// Token: 0x17005D63 RID: 23907
		// (get) Token: 0x0601B968 RID: 113000 RVA: 0x0040233C File Offset: 0x0040053C
		// (set) Token: 0x0601B969 RID: 113001 RVA: 0x00402344 File Offset: 0x00400544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x17005D64 RID: 23908
		// (get) Token: 0x0601B96A RID: 113002 RVA: 0x0040234D File Offset: 0x0040054D
		// (set) Token: 0x0601B96B RID: 113003 RVA: 0x00402355 File Offset: 0x00400555
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

		// Token: 0x0601B96C RID: 113004 RVA: 0x0040235E File Offset: 0x0040055E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceQuestRequest);
		}

		// Token: 0x0601B96D RID: 113005 RVA: 0x0040236C File Offset: 0x0040056C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceQuestRequest other)
		{
			return other != null && (other == this || (this.TraceType == other.TraceType && this.QuestId == other.QuestId && this.Operate == other.Operate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B96E RID: 113006 RVA: 0x004023C8 File Offset: 0x004005C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TraceType != 0)
			{
				num ^= this.TraceType.GetHashCode();
			}
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
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

		// Token: 0x0601B96F RID: 113007 RVA: 0x00402439 File Offset: 0x00400639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B970 RID: 113008 RVA: 0x00402446 File Offset: 0x00400646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B971 RID: 113009 RVA: 0x00402450 File Offset: 0x00400650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Operate != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Operate);
			}
			if (this.QuestId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.QuestId);
			}
			if (this.TraceType != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TraceType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B972 RID: 113010 RVA: 0x004024C8 File Offset: 0x004006C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TraceType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TraceType);
			}
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
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

		// Token: 0x0601B973 RID: 113011 RVA: 0x00402538 File Offset: 0x00400738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceQuestRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TraceType != 0)
			{
				this.TraceType = other.TraceType;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.Operate != 0)
			{
				this.Operate = other.Operate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B974 RID: 113012 RVA: 0x0040259C File Offset: 0x0040079C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B975 RID: 113013 RVA: 0x004025A8 File Offset: 0x004007A8
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
				if (num != 40U)
				{
					if (num != 80U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TraceType = input.ReadInt32();
						}
					}
					else
					{
						this.QuestId = input.ReadInt32();
					}
				}
				else
				{
					this.Operate = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A060 RID: 41056
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A061 RID: 41057
		public const int TraceTypeFieldNumber = 13;

		// Token: 0x0400A062 RID: 41058
		private int traceType_;

		// Token: 0x0400A063 RID: 41059
		public const int QuestIdFieldNumber = 10;

		// Token: 0x0400A064 RID: 41060
		private int questId_;

		// Token: 0x0400A065 RID: 41061
		public const int OperateFieldNumber = 5;

		// Token: 0x0400A066 RID: 41062
		private int operate_;
	}
}
