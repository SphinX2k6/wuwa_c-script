using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001383 RID: 4995
	public sealed class SysBuffInformation : IMessage<SysBuffInformation>, IMessage, IEquatable<SysBuffInformation>, IDeepCloneable<SysBuffInformation>, IBufferMessage
	{
		// Token: 0x0601A97D RID: 108925 RVA: 0x003DFC7D File Offset: 0x003DDE7D
		[NullableContext(1)]
		public static SysBuffInformation Create()
		{
			return new SysBuffInformation();
		}

		// Token: 0x17005A06 RID: 23046
		// (get) Token: 0x0601A97E RID: 108926 RVA: 0x003DFC84 File Offset: 0x003DDE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SysBuffInformation> Parser
		{
			get
			{
				return SysBuffInformation._parser;
			}
		}

		// Token: 0x17005A07 RID: 23047
		// (get) Token: 0x0601A97F RID: 108927 RVA: 0x003DFC8B File Offset: 0x003DDE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A08 RID: 23048
		// (get) Token: 0x0601A980 RID: 108928 RVA: 0x003DFC8E File Offset: 0x003DDE8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SysBuffInformation.Descriptor;
			}
		}

		// Token: 0x0601A981 RID: 108929 RVA: 0x003DFC95 File Offset: 0x003DDE95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysBuffInformation()
		{
		}

		// Token: 0x0601A982 RID: 108930 RVA: 0x003DFCA0 File Offset: 0x003DDEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysBuffInformation(SysBuffInformation other) : this()
		{
			this.serverId_ = other.serverId_;
			this.buffId_ = other.buffId_;
			this.level_ = other.level_;
			this.messageId_ = other.messageId_;
			this.instigatorId_ = other.instigatorId_;
			this.duration_ = other.duration_;
			this.stackCount_ = other.stackCount_;
			this.applyType_ = other.applyType_;
			this.isIterable_ = other.isIterable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A983 RID: 108931 RVA: 0x003DFD30 File Offset: 0x003DDF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysBuffInformation Clone()
		{
			return new SysBuffInformation(this);
		}

		// Token: 0x17005A09 RID: 23049
		// (get) Token: 0x0601A984 RID: 108932 RVA: 0x003DFD38 File Offset: 0x003DDF38
		// (set) Token: 0x0601A985 RID: 108933 RVA: 0x003DFD40 File Offset: 0x003DDF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ServerId
		{
			get
			{
				return this.serverId_;
			}
			set
			{
				this.serverId_ = value;
			}
		}

		// Token: 0x17005A0A RID: 23050
		// (get) Token: 0x0601A986 RID: 108934 RVA: 0x003DFD49 File Offset: 0x003DDF49
		// (set) Token: 0x0601A987 RID: 108935 RVA: 0x003DFD51 File Offset: 0x003DDF51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x17005A0B RID: 23051
		// (get) Token: 0x0601A988 RID: 108936 RVA: 0x003DFD5A File Offset: 0x003DDF5A
		// (set) Token: 0x0601A989 RID: 108937 RVA: 0x003DFD62 File Offset: 0x003DDF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17005A0C RID: 23052
		// (get) Token: 0x0601A98A RID: 108938 RVA: 0x003DFD6B File Offset: 0x003DDF6B
		// (set) Token: 0x0601A98B RID: 108939 RVA: 0x003DFD73 File Offset: 0x003DDF73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MessageId
		{
			get
			{
				return this.messageId_;
			}
			set
			{
				this.messageId_ = value;
			}
		}

		// Token: 0x17005A0D RID: 23053
		// (get) Token: 0x0601A98C RID: 108940 RVA: 0x003DFD7C File Offset: 0x003DDF7C
		// (set) Token: 0x0601A98D RID: 108941 RVA: 0x003DFD84 File Offset: 0x003DDF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InstigatorId
		{
			get
			{
				return this.instigatorId_;
			}
			set
			{
				this.instigatorId_ = value;
			}
		}

		// Token: 0x17005A0E RID: 23054
		// (get) Token: 0x0601A98E RID: 108942 RVA: 0x003DFD8D File Offset: 0x003DDF8D
		// (set) Token: 0x0601A98F RID: 108943 RVA: 0x003DFD95 File Offset: 0x003DDF95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Duration
		{
			get
			{
				return this.duration_;
			}
			set
			{
				this.duration_ = value;
			}
		}

		// Token: 0x17005A0F RID: 23055
		// (get) Token: 0x0601A990 RID: 108944 RVA: 0x003DFD9E File Offset: 0x003DDF9E
		// (set) Token: 0x0601A991 RID: 108945 RVA: 0x003DFDA6 File Offset: 0x003DDFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StackCount
		{
			get
			{
				return this.stackCount_;
			}
			set
			{
				this.stackCount_ = value;
			}
		}

		// Token: 0x17005A10 RID: 23056
		// (get) Token: 0x0601A992 RID: 108946 RVA: 0x003DFDAF File Offset: 0x003DDFAF
		// (set) Token: 0x0601A993 RID: 108947 RVA: 0x003DFDB7 File Offset: 0x003DDFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGEType ApplyType
		{
			get
			{
				return this.applyType_;
			}
			set
			{
				this.applyType_ = value;
			}
		}

		// Token: 0x17005A11 RID: 23057
		// (get) Token: 0x0601A994 RID: 108948 RVA: 0x003DFDC0 File Offset: 0x003DDFC0
		// (set) Token: 0x0601A995 RID: 108949 RVA: 0x003DFDC8 File Offset: 0x003DDFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsIterable
		{
			get
			{
				return this.isIterable_;
			}
			set
			{
				this.isIterable_ = value;
			}
		}

		// Token: 0x0601A996 RID: 108950 RVA: 0x003DFDD1 File Offset: 0x003DDFD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SysBuffInformation);
		}

		// Token: 0x0601A997 RID: 108951 RVA: 0x003DFDE0 File Offset: 0x003DDFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SysBuffInformation other)
		{
			return other != null && (other == this || (this.ServerId == other.ServerId && this.BuffId == other.BuffId && this.Level == other.Level && this.MessageId == other.MessageId && this.InstigatorId == other.InstigatorId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && this.StackCount == other.StackCount && this.ApplyType == other.ApplyType && this.IsIterable == other.IsIterable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A998 RID: 108952 RVA: 0x003DFEA4 File Offset: 0x003DE0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ServerId != 0)
			{
				num ^= this.ServerId.GetHashCode();
			}
			if (this.BuffId != 0L)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.MessageId != 0L)
			{
				num ^= this.MessageId.GetHashCode();
			}
			if (this.InstigatorId != 0L)
			{
				num ^= this.InstigatorId.GetHashCode();
			}
			if (this.Duration != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Duration);
			}
			if (this.StackCount != 0)
			{
				num ^= this.StackCount.GetHashCode();
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				num ^= this.ApplyType.GetHashCode();
			}
			if (this.IsIterable)
			{
				num ^= this.IsIterable.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A999 RID: 108953 RVA: 0x003DFFB9 File Offset: 0x003DE1B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A99A RID: 108954 RVA: 0x003DFFC6 File Offset: 0x003DE1C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A99B RID: 108955 RVA: 0x003DFFD0 File Offset: 0x003DE1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ServerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ServerId);
			}
			if (this.BuffId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BuffId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Level);
			}
			if (this.MessageId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.MessageId);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.Duration != 0f)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.Duration);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.StackCount);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ApplyType);
			}
			if (this.IsIterable)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsIterable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A99C RID: 108956 RVA: 0x003E00F4 File Offset: 0x003DE2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ServerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ServerId);
			}
			if (this.BuffId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BuffId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.MessageId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MessageId);
			}
			if (this.InstigatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InstigatorId);
			}
			if (this.Duration != 0f)
			{
				num += 5;
			}
			if (this.StackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackCount);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ApplyType);
			}
			if (this.IsIterable)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A99D RID: 108957 RVA: 0x003E01E0 File Offset: 0x003DE3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SysBuffInformation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ServerId != 0)
			{
				this.ServerId = other.ServerId;
			}
			if (other.BuffId != 0L)
			{
				this.BuffId = other.BuffId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.MessageId != 0L)
			{
				this.MessageId = other.MessageId;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			if (other.Duration != 0f)
			{
				this.Duration = other.Duration;
			}
			if (other.StackCount != 0)
			{
				this.StackCount = other.StackCount;
			}
			if (other.ApplyType != ApplyGEType.Common)
			{
				this.ApplyType = other.ApplyType;
			}
			if (other.IsIterable)
			{
				this.IsIterable = other.IsIterable;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A99E RID: 108958 RVA: 0x003E02C1 File Offset: 0x003DE4C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A99F RID: 108959 RVA: 0x003E02CC File Offset: 0x003DE4CC
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.ServerId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.BuffId = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.MessageId = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 53U)
				{
					if (num == 40U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
					if (num == 53U)
					{
						this.Duration = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.ApplyType = (ApplyGEType)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.IsIterable = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009BD3 RID: 39891
		private static readonly MessageParser<SysBuffInformation> _parser = new MessageParser<SysBuffInformation>(() => new SysBuffInformation());

		// Token: 0x04009BD4 RID: 39892
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BD5 RID: 39893
		public const int ServerIdFieldNumber = 1;

		// Token: 0x04009BD6 RID: 39894
		private int serverId_;

		// Token: 0x04009BD7 RID: 39895
		public const int BuffIdFieldNumber = 2;

		// Token: 0x04009BD8 RID: 39896
		private long buffId_;

		// Token: 0x04009BD9 RID: 39897
		public const int LevelFieldNumber = 3;

		// Token: 0x04009BDA RID: 39898
		private int level_;

		// Token: 0x04009BDB RID: 39899
		public const int MessageIdFieldNumber = 4;

		// Token: 0x04009BDC RID: 39900
		private long messageId_;

		// Token: 0x04009BDD RID: 39901
		public const int InstigatorIdFieldNumber = 5;

		// Token: 0x04009BDE RID: 39902
		private long instigatorId_;

		// Token: 0x04009BDF RID: 39903
		public const int DurationFieldNumber = 6;

		// Token: 0x04009BE0 RID: 39904
		private float duration_;

		// Token: 0x04009BE1 RID: 39905
		public const int StackCountFieldNumber = 7;

		// Token: 0x04009BE2 RID: 39906
		private int stackCount_;

		// Token: 0x04009BE3 RID: 39907
		public const int ApplyTypeFieldNumber = 8;

		// Token: 0x04009BE4 RID: 39908
		private ApplyGEType applyType_;

		// Token: 0x04009BE5 RID: 39909
		public const int IsIterableFieldNumber = 9;

		// Token: 0x04009BE6 RID: 39910
		private bool isIterable_;
	}
}
