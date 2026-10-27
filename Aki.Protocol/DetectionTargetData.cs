using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D2 RID: 978
	public sealed class DetectionTargetData : IMessage<DetectionTargetData>, IMessage, IEquatable<DetectionTargetData>, IDeepCloneable<DetectionTargetData>, IBufferMessage
	{
		// Token: 0x06005F5C RID: 24412 RVA: 0x000E6D16 File Offset: 0x000E4F16
		[NullableContext(1)]
		public static DetectionTargetData Create()
		{
			return new DetectionTargetData();
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x06005F5D RID: 24413 RVA: 0x000E6D1D File Offset: 0x000E4F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DetectionTargetData> Parser
		{
			get
			{
				return DetectionTargetData._parser;
			}
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06005F5E RID: 24414 RVA: 0x000E6D24 File Offset: 0x000E4F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06005F5F RID: 24415 RVA: 0x000E6D27 File Offset: 0x000E4F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionTargetData.Descriptor;
			}
		}

		// Token: 0x06005F60 RID: 24416 RVA: 0x000E6D2E File Offset: 0x000E4F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTargetData()
		{
		}

		// Token: 0x06005F61 RID: 24417 RVA: 0x000E6D41 File Offset: 0x000E4F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTargetData(DetectionTargetData other) : this()
		{
			this.mapId_ = other.mapId_;
			this.targetIds_ = other.targetIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F62 RID: 24418 RVA: 0x000E6D77 File Offset: 0x000E4F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTargetData Clone()
		{
			return new DetectionTargetData(this);
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06005F63 RID: 24419 RVA: 0x000E6D7F File Offset: 0x000E4F7F
		// (set) Token: 0x06005F64 RID: 24420 RVA: 0x000E6D87 File Offset: 0x000E4F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x06005F65 RID: 24421 RVA: 0x000E6D90 File Offset: 0x000E4F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TargetIds
		{
			get
			{
				return this.targetIds_;
			}
		}

		// Token: 0x06005F66 RID: 24422 RVA: 0x000E6D98 File Offset: 0x000E4F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionTargetData);
		}

		// Token: 0x06005F67 RID: 24423 RVA: 0x000E6DA8 File Offset: 0x000E4FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionTargetData other)
		{
			return other != null && (other == this || (this.MapId == other.MapId && this.targetIds_.Equals(other.targetIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F68 RID: 24424 RVA: 0x000E6DF8 File Offset: 0x000E4FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MapId != 0)
			{
				num ^= this.MapId.GetHashCode();
			}
			num ^= this.targetIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005F69 RID: 24425 RVA: 0x000E6E45 File Offset: 0x000E5045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005F6A RID: 24426 RVA: 0x000E6E52 File Offset: 0x000E5052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F6B RID: 24427 RVA: 0x000E6E5C File Offset: 0x000E505C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MapId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MapId);
			}
			this.targetIds_.WriteTo(ref output, DetectionTargetData._repeated_targetIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F6C RID: 24428 RVA: 0x000E6EAC File Offset: 0x000E50AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MapId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapId);
			}
			num += this.targetIds_.CalculateSize(DetectionTargetData._repeated_targetIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005F6D RID: 24429 RVA: 0x000E6F00 File Offset: 0x000E5100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DetectionTargetData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MapId != 0)
			{
				this.MapId = other.MapId;
			}
			this.targetIds_.Add(other.targetIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005F6E RID: 24430 RVA: 0x000E6F4D File Offset: 0x000E514D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F6F RID: 24431 RVA: 0x000E6F58 File Offset: 0x000E5158
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
				if (num != 8U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.targetIds_.AddEntriesFrom(ref input, DetectionTargetData._repeated_targetIds_codec);
					}
				}
				else
				{
					this.MapId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003712 RID: 14098
		private static readonly MessageParser<DetectionTargetData> _parser = new MessageParser<DetectionTargetData>(() => new DetectionTargetData());

		// Token: 0x04003713 RID: 14099
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003714 RID: 14100
		public const int MapIdFieldNumber = 1;

		// Token: 0x04003715 RID: 14101
		private int mapId_;

		// Token: 0x04003716 RID: 14102
		public const int TargetIdsFieldNumber = 2;

		// Token: 0x04003717 RID: 14103
		private static readonly FieldCodec<int> _repeated_targetIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04003718 RID: 14104
		private readonly RepeatedField<int> targetIds_ = new RepeatedField<int>();
	}
}
