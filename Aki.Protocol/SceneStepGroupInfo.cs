using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001189 RID: 4489
	public sealed class SceneStepGroupInfo : IMessage<SceneStepGroupInfo>, IMessage, IEquatable<SceneStepGroupInfo>, IDeepCloneable<SceneStepGroupInfo>, IBufferMessage
	{
		// Token: 0x06017ED8 RID: 98008 RVA: 0x00379A8B File Offset: 0x00377C8B
		[NullableContext(1)]
		public static SceneStepGroupInfo Create()
		{
			return new SceneStepGroupInfo();
		}

		// Token: 0x17005065 RID: 20581
		// (get) Token: 0x06017ED9 RID: 98009 RVA: 0x00379A92 File Offset: 0x00377C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneStepGroupInfo> Parser
		{
			get
			{
				return SceneStepGroupInfo._parser;
			}
		}

		// Token: 0x17005066 RID: 20582
		// (get) Token: 0x06017EDA RID: 98010 RVA: 0x00379A99 File Offset: 0x00377C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005067 RID: 20583
		// (get) Token: 0x06017EDB RID: 98011 RVA: 0x00379A9C File Offset: 0x00377C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneStepGroupInfo.Descriptor;
			}
		}

		// Token: 0x06017EDC RID: 98012 RVA: 0x00379AA3 File Offset: 0x00377CA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepGroupInfo()
		{
		}

		// Token: 0x06017EDD RID: 98013 RVA: 0x00379AB6 File Offset: 0x00377CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepGroupInfo(SceneStepGroupInfo other) : this()
		{
			this.stepGroupId_ = other.stepGroupId_;
			this.steps_ = other.steps_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017EDE RID: 98014 RVA: 0x00379AEC File Offset: 0x00377CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneStepGroupInfo Clone()
		{
			return new SceneStepGroupInfo(this);
		}

		// Token: 0x17005068 RID: 20584
		// (get) Token: 0x06017EDF RID: 98015 RVA: 0x00379AF4 File Offset: 0x00377CF4
		// (set) Token: 0x06017EE0 RID: 98016 RVA: 0x00379AFC File Offset: 0x00377CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StepGroupId
		{
			get
			{
				return this.stepGroupId_;
			}
			set
			{
				this.stepGroupId_ = value;
			}
		}

		// Token: 0x17005069 RID: 20585
		// (get) Token: 0x06017EE1 RID: 98017 RVA: 0x00379B05 File Offset: 0x00377D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneStepInfo> Steps
		{
			get
			{
				return this.steps_;
			}
		}

		// Token: 0x06017EE2 RID: 98018 RVA: 0x00379B0D File Offset: 0x00377D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneStepGroupInfo);
		}

		// Token: 0x06017EE3 RID: 98019 RVA: 0x00379B1C File Offset: 0x00377D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneStepGroupInfo other)
		{
			return other != null && (other == this || (this.StepGroupId == other.StepGroupId && this.steps_.Equals(other.steps_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017EE4 RID: 98020 RVA: 0x00379B6C File Offset: 0x00377D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StepGroupId != 0)
			{
				num ^= this.StepGroupId.GetHashCode();
			}
			num ^= this.steps_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017EE5 RID: 98021 RVA: 0x00379BB9 File Offset: 0x00377DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017EE6 RID: 98022 RVA: 0x00379BC6 File Offset: 0x00377DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017EE7 RID: 98023 RVA: 0x00379BD0 File Offset: 0x00377DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StepGroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StepGroupId);
			}
			this.steps_.WriteTo(ref output, SceneStepGroupInfo._repeated_steps_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017EE8 RID: 98024 RVA: 0x00379C20 File Offset: 0x00377E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StepGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StepGroupId);
			}
			num += this.steps_.CalculateSize(SceneStepGroupInfo._repeated_steps_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017EE9 RID: 98025 RVA: 0x00379C74 File Offset: 0x00377E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneStepGroupInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StepGroupId != 0)
			{
				this.StepGroupId = other.StepGroupId;
			}
			this.steps_.Add(other.steps_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017EEA RID: 98026 RVA: 0x00379CC1 File Offset: 0x00377EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017EEB RID: 98027 RVA: 0x00379CCC File Offset: 0x00377ECC
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.steps_.AddEntriesFrom(ref input, SceneStepGroupInfo._repeated_steps_codec);
					}
				}
				else
				{
					this.StepGroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008DC2 RID: 36290
		private static readonly MessageParser<SceneStepGroupInfo> _parser = new MessageParser<SceneStepGroupInfo>(() => new SceneStepGroupInfo());

		// Token: 0x04008DC3 RID: 36291
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DC4 RID: 36292
		public const int StepGroupIdFieldNumber = 1;

		// Token: 0x04008DC5 RID: 36293
		private int stepGroupId_;

		// Token: 0x04008DC6 RID: 36294
		public const int StepsFieldNumber = 2;

		// Token: 0x04008DC7 RID: 36295
		private static readonly FieldCodec<SceneStepInfo> _repeated_steps_codec = FieldCodec.ForMessage<SceneStepInfo>(18U, SceneStepInfo.Parser);

		// Token: 0x04008DC8 RID: 36296
		private readonly RepeatedField<SceneStepInfo> steps_ = new RepeatedField<SceneStepInfo>();
	}
}
