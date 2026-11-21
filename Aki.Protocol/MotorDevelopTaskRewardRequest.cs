using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A20 RID: 2592
	[NetMessage(EMessageId.MotorDevelopTaskRewardRequest)]
	public sealed class MotorDevelopTaskRewardRequest : IMessage<MotorDevelopTaskRewardRequest>, IMessage, IEquatable<MotorDevelopTaskRewardRequest>, IDeepCloneable<MotorDevelopTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600E2CA RID: 58058 RVA: 0x002133A5 File Offset: 0x002115A5
		[NullableContext(1)]
		public static MotorDevelopTaskRewardRequest Create()
		{
			return new MotorDevelopTaskRewardRequest();
		}

		// Token: 0x17002DF3 RID: 11763
		// (get) Token: 0x0600E2CB RID: 58059 RVA: 0x002133AC File Offset: 0x002115AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DF4 RID: 11764
		// (get) Token: 0x0600E2CC RID: 58060 RVA: 0x002133AF File Offset: 0x002115AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDevelopTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600E2CD RID: 58061 RVA: 0x002133B6 File Offset: 0x002115B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskRewardRequest()
		{
		}

		// Token: 0x0600E2CE RID: 58062 RVA: 0x002133C9 File Offset: 0x002115C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskRewardRequest(MotorDevelopTaskRewardRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E2CF RID: 58063 RVA: 0x002133F3 File Offset: 0x002115F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskRewardRequest Clone()
		{
			return new MotorDevelopTaskRewardRequest(this);
		}

		// Token: 0x17002DF5 RID: 11765
		// (get) Token: 0x0600E2D0 RID: 58064 RVA: 0x002133FB File Offset: 0x002115FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0600E2D1 RID: 58065 RVA: 0x00213403 File Offset: 0x00211603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDevelopTaskRewardRequest);
		}

		// Token: 0x0600E2D2 RID: 58066 RVA: 0x00213411 File Offset: 0x00211611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDevelopTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E2D3 RID: 58067 RVA: 0x00213444 File Offset: 0x00211644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E2D4 RID: 58068 RVA: 0x00213478 File Offset: 0x00211678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E2D5 RID: 58069 RVA: 0x00213485 File Offset: 0x00211685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E2D6 RID: 58070 RVA: 0x0021348E File Offset: 0x0021168E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, MotorDevelopTaskRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E2D7 RID: 58071 RVA: 0x002134B8 File Offset: 0x002116B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(MotorDevelopTaskRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E2D8 RID: 58072 RVA: 0x002134F1 File Offset: 0x002116F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDevelopTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E2D9 RID: 58073 RVA: 0x0021351F File Offset: 0x0021171F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E2DA RID: 58074 RVA: 0x00213528 File Offset: 0x00211728
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, MotorDevelopTaskRewardRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04005D54 RID: 23892
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D55 RID: 23893
		public const int IdsFieldNumber = 6;

		// Token: 0x04005D56 RID: 23894
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04005D57 RID: 23895
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
