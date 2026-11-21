using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006AA RID: 1706
	public sealed class GatherTaskSubmitInfo : IMessage<GatherTaskSubmitInfo>, IMessage, IEquatable<GatherTaskSubmitInfo>, IDeepCloneable<GatherTaskSubmitInfo>, IBufferMessage
	{
		// Token: 0x06009CB4 RID: 40116 RVA: 0x0017D225 File Offset: 0x0017B425
		[NullableContext(1)]
		public static GatherTaskSubmitInfo Create()
		{
			return new GatherTaskSubmitInfo();
		}

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x06009CB5 RID: 40117 RVA: 0x0017D22C File Offset: 0x0017B42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GatherTaskSubmitInfo> Parser
		{
			get
			{
				return GatherTaskSubmitInfo._parser;
			}
		}

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x06009CB6 RID: 40118 RVA: 0x0017D233 File Offset: 0x0017B433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x06009CB7 RID: 40119 RVA: 0x0017D236 File Offset: 0x0017B436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatherTaskSubmitInfo.Descriptor;
			}
		}

		// Token: 0x06009CB8 RID: 40120 RVA: 0x0017D23D File Offset: 0x0017B43D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskSubmitInfo()
		{
		}

		// Token: 0x06009CB9 RID: 40121 RVA: 0x0017D250 File Offset: 0x0017B450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskSubmitInfo(GatherTaskSubmitInfo other) : this()
		{
			this.taskId_ = other.taskId_;
			this.gatherItemInfos_ = other.gatherItemInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009CBA RID: 40122 RVA: 0x0017D286 File Offset: 0x0017B486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskSubmitInfo Clone()
		{
			return new GatherTaskSubmitInfo(this);
		}

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x06009CBB RID: 40123 RVA: 0x0017D28E File Offset: 0x0017B48E
		// (set) Token: 0x06009CBC RID: 40124 RVA: 0x0017D296 File Offset: 0x0017B496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TaskId
		{
			get
			{
				return this.taskId_;
			}
			set
			{
				this.taskId_ = value;
			}
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x06009CBD RID: 40125 RVA: 0x0017D29F File Offset: 0x0017B49F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GatherItemInfo> GatherItemInfos
		{
			get
			{
				return this.gatherItemInfos_;
			}
		}

		// Token: 0x06009CBE RID: 40126 RVA: 0x0017D2A7 File Offset: 0x0017B4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatherTaskSubmitInfo);
		}

		// Token: 0x06009CBF RID: 40127 RVA: 0x0017D2B8 File Offset: 0x0017B4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatherTaskSubmitInfo other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && this.gatherItemInfos_.Equals(other.gatherItemInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009CC0 RID: 40128 RVA: 0x0017D308 File Offset: 0x0017B508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			num ^= this.gatherItemInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009CC1 RID: 40129 RVA: 0x0017D355 File Offset: 0x0017B555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009CC2 RID: 40130 RVA: 0x0017D362 File Offset: 0x0017B562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009CC3 RID: 40131 RVA: 0x0017D36C File Offset: 0x0017B56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TaskId);
			}
			this.gatherItemInfos_.WriteTo(ref output, GatherTaskSubmitInfo._repeated_gatherItemInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009CC4 RID: 40132 RVA: 0x0017D3BC File Offset: 0x0017B5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			num += this.gatherItemInfos_.CalculateSize(GatherTaskSubmitInfo._repeated_gatherItemInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009CC5 RID: 40133 RVA: 0x0017D410 File Offset: 0x0017B610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GatherTaskSubmitInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			this.gatherItemInfos_.Add(other.gatherItemInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009CC6 RID: 40134 RVA: 0x0017D45D File Offset: 0x0017B65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009CC7 RID: 40135 RVA: 0x0017D468 File Offset: 0x0017B668
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
						this.gatherItemInfos_.AddEntriesFrom(ref input, GatherTaskSubmitInfo._repeated_gatherItemInfos_codec);
					}
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004A13 RID: 18963
		private static readonly MessageParser<GatherTaskSubmitInfo> _parser = new MessageParser<GatherTaskSubmitInfo>(() => new GatherTaskSubmitInfo());

		// Token: 0x04004A14 RID: 18964
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A15 RID: 18965
		public const int TaskIdFieldNumber = 1;

		// Token: 0x04004A16 RID: 18966
		private int taskId_;

		// Token: 0x04004A17 RID: 18967
		public const int GatherItemInfosFieldNumber = 2;

		// Token: 0x04004A18 RID: 18968
		private static readonly FieldCodec<GatherItemInfo> _repeated_gatherItemInfos_codec = FieldCodec.ForMessage<GatherItemInfo>(18U, GatherItemInfo.Parser);

		// Token: 0x04004A19 RID: 18969
		private readonly RepeatedField<GatherItemInfo> gatherItemInfos_ = new RepeatedField<GatherItemInfo>();
	}
}
