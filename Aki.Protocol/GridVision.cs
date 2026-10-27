using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200071D RID: 1821
	public sealed class GridVision : IMessage<GridVision>, IMessage, IEquatable<GridVision>, IDeepCloneable<GridVision>, IBufferMessage
	{
		// Token: 0x0600A588 RID: 42376 RVA: 0x0018F7D1 File Offset: 0x0018D9D1
		[NullableContext(1)]
		public static GridVision Create()
		{
			return new GridVision();
		}

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x0600A589 RID: 42377 RVA: 0x0018F7D8 File Offset: 0x0018D9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GridVision> Parser
		{
			get
			{
				return GridVision._parser;
			}
		}

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x0600A58A RID: 42378 RVA: 0x0018F7DF File Offset: 0x0018D9DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x0600A58B RID: 42379 RVA: 0x0018F7E2 File Offset: 0x0018D9E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GridVision.Descriptor;
			}
		}

		// Token: 0x0600A58C RID: 42380 RVA: 0x0018F7E9 File Offset: 0x0018D9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridVision()
		{
		}

		// Token: 0x0600A58D RID: 42381 RVA: 0x0018F7FC File Offset: 0x0018D9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridVision(GridVision other) : this()
		{
			this.grids_ = other.grids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A58E RID: 42382 RVA: 0x0018F826 File Offset: 0x0018DA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridVision Clone()
		{
			return new GridVision(this);
		}

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x0600A58F RID: 42383 RVA: 0x0018F82E File Offset: 0x0018DA2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Grids
		{
			get
			{
				return this.grids_;
			}
		}

		// Token: 0x0600A590 RID: 42384 RVA: 0x0018F836 File Offset: 0x0018DA36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GridVision);
		}

		// Token: 0x0600A591 RID: 42385 RVA: 0x0018F844 File Offset: 0x0018DA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GridVision other)
		{
			return other != null && (other == this || (this.grids_.Equals(other.grids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A592 RID: 42386 RVA: 0x0018F878 File Offset: 0x0018DA78
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

		// Token: 0x0600A593 RID: 42387 RVA: 0x0018F8AC File Offset: 0x0018DAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A594 RID: 42388 RVA: 0x0018F8B9 File Offset: 0x0018DAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A595 RID: 42389 RVA: 0x0018F8C2 File Offset: 0x0018DAC2
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

		// Token: 0x0600A596 RID: 42390 RVA: 0x0018F8EC File Offset: 0x0018DAEC
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

		// Token: 0x0600A597 RID: 42391 RVA: 0x0018F925 File Offset: 0x0018DB25
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

		// Token: 0x0600A598 RID: 42392 RVA: 0x0018F953 File Offset: 0x0018DB53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A599 RID: 42393 RVA: 0x0018F95C File Offset: 0x0018DB5C
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

		// Token: 0x04004C1D RID: 19485
		private static readonly MessageParser<GridVision> _parser = new MessageParser<GridVision>(() => new GridVision());

		// Token: 0x04004C1E RID: 19486
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C1F RID: 19487
		public const int GridsFieldNumber = 1;

		// Token: 0x04004C20 RID: 19488
		private static readonly FieldCodec<int> _repeated_grids_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04004C21 RID: 19489
		private readonly RepeatedField<int> grids_ = new RepeatedField<int>();
	}
}
