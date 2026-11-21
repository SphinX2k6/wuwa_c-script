using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A16 RID: 2582
	[NetMessage(EMessageId.MotorcycleTaskUpdateNotify)]
	public sealed class MotorcycleTaskUpdateNotify : IMessage<MotorcycleTaskUpdateNotify>, IMessage, IEquatable<MotorcycleTaskUpdateNotify>, IDeepCloneable<MotorcycleTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E212 RID: 57874 RVA: 0x00211E99 File Offset: 0x00210099
		[NullableContext(1)]
		public static MotorcycleTaskUpdateNotify Create()
		{
			return new MotorcycleTaskUpdateNotify();
		}

		// Token: 0x17002DD3 RID: 11731
		// (get) Token: 0x0600E213 RID: 57875 RVA: 0x00211EA0 File Offset: 0x002100A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DD4 RID: 11732
		// (get) Token: 0x0600E214 RID: 57876 RVA: 0x00211EA3 File Offset: 0x002100A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorcycleTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E215 RID: 57877 RVA: 0x00211EAA File Offset: 0x002100AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorcycleTaskUpdateNotify()
		{
		}

		// Token: 0x0600E216 RID: 57878 RVA: 0x00211EB2 File Offset: 0x002100B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorcycleTaskUpdateNotify(MotorcycleTaskUpdateNotify other) : this()
		{
			this.task_ = ((other.task_ != null) ? other.task_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E217 RID: 57879 RVA: 0x00211EE7 File Offset: 0x002100E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorcycleTaskUpdateNotify Clone()
		{
			return new MotorcycleTaskUpdateNotify(this);
		}

		// Token: 0x17002DD5 RID: 11733
		// (get) Token: 0x0600E218 RID: 57880 RVA: 0x00211EEF File Offset: 0x002100EF
		// (set) Token: 0x0600E219 RID: 57881 RVA: 0x00211EF7 File Offset: 0x002100F7
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

		// Token: 0x0600E21A RID: 57882 RVA: 0x00211F00 File Offset: 0x00210100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorcycleTaskUpdateNotify);
		}

		// Token: 0x0600E21B RID: 57883 RVA: 0x00211F0E File Offset: 0x0021010E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorcycleTaskUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Task, other.Task) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E21C RID: 57884 RVA: 0x00211F44 File Offset: 0x00210144
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

		// Token: 0x0600E21D RID: 57885 RVA: 0x00211F80 File Offset: 0x00210180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E21E RID: 57886 RVA: 0x00211F8D File Offset: 0x0021018D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E21F RID: 57887 RVA: 0x00211F96 File Offset: 0x00210196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.task_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Task);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E220 RID: 57888 RVA: 0x00211FC8 File Offset: 0x002101C8
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

		// Token: 0x0600E221 RID: 57889 RVA: 0x00212008 File Offset: 0x00210208
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

		// Token: 0x0600E222 RID: 57890 RVA: 0x0021205C File Offset: 0x0021025C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E223 RID: 57891 RVA: 0x00212068 File Offset: 0x00210268
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
				if (num != 42U)
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

		// Token: 0x04005D2F RID: 23855
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D30 RID: 23856
		public const int TaskFieldNumber = 5;

		// Token: 0x04005D31 RID: 23857
		private ConditionTask task_;
	}
}
