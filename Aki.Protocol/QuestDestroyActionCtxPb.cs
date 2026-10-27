using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E0D RID: 3597
	public sealed class QuestDestroyActionCtxPb : IMessage<QuestDestroyActionCtxPb>, IMessage, IEquatable<QuestDestroyActionCtxPb>, IDeepCloneable<QuestDestroyActionCtxPb>, IBufferMessage
	{
		// Token: 0x0601354F RID: 79183 RVA: 0x002D0389 File Offset: 0x002CE589
		[NullableContext(1)]
		public static QuestDestroyActionCtxPb Create()
		{
			return new QuestDestroyActionCtxPb();
		}

		// Token: 0x1700401E RID: 16414
		// (get) Token: 0x06013550 RID: 79184 RVA: 0x002D0390 File Offset: 0x002CE590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700401F RID: 16415
		// (get) Token: 0x06013551 RID: 79185 RVA: 0x002D0393 File Offset: 0x002CE593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestDestroyActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06013552 RID: 79186 RVA: 0x002D039A File Offset: 0x002CE59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestDestroyActionCtxPb()
		{
		}

		// Token: 0x06013553 RID: 79187 RVA: 0x002D03A2 File Offset: 0x002CE5A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestDestroyActionCtxPb(QuestDestroyActionCtxPb other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013554 RID: 79188 RVA: 0x002D03C7 File Offset: 0x002CE5C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestDestroyActionCtxPb Clone()
		{
			return new QuestDestroyActionCtxPb(this);
		}

		// Token: 0x17004020 RID: 16416
		// (get) Token: 0x06013555 RID: 79189 RVA: 0x002D03CF File Offset: 0x002CE5CF
		// (set) Token: 0x06013556 RID: 79190 RVA: 0x002D03D7 File Offset: 0x002CE5D7
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

		// Token: 0x06013557 RID: 79191 RVA: 0x002D03E0 File Offset: 0x002CE5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestDestroyActionCtxPb);
		}

		// Token: 0x06013558 RID: 79192 RVA: 0x002D03EE File Offset: 0x002CE5EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestDestroyActionCtxPb other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013559 RID: 79193 RVA: 0x002D041C File Offset: 0x002CE61C
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

		// Token: 0x0601355A RID: 79194 RVA: 0x002D045B File Offset: 0x002CE65B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601355B RID: 79195 RVA: 0x002D0468 File Offset: 0x002CE668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601355C RID: 79196 RVA: 0x002D0471 File Offset: 0x002CE671
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

		// Token: 0x0601355D RID: 79197 RVA: 0x002D04A4 File Offset: 0x002CE6A4
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

		// Token: 0x0601355E RID: 79198 RVA: 0x002D04E2 File Offset: 0x002CE6E2
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

		// Token: 0x0601355F RID: 79199 RVA: 0x002D0513 File Offset: 0x002CE713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013560 RID: 79200 RVA: 0x002D051C File Offset: 0x002CE71C
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

		// Token: 0x040076C0 RID: 30400
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076C1 RID: 30401
		public const int QuestIdFieldNumber = 1;

		// Token: 0x040076C2 RID: 30402
		private int questId_;
	}
}
