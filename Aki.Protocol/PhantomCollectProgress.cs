using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC4 RID: 3268
	public sealed class PhantomCollectProgress : IMessage<PhantomCollectProgress>, IMessage, IEquatable<PhantomCollectProgress>, IDeepCloneable<PhantomCollectProgress>, IBufferMessage
	{
		// Token: 0x06011B1F RID: 72479 RVA: 0x00297245 File Offset: 0x00295445
		[NullableContext(1)]
		public static PhantomCollectProgress Create()
		{
			return new PhantomCollectProgress();
		}

		// Token: 0x17003AA0 RID: 15008
		// (get) Token: 0x06011B20 RID: 72480 RVA: 0x0029724C File Offset: 0x0029544C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AA1 RID: 15009
		// (get) Token: 0x06011B21 RID: 72481 RVA: 0x0029724F File Offset: 0x0029544F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomCollectProgress.Descriptor;
			}
		}

		// Token: 0x06011B22 RID: 72482 RVA: 0x00297256 File Offset: 0x00295456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectProgress()
		{
		}

		// Token: 0x06011B23 RID: 72483 RVA: 0x00297269 File Offset: 0x00295469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectProgress(PhantomCollectProgress other) : this()
		{
			this.phantoms_ = other.phantoms_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011B24 RID: 72484 RVA: 0x00297293 File Offset: 0x00295493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectProgress Clone()
		{
			return new PhantomCollectProgress(this);
		}

		// Token: 0x17003AA2 RID: 15010
		// (get) Token: 0x06011B25 RID: 72485 RVA: 0x0029729B File Offset: 0x0029549B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Phantoms
		{
			get
			{
				return this.phantoms_;
			}
		}

		// Token: 0x06011B26 RID: 72486 RVA: 0x002972A3 File Offset: 0x002954A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomCollectProgress);
		}

		// Token: 0x06011B27 RID: 72487 RVA: 0x002972B1 File Offset: 0x002954B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomCollectProgress other)
		{
			return other != null && (other == this || (this.phantoms_.Equals(other.phantoms_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011B28 RID: 72488 RVA: 0x002972E4 File Offset: 0x002954E4
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

		// Token: 0x06011B29 RID: 72489 RVA: 0x00297318 File Offset: 0x00295518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011B2A RID: 72490 RVA: 0x00297325 File Offset: 0x00295525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011B2B RID: 72491 RVA: 0x0029732E File Offset: 0x0029552E
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

		// Token: 0x06011B2C RID: 72492 RVA: 0x00297358 File Offset: 0x00295558
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

		// Token: 0x06011B2D RID: 72493 RVA: 0x00297391 File Offset: 0x00295591
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

		// Token: 0x06011B2E RID: 72494 RVA: 0x002973BF File Offset: 0x002955BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011B2F RID: 72495 RVA: 0x002973C8 File Offset: 0x002955C8
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

		// Token: 0x04006F4E RID: 28494
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F4F RID: 28495
		public const int PhantomsFieldNumber = 1;

		// Token: 0x04006F50 RID: 28496
		private static readonly FieldCodec<int> _repeated_phantoms_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006F51 RID: 28497
		private readonly RepeatedField<int> phantoms_ = new RepeatedField<int>();
	}
}
