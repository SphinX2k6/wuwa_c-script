using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006BE RID: 1726
	public sealed class GatherTaskSubmitInfo : IMessage<GatherTaskSubmitInfo>, IMessage, IEquatable<GatherTaskSubmitInfo>, IDeepCloneable<GatherTaskSubmitInfo>, IBufferMessage
	{
		// Token: 0x06009E0A RID: 40458 RVA: 0x0017FC55 File Offset: 0x0017DE55
		[NullableContext(1)]
		public static GatherTaskSubmitInfo Create()
		{
			return new GatherTaskSubmitInfo();
		}

		// Token: 0x17001FC3 RID: 8131
		// (get) Token: 0x06009E0B RID: 40459 RVA: 0x0017FC5C File Offset: 0x0017DE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GatherTaskSubmitInfo> Parser
		{
			get
			{
				return GatherTaskSubmitInfo._parser;
			}
		}

		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x06009E0C RID: 40460 RVA: 0x0017FC63 File Offset: 0x0017DE63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x06009E0D RID: 40461 RVA: 0x0017FC66 File Offset: 0x0017DE66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatherTaskSubmitInfo.Descriptor;
			}
		}

		// Token: 0x06009E0E RID: 40462 RVA: 0x0017FC6D File Offset: 0x0017DE6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskSubmitInfo()
		{
		}

		// Token: 0x06009E0F RID: 40463 RVA: 0x0017FC80 File Offset: 0x0017DE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskSubmitInfo(GatherTaskSubmitInfo other) : this()
		{
			this.taskId_ = other.taskId_;
			this.gatherItemInfos_ = other.gatherItemInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E10 RID: 40464 RVA: 0x0017FCB6 File Offset: 0x0017DEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskSubmitInfo Clone()
		{
			return new GatherTaskSubmitInfo(this);
		}

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x06009E11 RID: 40465 RVA: 0x0017FCBE File Offset: 0x0017DEBE
		// (set) Token: 0x06009E12 RID: 40466 RVA: 0x0017FCC6 File Offset: 0x0017DEC6
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

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x06009E13 RID: 40467 RVA: 0x0017FCCF File Offset: 0x0017DECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GatherItemInfo> GatherItemInfos
		{
			get
			{
				return this.gatherItemInfos_;
			}
		}

		// Token: 0x06009E14 RID: 40468 RVA: 0x0017FCD7 File Offset: 0x0017DED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatherTaskSubmitInfo);
		}

		// Token: 0x06009E15 RID: 40469 RVA: 0x0017FCE8 File Offset: 0x0017DEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatherTaskSubmitInfo other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && this.gatherItemInfos_.Equals(other.gatherItemInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E16 RID: 40470 RVA: 0x0017FD38 File Offset: 0x0017DF38
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

		// Token: 0x06009E17 RID: 40471 RVA: 0x0017FD85 File Offset: 0x0017DF85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E18 RID: 40472 RVA: 0x0017FD92 File Offset: 0x0017DF92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E19 RID: 40473 RVA: 0x0017FD9C File Offset: 0x0017DF9C
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

		// Token: 0x06009E1A RID: 40474 RVA: 0x0017FDEC File Offset: 0x0017DFEC
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

		// Token: 0x06009E1B RID: 40475 RVA: 0x0017FE40 File Offset: 0x0017E040
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

		// Token: 0x06009E1C RID: 40476 RVA: 0x0017FE8D File Offset: 0x0017E08D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E1D RID: 40477 RVA: 0x0017FE98 File Offset: 0x0017E098
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

		// Token: 0x04004A1A RID: 18970
		private static readonly MessageParser<GatherTaskSubmitInfo> _parser = new MessageParser<GatherTaskSubmitInfo>(() => new GatherTaskSubmitInfo());

		// Token: 0x04004A1B RID: 18971
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A1C RID: 18972
		public const int TaskIdFieldNumber = 1;

		// Token: 0x04004A1D RID: 18973
		private int taskId_;

		// Token: 0x04004A1E RID: 18974
		public const int GatherItemInfosFieldNumber = 2;

		// Token: 0x04004A1F RID: 18975
		private static readonly FieldCodec<GatherItemInfo> _repeated_gatherItemInfos_codec = FieldCodec.ForMessage<GatherItemInfo>(18U, GatherItemInfo.Parser);

		// Token: 0x04004A20 RID: 18976
		private readonly RepeatedField<GatherItemInfo> gatherItemInfos_ = new RepeatedField<GatherItemInfo>();
	}
}
