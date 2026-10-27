using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A3 RID: 419
	public sealed class BlackboardParamComponentPb : IMessage<BlackboardParamComponentPb>, IMessage, IEquatable<BlackboardParamComponentPb>, IDeepCloneable<BlackboardParamComponentPb>, IBufferMessage
	{
		// Token: 0x0600315B RID: 12635 RVA: 0x0007DE7D File Offset: 0x0007C07D
		[NullableContext(1)]
		public static BlackboardParamComponentPb Create()
		{
			return new BlackboardParamComponentPb();
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x0600315C RID: 12636 RVA: 0x0007DE84 File Offset: 0x0007C084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x0600315D RID: 12637 RVA: 0x0007DE87 File Offset: 0x0007C087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackboardParamComponentPb.Descriptor;
			}
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x0007DE8E File Offset: 0x0007C08E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackboardParamComponentPb()
		{
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x0007DEA1 File Offset: 0x0007C0A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackboardParamComponentPb(BlackboardParamComponentPb other) : this()
		{
			this.blackboardParams_ = other.blackboardParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x0007DECB File Offset: 0x0007C0CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackboardParamComponentPb Clone()
		{
			return new BlackboardParamComponentPb(this);
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06003161 RID: 12641 RVA: 0x0007DED3 File Offset: 0x0007C0D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> BlackboardParams
		{
			get
			{
				return this.blackboardParams_;
			}
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x0007DEDB File Offset: 0x0007C0DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackboardParamComponentPb);
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x0007DEE9 File Offset: 0x0007C0E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackboardParamComponentPb other)
		{
			return other != null && (other == this || (this.blackboardParams_.Equals(other.blackboardParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x0007DF1C File Offset: 0x0007C11C
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

		// Token: 0x06003165 RID: 12645 RVA: 0x0007DF50 File Offset: 0x0007C150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x0007DF5D File Offset: 0x0007C15D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x0007DF66 File Offset: 0x0007C166
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

		// Token: 0x06003168 RID: 12648 RVA: 0x0007DF90 File Offset: 0x0007C190
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

		// Token: 0x06003169 RID: 12649 RVA: 0x0007DFC9 File Offset: 0x0007C1C9
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

		// Token: 0x0600316A RID: 12650 RVA: 0x0007DFF7 File Offset: 0x0007C1F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x0007E000 File Offset: 0x0007C200
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

		// Token: 0x0400292D RID: 10541
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400292E RID: 10542
		public const int BlackboardParamsFieldNumber = 1;

		// Token: 0x0400292F RID: 10543
		private static readonly FieldCodec<BlackboardParam> _repeated_blackboardParams_codec = FieldCodec.ForMessage<BlackboardParam>(10U, BlackboardParam.Parser);

		// Token: 0x04002930 RID: 10544
		private readonly RepeatedField<BlackboardParam> blackboardParams_ = new RepeatedField<BlackboardParam>();
	}
}
