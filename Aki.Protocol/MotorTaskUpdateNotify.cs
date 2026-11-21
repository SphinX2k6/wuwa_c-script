using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A99 RID: 2713
	[NetMessage(EMessageId.MotorTaskUpdateNotify)]
	public sealed class MotorTaskUpdateNotify : IMessage<MotorTaskUpdateNotify>, IMessage, IEquatable<MotorTaskUpdateNotify>, IDeepCloneable<MotorTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600EC8C RID: 60556 RVA: 0x00228F34 File Offset: 0x00227134
		[NullableContext(1)]
		public static MotorTaskUpdateNotify Create()
		{
			return new MotorTaskUpdateNotify();
		}

		// Token: 0x1700300B RID: 12299
		// (get) Token: 0x0600EC8D RID: 60557 RVA: 0x00228F3B File Offset: 0x0022713B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700300C RID: 12300
		// (get) Token: 0x0600EC8E RID: 60558 RVA: 0x00228F3E File Offset: 0x0022713E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600EC8F RID: 60559 RVA: 0x00228F45 File Offset: 0x00227145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskUpdateNotify()
		{
		}

		// Token: 0x0600EC90 RID: 60560 RVA: 0x00228F58 File Offset: 0x00227158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskUpdateNotify(MotorTaskUpdateNotify other) : this()
		{
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EC91 RID: 60561 RVA: 0x00228F82 File Offset: 0x00227182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskUpdateNotify Clone()
		{
			return new MotorTaskUpdateNotify(this);
		}

		// Token: 0x1700300D RID: 12301
		// (get) Token: 0x0600EC92 RID: 60562 RVA: 0x00228F8A File Offset: 0x0022718A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorTaskPb> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x0600EC93 RID: 60563 RVA: 0x00228F92 File Offset: 0x00227192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTaskUpdateNotify);
		}

		// Token: 0x0600EC94 RID: 60564 RVA: 0x00228FA0 File Offset: 0x002271A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EC95 RID: 60565 RVA: 0x00228FD4 File Offset: 0x002271D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.task_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EC96 RID: 60566 RVA: 0x00229008 File Offset: 0x00227208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EC97 RID: 60567 RVA: 0x00229015 File Offset: 0x00227215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EC98 RID: 60568 RVA: 0x0022901E File Offset: 0x0022721E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.task_.WriteTo(ref output, MotorTaskUpdateNotify._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EC99 RID: 60569 RVA: 0x00229048 File Offset: 0x00227248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.task_.CalculateSize(MotorTaskUpdateNotify._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EC9A RID: 60570 RVA: 0x00229081 File Offset: 0x00227281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.task_.Add(other.task_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EC9B RID: 60571 RVA: 0x002290AF File Offset: 0x002272AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EC9C RID: 60572 RVA: 0x002290B8 File Offset: 0x002272B8
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
					this.task_.AddEntriesFrom(ref input, MotorTaskUpdateNotify._repeated_task_codec);
				}
			}
		}

		// Token: 0x04006046 RID: 24646
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006047 RID: 24647
		public const int TaskFieldNumber = 6;

		// Token: 0x04006048 RID: 24648
		private static readonly FieldCodec<MotorTaskPb> _repeated_task_codec = FieldCodec.ForMessage<MotorTaskPb>(50U, MotorTaskPb.Parser);

		// Token: 0x04006049 RID: 24649
		private readonly RepeatedField<MotorTaskPb> task_ = new RepeatedField<MotorTaskPb>();
	}
}
