using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D2 RID: 1234
	public sealed class EntrustRoleInfo : IMessage<EntrustRoleInfo>, IMessage, IEquatable<EntrustRoleInfo>, IDeepCloneable<EntrustRoleInfo>, IBufferMessage
	{
		// Token: 0x06007534 RID: 30004 RVA: 0x0011F08A File Offset: 0x0011D28A
		[NullableContext(1)]
		public static EntrustRoleInfo Create()
		{
			return new EntrustRoleInfo();
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x06007535 RID: 30005 RVA: 0x0011F091 File Offset: 0x0011D291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntrustRoleInfo> Parser
		{
			get
			{
				return EntrustRoleInfo._parser;
			}
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x06007536 RID: 30006 RVA: 0x0011F098 File Offset: 0x0011D298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x06007537 RID: 30007 RVA: 0x0011F09B File Offset: 0x0011D29B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntrustRoleInfo.Descriptor;
			}
		}

		// Token: 0x06007538 RID: 30008 RVA: 0x0011F0A2 File Offset: 0x0011D2A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntrustRoleInfo()
		{
		}

		// Token: 0x06007539 RID: 30009 RVA: 0x0011F0AC File Offset: 0x0011D2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntrustRoleInfo(EntrustRoleInfo other) : this()
		{
			this.level_ = other.level_;
			this.roleAttr_ = ((other.roleAttr_ != null) ? other.roleAttr_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600753A RID: 30010 RVA: 0x0011F0F8 File Offset: 0x0011D2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntrustRoleInfo Clone()
		{
			return new EntrustRoleInfo(this);
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x0600753B RID: 30011 RVA: 0x0011F100 File Offset: 0x0011D300
		// (set) Token: 0x0600753C RID: 30012 RVA: 0x0011F108 File Offset: 0x0011D308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x0600753D RID: 30013 RVA: 0x0011F111 File Offset: 0x0011D311
		// (set) Token: 0x0600753E RID: 30014 RVA: 0x0011F119 File Offset: 0x0011D319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleProperSettle RoleAttr
		{
			get
			{
				return this.roleAttr_;
			}
			set
			{
				this.roleAttr_ = value;
			}
		}

		// Token: 0x0600753F RID: 30015 RVA: 0x0011F122 File Offset: 0x0011D322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntrustRoleInfo);
		}

		// Token: 0x06007540 RID: 30016 RVA: 0x0011F130 File Offset: 0x0011D330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntrustRoleInfo other)
		{
			return other != null && (other == this || (this.Level == other.Level && object.Equals(this.RoleAttr, other.RoleAttr) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007541 RID: 30017 RVA: 0x0011F180 File Offset: 0x0011D380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.roleAttr_ != null)
			{
				num ^= this.RoleAttr.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007542 RID: 30018 RVA: 0x0011F1D5 File Offset: 0x0011D3D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007543 RID: 30019 RVA: 0x0011F1E2 File Offset: 0x0011D3E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007544 RID: 30020 RVA: 0x0011F1EC File Offset: 0x0011D3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Level);
			}
			if (this.roleAttr_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RoleAttr);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007545 RID: 30021 RVA: 0x0011F244 File Offset: 0x0011D444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.roleAttr_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleAttr);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007546 RID: 30022 RVA: 0x0011F29C File Offset: 0x0011D49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntrustRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.roleAttr_ != null)
			{
				if (this.roleAttr_ == null)
				{
					this.RoleAttr = new RoleProperSettle();
				}
				this.RoleAttr.MergeFrom(other.RoleAttr);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007547 RID: 30023 RVA: 0x0011F304 File Offset: 0x0011D504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007548 RID: 30024 RVA: 0x0011F310 File Offset: 0x0011D510
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
						if (this.roleAttr_ == null)
						{
							this.RoleAttr = new RoleProperSettle();
						}
						input.ReadMessage(this.RoleAttr);
					}
				}
				else
				{
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003DA2 RID: 15778
		private static readonly MessageParser<EntrustRoleInfo> _parser = new MessageParser<EntrustRoleInfo>(() => new EntrustRoleInfo());

		// Token: 0x04003DA3 RID: 15779
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DA4 RID: 15780
		public const int LevelFieldNumber = 1;

		// Token: 0x04003DA5 RID: 15781
		private int level_;

		// Token: 0x04003DA6 RID: 15782
		public const int RoleAttrFieldNumber = 2;

		// Token: 0x04003DA7 RID: 15783
		private RoleProperSettle roleAttr_;
	}
}
