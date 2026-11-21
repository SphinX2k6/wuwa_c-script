using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B33 RID: 2867
	[NetMessage(EMessageId.NewTowerRewardRequest)]
	public sealed class NewTowerRewardRequest : IMessage<NewTowerRewardRequest>, IMessage, IEquatable<NewTowerRewardRequest>, IDeepCloneable<NewTowerRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F927 RID: 63783 RVA: 0x00245DA0 File Offset: 0x00243FA0
		[NullableContext(1)]
		public static NewTowerRewardRequest Create()
		{
			return new NewTowerRewardRequest();
		}

		// Token: 0x170032CD RID: 13005
		// (get) Token: 0x0600F928 RID: 63784 RVA: 0x00245DA7 File Offset: 0x00243FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032CE RID: 13006
		// (get) Token: 0x0600F929 RID: 63785 RVA: 0x00245DAA File Offset: 0x00243FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F92A RID: 63786 RVA: 0x00245DB1 File Offset: 0x00243FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRewardRequest()
		{
		}

		// Token: 0x0600F92B RID: 63787 RVA: 0x00245DC4 File Offset: 0x00243FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRewardRequest(NewTowerRewardRequest other) : this()
		{
			this.indexs_ = other.indexs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F92C RID: 63788 RVA: 0x00245DEE File Offset: 0x00243FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRewardRequest Clone()
		{
			return new NewTowerRewardRequest(this);
		}

		// Token: 0x170032CF RID: 13007
		// (get) Token: 0x0600F92D RID: 63789 RVA: 0x00245DF6 File Offset: 0x00243FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Indexs
		{
			get
			{
				return this.indexs_;
			}
		}

		// Token: 0x0600F92E RID: 63790 RVA: 0x00245DFE File Offset: 0x00243FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRewardRequest);
		}

		// Token: 0x0600F92F RID: 63791 RVA: 0x00245E0C File Offset: 0x0024400C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRewardRequest other)
		{
			return other != null && (other == this || (this.indexs_.Equals(other.indexs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F930 RID: 63792 RVA: 0x00245E40 File Offset: 0x00244040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.indexs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F931 RID: 63793 RVA: 0x00245E74 File Offset: 0x00244074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F932 RID: 63794 RVA: 0x00245E81 File Offset: 0x00244081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F933 RID: 63795 RVA: 0x00245E8A File Offset: 0x0024408A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.indexs_.WriteTo(ref output, NewTowerRewardRequest._repeated_indexs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F934 RID: 63796 RVA: 0x00245EB4 File Offset: 0x002440B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.indexs_.CalculateSize(NewTowerRewardRequest._repeated_indexs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F935 RID: 63797 RVA: 0x00245EED File Offset: 0x002440ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.indexs_.Add(other.indexs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F936 RID: 63798 RVA: 0x00245F1B File Offset: 0x0024411B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F937 RID: 63799 RVA: 0x00245F24 File Offset: 0x00244124
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.indexs_.AddEntriesFrom(ref input, NewTowerRewardRequest._repeated_indexs_codec);
				}
			}
		}

		// Token: 0x04006445 RID: 25669
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006446 RID: 25670
		public const int IndexsFieldNumber = 8;

		// Token: 0x04006447 RID: 25671
		private static readonly FieldCodec<int> _repeated_indexs_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04006448 RID: 25672
		private readonly RepeatedField<int> indexs_ = new RepeatedField<int>();
	}
}
