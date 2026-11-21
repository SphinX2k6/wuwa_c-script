using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D01 RID: 3329
	[NetMessage(EMessageId.PhantomVicePolishResponse)]
	public sealed class PhantomVicePolishResponse : IMessage<PhantomVicePolishResponse>, IMessage, IEquatable<PhantomVicePolishResponse>, IDeepCloneable<PhantomVicePolishResponse>, IBufferMessage
	{
		// Token: 0x0601202E RID: 73774 RVA: 0x002A25E0 File Offset: 0x002A07E0
		[NullableContext(1)]
		public static PhantomVicePolishResponse Create()
		{
			return new PhantomVicePolishResponse();
		}

		// Token: 0x17003BAC RID: 15276
		// (get) Token: 0x0601202F RID: 73775 RVA: 0x002A25E7 File Offset: 0x002A07E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BAD RID: 15277
		// (get) Token: 0x06012030 RID: 73776 RVA: 0x002A25EA File Offset: 0x002A07EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomVicePolishResponse.Descriptor;
			}
		}

		// Token: 0x06012031 RID: 73777 RVA: 0x002A25F1 File Offset: 0x002A07F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishResponse()
		{
		}

		// Token: 0x06012032 RID: 73778 RVA: 0x002A2604 File Offset: 0x002A0804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishResponse(PhantomVicePolishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomSubProp_ = other.phantomSubProp_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012033 RID: 73779 RVA: 0x002A263A File Offset: 0x002A083A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishResponse Clone()
		{
			return new PhantomVicePolishResponse(this);
		}

		// Token: 0x17003BAE RID: 15278
		// (get) Token: 0x06012034 RID: 73780 RVA: 0x002A2642 File Offset: 0x002A0842
		// (set) Token: 0x06012035 RID: 73781 RVA: 0x002A264A File Offset: 0x002A084A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17003BAF RID: 15279
		// (get) Token: 0x06012036 RID: 73782 RVA: 0x002A2653 File Offset: 0x002A0853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomPropInfo> PhantomSubProp
		{
			get
			{
				return this.phantomSubProp_;
			}
		}

		// Token: 0x06012037 RID: 73783 RVA: 0x002A265B File Offset: 0x002A085B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomVicePolishResponse);
		}

		// Token: 0x06012038 RID: 73784 RVA: 0x002A266C File Offset: 0x002A086C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomVicePolishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomSubProp_.Equals(other.phantomSubProp_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012039 RID: 73785 RVA: 0x002A26BC File Offset: 0x002A08BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.phantomSubProp_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601203A RID: 73786 RVA: 0x002A270F File Offset: 0x002A090F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601203B RID: 73787 RVA: 0x002A271C File Offset: 0x002A091C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601203C RID: 73788 RVA: 0x002A2728 File Offset: 0x002A0928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomSubProp_.WriteTo(ref output, PhantomVicePolishResponse._repeated_phantomSubProp_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601203D RID: 73789 RVA: 0x002A2778 File Offset: 0x002A0978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.phantomSubProp_.CalculateSize(PhantomVicePolishResponse._repeated_phantomSubProp_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601203E RID: 73790 RVA: 0x002A27CC File Offset: 0x002A09CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomVicePolishResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.phantomSubProp_.Add(other.phantomSubProp_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601203F RID: 73791 RVA: 0x002A2819 File Offset: 0x002A0A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012040 RID: 73792 RVA: 0x002A2824 File Offset: 0x002A0A24
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
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.phantomSubProp_.AddEntriesFrom(ref input, PhantomVicePolishResponse._repeated_phantomSubProp_codec);
				}
			}
		}

		// Token: 0x0400712C RID: 28972
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400712D RID: 28973
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400712E RID: 28974
		private ErrorCode errorCode_;

		// Token: 0x0400712F RID: 28975
		public const int PhantomSubPropFieldNumber = 6;

		// Token: 0x04007130 RID: 28976
		private static readonly FieldCodec<PhantomPropInfo> _repeated_phantomSubProp_codec = FieldCodec.ForMessage<PhantomPropInfo>(50U, PhantomPropInfo.Parser);

		// Token: 0x04007131 RID: 28977
		private readonly RepeatedField<PhantomPropInfo> phantomSubProp_ = new RepeatedField<PhantomPropInfo>();
	}
}
