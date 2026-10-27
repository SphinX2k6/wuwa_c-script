using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A49 RID: 2633
	[NetMessage(EMessageId.MotorFightLevelUpdateNotify)]
	public sealed class MotorFightLevelUpdateNotify : IMessage<MotorFightLevelUpdateNotify>, IMessage, IEquatable<MotorFightLevelUpdateNotify>, IDeepCloneable<MotorFightLevelUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E5D3 RID: 58835 RVA: 0x0021978A File Offset: 0x0021798A
		[NullableContext(1)]
		public static MotorFightLevelUpdateNotify Create()
		{
			return new MotorFightLevelUpdateNotify();
		}

		// Token: 0x17002E9A RID: 11930
		// (get) Token: 0x0600E5D4 RID: 58836 RVA: 0x00219791 File Offset: 0x00217991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E9B RID: 11931
		// (get) Token: 0x0600E5D5 RID: 58837 RVA: 0x00219794 File Offset: 0x00217994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightLevelUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E5D6 RID: 58838 RVA: 0x0021979B File Offset: 0x0021799B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLevelUpdateNotify()
		{
		}

		// Token: 0x0600E5D7 RID: 58839 RVA: 0x002197AE File Offset: 0x002179AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLevelUpdateNotify(MotorFightLevelUpdateNotify other) : this()
		{
			this.motorFightLevelPb_ = other.motorFightLevelPb_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E5D8 RID: 58840 RVA: 0x002197D8 File Offset: 0x002179D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLevelUpdateNotify Clone()
		{
			return new MotorFightLevelUpdateNotify(this);
		}

		// Token: 0x17002E9C RID: 11932
		// (get) Token: 0x0600E5D9 RID: 58841 RVA: 0x002197E0 File Offset: 0x002179E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightLevelPb> MotorFightLevelPb
		{
			get
			{
				return this.motorFightLevelPb_;
			}
		}

		// Token: 0x0600E5DA RID: 58842 RVA: 0x002197E8 File Offset: 0x002179E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightLevelUpdateNotify);
		}

		// Token: 0x0600E5DB RID: 58843 RVA: 0x002197F6 File Offset: 0x002179F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightLevelUpdateNotify other)
		{
			return other != null && (other == this || (this.motorFightLevelPb_.Equals(other.motorFightLevelPb_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E5DC RID: 58844 RVA: 0x0021982C File Offset: 0x00217A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.motorFightLevelPb_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E5DD RID: 58845 RVA: 0x00219860 File Offset: 0x00217A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E5DE RID: 58846 RVA: 0x0021986D File Offset: 0x00217A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E5DF RID: 58847 RVA: 0x00219876 File Offset: 0x00217A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.motorFightLevelPb_.WriteTo(ref output, MotorFightLevelUpdateNotify._repeated_motorFightLevelPb_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E5E0 RID: 58848 RVA: 0x002198A0 File Offset: 0x00217AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.motorFightLevelPb_.CalculateSize(MotorFightLevelUpdateNotify._repeated_motorFightLevelPb_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E5E1 RID: 58849 RVA: 0x002198D9 File Offset: 0x00217AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightLevelUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.motorFightLevelPb_.Add(other.motorFightLevelPb_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E5E2 RID: 58850 RVA: 0x00219907 File Offset: 0x00217B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E5E3 RID: 58851 RVA: 0x00219910 File Offset: 0x00217B10
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.motorFightLevelPb_.AddEntriesFrom(ref input, MotorFightLevelUpdateNotify._repeated_motorFightLevelPb_codec);
				}
			}
		}

		// Token: 0x04005DDB RID: 24027
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DDC RID: 24028
		public const int MotorFightLevelPbFieldNumber = 11;

		// Token: 0x04005DDD RID: 24029
		private static readonly FieldCodec<MotorFightLevelPb> _repeated_motorFightLevelPb_codec = FieldCodec.ForMessage<MotorFightLevelPb>(90U, Aki.Protocol.MotorFightLevelPb.Parser);

		// Token: 0x04005DDE RID: 24030
		private readonly RepeatedField<MotorFightLevelPb> motorFightLevelPb_ = new RepeatedField<MotorFightLevelPb>();
	}
}
