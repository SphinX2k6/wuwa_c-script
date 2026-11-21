using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F48 RID: 3912
	[NetMessage(EMessageId.RiskHarvestBuffUnlockNotify)]
	public sealed class RiskHarvestBuffUnlockNotify : IMessage<RiskHarvestBuffUnlockNotify>, IMessage, IEquatable<RiskHarvestBuffUnlockNotify>, IDeepCloneable<RiskHarvestBuffUnlockNotify>, IBufferMessage
	{
		// Token: 0x06014F41 RID: 85825 RVA: 0x0030AC15 File Offset: 0x00308E15
		[NullableContext(1)]
		public static RiskHarvestBuffUnlockNotify Create()
		{
			return new RiskHarvestBuffUnlockNotify();
		}

		// Token: 0x170045B7 RID: 17847
		// (get) Token: 0x06014F42 RID: 85826 RVA: 0x0030AC1C File Offset: 0x00308E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045B8 RID: 17848
		// (get) Token: 0x06014F43 RID: 85827 RVA: 0x0030AC1F File Offset: 0x00308E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestBuffUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06014F44 RID: 85828 RVA: 0x0030AC26 File Offset: 0x00308E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockNotify()
		{
		}

		// Token: 0x06014F45 RID: 85829 RVA: 0x0030AC39 File Offset: 0x00308E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockNotify(RiskHarvestBuffUnlockNotify other) : this()
		{
			this.unlockBuffGroup_ = other.unlockBuffGroup_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014F46 RID: 85830 RVA: 0x0030AC63 File Offset: 0x00308E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockNotify Clone()
		{
			return new RiskHarvestBuffUnlockNotify(this);
		}

		// Token: 0x170045B9 RID: 17849
		// (get) Token: 0x06014F47 RID: 85831 RVA: 0x0030AC6B File Offset: 0x00308E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBuffGroup
		{
			get
			{
				return this.unlockBuffGroup_;
			}
		}

		// Token: 0x06014F48 RID: 85832 RVA: 0x0030AC73 File Offset: 0x00308E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestBuffUnlockNotify);
		}

		// Token: 0x06014F49 RID: 85833 RVA: 0x0030AC81 File Offset: 0x00308E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestBuffUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockBuffGroup_.Equals(other.unlockBuffGroup_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014F4A RID: 85834 RVA: 0x0030ACB4 File Offset: 0x00308EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockBuffGroup_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014F4B RID: 85835 RVA: 0x0030ACE8 File Offset: 0x00308EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014F4C RID: 85836 RVA: 0x0030ACF5 File Offset: 0x00308EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014F4D RID: 85837 RVA: 0x0030ACFE File Offset: 0x00308EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockBuffGroup_.WriteTo(ref output, RiskHarvestBuffUnlockNotify._repeated_unlockBuffGroup_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014F4E RID: 85838 RVA: 0x0030AD28 File Offset: 0x00308F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockBuffGroup_.CalculateSize(RiskHarvestBuffUnlockNotify._repeated_unlockBuffGroup_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014F4F RID: 85839 RVA: 0x0030AD61 File Offset: 0x00308F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestBuffUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockBuffGroup_.Add(other.unlockBuffGroup_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014F50 RID: 85840 RVA: 0x0030AD8F File Offset: 0x00308F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014F51 RID: 85841 RVA: 0x0030AD98 File Offset: 0x00308F98
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockBuffGroup_.AddEntriesFrom(ref input, RiskHarvestBuffUnlockNotify._repeated_unlockBuffGroup_codec);
				}
			}
		}

		// Token: 0x04007EC3 RID: 32451
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EC4 RID: 32452
		public const int UnlockBuffGroupFieldNumber = 8;

		// Token: 0x04007EC5 RID: 32453
		private static readonly FieldCodec<int> _repeated_unlockBuffGroup_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04007EC6 RID: 32454
		private readonly RepeatedField<int> unlockBuffGroup_ = new RepeatedField<int>();
	}
}
