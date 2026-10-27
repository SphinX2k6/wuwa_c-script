using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A27 RID: 2599
	[NetMessage(EMessageId.MotorcycleTaskUpdateNotify)]
	public sealed class MotorcycleTaskUpdateNotify : IMessage<MotorcycleTaskUpdateNotify>, IMessage, IEquatable<MotorcycleTaskUpdateNotify>, IDeepCloneable<MotorcycleTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E32C RID: 58156 RVA: 0x0021408D File Offset: 0x0021228D
		[NullableContext(1)]
		public static MotorcycleTaskUpdateNotify Create()
		{
			return new MotorcycleTaskUpdateNotify();
		}

		// Token: 0x17002E11 RID: 11793
		// (get) Token: 0x0600E32D RID: 58157 RVA: 0x00214094 File Offset: 0x00212294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E12 RID: 11794
		// (get) Token: 0x0600E32E RID: 58158 RVA: 0x00214097 File Offset: 0x00212297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorcycleTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E32F RID: 58159 RVA: 0x0021409E File Offset: 0x0021229E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorcycleTaskUpdateNotify()
		{
		}

		// Token: 0x0600E330 RID: 58160 RVA: 0x002140A6 File Offset: 0x002122A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorcycleTaskUpdateNotify(MotorcycleTaskUpdateNotify other) : this()
		{
			this.task_ = ((other.task_ != null) ? other.task_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E331 RID: 58161 RVA: 0x002140DB File Offset: 0x002122DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorcycleTaskUpdateNotify Clone()
		{
			return new MotorcycleTaskUpdateNotify(this);
		}

		// Token: 0x17002E13 RID: 11795
		// (get) Token: 0x0600E332 RID: 58162 RVA: 0x002140E3 File Offset: 0x002122E3
		// (set) Token: 0x0600E333 RID: 58163 RVA: 0x002140EB File Offset: 0x002122EB
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

		// Token: 0x0600E334 RID: 58164 RVA: 0x002140F4 File Offset: 0x002122F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorcycleTaskUpdateNotify);
		}

		// Token: 0x0600E335 RID: 58165 RVA: 0x00214102 File Offset: 0x00212302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorcycleTaskUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Task, other.Task) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E336 RID: 58166 RVA: 0x00214138 File Offset: 0x00212338
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

		// Token: 0x0600E337 RID: 58167 RVA: 0x00214174 File Offset: 0x00212374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E338 RID: 58168 RVA: 0x00214181 File Offset: 0x00212381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E339 RID: 58169 RVA: 0x0021418A File Offset: 0x0021238A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.task_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Task);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E33A RID: 58170 RVA: 0x002141BC File Offset: 0x002123BC
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

		// Token: 0x0600E33B RID: 58171 RVA: 0x002141FC File Offset: 0x002123FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorcycleTaskUpdateNotify other)
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

		// Token: 0x0600E33C RID: 58172 RVA: 0x00214250 File Offset: 0x00212450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E33D RID: 58173 RVA: 0x0021425C File Offset: 0x0021245C
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
				if (num != 74U)
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

		// Token: 0x04005D26 RID: 23846
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D27 RID: 23847
		public const int TaskFieldNumber = 9;

		// Token: 0x04005D28 RID: 23848
		private ConditionTask task_;
	}
}
