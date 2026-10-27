using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB9 RID: 2745
	public sealed class MoveOp : IMessage<MoveOp>, IMessage, IEquatable<MoveOp>, IDeepCloneable<MoveOp>, IBufferMessage
	{
		// Token: 0x0600EEE1 RID: 61153 RVA: 0x0022DD9E File Offset: 0x0022BF9E
		[NullableContext(1)]
		public static MoveOp Create()
		{
			return new MoveOp();
		}

		// Token: 0x1700308D RID: 12429
		// (get) Token: 0x0600EEE2 RID: 61154 RVA: 0x0022DDA5 File Offset: 0x0022BFA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700308E RID: 12430
		// (get) Token: 0x0600EEE3 RID: 61155 RVA: 0x0022DDA8 File Offset: 0x0022BFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveOp.Descriptor;
			}
		}

		// Token: 0x0600EEE4 RID: 61156 RVA: 0x0022DDAF File Offset: 0x0022BFAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveOp()
		{
		}

		// Token: 0x0600EEE5 RID: 61157 RVA: 0x0022DDCD File Offset: 0x0022BFCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveOp(MoveOp other) : this()
		{
			this.paths_ = other.paths_.Clone();
			this.gridVisions_ = other.gridVisions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EEE6 RID: 61158 RVA: 0x0022DE08 File Offset: 0x0022C008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveOp Clone()
		{
			return new MoveOp(this);
		}

		// Token: 0x1700308F RID: 12431
		// (get) Token: 0x0600EEE7 RID: 61159 RVA: 0x0022DE10 File Offset: 0x0022C010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Paths
		{
			get
			{
				return this.paths_;
			}
		}

		// Token: 0x17003090 RID: 12432
		// (get) Token: 0x0600EEE8 RID: 61160 RVA: 0x0022DE18 File Offset: 0x0022C018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GridVision> GridVisions
		{
			get
			{
				return this.gridVisions_;
			}
		}

		// Token: 0x0600EEE9 RID: 61161 RVA: 0x0022DE20 File Offset: 0x0022C020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveOp);
		}

		// Token: 0x0600EEEA RID: 61162 RVA: 0x0022DE30 File Offset: 0x0022C030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveOp other)
		{
			return other != null && (other == this || (this.paths_.Equals(other.paths_) && this.gridVisions_.Equals(other.gridVisions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EEEB RID: 61163 RVA: 0x0022DE84 File Offset: 0x0022C084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.paths_.GetHashCode();
			num ^= this.gridVisions_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EEEC RID: 61164 RVA: 0x0022DEC6 File Offset: 0x0022C0C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EEED RID: 61165 RVA: 0x0022DED3 File Offset: 0x0022C0D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EEEE RID: 61166 RVA: 0x0022DEDC File Offset: 0x0022C0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.paths_.WriteTo(ref output, MoveOp._repeated_paths_codec);
			this.gridVisions_.WriteTo(ref output, MoveOp._repeated_gridVisions_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EEEF RID: 61167 RVA: 0x0022DF14 File Offset: 0x0022C114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.paths_.CalculateSize(MoveOp._repeated_paths_codec);
			num += this.gridVisions_.CalculateSize(MoveOp._repeated_gridVisions_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EEF0 RID: 61168 RVA: 0x0022DF60 File Offset: 0x0022C160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoveOp other)
		{
			if (other == null)
			{
				return;
			}
			this.paths_.Add(other.paths_);
			this.gridVisions_.Add(other.gridVisions_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EEF1 RID: 61169 RVA: 0x0022DF9F File Offset: 0x0022C19F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EEF2 RID: 61170 RVA: 0x0022DFA8 File Offset: 0x0022C1A8
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
				if (num != 8U && num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.gridVisions_.AddEntriesFrom(ref input, MoveOp._repeated_gridVisions_codec);
					}
				}
				else
				{
					this.paths_.AddEntriesFrom(ref input, MoveOp._repeated_paths_codec);
				}
			}
		}

		// Token: 0x04006099 RID: 24729
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400609A RID: 24730
		public const int PathsFieldNumber = 1;

		// Token: 0x0400609B RID: 24731
		private static readonly FieldCodec<int> _repeated_paths_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400609C RID: 24732
		private readonly RepeatedField<int> paths_ = new RepeatedField<int>();

		// Token: 0x0400609D RID: 24733
		public const int GridVisionsFieldNumber = 2;

		// Token: 0x0400609E RID: 24734
		private static readonly FieldCodec<GridVision> _repeated_gridVisions_codec = FieldCodec.ForMessage<GridVision>(18U, GridVision.Parser);

		// Token: 0x0400609F RID: 24735
		private readonly RepeatedField<GridVision> gridVisions_ = new RepeatedField<GridVision>();
	}
}
