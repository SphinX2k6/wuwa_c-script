using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B8F RID: 2959
	public sealed class OnlineMotorTaskUpdate : IMessage<OnlineMotorTaskUpdate>, IMessage, IEquatable<OnlineMotorTaskUpdate>, IDeepCloneable<OnlineMotorTaskUpdate>, IBufferMessage
	{
		// Token: 0x06010121 RID: 65825 RVA: 0x0025917C File Offset: 0x0025737C
		[NullableContext(1)]
		public static OnlineMotorTaskUpdate Create()
		{
			return new OnlineMotorTaskUpdate();
		}

		// Token: 0x170034AB RID: 13483
		// (get) Token: 0x06010122 RID: 65826 RVA: 0x00259183 File Offset: 0x00257383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034AC RID: 13484
		// (get) Token: 0x06010123 RID: 65827 RVA: 0x00259186 File Offset: 0x00257386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorTaskUpdate.Descriptor;
			}
		}

		// Token: 0x06010124 RID: 65828 RVA: 0x0025918D File Offset: 0x0025738D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorTaskUpdate()
		{
		}

		// Token: 0x06010125 RID: 65829 RVA: 0x002591AB File Offset: 0x002573AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorTaskUpdate(OnlineMotorTaskUpdate other) : this()
		{
			this.levelTasks_ = other.levelTasks_.Clone();
			this.globalTasks_ = other.globalTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010126 RID: 65830 RVA: 0x002591E6 File Offset: 0x002573E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorTaskUpdate Clone()
		{
			return new OnlineMotorTaskUpdate(this);
		}

		// Token: 0x170034AD RID: 13485
		// (get) Token: 0x06010127 RID: 65831 RVA: 0x002591EE File Offset: 0x002573EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnlineMotorTask> LevelTasks
		{
			get
			{
				return this.levelTasks_;
			}
		}

		// Token: 0x170034AE RID: 13486
		// (get) Token: 0x06010128 RID: 65832 RVA: 0x002591F6 File Offset: 0x002573F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnlineMotorTask> GlobalTasks
		{
			get
			{
				return this.globalTasks_;
			}
		}

		// Token: 0x06010129 RID: 65833 RVA: 0x002591FE File Offset: 0x002573FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorTaskUpdate);
		}

		// Token: 0x0601012A RID: 65834 RVA: 0x0025920C File Offset: 0x0025740C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorTaskUpdate other)
		{
			return other != null && (other == this || (this.levelTasks_.Equals(other.levelTasks_) && this.globalTasks_.Equals(other.globalTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601012B RID: 65835 RVA: 0x00259260 File Offset: 0x00257460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.levelTasks_.GetHashCode();
			num ^= this.globalTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601012C RID: 65836 RVA: 0x002592A2 File Offset: 0x002574A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601012D RID: 65837 RVA: 0x002592AF File Offset: 0x002574AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601012E RID: 65838 RVA: 0x002592B8 File Offset: 0x002574B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.levelTasks_.WriteTo(ref output, OnlineMotorTaskUpdate._repeated_levelTasks_codec);
			this.globalTasks_.WriteTo(ref output, OnlineMotorTaskUpdate._repeated_globalTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601012F RID: 65839 RVA: 0x002592F0 File Offset: 0x002574F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.levelTasks_.CalculateSize(OnlineMotorTaskUpdate._repeated_levelTasks_codec);
			num += this.globalTasks_.CalculateSize(OnlineMotorTaskUpdate._repeated_globalTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010130 RID: 65840 RVA: 0x0025933C File Offset: 0x0025753C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OnlineMotorTaskUpdate other)
		{
			if (other == null)
			{
				return;
			}
			this.levelTasks_.Add(other.levelTasks_);
			this.globalTasks_.Add(other.globalTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010131 RID: 65841 RVA: 0x0025937B File Offset: 0x0025757B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010132 RID: 65842 RVA: 0x00259384 File Offset: 0x00257584
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.globalTasks_.AddEntriesFrom(ref input, OnlineMotorTaskUpdate._repeated_globalTasks_codec);
					}
				}
				else
				{
					this.levelTasks_.AddEntriesFrom(ref input, OnlineMotorTaskUpdate._repeated_levelTasks_codec);
				}
			}
		}

		// Token: 0x040066E6 RID: 26342
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066E7 RID: 26343
		public const int LevelTasksFieldNumber = 1;

		// Token: 0x040066E8 RID: 26344
		private static readonly FieldCodec<OnlineMotorTask> _repeated_levelTasks_codec = FieldCodec.ForMessage<OnlineMotorTask>(10U, OnlineMotorTask.Parser);

		// Token: 0x040066E9 RID: 26345
		private readonly RepeatedField<OnlineMotorTask> levelTasks_ = new RepeatedField<OnlineMotorTask>();

		// Token: 0x040066EA RID: 26346
		public const int GlobalTasksFieldNumber = 2;

		// Token: 0x040066EB RID: 26347
		private static readonly FieldCodec<OnlineMotorTask> _repeated_globalTasks_codec = FieldCodec.ForMessage<OnlineMotorTask>(18U, OnlineMotorTask.Parser);

		// Token: 0x040066EC RID: 26348
		private readonly RepeatedField<OnlineMotorTask> globalTasks_ = new RepeatedField<OnlineMotorTask>();
	}
}
