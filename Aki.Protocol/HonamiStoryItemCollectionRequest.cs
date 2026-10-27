using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000780 RID: 1920
	[NetMessage(EMessageId.HonamiStoryItemCollectionRequest)]
	public sealed class HonamiStoryItemCollectionRequest : IMessage<HonamiStoryItemCollectionRequest>, IMessage, IEquatable<HonamiStoryItemCollectionRequest>, IDeepCloneable<HonamiStoryItemCollectionRequest>, IBufferMessage
	{
		// Token: 0x0600AD7E RID: 44414 RVA: 0x001A10A1 File Offset: 0x0019F2A1
		[NullableContext(1)]
		public static HonamiStoryItemCollectionRequest Create()
		{
			return new HonamiStoryItemCollectionRequest();
		}

		// Token: 0x170022FF RID: 8959
		// (get) Token: 0x0600AD7F RID: 44415 RVA: 0x001A10A8 File Offset: 0x0019F2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002300 RID: 8960
		// (get) Token: 0x0600AD80 RID: 44416 RVA: 0x001A10AB File Offset: 0x0019F2AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryItemCollectionRequest.Descriptor;
			}
		}

		// Token: 0x0600AD81 RID: 44417 RVA: 0x001A10B2 File Offset: 0x0019F2B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionRequest()
		{
		}

		// Token: 0x0600AD82 RID: 44418 RVA: 0x001A10C5 File Offset: 0x0019F2C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionRequest(HonamiStoryItemCollectionRequest other) : this()
		{
			this.honamiStoryItemCollectionId_ = other.honamiStoryItemCollectionId_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD83 RID: 44419 RVA: 0x001A10FB File Offset: 0x0019F2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionRequest Clone()
		{
			return new HonamiStoryItemCollectionRequest(this);
		}

		// Token: 0x17002301 RID: 8961
		// (get) Token: 0x0600AD84 RID: 44420 RVA: 0x001A1103 File Offset: 0x0019F303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HonamiStoryItemCollectionId
		{
			get
			{
				return this.honamiStoryItemCollectionId_;
			}
		}

		// Token: 0x17002302 RID: 8962
		// (get) Token: 0x0600AD85 RID: 44421 RVA: 0x001A110B File Offset: 0x0019F30B
		// (set) Token: 0x0600AD86 RID: 44422 RVA: 0x001A1113 File Offset: 0x0019F313
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

		// Token: 0x0600AD87 RID: 44423 RVA: 0x001A111C File Offset: 0x0019F31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryItemCollectionRequest);
		}

		// Token: 0x0600AD88 RID: 44424 RVA: 0x001A112C File Offset: 0x0019F32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryItemCollectionRequest other)
		{
			return other != null && (other == this || (this.honamiStoryItemCollectionId_.Equals(other.honamiStoryItemCollectionId_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD89 RID: 44425 RVA: 0x001A117C File Offset: 0x0019F37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.honamiStoryItemCollectionId_.GetHashCode();
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

		// Token: 0x0600AD8A RID: 44426 RVA: 0x001A11C9 File Offset: 0x0019F3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AD8B RID: 44427 RVA: 0x001A11D6 File Offset: 0x0019F3D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD8C RID: 44428 RVA: 0x001A11E0 File Offset: 0x0019F3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.honamiStoryItemCollectionId_.WriteTo(ref output, HonamiStoryItemCollectionRequest._repeated_honamiStoryItemCollectionId_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD8D RID: 44429 RVA: 0x001A1230 File Offset: 0x0019F430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.honamiStoryItemCollectionId_.CalculateSize(HonamiStoryItemCollectionRequest._repeated_honamiStoryItemCollectionId_codec);
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

		// Token: 0x0600AD8E RID: 44430 RVA: 0x001A1284 File Offset: 0x0019F484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryItemCollectionRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.honamiStoryItemCollectionId_.Add(other.honamiStoryItemCollectionId_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AD8F RID: 44431 RVA: 0x001A12D1 File Offset: 0x0019F4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD90 RID: 44432 RVA: 0x001A12DC File Offset: 0x0019F4DC
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
				if (num != 32U && num != 34U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.honamiStoryItemCollectionId_.AddEntriesFrom(ref input, HonamiStoryItemCollectionRequest._repeated_honamiStoryItemCollectionId_codec);
				}
			}
		}

		// Token: 0x04004E76 RID: 20086
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E77 RID: 20087
		public const int HonamiStoryItemCollectionIdFieldNumber = 4;

		// Token: 0x04004E78 RID: 20088
		private static readonly FieldCodec<int> _repeated_honamiStoryItemCollectionId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04004E79 RID: 20089
		private readonly RepeatedField<int> honamiStoryItemCollectionId_ = new RepeatedField<int>();

		// Token: 0x04004E7A RID: 20090
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x04004E7B RID: 20091
		private int activityId_;
	}
}
