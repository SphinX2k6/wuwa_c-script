using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF8 RID: 3064
	[NetMessage(EMessageId.PayShopUnlockNotify)]
	public sealed class PayShopUnlockNotify : IMessage<PayShopUnlockNotify>, IMessage, IEquatable<PayShopUnlockNotify>, IDeepCloneable<PayShopUnlockNotify>, IBufferMessage
	{
		// Token: 0x06010A18 RID: 68120 RVA: 0x0026F5A5 File Offset: 0x0026D7A5
		[NullableContext(1)]
		public static PayShopUnlockNotify Create()
		{
			return new PayShopUnlockNotify();
		}

		// Token: 0x170036CF RID: 14031
		// (get) Token: 0x06010A19 RID: 68121 RVA: 0x0026F5AC File Offset: 0x0026D7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036D0 RID: 14032
		// (get) Token: 0x06010A1A RID: 68122 RVA: 0x0026F5AF File Offset: 0x0026D7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06010A1B RID: 68123 RVA: 0x0026F5B6 File Offset: 0x0026D7B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUnlockNotify()
		{
		}

		// Token: 0x06010A1C RID: 68124 RVA: 0x0026F5C9 File Offset: 0x0026D7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUnlockNotify(PayShopUnlockNotify other) : this()
		{
			this.unlockList_ = other.unlockList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010A1D RID: 68125 RVA: 0x0026F5F3 File Offset: 0x0026D7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUnlockNotify Clone()
		{
			return new PayShopUnlockNotify(this);
		}

		// Token: 0x170036D1 RID: 14033
		// (get) Token: 0x06010A1E RID: 68126 RVA: 0x0026F5FB File Offset: 0x0026D7FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockList
		{
			get
			{
				return this.unlockList_;
			}
		}

		// Token: 0x06010A1F RID: 68127 RVA: 0x0026F603 File Offset: 0x0026D803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopUnlockNotify);
		}

		// Token: 0x06010A20 RID: 68128 RVA: 0x0026F611 File Offset: 0x0026D811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockList_.Equals(other.unlockList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010A21 RID: 68129 RVA: 0x0026F644 File Offset: 0x0026D844
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

		// Token: 0x06010A22 RID: 68130 RVA: 0x0026F678 File Offset: 0x0026D878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010A23 RID: 68131 RVA: 0x0026F685 File Offset: 0x0026D885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010A24 RID: 68132 RVA: 0x0026F68E File Offset: 0x0026D88E
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

		// Token: 0x06010A25 RID: 68133 RVA: 0x0026F6B8 File Offset: 0x0026D8B8
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

		// Token: 0x06010A26 RID: 68134 RVA: 0x0026F6F1 File Offset: 0x0026D8F1
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

		// Token: 0x06010A27 RID: 68135 RVA: 0x0026F71F File Offset: 0x0026D91F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010A28 RID: 68136 RVA: 0x0026F728 File Offset: 0x0026D928
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockList_.AddEntriesFrom(ref input, PayShopUnlockNotify._repeated_unlockList_codec);
				}
			}
		}

		// Token: 0x040069BD RID: 27069
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069BE RID: 27070
		public const int UnlockListFieldNumber = 11;

		// Token: 0x040069BF RID: 27071
		private static readonly FieldCodec<int> _repeated_unlockList_codec = FieldCodec.ForInt32(90U);

		// Token: 0x040069C0 RID: 27072
		private readonly RepeatedField<int> unlockList_ = new RepeatedField<int>();
	}
}
