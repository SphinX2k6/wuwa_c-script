using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C9F RID: 3231
	[NetMessage(EMessageId.PhantomBattleSelectReserveCardNotify)]
	public sealed class PhantomBattleSelectReserveCardNotify : IMessage<PhantomBattleSelectReserveCardNotify>, IMessage, IEquatable<PhantomBattleSelectReserveCardNotify>, IDeepCloneable<PhantomBattleSelectReserveCardNotify>, IBufferMessage
	{
		// Token: 0x0601186E RID: 71790 RVA: 0x00291949 File Offset: 0x0028FB49
		[NullableContext(1)]
		public static PhantomBattleSelectReserveCardNotify Create()
		{
			return new PhantomBattleSelectReserveCardNotify();
		}

		// Token: 0x17003A0E RID: 14862
		// (get) Token: 0x0601186F RID: 71791 RVA: 0x00291950 File Offset: 0x0028FB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A0F RID: 14863
		// (get) Token: 0x06011870 RID: 71792 RVA: 0x00291953 File Offset: 0x0028FB53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSelectReserveCardNotify.Descriptor;
			}
		}

		// Token: 0x06011871 RID: 71793 RVA: 0x0029195A File Offset: 0x0028FB5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectReserveCardNotify()
		{
		}

		// Token: 0x06011872 RID: 71794 RVA: 0x0029196D File Offset: 0x0028FB6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectReserveCardNotify(PhantomBattleSelectReserveCardNotify other) : this()
		{
			this.reserveCardNum_ = other.reserveCardNum_;
			this.phantomBattleHandCardInfos_ = other.phantomBattleHandCardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011873 RID: 71795 RVA: 0x002919A3 File Offset: 0x0028FBA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectReserveCardNotify Clone()
		{
			return new PhantomBattleSelectReserveCardNotify(this);
		}

		// Token: 0x17003A10 RID: 14864
		// (get) Token: 0x06011874 RID: 71796 RVA: 0x002919AB File Offset: 0x0028FBAB
		// (set) Token: 0x06011875 RID: 71797 RVA: 0x002919B3 File Offset: 0x0028FBB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReserveCardNum
		{
			get
			{
				return this.reserveCardNum_;
			}
			set
			{
				this.reserveCardNum_ = value;
			}
		}

		// Token: 0x17003A11 RID: 14865
		// (get) Token: 0x06011876 RID: 71798 RVA: 0x002919BC File Offset: 0x0028FBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x06011877 RID: 71799 RVA: 0x002919C4 File Offset: 0x0028FBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSelectReserveCardNotify);
		}

		// Token: 0x06011878 RID: 71800 RVA: 0x002919D4 File Offset: 0x0028FBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSelectReserveCardNotify other)
		{
			return other != null && (other == this || (this.ReserveCardNum == other.ReserveCardNum && this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011879 RID: 71801 RVA: 0x00291A24 File Offset: 0x0028FC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ReserveCardNum != 0)
			{
				num ^= this.ReserveCardNum.GetHashCode();
			}
			num ^= this.phantomBattleHandCardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601187A RID: 71802 RVA: 0x00291A71 File Offset: 0x0028FC71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601187B RID: 71803 RVA: 0x00291A7E File Offset: 0x0028FC7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601187C RID: 71804 RVA: 0x00291A88 File Offset: 0x0028FC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleHandCardInfos_.WriteTo(ref output, PhantomBattleSelectReserveCardNotify._repeated_phantomBattleHandCardInfos_codec);
			if (this.ReserveCardNum != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ReserveCardNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601187D RID: 71805 RVA: 0x00291AD8 File Offset: 0x0028FCD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ReserveCardNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReserveCardNum);
			}
			num += this.phantomBattleHandCardInfos_.CalculateSize(PhantomBattleSelectReserveCardNotify._repeated_phantomBattleHandCardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601187E RID: 71806 RVA: 0x00291B2C File Offset: 0x0028FD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSelectReserveCardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ReserveCardNum != 0)
			{
				this.ReserveCardNum = other.ReserveCardNum;
			}
			this.phantomBattleHandCardInfos_.Add(other.phantomBattleHandCardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601187F RID: 71807 RVA: 0x00291B79 File Offset: 0x0028FD79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011880 RID: 71808 RVA: 0x00291B84 File Offset: 0x0028FD84
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
				if (num != 18U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ReserveCardNum = input.ReadInt32();
					}
				}
				else
				{
					this.phantomBattleHandCardInfos_.AddEntriesFrom(ref input, PhantomBattleSelectReserveCardNotify._repeated_phantomBattleHandCardInfos_codec);
				}
			}
		}

		// Token: 0x04006EE1 RID: 28385
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EE2 RID: 28386
		public const int ReserveCardNumFieldNumber = 15;

		// Token: 0x04006EE3 RID: 28387
		private int reserveCardNum_;

		// Token: 0x04006EE4 RID: 28388
		public const int PhantomBattleHandCardInfosFieldNumber = 2;

		// Token: 0x04006EE5 RID: 28389
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(18U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006EE6 RID: 28390
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();
	}
}
