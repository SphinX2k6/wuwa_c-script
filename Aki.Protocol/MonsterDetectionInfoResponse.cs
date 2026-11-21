using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E9 RID: 2537
	[NetMessage(EMessageId.MonsterDetectionInfoResponse)]
	public sealed class MonsterDetectionInfoResponse : IMessage<MonsterDetectionInfoResponse>, IMessage, IEquatable<MonsterDetectionInfoResponse>, IDeepCloneable<MonsterDetectionInfoResponse>, IBufferMessage
	{
		// Token: 0x0600DE84 RID: 56964 RVA: 0x0020A6A9 File Offset: 0x002088A9
		[NullableContext(1)]
		public static MonsterDetectionInfoResponse Create()
		{
			return new MonsterDetectionInfoResponse();
		}

		// Token: 0x17002D18 RID: 11544
		// (get) Token: 0x0600DE85 RID: 56965 RVA: 0x0020A6B0 File Offset: 0x002088B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D19 RID: 11545
		// (get) Token: 0x0600DE86 RID: 56966 RVA: 0x0020A6B3 File Offset: 0x002088B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterDetectionInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600DE87 RID: 56967 RVA: 0x0020A6BA File Offset: 0x002088BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDetectionInfoResponse()
		{
		}

		// Token: 0x0600DE88 RID: 56968 RVA: 0x0020A6CD File Offset: 0x002088CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDetectionInfoResponse(MonsterDetectionInfoResponse other) : this()
		{
			this.detectionTarget_ = other.detectionTarget_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE89 RID: 56969 RVA: 0x0020A6F7 File Offset: 0x002088F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDetectionInfoResponse Clone()
		{
			return new MonsterDetectionInfoResponse(this);
		}

		// Token: 0x17002D1A RID: 11546
		// (get) Token: 0x0600DE8A RID: 56970 RVA: 0x0020A6FF File Offset: 0x002088FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DetectionTarget> DetectionTarget
		{
			get
			{
				return this.detectionTarget_;
			}
		}

		// Token: 0x0600DE8B RID: 56971 RVA: 0x0020A707 File Offset: 0x00208907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterDetectionInfoResponse);
		}

		// Token: 0x0600DE8C RID: 56972 RVA: 0x0020A715 File Offset: 0x00208915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterDetectionInfoResponse other)
		{
			return other != null && (other == this || (this.detectionTarget_.Equals(other.detectionTarget_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE8D RID: 56973 RVA: 0x0020A748 File Offset: 0x00208948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.detectionTarget_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DE8E RID: 56974 RVA: 0x0020A77C File Offset: 0x0020897C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DE8F RID: 56975 RVA: 0x0020A789 File Offset: 0x00208989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE90 RID: 56976 RVA: 0x0020A792 File Offset: 0x00208992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.detectionTarget_.WriteTo(ref output, MonsterDetectionInfoResponse._repeated_detectionTarget_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE91 RID: 56977 RVA: 0x0020A7BC File Offset: 0x002089BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.detectionTarget_.CalculateSize(MonsterDetectionInfoResponse._repeated_detectionTarget_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DE92 RID: 56978 RVA: 0x0020A7F5 File Offset: 0x002089F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterDetectionInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.detectionTarget_.Add(other.detectionTarget_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DE93 RID: 56979 RVA: 0x0020A823 File Offset: 0x00208A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE94 RID: 56980 RVA: 0x0020A82C File Offset: 0x00208A2C
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.detectionTarget_.AddEntriesFrom(ref input, MonsterDetectionInfoResponse._repeated_detectionTarget_codec);
				}
			}
		}

		// Token: 0x04005C38 RID: 23608
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C39 RID: 23609
		public const int DetectionTargetFieldNumber = 4;

		// Token: 0x04005C3A RID: 23610
		private static readonly FieldCodec<DetectionTarget> _repeated_detectionTarget_codec = FieldCodec.ForMessage<DetectionTarget>(34U, Aki.Protocol.DetectionTarget.Parser);

		// Token: 0x04005C3B RID: 23611
		private readonly RepeatedField<DetectionTarget> detectionTarget_ = new RepeatedField<DetectionTarget>();
	}
}
