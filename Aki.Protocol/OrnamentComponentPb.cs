using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B9E RID: 2974
	public sealed class OrnamentComponentPb : IMessage<OrnamentComponentPb>, IMessage, IEquatable<OrnamentComponentPb>, IDeepCloneable<OrnamentComponentPb>, IBufferMessage
	{
		// Token: 0x0601026A RID: 66154 RVA: 0x0025C2A9 File Offset: 0x0025A4A9
		[NullableContext(1)]
		public static OrnamentComponentPb Create()
		{
			return new OrnamentComponentPb();
		}

		// Token: 0x170034F6 RID: 13558
		// (get) Token: 0x0601026B RID: 66155 RVA: 0x0025C2B0 File Offset: 0x0025A4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034F7 RID: 13559
		// (get) Token: 0x0601026C RID: 66156 RVA: 0x0025C2B3 File Offset: 0x0025A4B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrnamentComponentPb.Descriptor;
			}
		}

		// Token: 0x0601026D RID: 66157 RVA: 0x0025C2BA File Offset: 0x0025A4BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentComponentPb()
		{
		}

		// Token: 0x0601026E RID: 66158 RVA: 0x0025C2CD File Offset: 0x0025A4CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentComponentPb(OrnamentComponentPb other) : this()
		{
			this.ornamentIds_ = other.ornamentIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601026F RID: 66159 RVA: 0x0025C2F7 File Offset: 0x0025A4F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentComponentPb Clone()
		{
			return new OrnamentComponentPb(this);
		}

		// Token: 0x170034F8 RID: 13560
		// (get) Token: 0x06010270 RID: 66160 RVA: 0x0025C2FF File Offset: 0x0025A4FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> OrnamentIds
		{
			get
			{
				return this.ornamentIds_;
			}
		}

		// Token: 0x06010271 RID: 66161 RVA: 0x0025C307 File Offset: 0x0025A507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrnamentComponentPb);
		}

		// Token: 0x06010272 RID: 66162 RVA: 0x0025C315 File Offset: 0x0025A515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrnamentComponentPb other)
		{
			return other != null && (other == this || (this.ornamentIds_.Equals(other.ornamentIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010273 RID: 66163 RVA: 0x0025C348 File Offset: 0x0025A548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ornamentIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010274 RID: 66164 RVA: 0x0025C37C File Offset: 0x0025A57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010275 RID: 66165 RVA: 0x0025C389 File Offset: 0x0025A589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010276 RID: 66166 RVA: 0x0025C392 File Offset: 0x0025A592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ornamentIds_.WriteTo(ref output, OrnamentComponentPb._repeated_ornamentIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010277 RID: 66167 RVA: 0x0025C3BC File Offset: 0x0025A5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ornamentIds_.CalculateSize(OrnamentComponentPb._repeated_ornamentIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010278 RID: 66168 RVA: 0x0025C3F5 File Offset: 0x0025A5F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrnamentComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.ornamentIds_.Add(other.ornamentIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010279 RID: 66169 RVA: 0x0025C423 File Offset: 0x0025A623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601027A RID: 66170 RVA: 0x0025C42C File Offset: 0x0025A62C
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
					this.ornamentIds_.AddEntriesFrom(ref input, OrnamentComponentPb._repeated_ornamentIds_codec);
				}
			}
		}

		// Token: 0x04006751 RID: 26449
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006752 RID: 26450
		public const int OrnamentIdsFieldNumber = 1;

		// Token: 0x04006753 RID: 26451
		private static readonly FieldCodec<int> _repeated_ornamentIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006754 RID: 26452
		private readonly RepeatedField<int> ornamentIds_ = new RepeatedField<int>();
	}
}
