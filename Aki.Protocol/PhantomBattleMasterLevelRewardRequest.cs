using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C88 RID: 3208
	[NetMessage(EMessageId.PhantomBattleMasterLevelRewardRequest)]
	public sealed class PhantomBattleMasterLevelRewardRequest : IMessage<PhantomBattleMasterLevelRewardRequest>, IMessage, IEquatable<PhantomBattleMasterLevelRewardRequest>, IDeepCloneable<PhantomBattleMasterLevelRewardRequest>, IBufferMessage
	{
		// Token: 0x0601169A RID: 71322 RVA: 0x0028DB83 File Offset: 0x0028BD83
		[NullableContext(1)]
		public static PhantomBattleMasterLevelRewardRequest Create()
		{
			return new PhantomBattleMasterLevelRewardRequest();
		}

		// Token: 0x170039AD RID: 14765
		// (get) Token: 0x0601169B RID: 71323 RVA: 0x0028DB8A File Offset: 0x0028BD8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039AE RID: 14766
		// (get) Token: 0x0601169C RID: 71324 RVA: 0x0028DB8D File Offset: 0x0028BD8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleMasterLevelRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601169D RID: 71325 RVA: 0x0028DB94 File Offset: 0x0028BD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterLevelRewardRequest()
		{
		}

		// Token: 0x0601169E RID: 71326 RVA: 0x0028DB9C File Offset: 0x0028BD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterLevelRewardRequest(PhantomBattleMasterLevelRewardRequest other) : this()
		{
			this.phantomBattleMasterLevelId_ = other.phantomBattleMasterLevelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601169F RID: 71327 RVA: 0x0028DBC1 File Offset: 0x0028BDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterLevelRewardRequest Clone()
		{
			return new PhantomBattleMasterLevelRewardRequest(this);
		}

		// Token: 0x170039AF RID: 14767
		// (get) Token: 0x060116A0 RID: 71328 RVA: 0x0028DBC9 File Offset: 0x0028BDC9
		// (set) Token: 0x060116A1 RID: 71329 RVA: 0x0028DBD1 File Offset: 0x0028BDD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomBattleMasterLevelId
		{
			get
			{
				return this.phantomBattleMasterLevelId_;
			}
			set
			{
				this.phantomBattleMasterLevelId_ = value;
			}
		}

		// Token: 0x060116A2 RID: 71330 RVA: 0x0028DBDA File Offset: 0x0028BDDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleMasterLevelRewardRequest);
		}

		// Token: 0x060116A3 RID: 71331 RVA: 0x0028DBE8 File Offset: 0x0028BDE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleMasterLevelRewardRequest other)
		{
			return other != null && (other == this || (this.PhantomBattleMasterLevelId == other.PhantomBattleMasterLevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060116A4 RID: 71332 RVA: 0x0028DC18 File Offset: 0x0028BE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomBattleMasterLevelId != 0)
			{
				num ^= this.PhantomBattleMasterLevelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060116A5 RID: 71333 RVA: 0x0028DC57 File Offset: 0x0028BE57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060116A6 RID: 71334 RVA: 0x0028DC64 File Offset: 0x0028BE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060116A7 RID: 71335 RVA: 0x0028DC6D File Offset: 0x0028BE6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomBattleMasterLevelId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PhantomBattleMasterLevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060116A8 RID: 71336 RVA: 0x0028DCA0 File Offset: 0x0028BEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomBattleMasterLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleMasterLevelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060116A9 RID: 71337 RVA: 0x0028DCDE File Offset: 0x0028BEDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleMasterLevelRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomBattleMasterLevelId != 0)
			{
				this.PhantomBattleMasterLevelId = other.PhantomBattleMasterLevelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060116AA RID: 71338 RVA: 0x0028DD0F File Offset: 0x0028BF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060116AB RID: 71339 RVA: 0x0028DD18 File Offset: 0x0028BF18
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PhantomBattleMasterLevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006E5B RID: 28251
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E5C RID: 28252
		public const int PhantomBattleMasterLevelIdFieldNumber = 8;

		// Token: 0x04006E5D RID: 28253
		private int phantomBattleMasterLevelId_;
	}
}
