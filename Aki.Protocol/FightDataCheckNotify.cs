using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000524 RID: 1316
	[NetMessage(EMessageId.FightDataCheckNotify)]
	public sealed class FightDataCheckNotify : IMessage<FightDataCheckNotify>, IMessage, IEquatable<FightDataCheckNotify>, IDeepCloneable<FightDataCheckNotify>, IBufferMessage
	{
		// Token: 0x06007BD9 RID: 31705 RVA: 0x0012CC3E File Offset: 0x0012AE3E
		[NullableContext(1)]
		public static FightDataCheckNotify Create()
		{
			return new FightDataCheckNotify();
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06007BDA RID: 31706 RVA: 0x0012CC45 File Offset: 0x0012AE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06007BDB RID: 31707 RVA: 0x0012CC48 File Offset: 0x0012AE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightDataCheckNotify.Descriptor;
			}
		}

		// Token: 0x06007BDC RID: 31708 RVA: 0x0012CC4F File Offset: 0x0012AE4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightDataCheckNotify()
		{
		}

		// Token: 0x06007BDD RID: 31709 RVA: 0x0012CC57 File Offset: 0x0012AE57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightDataCheckNotify(FightDataCheckNotify other) : this()
		{
			this.result_ = other.result_;
			this.changeList_ = other.changeList_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007BDE RID: 31710 RVA: 0x0012CC88 File Offset: 0x0012AE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightDataCheckNotify Clone()
		{
			return new FightDataCheckNotify(this);
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x06007BDF RID: 31711 RVA: 0x0012CC90 File Offset: 0x0012AE90
		// (set) Token: 0x06007BE0 RID: 31712 RVA: 0x0012CC98 File Offset: 0x0012AE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x06007BE1 RID: 31713 RVA: 0x0012CCA1 File Offset: 0x0012AEA1
		// (set) Token: 0x06007BE2 RID: 31714 RVA: 0x0012CCA9 File Offset: 0x0012AEA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChangeList
		{
			get
			{
				return this.changeList_;
			}
			set
			{
				this.changeList_ = value;
			}
		}

		// Token: 0x06007BE3 RID: 31715 RVA: 0x0012CCB2 File Offset: 0x0012AEB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightDataCheckNotify);
		}

		// Token: 0x06007BE4 RID: 31716 RVA: 0x0012CCC0 File Offset: 0x0012AEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightDataCheckNotify other)
		{
			return other != null && (other == this || (this.Result == other.Result && this.ChangeList == other.ChangeList && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007BE5 RID: 31717 RVA: 0x0012CD00 File Offset: 0x0012AF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Result)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this.ChangeList != 0)
			{
				num ^= this.ChangeList.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007BE6 RID: 31718 RVA: 0x0012CD58 File Offset: 0x0012AF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007BE7 RID: 31719 RVA: 0x0012CD65 File Offset: 0x0012AF65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007BE8 RID: 31720 RVA: 0x0012CD70 File Offset: 0x0012AF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChangeList != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ChangeList);
			}
			if (this.Result)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007BE9 RID: 31721 RVA: 0x0012CDCC File Offset: 0x0012AFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Result)
			{
				num += 2;
			}
			if (this.ChangeList != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChangeList);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007BEA RID: 31722 RVA: 0x0012CE18 File Offset: 0x0012B018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightDataCheckNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Result)
			{
				this.Result = other.Result;
			}
			if (other.ChangeList != 0)
			{
				this.ChangeList = other.ChangeList;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007BEB RID: 31723 RVA: 0x0012CE68 File Offset: 0x0012B068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007BEC RID: 31724 RVA: 0x0012CE74 File Offset: 0x0012B074
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
				if (num != 40U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Result = input.ReadBool();
					}
				}
				else
				{
					this.ChangeList = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003FB6 RID: 16310
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FB7 RID: 16311
		public const int ResultFieldNumber = 7;

		// Token: 0x04003FB8 RID: 16312
		private bool result_;

		// Token: 0x04003FB9 RID: 16313
		public const int ChangeListFieldNumber = 5;

		// Token: 0x04003FBA RID: 16314
		private int changeList_;
	}
}
