using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A4D RID: 2637
	[NetMessage(EMessageId.MotorFightRoleUpdateNotify)]
	public sealed class MotorFightRoleUpdateNotify : IMessage<MotorFightRoleUpdateNotify>, IMessage, IEquatable<MotorFightRoleUpdateNotify>, IDeepCloneable<MotorFightRoleUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E66B RID: 58987 RVA: 0x0021B104 File Offset: 0x00219304
		[NullableContext(1)]
		public static MotorFightRoleUpdateNotify Create()
		{
			return new MotorFightRoleUpdateNotify();
		}

		// Token: 0x17002EB7 RID: 11959
		// (get) Token: 0x0600E66C RID: 58988 RVA: 0x0021B10B File Offset: 0x0021930B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EB8 RID: 11960
		// (get) Token: 0x0600E66D RID: 58989 RVA: 0x0021B10E File Offset: 0x0021930E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRoleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E66E RID: 58990 RVA: 0x0021B115 File Offset: 0x00219315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoleUpdateNotify()
		{
		}

		// Token: 0x0600E66F RID: 58991 RVA: 0x0021B128 File Offset: 0x00219328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoleUpdateNotify(MotorFightRoleUpdateNotify other) : this()
		{
			this.unlockedRole_ = other.unlockedRole_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E670 RID: 58992 RVA: 0x0021B152 File Offset: 0x00219352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoleUpdateNotify Clone()
		{
			return new MotorFightRoleUpdateNotify(this);
		}

		// Token: 0x17002EB9 RID: 11961
		// (get) Token: 0x0600E671 RID: 58993 RVA: 0x0021B15A File Offset: 0x0021935A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedRole
		{
			get
			{
				return this.unlockedRole_;
			}
		}

		// Token: 0x0600E672 RID: 58994 RVA: 0x0021B162 File Offset: 0x00219362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRoleUpdateNotify);
		}

		// Token: 0x0600E673 RID: 58995 RVA: 0x0021B170 File Offset: 0x00219370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRoleUpdateNotify other)
		{
			return other != null && (other == this || (this.unlockedRole_.Equals(other.unlockedRole_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E674 RID: 58996 RVA: 0x0021B1A4 File Offset: 0x002193A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockedRole_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E675 RID: 58997 RVA: 0x0021B1D8 File Offset: 0x002193D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E676 RID: 58998 RVA: 0x0021B1E5 File Offset: 0x002193E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E677 RID: 58999 RVA: 0x0021B1EE File Offset: 0x002193EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockedRole_.WriteTo(ref output, MotorFightRoleUpdateNotify._repeated_unlockedRole_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E678 RID: 59000 RVA: 0x0021B218 File Offset: 0x00219418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockedRole_.CalculateSize(MotorFightRoleUpdateNotify._repeated_unlockedRole_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E679 RID: 59001 RVA: 0x0021B251 File Offset: 0x00219451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRoleUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockedRole_.Add(other.unlockedRole_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E67A RID: 59002 RVA: 0x0021B27F File Offset: 0x0021947F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E67B RID: 59003 RVA: 0x0021B288 File Offset: 0x00219488
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockedRole_.AddEntriesFrom(ref input, MotorFightRoleUpdateNotify._repeated_unlockedRole_codec);
				}
			}
		}

		// Token: 0x04005E60 RID: 24160
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E61 RID: 24161
		public const int UnlockedRoleFieldNumber = 9;

		// Token: 0x04005E62 RID: 24162
		private static readonly FieldCodec<int> _repeated_unlockedRole_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04005E63 RID: 24163
		private readonly RepeatedField<int> unlockedRole_ = new RepeatedField<int>();
	}
}
