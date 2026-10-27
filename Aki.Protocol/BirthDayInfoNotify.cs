using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200019A RID: 410
	[NetMessage(EMessageId.BirthDayInfoNotify)]
	public sealed class BirthDayInfoNotify : IMessage<BirthDayInfoNotify>, IMessage, IEquatable<BirthDayInfoNotify>, IDeepCloneable<BirthDayInfoNotify>, IBufferMessage
	{
		// Token: 0x06003087 RID: 12423 RVA: 0x0007BCC5 File Offset: 0x00079EC5
		[NullableContext(1)]
		public static BirthDayInfoNotify Create()
		{
			return new BirthDayInfoNotify();
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06003088 RID: 12424 RVA: 0x0007BCCC File Offset: 0x00079ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06003089 RID: 12425 RVA: 0x0007BCCF File Offset: 0x00079ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthDayInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600308A RID: 12426 RVA: 0x0007BCD6 File Offset: 0x00079ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayInfoNotify()
		{
		}

		// Token: 0x0600308B RID: 12427 RVA: 0x0007BCEC File Offset: 0x00079EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayInfoNotify(BirthDayInfoNotify other) : this()
		{
			this.birthDayReset_ = other.birthDayReset_;
			this.recentRewardTime_ = other.recentRewardTime_;
			this.roles_ = other.roles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x0007BD39 File Offset: 0x00079F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayInfoNotify Clone()
		{
			return new BirthDayInfoNotify(this);
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600308D RID: 12429 RVA: 0x0007BD41 File Offset: 0x00079F41
		// (set) Token: 0x0600308E RID: 12430 RVA: 0x0007BD49 File Offset: 0x00079F49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BirthDayReset
		{
			get
			{
				return this.birthDayReset_;
			}
			set
			{
				this.birthDayReset_ = value;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x0600308F RID: 12431 RVA: 0x0007BD52 File Offset: 0x00079F52
		// (set) Token: 0x06003090 RID: 12432 RVA: 0x0007BD5A File Offset: 0x00079F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecentRewardTime
		{
			get
			{
				return this.recentRewardTime_;
			}
			set
			{
				this.recentRewardTime_ = value;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06003091 RID: 12433 RVA: 0x0007BD63 File Offset: 0x00079F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BirthRoleSelect> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x0007BD6B File Offset: 0x00079F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthDayInfoNotify);
		}

		// Token: 0x06003093 RID: 12435 RVA: 0x0007BD7C File Offset: 0x00079F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthDayInfoNotify other)
		{
			return other != null && (other == this || (this.BirthDayReset == other.BirthDayReset && this.RecentRewardTime == other.RecentRewardTime && this.roles_.Equals(other.roles_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003094 RID: 12436 RVA: 0x0007BDDC File Offset: 0x00079FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BirthDayReset)
			{
				num ^= this.BirthDayReset.GetHashCode();
			}
			if (this.RecentRewardTime != 0)
			{
				num ^= this.RecentRewardTime.GetHashCode();
			}
			num ^= this.roles_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003095 RID: 12437 RVA: 0x0007BE42 File Offset: 0x0007A042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x0007BE4F File Offset: 0x0007A04F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x0007BE58 File Offset: 0x0007A058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecentRewardTime != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RecentRewardTime);
			}
			if (this.BirthDayReset)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.BirthDayReset);
			}
			this.roles_.WriteTo(ref output, BirthDayInfoNotify._repeated_roles_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x0007BEC4 File Offset: 0x0007A0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BirthDayReset)
			{
				num += 2;
			}
			if (this.RecentRewardTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecentRewardTime);
			}
			num += this.roles_.CalculateSize(BirthDayInfoNotify._repeated_roles_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x0007BF24 File Offset: 0x0007A124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BirthDayInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BirthDayReset)
			{
				this.BirthDayReset = other.BirthDayReset;
			}
			if (other.RecentRewardTime != 0)
			{
				this.RecentRewardTime = other.RecentRewardTime;
			}
			this.roles_.Add(other.roles_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x0007BF85 File Offset: 0x0007A185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600309B RID: 12443 RVA: 0x0007BF90 File Offset: 0x0007A190
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
				if (num != 24U)
				{
					if (num != 96U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.roles_.AddEntriesFrom(ref input, BirthDayInfoNotify._repeated_roles_codec);
						}
					}
					else
					{
						this.BirthDayReset = input.ReadBool();
					}
				}
				else
				{
					this.RecentRewardTime = input.ReadInt32();
				}
			}
		}

		// Token: 0x040028F8 RID: 10488
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028F9 RID: 10489
		public const int BirthDayResetFieldNumber = 12;

		// Token: 0x040028FA RID: 10490
		private bool birthDayReset_;

		// Token: 0x040028FB RID: 10491
		public const int RecentRewardTimeFieldNumber = 3;

		// Token: 0x040028FC RID: 10492
		private int recentRewardTime_;

		// Token: 0x040028FD RID: 10493
		public const int RolesFieldNumber = 15;

		// Token: 0x040028FE RID: 10494
		private static readonly FieldCodec<BirthRoleSelect> _repeated_roles_codec = FieldCodec.ForMessage<BirthRoleSelect>(122U, BirthRoleSelect.Parser);

		// Token: 0x040028FF RID: 10495
		private readonly RepeatedField<BirthRoleSelect> roles_ = new RepeatedField<BirthRoleSelect>();
	}
}
