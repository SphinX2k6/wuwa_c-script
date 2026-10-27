using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A4C RID: 2636
	[NetMessage(EMessageId.MotorFightOneKeyRewardRequest)]
	public sealed class MotorFightOneKeyRewardRequest : IMessage<MotorFightOneKeyRewardRequest>, IMessage, IEquatable<MotorFightOneKeyRewardRequest>, IDeepCloneable<MotorFightOneKeyRewardRequest>, IBufferMessage
	{
		// Token: 0x0600E613 RID: 58899 RVA: 0x0021A01F File Offset: 0x0021821F
		[NullableContext(1)]
		public static MotorFightOneKeyRewardRequest Create()
		{
			return new MotorFightOneKeyRewardRequest();
		}

		// Token: 0x17002EA8 RID: 11944
		// (get) Token: 0x0600E614 RID: 58900 RVA: 0x0021A026 File Offset: 0x00218226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EA9 RID: 11945
		// (get) Token: 0x0600E615 RID: 58901 RVA: 0x0021A029 File Offset: 0x00218229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightOneKeyRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600E616 RID: 58902 RVA: 0x0021A030 File Offset: 0x00218230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightOneKeyRewardRequest()
		{
		}

		// Token: 0x0600E617 RID: 58903 RVA: 0x0021A043 File Offset: 0x00218243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightOneKeyRewardRequest(MotorFightOneKeyRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E618 RID: 58904 RVA: 0x0021A06D File Offset: 0x0021826D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightOneKeyRewardRequest Clone()
		{
			return new MotorFightOneKeyRewardRequest(this);
		}

		// Token: 0x17002EAA RID: 11946
		// (get) Token: 0x0600E619 RID: 58905 RVA: 0x0021A075 File Offset: 0x00218275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600E61A RID: 58906 RVA: 0x0021A07D File Offset: 0x0021827D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightOneKeyRewardRequest);
		}

		// Token: 0x0600E61B RID: 58907 RVA: 0x0021A08B File Offset: 0x0021828B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightOneKeyRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E61C RID: 58908 RVA: 0x0021A0C0 File Offset: 0x002182C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E61D RID: 58909 RVA: 0x0021A0F4 File Offset: 0x002182F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E61E RID: 58910 RVA: 0x0021A101 File Offset: 0x00218301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E61F RID: 58911 RVA: 0x0021A10A File Offset: 0x0021830A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, MotorFightOneKeyRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E620 RID: 58912 RVA: 0x0021A134 File Offset: 0x00218334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(MotorFightOneKeyRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E621 RID: 58913 RVA: 0x0021A16D File Offset: 0x0021836D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightOneKeyRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E622 RID: 58914 RVA: 0x0021A19B File Offset: 0x0021839B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E623 RID: 58915 RVA: 0x0021A1A4 File Offset: 0x002183A4
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, MotorFightOneKeyRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04005DEE RID: 24046
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DEF RID: 24047
		public const int TaskIdsFieldNumber = 3;

		// Token: 0x04005DF0 RID: 24048
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005DF1 RID: 24049
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
