using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE0 RID: 3040
	public sealed class PayGiftShopInfo : IMessage<PayGiftShopInfo>, IMessage, IEquatable<PayGiftShopInfo>, IDeepCloneable<PayGiftShopInfo>, IBufferMessage
	{
		// Token: 0x06010788 RID: 67464 RVA: 0x002675DB File Offset: 0x002657DB
		[NullableContext(1)]
		public static PayGiftShopInfo Create()
		{
			return new PayGiftShopInfo();
		}

		// Token: 0x17003613 RID: 13843
		// (get) Token: 0x06010789 RID: 67465 RVA: 0x002675E2 File Offset: 0x002657E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003614 RID: 13844
		// (get) Token: 0x0601078A RID: 67466 RVA: 0x002675E5 File Offset: 0x002657E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayGiftShopInfo.Descriptor;
			}
		}

		// Token: 0x0601078B RID: 67467 RVA: 0x002675EC File Offset: 0x002657EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftShopInfo()
		{
		}

		// Token: 0x0601078C RID: 67468 RVA: 0x0026760A File Offset: 0x0026580A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftShopInfo(PayGiftShopInfo other) : this()
		{
			this.gifts_ = other.gifts_.Clone();
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601078D RID: 67469 RVA: 0x00267640 File Offset: 0x00265840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftShopInfo Clone()
		{
			return new PayGiftShopInfo(this);
		}

		// Token: 0x17003615 RID: 13845
		// (get) Token: 0x0601078E RID: 67470 RVA: 0x00267648 File Offset: 0x00265848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayGiftInfo> Gifts
		{
			get
			{
				return this.gifts_;
			}
		}

		// Token: 0x17003616 RID: 13846
		// (get) Token: 0x0601078F RID: 67471 RVA: 0x00267650 File Offset: 0x00265850
		// (set) Token: 0x06010790 RID: 67472 RVA: 0x00267658 File Offset: 0x00265858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06010791 RID: 67473 RVA: 0x0026766B File Offset: 0x0026586B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayGiftShopInfo);
		}

		// Token: 0x06010792 RID: 67474 RVA: 0x0026767C File Offset: 0x0026587C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayGiftShopInfo other)
		{
			return other != null && (other == this || (this.gifts_.Equals(other.gifts_) && !(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010793 RID: 67475 RVA: 0x002676D0 File Offset: 0x002658D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gifts_.GetHashCode();
			if (this.Version.Length != 0)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010794 RID: 67476 RVA: 0x0026771F File Offset: 0x0026591F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010795 RID: 67477 RVA: 0x0026772C File Offset: 0x0026592C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010796 RID: 67478 RVA: 0x00267738 File Offset: 0x00265938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gifts_.WriteTo(ref output, PayGiftShopInfo._repeated_gifts_codec);
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010797 RID: 67479 RVA: 0x0026778C File Offset: 0x0026598C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gifts_.CalculateSize(PayGiftShopInfo._repeated_gifts_codec);
			if (this.Version.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010798 RID: 67480 RVA: 0x002677E4 File Offset: 0x002659E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayGiftShopInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.gifts_.Add(other.gifts_);
			if (other.Version.Length != 0)
			{
				this.Version = other.Version;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010799 RID: 67481 RVA: 0x00267836 File Offset: 0x00265A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601079A RID: 67482 RVA: 0x00267840 File Offset: 0x00265A40
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Version = input.ReadString();
					}
				}
				else
				{
					this.gifts_.AddEntriesFrom(ref input, PayGiftShopInfo._repeated_gifts_codec);
				}
			}
		}

		// Token: 0x04006883 RID: 26755
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006884 RID: 26756
		public const int GiftsFieldNumber = 1;

		// Token: 0x04006885 RID: 26757
		private static readonly FieldCodec<PayGiftInfo> _repeated_gifts_codec = FieldCodec.ForMessage<PayGiftInfo>(10U, PayGiftInfo.Parser);

		// Token: 0x04006886 RID: 26758
		private readonly RepeatedField<PayGiftInfo> gifts_ = new RepeatedField<PayGiftInfo>();

		// Token: 0x04006887 RID: 26759
		public const int VersionFieldNumber = 2;

		// Token: 0x04006888 RID: 26760
		private string version_ = "";
	}
}
