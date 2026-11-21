using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DFD RID: 3581
	public sealed class QuestDestroyActionCtxPb : IMessage<QuestDestroyActionCtxPb>, IMessage, IEquatable<QuestDestroyActionCtxPb>, IDeepCloneable<QuestDestroyActionCtxPb>, IBufferMessage
	{
		// Token: 0x0601346A RID: 78954 RVA: 0x002CECCD File Offset: 0x002CCECD
		[NullableContext(1)]
		public static QuestDestroyActionCtxPb Create()
		{
			return new QuestDestroyActionCtxPb();
		}

		// Token: 0x17003FF4 RID: 16372
		// (get) Token: 0x0601346B RID: 78955 RVA: 0x002CECD4 File Offset: 0x002CCED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FF5 RID: 16373
		// (get) Token: 0x0601346C RID: 78956 RVA: 0x002CECD7 File Offset: 0x002CCED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestDestroyActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0601346D RID: 78957 RVA: 0x002CECDE File Offset: 0x002CCEDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestDestroyActionCtxPb()
		{
		}

		// Token: 0x0601346E RID: 78958 RVA: 0x002CECE6 File Offset: 0x002CCEE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestDestroyActionCtxPb(QuestDestroyActionCtxPb other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601346F RID: 78959 RVA: 0x002CED0B File Offset: 0x002CCF0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestDestroyActionCtxPb Clone()
		{
			return new QuestDestroyActionCtxPb(this);
		}

		// Token: 0x17003FF6 RID: 16374
		// (get) Token: 0x06013470 RID: 78960 RVA: 0x002CED13 File Offset: 0x002CCF13
		// (set) Token: 0x06013471 RID: 78961 RVA: 0x002CED1B File Offset: 0x002CCF1B
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

		// Token: 0x06013472 RID: 78962 RVA: 0x002CED24 File Offset: 0x002CCF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestDestroyActionCtxPb);
		}

		// Token: 0x06013473 RID: 78963 RVA: 0x002CED32 File Offset: 0x002CCF32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestDestroyActionCtxPb other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013474 RID: 78964 RVA: 0x002CED60 File Offset: 0x002CCF60
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

		// Token: 0x06013475 RID: 78965 RVA: 0x002CED9F File Offset: 0x002CCF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013476 RID: 78966 RVA: 0x002CEDAC File Offset: 0x002CCFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013477 RID: 78967 RVA: 0x002CEDB5 File Offset: 0x002CCFB5
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

		// Token: 0x06013478 RID: 78968 RVA: 0x002CEDE8 File Offset: 0x002CCFE8
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

		// Token: 0x06013479 RID: 78969 RVA: 0x002CEE26 File Offset: 0x002CD026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestDestroyActionCtxPb other)
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

		// Token: 0x0601347A RID: 78970 RVA: 0x002CEE57 File Offset: 0x002CD057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601347B RID: 78971 RVA: 0x002CEE60 File Offset: 0x002CD060
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

		// Token: 0x040076EA RID: 30442
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076EB RID: 30443
		public const int QuestIdFieldNumber = 1;

		// Token: 0x040076EC RID: 30444
		private int questId_;
	}
}
