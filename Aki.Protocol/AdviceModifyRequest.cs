using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000CB RID: 203
	[NetMessage(EMessageId.AdviceModifyRequest)]
	public sealed class AdviceModifyRequest : IMessage<AdviceModifyRequest>, IMessage, IEquatable<AdviceModifyRequest>, IDeepCloneable<AdviceModifyRequest>, IBufferMessage
	{
		// Token: 0x06001FA1 RID: 8097 RVA: 0x00055EA5 File Offset: 0x000540A5
		[NullableContext(1)]
		public static AdviceModifyRequest Create()
		{
			return new AdviceModifyRequest();
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x00055EAC File Offset: 0x000540AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x00055EAF File Offset: 0x000540AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceModifyRequest.Descriptor;
			}
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x00055EB6 File Offset: 0x000540B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceModifyRequest()
		{
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x00055EC9 File Offset: 0x000540C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceModifyRequest(AdviceModifyRequest other) : this()
		{
			this.id_ = other.id_;
			this.contents_ = other.contents_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x00055EFF File Offset: 0x000540FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceModifyRequest Clone()
		{
			return new AdviceModifyRequest(this);
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x00055F07 File Offset: 0x00054107
		// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x00055F0F File Offset: 0x0005410F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x00055F18 File Offset: 0x00054118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbAdviceContent> Contents
		{
			get
			{
				return this.contents_;
			}
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x00055F20 File Offset: 0x00054120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceModifyRequest);
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x00055F30 File Offset: 0x00054130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceModifyRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.contents_.Equals(other.contents_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x00055F80 File Offset: 0x00054180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.contents_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x00055FCD File Offset: 0x000541CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x00055FDA File Offset: 0x000541DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x00055FE4 File Offset: 0x000541E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.Id);
			}
			this.contents_.WriteTo(ref output, AdviceModifyRequest._repeated_contents_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x00056034 File Offset: 0x00054234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			num += this.contents_.CalculateSize(AdviceModifyRequest._repeated_contents_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x00056088 File Offset: 0x00054288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceModifyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this.contents_.Add(other.contents_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x000560D5 File Offset: 0x000542D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x000560E0 File Offset: 0x000542E0
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
				if (num != 80U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.contents_.AddEntriesFrom(ref input, AdviceModifyRequest._repeated_contents_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x040023C6 RID: 9158
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023C7 RID: 9159
		public const int IdFieldNumber = 10;

		// Token: 0x040023C8 RID: 9160
		private long id_;

		// Token: 0x040023C9 RID: 9161
		public const int ContentsFieldNumber = 15;

		// Token: 0x040023CA RID: 9162
		private static readonly FieldCodec<PbAdviceContent> _repeated_contents_codec = FieldCodec.ForMessage<PbAdviceContent>(122U, PbAdviceContent.Parser);

		// Token: 0x040023CB RID: 9163
		private readonly RepeatedField<PbAdviceContent> contents_ = new RepeatedField<PbAdviceContent>();
	}
}
