using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE8 RID: 3048
	[NetMessage(EMessageId.PayShopUnlockNotify)]
	public sealed class PayShopUnlockNotify : IMessage<PayShopUnlockNotify>, IMessage, IEquatable<PayShopUnlockNotify>, IDeepCloneable<PayShopUnlockNotify>, IBufferMessage
	{
		// Token: 0x06010918 RID: 67864 RVA: 0x0026D83D File Offset: 0x0026BA3D
		[NullableContext(1)]
		public static PayShopUnlockNotify Create()
		{
			return new PayShopUnlockNotify();
		}

		// Token: 0x17003698 RID: 13976
		// (get) Token: 0x06010919 RID: 67865 RVA: 0x0026D844 File Offset: 0x0026BA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003699 RID: 13977
		// (get) Token: 0x0601091A RID: 67866 RVA: 0x0026D847 File Offset: 0x0026BA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0601091B RID: 67867 RVA: 0x0026D84E File Offset: 0x0026BA4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUnlockNotify()
		{
		}

		// Token: 0x0601091C RID: 67868 RVA: 0x0026D861 File Offset: 0x0026BA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUnlockNotify(PayShopUnlockNotify other) : this()
		{
			this.unlockList_ = other.unlockList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601091D RID: 67869 RVA: 0x0026D88B File Offset: 0x0026BA8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUnlockNotify Clone()
		{
			return new PayShopUnlockNotify(this);
		}

		// Token: 0x1700369A RID: 13978
		// (get) Token: 0x0601091E RID: 67870 RVA: 0x0026D893 File Offset: 0x0026BA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockList
		{
			get
			{
				return this.unlockList_;
			}
		}

		// Token: 0x0601091F RID: 67871 RVA: 0x0026D89B File Offset: 0x0026BA9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopUnlockNotify);
		}

		// Token: 0x06010920 RID: 67872 RVA: 0x0026D8A9 File Offset: 0x0026BAA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockList_.Equals(other.unlockList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010921 RID: 67873 RVA: 0x0026D8DC File Offset: 0x0026BADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010922 RID: 67874 RVA: 0x0026D910 File Offset: 0x0026BB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010923 RID: 67875 RVA: 0x0026D91D File Offset: 0x0026BB1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010924 RID: 67876 RVA: 0x0026D926 File Offset: 0x0026BB26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockList_.WriteTo(ref output, PayShopUnlockNotify._repeated_unlockList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010925 RID: 67877 RVA: 0x0026D950 File Offset: 0x0026BB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockList_.CalculateSize(PayShopUnlockNotify._repeated_unlockList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010926 RID: 67878 RVA: 0x0026D989 File Offset: 0x0026BB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockList_.Add(other.unlockList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010927 RID: 67879 RVA: 0x0026D9B7 File Offset: 0x0026BBB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010928 RID: 67880 RVA: 0x0026D9C0 File Offset: 0x0026BBC0
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockList_.AddEntriesFrom(ref input, PayShopUnlockNotify._repeated_unlockList_codec);
				}
			}
		}

		// Token: 0x040069D1 RID: 27089
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069D2 RID: 27090
		public const int UnlockListFieldNumber = 6;

		// Token: 0x040069D3 RID: 27091
		private static readonly FieldCodec<int> _repeated_unlockList_codec = FieldCodec.ForInt32(50U);

		// Token: 0x040069D4 RID: 27092
		private readonly RepeatedField<int> unlockList_ = new RepeatedField<int>();
	}
}
