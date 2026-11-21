using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005DE RID: 1502
	public sealed class FloroUnLockInfo : IMessage<FloroUnLockInfo>, IMessage, IEquatable<FloroUnLockInfo>, IDeepCloneable<FloroUnLockInfo>, IBufferMessage
	{
		// Token: 0x06008B9C RID: 35740 RVA: 0x00153540 File Offset: 0x00151740
		[NullableContext(1)]
		public static FloroUnLockInfo Create()
		{
			return new FloroUnLockInfo();
		}

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x06008B9D RID: 35741 RVA: 0x00153547 File Offset: 0x00151747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroUnLockInfo> Parser
		{
			get
			{
				return FloroUnLockInfo._parser;
			}
		}

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x06008B9E RID: 35742 RVA: 0x0015354E File Offset: 0x0015174E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x06008B9F RID: 35743 RVA: 0x00153551 File Offset: 0x00151751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroUnLockInfo.Descriptor;
			}
		}

		// Token: 0x06008BA0 RID: 35744 RVA: 0x00153558 File Offset: 0x00151758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroUnLockInfo()
		{
		}

		// Token: 0x06008BA1 RID: 35745 RVA: 0x00153560 File Offset: 0x00151760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroUnLockInfo(FloroUnLockInfo other) : this()
		{
			this.key_ = other.key_;
			this.unLockCondition_ = other.unLockCondition_;
			this.unLock_ = other.unLock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008BA2 RID: 35746 RVA: 0x0015359D File Offset: 0x0015179D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroUnLockInfo Clone()
		{
			return new FloroUnLockInfo(this);
		}

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x06008BA3 RID: 35747 RVA: 0x001535A5 File Offset: 0x001517A5
		// (set) Token: 0x06008BA4 RID: 35748 RVA: 0x001535AD File Offset: 0x001517AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = value;
			}
		}

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x06008BA5 RID: 35749 RVA: 0x001535B6 File Offset: 0x001517B6
		// (set) Token: 0x06008BA6 RID: 35750 RVA: 0x001535BE File Offset: 0x001517BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnLockCondition
		{
			get
			{
				return this.unLockCondition_;
			}
			set
			{
				this.unLockCondition_ = value;
			}
		}

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x06008BA7 RID: 35751 RVA: 0x001535C7 File Offset: 0x001517C7
		// (set) Token: 0x06008BA8 RID: 35752 RVA: 0x001535CF File Offset: 0x001517CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UnLock
		{
			get
			{
				return this.unLock_;
			}
			set
			{
				this.unLock_ = value;
			}
		}

		// Token: 0x06008BA9 RID: 35753 RVA: 0x001535D8 File Offset: 0x001517D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroUnLockInfo);
		}

		// Token: 0x06008BAA RID: 35754 RVA: 0x001535E8 File Offset: 0x001517E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroUnLockInfo other)
		{
			return other != null && (other == this || (this.Key == other.Key && this.UnLockCondition == other.UnLockCondition && this.UnLock == other.UnLock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008BAB RID: 35755 RVA: 0x00153644 File Offset: 0x00151844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Key != 0)
			{
				num ^= this.Key.GetHashCode();
			}
			if (this.UnLockCondition != 0)
			{
				num ^= this.UnLockCondition.GetHashCode();
			}
			if (this.UnLock)
			{
				num ^= this.UnLock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008BAC RID: 35756 RVA: 0x001536B5 File Offset: 0x001518B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008BAD RID: 35757 RVA: 0x001536C2 File Offset: 0x001518C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008BAE RID: 35758 RVA: 0x001536CC File Offset: 0x001518CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Key != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Key);
			}
			if (this.UnLockCondition != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.UnLockCondition);
			}
			if (this.UnLock)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.UnLock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008BAF RID: 35759 RVA: 0x00153740 File Offset: 0x00151940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Key != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Key);
			}
			if (this.UnLockCondition != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnLockCondition);
			}
			if (this.UnLock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008BB0 RID: 35760 RVA: 0x001537A4 File Offset: 0x001519A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroUnLockInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Key != 0)
			{
				this.Key = other.Key;
			}
			if (other.UnLockCondition != 0)
			{
				this.UnLockCondition = other.UnLockCondition;
			}
			if (other.UnLock)
			{
				this.UnLock = other.UnLock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008BB1 RID: 35761 RVA: 0x00153808 File Offset: 0x00151A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008BB2 RID: 35762 RVA: 0x00153814 File Offset: 0x00151A14
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.UnLock = input.ReadBool();
						}
					}
					else
					{
						this.UnLockCondition = input.ReadInt32();
					}
				}
				else
				{
					this.Key = input.ReadInt32();
				}
			}
		}

		// Token: 0x040044E3 RID: 17635
		private static readonly MessageParser<FloroUnLockInfo> _parser = new MessageParser<FloroUnLockInfo>(() => new FloroUnLockInfo());

		// Token: 0x040044E4 RID: 17636
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044E5 RID: 17637
		public const int KeyFieldNumber = 1;

		// Token: 0x040044E6 RID: 17638
		private int key_;

		// Token: 0x040044E7 RID: 17639
		public const int UnLockConditionFieldNumber = 2;

		// Token: 0x040044E8 RID: 17640
		private int unLockCondition_;

		// Token: 0x040044E9 RID: 17641
		public const int UnLockFieldNumber = 3;

		// Token: 0x040044EA RID: 17642
		private bool unLock_;
	}
}
