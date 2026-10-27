using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CAA RID: 3242
	[NetMessage(EMessageId.PhantomBattleRoleRewardRequest)]
	public sealed class PhantomBattleRoleRewardRequest : IMessage<PhantomBattleRoleRewardRequest>, IMessage, IEquatable<PhantomBattleRoleRewardRequest>, IDeepCloneable<PhantomBattleRoleRewardRequest>, IBufferMessage
	{
		// Token: 0x06011913 RID: 71955 RVA: 0x00292C89 File Offset: 0x00290E89
		[NullableContext(1)]
		public static PhantomBattleRoleRewardRequest Create()
		{
			return new PhantomBattleRoleRewardRequest();
		}

		// Token: 0x17003A35 RID: 14901
		// (get) Token: 0x06011914 RID: 71956 RVA: 0x00292C90 File Offset: 0x00290E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A36 RID: 14902
		// (get) Token: 0x06011915 RID: 71957 RVA: 0x00292C93 File Offset: 0x00290E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRoleRewardRequest.Descriptor;
			}
		}

		// Token: 0x06011916 RID: 71958 RVA: 0x00292C9A File Offset: 0x00290E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleRewardRequest()
		{
		}

		// Token: 0x06011917 RID: 71959 RVA: 0x00292CA2 File Offset: 0x00290EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleRewardRequest(PhantomBattleRoleRewardRequest other) : this()
		{
			this.phantomBattleRoleId_ = other.phantomBattleRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011918 RID: 71960 RVA: 0x00292CC7 File Offset: 0x00290EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleRewardRequest Clone()
		{
			return new PhantomBattleRoleRewardRequest(this);
		}

		// Token: 0x17003A37 RID: 14903
		// (get) Token: 0x06011919 RID: 71961 RVA: 0x00292CCF File Offset: 0x00290ECF
		// (set) Token: 0x0601191A RID: 71962 RVA: 0x00292CD7 File Offset: 0x00290ED7
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

		// Token: 0x0601191B RID: 71963 RVA: 0x00292CE0 File Offset: 0x00290EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRoleRewardRequest);
		}

		// Token: 0x0601191C RID: 71964 RVA: 0x00292CEE File Offset: 0x00290EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRoleRewardRequest other)
		{
			return other != null && (other == this || (this.PhantomBattleRoleId == other.PhantomBattleRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601191D RID: 71965 RVA: 0x00292D1C File Offset: 0x00290F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomBattleRoleId != 0)
			{
				num ^= this.PhantomBattleRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601191E RID: 71966 RVA: 0x00292D5B File Offset: 0x00290F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601191F RID: 71967 RVA: 0x00292D68 File Offset: 0x00290F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011920 RID: 71968 RVA: 0x00292D71 File Offset: 0x00290F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomBattleRoleId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PhantomBattleRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011921 RID: 71969 RVA: 0x00292DA4 File Offset: 0x00290FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomBattleRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011922 RID: 71970 RVA: 0x00292DE2 File Offset: 0x00290FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleRoleRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomBattleRoleId != 0)
			{
				this.PhantomBattleRoleId = other.PhantomBattleRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011923 RID: 71971 RVA: 0x00292E13 File Offset: 0x00291013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011924 RID: 71972 RVA: 0x00292E1C File Offset: 0x0029101C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PhantomBattleRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006EBA RID: 28346
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EBB RID: 28347
		public const int PhantomBattleRoleIdFieldNumber = 13;

		// Token: 0x04006EBC RID: 28348
		private int phantomBattleRoleId_;
	}
}
