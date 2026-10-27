using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200069F RID: 1695
	[NetMessage(EMessageId.GachaResultNotify)]
	public sealed class GachaResultNotify : IMessage<GachaResultNotify>, IMessage, IEquatable<GachaResultNotify>, IDeepCloneable<GachaResultNotify>, IBufferMessage
	{
		// Token: 0x06009B2A RID: 39722 RVA: 0x001766ED File Offset: 0x001748ED
		[NullableContext(1)]
		public static GachaResultNotify Create()
		{
			return new GachaResultNotify();
		}

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x06009B2B RID: 39723 RVA: 0x001766F4 File Offset: 0x001748F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x06009B2C RID: 39724 RVA: 0x001766F7 File Offset: 0x001748F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaResultNotify.Descriptor;
			}
		}

		// Token: 0x06009B2D RID: 39725 RVA: 0x001766FE File Offset: 0x001748FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaResultNotify()
		{
		}

		// Token: 0x06009B2E RID: 39726 RVA: 0x00176711 File Offset: 0x00174911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaResultNotify(GachaResultNotify other) : this()
		{
			this.gachaResults_ = other.gachaResults_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B2F RID: 39727 RVA: 0x0017673B File Offset: 0x0017493B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaResultNotify Clone()
		{
			return new GachaResultNotify(this);
		}

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x06009B30 RID: 39728 RVA: 0x00176743 File Offset: 0x00174943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaResult> GachaResults
		{
			get
			{
				return this.gachaResults_;
			}
		}

		// Token: 0x06009B31 RID: 39729 RVA: 0x0017674B File Offset: 0x0017494B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaResultNotify);
		}

		// Token: 0x06009B32 RID: 39730 RVA: 0x00176759 File Offset: 0x00174959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaResultNotify other)
		{
			return other != null && (other == this || (this.gachaResults_.Equals(other.gachaResults_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B33 RID: 39731 RVA: 0x0017678C File Offset: 0x0017498C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gachaResults_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B34 RID: 39732 RVA: 0x001767C0 File Offset: 0x001749C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009B35 RID: 39733 RVA: 0x001767CD File Offset: 0x001749CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B36 RID: 39734 RVA: 0x001767D6 File Offset: 0x001749D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gachaResults_.WriteTo(ref output, GachaResultNotify._repeated_gachaResults_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B37 RID: 39735 RVA: 0x00176800 File Offset: 0x00174A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gachaResults_.CalculateSize(GachaResultNotify._repeated_gachaResults_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B38 RID: 39736 RVA: 0x00176839 File Offset: 0x00174A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.gachaResults_.Add(other.gachaResults_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009B39 RID: 39737 RVA: 0x00176867 File Offset: 0x00174A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B3A RID: 39738 RVA: 0x00176870 File Offset: 0x00174A70
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.gachaResults_.AddEntriesFrom(ref input, GachaResultNotify._repeated_gachaResults_codec);
				}
			}
		}

		// Token: 0x04004953 RID: 18771
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004954 RID: 18772
		public const int GachaResultsFieldNumber = 6;

		// Token: 0x04004955 RID: 18773
		private static readonly FieldCodec<GachaResult> _repeated_gachaResults_codec = FieldCodec.ForMessage<GachaResult>(50U, GachaResult.Parser);

		// Token: 0x04004956 RID: 18774
		private readonly RepeatedField<GachaResult> gachaResults_ = new RepeatedField<GachaResult>();
	}
}
