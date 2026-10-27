using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E32 RID: 3634
	public sealed class QuestTimerNotify : IMessage<QuestTimerNotify>, IMessage, IEquatable<QuestTimerNotify>, IDeepCloneable<QuestTimerNotify>, IBufferMessage
	{
		// Token: 0x0601382C RID: 79916 RVA: 0x002D5CCF File Offset: 0x002D3ECF
		[NullableContext(1)]
		public static QuestTimerNotify Create()
		{
			return new QuestTimerNotify();
		}

		// Token: 0x170040B0 RID: 16560
		// (get) Token: 0x0601382D RID: 79917 RVA: 0x002D5CD6 File Offset: 0x002D3ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040B1 RID: 16561
		// (get) Token: 0x0601382E RID: 79918 RVA: 0x002D5CD9 File Offset: 0x002D3ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestTimerNotify.Descriptor;
			}
		}

		// Token: 0x0601382F RID: 79919 RVA: 0x002D5CE0 File Offset: 0x002D3EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTimerNotify()
		{
		}

		// Token: 0x06013830 RID: 79920 RVA: 0x002D5CF3 File Offset: 0x002D3EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTimerNotify(QuestTimerNotify other) : this()
		{
			this.questTimers_ = other.questTimers_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013831 RID: 79921 RVA: 0x002D5D1D File Offset: 0x002D3F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestTimerNotify Clone()
		{
			return new QuestTimerNotify(this);
		}

		// Token: 0x170040B2 RID: 16562
		// (get) Token: 0x06013832 RID: 79922 RVA: 0x002D5D25 File Offset: 0x002D3F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, QuestTimer> QuestTimers
		{
			get
			{
				return this.questTimers_;
			}
		}

		// Token: 0x06013833 RID: 79923 RVA: 0x002D5D2D File Offset: 0x002D3F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestTimerNotify);
		}

		// Token: 0x06013834 RID: 79924 RVA: 0x002D5D3B File Offset: 0x002D3F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestTimerNotify other)
		{
			return other != null && (other == this || (this.QuestTimers.Equals(other.QuestTimers) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013835 RID: 79925 RVA: 0x002D5D70 File Offset: 0x002D3F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.QuestTimers.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013836 RID: 79926 RVA: 0x002D5DA4 File Offset: 0x002D3FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013837 RID: 79927 RVA: 0x002D5DB1 File Offset: 0x002D3FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013838 RID: 79928 RVA: 0x002D5DBA File Offset: 0x002D3FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questTimers_.WriteTo(ref output, QuestTimerNotify._map_questTimers_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013839 RID: 79929 RVA: 0x002D5DE4 File Offset: 0x002D3FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questTimers_.CalculateSize(QuestTimerNotify._map_questTimers_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601383A RID: 79930 RVA: 0x002D5E1D File Offset: 0x002D401D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestTimerNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questTimers_.MergeFrom(other.questTimers_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601383B RID: 79931 RVA: 0x002D5E4B File Offset: 0x002D404B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601383C RID: 79932 RVA: 0x002D5E54 File Offset: 0x002D4054
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questTimers_.AddEntriesFrom(ref input, QuestTimerNotify._map_questTimers_codec);
				}
			}
		}

		// Token: 0x04007779 RID: 30585
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400777A RID: 30586
		public const int QuestTimersFieldNumber = 1;

		// Token: 0x0400777B RID: 30587
		private static readonly MapField<int, QuestTimer>.Codec _map_questTimers_codec = new MapField<int, QuestTimer>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<QuestTimer>(18U, QuestTimer.Parser), 10U);

		// Token: 0x0400777C RID: 30588
		private readonly MapField<int, QuestTimer> questTimers_ = new MapField<int, QuestTimer>();
	}
}
