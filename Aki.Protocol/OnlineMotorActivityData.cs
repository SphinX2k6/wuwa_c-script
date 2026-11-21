using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B85 RID: 2949
	public sealed class OnlineMotorActivityData : IMessage<OnlineMotorActivityData>, IMessage, IEquatable<OnlineMotorActivityData>, IDeepCloneable<OnlineMotorActivityData>, IBufferMessage
	{
		// Token: 0x0601003C RID: 65596 RVA: 0x00256E64 File Offset: 0x00255064
		[NullableContext(1)]
		public static OnlineMotorActivityData Create()
		{
			return new OnlineMotorActivityData();
		}

		// Token: 0x17003473 RID: 13427
		// (get) Token: 0x0601003D RID: 65597 RVA: 0x00256E6B File Offset: 0x0025506B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003474 RID: 13428
		// (get) Token: 0x0601003E RID: 65598 RVA: 0x00256E6E File Offset: 0x0025506E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorActivityData.Descriptor;
			}
		}

		// Token: 0x0601003F RID: 65599 RVA: 0x00256E75 File Offset: 0x00255075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityData()
		{
		}

		// Token: 0x06010040 RID: 65600 RVA: 0x00256EAC File Offset: 0x002550AC
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

		// Token: 0x06010041 RID: 65601 RVA: 0x00256F14 File Offset: 0x00255114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorActivityData Clone()
		{
			return new OnlineMotorActivityData(this);
		}

		// Token: 0x17003475 RID: 13429
		// (get) Token: 0x06010042 RID: 65602 RVA: 0x00256F1C File Offset: 0x0025511C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnlineMotorLevelInfo> OnlineMotorLevelInfos
		{
			get
			{
				return this.onlineMotorLevelInfos_;
			}
		}

		// Token: 0x17003476 RID: 13430
		// (get) Token: 0x06010043 RID: 65603 RVA: 0x00256F24 File Offset: 0x00255124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnlineMotorTask> LevelTasks
		{
			get
			{
				return this.levelTasks_;
			}
		}

		// Token: 0x17003477 RID: 13431
		// (get) Token: 0x06010044 RID: 65604 RVA: 0x00256F2C File Offset: 0x0025512C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnlineMotorTask> GlobalTasks
		{
			get
			{
				return this.globalTasks_;
			}
		}

		// Token: 0x17003478 RID: 13432
		// (get) Token: 0x06010045 RID: 65605 RVA: 0x00256F34 File Offset: 0x00255134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnlineMotorLevelUnLockTime> UnLocks
		{
			get
			{
				return this.unLocks_;
			}
		}

		// Token: 0x06010046 RID: 65606 RVA: 0x00256F3C File Offset: 0x0025513C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorActivityData);
		}

		// Token: 0x06010047 RID: 65607 RVA: 0x00256F4C File Offset: 0x0025514C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorActivityData other)
		{
			return other != null && (other == this || (this.onlineMotorLevelInfos_.Equals(other.onlineMotorLevelInfos_) && this.levelTasks_.Equals(other.levelTasks_) && this.globalTasks_.Equals(other.globalTasks_) && this.unLocks_.Equals(other.unLocks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010048 RID: 65608 RVA: 0x00256FCC File Offset: 0x002551CC
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

		// Token: 0x06010049 RID: 65609 RVA: 0x0025702A File Offset: 0x0025522A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601004A RID: 65610 RVA: 0x00257037 File Offset: 0x00255237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601004B RID: 65611 RVA: 0x00257040 File Offset: 0x00255240
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

		// Token: 0x0601004C RID: 65612 RVA: 0x002570A8 File Offset: 0x002552A8
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

		// Token: 0x0601004D RID: 65613 RVA: 0x0025711C File Offset: 0x0025531C
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

		// Token: 0x0601004E RID: 65614 RVA: 0x00257188 File Offset: 0x00255388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601004F RID: 65615 RVA: 0x00257194 File Offset: 0x00255394
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

		// Token: 0x04006692 RID: 26258
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006693 RID: 26259
		public const int OnlineMotorLevelInfosFieldNumber = 1;

		// Token: 0x04006694 RID: 26260
		private static readonly FieldCodec<OnlineMotorLevelInfo> _repeated_onlineMotorLevelInfos_codec = FieldCodec.ForMessage<OnlineMotorLevelInfo>(10U, OnlineMotorLevelInfo.Parser);

		// Token: 0x04006695 RID: 26261
		private readonly RepeatedField<OnlineMotorLevelInfo> onlineMotorLevelInfos_ = new RepeatedField<OnlineMotorLevelInfo>();

		// Token: 0x04006696 RID: 26262
		public const int LevelTasksFieldNumber = 2;

		// Token: 0x04006697 RID: 26263
		private static readonly FieldCodec<OnlineMotorTask> _repeated_levelTasks_codec = FieldCodec.ForMessage<OnlineMotorTask>(18U, OnlineMotorTask.Parser);

		// Token: 0x04006698 RID: 26264
		private readonly RepeatedField<OnlineMotorTask> levelTasks_ = new RepeatedField<OnlineMotorTask>();

		// Token: 0x04006699 RID: 26265
		public const int GlobalTasksFieldNumber = 3;

		// Token: 0x0400669A RID: 26266
		private static readonly FieldCodec<OnlineMotorTask> _repeated_globalTasks_codec = FieldCodec.ForMessage<OnlineMotorTask>(26U, OnlineMotorTask.Parser);

		// Token: 0x0400669B RID: 26267
		private readonly RepeatedField<OnlineMotorTask> globalTasks_ = new RepeatedField<OnlineMotorTask>();

		// Token: 0x0400669C RID: 26268
		public const int UnLocksFieldNumber = 4;

		// Token: 0x0400669D RID: 26269
		private static readonly FieldCodec<OnlineMotorLevelUnLockTime> _repeated_unLocks_codec = FieldCodec.ForMessage<OnlineMotorLevelUnLockTime>(34U, OnlineMotorLevelUnLockTime.Parser);

		// Token: 0x0400669E RID: 26270
		private readonly RepeatedField<OnlineMotorLevelUnLockTime> unLocks_ = new RepeatedField<OnlineMotorLevelUnLockTime>();
	}
}
