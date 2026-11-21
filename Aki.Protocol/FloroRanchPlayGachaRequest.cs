using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A9 RID: 1449
	[NetMessage(EMessageId.FloroRanchPlayGachaRequest)]
	public sealed class FloroRanchPlayGachaRequest : IMessage<FloroRanchPlayGachaRequest>, IMessage, IEquatable<FloroRanchPlayGachaRequest>, IDeepCloneable<FloroRanchPlayGachaRequest>, IBufferMessage
	{
		// Token: 0x06008663 RID: 34403 RVA: 0x00143F8F File Offset: 0x0014218F
		[NullableContext(1)]
		public static FloroRanchPlayGachaRequest Create()
		{
			return new FloroRanchPlayGachaRequest();
		}

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x06008664 RID: 34404 RVA: 0x00143F96 File Offset: 0x00142196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x06008665 RID: 34405 RVA: 0x00143F99 File Offset: 0x00142199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayGachaRequest.Descriptor;
			}
		}

		// Token: 0x06008666 RID: 34406 RVA: 0x00143FA0 File Offset: 0x001421A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaRequest()
		{
		}

		// Token: 0x06008667 RID: 34407 RVA: 0x00143FA8 File Offset: 0x001421A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaRequest(FloroRanchPlayGachaRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.cardId_ = other.cardId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008668 RID: 34408 RVA: 0x00143FFC File Offset: 0x001421FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaRequest Clone()
		{
			return new FloroRanchPlayGachaRequest(this);
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x06008669 RID: 34409 RVA: 0x00144004 File Offset: 0x00142204
		// (set) Token: 0x0600866A RID: 34410 RVA: 0x0014400C File Offset: 0x0014220C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x0600866B RID: 34411 RVA: 0x00144015 File Offset: 0x00142215
		// (set) Token: 0x0600866C RID: 34412 RVA: 0x0014401D File Offset: 0x0014221D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x0600866D RID: 34413 RVA: 0x00144026 File Offset: 0x00142226
		// (set) Token: 0x0600866E RID: 34414 RVA: 0x0014402E File Offset: 0x0014222E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardId
		{
			get
			{
				return this.cardId_;
			}
			set
			{
				this.cardId_ = value;
			}
		}

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x0600866F RID: 34415 RVA: 0x00144037 File Offset: 0x00142237
		// (set) Token: 0x06008670 RID: 34416 RVA: 0x0014403F File Offset: 0x0014223F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x06008671 RID: 34417 RVA: 0x00144048 File Offset: 0x00142248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayGachaRequest);
		}

		// Token: 0x06008672 RID: 34418 RVA: 0x00144058 File Offset: 0x00142258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayGachaRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.CardId == other.CardId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008673 RID: 34419 RVA: 0x001440C4 File Offset: 0x001422C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this.CardId != 0)
			{
				num ^= this.CardId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008674 RID: 34420 RVA: 0x0014414E File Offset: 0x0014234E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008675 RID: 34421 RVA: 0x0014415B File Offset: 0x0014235B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008676 RID: 34422 RVA: 0x00144164 File Offset: 0x00142364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SubInsId);
			}
			if (this.CardId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.CardId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008677 RID: 34423 RVA: 0x001441F8 File Offset: 0x001423F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this.CardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008678 RID: 34424 RVA: 0x00144280 File Offset: 0x00142480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayGachaRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			if (other.CardId != 0)
			{
				this.CardId = other.CardId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008679 RID: 34425 RVA: 0x001442F8 File Offset: 0x001424F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600867A RID: 34426 RVA: 0x00144304 File Offset: 0x00142504
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
				if (num <= 56U)
				{
					if (num == 40U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.SubInsId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.CardId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040042D4 RID: 17108
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042D5 RID: 17109
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x040042D6 RID: 17110
		private int activityId_;

		// Token: 0x040042D7 RID: 17111
		public const int SubInsIdFieldNumber = 7;

		// Token: 0x040042D8 RID: 17112
		private int subInsId_;

		// Token: 0x040042D9 RID: 17113
		public const int CardIdFieldNumber = 10;

		// Token: 0x040042DA RID: 17114
		private int cardId_;

		// Token: 0x040042DB RID: 17115
		public const int IncIdFieldNumber = 11;

		// Token: 0x040042DC RID: 17116
		private int incId_;
	}
}
