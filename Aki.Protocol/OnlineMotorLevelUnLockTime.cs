using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B9A RID: 2970
	public sealed class OnlineMotorLevelUnLockTime : IMessage<OnlineMotorLevelUnLockTime>, IMessage, IEquatable<OnlineMotorLevelUnLockTime>, IDeepCloneable<OnlineMotorLevelUnLockTime>, IBufferMessage
	{
		// Token: 0x060101A9 RID: 65961 RVA: 0x00259C92 File Offset: 0x00257E92
		[NullableContext(1)]
		public static OnlineMotorLevelUnLockTime Create()
		{
			return new OnlineMotorLevelUnLockTime();
		}

		// Token: 0x170034C4 RID: 13508
		// (get) Token: 0x060101AA RID: 65962 RVA: 0x00259C99 File Offset: 0x00257E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OnlineMotorLevelUnLockTime> Parser
		{
			get
			{
				return OnlineMotorLevelUnLockTime._parser;
			}
		}

		// Token: 0x170034C5 RID: 13509
		// (get) Token: 0x060101AB RID: 65963 RVA: 0x00259CA0 File Offset: 0x00257EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034C6 RID: 13510
		// (get) Token: 0x060101AC RID: 65964 RVA: 0x00259CA3 File Offset: 0x00257EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorLevelUnLockTime.Descriptor;
			}
		}

		// Token: 0x060101AD RID: 65965 RVA: 0x00259CAA File Offset: 0x00257EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorLevelUnLockTime()
		{
		}

		// Token: 0x060101AE RID: 65966 RVA: 0x00259CB2 File Offset: 0x00257EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorLevelUnLockTime(OnlineMotorLevelUnLockTime other) : this()
		{
			this.levelId_ = other.levelId_;
			this.unLockTime_ = other.unLockTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060101AF RID: 65967 RVA: 0x00259CE3 File Offset: 0x00257EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorLevelUnLockTime Clone()
		{
			return new OnlineMotorLevelUnLockTime(this);
		}

		// Token: 0x170034C7 RID: 13511
		// (get) Token: 0x060101B0 RID: 65968 RVA: 0x00259CEB File Offset: 0x00257EEB
		// (set) Token: 0x060101B1 RID: 65969 RVA: 0x00259CF3 File Offset: 0x00257EF3
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

		// Token: 0x170034C8 RID: 13512
		// (get) Token: 0x060101B2 RID: 65970 RVA: 0x00259CFC File Offset: 0x00257EFC
		// (set) Token: 0x060101B3 RID: 65971 RVA: 0x00259D04 File Offset: 0x00257F04
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

		// Token: 0x060101B4 RID: 65972 RVA: 0x00259D0D File Offset: 0x00257F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorLevelUnLockTime);
		}

		// Token: 0x060101B5 RID: 65973 RVA: 0x00259D1B File Offset: 0x00257F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorLevelUnLockTime other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.UnLockTime == other.UnLockTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060101B6 RID: 65974 RVA: 0x00259D5C File Offset: 0x00257F5C
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

		// Token: 0x060101B7 RID: 65975 RVA: 0x00259DB4 File Offset: 0x00257FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060101B8 RID: 65976 RVA: 0x00259DC1 File Offset: 0x00257FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060101B9 RID: 65977 RVA: 0x00259DCC File Offset: 0x00257FCC
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

		// Token: 0x060101BA RID: 65978 RVA: 0x00259E24 File Offset: 0x00258024
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

		// Token: 0x060101BB RID: 65979 RVA: 0x00259E7C File Offset: 0x0025807C
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

		// Token: 0x060101BC RID: 65980 RVA: 0x00259ECC File Offset: 0x002580CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060101BD RID: 65981 RVA: 0x00259ED8 File Offset: 0x002580D8
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

		// Token: 0x040066A7 RID: 26279
		private static readonly MessageParser<OnlineMotorLevelUnLockTime> _parser = new MessageParser<OnlineMotorLevelUnLockTime>(() => new OnlineMotorLevelUnLockTime());

		// Token: 0x040066A8 RID: 26280
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066A9 RID: 26281
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040066AA RID: 26282
		private int levelId_;

		// Token: 0x040066AB RID: 26283
		public const int UnLockTimeFieldNumber = 2;

		// Token: 0x040066AC RID: 26284
		private long unLockTime_;
	}
}
