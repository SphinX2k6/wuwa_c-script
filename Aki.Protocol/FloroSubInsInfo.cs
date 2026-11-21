using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005DD RID: 1501
	public sealed class FloroSubInsInfo : IMessage<FloroSubInsInfo>, IMessage, IEquatable<FloroSubInsInfo>, IDeepCloneable<FloroSubInsInfo>, IBufferMessage
	{
		// Token: 0x06008B82 RID: 35714 RVA: 0x0015313F File Offset: 0x0015133F
		[NullableContext(1)]
		public static FloroSubInsInfo Create()
		{
			return new FloroSubInsInfo();
		}

		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x06008B83 RID: 35715 RVA: 0x00153146 File Offset: 0x00151346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroSubInsInfo> Parser
		{
			get
			{
				return FloroSubInsInfo._parser;
			}
		}

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x06008B84 RID: 35716 RVA: 0x0015314D File Offset: 0x0015134D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x06008B85 RID: 35717 RVA: 0x00153150 File Offset: 0x00151350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroSubInsInfo.Descriptor;
			}
		}

		// Token: 0x06008B86 RID: 35718 RVA: 0x00153157 File Offset: 0x00151357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroSubInsInfo()
		{
		}

		// Token: 0x06008B87 RID: 35719 RVA: 0x00153160 File Offset: 0x00151360
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

		// Token: 0x06008B88 RID: 35720 RVA: 0x001531B4 File Offset: 0x001513B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroSubInsInfo Clone()
		{
			return new FloroSubInsInfo(this);
		}

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x06008B89 RID: 35721 RVA: 0x001531BC File Offset: 0x001513BC
		// (set) Token: 0x06008B8A RID: 35722 RVA: 0x001531C4 File Offset: 0x001513C4
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

		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x06008B8B RID: 35723 RVA: 0x001531CD File Offset: 0x001513CD
		// (set) Token: 0x06008B8C RID: 35724 RVA: 0x001531D5 File Offset: 0x001513D5
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

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x06008B8D RID: 35725 RVA: 0x001531DE File Offset: 0x001513DE
		// (set) Token: 0x06008B8E RID: 35726 RVA: 0x001531E6 File Offset: 0x001513E6
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

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x06008B8F RID: 35727 RVA: 0x001531EF File Offset: 0x001513EF
		// (set) Token: 0x06008B90 RID: 35728 RVA: 0x001531F7 File Offset: 0x001513F7
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

		// Token: 0x06008B91 RID: 35729 RVA: 0x00153200 File Offset: 0x00151400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroSubInsInfo);
		}

		// Token: 0x06008B92 RID: 35730 RVA: 0x00153210 File Offset: 0x00151410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroSubInsInfo other)
		{
			return other != null && (other == this || (this.Key == other.Key && this.UnLockCondition == other.UnLockCondition && this.UnLock == other.UnLock && this.Pass == other.Pass && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B93 RID: 35731 RVA: 0x0015327C File Offset: 0x0015147C
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

		// Token: 0x06008B94 RID: 35732 RVA: 0x00153306 File Offset: 0x00151506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008B95 RID: 35733 RVA: 0x00153313 File Offset: 0x00151513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B96 RID: 35734 RVA: 0x0015331C File Offset: 0x0015151C
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

		// Token: 0x06008B97 RID: 35735 RVA: 0x001533AC File Offset: 0x001515AC
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

		// Token: 0x06008B98 RID: 35736 RVA: 0x0015341C File Offset: 0x0015161C
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

		// Token: 0x06008B99 RID: 35737 RVA: 0x00153494 File Offset: 0x00151694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B9A RID: 35738 RVA: 0x001534A0 File Offset: 0x001516A0
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

		// Token: 0x040044D9 RID: 17625
		private static readonly MessageParser<FloroSubInsInfo> _parser = new MessageParser<FloroSubInsInfo>(() => new FloroSubInsInfo());

		// Token: 0x040044DA RID: 17626
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044DB RID: 17627
		public const int KeyFieldNumber = 1;

		// Token: 0x040044DC RID: 17628
		private int key_;

		// Token: 0x040044DD RID: 17629
		public const int UnLockConditionFieldNumber = 2;

		// Token: 0x040044DE RID: 17630
		private int unLockCondition_;

		// Token: 0x040044DF RID: 17631
		public const int UnLockFieldNumber = 3;

		// Token: 0x040044E0 RID: 17632
		private bool unLock_;

		// Token: 0x040044E1 RID: 17633
		public const int PassFieldNumber = 4;

		// Token: 0x040044E2 RID: 17634
		private bool pass_;
	}
}
