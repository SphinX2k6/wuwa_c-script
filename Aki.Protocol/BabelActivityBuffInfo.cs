using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200013F RID: 319
	public sealed class BabelActivityBuffInfo : IMessage<BabelActivityBuffInfo>, IMessage, IEquatable<BabelActivityBuffInfo>, IDeepCloneable<BabelActivityBuffInfo>, IBufferMessage
	{
		// Token: 0x0600299E RID: 10654 RVA: 0x0006D5CD File Offset: 0x0006B7CD
		[NullableContext(1)]
		public static BabelActivityBuffInfo Create()
		{
			return new BabelActivityBuffInfo();
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600299F RID: 10655 RVA: 0x0006D5D4 File Offset: 0x0006B7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BabelActivityBuffInfo> Parser
		{
			get
			{
				return BabelActivityBuffInfo._parser;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x060029A0 RID: 10656 RVA: 0x0006D5DB File Offset: 0x0006B7DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060029A1 RID: 10657 RVA: 0x0006D5DE File Offset: 0x0006B7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityBuffInfo.Descriptor;
			}
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x0006D5E5 File Offset: 0x0006B7E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityBuffInfo()
		{
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x0006D5ED File Offset: 0x0006B7ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityBuffInfo(BabelActivityBuffInfo other) : this()
		{
			this.babelBuffId_ = other.babelBuffId_;
			this.difficultUnlock_ = other.difficultUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x0006D61E File Offset: 0x0006B81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityBuffInfo Clone()
		{
			return new BabelActivityBuffInfo(this);
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060029A5 RID: 10661 RVA: 0x0006D626 File Offset: 0x0006B826
		// (set) Token: 0x060029A6 RID: 10662 RVA: 0x0006D62E File Offset: 0x0006B82E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BabelBuffId
		{
			get
			{
				return this.babelBuffId_;
			}
			set
			{
				this.babelBuffId_ = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060029A7 RID: 10663 RVA: 0x0006D637 File Offset: 0x0006B837
		// (set) Token: 0x060029A8 RID: 10664 RVA: 0x0006D63F File Offset: 0x0006B83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DifficultUnlock
		{
			get
			{
				return this.difficultUnlock_;
			}
			set
			{
				this.difficultUnlock_ = value;
			}
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x0006D648 File Offset: 0x0006B848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityBuffInfo);
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x0006D656 File Offset: 0x0006B856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityBuffInfo other)
		{
			return other != null && (other == this || (this.BabelBuffId == other.BabelBuffId && this.DifficultUnlock == other.DifficultUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x0006D694 File Offset: 0x0006B894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BabelBuffId != 0)
			{
				num ^= this.BabelBuffId.GetHashCode();
			}
			if (this.DifficultUnlock)
			{
				num ^= this.DifficultUnlock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x0006D6EC File Offset: 0x0006B8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x0006D6F9 File Offset: 0x0006B8F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x0006D704 File Offset: 0x0006B904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BabelBuffId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BabelBuffId);
			}
			if (this.DifficultUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.DifficultUnlock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x0006D75C File Offset: 0x0006B95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BabelBuffId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BabelBuffId);
			}
			if (this.DifficultUnlock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x0006D7A8 File Offset: 0x0006B9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivityBuffInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BabelBuffId != 0)
			{
				this.BabelBuffId = other.BabelBuffId;
			}
			if (other.DifficultUnlock)
			{
				this.DifficultUnlock = other.DifficultUnlock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x0006D7F8 File Offset: 0x0006B9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x0006D804 File Offset: 0x0006BA04
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
						this.DifficultUnlock = input.ReadBool();
					}
				}
				else
				{
					this.BabelBuffId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002750 RID: 10064
		private static readonly MessageParser<BabelActivityBuffInfo> _parser = new MessageParser<BabelActivityBuffInfo>(() => new BabelActivityBuffInfo());

		// Token: 0x04002751 RID: 10065
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002752 RID: 10066
		public const int BabelBuffIdFieldNumber = 1;

		// Token: 0x04002753 RID: 10067
		private int babelBuffId_;

		// Token: 0x04002754 RID: 10068
		public const int DifficultUnlockFieldNumber = 2;

		// Token: 0x04002755 RID: 10069
		private bool difficultUnlock_;
	}
}
