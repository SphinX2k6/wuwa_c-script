using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001249 RID: 4681
	[NetMessage(EMessageId.ShortMessageUpdateNotify)]
	public sealed class ShortMessageUpdateNotify : IMessage<ShortMessageUpdateNotify>, IMessage, IEquatable<ShortMessageUpdateNotify>, IDeepCloneable<ShortMessageUpdateNotify>, IBufferMessage
	{
		// Token: 0x06018FEA RID: 102378 RVA: 0x003A4BE9 File Offset: 0x003A2DE9
		[NullableContext(1)]
		public static ShortMessageUpdateNotify Create()
		{
			return new ShortMessageUpdateNotify();
		}

		// Token: 0x17005476 RID: 21622
		// (get) Token: 0x06018FEB RID: 102379 RVA: 0x003A4BF0 File Offset: 0x003A2DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005477 RID: 21623
		// (get) Token: 0x06018FEC RID: 102380 RVA: 0x003A4BF3 File Offset: 0x003A2DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06018FED RID: 102381 RVA: 0x003A4BFA File Offset: 0x003A2DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateNotify()
		{
		}

		// Token: 0x06018FEE RID: 102382 RVA: 0x003A4C24 File Offset: 0x003A2E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateNotify(ShortMessageUpdateNotify other) : this()
		{
			this.adds_ = other.adds_.Clone();
			this.removes_ = other.removes_.Clone();
			this.reason_ = other.reason_;
			this.newPartnerChange_ = other.newPartnerChange_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018FEF RID: 102383 RVA: 0x003A4C87 File Offset: 0x003A2E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageUpdateNotify Clone()
		{
			return new ShortMessageUpdateNotify(this);
		}

		// Token: 0x17005478 RID: 21624
		// (get) Token: 0x06018FF0 RID: 102384 RVA: 0x003A4C8F File Offset: 0x003A2E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShortMessageInfo> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x17005479 RID: 21625
		// (get) Token: 0x06018FF1 RID: 102385 RVA: 0x003A4C97 File Offset: 0x003A2E97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Removes
		{
			get
			{
				return this.removes_;
			}
		}

		// Token: 0x1700547A RID: 21626
		// (get) Token: 0x06018FF2 RID: 102386 RVA: 0x003A4C9F File Offset: 0x003A2E9F
		// (set) Token: 0x06018FF3 RID: 102387 RVA: 0x003A4CA7 File Offset: 0x003A2EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x1700547B RID: 21627
		// (get) Token: 0x06018FF4 RID: 102388 RVA: 0x003A4CB0 File Offset: 0x003A2EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NewPartnerChange
		{
			get
			{
				return this.newPartnerChange_;
			}
		}

		// Token: 0x06018FF5 RID: 102389 RVA: 0x003A4CB8 File Offset: 0x003A2EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageUpdateNotify);
		}

		// Token: 0x06018FF6 RID: 102390 RVA: 0x003A4CC8 File Offset: 0x003A2EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageUpdateNotify other)
		{
			return other != null && (other == this || (this.adds_.Equals(other.adds_) && this.removes_.Equals(other.removes_) && this.Reason == other.Reason && this.newPartnerChange_.Equals(other.newPartnerChange_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018FF7 RID: 102391 RVA: 0x003A4D40 File Offset: 0x003A2F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.adds_.GetHashCode();
			num ^= this.removes_.GetHashCode();
			if (this.Reason != ChangeReason.None)
			{
				num ^= this.Reason.GetHashCode();
			}
			num ^= this.newPartnerChange_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018FF8 RID: 102392 RVA: 0x003A4DAF File Offset: 0x003A2FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018FF9 RID: 102393 RVA: 0x003A4DBC File Offset: 0x003A2FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018FFA RID: 102394 RVA: 0x003A4DC8 File Offset: 0x003A2FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.removes_.WriteTo(ref output, ShortMessageUpdateNotify._repeated_removes_codec);
			this.adds_.WriteTo(ref output, ShortMessageUpdateNotify._repeated_adds_codec);
			this.newPartnerChange_.WriteTo(ref output, ShortMessageUpdateNotify._repeated_newPartnerChange_codec);
			if (this.Reason != ChangeReason.None)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018FFB RID: 102395 RVA: 0x003A4E38 File Offset: 0x003A3038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.adds_.CalculateSize(ShortMessageUpdateNotify._repeated_adds_codec);
			num += this.removes_.CalculateSize(ShortMessageUpdateNotify._repeated_removes_codec);
			if (this.Reason != ChangeReason.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			num += this.newPartnerChange_.CalculateSize(ShortMessageUpdateNotify._repeated_newPartnerChange_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018FFC RID: 102396 RVA: 0x003A4EB0 File Offset: 0x003A30B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.adds_.Add(other.adds_);
			this.removes_.Add(other.removes_);
			if (other.Reason != ChangeReason.None)
			{
				this.Reason = other.Reason;
			}
			this.newPartnerChange_.Add(other.newPartnerChange_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018FFD RID: 102397 RVA: 0x003A4F1F File Offset: 0x003A311F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018FFE RID: 102398 RVA: 0x003A4F28 File Offset: 0x003A3128
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
				if (num <= 34U)
				{
					if (num == 16U || num == 18U)
					{
						this.removes_.AddEntriesFrom(ref input, ShortMessageUpdateNotify._repeated_removes_codec);
						continue;
					}
					if (num == 34U)
					{
						this.adds_.AddEntriesFrom(ref input, ShortMessageUpdateNotify._repeated_adds_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U || num == 82U)
					{
						this.newPartnerChange_.AddEntriesFrom(ref input, ShortMessageUpdateNotify._repeated_newPartnerChange_codec);
						continue;
					}
					if (num == 112U)
					{
						this.Reason = (ChangeReason)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009431 RID: 37937
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009432 RID: 37938
		public const int AddsFieldNumber = 4;

		// Token: 0x04009433 RID: 37939
		private static readonly FieldCodec<ShortMessageInfo> _repeated_adds_codec = FieldCodec.ForMessage<ShortMessageInfo>(34U, ShortMessageInfo.Parser);

		// Token: 0x04009434 RID: 37940
		private readonly RepeatedField<ShortMessageInfo> adds_ = new RepeatedField<ShortMessageInfo>();

		// Token: 0x04009435 RID: 37941
		public const int RemovesFieldNumber = 2;

		// Token: 0x04009436 RID: 37942
		private static readonly FieldCodec<int> _repeated_removes_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04009437 RID: 37943
		private readonly RepeatedField<int> removes_ = new RepeatedField<int>();

		// Token: 0x04009438 RID: 37944
		public const int ReasonFieldNumber = 14;

		// Token: 0x04009439 RID: 37945
		private ChangeReason reason_;

		// Token: 0x0400943A RID: 37946
		public const int NewPartnerChangeFieldNumber = 10;

		// Token: 0x0400943B RID: 37947
		private static readonly FieldCodec<int> _repeated_newPartnerChange_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400943C RID: 37948
		private readonly RepeatedField<int> newPartnerChange_ = new RepeatedField<int>();
	}
}
