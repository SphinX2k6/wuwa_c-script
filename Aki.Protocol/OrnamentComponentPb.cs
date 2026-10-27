using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BAE RID: 2990
	public sealed class OrnamentComponentPb : IMessage<OrnamentComponentPb>, IMessage, IEquatable<OrnamentComponentPb>, IDeepCloneable<OrnamentComponentPb>, IBufferMessage
	{
		// Token: 0x0601036E RID: 66414 RVA: 0x0025E161 File Offset: 0x0025C361
		[NullableContext(1)]
		public static OrnamentComponentPb Create()
		{
			return new OrnamentComponentPb();
		}

		// Token: 0x1700352F RID: 13615
		// (get) Token: 0x0601036F RID: 66415 RVA: 0x0025E168 File Offset: 0x0025C368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003530 RID: 13616
		// (get) Token: 0x06010370 RID: 66416 RVA: 0x0025E16B File Offset: 0x0025C36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrnamentComponentPb.Descriptor;
			}
		}

		// Token: 0x06010371 RID: 66417 RVA: 0x0025E172 File Offset: 0x0025C372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentComponentPb()
		{
		}

		// Token: 0x06010372 RID: 66418 RVA: 0x0025E185 File Offset: 0x0025C385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentComponentPb(OrnamentComponentPb other) : this()
		{
			this.ornamentIds_ = other.ornamentIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010373 RID: 66419 RVA: 0x0025E1AF File Offset: 0x0025C3AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentComponentPb Clone()
		{
			return new OrnamentComponentPb(this);
		}

		// Token: 0x17003531 RID: 13617
		// (get) Token: 0x06010374 RID: 66420 RVA: 0x0025E1B7 File Offset: 0x0025C3B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> OrnamentIds
		{
			get
			{
				return this.ornamentIds_;
			}
		}

		// Token: 0x06010375 RID: 66421 RVA: 0x0025E1BF File Offset: 0x0025C3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrnamentComponentPb);
		}

		// Token: 0x06010376 RID: 66422 RVA: 0x0025E1CD File Offset: 0x0025C3CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrnamentComponentPb other)
		{
			return other != null && (other == this || (this.ornamentIds_.Equals(other.ornamentIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010377 RID: 66423 RVA: 0x0025E200 File Offset: 0x0025C400
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

		// Token: 0x06010378 RID: 66424 RVA: 0x0025E234 File Offset: 0x0025C434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010379 RID: 66425 RVA: 0x0025E241 File Offset: 0x0025C441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601037A RID: 66426 RVA: 0x0025E24A File Offset: 0x0025C44A
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

		// Token: 0x0601037B RID: 66427 RVA: 0x0025E274 File Offset: 0x0025C474
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

		// Token: 0x0601037C RID: 66428 RVA: 0x0025E2AD File Offset: 0x0025C4AD
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

		// Token: 0x0601037D RID: 66429 RVA: 0x0025E2DB File Offset: 0x0025C4DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601037E RID: 66430 RVA: 0x0025E2E4 File Offset: 0x0025C4E4
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

		// Token: 0x04006741 RID: 26433
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006742 RID: 26434
		public const int OrnamentIdsFieldNumber = 1;

		// Token: 0x04006743 RID: 26435
		private static readonly FieldCodec<int> _repeated_ornamentIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006744 RID: 26436
		private readonly RepeatedField<int> ornamentIds_ = new RepeatedField<int>();
	}
}
