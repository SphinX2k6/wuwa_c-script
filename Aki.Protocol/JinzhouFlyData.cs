using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000850 RID: 2128
	public sealed class JinzhouFlyData : IMessage<JinzhouFlyData>, IMessage, IEquatable<JinzhouFlyData>, IDeepCloneable<JinzhouFlyData>, IBufferMessage
	{
		// Token: 0x0600BE13 RID: 48659 RVA: 0x001C4123 File Offset: 0x001C2323
		[NullableContext(1)]
		public static JinzhouFlyData Create()
		{
			return new JinzhouFlyData();
		}

		// Token: 0x1700265F RID: 9823
		// (get) Token: 0x0600BE14 RID: 48660 RVA: 0x001C412A File Offset: 0x001C232A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002660 RID: 9824
		// (get) Token: 0x0600BE15 RID: 48661 RVA: 0x001C412D File Offset: 0x001C232D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JinzhouFlyData.Descriptor;
			}
		}

		// Token: 0x0600BE16 RID: 48662 RVA: 0x001C4134 File Offset: 0x001C2334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JinzhouFlyData()
		{
		}

		// Token: 0x0600BE17 RID: 48663 RVA: 0x001C413C File Offset: 0x001C233C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JinzhouFlyData(JinzhouFlyData other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE18 RID: 48664 RVA: 0x001C4161 File Offset: 0x001C2361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JinzhouFlyData Clone()
		{
			return new JinzhouFlyData(this);
		}

		// Token: 0x17002661 RID: 9825
		// (get) Token: 0x0600BE19 RID: 48665 RVA: 0x001C4169 File Offset: 0x001C2369
		// (set) Token: 0x0600BE1A RID: 48666 RVA: 0x001C4171 File Offset: 0x001C2371
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

		// Token: 0x0600BE1B RID: 48667 RVA: 0x001C417A File Offset: 0x001C237A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JinzhouFlyData);
		}

		// Token: 0x0600BE1C RID: 48668 RVA: 0x001C4188 File Offset: 0x001C2388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JinzhouFlyData other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE1D RID: 48669 RVA: 0x001C41B8 File Offset: 0x001C23B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BE1E RID: 48670 RVA: 0x001C41F7 File Offset: 0x001C23F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BE1F RID: 48671 RVA: 0x001C4204 File Offset: 0x001C2404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE20 RID: 48672 RVA: 0x001C420D File Offset: 0x001C240D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE21 RID: 48673 RVA: 0x001C4240 File Offset: 0x001C2440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BE22 RID: 48674 RVA: 0x001C427E File Offset: 0x001C247E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JinzhouFlyData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BE23 RID: 48675 RVA: 0x001C42AF File Offset: 0x001C24AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE24 RID: 48676 RVA: 0x001C42B8 File Offset: 0x001C24B8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400534F RID: 21327
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005350 RID: 21328
		public const int QuestIdFieldNumber = 1;

		// Token: 0x04005351 RID: 21329
		private int questId_;
	}
}
