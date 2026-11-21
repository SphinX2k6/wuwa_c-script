using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200055B RID: 1371
	[NetMessage(EMessageId.FishingPortUnlockNotify)]
	public sealed class FishingPortUnlockNotify : IMessage<FishingPortUnlockNotify>, IMessage, IEquatable<FishingPortUnlockNotify>, IDeepCloneable<FishingPortUnlockNotify>, IBufferMessage
	{
		// Token: 0x06008033 RID: 32819 RVA: 0x001365D3 File Offset: 0x001347D3
		[NullableContext(1)]
		public static FishingPortUnlockNotify Create()
		{
			return new FishingPortUnlockNotify();
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x06008034 RID: 32820 RVA: 0x001365DA File Offset: 0x001347DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x06008035 RID: 32821 RVA: 0x001365DD File Offset: 0x001347DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingPortUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06008036 RID: 32822 RVA: 0x001365E4 File Offset: 0x001347E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPortUnlockNotify()
		{
		}

		// Token: 0x06008037 RID: 32823 RVA: 0x001365F7 File Offset: 0x001347F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPortUnlockNotify(FishingPortUnlockNotify other) : this()
		{
			this.unlockPortId_ = other.unlockPortId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008038 RID: 32824 RVA: 0x00136621 File Offset: 0x00134821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPortUnlockNotify Clone()
		{
			return new FishingPortUnlockNotify(this);
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x06008039 RID: 32825 RVA: 0x00136629 File Offset: 0x00134829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockPortId
		{
			get
			{
				return this.unlockPortId_;
			}
		}

		// Token: 0x0600803A RID: 32826 RVA: 0x00136631 File Offset: 0x00134831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingPortUnlockNotify);
		}

		// Token: 0x0600803B RID: 32827 RVA: 0x0013663F File Offset: 0x0013483F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingPortUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockPortId_.Equals(other.unlockPortId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600803C RID: 32828 RVA: 0x00136674 File Offset: 0x00134874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockPortId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600803D RID: 32829 RVA: 0x001366A8 File Offset: 0x001348A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600803E RID: 32830 RVA: 0x001366B5 File Offset: 0x001348B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600803F RID: 32831 RVA: 0x001366BE File Offset: 0x001348BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockPortId_.WriteTo(ref output, FishingPortUnlockNotify._repeated_unlockPortId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008040 RID: 32832 RVA: 0x001366E8 File Offset: 0x001348E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockPortId_.CalculateSize(FishingPortUnlockNotify._repeated_unlockPortId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008041 RID: 32833 RVA: 0x00136721 File Offset: 0x00134921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingPortUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockPortId_.Add(other.unlockPortId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008042 RID: 32834 RVA: 0x0013674F File Offset: 0x0013494F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008043 RID: 32835 RVA: 0x00136758 File Offset: 0x00134958
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockPortId_.AddEntriesFrom(ref input, FishingPortUnlockNotify._repeated_unlockPortId_codec);
				}
			}
		}

		// Token: 0x04004105 RID: 16645
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004106 RID: 16646
		public const int UnlockPortIdFieldNumber = 12;

		// Token: 0x04004107 RID: 16647
		private static readonly FieldCodec<int> _repeated_unlockPortId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04004108 RID: 16648
		private readonly RepeatedField<int> unlockPortId_ = new RepeatedField<int>();
	}
}
