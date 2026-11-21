using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB4 RID: 3252
	public sealed class PhantomCollectProgress : IMessage<PhantomCollectProgress>, IMessage, IEquatable<PhantomCollectProgress>, IDeepCloneable<PhantomCollectProgress>, IBufferMessage
	{
		// Token: 0x06011A1F RID: 72223 RVA: 0x002954E5 File Offset: 0x002936E5
		[NullableContext(1)]
		public static PhantomCollectProgress Create()
		{
			return new PhantomCollectProgress();
		}

		// Token: 0x17003A69 RID: 14953
		// (get) Token: 0x06011A20 RID: 72224 RVA: 0x002954EC File Offset: 0x002936EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A6A RID: 14954
		// (get) Token: 0x06011A21 RID: 72225 RVA: 0x002954EF File Offset: 0x002936EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomCollectProgress.Descriptor;
			}
		}

		// Token: 0x06011A22 RID: 72226 RVA: 0x002954F6 File Offset: 0x002936F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectProgress()
		{
		}

		// Token: 0x06011A23 RID: 72227 RVA: 0x00295509 File Offset: 0x00293709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectProgress(PhantomCollectProgress other) : this()
		{
			this.phantoms_ = other.phantoms_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011A24 RID: 72228 RVA: 0x00295533 File Offset: 0x00293733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectProgress Clone()
		{
			return new PhantomCollectProgress(this);
		}

		// Token: 0x17003A6B RID: 14955
		// (get) Token: 0x06011A25 RID: 72229 RVA: 0x0029553B File Offset: 0x0029373B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Phantoms
		{
			get
			{
				return this.phantoms_;
			}
		}

		// Token: 0x06011A26 RID: 72230 RVA: 0x00295543 File Offset: 0x00293743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomCollectProgress);
		}

		// Token: 0x06011A27 RID: 72231 RVA: 0x00295551 File Offset: 0x00293751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomCollectProgress other)
		{
			return other != null && (other == this || (this.phantoms_.Equals(other.phantoms_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011A28 RID: 72232 RVA: 0x00295584 File Offset: 0x00293784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantoms_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011A29 RID: 72233 RVA: 0x002955B8 File Offset: 0x002937B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011A2A RID: 72234 RVA: 0x002955C5 File Offset: 0x002937C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011A2B RID: 72235 RVA: 0x002955CE File Offset: 0x002937CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantoms_.WriteTo(ref output, PhantomCollectProgress._repeated_phantoms_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011A2C RID: 72236 RVA: 0x002955F8 File Offset: 0x002937F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantoms_.CalculateSize(PhantomCollectProgress._repeated_phantoms_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011A2D RID: 72237 RVA: 0x00295631 File Offset: 0x00293831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomCollectProgress other)
		{
			if (other == null)
			{
				return;
			}
			this.phantoms_.Add(other.phantoms_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011A2E RID: 72238 RVA: 0x0029565F File Offset: 0x0029385F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011A2F RID: 72239 RVA: 0x00295668 File Offset: 0x00293868
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
					this.phantoms_.AddEntriesFrom(ref input, PhantomCollectProgress._repeated_phantoms_codec);
				}
			}
		}

		// Token: 0x04006F62 RID: 28514
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F63 RID: 28515
		public const int PhantomsFieldNumber = 1;

		// Token: 0x04006F64 RID: 28516
		private static readonly FieldCodec<int> _repeated_phantoms_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006F65 RID: 28517
		private readonly RepeatedField<int> phantoms_ = new RepeatedField<int>();
	}
}
