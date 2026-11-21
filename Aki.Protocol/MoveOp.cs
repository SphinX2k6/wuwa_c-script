using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA8 RID: 2728
	public sealed class MoveOp : IMessage<MoveOp>, IMessage, IEquatable<MoveOp>, IDeepCloneable<MoveOp>, IBufferMessage
	{
		// Token: 0x0600EDC7 RID: 60871 RVA: 0x0022BB9E File Offset: 0x00229D9E
		[NullableContext(1)]
		public static MoveOp Create()
		{
			return new MoveOp();
		}

		// Token: 0x1700304F RID: 12367
		// (get) Token: 0x0600EDC8 RID: 60872 RVA: 0x0022BBA5 File Offset: 0x00229DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003050 RID: 12368
		// (get) Token: 0x0600EDC9 RID: 60873 RVA: 0x0022BBA8 File Offset: 0x00229DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveOp.Descriptor;
			}
		}

		// Token: 0x0600EDCA RID: 60874 RVA: 0x0022BBAF File Offset: 0x00229DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveOp()
		{
		}

		// Token: 0x0600EDCB RID: 60875 RVA: 0x0022BBCD File Offset: 0x00229DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveOp(MoveOp other) : this()
		{
			this.paths_ = other.paths_.Clone();
			this.gridVisions_ = other.gridVisions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EDCC RID: 60876 RVA: 0x0022BC08 File Offset: 0x00229E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveOp Clone()
		{
			return new MoveOp(this);
		}

		// Token: 0x17003051 RID: 12369
		// (get) Token: 0x0600EDCD RID: 60877 RVA: 0x0022BC10 File Offset: 0x00229E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Paths
		{
			get
			{
				return this.paths_;
			}
		}

		// Token: 0x17003052 RID: 12370
		// (get) Token: 0x0600EDCE RID: 60878 RVA: 0x0022BC18 File Offset: 0x00229E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GridVision> GridVisions
		{
			get
			{
				return this.gridVisions_;
			}
		}

		// Token: 0x0600EDCF RID: 60879 RVA: 0x0022BC20 File Offset: 0x00229E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveOp);
		}

		// Token: 0x0600EDD0 RID: 60880 RVA: 0x0022BC30 File Offset: 0x00229E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveOp other)
		{
			return other != null && (other == this || (this.paths_.Equals(other.paths_) && this.gridVisions_.Equals(other.gridVisions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EDD1 RID: 60881 RVA: 0x0022BC84 File Offset: 0x00229E84
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

		// Token: 0x0600EDD2 RID: 60882 RVA: 0x0022BCC6 File Offset: 0x00229EC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EDD3 RID: 60883 RVA: 0x0022BCD3 File Offset: 0x00229ED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EDD4 RID: 60884 RVA: 0x0022BCDC File Offset: 0x00229EDC
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

		// Token: 0x0600EDD5 RID: 60885 RVA: 0x0022BD14 File Offset: 0x00229F14
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

		// Token: 0x0600EDD6 RID: 60886 RVA: 0x0022BD60 File Offset: 0x00229F60
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

		// Token: 0x0600EDD7 RID: 60887 RVA: 0x0022BD9F File Offset: 0x00229F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EDD8 RID: 60888 RVA: 0x0022BDA8 File Offset: 0x00229FA8
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

		// Token: 0x040060A2 RID: 24738
		private UnknownFieldSet _unknownFields;

		// Token: 0x040060A3 RID: 24739
		public const int PathsFieldNumber = 1;

		// Token: 0x040060A4 RID: 24740
		private static readonly FieldCodec<int> _repeated_paths_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040060A5 RID: 24741
		private readonly RepeatedField<int> paths_ = new RepeatedField<int>();

		// Token: 0x040060A6 RID: 24742
		public const int GridVisionsFieldNumber = 2;

		// Token: 0x040060A7 RID: 24743
		private static readonly FieldCodec<GridVision> _repeated_gridVisions_codec = FieldCodec.ForMessage<GridVision>(18U, GridVision.Parser);

		// Token: 0x040060A8 RID: 24744
		private readonly RepeatedField<GridVision> gridVisions_ = new RepeatedField<GridVision>();
	}
}
