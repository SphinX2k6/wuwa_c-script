using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200059C RID: 1436
	[NetMessage(EMessageId.FloroRanchExecuteSkillPlayResponse)]
	public sealed class FloroRanchExecuteSkillPlayResponse : IMessage<FloroRanchExecuteSkillPlayResponse>, IMessage, IEquatable<FloroRanchExecuteSkillPlayResponse>, IDeepCloneable<FloroRanchExecuteSkillPlayResponse>, IBufferMessage
	{
		// Token: 0x0600853C RID: 34108 RVA: 0x00140DBF File Offset: 0x0013EFBF
		[NullableContext(1)]
		public static FloroRanchExecuteSkillPlayResponse Create()
		{
			return new FloroRanchExecuteSkillPlayResponse();
		}

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x0600853D RID: 34109 RVA: 0x00140DC6 File Offset: 0x0013EFC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x0600853E RID: 34110 RVA: 0x00140DC9 File Offset: 0x0013EFC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchExecuteSkillPlayResponse.Descriptor;
			}
		}

		// Token: 0x0600853F RID: 34111 RVA: 0x00140DD0 File Offset: 0x0013EFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchExecuteSkillPlayResponse()
		{
		}

		// Token: 0x06008540 RID: 34112 RVA: 0x00140DE3 File Offset: 0x0013EFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchExecuteSkillPlayResponse(FloroRanchExecuteSkillPlayResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008541 RID: 34113 RVA: 0x00140E19 File Offset: 0x0013F019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchExecuteSkillPlayResponse Clone()
		{
			return new FloroRanchExecuteSkillPlayResponse(this);
		}

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x06008542 RID: 34114 RVA: 0x00140E21 File Offset: 0x0013F021
		// (set) Token: 0x06008543 RID: 34115 RVA: 0x00140E29 File Offset: 0x0013F029
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

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x06008544 RID: 34116 RVA: 0x00140E32 File Offset: 0x0013F032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x06008545 RID: 34117 RVA: 0x00140E3A File Offset: 0x0013F03A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchExecuteSkillPlayResponse);
		}

		// Token: 0x06008546 RID: 34118 RVA: 0x00140E48 File Offset: 0x0013F048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchExecuteSkillPlayResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008547 RID: 34119 RVA: 0x00140E98 File Offset: 0x0013F098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.task_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008548 RID: 34120 RVA: 0x00140EEB File Offset: 0x0013F0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008549 RID: 34121 RVA: 0x00140EF8 File Offset: 0x0013F0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600854A RID: 34122 RVA: 0x00140F04 File Offset: 0x0013F104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.task_.WriteTo(ref output, FloroRanchExecuteSkillPlayResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600854B RID: 34123 RVA: 0x00140F54 File Offset: 0x0013F154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.task_.CalculateSize(FloroRanchExecuteSkillPlayResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600854C RID: 34124 RVA: 0x00140FA8 File Offset: 0x0013F1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchExecuteSkillPlayResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.task_.Add(other.task_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600854D RID: 34125 RVA: 0x00140FF5 File Offset: 0x0013F1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600854E RID: 34126 RVA: 0x00141000 File Offset: 0x0013F200
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
				if (num != 16U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.task_.AddEntriesFrom(ref input, FloroRanchExecuteSkillPlayResponse._repeated_task_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004257 RID: 16983
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004258 RID: 16984
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04004259 RID: 16985
		private ErrorCode errorCode_;

		// Token: 0x0400425A RID: 16986
		public const int TaskFieldNumber = 12;

		// Token: 0x0400425B RID: 16987
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(98U, FloroRanchPlayTask.Parser);

		// Token: 0x0400425C RID: 16988
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();
	}
}
