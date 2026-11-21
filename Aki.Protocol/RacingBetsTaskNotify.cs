using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E68 RID: 3688
	[NetMessage(EMessageId.RacingBetsTaskNotify)]
	public sealed class RacingBetsTaskNotify : IMessage<RacingBetsTaskNotify>, IMessage, IEquatable<RacingBetsTaskNotify>, IDeepCloneable<RacingBetsTaskNotify>, IBufferMessage
	{
		// Token: 0x06013D74 RID: 81268 RVA: 0x002E45BE File Offset: 0x002E27BE
		[NullableContext(1)]
		public static RacingBetsTaskNotify Create()
		{
			return new RacingBetsTaskNotify();
		}

		// Token: 0x17004202 RID: 16898
		// (get) Token: 0x06013D75 RID: 81269 RVA: 0x002E45C5 File Offset: 0x002E27C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004203 RID: 16899
		// (get) Token: 0x06013D76 RID: 81270 RVA: 0x002E45C8 File Offset: 0x002E27C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsTaskNotify.Descriptor;
			}
		}

		// Token: 0x06013D77 RID: 81271 RVA: 0x002E45CF File Offset: 0x002E27CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskNotify()
		{
		}

		// Token: 0x06013D78 RID: 81272 RVA: 0x002E45E2 File Offset: 0x002E27E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskNotify(RacingBetsTaskNotify other) : this()
		{
			this.taskDatas_ = other.taskDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013D79 RID: 81273 RVA: 0x002E460C File Offset: 0x002E280C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTaskNotify Clone()
		{
			return new RacingBetsTaskNotify(this);
		}

		// Token: 0x17004204 RID: 16900
		// (get) Token: 0x06013D7A RID: 81274 RVA: 0x002E4614 File Offset: 0x002E2814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTaskData> TaskDatas
		{
			get
			{
				return this.taskDatas_;
			}
		}

		// Token: 0x06013D7B RID: 81275 RVA: 0x002E461C File Offset: 0x002E281C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsTaskNotify);
		}

		// Token: 0x06013D7C RID: 81276 RVA: 0x002E462A File Offset: 0x002E282A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsTaskNotify other)
		{
			return other != null && (other == this || (this.taskDatas_.Equals(other.taskDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013D7D RID: 81277 RVA: 0x002E4660 File Offset: 0x002E2860
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

		// Token: 0x06013D7E RID: 81278 RVA: 0x002E4694 File Offset: 0x002E2894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013D7F RID: 81279 RVA: 0x002E46A1 File Offset: 0x002E28A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013D80 RID: 81280 RVA: 0x002E46AA File Offset: 0x002E28AA
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

		// Token: 0x06013D81 RID: 81281 RVA: 0x002E46D4 File Offset: 0x002E28D4
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

		// Token: 0x06013D82 RID: 81282 RVA: 0x002E470D File Offset: 0x002E290D
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

		// Token: 0x06013D83 RID: 81283 RVA: 0x002E473B File Offset: 0x002E293B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013D84 RID: 81284 RVA: 0x002E4744 File Offset: 0x002E2944
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
					this.taskDatas_.AddEntriesFrom(ref input, RacingBetsTaskNotify._repeated_taskDatas_codec);
				}
			}
		}

		// Token: 0x040079D0 RID: 31184
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079D1 RID: 31185
		public const int TaskDatasFieldNumber = 14;

		// Token: 0x040079D2 RID: 31186
		private static readonly FieldCodec<ConditionTaskData> _repeated_taskDatas_codec = FieldCodec.ForMessage<ConditionTaskData>(114U, ConditionTaskData.Parser);

		// Token: 0x040079D3 RID: 31187
		private readonly RepeatedField<ConditionTaskData> taskDatas_ = new RepeatedField<ConditionTaskData>();
	}
}
