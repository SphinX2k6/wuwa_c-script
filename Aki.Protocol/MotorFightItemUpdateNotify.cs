using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A42 RID: 2626
	[NetMessage(EMessageId.MotorFightItemUpdateNotify)]
	public sealed class MotorFightItemUpdateNotify : IMessage<MotorFightItemUpdateNotify>, IMessage, IEquatable<MotorFightItemUpdateNotify>, IDeepCloneable<MotorFightItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E53F RID: 58687 RVA: 0x0021832B File Offset: 0x0021652B
		[NullableContext(1)]
		public static MotorFightItemUpdateNotify Create()
		{
			return new MotorFightItemUpdateNotify();
		}

		// Token: 0x17002E7A RID: 11898
		// (get) Token: 0x0600E540 RID: 58688 RVA: 0x00218332 File Offset: 0x00216532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E7B RID: 11899
		// (get) Token: 0x0600E541 RID: 58689 RVA: 0x00218335 File Offset: 0x00216535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E542 RID: 58690 RVA: 0x0021833C File Offset: 0x0021653C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightItemUpdateNotify()
		{
		}

		// Token: 0x0600E543 RID: 58691 RVA: 0x0021834F File Offset: 0x0021654F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightItemUpdateNotify(MotorFightItemUpdateNotify other) : this()
		{
			this.unlockedItem_ = other.unlockedItem_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E544 RID: 58692 RVA: 0x00218379 File Offset: 0x00216579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightItemUpdateNotify Clone()
		{
			return new MotorFightItemUpdateNotify(this);
		}

		// Token: 0x17002E7C RID: 11900
		// (get) Token: 0x0600E545 RID: 58693 RVA: 0x00218381 File Offset: 0x00216581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedItem
		{
			get
			{
				return this.unlockedItem_;
			}
		}

		// Token: 0x0600E546 RID: 58694 RVA: 0x00218389 File Offset: 0x00216589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightItemUpdateNotify);
		}

		// Token: 0x0600E547 RID: 58695 RVA: 0x00218397 File Offset: 0x00216597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightItemUpdateNotify other)
		{
			return other != null && (other == this || (this.unlockedItem_.Equals(other.unlockedItem_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E548 RID: 58696 RVA: 0x002183CC File Offset: 0x002165CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockedItem_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E549 RID: 58697 RVA: 0x00218400 File Offset: 0x00216600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E54A RID: 58698 RVA: 0x0021840D File Offset: 0x0021660D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E54B RID: 58699 RVA: 0x00218416 File Offset: 0x00216616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockedItem_.WriteTo(ref output, MotorFightItemUpdateNotify._repeated_unlockedItem_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E54C RID: 58700 RVA: 0x00218440 File Offset: 0x00216640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockedItem_.CalculateSize(MotorFightItemUpdateNotify._repeated_unlockedItem_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E54D RID: 58701 RVA: 0x00218479 File Offset: 0x00216679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightItemUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockedItem_.Add(other.unlockedItem_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E54E RID: 58702 RVA: 0x002184A7 File Offset: 0x002166A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E54F RID: 58703 RVA: 0x002184B0 File Offset: 0x002166B0
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
					this.unlockedItem_.AddEntriesFrom(ref input, MotorFightItemUpdateNotify._repeated_unlockedItem_codec);
				}
			}
		}

		// Token: 0x04005DB0 RID: 23984
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DB1 RID: 23985
		public const int UnlockedItemFieldNumber = 8;

		// Token: 0x04005DB2 RID: 23986
		private static readonly FieldCodec<int> _repeated_unlockedItem_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04005DB3 RID: 23987
		private readonly RepeatedField<int> unlockedItem_ = new RepeatedField<int>();
	}
}
