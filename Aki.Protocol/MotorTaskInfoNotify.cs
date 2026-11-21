using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A92 RID: 2706
	[NetMessage(EMessageId.MotorTaskInfoNotify)]
	public sealed class MotorTaskInfoNotify : IMessage<MotorTaskInfoNotify>, IMessage, IEquatable<MotorTaskInfoNotify>, IDeepCloneable<MotorTaskInfoNotify>, IBufferMessage
	{
		// Token: 0x0600EBF7 RID: 60407 RVA: 0x00227A5A File Offset: 0x00225C5A
		[NullableContext(1)]
		public static MotorTaskInfoNotify Create()
		{
			return new MotorTaskInfoNotify();
		}

		// Token: 0x17002FEA RID: 12266
		// (get) Token: 0x0600EBF8 RID: 60408 RVA: 0x00227A61 File Offset: 0x00225C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FEB RID: 12267
		// (get) Token: 0x0600EBF9 RID: 60409 RVA: 0x00227A64 File Offset: 0x00225C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTaskInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600EBFA RID: 60410 RVA: 0x00227A6B File Offset: 0x00225C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskInfoNotify()
		{
		}

		// Token: 0x0600EBFB RID: 60411 RVA: 0x00227A7E File Offset: 0x00225C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskInfoNotify(MotorTaskInfoNotify other) : this()
		{
			this.taskTrees_ = other.taskTrees_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EBFC RID: 60412 RVA: 0x00227AA8 File Offset: 0x00225CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskInfoNotify Clone()
		{
			return new MotorTaskInfoNotify(this);
		}

		// Token: 0x17002FEC RID: 12268
		// (get) Token: 0x0600EBFD RID: 60413 RVA: 0x00227AB0 File Offset: 0x00225CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorTaskTreePb> TaskTrees
		{
			get
			{
				return this.taskTrees_;
			}
		}

		// Token: 0x0600EBFE RID: 60414 RVA: 0x00227AB8 File Offset: 0x00225CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTaskInfoNotify);
		}

		// Token: 0x0600EBFF RID: 60415 RVA: 0x00227AC6 File Offset: 0x00225CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTaskInfoNotify other)
		{
			return other != null && (other == this || (this.taskTrees_.Equals(other.taskTrees_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EC00 RID: 60416 RVA: 0x00227AFC File Offset: 0x00225CFC
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

		// Token: 0x0600EC01 RID: 60417 RVA: 0x00227B30 File Offset: 0x00225D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EC02 RID: 60418 RVA: 0x00227B3D File Offset: 0x00225D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EC03 RID: 60419 RVA: 0x00227B46 File Offset: 0x00225D46
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

		// Token: 0x0600EC04 RID: 60420 RVA: 0x00227B70 File Offset: 0x00225D70
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

		// Token: 0x0600EC05 RID: 60421 RVA: 0x00227BA9 File Offset: 0x00225DA9
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

		// Token: 0x0600EC06 RID: 60422 RVA: 0x00227BD7 File Offset: 0x00225DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EC07 RID: 60423 RVA: 0x00227BE0 File Offset: 0x00225DE0
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

		// Token: 0x04006018 RID: 24600
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006019 RID: 24601
		public const int TaskTreesFieldNumber = 14;

		// Token: 0x0400601A RID: 24602
		private static readonly FieldCodec<MotorTaskTreePb> _repeated_taskTrees_codec = FieldCodec.ForMessage<MotorTaskTreePb>(114U, MotorTaskTreePb.Parser);

		// Token: 0x0400601B RID: 24603
		private readonly RepeatedField<MotorTaskTreePb> taskTrees_ = new RepeatedField<MotorTaskTreePb>();
	}
}
