using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B48 RID: 2888
	[NetMessage(EMessageId.NewTowerRoundUpdateNotify)]
	public sealed class NewTowerRoundUpdateNotify : IMessage<NewTowerRoundUpdateNotify>, IMessage, IEquatable<NewTowerRoundUpdateNotify>, IDeepCloneable<NewTowerRoundUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600FA8B RID: 64139 RVA: 0x00248804 File Offset: 0x00246A04
		[NullableContext(1)]
		public static NewTowerRoundUpdateNotify Create()
		{
			return new NewTowerRoundUpdateNotify();
		}

		// Token: 0x17003318 RID: 13080
		// (get) Token: 0x0600FA8C RID: 64140 RVA: 0x0024880B File Offset: 0x00246A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003319 RID: 13081
		// (get) Token: 0x0600FA8D RID: 64141 RVA: 0x0024880E File Offset: 0x00246A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRoundUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600FA8E RID: 64142 RVA: 0x00248815 File Offset: 0x00246A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoundUpdateNotify()
		{
		}

		// Token: 0x0600FA8F RID: 64143 RVA: 0x0024881D File Offset: 0x00246A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoundUpdateNotify(NewTowerRoundUpdateNotify other) : this()
		{
			this.round_ = other.round_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FA90 RID: 64144 RVA: 0x00248842 File Offset: 0x00246A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoundUpdateNotify Clone()
		{
			return new NewTowerRoundUpdateNotify(this);
		}

		// Token: 0x1700331A RID: 13082
		// (get) Token: 0x0600FA91 RID: 64145 RVA: 0x0024884A File Offset: 0x00246A4A
		// (set) Token: 0x0600FA92 RID: 64146 RVA: 0x00248852 File Offset: 0x00246A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Round
		{
			get
			{
				return this.round_;
			}
			set
			{
				this.round_ = value;
			}
		}

		// Token: 0x0600FA93 RID: 64147 RVA: 0x0024885B File Offset: 0x00246A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRoundUpdateNotify);
		}

		// Token: 0x0600FA94 RID: 64148 RVA: 0x00248869 File Offset: 0x00246A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRoundUpdateNotify other)
		{
			return other != null && (other == this || (this.Round == other.Round && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FA95 RID: 64149 RVA: 0x00248898 File Offset: 0x00246A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Round != 0)
			{
				num ^= this.Round.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FA96 RID: 64150 RVA: 0x002488D7 File Offset: 0x00246AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FA97 RID: 64151 RVA: 0x002488E4 File Offset: 0x00246AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FA98 RID: 64152 RVA: 0x002488ED File Offset: 0x00246AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Round != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Round);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FA99 RID: 64153 RVA: 0x00248920 File Offset: 0x00246B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Round != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Round);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FA9A RID: 64154 RVA: 0x0024895E File Offset: 0x00246B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerRoundUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Round != 0)
			{
				this.Round = other.Round;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FA9B RID: 64155 RVA: 0x0024898F File Offset: 0x00246B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FA9C RID: 64156 RVA: 0x00248998 File Offset: 0x00246B98
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Round = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400644C RID: 25676
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400644D RID: 25677
		public const int RoundFieldNumber = 3;

		// Token: 0x0400644E RID: 25678
		private int round_;
	}
}
