using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ACE RID: 2766
	[NetMessage(EMessageId.MulGetAdventureRewardResponse)]
	public sealed class MulGetAdventureRewardResponse : IMessage<MulGetAdventureRewardResponse>, IMessage, IEquatable<MulGetAdventureRewardResponse>, IDeepCloneable<MulGetAdventureRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F103 RID: 61699 RVA: 0x0023386D File Offset: 0x00231A6D
		[NullableContext(1)]
		public static MulGetAdventureRewardResponse Create()
		{
			return new MulGetAdventureRewardResponse();
		}

		// Token: 0x1700310E RID: 12558
		// (get) Token: 0x0600F104 RID: 61700 RVA: 0x00233874 File Offset: 0x00231A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700310F RID: 12559
		// (get) Token: 0x0600F105 RID: 61701 RVA: 0x00233877 File Offset: 0x00231A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulGetAdventureRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F106 RID: 61702 RVA: 0x0023387E File Offset: 0x00231A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulGetAdventureRewardResponse()
		{
		}

		// Token: 0x0600F107 RID: 61703 RVA: 0x00233891 File Offset: 0x00231A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulGetAdventureRewardResponse(MulGetAdventureRewardResponse other) : this()
		{
			this.code_ = other.code_;
			this.id_ = other.id_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F108 RID: 61704 RVA: 0x002338C7 File Offset: 0x00231AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulGetAdventureRewardResponse Clone()
		{
			return new MulGetAdventureRewardResponse(this);
		}

		// Token: 0x17003110 RID: 12560
		// (get) Token: 0x0600F109 RID: 61705 RVA: 0x002338CF File Offset: 0x00231ACF
		// (set) Token: 0x0600F10A RID: 61706 RVA: 0x002338D7 File Offset: 0x00231AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17003111 RID: 12561
		// (get) Token: 0x0600F10B RID: 61707 RVA: 0x002338E0 File Offset: 0x00231AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Id
		{
			get
			{
				return this.id_;
			}
		}

		// Token: 0x0600F10C RID: 61708 RVA: 0x002338E8 File Offset: 0x00231AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulGetAdventureRewardResponse);
		}

		// Token: 0x0600F10D RID: 61709 RVA: 0x002338F8 File Offset: 0x00231AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulGetAdventureRewardResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.id_.Equals(other.id_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F10E RID: 61710 RVA: 0x00233948 File Offset: 0x00231B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			num ^= this.id_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F10F RID: 61711 RVA: 0x0023399B File Offset: 0x00231B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F110 RID: 61712 RVA: 0x002339A8 File Offset: 0x00231BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F111 RID: 61713 RVA: 0x002339B4 File Offset: 0x00231BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Code);
			}
			this.id_.WriteTo(ref output, MulGetAdventureRewardResponse._repeated_id_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F112 RID: 61714 RVA: 0x00233A04 File Offset: 0x00231C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			num += this.id_.CalculateSize(MulGetAdventureRewardResponse._repeated_id_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F113 RID: 61715 RVA: 0x00233A58 File Offset: 0x00231C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulGetAdventureRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this.id_.Add(other.id_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F114 RID: 61716 RVA: 0x00233AA5 File Offset: 0x00231CA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F115 RID: 61717 RVA: 0x00233AB0 File Offset: 0x00231CB0
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
				if (num != 64U)
				{
					if (num != 80U && num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.id_.AddEntriesFrom(ref input, MulGetAdventureRewardResponse._repeated_id_codec);
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040061BF RID: 25023
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061C0 RID: 25024
		public const int CodeFieldNumber = 8;

		// Token: 0x040061C1 RID: 25025
		private ErrorCode code_;

		// Token: 0x040061C2 RID: 25026
		public const int IdFieldNumber = 10;

		// Token: 0x040061C3 RID: 25027
		private static readonly FieldCodec<int> _repeated_id_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040061C4 RID: 25028
		private readonly RepeatedField<int> id_ = new RepeatedField<int>();
	}
}
