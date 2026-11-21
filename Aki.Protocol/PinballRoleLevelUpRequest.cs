using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D49 RID: 3401
	[NetMessage(EMessageId.PinballRoleLevelUpRequest)]
	public sealed class PinballRoleLevelUpRequest : IMessage<PinballRoleLevelUpRequest>, IMessage, IEquatable<PinballRoleLevelUpRequest>, IDeepCloneable<PinballRoleLevelUpRequest>, IBufferMessage
	{
		// Token: 0x060125F8 RID: 75256 RVA: 0x002AF0E7 File Offset: 0x002AD2E7
		[NullableContext(1)]
		public static PinballRoleLevelUpRequest Create()
		{
			return new PinballRoleLevelUpRequest();
		}

		// Token: 0x17003CEA RID: 15594
		// (get) Token: 0x060125F9 RID: 75257 RVA: 0x002AF0EE File Offset: 0x002AD2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CEB RID: 15595
		// (get) Token: 0x060125FA RID: 75258 RVA: 0x002AF0F1 File Offset: 0x002AD2F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballRoleLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x060125FB RID: 75259 RVA: 0x002AF0F8 File Offset: 0x002AD2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleLevelUpRequest()
		{
		}

		// Token: 0x060125FC RID: 75260 RVA: 0x002AF100 File Offset: 0x002AD300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleLevelUpRequest(PinballRoleLevelUpRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.addLv_ = other.addLv_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060125FD RID: 75261 RVA: 0x002AF131 File Offset: 0x002AD331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleLevelUpRequest Clone()
		{
			return new PinballRoleLevelUpRequest(this);
		}

		// Token: 0x17003CEC RID: 15596
		// (get) Token: 0x060125FE RID: 75262 RVA: 0x002AF139 File Offset: 0x002AD339
		// (set) Token: 0x060125FF RID: 75263 RVA: 0x002AF141 File Offset: 0x002AD341
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

		// Token: 0x17003CED RID: 15597
		// (get) Token: 0x06012600 RID: 75264 RVA: 0x002AF14A File Offset: 0x002AD34A
		// (set) Token: 0x06012601 RID: 75265 RVA: 0x002AF152 File Offset: 0x002AD352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AddLv
		{
			get
			{
				return this.addLv_;
			}
			set
			{
				this.addLv_ = value;
			}
		}

		// Token: 0x06012602 RID: 75266 RVA: 0x002AF15B File Offset: 0x002AD35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballRoleLevelUpRequest);
		}

		// Token: 0x06012603 RID: 75267 RVA: 0x002AF169 File Offset: 0x002AD369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballRoleLevelUpRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.AddLv == other.AddLv && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012604 RID: 75268 RVA: 0x002AF1A8 File Offset: 0x002AD3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.AddLv != 0)
			{
				num ^= this.AddLv.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012605 RID: 75269 RVA: 0x002AF200 File Offset: 0x002AD400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012606 RID: 75270 RVA: 0x002AF20D File Offset: 0x002AD40D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012607 RID: 75271 RVA: 0x002AF218 File Offset: 0x002AD418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.AddLv != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.AddLv);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012608 RID: 75272 RVA: 0x002AF270 File Offset: 0x002AD470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.AddLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AddLv);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012609 RID: 75273 RVA: 0x002AF2C8 File Offset: 0x002AD4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballRoleLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.AddLv != 0)
			{
				this.AddLv = other.AddLv;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601260A RID: 75274 RVA: 0x002AF318 File Offset: 0x002AD518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601260B RID: 75275 RVA: 0x002AF324 File Offset: 0x002AD524
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AddLv = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040072DD RID: 29405
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072DE RID: 29406
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040072DF RID: 29407
		private int roleId_;

		// Token: 0x040072E0 RID: 29408
		public const int AddLvFieldNumber = 15;

		// Token: 0x040072E1 RID: 29409
		private int addLv_;
	}
}
