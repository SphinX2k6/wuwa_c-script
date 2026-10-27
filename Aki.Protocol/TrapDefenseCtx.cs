using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200141D RID: 5149
	public sealed class TrapDefenseCtx : IMessage<TrapDefenseCtx>, IMessage, IEquatable<TrapDefenseCtx>, IDeepCloneable<TrapDefenseCtx>, IBufferMessage
	{
		// Token: 0x0601B4B0 RID: 111792 RVA: 0x003F4869 File Offset: 0x003F2A69
		[NullableContext(1)]
		public static TrapDefenseCtx Create()
		{
			return new TrapDefenseCtx();
		}

		// Token: 0x17005C12 RID: 23570
		// (get) Token: 0x0601B4B1 RID: 111793 RVA: 0x003F4870 File Offset: 0x003F2A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C13 RID: 23571
		// (get) Token: 0x0601B4B2 RID: 111794 RVA: 0x003F4873 File Offset: 0x003F2A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseCtx.Descriptor;
			}
		}

		// Token: 0x0601B4B3 RID: 111795 RVA: 0x003F487A File Offset: 0x003F2A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCtx()
		{
		}

		// Token: 0x0601B4B4 RID: 111796 RVA: 0x003F4882 File Offset: 0x003F2A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCtx(TrapDefenseCtx other) : this()
		{
			this.configId_ = other.configId_;
			this.newChallenge_ = other.newChallenge_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B4B5 RID: 111797 RVA: 0x003F48B3 File Offset: 0x003F2AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCtx Clone()
		{
			return new TrapDefenseCtx(this);
		}

		// Token: 0x17005C14 RID: 23572
		// (get) Token: 0x0601B4B6 RID: 111798 RVA: 0x003F48BB File Offset: 0x003F2ABB
		// (set) Token: 0x0601B4B7 RID: 111799 RVA: 0x003F48C3 File Offset: 0x003F2AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17005C15 RID: 23573
		// (get) Token: 0x0601B4B8 RID: 111800 RVA: 0x003F48CC File Offset: 0x003F2ACC
		// (set) Token: 0x0601B4B9 RID: 111801 RVA: 0x003F48D4 File Offset: 0x003F2AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NewChallenge
		{
			get
			{
				return this.newChallenge_;
			}
			set
			{
				this.newChallenge_ = value;
			}
		}

		// Token: 0x0601B4BA RID: 111802 RVA: 0x003F48DD File Offset: 0x003F2ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseCtx);
		}

		// Token: 0x0601B4BB RID: 111803 RVA: 0x003F48EB File Offset: 0x003F2AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseCtx other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.NewChallenge == other.NewChallenge && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B4BC RID: 111804 RVA: 0x003F492C File Offset: 0x003F2B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.NewChallenge)
			{
				num ^= this.NewChallenge.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B4BD RID: 111805 RVA: 0x003F4984 File Offset: 0x003F2B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B4BE RID: 111806 RVA: 0x003F4991 File Offset: 0x003F2B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B4BF RID: 111807 RVA: 0x003F499C File Offset: 0x003F2B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.NewChallenge)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.NewChallenge);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B4C0 RID: 111808 RVA: 0x003F49F4 File Offset: 0x003F2BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.NewChallenge)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B4C1 RID: 111809 RVA: 0x003F4A40 File Offset: 0x003F2C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.NewChallenge)
			{
				this.NewChallenge = other.NewChallenge;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B4C2 RID: 111810 RVA: 0x003F4A90 File Offset: 0x003F2C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B4C3 RID: 111811 RVA: 0x003F4A9C File Offset: 0x003F2C9C
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
						this.NewChallenge = input.ReadBool();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009DC7 RID: 40391
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DC8 RID: 40392
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04009DC9 RID: 40393
		private int configId_;

		// Token: 0x04009DCA RID: 40394
		public const int NewChallengeFieldNumber = 2;

		// Token: 0x04009DCB RID: 40395
		private bool newChallenge_;
	}
}
