using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200041C RID: 1052
	public sealed class EnableFBParam : IMessage<EnableFBParam>, IMessage, IEquatable<EnableFBParam>, IDeepCloneable<EnableFBParam>, IBufferMessage
	{
		// Token: 0x06006583 RID: 25987 RVA: 0x000F4979 File Offset: 0x000F2B79
		[NullableContext(1)]
		public static EnableFBParam Create()
		{
			return new EnableFBParam();
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06006584 RID: 25988 RVA: 0x000F4980 File Offset: 0x000F2B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06006585 RID: 25989 RVA: 0x000F4983 File Offset: 0x000F2B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnableFBParam.Descriptor;
			}
		}

		// Token: 0x06006586 RID: 25990 RVA: 0x000F498A File Offset: 0x000F2B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableFBParam()
		{
		}

		// Token: 0x06006587 RID: 25991 RVA: 0x000F499D File Offset: 0x000F2B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableFBParam(EnableFBParam other) : this()
		{
			this.paramIntList_ = other.paramIntList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006588 RID: 25992 RVA: 0x000F49C7 File Offset: 0x000F2BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableFBParam Clone()
		{
			return new EnableFBParam(this);
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06006589 RID: 25993 RVA: 0x000F49CF File Offset: 0x000F2BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ParamIntList
		{
			get
			{
				return this.paramIntList_;
			}
		}

		// Token: 0x0600658A RID: 25994 RVA: 0x000F49D7 File Offset: 0x000F2BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnableFBParam);
		}

		// Token: 0x0600658B RID: 25995 RVA: 0x000F49E5 File Offset: 0x000F2BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnableFBParam other)
		{
			return other != null && (other == this || (this.paramIntList_.Equals(other.paramIntList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600658C RID: 25996 RVA: 0x000F4A18 File Offset: 0x000F2C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.paramIntList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600658D RID: 25997 RVA: 0x000F4A4C File Offset: 0x000F2C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600658E RID: 25998 RVA: 0x000F4A59 File Offset: 0x000F2C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600658F RID: 25999 RVA: 0x000F4A62 File Offset: 0x000F2C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.paramIntList_.WriteTo(ref output, EnableFBParam._repeated_paramIntList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006590 RID: 26000 RVA: 0x000F4A8C File Offset: 0x000F2C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.paramIntList_.CalculateSize(EnableFBParam._repeated_paramIntList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006591 RID: 26001 RVA: 0x000F4AC5 File Offset: 0x000F2CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnableFBParam other)
		{
			if (other == null)
			{
				return;
			}
			this.paramIntList_.Add(other.paramIntList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006592 RID: 26002 RVA: 0x000F4AF3 File Offset: 0x000F2CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006593 RID: 26003 RVA: 0x000F4AFC File Offset: 0x000F2CFC
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
					this.paramIntList_.AddEntriesFrom(ref input, EnableFBParam._repeated_paramIntList_codec);
				}
			}
		}

		// Token: 0x04003939 RID: 14649
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400393A RID: 14650
		public const int ParamIntListFieldNumber = 1;

		// Token: 0x0400393B RID: 14651
		private static readonly FieldCodec<int> _repeated_paramIntList_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400393C RID: 14652
		private readonly RepeatedField<int> paramIntList_ = new RepeatedField<int>();
	}
}
