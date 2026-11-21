using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200099B RID: 2459
	public sealed class MarkTreasureBoxInfo : IMessage<MarkTreasureBoxInfo>, IMessage, IEquatable<MarkTreasureBoxInfo>, IDeepCloneable<MarkTreasureBoxInfo>, IBufferMessage
	{
		// Token: 0x0600D84D RID: 55373 RVA: 0x001FCF35 File Offset: 0x001FB135
		[NullableContext(1)]
		public static MarkTreasureBoxInfo Create()
		{
			return new MarkTreasureBoxInfo();
		}

		// Token: 0x17002BCC RID: 11212
		// (get) Token: 0x0600D84E RID: 55374 RVA: 0x001FCF3C File Offset: 0x001FB13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BCD RID: 11213
		// (get) Token: 0x0600D84F RID: 55375 RVA: 0x001FCF3F File Offset: 0x001FB13F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkTreasureBoxInfo.Descriptor;
			}
		}

		// Token: 0x0600D850 RID: 55376 RVA: 0x001FCF46 File Offset: 0x001FB146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkTreasureBoxInfo()
		{
		}

		// Token: 0x0600D851 RID: 55377 RVA: 0x001FCF59 File Offset: 0x001FB159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkTreasureBoxInfo(MarkTreasureBoxInfo other) : this()
		{
			this.markPointInfo_ = other.markPointInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D852 RID: 55378 RVA: 0x001FCF83 File Offset: 0x001FB183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkTreasureBoxInfo Clone()
		{
			return new MarkTreasureBoxInfo(this);
		}

		// Token: 0x17002BCE RID: 11214
		// (get) Token: 0x0600D853 RID: 55379 RVA: 0x001FCF8B File Offset: 0x001FB18B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MarkPointInfo> MarkPointInfo
		{
			get
			{
				return this.markPointInfo_;
			}
		}

		// Token: 0x0600D854 RID: 55380 RVA: 0x001FCF93 File Offset: 0x001FB193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkTreasureBoxInfo);
		}

		// Token: 0x0600D855 RID: 55381 RVA: 0x001FCFA1 File Offset: 0x001FB1A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MarkTreasureBoxInfo other)
		{
			return other != null && (other == this || (this.markPointInfo_.Equals(other.markPointInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D856 RID: 55382 RVA: 0x001FCFD4 File Offset: 0x001FB1D4
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

		// Token: 0x0600D857 RID: 55383 RVA: 0x001FD008 File Offset: 0x001FB208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D858 RID: 55384 RVA: 0x001FD015 File Offset: 0x001FB215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D859 RID: 55385 RVA: 0x001FD01E File Offset: 0x001FB21E
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

		// Token: 0x0600D85A RID: 55386 RVA: 0x001FD048 File Offset: 0x001FB248
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

		// Token: 0x0600D85B RID: 55387 RVA: 0x001FD081 File Offset: 0x001FB281
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

		// Token: 0x0600D85C RID: 55388 RVA: 0x001FD0AF File Offset: 0x001FB2AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D85D RID: 55389 RVA: 0x001FD0B8 File Offset: 0x001FB2B8
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

		// Token: 0x04005A7F RID: 23167
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A80 RID: 23168
		public const int MarkPointInfoFieldNumber = 1;

		// Token: 0x04005A81 RID: 23169
		private static readonly FieldCodec<MarkPointInfo> _repeated_markPointInfo_codec = FieldCodec.ForMessage<MarkPointInfo>(10U, Aki.Protocol.MarkPointInfo.Parser);

		// Token: 0x04005A82 RID: 23170
		private readonly RepeatedField<MarkPointInfo> markPointInfo_ = new RepeatedField<MarkPointInfo>();
	}
}
