using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B95 RID: 2965
	public sealed class OnlineMotorActivityData : IMessage<OnlineMotorActivityData>, IMessage, IEquatable<OnlineMotorActivityData>, IDeepCloneable<OnlineMotorActivityData>, IBufferMessage
	{
		// Token: 0x06010140 RID: 65856 RVA: 0x00258D34 File Offset: 0x00256F34
		[NullableContext(1)]
		public static OnlineMotorActivityData Create()
		{
			return new OnlineMotorActivityData();
		}

		// Token: 0x170034AC RID: 13484
		// (get) Token: 0x06010141 RID: 65857 RVA: 0x00258D3B File Offset: 0x00256F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034AD RID: 13485
		// (get) Token: 0x06010142 RID: 65858 RVA: 0x00258D3E File Offset: 0x00256F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorActivityData.Descriptor;
			}
		}

		// Token: 0x06010143 RID: 65859 RVA: 0x00258D45 File Offset: 0x00256F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityData()
		{
		}

		// Token: 0x06010144 RID: 65860 RVA: 0x00258D7C File Offset: 0x00256F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityData(OnlineMotorActivityData other) : this()
		{
			this.onlineMotorLevelInfos_ = other.onlineMotorLevelInfos_.Clone();
			this.levelTasks_ = other.levelTasks_.Clone();
			this.globalTasks_ = other.globalTasks_.Clone();
			this.unLocks_ = other.unLocks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010145 RID: 65861 RVA: 0x00258DE4 File Offset: 0x00256FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityData Clone()
		{
			return new OnlineMotorActivityData(this);
		}

		// Token: 0x170034AE RID: 13486
		// (get) Token: 0x06010146 RID: 65862 RVA: 0x00258DEC File Offset: 0x00256FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnlineMotorLevelInfo> OnlineMotorLevelInfos
		{
			get
			{
				return this.onlineMotorLevelInfos_;
			}
		}

		// Token: 0x170034AF RID: 13487
		// (get) Token: 0x06010147 RID: 65863 RVA: 0x00258DF4 File Offset: 0x00256FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnlineMotorTask> LevelTasks
		{
			get
			{
				return this.levelTasks_;
			}
		}

		// Token: 0x170034B0 RID: 13488
		// (get) Token: 0x06010148 RID: 65864 RVA: 0x00258DFC File Offset: 0x00256FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnlineMotorTask> GlobalTasks
		{
			get
			{
				return this.globalTasks_;
			}
		}

		// Token: 0x170034B1 RID: 13489
		// (get) Token: 0x06010149 RID: 65865 RVA: 0x00258E04 File Offset: 0x00257004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnlineMotorLevelUnLockTime> UnLocks
		{
			get
			{
				return this.unLocks_;
			}
		}

		// Token: 0x0601014A RID: 65866 RVA: 0x00258E0C File Offset: 0x0025700C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorActivityData);
		}

		// Token: 0x0601014B RID: 65867 RVA: 0x00258E1C File Offset: 0x0025701C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorActivityData other)
		{
			return other != null && (other == this || (this.onlineMotorLevelInfos_.Equals(other.onlineMotorLevelInfos_) && this.levelTasks_.Equals(other.levelTasks_) && this.globalTasks_.Equals(other.globalTasks_) && this.unLocks_.Equals(other.unLocks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601014C RID: 65868 RVA: 0x00258E9C File Offset: 0x0025709C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.onlineMotorLevelInfos_.GetHashCode();
			num ^= this.levelTasks_.GetHashCode();
			num ^= this.globalTasks_.GetHashCode();
			num ^= this.unLocks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601014D RID: 65869 RVA: 0x00258EFA File Offset: 0x002570FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601014E RID: 65870 RVA: 0x00258F07 File Offset: 0x00257107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601014F RID: 65871 RVA: 0x00258F10 File Offset: 0x00257110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.onlineMotorLevelInfos_.WriteTo(ref output, OnlineMotorActivityData._repeated_onlineMotorLevelInfos_codec);
			this.levelTasks_.WriteTo(ref output, OnlineMotorActivityData._repeated_levelTasks_codec);
			this.globalTasks_.WriteTo(ref output, OnlineMotorActivityData._repeated_globalTasks_codec);
			this.unLocks_.WriteTo(ref output, OnlineMotorActivityData._repeated_unLocks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010150 RID: 65872 RVA: 0x00258F78 File Offset: 0x00257178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.onlineMotorLevelInfos_.CalculateSize(OnlineMotorActivityData._repeated_onlineMotorLevelInfos_codec);
			num += this.levelTasks_.CalculateSize(OnlineMotorActivityData._repeated_levelTasks_codec);
			num += this.globalTasks_.CalculateSize(OnlineMotorActivityData._repeated_globalTasks_codec);
			num += this.unLocks_.CalculateSize(OnlineMotorActivityData._repeated_unLocks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010151 RID: 65873 RVA: 0x00258FEC File Offset: 0x002571EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OnlineMotorActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.onlineMotorLevelInfos_.Add(other.onlineMotorLevelInfos_);
			this.levelTasks_.Add(other.levelTasks_);
			this.globalTasks_.Add(other.globalTasks_);
			this.unLocks_.Add(other.unLocks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010152 RID: 65874 RVA: 0x00259058 File Offset: 0x00257258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010153 RID: 65875 RVA: 0x00259064 File Offset: 0x00257264
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.onlineMotorLevelInfos_.AddEntriesFrom(ref input, OnlineMotorActivityData._repeated_onlineMotorLevelInfos_codec);
						continue;
					}
					if (num == 18U)
					{
						this.levelTasks_.AddEntriesFrom(ref input, OnlineMotorActivityData._repeated_levelTasks_codec);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.globalTasks_.AddEntriesFrom(ref input, OnlineMotorActivityData._repeated_globalTasks_codec);
						continue;
					}
					if (num == 34U)
					{
						this.unLocks_.AddEntriesFrom(ref input, OnlineMotorActivityData._repeated_unLocks_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006682 RID: 26242
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006683 RID: 26243
		public const int OnlineMotorLevelInfosFieldNumber = 1;

		// Token: 0x04006684 RID: 26244
		private static readonly FieldCodec<OnlineMotorLevelInfo> _repeated_onlineMotorLevelInfos_codec = FieldCodec.ForMessage<OnlineMotorLevelInfo>(10U, OnlineMotorLevelInfo.Parser);

		// Token: 0x04006685 RID: 26245
		private readonly RepeatedField<OnlineMotorLevelInfo> onlineMotorLevelInfos_ = new RepeatedField<OnlineMotorLevelInfo>();

		// Token: 0x04006686 RID: 26246
		public const int LevelTasksFieldNumber = 2;

		// Token: 0x04006687 RID: 26247
		private static readonly FieldCodec<OnlineMotorTask> _repeated_levelTasks_codec = FieldCodec.ForMessage<OnlineMotorTask>(18U, OnlineMotorTask.Parser);

		// Token: 0x04006688 RID: 26248
		private readonly RepeatedField<OnlineMotorTask> levelTasks_ = new RepeatedField<OnlineMotorTask>();

		// Token: 0x04006689 RID: 26249
		public const int GlobalTasksFieldNumber = 3;

		// Token: 0x0400668A RID: 26250
		private static readonly FieldCodec<OnlineMotorTask> _repeated_globalTasks_codec = FieldCodec.ForMessage<OnlineMotorTask>(26U, OnlineMotorTask.Parser);

		// Token: 0x0400668B RID: 26251
		private readonly RepeatedField<OnlineMotorTask> globalTasks_ = new RepeatedField<OnlineMotorTask>();

		// Token: 0x0400668C RID: 26252
		public const int UnLocksFieldNumber = 4;

		// Token: 0x0400668D RID: 26253
		private static readonly FieldCodec<OnlineMotorLevelUnLockTime> _repeated_unLocks_codec = FieldCodec.ForMessage<OnlineMotorLevelUnLockTime>(34U, OnlineMotorLevelUnLockTime.Parser);

		// Token: 0x0400668E RID: 26254
		private readonly RepeatedField<OnlineMotorLevelUnLockTime> unLocks_ = new RepeatedField<OnlineMotorLevelUnLockTime>();
	}
}
