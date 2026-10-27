using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A7 RID: 423
	public sealed class BlackCoastThemeStageInfo : IMessage<BlackCoastThemeStageInfo>, IMessage, IEquatable<BlackCoastThemeStageInfo>, IDeepCloneable<BlackCoastThemeStageInfo>, IBufferMessage
	{
		// Token: 0x060031A8 RID: 12712 RVA: 0x0007E846 File Offset: 0x0007CA46
		[NullableContext(1)]
		public static BlackCoastThemeStageInfo Create()
		{
			return new BlackCoastThemeStageInfo();
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060031A9 RID: 12713 RVA: 0x0007E84D File Offset: 0x0007CA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BlackCoastThemeStageInfo> Parser
		{
			get
			{
				return BlackCoastThemeStageInfo._parser;
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x060031AA RID: 12714 RVA: 0x0007E854 File Offset: 0x0007CA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060031AB RID: 12715 RVA: 0x0007E857 File Offset: 0x0007CA57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackCoastThemeStageInfo.Descriptor;
			}
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x0007E85E File Offset: 0x0007CA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeStageInfo()
		{
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x0007E871 File Offset: 0x0007CA71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeStageInfo(BlackCoastThemeStageInfo other) : this()
		{
			this.id_ = other.id_;
			this.tasks_ = other.tasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060031AE RID: 12718 RVA: 0x0007E8A7 File Offset: 0x0007CAA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeStageInfo Clone()
		{
			return new BlackCoastThemeStageInfo(this);
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060031AF RID: 12719 RVA: 0x0007E8AF File Offset: 0x0007CAAF
		// (set) Token: 0x060031B0 RID: 12720 RVA: 0x0007E8B7 File Offset: 0x0007CAB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x060031B1 RID: 12721 RVA: 0x0007E8C0 File Offset: 0x0007CAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x0007E8C8 File Offset: 0x0007CAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackCoastThemeStageInfo);
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x0007E8D8 File Offset: 0x0007CAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackCoastThemeStageInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.tasks_.Equals(other.tasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x0007E928 File Offset: 0x0007CB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.tasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x0007E975 File Offset: 0x0007CB75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060031B6 RID: 12726 RVA: 0x0007E982 File Offset: 0x0007CB82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x0007E98C File Offset: 0x0007CB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			this.tasks_.WriteTo(ref output, BlackCoastThemeStageInfo._repeated_tasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x0007E9DC File Offset: 0x0007CBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.tasks_.CalculateSize(BlackCoastThemeStageInfo._repeated_tasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x0007EA30 File Offset: 0x0007CC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackCoastThemeStageInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.tasks_.Add(other.tasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x0007EA7D File Offset: 0x0007CC7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x0007EA88 File Offset: 0x0007CC88
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
						this.tasks_.AddEntriesFrom(ref input, BlackCoastThemeStageInfo._repeated_tasks_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002944 RID: 10564
		private static readonly MessageParser<BlackCoastThemeStageInfo> _parser = new MessageParser<BlackCoastThemeStageInfo>(() => new BlackCoastThemeStageInfo());

		// Token: 0x04002945 RID: 10565
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002946 RID: 10566
		public const int IdFieldNumber = 1;

		// Token: 0x04002947 RID: 10567
		private int id_;

		// Token: 0x04002948 RID: 10568
		public const int TasksFieldNumber = 2;

		// Token: 0x04002949 RID: 10569
		private static readonly FieldCodec<ActivityTask> _repeated_tasks_codec = FieldCodec.ForMessage<ActivityTask>(18U, ActivityTask.Parser);

		// Token: 0x0400294A RID: 10570
		private readonly RepeatedField<ActivityTask> tasks_ = new RepeatedField<ActivityTask>();
	}
}
