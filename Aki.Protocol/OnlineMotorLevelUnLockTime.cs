using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B8A RID: 2954
	public sealed class OnlineMotorLevelUnLockTime : IMessage<OnlineMotorLevelUnLockTime>, IMessage, IEquatable<OnlineMotorLevelUnLockTime>, IDeepCloneable<OnlineMotorLevelUnLockTime>, IBufferMessage
	{
		// Token: 0x060100A5 RID: 65701 RVA: 0x00257DC6 File Offset: 0x00255FC6
		[NullableContext(1)]
		public static OnlineMotorLevelUnLockTime Create()
		{
			return new OnlineMotorLevelUnLockTime();
		}

		// Token: 0x1700348B RID: 13451
		// (get) Token: 0x060100A6 RID: 65702 RVA: 0x00257DCD File Offset: 0x00255FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OnlineMotorLevelUnLockTime> Parser
		{
			get
			{
				return OnlineMotorLevelUnLockTime._parser;
			}
		}

		// Token: 0x1700348C RID: 13452
		// (get) Token: 0x060100A7 RID: 65703 RVA: 0x00257DD4 File Offset: 0x00255FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700348D RID: 13453
		// (get) Token: 0x060100A8 RID: 65704 RVA: 0x00257DD7 File Offset: 0x00255FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorLevelUnLockTime.Descriptor;
			}
		}

		// Token: 0x060100A9 RID: 65705 RVA: 0x00257DDE File Offset: 0x00255FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorLevelUnLockTime()
		{
		}

		// Token: 0x060100AA RID: 65706 RVA: 0x00257DE6 File Offset: 0x00255FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorLevelUnLockTime(OnlineMotorLevelUnLockTime other) : this()
		{
			this.levelId_ = other.levelId_;
			this.unLockTime_ = other.unLockTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060100AB RID: 65707 RVA: 0x00257E17 File Offset: 0x00256017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorLevelUnLockTime Clone()
		{
			return new OnlineMotorLevelUnLockTime(this);
		}

		// Token: 0x1700348E RID: 13454
		// (get) Token: 0x060100AC RID: 65708 RVA: 0x00257E1F File Offset: 0x0025601F
		// (set) Token: 0x060100AD RID: 65709 RVA: 0x00257E27 File Offset: 0x00256027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x1700348F RID: 13455
		// (get) Token: 0x060100AE RID: 65710 RVA: 0x00257E30 File Offset: 0x00256030
		// (set) Token: 0x060100AF RID: 65711 RVA: 0x00257E38 File Offset: 0x00256038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnLockTime
		{
			get
			{
				return this.unLockTime_;
			}
			set
			{
				this.unLockTime_ = value;
			}
		}

		// Token: 0x060100B0 RID: 65712 RVA: 0x00257E41 File Offset: 0x00256041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorLevelUnLockTime);
		}

		// Token: 0x060100B1 RID: 65713 RVA: 0x00257E4F File Offset: 0x0025604F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorLevelUnLockTime other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.UnLockTime == other.UnLockTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060100B2 RID: 65714 RVA: 0x00257E90 File Offset: 0x00256090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.UnLockTime != 0L)
			{
				num ^= this.UnLockTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060100B3 RID: 65715 RVA: 0x00257EE8 File Offset: 0x002560E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060100B4 RID: 65716 RVA: 0x00257EF5 File Offset: 0x002560F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060100B5 RID: 65717 RVA: 0x00257F00 File Offset: 0x00256100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.UnLockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnLockTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060100B6 RID: 65718 RVA: 0x00257F58 File Offset: 0x00256158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.UnLockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnLockTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060100B7 RID: 65719 RVA: 0x00257FB0 File Offset: 0x002561B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OnlineMotorLevelUnLockTime other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.UnLockTime != 0L)
			{
				this.UnLockTime = other.UnLockTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060100B8 RID: 65720 RVA: 0x00258000 File Offset: 0x00256200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060100B9 RID: 65721 RVA: 0x0025800C File Offset: 0x0025620C
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.UnLockTime = input.ReadInt64();
					}
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040066B7 RID: 26295
		private static readonly MessageParser<OnlineMotorLevelUnLockTime> _parser = new MessageParser<OnlineMotorLevelUnLockTime>(() => new OnlineMotorLevelUnLockTime());

		// Token: 0x040066B8 RID: 26296
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066B9 RID: 26297
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040066BA RID: 26298
		private int levelId_;

		// Token: 0x040066BB RID: 26299
		public const int UnLockTimeFieldNumber = 2;

		// Token: 0x040066BC RID: 26300
		private long unLockTime_;
	}
}
