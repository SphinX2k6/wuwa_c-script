using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003BB RID: 955
	public sealed class DetectionTargetData : IMessage<DetectionTargetData>, IMessage, IEquatable<DetectionTargetData>, IDeepCloneable<DetectionTargetData>, IBufferMessage
	{
		// Token: 0x06005DCC RID: 24012 RVA: 0x000E3B97 File Offset: 0x000E1D97
		[NullableContext(1)]
		public static DetectionTargetData Create()
		{
			return new DetectionTargetData();
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06005DCD RID: 24013 RVA: 0x000E3B9E File Offset: 0x000E1D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DetectionTargetData> Parser
		{
			get
			{
				return DetectionTargetData._parser;
			}
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06005DCE RID: 24014 RVA: 0x000E3BA5 File Offset: 0x000E1DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x06005DCF RID: 24015 RVA: 0x000E3BA8 File Offset: 0x000E1DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionTargetData.Descriptor;
			}
		}

		// Token: 0x06005DD0 RID: 24016 RVA: 0x000E3BAF File Offset: 0x000E1DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTargetData()
		{
		}

		// Token: 0x06005DD1 RID: 24017 RVA: 0x000E3BC2 File Offset: 0x000E1DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTargetData(DetectionTargetData other) : this()
		{
			this.mapId_ = other.mapId_;
			this.targetIds_ = other.targetIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005DD2 RID: 24018 RVA: 0x000E3BF8 File Offset: 0x000E1DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionTargetData Clone()
		{
			return new DetectionTargetData(this);
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06005DD3 RID: 24019 RVA: 0x000E3C00 File Offset: 0x000E1E00
		// (set) Token: 0x06005DD4 RID: 24020 RVA: 0x000E3C08 File Offset: 0x000E1E08
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

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06005DD5 RID: 24021 RVA: 0x000E3C11 File Offset: 0x000E1E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TargetIds
		{
			get
			{
				return this.targetIds_;
			}
		}

		// Token: 0x06005DD6 RID: 24022 RVA: 0x000E3C19 File Offset: 0x000E1E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionTargetData);
		}

		// Token: 0x06005DD7 RID: 24023 RVA: 0x000E3C28 File Offset: 0x000E1E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionTargetData other)
		{
			return other != null && (other == this || (this.MapId == other.MapId && this.targetIds_.Equals(other.targetIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x000E3C78 File Offset: 0x000E1E78
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

		// Token: 0x06005DD9 RID: 24025 RVA: 0x000E3CC5 File Offset: 0x000E1EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005DDA RID: 24026 RVA: 0x000E3CD2 File Offset: 0x000E1ED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DDB RID: 24027 RVA: 0x000E3CDC File Offset: 0x000E1EDC
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

		// Token: 0x06005DDC RID: 24028 RVA: 0x000E3D2C File Offset: 0x000E1F2C
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

		// Token: 0x06005DDD RID: 24029 RVA: 0x000E3D80 File Offset: 0x000E1F80
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

		// Token: 0x06005DDE RID: 24030 RVA: 0x000E3DCD File Offset: 0x000E1FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005DDF RID: 24031 RVA: 0x000E3DD8 File Offset: 0x000E1FD8
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

		// Token: 0x040036FF RID: 14079
		private static readonly MessageParser<DetectionTargetData> _parser = new MessageParser<DetectionTargetData>(() => new DetectionTargetData());

		// Token: 0x04003700 RID: 14080
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003701 RID: 14081
		public const int MapIdFieldNumber = 1;

		// Token: 0x04003702 RID: 14082
		private int mapId_;

		// Token: 0x04003703 RID: 14083
		public const int TargetIdsFieldNumber = 2;

		// Token: 0x04003704 RID: 14084
		private static readonly FieldCodec<int> _repeated_targetIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04003705 RID: 14085
		private readonly RepeatedField<int> targetIds_ = new RepeatedField<int>();
	}
}
