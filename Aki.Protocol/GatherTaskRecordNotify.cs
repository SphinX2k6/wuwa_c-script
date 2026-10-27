using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006BD RID: 1725
	[NetMessage(EMessageId.GatherTaskRecordNotify)]
	public sealed class GatherTaskRecordNotify : IMessage<GatherTaskRecordNotify>, IMessage, IEquatable<GatherTaskRecordNotify>, IDeepCloneable<GatherTaskRecordNotify>, IBufferMessage
	{
		// Token: 0x06009DF8 RID: 40440 RVA: 0x0017FA73 File Offset: 0x0017DC73
		[NullableContext(1)]
		public static GatherTaskRecordNotify Create()
		{
			return new GatherTaskRecordNotify();
		}

		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x06009DF9 RID: 40441 RVA: 0x0017FA7A File Offset: 0x0017DC7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x06009DFA RID: 40442 RVA: 0x0017FA7D File Offset: 0x0017DC7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatherTaskRecordNotify.Descriptor;
			}
		}

		// Token: 0x06009DFB RID: 40443 RVA: 0x0017FA84 File Offset: 0x0017DC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskRecordNotify()
		{
		}

		// Token: 0x06009DFC RID: 40444 RVA: 0x0017FA97 File Offset: 0x0017DC97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskRecordNotify(GatherTaskRecordNotify other) : this()
		{
			this.taskDoneInfo_ = other.taskDoneInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DFD RID: 40445 RVA: 0x0017FAC1 File Offset: 0x0017DCC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskRecordNotify Clone()
		{
			return new GatherTaskRecordNotify(this);
		}

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x06009DFE RID: 40446 RVA: 0x0017FAC9 File Offset: 0x0017DCC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TaskDoneInfo> TaskDoneInfo
		{
			get
			{
				return this.taskDoneInfo_;
			}
		}

		// Token: 0x06009DFF RID: 40447 RVA: 0x0017FAD1 File Offset: 0x0017DCD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatherTaskRecordNotify);
		}

		// Token: 0x06009E00 RID: 40448 RVA: 0x0017FADF File Offset: 0x0017DCDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatherTaskRecordNotify other)
		{
			return other != null && (other == this || (this.taskDoneInfo_.Equals(other.taskDoneInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E01 RID: 40449 RVA: 0x0017FB14 File Offset: 0x0017DD14
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

		// Token: 0x06009E02 RID: 40450 RVA: 0x0017FB48 File Offset: 0x0017DD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E03 RID: 40451 RVA: 0x0017FB55 File Offset: 0x0017DD55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E04 RID: 40452 RVA: 0x0017FB5E File Offset: 0x0017DD5E
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

		// Token: 0x06009E05 RID: 40453 RVA: 0x0017FB88 File Offset: 0x0017DD88
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

		// Token: 0x06009E06 RID: 40454 RVA: 0x0017FBC1 File Offset: 0x0017DDC1
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

		// Token: 0x06009E07 RID: 40455 RVA: 0x0017FBEF File Offset: 0x0017DDEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E08 RID: 40456 RVA: 0x0017FBF8 File Offset: 0x0017DDF8
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskDoneInfo_.AddEntriesFrom(ref input, GatherTaskRecordNotify._repeated_taskDoneInfo_codec);
				}
			}
		}

		// Token: 0x04004A16 RID: 18966
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A17 RID: 18967
		public const int TaskDoneInfoFieldNumber = 8;

		// Token: 0x04004A18 RID: 18968
		private static readonly FieldCodec<TaskDoneInfo> _repeated_taskDoneInfo_codec = FieldCodec.ForMessage<TaskDoneInfo>(66U, Aki.Protocol.TaskDoneInfo.Parser);

		// Token: 0x04004A19 RID: 18969
		private readonly RepeatedField<TaskDoneInfo> taskDoneInfo_ = new RepeatedField<TaskDoneInfo>();
	}
}
