using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C1F RID: 3103
	public sealed class PhantomBattleBadgeInfo : IMessage<PhantomBattleBadgeInfo>, IMessage, IEquatable<PhantomBattleBadgeInfo>, IDeepCloneable<PhantomBattleBadgeInfo>, IBufferMessage
	{
		// Token: 0x06010DB8 RID: 69048 RVA: 0x002787CB File Offset: 0x002769CB
		[NullableContext(1)]
		public static PhantomBattleBadgeInfo Create()
		{
			return new PhantomBattleBadgeInfo();
		}

		// Token: 0x170037A9 RID: 14249
		// (get) Token: 0x06010DB9 RID: 69049 RVA: 0x002787D2 File Offset: 0x002769D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleBadgeInfo> Parser
		{
			get
			{
				return PhantomBattleBadgeInfo._parser;
			}
		}

		// Token: 0x170037AA RID: 14250
		// (get) Token: 0x06010DBA RID: 69050 RVA: 0x002787D9 File Offset: 0x002769D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037AB RID: 14251
		// (get) Token: 0x06010DBB RID: 69051 RVA: 0x002787DC File Offset: 0x002769DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBadgeInfo.Descriptor;
			}
		}

		// Token: 0x06010DBC RID: 69052 RVA: 0x002787E3 File Offset: 0x002769E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeInfo()
		{
		}

		// Token: 0x06010DBD RID: 69053 RVA: 0x002787EB File Offset: 0x002769EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeInfo(PhantomBattleBadgeInfo other) : this()
		{
			this.phantomBattleBadgeId_ = other.phantomBattleBadgeId_;
			this.isUnlock_ = other.isUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010DBE RID: 69054 RVA: 0x0027881C File Offset: 0x00276A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeInfo Clone()
		{
			return new PhantomBattleBadgeInfo(this);
		}

		// Token: 0x170037AC RID: 14252
		// (get) Token: 0x06010DBF RID: 69055 RVA: 0x00278824 File Offset: 0x00276A24
		// (set) Token: 0x06010DC0 RID: 69056 RVA: 0x0027882C File Offset: 0x00276A2C
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

		// Token: 0x170037AD RID: 14253
		// (get) Token: 0x06010DC1 RID: 69057 RVA: 0x00278835 File Offset: 0x00276A35
		// (set) Token: 0x06010DC2 RID: 69058 RVA: 0x0027883D File Offset: 0x00276A3D
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

		// Token: 0x06010DC3 RID: 69059 RVA: 0x00278846 File Offset: 0x00276A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBadgeInfo);
		}

		// Token: 0x06010DC4 RID: 69060 RVA: 0x00278854 File Offset: 0x00276A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBadgeInfo other)
		{
			return other != null && (other == this || (this.PhantomBattleBadgeId == other.PhantomBattleBadgeId && this.IsUnlock == other.IsUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010DC5 RID: 69061 RVA: 0x00278894 File Offset: 0x00276A94
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

		// Token: 0x06010DC6 RID: 69062 RVA: 0x002788EC File Offset: 0x00276AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010DC7 RID: 69063 RVA: 0x002788F9 File Offset: 0x00276AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010DC8 RID: 69064 RVA: 0x00278904 File Offset: 0x00276B04
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

		// Token: 0x06010DC9 RID: 69065 RVA: 0x0027895C File Offset: 0x00276B5C
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

		// Token: 0x06010DCA RID: 69066 RVA: 0x002789A8 File Offset: 0x00276BA8
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

		// Token: 0x06010DCB RID: 69067 RVA: 0x002789F8 File Offset: 0x00276BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010DCC RID: 69068 RVA: 0x00278A04 File Offset: 0x00276C04
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

		// Token: 0x04006B6D RID: 27501
		private static readonly MessageParser<PhantomBattleBadgeInfo> _parser = new MessageParser<PhantomBattleBadgeInfo>(() => new PhantomBattleBadgeInfo());

		// Token: 0x04006B6E RID: 27502
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B6F RID: 27503
		public const int PhantomBattleBadgeIdFieldNumber = 1;

		// Token: 0x04006B70 RID: 27504
		private int phantomBattleBadgeId_;

		// Token: 0x04006B71 RID: 27505
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x04006B72 RID: 27506
		private bool isUnlock_;
	}
}
