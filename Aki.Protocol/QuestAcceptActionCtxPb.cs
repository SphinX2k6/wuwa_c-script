using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E02 RID: 3586
	public sealed class QuestAcceptActionCtxPb : IMessage<QuestAcceptActionCtxPb>, IMessage, IEquatable<QuestAcceptActionCtxPb>, IDeepCloneable<QuestAcceptActionCtxPb>, IBufferMessage
	{
		// Token: 0x0601347B RID: 78971 RVA: 0x002CE804 File Offset: 0x002CCA04
		[NullableContext(1)]
		public static QuestAcceptActionCtxPb Create()
		{
			return new QuestAcceptActionCtxPb();
		}

		// Token: 0x17003FF5 RID: 16373
		// (get) Token: 0x0601347C RID: 78972 RVA: 0x002CE80B File Offset: 0x002CCA0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FF6 RID: 16374
		// (get) Token: 0x0601347D RID: 78973 RVA: 0x002CE80E File Offset: 0x002CCA0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestAcceptActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0601347E RID: 78974 RVA: 0x002CE815 File Offset: 0x002CCA15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestAcceptActionCtxPb()
		{
		}

		// Token: 0x0601347F RID: 78975 RVA: 0x002CE81D File Offset: 0x002CCA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestAcceptActionCtxPb(QuestAcceptActionCtxPb other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013480 RID: 78976 RVA: 0x002CE842 File Offset: 0x002CCA42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestAcceptActionCtxPb Clone()
		{
			return new QuestAcceptActionCtxPb(this);
		}

		// Token: 0x17003FF7 RID: 16375
		// (get) Token: 0x06013481 RID: 78977 RVA: 0x002CE84A File Offset: 0x002CCA4A
		// (set) Token: 0x06013482 RID: 78978 RVA: 0x002CE852 File Offset: 0x002CCA52
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

		// Token: 0x06013483 RID: 78979 RVA: 0x002CE85B File Offset: 0x002CCA5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestAcceptActionCtxPb);
		}

		// Token: 0x06013484 RID: 78980 RVA: 0x002CE869 File Offset: 0x002CCA69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestAcceptActionCtxPb other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013485 RID: 78981 RVA: 0x002CE898 File Offset: 0x002CCA98
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

		// Token: 0x06013486 RID: 78982 RVA: 0x002CE8D7 File Offset: 0x002CCAD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013487 RID: 78983 RVA: 0x002CE8E4 File Offset: 0x002CCAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013488 RID: 78984 RVA: 0x002CE8ED File Offset: 0x002CCAED
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

		// Token: 0x06013489 RID: 78985 RVA: 0x002CE920 File Offset: 0x002CCB20
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

		// Token: 0x0601348A RID: 78986 RVA: 0x002CE95E File Offset: 0x002CCB5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestAcceptActionCtxPb other)
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

		// Token: 0x0601348B RID: 78987 RVA: 0x002CE98F File Offset: 0x002CCB8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601348C RID: 78988 RVA: 0x002CE998 File Offset: 0x002CCB98
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

		// Token: 0x0400768B RID: 30347
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400768C RID: 30348
		public const int QuestIdFieldNumber = 1;

		// Token: 0x0400768D RID: 30349
		private int questId_;
	}
}
