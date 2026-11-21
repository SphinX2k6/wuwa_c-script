using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200086B RID: 2155
	public sealed class JumpTaskCondInfo : IMessage<JumpTaskCondInfo>, IMessage, IEquatable<JumpTaskCondInfo>, IDeepCloneable<JumpTaskCondInfo>, IBufferMessage
	{
		// Token: 0x0600C043 RID: 49219 RVA: 0x001C9259 File Offset: 0x001C7459
		[NullableContext(1)]
		public static JumpTaskCondInfo Create()
		{
			return new JumpTaskCondInfo();
		}

		// Token: 0x170026D5 RID: 9941
		// (get) Token: 0x0600C044 RID: 49220 RVA: 0x001C9260 File Offset: 0x001C7460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JumpTaskCondInfo> Parser
		{
			get
			{
				return JumpTaskCondInfo._parser;
			}
		}

		// Token: 0x170026D6 RID: 9942
		// (get) Token: 0x0600C045 RID: 49221 RVA: 0x001C9267 File Offset: 0x001C7467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026D7 RID: 9943
		// (get) Token: 0x0600C046 RID: 49222 RVA: 0x001C926A File Offset: 0x001C746A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JumpTaskCondInfo.Descriptor;
			}
		}

		// Token: 0x0600C047 RID: 49223 RVA: 0x001C9271 File Offset: 0x001C7471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JumpTaskCondInfo()
		{
		}

		// Token: 0x0600C048 RID: 49224 RVA: 0x001C9284 File Offset: 0x001C7484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JumpTaskCondInfo(JumpTaskCondInfo other) : this()
		{
			this.jumpTaskId_ = other.jumpTaskId_;
			this.conditionGroupIds_ = other.conditionGroupIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C049 RID: 49225 RVA: 0x001C92BA File Offset: 0x001C74BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JumpTaskCondInfo Clone()
		{
			return new JumpTaskCondInfo(this);
		}

		// Token: 0x170026D8 RID: 9944
		// (get) Token: 0x0600C04A RID: 49226 RVA: 0x001C92C2 File Offset: 0x001C74C2
		// (set) Token: 0x0600C04B RID: 49227 RVA: 0x001C92CA File Offset: 0x001C74CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int JumpTaskId
		{
			get
			{
				return this.jumpTaskId_;
			}
			set
			{
				this.jumpTaskId_ = value;
			}
		}

		// Token: 0x170026D9 RID: 9945
		// (get) Token: 0x0600C04C RID: 49228 RVA: 0x001C92D3 File Offset: 0x001C74D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConditionGroupIds
		{
			get
			{
				return this.conditionGroupIds_;
			}
		}

		// Token: 0x0600C04D RID: 49229 RVA: 0x001C92DB File Offset: 0x001C74DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JumpTaskCondInfo);
		}

		// Token: 0x0600C04E RID: 49230 RVA: 0x001C92EC File Offset: 0x001C74EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JumpTaskCondInfo other)
		{
			return other != null && (other == this || (this.JumpTaskId == other.JumpTaskId && this.conditionGroupIds_.Equals(other.conditionGroupIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C04F RID: 49231 RVA: 0x001C933C File Offset: 0x001C753C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JumpTaskId != 0)
			{
				num ^= this.JumpTaskId.GetHashCode();
			}
			num ^= this.conditionGroupIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C050 RID: 49232 RVA: 0x001C9389 File Offset: 0x001C7589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C051 RID: 49233 RVA: 0x001C9396 File Offset: 0x001C7596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C052 RID: 49234 RVA: 0x001C93A0 File Offset: 0x001C75A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JumpTaskId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.JumpTaskId);
			}
			this.conditionGroupIds_.WriteTo(ref output, JumpTaskCondInfo._repeated_conditionGroupIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C053 RID: 49235 RVA: 0x001C93F0 File Offset: 0x001C75F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JumpTaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.JumpTaskId);
			}
			num += this.conditionGroupIds_.CalculateSize(JumpTaskCondInfo._repeated_conditionGroupIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C054 RID: 49236 RVA: 0x001C9444 File Offset: 0x001C7644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JumpTaskCondInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JumpTaskId != 0)
			{
				this.JumpTaskId = other.JumpTaskId;
			}
			this.conditionGroupIds_.Add(other.conditionGroupIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C055 RID: 49237 RVA: 0x001C9491 File Offset: 0x001C7691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C056 RID: 49238 RVA: 0x001C949C File Offset: 0x001C769C
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
						this.conditionGroupIds_.AddEntriesFrom(ref input, JumpTaskCondInfo._repeated_conditionGroupIds_codec);
					}
				}
				else
				{
					this.JumpTaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040053E6 RID: 21478
		private static readonly MessageParser<JumpTaskCondInfo> _parser = new MessageParser<JumpTaskCondInfo>(() => new JumpTaskCondInfo());

		// Token: 0x040053E7 RID: 21479
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053E8 RID: 21480
		public const int JumpTaskIdFieldNumber = 1;

		// Token: 0x040053E9 RID: 21481
		private int jumpTaskId_;

		// Token: 0x040053EA RID: 21482
		public const int ConditionGroupIdsFieldNumber = 2;

		// Token: 0x040053EB RID: 21483
		private static readonly FieldCodec<int> _repeated_conditionGroupIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040053EC RID: 21484
		private readonly RepeatedField<int> conditionGroupIds_ = new RepeatedField<int>();
	}
}
