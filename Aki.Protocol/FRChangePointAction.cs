using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000644 RID: 1604
	public sealed class FRChangePointAction : IMessage<FRChangePointAction>, IMessage, IEquatable<FRChangePointAction>, IDeepCloneable<FRChangePointAction>, IBufferMessage
	{
		// Token: 0x060093AD RID: 37805 RVA: 0x00165215 File Offset: 0x00163415
		[NullableContext(1)]
		public static FRChangePointAction Create()
		{
			return new FRChangePointAction();
		}

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x060093AE RID: 37806 RVA: 0x0016521C File Offset: 0x0016341C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x060093AF RID: 37807 RVA: 0x0016521F File Offset: 0x0016341F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRChangePointAction.Descriptor;
			}
		}

		// Token: 0x060093B0 RID: 37808 RVA: 0x00165226 File Offset: 0x00163426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRChangePointAction()
		{
		}

		// Token: 0x060093B1 RID: 37809 RVA: 0x00165239 File Offset: 0x00163439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRChangePointAction(FRChangePointAction other) : this()
		{
			this.phantom_ = other.phantom_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060093B2 RID: 37810 RVA: 0x00165263 File Offset: 0x00163463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRChangePointAction Clone()
		{
			return new FRChangePointAction(this);
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x060093B3 RID: 37811 RVA: 0x0016526B File Offset: 0x0016346B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayUnit> Phantom
		{
			get
			{
				return this.phantom_;
			}
		}

		// Token: 0x060093B4 RID: 37812 RVA: 0x00165273 File Offset: 0x00163473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRChangePointAction);
		}

		// Token: 0x060093B5 RID: 37813 RVA: 0x00165281 File Offset: 0x00163481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRChangePointAction other)
		{
			return other != null && (other == this || (this.phantom_.Equals(other.phantom_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060093B6 RID: 37814 RVA: 0x001652B4 File Offset: 0x001634B4
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

		// Token: 0x060093B7 RID: 37815 RVA: 0x001652E8 File Offset: 0x001634E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060093B8 RID: 37816 RVA: 0x001652F5 File Offset: 0x001634F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060093B9 RID: 37817 RVA: 0x001652FE File Offset: 0x001634FE
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

		// Token: 0x060093BA RID: 37818 RVA: 0x00165328 File Offset: 0x00163528
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

		// Token: 0x060093BB RID: 37819 RVA: 0x00165361 File Offset: 0x00163561
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

		// Token: 0x060093BC RID: 37820 RVA: 0x0016538F File Offset: 0x0016358F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060093BD RID: 37821 RVA: 0x00165398 File Offset: 0x00163598
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

		// Token: 0x040046F4 RID: 18164
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046F5 RID: 18165
		public const int PhantomFieldNumber = 1;

		// Token: 0x040046F6 RID: 18166
		private static readonly FieldCodec<FloroRanchPlayUnit> _repeated_phantom_codec = FieldCodec.ForMessage<FloroRanchPlayUnit>(10U, FloroRanchPlayUnit.Parser);

		// Token: 0x040046F7 RID: 18167
		private readonly RepeatedField<FloroRanchPlayUnit> phantom_ = new RepeatedField<FloroRanchPlayUnit>();
	}
}
