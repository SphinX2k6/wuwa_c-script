using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200157C RID: 5500
	[NetMessage(EMessageId.WeekCardInfoRequest)]
	public sealed class WeekCardInfoRequest : IMessage<WeekCardInfoRequest>, IMessage, IEquatable<WeekCardInfoRequest>, IDeepCloneable<WeekCardInfoRequest>, IBufferMessage
	{
		// Token: 0x0601D1F1 RID: 119281 RVA: 0x00437937 File Offset: 0x00435B37
		[NullableContext(1)]
		public static WeekCardInfoRequest Create()
		{
			return new WeekCardInfoRequest();
		}

		// Token: 0x17006288 RID: 25224
		// (get) Token: 0x0601D1F2 RID: 119282 RVA: 0x0043793E File Offset: 0x00435B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006289 RID: 25225
		// (get) Token: 0x0601D1F3 RID: 119283 RVA: 0x00437941 File Offset: 0x00435B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeekCardInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601D1F4 RID: 119284 RVA: 0x00437948 File Offset: 0x00435B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfoRequest()
		{
		}

		// Token: 0x0601D1F5 RID: 119285 RVA: 0x0043795B File Offset: 0x00435B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfoRequest(WeekCardInfoRequest other) : this()
		{
			this.weekCardId_ = other.weekCardId_;
			this.weekCardIds_ = other.weekCardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D1F6 RID: 119286 RVA: 0x00437991 File Offset: 0x00435B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfoRequest Clone()
		{
			return new WeekCardInfoRequest(this);
		}

		// Token: 0x1700628A RID: 25226
		// (get) Token: 0x0601D1F7 RID: 119287 RVA: 0x00437999 File Offset: 0x00435B99
		// (set) Token: 0x0601D1F8 RID: 119288 RVA: 0x004379A1 File Offset: 0x00435BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeekCardId
		{
			get
			{
				return this.weekCardId_;
			}
			set
			{
				this.weekCardId_ = value;
			}
		}

		// Token: 0x1700628B RID: 25227
		// (get) Token: 0x0601D1F9 RID: 119289 RVA: 0x004379AA File Offset: 0x00435BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> WeekCardIds
		{
			get
			{
				return this.weekCardIds_;
			}
		}

		// Token: 0x0601D1FA RID: 119290 RVA: 0x004379B2 File Offset: 0x00435BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeekCardInfoRequest);
		}

		// Token: 0x0601D1FB RID: 119291 RVA: 0x004379C0 File Offset: 0x00435BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeekCardInfoRequest other)
		{
			return other != null && (other == this || (this.WeekCardId == other.WeekCardId && this.weekCardIds_.Equals(other.weekCardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D1FC RID: 119292 RVA: 0x00437A10 File Offset: 0x00435C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeekCardId != 0)
			{
				num ^= this.WeekCardId.GetHashCode();
			}
			num ^= this.weekCardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D1FD RID: 119293 RVA: 0x00437A5D File Offset: 0x00435C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D1FE RID: 119294 RVA: 0x00437A6A File Offset: 0x00435C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D1FF RID: 119295 RVA: 0x00437A74 File Offset: 0x00435C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeekCardId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.WeekCardId);
			}
			this.weekCardIds_.WriteTo(ref output, WeekCardInfoRequest._repeated_weekCardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D200 RID: 119296 RVA: 0x00437AC4 File Offset: 0x00435CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeekCardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeekCardId);
			}
			num += this.weekCardIds_.CalculateSize(WeekCardInfoRequest._repeated_weekCardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D201 RID: 119297 RVA: 0x00437B18 File Offset: 0x00435D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeekCardInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeekCardId != 0)
			{
				this.WeekCardId = other.WeekCardId;
			}
			this.weekCardIds_.Add(other.weekCardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D202 RID: 119298 RVA: 0x00437B65 File Offset: 0x00435D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D203 RID: 119299 RVA: 0x00437B70 File Offset: 0x00435D70
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
				if (num != 24U)
				{
					if (num != 80U && num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.weekCardIds_.AddEntriesFrom(ref input, WeekCardInfoRequest._repeated_weekCardIds_codec);
					}
				}
				else
				{
					this.WeekCardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A735 RID: 42805
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A736 RID: 42806
		public const int WeekCardIdFieldNumber = 3;

		// Token: 0x0400A737 RID: 42807
		private int weekCardId_;

		// Token: 0x0400A738 RID: 42808
		public const int WeekCardIdsFieldNumber = 10;

		// Token: 0x0400A739 RID: 42809
		private static readonly FieldCodec<int> _repeated_weekCardIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400A73A RID: 42810
		private readonly RepeatedField<int> weekCardIds_ = new RepeatedField<int>();
	}
}
