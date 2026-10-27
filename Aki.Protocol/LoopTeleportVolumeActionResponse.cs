using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200095A RID: 2394
	[NetMessage(EMessageId.LoopTeleportVolumeActionResponse)]
	public sealed class LoopTeleportVolumeActionResponse : IMessage<LoopTeleportVolumeActionResponse>, IMessage, IEquatable<LoopTeleportVolumeActionResponse>, IDeepCloneable<LoopTeleportVolumeActionResponse>, IBufferMessage
	{
		// Token: 0x0600D2FB RID: 54011 RVA: 0x001F17DD File Offset: 0x001EF9DD
		[NullableContext(1)]
		public static LoopTeleportVolumeActionResponse Create()
		{
			return new LoopTeleportVolumeActionResponse();
		}

		// Token: 0x17002AB9 RID: 10937
		// (get) Token: 0x0600D2FC RID: 54012 RVA: 0x001F17E4 File Offset: 0x001EF9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002ABA RID: 10938
		// (get) Token: 0x0600D2FD RID: 54013 RVA: 0x001F17E7 File Offset: 0x001EF9E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoopTeleportVolumeActionResponse.Descriptor;
			}
		}

		// Token: 0x0600D2FE RID: 54014 RVA: 0x001F17EE File Offset: 0x001EF9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoopTeleportVolumeActionResponse()
		{
		}

		// Token: 0x0600D2FF RID: 54015 RVA: 0x001F1801 File Offset: 0x001EFA01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoopTeleportVolumeActionResponse(LoopTeleportVolumeActionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.conditionMetIds_ = other.conditionMetIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D300 RID: 54016 RVA: 0x001F1837 File Offset: 0x001EFA37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoopTeleportVolumeActionResponse Clone()
		{
			return new LoopTeleportVolumeActionResponse(this);
		}

		// Token: 0x17002ABB RID: 10939
		// (get) Token: 0x0600D301 RID: 54017 RVA: 0x001F183F File Offset: 0x001EFA3F
		// (set) Token: 0x0600D302 RID: 54018 RVA: 0x001F1847 File Offset: 0x001EFA47
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

		// Token: 0x17002ABC RID: 10940
		// (get) Token: 0x0600D303 RID: 54019 RVA: 0x001F1850 File Offset: 0x001EFA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConditionMetIds
		{
			get
			{
				return this.conditionMetIds_;
			}
		}

		// Token: 0x0600D304 RID: 54020 RVA: 0x001F1858 File Offset: 0x001EFA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoopTeleportVolumeActionResponse);
		}

		// Token: 0x0600D305 RID: 54021 RVA: 0x001F1868 File Offset: 0x001EFA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoopTeleportVolumeActionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.conditionMetIds_.Equals(other.conditionMetIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D306 RID: 54022 RVA: 0x001F18B8 File Offset: 0x001EFAB8
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

		// Token: 0x0600D307 RID: 54023 RVA: 0x001F190B File Offset: 0x001EFB0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D308 RID: 54024 RVA: 0x001F1918 File Offset: 0x001EFB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D309 RID: 54025 RVA: 0x001F1924 File Offset: 0x001EFB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.conditionMetIds_.WriteTo(ref output, LoopTeleportVolumeActionResponse._repeated_conditionMetIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D30A RID: 54026 RVA: 0x001F1974 File Offset: 0x001EFB74
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

		// Token: 0x0600D30B RID: 54027 RVA: 0x001F19C8 File Offset: 0x001EFBC8
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

		// Token: 0x0600D30C RID: 54028 RVA: 0x001F1A15 File Offset: 0x001EFC15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D30D RID: 54029 RVA: 0x001F1A20 File Offset: 0x001EFC20
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
				if (num != 56U)
				{
					if (num != 112U && num != 114U)
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

		// Token: 0x040058B9 RID: 22713
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058BA RID: 22714
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040058BB RID: 22715
		private ErrorCode errorCode_;

		// Token: 0x040058BC RID: 22716
		public const int ConditionMetIdsFieldNumber = 14;

		// Token: 0x040058BD RID: 22717
		private static readonly FieldCodec<int> _repeated_conditionMetIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x040058BE RID: 22718
		private readonly RepeatedField<int> conditionMetIds_ = new RepeatedField<int>();
	}
}
