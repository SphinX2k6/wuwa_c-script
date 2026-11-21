using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000630 RID: 1584
	public sealed class FRChangePointAction : IMessage<FRChangePointAction>, IMessage, IEquatable<FRChangePointAction>, IDeepCloneable<FRChangePointAction>, IBufferMessage
	{
		// Token: 0x06009257 RID: 37463 RVA: 0x001627E4 File Offset: 0x001609E4
		[NullableContext(1)]
		public static FRChangePointAction Create()
		{
			return new FRChangePointAction();
		}

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x06009258 RID: 37464 RVA: 0x001627EB File Offset: 0x001609EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x06009259 RID: 37465 RVA: 0x001627EE File Offset: 0x001609EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRChangePointAction.Descriptor;
			}
		}

		// Token: 0x0600925A RID: 37466 RVA: 0x001627F5 File Offset: 0x001609F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRChangePointAction()
		{
		}

		// Token: 0x0600925B RID: 37467 RVA: 0x00162808 File Offset: 0x00160A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRChangePointAction(FRChangePointAction other) : this()
		{
			this.phantom_ = other.phantom_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600925C RID: 37468 RVA: 0x00162832 File Offset: 0x00160A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRChangePointAction Clone()
		{
			return new FRChangePointAction(this);
		}

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x0600925D RID: 37469 RVA: 0x0016283A File Offset: 0x00160A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayUnit> Phantom
		{
			get
			{
				return this.phantom_;
			}
		}

		// Token: 0x0600925E RID: 37470 RVA: 0x00162842 File Offset: 0x00160A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRChangePointAction);
		}

		// Token: 0x0600925F RID: 37471 RVA: 0x00162850 File Offset: 0x00160A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRChangePointAction other)
		{
			return other != null && (other == this || (this.phantom_.Equals(other.phantom_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009260 RID: 37472 RVA: 0x00162884 File Offset: 0x00160A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantom_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009261 RID: 37473 RVA: 0x001628B8 File Offset: 0x00160AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009262 RID: 37474 RVA: 0x001628C5 File Offset: 0x00160AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009263 RID: 37475 RVA: 0x001628CE File Offset: 0x00160ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantom_.WriteTo(ref output, FRChangePointAction._repeated_phantom_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009264 RID: 37476 RVA: 0x001628F8 File Offset: 0x00160AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantom_.CalculateSize(FRChangePointAction._repeated_phantom_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009265 RID: 37477 RVA: 0x00162931 File Offset: 0x00160B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRChangePointAction other)
		{
			if (other == null)
			{
				return;
			}
			this.phantom_.Add(other.phantom_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009266 RID: 37478 RVA: 0x0016295F File Offset: 0x00160B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009267 RID: 37479 RVA: 0x00162968 File Offset: 0x00160B68
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
					this.phantom_.AddEntriesFrom(ref input, FRChangePointAction._repeated_phantom_codec);
				}
			}
		}

		// Token: 0x040046ED RID: 18157
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046EE RID: 18158
		public const int PhantomFieldNumber = 1;

		// Token: 0x040046EF RID: 18159
		private static readonly FieldCodec<FloroRanchPlayUnit> _repeated_phantom_codec = FieldCodec.ForMessage<FloroRanchPlayUnit>(10U, FloroRanchPlayUnit.Parser);

		// Token: 0x040046F0 RID: 18160
		private readonly RepeatedField<FloroRanchPlayUnit> phantom_ = new RepeatedField<FloroRanchPlayUnit>();
	}
}
