using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E78 RID: 3704
	[NetMessage(EMessageId.RacingBetsTaskNotify)]
	public sealed class RacingBetsTaskNotify : IMessage<RacingBetsTaskNotify>, IMessage, IEquatable<RacingBetsTaskNotify>, IDeepCloneable<RacingBetsTaskNotify>, IBufferMessage
	{
		// Token: 0x06013E59 RID: 81497 RVA: 0x002E5C7E File Offset: 0x002E3E7E
		[NullableContext(1)]
		public static RacingBetsTaskNotify Create()
		{
			return new RacingBetsTaskNotify();
		}

		// Token: 0x1700422C RID: 16940
		// (get) Token: 0x06013E5A RID: 81498 RVA: 0x002E5C85 File Offset: 0x002E3E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700422D RID: 16941
		// (get) Token: 0x06013E5B RID: 81499 RVA: 0x002E5C88 File Offset: 0x002E3E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsTaskNotify.Descriptor;
			}
		}

		// Token: 0x06013E5C RID: 81500 RVA: 0x002E5C8F File Offset: 0x002E3E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskNotify()
		{
		}

		// Token: 0x06013E5D RID: 81501 RVA: 0x002E5CA2 File Offset: 0x002E3EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskNotify(RacingBetsTaskNotify other) : this()
		{
			this.taskDatas_ = other.taskDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013E5E RID: 81502 RVA: 0x002E5CCC File Offset: 0x002E3ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskNotify Clone()
		{
			return new RacingBetsTaskNotify(this);
		}

		// Token: 0x1700422E RID: 16942
		// (get) Token: 0x06013E5F RID: 81503 RVA: 0x002E5CD4 File Offset: 0x002E3ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTaskData> TaskDatas
		{
			get
			{
				return this.taskDatas_;
			}
		}

		// Token: 0x06013E60 RID: 81504 RVA: 0x002E5CDC File Offset: 0x002E3EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsTaskNotify);
		}

		// Token: 0x06013E61 RID: 81505 RVA: 0x002E5CEA File Offset: 0x002E3EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsTaskNotify other)
		{
			return other != null && (other == this || (this.taskDatas_.Equals(other.taskDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013E62 RID: 81506 RVA: 0x002E5D20 File Offset: 0x002E3F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013E63 RID: 81507 RVA: 0x002E5D54 File Offset: 0x002E3F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013E64 RID: 81508 RVA: 0x002E5D61 File Offset: 0x002E3F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013E65 RID: 81509 RVA: 0x002E5D6A File Offset: 0x002E3F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskDatas_.WriteTo(ref output, RacingBetsTaskNotify._repeated_taskDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013E66 RID: 81510 RVA: 0x002E5D94 File Offset: 0x002E3F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskDatas_.CalculateSize(RacingBetsTaskNotify._repeated_taskDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013E67 RID: 81511 RVA: 0x002E5DCD File Offset: 0x002E3FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsTaskNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.taskDatas_.Add(other.taskDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013E68 RID: 81512 RVA: 0x002E5DFB File Offset: 0x002E3FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013E69 RID: 81513 RVA: 0x002E5E04 File Offset: 0x002E4004
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskDatas_.AddEntriesFrom(ref input, RacingBetsTaskNotify._repeated_taskDatas_codec);
				}
			}
		}

		// Token: 0x040079A6 RID: 31142
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079A7 RID: 31143
		public const int TaskDatasFieldNumber = 8;

		// Token: 0x040079A8 RID: 31144
		private static readonly FieldCodec<ConditionTaskData> _repeated_taskDatas_codec = FieldCodec.ForMessage<ConditionTaskData>(66U, ConditionTaskData.Parser);

		// Token: 0x040079A9 RID: 31145
		private readonly RepeatedField<ConditionTaskData> taskDatas_ = new RepeatedField<ConditionTaskData>();
	}
}
