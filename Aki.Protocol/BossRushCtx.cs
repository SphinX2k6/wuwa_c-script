using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001DA RID: 474
	public sealed class BossRushCtx : IMessage<BossRushCtx>, IMessage, IEquatable<BossRushCtx>, IDeepCloneable<BossRushCtx>, IBufferMessage
	{
		// Token: 0x060035D3 RID: 13779 RVA: 0x000875F1 File Offset: 0x000857F1
		[NullableContext(1)]
		public static BossRushCtx Create()
		{
			return new BossRushCtx();
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x060035D4 RID: 13780 RVA: 0x000875F8 File Offset: 0x000857F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x060035D5 RID: 13781 RVA: 0x000875FB File Offset: 0x000857FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushCtx.Descriptor;
			}
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x00087602 File Offset: 0x00085802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushCtx()
		{
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x00087620 File Offset: 0x00085820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushCtx(BossRushCtx other) : this()
		{
			this.id_ = other.id_;
			this.activityId_ = other.activityId_;
			this.buffSelections_ = other.buffSelections_.Clone();
			this.scoreBuff_ = other.scoreBuff_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x0008767E File Offset: 0x0008587E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushCtx Clone()
		{
			return new BossRushCtx(this);
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x060035D9 RID: 13785 RVA: 0x00087686 File Offset: 0x00085886
		// (set) Token: 0x060035DA RID: 13786 RVA: 0x0008768E File Offset: 0x0008588E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x060035DB RID: 13787 RVA: 0x00087697 File Offset: 0x00085897
		// (set) Token: 0x060035DC RID: 13788 RVA: 0x0008769F File Offset: 0x0008589F
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

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x060035DD RID: 13789 RVA: 0x000876A8 File Offset: 0x000858A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BuffSelection> BuffSelections
		{
			get
			{
				return this.buffSelections_;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x060035DE RID: 13790 RVA: 0x000876B0 File Offset: 0x000858B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreBuff
		{
			get
			{
				return this.scoreBuff_;
			}
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x000876B8 File Offset: 0x000858B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushCtx);
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x000876C8 File Offset: 0x000858C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushCtx other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ActivityId == other.ActivityId && this.buffSelections_.Equals(other.buffSelections_) && this.scoreBuff_.Equals(other.scoreBuff_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x0008773C File Offset: 0x0008593C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.buffSelections_.GetHashCode();
			num ^= this.scoreBuff_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x000877B0 File Offset: 0x000859B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x000877BD File Offset: 0x000859BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x000877C8 File Offset: 0x000859C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			this.buffSelections_.WriteTo(ref output, BossRushCtx._repeated_buffSelections_codec);
			this.scoreBuff_.WriteTo(ref output, BossRushCtx._repeated_scoreBuff_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x00087844 File Offset: 0x00085A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.buffSelections_.CalculateSize(BossRushCtx._repeated_buffSelections_codec);
			num += this.scoreBuff_.CalculateSize(BossRushCtx._repeated_scoreBuff_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x000878C0 File Offset: 0x00085AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.buffSelections_.Add(other.buffSelections_);
			this.scoreBuff_.Add(other.scoreBuff_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x00087932 File Offset: 0x00085B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060035E8 RID: 13800 RVA: 0x0008793C File Offset: 0x00085B3C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.buffSelections_.AddEntriesFrom(ref input, BossRushCtx._repeated_buffSelections_codec);
						continue;
					}
					if (num == 56U || num == 58U)
					{
						this.scoreBuff_.AddEntriesFrom(ref input, BossRushCtx._repeated_scoreBuff_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002AB7 RID: 10935
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AB8 RID: 10936
		public const int IdFieldNumber = 1;

		// Token: 0x04002AB9 RID: 10937
		private int id_;

		// Token: 0x04002ABA RID: 10938
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04002ABB RID: 10939
		private int activityId_;

		// Token: 0x04002ABC RID: 10940
		public const int BuffSelectionsFieldNumber = 3;

		// Token: 0x04002ABD RID: 10941
		private static readonly FieldCodec<BuffSelection> _repeated_buffSelections_codec = FieldCodec.ForMessage<BuffSelection>(26U, BuffSelection.Parser);

		// Token: 0x04002ABE RID: 10942
		private readonly RepeatedField<BuffSelection> buffSelections_ = new RepeatedField<BuffSelection>();

		// Token: 0x04002ABF RID: 10943
		public const int ScoreBuffFieldNumber = 7;

		// Token: 0x04002AC0 RID: 10944
		private static readonly FieldCodec<int> _repeated_scoreBuff_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04002AC1 RID: 10945
		private readonly RepeatedField<int> scoreBuff_ = new RepeatedField<int>();
	}
}
