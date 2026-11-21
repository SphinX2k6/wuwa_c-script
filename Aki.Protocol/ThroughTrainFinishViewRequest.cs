using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D5 RID: 5077
	[NetMessage(EMessageId.ThroughTrainFinishViewRequest)]
	public sealed class ThroughTrainFinishViewRequest : IMessage<ThroughTrainFinishViewRequest>, IMessage, IEquatable<ThroughTrainFinishViewRequest>, IDeepCloneable<ThroughTrainFinishViewRequest>, IBufferMessage
	{
		// Token: 0x0601B034 RID: 110644 RVA: 0x003EEEFC File Offset: 0x003ED0FC
		[NullableContext(1)]
		public static ThroughTrainFinishViewRequest Create()
		{
			return new ThroughTrainFinishViewRequest();
		}

		// Token: 0x17005B7B RID: 23419
		// (get) Token: 0x0601B035 RID: 110645 RVA: 0x003EEF03 File Offset: 0x003ED103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B7C RID: 23420
		// (get) Token: 0x0601B036 RID: 110646 RVA: 0x003EEF06 File Offset: 0x003ED106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThroughTrainFinishViewRequest.Descriptor;
			}
		}

		// Token: 0x0601B037 RID: 110647 RVA: 0x003EEF0D File Offset: 0x003ED10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainFinishViewRequest()
		{
		}

		// Token: 0x0601B038 RID: 110648 RVA: 0x003EEF15 File Offset: 0x003ED115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainFinishViewRequest(ThroughTrainFinishViewRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B039 RID: 110649 RVA: 0x003EEF3A File Offset: 0x003ED13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainFinishViewRequest Clone()
		{
			return new ThroughTrainFinishViewRequest(this);
		}

		// Token: 0x17005B7D RID: 23421
		// (get) Token: 0x0601B03A RID: 110650 RVA: 0x003EEF42 File Offset: 0x003ED142
		// (set) Token: 0x0601B03B RID: 110651 RVA: 0x003EEF4A File Offset: 0x003ED14A
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

		// Token: 0x0601B03C RID: 110652 RVA: 0x003EEF53 File Offset: 0x003ED153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThroughTrainFinishViewRequest);
		}

		// Token: 0x0601B03D RID: 110653 RVA: 0x003EEF61 File Offset: 0x003ED161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThroughTrainFinishViewRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B03E RID: 110654 RVA: 0x003EEF90 File Offset: 0x003ED190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B03F RID: 110655 RVA: 0x003EEFCF File Offset: 0x003ED1CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B040 RID: 110656 RVA: 0x003EEFDC File Offset: 0x003ED1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B041 RID: 110657 RVA: 0x003EEFE5 File Offset: 0x003ED1E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B042 RID: 110658 RVA: 0x003EF018 File Offset: 0x003ED218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B043 RID: 110659 RVA: 0x003EF056 File Offset: 0x003ED256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThroughTrainFinishViewRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B044 RID: 110660 RVA: 0x003EF087 File Offset: 0x003ED287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B045 RID: 110661 RVA: 0x003EF090 File Offset: 0x003ED290
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009DD7 RID: 40407
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DD8 RID: 40408
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04009DD9 RID: 40409
		private int activityId_;
	}
}
