using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E00 RID: 3584
	public sealed class QuestFinishActionCtxPb : IMessage<QuestFinishActionCtxPb>, IMessage, IEquatable<QuestFinishActionCtxPb>, IDeepCloneable<QuestFinishActionCtxPb>, IBufferMessage
	{
		// Token: 0x060134A4 RID: 79012 RVA: 0x002CF3C8 File Offset: 0x002CD5C8
		[NullableContext(1)]
		public static QuestFinishActionCtxPb Create()
		{
			return new QuestFinishActionCtxPb();
		}

		// Token: 0x17003FFF RID: 16383
		// (get) Token: 0x060134A5 RID: 79013 RVA: 0x002CF3CF File Offset: 0x002CD5CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004000 RID: 16384
		// (get) Token: 0x060134A6 RID: 79014 RVA: 0x002CF3D2 File Offset: 0x002CD5D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFinishActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060134A7 RID: 79015 RVA: 0x002CF3D9 File Offset: 0x002CD5D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionCtxPb()
		{
		}

		// Token: 0x060134A8 RID: 79016 RVA: 0x002CF3E1 File Offset: 0x002CD5E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionCtxPb(QuestFinishActionCtxPb other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060134A9 RID: 79017 RVA: 0x002CF406 File Offset: 0x002CD606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionCtxPb Clone()
		{
			return new QuestFinishActionCtxPb(this);
		}

		// Token: 0x17004001 RID: 16385
		// (get) Token: 0x060134AA RID: 79018 RVA: 0x002CF40E File Offset: 0x002CD60E
		// (set) Token: 0x060134AB RID: 79019 RVA: 0x002CF416 File Offset: 0x002CD616
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

		// Token: 0x060134AC RID: 79020 RVA: 0x002CF41F File Offset: 0x002CD61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFinishActionCtxPb);
		}

		// Token: 0x060134AD RID: 79021 RVA: 0x002CF42D File Offset: 0x002CD62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFinishActionCtxPb other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060134AE RID: 79022 RVA: 0x002CF45C File Offset: 0x002CD65C
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

		// Token: 0x060134AF RID: 79023 RVA: 0x002CF49B File Offset: 0x002CD69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060134B0 RID: 79024 RVA: 0x002CF4A8 File Offset: 0x002CD6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060134B1 RID: 79025 RVA: 0x002CF4B1 File Offset: 0x002CD6B1
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

		// Token: 0x060134B2 RID: 79026 RVA: 0x002CF4E4 File Offset: 0x002CD6E4
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

		// Token: 0x060134B3 RID: 79027 RVA: 0x002CF522 File Offset: 0x002CD722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestFinishActionCtxPb other)
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

		// Token: 0x060134B4 RID: 79028 RVA: 0x002CF553 File Offset: 0x002CD753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060134B5 RID: 79029 RVA: 0x002CF55C File Offset: 0x002CD75C
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

		// Token: 0x040076F7 RID: 30455
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076F8 RID: 30456
		public const int QuestIdFieldNumber = 1;

		// Token: 0x040076F9 RID: 30457
		private int questId_;
	}
}
