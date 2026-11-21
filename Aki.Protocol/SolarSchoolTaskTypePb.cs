using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012CE RID: 4814
	public sealed class SolarSchoolTaskTypePb : IMessage<SolarSchoolTaskTypePb>, IMessage, IEquatable<SolarSchoolTaskTypePb>, IDeepCloneable<SolarSchoolTaskTypePb>, IBufferMessage
	{
		// Token: 0x06019B26 RID: 105254 RVA: 0x003BFE23 File Offset: 0x003BE023
		[NullableContext(1)]
		public static SolarSchoolTaskTypePb Create()
		{
			return new SolarSchoolTaskTypePb();
		}

		// Token: 0x17005706 RID: 22278
		// (get) Token: 0x06019B27 RID: 105255 RVA: 0x003BFE2A File Offset: 0x003BE02A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SolarSchoolTaskTypePb> Parser
		{
			get
			{
				return SolarSchoolTaskTypePb._parser;
			}
		}

		// Token: 0x17005707 RID: 22279
		// (get) Token: 0x06019B28 RID: 105256 RVA: 0x003BFE31 File Offset: 0x003BE031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005708 RID: 22280
		// (get) Token: 0x06019B29 RID: 105257 RVA: 0x003BFE34 File Offset: 0x003BE034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolTaskTypePb.Descriptor;
			}
		}

		// Token: 0x06019B2A RID: 105258 RVA: 0x003BFE3B File Offset: 0x003BE03B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTaskTypePb()
		{
		}

		// Token: 0x06019B2B RID: 105259 RVA: 0x003BFE4E File Offset: 0x003BE04E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTaskTypePb(SolarSchoolTaskTypePb other) : this()
		{
			this.taskType_ = other.taskType_;
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019B2C RID: 105260 RVA: 0x003BFE84 File Offset: 0x003BE084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTaskTypePb Clone()
		{
			return new SolarSchoolTaskTypePb(this);
		}

		// Token: 0x17005709 RID: 22281
		// (get) Token: 0x06019B2D RID: 105261 RVA: 0x003BFE8C File Offset: 0x003BE08C
		// (set) Token: 0x06019B2E RID: 105262 RVA: 0x003BFE94 File Offset: 0x003BE094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTaskType TaskType
		{
			get
			{
				return this.taskType_;
			}
			set
			{
				this.taskType_ = value;
			}
		}

		// Token: 0x1700570A RID: 22282
		// (get) Token: 0x06019B2F RID: 105263 RVA: 0x003BFE9D File Offset: 0x003BE09D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x06019B30 RID: 105264 RVA: 0x003BFEA5 File Offset: 0x003BE0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolTaskTypePb);
		}

		// Token: 0x06019B31 RID: 105265 RVA: 0x003BFEB4 File Offset: 0x003BE0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolTaskTypePb other)
		{
			return other != null && (other == this || (this.TaskType == other.TaskType && this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019B32 RID: 105266 RVA: 0x003BFF04 File Offset: 0x003BE104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskType != SolarSchoolTaskType.SolarSchoolResident)
			{
				num ^= this.TaskType.GetHashCode();
			}
			num ^= this.task_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019B33 RID: 105267 RVA: 0x003BFF57 File Offset: 0x003BE157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019B34 RID: 105268 RVA: 0x003BFF64 File Offset: 0x003BE164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019B35 RID: 105269 RVA: 0x003BFF70 File Offset: 0x003BE170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskType != SolarSchoolTaskType.SolarSchoolResident)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.TaskType);
			}
			this.task_.WriteTo(ref output, SolarSchoolTaskTypePb._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019B36 RID: 105270 RVA: 0x003BFFC0 File Offset: 0x003BE1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskType != SolarSchoolTaskType.SolarSchoolResident)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TaskType);
			}
			num += this.task_.CalculateSize(SolarSchoolTaskTypePb._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019B37 RID: 105271 RVA: 0x003C0014 File Offset: 0x003BE214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolTaskTypePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskType != SolarSchoolTaskType.SolarSchoolResident)
			{
				this.TaskType = other.TaskType;
			}
			this.task_.Add(other.task_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019B38 RID: 105272 RVA: 0x003C0061 File Offset: 0x003BE261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019B39 RID: 105273 RVA: 0x003C006C File Offset: 0x003BE26C
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.task_.AddEntriesFrom(ref input, SolarSchoolTaskTypePb._repeated_task_codec);
					}
				}
				else
				{
					this.TaskType = (SolarSchoolTaskType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040097C9 RID: 38857
		private static readonly MessageParser<SolarSchoolTaskTypePb> _parser = new MessageParser<SolarSchoolTaskTypePb>(() => new SolarSchoolTaskTypePb());

		// Token: 0x040097CA RID: 38858
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097CB RID: 38859
		public const int TaskTypeFieldNumber = 1;

		// Token: 0x040097CC RID: 38860
		private SolarSchoolTaskType taskType_;

		// Token: 0x040097CD RID: 38861
		public const int TaskFieldNumber = 2;

		// Token: 0x040097CE RID: 38862
		private static readonly FieldCodec<ConditionTask> _repeated_task_codec = FieldCodec.ForMessage<ConditionTask>(18U, ConditionTask.Parser);

		// Token: 0x040097CF RID: 38863
		private readonly RepeatedField<ConditionTask> task_ = new RepeatedField<ConditionTask>();
	}
}
