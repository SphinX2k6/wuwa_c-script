using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C9D RID: 3229
	[NetMessage(EMessageId.PhantomBattlePhantomCardSkillRequest)]
	public sealed class PhantomBattlePhantomCardSkillRequest : IMessage<PhantomBattlePhantomCardSkillRequest>, IMessage, IEquatable<PhantomBattlePhantomCardSkillRequest>, IDeepCloneable<PhantomBattlePhantomCardSkillRequest>, IBufferMessage
	{
		// Token: 0x060117F7 RID: 71671 RVA: 0x002903C0 File Offset: 0x0028E5C0
		[NullableContext(1)]
		public static PhantomBattlePhantomCardSkillRequest Create()
		{
			return new PhantomBattlePhantomCardSkillRequest();
		}

		// Token: 0x170039F5 RID: 14837
		// (get) Token: 0x060117F8 RID: 71672 RVA: 0x002903C7 File Offset: 0x0028E5C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039F6 RID: 14838
		// (get) Token: 0x060117F9 RID: 71673 RVA: 0x002903CA File Offset: 0x0028E5CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattlePhantomCardSkillRequest.Descriptor;
			}
		}

		// Token: 0x060117FA RID: 71674 RVA: 0x002903D1 File Offset: 0x0028E5D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattlePhantomCardSkillRequest()
		{
		}

		// Token: 0x060117FB RID: 71675 RVA: 0x002903D9 File Offset: 0x0028E5D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattlePhantomCardSkillRequest(PhantomBattlePhantomCardSkillRequest other) : this()
		{
			this.cardUid_ = other.cardUid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060117FC RID: 71676 RVA: 0x002903FE File Offset: 0x0028E5FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattlePhantomCardSkillRequest Clone()
		{
			return new PhantomBattlePhantomCardSkillRequest(this);
		}

		// Token: 0x170039F7 RID: 14839
		// (get) Token: 0x060117FD RID: 71677 RVA: 0x00290406 File Offset: 0x0028E606
		// (set) Token: 0x060117FE RID: 71678 RVA: 0x0029040E File Offset: 0x0028E60E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUid
		{
			get
			{
				return this.cardUid_;
			}
			set
			{
				this.cardUid_ = value;
			}
		}

		// Token: 0x060117FF RID: 71679 RVA: 0x00290417 File Offset: 0x0028E617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattlePhantomCardSkillRequest);
		}

		// Token: 0x06011800 RID: 71680 RVA: 0x00290425 File Offset: 0x0028E625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattlePhantomCardSkillRequest other)
		{
			return other != null && (other == this || (this.CardUid == other.CardUid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011801 RID: 71681 RVA: 0x00290454 File Offset: 0x0028E654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardUid != 0)
			{
				num ^= this.CardUid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011802 RID: 71682 RVA: 0x00290493 File Offset: 0x0028E693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011803 RID: 71683 RVA: 0x002904A0 File Offset: 0x0028E6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011804 RID: 71684 RVA: 0x002904A9 File Offset: 0x0028E6A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUid != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CardUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011805 RID: 71685 RVA: 0x002904DC File Offset: 0x0028E6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011806 RID: 71686 RVA: 0x0029051A File Offset: 0x0028E71A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattlePhantomCardSkillRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardUid != 0)
			{
				this.CardUid = other.CardUid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011807 RID: 71687 RVA: 0x0029054B File Offset: 0x0028E74B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011808 RID: 71688 RVA: 0x00290554 File Offset: 0x0028E754
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CardUid = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006E5C RID: 28252
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E5D RID: 28253
		public const int CardUidFieldNumber = 5;

		// Token: 0x04006E5E RID: 28254
		private int cardUid_;
	}
}
