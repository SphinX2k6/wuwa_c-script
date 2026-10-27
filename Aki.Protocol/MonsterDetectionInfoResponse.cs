using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009FA RID: 2554
	[NetMessage(EMessageId.MonsterDetectionInfoResponse)]
	public sealed class MonsterDetectionInfoResponse : IMessage<MonsterDetectionInfoResponse>, IMessage, IEquatable<MonsterDetectionInfoResponse>, IDeepCloneable<MonsterDetectionInfoResponse>, IBufferMessage
	{
		// Token: 0x0600DF9E RID: 57246 RVA: 0x0020C895 File Offset: 0x0020AA95
		[NullableContext(1)]
		public static MonsterDetectionInfoResponse Create()
		{
			return new MonsterDetectionInfoResponse();
		}

		// Token: 0x17002D56 RID: 11606
		// (get) Token: 0x0600DF9F RID: 57247 RVA: 0x0020C89C File Offset: 0x0020AA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D57 RID: 11607
		// (get) Token: 0x0600DFA0 RID: 57248 RVA: 0x0020C89F File Offset: 0x0020AA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterDetectionInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600DFA1 RID: 57249 RVA: 0x0020C8A6 File Offset: 0x0020AAA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDetectionInfoResponse()
		{
		}

		// Token: 0x0600DFA2 RID: 57250 RVA: 0x0020C8B9 File Offset: 0x0020AAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDetectionInfoResponse(MonsterDetectionInfoResponse other) : this()
		{
			this.detectionTarget_ = other.detectionTarget_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DFA3 RID: 57251 RVA: 0x0020C8E3 File Offset: 0x0020AAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDetectionInfoResponse Clone()
		{
			return new MonsterDetectionInfoResponse(this);
		}

		// Token: 0x17002D58 RID: 11608
		// (get) Token: 0x0600DFA4 RID: 57252 RVA: 0x0020C8EB File Offset: 0x0020AAEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DetectionTarget> DetectionTarget
		{
			get
			{
				return this.detectionTarget_;
			}
		}

		// Token: 0x0600DFA5 RID: 57253 RVA: 0x0020C8F3 File Offset: 0x0020AAF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterDetectionInfoResponse);
		}

		// Token: 0x0600DFA6 RID: 57254 RVA: 0x0020C901 File Offset: 0x0020AB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterDetectionInfoResponse other)
		{
			return other != null && (other == this || (this.detectionTarget_.Equals(other.detectionTarget_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DFA7 RID: 57255 RVA: 0x0020C934 File Offset: 0x0020AB34
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

		// Token: 0x0600DFA8 RID: 57256 RVA: 0x0020C968 File Offset: 0x0020AB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DFA9 RID: 57257 RVA: 0x0020C975 File Offset: 0x0020AB75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DFAA RID: 57258 RVA: 0x0020C97E File Offset: 0x0020AB7E
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

		// Token: 0x0600DFAB RID: 57259 RVA: 0x0020C9A8 File Offset: 0x0020ABA8
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

		// Token: 0x0600DFAC RID: 57260 RVA: 0x0020C9E1 File Offset: 0x0020ABE1
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

		// Token: 0x0600DFAD RID: 57261 RVA: 0x0020CA0F File Offset: 0x0020AC0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DFAE RID: 57262 RVA: 0x0020CA18 File Offset: 0x0020AC18
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.detectionTarget_.AddEntriesFrom(ref input, MonsterDetectionInfoResponse._repeated_detectionTarget_codec);
				}
			}
		}

		// Token: 0x04005C2F RID: 23599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C30 RID: 23600
		public const int DetectionTargetFieldNumber = 6;

		// Token: 0x04005C31 RID: 23601
		private static readonly FieldCodec<DetectionTarget> _repeated_detectionTarget_codec = FieldCodec.ForMessage<DetectionTarget>(50U, Aki.Protocol.DetectionTarget.Parser);

		// Token: 0x04005C32 RID: 23602
		private readonly RepeatedField<DetectionTarget> detectionTarget_ = new RepeatedField<DetectionTarget>();
	}
}
