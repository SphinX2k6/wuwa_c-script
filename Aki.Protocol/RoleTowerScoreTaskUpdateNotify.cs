using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010EA RID: 4330
	[NetMessage(EMessageId.RoleTowerScoreTaskUpdateNotify)]
	public sealed class RoleTowerScoreTaskUpdateNotify : IMessage<RoleTowerScoreTaskUpdateNotify>, IMessage, IEquatable<RoleTowerScoreTaskUpdateNotify>, IDeepCloneable<RoleTowerScoreTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x06017258 RID: 94808 RVA: 0x0035DFCD File Offset: 0x0035C1CD
		[NullableContext(1)]
		public static RoleTowerScoreTaskUpdateNotify Create()
		{
			return new RoleTowerScoreTaskUpdateNotify();
		}

		// Token: 0x17004DB8 RID: 19896
		// (get) Token: 0x06017259 RID: 94809 RVA: 0x0035DFD4 File Offset: 0x0035C1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DB9 RID: 19897
		// (get) Token: 0x0601725A RID: 94810 RVA: 0x0035DFD7 File Offset: 0x0035C1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerScoreTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601725B RID: 94811 RVA: 0x0035DFDE File Offset: 0x0035C1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerScoreTaskUpdateNotify()
		{
		}

		// Token: 0x0601725C RID: 94812 RVA: 0x0035DFF1 File Offset: 0x0035C1F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerScoreTaskUpdateNotify(RoleTowerScoreTaskUpdateNotify other) : this()
		{
			this.scoreTasks_ = other.scoreTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601725D RID: 94813 RVA: 0x0035E01B File Offset: 0x0035C21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerScoreTaskUpdateNotify Clone()
		{
			return new RoleTowerScoreTaskUpdateNotify(this);
		}

		// Token: 0x17004DBA RID: 19898
		// (get) Token: 0x0601725E RID: 94814 RVA: 0x0035E023 File Offset: 0x0035C223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreTasks
		{
			get
			{
				return this.scoreTasks_;
			}
		}

		// Token: 0x0601725F RID: 94815 RVA: 0x0035E02B File Offset: 0x0035C22B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerScoreTaskUpdateNotify);
		}

		// Token: 0x06017260 RID: 94816 RVA: 0x0035E039 File Offset: 0x0035C239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerScoreTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.scoreTasks_.Equals(other.scoreTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017261 RID: 94817 RVA: 0x0035E06C File Offset: 0x0035C26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.scoreTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017262 RID: 94818 RVA: 0x0035E0A0 File Offset: 0x0035C2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017263 RID: 94819 RVA: 0x0035E0AD File Offset: 0x0035C2AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017264 RID: 94820 RVA: 0x0035E0B6 File Offset: 0x0035C2B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.scoreTasks_.WriteTo(ref output, RoleTowerScoreTaskUpdateNotify._repeated_scoreTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017265 RID: 94821 RVA: 0x0035E0E0 File Offset: 0x0035C2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.scoreTasks_.CalculateSize(RoleTowerScoreTaskUpdateNotify._repeated_scoreTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017266 RID: 94822 RVA: 0x0035E119 File Offset: 0x0035C319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerScoreTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.scoreTasks_.Add(other.scoreTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017267 RID: 94823 RVA: 0x0035E147 File Offset: 0x0035C347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017268 RID: 94824 RVA: 0x0035E150 File Offset: 0x0035C350
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
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.scoreTasks_.AddEntriesFrom(ref input, RoleTowerScoreTaskUpdateNotify._repeated_scoreTasks_codec);
				}
			}
		}

		// Token: 0x04008A7D RID: 35453
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A7E RID: 35454
		public const int ScoreTasksFieldNumber = 5;

		// Token: 0x04008A7F RID: 35455
		private static readonly FieldCodec<int> _repeated_scoreTasks_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04008A80 RID: 35456
		private readonly RepeatedField<int> scoreTasks_ = new RepeatedField<int>();
	}
}
