using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009AC RID: 2476
	public sealed class MarkTreasureBoxInfo : IMessage<MarkTreasureBoxInfo>, IMessage, IEquatable<MarkTreasureBoxInfo>, IDeepCloneable<MarkTreasureBoxInfo>, IBufferMessage
	{
		// Token: 0x0600D967 RID: 55655 RVA: 0x001FF129 File Offset: 0x001FD329
		[NullableContext(1)]
		public static MarkTreasureBoxInfo Create()
		{
			return new MarkTreasureBoxInfo();
		}

		// Token: 0x17002C0A RID: 11274
		// (get) Token: 0x0600D968 RID: 55656 RVA: 0x001FF130 File Offset: 0x001FD330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C0B RID: 11275
		// (get) Token: 0x0600D969 RID: 55657 RVA: 0x001FF133 File Offset: 0x001FD333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkTreasureBoxInfo.Descriptor;
			}
		}

		// Token: 0x0600D96A RID: 55658 RVA: 0x001FF13A File Offset: 0x001FD33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkTreasureBoxInfo()
		{
		}

		// Token: 0x0600D96B RID: 55659 RVA: 0x001FF14D File Offset: 0x001FD34D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkTreasureBoxInfo(MarkTreasureBoxInfo other) : this()
		{
			this.markPointInfo_ = other.markPointInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D96C RID: 55660 RVA: 0x001FF177 File Offset: 0x001FD377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkTreasureBoxInfo Clone()
		{
			return new MarkTreasureBoxInfo(this);
		}

		// Token: 0x17002C0C RID: 11276
		// (get) Token: 0x0600D96D RID: 55661 RVA: 0x001FF17F File Offset: 0x001FD37F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MarkPointInfo> MarkPointInfo
		{
			get
			{
				return this.markPointInfo_;
			}
		}

		// Token: 0x0600D96E RID: 55662 RVA: 0x001FF187 File Offset: 0x001FD387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkTreasureBoxInfo);
		}

		// Token: 0x0600D96F RID: 55663 RVA: 0x001FF195 File Offset: 0x001FD395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MarkTreasureBoxInfo other)
		{
			return other != null && (other == this || (this.markPointInfo_.Equals(other.markPointInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D970 RID: 55664 RVA: 0x001FF1C8 File Offset: 0x001FD3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.markPointInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D971 RID: 55665 RVA: 0x001FF1FC File Offset: 0x001FD3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D972 RID: 55666 RVA: 0x001FF209 File Offset: 0x001FD409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D973 RID: 55667 RVA: 0x001FF212 File Offset: 0x001FD412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.markPointInfo_.WriteTo(ref output, MarkTreasureBoxInfo._repeated_markPointInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D974 RID: 55668 RVA: 0x001FF23C File Offset: 0x001FD43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.markPointInfo_.CalculateSize(MarkTreasureBoxInfo._repeated_markPointInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D975 RID: 55669 RVA: 0x001FF275 File Offset: 0x001FD475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MarkTreasureBoxInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.markPointInfo_.Add(other.markPointInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D976 RID: 55670 RVA: 0x001FF2A3 File Offset: 0x001FD4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D977 RID: 55671 RVA: 0x001FF2AC File Offset: 0x001FD4AC
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.markPointInfo_.AddEntriesFrom(ref input, MarkTreasureBoxInfo._repeated_markPointInfo_codec);
				}
			}
		}

		// Token: 0x04005A76 RID: 23158
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A77 RID: 23159
		public const int MarkPointInfoFieldNumber = 1;

		// Token: 0x04005A78 RID: 23160
		private static readonly FieldCodec<MarkPointInfo> _repeated_markPointInfo_codec = FieldCodec.ForMessage<MarkPointInfo>(10U, Aki.Protocol.MarkPointInfo.Parser);

		// Token: 0x04005A79 RID: 23161
		private readonly RepeatedField<MarkPointInfo> markPointInfo_ = new RepeatedField<MarkPointInfo>();
	}
}
