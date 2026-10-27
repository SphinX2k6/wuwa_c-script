using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA3 RID: 2723
	[NetMessage(EMessageId.MotorTaskInfoNotify)]
	public sealed class MotorTaskInfoNotify : IMessage<MotorTaskInfoNotify>, IMessage, IEquatable<MotorTaskInfoNotify>, IDeepCloneable<MotorTaskInfoNotify>, IBufferMessage
	{
		// Token: 0x0600ED11 RID: 60689 RVA: 0x00229C56 File Offset: 0x00227E56
		[NullableContext(1)]
		public static MotorTaskInfoNotify Create()
		{
			return new MotorTaskInfoNotify();
		}

		// Token: 0x17003028 RID: 12328
		// (get) Token: 0x0600ED12 RID: 60690 RVA: 0x00229C5D File Offset: 0x00227E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003029 RID: 12329
		// (get) Token: 0x0600ED13 RID: 60691 RVA: 0x00229C60 File Offset: 0x00227E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTaskInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600ED14 RID: 60692 RVA: 0x00229C67 File Offset: 0x00227E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskInfoNotify()
		{
		}

		// Token: 0x0600ED15 RID: 60693 RVA: 0x00229C7A File Offset: 0x00227E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskInfoNotify(MotorTaskInfoNotify other) : this()
		{
			this.taskTrees_ = other.taskTrees_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ED16 RID: 60694 RVA: 0x00229CA4 File Offset: 0x00227EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskInfoNotify Clone()
		{
			return new MotorTaskInfoNotify(this);
		}

		// Token: 0x1700302A RID: 12330
		// (get) Token: 0x0600ED17 RID: 60695 RVA: 0x00229CAC File Offset: 0x00227EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorTaskTreePb> TaskTrees
		{
			get
			{
				return this.taskTrees_;
			}
		}

		// Token: 0x0600ED18 RID: 60696 RVA: 0x00229CB4 File Offset: 0x00227EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTaskInfoNotify);
		}

		// Token: 0x0600ED19 RID: 60697 RVA: 0x00229CC2 File Offset: 0x00227EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTaskInfoNotify other)
		{
			return other != null && (other == this || (this.taskTrees_.Equals(other.taskTrees_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ED1A RID: 60698 RVA: 0x00229CF8 File Offset: 0x00227EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskTrees_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ED1B RID: 60699 RVA: 0x00229D2C File Offset: 0x00227F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ED1C RID: 60700 RVA: 0x00229D39 File Offset: 0x00227F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ED1D RID: 60701 RVA: 0x00229D42 File Offset: 0x00227F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskTrees_.WriteTo(ref output, MotorTaskInfoNotify._repeated_taskTrees_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ED1E RID: 60702 RVA: 0x00229D6C File Offset: 0x00227F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskTrees_.CalculateSize(MotorTaskInfoNotify._repeated_taskTrees_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ED1F RID: 60703 RVA: 0x00229DA5 File Offset: 0x00227FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTaskInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.taskTrees_.Add(other.taskTrees_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ED20 RID: 60704 RVA: 0x00229DD3 File Offset: 0x00227FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ED21 RID: 60705 RVA: 0x00229DDC File Offset: 0x00227FDC
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskTrees_.AddEntriesFrom(ref input, MotorTaskInfoNotify._repeated_taskTrees_codec);
				}
			}
		}

		// Token: 0x0400600F RID: 24591
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006010 RID: 24592
		public const int TaskTreesFieldNumber = 14;

		// Token: 0x04006011 RID: 24593
		private static readonly FieldCodec<MotorTaskTreePb> _repeated_taskTrees_codec = FieldCodec.ForMessage<MotorTaskTreePb>(114U, MotorTaskTreePb.Parser);

		// Token: 0x04006012 RID: 24594
		private readonly RepeatedField<MotorTaskTreePb> taskTrees_ = new RepeatedField<MotorTaskTreePb>();
	}
}
