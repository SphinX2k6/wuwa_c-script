using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E59 RID: 3673
	public sealed class RacingBetsDiceInfo : IMessage<RacingBetsDiceInfo>, IMessage, IEquatable<RacingBetsDiceInfo>, IDeepCloneable<RacingBetsDiceInfo>, IBufferMessage
	{
		// Token: 0x06013B74 RID: 80756 RVA: 0x002DD874 File Offset: 0x002DBA74
		[NullableContext(1)]
		public static RacingBetsDiceInfo Create()
		{
			return new RacingBetsDiceInfo();
		}

		// Token: 0x1700416D RID: 16749
		// (get) Token: 0x06013B75 RID: 80757 RVA: 0x002DD87B File Offset: 0x002DBA7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700416E RID: 16750
		// (get) Token: 0x06013B76 RID: 80758 RVA: 0x002DD87E File Offset: 0x002DBA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDiceInfo.Descriptor;
			}
		}

		// Token: 0x06013B77 RID: 80759 RVA: 0x002DD885 File Offset: 0x002DBA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDiceInfo()
		{
		}

		// Token: 0x06013B78 RID: 80760 RVA: 0x002DD898 File Offset: 0x002DBA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDiceInfo(RacingBetsDiceInfo other) : this()
		{
			this.diceInfo_ = other.diceInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013B79 RID: 80761 RVA: 0x002DD8C2 File Offset: 0x002DBAC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDiceInfo Clone()
		{
			return new RacingBetsDiceInfo(this);
		}

		// Token: 0x1700416F RID: 16751
		// (get) Token: 0x06013B7A RID: 80762 RVA: 0x002DD8CA File Offset: 0x002DBACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoIdToDiceNum> DiceInfo
		{
			get
			{
				return this.diceInfo_;
			}
		}

		// Token: 0x06013B7B RID: 80763 RVA: 0x002DD8D2 File Offset: 0x002DBAD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDiceInfo);
		}

		// Token: 0x06013B7C RID: 80764 RVA: 0x002DD8E0 File Offset: 0x002DBAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDiceInfo other)
		{
			return other != null && (other == this || (this.diceInfo_.Equals(other.diceInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013B7D RID: 80765 RVA: 0x002DD914 File Offset: 0x002DBB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.diceInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013B7E RID: 80766 RVA: 0x002DD948 File Offset: 0x002DBB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013B7F RID: 80767 RVA: 0x002DD955 File Offset: 0x002DBB55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013B80 RID: 80768 RVA: 0x002DD95E File Offset: 0x002DBB5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.diceInfo_.WriteTo(ref output, RacingBetsDiceInfo._repeated_diceInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013B81 RID: 80769 RVA: 0x002DD988 File Offset: 0x002DBB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.diceInfo_.CalculateSize(RacingBetsDiceInfo._repeated_diceInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013B82 RID: 80770 RVA: 0x002DD9C1 File Offset: 0x002DBBC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsDiceInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.diceInfo_.Add(other.diceInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013B83 RID: 80771 RVA: 0x002DD9EF File Offset: 0x002DBBEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013B84 RID: 80772 RVA: 0x002DD9F8 File Offset: 0x002DBBF8
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.diceInfo_.AddEntriesFrom(ref input, RacingBetsDiceInfo._repeated_diceInfo_codec);
				}
			}
		}

		// Token: 0x04007890 RID: 30864
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007891 RID: 30865
		public const int DiceInfoFieldNumber = 1;

		// Token: 0x04007892 RID: 30866
		private static readonly FieldCodec<DangoIdToDiceNum> _repeated_diceInfo_codec = FieldCodec.ForMessage<DangoIdToDiceNum>(10U, DangoIdToDiceNum.Parser);

		// Token: 0x04007893 RID: 30867
		private readonly RepeatedField<DangoIdToDiceNum> diceInfo_ = new RepeatedField<DangoIdToDiceNum>();
	}
}
