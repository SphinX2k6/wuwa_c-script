using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F3 RID: 1523
	public sealed class FloroUnLockInfo : IMessage<FloroUnLockInfo>, IMessage, IEquatable<FloroUnLockInfo>, IDeepCloneable<FloroUnLockInfo>, IBufferMessage
	{
		// Token: 0x06008D04 RID: 36100 RVA: 0x00156148 File Offset: 0x00154348
		[NullableContext(1)]
		public static FloroUnLockInfo Create()
		{
			return new FloroUnLockInfo();
		}

		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x06008D05 RID: 36101 RVA: 0x0015614F File Offset: 0x0015434F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroUnLockInfo> Parser
		{
			get
			{
				return FloroUnLockInfo._parser;
			}
		}

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x06008D06 RID: 36102 RVA: 0x00156156 File Offset: 0x00154356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x06008D07 RID: 36103 RVA: 0x00156159 File Offset: 0x00154359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroUnLockInfo.Descriptor;
			}
		}

		// Token: 0x06008D08 RID: 36104 RVA: 0x00156160 File Offset: 0x00154360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroUnLockInfo()
		{
		}

		// Token: 0x06008D09 RID: 36105 RVA: 0x00156168 File Offset: 0x00154368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroUnLockInfo(FloroUnLockInfo other) : this()
		{
			this.key_ = other.key_;
			this.unLockCondition_ = other.unLockCondition_;
			this.unLock_ = other.unLock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D0A RID: 36106 RVA: 0x001561A5 File Offset: 0x001543A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroUnLockInfo Clone()
		{
			return new FloroUnLockInfo(this);
		}

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x06008D0B RID: 36107 RVA: 0x001561AD File Offset: 0x001543AD
		// (set) Token: 0x06008D0C RID: 36108 RVA: 0x001561B5 File Offset: 0x001543B5
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

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x06008D0D RID: 36109 RVA: 0x001561BE File Offset: 0x001543BE
		// (set) Token: 0x06008D0E RID: 36110 RVA: 0x001561C6 File Offset: 0x001543C6
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

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x06008D0F RID: 36111 RVA: 0x001561CF File Offset: 0x001543CF
		// (set) Token: 0x06008D10 RID: 36112 RVA: 0x001561D7 File Offset: 0x001543D7
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

		// Token: 0x06008D11 RID: 36113 RVA: 0x001561E0 File Offset: 0x001543E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroUnLockInfo);
		}

		// Token: 0x06008D12 RID: 36114 RVA: 0x001561F0 File Offset: 0x001543F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroUnLockInfo other)
		{
			return other != null && (other == this || (this.Key == other.Key && this.UnLockCondition == other.UnLockCondition && this.UnLock == other.UnLock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D13 RID: 36115 RVA: 0x0015624C File Offset: 0x0015444C
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

		// Token: 0x06008D14 RID: 36116 RVA: 0x001562BD File Offset: 0x001544BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008D15 RID: 36117 RVA: 0x001562CA File Offset: 0x001544CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D16 RID: 36118 RVA: 0x001562D4 File Offset: 0x001544D4
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

		// Token: 0x06008D17 RID: 36119 RVA: 0x00156348 File Offset: 0x00154548
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

		// Token: 0x06008D18 RID: 36120 RVA: 0x001563AC File Offset: 0x001545AC
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

		// Token: 0x06008D19 RID: 36121 RVA: 0x00156410 File Offset: 0x00154610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D1A RID: 36122 RVA: 0x0015641C File Offset: 0x0015461C
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

		// Token: 0x040044ED RID: 17645
		private static readonly MessageParser<FloroUnLockInfo> _parser = new MessageParser<FloroUnLockInfo>(() => new FloroUnLockInfo());

		// Token: 0x040044EE RID: 17646
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044EF RID: 17647
		public const int KeyFieldNumber = 1;

		// Token: 0x040044F0 RID: 17648
		private int key_;

		// Token: 0x040044F1 RID: 17649
		public const int UnLockConditionFieldNumber = 2;

		// Token: 0x040044F2 RID: 17650
		private int unLockCondition_;

		// Token: 0x040044F3 RID: 17651
		public const int UnLockFieldNumber = 3;

		// Token: 0x040044F4 RID: 17652
		private bool unLock_;
	}
}
