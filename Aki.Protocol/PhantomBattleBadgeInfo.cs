using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C2F RID: 3119
	public sealed class PhantomBattleBadgeInfo : IMessage<PhantomBattleBadgeInfo>, IMessage, IEquatable<PhantomBattleBadgeInfo>, IDeepCloneable<PhantomBattleBadgeInfo>, IBufferMessage
	{
		// Token: 0x06010EB8 RID: 69304 RVA: 0x0027A52F File Offset: 0x0027872F
		[NullableContext(1)]
		public static PhantomBattleBadgeInfo Create()
		{
			return new PhantomBattleBadgeInfo();
		}

		// Token: 0x170037E0 RID: 14304
		// (get) Token: 0x06010EB9 RID: 69305 RVA: 0x0027A536 File Offset: 0x00278736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleBadgeInfo> Parser
		{
			get
			{
				return PhantomBattleBadgeInfo._parser;
			}
		}

		// Token: 0x170037E1 RID: 14305
		// (get) Token: 0x06010EBA RID: 69306 RVA: 0x0027A53D File Offset: 0x0027873D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037E2 RID: 14306
		// (get) Token: 0x06010EBB RID: 69307 RVA: 0x0027A540 File Offset: 0x00278740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBadgeInfo.Descriptor;
			}
		}

		// Token: 0x06010EBC RID: 69308 RVA: 0x0027A547 File Offset: 0x00278747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeInfo()
		{
		}

		// Token: 0x06010EBD RID: 69309 RVA: 0x0027A54F File Offset: 0x0027874F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeInfo(PhantomBattleBadgeInfo other) : this()
		{
			this.phantomBattleBadgeId_ = other.phantomBattleBadgeId_;
			this.isUnlock_ = other.isUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010EBE RID: 69310 RVA: 0x0027A580 File Offset: 0x00278780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeInfo Clone()
		{
			return new PhantomBattleBadgeInfo(this);
		}

		// Token: 0x170037E3 RID: 14307
		// (get) Token: 0x06010EBF RID: 69311 RVA: 0x0027A588 File Offset: 0x00278788
		// (set) Token: 0x06010EC0 RID: 69312 RVA: 0x0027A590 File Offset: 0x00278790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomBattleBadgeId
		{
			get
			{
				return this.phantomBattleBadgeId_;
			}
			set
			{
				this.phantomBattleBadgeId_ = value;
			}
		}

		// Token: 0x170037E4 RID: 14308
		// (get) Token: 0x06010EC1 RID: 69313 RVA: 0x0027A599 File Offset: 0x00278799
		// (set) Token: 0x06010EC2 RID: 69314 RVA: 0x0027A5A1 File Offset: 0x002787A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x06010EC3 RID: 69315 RVA: 0x0027A5AA File Offset: 0x002787AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBadgeInfo);
		}

		// Token: 0x06010EC4 RID: 69316 RVA: 0x0027A5B8 File Offset: 0x002787B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBadgeInfo other)
		{
			return other != null && (other == this || (this.PhantomBattleBadgeId == other.PhantomBattleBadgeId && this.IsUnlock == other.IsUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010EC5 RID: 69317 RVA: 0x0027A5F8 File Offset: 0x002787F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomBattleBadgeId != 0)
			{
				num ^= this.PhantomBattleBadgeId.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010EC6 RID: 69318 RVA: 0x0027A650 File Offset: 0x00278850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010EC7 RID: 69319 RVA: 0x0027A65D File Offset: 0x0027885D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010EC8 RID: 69320 RVA: 0x0027A668 File Offset: 0x00278868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomBattleBadgeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PhantomBattleBadgeId);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010EC9 RID: 69321 RVA: 0x0027A6C0 File Offset: 0x002788C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomBattleBadgeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleBadgeId);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010ECA RID: 69322 RVA: 0x0027A70C File Offset: 0x0027890C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBadgeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomBattleBadgeId != 0)
			{
				this.PhantomBattleBadgeId = other.PhantomBattleBadgeId;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010ECB RID: 69323 RVA: 0x0027A75C File Offset: 0x0027895C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010ECC RID: 69324 RVA: 0x0027A768 File Offset: 0x00278968
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
						this.IsUnlock = input.ReadBool();
					}
				}
				else
				{
					this.PhantomBattleBadgeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006B59 RID: 27481
		private static readonly MessageParser<PhantomBattleBadgeInfo> _parser = new MessageParser<PhantomBattleBadgeInfo>(() => new PhantomBattleBadgeInfo());

		// Token: 0x04006B5A RID: 27482
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B5B RID: 27483
		public const int PhantomBattleBadgeIdFieldNumber = 1;

		// Token: 0x04006B5C RID: 27484
		private int phantomBattleBadgeId_;

		// Token: 0x04006B5D RID: 27485
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x04006B5E RID: 27486
		private bool isUnlock_;
	}
}
