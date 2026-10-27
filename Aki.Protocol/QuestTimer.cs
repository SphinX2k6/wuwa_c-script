using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E31 RID: 3633
	public sealed class QuestTimer : IMessage<QuestTimer>, IMessage, IEquatable<QuestTimer>, IDeepCloneable<QuestTimer>, IBufferMessage
	{
		// Token: 0x06013816 RID: 79894 RVA: 0x002D5A18 File Offset: 0x002D3C18
		[NullableContext(1)]
		public static QuestTimer Create()
		{
			return new QuestTimer();
		}

		// Token: 0x170040AB RID: 16555
		// (get) Token: 0x06013817 RID: 79895 RVA: 0x002D5A1F File Offset: 0x002D3C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestTimer> Parser
		{
			get
			{
				return QuestTimer._parser;
			}
		}

		// Token: 0x170040AC RID: 16556
		// (get) Token: 0x06013818 RID: 79896 RVA: 0x002D5A26 File Offset: 0x002D3C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040AD RID: 16557
		// (get) Token: 0x06013819 RID: 79897 RVA: 0x002D5A29 File Offset: 0x002D3C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestTimer.Descriptor;
			}
		}

		// Token: 0x0601381A RID: 79898 RVA: 0x002D5A30 File Offset: 0x002D3C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTimer()
		{
		}

		// Token: 0x0601381B RID: 79899 RVA: 0x002D5A38 File Offset: 0x002D3C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTimer(QuestTimer other) : this()
		{
			this.status_ = other.status_;
			this.remainTick_ = other.remainTick_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601381C RID: 79900 RVA: 0x002D5A69 File Offset: 0x002D3C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTimer Clone()
		{
			return new QuestTimer(this);
		}

		// Token: 0x170040AE RID: 16558
		// (get) Token: 0x0601381D RID: 79901 RVA: 0x002D5A71 File Offset: 0x002D3C71
		// (set) Token: 0x0601381E RID: 79902 RVA: 0x002D5A79 File Offset: 0x002D3C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x170040AF RID: 16559
		// (get) Token: 0x0601381F RID: 79903 RVA: 0x002D5A82 File Offset: 0x002D3C82
		// (set) Token: 0x06013820 RID: 79904 RVA: 0x002D5A8A File Offset: 0x002D3C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemainTick
		{
			get
			{
				return this.remainTick_;
			}
			set
			{
				this.remainTick_ = value;
			}
		}

		// Token: 0x06013821 RID: 79905 RVA: 0x002D5A93 File Offset: 0x002D3C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestTimer);
		}

		// Token: 0x06013822 RID: 79906 RVA: 0x002D5AA1 File Offset: 0x002D3CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestTimer other)
		{
			return other != null && (other == this || (this.Status == other.Status && this.RemainTick == other.RemainTick && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013823 RID: 79907 RVA: 0x002D5AE0 File Offset: 0x002D3CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.RemainTick != 0)
			{
				num ^= this.RemainTick.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013824 RID: 79908 RVA: 0x002D5B38 File Offset: 0x002D3D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013825 RID: 79909 RVA: 0x002D5B45 File Offset: 0x002D3D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013826 RID: 79910 RVA: 0x002D5B50 File Offset: 0x002D3D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Status != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Status);
			}
			if (this.RemainTick != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RemainTick);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013827 RID: 79911 RVA: 0x002D5BA8 File Offset: 0x002D3DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Status != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			if (this.RemainTick != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemainTick);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013828 RID: 79912 RVA: 0x002D5C00 File Offset: 0x002D3E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestTimer other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			if (other.RemainTick != 0)
			{
				this.RemainTick = other.RemainTick;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013829 RID: 79913 RVA: 0x002D5C50 File Offset: 0x002D3E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601382A RID: 79914 RVA: 0x002D5C5C File Offset: 0x002D3E5C
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RemainTick = input.ReadInt32();
					}
				}
				else
				{
					this.Status = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007773 RID: 30579
		private static readonly MessageParser<QuestTimer> _parser = new MessageParser<QuestTimer>(() => new QuestTimer());

		// Token: 0x04007774 RID: 30580
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007775 RID: 30581
		public const int StatusFieldNumber = 1;

		// Token: 0x04007776 RID: 30582
		private int status_;

		// Token: 0x04007777 RID: 30583
		public const int RemainTickFieldNumber = 2;

		// Token: 0x04007778 RID: 30584
		private int remainTick_;
	}
}
