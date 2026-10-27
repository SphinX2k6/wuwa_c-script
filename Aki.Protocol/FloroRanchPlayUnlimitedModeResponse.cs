using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D7 RID: 1495
	[NetMessage(EMessageId.FloroRanchPlayUnlimitedModeResponse)]
	public sealed class FloroRanchPlayUnlimitedModeResponse : IMessage<FloroRanchPlayUnlimitedModeResponse>, IMessage, IEquatable<FloroRanchPlayUnlimitedModeResponse>, IDeepCloneable<FloroRanchPlayUnlimitedModeResponse>, IBufferMessage
	{
		// Token: 0x06008A5D RID: 35421 RVA: 0x0014E980 File Offset: 0x0014CB80
		[NullableContext(1)]
		public static FloroRanchPlayUnlimitedModeResponse Create()
		{
			return new FloroRanchPlayUnlimitedModeResponse();
		}

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x06008A5E RID: 35422 RVA: 0x0014E987 File Offset: 0x0014CB87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x06008A5F RID: 35423 RVA: 0x0014E98A File Offset: 0x0014CB8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayUnlimitedModeResponse.Descriptor;
			}
		}

		// Token: 0x06008A60 RID: 35424 RVA: 0x0014E991 File Offset: 0x0014CB91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnlimitedModeResponse()
		{
		}

		// Token: 0x06008A61 RID: 35425 RVA: 0x0014E9A4 File Offset: 0x0014CBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnlimitedModeResponse(FloroRanchPlayUnlimitedModeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.curStage_ = other.curStage_;
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A62 RID: 35426 RVA: 0x0014E9F1 File Offset: 0x0014CBF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnlimitedModeResponse Clone()
		{
			return new FloroRanchPlayUnlimitedModeResponse(this);
		}

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x06008A63 RID: 35427 RVA: 0x0014E9F9 File Offset: 0x0014CBF9
		// (set) Token: 0x06008A64 RID: 35428 RVA: 0x0014EA01 File Offset: 0x0014CC01
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

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x06008A65 RID: 35429 RVA: 0x0014EA0A File Offset: 0x0014CC0A
		// (set) Token: 0x06008A66 RID: 35430 RVA: 0x0014EA12 File Offset: 0x0014CC12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurStage
		{
			get
			{
				return this.curStage_;
			}
			set
			{
				this.curStage_ = value;
			}
		}

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x06008A67 RID: 35431 RVA: 0x0014EA1B File Offset: 0x0014CC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x06008A68 RID: 35432 RVA: 0x0014EA23 File Offset: 0x0014CC23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayUnlimitedModeResponse);
		}

		// Token: 0x06008A69 RID: 35433 RVA: 0x0014EA34 File Offset: 0x0014CC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayUnlimitedModeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CurStage == other.CurStage && this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A6A RID: 35434 RVA: 0x0014EA94 File Offset: 0x0014CC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.CurStage != 0)
			{
				num ^= this.CurStage.GetHashCode();
			}
			num ^= this.task_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A6B RID: 35435 RVA: 0x0014EB00 File Offset: 0x0014CD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008A6C RID: 35436 RVA: 0x0014EB0D File Offset: 0x0014CD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A6D RID: 35437 RVA: 0x0014EB18 File Offset: 0x0014CD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CurStage != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurStage);
			}
			this.task_.WriteTo(ref output, FloroRanchPlayUnlimitedModeResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A6E RID: 35438 RVA: 0x0014EB84 File Offset: 0x0014CD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.CurStage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurStage);
			}
			num += this.task_.CalculateSize(FloroRanchPlayUnlimitedModeResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A6F RID: 35439 RVA: 0x0014EBF0 File Offset: 0x0014CDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayUnlimitedModeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.CurStage != 0)
			{
				this.CurStage = other.CurStage;
			}
			this.task_.Add(other.task_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008A70 RID: 35440 RVA: 0x0014EC51 File Offset: 0x0014CE51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A71 RID: 35441 RVA: 0x0014EC5C File Offset: 0x0014CE5C
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
					if (num != 24U)
					{
						if (num != 82U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.task_.AddEntriesFrom(ref input, FloroRanchPlayUnlimitedModeResponse._repeated_task_codec);
						}
					}
					else
					{
						this.CurStage = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040043FD RID: 17405
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043FE RID: 17406
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040043FF RID: 17407
		private ErrorCode errorCode_;

		// Token: 0x04004400 RID: 17408
		public const int CurStageFieldNumber = 3;

		// Token: 0x04004401 RID: 17409
		private int curStage_;

		// Token: 0x04004402 RID: 17410
		public const int TaskFieldNumber = 10;

		// Token: 0x04004403 RID: 17411
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(82U, FloroRanchPlayTask.Parser);

		// Token: 0x04004404 RID: 17412
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();
	}
}
