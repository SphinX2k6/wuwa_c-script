using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E3 RID: 4835
	public sealed class SurvivorsRoleLv : IMessage<SurvivorsRoleLv>, IMessage, IEquatable<SurvivorsRoleLv>, IDeepCloneable<SurvivorsRoleLv>, IBufferMessage
	{
		// Token: 0x06019B74 RID: 105332 RVA: 0x003BCE2E File Offset: 0x003BB02E
		[NullableContext(1)]
		public static SurvivorsRoleLv Create()
		{
			return new SurvivorsRoleLv();
		}

		// Token: 0x170056BF RID: 22207
		// (get) Token: 0x06019B75 RID: 105333 RVA: 0x003BCE35 File Offset: 0x003BB035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056C0 RID: 22208
		// (get) Token: 0x06019B76 RID: 105334 RVA: 0x003BCE38 File Offset: 0x003BB038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsRoleLv.Descriptor;
			}
		}

		// Token: 0x06019B77 RID: 105335 RVA: 0x003BCE3F File Offset: 0x003BB03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleLv()
		{
		}

		// Token: 0x06019B78 RID: 105336 RVA: 0x003BCE48 File Offset: 0x003BB048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleLv(SurvivorsRoleLv other) : this()
		{
			this.roleId_ = other.roleId_;
			this.survivorsRole_ = ((other.survivorsRole_ != null) ? other.survivorsRole_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019B79 RID: 105337 RVA: 0x003BCE94 File Offset: 0x003BB094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleLv Clone()
		{
			return new SurvivorsRoleLv(this);
		}

		// Token: 0x170056C1 RID: 22209
		// (get) Token: 0x06019B7A RID: 105338 RVA: 0x003BCE9C File Offset: 0x003BB09C
		// (set) Token: 0x06019B7B RID: 105339 RVA: 0x003BCEA4 File Offset: 0x003BB0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x170056C2 RID: 22210
		// (get) Token: 0x06019B7C RID: 105340 RVA: 0x003BCEAD File Offset: 0x003BB0AD
		// (set) Token: 0x06019B7D RID: 105341 RVA: 0x003BCEB5 File Offset: 0x003BB0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRole SurvivorsRole
		{
			get
			{
				return this.survivorsRole_;
			}
			set
			{
				this.survivorsRole_ = value;
			}
		}

		// Token: 0x06019B7E RID: 105342 RVA: 0x003BCEBE File Offset: 0x003BB0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsRoleLv);
		}

		// Token: 0x06019B7F RID: 105343 RVA: 0x003BCECC File Offset: 0x003BB0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsRoleLv other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this.SurvivorsRole, other.SurvivorsRole) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019B80 RID: 105344 RVA: 0x003BCF1C File Offset: 0x003BB11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.survivorsRole_ != null)
			{
				num ^= this.SurvivorsRole.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019B81 RID: 105345 RVA: 0x003BCF71 File Offset: 0x003BB171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019B82 RID: 105346 RVA: 0x003BCF7E File Offset: 0x003BB17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019B83 RID: 105347 RVA: 0x003BCF88 File Offset: 0x003BB188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.survivorsRole_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SurvivorsRole);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019B84 RID: 105348 RVA: 0x003BCFE0 File Offset: 0x003BB1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.survivorsRole_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsRole);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019B85 RID: 105349 RVA: 0x003BD038 File Offset: 0x003BB238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsRoleLv other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.survivorsRole_ != null)
			{
				if (this.survivorsRole_ == null)
				{
					this.SurvivorsRole = new SurvivorsRole();
				}
				this.SurvivorsRole.MergeFrom(other.SurvivorsRole);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019B86 RID: 105350 RVA: 0x003BD0A0 File Offset: 0x003BB2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019B87 RID: 105351 RVA: 0x003BD0AC File Offset: 0x003BB2AC
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.survivorsRole_ == null)
						{
							this.SurvivorsRole = new SurvivorsRole();
						}
						input.ReadMessage(this.SurvivorsRole);
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040096A9 RID: 38569
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096AA RID: 38570
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040096AB RID: 38571
		private int roleId_;

		// Token: 0x040096AC RID: 38572
		public const int SurvivorsRoleFieldNumber = 2;

		// Token: 0x040096AD RID: 38573
		private SurvivorsRole survivorsRole_;
	}
}
