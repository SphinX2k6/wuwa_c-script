using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA8 RID: 3240
	public sealed class PhantomBattleRoleInfo : IMessage<PhantomBattleRoleInfo>, IMessage, IEquatable<PhantomBattleRoleInfo>, IDeepCloneable<PhantomBattleRoleInfo>, IBufferMessage
	{
		// Token: 0x060118E9 RID: 71913 RVA: 0x0029275A File Offset: 0x0029095A
		[NullableContext(1)]
		public static PhantomBattleRoleInfo Create()
		{
			return new PhantomBattleRoleInfo();
		}

		// Token: 0x17003A2C RID: 14892
		// (get) Token: 0x060118EA RID: 71914 RVA: 0x00292761 File Offset: 0x00290961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleRoleInfo> Parser
		{
			get
			{
				return PhantomBattleRoleInfo._parser;
			}
		}

		// Token: 0x17003A2D RID: 14893
		// (get) Token: 0x060118EB RID: 71915 RVA: 0x00292768 File Offset: 0x00290968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A2E RID: 14894
		// (get) Token: 0x060118EC RID: 71916 RVA: 0x0029276B File Offset: 0x0029096B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRoleInfo.Descriptor;
			}
		}

		// Token: 0x060118ED RID: 71917 RVA: 0x00292772 File Offset: 0x00290972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleInfo()
		{
		}

		// Token: 0x060118EE RID: 71918 RVA: 0x0029277A File Offset: 0x0029097A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleInfo(PhantomBattleRoleInfo other) : this()
		{
			this.phantomBattleRoleId_ = other.phantomBattleRoleId_;
			this.isUnlock_ = other.isUnlock_;
			this.isRewarded_ = other.isRewarded_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060118EF RID: 71919 RVA: 0x002927B7 File Offset: 0x002909B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleInfo Clone()
		{
			return new PhantomBattleRoleInfo(this);
		}

		// Token: 0x17003A2F RID: 14895
		// (get) Token: 0x060118F0 RID: 71920 RVA: 0x002927BF File Offset: 0x002909BF
		// (set) Token: 0x060118F1 RID: 71921 RVA: 0x002927C7 File Offset: 0x002909C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomBattleRoleId
		{
			get
			{
				return this.phantomBattleRoleId_;
			}
			set
			{
				this.phantomBattleRoleId_ = value;
			}
		}

		// Token: 0x17003A30 RID: 14896
		// (get) Token: 0x060118F2 RID: 71922 RVA: 0x002927D0 File Offset: 0x002909D0
		// (set) Token: 0x060118F3 RID: 71923 RVA: 0x002927D8 File Offset: 0x002909D8
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

		// Token: 0x17003A31 RID: 14897
		// (get) Token: 0x060118F4 RID: 71924 RVA: 0x002927E1 File Offset: 0x002909E1
		// (set) Token: 0x060118F5 RID: 71925 RVA: 0x002927E9 File Offset: 0x002909E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRewarded
		{
			get
			{
				return this.isRewarded_;
			}
			set
			{
				this.isRewarded_ = value;
			}
		}

		// Token: 0x060118F6 RID: 71926 RVA: 0x002927F2 File Offset: 0x002909F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRoleInfo);
		}

		// Token: 0x060118F7 RID: 71927 RVA: 0x00292800 File Offset: 0x00290A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRoleInfo other)
		{
			return other != null && (other == this || (this.PhantomBattleRoleId == other.PhantomBattleRoleId && this.IsUnlock == other.IsUnlock && this.IsRewarded == other.IsRewarded && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060118F8 RID: 71928 RVA: 0x0029285C File Offset: 0x00290A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomBattleRoleId != 0)
			{
				num ^= this.PhantomBattleRoleId.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.IsRewarded)
			{
				num ^= this.IsRewarded.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060118F9 RID: 71929 RVA: 0x002928CD File Offset: 0x00290ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060118FA RID: 71930 RVA: 0x002928DA File Offset: 0x00290ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060118FB RID: 71931 RVA: 0x002928E4 File Offset: 0x00290AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomBattleRoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PhantomBattleRoleId);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlock);
			}
			if (this.IsRewarded)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsRewarded);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060118FC RID: 71932 RVA: 0x00292958 File Offset: 0x00290B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomBattleRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleRoleId);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.IsRewarded)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060118FD RID: 71933 RVA: 0x002929B0 File Offset: 0x00290BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomBattleRoleId != 0)
			{
				this.PhantomBattleRoleId = other.PhantomBattleRoleId;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.IsRewarded)
			{
				this.IsRewarded = other.IsRewarded;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060118FE RID: 71934 RVA: 0x00292A14 File Offset: 0x00290C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060118FF RID: 71935 RVA: 0x00292A20 File Offset: 0x00290C20
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
							this.IsRewarded = input.ReadBool();
						}
					}
					else
					{
						this.IsUnlock = input.ReadBool();
					}
				}
				else
				{
					this.PhantomBattleRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006EAE RID: 28334
		private static readonly MessageParser<PhantomBattleRoleInfo> _parser = new MessageParser<PhantomBattleRoleInfo>(() => new PhantomBattleRoleInfo());

		// Token: 0x04006EAF RID: 28335
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EB0 RID: 28336
		public const int PhantomBattleRoleIdFieldNumber = 1;

		// Token: 0x04006EB1 RID: 28337
		private int phantomBattleRoleId_;

		// Token: 0x04006EB2 RID: 28338
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x04006EB3 RID: 28339
		private bool isUnlock_;

		// Token: 0x04006EB4 RID: 28340
		public const int IsRewardedFieldNumber = 3;

		// Token: 0x04006EB5 RID: 28341
		private bool isRewarded_;
	}
}
