using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A31 RID: 2609
	[NetMessage(EMessageId.MotorFightItemUpdateNotify)]
	public sealed class MotorFightItemUpdateNotify : IMessage<MotorFightItemUpdateNotify>, IMessage, IEquatable<MotorFightItemUpdateNotify>, IDeepCloneable<MotorFightItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E425 RID: 58405 RVA: 0x0021613B File Offset: 0x0021433B
		[NullableContext(1)]
		public static MotorFightItemUpdateNotify Create()
		{
			return new MotorFightItemUpdateNotify();
		}

		// Token: 0x17002E3C RID: 11836
		// (get) Token: 0x0600E426 RID: 58406 RVA: 0x00216142 File Offset: 0x00214342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E3D RID: 11837
		// (get) Token: 0x0600E427 RID: 58407 RVA: 0x00216145 File Offset: 0x00214345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E428 RID: 58408 RVA: 0x0021614C File Offset: 0x0021434C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightItemUpdateNotify()
		{
		}

		// Token: 0x0600E429 RID: 58409 RVA: 0x0021615F File Offset: 0x0021435F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightItemUpdateNotify(MotorFightItemUpdateNotify other) : this()
		{
			this.unlockedItem_ = other.unlockedItem_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E42A RID: 58410 RVA: 0x00216189 File Offset: 0x00214389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightItemUpdateNotify Clone()
		{
			return new MotorFightItemUpdateNotify(this);
		}

		// Token: 0x17002E3E RID: 11838
		// (get) Token: 0x0600E42B RID: 58411 RVA: 0x00216191 File Offset: 0x00214391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedItem
		{
			get
			{
				return this.unlockedItem_;
			}
		}

		// Token: 0x0600E42C RID: 58412 RVA: 0x00216199 File Offset: 0x00214399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightItemUpdateNotify);
		}

		// Token: 0x0600E42D RID: 58413 RVA: 0x002161A7 File Offset: 0x002143A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightItemUpdateNotify other)
		{
			return other != null && (other == this || (this.unlockedItem_.Equals(other.unlockedItem_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E42E RID: 58414 RVA: 0x002161DC File Offset: 0x002143DC
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

		// Token: 0x0600E42F RID: 58415 RVA: 0x00216210 File Offset: 0x00214410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E430 RID: 58416 RVA: 0x0021621D File Offset: 0x0021441D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E431 RID: 58417 RVA: 0x00216226 File Offset: 0x00214426
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

		// Token: 0x0600E432 RID: 58418 RVA: 0x00216250 File Offset: 0x00214450
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

		// Token: 0x0600E433 RID: 58419 RVA: 0x00216289 File Offset: 0x00214489
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

		// Token: 0x0600E434 RID: 58420 RVA: 0x002162B7 File Offset: 0x002144B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E435 RID: 58421 RVA: 0x002162C0 File Offset: 0x002144C0
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockedItem_.AddEntriesFrom(ref input, MotorFightItemUpdateNotify._repeated_unlockedItem_codec);
				}
			}
		}

		// Token: 0x04005DB9 RID: 23993
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DBA RID: 23994
		public const int UnlockedItemFieldNumber = 4;

		// Token: 0x04005DBB RID: 23995
		private static readonly FieldCodec<int> _repeated_unlockedItem_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04005DBC RID: 23996
		private readonly RepeatedField<int> unlockedItem_ = new RepeatedField<int>();
	}
}
