using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000399 RID: 921
	[NetMessage(EMessageId.DangoMonopolyTaskRemoveNotify)]
	public sealed class DangoMonopolyTaskRemoveNotify : IMessage<DangoMonopolyTaskRemoveNotify>, IMessage, IEquatable<DangoMonopolyTaskRemoveNotify>, IDeepCloneable<DangoMonopolyTaskRemoveNotify>, IBufferMessage
	{
		// Token: 0x06005B1C RID: 23324 RVA: 0x000DDF08 File Offset: 0x000DC108
		[NullableContext(1)]
		public static DangoMonopolyTaskRemoveNotify Create()
		{
			return new DangoMonopolyTaskRemoveNotify();
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06005B1D RID: 23325 RVA: 0x000DDF0F File Offset: 0x000DC10F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06005B1E RID: 23326 RVA: 0x000DDF12 File Offset: 0x000DC112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyTaskRemoveNotify.Descriptor;
			}
		}

		// Token: 0x06005B1F RID: 23327 RVA: 0x000DDF19 File Offset: 0x000DC119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRemoveNotify()
		{
		}

		// Token: 0x06005B20 RID: 23328 RVA: 0x000DDF2C File Offset: 0x000DC12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRemoveNotify(DangoMonopolyTaskRemoveNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B21 RID: 23329 RVA: 0x000DDF62 File Offset: 0x000DC162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRemoveNotify Clone()
		{
			return new DangoMonopolyTaskRemoveNotify(this);
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06005B22 RID: 23330 RVA: 0x000DDF6A File Offset: 0x000DC16A
		// (set) Token: 0x06005B23 RID: 23331 RVA: 0x000DDF72 File Offset: 0x000DC172
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

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06005B24 RID: 23332 RVA: 0x000DDF7B File Offset: 0x000DC17B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x06005B25 RID: 23333 RVA: 0x000DDF83 File Offset: 0x000DC183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyTaskRemoveNotify);
		}

		// Token: 0x06005B26 RID: 23334 RVA: 0x000DDF94 File Offset: 0x000DC194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyTaskRemoveNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B27 RID: 23335 RVA: 0x000DDFE4 File Offset: 0x000DC1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005B28 RID: 23336 RVA: 0x000DE031 File Offset: 0x000DC231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005B29 RID: 23337 RVA: 0x000DE03E File Offset: 0x000DC23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B2A RID: 23338 RVA: 0x000DE048 File Offset: 0x000DC248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			this.taskIds_.WriteTo(ref output, DangoMonopolyTaskRemoveNotify._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B2B RID: 23339 RVA: 0x000DE098 File Offset: 0x000DC298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskIds_.CalculateSize(DangoMonopolyTaskRemoveNotify._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005B2C RID: 23340 RVA: 0x000DE0EC File Offset: 0x000DC2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyTaskRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B2D RID: 23341 RVA: 0x000DE139 File Offset: 0x000DC339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B2E RID: 23342 RVA: 0x000DE144 File Offset: 0x000DC344
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
				if (num != 48U)
				{
					if (num != 120U && num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskIds_.AddEntriesFrom(ref input, DangoMonopolyTaskRemoveNotify._repeated_taskIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400363E RID: 13886
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400363F RID: 13887
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04003640 RID: 13888
		private int activityId_;

		// Token: 0x04003641 RID: 13889
		public const int TaskIdsFieldNumber = 15;

		// Token: 0x04003642 RID: 13890
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04003643 RID: 13891
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
