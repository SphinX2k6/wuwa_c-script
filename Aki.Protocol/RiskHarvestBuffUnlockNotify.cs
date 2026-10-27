using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F58 RID: 3928
	[NetMessage(EMessageId.RiskHarvestBuffUnlockNotify)]
	public sealed class RiskHarvestBuffUnlockNotify : IMessage<RiskHarvestBuffUnlockNotify>, IMessage, IEquatable<RiskHarvestBuffUnlockNotify>, IDeepCloneable<RiskHarvestBuffUnlockNotify>, IBufferMessage
	{
		// Token: 0x06015026 RID: 86054 RVA: 0x0030C2CC File Offset: 0x0030A4CC
		[NullableContext(1)]
		public static RiskHarvestBuffUnlockNotify Create()
		{
			return new RiskHarvestBuffUnlockNotify();
		}

		// Token: 0x170045E1 RID: 17889
		// (get) Token: 0x06015027 RID: 86055 RVA: 0x0030C2D3 File Offset: 0x0030A4D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045E2 RID: 17890
		// (get) Token: 0x06015028 RID: 86056 RVA: 0x0030C2D6 File Offset: 0x0030A4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestBuffUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06015029 RID: 86057 RVA: 0x0030C2DD File Offset: 0x0030A4DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockNotify()
		{
		}

		// Token: 0x0601502A RID: 86058 RVA: 0x0030C2F0 File Offset: 0x0030A4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockNotify(RiskHarvestBuffUnlockNotify other) : this()
		{
			this.unlockBuffGroup_ = other.unlockBuffGroup_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601502B RID: 86059 RVA: 0x0030C31A File Offset: 0x0030A51A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockNotify Clone()
		{
			return new RiskHarvestBuffUnlockNotify(this);
		}

		// Token: 0x170045E3 RID: 17891
		// (get) Token: 0x0601502C RID: 86060 RVA: 0x0030C322 File Offset: 0x0030A522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBuffGroup
		{
			get
			{
				return this.unlockBuffGroup_;
			}
		}

		// Token: 0x0601502D RID: 86061 RVA: 0x0030C32A File Offset: 0x0030A52A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestBuffUnlockNotify);
		}

		// Token: 0x0601502E RID: 86062 RVA: 0x0030C338 File Offset: 0x0030A538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestBuffUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockBuffGroup_.Equals(other.unlockBuffGroup_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601502F RID: 86063 RVA: 0x0030C36C File Offset: 0x0030A56C
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

		// Token: 0x06015030 RID: 86064 RVA: 0x0030C3A0 File Offset: 0x0030A5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015031 RID: 86065 RVA: 0x0030C3AD File Offset: 0x0030A5AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015032 RID: 86066 RVA: 0x0030C3B6 File Offset: 0x0030A5B6
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

		// Token: 0x06015033 RID: 86067 RVA: 0x0030C3E0 File Offset: 0x0030A5E0
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

		// Token: 0x06015034 RID: 86068 RVA: 0x0030C419 File Offset: 0x0030A619
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

		// Token: 0x06015035 RID: 86069 RVA: 0x0030C447 File Offset: 0x0030A647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015036 RID: 86070 RVA: 0x0030C450 File Offset: 0x0030A650
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockBuffGroup_.AddEntriesFrom(ref input, RiskHarvestBuffUnlockNotify._repeated_unlockBuffGroup_codec);
				}
			}
		}

		// Token: 0x04007E99 RID: 32409
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E9A RID: 32410
		public const int UnlockBuffGroupFieldNumber = 12;

		// Token: 0x04007E9B RID: 32411
		private static readonly FieldCodec<int> _repeated_unlockBuffGroup_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04007E9C RID: 32412
		private readonly RepeatedField<int> unlockBuffGroup_ = new RepeatedField<int>();
	}
}
