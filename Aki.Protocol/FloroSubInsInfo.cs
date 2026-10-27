using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F2 RID: 1522
	public sealed class FloroSubInsInfo : IMessage<FloroSubInsInfo>, IMessage, IEquatable<FloroSubInsInfo>, IDeepCloneable<FloroSubInsInfo>, IBufferMessage
	{
		// Token: 0x06008CEA RID: 36074 RVA: 0x00155D47 File Offset: 0x00153F47
		[NullableContext(1)]
		public static FloroSubInsInfo Create()
		{
			return new FloroSubInsInfo();
		}

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x06008CEB RID: 36075 RVA: 0x00155D4E File Offset: 0x00153F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroSubInsInfo> Parser
		{
			get
			{
				return FloroSubInsInfo._parser;
			}
		}

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x06008CEC RID: 36076 RVA: 0x00155D55 File Offset: 0x00153F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x06008CED RID: 36077 RVA: 0x00155D58 File Offset: 0x00153F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroSubInsInfo.Descriptor;
			}
		}

		// Token: 0x06008CEE RID: 36078 RVA: 0x00155D5F File Offset: 0x00153F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroSubInsInfo()
		{
		}

		// Token: 0x06008CEF RID: 36079 RVA: 0x00155D68 File Offset: 0x00153F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroSubInsInfo(FloroSubInsInfo other) : this()
		{
			this.key_ = other.key_;
			this.unLockCondition_ = other.unLockCondition_;
			this.unLock_ = other.unLock_;
			this.pass_ = other.pass_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008CF0 RID: 36080 RVA: 0x00155DBC File Offset: 0x00153FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroSubInsInfo Clone()
		{
			return new FloroSubInsInfo(this);
		}

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x06008CF1 RID: 36081 RVA: 0x00155DC4 File Offset: 0x00153FC4
		// (set) Token: 0x06008CF2 RID: 36082 RVA: 0x00155DCC File Offset: 0x00153FCC
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

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x06008CF3 RID: 36083 RVA: 0x00155DD5 File Offset: 0x00153FD5
		// (set) Token: 0x06008CF4 RID: 36084 RVA: 0x00155DDD File Offset: 0x00153FDD
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

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x06008CF5 RID: 36085 RVA: 0x00155DE6 File Offset: 0x00153FE6
		// (set) Token: 0x06008CF6 RID: 36086 RVA: 0x00155DEE File Offset: 0x00153FEE
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

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x06008CF7 RID: 36087 RVA: 0x00155DF7 File Offset: 0x00153FF7
		// (set) Token: 0x06008CF8 RID: 36088 RVA: 0x00155DFF File Offset: 0x00153FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Pass
		{
			get
			{
				return this.pass_;
			}
			set
			{
				this.pass_ = value;
			}
		}

		// Token: 0x06008CF9 RID: 36089 RVA: 0x00155E08 File Offset: 0x00154008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroSubInsInfo);
		}

		// Token: 0x06008CFA RID: 36090 RVA: 0x00155E18 File Offset: 0x00154018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroSubInsInfo other)
		{
			return other != null && (other == this || (this.Key == other.Key && this.UnLockCondition == other.UnLockCondition && this.UnLock == other.UnLock && this.Pass == other.Pass && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008CFB RID: 36091 RVA: 0x00155E84 File Offset: 0x00154084
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
			if (this.Pass)
			{
				num ^= this.Pass.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008CFC RID: 36092 RVA: 0x00155F0E File Offset: 0x0015410E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008CFD RID: 36093 RVA: 0x00155F1B File Offset: 0x0015411B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008CFE RID: 36094 RVA: 0x00155F24 File Offset: 0x00154124
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
			if (this.Pass)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Pass);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008CFF RID: 36095 RVA: 0x00155FB4 File Offset: 0x001541B4
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
			if (this.Pass)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D00 RID: 36096 RVA: 0x00156024 File Offset: 0x00154224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroSubInsInfo other)
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
			if (other.Pass)
			{
				this.Pass = other.Pass;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008D01 RID: 36097 RVA: 0x0015609C File Offset: 0x0015429C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D02 RID: 36098 RVA: 0x001560A8 File Offset: 0x001542A8
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Key = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.UnLockCondition = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.UnLock = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.Pass = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040044E3 RID: 17635
		private static readonly MessageParser<FloroSubInsInfo> _parser = new MessageParser<FloroSubInsInfo>(() => new FloroSubInsInfo());

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

		// Token: 0x040044EB RID: 17643
		public const int PassFieldNumber = 4;

		// Token: 0x040044EC RID: 17644
		private bool pass_;
	}
}
