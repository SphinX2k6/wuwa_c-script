using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E9 RID: 745
	[NetMessage(EMessageId.ConsumptiveTaskInfoNotify)]
	public sealed class ConsumptiveTaskInfoNotify : IMessage<ConsumptiveTaskInfoNotify>, IMessage, IEquatable<ConsumptiveTaskInfoNotify>, IDeepCloneable<ConsumptiveTaskInfoNotify>, IBufferMessage
	{
		// Token: 0x06004BBD RID: 19389 RVA: 0x000B88C0 File Offset: 0x000B6AC0
		[NullableContext(1)]
		public static ConsumptiveTaskInfoNotify Create()
		{
			return new ConsumptiveTaskInfoNotify();
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06004BBE RID: 19390 RVA: 0x000B88C7 File Offset: 0x000B6AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06004BBF RID: 19391 RVA: 0x000B88CA File Offset: 0x000B6ACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveTaskInfoNotify.Descriptor;
			}
		}

		// Token: 0x06004BC0 RID: 19392 RVA: 0x000B88D1 File Offset: 0x000B6AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskInfoNotify()
		{
		}

		// Token: 0x06004BC1 RID: 19393 RVA: 0x000B88D9 File Offset: 0x000B6AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskInfoNotify(ConsumptiveTaskInfoNotify other) : this()
		{
			this.consumptiveTaskInfo_ = ((other.consumptiveTaskInfo_ != null) ? other.consumptiveTaskInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x000B890E File Offset: 0x000B6B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskInfoNotify Clone()
		{
			return new ConsumptiveTaskInfoNotify(this);
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06004BC3 RID: 19395 RVA: 0x000B8916 File Offset: 0x000B6B16
		// (set) Token: 0x06004BC4 RID: 19396 RVA: 0x000B891E File Offset: 0x000B6B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskInfo ConsumptiveTaskInfo
		{
			get
			{
				return this.consumptiveTaskInfo_;
			}
			set
			{
				this.consumptiveTaskInfo_ = value;
			}
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x000B8927 File Offset: 0x000B6B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveTaskInfoNotify);
		}

		// Token: 0x06004BC6 RID: 19398 RVA: 0x000B8935 File Offset: 0x000B6B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveTaskInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ConsumptiveTaskInfo, other.ConsumptiveTaskInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004BC7 RID: 19399 RVA: 0x000B8968 File Offset: 0x000B6B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.consumptiveTaskInfo_ != null)
			{
				num ^= this.ConsumptiveTaskInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004BC8 RID: 19400 RVA: 0x000B89A4 File Offset: 0x000B6BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004BC9 RID: 19401 RVA: 0x000B89B1 File Offset: 0x000B6BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004BCA RID: 19402 RVA: 0x000B89BA File Offset: 0x000B6BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.consumptiveTaskInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ConsumptiveTaskInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x000B89EC File Offset: 0x000B6BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.consumptiveTaskInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ConsumptiveTaskInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004BCC RID: 19404 RVA: 0x000B8A2C File Offset: 0x000B6C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveTaskInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.consumptiveTaskInfo_ != null)
			{
				if (this.consumptiveTaskInfo_ == null)
				{
					this.ConsumptiveTaskInfo = new ConsumptiveTaskInfo();
				}
				this.ConsumptiveTaskInfo.MergeFrom(other.ConsumptiveTaskInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004BCD RID: 19405 RVA: 0x000B8A80 File Offset: 0x000B6C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BCE RID: 19406 RVA: 0x000B8A8C File Offset: 0x000B6C8C
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.consumptiveTaskInfo_ == null)
					{
						this.ConsumptiveTaskInfo = new ConsumptiveTaskInfo();
					}
					input.ReadMessage(this.ConsumptiveTaskInfo);
				}
			}
		}

		// Token: 0x040030CD RID: 12493
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030CE RID: 12494
		public const int ConsumptiveTaskInfoFieldNumber = 1;

		// Token: 0x040030CF RID: 12495
		private ConsumptiveTaskInfo consumptiveTaskInfo_;
	}
}
