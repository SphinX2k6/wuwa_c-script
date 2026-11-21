using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000709 RID: 1801
	public sealed class GridVision : IMessage<GridVision>, IMessage, IEquatable<GridVision>, IDeepCloneable<GridVision>, IBufferMessage
	{
		// Token: 0x0600A432 RID: 42034 RVA: 0x0018CD9D File Offset: 0x0018AF9D
		[NullableContext(1)]
		public static GridVision Create()
		{
			return new GridVision();
		}

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x0600A433 RID: 42035 RVA: 0x0018CDA4 File Offset: 0x0018AFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GridVision> Parser
		{
			get
			{
				return GridVision._parser;
			}
		}

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x0600A434 RID: 42036 RVA: 0x0018CDAB File Offset: 0x0018AFAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x0600A435 RID: 42037 RVA: 0x0018CDAE File Offset: 0x0018AFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GridVision.Descriptor;
			}
		}

		// Token: 0x0600A436 RID: 42038 RVA: 0x0018CDB5 File Offset: 0x0018AFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridVision()
		{
		}

		// Token: 0x0600A437 RID: 42039 RVA: 0x0018CDC8 File Offset: 0x0018AFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridVision(GridVision other) : this()
		{
			this.grids_ = other.grids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A438 RID: 42040 RVA: 0x0018CDF2 File Offset: 0x0018AFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridVision Clone()
		{
			return new GridVision(this);
		}

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x0600A439 RID: 42041 RVA: 0x0018CDFA File Offset: 0x0018AFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Grids
		{
			get
			{
				return this.grids_;
			}
		}

		// Token: 0x0600A43A RID: 42042 RVA: 0x0018CE02 File Offset: 0x0018B002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GridVision);
		}

		// Token: 0x0600A43B RID: 42043 RVA: 0x0018CE10 File Offset: 0x0018B010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GridVision other)
		{
			return other != null && (other == this || (this.grids_.Equals(other.grids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A43C RID: 42044 RVA: 0x0018CE44 File Offset: 0x0018B044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.grids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A43D RID: 42045 RVA: 0x0018CE78 File Offset: 0x0018B078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A43E RID: 42046 RVA: 0x0018CE85 File Offset: 0x0018B085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A43F RID: 42047 RVA: 0x0018CE8E File Offset: 0x0018B08E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.grids_.WriteTo(ref output, GridVision._repeated_grids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A440 RID: 42048 RVA: 0x0018CEB8 File Offset: 0x0018B0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.grids_.CalculateSize(GridVision._repeated_grids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A441 RID: 42049 RVA: 0x0018CEF1 File Offset: 0x0018B0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GridVision other)
		{
			if (other == null)
			{
				return;
			}
			this.grids_.Add(other.grids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A442 RID: 42050 RVA: 0x0018CF1F File Offset: 0x0018B11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A443 RID: 42051 RVA: 0x0018CF28 File Offset: 0x0018B128
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.grids_.AddEntriesFrom(ref input, GridVision._repeated_grids_codec);
				}
			}
		}

		// Token: 0x04004C16 RID: 19478
		private static readonly MessageParser<GridVision> _parser = new MessageParser<GridVision>(() => new GridVision());

		// Token: 0x04004C17 RID: 19479
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C18 RID: 19480
		public const int GridsFieldNumber = 1;

		// Token: 0x04004C19 RID: 19481
		private static readonly FieldCodec<int> _repeated_grids_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04004C1A RID: 19482
		private readonly RepeatedField<int> grids_ = new RepeatedField<int>();
	}
}
