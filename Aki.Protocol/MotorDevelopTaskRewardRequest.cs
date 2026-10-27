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
	[NetMessage(EMessageId.MotorDevelopTaskRewardRequest)]
	public sealed class MotorDevelopTaskRewardRequest : IMessage<MotorDevelopTaskRewardRequest>, IMessage, IEquatable<MotorDevelopTaskRewardRequest>, IDeepCloneable<MotorDevelopTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600E3E4 RID: 58340 RVA: 0x00215595 File Offset: 0x00213795
		[NullableContext(1)]
		public static MotorDevelopTaskRewardRequest Create()
		{
			return new MotorDevelopTaskRewardRequest();
		}

		// Token: 0x17002E31 RID: 11825
		// (get) Token: 0x0600E3E5 RID: 58341 RVA: 0x0021559C File Offset: 0x0021379C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E32 RID: 11826
		// (get) Token: 0x0600E3E6 RID: 58342 RVA: 0x0021559F File Offset: 0x0021379F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDevelopTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600E3E7 RID: 58343 RVA: 0x002155A6 File Offset: 0x002137A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskRewardRequest()
		{
		}

		// Token: 0x0600E3E8 RID: 58344 RVA: 0x002155B9 File Offset: 0x002137B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskRewardRequest(MotorDevelopTaskRewardRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E3E9 RID: 58345 RVA: 0x002155E3 File Offset: 0x002137E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskRewardRequest Clone()
		{
			return new MotorDevelopTaskRewardRequest(this);
		}

		// Token: 0x17002E33 RID: 11827
		// (get) Token: 0x0600E3EA RID: 58346 RVA: 0x002155EB File Offset: 0x002137EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0600E3EB RID: 58347 RVA: 0x002155F3 File Offset: 0x002137F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDevelopTaskRewardRequest);
		}

		// Token: 0x0600E3EC RID: 58348 RVA: 0x00215601 File Offset: 0x00213801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDevelopTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E3ED RID: 58349 RVA: 0x00215634 File Offset: 0x00213834
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

		// Token: 0x0600E3EE RID: 58350 RVA: 0x00215668 File Offset: 0x00213868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E3EF RID: 58351 RVA: 0x00215675 File Offset: 0x00213875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E3F0 RID: 58352 RVA: 0x0021567E File Offset: 0x0021387E
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

		// Token: 0x0600E3F1 RID: 58353 RVA: 0x002156A8 File Offset: 0x002138A8
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

		// Token: 0x0600E3F2 RID: 58354 RVA: 0x002156E1 File Offset: 0x002138E1
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

		// Token: 0x0600E3F3 RID: 58355 RVA: 0x0021570F File Offset: 0x0021390F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E3F4 RID: 58356 RVA: 0x00215718 File Offset: 0x00213918
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
					this.ids_.AddEntriesFrom(ref input, MotorDevelopTaskRewardRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04005D4B RID: 23883
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D4C RID: 23884
		public const int IdsFieldNumber = 3;

		// Token: 0x04005D4D RID: 23885
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005D4E RID: 23886
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
