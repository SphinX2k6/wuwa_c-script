using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014ED RID: 5357
	public sealed class WeaponIllustratedInfo : IMessage<WeaponIllustratedInfo>, IMessage, IEquatable<WeaponIllustratedInfo>, IDeepCloneable<WeaponIllustratedInfo>, IBufferMessage
	{
		// Token: 0x0601C527 RID: 116007 RVA: 0x0041796E File Offset: 0x00415B6E
		[NullableContext(1)]
		public static WeaponIllustratedInfo Create()
		{
			return new WeaponIllustratedInfo();
		}

		// Token: 0x17005F7A RID: 24442
		// (get) Token: 0x0601C528 RID: 116008 RVA: 0x00417975 File Offset: 0x00415B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WeaponIllustratedInfo> Parser
		{
			get
			{
				return WeaponIllustratedInfo._parser;
			}
		}

		// Token: 0x17005F7B RID: 24443
		// (get) Token: 0x0601C529 RID: 116009 RVA: 0x0041797C File Offset: 0x00415B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F7C RID: 24444
		// (get) Token: 0x0601C52A RID: 116010 RVA: 0x0041797F File Offset: 0x00415B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponIllustratedInfo.Descriptor;
			}
		}

		// Token: 0x0601C52B RID: 116011 RVA: 0x00417986 File Offset: 0x00415B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponIllustratedInfo()
		{
		}

		// Token: 0x0601C52C RID: 116012 RVA: 0x0041798E File Offset: 0x00415B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponIllustratedInfo(WeaponIllustratedInfo other) : this()
		{
			this.weaponId_ = other.weaponId_;
			this.unlockTime_ = other.unlockTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C52D RID: 116013 RVA: 0x004179BF File Offset: 0x00415BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponIllustratedInfo Clone()
		{
			return new WeaponIllustratedInfo(this);
		}

		// Token: 0x17005F7D RID: 24445
		// (get) Token: 0x0601C52E RID: 116014 RVA: 0x004179C7 File Offset: 0x00415BC7
		// (set) Token: 0x0601C52F RID: 116015 RVA: 0x004179CF File Offset: 0x00415BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponId
		{
			get
			{
				return this.weaponId_;
			}
			set
			{
				this.weaponId_ = value;
			}
		}

		// Token: 0x17005F7E RID: 24446
		// (get) Token: 0x0601C530 RID: 116016 RVA: 0x004179D8 File Offset: 0x00415BD8
		// (set) Token: 0x0601C531 RID: 116017 RVA: 0x004179E0 File Offset: 0x00415BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x0601C532 RID: 116018 RVA: 0x004179E9 File Offset: 0x00415BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponIllustratedInfo);
		}

		// Token: 0x0601C533 RID: 116019 RVA: 0x004179F7 File Offset: 0x00415BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponIllustratedInfo other)
		{
			return other != null && (other == this || (this.WeaponId == other.WeaponId && this.UnlockTime == other.UnlockTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C534 RID: 116020 RVA: 0x00417A38 File Offset: 0x00415C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeaponId != 0)
			{
				num ^= this.WeaponId.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C535 RID: 116021 RVA: 0x00417A90 File Offset: 0x00415C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C536 RID: 116022 RVA: 0x00417A9D File Offset: 0x00415C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C537 RID: 116023 RVA: 0x00417AA8 File Offset: 0x00415CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WeaponId);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnlockTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C538 RID: 116024 RVA: 0x00417B00 File Offset: 0x00415D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeaponId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponId);
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C539 RID: 116025 RVA: 0x00417B58 File Offset: 0x00415D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponIllustratedInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeaponId != 0)
			{
				this.WeaponId = other.WeaponId;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C53A RID: 116026 RVA: 0x00417BA8 File Offset: 0x00415DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C53B RID: 116027 RVA: 0x00417BB4 File Offset: 0x00415DB4
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.UnlockTime = input.ReadInt64();
					}
				}
				else
				{
					this.WeaponId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A244 RID: 41540
		private static readonly MessageParser<WeaponIllustratedInfo> _parser = new MessageParser<WeaponIllustratedInfo>(() => new WeaponIllustratedInfo());

		// Token: 0x0400A245 RID: 41541
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A246 RID: 41542
		public const int WeaponIdFieldNumber = 1;

		// Token: 0x0400A247 RID: 41543
		private int weaponId_;

		// Token: 0x0400A248 RID: 41544
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x0400A249 RID: 41545
		private long unlockTime_;
	}
}
