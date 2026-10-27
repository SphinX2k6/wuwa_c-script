using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA4 RID: 2724
	[NetMessage(EMessageId.MotorTaskOneKeyRewardRequest)]
	public sealed class MotorTaskOneKeyRewardRequest : IMessage<MotorTaskOneKeyRewardRequest>, IMessage, IEquatable<MotorTaskOneKeyRewardRequest>, IDeepCloneable<MotorTaskOneKeyRewardRequest>, IBufferMessage
	{
		// Token: 0x0600ED23 RID: 60707 RVA: 0x00229E39 File Offset: 0x00228039
		[NullableContext(1)]
		public static MotorTaskOneKeyRewardRequest Create()
		{
			return new MotorTaskOneKeyRewardRequest();
		}

		// Token: 0x1700302B RID: 12331
		// (get) Token: 0x0600ED24 RID: 60708 RVA: 0x00229E40 File Offset: 0x00228040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700302C RID: 12332
		// (get) Token: 0x0600ED25 RID: 60709 RVA: 0x00229E43 File Offset: 0x00228043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTaskOneKeyRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600ED26 RID: 60710 RVA: 0x00229E4A File Offset: 0x0022804A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskOneKeyRewardRequest()
		{
		}

		// Token: 0x0600ED27 RID: 60711 RVA: 0x00229E5D File Offset: 0x0022805D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskOneKeyRewardRequest(MotorTaskOneKeyRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ED28 RID: 60712 RVA: 0x00229E87 File Offset: 0x00228087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskOneKeyRewardRequest Clone()
		{
			return new MotorTaskOneKeyRewardRequest(this);
		}

		// Token: 0x1700302D RID: 12333
		// (get) Token: 0x0600ED29 RID: 60713 RVA: 0x00229E8F File Offset: 0x0022808F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600ED2A RID: 60714 RVA: 0x00229E97 File Offset: 0x00228097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTaskOneKeyRewardRequest);
		}

		// Token: 0x0600ED2B RID: 60715 RVA: 0x00229EA5 File Offset: 0x002280A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTaskOneKeyRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ED2C RID: 60716 RVA: 0x00229ED8 File Offset: 0x002280D8
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

		// Token: 0x0600ED2D RID: 60717 RVA: 0x00229F0C File Offset: 0x0022810C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ED2E RID: 60718 RVA: 0x00229F19 File Offset: 0x00228119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ED2F RID: 60719 RVA: 0x00229F22 File Offset: 0x00228122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, MotorTaskOneKeyRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ED30 RID: 60720 RVA: 0x00229F4C File Offset: 0x0022814C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(MotorTaskOneKeyRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ED31 RID: 60721 RVA: 0x00229F85 File Offset: 0x00228185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTaskOneKeyRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ED32 RID: 60722 RVA: 0x00229FB3 File Offset: 0x002281B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ED33 RID: 60723 RVA: 0x00229FBC File Offset: 0x002281BC
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
					this.taskIds_.AddEntriesFrom(ref input, MotorTaskOneKeyRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04006013 RID: 24595
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006014 RID: 24596
		public const int TaskIdsFieldNumber = 8;

		// Token: 0x04006015 RID: 24597
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04006016 RID: 24598
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
