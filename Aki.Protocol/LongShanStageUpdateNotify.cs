using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000955 RID: 2389
	[NetMessage(EMessageId.LongShanStageUpdateNotify)]
	public sealed class LongShanStageUpdateNotify : IMessage<LongShanStageUpdateNotify>, IMessage, IEquatable<LongShanStageUpdateNotify>, IDeepCloneable<LongShanStageUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600D28E RID: 53902 RVA: 0x001F087B File Offset: 0x001EEA7B
		[NullableContext(1)]
		public static LongShanStageUpdateNotify Create()
		{
			return new LongShanStageUpdateNotify();
		}

		// Token: 0x17002AA0 RID: 10912
		// (get) Token: 0x0600D28F RID: 53903 RVA: 0x001F0882 File Offset: 0x001EEA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AA1 RID: 10913
		// (get) Token: 0x0600D290 RID: 53904 RVA: 0x001F0885 File Offset: 0x001EEA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongShanStageUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600D291 RID: 53905 RVA: 0x001F088C File Offset: 0x001EEA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanStageUpdateNotify()
		{
		}

		// Token: 0x0600D292 RID: 53906 RVA: 0x001F089F File Offset: 0x001EEA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanStageUpdateNotify(LongShanStageUpdateNotify other) : this()
		{
			this.stages_ = other.stages_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D293 RID: 53907 RVA: 0x001F08C9 File Offset: 0x001EEAC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanStageUpdateNotify Clone()
		{
			return new LongShanStageUpdateNotify(this);
		}

		// Token: 0x17002AA2 RID: 10914
		// (get) Token: 0x0600D294 RID: 53908 RVA: 0x001F08D1 File Offset: 0x001EEAD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LongShanStageInfo> Stages
		{
			get
			{
				return this.stages_;
			}
		}

		// Token: 0x0600D295 RID: 53909 RVA: 0x001F08D9 File Offset: 0x001EEAD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongShanStageUpdateNotify);
		}

		// Token: 0x0600D296 RID: 53910 RVA: 0x001F08E7 File Offset: 0x001EEAE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongShanStageUpdateNotify other)
		{
			return other != null && (other == this || (this.stages_.Equals(other.stages_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D297 RID: 53911 RVA: 0x001F091C File Offset: 0x001EEB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.stages_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D298 RID: 53912 RVA: 0x001F0950 File Offset: 0x001EEB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D299 RID: 53913 RVA: 0x001F095D File Offset: 0x001EEB5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D29A RID: 53914 RVA: 0x001F0966 File Offset: 0x001EEB66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stages_.WriteTo(ref output, LongShanStageUpdateNotify._repeated_stages_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D29B RID: 53915 RVA: 0x001F0990 File Offset: 0x001EEB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.stages_.CalculateSize(LongShanStageUpdateNotify._repeated_stages_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D29C RID: 53916 RVA: 0x001F09C9 File Offset: 0x001EEBC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongShanStageUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.stages_.Add(other.stages_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D29D RID: 53917 RVA: 0x001F09F7 File Offset: 0x001EEBF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D29E RID: 53918 RVA: 0x001F0A00 File Offset: 0x001EEC00
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.stages_.AddEntriesFrom(ref input, LongShanStageUpdateNotify._repeated_stages_codec);
				}
			}
		}

		// Token: 0x04005894 RID: 22676
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005895 RID: 22677
		public const int StagesFieldNumber = 14;

		// Token: 0x04005896 RID: 22678
		private static readonly FieldCodec<LongShanStageInfo> _repeated_stages_codec = FieldCodec.ForMessage<LongShanStageInfo>(114U, LongShanStageInfo.Parser);

		// Token: 0x04005897 RID: 22679
		private readonly RepeatedField<LongShanStageInfo> stages_ = new RepeatedField<LongShanStageInfo>();
	}
}
