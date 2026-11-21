using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013CC RID: 5068
	[NetMessage(EMessageId.ThemeCeleWuWuTaskNotify)]
	public sealed class ThemeCeleWuWuTaskNotify : IMessage<ThemeCeleWuWuTaskNotify>, IMessage, IEquatable<ThemeCeleWuWuTaskNotify>, IDeepCloneable<ThemeCeleWuWuTaskNotify>, IBufferMessage
	{
		// Token: 0x0601AF92 RID: 110482 RVA: 0x003EDDF1 File Offset: 0x003EBFF1
		[NullableContext(1)]
		public static ThemeCeleWuWuTaskNotify Create()
		{
			return new ThemeCeleWuWuTaskNotify();
		}

		// Token: 0x17005B60 RID: 23392
		// (get) Token: 0x0601AF93 RID: 110483 RVA: 0x003EDDF8 File Offset: 0x003EBFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B61 RID: 23393
		// (get) Token: 0x0601AF94 RID: 110484 RVA: 0x003EDDFB File Offset: 0x003EBFFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThemeCeleWuWuTaskNotify.Descriptor;
			}
		}

		// Token: 0x0601AF95 RID: 110485 RVA: 0x003EDE02 File Offset: 0x003EC002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeCeleWuWuTaskNotify()
		{
		}

		// Token: 0x0601AF96 RID: 110486 RVA: 0x003EDE0A File Offset: 0x003EC00A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeCeleWuWuTaskNotify(ThemeCeleWuWuTaskNotify other) : this()
		{
			this.task_ = ((other.task_ != null) ? other.task_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AF97 RID: 110487 RVA: 0x003EDE3F File Offset: 0x003EC03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeCeleWuWuTaskNotify Clone()
		{
			return new ThemeCeleWuWuTaskNotify(this);
		}

		// Token: 0x17005B62 RID: 23394
		// (get) Token: 0x0601AF98 RID: 110488 RVA: 0x003EDE47 File Offset: 0x003EC047
		// (set) Token: 0x0601AF99 RID: 110489 RVA: 0x003EDE4F File Offset: 0x003EC04F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask Task
		{
			get
			{
				return this.task_;
			}
			set
			{
				this.task_ = value;
			}
		}

		// Token: 0x0601AF9A RID: 110490 RVA: 0x003EDE58 File Offset: 0x003EC058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThemeCeleWuWuTaskNotify);
		}

		// Token: 0x0601AF9B RID: 110491 RVA: 0x003EDE66 File Offset: 0x003EC066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThemeCeleWuWuTaskNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Task, other.Task) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AF9C RID: 110492 RVA: 0x003EDE9C File Offset: 0x003EC09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.task_ != null)
			{
				num ^= this.Task.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AF9D RID: 110493 RVA: 0x003EDED8 File Offset: 0x003EC0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AF9E RID: 110494 RVA: 0x003EDEE5 File Offset: 0x003EC0E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AF9F RID: 110495 RVA: 0x003EDEEE File Offset: 0x003EC0EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.task_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Task);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AFA0 RID: 110496 RVA: 0x003EDF20 File Offset: 0x003EC120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.task_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Task);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AFA1 RID: 110497 RVA: 0x003EDF60 File Offset: 0x003EC160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThemeCeleWuWuTaskNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.task_ != null)
			{
				if (this.task_ == null)
				{
					this.Task = new ConditionTask();
				}
				this.Task.MergeFrom(other.Task);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AFA2 RID: 110498 RVA: 0x003EDFB4 File Offset: 0x003EC1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AFA3 RID: 110499 RVA: 0x003EDFC0 File Offset: 0x003EC1C0
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.task_ == null)
					{
						this.Task = new ConditionTask();
					}
					input.ReadMessage(this.Task);
				}
			}
		}

		// Token: 0x04009DB9 RID: 40377
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DBA RID: 40378
		public const int TaskFieldNumber = 13;

		// Token: 0x04009DBB RID: 40379
		private ConditionTask task_;
	}
}
