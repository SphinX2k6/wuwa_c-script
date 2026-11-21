using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A9 RID: 1705
	[NetMessage(EMessageId.GatherTaskRecordNotify)]
	public sealed class GatherTaskRecordNotify : IMessage<GatherTaskRecordNotify>, IMessage, IEquatable<GatherTaskRecordNotify>, IDeepCloneable<GatherTaskRecordNotify>, IBufferMessage
	{
		// Token: 0x06009CA2 RID: 40098 RVA: 0x0017D043 File Offset: 0x0017B243
		[NullableContext(1)]
		public static GatherTaskRecordNotify Create()
		{
			return new GatherTaskRecordNotify();
		}

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x06009CA3 RID: 40099 RVA: 0x0017D04A File Offset: 0x0017B24A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x06009CA4 RID: 40100 RVA: 0x0017D04D File Offset: 0x0017B24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatherTaskRecordNotify.Descriptor;
			}
		}

		// Token: 0x06009CA5 RID: 40101 RVA: 0x0017D054 File Offset: 0x0017B254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskRecordNotify()
		{
		}

		// Token: 0x06009CA6 RID: 40102 RVA: 0x0017D067 File Offset: 0x0017B267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskRecordNotify(GatherTaskRecordNotify other) : this()
		{
			this.taskDoneInfo_ = other.taskDoneInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009CA7 RID: 40103 RVA: 0x0017D091 File Offset: 0x0017B291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskRecordNotify Clone()
		{
			return new GatherTaskRecordNotify(this);
		}

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x06009CA8 RID: 40104 RVA: 0x0017D099 File Offset: 0x0017B299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TaskDoneInfo> TaskDoneInfo
		{
			get
			{
				return this.taskDoneInfo_;
			}
		}

		// Token: 0x06009CA9 RID: 40105 RVA: 0x0017D0A1 File Offset: 0x0017B2A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatherTaskRecordNotify);
		}

		// Token: 0x06009CAA RID: 40106 RVA: 0x0017D0AF File Offset: 0x0017B2AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatherTaskRecordNotify other)
		{
			return other != null && (other == this || (this.taskDoneInfo_.Equals(other.taskDoneInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009CAB RID: 40107 RVA: 0x0017D0E4 File Offset: 0x0017B2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskDoneInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009CAC RID: 40108 RVA: 0x0017D118 File Offset: 0x0017B318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009CAD RID: 40109 RVA: 0x0017D125 File Offset: 0x0017B325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009CAE RID: 40110 RVA: 0x0017D12E File Offset: 0x0017B32E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskDoneInfo_.WriteTo(ref output, GatherTaskRecordNotify._repeated_taskDoneInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009CAF RID: 40111 RVA: 0x0017D158 File Offset: 0x0017B358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskDoneInfo_.CalculateSize(GatherTaskRecordNotify._repeated_taskDoneInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009CB0 RID: 40112 RVA: 0x0017D191 File Offset: 0x0017B391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GatherTaskRecordNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.taskDoneInfo_.Add(other.taskDoneInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009CB1 RID: 40113 RVA: 0x0017D1BF File Offset: 0x0017B3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009CB2 RID: 40114 RVA: 0x0017D1C8 File Offset: 0x0017B3C8
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskDoneInfo_.AddEntriesFrom(ref input, GatherTaskRecordNotify._repeated_taskDoneInfo_codec);
				}
			}
		}

		// Token: 0x04004A0F RID: 18959
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A10 RID: 18960
		public const int TaskDoneInfoFieldNumber = 9;

		// Token: 0x04004A11 RID: 18961
		private static readonly FieldCodec<TaskDoneInfo> _repeated_taskDoneInfo_codec = FieldCodec.ForMessage<TaskDoneInfo>(74U, Aki.Protocol.TaskDoneInfo.Parser);

		// Token: 0x04004A12 RID: 18962
		private readonly RepeatedField<TaskDoneInfo> taskDoneInfo_ = new RepeatedField<TaskDoneInfo>();
	}
}
