using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D8 RID: 5080
	[NetMessage(EMessageId.ThroughTrainRequest)]
	public sealed class ThroughTrainRequest : IMessage<ThroughTrainRequest>, IMessage, IEquatable<ThroughTrainRequest>, IDeepCloneable<ThroughTrainRequest>, IBufferMessage
	{
		// Token: 0x0601B06A RID: 110698 RVA: 0x003EF48D File Offset: 0x003ED68D
		[NullableContext(1)]
		public static ThroughTrainRequest Create()
		{
			return new ThroughTrainRequest();
		}

		// Token: 0x17005B84 RID: 23428
		// (get) Token: 0x0601B06B RID: 110699 RVA: 0x003EF494 File Offset: 0x003ED694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B85 RID: 23429
		// (get) Token: 0x0601B06C RID: 110700 RVA: 0x003EF497 File Offset: 0x003ED697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThroughTrainRequest.Descriptor;
			}
		}

		// Token: 0x0601B06D RID: 110701 RVA: 0x003EF49E File Offset: 0x003ED69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainRequest()
		{
		}

		// Token: 0x0601B06E RID: 110702 RVA: 0x003EF4A6 File Offset: 0x003ED6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainRequest(ThroughTrainRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B06F RID: 110703 RVA: 0x003EF4CB File Offset: 0x003ED6CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainRequest Clone()
		{
			return new ThroughTrainRequest(this);
		}

		// Token: 0x17005B86 RID: 23430
		// (get) Token: 0x0601B070 RID: 110704 RVA: 0x003EF4D3 File Offset: 0x003ED6D3
		// (set) Token: 0x0601B071 RID: 110705 RVA: 0x003EF4DB File Offset: 0x003ED6DB
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

		// Token: 0x0601B072 RID: 110706 RVA: 0x003EF4E4 File Offset: 0x003ED6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThroughTrainRequest);
		}

		// Token: 0x0601B073 RID: 110707 RVA: 0x003EF4F2 File Offset: 0x003ED6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThroughTrainRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B074 RID: 110708 RVA: 0x003EF520 File Offset: 0x003ED720
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

		// Token: 0x0601B075 RID: 110709 RVA: 0x003EF55F File Offset: 0x003ED75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B076 RID: 110710 RVA: 0x003EF56C File Offset: 0x003ED76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B077 RID: 110711 RVA: 0x003EF575 File Offset: 0x003ED775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B078 RID: 110712 RVA: 0x003EF5A8 File Offset: 0x003ED7A8
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

		// Token: 0x0601B079 RID: 110713 RVA: 0x003EF5E6 File Offset: 0x003ED7E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThroughTrainRequest other)
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

		// Token: 0x0601B07A RID: 110714 RVA: 0x003EF617 File Offset: 0x003ED817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B07B RID: 110715 RVA: 0x003EF620 File Offset: 0x003ED820
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009DE0 RID: 40416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DE1 RID: 40417
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04009DE2 RID: 40418
		private int activityId_;
	}
}
