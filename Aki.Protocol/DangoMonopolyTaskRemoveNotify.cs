using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000391 RID: 913
	[NetMessage(EMessageId.DangoMonopolyTaskRemoveNotify)]
	public sealed class DangoMonopolyTaskRemoveNotify : IMessage<DangoMonopolyTaskRemoveNotify>, IMessage, IEquatable<DangoMonopolyTaskRemoveNotify>, IDeepCloneable<DangoMonopolyTaskRemoveNotify>, IBufferMessage
	{
		// Token: 0x06005A2F RID: 23087 RVA: 0x000DB880 File Offset: 0x000D9A80
		[NullableContext(1)]
		public static DangoMonopolyTaskRemoveNotify Create()
		{
			return new DangoMonopolyTaskRemoveNotify();
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06005A30 RID: 23088 RVA: 0x000DB887 File Offset: 0x000D9A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06005A31 RID: 23089 RVA: 0x000DB88A File Offset: 0x000D9A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyTaskRemoveNotify.Descriptor;
			}
		}

		// Token: 0x06005A32 RID: 23090 RVA: 0x000DB891 File Offset: 0x000D9A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRemoveNotify()
		{
		}

		// Token: 0x06005A33 RID: 23091 RVA: 0x000DB8A4 File Offset: 0x000D9AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRemoveNotify(DangoMonopolyTaskRemoveNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A34 RID: 23092 RVA: 0x000DB8DA File Offset: 0x000D9ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRemoveNotify Clone()
		{
			return new DangoMonopolyTaskRemoveNotify(this);
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06005A35 RID: 23093 RVA: 0x000DB8E2 File Offset: 0x000D9AE2
		// (set) Token: 0x06005A36 RID: 23094 RVA: 0x000DB8EA File Offset: 0x000D9AEA
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

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06005A37 RID: 23095 RVA: 0x000DB8F3 File Offset: 0x000D9AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x06005A38 RID: 23096 RVA: 0x000DB8FB File Offset: 0x000D9AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyTaskRemoveNotify);
		}

		// Token: 0x06005A39 RID: 23097 RVA: 0x000DB90C File Offset: 0x000D9B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyTaskRemoveNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A3A RID: 23098 RVA: 0x000DB95C File Offset: 0x000D9B5C
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

		// Token: 0x06005A3B RID: 23099 RVA: 0x000DB9A9 File Offset: 0x000D9BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005A3C RID: 23100 RVA: 0x000DB9B6 File Offset: 0x000D9BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A3D RID: 23101 RVA: 0x000DB9C0 File Offset: 0x000D9BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, DangoMonopolyTaskRemoveNotify._repeated_taskIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A3E RID: 23102 RVA: 0x000DBA10 File Offset: 0x000D9C10
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

		// Token: 0x06005A3F RID: 23103 RVA: 0x000DBA64 File Offset: 0x000D9C64
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

		// Token: 0x06005A40 RID: 23104 RVA: 0x000DBAB1 File Offset: 0x000D9CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A41 RID: 23105 RVA: 0x000DBABC File Offset: 0x000D9CBC
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
				if (num != 16U && num != 18U)
				{
					if (num != 40U)
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
					this.taskIds_.AddEntriesFrom(ref input, DangoMonopolyTaskRemoveNotify._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x040035A2 RID: 13730
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035A3 RID: 13731
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x040035A4 RID: 13732
		private int activityId_;

		// Token: 0x040035A5 RID: 13733
		public const int TaskIdsFieldNumber = 2;

		// Token: 0x040035A6 RID: 13734
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040035A7 RID: 13735
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
