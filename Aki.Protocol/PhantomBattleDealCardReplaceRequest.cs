using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C72 RID: 3186
	[NetMessage(EMessageId.PhantomBattleDealCardReplaceRequest)]
	public sealed class PhantomBattleDealCardReplaceRequest : IMessage<PhantomBattleDealCardReplaceRequest>, IMessage, IEquatable<PhantomBattleDealCardReplaceRequest>, IDeepCloneable<PhantomBattleDealCardReplaceRequest>, IBufferMessage
	{
		// Token: 0x06011458 RID: 70744 RVA: 0x0028764C File Offset: 0x0028584C
		[NullableContext(1)]
		public static PhantomBattleDealCardReplaceRequest Create()
		{
			return new PhantomBattleDealCardReplaceRequest();
		}

		// Token: 0x17003923 RID: 14627
		// (get) Token: 0x06011459 RID: 70745 RVA: 0x00287653 File Offset: 0x00285853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003924 RID: 14628
		// (get) Token: 0x0601145A RID: 70746 RVA: 0x00287656 File Offset: 0x00285856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDealCardReplaceRequest.Descriptor;
			}
		}

		// Token: 0x0601145B RID: 70747 RVA: 0x0028765D File Offset: 0x0028585D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceRequest()
		{
		}

		// Token: 0x0601145C RID: 70748 RVA: 0x00287670 File Offset: 0x00285870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceRequest(PhantomBattleDealCardReplaceRequest other) : this()
		{
			this.replaceCardUid_ = other.replaceCardUid_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601145D RID: 70749 RVA: 0x0028769A File Offset: 0x0028589A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardReplaceRequest Clone()
		{
			return new PhantomBattleDealCardReplaceRequest(this);
		}

		// Token: 0x17003925 RID: 14629
		// (get) Token: 0x0601145E RID: 70750 RVA: 0x002876A2 File Offset: 0x002858A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReplaceCardUid
		{
			get
			{
				return this.replaceCardUid_;
			}
		}

		// Token: 0x0601145F RID: 70751 RVA: 0x002876AA File Offset: 0x002858AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDealCardReplaceRequest);
		}

		// Token: 0x06011460 RID: 70752 RVA: 0x002876B8 File Offset: 0x002858B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDealCardReplaceRequest other)
		{
			return other != null && (other == this || (this.replaceCardUid_.Equals(other.replaceCardUid_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011461 RID: 70753 RVA: 0x002876EC File Offset: 0x002858EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.replaceCardUid_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011462 RID: 70754 RVA: 0x00287720 File Offset: 0x00285920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011463 RID: 70755 RVA: 0x0028772D File Offset: 0x0028592D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011464 RID: 70756 RVA: 0x00287736 File Offset: 0x00285936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.replaceCardUid_.WriteTo(ref output, PhantomBattleDealCardReplaceRequest._repeated_replaceCardUid_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011465 RID: 70757 RVA: 0x00287760 File Offset: 0x00285960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.replaceCardUid_.CalculateSize(PhantomBattleDealCardReplaceRequest._repeated_replaceCardUid_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011466 RID: 70758 RVA: 0x00287799 File Offset: 0x00285999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDealCardReplaceRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.replaceCardUid_.Add(other.replaceCardUid_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011467 RID: 70759 RVA: 0x002877C7 File Offset: 0x002859C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011468 RID: 70760 RVA: 0x002877D0 File Offset: 0x002859D0
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
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.replaceCardUid_.AddEntriesFrom(ref input, PhantomBattleDealCardReplaceRequest._repeated_replaceCardUid_codec);
				}
			}
		}

		// Token: 0x04006D3A RID: 27962
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D3B RID: 27963
		public const int ReplaceCardUidFieldNumber = 5;

		// Token: 0x04006D3C RID: 27964
		private static readonly FieldCodec<int> _repeated_replaceCardUid_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04006D3D RID: 27965
		private readonly RepeatedField<int> replaceCardUid_ = new RepeatedField<int>();
	}
}
