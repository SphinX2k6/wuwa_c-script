using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B1 RID: 1457
	[NetMessage(EMessageId.FloroRanchExecuteSkillPlayResponse)]
	public sealed class FloroRanchExecuteSkillPlayResponse : IMessage<FloroRanchExecuteSkillPlayResponse>, IMessage, IEquatable<FloroRanchExecuteSkillPlayResponse>, IDeepCloneable<FloroRanchExecuteSkillPlayResponse>, IBufferMessage
	{
		// Token: 0x060086A4 RID: 34468 RVA: 0x001439CF File Offset: 0x00141BCF
		[NullableContext(1)]
		public static FloroRanchExecuteSkillPlayResponse Create()
		{
			return new FloroRanchExecuteSkillPlayResponse();
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x060086A5 RID: 34469 RVA: 0x001439D6 File Offset: 0x00141BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x060086A6 RID: 34470 RVA: 0x001439D9 File Offset: 0x00141BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchExecuteSkillPlayResponse.Descriptor;
			}
		}

		// Token: 0x060086A7 RID: 34471 RVA: 0x001439E0 File Offset: 0x00141BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchExecuteSkillPlayResponse()
		{
		}

		// Token: 0x060086A8 RID: 34472 RVA: 0x001439F3 File Offset: 0x00141BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchExecuteSkillPlayResponse(FloroRanchExecuteSkillPlayResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060086A9 RID: 34473 RVA: 0x00143A29 File Offset: 0x00141C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchExecuteSkillPlayResponse Clone()
		{
			return new FloroRanchExecuteSkillPlayResponse(this);
		}

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x060086AA RID: 34474 RVA: 0x00143A31 File Offset: 0x00141C31
		// (set) Token: 0x060086AB RID: 34475 RVA: 0x00143A39 File Offset: 0x00141C39
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

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x060086AC RID: 34476 RVA: 0x00143A42 File Offset: 0x00141C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x060086AD RID: 34477 RVA: 0x00143A4A File Offset: 0x00141C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchExecuteSkillPlayResponse);
		}

		// Token: 0x060086AE RID: 34478 RVA: 0x00143A58 File Offset: 0x00141C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchExecuteSkillPlayResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060086AF RID: 34479 RVA: 0x00143AA8 File Offset: 0x00141CA8
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

		// Token: 0x060086B0 RID: 34480 RVA: 0x00143AFB File Offset: 0x00141CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060086B1 RID: 34481 RVA: 0x00143B08 File Offset: 0x00141D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060086B2 RID: 34482 RVA: 0x00143B14 File Offset: 0x00141D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.task_.WriteTo(ref output, FloroRanchExecuteSkillPlayResponse._repeated_task_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060086B3 RID: 34483 RVA: 0x00143B64 File Offset: 0x00141D64
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

		// Token: 0x060086B4 RID: 34484 RVA: 0x00143BB8 File Offset: 0x00141DB8
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

		// Token: 0x060086B5 RID: 34485 RVA: 0x00143C05 File Offset: 0x00141E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060086B6 RID: 34486 RVA: 0x00143C10 File Offset: 0x00141E10
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.task_.AddEntriesFrom(ref input, FloroRanchExecuteSkillPlayResponse._repeated_task_codec);
				}
			}
		}

		// Token: 0x04004261 RID: 16993
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004262 RID: 16994
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04004263 RID: 16995
		private ErrorCode errorCode_;

		// Token: 0x04004264 RID: 16996
		public const int TaskFieldNumber = 4;

		// Token: 0x04004265 RID: 16997
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(34U, FloroRanchPlayTask.Parser);

		// Token: 0x04004266 RID: 16998
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();
	}
}
