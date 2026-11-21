using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000949 RID: 2377
	[NetMessage(EMessageId.LoopTeleportVolumeActionResponse)]
	public sealed class LoopTeleportVolumeActionResponse : IMessage<LoopTeleportVolumeActionResponse>, IMessage, IEquatable<LoopTeleportVolumeActionResponse>, IDeepCloneable<LoopTeleportVolumeActionResponse>, IBufferMessage
	{
		// Token: 0x0600D1E1 RID: 53729 RVA: 0x001EF5F5 File Offset: 0x001ED7F5
		[NullableContext(1)]
		public static LoopTeleportVolumeActionResponse Create()
		{
			return new LoopTeleportVolumeActionResponse();
		}

		// Token: 0x17002A7B RID: 10875
		// (get) Token: 0x0600D1E2 RID: 53730 RVA: 0x001EF5FC File Offset: 0x001ED7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A7C RID: 10876
		// (get) Token: 0x0600D1E3 RID: 53731 RVA: 0x001EF5FF File Offset: 0x001ED7FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoopTeleportVolumeActionResponse.Descriptor;
			}
		}

		// Token: 0x0600D1E4 RID: 53732 RVA: 0x001EF606 File Offset: 0x001ED806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoopTeleportVolumeActionResponse()
		{
		}

		// Token: 0x0600D1E5 RID: 53733 RVA: 0x001EF619 File Offset: 0x001ED819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoopTeleportVolumeActionResponse(LoopTeleportVolumeActionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.conditionMetIds_ = other.conditionMetIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D1E6 RID: 53734 RVA: 0x001EF64F File Offset: 0x001ED84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoopTeleportVolumeActionResponse Clone()
		{
			return new LoopTeleportVolumeActionResponse(this);
		}

		// Token: 0x17002A7D RID: 10877
		// (get) Token: 0x0600D1E7 RID: 53735 RVA: 0x001EF657 File Offset: 0x001ED857
		// (set) Token: 0x0600D1E8 RID: 53736 RVA: 0x001EF65F File Offset: 0x001ED85F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17002A7E RID: 10878
		// (get) Token: 0x0600D1E9 RID: 53737 RVA: 0x001EF668 File Offset: 0x001ED868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConditionMetIds
		{
			get
			{
				return this.conditionMetIds_;
			}
		}

		// Token: 0x0600D1EA RID: 53738 RVA: 0x001EF670 File Offset: 0x001ED870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoopTeleportVolumeActionResponse);
		}

		// Token: 0x0600D1EB RID: 53739 RVA: 0x001EF680 File Offset: 0x001ED880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoopTeleportVolumeActionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.conditionMetIds_.Equals(other.conditionMetIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D1EC RID: 53740 RVA: 0x001EF6D0 File Offset: 0x001ED8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.conditionMetIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D1ED RID: 53741 RVA: 0x001EF723 File Offset: 0x001ED923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D1EE RID: 53742 RVA: 0x001EF730 File Offset: 0x001ED930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D1EF RID: 53743 RVA: 0x001EF73C File Offset: 0x001ED93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.conditionMetIds_.WriteTo(ref output, LoopTeleportVolumeActionResponse._repeated_conditionMetIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D1F0 RID: 53744 RVA: 0x001EF78C File Offset: 0x001ED98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.conditionMetIds_.CalculateSize(LoopTeleportVolumeActionResponse._repeated_conditionMetIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D1F1 RID: 53745 RVA: 0x001EF7E0 File Offset: 0x001ED9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoopTeleportVolumeActionResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.conditionMetIds_.Add(other.conditionMetIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D1F2 RID: 53746 RVA: 0x001EF82D File Offset: 0x001EDA2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D1F3 RID: 53747 RVA: 0x001EF838 File Offset: 0x001EDA38
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
				if (num != 104U)
				{
					if (num != 120U && num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.conditionMetIds_.AddEntriesFrom(ref input, LoopTeleportVolumeActionResponse._repeated_conditionMetIds_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040058C2 RID: 22722
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058C3 RID: 22723
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040058C4 RID: 22724
		private ErrorCode errorCode_;

		// Token: 0x040058C5 RID: 22725
		public const int ConditionMetIdsFieldNumber = 15;

		// Token: 0x040058C6 RID: 22726
		private static readonly FieldCodec<int> _repeated_conditionMetIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x040058C7 RID: 22727
		private readonly RepeatedField<int> conditionMetIds_ = new RepeatedField<int>();
	}
}
