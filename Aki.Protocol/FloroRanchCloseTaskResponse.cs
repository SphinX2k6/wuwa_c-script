using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005AB RID: 1451
	[NetMessage(EMessageId.FloroRanchCloseTaskResponse)]
	public sealed class FloroRanchCloseTaskResponse : IMessage<FloroRanchCloseTaskResponse>, IMessage, IEquatable<FloroRanchCloseTaskResponse>, IDeepCloneable<FloroRanchCloseTaskResponse>, IBufferMessage
	{
		// Token: 0x0600861D RID: 34333 RVA: 0x00142493 File Offset: 0x00140693
		[NullableContext(1)]
		public static FloroRanchCloseTaskResponse Create()
		{
			return new FloroRanchCloseTaskResponse();
		}

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x0600861E RID: 34334 RVA: 0x0014249A File Offset: 0x0014069A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x0600861F RID: 34335 RVA: 0x0014249D File Offset: 0x0014069D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchCloseTaskResponse.Descriptor;
			}
		}

		// Token: 0x06008620 RID: 34336 RVA: 0x001424A4 File Offset: 0x001406A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchCloseTaskResponse()
		{
		}

		// Token: 0x06008621 RID: 34337 RVA: 0x001424B7 File Offset: 0x001406B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchCloseTaskResponse(FloroRanchCloseTaskResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008622 RID: 34338 RVA: 0x001424ED File Offset: 0x001406ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchCloseTaskResponse Clone()
		{
			return new FloroRanchCloseTaskResponse(this);
		}

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x06008623 RID: 34339 RVA: 0x001424F5 File Offset: 0x001406F5
		// (set) Token: 0x06008624 RID: 34340 RVA: 0x001424FD File Offset: 0x001406FD
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

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x06008625 RID: 34341 RVA: 0x00142506 File Offset: 0x00140706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x06008626 RID: 34342 RVA: 0x0014250E File Offset: 0x0014070E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchCloseTaskResponse);
		}

		// Token: 0x06008627 RID: 34343 RVA: 0x0014251C File Offset: 0x0014071C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchCloseTaskResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008628 RID: 34344 RVA: 0x0014256C File Offset: 0x0014076C
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

		// Token: 0x06008629 RID: 34345 RVA: 0x001425BF File Offset: 0x001407BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600862A RID: 34346 RVA: 0x001425CC File Offset: 0x001407CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600862B RID: 34347 RVA: 0x001425D8 File Offset: 0x001407D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.task_.WriteTo(ref output, FloroRanchCloseTaskResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600862C RID: 34348 RVA: 0x00142628 File Offset: 0x00140828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.task_.CalculateSize(FloroRanchCloseTaskResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600862D RID: 34349 RVA: 0x0014267C File Offset: 0x0014087C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchCloseTaskResponse other)
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

		// Token: 0x0600862E RID: 34350 RVA: 0x001426C9 File Offset: 0x001408C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600862F RID: 34351 RVA: 0x001426D4 File Offset: 0x001408D4
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
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.task_.AddEntriesFrom(ref input, FloroRanchCloseTaskResponse._repeated_task_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400422E RID: 16942
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400422F RID: 16943
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04004230 RID: 16944
		private ErrorCode errorCode_;

		// Token: 0x04004231 RID: 16945
		public const int TaskFieldNumber = 10;

		// Token: 0x04004232 RID: 16946
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(82U, FloroRanchPlayTask.Parser);

		// Token: 0x04004233 RID: 16947
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();
	}
}
