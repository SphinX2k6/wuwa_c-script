using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C41 RID: 3137
	public sealed class PhantomBattleCardInfo : IMessage<PhantomBattleCardInfo>, IMessage, IEquatable<PhantomBattleCardInfo>, IDeepCloneable<PhantomBattleCardInfo>, IBufferMessage
	{
		// Token: 0x06011094 RID: 69780 RVA: 0x0027F4C2 File Offset: 0x0027D6C2
		[NullableContext(1)]
		public static PhantomBattleCardInfo Create()
		{
			return new PhantomBattleCardInfo();
		}

		// Token: 0x1700384F RID: 14415
		// (get) Token: 0x06011095 RID: 69781 RVA: 0x0027F4C9 File Offset: 0x0027D6C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleCardInfo> Parser
		{
			get
			{
				return PhantomBattleCardInfo._parser;
			}
		}

		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x06011096 RID: 69782 RVA: 0x0027F4D0 File Offset: 0x0027D6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x06011097 RID: 69783 RVA: 0x0027F4D3 File Offset: 0x0027D6D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardInfo.Descriptor;
			}
		}

		// Token: 0x06011098 RID: 69784 RVA: 0x0027F4DA File Offset: 0x0027D6DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardInfo()
		{
		}

		// Token: 0x06011099 RID: 69785 RVA: 0x0027F4E2 File Offset: 0x0027D6E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardInfo(PhantomBattleCardInfo other) : this()
		{
			this.phantomBattleCardId_ = other.phantomBattleCardId_;
			this.isUnlock_ = other.isUnlock_;
			this.isUnlockOutLook_ = other.isUnlockOutLook_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601109A RID: 69786 RVA: 0x0027F51F File Offset: 0x0027D71F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardInfo Clone()
		{
			return new PhantomBattleCardInfo(this);
		}

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x0601109B RID: 69787 RVA: 0x0027F527 File Offset: 0x0027D727
		// (set) Token: 0x0601109C RID: 69788 RVA: 0x0027F52F File Offset: 0x0027D72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomBattleCardId
		{
			get
			{
				return this.phantomBattleCardId_;
			}
			set
			{
				this.phantomBattleCardId_ = value;
			}
		}

		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x0601109D RID: 69789 RVA: 0x0027F538 File Offset: 0x0027D738
		// (set) Token: 0x0601109E RID: 69790 RVA: 0x0027F540 File Offset: 0x0027D740
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

		// Token: 0x17003854 RID: 14420
		// (get) Token: 0x0601109F RID: 69791 RVA: 0x0027F549 File Offset: 0x0027D749
		// (set) Token: 0x060110A0 RID: 69792 RVA: 0x0027F551 File Offset: 0x0027D751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlockOutLook
		{
			get
			{
				return this.isUnlockOutLook_;
			}
			set
			{
				this.isUnlockOutLook_ = value;
			}
		}

		// Token: 0x060110A1 RID: 69793 RVA: 0x0027F55A File Offset: 0x0027D75A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardInfo);
		}

		// Token: 0x060110A2 RID: 69794 RVA: 0x0027F568 File Offset: 0x0027D768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardInfo other)
		{
			return other != null && (other == this || (this.PhantomBattleCardId == other.PhantomBattleCardId && this.IsUnlock == other.IsUnlock && this.IsUnlockOutLook == other.IsUnlockOutLook && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060110A3 RID: 69795 RVA: 0x0027F5C4 File Offset: 0x0027D7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomBattleCardId != 0)
			{
				num ^= this.PhantomBattleCardId.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.IsUnlockOutLook)
			{
				num ^= this.IsUnlockOutLook.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060110A4 RID: 69796 RVA: 0x0027F635 File Offset: 0x0027D835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060110A5 RID: 69797 RVA: 0x0027F642 File Offset: 0x0027D842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060110A6 RID: 69798 RVA: 0x0027F64C File Offset: 0x0027D84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomBattleCardId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PhantomBattleCardId);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlock);
			}
			if (this.IsUnlockOutLook)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsUnlockOutLook);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060110A7 RID: 69799 RVA: 0x0027F6C0 File Offset: 0x0027D8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomBattleCardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleCardId);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.IsUnlockOutLook)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060110A8 RID: 69800 RVA: 0x0027F718 File Offset: 0x0027D918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomBattleCardId != 0)
			{
				this.PhantomBattleCardId = other.PhantomBattleCardId;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.IsUnlockOutLook)
			{
				this.IsUnlockOutLook = other.IsUnlockOutLook;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060110A9 RID: 69801 RVA: 0x0027F77C File Offset: 0x0027D97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060110AA RID: 69802 RVA: 0x0027F788 File Offset: 0x0027D988
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
							this.IsUnlockOutLook = input.ReadBool();
						}
					}
					else
					{
						this.IsUnlock = input.ReadBool();
					}
				}
				else
				{
					this.PhantomBattleCardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006C67 RID: 27751
		private static readonly MessageParser<PhantomBattleCardInfo> _parser = new MessageParser<PhantomBattleCardInfo>(() => new PhantomBattleCardInfo());

		// Token: 0x04006C68 RID: 27752
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C69 RID: 27753
		public const int PhantomBattleCardIdFieldNumber = 1;

		// Token: 0x04006C6A RID: 27754
		private int phantomBattleCardId_;

		// Token: 0x04006C6B RID: 27755
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x04006C6C RID: 27756
		private bool isUnlock_;

		// Token: 0x04006C6D RID: 27757
		public const int IsUnlockOutLookFieldNumber = 3;

		// Token: 0x04006C6E RID: 27758
		private bool isUnlockOutLook_;
	}
}
