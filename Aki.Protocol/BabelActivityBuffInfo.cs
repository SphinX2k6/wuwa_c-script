using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200013C RID: 316
	public sealed class BabelActivityBuffInfo : IMessage<BabelActivityBuffInfo>, IMessage, IEquatable<BabelActivityBuffInfo>, IDeepCloneable<BabelActivityBuffInfo>, IBufferMessage
	{
		// Token: 0x06002927 RID: 10535 RVA: 0x0006C199 File Offset: 0x0006A399
		[NullableContext(1)]
		public static BabelActivityBuffInfo Create()
		{
			return new BabelActivityBuffInfo();
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06002928 RID: 10536 RVA: 0x0006C1A0 File Offset: 0x0006A3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BabelActivityBuffInfo> Parser
		{
			get
			{
				return BabelActivityBuffInfo._parser;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x0006C1A7 File Offset: 0x0006A3A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x0600292A RID: 10538 RVA: 0x0006C1AA File Offset: 0x0006A3AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityBuffInfo.Descriptor;
			}
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x0006C1B1 File Offset: 0x0006A3B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityBuffInfo()
		{
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x0006C1B9 File Offset: 0x0006A3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityBuffInfo(BabelActivityBuffInfo other) : this()
		{
			this.babelBuffId_ = other.babelBuffId_;
			this.difficultUnlock_ = other.difficultUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x0006C1EA File Offset: 0x0006A3EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityBuffInfo Clone()
		{
			return new BabelActivityBuffInfo(this);
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x0600292E RID: 10542 RVA: 0x0006C1F2 File Offset: 0x0006A3F2
		// (set) Token: 0x0600292F RID: 10543 RVA: 0x0006C1FA File Offset: 0x0006A3FA
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

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x0006C203 File Offset: 0x0006A403
		// (set) Token: 0x06002931 RID: 10545 RVA: 0x0006C20B File Offset: 0x0006A40B
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

		// Token: 0x06002932 RID: 10546 RVA: 0x0006C214 File Offset: 0x0006A414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityBuffInfo);
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x0006C222 File Offset: 0x0006A422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityBuffInfo other)
		{
			return other != null && (other == this || (this.BabelBuffId == other.BabelBuffId && this.DifficultUnlock == other.DifficultUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x0006C260 File Offset: 0x0006A460
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

		// Token: 0x06002935 RID: 10549 RVA: 0x0006C2B8 File Offset: 0x0006A4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x0006C2C5 File Offset: 0x0006A4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x0006C2D0 File Offset: 0x0006A4D0
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

		// Token: 0x06002938 RID: 10552 RVA: 0x0006C328 File Offset: 0x0006A528
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

		// Token: 0x06002939 RID: 10553 RVA: 0x0006C374 File Offset: 0x0006A574
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

		// Token: 0x0600293A RID: 10554 RVA: 0x0006C3C4 File Offset: 0x0006A5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x0006C3D0 File Offset: 0x0006A5D0
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

		// Token: 0x040026DC RID: 9948
		private static readonly MessageParser<BabelActivityBuffInfo> _parser = new MessageParser<BabelActivityBuffInfo>(() => new BabelActivityBuffInfo());

		// Token: 0x040026DD RID: 9949
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026DE RID: 9950
		public const int BabelBuffIdFieldNumber = 1;

		// Token: 0x040026DF RID: 9951
		private int babelBuffId_;

		// Token: 0x040026E0 RID: 9952
		public const int DifficultUnlockFieldNumber = 2;

		// Token: 0x040026E1 RID: 9953
		private bool difficultUnlock_;
	}
}
