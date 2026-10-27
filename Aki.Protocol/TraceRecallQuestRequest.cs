using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D9 RID: 5081
	[NetMessage(EMessageId.TraceRecallQuestRequest)]
	public sealed class TraceRecallQuestRequest : IMessage<TraceRecallQuestRequest>, IMessage, IEquatable<TraceRecallQuestRequest>, IDeepCloneable<TraceRecallQuestRequest>, IBufferMessage
	{
		// Token: 0x0601AF0F RID: 110351 RVA: 0x003E7701 File Offset: 0x003E5901
		[NullableContext(1)]
		public static TraceRecallQuestRequest Create()
		{
			return new TraceRecallQuestRequest();
		}

		// Token: 0x17005AD6 RID: 23254
		// (get) Token: 0x0601AF10 RID: 110352 RVA: 0x003E7708 File Offset: 0x003E5908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AD7 RID: 23255
		// (get) Token: 0x0601AF11 RID: 110353 RVA: 0x003E770B File Offset: 0x003E590B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceRecallQuestRequest.Descriptor;
			}
		}

		// Token: 0x0601AF12 RID: 110354 RVA: 0x003E7712 File Offset: 0x003E5912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestRequest()
		{
		}

		// Token: 0x0601AF13 RID: 110355 RVA: 0x003E771A File Offset: 0x003E591A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestRequest(TraceRecallQuestRequest other) : this()
		{
			this.traceType_ = other.traceType_;
			this.recallQuestId_ = other.recallQuestId_;
			this.operate_ = other.operate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AF14 RID: 110356 RVA: 0x003E7757 File Offset: 0x003E5957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceRecallQuestRequest Clone()
		{
			return new TraceRecallQuestRequest(this);
		}

		// Token: 0x17005AD8 RID: 23256
		// (get) Token: 0x0601AF15 RID: 110357 RVA: 0x003E775F File Offset: 0x003E595F
		// (set) Token: 0x0601AF16 RID: 110358 RVA: 0x003E7767 File Offset: 0x003E5967
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

		// Token: 0x17005AD9 RID: 23257
		// (get) Token: 0x0601AF17 RID: 110359 RVA: 0x003E7770 File Offset: 0x003E5970
		// (set) Token: 0x0601AF18 RID: 110360 RVA: 0x003E7778 File Offset: 0x003E5978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallQuestId
		{
			get
			{
				return this.recallQuestId_;
			}
			set
			{
				this.recallQuestId_ = value;
			}
		}

		// Token: 0x17005ADA RID: 23258
		// (get) Token: 0x0601AF19 RID: 110361 RVA: 0x003E7781 File Offset: 0x003E5981
		// (set) Token: 0x0601AF1A RID: 110362 RVA: 0x003E7789 File Offset: 0x003E5989
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

		// Token: 0x0601AF1B RID: 110363 RVA: 0x003E7792 File Offset: 0x003E5992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceRecallQuestRequest);
		}

		// Token: 0x0601AF1C RID: 110364 RVA: 0x003E77A0 File Offset: 0x003E59A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceRecallQuestRequest other)
		{
			return other != null && (other == this || (this.TraceType == other.TraceType && this.RecallQuestId == other.RecallQuestId && this.Operate == other.Operate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AF1D RID: 110365 RVA: 0x003E77FC File Offset: 0x003E59FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TraceType != 0)
			{
				num ^= this.TraceType.GetHashCode();
			}
			if (this.RecallQuestId != 0)
			{
				num ^= this.RecallQuestId.GetHashCode();
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

		// Token: 0x0601AF1E RID: 110366 RVA: 0x003E786D File Offset: 0x003E5A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AF1F RID: 110367 RVA: 0x003E787A File Offset: 0x003E5A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AF20 RID: 110368 RVA: 0x003E7884 File Offset: 0x003E5A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Operate != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Operate);
			}
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this.TraceType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TraceType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AF21 RID: 110369 RVA: 0x003E78FC File Offset: 0x003E5AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TraceType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TraceType);
			}
			if (this.RecallQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallQuestId);
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

		// Token: 0x0601AF22 RID: 110370 RVA: 0x003E796C File Offset: 0x003E5B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceRecallQuestRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TraceType != 0)
			{
				this.TraceType = other.TraceType;
			}
			if (other.RecallQuestId != 0)
			{
				this.RecallQuestId = other.RecallQuestId;
			}
			if (other.Operate != 0)
			{
				this.Operate = other.Operate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AF23 RID: 110371 RVA: 0x003E79D0 File Offset: 0x003E5BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AF24 RID: 110372 RVA: 0x003E79DC File Offset: 0x003E5BDC
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
				if (num != 16U)
				{
					if (num != 32U)
					{
						if (num != 40U)
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
						this.RecallQuestId = input.ReadInt32();
					}
				}
				else
				{
					this.Operate = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009C26 RID: 39974
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C27 RID: 39975
		public const int TraceTypeFieldNumber = 5;

		// Token: 0x04009C28 RID: 39976
		private int traceType_;

		// Token: 0x04009C29 RID: 39977
		public const int RecallQuestIdFieldNumber = 4;

		// Token: 0x04009C2A RID: 39978
		private int recallQuestId_;

		// Token: 0x04009C2B RID: 39979
		public const int OperateFieldNumber = 2;

		// Token: 0x04009C2C RID: 39980
		private int operate_;
	}
}
