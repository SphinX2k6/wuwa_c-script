using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A7 RID: 423
	public sealed class BlackboardParamComponentPb : IMessage<BlackboardParamComponentPb>, IMessage, IEquatable<BlackboardParamComponentPb>, IDeepCloneable<BlackboardParamComponentPb>, IBufferMessage
	{
		// Token: 0x060031E8 RID: 12776 RVA: 0x0007F5E5 File Offset: 0x0007D7E5
		[NullableContext(1)]
		public static BlackboardParamComponentPb Create()
		{
			return new BlackboardParamComponentPb();
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060031E9 RID: 12777 RVA: 0x0007F5EC File Offset: 0x0007D7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060031EA RID: 12778 RVA: 0x0007F5EF File Offset: 0x0007D7EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackboardParamComponentPb.Descriptor;
			}
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x0007F5F6 File Offset: 0x0007D7F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackboardParamComponentPb()
		{
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x0007F609 File Offset: 0x0007D809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackboardParamComponentPb(BlackboardParamComponentPb other) : this()
		{
			this.blackboardParams_ = other.blackboardParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x0007F633 File Offset: 0x0007D833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackboardParamComponentPb Clone()
		{
			return new BlackboardParamComponentPb(this);
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x060031EE RID: 12782 RVA: 0x0007F63B File Offset: 0x0007D83B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> BlackboardParams
		{
			get
			{
				return this.blackboardParams_;
			}
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x0007F643 File Offset: 0x0007D843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackboardParamComponentPb);
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x0007F651 File Offset: 0x0007D851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackboardParamComponentPb other)
		{
			return other != null && (other == this || (this.blackboardParams_.Equals(other.blackboardParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x0007F684 File Offset: 0x0007D884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.blackboardParams_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x0007F6B8 File Offset: 0x0007D8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x0007F6C5 File Offset: 0x0007D8C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x0007F6CE File Offset: 0x0007D8CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.blackboardParams_.WriteTo(ref output, BlackboardParamComponentPb._repeated_blackboardParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x0007F6F8 File Offset: 0x0007D8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.blackboardParams_.CalculateSize(BlackboardParamComponentPb._repeated_blackboardParams_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x0007F731 File Offset: 0x0007D931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackboardParamComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.blackboardParams_.Add(other.blackboardParams_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x0007F75F File Offset: 0x0007D95F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x0007F768 File Offset: 0x0007D968
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
					this.blackboardParams_.AddEntriesFrom(ref input, BlackboardParamComponentPb._repeated_blackboardParams_codec);
				}
			}
		}

		// Token: 0x040029A8 RID: 10664
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029A9 RID: 10665
		public const int BlackboardParamsFieldNumber = 1;

		// Token: 0x040029AA RID: 10666
		private static readonly FieldCodec<BlackboardParam> _repeated_blackboardParams_codec = FieldCodec.ForMessage<BlackboardParam>(10U, BlackboardParam.Parser);

		// Token: 0x040029AB RID: 10667
		private readonly RepeatedField<BlackboardParam> blackboardParams_ = new RepeatedField<BlackboardParam>();
	}
}
