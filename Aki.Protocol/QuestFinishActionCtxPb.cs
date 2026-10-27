using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E10 RID: 3600
	public sealed class QuestFinishActionCtxPb : IMessage<QuestFinishActionCtxPb>, IMessage, IEquatable<QuestFinishActionCtxPb>, IDeepCloneable<QuestFinishActionCtxPb>, IBufferMessage
	{
		// Token: 0x06013589 RID: 79241 RVA: 0x002D0A89 File Offset: 0x002CEC89
		[NullableContext(1)]
		public static QuestFinishActionCtxPb Create()
		{
			return new QuestFinishActionCtxPb();
		}

		// Token: 0x17004029 RID: 16425
		// (get) Token: 0x0601358A RID: 79242 RVA: 0x002D0A90 File Offset: 0x002CEC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700402A RID: 16426
		// (get) Token: 0x0601358B RID: 79243 RVA: 0x002D0A93 File Offset: 0x002CEC93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestFinishActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0601358C RID: 79244 RVA: 0x002D0A9A File Offset: 0x002CEC9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionCtxPb()
		{
		}

		// Token: 0x0601358D RID: 79245 RVA: 0x002D0AA2 File Offset: 0x002CECA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionCtxPb(QuestFinishActionCtxPb other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601358E RID: 79246 RVA: 0x002D0AC7 File Offset: 0x002CECC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFinishActionCtxPb Clone()
		{
			return new QuestFinishActionCtxPb(this);
		}

		// Token: 0x1700402B RID: 16427
		// (get) Token: 0x0601358F RID: 79247 RVA: 0x002D0ACF File Offset: 0x002CECCF
		// (set) Token: 0x06013590 RID: 79248 RVA: 0x002D0AD7 File Offset: 0x002CECD7
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

		// Token: 0x06013591 RID: 79249 RVA: 0x002D0AE0 File Offset: 0x002CECE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestFinishActionCtxPb);
		}

		// Token: 0x06013592 RID: 79250 RVA: 0x002D0AEE File Offset: 0x002CECEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestFinishActionCtxPb other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013593 RID: 79251 RVA: 0x002D0B1C File Offset: 0x002CED1C
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

		// Token: 0x06013594 RID: 79252 RVA: 0x002D0B5B File Offset: 0x002CED5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013595 RID: 79253 RVA: 0x002D0B68 File Offset: 0x002CED68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013596 RID: 79254 RVA: 0x002D0B71 File Offset: 0x002CED71
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

		// Token: 0x06013597 RID: 79255 RVA: 0x002D0BA4 File Offset: 0x002CEDA4
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

		// Token: 0x06013598 RID: 79256 RVA: 0x002D0BE2 File Offset: 0x002CEDE2
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

		// Token: 0x06013599 RID: 79257 RVA: 0x002D0C13 File Offset: 0x002CEE13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601359A RID: 79258 RVA: 0x002D0C1C File Offset: 0x002CEE1C
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

		// Token: 0x040076CD RID: 30413
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076CE RID: 30414
		public const int QuestIdFieldNumber = 1;

		// Token: 0x040076CF RID: 30415
		private int questId_;
	}
}
